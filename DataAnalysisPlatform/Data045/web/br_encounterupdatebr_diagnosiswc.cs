/*
               File: BR_EncounterUpdateBR_DiagnosisWC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:45.10
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
   public class br_encounterupdatebr_diagnosiswc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterupdatebr_diagnosiswc( )
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

      public br_encounterupdatebr_diagnosiswc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_EncounterID )
      {
         this.AV8BR_EncounterID = aP0_BR_EncounterID;
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
         cmbBR_Diagnosis_InitialDX = new GXCombobox();
         cmbBR_Diagnosis_MetastasesDX = new GXCombobox();
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
                  AV8BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)AV8BR_EncounterID});
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
                  nRC_GXsfl_28 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_28_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_28_idx = GetNextPar( );
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
                  AV14OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV15OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
                  AV82TFBR_Diagnosis_No = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV83TFBR_Diagnosis_No_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV8BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace = GetNextPar( );
                  AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = GetNextPar( );
                  AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = GetNextPar( );
                  AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = GetNextPar( );
                  AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = GetNextPar( );
                  AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = GetNextPar( );
                  AV91Pgmname = GetNextPar( );
                  AV44IsAuthorized_Display = StringUtil.StrToBool( GetNextPar( ));
                  AV40IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
                  AV42IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV82TFBR_Diagnosis_No, AV83TFBR_Diagnosis_No_To, AV8BR_EncounterID, AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV91Pgmname, AV44IsAuthorized_Display, AV40IsAuthorized_Update, AV42IsAuthorized_Delete, sPrefix) ;
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
            PA242( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV91Pgmname = "BR_EncounterUpdateBR_DiagnosisWC";
               context.Gx_err = 0;
               WS242( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281564549", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterupdatebr_diagnosiswc.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDDSC", StringUtil.BoolToStr( AV15OrderedDsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_DIAGNOSIS_NO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV82TFBR_Diagnosis_No), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_DIAGNOSIS_NO_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV83TFBR_Diagnosis_No_To), 10, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV36GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV85GridPageCount), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV33DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV33DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_DIAGNOSIS_NOTITLEFILTERDATA", AV81BR_Diagnosis_NoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_DIAGNOSIS_NOTITLEFILTERDATA", AV81BR_Diagnosis_NoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA", AV27BR_Diagnosis_DXDescriptionTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA", AV27BR_Diagnosis_DXDescriptionTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA", AV25BR_Diagnosis_DXTsourceTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA", AV25BR_Diagnosis_DXTsourceTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_DIAGNOSIS_DXIDTITLEFILTERDATA", AV19BR_Diagnosis_DXIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_DIAGNOSIS_DXIDTITLEFILTERDATA", AV19BR_Diagnosis_DXIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_DIAGNOSIS_DXCODETITLEFILTERDATA", AV21BR_Diagnosis_DXCodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_DIAGNOSIS_DXCODETITLEFILTERDATA", AV21BR_Diagnosis_DXCodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA", AV23BR_Diagnosis_DXTypeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA", AV23BR_Diagnosis_DXTypeTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV91Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DISPLAY", AV44IsAuthorized_Display);
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_UPDATE", AV40IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DELETE", AV42IsAuthorized_Delete);
         GxWebStd.gx_hidden_field( context, sPrefix+"vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
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
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Caption", StringUtil.RTrim( Ddo_br_diagnosis_no_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_no_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Cls", StringUtil.RTrim( Ddo_br_diagnosis_no_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Filteredtext_set", StringUtil.RTrim( Ddo_br_diagnosis_no_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Filteredtextto_set", StringUtil.RTrim( Ddo_br_diagnosis_no_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_no_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_no_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_no_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_no_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_no_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_no_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Filtertype", StringUtil.RTrim( Ddo_br_diagnosis_no_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Filterisrange", StringUtil.BoolToStr( Ddo_br_diagnosis_no_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_no_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_no_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_no_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Cleanfilter", StringUtil.RTrim( Ddo_br_diagnosis_no_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Rangefilterfrom", StringUtil.RTrim( Ddo_br_diagnosis_no_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Rangefilterto", StringUtil.RTrim( Ddo_br_diagnosis_no_Rangefilterto));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_no_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxdescription_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxdescription_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxdescription_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxdescription_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxid_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxid_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxid_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxcode_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxcode_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxcode_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxcode_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_no_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Filteredtext_get", StringUtil.RTrim( Ddo_br_diagnosis_no_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Filteredtextto_get", StringUtil.RTrim( Ddo_br_diagnosis_no_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_no_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Filteredtext_get", StringUtil.RTrim( Ddo_br_diagnosis_no_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_NO_Filteredtextto_get", StringUtil.RTrim( Ddo_br_diagnosis_no_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXID_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Activeeventkey));
      }

      protected void RenderHtmlCloseForm242( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encounterupdatebr_diagnosiswc.js", "?2020228156493", false);
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
         return "BR_EncounterUpdateBR_DiagnosisWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB240( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encounterupdatebr_diagnosiswc.aspx");
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
            GxWebStd.gx_div_start( context, divTablegridheader_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
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
            ucDvpanel_tableheader.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableheader_Internalname, sPrefix+"DVPANEL_TABLEHEADERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"DVPANEL_TABLEHEADERContainer"+"Body"+"\" style=\"display:none;\">") ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
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
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"28\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDisplay_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_No_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_No_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_No_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "序号") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXDescription_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXDescription_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXDescription_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXTsource_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXTsource_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXTsource_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXCode_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXCode_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXCode_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXType_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXType_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXType_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "是否为原发肿瘤") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "是否为转移肿瘤") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV43Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDisplay_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV39Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV41Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A513BR_Diagnosis_No), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_No_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_No_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A64BR_DiagnosisID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A69BR_Diagnosis_DXDescription);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXDescription_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXDescription_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A68BR_Diagnosis_DXTsource);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXTsource_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXTsource_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A65BR_Diagnosis_DXID);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A66BR_Diagnosis_DXCode);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXCode_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXCode_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A67BR_Diagnosis_DXType);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXType_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXType_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A70BR_Diagnosis_InitialDX);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A71BR_Diagnosis_MetastasesDX);
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
         if ( wbEnd == 28 )
         {
            wbEnd = 0;
            nRC_GXsfl_28 = (short)(nGXsfl_28_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV36GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV85GridPageCount);
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
            ucDdo_br_diagnosis_no.SetProperty("Caption", Ddo_br_diagnosis_no_Caption);
            ucDdo_br_diagnosis_no.SetProperty("Tooltip", Ddo_br_diagnosis_no_Tooltip);
            ucDdo_br_diagnosis_no.SetProperty("Cls", Ddo_br_diagnosis_no_Cls);
            ucDdo_br_diagnosis_no.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_no_Dropdownoptionstype);
            ucDdo_br_diagnosis_no.SetProperty("IncludeSortASC", Ddo_br_diagnosis_no_Includesortasc);
            ucDdo_br_diagnosis_no.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_no_Includesortdsc);
            ucDdo_br_diagnosis_no.SetProperty("IncludeFilter", Ddo_br_diagnosis_no_Includefilter);
            ucDdo_br_diagnosis_no.SetProperty("FilterType", Ddo_br_diagnosis_no_Filtertype);
            ucDdo_br_diagnosis_no.SetProperty("FilterIsRange", Ddo_br_diagnosis_no_Filterisrange);
            ucDdo_br_diagnosis_no.SetProperty("IncludeDataList", Ddo_br_diagnosis_no_Includedatalist);
            ucDdo_br_diagnosis_no.SetProperty("SortASC", Ddo_br_diagnosis_no_Sortasc);
            ucDdo_br_diagnosis_no.SetProperty("SortDSC", Ddo_br_diagnosis_no_Sortdsc);
            ucDdo_br_diagnosis_no.SetProperty("CleanFilter", Ddo_br_diagnosis_no_Cleanfilter);
            ucDdo_br_diagnosis_no.SetProperty("RangeFilterFrom", Ddo_br_diagnosis_no_Rangefilterfrom);
            ucDdo_br_diagnosis_no.SetProperty("RangeFilterTo", Ddo_br_diagnosis_no_Rangefilterto);
            ucDdo_br_diagnosis_no.SetProperty("SearchButtonText", Ddo_br_diagnosis_no_Searchbuttontext);
            ucDdo_br_diagnosis_no.SetProperty("DropDownOptionsTitleSettingsIcons", AV33DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_no.SetProperty("DropDownOptionsData", AV81BR_Diagnosis_NoTitleFilterData);
            ucDdo_br_diagnosis_no.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_no_Internalname, sPrefix+"DDO_BR_DIAGNOSIS_NOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname, AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxdescription.SetProperty("Caption", Ddo_br_diagnosis_dxdescription_Caption);
            ucDdo_br_diagnosis_dxdescription.SetProperty("Tooltip", Ddo_br_diagnosis_dxdescription_Tooltip);
            ucDdo_br_diagnosis_dxdescription.SetProperty("Cls", Ddo_br_diagnosis_dxdescription_Cls);
            ucDdo_br_diagnosis_dxdescription.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxdescription_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxdescription.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxdescription_Includesortasc);
            ucDdo_br_diagnosis_dxdescription.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxdescription_Includesortdsc);
            ucDdo_br_diagnosis_dxdescription.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxdescription_Includefilter);
            ucDdo_br_diagnosis_dxdescription.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxdescription_Includedatalist);
            ucDdo_br_diagnosis_dxdescription.SetProperty("SortASC", Ddo_br_diagnosis_dxdescription_Sortasc);
            ucDdo_br_diagnosis_dxdescription.SetProperty("SortDSC", Ddo_br_diagnosis_dxdescription_Sortdsc);
            ucDdo_br_diagnosis_dxdescription.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxdescription_Searchbuttontext);
            ucDdo_br_diagnosis_dxdescription.SetProperty("DropDownOptionsTitleSettingsIcons", AV33DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxdescription.SetProperty("DropDownOptionsData", AV27BR_Diagnosis_DXDescriptionTitleFilterData);
            ucDdo_br_diagnosis_dxdescription.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxdescription_Internalname, sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Internalname, AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxtsource.SetProperty("Caption", Ddo_br_diagnosis_dxtsource_Caption);
            ucDdo_br_diagnosis_dxtsource.SetProperty("Tooltip", Ddo_br_diagnosis_dxtsource_Tooltip);
            ucDdo_br_diagnosis_dxtsource.SetProperty("Cls", Ddo_br_diagnosis_dxtsource_Cls);
            ucDdo_br_diagnosis_dxtsource.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxtsource_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxtsource.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxtsource_Includesortasc);
            ucDdo_br_diagnosis_dxtsource.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxtsource_Includesortdsc);
            ucDdo_br_diagnosis_dxtsource.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxtsource_Includefilter);
            ucDdo_br_diagnosis_dxtsource.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxtsource_Includedatalist);
            ucDdo_br_diagnosis_dxtsource.SetProperty("SortASC", Ddo_br_diagnosis_dxtsource_Sortasc);
            ucDdo_br_diagnosis_dxtsource.SetProperty("SortDSC", Ddo_br_diagnosis_dxtsource_Sortdsc);
            ucDdo_br_diagnosis_dxtsource.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxtsource_Searchbuttontext);
            ucDdo_br_diagnosis_dxtsource.SetProperty("DropDownOptionsTitleSettingsIcons", AV33DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxtsource.SetProperty("DropDownOptionsData", AV25BR_Diagnosis_DXTsourceTitleFilterData);
            ucDdo_br_diagnosis_dxtsource.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxtsource_Internalname, sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Internalname, AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxid.SetProperty("Caption", Ddo_br_diagnosis_dxid_Caption);
            ucDdo_br_diagnosis_dxid.SetProperty("Tooltip", Ddo_br_diagnosis_dxid_Tooltip);
            ucDdo_br_diagnosis_dxid.SetProperty("Cls", Ddo_br_diagnosis_dxid_Cls);
            ucDdo_br_diagnosis_dxid.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxid_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxid.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxid_Includesortasc);
            ucDdo_br_diagnosis_dxid.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxid_Includesortdsc);
            ucDdo_br_diagnosis_dxid.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxid_Includefilter);
            ucDdo_br_diagnosis_dxid.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxid_Includedatalist);
            ucDdo_br_diagnosis_dxid.SetProperty("SortASC", Ddo_br_diagnosis_dxid_Sortasc);
            ucDdo_br_diagnosis_dxid.SetProperty("SortDSC", Ddo_br_diagnosis_dxid_Sortdsc);
            ucDdo_br_diagnosis_dxid.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxid_Searchbuttontext);
            ucDdo_br_diagnosis_dxid.SetProperty("DropDownOptionsTitleSettingsIcons", AV33DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxid.SetProperty("DropDownOptionsData", AV19BR_Diagnosis_DXIDTitleFilterData);
            ucDdo_br_diagnosis_dxid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxid_Internalname, sPrefix+"DDO_BR_DIAGNOSIS_DXIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Internalname, AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxcode.SetProperty("Caption", Ddo_br_diagnosis_dxcode_Caption);
            ucDdo_br_diagnosis_dxcode.SetProperty("Tooltip", Ddo_br_diagnosis_dxcode_Tooltip);
            ucDdo_br_diagnosis_dxcode.SetProperty("Cls", Ddo_br_diagnosis_dxcode_Cls);
            ucDdo_br_diagnosis_dxcode.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxcode_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxcode.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxcode_Includesortasc);
            ucDdo_br_diagnosis_dxcode.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxcode_Includesortdsc);
            ucDdo_br_diagnosis_dxcode.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxcode_Includefilter);
            ucDdo_br_diagnosis_dxcode.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxcode_Includedatalist);
            ucDdo_br_diagnosis_dxcode.SetProperty("SortASC", Ddo_br_diagnosis_dxcode_Sortasc);
            ucDdo_br_diagnosis_dxcode.SetProperty("SortDSC", Ddo_br_diagnosis_dxcode_Sortdsc);
            ucDdo_br_diagnosis_dxcode.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxcode_Searchbuttontext);
            ucDdo_br_diagnosis_dxcode.SetProperty("DropDownOptionsTitleSettingsIcons", AV33DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxcode.SetProperty("DropDownOptionsData", AV21BR_Diagnosis_DXCodeTitleFilterData);
            ucDdo_br_diagnosis_dxcode.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxcode_Internalname, sPrefix+"DDO_BR_DIAGNOSIS_DXCODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Internalname, AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxtype.SetProperty("Caption", Ddo_br_diagnosis_dxtype_Caption);
            ucDdo_br_diagnosis_dxtype.SetProperty("Tooltip", Ddo_br_diagnosis_dxtype_Tooltip);
            ucDdo_br_diagnosis_dxtype.SetProperty("Cls", Ddo_br_diagnosis_dxtype_Cls);
            ucDdo_br_diagnosis_dxtype.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxtype_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxtype.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxtype_Includesortasc);
            ucDdo_br_diagnosis_dxtype.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxtype_Includesortdsc);
            ucDdo_br_diagnosis_dxtype.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxtype_Includefilter);
            ucDdo_br_diagnosis_dxtype.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxtype_Includedatalist);
            ucDdo_br_diagnosis_dxtype.SetProperty("SortASC", Ddo_br_diagnosis_dxtype_Sortasc);
            ucDdo_br_diagnosis_dxtype.SetProperty("SortDSC", Ddo_br_diagnosis_dxtype_Sortdsc);
            ucDdo_br_diagnosis_dxtype.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxtype_Searchbuttontext);
            ucDdo_br_diagnosis_dxtype.SetProperty("DropDownOptionsTitleSettingsIcons", AV33DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxtype.SetProperty("DropDownOptionsData", AV23BR_Diagnosis_DXTypeTitleFilterData);
            ucDdo_br_diagnosis_dxtype.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxtype_Internalname, sPrefix+"DDO_BR_DIAGNOSIS_DXTYPEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Internalname, AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_diagnosis_no_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV82TFBR_Diagnosis_No), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV82TFBR_Diagnosis_No), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_diagnosis_no_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_diagnosis_no_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_diagnosis_no_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV83TFBR_Diagnosis_No_To), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV83TFBR_Diagnosis_No_To), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_diagnosis_no_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_diagnosis_no_to_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_DiagnosisWC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 28 )
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

      protected void START242( )
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
               STRUP240( ) ;
            }
         }
      }

      protected void WS242( )
      {
         START242( ) ;
         EVT242( ) ;
      }

      protected void EVT242( )
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
                                 STRUP240( ) ;
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
                                 STRUP240( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E11242 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP240( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E12242 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_NO.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP240( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E13242 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXDESCRIPTION.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP240( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E14242 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXTSOURCE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP240( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E15242 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXID.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP240( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E16242 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXCODE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP240( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E17242 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXTYPE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP240( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E18242 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP240( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DoInsert' */
                                    E19242 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP240( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname;
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VUPDATE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VDELETE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VUPDATE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VDELETE.CLICK") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP240( ) ;
                              }
                              nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
                              SubsflControlProps_282( ) ;
                              AV43Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV43Display)) ? AV88Display_GXI : context.convertURL( context.PathToRelativeUrl( AV43Display))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV43Display), true);
                              AV39Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV39Update)) ? AV89Update_GXI : context.convertURL( context.PathToRelativeUrl( AV39Update))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV39Update), true);
                              AV41Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV41Delete)) ? AV90Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV41Delete))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV41Delete), true);
                              A513BR_Diagnosis_No = (long)(context.localUtil.CToN( cgiGet( edtBR_Diagnosis_No_Internalname), ".", ","));
                              n513BR_Diagnosis_No = false;
                              A64BR_DiagnosisID = (long)(context.localUtil.CToN( cgiGet( edtBR_DiagnosisID_Internalname), ".", ","));
                              A69BR_Diagnosis_DXDescription = cgiGet( edtBR_Diagnosis_DXDescription_Internalname);
                              n69BR_Diagnosis_DXDescription = false;
                              A68BR_Diagnosis_DXTsource = cgiGet( edtBR_Diagnosis_DXTsource_Internalname);
                              n68BR_Diagnosis_DXTsource = false;
                              A65BR_Diagnosis_DXID = cgiGet( edtBR_Diagnosis_DXID_Internalname);
                              n65BR_Diagnosis_DXID = false;
                              A66BR_Diagnosis_DXCode = cgiGet( edtBR_Diagnosis_DXCode_Internalname);
                              n66BR_Diagnosis_DXCode = false;
                              A67BR_Diagnosis_DXType = cgiGet( edtBR_Diagnosis_DXType_Internalname);
                              n67BR_Diagnosis_DXType = false;
                              cmbBR_Diagnosis_InitialDX.Name = cmbBR_Diagnosis_InitialDX_Internalname;
                              cmbBR_Diagnosis_InitialDX.CurrentValue = cgiGet( cmbBR_Diagnosis_InitialDX_Internalname);
                              A70BR_Diagnosis_InitialDX = cgiGet( cmbBR_Diagnosis_InitialDX_Internalname);
                              n70BR_Diagnosis_InitialDX = false;
                              cmbBR_Diagnosis_MetastasesDX.Name = cmbBR_Diagnosis_MetastasesDX_Internalname;
                              cmbBR_Diagnosis_MetastasesDX.CurrentValue = cgiGet( cmbBR_Diagnosis_MetastasesDX_Internalname);
                              A71BR_Diagnosis_MetastasesDX = cgiGet( cmbBR_Diagnosis_MetastasesDX_Internalname);
                              n71BR_Diagnosis_MetastasesDX = false;
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
                                          GX_FocusControl = edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E20242 ();
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
                                          GX_FocusControl = edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E21242 ();
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
                                          GX_FocusControl = edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E22242 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VUPDATE.CLICK") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E23242 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VDELETE.CLICK") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E24242 ();
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
                                             /* Set Refresh If Tfbr_diagnosis_no Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_DIAGNOSIS_NO"), ".", ",") != Convert.ToDecimal( AV82TFBR_Diagnosis_No )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_diagnosis_no_to Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_DIAGNOSIS_NO_TO"), ".", ",") != Convert.ToDecimal( AV83TFBR_Diagnosis_No_To )) )
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
                                       STRUP240( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname;
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

      protected void WE242( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm242( ) ;
            }
         }
      }

      protected void PA242( )
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
               GX_FocusControl = edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname;
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
         SubsflControlProps_282( ) ;
         while ( nGXsfl_28_idx <= nRC_GXsfl_28 )
         {
            sendrow_282( ) ;
            nGXsfl_28_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV14OrderedBy ,
                                       bool AV15OrderedDsc ,
                                       long AV82TFBR_Diagnosis_No ,
                                       long AV83TFBR_Diagnosis_No_To ,
                                       long AV8BR_EncounterID ,
                                       String AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace ,
                                       String AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace ,
                                       String AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace ,
                                       String AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace ,
                                       String AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace ,
                                       String AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace ,
                                       String AV91Pgmname ,
                                       bool AV44IsAuthorized_Display ,
                                       bool AV40IsAuthorized_Update ,
                                       bool AV42IsAuthorized_Delete ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF242( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_DIAGNOSISID", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_DIAGNOSISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A64BR_DiagnosisID), 18, 0, ".", "")));
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
         RF242( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV91Pgmname = "BR_EncounterUpdateBR_DiagnosisWC";
         context.Gx_err = 0;
      }

      protected void RF242( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E21242 ();
         nGXsfl_28_idx = 1;
         sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
         SubsflControlProps_282( ) ;
         bGXsfl_28_Refreshing = true;
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
            SubsflControlProps_282( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV82TFBR_Diagnosis_No ,
                                                 AV83TFBR_Diagnosis_No_To ,
                                                 A513BR_Diagnosis_No ,
                                                 AV14OrderedBy ,
                                                 AV15OrderedDsc ,
                                                 A19BR_EncounterID ,
                                                 AV8BR_EncounterID } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H00242 */
            pr_default.execute(0, new Object[] {AV8BR_EncounterID, AV82TFBR_Diagnosis_No, AV83TFBR_Diagnosis_No_To, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A19BR_EncounterID = H00242_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               A71BR_Diagnosis_MetastasesDX = H00242_A71BR_Diagnosis_MetastasesDX[0];
               n71BR_Diagnosis_MetastasesDX = H00242_n71BR_Diagnosis_MetastasesDX[0];
               A70BR_Diagnosis_InitialDX = H00242_A70BR_Diagnosis_InitialDX[0];
               n70BR_Diagnosis_InitialDX = H00242_n70BR_Diagnosis_InitialDX[0];
               A67BR_Diagnosis_DXType = H00242_A67BR_Diagnosis_DXType[0];
               n67BR_Diagnosis_DXType = H00242_n67BR_Diagnosis_DXType[0];
               A66BR_Diagnosis_DXCode = H00242_A66BR_Diagnosis_DXCode[0];
               n66BR_Diagnosis_DXCode = H00242_n66BR_Diagnosis_DXCode[0];
               A65BR_Diagnosis_DXID = H00242_A65BR_Diagnosis_DXID[0];
               n65BR_Diagnosis_DXID = H00242_n65BR_Diagnosis_DXID[0];
               A68BR_Diagnosis_DXTsource = H00242_A68BR_Diagnosis_DXTsource[0];
               n68BR_Diagnosis_DXTsource = H00242_n68BR_Diagnosis_DXTsource[0];
               A69BR_Diagnosis_DXDescription = H00242_A69BR_Diagnosis_DXDescription[0];
               n69BR_Diagnosis_DXDescription = H00242_n69BR_Diagnosis_DXDescription[0];
               A64BR_DiagnosisID = H00242_A64BR_DiagnosisID[0];
               A513BR_Diagnosis_No = H00242_A513BR_Diagnosis_No[0];
               n513BR_Diagnosis_No = H00242_n513BR_Diagnosis_No[0];
               E22242 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB240( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes242( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_DIAGNOSISID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sPrefix+sGXsfl_28_idx, context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
                                              AV82TFBR_Diagnosis_No ,
                                              AV83TFBR_Diagnosis_No_To ,
                                              A513BR_Diagnosis_No ,
                                              AV14OrderedBy ,
                                              AV15OrderedDsc ,
                                              A19BR_EncounterID ,
                                              AV8BR_EncounterID } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H00243 */
         pr_default.execute(1, new Object[] {AV8BR_EncounterID, AV82TFBR_Diagnosis_No, AV83TFBR_Diagnosis_No_To});
         GRID_nRecordCount = H00243_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV82TFBR_Diagnosis_No, AV83TFBR_Diagnosis_No_To, AV8BR_EncounterID, AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV91Pgmname, AV44IsAuthorized_Display, AV40IsAuthorized_Update, AV42IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV82TFBR_Diagnosis_No, AV83TFBR_Diagnosis_No_To, AV8BR_EncounterID, AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV91Pgmname, AV44IsAuthorized_Display, AV40IsAuthorized_Update, AV42IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV82TFBR_Diagnosis_No, AV83TFBR_Diagnosis_No_To, AV8BR_EncounterID, AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV91Pgmname, AV44IsAuthorized_Display, AV40IsAuthorized_Update, AV42IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV82TFBR_Diagnosis_No, AV83TFBR_Diagnosis_No_To, AV8BR_EncounterID, AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV91Pgmname, AV44IsAuthorized_Display, AV40IsAuthorized_Update, AV42IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV82TFBR_Diagnosis_No, AV83TFBR_Diagnosis_No_To, AV8BR_EncounterID, AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV91Pgmname, AV44IsAuthorized_Display, AV40IsAuthorized_Update, AV42IsAuthorized_Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP240( )
      {
         /* Before Start, stand alone formulas. */
         AV91Pgmname = "BR_EncounterUpdateBR_DiagnosisWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E20242 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV33DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_DIAGNOSIS_NOTITLEFILTERDATA"), AV81BR_Diagnosis_NoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA"), AV27BR_Diagnosis_DXDescriptionTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA"), AV25BR_Diagnosis_DXTsourceTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_DIAGNOSIS_DXIDTITLEFILTERDATA"), AV19BR_Diagnosis_DXIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_DIAGNOSIS_DXCODETITLEFILTERDATA"), AV21BR_Diagnosis_DXCodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA"), AV23BR_Diagnosis_DXTypeTitleFilterData);
            /* Read variables values. */
            AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace", AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace);
            AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace", AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace);
            AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace", AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace);
            AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace", AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace);
            AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace", AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace);
            AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace", AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace);
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_diagnosis_no_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_diagnosis_no_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_DIAGNOSIS_NO");
               GX_FocusControl = edtavTfbr_diagnosis_no_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV82TFBR_Diagnosis_No = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV82TFBR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(AV82TFBR_Diagnosis_No), 10, 0)));
            }
            else
            {
               AV82TFBR_Diagnosis_No = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_diagnosis_no_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV82TFBR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(AV82TFBR_Diagnosis_No), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_diagnosis_no_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_diagnosis_no_to_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_DIAGNOSIS_NO_TO");
               GX_FocusControl = edtavTfbr_diagnosis_no_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV83TFBR_Diagnosis_No_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV83TFBR_Diagnosis_No_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV83TFBR_Diagnosis_No_To), 10, 0)));
            }
            else
            {
               AV83TFBR_Diagnosis_No_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_diagnosis_no_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV83TFBR_Diagnosis_No_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV83TFBR_Diagnosis_No_To), 10, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_28"), ".", ","));
            AV36GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV85GridPageCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGECOUNT"), ".", ","));
            wcpOAV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_EncounterID"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_tableheader_Width = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Cls = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autoscroll"));
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
            Ddo_br_diagnosis_no_Caption = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Caption");
            Ddo_br_diagnosis_no_Tooltip = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Tooltip");
            Ddo_br_diagnosis_no_Cls = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Cls");
            Ddo_br_diagnosis_no_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Filteredtext_set");
            Ddo_br_diagnosis_no_Filteredtextto_set = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Filteredtextto_set");
            Ddo_br_diagnosis_no_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Dropdownoptionstype");
            Ddo_br_diagnosis_no_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_no_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Includesortasc"));
            Ddo_br_diagnosis_no_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Includesortdsc"));
            Ddo_br_diagnosis_no_Sortedstatus = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Sortedstatus");
            Ddo_br_diagnosis_no_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Includefilter"));
            Ddo_br_diagnosis_no_Filtertype = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Filtertype");
            Ddo_br_diagnosis_no_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Filterisrange"));
            Ddo_br_diagnosis_no_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Includedatalist"));
            Ddo_br_diagnosis_no_Sortasc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Sortasc");
            Ddo_br_diagnosis_no_Sortdsc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Sortdsc");
            Ddo_br_diagnosis_no_Cleanfilter = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Cleanfilter");
            Ddo_br_diagnosis_no_Rangefilterfrom = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Rangefilterfrom");
            Ddo_br_diagnosis_no_Rangefilterto = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Rangefilterto");
            Ddo_br_diagnosis_no_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Searchbuttontext");
            Ddo_br_diagnosis_dxdescription_Caption = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Caption");
            Ddo_br_diagnosis_dxdescription_Tooltip = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Tooltip");
            Ddo_br_diagnosis_dxdescription_Cls = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Cls");
            Ddo_br_diagnosis_dxdescription_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Dropdownoptionstype");
            Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxdescription_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includesortasc"));
            Ddo_br_diagnosis_dxdescription_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includesortdsc"));
            Ddo_br_diagnosis_dxdescription_Sortedstatus = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortedstatus");
            Ddo_br_diagnosis_dxdescription_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includefilter"));
            Ddo_br_diagnosis_dxdescription_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includedatalist"));
            Ddo_br_diagnosis_dxdescription_Sortasc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortasc");
            Ddo_br_diagnosis_dxdescription_Sortdsc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortdsc");
            Ddo_br_diagnosis_dxdescription_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Searchbuttontext");
            Ddo_br_diagnosis_dxtsource_Caption = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Caption");
            Ddo_br_diagnosis_dxtsource_Tooltip = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Tooltip");
            Ddo_br_diagnosis_dxtsource_Cls = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Cls");
            Ddo_br_diagnosis_dxtsource_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Dropdownoptionstype");
            Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxtsource_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Includesortasc"));
            Ddo_br_diagnosis_dxtsource_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Includesortdsc"));
            Ddo_br_diagnosis_dxtsource_Sortedstatus = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Sortedstatus");
            Ddo_br_diagnosis_dxtsource_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Includefilter"));
            Ddo_br_diagnosis_dxtsource_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Includedatalist"));
            Ddo_br_diagnosis_dxtsource_Sortasc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Sortasc");
            Ddo_br_diagnosis_dxtsource_Sortdsc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Sortdsc");
            Ddo_br_diagnosis_dxtsource_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Searchbuttontext");
            Ddo_br_diagnosis_dxid_Caption = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Caption");
            Ddo_br_diagnosis_dxid_Tooltip = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Tooltip");
            Ddo_br_diagnosis_dxid_Cls = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Cls");
            Ddo_br_diagnosis_dxid_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Dropdownoptionstype");
            Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxid_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Includesortasc"));
            Ddo_br_diagnosis_dxid_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Includesortdsc"));
            Ddo_br_diagnosis_dxid_Sortedstatus = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Sortedstatus");
            Ddo_br_diagnosis_dxid_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Includefilter"));
            Ddo_br_diagnosis_dxid_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Includedatalist"));
            Ddo_br_diagnosis_dxid_Sortasc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Sortasc");
            Ddo_br_diagnosis_dxid_Sortdsc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Sortdsc");
            Ddo_br_diagnosis_dxid_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Searchbuttontext");
            Ddo_br_diagnosis_dxcode_Caption = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Caption");
            Ddo_br_diagnosis_dxcode_Tooltip = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Tooltip");
            Ddo_br_diagnosis_dxcode_Cls = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Cls");
            Ddo_br_diagnosis_dxcode_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Dropdownoptionstype");
            Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxcode_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Includesortasc"));
            Ddo_br_diagnosis_dxcode_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Includesortdsc"));
            Ddo_br_diagnosis_dxcode_Sortedstatus = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Sortedstatus");
            Ddo_br_diagnosis_dxcode_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Includefilter"));
            Ddo_br_diagnosis_dxcode_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Includedatalist"));
            Ddo_br_diagnosis_dxcode_Sortasc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Sortasc");
            Ddo_br_diagnosis_dxcode_Sortdsc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Sortdsc");
            Ddo_br_diagnosis_dxcode_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Searchbuttontext");
            Ddo_br_diagnosis_dxtype_Caption = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Caption");
            Ddo_br_diagnosis_dxtype_Tooltip = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Tooltip");
            Ddo_br_diagnosis_dxtype_Cls = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Cls");
            Ddo_br_diagnosis_dxtype_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Dropdownoptionstype");
            Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxtype_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Includesortasc"));
            Ddo_br_diagnosis_dxtype_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Includesortdsc"));
            Ddo_br_diagnosis_dxtype_Sortedstatus = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Sortedstatus");
            Ddo_br_diagnosis_dxtype_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Includefilter"));
            Ddo_br_diagnosis_dxtype_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Includedatalist"));
            Ddo_br_diagnosis_dxtype_Sortasc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Sortasc");
            Ddo_br_diagnosis_dxtype_Sortdsc = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Sortdsc");
            Ddo_br_diagnosis_dxtype_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_diagnosis_no_Activeeventkey = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Activeeventkey");
            Ddo_br_diagnosis_no_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Filteredtext_get");
            Ddo_br_diagnosis_no_Filteredtextto_get = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_NO_Filteredtextto_get");
            Ddo_br_diagnosis_dxdescription_Activeeventkey = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION_Activeeventkey");
            Ddo_br_diagnosis_dxtsource_Activeeventkey = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE_Activeeventkey");
            Ddo_br_diagnosis_dxid_Activeeventkey = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXID_Activeeventkey");
            Ddo_br_diagnosis_dxcode_Activeeventkey = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXCODE_Activeeventkey");
            Ddo_br_diagnosis_dxtype_Activeeventkey = cgiGet( sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_DIAGNOSIS_NO"), ".", ",") != Convert.ToDecimal( AV82TFBR_Diagnosis_No )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_DIAGNOSIS_NO_TO"), ".", ",") != Convert.ToDecimal( AV83TFBR_Diagnosis_No_To )) )
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
         E20242 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E20242( )
      {
         /* Start Routine */
         AV51tResult = AV54websession.Get("DAS_UserInfo");
         AV52tSDT_MicroUserInfo.FromJSonString(AV51tResult, null);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_diagnosis_no_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_diagnosis_no_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_diagnosis_no_Visible), 5, 0)), true);
         edtavTfbr_diagnosis_no_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_diagnosis_no_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_diagnosis_no_to_Visible), 5, 0)), true);
         Ddo_br_diagnosis_no_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_No";
         ucDdo_br_diagnosis_no.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_no_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_no_Titlecontrolidtoreplace);
         AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace = Ddo_br_diagnosis_no_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace", AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace);
         edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXDescription";
         ucDdo_br_diagnosis_dxdescription.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxdescription_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace);
         AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace", AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXTsource";
         ucDdo_br_diagnosis_dxtsource.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxtsource_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace);
         AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace", AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXID";
         ucDdo_br_diagnosis_dxid.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxid_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace);
         AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace", AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXCode";
         ucDdo_br_diagnosis_dxcode.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxcode_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace);
         AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace", AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXType";
         ucDdo_br_diagnosis_dxtype.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxtype_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace);
         AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace", AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV33DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV33DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E21242( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV81BR_Diagnosis_NoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Diagnosis_DXDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_Diagnosis_DXTsourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Diagnosis_DXIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Diagnosis_DXCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Diagnosis_DXTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Diagnosis_No_Titleformat = 2;
         edtBR_Diagnosis_No_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断次序", AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Diagnosis_No_Internalname, "Title", edtBR_Diagnosis_No_Title, !bGXsfl_28_Refreshing);
         edtBR_Diagnosis_DXDescription_Titleformat = 2;
         edtBR_Diagnosis_DXDescription_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断名称", AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Diagnosis_DXDescription_Internalname, "Title", edtBR_Diagnosis_DXDescription_Title, !bGXsfl_28_Refreshing);
         edtBR_Diagnosis_DXTsource_Titleformat = 2;
         edtBR_Diagnosis_DXTsource_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断来源", AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Diagnosis_DXTsource_Internalname, "Title", edtBR_Diagnosis_DXTsource_Title, !bGXsfl_28_Refreshing);
         edtBR_Diagnosis_DXID_Titleformat = 2;
         edtBR_Diagnosis_DXID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "疾病序号", AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Diagnosis_DXID_Internalname, "Title", edtBR_Diagnosis_DXID_Title, !bGXsfl_28_Refreshing);
         edtBR_Diagnosis_DXCode_Titleformat = 2;
         edtBR_Diagnosis_DXCode_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "疾病代码", AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Diagnosis_DXCode_Internalname, "Title", edtBR_Diagnosis_DXCode_Title, !bGXsfl_28_Refreshing);
         edtBR_Diagnosis_DXType_Titleformat = 2;
         edtBR_Diagnosis_DXType_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "疾病类型", AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Diagnosis_DXType_Internalname, "Title", edtBR_Diagnosis_DXType_Title, !bGXsfl_28_Refreshing);
         AV36GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV36GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36GridCurrentPage), 10, 0)));
         AV85GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV85GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV85GridPageCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV81BR_Diagnosis_NoTitleFilterData", AV81BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Diagnosis_DXDescriptionTitleFilterData", AV27BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Diagnosis_DXTsourceTitleFilterData", AV25BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Diagnosis_DXIDTitleFilterData", AV19BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Diagnosis_DXCodeTitleFilterData", AV21BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Diagnosis_DXTypeTitleFilterData", AV23BR_Diagnosis_DXTypeTitleFilterData);
      }

      protected void E11242( )
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
            AV35PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV35PageToGo) ;
         }
      }

      protected void E12242( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13242( )
      {
         /* Ddo_br_diagnosis_no_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_no_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_diagnosis_no_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_no.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_no_Internalname, "SortedStatus", Ddo_br_diagnosis_no_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_no_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_diagnosis_no_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_no.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_no_Internalname, "SortedStatus", Ddo_br_diagnosis_no_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_no_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV82TFBR_Diagnosis_No = (long)(NumberUtil.Val( Ddo_br_diagnosis_no_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV82TFBR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(AV82TFBR_Diagnosis_No), 10, 0)));
            AV83TFBR_Diagnosis_No_To = (long)(NumberUtil.Val( Ddo_br_diagnosis_no_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV83TFBR_Diagnosis_No_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV83TFBR_Diagnosis_No_To), 10, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV81BR_Diagnosis_NoTitleFilterData", AV81BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Diagnosis_DXDescriptionTitleFilterData", AV27BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Diagnosis_DXTsourceTitleFilterData", AV25BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Diagnosis_DXIDTitleFilterData", AV19BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Diagnosis_DXCodeTitleFilterData", AV21BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Diagnosis_DXTypeTitleFilterData", AV23BR_Diagnosis_DXTypeTitleFilterData);
      }

      protected void E14242( )
      {
         /* Ddo_br_diagnosis_dxdescription_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxdescription_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_diagnosis_dxdescription_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxdescription.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxdescription_Internalname, "SortedStatus", Ddo_br_diagnosis_dxdescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxdescription_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_diagnosis_dxdescription_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxdescription.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxdescription_Internalname, "SortedStatus", Ddo_br_diagnosis_dxdescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV81BR_Diagnosis_NoTitleFilterData", AV81BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Diagnosis_DXDescriptionTitleFilterData", AV27BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Diagnosis_DXTsourceTitleFilterData", AV25BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Diagnosis_DXIDTitleFilterData", AV19BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Diagnosis_DXCodeTitleFilterData", AV21BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Diagnosis_DXTypeTitleFilterData", AV23BR_Diagnosis_DXTypeTitleFilterData);
      }

      protected void E15242( )
      {
         /* Ddo_br_diagnosis_dxtsource_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtsource_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_diagnosis_dxtsource_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxtsource.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxtsource_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtsource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtsource_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_diagnosis_dxtsource_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxtsource.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxtsource_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtsource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV81BR_Diagnosis_NoTitleFilterData", AV81BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Diagnosis_DXDescriptionTitleFilterData", AV27BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Diagnosis_DXTsourceTitleFilterData", AV25BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Diagnosis_DXIDTitleFilterData", AV19BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Diagnosis_DXCodeTitleFilterData", AV21BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Diagnosis_DXTypeTitleFilterData", AV23BR_Diagnosis_DXTypeTitleFilterData);
      }

      protected void E16242( )
      {
         /* Ddo_br_diagnosis_dxid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_diagnosis_dxid_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxid.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxid_Internalname, "SortedStatus", Ddo_br_diagnosis_dxid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_diagnosis_dxid_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxid.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxid_Internalname, "SortedStatus", Ddo_br_diagnosis_dxid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV81BR_Diagnosis_NoTitleFilterData", AV81BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Diagnosis_DXDescriptionTitleFilterData", AV27BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Diagnosis_DXTsourceTitleFilterData", AV25BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Diagnosis_DXIDTitleFilterData", AV19BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Diagnosis_DXCodeTitleFilterData", AV21BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Diagnosis_DXTypeTitleFilterData", AV23BR_Diagnosis_DXTypeTitleFilterData);
      }

      protected void E17242( )
      {
         /* Ddo_br_diagnosis_dxcode_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxcode_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_diagnosis_dxcode_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxcode.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxcode_Internalname, "SortedStatus", Ddo_br_diagnosis_dxcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxcode_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_diagnosis_dxcode_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxcode.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxcode_Internalname, "SortedStatus", Ddo_br_diagnosis_dxcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV81BR_Diagnosis_NoTitleFilterData", AV81BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Diagnosis_DXDescriptionTitleFilterData", AV27BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Diagnosis_DXTsourceTitleFilterData", AV25BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Diagnosis_DXIDTitleFilterData", AV19BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Diagnosis_DXCodeTitleFilterData", AV21BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Diagnosis_DXTypeTitleFilterData", AV23BR_Diagnosis_DXTypeTitleFilterData);
      }

      protected void E18242( )
      {
         /* Ddo_br_diagnosis_dxtype_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtype_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_diagnosis_dxtype_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxtype.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxtype_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtype_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_diagnosis_dxtype_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxtype.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxtype_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV81BR_Diagnosis_NoTitleFilterData", AV81BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Diagnosis_DXDescriptionTitleFilterData", AV27BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Diagnosis_DXTsourceTitleFilterData", AV25BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Diagnosis_DXIDTitleFilterData", AV19BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Diagnosis_DXCodeTitleFilterData", AV21BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Diagnosis_DXTypeTitleFilterData", AV23BR_Diagnosis_DXTypeTitleFilterData);
      }

      private void E22242( )
      {
         /* Grid_Load Routine */
         AV43Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDisplay_Internalname, AV43Display);
         AV88Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         if ( AV44IsAuthorized_Display )
         {
            edtavDisplay_Link = formatLink("br_diagnosisview.aspx") + "?" + UrlEncode("" +A64BR_DiagnosisID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         AV39Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavUpdate_Internalname, AV39Update);
         AV89Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV40IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_diagnosis.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A64BR_DiagnosisID);
         }
         AV41Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDelete_Internalname, AV41Delete);
         AV90Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV42IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_diagnosis.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A64BR_DiagnosisID);
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 28;
         }
         sendrow_282( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_28_Refreshing )
         {
            context.DoAjaxLoad(28, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E19242( )
      {
         /* 'DoInsert' Routine */
         if ( 1 == 0 )
         {
            CallWebObject(formatLink("br_diagnosis.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
            context.wjLocDisableFrm = 1;
         }
         CallWebObject(formatLink("br_diagnosisinsert.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_diagnosis_no_Sortedstatus = "";
         ucDdo_br_diagnosis_no.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_no_Internalname, "SortedStatus", Ddo_br_diagnosis_no_Sortedstatus);
         Ddo_br_diagnosis_dxdescription_Sortedstatus = "";
         ucDdo_br_diagnosis_dxdescription.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxdescription_Internalname, "SortedStatus", Ddo_br_diagnosis_dxdescription_Sortedstatus);
         Ddo_br_diagnosis_dxtsource_Sortedstatus = "";
         ucDdo_br_diagnosis_dxtsource.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxtsource_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtsource_Sortedstatus);
         Ddo_br_diagnosis_dxid_Sortedstatus = "";
         ucDdo_br_diagnosis_dxid.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxid_Internalname, "SortedStatus", Ddo_br_diagnosis_dxid_Sortedstatus);
         Ddo_br_diagnosis_dxcode_Sortedstatus = "";
         ucDdo_br_diagnosis_dxcode.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxcode_Internalname, "SortedStatus", Ddo_br_diagnosis_dxcode_Sortedstatus);
         Ddo_br_diagnosis_dxtype_Sortedstatus = "";
         ucDdo_br_diagnosis_dxtype.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxtype_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtype_Sortedstatus);
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
            Ddo_br_diagnosis_no_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_diagnosis_no.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_no_Internalname, "SortedStatus", Ddo_br_diagnosis_no_Sortedstatus);
         }
         else if ( AV14OrderedBy == 2 )
         {
            Ddo_br_diagnosis_dxdescription_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_diagnosis_dxdescription.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxdescription_Internalname, "SortedStatus", Ddo_br_diagnosis_dxdescription_Sortedstatus);
         }
         else if ( AV14OrderedBy == 3 )
         {
            Ddo_br_diagnosis_dxtsource_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_diagnosis_dxtsource.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxtsource_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtsource_Sortedstatus);
         }
         else if ( AV14OrderedBy == 4 )
         {
            Ddo_br_diagnosis_dxid_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_diagnosis_dxid.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxid_Internalname, "SortedStatus", Ddo_br_diagnosis_dxid_Sortedstatus);
         }
         else if ( AV14OrderedBy == 5 )
         {
            Ddo_br_diagnosis_dxcode_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_diagnosis_dxcode.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxcode_Internalname, "SortedStatus", Ddo_br_diagnosis_dxcode_Sortedstatus);
         }
         else if ( AV14OrderedBy == 6 )
         {
            Ddo_br_diagnosis_dxtype_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_diagnosis_dxtype.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_dxtype_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtype_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV44IsAuthorized_Display;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean2) ;
         AV44IsAuthorized_Display = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV44IsAuthorized_Display", AV44IsAuthorized_Display);
         if ( ! ( AV44IsAuthorized_Display ) )
         {
            edtavDisplay_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDisplay_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV40IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean2) ;
         AV40IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV40IsAuthorized_Update", AV40IsAuthorized_Update);
         if ( ! ( AV40IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV42IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean2) ;
         AV42IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV42IsAuthorized_Delete", AV42IsAuthorized_Delete);
         if ( ! ( AV42IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV45TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean2) ;
         AV45TempBoolean = GXt_boolean2;
         if ( ! ( AV45TempBoolean ) )
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
            if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_DIAGNOSIS_NO") == 0 )
            {
               AV82TFBR_Diagnosis_No = (long)(NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV82TFBR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(AV82TFBR_Diagnosis_No), 10, 0)));
               AV83TFBR_Diagnosis_No_To = (long)(NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV83TFBR_Diagnosis_No_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV83TFBR_Diagnosis_No_To), 10, 0)));
               if ( ! (0==AV82TFBR_Diagnosis_No) )
               {
                  Ddo_br_diagnosis_no_Filteredtext_set = StringUtil.Str( (decimal)(AV82TFBR_Diagnosis_No), 10, 0);
                  ucDdo_br_diagnosis_no.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_no_Internalname, "FilteredText_set", Ddo_br_diagnosis_no_Filteredtext_set);
               }
               if ( ! (0==AV83TFBR_Diagnosis_No_To) )
               {
                  Ddo_br_diagnosis_no_Filteredtextto_set = StringUtil.Str( (decimal)(AV83TFBR_Diagnosis_No_To), 10, 0);
                  ucDdo_br_diagnosis_no.SendProperty(context, sPrefix, false, Ddo_br_diagnosis_no_Internalname, "FilteredTextTo_set", Ddo_br_diagnosis_no_Filteredtextto_set);
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
         if ( ! ( (0==AV82TFBR_Diagnosis_No) && (0==AV83TFBR_Diagnosis_No_To) ) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_DIAGNOSIS_NO";
            AV13GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV82TFBR_Diagnosis_No), 10, 0);
            AV13GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV83TFBR_Diagnosis_No_To), 10, 0);
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
         AV10TrnContext.gxTpr_Transactionname = "BR_Diagnosis";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV16Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void E23242( )
      {
         /* Update_Click Routine */
         new zutil_checksession(context ).execute( out  AV80tCheckFlag) ;
         if ( ! AV80tCheckFlag )
         {
            CallWebObject(formatLink("br_diagnosisupdate.aspx") + "?" + UrlEncode("" +A64BR_DiagnosisID));
            context.wjLocDisableFrm = 1;
         }
      }

      protected void E24242( )
      {
         /* Delete_Click Routine */
         new zutil_checksession(context ).execute( out  AV80tCheckFlag) ;
         if ( ! AV80tCheckFlag )
         {
            CallWebObject(formatLink("br_diagnosisdelete.aspx") + "?" + UrlEncode("" +A64BR_DiagnosisID));
            context.wjLocDisableFrm = 1;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
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
         PA242( ) ;
         WS242( ) ;
         WE242( ) ;
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
         sCtrlAV8BR_EncounterID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA242( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encounterupdatebr_diagnosiswc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA242( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV8BR_EncounterID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
         }
         wcpOAV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_EncounterID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( AV8BR_EncounterID != wcpOAV8BR_EncounterID ) ) )
         {
            setjustcreated();
         }
         wcpOAV8BR_EncounterID = AV8BR_EncounterID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV8BR_EncounterID = cgiGet( sPrefix+"AV8BR_EncounterID_CTRL");
         if ( StringUtil.Len( sCtrlAV8BR_EncounterID) > 0 )
         {
            AV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sCtrlAV8BR_EncounterID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
         }
         else
         {
            AV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"AV8BR_EncounterID_PARM"), ".", ","));
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
         PA242( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS242( ) ;
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
         WS242( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_EncounterID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_EncounterID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8BR_EncounterID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_EncounterID_CTRL", StringUtil.RTrim( sCtrlAV8BR_EncounterID));
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
         WE242( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815750", true);
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
         context.AddJavascriptSource("br_encounterupdatebr_diagnosiswc.js", "?202022815751", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_28_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_28_idx;
         edtBR_Diagnosis_No_Internalname = sPrefix+"BR_DIAGNOSIS_NO_"+sGXsfl_28_idx;
         edtBR_DiagnosisID_Internalname = sPrefix+"BR_DIAGNOSISID_"+sGXsfl_28_idx;
         edtBR_Diagnosis_DXDescription_Internalname = sPrefix+"BR_DIAGNOSIS_DXDESCRIPTION_"+sGXsfl_28_idx;
         edtBR_Diagnosis_DXTsource_Internalname = sPrefix+"BR_DIAGNOSIS_DXTSOURCE_"+sGXsfl_28_idx;
         edtBR_Diagnosis_DXID_Internalname = sPrefix+"BR_DIAGNOSIS_DXID_"+sGXsfl_28_idx;
         edtBR_Diagnosis_DXCode_Internalname = sPrefix+"BR_DIAGNOSIS_DXCODE_"+sGXsfl_28_idx;
         edtBR_Diagnosis_DXType_Internalname = sPrefix+"BR_DIAGNOSIS_DXTYPE_"+sGXsfl_28_idx;
         cmbBR_Diagnosis_InitialDX_Internalname = sPrefix+"BR_DIAGNOSIS_INITIALDX_"+sGXsfl_28_idx;
         cmbBR_Diagnosis_MetastasesDX_Internalname = sPrefix+"BR_DIAGNOSIS_METASTASESDX_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_fel_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_28_fel_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_28_fel_idx;
         edtBR_Diagnosis_No_Internalname = sPrefix+"BR_DIAGNOSIS_NO_"+sGXsfl_28_fel_idx;
         edtBR_DiagnosisID_Internalname = sPrefix+"BR_DIAGNOSISID_"+sGXsfl_28_fel_idx;
         edtBR_Diagnosis_DXDescription_Internalname = sPrefix+"BR_DIAGNOSIS_DXDESCRIPTION_"+sGXsfl_28_fel_idx;
         edtBR_Diagnosis_DXTsource_Internalname = sPrefix+"BR_DIAGNOSIS_DXTSOURCE_"+sGXsfl_28_fel_idx;
         edtBR_Diagnosis_DXID_Internalname = sPrefix+"BR_DIAGNOSIS_DXID_"+sGXsfl_28_fel_idx;
         edtBR_Diagnosis_DXCode_Internalname = sPrefix+"BR_DIAGNOSIS_DXCODE_"+sGXsfl_28_fel_idx;
         edtBR_Diagnosis_DXType_Internalname = sPrefix+"BR_DIAGNOSIS_DXTYPE_"+sGXsfl_28_fel_idx;
         cmbBR_Diagnosis_InitialDX_Internalname = sPrefix+"BR_DIAGNOSIS_INITIALDX_"+sGXsfl_28_fel_idx;
         cmbBR_Diagnosis_MetastasesDX_Internalname = sPrefix+"BR_DIAGNOSIS_METASTASESDX_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB240( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_28_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_28_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_28_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDisplay_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV43Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV43Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV88Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV43Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV43Display)) ? AV88Display_GXI : context.PathToRelativeUrl( AV43Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDisplay_Visible,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV43Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavUpdate_Enabled!=0)&&(edtavUpdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV39Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV39Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV89Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV39Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV39Update)) ? AV89Update_GXI : context.PathToRelativeUrl( AV39Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUpdate_Jsonclick,"'"+sPrefix+"'"+",false,"+"'"+sPrefix+"EVUPDATE.CLICK."+sGXsfl_28_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV39Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDelete_Enabled!=0)&&(edtavDelete_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV41Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV41Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV90Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV41Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV41Delete)) ? AV90Delete_GXI : context.PathToRelativeUrl( AV41Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavDelete_Jsonclick,"'"+sPrefix+"'"+",false,"+"'"+sPrefix+"EVDELETE.CLICK."+sGXsfl_28_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV41Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_No_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A513BR_Diagnosis_No), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A513BR_Diagnosis_No), "ZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_No_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_DiagnosisID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A64BR_DiagnosisID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_DiagnosisID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXDescription_Internalname,(String)A69BR_Diagnosis_DXDescription,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXTsource_Internalname,(String)A68BR_Diagnosis_DXTsource,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXTsource_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXID_Internalname,(String)A65BR_Diagnosis_DXID,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXCode_Internalname,(String)A66BR_Diagnosis_DXCode,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXType_Internalname,(String)A67BR_Diagnosis_DXType,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( cmbBR_Diagnosis_InitialDX.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_DIAGNOSIS_INITIALDX_" + sGXsfl_28_idx;
               cmbBR_Diagnosis_InitialDX.Name = GXCCtl;
               cmbBR_Diagnosis_InitialDX.WebTags = "";
               cmbBR_Diagnosis_InitialDX.addItem("", "(请选择)", 0);
               cmbBR_Diagnosis_InitialDX.addItem("否", "否", 0);
               cmbBR_Diagnosis_InitialDX.addItem("是", "是", 0);
               cmbBR_Diagnosis_InitialDX.addItem("不详", "不详", 0);
               if ( cmbBR_Diagnosis_InitialDX.ItemCount > 0 )
               {
                  A70BR_Diagnosis_InitialDX = cmbBR_Diagnosis_InitialDX.getValidValue(A70BR_Diagnosis_InitialDX);
                  n70BR_Diagnosis_InitialDX = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Diagnosis_InitialDX,(String)cmbBR_Diagnosis_InitialDX_Internalname,StringUtil.RTrim( A70BR_Diagnosis_InitialDX),(short)1,(String)cmbBR_Diagnosis_InitialDX_Jsonclick,(short)0,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Diagnosis_InitialDX.CurrentValue = StringUtil.RTrim( A70BR_Diagnosis_InitialDX);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Diagnosis_InitialDX_Internalname, "Values", (String)(cmbBR_Diagnosis_InitialDX.ToJavascriptSource()), !bGXsfl_28_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( cmbBR_Diagnosis_MetastasesDX.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_DIAGNOSIS_METASTASESDX_" + sGXsfl_28_idx;
               cmbBR_Diagnosis_MetastasesDX.Name = GXCCtl;
               cmbBR_Diagnosis_MetastasesDX.WebTags = "";
               cmbBR_Diagnosis_MetastasesDX.addItem("", "(请选择)", 0);
               cmbBR_Diagnosis_MetastasesDX.addItem("否", "否", 0);
               cmbBR_Diagnosis_MetastasesDX.addItem("是", "是", 0);
               cmbBR_Diagnosis_MetastasesDX.addItem("不详", "不详", 0);
               if ( cmbBR_Diagnosis_MetastasesDX.ItemCount > 0 )
               {
                  A71BR_Diagnosis_MetastasesDX = cmbBR_Diagnosis_MetastasesDX.getValidValue(A71BR_Diagnosis_MetastasesDX);
                  n71BR_Diagnosis_MetastasesDX = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Diagnosis_MetastasesDX,(String)cmbBR_Diagnosis_MetastasesDX_Internalname,StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX),(short)1,(String)cmbBR_Diagnosis_MetastasesDX_Jsonclick,(short)0,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Diagnosis_MetastasesDX.CurrentValue = StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Diagnosis_MetastasesDX_Internalname, "Values", (String)(cmbBR_Diagnosis_MetastasesDX.ToJavascriptSource()), !bGXsfl_28_Refreshing);
            send_integrity_lvl_hashes242( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_28_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
         }
         /* End function sendrow_282 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_DIAGNOSIS_INITIALDX_" + sGXsfl_28_idx;
         cmbBR_Diagnosis_InitialDX.Name = GXCCtl;
         cmbBR_Diagnosis_InitialDX.WebTags = "";
         cmbBR_Diagnosis_InitialDX.addItem("", "(请选择)", 0);
         cmbBR_Diagnosis_InitialDX.addItem("否", "否", 0);
         cmbBR_Diagnosis_InitialDX.addItem("是", "是", 0);
         cmbBR_Diagnosis_InitialDX.addItem("不详", "不详", 0);
         if ( cmbBR_Diagnosis_InitialDX.ItemCount > 0 )
         {
         }
         GXCCtl = "BR_DIAGNOSIS_METASTASESDX_" + sGXsfl_28_idx;
         cmbBR_Diagnosis_MetastasesDX.Name = GXCCtl;
         cmbBR_Diagnosis_MetastasesDX.WebTags = "";
         cmbBR_Diagnosis_MetastasesDX.addItem("", "(请选择)", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("否", "否", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("是", "是", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("不详", "不详", 0);
         if ( cmbBR_Diagnosis_MetastasesDX.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = sPrefix+"BTNINSERT";
         divTableactions_Internalname = sPrefix+"TABLEACTIONS";
         divTableheader_Internalname = sPrefix+"TABLEHEADER";
         divLayout_tableheader_Internalname = sPrefix+"LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = sPrefix+"DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = sPrefix+"HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = sPrefix+"vDISPLAY";
         edtavUpdate_Internalname = sPrefix+"vUPDATE";
         edtavDelete_Internalname = sPrefix+"vDELETE";
         edtBR_Diagnosis_No_Internalname = sPrefix+"BR_DIAGNOSIS_NO";
         edtBR_DiagnosisID_Internalname = sPrefix+"BR_DIAGNOSISID";
         edtBR_Diagnosis_DXDescription_Internalname = sPrefix+"BR_DIAGNOSIS_DXDESCRIPTION";
         edtBR_Diagnosis_DXTsource_Internalname = sPrefix+"BR_DIAGNOSIS_DXTSOURCE";
         edtBR_Diagnosis_DXID_Internalname = sPrefix+"BR_DIAGNOSIS_DXID";
         edtBR_Diagnosis_DXCode_Internalname = sPrefix+"BR_DIAGNOSIS_DXCODE";
         edtBR_Diagnosis_DXType_Internalname = sPrefix+"BR_DIAGNOSIS_DXTYPE";
         cmbBR_Diagnosis_InitialDX_Internalname = sPrefix+"BR_DIAGNOSIS_INITIALDX";
         cmbBR_Diagnosis_MetastasesDX_Internalname = sPrefix+"BR_DIAGNOSIS_METASTASESDX";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_br_diagnosis_no_Internalname = sPrefix+"DDO_BR_DIAGNOSIS_NO";
         edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxdescription_Internalname = sPrefix+"DDO_BR_DIAGNOSIS_DXDESCRIPTION";
         edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxtsource_Internalname = sPrefix+"DDO_BR_DIAGNOSIS_DXTSOURCE";
         edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxid_Internalname = sPrefix+"DDO_BR_DIAGNOSIS_DXID";
         edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxcode_Internalname = sPrefix+"DDO_BR_DIAGNOSIS_DXCODE";
         edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxtype_Internalname = sPrefix+"DDO_BR_DIAGNOSIS_DXTYPE";
         edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         edtavTfbr_diagnosis_no_Internalname = sPrefix+"vTFBR_DIAGNOSIS_NO";
         edtavTfbr_diagnosis_no_to_Internalname = sPrefix+"vTFBR_DIAGNOSIS_NO_TO";
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
         cmbBR_Diagnosis_MetastasesDX_Jsonclick = "";
         cmbBR_Diagnosis_InitialDX_Jsonclick = "";
         edtBR_Diagnosis_DXType_Jsonclick = "";
         edtBR_Diagnosis_DXCode_Jsonclick = "";
         edtBR_Diagnosis_DXID_Jsonclick = "";
         edtBR_Diagnosis_DXTsource_Jsonclick = "";
         edtBR_Diagnosis_DXDescription_Jsonclick = "";
         edtBR_DiagnosisID_Jsonclick = "";
         edtBR_Diagnosis_No_Jsonclick = "";
         edtavDelete_Jsonclick = "";
         edtavDelete_Enabled = 1;
         edtavUpdate_Jsonclick = "";
         edtavUpdate_Enabled = 1;
         edtavTfbr_diagnosis_no_to_Jsonclick = "";
         edtavTfbr_diagnosis_no_to_Visible = 1;
         edtavTfbr_diagnosis_no_Jsonclick = "";
         edtavTfbr_diagnosis_no_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Diagnosis_DXType_Titleformat = 0;
         edtBR_Diagnosis_DXType_Title = "疾病类型";
         edtBR_Diagnosis_DXCode_Titleformat = 0;
         edtBR_Diagnosis_DXCode_Title = "疾病代码";
         edtBR_Diagnosis_DXID_Titleformat = 0;
         edtBR_Diagnosis_DXID_Title = "疾病序号";
         edtBR_Diagnosis_DXTsource_Titleformat = 0;
         edtBR_Diagnosis_DXTsource_Title = "诊断来源";
         edtBR_Diagnosis_DXDescription_Titleformat = 0;
         edtBR_Diagnosis_DXDescription_Title = "诊断名称";
         edtBR_Diagnosis_No_Titleformat = 0;
         edtBR_Diagnosis_No_Title = "诊断次序";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         edtavDisplay_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_diagnosis_dxtype_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxtype_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxtype_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxtype_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtype_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtype_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtype_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxtype_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxtype_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxtype_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxtype_Caption = "";
         Ddo_br_diagnosis_dxcode_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxcode_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxcode_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxcode_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxcode_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxcode_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxcode_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxcode_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxcode_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxcode_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxcode_Caption = "";
         Ddo_br_diagnosis_dxid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxid_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxid_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxid_Caption = "";
         Ddo_br_diagnosis_dxtsource_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxtsource_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxtsource_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxtsource_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtsource_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtsource_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtsource_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxtsource_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxtsource_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxtsource_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxtsource_Caption = "";
         Ddo_br_diagnosis_dxdescription_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxdescription_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxdescription_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxdescription_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxdescription_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxdescription_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxdescription_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxdescription_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxdescription_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxdescription_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxdescription_Caption = "";
         Ddo_br_diagnosis_no_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_no_Rangefilterto = "WWP_TSTo";
         Ddo_br_diagnosis_no_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_diagnosis_no_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_diagnosis_no_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_no_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_no_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_no_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_no_Filtertype = "Numeric";
         Ddo_br_diagnosis_no_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_no_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_no_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_no_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_no_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_no_Cls = "ColumnSettings";
         Ddo_br_diagnosis_no_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_no_Caption = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV82TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV81BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV85GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11242',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV82TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12242',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV82TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_NO.ONOPTIONCLICKED","{handler:'E13242',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV82TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_diagnosis_no_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'ActiveEventKey'},{av:'Ddo_br_diagnosis_no_Filteredtext_get',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'FilteredText_get'},{av:'Ddo_br_diagnosis_no_Filteredtextto_get',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_NO.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_no_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'AV82TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'Ddo_br_diagnosis_dxdescription_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxtsource_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxid_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxcode_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxtype_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV81BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV85GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXDESCRIPTION.ONOPTIONCLICKED","{handler:'E14242',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV82TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_diagnosis_dxdescription_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXDESCRIPTION.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxdescription_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_no_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxtsource_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxid_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxcode_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxtype_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV81BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV85GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTSOURCE.ONOPTIONCLICKED","{handler:'E15242',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV82TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_diagnosis_dxtsource_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTSOURCE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxtsource_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_no_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxdescription_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxid_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxcode_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxtype_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV81BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV85GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXID.ONOPTIONCLICKED","{handler:'E16242',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV82TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_diagnosis_dxid_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXID.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxid_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_no_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxdescription_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxtsource_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxcode_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxtype_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV81BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV85GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXCODE.ONOPTIONCLICKED","{handler:'E17242',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV82TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_diagnosis_dxcode_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXCODE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxcode_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_no_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxdescription_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxtsource_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxid_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxtype_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV81BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV85GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTYPE.ONOPTIONCLICKED","{handler:'E18242',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV82TFBR_Diagnosis_No',fld:'vTFBR_DIAGNOSIS_NO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Diagnosis_No_To',fld:'vTFBR_DIAGNOSIS_NO_TO',pic:'ZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV91Pgmname',fld:'vPGMNAME',pic:''},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_diagnosis_dxtype_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTYPE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxtype_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_no_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxdescription_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxtsource_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxid_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'Ddo_br_diagnosis_dxcode_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'AV81BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV25BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV19BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV23BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV85GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E22242',iparms:[{av:'AV44IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A64BR_DiagnosisID',fld:'BR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV40IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV42IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV43Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV39Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV41Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E19242',iparms:[{av:'A64BR_DiagnosisID',fld:'BR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VUPDATE.CLICK","{handler:'E23242',iparms:[{av:'A64BR_DiagnosisID',fld:'BR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VUPDATE.CLICK",",oparms:[]}");
         setEventMetadata("VDELETE.CLICK","{handler:'E24242',iparms:[{av:'A64BR_DiagnosisID',fld:'BR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VDELETE.CLICK",",oparms:[]}");
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
         Ddo_br_diagnosis_no_Activeeventkey = "";
         Ddo_br_diagnosis_no_Filteredtext_get = "";
         Ddo_br_diagnosis_no_Filteredtextto_get = "";
         Ddo_br_diagnosis_dxdescription_Activeeventkey = "";
         Ddo_br_diagnosis_dxtsource_Activeeventkey = "";
         Ddo_br_diagnosis_dxid_Activeeventkey = "";
         Ddo_br_diagnosis_dxcode_Activeeventkey = "";
         Ddo_br_diagnosis_dxtype_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace = "";
         AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = "";
         AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = "";
         AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = "";
         AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = "";
         AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = "";
         AV91Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV33DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV81BR_Diagnosis_NoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Diagnosis_DXDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_Diagnosis_DXTsourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Diagnosis_DXIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Diagnosis_DXCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Diagnosis_DXTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_diagnosis_no_Filteredtext_set = "";
         Ddo_br_diagnosis_no_Filteredtextto_set = "";
         Ddo_br_diagnosis_no_Sortedstatus = "";
         Ddo_br_diagnosis_dxdescription_Sortedstatus = "";
         Ddo_br_diagnosis_dxtsource_Sortedstatus = "";
         Ddo_br_diagnosis_dxid_Sortedstatus = "";
         Ddo_br_diagnosis_dxcode_Sortedstatus = "";
         Ddo_br_diagnosis_dxtype_Sortedstatus = "";
         GX_FocusControl = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV43Display = "";
         AV39Update = "";
         AV41Delete = "";
         A69BR_Diagnosis_DXDescription = "";
         A68BR_Diagnosis_DXTsource = "";
         A65BR_Diagnosis_DXID = "";
         A66BR_Diagnosis_DXCode = "";
         A67BR_Diagnosis_DXType = "";
         A70BR_Diagnosis_InitialDX = "";
         A71BR_Diagnosis_MetastasesDX = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_diagnosis_no = new GXUserControl();
         ucDdo_br_diagnosis_dxdescription = new GXUserControl();
         ucDdo_br_diagnosis_dxtsource = new GXUserControl();
         ucDdo_br_diagnosis_dxid = new GXUserControl();
         ucDdo_br_diagnosis_dxcode = new GXUserControl();
         ucDdo_br_diagnosis_dxtype = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV88Display_GXI = "";
         AV89Update_GXI = "";
         AV90Delete_GXI = "";
         scmdbuf = "";
         H00242_A19BR_EncounterID = new long[1] ;
         H00242_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         H00242_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         H00242_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         H00242_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         H00242_A67BR_Diagnosis_DXType = new String[] {""} ;
         H00242_n67BR_Diagnosis_DXType = new bool[] {false} ;
         H00242_A66BR_Diagnosis_DXCode = new String[] {""} ;
         H00242_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         H00242_A65BR_Diagnosis_DXID = new String[] {""} ;
         H00242_n65BR_Diagnosis_DXID = new bool[] {false} ;
         H00242_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         H00242_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         H00242_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         H00242_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         H00242_A64BR_DiagnosisID = new long[1] ;
         H00242_A513BR_Diagnosis_No = new long[1] ;
         H00242_n513BR_Diagnosis_No = new bool[] {false} ;
         H00243_AGRID_nRecordCount = new long[1] ;
         AV51tResult = "";
         AV54websession = context.GetSession();
         AV52tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV16Session = context.GetSession();
         AV12GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8BR_EncounterID = "";
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterupdatebr_diagnosiswc__default(),
            new Object[][] {
                new Object[] {
               H00242_A19BR_EncounterID, H00242_A71BR_Diagnosis_MetastasesDX, H00242_n71BR_Diagnosis_MetastasesDX, H00242_A70BR_Diagnosis_InitialDX, H00242_n70BR_Diagnosis_InitialDX, H00242_A67BR_Diagnosis_DXType, H00242_n67BR_Diagnosis_DXType, H00242_A66BR_Diagnosis_DXCode, H00242_n66BR_Diagnosis_DXCode, H00242_A65BR_Diagnosis_DXID,
               H00242_n65BR_Diagnosis_DXID, H00242_A68BR_Diagnosis_DXTsource, H00242_n68BR_Diagnosis_DXTsource, H00242_A69BR_Diagnosis_DXDescription, H00242_n69BR_Diagnosis_DXDescription, H00242_A64BR_DiagnosisID, H00242_A513BR_Diagnosis_No, H00242_n513BR_Diagnosis_No
               }
               , new Object[] {
               H00243_AGRID_nRecordCount
               }
            }
         );
         AV91Pgmname = "BR_EncounterUpdateBR_DiagnosisWC";
         /* GeneXus formulas. */
         AV91Pgmname = "BR_EncounterUpdateBR_DiagnosisWC";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_28 ;
      private short nGXsfl_28_idx=1 ;
      private short GRID_nEOF ;
      private short AV14OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_Diagnosis_No_Titleformat ;
      private short edtBR_Diagnosis_DXDescription_Titleformat ;
      private short edtBR_Diagnosis_DXTsource_Titleformat ;
      private short edtBR_Diagnosis_DXID_Titleformat ;
      private short edtBR_Diagnosis_DXCode_Titleformat ;
      private short edtBR_Diagnosis_DXType_Titleformat ;
      private short subGrid_Sortable ;
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
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavDisplay_Visible ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_diagnosis_no_Visible ;
      private int edtavTfbr_diagnosis_no_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV35PageToGo ;
      private int AV92GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private long AV8BR_EncounterID ;
      private long wcpOAV8BR_EncounterID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV82TFBR_Diagnosis_No ;
      private long AV83TFBR_Diagnosis_No_To ;
      private long AV36GridCurrentPage ;
      private long AV85GridPageCount ;
      private long A513BR_Diagnosis_No ;
      private long A64BR_DiagnosisID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_diagnosis_no_Activeeventkey ;
      private String Ddo_br_diagnosis_no_Filteredtext_get ;
      private String Ddo_br_diagnosis_no_Filteredtextto_get ;
      private String Ddo_br_diagnosis_dxdescription_Activeeventkey ;
      private String Ddo_br_diagnosis_dxtsource_Activeeventkey ;
      private String Ddo_br_diagnosis_dxid_Activeeventkey ;
      private String Ddo_br_diagnosis_dxcode_Activeeventkey ;
      private String Ddo_br_diagnosis_dxtype_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_28_idx="0001" ;
      private String AV91Pgmname ;
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
      private String Ddo_br_diagnosis_no_Caption ;
      private String Ddo_br_diagnosis_no_Tooltip ;
      private String Ddo_br_diagnosis_no_Cls ;
      private String Ddo_br_diagnosis_no_Filteredtext_set ;
      private String Ddo_br_diagnosis_no_Filteredtextto_set ;
      private String Ddo_br_diagnosis_no_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_no_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_no_Sortedstatus ;
      private String Ddo_br_diagnosis_no_Filtertype ;
      private String Ddo_br_diagnosis_no_Sortasc ;
      private String Ddo_br_diagnosis_no_Sortdsc ;
      private String Ddo_br_diagnosis_no_Cleanfilter ;
      private String Ddo_br_diagnosis_no_Rangefilterfrom ;
      private String Ddo_br_diagnosis_no_Rangefilterto ;
      private String Ddo_br_diagnosis_no_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxdescription_Caption ;
      private String Ddo_br_diagnosis_dxdescription_Tooltip ;
      private String Ddo_br_diagnosis_dxdescription_Cls ;
      private String Ddo_br_diagnosis_dxdescription_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxdescription_Sortedstatus ;
      private String Ddo_br_diagnosis_dxdescription_Sortasc ;
      private String Ddo_br_diagnosis_dxdescription_Sortdsc ;
      private String Ddo_br_diagnosis_dxdescription_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxtsource_Caption ;
      private String Ddo_br_diagnosis_dxtsource_Tooltip ;
      private String Ddo_br_diagnosis_dxtsource_Cls ;
      private String Ddo_br_diagnosis_dxtsource_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxtsource_Sortedstatus ;
      private String Ddo_br_diagnosis_dxtsource_Sortasc ;
      private String Ddo_br_diagnosis_dxtsource_Sortdsc ;
      private String Ddo_br_diagnosis_dxtsource_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxid_Caption ;
      private String Ddo_br_diagnosis_dxid_Tooltip ;
      private String Ddo_br_diagnosis_dxid_Cls ;
      private String Ddo_br_diagnosis_dxid_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxid_Sortedstatus ;
      private String Ddo_br_diagnosis_dxid_Sortasc ;
      private String Ddo_br_diagnosis_dxid_Sortdsc ;
      private String Ddo_br_diagnosis_dxid_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxcode_Caption ;
      private String Ddo_br_diagnosis_dxcode_Tooltip ;
      private String Ddo_br_diagnosis_dxcode_Cls ;
      private String Ddo_br_diagnosis_dxcode_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxcode_Sortedstatus ;
      private String Ddo_br_diagnosis_dxcode_Sortasc ;
      private String Ddo_br_diagnosis_dxcode_Sortdsc ;
      private String Ddo_br_diagnosis_dxcode_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxtype_Caption ;
      private String Ddo_br_diagnosis_dxtype_Tooltip ;
      private String Ddo_br_diagnosis_dxtype_Cls ;
      private String Ddo_br_diagnosis_dxtype_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxtype_Sortedstatus ;
      private String Ddo_br_diagnosis_dxtype_Sortasc ;
      private String Ddo_br_diagnosis_dxtype_Sortdsc ;
      private String Ddo_br_diagnosis_dxtype_Searchbuttontext ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTablegridheader_Internalname ;
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
      private String edtBR_Diagnosis_No_Title ;
      private String edtBR_Diagnosis_DXDescription_Title ;
      private String edtBR_Diagnosis_DXTsource_Title ;
      private String edtBR_Diagnosis_DXID_Title ;
      private String edtBR_Diagnosis_DXCode_Title ;
      private String edtBR_Diagnosis_DXType_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_diagnosis_no_Internalname ;
      private String edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxdescription_Internalname ;
      private String edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxtsource_Internalname ;
      private String edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxid_Internalname ;
      private String edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxcode_Internalname ;
      private String edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxtype_Internalname ;
      private String edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_diagnosis_no_Internalname ;
      private String edtavTfbr_diagnosis_no_Jsonclick ;
      private String edtavTfbr_diagnosis_no_to_Internalname ;
      private String edtavTfbr_diagnosis_no_to_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_Diagnosis_No_Internalname ;
      private String edtBR_DiagnosisID_Internalname ;
      private String edtBR_Diagnosis_DXDescription_Internalname ;
      private String edtBR_Diagnosis_DXTsource_Internalname ;
      private String edtBR_Diagnosis_DXID_Internalname ;
      private String edtBR_Diagnosis_DXCode_Internalname ;
      private String edtBR_Diagnosis_DXType_Internalname ;
      private String cmbBR_Diagnosis_InitialDX_Internalname ;
      private String cmbBR_Diagnosis_MetastasesDX_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV8BR_EncounterID ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Diagnosis_No_Jsonclick ;
      private String edtBR_DiagnosisID_Jsonclick ;
      private String edtBR_Diagnosis_DXDescription_Jsonclick ;
      private String edtBR_Diagnosis_DXTsource_Jsonclick ;
      private String edtBR_Diagnosis_DXID_Jsonclick ;
      private String edtBR_Diagnosis_DXCode_Jsonclick ;
      private String edtBR_Diagnosis_DXType_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Diagnosis_InitialDX_Jsonclick ;
      private String cmbBR_Diagnosis_MetastasesDX_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV15OrderedDsc ;
      private bool AV44IsAuthorized_Display ;
      private bool AV40IsAuthorized_Update ;
      private bool AV42IsAuthorized_Delete ;
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
      private bool Ddo_br_diagnosis_no_Includesortasc ;
      private bool Ddo_br_diagnosis_no_Includesortdsc ;
      private bool Ddo_br_diagnosis_no_Includefilter ;
      private bool Ddo_br_diagnosis_no_Filterisrange ;
      private bool Ddo_br_diagnosis_no_Includedatalist ;
      private bool Ddo_br_diagnosis_dxdescription_Includesortasc ;
      private bool Ddo_br_diagnosis_dxdescription_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxdescription_Includefilter ;
      private bool Ddo_br_diagnosis_dxdescription_Includedatalist ;
      private bool Ddo_br_diagnosis_dxtsource_Includesortasc ;
      private bool Ddo_br_diagnosis_dxtsource_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxtsource_Includefilter ;
      private bool Ddo_br_diagnosis_dxtsource_Includedatalist ;
      private bool Ddo_br_diagnosis_dxid_Includesortasc ;
      private bool Ddo_br_diagnosis_dxid_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxid_Includefilter ;
      private bool Ddo_br_diagnosis_dxid_Includedatalist ;
      private bool Ddo_br_diagnosis_dxcode_Includesortasc ;
      private bool Ddo_br_diagnosis_dxcode_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxcode_Includefilter ;
      private bool Ddo_br_diagnosis_dxcode_Includedatalist ;
      private bool Ddo_br_diagnosis_dxtype_Includesortasc ;
      private bool Ddo_br_diagnosis_dxtype_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxtype_Includefilter ;
      private bool Ddo_br_diagnosis_dxtype_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool n513BR_Diagnosis_No ;
      private bool n69BR_Diagnosis_DXDescription ;
      private bool n68BR_Diagnosis_DXTsource ;
      private bool n65BR_Diagnosis_DXID ;
      private bool n66BR_Diagnosis_DXCode ;
      private bool n67BR_Diagnosis_DXType ;
      private bool n70BR_Diagnosis_InitialDX ;
      private bool n71BR_Diagnosis_MetastasesDX ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV45TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV80tCheckFlag ;
      private bool AV43Display_IsBlob ;
      private bool AV39Update_IsBlob ;
      private bool AV41Delete_IsBlob ;
      private String AV84ddo_BR_Diagnosis_NoTitleControlIdToReplace ;
      private String AV28ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace ;
      private String AV26ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace ;
      private String AV20ddo_BR_Diagnosis_DXIDTitleControlIdToReplace ;
      private String AV22ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace ;
      private String AV24ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace ;
      private String A69BR_Diagnosis_DXDescription ;
      private String A68BR_Diagnosis_DXTsource ;
      private String A65BR_Diagnosis_DXID ;
      private String A66BR_Diagnosis_DXCode ;
      private String A67BR_Diagnosis_DXType ;
      private String A70BR_Diagnosis_InitialDX ;
      private String A71BR_Diagnosis_MetastasesDX ;
      private String AV88Display_GXI ;
      private String AV89Update_GXI ;
      private String AV90Delete_GXI ;
      private String AV51tResult ;
      private String AV43Display ;
      private String AV39Update ;
      private String AV41Delete ;
      private IGxSession AV54websession ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_diagnosis_no ;
      private GXUserControl ucDdo_br_diagnosis_dxdescription ;
      private GXUserControl ucDdo_br_diagnosis_dxtsource ;
      private GXUserControl ucDdo_br_diagnosis_dxid ;
      private GXUserControl ucDdo_br_diagnosis_dxcode ;
      private GXUserControl ucDdo_br_diagnosis_dxtype ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Diagnosis_InitialDX ;
      private GXCombobox cmbBR_Diagnosis_MetastasesDX ;
      private IDataStoreProvider pr_default ;
      private long[] H00242_A19BR_EncounterID ;
      private String[] H00242_A71BR_Diagnosis_MetastasesDX ;
      private bool[] H00242_n71BR_Diagnosis_MetastasesDX ;
      private String[] H00242_A70BR_Diagnosis_InitialDX ;
      private bool[] H00242_n70BR_Diagnosis_InitialDX ;
      private String[] H00242_A67BR_Diagnosis_DXType ;
      private bool[] H00242_n67BR_Diagnosis_DXType ;
      private String[] H00242_A66BR_Diagnosis_DXCode ;
      private bool[] H00242_n66BR_Diagnosis_DXCode ;
      private String[] H00242_A65BR_Diagnosis_DXID ;
      private bool[] H00242_n65BR_Diagnosis_DXID ;
      private String[] H00242_A68BR_Diagnosis_DXTsource ;
      private bool[] H00242_n68BR_Diagnosis_DXTsource ;
      private String[] H00242_A69BR_Diagnosis_DXDescription ;
      private bool[] H00242_n69BR_Diagnosis_DXDescription ;
      private long[] H00242_A64BR_DiagnosisID ;
      private long[] H00242_A513BR_Diagnosis_No ;
      private bool[] H00242_n513BR_Diagnosis_No ;
      private long[] H00243_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV81BR_Diagnosis_NoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27BR_Diagnosis_DXDescriptionTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25BR_Diagnosis_DXTsourceTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_Diagnosis_DXIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Diagnosis_DXCodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_Diagnosis_DXTypeTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV33DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV13GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private SdtSDT_MicroUserInfo AV52tSDT_MicroUserInfo ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
   }

   public class br_encounterupdatebr_diagnosiswc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00242( IGxContext context ,
                                             long AV82TFBR_Diagnosis_No ,
                                             long AV83TFBR_Diagnosis_No_To ,
                                             long A513BR_Diagnosis_No ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV8BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_EncounterID], [BR_Diagnosis_MetastasesDX], [BR_Diagnosis_InitialDX], [BR_Diagnosis_DXType], [BR_Diagnosis_DXCode], [BR_Diagnosis_DXID], [BR_Diagnosis_DXTsource], [BR_Diagnosis_DXDescription], [BR_DiagnosisID], [BR_Diagnosis_No]";
         sFromString = " FROM [BR_Diagnosis] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ! (0==AV82TFBR_Diagnosis_No) )
         {
            sWhereString = sWhereString + " and ([BR_Diagnosis_No] >= @AV82TFBR_Diagnosis_No)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV83TFBR_Diagnosis_No_To) )
         {
            sWhereString = sWhereString + " and ([BR_Diagnosis_No] <= @AV83TFBR_Diagnosis_No_To)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Diagnosis_No]";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Diagnosis_No] DESC";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Diagnosis_DXDescription]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Diagnosis_DXDescription] DESC";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Diagnosis_DXTsource]";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Diagnosis_DXTsource] DESC";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Diagnosis_DXID]";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Diagnosis_DXID] DESC";
         }
         else if ( ( AV14OrderedBy == 5 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Diagnosis_DXCode]";
         }
         else if ( ( AV14OrderedBy == 5 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Diagnosis_DXCode] DESC";
         }
         else if ( ( AV14OrderedBy == 6 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Diagnosis_DXType]";
         }
         else if ( ( AV14OrderedBy == 6 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Diagnosis_DXType] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_DiagnosisID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00243( IGxContext context ,
                                             long AV82TFBR_Diagnosis_No ,
                                             long AV83TFBR_Diagnosis_No_To ,
                                             long A513BR_Diagnosis_No ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV8BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [3] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Diagnosis] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ! (0==AV82TFBR_Diagnosis_No) )
         {
            sWhereString = sWhereString + " and ([BR_Diagnosis_No] >= @AV82TFBR_Diagnosis_No)";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV83TFBR_Diagnosis_No_To) )
         {
            sWhereString = sWhereString + " and ([BR_Diagnosis_No] <= @AV83TFBR_Diagnosis_No_To)";
         }
         else
         {
            GXv_int5[2] = 1;
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
                     return conditional_H00242(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] );
               case 1 :
                     return conditional_H00243(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] );
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
          Object[] prmH00242 ;
          prmH00242 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV82TFBR_Diagnosis_No",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV83TFBR_Diagnosis_No_To",SqlDbType.Decimal,10,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00243 ;
          prmH00243 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV82TFBR_Diagnosis_No",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV83TFBR_Diagnosis_No_To",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00242", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00242,11,0,true,false )
             ,new CursorDef("H00243", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00243,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((long[]) buf[15])[0] = rslt.getLong(9) ;
                ((long[]) buf[16])[0] = rslt.getLong(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
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
                   stmt.SetParameter(sIdx, (long)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[5]);
                }
                return;
       }
    }

 }

}
