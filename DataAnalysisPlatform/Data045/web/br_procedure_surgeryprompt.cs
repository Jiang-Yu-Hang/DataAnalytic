/*
               File: BR_Procedure_SurgeryPrompt
        Description: 选择诊疗处理手术信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:15:4.96
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
   public class br_procedure_surgeryprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_procedure_surgeryprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure_surgeryprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_Procedure_SurgeryID ,
                           ref String aP1_InOutBR_Procedure_Surgery_Name )
      {
         this.AV8InOutBR_Procedure_SurgeryID = aP0_InOutBR_Procedure_SurgeryID;
         this.AV9InOutBR_Procedure_Surgery_Name = aP1_InOutBR_Procedure_Surgery_Name;
         executePrivate();
         aP0_InOutBR_Procedure_SurgeryID=this.AV8InOutBR_Procedure_SurgeryID;
         aP1_InOutBR_Procedure_Surgery_Name=this.AV9InOutBR_Procedure_Surgery_Name;
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
               AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_ProcedureIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = GetNextPar( );
               AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace) ;
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
               AV8InOutBR_Procedure_SurgeryID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Procedure_SurgeryID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutBR_Procedure_Surgery_Name = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Procedure_Surgery_Name", AV9InOutBR_Procedure_Surgery_Name);
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
            PA6C2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV29Pgmname = "BR_Procedure_SurgeryPrompt";
               context.Gx_err = 0;
               WS6C2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE6C2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020228151554", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_procedure_surgeryprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_Procedure_SurgeryID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutBR_Procedure_Surgery_Name))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV23GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV21DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV21DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA", AV13BR_Procedure_SurgeryIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA", AV13BR_Procedure_SurgeryIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDUREIDTITLEFILTERDATA", AV15BR_ProcedureIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDUREIDTITLEFILTERDATA", AV15BR_ProcedureIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA", AV17BR_Procedure_Surgery_NameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA", AV17BR_Procedure_Surgery_NameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA", AV19BR_Procedure_Surgery_LocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA", AV19BR_Procedure_Surgery_LocTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PROCEDURE_SURGERYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_Procedure_SurgeryID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PROCEDURE_SURGERY_NAME", AV9InOutBR_Procedure_Surgery_Name);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Caption", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Tooltip", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Cls", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_surgeryid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_surgeryid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_surgeryid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_surgeryid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Sortasc", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Caption", StringUtil.RTrim( Ddo_br_procedureid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Tooltip", StringUtil.RTrim( Ddo_br_procedureid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Cls", StringUtil.RTrim( Ddo_br_procedureid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedureid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedureid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedureid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedureid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedureid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedureid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedureid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortasc", StringUtil.RTrim( Ddo_br_procedureid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortdsc", StringUtil.RTrim( Ddo_br_procedureid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedureid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Caption", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Tooltip", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Cls", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_surgery_name_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_surgery_name_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_surgery_name_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_surgery_name_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Sortasc", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Caption", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Tooltip", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Cls", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_surgery_loc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_surgery_loc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_surgery_loc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_surgery_loc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Sortasc", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Activeeventkey));
      }

      protected void RenderHtmlCloseForm6C2( )
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
         return "BR_Procedure_SurgeryPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择诊疗处理手术信息" ;
      }

      protected void WB6C0( )
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
               if ( edtBR_Procedure_SurgeryID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_SurgeryID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_SurgeryID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_ProcedureID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_ProcedureID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_ProcedureID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_Surgery_Name_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_Surgery_Name_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_Surgery_Name_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_Surgery_Loc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_Surgery_Loc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_Surgery_Loc_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV26Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A320BR_Procedure_SurgeryID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_SurgeryID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_SurgeryID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_ProcedureID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_ProcedureID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A321BR_Procedure_Surgery_Name);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_Surgery_Name_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_Surgery_Name_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A322BR_Procedure_Surgery_Loc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_Surgery_Loc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_Surgery_Loc_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV23GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV25GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV24GridPageSize);
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
            ucDdo_br_procedure_surgeryid.SetProperty("Caption", Ddo_br_procedure_surgeryid_Caption);
            ucDdo_br_procedure_surgeryid.SetProperty("Tooltip", Ddo_br_procedure_surgeryid_Tooltip);
            ucDdo_br_procedure_surgeryid.SetProperty("Cls", Ddo_br_procedure_surgeryid_Cls);
            ucDdo_br_procedure_surgeryid.SetProperty("DropDownOptionsType", Ddo_br_procedure_surgeryid_Dropdownoptionstype);
            ucDdo_br_procedure_surgeryid.SetProperty("IncludeSortASC", Ddo_br_procedure_surgeryid_Includesortasc);
            ucDdo_br_procedure_surgeryid.SetProperty("IncludeSortDSC", Ddo_br_procedure_surgeryid_Includesortdsc);
            ucDdo_br_procedure_surgeryid.SetProperty("IncludeFilter", Ddo_br_procedure_surgeryid_Includefilter);
            ucDdo_br_procedure_surgeryid.SetProperty("IncludeDataList", Ddo_br_procedure_surgeryid_Includedatalist);
            ucDdo_br_procedure_surgeryid.SetProperty("SortASC", Ddo_br_procedure_surgeryid_Sortasc);
            ucDdo_br_procedure_surgeryid.SetProperty("SortDSC", Ddo_br_procedure_surgeryid_Sortdsc);
            ucDdo_br_procedure_surgeryid.SetProperty("SearchButtonText", Ddo_br_procedure_surgeryid_Searchbuttontext);
            ucDdo_br_procedure_surgeryid.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_br_procedure_surgeryid.SetProperty("DropDownOptionsData", AV13BR_Procedure_SurgeryIDTitleFilterData);
            ucDdo_br_procedure_surgeryid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_surgeryid_Internalname, "DDO_BR_PROCEDURE_SURGERYIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname, AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", 0, edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_SurgeryPrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedureid.SetProperty("Caption", Ddo_br_procedureid_Caption);
            ucDdo_br_procedureid.SetProperty("Tooltip", Ddo_br_procedureid_Tooltip);
            ucDdo_br_procedureid.SetProperty("Cls", Ddo_br_procedureid_Cls);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsType", Ddo_br_procedureid_Dropdownoptionstype);
            ucDdo_br_procedureid.SetProperty("IncludeSortASC", Ddo_br_procedureid_Includesortasc);
            ucDdo_br_procedureid.SetProperty("IncludeSortDSC", Ddo_br_procedureid_Includesortdsc);
            ucDdo_br_procedureid.SetProperty("IncludeFilter", Ddo_br_procedureid_Includefilter);
            ucDdo_br_procedureid.SetProperty("IncludeDataList", Ddo_br_procedureid_Includedatalist);
            ucDdo_br_procedureid.SetProperty("SortASC", Ddo_br_procedureid_Sortasc);
            ucDdo_br_procedureid.SetProperty("SortDSC", Ddo_br_procedureid_Sortdsc);
            ucDdo_br_procedureid.SetProperty("SearchButtonText", Ddo_br_procedureid_Searchbuttontext);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsData", AV15BR_ProcedureIDTitleFilterData);
            ucDdo_br_procedureid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedureid_Internalname, "DDO_BR_PROCEDUREIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", 0, edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_SurgeryPrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedure_surgery_name.SetProperty("Caption", Ddo_br_procedure_surgery_name_Caption);
            ucDdo_br_procedure_surgery_name.SetProperty("Tooltip", Ddo_br_procedure_surgery_name_Tooltip);
            ucDdo_br_procedure_surgery_name.SetProperty("Cls", Ddo_br_procedure_surgery_name_Cls);
            ucDdo_br_procedure_surgery_name.SetProperty("DropDownOptionsType", Ddo_br_procedure_surgery_name_Dropdownoptionstype);
            ucDdo_br_procedure_surgery_name.SetProperty("IncludeSortASC", Ddo_br_procedure_surgery_name_Includesortasc);
            ucDdo_br_procedure_surgery_name.SetProperty("IncludeSortDSC", Ddo_br_procedure_surgery_name_Includesortdsc);
            ucDdo_br_procedure_surgery_name.SetProperty("IncludeFilter", Ddo_br_procedure_surgery_name_Includefilter);
            ucDdo_br_procedure_surgery_name.SetProperty("IncludeDataList", Ddo_br_procedure_surgery_name_Includedatalist);
            ucDdo_br_procedure_surgery_name.SetProperty("SortASC", Ddo_br_procedure_surgery_name_Sortasc);
            ucDdo_br_procedure_surgery_name.SetProperty("SortDSC", Ddo_br_procedure_surgery_name_Sortdsc);
            ucDdo_br_procedure_surgery_name.SetProperty("SearchButtonText", Ddo_br_procedure_surgery_name_Searchbuttontext);
            ucDdo_br_procedure_surgery_name.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_br_procedure_surgery_name.SetProperty("DropDownOptionsData", AV17BR_Procedure_Surgery_NameTitleFilterData);
            ucDdo_br_procedure_surgery_name.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_surgery_name_Internalname, "DDO_BR_PROCEDURE_SURGERY_NAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Internalname, AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", 0, edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_SurgeryPrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedure_surgery_loc.SetProperty("Caption", Ddo_br_procedure_surgery_loc_Caption);
            ucDdo_br_procedure_surgery_loc.SetProperty("Tooltip", Ddo_br_procedure_surgery_loc_Tooltip);
            ucDdo_br_procedure_surgery_loc.SetProperty("Cls", Ddo_br_procedure_surgery_loc_Cls);
            ucDdo_br_procedure_surgery_loc.SetProperty("DropDownOptionsType", Ddo_br_procedure_surgery_loc_Dropdownoptionstype);
            ucDdo_br_procedure_surgery_loc.SetProperty("IncludeSortASC", Ddo_br_procedure_surgery_loc_Includesortasc);
            ucDdo_br_procedure_surgery_loc.SetProperty("IncludeSortDSC", Ddo_br_procedure_surgery_loc_Includesortdsc);
            ucDdo_br_procedure_surgery_loc.SetProperty("IncludeFilter", Ddo_br_procedure_surgery_loc_Includefilter);
            ucDdo_br_procedure_surgery_loc.SetProperty("IncludeDataList", Ddo_br_procedure_surgery_loc_Includedatalist);
            ucDdo_br_procedure_surgery_loc.SetProperty("SortASC", Ddo_br_procedure_surgery_loc_Sortasc);
            ucDdo_br_procedure_surgery_loc.SetProperty("SortDSC", Ddo_br_procedure_surgery_loc_Sortdsc);
            ucDdo_br_procedure_surgery_loc.SetProperty("SearchButtonText", Ddo_br_procedure_surgery_loc_Searchbuttontext);
            ucDdo_br_procedure_surgery_loc.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_br_procedure_surgery_loc.SetProperty("DropDownOptionsData", AV19BR_Procedure_Surgery_LocTitleFilterData);
            ucDdo_br_procedure_surgery_loc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_surgery_loc_Internalname, "DDO_BR_PROCEDURE_SURGERY_LOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Internalname, AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", 0, edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_SurgeryPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_SurgeryPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Procedure_SurgeryPrompt.htm");
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

      protected void START6C2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择诊疗处理手术信息", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP6C0( ) ;
      }

      protected void WS6C2( )
      {
         START6C2( ) ;
         EVT6C2( ) ;
      }

      protected void EVT6C2( )
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
                           E116C2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E126C2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_SURGERYID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E136C2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDUREID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E146C2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_SURGERY_NAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E156C2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_SURGERY_LOC.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E166C2 ();
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
                           AV26Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV26Select)) ? AV30Select_GXI : context.convertURL( context.PathToRelativeUrl( AV26Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV26Select), true);
                           A320BR_Procedure_SurgeryID = (long)(context.localUtil.CToN( cgiGet( edtBR_Procedure_SurgeryID_Internalname), ".", ","));
                           A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ","));
                           A321BR_Procedure_Surgery_Name = cgiGet( edtBR_Procedure_Surgery_Name_Internalname);
                           n321BR_Procedure_Surgery_Name = false;
                           A322BR_Procedure_Surgery_Loc = cgiGet( edtBR_Procedure_Surgery_Loc_Internalname);
                           n322BR_Procedure_Surgery_Loc = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E176C2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E186C2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E196C2 ();
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
                                       E206C2 ();
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

      protected void WE6C2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm6C2( ) ;
            }
         }
      }

      protected void PA6C2( )
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
               GX_FocusControl = edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_ProcedureIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace ,
                                       String AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF6C2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_SURGERYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PROCEDURE_SURGERYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A320BR_Procedure_SurgeryID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_SURGERY_NAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A321BR_Procedure_Surgery_Name, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_PROCEDURE_SURGERY_NAME", A321BR_Procedure_Surgery_Name);
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
         RF6C2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV29Pgmname = "BR_Procedure_SurgeryPrompt";
         context.Gx_err = 0;
      }

      protected void RF6C2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E186C2 ();
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
            /* Using cursor H006C2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A322BR_Procedure_Surgery_Loc = H006C2_A322BR_Procedure_Surgery_Loc[0];
               n322BR_Procedure_Surgery_Loc = H006C2_n322BR_Procedure_Surgery_Loc[0];
               A321BR_Procedure_Surgery_Name = H006C2_A321BR_Procedure_Surgery_Name[0];
               n321BR_Procedure_Surgery_Name = H006C2_n321BR_Procedure_Surgery_Name[0];
               A139BR_ProcedureID = H006C2_A139BR_ProcedureID[0];
               A320BR_Procedure_SurgeryID = H006C2_A320BR_Procedure_SurgeryID[0];
               E196C2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB6C0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes6C2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_SURGERYID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_SURGERY_NAME"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A321BR_Procedure_Surgery_Name, "")), context));
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
         /* Using cursor H006C3 */
         pr_default.execute(1);
         GRID_nRecordCount = H006C3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP6C0( )
      {
         /* Before Start, stand alone formulas. */
         AV29Pgmname = "BR_Procedure_SurgeryPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E176C2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV21DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA"), AV13BR_Procedure_SurgeryIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDUREIDTITLEFILTERDATA"), AV15BR_ProcedureIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA"), AV17BR_Procedure_Surgery_NameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA"), AV19BR_Procedure_Surgery_LocTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace", AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace);
            AV16ddo_BR_ProcedureIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_ProcedureIDTitleControlIdToReplace", AV16ddo_BR_ProcedureIDTitleControlIdToReplace);
            AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace", AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace);
            AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace", AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace);
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
            AV23GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV25GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV24GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_procedure_surgeryid_Caption = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Caption");
            Ddo_br_procedure_surgeryid_Tooltip = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Tooltip");
            Ddo_br_procedure_surgeryid_Cls = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Cls");
            Ddo_br_procedure_surgeryid_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Dropdownoptionstype");
            Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Titlecontrolidtoreplace");
            Ddo_br_procedure_surgeryid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Includesortasc"));
            Ddo_br_procedure_surgeryid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Includesortdsc"));
            Ddo_br_procedure_surgeryid_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Sortedstatus");
            Ddo_br_procedure_surgeryid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Includefilter"));
            Ddo_br_procedure_surgeryid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Includedatalist"));
            Ddo_br_procedure_surgeryid_Sortasc = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Sortasc");
            Ddo_br_procedure_surgeryid_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Sortdsc");
            Ddo_br_procedure_surgeryid_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Searchbuttontext");
            Ddo_br_procedureid_Caption = cgiGet( "DDO_BR_PROCEDUREID_Caption");
            Ddo_br_procedureid_Tooltip = cgiGet( "DDO_BR_PROCEDUREID_Tooltip");
            Ddo_br_procedureid_Cls = cgiGet( "DDO_BR_PROCEDUREID_Cls");
            Ddo_br_procedureid_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDUREID_Dropdownoptionstype");
            Ddo_br_procedureid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDUREID_Titlecontrolidtoreplace");
            Ddo_br_procedureid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includesortasc"));
            Ddo_br_procedureid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includesortdsc"));
            Ddo_br_procedureid_Sortedstatus = cgiGet( "DDO_BR_PROCEDUREID_Sortedstatus");
            Ddo_br_procedureid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includefilter"));
            Ddo_br_procedureid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includedatalist"));
            Ddo_br_procedureid_Sortasc = cgiGet( "DDO_BR_PROCEDUREID_Sortasc");
            Ddo_br_procedureid_Sortdsc = cgiGet( "DDO_BR_PROCEDUREID_Sortdsc");
            Ddo_br_procedureid_Searchbuttontext = cgiGet( "DDO_BR_PROCEDUREID_Searchbuttontext");
            Ddo_br_procedure_surgery_name_Caption = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Caption");
            Ddo_br_procedure_surgery_name_Tooltip = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Tooltip");
            Ddo_br_procedure_surgery_name_Cls = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Cls");
            Ddo_br_procedure_surgery_name_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Dropdownoptionstype");
            Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Titlecontrolidtoreplace");
            Ddo_br_procedure_surgery_name_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Includesortasc"));
            Ddo_br_procedure_surgery_name_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Includesortdsc"));
            Ddo_br_procedure_surgery_name_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Sortedstatus");
            Ddo_br_procedure_surgery_name_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Includefilter"));
            Ddo_br_procedure_surgery_name_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Includedatalist"));
            Ddo_br_procedure_surgery_name_Sortasc = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Sortasc");
            Ddo_br_procedure_surgery_name_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Sortdsc");
            Ddo_br_procedure_surgery_name_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Searchbuttontext");
            Ddo_br_procedure_surgery_loc_Caption = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Caption");
            Ddo_br_procedure_surgery_loc_Tooltip = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Tooltip");
            Ddo_br_procedure_surgery_loc_Cls = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Cls");
            Ddo_br_procedure_surgery_loc_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Dropdownoptionstype");
            Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Titlecontrolidtoreplace");
            Ddo_br_procedure_surgery_loc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Includesortasc"));
            Ddo_br_procedure_surgery_loc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Includesortdsc"));
            Ddo_br_procedure_surgery_loc_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Sortedstatus");
            Ddo_br_procedure_surgery_loc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Includefilter"));
            Ddo_br_procedure_surgery_loc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Includedatalist"));
            Ddo_br_procedure_surgery_loc_Sortasc = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Sortasc");
            Ddo_br_procedure_surgery_loc_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Sortdsc");
            Ddo_br_procedure_surgery_loc_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_procedure_surgeryid_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Activeeventkey");
            Ddo_br_procedureid_Activeeventkey = cgiGet( "DDO_BR_PROCEDUREID_Activeeventkey");
            Ddo_br_procedure_surgery_name_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Activeeventkey");
            Ddo_br_procedure_surgery_loc_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Activeeventkey");
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
         E176C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E176C2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Surgery", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV29Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_SurgeryID";
         ucDdo_br_procedure_surgeryid.SendProperty(context, "", false, Ddo_br_procedure_surgeryid_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace);
         AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace", AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace);
         edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedureid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_ProcedureID";
         ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "TitleControlIdToReplace", Ddo_br_procedureid_Titlecontrolidtoreplace);
         AV16ddo_BR_ProcedureIDTitleControlIdToReplace = Ddo_br_procedureid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_ProcedureIDTitleControlIdToReplace", AV16ddo_BR_ProcedureIDTitleControlIdToReplace);
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_Surgery_Name";
         ucDdo_br_procedure_surgery_name.SendProperty(context, "", false, Ddo_br_procedure_surgery_name_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace);
         AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace", AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace);
         edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_Surgery_Loc";
         ucDdo_br_procedure_surgery_loc.SendProperty(context, "", false, Ddo_br_procedure_surgery_loc_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace);
         AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace", AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace);
         edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择诊疗处理手术信息";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV21DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV21DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E186C2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_Procedure_SurgeryIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Procedure_Surgery_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Procedure_Surgery_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_Procedure_SurgeryID_Titleformat = 2;
         edtBR_Procedure_SurgeryID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "主键", AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_SurgeryID_Internalname, "Title", edtBR_Procedure_SurgeryID_Title, !bGXsfl_12_Refreshing);
         edtBR_ProcedureID_Titleformat = 2;
         edtBR_ProcedureID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊疗处理主键", AV16ddo_BR_ProcedureIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Title", edtBR_ProcedureID_Title, !bGXsfl_12_Refreshing);
         edtBR_Procedure_Surgery_Name_Titleformat = 2;
         edtBR_Procedure_Surgery_Name_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "手术名称", AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Surgery_Name_Internalname, "Title", edtBR_Procedure_Surgery_Name_Title, !bGXsfl_12_Refreshing);
         edtBR_Procedure_Surgery_Loc_Titleformat = 2;
         edtBR_Procedure_Surgery_Loc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "手术部位", AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Surgery_Loc_Internalname, "Title", edtBR_Procedure_Surgery_Loc_Title, !bGXsfl_12_Refreshing);
         AV23GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23GridCurrentPage), 10, 0)));
         AV24GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GridPageSize), 10, 0)));
         AV25GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Procedure_SurgeryIDTitleFilterData", AV13BR_Procedure_SurgeryIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_ProcedureIDTitleFilterData", AV15BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Procedure_Surgery_NameTitleFilterData", AV17BR_Procedure_Surgery_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Procedure_Surgery_LocTitleFilterData", AV19BR_Procedure_Surgery_LocTitleFilterData);
      }

      protected void E116C2( )
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
            AV22PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV22PageToGo) ;
         }
      }

      protected void E126C2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E136C2( )
      {
         /* Ddo_br_procedure_surgeryid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_surgeryid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_surgeryid_Sortedstatus = "ASC";
            ucDdo_br_procedure_surgeryid.SendProperty(context, "", false, Ddo_br_procedure_surgeryid_Internalname, "SortedStatus", Ddo_br_procedure_surgeryid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_surgeryid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_surgeryid_Sortedstatus = "DSC";
            ucDdo_br_procedure_surgeryid.SendProperty(context, "", false, Ddo_br_procedure_surgeryid_Internalname, "SortedStatus", Ddo_br_procedure_surgeryid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Procedure_SurgeryIDTitleFilterData", AV13BR_Procedure_SurgeryIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_ProcedureIDTitleFilterData", AV15BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Procedure_Surgery_NameTitleFilterData", AV17BR_Procedure_Surgery_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Procedure_Surgery_LocTitleFilterData", AV19BR_Procedure_Surgery_LocTitleFilterData);
      }

      protected void E146C2( )
      {
         /* Ddo_br_procedureid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedureid_Sortedstatus = "ASC";
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedureid_Sortedstatus = "DSC";
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Procedure_SurgeryIDTitleFilterData", AV13BR_Procedure_SurgeryIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_ProcedureIDTitleFilterData", AV15BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Procedure_Surgery_NameTitleFilterData", AV17BR_Procedure_Surgery_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Procedure_Surgery_LocTitleFilterData", AV19BR_Procedure_Surgery_LocTitleFilterData);
      }

      protected void E156C2( )
      {
         /* Ddo_br_procedure_surgery_name_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_surgery_name_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_surgery_name_Sortedstatus = "ASC";
            ucDdo_br_procedure_surgery_name.SendProperty(context, "", false, Ddo_br_procedure_surgery_name_Internalname, "SortedStatus", Ddo_br_procedure_surgery_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_surgery_name_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_surgery_name_Sortedstatus = "DSC";
            ucDdo_br_procedure_surgery_name.SendProperty(context, "", false, Ddo_br_procedure_surgery_name_Internalname, "SortedStatus", Ddo_br_procedure_surgery_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Procedure_SurgeryIDTitleFilterData", AV13BR_Procedure_SurgeryIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_ProcedureIDTitleFilterData", AV15BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Procedure_Surgery_NameTitleFilterData", AV17BR_Procedure_Surgery_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Procedure_Surgery_LocTitleFilterData", AV19BR_Procedure_Surgery_LocTitleFilterData);
      }

      protected void E166C2( )
      {
         /* Ddo_br_procedure_surgery_loc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_surgery_loc_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_surgery_loc_Sortedstatus = "ASC";
            ucDdo_br_procedure_surgery_loc.SendProperty(context, "", false, Ddo_br_procedure_surgery_loc_Internalname, "SortedStatus", Ddo_br_procedure_surgery_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_surgery_loc_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_surgery_loc_Sortedstatus = "DSC";
            ucDdo_br_procedure_surgery_loc.SendProperty(context, "", false, Ddo_br_procedure_surgery_loc_Internalname, "SortedStatus", Ddo_br_procedure_surgery_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Procedure_SurgeryIDTitleFilterData", AV13BR_Procedure_SurgeryIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_ProcedureIDTitleFilterData", AV15BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Procedure_Surgery_NameTitleFilterData", AV17BR_Procedure_Surgery_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Procedure_Surgery_LocTitleFilterData", AV19BR_Procedure_Surgery_LocTitleFilterData);
      }

      private void E196C2( )
      {
         /* Grid_Load Routine */
         AV26Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV26Select);
         AV30Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E206C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E206C2( )
      {
         /* Enter Routine */
         AV8InOutBR_Procedure_SurgeryID = A320BR_Procedure_SurgeryID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Procedure_SurgeryID), 18, 0)));
         AV9InOutBR_Procedure_Surgery_Name = A321BR_Procedure_Surgery_Name;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Procedure_Surgery_Name", AV9InOutBR_Procedure_Surgery_Name);
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_Procedure_SurgeryID,(String)AV9InOutBR_Procedure_Surgery_Name});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_Procedure_SurgeryID","AV9InOutBR_Procedure_Surgery_Name"});
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
         AV8InOutBR_Procedure_SurgeryID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Procedure_SurgeryID), 18, 0)));
         AV9InOutBR_Procedure_Surgery_Name = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Procedure_Surgery_Name", AV9InOutBR_Procedure_Surgery_Name);
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
         PA6C2( ) ;
         WS6C2( ) ;
         WE6C2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815151232", true);
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
         context.AddJavascriptSource("br_procedure_surgeryprompt.js", "?202022815151232", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
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
         edtBR_Procedure_SurgeryID_Internalname = "BR_PROCEDURE_SURGERYID_"+sGXsfl_12_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_12_idx;
         edtBR_Procedure_Surgery_Name_Internalname = "BR_PROCEDURE_SURGERY_NAME_"+sGXsfl_12_idx;
         edtBR_Procedure_Surgery_Loc_Internalname = "BR_PROCEDURE_SURGERY_LOC_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_Procedure_SurgeryID_Internalname = "BR_PROCEDURE_SURGERYID_"+sGXsfl_12_fel_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_12_fel_idx;
         edtBR_Procedure_Surgery_Name_Internalname = "BR_PROCEDURE_SURGERY_NAME_"+sGXsfl_12_fel_idx;
         edtBR_Procedure_Surgery_Loc_Internalname = "BR_PROCEDURE_SURGERY_LOC_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB6C0( ) ;
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
            AV26Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV26Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV30Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV26Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV26Select)) ? AV30Select_GXI : context.PathToRelativeUrl( AV26Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV26Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_SurgeryID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A320BR_Procedure_SurgeryID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_SurgeryID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_ProcedureID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_ProcedureID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_Surgery_Name_Internalname,(String)A321BR_Procedure_Surgery_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_Surgery_Name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_Surgery_Loc_Internalname,(String)A322BR_Procedure_Surgery_Loc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_Surgery_Loc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes6C2( ) ;
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
         edtBR_Procedure_SurgeryID_Internalname = "BR_PROCEDURE_SURGERYID";
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID";
         edtBR_Procedure_Surgery_Name_Internalname = "BR_PROCEDURE_SURGERY_NAME";
         edtBR_Procedure_Surgery_Loc_Internalname = "BR_PROCEDURE_SURGERY_LOC";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_procedure_surgeryid_Internalname = "DDO_BR_PROCEDURE_SURGERYID";
         edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedureid_Internalname = "DDO_BR_PROCEDUREID";
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_surgery_name_Internalname = "DDO_BR_PROCEDURE_SURGERY_NAME";
         edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_surgery_loc_Internalname = "DDO_BR_PROCEDURE_SURGERY_LOC";
         edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE";
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
         edtBR_Procedure_Surgery_Loc_Jsonclick = "";
         edtBR_Procedure_Surgery_Name_Jsonclick = "";
         edtBR_ProcedureID_Jsonclick = "";
         edtBR_Procedure_SurgeryID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Procedure_Surgery_Loc_Titleformat = 0;
         edtBR_Procedure_Surgery_Loc_Title = "手术部位";
         edtBR_Procedure_Surgery_Name_Titleformat = 0;
         edtBR_Procedure_Surgery_Name_Title = "手术名称";
         edtBR_ProcedureID_Titleformat = 0;
         edtBR_ProcedureID_Title = "诊疗处理主键";
         edtBR_Procedure_SurgeryID_Titleformat = 0;
         edtBR_Procedure_SurgeryID_Title = "主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_procedure_surgery_loc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_surgery_loc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_surgery_loc_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_surgery_loc_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_surgery_loc_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_surgery_loc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_loc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_surgery_loc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_surgery_loc_Cls = "ColumnSettings";
         Ddo_br_procedure_surgery_loc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_surgery_loc_Caption = "";
         Ddo_br_procedure_surgery_name_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_surgery_name_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_surgery_name_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_surgery_name_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_surgery_name_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_surgery_name_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_name_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_surgery_name_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_surgery_name_Cls = "ColumnSettings";
         Ddo_br_procedure_surgery_name_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_surgery_name_Caption = "";
         Ddo_br_procedureid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedureid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedureid_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedureid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedureid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedureid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Titlecontrolidtoreplace = "";
         Ddo_br_procedureid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedureid_Cls = "ColumnSettings";
         Ddo_br_procedureid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedureid_Caption = "";
         Ddo_br_procedure_surgeryid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_surgeryid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_surgeryid_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_surgeryid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_surgeryid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_surgeryid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgeryid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_surgeryid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_surgeryid_Cls = "ColumnSettings";
         Ddo_br_procedure_surgeryid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_surgeryid_Caption = "";
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
         Form.Caption = "选择诊疗处理手术信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV19BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_SurgeryID_Titleformat',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat'},{av:'edtBR_Procedure_SurgeryID_Title',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Surgery_Name_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Name_Title',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{av:'edtBR_Procedure_Surgery_Loc_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Loc_Title',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E116C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E126C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERYID.ONOPTIONCLICKED","{handler:'E136C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_surgeryid_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERYID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_surgeryid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'SortedStatus'},{av:'AV13BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV19BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_SurgeryID_Titleformat',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat'},{av:'edtBR_Procedure_SurgeryID_Title',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Surgery_Name_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Name_Title',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{av:'edtBR_Procedure_Surgery_Loc_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Loc_Title',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED","{handler:'E146C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedureid_Activeeventkey',ctrl:'DDO_BR_PROCEDUREID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'AV13BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV19BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_SurgeryID_Titleformat',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat'},{av:'edtBR_Procedure_SurgeryID_Title',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Surgery_Name_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Name_Title',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{av:'edtBR_Procedure_Surgery_Loc_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Loc_Title',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERY_NAME.ONOPTIONCLICKED","{handler:'E156C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_surgery_name_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERY_NAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_surgery_name_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SortedStatus'},{av:'AV13BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV19BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_SurgeryID_Titleformat',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat'},{av:'edtBR_Procedure_SurgeryID_Title',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Surgery_Name_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Name_Title',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{av:'edtBR_Procedure_Surgery_Loc_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Loc_Title',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERY_LOC.ONOPTIONCLICKED","{handler:'E166C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_surgery_loc_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERY_LOC.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_surgery_loc_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SortedStatus'},{av:'AV13BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV19BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_SurgeryID_Titleformat',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat'},{av:'edtBR_Procedure_SurgeryID_Title',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Surgery_Name_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Name_Title',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{av:'edtBR_Procedure_Surgery_Loc_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Loc_Title',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E196C2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV26Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E206C2',iparms:[{av:'A320BR_Procedure_SurgeryID',fld:'BR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A321BR_Procedure_Surgery_Name',fld:'BR_PROCEDURE_SURGERY_NAME',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_Procedure_SurgeryID',fld:'vINOUTBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutBR_Procedure_Surgery_Name',fld:'vINOUTBR_PROCEDURE_SURGERY_NAME',pic:''}]}");
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
         wcpOAV9InOutBR_Procedure_Surgery_Name = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_procedure_surgeryid_Activeeventkey = "";
         Ddo_br_procedureid_Activeeventkey = "";
         Ddo_br_procedure_surgery_name_Activeeventkey = "";
         Ddo_br_procedure_surgery_loc_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = "";
         AV16ddo_BR_ProcedureIDTitleControlIdToReplace = "";
         AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = "";
         AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = "";
         GXKey = "";
         AV29Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV21DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_Procedure_SurgeryIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Procedure_Surgery_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Procedure_Surgery_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_procedure_surgeryid_Sortedstatus = "";
         Ddo_br_procedureid_Sortedstatus = "";
         Ddo_br_procedure_surgery_name_Sortedstatus = "";
         Ddo_br_procedure_surgery_loc_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV26Select = "";
         A321BR_Procedure_Surgery_Name = "";
         A322BR_Procedure_Surgery_Loc = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_procedure_surgeryid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_procedureid = new GXUserControl();
         ucDdo_br_procedure_surgery_name = new GXUserControl();
         ucDdo_br_procedure_surgery_loc = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV30Select_GXI = "";
         scmdbuf = "";
         H006C2_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         H006C2_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         H006C2_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         H006C2_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         H006C2_A139BR_ProcedureID = new long[1] ;
         H006C2_A320BR_Procedure_SurgeryID = new long[1] ;
         H006C3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_surgeryprompt__default(),
            new Object[][] {
                new Object[] {
               H006C2_A322BR_Procedure_Surgery_Loc, H006C2_n322BR_Procedure_Surgery_Loc, H006C2_A321BR_Procedure_Surgery_Name, H006C2_n321BR_Procedure_Surgery_Name, H006C2_A139BR_ProcedureID, H006C2_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               H006C3_AGRID_nRecordCount
               }
            }
         );
         AV29Pgmname = "BR_Procedure_SurgeryPrompt";
         /* GeneXus formulas. */
         AV29Pgmname = "BR_Procedure_SurgeryPrompt";
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
      private short edtBR_Procedure_SurgeryID_Titleformat ;
      private short edtBR_ProcedureID_Titleformat ;
      private short edtBR_Procedure_Surgery_Name_Titleformat ;
      private short edtBR_Procedure_Surgery_Loc_Titleformat ;
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
      private int edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV22PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_Procedure_SurgeryID ;
      private long wcpOAV8InOutBR_Procedure_SurgeryID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV23GridCurrentPage ;
      private long AV25GridRecordCount ;
      private long AV24GridPageSize ;
      private long A320BR_Procedure_SurgeryID ;
      private long A139BR_ProcedureID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_procedure_surgeryid_Activeeventkey ;
      private String Ddo_br_procedureid_Activeeventkey ;
      private String Ddo_br_procedure_surgery_name_Activeeventkey ;
      private String Ddo_br_procedure_surgery_loc_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV29Pgmname ;
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
      private String Ddo_br_procedure_surgeryid_Caption ;
      private String Ddo_br_procedure_surgeryid_Tooltip ;
      private String Ddo_br_procedure_surgeryid_Cls ;
      private String Ddo_br_procedure_surgeryid_Dropdownoptionstype ;
      private String Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_surgeryid_Sortedstatus ;
      private String Ddo_br_procedure_surgeryid_Sortasc ;
      private String Ddo_br_procedure_surgeryid_Sortdsc ;
      private String Ddo_br_procedure_surgeryid_Searchbuttontext ;
      private String Ddo_br_procedureid_Caption ;
      private String Ddo_br_procedureid_Tooltip ;
      private String Ddo_br_procedureid_Cls ;
      private String Ddo_br_procedureid_Dropdownoptionstype ;
      private String Ddo_br_procedureid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedureid_Sortedstatus ;
      private String Ddo_br_procedureid_Sortasc ;
      private String Ddo_br_procedureid_Sortdsc ;
      private String Ddo_br_procedureid_Searchbuttontext ;
      private String Ddo_br_procedure_surgery_name_Caption ;
      private String Ddo_br_procedure_surgery_name_Tooltip ;
      private String Ddo_br_procedure_surgery_name_Cls ;
      private String Ddo_br_procedure_surgery_name_Dropdownoptionstype ;
      private String Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_surgery_name_Sortedstatus ;
      private String Ddo_br_procedure_surgery_name_Sortasc ;
      private String Ddo_br_procedure_surgery_name_Sortdsc ;
      private String Ddo_br_procedure_surgery_name_Searchbuttontext ;
      private String Ddo_br_procedure_surgery_loc_Caption ;
      private String Ddo_br_procedure_surgery_loc_Tooltip ;
      private String Ddo_br_procedure_surgery_loc_Cls ;
      private String Ddo_br_procedure_surgery_loc_Dropdownoptionstype ;
      private String Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_surgery_loc_Sortedstatus ;
      private String Ddo_br_procedure_surgery_loc_Sortasc ;
      private String Ddo_br_procedure_surgery_loc_Sortdsc ;
      private String Ddo_br_procedure_surgery_loc_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Procedure_SurgeryID_Title ;
      private String edtBR_ProcedureID_Title ;
      private String edtBR_Procedure_Surgery_Name_Title ;
      private String edtBR_Procedure_Surgery_Loc_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_procedure_surgeryid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedureid_Internalname ;
      private String edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_surgery_name_Internalname ;
      private String edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_surgery_loc_Internalname ;
      private String edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_Procedure_SurgeryID_Internalname ;
      private String edtBR_ProcedureID_Internalname ;
      private String edtBR_Procedure_Surgery_Name_Internalname ;
      private String edtBR_Procedure_Surgery_Loc_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Procedure_SurgeryID_Jsonclick ;
      private String edtBR_ProcedureID_Jsonclick ;
      private String edtBR_Procedure_Surgery_Name_Jsonclick ;
      private String edtBR_Procedure_Surgery_Loc_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_procedure_surgeryid_Includesortasc ;
      private bool Ddo_br_procedure_surgeryid_Includesortdsc ;
      private bool Ddo_br_procedure_surgeryid_Includefilter ;
      private bool Ddo_br_procedure_surgeryid_Includedatalist ;
      private bool Ddo_br_procedureid_Includesortasc ;
      private bool Ddo_br_procedureid_Includesortdsc ;
      private bool Ddo_br_procedureid_Includefilter ;
      private bool Ddo_br_procedureid_Includedatalist ;
      private bool Ddo_br_procedure_surgery_name_Includesortasc ;
      private bool Ddo_br_procedure_surgery_name_Includesortdsc ;
      private bool Ddo_br_procedure_surgery_name_Includefilter ;
      private bool Ddo_br_procedure_surgery_name_Includedatalist ;
      private bool Ddo_br_procedure_surgery_loc_Includesortasc ;
      private bool Ddo_br_procedure_surgery_loc_Includesortdsc ;
      private bool Ddo_br_procedure_surgery_loc_Includefilter ;
      private bool Ddo_br_procedure_surgery_loc_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n321BR_Procedure_Surgery_Name ;
      private bool n322BR_Procedure_Surgery_Loc ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV26Select_IsBlob ;
      private String AV9InOutBR_Procedure_Surgery_Name ;
      private String wcpOAV9InOutBR_Procedure_Surgery_Name ;
      private String AV14ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace ;
      private String AV16ddo_BR_ProcedureIDTitleControlIdToReplace ;
      private String AV18ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace ;
      private String AV20ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace ;
      private String A321BR_Procedure_Surgery_Name ;
      private String A322BR_Procedure_Surgery_Loc ;
      private String AV30Select_GXI ;
      private String AV26Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_procedure_surgeryid ;
      private GXUserControl ucDdo_br_procedureid ;
      private GXUserControl ucDdo_br_procedure_surgery_name ;
      private GXUserControl ucDdo_br_procedure_surgery_loc ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_Procedure_SurgeryID ;
      private String aP1_InOutBR_Procedure_Surgery_Name ;
      private IDataStoreProvider pr_default ;
      private String[] H006C2_A322BR_Procedure_Surgery_Loc ;
      private bool[] H006C2_n322BR_Procedure_Surgery_Loc ;
      private String[] H006C2_A321BR_Procedure_Surgery_Name ;
      private bool[] H006C2_n321BR_Procedure_Surgery_Name ;
      private long[] H006C2_A139BR_ProcedureID ;
      private long[] H006C2_A320BR_Procedure_SurgeryID ;
      private long[] H006C3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_Procedure_SurgeryIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_ProcedureIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Procedure_Surgery_NameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_Procedure_Surgery_LocTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV21DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_procedure_surgeryprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H006C2( IGxContext context ,
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
         sSelectString = " [BR_Procedure_Surgery_Loc], [BR_Procedure_Surgery_Name], [BR_ProcedureID], [BR_Procedure_SurgeryID]";
         sFromString = " FROM [BR_Procedure_Surgery] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_SurgeryID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_SurgeryID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_ProcedureID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_ProcedureID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Surgery_Name]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Surgery_Name] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Surgery_Loc]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Surgery_Loc] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_SurgeryID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H006C3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Procedure_Surgery] WITH (NOLOCK)";
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
                     return conditional_H006C2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H006C3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH006C2 ;
          prmH006C2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH006C3 ;
          prmH006C3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H006C2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006C2,11,0,true,false )
             ,new CursorDef("H006C3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006C3,1,0,true,false )
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
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
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
