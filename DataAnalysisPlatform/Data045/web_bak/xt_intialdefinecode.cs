/*
               File: XT_IntialDefineCode
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:47:16.81
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
   public class xt_intialdefinecode : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public xt_intialdefinecode( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_intialdefinecode( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_InOutBAS_TenantTenantCode )
      {
         this.AV8InOutBAS_TenantTenantCode = aP0_InOutBAS_TenantTenantCode;
         executePrivate();
         aP0_InOutBAS_TenantTenantCode=this.AV8InOutBAS_TenantTenantCode;
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
               nRC_GXsfl_15 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_15_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_15_idx = GetNextPar( );
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
               AV44TFBAS_TenantTenantCode = GetNextPar( );
               AV45TFBAS_TenantTenantCode_Sel = GetNextPar( );
               AV16ddo_TenantNameTitleControlIdToReplace = GetNextPar( );
               AV20ddo_HospitalNameTitleControlIdToReplace = GetNextPar( );
               AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace = GetNextPar( );
               AV49Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV44TFBAS_TenantTenantCode, AV45TFBAS_TenantTenantCode_Sel, AV16ddo_TenantNameTitleControlIdToReplace, AV20ddo_HospitalNameTitleControlIdToReplace, AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace, AV49Pgmname) ;
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
               AV8InOutBAS_TenantTenantCode = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBAS_TenantTenantCode", AV8InOutBAS_TenantTenantCode);
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
         PA872( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START872( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279471693", false);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_intialdefinecode.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8InOutBAS_TenantTenantCode))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBAS_TENANTTENANTCODE", AV44TFBAS_TenantTenantCode);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBAS_TENANTTENANTCODE_SEL", AV45TFBAS_TenantTenantCode_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_15", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_15), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV37GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV39GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV35DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV35DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTENANTNAMETITLEFILTERDATA", AV15TenantNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTENANTNAMETITLEFILTERDATA", AV15TenantNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vHOSPITALNAMETITLEFILTERDATA", AV19HospitalNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vHOSPITALNAMETITLEFILTERDATA", AV19HospitalNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBAS_TENANTTENANTCODETITLEFILTERDATA", AV13BAS_TenantTenantCodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBAS_TENANTTENANTCODETITLEFILTERDATA", AV13BAS_TenantTenantCodeTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV49Pgmname));
         GxWebStd.gx_hidden_field( context, "vTTENANTCODE", AV46tTenantCode);
         GxWebStd.gx_hidden_field( context, "vINOUTBAS_TENANTTENANTCODE", AV8InOutBAS_TenantTenantCode);
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
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Caption", StringUtil.RTrim( Ddo_tenantname_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Tooltip", StringUtil.RTrim( Ddo_tenantname_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Cls", StringUtil.RTrim( Ddo_tenantname_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_tenantname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_tenantname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Includesortasc", StringUtil.BoolToStr( Ddo_tenantname_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_tenantname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Sortedstatus", StringUtil.RTrim( Ddo_tenantname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Includefilter", StringUtil.BoolToStr( Ddo_tenantname_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Includedatalist", StringUtil.BoolToStr( Ddo_tenantname_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Sortasc", StringUtil.RTrim( Ddo_tenantname_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Sortdsc", StringUtil.RTrim( Ddo_tenantname_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Searchbuttontext", StringUtil.RTrim( Ddo_tenantname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Caption", StringUtil.RTrim( Ddo_hospitalname_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Tooltip", StringUtil.RTrim( Ddo_hospitalname_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Cls", StringUtil.RTrim( Ddo_hospitalname_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_hospitalname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_hospitalname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Includesortasc", StringUtil.BoolToStr( Ddo_hospitalname_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_hospitalname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Sortedstatus", StringUtil.RTrim( Ddo_hospitalname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Includefilter", StringUtil.BoolToStr( Ddo_hospitalname_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Includedatalist", StringUtil.BoolToStr( Ddo_hospitalname_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Sortasc", StringUtil.RTrim( Ddo_hospitalname_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Sortdsc", StringUtil.RTrim( Ddo_hospitalname_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Searchbuttontext", StringUtil.RTrim( Ddo_hospitalname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Caption", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Tooltip", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Cls", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Includesortasc", StringUtil.BoolToStr( Ddo_bas_tenanttenantcode_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Includesortdsc", StringUtil.BoolToStr( Ddo_bas_tenanttenantcode_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Sortedstatus", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Includefilter", StringUtil.BoolToStr( Ddo_bas_tenanttenantcode_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Filtertype", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Filterisrange", StringUtil.BoolToStr( Ddo_bas_tenanttenantcode_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Includedatalist", StringUtil.BoolToStr( Ddo_bas_tenanttenantcode_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Datalisttype", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Datalistproc", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_bas_tenanttenantcode_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Sortasc", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Sortdsc", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Loadingdata", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Cleanfilter", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Noresultsfound", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Searchbuttontext", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_MINSAVE_Title", StringUtil.RTrim( Dvelop_confirmpanel_minsave_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_MINSAVE_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_minsave_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_MINSAVE_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_minsave_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_MINSAVE_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_minsave_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_MINSAVE_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_minsave_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_MINSAVE_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_minsave_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_MINSAVE_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_minsave_Confirmtype));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Activeeventkey", StringUtil.RTrim( Ddo_tenantname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Activeeventkey", StringUtil.RTrim( Ddo_hospitalname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Activeeventkey", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Filteredtext_get", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Selectedvalue_get", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_MINSAVE_Result", StringUtil.RTrim( Dvelop_confirmpanel_minsave_Result));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_TENANTNAME_Activeeventkey", StringUtil.RTrim( Ddo_tenantname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_HOSPITALNAME_Activeeventkey", StringUtil.RTrim( Ddo_hospitalname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Activeeventkey", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Filteredtext_get", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BAS_TENANTTENANTCODE_Selectedvalue_get", StringUtil.RTrim( Ddo_bas_tenanttenantcode_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_MINSAVE_Result", StringUtil.RTrim( Dvelop_confirmpanel_minsave_Result));
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
            WE872( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT872( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("xt_intialdefinecode.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8InOutBAS_TenantTenantCode)) ;
      }

      public override String GetPgmname( )
      {
         return "XT_IntialDefineCode" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB870( )
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", divTablemain_Height, "px", "TableMain", "left", "top", "", "", "div");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"15\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "GridWithPaginationBar GridWithBorderColor WorkWithSelection WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtTenantName_Titleformat == 0 )
               {
                  context.SendWebValue( edtTenantName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtTenantName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Institute Code") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtHospitalName_Titleformat == 0 )
               {
                  context.SendWebValue( edtHospitalName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtHospitalName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBAS_TenantTenantCode_Titleformat == 0 )
               {
                  context.SendWebValue( edtBAS_TenantTenantCode_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBAS_TenantTenantCode_Title) ;
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
               GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWithSelection WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A394TenantName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtTenantName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTenantName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A358InstituteCode);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A395HospitalName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtHospitalName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtHospitalName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A360BAS_TenantTenantCode);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBAS_TenantTenantCode_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBAS_TenantTenantCode_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 15 )
         {
            wbEnd = 0;
            nRC_GXsfl_15 = (short)(nGXsfl_15_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV37GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV39GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV38GridPageSize);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, "GRIDPAGINATIONBARContainer");
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
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnminsave_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(15), 2, 0)+","+"null"+");", "确定", bttBtnminsave_Jsonclick, 7, "确定", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e11871_client"+"'", TempTags, "", 2, "HLP_XT_IntialDefineCode.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(15), 2, 0)+","+"null"+");", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_IntialDefineCode.htm");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDdo_tenantname.SetProperty("Caption", Ddo_tenantname_Caption);
            ucDdo_tenantname.SetProperty("Tooltip", Ddo_tenantname_Tooltip);
            ucDdo_tenantname.SetProperty("Cls", Ddo_tenantname_Cls);
            ucDdo_tenantname.SetProperty("DropDownOptionsType", Ddo_tenantname_Dropdownoptionstype);
            ucDdo_tenantname.SetProperty("IncludeSortASC", Ddo_tenantname_Includesortasc);
            ucDdo_tenantname.SetProperty("IncludeSortDSC", Ddo_tenantname_Includesortdsc);
            ucDdo_tenantname.SetProperty("IncludeFilter", Ddo_tenantname_Includefilter);
            ucDdo_tenantname.SetProperty("IncludeDataList", Ddo_tenantname_Includedatalist);
            ucDdo_tenantname.SetProperty("SortASC", Ddo_tenantname_Sortasc);
            ucDdo_tenantname.SetProperty("SortDSC", Ddo_tenantname_Sortdsc);
            ucDdo_tenantname.SetProperty("SearchButtonText", Ddo_tenantname_Searchbuttontext);
            ucDdo_tenantname.SetProperty("DropDownOptionsTitleSettingsIcons", AV35DDO_TitleSettingsIcons);
            ucDdo_tenantname.SetProperty("DropDownOptionsData", AV15TenantNameTitleFilterData);
            ucDdo_tenantname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_tenantname_Internalname, "DDO_TENANTNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_15_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_tenantnametitlecontrolidtoreplace_Internalname, AV16ddo_TenantNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_tenantnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_IntialDefineCode.htm");
            /* User Defined Control */
            ucDdo_hospitalname.SetProperty("Caption", Ddo_hospitalname_Caption);
            ucDdo_hospitalname.SetProperty("Tooltip", Ddo_hospitalname_Tooltip);
            ucDdo_hospitalname.SetProperty("Cls", Ddo_hospitalname_Cls);
            ucDdo_hospitalname.SetProperty("DropDownOptionsType", Ddo_hospitalname_Dropdownoptionstype);
            ucDdo_hospitalname.SetProperty("IncludeSortASC", Ddo_hospitalname_Includesortasc);
            ucDdo_hospitalname.SetProperty("IncludeSortDSC", Ddo_hospitalname_Includesortdsc);
            ucDdo_hospitalname.SetProperty("IncludeFilter", Ddo_hospitalname_Includefilter);
            ucDdo_hospitalname.SetProperty("IncludeDataList", Ddo_hospitalname_Includedatalist);
            ucDdo_hospitalname.SetProperty("SortASC", Ddo_hospitalname_Sortasc);
            ucDdo_hospitalname.SetProperty("SortDSC", Ddo_hospitalname_Sortdsc);
            ucDdo_hospitalname.SetProperty("SearchButtonText", Ddo_hospitalname_Searchbuttontext);
            ucDdo_hospitalname.SetProperty("DropDownOptionsTitleSettingsIcons", AV35DDO_TitleSettingsIcons);
            ucDdo_hospitalname.SetProperty("DropDownOptionsData", AV19HospitalNameTitleFilterData);
            ucDdo_hospitalname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_hospitalname_Internalname, "DDO_HOSPITALNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_15_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_hospitalnametitlecontrolidtoreplace_Internalname, AV20ddo_HospitalNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", 0, edtavDdo_hospitalnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_IntialDefineCode.htm");
            /* User Defined Control */
            ucDdo_bas_tenanttenantcode.SetProperty("Caption", Ddo_bas_tenanttenantcode_Caption);
            ucDdo_bas_tenanttenantcode.SetProperty("Tooltip", Ddo_bas_tenanttenantcode_Tooltip);
            ucDdo_bas_tenanttenantcode.SetProperty("Cls", Ddo_bas_tenanttenantcode_Cls);
            ucDdo_bas_tenanttenantcode.SetProperty("DropDownOptionsType", Ddo_bas_tenanttenantcode_Dropdownoptionstype);
            ucDdo_bas_tenanttenantcode.SetProperty("IncludeSortASC", Ddo_bas_tenanttenantcode_Includesortasc);
            ucDdo_bas_tenanttenantcode.SetProperty("IncludeSortDSC", Ddo_bas_tenanttenantcode_Includesortdsc);
            ucDdo_bas_tenanttenantcode.SetProperty("IncludeFilter", Ddo_bas_tenanttenantcode_Includefilter);
            ucDdo_bas_tenanttenantcode.SetProperty("FilterType", Ddo_bas_tenanttenantcode_Filtertype);
            ucDdo_bas_tenanttenantcode.SetProperty("FilterIsRange", Ddo_bas_tenanttenantcode_Filterisrange);
            ucDdo_bas_tenanttenantcode.SetProperty("IncludeDataList", Ddo_bas_tenanttenantcode_Includedatalist);
            ucDdo_bas_tenanttenantcode.SetProperty("DataListType", Ddo_bas_tenanttenantcode_Datalisttype);
            ucDdo_bas_tenanttenantcode.SetProperty("DataListProc", Ddo_bas_tenanttenantcode_Datalistproc);
            ucDdo_bas_tenanttenantcode.SetProperty("DataListUpdateMinimumCharacters", Ddo_bas_tenanttenantcode_Datalistupdateminimumcharacters);
            ucDdo_bas_tenanttenantcode.SetProperty("SortASC", Ddo_bas_tenanttenantcode_Sortasc);
            ucDdo_bas_tenanttenantcode.SetProperty("SortDSC", Ddo_bas_tenanttenantcode_Sortdsc);
            ucDdo_bas_tenanttenantcode.SetProperty("LoadingData", Ddo_bas_tenanttenantcode_Loadingdata);
            ucDdo_bas_tenanttenantcode.SetProperty("CleanFilter", Ddo_bas_tenanttenantcode_Cleanfilter);
            ucDdo_bas_tenanttenantcode.SetProperty("NoResultsFound", Ddo_bas_tenanttenantcode_Noresultsfound);
            ucDdo_bas_tenanttenantcode.SetProperty("SearchButtonText", Ddo_bas_tenanttenantcode_Searchbuttontext);
            ucDdo_bas_tenanttenantcode.SetProperty("DropDownOptionsTitleSettingsIcons", AV35DDO_TitleSettingsIcons);
            ucDdo_bas_tenanttenantcode.SetProperty("DropDownOptionsData", AV13BAS_TenantTenantCodeTitleFilterData);
            ucDdo_bas_tenanttenantcode.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_bas_tenanttenantcode_Internalname, "DDO_BAS_TENANTTENANTCODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'" + sGXsfl_15_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_bas_tenanttenantcodetitlecontrolidtoreplace_Internalname, AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", 0, edtavDdo_bas_tenanttenantcodetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_IntialDefineCode.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_15_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_IntialDefineCode.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_15_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_XT_IntialDefineCode.htm");
            wb_table1_46_872( true) ;
         }
         else
         {
            wb_table1_46_872( false) ;
         }
         return  ;
      }

      protected void wb_table1_46_872e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_15_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbas_tenanttenantcode_Internalname, AV44TFBAS_TenantTenantCode, StringUtil.RTrim( context.localUtil.Format( AV44TFBAS_TenantTenantCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbas_tenanttenantcode_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbas_tenanttenantcode_Visible, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_IntialDefineCode.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_15_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbas_tenanttenantcode_sel_Internalname, AV45TFBAS_TenantTenantCode_Sel, StringUtil.RTrim( context.localUtil.Format( AV45TFBAS_TenantTenantCode_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbas_tenanttenantcode_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbas_tenanttenantcode_sel_Visible, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_IntialDefineCode.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 15 )
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

      protected void START872( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP870( ) ;
      }

      protected void WS872( )
      {
         START872( ) ;
         EVT872( ) ;
      }

      protected void EVT872( )
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
                              E12872 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13872 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_TENANTNAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14872 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_HOSPITALNAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15872 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BAS_TENANTTENANTCODE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16872 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_MINSAVE.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E17872 ();
                              /* No code required for Cancel button. It is implemented as the Reset button. */
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_15_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
                              SubsflControlProps_152( ) ;
                              A394TenantName = cgiGet( edtTenantName_Internalname);
                              A358InstituteCode = cgiGet( edtInstituteCode_Internalname);
                              n358InstituteCode = false;
                              A395HospitalName = cgiGet( edtHospitalName_Internalname);
                              A360BAS_TenantTenantCode = cgiGet( edtBAS_TenantTenantCode_Internalname);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E18872 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E19872 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E20872 ();
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
                                       /* Set Refresh If Tfbas_tenanttenantcode Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBAS_TENANTTENANTCODE"), AV44TFBAS_TenantTenantCode) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbas_tenanttenantcode_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBAS_TENANTTENANTCODE_SEL"), AV45TFBAS_TenantTenantCode_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E21872 ();
                                       }
                                       dynload_actions( ) ;
                                    }
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

      protected void WE872( )
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

      protected void PA872( )
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
               GX_FocusControl = edtavDdo_tenantnametitlecontrolidtoreplace_Internalname;
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
         SubsflControlProps_152( ) ;
         while ( nGXsfl_15_idx <= nRC_GXsfl_15 )
         {
            sendrow_152( ) ;
            nGXsfl_15_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_15_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_15_idx+1));
            sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
            SubsflControlProps_152( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV11OrderedBy ,
                                       bool AV12OrderedDsc ,
                                       String AV44TFBAS_TenantTenantCode ,
                                       String AV45TFBAS_TenantTenantCode_Sel ,
                                       String AV16ddo_TenantNameTitleControlIdToReplace ,
                                       String AV20ddo_HospitalNameTitleControlIdToReplace ,
                                       String AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace ,
                                       String AV49Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF872( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BAS_TENANTTENANTCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A360BAS_TenantTenantCode, "")), context));
         GxWebStd.gx_hidden_field( context, "BAS_TENANTTENANTCODE", A360BAS_TenantTenantCode);
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
         RF872( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV49Pgmname = "XT_IntialDefineCode";
         context.Gx_err = 0;
      }

      protected void RF872( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 15;
         /* Execute user event: Refresh */
         E19872 ();
         nGXsfl_15_idx = 1;
         sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
         SubsflControlProps_152( ) ;
         bGXsfl_15_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWithSelection WorkWith");
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
            SubsflControlProps_152( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_datastore1.dynParam(0, new Object[]{ new Object[]{
                                                 AV45TFBAS_TenantTenantCode_Sel ,
                                                 AV44TFBAS_TenantTenantCode ,
                                                 A360BAS_TenantTenantCode ,
                                                 AV11OrderedBy ,
                                                 AV12OrderedDsc ,
                                                 A401BAS_TenantIsDeleted } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT
                                                 }
            } ) ;
            lV44TFBAS_TenantTenantCode = StringUtil.Concat( StringUtil.RTrim( AV44TFBAS_TenantTenantCode), "%", "");
            /* Using cursor H00872 */
            pr_datastore1.execute(0, new Object[] {lV44TFBAS_TenantTenantCode, AV45TFBAS_TenantTenantCode_Sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_15_idx = 1;
            sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
            SubsflControlProps_152( ) ;
            while ( ( (pr_datastore1.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A401BAS_TenantIsDeleted = H00872_A401BAS_TenantIsDeleted[0];
               A360BAS_TenantTenantCode = H00872_A360BAS_TenantTenantCode[0];
               A395HospitalName = H00872_A395HospitalName[0];
               A358InstituteCode = H00872_A358InstituteCode[0];
               n358InstituteCode = H00872_n358InstituteCode[0];
               A394TenantName = H00872_A394TenantName[0];
               E20872 ();
               pr_datastore1.readNext(0);
            }
            GRID_nEOF = (short)(((pr_datastore1.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_datastore1.close(0);
            wbEnd = 15;
            WB870( ) ;
         }
         bGXsfl_15_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes872( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BAS_TENANTTENANTCODE"+"_"+sGXsfl_15_idx, GetSecureSignedToken( sGXsfl_15_idx, StringUtil.RTrim( context.localUtil.Format( A360BAS_TenantTenantCode, "")), context));
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
         pr_datastore1.dynParam(1, new Object[]{ new Object[]{
                                              AV45TFBAS_TenantTenantCode_Sel ,
                                              AV44TFBAS_TenantTenantCode ,
                                              A360BAS_TenantTenantCode ,
                                              AV11OrderedBy ,
                                              AV12OrderedDsc ,
                                              A401BAS_TenantIsDeleted } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT
                                              }
         } ) ;
         lV44TFBAS_TenantTenantCode = StringUtil.Concat( StringUtil.RTrim( AV44TFBAS_TenantTenantCode), "%", "");
         /* Using cursor H00873 */
         pr_datastore1.execute(1, new Object[] {lV44TFBAS_TenantTenantCode, AV45TFBAS_TenantTenantCode_Sel});
         GRID_nRecordCount = H00873_AGRID_nRecordCount[0];
         pr_datastore1.close(1);
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV44TFBAS_TenantTenantCode, AV45TFBAS_TenantTenantCode_Sel, AV16ddo_TenantNameTitleControlIdToReplace, AV20ddo_HospitalNameTitleControlIdToReplace, AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace, AV49Pgmname) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV44TFBAS_TenantTenantCode, AV45TFBAS_TenantTenantCode_Sel, AV16ddo_TenantNameTitleControlIdToReplace, AV20ddo_HospitalNameTitleControlIdToReplace, AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace, AV49Pgmname) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV44TFBAS_TenantTenantCode, AV45TFBAS_TenantTenantCode_Sel, AV16ddo_TenantNameTitleControlIdToReplace, AV20ddo_HospitalNameTitleControlIdToReplace, AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace, AV49Pgmname) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV44TFBAS_TenantTenantCode, AV45TFBAS_TenantTenantCode_Sel, AV16ddo_TenantNameTitleControlIdToReplace, AV20ddo_HospitalNameTitleControlIdToReplace, AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace, AV49Pgmname) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV44TFBAS_TenantTenantCode, AV45TFBAS_TenantTenantCode_Sel, AV16ddo_TenantNameTitleControlIdToReplace, AV20ddo_HospitalNameTitleControlIdToReplace, AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace, AV49Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP870( )
      {
         /* Before Start, stand alone formulas. */
         AV49Pgmname = "XT_IntialDefineCode";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E18872 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV35DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vTENANTNAMETITLEFILTERDATA"), AV15TenantNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vHOSPITALNAMETITLEFILTERDATA"), AV19HospitalNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBAS_TENANTTENANTCODETITLEFILTERDATA"), AV13BAS_TenantTenantCodeTitleFilterData);
            /* Read variables values. */
            AV16ddo_TenantNameTitleControlIdToReplace = cgiGet( edtavDdo_tenantnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_TenantNameTitleControlIdToReplace", AV16ddo_TenantNameTitleControlIdToReplace);
            AV20ddo_HospitalNameTitleControlIdToReplace = cgiGet( edtavDdo_hospitalnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_HospitalNameTitleControlIdToReplace", AV20ddo_HospitalNameTitleControlIdToReplace);
            AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace = cgiGet( edtavDdo_bas_tenanttenantcodetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace", AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace);
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
            AV44TFBAS_TenantTenantCode = cgiGet( edtavTfbas_tenanttenantcode_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44TFBAS_TenantTenantCode", AV44TFBAS_TenantTenantCode);
            AV45TFBAS_TenantTenantCode_Sel = cgiGet( edtavTfbas_tenanttenantcode_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45TFBAS_TenantTenantCode_Sel", AV45TFBAS_TenantTenantCode_Sel);
            /* Read saved values. */
            nRC_GXsfl_15 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_15"), ".", ","));
            AV37GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV39GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV38GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            AV46tTenantCode = cgiGet( "vTTENANTCODE");
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
            Ddo_tenantname_Caption = cgiGet( "DDO_TENANTNAME_Caption");
            Ddo_tenantname_Tooltip = cgiGet( "DDO_TENANTNAME_Tooltip");
            Ddo_tenantname_Cls = cgiGet( "DDO_TENANTNAME_Cls");
            Ddo_tenantname_Dropdownoptionstype = cgiGet( "DDO_TENANTNAME_Dropdownoptionstype");
            Ddo_tenantname_Titlecontrolidtoreplace = cgiGet( "DDO_TENANTNAME_Titlecontrolidtoreplace");
            Ddo_tenantname_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_TENANTNAME_Includesortasc"));
            Ddo_tenantname_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_TENANTNAME_Includesortdsc"));
            Ddo_tenantname_Sortedstatus = cgiGet( "DDO_TENANTNAME_Sortedstatus");
            Ddo_tenantname_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_TENANTNAME_Includefilter"));
            Ddo_tenantname_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_TENANTNAME_Includedatalist"));
            Ddo_tenantname_Sortasc = cgiGet( "DDO_TENANTNAME_Sortasc");
            Ddo_tenantname_Sortdsc = cgiGet( "DDO_TENANTNAME_Sortdsc");
            Ddo_tenantname_Searchbuttontext = cgiGet( "DDO_TENANTNAME_Searchbuttontext");
            Ddo_hospitalname_Caption = cgiGet( "DDO_HOSPITALNAME_Caption");
            Ddo_hospitalname_Tooltip = cgiGet( "DDO_HOSPITALNAME_Tooltip");
            Ddo_hospitalname_Cls = cgiGet( "DDO_HOSPITALNAME_Cls");
            Ddo_hospitalname_Dropdownoptionstype = cgiGet( "DDO_HOSPITALNAME_Dropdownoptionstype");
            Ddo_hospitalname_Titlecontrolidtoreplace = cgiGet( "DDO_HOSPITALNAME_Titlecontrolidtoreplace");
            Ddo_hospitalname_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_HOSPITALNAME_Includesortasc"));
            Ddo_hospitalname_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_HOSPITALNAME_Includesortdsc"));
            Ddo_hospitalname_Sortedstatus = cgiGet( "DDO_HOSPITALNAME_Sortedstatus");
            Ddo_hospitalname_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_HOSPITALNAME_Includefilter"));
            Ddo_hospitalname_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_HOSPITALNAME_Includedatalist"));
            Ddo_hospitalname_Sortasc = cgiGet( "DDO_HOSPITALNAME_Sortasc");
            Ddo_hospitalname_Sortdsc = cgiGet( "DDO_HOSPITALNAME_Sortdsc");
            Ddo_hospitalname_Searchbuttontext = cgiGet( "DDO_HOSPITALNAME_Searchbuttontext");
            Ddo_bas_tenanttenantcode_Caption = cgiGet( "DDO_BAS_TENANTTENANTCODE_Caption");
            Ddo_bas_tenanttenantcode_Tooltip = cgiGet( "DDO_BAS_TENANTTENANTCODE_Tooltip");
            Ddo_bas_tenanttenantcode_Cls = cgiGet( "DDO_BAS_TENANTTENANTCODE_Cls");
            Ddo_bas_tenanttenantcode_Dropdownoptionstype = cgiGet( "DDO_BAS_TENANTTENANTCODE_Dropdownoptionstype");
            Ddo_bas_tenanttenantcode_Titlecontrolidtoreplace = cgiGet( "DDO_BAS_TENANTTENANTCODE_Titlecontrolidtoreplace");
            Ddo_bas_tenanttenantcode_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BAS_TENANTTENANTCODE_Includesortasc"));
            Ddo_bas_tenanttenantcode_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BAS_TENANTTENANTCODE_Includesortdsc"));
            Ddo_bas_tenanttenantcode_Sortedstatus = cgiGet( "DDO_BAS_TENANTTENANTCODE_Sortedstatus");
            Ddo_bas_tenanttenantcode_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BAS_TENANTTENANTCODE_Includefilter"));
            Ddo_bas_tenanttenantcode_Filtertype = cgiGet( "DDO_BAS_TENANTTENANTCODE_Filtertype");
            Ddo_bas_tenanttenantcode_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BAS_TENANTTENANTCODE_Filterisrange"));
            Ddo_bas_tenanttenantcode_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BAS_TENANTTENANTCODE_Includedatalist"));
            Ddo_bas_tenanttenantcode_Datalisttype = cgiGet( "DDO_BAS_TENANTTENANTCODE_Datalisttype");
            Ddo_bas_tenanttenantcode_Datalistproc = cgiGet( "DDO_BAS_TENANTTENANTCODE_Datalistproc");
            Ddo_bas_tenanttenantcode_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BAS_TENANTTENANTCODE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_bas_tenanttenantcode_Sortasc = cgiGet( "DDO_BAS_TENANTTENANTCODE_Sortasc");
            Ddo_bas_tenanttenantcode_Sortdsc = cgiGet( "DDO_BAS_TENANTTENANTCODE_Sortdsc");
            Ddo_bas_tenanttenantcode_Loadingdata = cgiGet( "DDO_BAS_TENANTTENANTCODE_Loadingdata");
            Ddo_bas_tenanttenantcode_Cleanfilter = cgiGet( "DDO_BAS_TENANTTENANTCODE_Cleanfilter");
            Ddo_bas_tenanttenantcode_Noresultsfound = cgiGet( "DDO_BAS_TENANTTENANTCODE_Noresultsfound");
            Ddo_bas_tenanttenantcode_Searchbuttontext = cgiGet( "DDO_BAS_TENANTTENANTCODE_Searchbuttontext");
            Dvelop_confirmpanel_minsave_Title = cgiGet( "DVELOP_CONFIRMPANEL_MINSAVE_Title");
            Dvelop_confirmpanel_minsave_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_MINSAVE_Confirmationtext");
            Dvelop_confirmpanel_minsave_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_MINSAVE_Yesbuttoncaption");
            Dvelop_confirmpanel_minsave_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_MINSAVE_Nobuttoncaption");
            Dvelop_confirmpanel_minsave_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_MINSAVE_Cancelbuttoncaption");
            Dvelop_confirmpanel_minsave_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_MINSAVE_Yesbuttonposition");
            Dvelop_confirmpanel_minsave_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_MINSAVE_Confirmtype");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_tenantname_Activeeventkey = cgiGet( "DDO_TENANTNAME_Activeeventkey");
            Ddo_hospitalname_Activeeventkey = cgiGet( "DDO_HOSPITALNAME_Activeeventkey");
            Ddo_bas_tenanttenantcode_Activeeventkey = cgiGet( "DDO_BAS_TENANTTENANTCODE_Activeeventkey");
            Ddo_bas_tenanttenantcode_Filteredtext_get = cgiGet( "DDO_BAS_TENANTTENANTCODE_Filteredtext_get");
            Ddo_bas_tenanttenantcode_Selectedvalue_get = cgiGet( "DDO_BAS_TENANTTENANTCODE_Selectedvalue_get");
            Dvelop_confirmpanel_minsave_Result = cgiGet( "DVELOP_CONFIRMPANEL_MINSAVE_Result");
            /* Read subfile selected row values. */
            nGXsfl_15_idx = (short)(context.localUtil.CToN( cgiGet( subGrid_Internalname+"_ROW"), ".", ","));
            sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
            SubsflControlProps_152( ) ;
            if ( nGXsfl_15_idx > 0 )
            {
               A394TenantName = cgiGet( edtTenantName_Internalname);
               A358InstituteCode = cgiGet( edtInstituteCode_Internalname);
               n358InstituteCode = false;
               A395HospitalName = cgiGet( edtHospitalName_Internalname);
               A360BAS_TenantTenantCode = cgiGet( edtBAS_TenantTenantCode_Internalname);
            }
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
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBAS_TENANTTENANTCODE"), AV44TFBAS_TenantTenantCode) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBAS_TENANTTENANTCODE_SEL"), AV45TFBAS_TenantTenantCode_Sel) != 0 )
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
         E18872 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E18872( )
      {
         /* Start Routine */
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbas_tenanttenantcode_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbas_tenanttenantcode_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbas_tenanttenantcode_Visible), 5, 0)), true);
         edtavTfbas_tenanttenantcode_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbas_tenanttenantcode_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbas_tenanttenantcode_sel_Visible), 5, 0)), true);
         Ddo_tenantname_Titlecontrolidtoreplace = subGrid_Internalname+"_TenantName";
         ucDdo_tenantname.SendProperty(context, "", false, Ddo_tenantname_Internalname, "TitleControlIdToReplace", Ddo_tenantname_Titlecontrolidtoreplace);
         AV16ddo_TenantNameTitleControlIdToReplace = Ddo_tenantname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_TenantNameTitleControlIdToReplace", AV16ddo_TenantNameTitleControlIdToReplace);
         edtavDdo_tenantnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_tenantnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_tenantnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_hospitalname_Titlecontrolidtoreplace = subGrid_Internalname+"_HospitalName";
         ucDdo_hospitalname.SendProperty(context, "", false, Ddo_hospitalname_Internalname, "TitleControlIdToReplace", Ddo_hospitalname_Titlecontrolidtoreplace);
         AV20ddo_HospitalNameTitleControlIdToReplace = Ddo_hospitalname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_HospitalNameTitleControlIdToReplace", AV20ddo_HospitalNameTitleControlIdToReplace);
         edtavDdo_hospitalnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_hospitalnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_hospitalnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_bas_tenanttenantcode_Titlecontrolidtoreplace = subGrid_Internalname+"_BAS_TenantTenantCode";
         ucDdo_bas_tenanttenantcode.SendProperty(context, "", false, Ddo_bas_tenanttenantcode_Internalname, "TitleControlIdToReplace", Ddo_bas_tenanttenantcode_Titlecontrolidtoreplace);
         AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace = Ddo_bas_tenanttenantcode_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace", AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace);
         edtavDdo_bas_tenanttenantcodetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_bas_tenanttenantcodetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_bas_tenanttenantcodetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "Data Mgmt Portal - RAAP";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV11OrderedBy < 1 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV35DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV35DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         GXt_boolean2 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefindcodeType", out  GXt_boolean2) ;
         AV5IsAuthorized = GXt_boolean2;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV49Pgmname)));
            context.wjLocDisableFrm = 1;
         }
      }

      protected void E19872( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV15TenantNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19HospitalNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV13BAS_TenantTenantCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtTenantName_Titleformat = 2;
         edtTenantName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "租户名称", AV16ddo_TenantNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTenantName_Internalname, "Title", edtTenantName_Title, !bGXsfl_15_Refreshing);
         edtHospitalName_Titleformat = 2;
         edtHospitalName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院名称", AV20ddo_HospitalNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHospitalName_Internalname, "Title", edtHospitalName_Title, !bGXsfl_15_Refreshing);
         edtBAS_TenantTenantCode_Titleformat = 2;
         edtBAS_TenantTenantCode_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "租户code", AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantTenantCode_Internalname, "Title", edtBAS_TenantTenantCode_Title, !bGXsfl_15_Refreshing);
         AV37GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV37GridCurrentPage), 10, 0)));
         AV38GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridPageSize), 10, 0)));
         AV39GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV39GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15TenantNameTitleFilterData", AV15TenantNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19HospitalNameTitleFilterData", AV19HospitalNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BAS_TenantTenantCodeTitleFilterData", AV13BAS_TenantTenantCodeTitleFilterData);
      }

      protected void E12872( )
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
            AV36PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV36PageToGo) ;
         }
      }

      protected void E13872( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E14872( )
      {
         /* Ddo_tenantname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_tenantname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_tenantname_Sortedstatus = "ASC";
            ucDdo_tenantname.SendProperty(context, "", false, Ddo_tenantname_Internalname, "SortedStatus", Ddo_tenantname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_tenantname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_tenantname_Sortedstatus = "DSC";
            ucDdo_tenantname.SendProperty(context, "", false, Ddo_tenantname_Internalname, "SortedStatus", Ddo_tenantname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15TenantNameTitleFilterData", AV15TenantNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19HospitalNameTitleFilterData", AV19HospitalNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BAS_TenantTenantCodeTitleFilterData", AV13BAS_TenantTenantCodeTitleFilterData);
      }

      protected void E15872( )
      {
         /* Ddo_hospitalname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_hospitalname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_hospitalname_Sortedstatus = "ASC";
            ucDdo_hospitalname.SendProperty(context, "", false, Ddo_hospitalname_Internalname, "SortedStatus", Ddo_hospitalname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_hospitalname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_hospitalname_Sortedstatus = "DSC";
            ucDdo_hospitalname.SendProperty(context, "", false, Ddo_hospitalname_Internalname, "SortedStatus", Ddo_hospitalname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15TenantNameTitleFilterData", AV15TenantNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19HospitalNameTitleFilterData", AV19HospitalNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BAS_TenantTenantCodeTitleFilterData", AV13BAS_TenantTenantCodeTitleFilterData);
      }

      protected void E16872( )
      {
         /* Ddo_bas_tenanttenantcode_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_bas_tenanttenantcode_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_bas_tenanttenantcode_Sortedstatus = "ASC";
            ucDdo_bas_tenanttenantcode.SendProperty(context, "", false, Ddo_bas_tenanttenantcode_Internalname, "SortedStatus", Ddo_bas_tenanttenantcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_bas_tenanttenantcode_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_bas_tenanttenantcode_Sortedstatus = "DSC";
            ucDdo_bas_tenanttenantcode.SendProperty(context, "", false, Ddo_bas_tenanttenantcode_Internalname, "SortedStatus", Ddo_bas_tenanttenantcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_bas_tenanttenantcode_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV44TFBAS_TenantTenantCode = Ddo_bas_tenanttenantcode_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44TFBAS_TenantTenantCode", AV44TFBAS_TenantTenantCode);
            AV45TFBAS_TenantTenantCode_Sel = Ddo_bas_tenanttenantcode_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45TFBAS_TenantTenantCode_Sel", AV45TFBAS_TenantTenantCode_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15TenantNameTitleFilterData", AV15TenantNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19HospitalNameTitleFilterData", AV19HospitalNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BAS_TenantTenantCodeTitleFilterData", AV13BAS_TenantTenantCodeTitleFilterData);
      }

      private void E20872( )
      {
         /* Grid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 15;
         }
         sendrow_152( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_15_Refreshing )
         {
            context.DoAjaxLoad(15, GridRow);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E21872 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21872( )
      {
         /* Enter Routine */
         AV8InOutBAS_TenantTenantCode = A360BAS_TenantTenantCode;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBAS_TenantTenantCode", AV8InOutBAS_TenantTenantCode);
         context.setWebReturnParms(new Object[] {(String)AV8InOutBAS_TenantTenantCode});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBAS_TenantTenantCode"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      protected void E17872( )
      {
         /* Dvelop_confirmpanel_minsave_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_minsave_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION MINSAVE' */
            S142 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void S132( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_tenantname_Sortedstatus = "";
         ucDdo_tenantname.SendProperty(context, "", false, Ddo_tenantname_Internalname, "SortedStatus", Ddo_tenantname_Sortedstatus);
         Ddo_hospitalname_Sortedstatus = "";
         ucDdo_hospitalname.SendProperty(context, "", false, Ddo_hospitalname_Internalname, "SortedStatus", Ddo_hospitalname_Sortedstatus);
         Ddo_bas_tenanttenantcode_Sortedstatus = "";
         ucDdo_bas_tenanttenantcode.SendProperty(context, "", false, Ddo_bas_tenanttenantcode_Internalname, "SortedStatus", Ddo_bas_tenanttenantcode_Sortedstatus);
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
         if ( AV11OrderedBy == 1 )
         {
            Ddo_tenantname_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_tenantname.SendProperty(context, "", false, Ddo_tenantname_Internalname, "SortedStatus", Ddo_tenantname_Sortedstatus);
         }
         else if ( AV11OrderedBy == 2 )
         {
            Ddo_hospitalname_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_hospitalname.SendProperty(context, "", false, Ddo_hospitalname_Internalname, "SortedStatus", Ddo_hospitalname_Sortedstatus);
         }
         else if ( AV11OrderedBy == 3 )
         {
            Ddo_bas_tenanttenantcode_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_bas_tenanttenantcode.SendProperty(context, "", false, Ddo_bas_tenanttenantcode_Internalname, "SortedStatus", Ddo_bas_tenanttenantcode_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'DO ACTION MINSAVE' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV46tTenantCode)) )
         {
            GX_msglist.addItem("请选择需要初始化数据字典的租户");
         }
         else
         {
            GX_msglist.addItem("执行时间较长，请耐心等待");
            new pc_intialdefinecode(context ).execute(  AV46tTenantCode) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46tTenantCode", AV46tTenantCode);
            context.setWebReturnParms(new Object[] {(String)AV8InOutBAS_TenantTenantCode});
            context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBAS_TenantTenantCode"});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S122( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV42GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV42GridState.gxTpr_Orderedby = AV11OrderedBy;
         AV42GridState.gxTpr_Ordereddsc = AV12OrderedDsc;
         AV42GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44TFBAS_TenantTenantCode)) )
         {
            AV43GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV43GridStateFilterValue.gxTpr_Name = "TFBAS_TENANTTENANTCODE";
            AV43GridStateFilterValue.gxTpr_Value = AV44TFBAS_TenantTenantCode;
            AV42GridState.gxTpr_Filtervalues.Add(AV43GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45TFBAS_TenantTenantCode_Sel)) )
         {
            AV43GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV43GridStateFilterValue.gxTpr_Name = "TFBAS_TENANTTENANTCODE_SEL";
            AV43GridStateFilterValue.gxTpr_Value = AV45TFBAS_TenantTenantCode_Sel;
            AV42GridState.gxTpr_Filtervalues.Add(AV43GridStateFilterValue, 0);
         }
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV49Pgmname+"GridState",  AV42GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void wb_table1_46_872( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_minsave_Internalname, tblTabledvelop_confirmpanel_minsave_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_minsave.SetProperty("Title", Dvelop_confirmpanel_minsave_Title);
            ucDvelop_confirmpanel_minsave.SetProperty("ConfirmationText", Dvelop_confirmpanel_minsave_Confirmationtext);
            ucDvelop_confirmpanel_minsave.SetProperty("YesButtonCaption", Dvelop_confirmpanel_minsave_Yesbuttoncaption);
            ucDvelop_confirmpanel_minsave.SetProperty("NoButtonCaption", Dvelop_confirmpanel_minsave_Nobuttoncaption);
            ucDvelop_confirmpanel_minsave.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_minsave_Cancelbuttoncaption);
            ucDvelop_confirmpanel_minsave.SetProperty("YesButtonPosition", Dvelop_confirmpanel_minsave_Yesbuttonposition);
            ucDvelop_confirmpanel_minsave.SetProperty("ConfirmType", Dvelop_confirmpanel_minsave_Confirmtype);
            ucDvelop_confirmpanel_minsave.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_minsave_Internalname, "DVELOP_CONFIRMPANEL_MINSAVEContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_MINSAVEContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_46_872e( true) ;
         }
         else
         {
            wb_table1_46_872e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8InOutBAS_TenantTenantCode = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBAS_TenantTenantCode", AV8InOutBAS_TenantTenantCode);
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
         PA872( ) ;
         WS872( ) ;
         WE872( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279472440", true);
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
         context.AddJavascriptSource("xt_intialdefinecode.js", "?20202279472441", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_152( )
      {
         edtTenantName_Internalname = "TENANTNAME_"+sGXsfl_15_idx;
         edtInstituteCode_Internalname = "INSTITUTECODE_"+sGXsfl_15_idx;
         edtHospitalName_Internalname = "HOSPITALNAME_"+sGXsfl_15_idx;
         edtBAS_TenantTenantCode_Internalname = "BAS_TENANTTENANTCODE_"+sGXsfl_15_idx;
      }

      protected void SubsflControlProps_fel_152( )
      {
         edtTenantName_Internalname = "TENANTNAME_"+sGXsfl_15_fel_idx;
         edtInstituteCode_Internalname = "INSTITUTECODE_"+sGXsfl_15_fel_idx;
         edtHospitalName_Internalname = "HOSPITALNAME_"+sGXsfl_15_fel_idx;
         edtBAS_TenantTenantCode_Internalname = "BAS_TENANTTENANTCODE_"+sGXsfl_15_fel_idx;
      }

      protected void sendrow_152( )
      {
         SubsflControlProps_152( ) ;
         WB870( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_15_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_15_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " class=\""+"GridWithPaginationBar GridWithBorderColor WorkWithSelection WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_15_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTenantName_Internalname,(String)A394TenantName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTenantName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)15,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtInstituteCode_Internalname,(String)A358InstituteCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtInstituteCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)15,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHospitalName_Internalname,(String)A395HospitalName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtHospitalName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)15,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBAS_TenantTenantCode_Internalname,(String)A360BAS_TenantTenantCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBAS_TenantTenantCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)15,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes872( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_15_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_15_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_15_idx+1));
            sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
            SubsflControlProps_152( ) ;
         }
         /* End function sendrow_152 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtTenantName_Internalname = "TENANTNAME";
         edtInstituteCode_Internalname = "INSTITUTECODE";
         edtHospitalName_Internalname = "HOSPITALNAME";
         edtBAS_TenantTenantCode_Internalname = "BAS_TENANTTENANTCODE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         bttBtnminsave_Internalname = "BTNMINSAVE";
         bttBtncancel_Internalname = "BTNCANCEL";
         divUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_tenantname_Internalname = "DDO_TENANTNAME";
         edtavDdo_tenantnametitlecontrolidtoreplace_Internalname = "vDDO_TENANTNAMETITLECONTROLIDTOREPLACE";
         Ddo_hospitalname_Internalname = "DDO_HOSPITALNAME";
         edtavDdo_hospitalnametitlecontrolidtoreplace_Internalname = "vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE";
         Ddo_bas_tenanttenantcode_Internalname = "DDO_BAS_TENANTTENANTCODE";
         edtavDdo_bas_tenanttenantcodetitlecontrolidtoreplace_Internalname = "vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         Dvelop_confirmpanel_minsave_Internalname = "DVELOP_CONFIRMPANEL_MINSAVE";
         tblTabledvelop_confirmpanel_minsave_Internalname = "TABLEDVELOP_CONFIRMPANEL_MINSAVE";
         edtavTfbas_tenanttenantcode_Internalname = "vTFBAS_TENANTTENANTCODE";
         edtavTfbas_tenanttenantcode_sel_Internalname = "vTFBAS_TENANTTENANTCODE_SEL";
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
         edtBAS_TenantTenantCode_Jsonclick = "";
         edtHospitalName_Jsonclick = "";
         edtInstituteCode_Jsonclick = "";
         edtTenantName_Jsonclick = "";
         edtavTfbas_tenanttenantcode_sel_Jsonclick = "";
         edtavTfbas_tenanttenantcode_sel_Visible = 1;
         edtavTfbas_tenanttenantcode_Jsonclick = "";
         edtavTfbas_tenanttenantcode_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_bas_tenanttenantcodetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_hospitalnametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_tenantnametitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowhovering = -1;
         subGrid_Allowselection = 1;
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBAS_TenantTenantCode_Titleformat = 0;
         edtBAS_TenantTenantCode_Title = "租户code";
         edtHospitalName_Titleformat = 0;
         edtHospitalName_Title = "医院名称";
         edtTenantName_Titleformat = 0;
         edtTenantName_Title = "租户名称";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWithSelection WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Dvelop_confirmpanel_minsave_Confirmtype = "1";
         Dvelop_confirmpanel_minsave_Yesbuttonposition = "left";
         Dvelop_confirmpanel_minsave_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_minsave_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_minsave_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_minsave_Confirmationtext = "确认初始化租户数据字典(初始化操作会将选择租户的原有所有数据字典信息删除)";
         Dvelop_confirmpanel_minsave_Title = "";
         Ddo_bas_tenanttenantcode_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_bas_tenanttenantcode_Noresultsfound = "WWP_TSNoResults";
         Ddo_bas_tenanttenantcode_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_bas_tenanttenantcode_Loadingdata = "WWP_TSLoading";
         Ddo_bas_tenanttenantcode_Sortdsc = "WWP_TSSortDSC";
         Ddo_bas_tenanttenantcode_Sortasc = "WWP_TSSortASC";
         Ddo_bas_tenanttenantcode_Datalistupdateminimumcharacters = 0;
         Ddo_bas_tenanttenantcode_Datalistproc = "XT_IntialDefineCodeGetFilterData";
         Ddo_bas_tenanttenantcode_Datalisttype = "Dynamic";
         Ddo_bas_tenanttenantcode_Includedatalist = Convert.ToBoolean( -1);
         Ddo_bas_tenanttenantcode_Filterisrange = Convert.ToBoolean( 0);
         Ddo_bas_tenanttenantcode_Filtertype = "Character";
         Ddo_bas_tenanttenantcode_Includefilter = Convert.ToBoolean( -1);
         Ddo_bas_tenanttenantcode_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_bas_tenanttenantcode_Includesortasc = Convert.ToBoolean( -1);
         Ddo_bas_tenanttenantcode_Titlecontrolidtoreplace = "";
         Ddo_bas_tenanttenantcode_Dropdownoptionstype = "GridTitleSettings";
         Ddo_bas_tenanttenantcode_Cls = "ColumnSettings";
         Ddo_bas_tenanttenantcode_Tooltip = "WWP_TSColumnOptions";
         Ddo_bas_tenanttenantcode_Caption = "";
         Ddo_hospitalname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_hospitalname_Sortdsc = "WWP_TSSortDSC";
         Ddo_hospitalname_Sortasc = "WWP_TSSortASC";
         Ddo_hospitalname_Includedatalist = Convert.ToBoolean( 0);
         Ddo_hospitalname_Includefilter = Convert.ToBoolean( 0);
         Ddo_hospitalname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_hospitalname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_hospitalname_Titlecontrolidtoreplace = "";
         Ddo_hospitalname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_hospitalname_Cls = "ColumnSettings";
         Ddo_hospitalname_Tooltip = "WWP_TSColumnOptions";
         Ddo_hospitalname_Caption = "";
         Ddo_tenantname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_tenantname_Sortdsc = "WWP_TSSortDSC";
         Ddo_tenantname_Sortasc = "WWP_TSSortASC";
         Ddo_tenantname_Includedatalist = Convert.ToBoolean( 0);
         Ddo_tenantname_Includefilter = Convert.ToBoolean( 0);
         Ddo_tenantname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_tenantname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_tenantname_Titlecontrolidtoreplace = "";
         Ddo_tenantname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_tenantname_Cls = "ColumnSettings";
         Ddo_tenantname_Tooltip = "WWP_TSColumnOptions";
         Ddo_tenantname_Caption = "";
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
         Form.Caption = "Data Mgmt Portal - RAAP";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV15TenantNameTitleFilterData',fld:'vTENANTNAMETITLEFILTERDATA',pic:''},{av:'AV19HospitalNameTitleFilterData',fld:'vHOSPITALNAMETITLEFILTERDATA',pic:''},{av:'AV13BAS_TenantTenantCodeTitleFilterData',fld:'vBAS_TENANTTENANTCODETITLEFILTERDATA',pic:''},{av:'edtTenantName_Titleformat',ctrl:'TENANTNAME',prop:'Titleformat'},{av:'edtTenantName_Title',ctrl:'TENANTNAME',prop:'Title'},{av:'edtHospitalName_Titleformat',ctrl:'HOSPITALNAME',prop:'Titleformat'},{av:'edtHospitalName_Title',ctrl:'HOSPITALNAME',prop:'Title'},{av:'edtBAS_TenantTenantCode_Titleformat',ctrl:'BAS_TENANTTENANTCODE',prop:'Titleformat'},{av:'edtBAS_TenantTenantCode_Title',ctrl:'BAS_TENANTTENANTCODE',prop:'Title'},{av:'AV37GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV38GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV39GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E12872',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E13872',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_TENANTNAME.ONOPTIONCLICKED","{handler:'E14872',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_tenantname_Activeeventkey',ctrl:'DDO_TENANTNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_TENANTNAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_tenantname_Sortedstatus',ctrl:'DDO_TENANTNAME',prop:'SortedStatus'},{av:'Ddo_hospitalname_Sortedstatus',ctrl:'DDO_HOSPITALNAME',prop:'SortedStatus'},{av:'Ddo_bas_tenanttenantcode_Sortedstatus',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'SortedStatus'},{av:'AV15TenantNameTitleFilterData',fld:'vTENANTNAMETITLEFILTERDATA',pic:''},{av:'AV19HospitalNameTitleFilterData',fld:'vHOSPITALNAMETITLEFILTERDATA',pic:''},{av:'AV13BAS_TenantTenantCodeTitleFilterData',fld:'vBAS_TENANTTENANTCODETITLEFILTERDATA',pic:''},{av:'edtTenantName_Titleformat',ctrl:'TENANTNAME',prop:'Titleformat'},{av:'edtTenantName_Title',ctrl:'TENANTNAME',prop:'Title'},{av:'edtHospitalName_Titleformat',ctrl:'HOSPITALNAME',prop:'Titleformat'},{av:'edtHospitalName_Title',ctrl:'HOSPITALNAME',prop:'Title'},{av:'edtBAS_TenantTenantCode_Titleformat',ctrl:'BAS_TENANTTENANTCODE',prop:'Titleformat'},{av:'edtBAS_TenantTenantCode_Title',ctrl:'BAS_TENANTTENANTCODE',prop:'Title'},{av:'AV37GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV38GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV39GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_HOSPITALNAME.ONOPTIONCLICKED","{handler:'E15872',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_hospitalname_Activeeventkey',ctrl:'DDO_HOSPITALNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_HOSPITALNAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_hospitalname_Sortedstatus',ctrl:'DDO_HOSPITALNAME',prop:'SortedStatus'},{av:'Ddo_tenantname_Sortedstatus',ctrl:'DDO_TENANTNAME',prop:'SortedStatus'},{av:'Ddo_bas_tenanttenantcode_Sortedstatus',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'SortedStatus'},{av:'AV15TenantNameTitleFilterData',fld:'vTENANTNAMETITLEFILTERDATA',pic:''},{av:'AV19HospitalNameTitleFilterData',fld:'vHOSPITALNAMETITLEFILTERDATA',pic:''},{av:'AV13BAS_TenantTenantCodeTitleFilterData',fld:'vBAS_TENANTTENANTCODETITLEFILTERDATA',pic:''},{av:'edtTenantName_Titleformat',ctrl:'TENANTNAME',prop:'Titleformat'},{av:'edtTenantName_Title',ctrl:'TENANTNAME',prop:'Title'},{av:'edtHospitalName_Titleformat',ctrl:'HOSPITALNAME',prop:'Titleformat'},{av:'edtHospitalName_Title',ctrl:'HOSPITALNAME',prop:'Title'},{av:'edtBAS_TenantTenantCode_Titleformat',ctrl:'BAS_TENANTTENANTCODE',prop:'Titleformat'},{av:'edtBAS_TenantTenantCode_Title',ctrl:'BAS_TENANTTENANTCODE',prop:'Title'},{av:'AV37GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV38GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV39GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BAS_TENANTTENANTCODE.ONOPTIONCLICKED","{handler:'E16872',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'AV16ddo_TenantNameTitleControlIdToReplace',fld:'vDDO_TENANTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_HospitalNameTitleControlIdToReplace',fld:'vDDO_HOSPITALNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace',fld:'vDDO_BAS_TENANTTENANTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_bas_tenanttenantcode_Activeeventkey',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'ActiveEventKey'},{av:'Ddo_bas_tenanttenantcode_Filteredtext_get',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'FilteredText_get'},{av:'Ddo_bas_tenanttenantcode_Selectedvalue_get',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BAS_TENANTTENANTCODE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_bas_tenanttenantcode_Sortedstatus',ctrl:'DDO_BAS_TENANTTENANTCODE',prop:'SortedStatus'},{av:'AV44TFBAS_TenantTenantCode',fld:'vTFBAS_TENANTTENANTCODE',pic:''},{av:'AV45TFBAS_TenantTenantCode_Sel',fld:'vTFBAS_TENANTTENANTCODE_SEL',pic:''},{av:'Ddo_tenantname_Sortedstatus',ctrl:'DDO_TENANTNAME',prop:'SortedStatus'},{av:'Ddo_hospitalname_Sortedstatus',ctrl:'DDO_HOSPITALNAME',prop:'SortedStatus'},{av:'AV15TenantNameTitleFilterData',fld:'vTENANTNAMETITLEFILTERDATA',pic:''},{av:'AV19HospitalNameTitleFilterData',fld:'vHOSPITALNAMETITLEFILTERDATA',pic:''},{av:'AV13BAS_TenantTenantCodeTitleFilterData',fld:'vBAS_TENANTTENANTCODETITLEFILTERDATA',pic:''},{av:'edtTenantName_Titleformat',ctrl:'TENANTNAME',prop:'Titleformat'},{av:'edtTenantName_Title',ctrl:'TENANTNAME',prop:'Title'},{av:'edtHospitalName_Titleformat',ctrl:'HOSPITALNAME',prop:'Titleformat'},{av:'edtHospitalName_Title',ctrl:'HOSPITALNAME',prop:'Title'},{av:'edtBAS_TenantTenantCode_Titleformat',ctrl:'BAS_TENANTTENANTCODE',prop:'Titleformat'},{av:'edtBAS_TenantTenantCode_Title',ctrl:'BAS_TENANTTENANTCODE',prop:'Title'},{av:'AV37GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV38GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV39GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E20872',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E21872',iparms:[{av:'A360BAS_TenantTenantCode',fld:'BAS_TENANTTENANTCODE',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBAS_TenantTenantCode',fld:'vINOUTBAS_TENANTTENANTCODE',pic:''}]}");
         setEventMetadata("'DOMINSAVE'","{handler:'E11871',iparms:[]");
         setEventMetadata("'DOMINSAVE'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_MINSAVE.CLOSE","{handler:'E17872',iparms:[{av:'Dvelop_confirmpanel_minsave_Result',ctrl:'DVELOP_CONFIRMPANEL_MINSAVE',prop:'Result'},{av:'AV46tTenantCode',fld:'vTTENANTCODE',pic:''},{av:'AV8InOutBAS_TenantTenantCode',fld:'vINOUTBAS_TENANTTENANTCODE',pic:''}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_MINSAVE.CLOSE",",oparms:[]}");
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
         wcpOAV8InOutBAS_TenantTenantCode = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_tenantname_Activeeventkey = "";
         Ddo_hospitalname_Activeeventkey = "";
         Ddo_bas_tenanttenantcode_Activeeventkey = "";
         Ddo_bas_tenanttenantcode_Filteredtext_get = "";
         Ddo_bas_tenanttenantcode_Selectedvalue_get = "";
         Dvelop_confirmpanel_minsave_Result = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV44TFBAS_TenantTenantCode = "";
         AV45TFBAS_TenantTenantCode_Sel = "";
         AV16ddo_TenantNameTitleControlIdToReplace = "";
         AV20ddo_HospitalNameTitleControlIdToReplace = "";
         AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace = "";
         AV49Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV35DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV15TenantNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19HospitalNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV13BAS_TenantTenantCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46tTenantCode = "";
         Ddo_tenantname_Sortedstatus = "";
         Ddo_hospitalname_Sortedstatus = "";
         Ddo_bas_tenanttenantcode_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A394TenantName = "";
         A358InstituteCode = "";
         A395HospitalName = "";
         A360BAS_TenantTenantCode = "";
         ucGridpaginationbar = new GXUserControl();
         TempTags = "";
         bttBtnminsave_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         ucDdo_tenantname = new GXUserControl();
         ucDdo_hospitalname = new GXUserControl();
         ucDdo_bas_tenanttenantcode = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV44TFBAS_TenantTenantCode = "";
         H00872_A401BAS_TenantIsDeleted = new short[1] ;
         H00872_A360BAS_TenantTenantCode = new String[] {""} ;
         H00872_A395HospitalName = new String[] {""} ;
         H00872_A358InstituteCode = new String[] {""} ;
         H00872_n358InstituteCode = new bool[] {false} ;
         H00872_A394TenantName = new String[] {""} ;
         H00873_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV42GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV43GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         ucDvelop_confirmpanel_minsave = new GXUserControl();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_intialdefinecode__datastore1(),
            new Object[][] {
                new Object[] {
               H00872_A401BAS_TenantIsDeleted, H00872_A360BAS_TenantTenantCode, H00872_A395HospitalName, H00872_A358InstituteCode, H00872_n358InstituteCode, H00872_A394TenantName
               }
               , new Object[] {
               H00873_AGRID_nRecordCount
               }
            }
         );
         AV49Pgmname = "XT_IntialDefineCode";
         /* GeneXus formulas. */
         AV49Pgmname = "XT_IntialDefineCode";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_15 ;
      private short nGXsfl_15_idx=1 ;
      private short GRID_nEOF ;
      private short AV11OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtTenantName_Titleformat ;
      private short edtHospitalName_Titleformat ;
      private short edtBAS_TenantTenantCode_Titleformat ;
      private short subGrid_Sortable ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A401BAS_TenantIsDeleted ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_bas_tenanttenantcode_Datalistupdateminimumcharacters ;
      private int divTablemain_Height ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_tenantnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_hospitalnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_bas_tenanttenantcodetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbas_tenanttenantcode_Visible ;
      private int edtavTfbas_tenanttenantcode_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV36PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV37GridCurrentPage ;
      private long AV39GridRecordCount ;
      private long AV38GridPageSize ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_tenantname_Activeeventkey ;
      private String Ddo_hospitalname_Activeeventkey ;
      private String Ddo_bas_tenanttenantcode_Activeeventkey ;
      private String Ddo_bas_tenanttenantcode_Filteredtext_get ;
      private String Ddo_bas_tenanttenantcode_Selectedvalue_get ;
      private String Dvelop_confirmpanel_minsave_Result ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_15_idx="0001" ;
      private String AV49Pgmname ;
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
      private String Ddo_tenantname_Caption ;
      private String Ddo_tenantname_Tooltip ;
      private String Ddo_tenantname_Cls ;
      private String Ddo_tenantname_Dropdownoptionstype ;
      private String Ddo_tenantname_Titlecontrolidtoreplace ;
      private String Ddo_tenantname_Sortedstatus ;
      private String Ddo_tenantname_Sortasc ;
      private String Ddo_tenantname_Sortdsc ;
      private String Ddo_tenantname_Searchbuttontext ;
      private String Ddo_hospitalname_Caption ;
      private String Ddo_hospitalname_Tooltip ;
      private String Ddo_hospitalname_Cls ;
      private String Ddo_hospitalname_Dropdownoptionstype ;
      private String Ddo_hospitalname_Titlecontrolidtoreplace ;
      private String Ddo_hospitalname_Sortedstatus ;
      private String Ddo_hospitalname_Sortasc ;
      private String Ddo_hospitalname_Sortdsc ;
      private String Ddo_hospitalname_Searchbuttontext ;
      private String Ddo_bas_tenanttenantcode_Caption ;
      private String Ddo_bas_tenanttenantcode_Tooltip ;
      private String Ddo_bas_tenanttenantcode_Cls ;
      private String Ddo_bas_tenanttenantcode_Dropdownoptionstype ;
      private String Ddo_bas_tenanttenantcode_Titlecontrolidtoreplace ;
      private String Ddo_bas_tenanttenantcode_Sortedstatus ;
      private String Ddo_bas_tenanttenantcode_Filtertype ;
      private String Ddo_bas_tenanttenantcode_Datalisttype ;
      private String Ddo_bas_tenanttenantcode_Datalistproc ;
      private String Ddo_bas_tenanttenantcode_Sortasc ;
      private String Ddo_bas_tenanttenantcode_Sortdsc ;
      private String Ddo_bas_tenanttenantcode_Loadingdata ;
      private String Ddo_bas_tenanttenantcode_Cleanfilter ;
      private String Ddo_bas_tenanttenantcode_Noresultsfound ;
      private String Ddo_bas_tenanttenantcode_Searchbuttontext ;
      private String Dvelop_confirmpanel_minsave_Title ;
      private String Dvelop_confirmpanel_minsave_Confirmationtext ;
      private String Dvelop_confirmpanel_minsave_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_minsave_Nobuttoncaption ;
      private String Dvelop_confirmpanel_minsave_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_minsave_Yesbuttonposition ;
      private String Dvelop_confirmpanel_minsave_Confirmtype ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtTenantName_Title ;
      private String edtHospitalName_Title ;
      private String edtBAS_TenantTenantCode_Title ;
      private String subGrid_Header ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String TempTags ;
      private String bttBtnminsave_Internalname ;
      private String bttBtnminsave_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_tenantname_Internalname ;
      private String edtavDdo_tenantnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_hospitalname_Internalname ;
      private String edtavDdo_hospitalnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_bas_tenanttenantcode_Internalname ;
      private String edtavDdo_bas_tenanttenantcodetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbas_tenanttenantcode_Internalname ;
      private String edtavTfbas_tenanttenantcode_Jsonclick ;
      private String edtavTfbas_tenanttenantcode_sel_Internalname ;
      private String edtavTfbas_tenanttenantcode_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtTenantName_Internalname ;
      private String edtInstituteCode_Internalname ;
      private String edtHospitalName_Internalname ;
      private String edtBAS_TenantTenantCode_Internalname ;
      private String scmdbuf ;
      private String tblTabledvelop_confirmpanel_minsave_Internalname ;
      private String Dvelop_confirmpanel_minsave_Internalname ;
      private String sGXsfl_15_fel_idx="0001" ;
      private String ROClassString ;
      private String edtTenantName_Jsonclick ;
      private String edtInstituteCode_Jsonclick ;
      private String edtHospitalName_Jsonclick ;
      private String edtBAS_TenantTenantCode_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_tenantname_Includesortasc ;
      private bool Ddo_tenantname_Includesortdsc ;
      private bool Ddo_tenantname_Includefilter ;
      private bool Ddo_tenantname_Includedatalist ;
      private bool Ddo_hospitalname_Includesortasc ;
      private bool Ddo_hospitalname_Includesortdsc ;
      private bool Ddo_hospitalname_Includefilter ;
      private bool Ddo_hospitalname_Includedatalist ;
      private bool Ddo_bas_tenanttenantcode_Includesortasc ;
      private bool Ddo_bas_tenanttenantcode_Includesortdsc ;
      private bool Ddo_bas_tenanttenantcode_Includefilter ;
      private bool Ddo_bas_tenanttenantcode_Filterisrange ;
      private bool Ddo_bas_tenanttenantcode_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n358InstituteCode ;
      private bool bGXsfl_15_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean2 ;
      private bool gx_refresh_fired ;
      private String AV8InOutBAS_TenantTenantCode ;
      private String wcpOAV8InOutBAS_TenantTenantCode ;
      private String AV44TFBAS_TenantTenantCode ;
      private String AV45TFBAS_TenantTenantCode_Sel ;
      private String AV16ddo_TenantNameTitleControlIdToReplace ;
      private String AV20ddo_HospitalNameTitleControlIdToReplace ;
      private String AV14ddo_BAS_TenantTenantCodeTitleControlIdToReplace ;
      private String AV46tTenantCode ;
      private String A394TenantName ;
      private String A358InstituteCode ;
      private String A395HospitalName ;
      private String A360BAS_TenantTenantCode ;
      private String lV44TFBAS_TenantTenantCode ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_tenantname ;
      private GXUserControl ucDdo_hospitalname ;
      private GXUserControl ucDdo_bas_tenanttenantcode ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXUserControl ucDvelop_confirmpanel_minsave ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private String aP0_InOutBAS_TenantTenantCode ;
      private IDataStoreProvider pr_datastore1 ;
      private short[] H00872_A401BAS_TenantIsDeleted ;
      private String[] H00872_A360BAS_TenantTenantCode ;
      private String[] H00872_A395HospitalName ;
      private String[] H00872_A358InstituteCode ;
      private bool[] H00872_n358InstituteCode ;
      private String[] H00872_A394TenantName ;
      private long[] H00873_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15TenantNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19HospitalNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BAS_TenantTenantCodeTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV35DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV42GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV43GridStateFilterValue ;
   }

   public class xt_intialdefinecode__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00872( IGxContext context ,
                                             String AV45TFBAS_TenantTenantCode_Sel ,
                                             String AV44TFBAS_TenantTenantCode ,
                                             String A360BAS_TenantTenantCode ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc ,
                                             short A401BAS_TenantIsDeleted )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [5] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [IsDeleted], [TenantCode], [HospitalName], [InstituteCode], [TenantName]";
         sFromString = " FROM dbo.[BAS_Tenant] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([IsDeleted] = 0)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV45TFBAS_TenantTenantCode_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44TFBAS_TenantTenantCode)) ) )
         {
            sWhereString = sWhereString + " and ([TenantCode] like @lV44TFBAS_TenantTenantCode)";
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45TFBAS_TenantTenantCode_Sel)) )
         {
            sWhereString = sWhereString + " and ([TenantCode] = @AV45TFBAS_TenantTenantCode_Sel)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [TenantName]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [TenantName] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [HospitalName]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [HospitalName] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [TenantCode]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [TenantCode] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [TenantCode]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00873( IGxContext context ,
                                             String AV45TFBAS_TenantTenantCode_Sel ,
                                             String AV44TFBAS_TenantTenantCode ,
                                             String A360BAS_TenantTenantCode ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc ,
                                             short A401BAS_TenantIsDeleted )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [2] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM dbo.[BAS_Tenant] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([IsDeleted] = 0)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV45TFBAS_TenantTenantCode_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44TFBAS_TenantTenantCode)) ) )
         {
            sWhereString = sWhereString + " and ([TenantCode] like @lV44TFBAS_TenantTenantCode)";
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45TFBAS_TenantTenantCode_Sel)) )
         {
            sWhereString = sWhereString + " and ([TenantCode] = @AV45TFBAS_TenantTenantCode_Sel)";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
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
                     return conditional_H00872(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] , (short)dynConstraints[5] );
               case 1 :
                     return conditional_H00873(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] , (short)dynConstraints[5] );
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
          Object[] prmH00872 ;
          prmH00872 = new Object[] {
          new Object[] {"@lV44TFBAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV45TFBAS_TenantTenantCode_Sel",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00873 ;
          prmH00873 = new Object[] {
          new Object[] {"@lV44TFBAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV45TFBAS_TenantTenantCode_Sel",SqlDbType.NVarChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00872", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00872,11,0,true,false )
             ,new CursorDef("H00873", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00873,1,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
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
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[2]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

}
