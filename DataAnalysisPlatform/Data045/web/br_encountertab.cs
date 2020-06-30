/*
               File: BR_EncounterTab
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:42.52
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
   public class br_encountertab : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encountertab( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
      }

      public br_encountertab( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Information_ID )
      {
         this.AV8BR_Information_ID = aP0_BR_Information_ID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
         cmbBR_Encounter_Status = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  AV8BR_Information_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)AV8BR_Information_ID});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
                  nRC_GXsfl_27 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_27_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_27_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
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
                  AV76BR_EncounterID = GetNextPar( );
                  AV14OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV15OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
                  AV81TFBR_Encounter_Departmentadm = GetNextPar( );
                  AV82TFBR_Encounter_Departmentadm_Sel = GetNextPar( );
                  AV85TFBR_Encounter_Departmentdisch = GetNextPar( );
                  AV86TFBR_Encounter_Departmentdisch_Sel = GetNextPar( );
                  AV8BR_Information_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV56ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
                  AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace = GetNextPar( );
                  AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = GetNextPar( );
                  AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace = GetNextPar( );
                  AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace = GetNextPar( );
                  AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = GetNextPar( );
                  AV74ddo_BR_Encounter_StatusTitleControlIdToReplace = GetNextPar( );
                  AV91Pgmname = GetNextPar( );
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV76BR_EncounterID, AV14OrderedBy, AV15OrderedDsc, AV81TFBR_Encounter_Departmentadm, AV82TFBR_Encounter_Departmentadm_Sel, AV85TFBR_Encounter_Departmentdisch, AV86TFBR_Encounter_Departmentdisch_Sel, AV8BR_Information_ID, AV56ddo_BR_EncounterIDTitleControlIdToReplace, AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace, AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV74ddo_BR_Encounter_StatusTitleControlIdToReplace, AV91Pgmname, sPrefix) ;
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
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA4B2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV91Pgmname = "BR_EncounterTab";
               context.Gx_err = 0;
               WS4B2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Data Mgmt Portal - RAAP") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202281564291", false);
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encountertab.aspx") + "?" + UrlEncode("" +AV8BR_Information_ID)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vBR_ENCOUNTERID", AV76BR_EncounterID);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDDSC", StringUtil.BoolToStr( AV15OrderedDsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTADM", AV81TFBR_Encounter_Departmentadm);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTADM_SEL", AV82TFBR_Encounter_Departmentadm_Sel);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTDISCH", AV85TFBR_Encounter_Departmentdisch);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL", AV86TFBR_Encounter_Departmentdisch_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_27", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_27), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV88GridPageCount), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV41DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV41DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_ENCOUNTERIDTITLEFILTERDATA", AV53BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_ENCOUNTERIDTITLEFILTERDATA", AV53BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_ENCOUNTER_ENCIDTITLEFILTERDATA", AV17BR_Encounter_EncIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_ENCOUNTER_ENCIDTITLEFILTERDATA", AV17BR_Encounter_EncIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA", AV58BR_Encounter_ENCTypeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA", AV58BR_Encounter_ENCTypeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA", AV80BR_Encounter_DepartmentadmTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA", AV80BR_Encounter_DepartmentadmTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA", AV84BR_Encounter_DepartmentdischTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA", AV84BR_Encounter_DepartmentdischTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA", AV21BR_Encounter_AdmitDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA", AV21BR_Encounter_AdmitDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_ENCOUNTER_STATUSTITLEFILTERDATA", AV71BR_Encounter_StatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_ENCOUNTER_STATUSTITLEFILTERDATA", AV71BR_Encounter_StatusTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_Information_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV91Pgmname));
         GxWebStd.gx_hidden_field( context, sPrefix+"vBR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Width", StringUtil.RTrim( Dvpanel_unnamedtable2_Width));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Cls", StringUtil.RTrim( Dvpanel_unnamedtable2_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Title", StringUtil.RTrim( Dvpanel_unnamedtable2_Title));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Collapsible));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Collapsed));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autowidth));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autoheight));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable2_Iconposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autoscroll));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_br_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_br_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_br_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_br_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_br_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Caption", StringUtil.RTrim( Ddo_br_encounter_encid_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Tooltip", StringUtil.RTrim( Ddo_br_encounter_encid_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Cls", StringUtil.RTrim( Ddo_br_encounter_encid_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_encid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_encid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_encid_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_encid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_encid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_encid_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_encid_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Sortasc", StringUtil.RTrim( Ddo_br_encounter_encid_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_encid_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_encid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Caption", StringUtil.RTrim( Ddo_br_encounter_enctype_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_enctype_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Cls", StringUtil.RTrim( Ddo_br_encounter_enctype_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_enctype_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_enctype_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_enctype_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_enctype_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_enctype_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_enctype_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Caption", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Tooltip", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Cls", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Selectedvalue_set", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_departmentadm_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_departmentadm_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_departmentadm_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Filtertype", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounter_departmentadm_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_departmentadm_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Datalisttype", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Datalisttype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Datalistproc", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Datalistproc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_encounter_departmentadm_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Sortasc", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Loadingdata", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Loadingdata));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Cleanfilter", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Noresultsfound", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Noresultsfound));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Caption", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Tooltip", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Cls", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Selectedvalue_set", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_departmentdisch_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_departmentdisch_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_departmentdisch_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Filtertype", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounter_departmentdisch_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_departmentdisch_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Datalisttype", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Datalisttype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Datalistproc", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Datalistproc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_encounter_departmentdisch_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Sortasc", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Loadingdata", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Loadingdata));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Cleanfilter", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Noresultsfound", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Noresultsfound));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Caption", StringUtil.RTrim( Ddo_br_encounter_admitdate_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_admitdate_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Cls", StringUtil.RTrim( Ddo_br_encounter_admitdate_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_admitdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_admitdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_admitdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_admitdate_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_admitdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_admitdate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Caption", StringUtil.RTrim( Ddo_br_encounter_status_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Tooltip", StringUtil.RTrim( Ddo_br_encounter_status_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Cls", StringUtil.RTrim( Ddo_br_encounter_status_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_status_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_status_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_status_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_status_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_status_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_status_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_status_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Sortasc", StringUtil.RTrim( Ddo_br_encounter_status_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_status_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_status_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_encid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_enctype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_admitdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_encid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_enctype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_departmentadm_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_departmentdisch_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_admitdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_ENCOUNTER_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_status_Activeeventkey));
      }

      protected void RenderHtmlCloseForm4B2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encountertab.js", "?20202281564737", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterTab" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB4B0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encountertab.aspx");
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
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable2.SetProperty("Width", Dvpanel_unnamedtable2_Width);
            ucDvpanel_unnamedtable2.SetProperty("AutoWidth", Dvpanel_unnamedtable2_Autowidth);
            ucDvpanel_unnamedtable2.SetProperty("AutoHeight", Dvpanel_unnamedtable2_Autoheight);
            ucDvpanel_unnamedtable2.SetProperty("Cls", Dvpanel_unnamedtable2_Cls);
            ucDvpanel_unnamedtable2.SetProperty("Title", Dvpanel_unnamedtable2_Title);
            ucDvpanel_unnamedtable2.SetProperty("Collapsible", Dvpanel_unnamedtable2_Collapsible);
            ucDvpanel_unnamedtable2.SetProperty("Collapsed", Dvpanel_unnamedtable2_Collapsed);
            ucDvpanel_unnamedtable2.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable2_Showcollapseicon);
            ucDvpanel_unnamedtable2.SetProperty("IconPosition", Dvpanel_unnamedtable2_Iconposition);
            ucDvpanel_unnamedtable2.SetProperty("AutoScroll", Dvpanel_unnamedtable2_Autoscroll);
            ucDvpanel_unnamedtable2.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable2_Internalname, sPrefix+"DVPANEL_UNNAMEDTABLE2Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"DVPANEL_UNNAMEDTABLE2Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable2_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-md-1", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(27), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterTab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-9 col-md-11", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_encounterid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounterid_Internalname, "就诊序号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_encounterid_Internalname, AV76BR_EncounterID, StringUtil.RTrim( context.localUtil.Format( AV76BR_EncounterID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,21);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_encounterid_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterTab.htm");
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
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"27\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_EncID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_EncID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_EncID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_ENCType_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_ENCType_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_ENCType_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_Departmentadm_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_Departmentadm_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_Departmentadm_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_Departmentdisch_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_Departmentdisch_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_Departmentdisch_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_AdmitDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_AdmitDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_AdmitDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "入院原因") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Encounter_Status_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Encounter_Status.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Encounter_Status.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "BAS_Tenant Tenant Code") ;
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
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A35BR_Encounter_EncID), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_EncID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_EncID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A90BR_Encounter_ENCType);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_ENCType_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_ENCType_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A570BR_Encounter_Departmentadm);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_Departmentadm_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_Departmentadm_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A572BR_Encounter_Departmentdisch);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_Departmentdisch_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_Departmentdisch_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_AdmitDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_AdmitDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A92BR_Encounter_AdmitSource);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BR_Encounter_Status), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Encounter_Status.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Encounter_Status_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A360BAS_TenantTenantCode);
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
         if ( wbEnd == 27 )
         {
            wbEnd = 0;
            nRC_GXsfl_27 = (short)(nGXsfl_27_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV44GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV88GridPageCount);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, sPrefix+"GRIDPAGINATIONBARContainer");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV41DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV53BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, sPrefix+"DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV56ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterTab.htm");
            /* User Defined Control */
            ucDdo_br_encounter_encid.SetProperty("Caption", Ddo_br_encounter_encid_Caption);
            ucDdo_br_encounter_encid.SetProperty("Tooltip", Ddo_br_encounter_encid_Tooltip);
            ucDdo_br_encounter_encid.SetProperty("Cls", Ddo_br_encounter_encid_Cls);
            ucDdo_br_encounter_encid.SetProperty("DropDownOptionsType", Ddo_br_encounter_encid_Dropdownoptionstype);
            ucDdo_br_encounter_encid.SetProperty("IncludeSortASC", Ddo_br_encounter_encid_Includesortasc);
            ucDdo_br_encounter_encid.SetProperty("IncludeSortDSC", Ddo_br_encounter_encid_Includesortdsc);
            ucDdo_br_encounter_encid.SetProperty("IncludeFilter", Ddo_br_encounter_encid_Includefilter);
            ucDdo_br_encounter_encid.SetProperty("IncludeDataList", Ddo_br_encounter_encid_Includedatalist);
            ucDdo_br_encounter_encid.SetProperty("SortASC", Ddo_br_encounter_encid_Sortasc);
            ucDdo_br_encounter_encid.SetProperty("SortDSC", Ddo_br_encounter_encid_Sortdsc);
            ucDdo_br_encounter_encid.SetProperty("SearchButtonText", Ddo_br_encounter_encid_Searchbuttontext);
            ucDdo_br_encounter_encid.SetProperty("DropDownOptionsTitleSettingsIcons", AV41DDO_TitleSettingsIcons);
            ucDdo_br_encounter_encid.SetProperty("DropDownOptionsData", AV17BR_Encounter_EncIDTitleFilterData);
            ucDdo_br_encounter_encid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_encid_Internalname, sPrefix+"DDO_BR_ENCOUNTER_ENCIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Internalname, AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterTab.htm");
            /* User Defined Control */
            ucDdo_br_encounter_enctype.SetProperty("Caption", Ddo_br_encounter_enctype_Caption);
            ucDdo_br_encounter_enctype.SetProperty("Tooltip", Ddo_br_encounter_enctype_Tooltip);
            ucDdo_br_encounter_enctype.SetProperty("Cls", Ddo_br_encounter_enctype_Cls);
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsType", Ddo_br_encounter_enctype_Dropdownoptionstype);
            ucDdo_br_encounter_enctype.SetProperty("IncludeSortASC", Ddo_br_encounter_enctype_Includesortasc);
            ucDdo_br_encounter_enctype.SetProperty("IncludeSortDSC", Ddo_br_encounter_enctype_Includesortdsc);
            ucDdo_br_encounter_enctype.SetProperty("IncludeFilter", Ddo_br_encounter_enctype_Includefilter);
            ucDdo_br_encounter_enctype.SetProperty("IncludeDataList", Ddo_br_encounter_enctype_Includedatalist);
            ucDdo_br_encounter_enctype.SetProperty("SortASC", Ddo_br_encounter_enctype_Sortasc);
            ucDdo_br_encounter_enctype.SetProperty("SortDSC", Ddo_br_encounter_enctype_Sortdsc);
            ucDdo_br_encounter_enctype.SetProperty("SearchButtonText", Ddo_br_encounter_enctype_Searchbuttontext);
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsTitleSettingsIcons", AV41DDO_TitleSettingsIcons);
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsData", AV58BR_Encounter_ENCTypeTitleFilterData);
            ucDdo_br_encounter_enctype.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_enctype_Internalname, sPrefix+"DDO_BR_ENCOUNTER_ENCTYPEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname, AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterTab.htm");
            /* User Defined Control */
            ucDdo_br_encounter_departmentadm.SetProperty("Caption", Ddo_br_encounter_departmentadm_Caption);
            ucDdo_br_encounter_departmentadm.SetProperty("Tooltip", Ddo_br_encounter_departmentadm_Tooltip);
            ucDdo_br_encounter_departmentadm.SetProperty("Cls", Ddo_br_encounter_departmentadm_Cls);
            ucDdo_br_encounter_departmentadm.SetProperty("DropDownOptionsType", Ddo_br_encounter_departmentadm_Dropdownoptionstype);
            ucDdo_br_encounter_departmentadm.SetProperty("IncludeSortASC", Ddo_br_encounter_departmentadm_Includesortasc);
            ucDdo_br_encounter_departmentadm.SetProperty("IncludeSortDSC", Ddo_br_encounter_departmentadm_Includesortdsc);
            ucDdo_br_encounter_departmentadm.SetProperty("IncludeFilter", Ddo_br_encounter_departmentadm_Includefilter);
            ucDdo_br_encounter_departmentadm.SetProperty("FilterType", Ddo_br_encounter_departmentadm_Filtertype);
            ucDdo_br_encounter_departmentadm.SetProperty("FilterIsRange", Ddo_br_encounter_departmentadm_Filterisrange);
            ucDdo_br_encounter_departmentadm.SetProperty("IncludeDataList", Ddo_br_encounter_departmentadm_Includedatalist);
            ucDdo_br_encounter_departmentadm.SetProperty("DataListType", Ddo_br_encounter_departmentadm_Datalisttype);
            ucDdo_br_encounter_departmentadm.SetProperty("DataListProc", Ddo_br_encounter_departmentadm_Datalistproc);
            ucDdo_br_encounter_departmentadm.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_encounter_departmentadm_Datalistupdateminimumcharacters);
            ucDdo_br_encounter_departmentadm.SetProperty("SortASC", Ddo_br_encounter_departmentadm_Sortasc);
            ucDdo_br_encounter_departmentadm.SetProperty("SortDSC", Ddo_br_encounter_departmentadm_Sortdsc);
            ucDdo_br_encounter_departmentadm.SetProperty("LoadingData", Ddo_br_encounter_departmentadm_Loadingdata);
            ucDdo_br_encounter_departmentadm.SetProperty("CleanFilter", Ddo_br_encounter_departmentadm_Cleanfilter);
            ucDdo_br_encounter_departmentadm.SetProperty("NoResultsFound", Ddo_br_encounter_departmentadm_Noresultsfound);
            ucDdo_br_encounter_departmentadm.SetProperty("SearchButtonText", Ddo_br_encounter_departmentadm_Searchbuttontext);
            ucDdo_br_encounter_departmentadm.SetProperty("DropDownOptionsTitleSettingsIcons", AV41DDO_TitleSettingsIcons);
            ucDdo_br_encounter_departmentadm.SetProperty("DropDownOptionsData", AV80BR_Encounter_DepartmentadmTitleFilterData);
            ucDdo_br_encounter_departmentadm.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_departmentadm_Internalname, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_departmentadmtitlecontrolidtoreplace_Internalname, AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_encounter_departmentadmtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterTab.htm");
            /* User Defined Control */
            ucDdo_br_encounter_departmentdisch.SetProperty("Caption", Ddo_br_encounter_departmentdisch_Caption);
            ucDdo_br_encounter_departmentdisch.SetProperty("Tooltip", Ddo_br_encounter_departmentdisch_Tooltip);
            ucDdo_br_encounter_departmentdisch.SetProperty("Cls", Ddo_br_encounter_departmentdisch_Cls);
            ucDdo_br_encounter_departmentdisch.SetProperty("DropDownOptionsType", Ddo_br_encounter_departmentdisch_Dropdownoptionstype);
            ucDdo_br_encounter_departmentdisch.SetProperty("IncludeSortASC", Ddo_br_encounter_departmentdisch_Includesortasc);
            ucDdo_br_encounter_departmentdisch.SetProperty("IncludeSortDSC", Ddo_br_encounter_departmentdisch_Includesortdsc);
            ucDdo_br_encounter_departmentdisch.SetProperty("IncludeFilter", Ddo_br_encounter_departmentdisch_Includefilter);
            ucDdo_br_encounter_departmentdisch.SetProperty("FilterType", Ddo_br_encounter_departmentdisch_Filtertype);
            ucDdo_br_encounter_departmentdisch.SetProperty("FilterIsRange", Ddo_br_encounter_departmentdisch_Filterisrange);
            ucDdo_br_encounter_departmentdisch.SetProperty("IncludeDataList", Ddo_br_encounter_departmentdisch_Includedatalist);
            ucDdo_br_encounter_departmentdisch.SetProperty("DataListType", Ddo_br_encounter_departmentdisch_Datalisttype);
            ucDdo_br_encounter_departmentdisch.SetProperty("DataListProc", Ddo_br_encounter_departmentdisch_Datalistproc);
            ucDdo_br_encounter_departmentdisch.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_encounter_departmentdisch_Datalistupdateminimumcharacters);
            ucDdo_br_encounter_departmentdisch.SetProperty("SortASC", Ddo_br_encounter_departmentdisch_Sortasc);
            ucDdo_br_encounter_departmentdisch.SetProperty("SortDSC", Ddo_br_encounter_departmentdisch_Sortdsc);
            ucDdo_br_encounter_departmentdisch.SetProperty("LoadingData", Ddo_br_encounter_departmentdisch_Loadingdata);
            ucDdo_br_encounter_departmentdisch.SetProperty("CleanFilter", Ddo_br_encounter_departmentdisch_Cleanfilter);
            ucDdo_br_encounter_departmentdisch.SetProperty("NoResultsFound", Ddo_br_encounter_departmentdisch_Noresultsfound);
            ucDdo_br_encounter_departmentdisch.SetProperty("SearchButtonText", Ddo_br_encounter_departmentdisch_Searchbuttontext);
            ucDdo_br_encounter_departmentdisch.SetProperty("DropDownOptionsTitleSettingsIcons", AV41DDO_TitleSettingsIcons);
            ucDdo_br_encounter_departmentdisch.SetProperty("DropDownOptionsData", AV84BR_Encounter_DepartmentdischTitleFilterData);
            ucDdo_br_encounter_departmentdisch.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_departmentdisch_Internalname, sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCHContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_departmentdischtitlecontrolidtoreplace_Internalname, AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_encounter_departmentdischtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterTab.htm");
            /* User Defined Control */
            ucDdo_br_encounter_admitdate.SetProperty("Caption", Ddo_br_encounter_admitdate_Caption);
            ucDdo_br_encounter_admitdate.SetProperty("Tooltip", Ddo_br_encounter_admitdate_Tooltip);
            ucDdo_br_encounter_admitdate.SetProperty("Cls", Ddo_br_encounter_admitdate_Cls);
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsType", Ddo_br_encounter_admitdate_Dropdownoptionstype);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeSortASC", Ddo_br_encounter_admitdate_Includesortasc);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeSortDSC", Ddo_br_encounter_admitdate_Includesortdsc);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeFilter", Ddo_br_encounter_admitdate_Includefilter);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeDataList", Ddo_br_encounter_admitdate_Includedatalist);
            ucDdo_br_encounter_admitdate.SetProperty("SortASC", Ddo_br_encounter_admitdate_Sortasc);
            ucDdo_br_encounter_admitdate.SetProperty("SortDSC", Ddo_br_encounter_admitdate_Sortdsc);
            ucDdo_br_encounter_admitdate.SetProperty("SearchButtonText", Ddo_br_encounter_admitdate_Searchbuttontext);
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV41DDO_TitleSettingsIcons);
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsData", AV21BR_Encounter_AdmitDateTitleFilterData);
            ucDdo_br_encounter_admitdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_admitdate_Internalname, sPrefix+"DDO_BR_ENCOUNTER_ADMITDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname, AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterTab.htm");
            /* User Defined Control */
            ucDdo_br_encounter_status.SetProperty("Caption", Ddo_br_encounter_status_Caption);
            ucDdo_br_encounter_status.SetProperty("Tooltip", Ddo_br_encounter_status_Tooltip);
            ucDdo_br_encounter_status.SetProperty("Cls", Ddo_br_encounter_status_Cls);
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsType", Ddo_br_encounter_status_Dropdownoptionstype);
            ucDdo_br_encounter_status.SetProperty("IncludeSortASC", Ddo_br_encounter_status_Includesortasc);
            ucDdo_br_encounter_status.SetProperty("IncludeSortDSC", Ddo_br_encounter_status_Includesortdsc);
            ucDdo_br_encounter_status.SetProperty("IncludeFilter", Ddo_br_encounter_status_Includefilter);
            ucDdo_br_encounter_status.SetProperty("IncludeDataList", Ddo_br_encounter_status_Includedatalist);
            ucDdo_br_encounter_status.SetProperty("SortASC", Ddo_br_encounter_status_Sortasc);
            ucDdo_br_encounter_status.SetProperty("SortDSC", Ddo_br_encounter_status_Sortdsc);
            ucDdo_br_encounter_status.SetProperty("SearchButtonText", Ddo_br_encounter_status_Searchbuttontext);
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsTitleSettingsIcons", AV41DDO_TitleSettingsIcons);
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsData", AV71BR_Encounter_StatusTitleFilterData);
            ucDdo_br_encounter_status.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_status_Internalname, sPrefix+"DDO_BR_ENCOUNTER_STATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname, AV74ddo_BR_Encounter_StatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterTab.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_ID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_ID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterTab.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterTab.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterTab.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_departmentadm_Internalname, AV81TFBR_Encounter_Departmentadm, StringUtil.RTrim( context.localUtil.Format( AV81TFBR_Encounter_Departmentadm, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_departmentadm_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_departmentadm_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterTab.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_departmentadm_sel_Internalname, AV82TFBR_Encounter_Departmentadm_Sel, StringUtil.RTrim( context.localUtil.Format( AV82TFBR_Encounter_Departmentadm_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_departmentadm_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_departmentadm_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterTab.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_departmentdisch_Internalname, AV85TFBR_Encounter_Departmentdisch, StringUtil.RTrim( context.localUtil.Format( AV85TFBR_Encounter_Departmentdisch, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_departmentdisch_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_departmentdisch_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterTab.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'" + sPrefix + "',false,'" + sGXsfl_27_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_departmentdisch_sel_Internalname, AV86TFBR_Encounter_Departmentdisch_Sel, StringUtil.RTrim( context.localUtil.Format( AV86TFBR_Encounter_Departmentdisch_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_departmentdisch_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_departmentdisch_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterTab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 27 )
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
                  context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
                  if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START4B2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP4B0( ) ;
            }
         }
      }

      protected void WS4B2( )
      {
         START4B2( ) ;
         EVT4B2( ) ;
      }

      protected void EVT4B2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
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
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E114B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E124B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E134B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ENCID.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E144B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E154B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_DEPARTMENTADM.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E164B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_DEPARTMENTDISCH.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E174B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E184B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E194B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DoInsert' */
                                    E204B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VBR_ENCOUNTERID.CONTROLVALUECHANGING") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E214B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavBr_encounterid_Internalname;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 20), "BR_ENCOUNTERID.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 20), "BR_ENCOUNTERID.CLICK") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4B0( ) ;
                              }
                              nGXsfl_27_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_27_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_27_idx), 4, 0)), 4, "0");
                              SubsflControlProps_272( ) ;
                              A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                              A35BR_Encounter_EncID = (long)(context.localUtil.CToN( cgiGet( edtBR_Encounter_EncID_Internalname), ".", ","));
                              n35BR_Encounter_EncID = false;
                              A90BR_Encounter_ENCType = cgiGet( edtBR_Encounter_ENCType_Internalname);
                              n90BR_Encounter_ENCType = false;
                              A570BR_Encounter_Departmentadm = cgiGet( edtBR_Encounter_Departmentadm_Internalname);
                              n570BR_Encounter_Departmentadm = false;
                              A572BR_Encounter_Departmentdisch = cgiGet( edtBR_Encounter_Departmentdisch_Internalname);
                              n572BR_Encounter_Departmentdisch = false;
                              A91BR_Encounter_AdmitDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Encounter_AdmitDate_Internalname), 0));
                              n91BR_Encounter_AdmitDate = false;
                              A92BR_Encounter_AdmitSource = cgiGet( edtBR_Encounter_AdmitSource_Internalname);
                              n92BR_Encounter_AdmitSource = false;
                              cmbBR_Encounter_Status.Name = cmbBR_Encounter_Status_Internalname;
                              cmbBR_Encounter_Status.CurrentValue = cgiGet( cmbBR_Encounter_Status_Internalname);
                              A172BR_Encounter_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_Status_Internalname), "."));
                              n172BR_Encounter_Status = false;
                              A360BAS_TenantTenantCode = cgiGet( edtBAS_TenantTenantCode_Internalname);
                              n360BAS_TenantTenantCode = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavBr_encounterid_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E224B2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavBr_encounterid_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E234B2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavBr_encounterid_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E244B2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "BR_ENCOUNTERID.CLICK") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavBr_encounterid_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E254B2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false;
                                             /* Set Refresh If Br_encounterid Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vBR_ENCOUNTERID"), AV76BR_EncounterID) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Orderedby Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Ordereddsc Changed */
                                             if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_encounter_departmentadm Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTADM"), AV81TFBR_Encounter_Departmentadm) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_encounter_departmentadm_sel Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTADM_SEL"), AV82TFBR_Encounter_Departmentadm_Sel) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_encounter_departmentdisch Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTDISCH"), AV85TFBR_Encounter_Departmentdisch) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_encounter_departmentdisch_sel Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL"), AV86TFBR_Encounter_Departmentdisch_Sel) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP4B0( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavBr_encounterid_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
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

      protected void WE4B2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm4B2( ) ;
            }
         }
      }

      protected void PA4B2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavBr_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
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
         SubsflControlProps_272( ) ;
         while ( nGXsfl_27_idx <= nRC_GXsfl_27 )
         {
            sendrow_272( ) ;
            nGXsfl_27_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_27_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_27_idx+1));
            sGXsfl_27_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_27_idx), 4, 0)), 4, "0");
            SubsflControlProps_272( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV76BR_EncounterID ,
                                       short AV14OrderedBy ,
                                       bool AV15OrderedDsc ,
                                       String AV81TFBR_Encounter_Departmentadm ,
                                       String AV82TFBR_Encounter_Departmentadm_Sel ,
                                       String AV85TFBR_Encounter_Departmentdisch ,
                                       String AV86TFBR_Encounter_Departmentdisch_Sel ,
                                       long AV8BR_Information_ID ,
                                       String AV56ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace ,
                                       String AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace ,
                                       String AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace ,
                                       String AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace ,
                                       String AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace ,
                                       String AV74ddo_BR_Encounter_StatusTitleControlIdToReplace ,
                                       String AV91Pgmname ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF4B2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_ENCOUNTERID", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_ENCOUNTER_STATUS", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A172BR_Encounter_Status), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_ENCOUNTER_STATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BR_Encounter_Status), 4, 0, ".", "")));
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
         RF4B2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV91Pgmname = "BR_EncounterTab";
         context.Gx_err = 0;
      }

      protected void RF4B2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 27;
         /* Execute user event: Refresh */
         E234B2 ();
         nGXsfl_27_idx = 1;
         sGXsfl_27_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_27_idx), 4, 0)), 4, "0");
         SubsflControlProps_272( ) ;
         bGXsfl_27_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", sPrefix);
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
            SubsflControlProps_272( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV76BR_EncounterID ,
                                                 AV82TFBR_Encounter_Departmentadm_Sel ,
                                                 AV81TFBR_Encounter_Departmentadm ,
                                                 AV86TFBR_Encounter_Departmentdisch_Sel ,
                                                 AV85TFBR_Encounter_Departmentdisch ,
                                                 A19BR_EncounterID ,
                                                 A570BR_Encounter_Departmentadm ,
                                                 A572BR_Encounter_Departmentdisch ,
                                                 AV14OrderedBy ,
                                                 AV15OrderedDsc ,
                                                 A85BR_Information_ID ,
                                                 AV8BR_Information_ID ,
                                                 A360BAS_TenantTenantCode ,
                                                 AV77tCurrentCode } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                                 }
            } ) ;
            lV76BR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV76BR_EncounterID), "%", "");
            lV81TFBR_Encounter_Departmentadm = StringUtil.Concat( StringUtil.RTrim( AV81TFBR_Encounter_Departmentadm), "%", "");
            lV85TFBR_Encounter_Departmentdisch = StringUtil.Concat( StringUtil.RTrim( AV85TFBR_Encounter_Departmentdisch), "%", "");
            /* Using cursor H004B2 */
            pr_default.execute(0, new Object[] {AV8BR_Information_ID, AV77tCurrentCode, lV76BR_EncounterID, lV81TFBR_Encounter_Departmentadm, AV82TFBR_Encounter_Departmentadm_Sel, lV85TFBR_Encounter_Departmentdisch, AV86TFBR_Encounter_Departmentdisch_Sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_27_idx = 1;
            sGXsfl_27_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_27_idx), 4, 0)), 4, "0");
            SubsflControlProps_272( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H004B2_A85BR_Information_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
               n85BR_Information_ID = H004B2_n85BR_Information_ID[0];
               A360BAS_TenantTenantCode = H004B2_A360BAS_TenantTenantCode[0];
               n360BAS_TenantTenantCode = H004B2_n360BAS_TenantTenantCode[0];
               A172BR_Encounter_Status = H004B2_A172BR_Encounter_Status[0];
               n172BR_Encounter_Status = H004B2_n172BR_Encounter_Status[0];
               A92BR_Encounter_AdmitSource = H004B2_A92BR_Encounter_AdmitSource[0];
               n92BR_Encounter_AdmitSource = H004B2_n92BR_Encounter_AdmitSource[0];
               A91BR_Encounter_AdmitDate = H004B2_A91BR_Encounter_AdmitDate[0];
               n91BR_Encounter_AdmitDate = H004B2_n91BR_Encounter_AdmitDate[0];
               A572BR_Encounter_Departmentdisch = H004B2_A572BR_Encounter_Departmentdisch[0];
               n572BR_Encounter_Departmentdisch = H004B2_n572BR_Encounter_Departmentdisch[0];
               A570BR_Encounter_Departmentadm = H004B2_A570BR_Encounter_Departmentadm[0];
               n570BR_Encounter_Departmentadm = H004B2_n570BR_Encounter_Departmentadm[0];
               A90BR_Encounter_ENCType = H004B2_A90BR_Encounter_ENCType[0];
               n90BR_Encounter_ENCType = H004B2_n90BR_Encounter_ENCType[0];
               A35BR_Encounter_EncID = H004B2_A35BR_Encounter_EncID[0];
               n35BR_Encounter_EncID = H004B2_n35BR_Encounter_EncID[0];
               A19BR_EncounterID = H004B2_A19BR_EncounterID[0];
               E244B2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 27;
            WB4B0( ) ;
         }
         bGXsfl_27_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes4B2( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_ENCOUNTERID"+"_"+sGXsfl_27_idx, GetSecureSignedToken( sPrefix+sGXsfl_27_idx, context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_ENCOUNTER_STATUS"+"_"+sGXsfl_27_idx, GetSecureSignedToken( sPrefix+sGXsfl_27_idx, context.localUtil.Format( (decimal)(A172BR_Encounter_Status), "ZZZ9"), context));
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
                                              AV76BR_EncounterID ,
                                              AV82TFBR_Encounter_Departmentadm_Sel ,
                                              AV81TFBR_Encounter_Departmentadm ,
                                              AV86TFBR_Encounter_Departmentdisch_Sel ,
                                              AV85TFBR_Encounter_Departmentdisch ,
                                              A19BR_EncounterID ,
                                              A570BR_Encounter_Departmentadm ,
                                              A572BR_Encounter_Departmentdisch ,
                                              AV14OrderedBy ,
                                              AV15OrderedDsc ,
                                              A85BR_Information_ID ,
                                              AV8BR_Information_ID ,
                                              A360BAS_TenantTenantCode ,
                                              AV77tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV76BR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV76BR_EncounterID), "%", "");
         lV81TFBR_Encounter_Departmentadm = StringUtil.Concat( StringUtil.RTrim( AV81TFBR_Encounter_Departmentadm), "%", "");
         lV85TFBR_Encounter_Departmentdisch = StringUtil.Concat( StringUtil.RTrim( AV85TFBR_Encounter_Departmentdisch), "%", "");
         /* Using cursor H004B3 */
         pr_default.execute(1, new Object[] {AV8BR_Information_ID, AV77tCurrentCode, lV76BR_EncounterID, lV81TFBR_Encounter_Departmentadm, AV82TFBR_Encounter_Departmentadm_Sel, lV85TFBR_Encounter_Departmentdisch, AV86TFBR_Encounter_Departmentdisch_Sel});
         GRID_nRecordCount = H004B3_AGRID_nRecordCount[0];
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV76BR_EncounterID, AV14OrderedBy, AV15OrderedDsc, AV81TFBR_Encounter_Departmentadm, AV82TFBR_Encounter_Departmentadm_Sel, AV85TFBR_Encounter_Departmentdisch, AV86TFBR_Encounter_Departmentdisch_Sel, AV8BR_Information_ID, AV56ddo_BR_EncounterIDTitleControlIdToReplace, AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace, AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV74ddo_BR_Encounter_StatusTitleControlIdToReplace, AV91Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV76BR_EncounterID, AV14OrderedBy, AV15OrderedDsc, AV81TFBR_Encounter_Departmentadm, AV82TFBR_Encounter_Departmentadm_Sel, AV85TFBR_Encounter_Departmentdisch, AV86TFBR_Encounter_Departmentdisch_Sel, AV8BR_Information_ID, AV56ddo_BR_EncounterIDTitleControlIdToReplace, AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace, AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV74ddo_BR_Encounter_StatusTitleControlIdToReplace, AV91Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV76BR_EncounterID, AV14OrderedBy, AV15OrderedDsc, AV81TFBR_Encounter_Departmentadm, AV82TFBR_Encounter_Departmentadm_Sel, AV85TFBR_Encounter_Departmentdisch, AV86TFBR_Encounter_Departmentdisch_Sel, AV8BR_Information_ID, AV56ddo_BR_EncounterIDTitleControlIdToReplace, AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace, AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV74ddo_BR_Encounter_StatusTitleControlIdToReplace, AV91Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV76BR_EncounterID, AV14OrderedBy, AV15OrderedDsc, AV81TFBR_Encounter_Departmentadm, AV82TFBR_Encounter_Departmentadm_Sel, AV85TFBR_Encounter_Departmentdisch, AV86TFBR_Encounter_Departmentdisch_Sel, AV8BR_Information_ID, AV56ddo_BR_EncounterIDTitleControlIdToReplace, AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace, AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV74ddo_BR_Encounter_StatusTitleControlIdToReplace, AV91Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV76BR_EncounterID, AV14OrderedBy, AV15OrderedDsc, AV81TFBR_Encounter_Departmentadm, AV82TFBR_Encounter_Departmentadm_Sel, AV85TFBR_Encounter_Departmentdisch, AV86TFBR_Encounter_Departmentdisch_Sel, AV8BR_Information_ID, AV56ddo_BR_EncounterIDTitleControlIdToReplace, AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace, AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV74ddo_BR_Encounter_StatusTitleControlIdToReplace, AV91Pgmname, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP4B0( )
      {
         /* Before Start, stand alone formulas. */
         AV91Pgmname = "BR_EncounterTab";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E224B2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV41DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_ENCOUNTERIDTITLEFILTERDATA"), AV53BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_ENCOUNTER_ENCIDTITLEFILTERDATA"), AV17BR_Encounter_EncIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA"), AV58BR_Encounter_ENCTypeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA"), AV80BR_Encounter_DepartmentadmTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA"), AV84BR_Encounter_DepartmentdischTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA"), AV21BR_Encounter_AdmitDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_ENCOUNTER_STATUSTITLEFILTERDATA"), AV71BR_Encounter_StatusTitleFilterData);
            /* Read variables values. */
            AV76BR_EncounterID = cgiGet( edtavBr_encounterid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV76BR_EncounterID", AV76BR_EncounterID);
            AV56ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV56ddo_BR_EncounterIDTitleControlIdToReplace", AV56ddo_BR_EncounterIDTitleControlIdToReplace);
            AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace", AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace);
            AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace", AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace);
            AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_departmentadmtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace", AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace);
            AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_departmentdischtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace", AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace);
            AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace", AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace);
            AV74ddo_BR_Encounter_StatusTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV74ddo_BR_Encounter_StatusTitleControlIdToReplace", AV74ddo_BR_Encounter_StatusTitleControlIdToReplace);
            A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ","));
            n85BR_Information_ID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            }
            else
            {
               AV14OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            }
            AV15OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            AV81TFBR_Encounter_Departmentadm = cgiGet( edtavTfbr_encounter_departmentadm_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV81TFBR_Encounter_Departmentadm", AV81TFBR_Encounter_Departmentadm);
            AV82TFBR_Encounter_Departmentadm_Sel = cgiGet( edtavTfbr_encounter_departmentadm_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV82TFBR_Encounter_Departmentadm_Sel", AV82TFBR_Encounter_Departmentadm_Sel);
            AV85TFBR_Encounter_Departmentdisch = cgiGet( edtavTfbr_encounter_departmentdisch_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV85TFBR_Encounter_Departmentdisch", AV85TFBR_Encounter_Departmentdisch);
            AV86TFBR_Encounter_Departmentdisch_Sel = cgiGet( edtavTfbr_encounter_departmentdisch_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV86TFBR_Encounter_Departmentdisch_Sel", AV86TFBR_Encounter_Departmentdisch_Sel);
            /* Read saved values. */
            nRC_GXsfl_27 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_27"), ".", ","));
            AV44GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV88GridPageCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGECOUNT"), ".", ","));
            wcpOAV8BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_Information_ID"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_unnamedtable2_Width = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Width");
            Dvpanel_unnamedtable2_Cls = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Cls");
            Dvpanel_unnamedtable2_Title = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Title");
            Dvpanel_unnamedtable2_Collapsible = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Collapsible"));
            Dvpanel_unnamedtable2_Collapsed = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Collapsed"));
            Dvpanel_unnamedtable2_Autowidth = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Autowidth"));
            Dvpanel_unnamedtable2_Autoheight = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Autoheight"));
            Dvpanel_unnamedtable2_Showcollapseicon = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Showcollapseicon"));
            Dvpanel_unnamedtable2_Iconposition = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Iconposition");
            Dvpanel_unnamedtable2_Autoscroll = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Autoscroll"));
            Gridpaginationbar_Class = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagestoshow"), ".", ","));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_br_encounterid_Caption = cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Caption");
            Ddo_br_encounterid_Tooltip = cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Tooltip");
            Ddo_br_encounterid_Cls = cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Cls");
            Ddo_br_encounterid_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Dropdownoptionstype");
            Ddo_br_encounterid_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace");
            Ddo_br_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Includesortasc"));
            Ddo_br_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Includesortdsc"));
            Ddo_br_encounterid_Sortedstatus = cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Sortedstatus");
            Ddo_br_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Includefilter"));
            Ddo_br_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Includedatalist"));
            Ddo_br_encounterid_Sortasc = cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Sortasc");
            Ddo_br_encounterid_Sortdsc = cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Sortdsc");
            Ddo_br_encounterid_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Searchbuttontext");
            Ddo_br_encounter_encid_Caption = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Caption");
            Ddo_br_encounter_encid_Tooltip = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Tooltip");
            Ddo_br_encounter_encid_Cls = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Cls");
            Ddo_br_encounter_encid_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Dropdownoptionstype");
            Ddo_br_encounter_encid_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Titlecontrolidtoreplace");
            Ddo_br_encounter_encid_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Includesortasc"));
            Ddo_br_encounter_encid_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Includesortdsc"));
            Ddo_br_encounter_encid_Sortedstatus = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Sortedstatus");
            Ddo_br_encounter_encid_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Includefilter"));
            Ddo_br_encounter_encid_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Includedatalist"));
            Ddo_br_encounter_encid_Sortasc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Sortasc");
            Ddo_br_encounter_encid_Sortdsc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Sortdsc");
            Ddo_br_encounter_encid_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Searchbuttontext");
            Ddo_br_encounter_enctype_Caption = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Caption");
            Ddo_br_encounter_enctype_Tooltip = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Tooltip");
            Ddo_br_encounter_enctype_Cls = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Cls");
            Ddo_br_encounter_enctype_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Dropdownoptionstype");
            Ddo_br_encounter_enctype_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Titlecontrolidtoreplace");
            Ddo_br_encounter_enctype_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Includesortasc"));
            Ddo_br_encounter_enctype_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Includesortdsc"));
            Ddo_br_encounter_enctype_Sortedstatus = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Sortedstatus");
            Ddo_br_encounter_enctype_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Includefilter"));
            Ddo_br_encounter_enctype_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Includedatalist"));
            Ddo_br_encounter_enctype_Sortasc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Sortasc");
            Ddo_br_encounter_enctype_Sortdsc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Sortdsc");
            Ddo_br_encounter_enctype_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Searchbuttontext");
            Ddo_br_encounter_departmentadm_Caption = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Caption");
            Ddo_br_encounter_departmentadm_Tooltip = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Tooltip");
            Ddo_br_encounter_departmentadm_Cls = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Cls");
            Ddo_br_encounter_departmentadm_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Filteredtext_set");
            Ddo_br_encounter_departmentadm_Selectedvalue_set = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Selectedvalue_set");
            Ddo_br_encounter_departmentadm_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Dropdownoptionstype");
            Ddo_br_encounter_departmentadm_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Titlecontrolidtoreplace");
            Ddo_br_encounter_departmentadm_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Includesortasc"));
            Ddo_br_encounter_departmentadm_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Includesortdsc"));
            Ddo_br_encounter_departmentadm_Sortedstatus = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Sortedstatus");
            Ddo_br_encounter_departmentadm_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Includefilter"));
            Ddo_br_encounter_departmentadm_Filtertype = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Filtertype");
            Ddo_br_encounter_departmentadm_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Filterisrange"));
            Ddo_br_encounter_departmentadm_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Includedatalist"));
            Ddo_br_encounter_departmentadm_Datalisttype = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Datalisttype");
            Ddo_br_encounter_departmentadm_Datalistproc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Datalistproc");
            Ddo_br_encounter_departmentadm_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_encounter_departmentadm_Sortasc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Sortasc");
            Ddo_br_encounter_departmentadm_Sortdsc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Sortdsc");
            Ddo_br_encounter_departmentadm_Loadingdata = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Loadingdata");
            Ddo_br_encounter_departmentadm_Cleanfilter = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Cleanfilter");
            Ddo_br_encounter_departmentadm_Noresultsfound = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Noresultsfound");
            Ddo_br_encounter_departmentadm_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Searchbuttontext");
            Ddo_br_encounter_departmentdisch_Caption = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Caption");
            Ddo_br_encounter_departmentdisch_Tooltip = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Tooltip");
            Ddo_br_encounter_departmentdisch_Cls = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Cls");
            Ddo_br_encounter_departmentdisch_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Filteredtext_set");
            Ddo_br_encounter_departmentdisch_Selectedvalue_set = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Selectedvalue_set");
            Ddo_br_encounter_departmentdisch_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Dropdownoptionstype");
            Ddo_br_encounter_departmentdisch_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Titlecontrolidtoreplace");
            Ddo_br_encounter_departmentdisch_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Includesortasc"));
            Ddo_br_encounter_departmentdisch_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Includesortdsc"));
            Ddo_br_encounter_departmentdisch_Sortedstatus = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Sortedstatus");
            Ddo_br_encounter_departmentdisch_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Includefilter"));
            Ddo_br_encounter_departmentdisch_Filtertype = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Filtertype");
            Ddo_br_encounter_departmentdisch_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Filterisrange"));
            Ddo_br_encounter_departmentdisch_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Includedatalist"));
            Ddo_br_encounter_departmentdisch_Datalisttype = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Datalisttype");
            Ddo_br_encounter_departmentdisch_Datalistproc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Datalistproc");
            Ddo_br_encounter_departmentdisch_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_encounter_departmentdisch_Sortasc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Sortasc");
            Ddo_br_encounter_departmentdisch_Sortdsc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Sortdsc");
            Ddo_br_encounter_departmentdisch_Loadingdata = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Loadingdata");
            Ddo_br_encounter_departmentdisch_Cleanfilter = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Cleanfilter");
            Ddo_br_encounter_departmentdisch_Noresultsfound = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Noresultsfound");
            Ddo_br_encounter_departmentdisch_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Searchbuttontext");
            Ddo_br_encounter_admitdate_Caption = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Caption");
            Ddo_br_encounter_admitdate_Tooltip = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Tooltip");
            Ddo_br_encounter_admitdate_Cls = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Cls");
            Ddo_br_encounter_admitdate_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Dropdownoptionstype");
            Ddo_br_encounter_admitdate_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Titlecontrolidtoreplace");
            Ddo_br_encounter_admitdate_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Includesortasc"));
            Ddo_br_encounter_admitdate_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Includesortdsc"));
            Ddo_br_encounter_admitdate_Sortedstatus = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Sortedstatus");
            Ddo_br_encounter_admitdate_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Includefilter"));
            Ddo_br_encounter_admitdate_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Includedatalist"));
            Ddo_br_encounter_admitdate_Sortasc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Sortasc");
            Ddo_br_encounter_admitdate_Sortdsc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Sortdsc");
            Ddo_br_encounter_admitdate_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Searchbuttontext");
            Ddo_br_encounter_status_Caption = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Caption");
            Ddo_br_encounter_status_Tooltip = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Tooltip");
            Ddo_br_encounter_status_Cls = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Cls");
            Ddo_br_encounter_status_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Dropdownoptionstype");
            Ddo_br_encounter_status_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Titlecontrolidtoreplace");
            Ddo_br_encounter_status_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Includesortasc"));
            Ddo_br_encounter_status_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Includesortdsc"));
            Ddo_br_encounter_status_Sortedstatus = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Sortedstatus");
            Ddo_br_encounter_status_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Includefilter"));
            Ddo_br_encounter_status_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Includedatalist"));
            Ddo_br_encounter_status_Sortasc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Sortasc");
            Ddo_br_encounter_status_Sortdsc = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Sortdsc");
            Ddo_br_encounter_status_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_encounterid_Activeeventkey = cgiGet( sPrefix+"DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_encounter_encid_Activeeventkey = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCID_Activeeventkey");
            Ddo_br_encounter_enctype_Activeeventkey = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey");
            Ddo_br_encounter_departmentadm_Activeeventkey = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Activeeventkey");
            Ddo_br_encounter_departmentadm_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Filteredtext_get");
            Ddo_br_encounter_departmentadm_Selectedvalue_get = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM_Selectedvalue_get");
            Ddo_br_encounter_departmentdisch_Activeeventkey = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Activeeventkey");
            Ddo_br_encounter_departmentdisch_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Filteredtext_get");
            Ddo_br_encounter_departmentdisch_Selectedvalue_get = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH_Selectedvalue_get");
            Ddo_br_encounter_admitdate_Activeeventkey = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey");
            Ddo_br_encounter_status_Activeeventkey = cgiGet( sPrefix+"DDO_BR_ENCOUNTER_STATUS_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vBR_ENCOUNTERID"), AV76BR_EncounterID) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTADM"), AV81TFBR_Encounter_Departmentadm) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTADM_SEL"), AV82TFBR_Encounter_Departmentadm_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTDISCH"), AV85TFBR_Encounter_Departmentdisch) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL"), AV86TFBR_Encounter_Departmentdisch_Sel) != 0 )
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
         E224B2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E224B2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_encounter_departmentadm_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_encounter_departmentadm_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_departmentadm_Visible), 5, 0)), true);
         edtavTfbr_encounter_departmentadm_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_encounter_departmentadm_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_departmentadm_sel_Visible), 5, 0)), true);
         edtavTfbr_encounter_departmentdisch_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_encounter_departmentdisch_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_departmentdisch_Visible), 5, 0)), true);
         edtavTfbr_encounter_departmentdisch_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_encounter_departmentdisch_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_departmentdisch_sel_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, sPrefix, false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV56ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV56ddo_BR_EncounterIDTitleControlIdToReplace", AV56ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_encid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_EncID";
         ucDdo_br_encounter_encid.SendProperty(context, sPrefix, false, Ddo_br_encounter_encid_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_encid_Titlecontrolidtoreplace);
         AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace = Ddo_br_encounter_encid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace", AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace);
         edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_enctype_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_ENCType";
         ucDdo_br_encounter_enctype.SendProperty(context, sPrefix, false, Ddo_br_encounter_enctype_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_enctype_Titlecontrolidtoreplace);
         AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = Ddo_br_encounter_enctype_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace", AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace);
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_departmentadm_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_Departmentadm";
         ucDdo_br_encounter_departmentadm.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentadm_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_departmentadm_Titlecontrolidtoreplace);
         AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace = Ddo_br_encounter_departmentadm_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace", AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace);
         edtavDdo_br_encounter_departmentadmtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_encounter_departmentadmtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_departmentadmtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_departmentdisch_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_Departmentdisch";
         ucDdo_br_encounter_departmentdisch.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentdisch_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_departmentdisch_Titlecontrolidtoreplace);
         AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace = Ddo_br_encounter_departmentdisch_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace", AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace);
         edtavDdo_br_encounter_departmentdischtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_encounter_departmentdischtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_departmentdischtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_admitdate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_AdmitDate";
         ucDdo_br_encounter_admitdate.SendProperty(context, sPrefix, false, Ddo_br_encounter_admitdate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_admitdate_Titlecontrolidtoreplace);
         AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = Ddo_br_encounter_admitdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace", AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace);
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_status_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_Status";
         ucDdo_br_encounter_status.SendProperty(context, sPrefix, false, Ddo_br_encounter_status_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_status_Titlecontrolidtoreplace);
         AV74ddo_BR_Encounter_StatusTitleControlIdToReplace = Ddo_br_encounter_status_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV74ddo_BR_Encounter_StatusTitleControlIdToReplace", AV74ddo_BR_Encounter_StatusTitleControlIdToReplace);
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible), 5, 0)), true);
         edtBR_Information_ID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Information_ID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_ID_Visible), 5, 0)), true);
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
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV14OrderedBy < 1 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV41DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV41DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E234B2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         GXt_char2 = AV77tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char2) ;
         AV77tCurrentCode = GXt_char2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV77tCurrentCode", AV77tCurrentCode);
         AV53BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Encounter_EncIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV58BR_Encounter_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV80BR_Encounter_DepartmentadmTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV84BR_Encounter_DepartmentdischTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Encounter_AdmitDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV71BR_Encounter_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊序号", AV56ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_27_Refreshing);
         edtBR_Encounter_EncID_Titleformat = 2;
         edtBR_Encounter_EncID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊次序", AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_EncID_Internalname, "Title", edtBR_Encounter_EncID_Title, !bGXsfl_27_Refreshing);
         edtBR_Encounter_ENCType_Titleformat = 2;
         edtBR_Encounter_ENCType_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊方式", AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_ENCType_Internalname, "Title", edtBR_Encounter_ENCType_Title, !bGXsfl_27_Refreshing);
         edtBR_Encounter_Departmentadm_Titleformat = 2;
         edtBR_Encounter_Departmentadm_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊入院科室", AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_Departmentadm_Internalname, "Title", edtBR_Encounter_Departmentadm_Title, !bGXsfl_27_Refreshing);
         edtBR_Encounter_Departmentdisch_Titleformat = 2;
         edtBR_Encounter_Departmentdisch_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊出院科室", AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_Departmentdisch_Internalname, "Title", edtBR_Encounter_Departmentdisch_Title, !bGXsfl_27_Refreshing);
         edtBR_Encounter_AdmitDate_Titleformat = 2;
         edtBR_Encounter_AdmitDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊/入院时间", AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_AdmitDate_Internalname, "Title", edtBR_Encounter_AdmitDate_Title, !bGXsfl_27_Refreshing);
         cmbBR_Encounter_Status_Titleformat = 2;
         cmbBR_Encounter_Status.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "审批状态", AV74ddo_BR_Encounter_StatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Encounter_Status_Internalname, "Title", cmbBR_Encounter_Status.Title.Text, !bGXsfl_27_Refreshing);
         AV44GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV44GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44GridCurrentPage), 10, 0)));
         AV88GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV88GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV88GridPageCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV53BR_EncounterIDTitleFilterData", AV53BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV58BR_Encounter_ENCTypeTitleFilterData", AV58BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV80BR_Encounter_DepartmentadmTitleFilterData", AV80BR_Encounter_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV84BR_Encounter_DepartmentdischTitleFilterData", AV84BR_Encounter_DepartmentdischTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Encounter_AdmitDateTitleFilterData", AV21BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV71BR_Encounter_StatusTitleFilterData", AV71BR_Encounter_StatusTitleFilterData);
      }

      protected void E114B2( )
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
            AV43PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV43PageToGo) ;
         }
      }

      protected void E124B2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E134B2( )
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
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, sPrefix, false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
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
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, sPrefix, false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV53BR_EncounterIDTitleFilterData", AV53BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV58BR_Encounter_ENCTypeTitleFilterData", AV58BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV80BR_Encounter_DepartmentadmTitleFilterData", AV80BR_Encounter_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV84BR_Encounter_DepartmentdischTitleFilterData", AV84BR_Encounter_DepartmentdischTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Encounter_AdmitDateTitleFilterData", AV21BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV71BR_Encounter_StatusTitleFilterData", AV71BR_Encounter_StatusTitleFilterData);
      }

      protected void E144B2( )
      {
         /* Ddo_br_encounter_encid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_encid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_encid_Sortedstatus = "ASC";
            ucDdo_br_encounter_encid.SendProperty(context, sPrefix, false, Ddo_br_encounter_encid_Internalname, "SortedStatus", Ddo_br_encounter_encid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_encid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_encid_Sortedstatus = "DSC";
            ucDdo_br_encounter_encid.SendProperty(context, sPrefix, false, Ddo_br_encounter_encid_Internalname, "SortedStatus", Ddo_br_encounter_encid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV53BR_EncounterIDTitleFilterData", AV53BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV58BR_Encounter_ENCTypeTitleFilterData", AV58BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV80BR_Encounter_DepartmentadmTitleFilterData", AV80BR_Encounter_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV84BR_Encounter_DepartmentdischTitleFilterData", AV84BR_Encounter_DepartmentdischTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Encounter_AdmitDateTitleFilterData", AV21BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV71BR_Encounter_StatusTitleFilterData", AV71BR_Encounter_StatusTitleFilterData);
      }

      protected void E154B2( )
      {
         /* Ddo_br_encounter_enctype_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_enctype_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_enctype_Sortedstatus = "ASC";
            ucDdo_br_encounter_enctype.SendProperty(context, sPrefix, false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_enctype_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_enctype_Sortedstatus = "DSC";
            ucDdo_br_encounter_enctype.SendProperty(context, sPrefix, false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV53BR_EncounterIDTitleFilterData", AV53BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV58BR_Encounter_ENCTypeTitleFilterData", AV58BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV80BR_Encounter_DepartmentadmTitleFilterData", AV80BR_Encounter_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV84BR_Encounter_DepartmentdischTitleFilterData", AV84BR_Encounter_DepartmentdischTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Encounter_AdmitDateTitleFilterData", AV21BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV71BR_Encounter_StatusTitleFilterData", AV71BR_Encounter_StatusTitleFilterData);
      }

      protected void E164B2( )
      {
         /* Ddo_br_encounter_departmentadm_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_departmentadm_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_departmentadm_Sortedstatus = "ASC";
            ucDdo_br_encounter_departmentadm.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentadm_Internalname, "SortedStatus", Ddo_br_encounter_departmentadm_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_departmentadm_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_departmentadm_Sortedstatus = "DSC";
            ucDdo_br_encounter_departmentadm.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentadm_Internalname, "SortedStatus", Ddo_br_encounter_departmentadm_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_departmentadm_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV81TFBR_Encounter_Departmentadm = Ddo_br_encounter_departmentadm_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV81TFBR_Encounter_Departmentadm", AV81TFBR_Encounter_Departmentadm);
            AV82TFBR_Encounter_Departmentadm_Sel = Ddo_br_encounter_departmentadm_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV82TFBR_Encounter_Departmentadm_Sel", AV82TFBR_Encounter_Departmentadm_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV53BR_EncounterIDTitleFilterData", AV53BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV58BR_Encounter_ENCTypeTitleFilterData", AV58BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV80BR_Encounter_DepartmentadmTitleFilterData", AV80BR_Encounter_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV84BR_Encounter_DepartmentdischTitleFilterData", AV84BR_Encounter_DepartmentdischTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Encounter_AdmitDateTitleFilterData", AV21BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV71BR_Encounter_StatusTitleFilterData", AV71BR_Encounter_StatusTitleFilterData);
      }

      protected void E174B2( )
      {
         /* Ddo_br_encounter_departmentdisch_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_departmentdisch_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_departmentdisch_Sortedstatus = "ASC";
            ucDdo_br_encounter_departmentdisch.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentdisch_Internalname, "SortedStatus", Ddo_br_encounter_departmentdisch_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_departmentdisch_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_departmentdisch_Sortedstatus = "DSC";
            ucDdo_br_encounter_departmentdisch.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentdisch_Internalname, "SortedStatus", Ddo_br_encounter_departmentdisch_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_departmentdisch_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV85TFBR_Encounter_Departmentdisch = Ddo_br_encounter_departmentdisch_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV85TFBR_Encounter_Departmentdisch", AV85TFBR_Encounter_Departmentdisch);
            AV86TFBR_Encounter_Departmentdisch_Sel = Ddo_br_encounter_departmentdisch_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV86TFBR_Encounter_Departmentdisch_Sel", AV86TFBR_Encounter_Departmentdisch_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV53BR_EncounterIDTitleFilterData", AV53BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV58BR_Encounter_ENCTypeTitleFilterData", AV58BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV80BR_Encounter_DepartmentadmTitleFilterData", AV80BR_Encounter_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV84BR_Encounter_DepartmentdischTitleFilterData", AV84BR_Encounter_DepartmentdischTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Encounter_AdmitDateTitleFilterData", AV21BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV71BR_Encounter_StatusTitleFilterData", AV71BR_Encounter_StatusTitleFilterData);
      }

      protected void E184B2( )
      {
         /* Ddo_br_encounter_admitdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_admitdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_admitdate_Sortedstatus = "ASC";
            ucDdo_br_encounter_admitdate.SendProperty(context, sPrefix, false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_admitdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_admitdate_Sortedstatus = "DSC";
            ucDdo_br_encounter_admitdate.SendProperty(context, sPrefix, false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV53BR_EncounterIDTitleFilterData", AV53BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV58BR_Encounter_ENCTypeTitleFilterData", AV58BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV80BR_Encounter_DepartmentadmTitleFilterData", AV80BR_Encounter_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV84BR_Encounter_DepartmentdischTitleFilterData", AV84BR_Encounter_DepartmentdischTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Encounter_AdmitDateTitleFilterData", AV21BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV71BR_Encounter_StatusTitleFilterData", AV71BR_Encounter_StatusTitleFilterData);
      }

      protected void E194B2( )
      {
         /* Ddo_br_encounter_status_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_status_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_status_Sortedstatus = "ASC";
            ucDdo_br_encounter_status.SendProperty(context, sPrefix, false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_status_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_encounter_status_Sortedstatus = "DSC";
            ucDdo_br_encounter_status.SendProperty(context, sPrefix, false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV53BR_EncounterIDTitleFilterData", AV53BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV58BR_Encounter_ENCTypeTitleFilterData", AV58BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV80BR_Encounter_DepartmentadmTitleFilterData", AV80BR_Encounter_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV84BR_Encounter_DepartmentdischTitleFilterData", AV84BR_Encounter_DepartmentdischTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Encounter_AdmitDateTitleFilterData", AV21BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV71BR_Encounter_StatusTitleFilterData", AV71BR_Encounter_StatusTitleFilterData);
      }

      private void E244B2( )
      {
         /* Grid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 27;
         }
         sendrow_272( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_27_Refreshing )
         {
            context.DoAjaxLoad(27, GridRow);
         }
      }

      protected void E204B2( )
      {
         /* 'DoInsert' Routine */
         if ( 1 == 0 )
         {
            CallWebObject(formatLink("br_encounter.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
            context.wjLocDisableFrm = 1;
         }
         CallWebObject(formatLink("br_encounterinsert.aspx") + "?" + UrlEncode("" +AV8BR_Information_ID));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_encounterid_Sortedstatus = "";
         ucDdo_br_encounterid.SendProperty(context, sPrefix, false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         Ddo_br_encounter_encid_Sortedstatus = "";
         ucDdo_br_encounter_encid.SendProperty(context, sPrefix, false, Ddo_br_encounter_encid_Internalname, "SortedStatus", Ddo_br_encounter_encid_Sortedstatus);
         Ddo_br_encounter_enctype_Sortedstatus = "";
         ucDdo_br_encounter_enctype.SendProperty(context, sPrefix, false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
         Ddo_br_encounter_departmentadm_Sortedstatus = "";
         ucDdo_br_encounter_departmentadm.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentadm_Internalname, "SortedStatus", Ddo_br_encounter_departmentadm_Sortedstatus);
         Ddo_br_encounter_departmentdisch_Sortedstatus = "";
         ucDdo_br_encounter_departmentdisch.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentdisch_Internalname, "SortedStatus", Ddo_br_encounter_departmentdisch_Sortedstatus);
         Ddo_br_encounter_admitdate_Sortedstatus = "";
         ucDdo_br_encounter_admitdate.SendProperty(context, sPrefix, false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
         Ddo_br_encounter_status_Sortedstatus = "";
         ucDdo_br_encounter_status.SendProperty(context, sPrefix, false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
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
         if ( AV14OrderedBy == 1 )
         {
            Ddo_br_encounterid_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounterid.SendProperty(context, sPrefix, false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         }
         else if ( AV14OrderedBy == 2 )
         {
            Ddo_br_encounter_encid_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_encid.SendProperty(context, sPrefix, false, Ddo_br_encounter_encid_Internalname, "SortedStatus", Ddo_br_encounter_encid_Sortedstatus);
         }
         else if ( AV14OrderedBy == 3 )
         {
            Ddo_br_encounter_enctype_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_enctype.SendProperty(context, sPrefix, false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
         }
         else if ( AV14OrderedBy == 4 )
         {
            Ddo_br_encounter_departmentadm_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_departmentadm.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentadm_Internalname, "SortedStatus", Ddo_br_encounter_departmentadm_Sortedstatus);
         }
         else if ( AV14OrderedBy == 5 )
         {
            Ddo_br_encounter_departmentdisch_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_departmentdisch.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentdisch_Internalname, "SortedStatus", Ddo_br_encounter_departmentdisch_Sortedstatus);
         }
         else if ( AV14OrderedBy == 6 )
         {
            Ddo_br_encounter_admitdate_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_admitdate.SendProperty(context, sPrefix, false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
         }
         else if ( AV14OrderedBy == 7 )
         {
            Ddo_br_encounter_status_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_status.SendProperty(context, sPrefix, false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean3 = AV52TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Encounter", out  GXt_boolean3) ;
         AV52TempBoolean = GXt_boolean3;
         if ( ! ( AV52TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV91Pgmname+"GridState"), "") == 0 )
         {
            AV12GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV91Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV12GridState.FromXml(AV16Session.Get(AV91Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV14OrderedBy = AV12GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
         AV15OrderedDsc = AV12GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV92GXV1 = 1;
         while ( AV92GXV1 <= AV12GridState.gxTpr_Filtervalues.Count )
         {
            AV13GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV12GridState.gxTpr_Filtervalues.Item(AV92GXV1));
            if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "BR_ENCOUNTERID") == 0 )
            {
               AV76BR_EncounterID = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV76BR_EncounterID", AV76BR_EncounterID);
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_DEPARTMENTADM") == 0 )
            {
               AV81TFBR_Encounter_Departmentadm = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV81TFBR_Encounter_Departmentadm", AV81TFBR_Encounter_Departmentadm);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81TFBR_Encounter_Departmentadm)) )
               {
                  Ddo_br_encounter_departmentadm_Filteredtext_set = AV81TFBR_Encounter_Departmentadm;
                  ucDdo_br_encounter_departmentadm.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentadm_Internalname, "FilteredText_set", Ddo_br_encounter_departmentadm_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_DEPARTMENTADM_SEL") == 0 )
            {
               AV82TFBR_Encounter_Departmentadm_Sel = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV82TFBR_Encounter_Departmentadm_Sel", AV82TFBR_Encounter_Departmentadm_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82TFBR_Encounter_Departmentadm_Sel)) )
               {
                  Ddo_br_encounter_departmentadm_Selectedvalue_set = AV82TFBR_Encounter_Departmentadm_Sel;
                  ucDdo_br_encounter_departmentadm.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentadm_Internalname, "SelectedValue_set", Ddo_br_encounter_departmentadm_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_DEPARTMENTDISCH") == 0 )
            {
               AV85TFBR_Encounter_Departmentdisch = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV85TFBR_Encounter_Departmentdisch", AV85TFBR_Encounter_Departmentdisch);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85TFBR_Encounter_Departmentdisch)) )
               {
                  Ddo_br_encounter_departmentdisch_Filteredtext_set = AV85TFBR_Encounter_Departmentdisch;
                  ucDdo_br_encounter_departmentdisch.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentdisch_Internalname, "FilteredText_set", Ddo_br_encounter_departmentdisch_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_DEPARTMENTDISCH_SEL") == 0 )
            {
               AV86TFBR_Encounter_Departmentdisch_Sel = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV86TFBR_Encounter_Departmentdisch_Sel", AV86TFBR_Encounter_Departmentdisch_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86TFBR_Encounter_Departmentdisch_Sel)) )
               {
                  Ddo_br_encounter_departmentdisch_Selectedvalue_set = AV86TFBR_Encounter_Departmentdisch_Sel;
                  ucDdo_br_encounter_departmentdisch.SendProperty(context, sPrefix, false, Ddo_br_encounter_departmentdisch_Internalname, "SelectedValue_set", Ddo_br_encounter_departmentdisch_Selectedvalue_set);
               }
            }
            AV92GXV1 = (int)(AV92GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV12GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV12GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV12GridState.FromXml(AV16Session.Get(AV91Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV12GridState.gxTpr_Orderedby = AV14OrderedBy;
         AV12GridState.gxTpr_Ordereddsc = AV15OrderedDsc;
         AV12GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_EncounterID)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "BR_ENCOUNTERID";
            AV13GridStateFilterValue.gxTpr_Value = AV76BR_EncounterID;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81TFBR_Encounter_Departmentadm)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_DEPARTMENTADM";
            AV13GridStateFilterValue.gxTpr_Value = AV81TFBR_Encounter_Departmentadm;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82TFBR_Encounter_Departmentadm_Sel)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_DEPARTMENTADM_SEL";
            AV13GridStateFilterValue.gxTpr_Value = AV82TFBR_Encounter_Departmentadm_Sel;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85TFBR_Encounter_Departmentdisch)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_DEPARTMENTDISCH";
            AV13GridStateFilterValue.gxTpr_Value = AV85TFBR_Encounter_Departmentdisch;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86TFBR_Encounter_Departmentdisch_Sel)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_DEPARTMENTDISCH_SEL";
            AV13GridStateFilterValue.gxTpr_Value = AV86TFBR_Encounter_Departmentdisch_Sel;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! (0==AV8BR_Information_ID) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "PARM_&BR_INFORMATION_ID";
            AV13GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0);
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         AV12GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV91Pgmname+"GridState",  AV12GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV91Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "BR_Encounter";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "BR_Information_ID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV16Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void E214B2( )
      {
         /* Br_encounterid_Controlvaluechanging Routine */
         context.DoAjaxRefreshCmp(sPrefix);
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV53BR_EncounterIDTitleFilterData", AV53BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV58BR_Encounter_ENCTypeTitleFilterData", AV58BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV80BR_Encounter_DepartmentadmTitleFilterData", AV80BR_Encounter_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV84BR_Encounter_DepartmentdischTitleFilterData", AV84BR_Encounter_DepartmentdischTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Encounter_AdmitDateTitleFilterData", AV21BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV71BR_Encounter_StatusTitleFilterData", AV71BR_Encounter_StatusTitleFilterData);
      }

      protected void E254B2( )
      {
         /* BR_EncounterID_Click Routine */
         AV51WebSession.Set("Br_EncounterReturnPage", "br_information");
         AV51WebSession.Remove("Permisstion_Update");
         AV75IsInsert = false;
         GXt_boolean3 = AV75IsInsert;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_CRC", out  GXt_boolean3) ;
         AV75IsInsert = GXt_boolean3;
         if ( AV75IsInsert )
         {
            if ( A172BR_Encounter_Status == 1 )
            {
               CallWebObject(formatLink("br_encounterupdate.aspx") + "?" + UrlEncode("" +A19BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim("BR_Encounter")));
               context.wjLocDisableFrm = 1;
            }
            else
            {
               CallWebObject(formatLink("br_encountercheck.aspx") + "?" + UrlEncode("" +A19BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim("General")));
               context.wjLocDisableFrm = 1;
            }
         }
         else
         {
            CallWebObject(formatLink("br_encountercheck.aspx") + "?" + UrlEncode("" +A19BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim("General")));
            context.wjLocDisableFrm = 1;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8BR_Information_ID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0)));
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
         PA4B2( ) ;
         WS4B2( ) ;
         WE4B2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV8BR_Information_ID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA4B2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encountertab", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA4B2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV8BR_Information_ID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0)));
         }
         wcpOAV8BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_Information_ID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( AV8BR_Information_ID != wcpOAV8BR_Information_ID ) ) )
         {
            setjustcreated();
         }
         wcpOAV8BR_Information_ID = AV8BR_Information_ID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV8BR_Information_ID = cgiGet( sPrefix+"AV8BR_Information_ID_CTRL");
         if ( StringUtil.Len( sCtrlAV8BR_Information_ID) > 0 )
         {
            AV8BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( sCtrlAV8BR_Information_ID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0)));
         }
         else
         {
            AV8BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"AV8BR_Information_ID_PARM"), ".", ","));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA4B2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS4B2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS4B2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_Information_ID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_Information_ID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8BR_Information_ID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_Information_ID_CTRL", StringUtil.RTrim( sCtrlAV8BR_Information_ID));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE4B2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228157539", true);
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
         context.AddJavascriptSource("br_encountertab.js", "?2020228157540", false);
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

      protected void SubsflControlProps_272( )
      {
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID_"+sGXsfl_27_idx;
         edtBR_Encounter_EncID_Internalname = sPrefix+"BR_ENCOUNTER_ENCID_"+sGXsfl_27_idx;
         edtBR_Encounter_ENCType_Internalname = sPrefix+"BR_ENCOUNTER_ENCTYPE_"+sGXsfl_27_idx;
         edtBR_Encounter_Departmentadm_Internalname = sPrefix+"BR_ENCOUNTER_DEPARTMENTADM_"+sGXsfl_27_idx;
         edtBR_Encounter_Departmentdisch_Internalname = sPrefix+"BR_ENCOUNTER_DEPARTMENTDISCH_"+sGXsfl_27_idx;
         edtBR_Encounter_AdmitDate_Internalname = sPrefix+"BR_ENCOUNTER_ADMITDATE_"+sGXsfl_27_idx;
         edtBR_Encounter_AdmitSource_Internalname = sPrefix+"BR_ENCOUNTER_ADMITSOURCE_"+sGXsfl_27_idx;
         cmbBR_Encounter_Status_Internalname = sPrefix+"BR_ENCOUNTER_STATUS_"+sGXsfl_27_idx;
         edtBAS_TenantTenantCode_Internalname = sPrefix+"BAS_TENANTTENANTCODE_"+sGXsfl_27_idx;
      }

      protected void SubsflControlProps_fel_272( )
      {
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID_"+sGXsfl_27_fel_idx;
         edtBR_Encounter_EncID_Internalname = sPrefix+"BR_ENCOUNTER_ENCID_"+sGXsfl_27_fel_idx;
         edtBR_Encounter_ENCType_Internalname = sPrefix+"BR_ENCOUNTER_ENCTYPE_"+sGXsfl_27_fel_idx;
         edtBR_Encounter_Departmentadm_Internalname = sPrefix+"BR_ENCOUNTER_DEPARTMENTADM_"+sGXsfl_27_fel_idx;
         edtBR_Encounter_Departmentdisch_Internalname = sPrefix+"BR_ENCOUNTER_DEPARTMENTDISCH_"+sGXsfl_27_fel_idx;
         edtBR_Encounter_AdmitDate_Internalname = sPrefix+"BR_ENCOUNTER_ADMITDATE_"+sGXsfl_27_fel_idx;
         edtBR_Encounter_AdmitSource_Internalname = sPrefix+"BR_ENCOUNTER_ADMITSOURCE_"+sGXsfl_27_fel_idx;
         cmbBR_Encounter_Status_Internalname = sPrefix+"BR_ENCOUNTER_STATUS_"+sGXsfl_27_fel_idx;
         edtBAS_TenantTenantCode_Internalname = sPrefix+"BAS_TENANTTENANTCODE_"+sGXsfl_27_fel_idx;
      }

      protected void sendrow_272( )
      {
         SubsflControlProps_272( ) ;
         WB4B0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_27_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_27_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_27_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"","'"+sPrefix+"'"+",false,"+"'"+sPrefix+"EBR_ENCOUNTERID.CLICK."+sGXsfl_27_idx+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)5,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)27,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_EncID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A35BR_Encounter_EncID), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A35BR_Encounter_EncID), "ZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_EncID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)27,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_ENCType_Internalname,(String)A90BR_Encounter_ENCType,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_ENCType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm hidden-md",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)27,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_Departmentadm_Internalname,(String)A570BR_Encounter_Departmentadm,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_Departmentadm_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)27,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_Departmentdisch_Internalname,(String)A572BR_Encounter_Departmentdisch,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_Departmentdisch_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)27,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_AdmitDate_Internalname,context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"),context.localUtil.Format( A91BR_Encounter_AdmitDate, "9999/99/99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_AdmitDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm hidden-md",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)27,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_AdmitSource_Internalname,(String)A92BR_Encounter_AdmitSource,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_AdmitSource_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)27,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Encounter_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_ENCOUNTER_STATUS_" + sGXsfl_27_idx;
               cmbBR_Encounter_Status.Name = GXCCtl;
               cmbBR_Encounter_Status.WebTags = "";
               cmbBR_Encounter_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
               cmbBR_Encounter_Status.addItem("1", "录入中", 0);
               cmbBR_Encounter_Status.addItem("2", "待初审", 0);
               cmbBR_Encounter_Status.addItem("3", "初审不通过", 0);
               cmbBR_Encounter_Status.addItem("4", "待复审", 0);
               cmbBR_Encounter_Status.addItem("5", "复审不通过", 0);
               cmbBR_Encounter_Status.addItem("6", "完成", 0);
               if ( cmbBR_Encounter_Status.ItemCount > 0 )
               {
                  A172BR_Encounter_Status = (short)(NumberUtil.Val( cmbBR_Encounter_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0))), "."));
                  n172BR_Encounter_Status = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Encounter_Status,(String)cmbBR_Encounter_Status_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)),(short)1,(String)cmbBR_Encounter_Status_Jsonclick,(short)0,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Encounter_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Encounter_Status_Internalname, "Values", (String)(cmbBR_Encounter_Status.ToJavascriptSource()), !bGXsfl_27_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBAS_TenantTenantCode_Internalname,(String)A360BAS_TenantTenantCode,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBAS_TenantTenantCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)27,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes4B2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_27_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_27_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_27_idx+1));
            sGXsfl_27_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_27_idx), 4, 0)), 4, "0");
            SubsflControlProps_272( ) ;
         }
         /* End function sendrow_272 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_ENCOUNTER_STATUS_" + sGXsfl_27_idx;
         cmbBR_Encounter_Status.Name = GXCCtl;
         cmbBR_Encounter_Status.WebTags = "";
         cmbBR_Encounter_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
         cmbBR_Encounter_Status.addItem("1", "录入中", 0);
         cmbBR_Encounter_Status.addItem("2", "待初审", 0);
         cmbBR_Encounter_Status.addItem("3", "初审不通过", 0);
         cmbBR_Encounter_Status.addItem("4", "待复审", 0);
         cmbBR_Encounter_Status.addItem("5", "复审不通过", 0);
         cmbBR_Encounter_Status.addItem("6", "完成", 0);
         if ( cmbBR_Encounter_Status.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = sPrefix+"BTNINSERT";
         edtavBr_encounterid_Internalname = sPrefix+"vBR_ENCOUNTERID";
         divUnnamedtable2_Internalname = sPrefix+"UNNAMEDTABLE2";
         divLayout_unnamedtable2_Internalname = sPrefix+"LAYOUT_UNNAMEDTABLE2";
         Dvpanel_unnamedtable2_Internalname = sPrefix+"DVPANEL_UNNAMEDTABLE2";
         divHtml_dvpanel_unnamedtable2_Internalname = sPrefix+"HTML_DVPANEL_UNNAMEDTABLE2";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         edtBR_Encounter_EncID_Internalname = sPrefix+"BR_ENCOUNTER_ENCID";
         edtBR_Encounter_ENCType_Internalname = sPrefix+"BR_ENCOUNTER_ENCTYPE";
         edtBR_Encounter_Departmentadm_Internalname = sPrefix+"BR_ENCOUNTER_DEPARTMENTADM";
         edtBR_Encounter_Departmentdisch_Internalname = sPrefix+"BR_ENCOUNTER_DEPARTMENTDISCH";
         edtBR_Encounter_AdmitDate_Internalname = sPrefix+"BR_ENCOUNTER_ADMITDATE";
         edtBR_Encounter_AdmitSource_Internalname = sPrefix+"BR_ENCOUNTER_ADMITSOURCE";
         cmbBR_Encounter_Status_Internalname = sPrefix+"BR_ENCOUNTER_STATUS";
         edtBAS_TenantTenantCode_Internalname = sPrefix+"BAS_TENANTTENANTCODE";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divUnnamedtable1_Internalname = sPrefix+"UNNAMEDTABLE1";
         Ddo_br_encounterid_Internalname = sPrefix+"DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_encid_Internalname = sPrefix+"DDO_BR_ENCOUNTER_ENCID";
         edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_enctype_Internalname = sPrefix+"DDO_BR_ENCOUNTER_ENCTYPE";
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_departmentadm_Internalname = sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTADM";
         edtavDdo_br_encounter_departmentadmtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_departmentdisch_Internalname = sPrefix+"DDO_BR_ENCOUNTER_DEPARTMENTDISCH";
         edtavDdo_br_encounter_departmentdischtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_admitdate_Internalname = sPrefix+"DDO_BR_ENCOUNTER_ADMITDATE";
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_status_Internalname = sPrefix+"DDO_BR_ENCOUNTER_STATUS";
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE";
         edtBR_Information_ID_Internalname = sPrefix+"BR_INFORMATION_ID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         edtavTfbr_encounter_departmentadm_Internalname = sPrefix+"vTFBR_ENCOUNTER_DEPARTMENTADM";
         edtavTfbr_encounter_departmentadm_sel_Internalname = sPrefix+"vTFBR_ENCOUNTER_DEPARTMENTADM_SEL";
         edtavTfbr_encounter_departmentdisch_Internalname = sPrefix+"vTFBR_ENCOUNTER_DEPARTMENTDISCH";
         edtavTfbr_encounter_departmentdisch_sel_Internalname = sPrefix+"vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL";
         divHtml_bottomauxiliarcontrols_Internalname = sPrefix+"HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = sPrefix+"LAYOUTMAINTABLE";
         Form.Internalname = sPrefix+"FORM";
         subGrid_Internalname = sPrefix+"GRID";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtBAS_TenantTenantCode_Jsonclick = "";
         cmbBR_Encounter_Status_Jsonclick = "";
         edtBR_Encounter_AdmitSource_Jsonclick = "";
         edtBR_Encounter_AdmitDate_Jsonclick = "";
         edtBR_Encounter_Departmentdisch_Jsonclick = "";
         edtBR_Encounter_Departmentadm_Jsonclick = "";
         edtBR_Encounter_ENCType_Jsonclick = "";
         edtBR_Encounter_EncID_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtavTfbr_encounter_departmentdisch_sel_Jsonclick = "";
         edtavTfbr_encounter_departmentdisch_sel_Visible = 1;
         edtavTfbr_encounter_departmentdisch_Jsonclick = "";
         edtavTfbr_encounter_departmentdisch_Visible = 1;
         edtavTfbr_encounter_departmentadm_sel_Jsonclick = "";
         edtavTfbr_encounter_departmentadm_sel_Visible = 1;
         edtavTfbr_encounter_departmentadm_Jsonclick = "";
         edtavTfbr_encounter_departmentadm_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtBR_Information_ID_Jsonclick = "";
         edtBR_Information_ID_Visible = 1;
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_departmentdischtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_departmentadmtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         subGrid_Sortable = 0;
         subGrid_Header = "";
         cmbBR_Encounter_Status_Titleformat = 0;
         cmbBR_Encounter_Status.Title.Text = "审批状态";
         edtBR_Encounter_AdmitDate_Titleformat = 0;
         edtBR_Encounter_AdmitDate_Title = "就诊/入院时间";
         edtBR_Encounter_Departmentdisch_Titleformat = 0;
         edtBR_Encounter_Departmentdisch_Title = "就诊出院科室";
         edtBR_Encounter_Departmentadm_Titleformat = 0;
         edtBR_Encounter_Departmentadm_Title = "就诊入院科室";
         edtBR_Encounter_ENCType_Titleformat = 0;
         edtBR_Encounter_ENCType_Title = "就诊方式";
         edtBR_Encounter_EncID_Titleformat = 0;
         edtBR_Encounter_EncID_Title = "就诊次序";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊序号";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         edtavBr_encounterid_Jsonclick = "";
         edtavBr_encounterid_Enabled = 1;
         bttBtninsert_Visible = 1;
         Ddo_br_encounter_status_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_status_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_status_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_status_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_status_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_status_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_status_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_status_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_status_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_status_Cls = "ColumnSettings";
         Ddo_br_encounter_status_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_status_Caption = "";
         Ddo_br_encounter_admitdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_admitdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_admitdate_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_admitdate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_admitdate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_admitdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_admitdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_admitdate_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_admitdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_admitdate_Cls = "ColumnSettings";
         Ddo_br_encounter_admitdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_admitdate_Caption = "";
         Ddo_br_encounter_departmentdisch_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_departmentdisch_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_encounter_departmentdisch_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounter_departmentdisch_Loadingdata = "WWP_TSLoading";
         Ddo_br_encounter_departmentdisch_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_departmentdisch_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_departmentdisch_Datalistupdateminimumcharacters = 0;
         Ddo_br_encounter_departmentdisch_Datalistproc = "BR_EncounterTabGetFilterData";
         Ddo_br_encounter_departmentdisch_Datalisttype = "Dynamic";
         Ddo_br_encounter_departmentdisch_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_encounter_departmentdisch_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_encounter_departmentdisch_Filtertype = "Character";
         Ddo_br_encounter_departmentdisch_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounter_departmentdisch_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_departmentdisch_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_departmentdisch_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_departmentdisch_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_departmentdisch_Cls = "ColumnSettings";
         Ddo_br_encounter_departmentdisch_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_departmentdisch_Caption = "";
         Ddo_br_encounter_departmentadm_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_departmentadm_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_encounter_departmentadm_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounter_departmentadm_Loadingdata = "WWP_TSLoading";
         Ddo_br_encounter_departmentadm_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_departmentadm_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_departmentadm_Datalistupdateminimumcharacters = 0;
         Ddo_br_encounter_departmentadm_Datalistproc = "BR_EncounterTabGetFilterData";
         Ddo_br_encounter_departmentadm_Datalisttype = "Dynamic";
         Ddo_br_encounter_departmentadm_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_encounter_departmentadm_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_encounter_departmentadm_Filtertype = "Character";
         Ddo_br_encounter_departmentadm_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounter_departmentadm_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_departmentadm_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_departmentadm_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_departmentadm_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_departmentadm_Cls = "ColumnSettings";
         Ddo_br_encounter_departmentadm_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_departmentadm_Caption = "";
         Ddo_br_encounter_enctype_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_enctype_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_enctype_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_enctype_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_enctype_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_enctype_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_enctype_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_enctype_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_enctype_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_enctype_Cls = "ColumnSettings";
         Ddo_br_encounter_enctype_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_enctype_Caption = "";
         Ddo_br_encounter_encid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_encid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_encid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_encid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_encid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_encid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_encid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_encid_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_encid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_encid_Cls = "ColumnSettings";
         Ddo_br_encounter_encid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_encid_Caption = "";
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
         Dvpanel_unnamedtable2_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Iconposition = "left";
         Dvpanel_unnamedtable2_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable2_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable2_Title = "";
         Dvpanel_unnamedtable2_Cls = "PanelNoHeader";
         Dvpanel_unnamedtable2_Width = "100%";
         subGrid_Rows = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'sPrefix'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV77tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV53BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV58BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV80BR_Encounter_DepartmentadmTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV84BR_Encounter_DepartmentdischTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV71BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_Departmentadm_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentadm_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Title'},{av:'edtBR_Encounter_Departmentdisch_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentdisch_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E114B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E124B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E134B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_encid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCID',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentadm_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentdisch_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTDISCH',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'AV77tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV53BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV58BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV80BR_Encounter_DepartmentadmTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV84BR_Encounter_DepartmentdischTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV71BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_Departmentadm_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentadm_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Title'},{av:'edtBR_Encounter_Departmentdisch_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentdisch_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCID.ONOPTIONCLICKED","{handler:'E144B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_br_encounter_encid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ENCID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCID.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_encid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentadm_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentdisch_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTDISCH',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'AV77tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV53BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV58BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV80BR_Encounter_DepartmentadmTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV84BR_Encounter_DepartmentdischTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV71BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_Departmentadm_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentadm_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Title'},{av:'edtBR_Encounter_Departmentdisch_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentdisch_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED","{handler:'E154B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_br_encounter_enctype_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_encid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCID',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentadm_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentdisch_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTDISCH',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'AV77tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV53BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV58BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV80BR_Encounter_DepartmentadmTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV84BR_Encounter_DepartmentdischTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV71BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_Departmentadm_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentadm_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Title'},{av:'edtBR_Encounter_Departmentdisch_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentdisch_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_DEPARTMENTADM.ONOPTIONCLICKED","{handler:'E164B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_br_encounter_departmentadm_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTADM',prop:'ActiveEventKey'},{av:'Ddo_br_encounter_departmentadm_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTADM',prop:'FilteredText_get'},{av:'Ddo_br_encounter_departmentadm_Selectedvalue_get',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTADM',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_DEPARTMENTADM.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_departmentadm_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTADM',prop:'SortedStatus'},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_encid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCID',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentdisch_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTDISCH',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'AV77tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV53BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV58BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV80BR_Encounter_DepartmentadmTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV84BR_Encounter_DepartmentdischTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV71BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_Departmentadm_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentadm_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Title'},{av:'edtBR_Encounter_Departmentdisch_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentdisch_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_DEPARTMENTDISCH.ONOPTIONCLICKED","{handler:'E174B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_br_encounter_departmentdisch_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTDISCH',prop:'ActiveEventKey'},{av:'Ddo_br_encounter_departmentdisch_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTDISCH',prop:'FilteredText_get'},{av:'Ddo_br_encounter_departmentdisch_Selectedvalue_get',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTDISCH',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_DEPARTMENTDISCH.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_departmentdisch_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTDISCH',prop:'SortedStatus'},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_encid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCID',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentadm_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'AV77tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV53BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV58BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV80BR_Encounter_DepartmentadmTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV84BR_Encounter_DepartmentdischTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV71BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_Departmentadm_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentadm_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Title'},{av:'edtBR_Encounter_Departmentdisch_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentdisch_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED","{handler:'E184B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_br_encounter_admitdate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_encid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCID',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentadm_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentdisch_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTDISCH',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'AV77tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV53BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV58BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV80BR_Encounter_DepartmentadmTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV84BR_Encounter_DepartmentdischTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV71BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_Departmentadm_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentadm_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Title'},{av:'edtBR_Encounter_Departmentdisch_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentdisch_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED","{handler:'E194B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_br_encounter_status_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_encid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCID',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentadm_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_br_encounter_departmentdisch_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENTDISCH',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'AV77tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV53BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV58BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV80BR_Encounter_DepartmentadmTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV84BR_Encounter_DepartmentdischTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV71BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_Departmentadm_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentadm_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Title'},{av:'edtBR_Encounter_Departmentdisch_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentdisch_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E244B2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[]}");
         setEventMetadata("'DOINSERT'","{handler:'E204B2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VBR_ENCOUNTERID.CONTROLVALUECHANGING","{handler:'E214B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV76BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV81TFBR_Encounter_Departmentadm',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'AV82TFBR_Encounter_Departmentadm_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTADM_SEL',pic:''},{av:'AV85TFBR_Encounter_Departmentdisch',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'AV86TFBR_Encounter_Departmentdisch_Sel',fld:'vTFBR_ENCOUNTER_DEPARTMENTDISCH_SEL',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV56ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTDISCHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'}]");
         setEventMetadata("VBR_ENCOUNTERID.CONTROLVALUECHANGING",",oparms:[{av:'AV77tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV53BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV58BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV80BR_Encounter_DepartmentadmTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV84BR_Encounter_DepartmentdischTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTDISCHTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV71BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_Departmentadm_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentadm_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTADM',prop:'Title'},{av:'edtBR_Encounter_Departmentdisch_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Titleformat'},{av:'edtBR_Encounter_Departmentdisch_Title',ctrl:'BR_ENCOUNTER_DEPARTMENTDISCH',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'AV44GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("BR_ENCOUNTERID.CLICK","{handler:'E254B2',iparms:[{av:'cmbBR_Encounter_Status'},{av:'A172BR_Encounter_Status',fld:'BR_ENCOUNTER_STATUS',pic:'ZZZ9',hsh:true},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("BR_ENCOUNTERID.CLICK",",oparms:[]}");
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
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_encounter_encid_Activeeventkey = "";
         Ddo_br_encounter_enctype_Activeeventkey = "";
         Ddo_br_encounter_departmentadm_Activeeventkey = "";
         Ddo_br_encounter_departmentadm_Filteredtext_get = "";
         Ddo_br_encounter_departmentadm_Selectedvalue_get = "";
         Ddo_br_encounter_departmentdisch_Activeeventkey = "";
         Ddo_br_encounter_departmentdisch_Filteredtext_get = "";
         Ddo_br_encounter_departmentdisch_Selectedvalue_get = "";
         Ddo_br_encounter_admitdate_Activeeventkey = "";
         Ddo_br_encounter_status_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV76BR_EncounterID = "";
         AV81TFBR_Encounter_Departmentadm = "";
         AV82TFBR_Encounter_Departmentadm_Sel = "";
         AV85TFBR_Encounter_Departmentdisch = "";
         AV86TFBR_Encounter_Departmentdisch_Sel = "";
         AV56ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace = "";
         AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "";
         AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace = "";
         AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace = "";
         AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "";
         AV74ddo_BR_Encounter_StatusTitleControlIdToReplace = "";
         AV91Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV41DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV53BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Encounter_EncIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV58BR_Encounter_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV80BR_Encounter_DepartmentadmTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV84BR_Encounter_DepartmentdischTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Encounter_AdmitDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV71BR_Encounter_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_encounter_encid_Sortedstatus = "";
         Ddo_br_encounter_enctype_Sortedstatus = "";
         Ddo_br_encounter_departmentadm_Filteredtext_set = "";
         Ddo_br_encounter_departmentadm_Selectedvalue_set = "";
         Ddo_br_encounter_departmentadm_Sortedstatus = "";
         Ddo_br_encounter_departmentdisch_Filteredtext_set = "";
         Ddo_br_encounter_departmentdisch_Selectedvalue_set = "";
         Ddo_br_encounter_departmentdisch_Sortedstatus = "";
         Ddo_br_encounter_admitdate_Sortedstatus = "";
         Ddo_br_encounter_status_Sortedstatus = "";
         GX_FocusControl = "";
         ucDvpanel_unnamedtable2 = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A90BR_Encounter_ENCType = "";
         A570BR_Encounter_Departmentadm = "";
         A572BR_Encounter_Departmentdisch = "";
         A91BR_Encounter_AdmitDate = DateTime.MinValue;
         A92BR_Encounter_AdmitSource = "";
         A360BAS_TenantTenantCode = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_encounter_encid = new GXUserControl();
         ucDdo_br_encounter_enctype = new GXUserControl();
         ucDdo_br_encounter_departmentadm = new GXUserControl();
         ucDdo_br_encounter_departmentdisch = new GXUserControl();
         ucDdo_br_encounter_admitdate = new GXUserControl();
         ucDdo_br_encounter_status = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV76BR_EncounterID = "";
         lV81TFBR_Encounter_Departmentadm = "";
         lV85TFBR_Encounter_Departmentdisch = "";
         AV77tCurrentCode = "";
         H004B2_A85BR_Information_ID = new long[1] ;
         H004B2_n85BR_Information_ID = new bool[] {false} ;
         H004B2_A360BAS_TenantTenantCode = new String[] {""} ;
         H004B2_n360BAS_TenantTenantCode = new bool[] {false} ;
         H004B2_A172BR_Encounter_Status = new short[1] ;
         H004B2_n172BR_Encounter_Status = new bool[] {false} ;
         H004B2_A92BR_Encounter_AdmitSource = new String[] {""} ;
         H004B2_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         H004B2_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         H004B2_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         H004B2_A572BR_Encounter_Departmentdisch = new String[] {""} ;
         H004B2_n572BR_Encounter_Departmentdisch = new bool[] {false} ;
         H004B2_A570BR_Encounter_Departmentadm = new String[] {""} ;
         H004B2_n570BR_Encounter_Departmentadm = new bool[] {false} ;
         H004B2_A90BR_Encounter_ENCType = new String[] {""} ;
         H004B2_n90BR_Encounter_ENCType = new bool[] {false} ;
         H004B2_A35BR_Encounter_EncID = new long[1] ;
         H004B2_n35BR_Encounter_EncID = new bool[] {false} ;
         H004B2_A19BR_EncounterID = new long[1] ;
         H004B3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         GXt_char2 = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV16Session = context.GetSession();
         AV12GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV51WebSession = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8BR_Information_ID = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountertab__default(),
            new Object[][] {
                new Object[] {
               H004B2_A85BR_Information_ID, H004B2_n85BR_Information_ID, H004B2_A360BAS_TenantTenantCode, H004B2_n360BAS_TenantTenantCode, H004B2_A172BR_Encounter_Status, H004B2_n172BR_Encounter_Status, H004B2_A92BR_Encounter_AdmitSource, H004B2_n92BR_Encounter_AdmitSource, H004B2_A91BR_Encounter_AdmitDate, H004B2_n91BR_Encounter_AdmitDate,
               H004B2_A572BR_Encounter_Departmentdisch, H004B2_n572BR_Encounter_Departmentdisch, H004B2_A570BR_Encounter_Departmentadm, H004B2_n570BR_Encounter_Departmentadm, H004B2_A90BR_Encounter_ENCType, H004B2_n90BR_Encounter_ENCType, H004B2_A35BR_Encounter_EncID, H004B2_n35BR_Encounter_EncID, H004B2_A19BR_EncounterID
               }
               , new Object[] {
               H004B3_AGRID_nRecordCount
               }
            }
         );
         AV91Pgmname = "BR_EncounterTab";
         /* GeneXus formulas. */
         AV91Pgmname = "BR_EncounterTab";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_27 ;
      private short nGXsfl_27_idx=1 ;
      private short GRID_nEOF ;
      private short AV14OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Encounter_EncID_Titleformat ;
      private short edtBR_Encounter_ENCType_Titleformat ;
      private short edtBR_Encounter_Departmentadm_Titleformat ;
      private short edtBR_Encounter_Departmentdisch_Titleformat ;
      private short edtBR_Encounter_AdmitDate_Titleformat ;
      private short cmbBR_Encounter_Status_Titleformat ;
      private short subGrid_Sortable ;
      private short A172BR_Encounter_Status ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_br_encounter_departmentadm_Datalistupdateminimumcharacters ;
      private int Ddo_br_encounter_departmentdisch_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int edtavBr_encounterid_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_departmentadmtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_departmentdischtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible ;
      private int edtBR_Information_ID_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_encounter_departmentadm_Visible ;
      private int edtavTfbr_encounter_departmentadm_sel_Visible ;
      private int edtavTfbr_encounter_departmentdisch_Visible ;
      private int edtavTfbr_encounter_departmentdisch_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV43PageToGo ;
      private int AV92GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long AV8BR_Information_ID ;
      private long wcpOAV8BR_Information_ID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV44GridCurrentPage ;
      private long AV88GridPageCount ;
      private long A19BR_EncounterID ;
      private long A35BR_Encounter_EncID ;
      private long A85BR_Information_ID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_encounter_encid_Activeeventkey ;
      private String Ddo_br_encounter_enctype_Activeeventkey ;
      private String Ddo_br_encounter_departmentadm_Activeeventkey ;
      private String Ddo_br_encounter_departmentadm_Filteredtext_get ;
      private String Ddo_br_encounter_departmentadm_Selectedvalue_get ;
      private String Ddo_br_encounter_departmentdisch_Activeeventkey ;
      private String Ddo_br_encounter_departmentdisch_Filteredtext_get ;
      private String Ddo_br_encounter_departmentdisch_Selectedvalue_get ;
      private String Ddo_br_encounter_admitdate_Activeeventkey ;
      private String Ddo_br_encounter_status_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_27_idx="0001" ;
      private String AV91Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_unnamedtable2_Width ;
      private String Dvpanel_unnamedtable2_Cls ;
      private String Dvpanel_unnamedtable2_Title ;
      private String Dvpanel_unnamedtable2_Iconposition ;
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
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_encounter_encid_Caption ;
      private String Ddo_br_encounter_encid_Tooltip ;
      private String Ddo_br_encounter_encid_Cls ;
      private String Ddo_br_encounter_encid_Dropdownoptionstype ;
      private String Ddo_br_encounter_encid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_encid_Sortedstatus ;
      private String Ddo_br_encounter_encid_Sortasc ;
      private String Ddo_br_encounter_encid_Sortdsc ;
      private String Ddo_br_encounter_encid_Searchbuttontext ;
      private String Ddo_br_encounter_enctype_Caption ;
      private String Ddo_br_encounter_enctype_Tooltip ;
      private String Ddo_br_encounter_enctype_Cls ;
      private String Ddo_br_encounter_enctype_Dropdownoptionstype ;
      private String Ddo_br_encounter_enctype_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_enctype_Sortedstatus ;
      private String Ddo_br_encounter_enctype_Sortasc ;
      private String Ddo_br_encounter_enctype_Sortdsc ;
      private String Ddo_br_encounter_enctype_Searchbuttontext ;
      private String Ddo_br_encounter_departmentadm_Caption ;
      private String Ddo_br_encounter_departmentadm_Tooltip ;
      private String Ddo_br_encounter_departmentadm_Cls ;
      private String Ddo_br_encounter_departmentadm_Filteredtext_set ;
      private String Ddo_br_encounter_departmentadm_Selectedvalue_set ;
      private String Ddo_br_encounter_departmentadm_Dropdownoptionstype ;
      private String Ddo_br_encounter_departmentadm_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_departmentadm_Sortedstatus ;
      private String Ddo_br_encounter_departmentadm_Filtertype ;
      private String Ddo_br_encounter_departmentadm_Datalisttype ;
      private String Ddo_br_encounter_departmentadm_Datalistproc ;
      private String Ddo_br_encounter_departmentadm_Sortasc ;
      private String Ddo_br_encounter_departmentadm_Sortdsc ;
      private String Ddo_br_encounter_departmentadm_Loadingdata ;
      private String Ddo_br_encounter_departmentadm_Cleanfilter ;
      private String Ddo_br_encounter_departmentadm_Noresultsfound ;
      private String Ddo_br_encounter_departmentadm_Searchbuttontext ;
      private String Ddo_br_encounter_departmentdisch_Caption ;
      private String Ddo_br_encounter_departmentdisch_Tooltip ;
      private String Ddo_br_encounter_departmentdisch_Cls ;
      private String Ddo_br_encounter_departmentdisch_Filteredtext_set ;
      private String Ddo_br_encounter_departmentdisch_Selectedvalue_set ;
      private String Ddo_br_encounter_departmentdisch_Dropdownoptionstype ;
      private String Ddo_br_encounter_departmentdisch_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_departmentdisch_Sortedstatus ;
      private String Ddo_br_encounter_departmentdisch_Filtertype ;
      private String Ddo_br_encounter_departmentdisch_Datalisttype ;
      private String Ddo_br_encounter_departmentdisch_Datalistproc ;
      private String Ddo_br_encounter_departmentdisch_Sortasc ;
      private String Ddo_br_encounter_departmentdisch_Sortdsc ;
      private String Ddo_br_encounter_departmentdisch_Loadingdata ;
      private String Ddo_br_encounter_departmentdisch_Cleanfilter ;
      private String Ddo_br_encounter_departmentdisch_Noresultsfound ;
      private String Ddo_br_encounter_departmentdisch_Searchbuttontext ;
      private String Ddo_br_encounter_admitdate_Caption ;
      private String Ddo_br_encounter_admitdate_Tooltip ;
      private String Ddo_br_encounter_admitdate_Cls ;
      private String Ddo_br_encounter_admitdate_Dropdownoptionstype ;
      private String Ddo_br_encounter_admitdate_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_admitdate_Sortedstatus ;
      private String Ddo_br_encounter_admitdate_Sortasc ;
      private String Ddo_br_encounter_admitdate_Sortdsc ;
      private String Ddo_br_encounter_admitdate_Searchbuttontext ;
      private String Ddo_br_encounter_status_Caption ;
      private String Ddo_br_encounter_status_Tooltip ;
      private String Ddo_br_encounter_status_Cls ;
      private String Ddo_br_encounter_status_Dropdownoptionstype ;
      private String Ddo_br_encounter_status_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_status_Sortedstatus ;
      private String Ddo_br_encounter_status_Sortasc ;
      private String Ddo_br_encounter_status_Sortdsc ;
      private String Ddo_br_encounter_status_Searchbuttontext ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String divHtml_dvpanel_unnamedtable2_Internalname ;
      private String Dvpanel_unnamedtable2_Internalname ;
      private String divLayout_unnamedtable2_Internalname ;
      private String divUnnamedtable2_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String edtavBr_encounterid_Internalname ;
      private String edtavBr_encounterid_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Encounter_EncID_Title ;
      private String edtBR_Encounter_ENCType_Title ;
      private String edtBR_Encounter_Departmentadm_Title ;
      private String edtBR_Encounter_Departmentdisch_Title ;
      private String edtBR_Encounter_AdmitDate_Title ;
      private String subGrid_Header ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_encid_Internalname ;
      private String edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_enctype_Internalname ;
      private String edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_departmentadm_Internalname ;
      private String edtavDdo_br_encounter_departmentadmtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_departmentdisch_Internalname ;
      private String edtavDdo_br_encounter_departmentdischtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_admitdate_Internalname ;
      private String edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_status_Internalname ;
      private String edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname ;
      private String edtBR_Information_ID_Internalname ;
      private String edtBR_Information_ID_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_encounter_departmentadm_Internalname ;
      private String edtavTfbr_encounter_departmentadm_Jsonclick ;
      private String edtavTfbr_encounter_departmentadm_sel_Internalname ;
      private String edtavTfbr_encounter_departmentadm_sel_Jsonclick ;
      private String edtavTfbr_encounter_departmentdisch_Internalname ;
      private String edtavTfbr_encounter_departmentdisch_Jsonclick ;
      private String edtavTfbr_encounter_departmentdisch_sel_Internalname ;
      private String edtavTfbr_encounter_departmentdisch_sel_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Encounter_EncID_Internalname ;
      private String edtBR_Encounter_ENCType_Internalname ;
      private String edtBR_Encounter_Departmentadm_Internalname ;
      private String edtBR_Encounter_Departmentdisch_Internalname ;
      private String edtBR_Encounter_AdmitDate_Internalname ;
      private String edtBR_Encounter_AdmitSource_Internalname ;
      private String cmbBR_Encounter_Status_Internalname ;
      private String edtBAS_TenantTenantCode_Internalname ;
      private String scmdbuf ;
      private String GXt_char2 ;
      private String sCtrlAV8BR_Information_ID ;
      private String sGXsfl_27_fel_idx="0001" ;
      private String ROClassString ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Encounter_EncID_Jsonclick ;
      private String edtBR_Encounter_ENCType_Jsonclick ;
      private String edtBR_Encounter_Departmentadm_Jsonclick ;
      private String edtBR_Encounter_Departmentdisch_Jsonclick ;
      private String edtBR_Encounter_AdmitDate_Jsonclick ;
      private String edtBR_Encounter_AdmitSource_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Encounter_Status_Jsonclick ;
      private String edtBAS_TenantTenantCode_Jsonclick ;
      private DateTime A91BR_Encounter_AdmitDate ;
      private bool entryPointCalled ;
      private bool AV15OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Dvpanel_unnamedtable2_Collapsible ;
      private bool Dvpanel_unnamedtable2_Collapsed ;
      private bool Dvpanel_unnamedtable2_Autowidth ;
      private bool Dvpanel_unnamedtable2_Autoheight ;
      private bool Dvpanel_unnamedtable2_Showcollapseicon ;
      private bool Dvpanel_unnamedtable2_Autoscroll ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_encounter_encid_Includesortasc ;
      private bool Ddo_br_encounter_encid_Includesortdsc ;
      private bool Ddo_br_encounter_encid_Includefilter ;
      private bool Ddo_br_encounter_encid_Includedatalist ;
      private bool Ddo_br_encounter_enctype_Includesortasc ;
      private bool Ddo_br_encounter_enctype_Includesortdsc ;
      private bool Ddo_br_encounter_enctype_Includefilter ;
      private bool Ddo_br_encounter_enctype_Includedatalist ;
      private bool Ddo_br_encounter_departmentadm_Includesortasc ;
      private bool Ddo_br_encounter_departmentadm_Includesortdsc ;
      private bool Ddo_br_encounter_departmentadm_Includefilter ;
      private bool Ddo_br_encounter_departmentadm_Filterisrange ;
      private bool Ddo_br_encounter_departmentadm_Includedatalist ;
      private bool Ddo_br_encounter_departmentdisch_Includesortasc ;
      private bool Ddo_br_encounter_departmentdisch_Includesortdsc ;
      private bool Ddo_br_encounter_departmentdisch_Includefilter ;
      private bool Ddo_br_encounter_departmentdisch_Filterisrange ;
      private bool Ddo_br_encounter_departmentdisch_Includedatalist ;
      private bool Ddo_br_encounter_admitdate_Includesortasc ;
      private bool Ddo_br_encounter_admitdate_Includesortdsc ;
      private bool Ddo_br_encounter_admitdate_Includefilter ;
      private bool Ddo_br_encounter_admitdate_Includedatalist ;
      private bool Ddo_br_encounter_status_Includesortasc ;
      private bool Ddo_br_encounter_status_Includesortdsc ;
      private bool Ddo_br_encounter_status_Includefilter ;
      private bool Ddo_br_encounter_status_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n35BR_Encounter_EncID ;
      private bool n90BR_Encounter_ENCType ;
      private bool n570BR_Encounter_Departmentadm ;
      private bool n572BR_Encounter_Departmentdisch ;
      private bool n91BR_Encounter_AdmitDate ;
      private bool n92BR_Encounter_AdmitSource ;
      private bool n172BR_Encounter_Status ;
      private bool n360BAS_TenantTenantCode ;
      private bool bGXsfl_27_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV52TempBoolean ;
      private bool AV75IsInsert ;
      private bool GXt_boolean3 ;
      private String AV76BR_EncounterID ;
      private String AV81TFBR_Encounter_Departmentadm ;
      private String AV82TFBR_Encounter_Departmentadm_Sel ;
      private String AV85TFBR_Encounter_Departmentdisch ;
      private String AV86TFBR_Encounter_Departmentdisch_Sel ;
      private String AV56ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV20ddo_BR_Encounter_EncIDTitleControlIdToReplace ;
      private String AV61ddo_BR_Encounter_ENCTypeTitleControlIdToReplace ;
      private String AV83ddo_BR_Encounter_DepartmentadmTitleControlIdToReplace ;
      private String AV87ddo_BR_Encounter_DepartmentdischTitleControlIdToReplace ;
      private String AV26ddo_BR_Encounter_AdmitDateTitleControlIdToReplace ;
      private String AV74ddo_BR_Encounter_StatusTitleControlIdToReplace ;
      private String A90BR_Encounter_ENCType ;
      private String A570BR_Encounter_Departmentadm ;
      private String A572BR_Encounter_Departmentdisch ;
      private String A92BR_Encounter_AdmitSource ;
      private String A360BAS_TenantTenantCode ;
      private String lV76BR_EncounterID ;
      private String lV81TFBR_Encounter_Departmentadm ;
      private String lV85TFBR_Encounter_Departmentdisch ;
      private String AV77tCurrentCode ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_unnamedtable2 ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_encounter_encid ;
      private GXUserControl ucDdo_br_encounter_enctype ;
      private GXUserControl ucDdo_br_encounter_departmentadm ;
      private GXUserControl ucDdo_br_encounter_departmentdisch ;
      private GXUserControl ucDdo_br_encounter_admitdate ;
      private GXUserControl ucDdo_br_encounter_status ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Encounter_Status ;
      private IDataStoreProvider pr_default ;
      private long[] H004B2_A85BR_Information_ID ;
      private bool[] H004B2_n85BR_Information_ID ;
      private String[] H004B2_A360BAS_TenantTenantCode ;
      private bool[] H004B2_n360BAS_TenantTenantCode ;
      private short[] H004B2_A172BR_Encounter_Status ;
      private bool[] H004B2_n172BR_Encounter_Status ;
      private String[] H004B2_A92BR_Encounter_AdmitSource ;
      private bool[] H004B2_n92BR_Encounter_AdmitSource ;
      private DateTime[] H004B2_A91BR_Encounter_AdmitDate ;
      private bool[] H004B2_n91BR_Encounter_AdmitDate ;
      private String[] H004B2_A572BR_Encounter_Departmentdisch ;
      private bool[] H004B2_n572BR_Encounter_Departmentdisch ;
      private String[] H004B2_A570BR_Encounter_Departmentadm ;
      private bool[] H004B2_n570BR_Encounter_Departmentadm ;
      private String[] H004B2_A90BR_Encounter_ENCType ;
      private bool[] H004B2_n90BR_Encounter_ENCType ;
      private long[] H004B2_A35BR_Encounter_EncID ;
      private bool[] H004B2_n35BR_Encounter_EncID ;
      private long[] H004B2_A19BR_EncounterID ;
      private long[] H004B3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private IGxSession AV51WebSession ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV53BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Encounter_EncIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV58BR_Encounter_ENCTypeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV80BR_Encounter_DepartmentadmTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV84BR_Encounter_DepartmentdischTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Encounter_AdmitDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV71BR_Encounter_StatusTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV13GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV41DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_encountertab__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H004B2( IGxContext context ,
                                             String AV76BR_EncounterID ,
                                             String AV82TFBR_Encounter_Departmentadm_Sel ,
                                             String AV81TFBR_Encounter_Departmentadm ,
                                             String AV86TFBR_Encounter_Departmentdisch_Sel ,
                                             String AV85TFBR_Encounter_Departmentdisch ,
                                             long A19BR_EncounterID ,
                                             String A570BR_Encounter_Departmentadm ,
                                             String A572BR_Encounter_Departmentdisch ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A85BR_Information_ID ,
                                             long AV8BR_Information_ID ,
                                             String A360BAS_TenantTenantCode ,
                                             String AV77tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [10] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Information_ID], [BAS_TenantTenantCode], [BR_Encounter_Status], [BR_Encounter_AdmitSource], [BR_Encounter_AdmitDate], [BR_Encounter_Departmentdisch], [BR_Encounter_Departmentadm], [BR_Encounter_ENCType], [BR_Encounter_EncID], [BR_EncounterID]";
         sFromString = " FROM [BR_Encounter] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_Information_ID] = @AV8BR_Information_ID)";
         sWhereString = sWhereString + " and ([BAS_TenantTenantCode] = @AV77tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([BR_EncounterID] AS decimal(18,0))) like '%' + @lV76BR_EncounterID + '%')";
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82TFBR_Encounter_Departmentadm_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81TFBR_Encounter_Departmentadm)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentadm] like @lV81TFBR_Encounter_Departmentadm)";
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82TFBR_Encounter_Departmentadm_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentadm] = @AV82TFBR_Encounter_Departmentadm_Sel)";
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86TFBR_Encounter_Departmentdisch_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85TFBR_Encounter_Departmentdisch)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentdisch] like @lV85TFBR_Encounter_Departmentdisch)";
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86TFBR_Encounter_Departmentdisch_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentdisch] = @AV86TFBR_Encounter_Departmentdisch_Sel)";
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID], [BR_Encounter_EncID]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID] DESC, [BR_Encounter_EncID] DESC";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID], [BR_Encounter_ENCType]";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID] DESC, [BR_Encounter_ENCType] DESC";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID], [BR_Encounter_Departmentadm]";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID] DESC, [BR_Encounter_Departmentadm] DESC";
         }
         else if ( ( AV14OrderedBy == 5 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID], [BR_Encounter_Departmentdisch]";
         }
         else if ( ( AV14OrderedBy == 5 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID] DESC, [BR_Encounter_Departmentdisch] DESC";
         }
         else if ( ( AV14OrderedBy == 6 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID], [BR_Encounter_AdmitDate]";
         }
         else if ( ( AV14OrderedBy == 6 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID] DESC, [BR_Encounter_AdmitDate] DESC";
         }
         else if ( ( AV14OrderedBy == 7 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID], [BR_Encounter_Status]";
         }
         else if ( ( AV14OrderedBy == 7 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Information_ID] DESC, [BR_Encounter_Status] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_H004B3( IGxContext context ,
                                             String AV76BR_EncounterID ,
                                             String AV82TFBR_Encounter_Departmentadm_Sel ,
                                             String AV81TFBR_Encounter_Departmentadm ,
                                             String AV86TFBR_Encounter_Departmentdisch_Sel ,
                                             String AV85TFBR_Encounter_Departmentdisch ,
                                             long A19BR_EncounterID ,
                                             String A570BR_Encounter_Departmentadm ,
                                             String A572BR_Encounter_Departmentdisch ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A85BR_Information_ID ,
                                             long AV8BR_Information_ID ,
                                             String A360BAS_TenantTenantCode ,
                                             String AV77tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [7] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_Information_ID] = @AV8BR_Information_ID)";
         scmdbuf = scmdbuf + " and ([BAS_TenantTenantCode] = @AV77tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([BR_EncounterID] AS decimal(18,0))) like '%' + @lV76BR_EncounterID + '%')";
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82TFBR_Encounter_Departmentadm_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81TFBR_Encounter_Departmentadm)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentadm] like @lV81TFBR_Encounter_Departmentadm)";
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82TFBR_Encounter_Departmentadm_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentadm] = @AV82TFBR_Encounter_Departmentadm_Sel)";
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86TFBR_Encounter_Departmentdisch_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85TFBR_Encounter_Departmentdisch)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentdisch] like @lV85TFBR_Encounter_Departmentdisch)";
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86TFBR_Encounter_Departmentdisch_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentdisch] = @AV86TFBR_Encounter_Departmentdisch_Sel)";
         }
         else
         {
            GXv_int6[6] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 5 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 5 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 6 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 6 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 7 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 7 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H004B2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (short)dynConstraints[8] , (bool)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] );
               case 1 :
                     return conditional_H004B3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (short)dynConstraints[8] , (bool)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] );
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
          Object[] prmH004B2 ;
          prmH004B2 = new Object[] {
          new Object[] {"@AV8BR_Information_ID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV76BR_EncounterID",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81TFBR_Encounter_Departmentadm",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV82TFBR_Encounter_Departmentadm_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85TFBR_Encounter_Departmentdisch",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV86TFBR_Encounter_Departmentdisch_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH004B3 ;
          prmH004B3 = new Object[] {
          new Object[] {"@AV8BR_Information_ID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV76BR_EncounterID",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV81TFBR_Encounter_Departmentadm",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV82TFBR_Encounter_Departmentadm_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV85TFBR_Encounter_Departmentdisch",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV86TFBR_Encounter_Departmentdisch_Sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004B2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004B2,11,0,true,false )
             ,new CursorDef("H004B3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004B3,1,0,true,false )
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
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
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
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                return;
             case 1 :
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
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                return;
       }
    }

 }

}
