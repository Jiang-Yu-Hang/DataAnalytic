/*
               File: BR_Scheme_BR_Scheme_Medication
        Description: BR_Scheme_BR_Scheme_Medication
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:4.53
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
   public class br_scheme_br_scheme_medication : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_scheme_br_scheme_medication( )
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

      public br_scheme_br_scheme_medication( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_SchemeID )
      {
         this.AV8BR_SchemeID = aP0_BR_SchemeID;
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
                  AV8BR_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_SchemeID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)AV8BR_SchemeID});
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
                  edtavNewupdate_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavNewupdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNewupdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
                  edtavDelete_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
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
                  AV18TFBR_Scheme_Chem_Regimens = GetNextPar( );
                  AV19TFBR_Scheme_Chem_Regimens_Sel = GetNextPar( );
                  AV47TFBR_Medication_RXName = GetNextPar( );
                  AV48TFBR_Medication_RXName_Sel = GetNextPar( );
                  AV51TFBR_Medication_RXDose = NumberUtil.Val( GetNextPar( ), ".");
                  AV52TFBR_Medication_RXDose_To = NumberUtil.Val( GetNextPar( ), ".");
                  AV55TFBR_Medication_RXUnit = GetNextPar( );
                  AV56TFBR_Medication_RXUnit_Sel = GetNextPar( );
                  AV8BR_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = GetNextPar( );
                  AV49ddo_BR_Medication_RXNameTitleControlIdToReplace = GetNextPar( );
                  AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace = GetNextPar( );
                  AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace = GetNextPar( );
                  AV68Pgmname = GetNextPar( );
                  edtavNewupdate_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavNewupdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNewupdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
                  edtavDelete_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
                  AV44IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_Scheme_Chem_Regimens, AV19TFBR_Scheme_Chem_Regimens_Sel, AV47TFBR_Medication_RXName, AV48TFBR_Medication_RXName_Sel, AV51TFBR_Medication_RXDose, AV52TFBR_Medication_RXDose_To, AV55TFBR_Medication_RXUnit, AV56TFBR_Medication_RXUnit_Sel, AV8BR_SchemeID, AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV49ddo_BR_Medication_RXNameTitleControlIdToReplace, AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV68Pgmname, AV44IsAuthorized_Delete, sPrefix) ;
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
            PA6H2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV68Pgmname = "BR_Scheme_BR_Scheme_Medication";
               context.Gx_err = 0;
               WS6H2( ) ;
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
            context.SendWebValue( "BR_Scheme_BR_Scheme_Medication") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271158480", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_scheme_br_scheme_medication.aspx") + "?" + UrlEncode("" +AV8BR_SchemeID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_SCHEME_CHEM_REGIMENS", AV18TFBR_Scheme_Chem_Regimens);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_SCHEME_CHEM_REGIMENS_SEL", AV19TFBR_Scheme_Chem_Regimens_Sel);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_MEDICATION_RXNAME", AV47TFBR_Medication_RXName);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_MEDICATION_RXNAME_SEL", AV48TFBR_Medication_RXName_Sel);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_MEDICATION_RXDOSE", StringUtil.LTrim( StringUtil.NToC( AV51TFBR_Medication_RXDose, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_MEDICATION_RXDOSE_TO", StringUtil.LTrim( StringUtil.NToC( AV52TFBR_Medication_RXDose_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_MEDICATION_RXUNIT", AV55TFBR_Medication_RXUnit);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_MEDICATION_RXUNIT_SEL", AV56TFBR_Medication_RXUnit_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV36GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV37GridPageSize), 10, 0, ".", "")));
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICATION_RXNAMETITLEFILTERDATA", AV46BR_Medication_RXNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICATION_RXNAMETITLEFILTERDATA", AV46BR_Medication_RXNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICATION_RXDOSETITLEFILTERDATA", AV50BR_Medication_RXDoseTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICATION_RXDOSETITLEFILTERDATA", AV50BR_Medication_RXDoseTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICATION_RXUNITTITLEFILTERDATA", AV54BR_Medication_RXUnitTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICATION_RXUNITTITLEFILTERDATA", AV54BR_Medication_RXUnitTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_SchemeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV68Pgmname));
         GxWebStd.gx_hidden_field( context, sPrefix+"vBR_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DELETE", AV44IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Caption", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Tooltip", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Cls", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_set", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_set", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Filtertype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Filterisrange", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Datalisttype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Datalisttype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Datalistproc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Datalistproc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Sortasc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Loadingdata", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Loadingdata));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Cleanfilter", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Noresultsfound", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Noresultsfound));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Caption", StringUtil.RTrim( Ddo_br_medication_rxname_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxname_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Cls", StringUtil.RTrim( Ddo_br_medication_rxname_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_rxname_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_rxname_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxname_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxname_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Datalisttype", StringUtil.RTrim( Ddo_br_medication_rxname_Datalisttype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Datalistproc", StringUtil.RTrim( Ddo_br_medication_rxname_Datalistproc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_rxname_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxname_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxname_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Loadingdata", StringUtil.RTrim( Ddo_br_medication_rxname_Loadingdata));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxname_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_rxname_Noresultsfound));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Caption", StringUtil.RTrim( Ddo_br_medication_rxdose_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxdose_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Cls", StringUtil.RTrim( Ddo_br_medication_rxdose_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxdose_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxdose_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxdose_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxdose_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medication_rxdose_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Rangefilterto", StringUtil.RTrim( Ddo_br_medication_rxdose_Rangefilterto));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxdose_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Caption", StringUtil.RTrim( Ddo_br_medication_rxunit_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxunit_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Cls", StringUtil.RTrim( Ddo_br_medication_rxunit_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_rxunit_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_rxunit_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxunit_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxunit_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxunit_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Datalisttype", StringUtil.RTrim( Ddo_br_medication_rxunit_Datalisttype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Datalistproc", StringUtil.RTrim( Ddo_br_medication_rxunit_Datalistproc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_rxunit_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Loadingdata", StringUtil.RTrim( Ddo_br_medication_rxunit_Loadingdata));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxunit_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_rxunit_Noresultsfound));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxunit_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxname_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxname_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdose_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"vNEWUPDATE_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavNewupdate_Visible), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vDELETE_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxname_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxname_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdose_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXUNIT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Selectedvalue_get));
      }

      protected void RenderHtmlCloseForm6H2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_scheme_br_scheme_medication.js", "?20202271158748", false);
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
         return "BR_Scheme_BR_Scheme_Medication" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Scheme_BR_Scheme_Medication" ;
      }

      protected void WB6H0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_scheme_br_scheme_medication.aspx");
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
            GxWebStd.gx_div_start( context, divTableheader_Internalname, divTableheader_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
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
            GxWebStd.gx_button_ctrl( context, bttBtnmineinsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "新增", bttBtnmineinsert_Jsonclick, 7, "新增", "", StyleString, ClassString, bttBtnmineinsert_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e116h1_client"+"'", TempTags, "", 2, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavNewupdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "药物治疗主键") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "化疗方案药物详情主键") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV39Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV60newupdate));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavNewupdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavNewupdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV43Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
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
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("RecordCount", AV38GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV37GridPageSize);
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
            ucDdo_br_scheme_chem_regimens.SetProperty("Caption", Ddo_br_scheme_chem_regimens_Caption);
            ucDdo_br_scheme_chem_regimens.SetProperty("Tooltip", Ddo_br_scheme_chem_regimens_Tooltip);
            ucDdo_br_scheme_chem_regimens.SetProperty("Cls", Ddo_br_scheme_chem_regimens_Cls);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsType", Ddo_br_scheme_chem_regimens_Dropdownoptionstype);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeSortASC", Ddo_br_scheme_chem_regimens_Includesortasc);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeSortDSC", Ddo_br_scheme_chem_regimens_Includesortdsc);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeFilter", Ddo_br_scheme_chem_regimens_Includefilter);
            ucDdo_br_scheme_chem_regimens.SetProperty("FilterType", Ddo_br_scheme_chem_regimens_Filtertype);
            ucDdo_br_scheme_chem_regimens.SetProperty("FilterIsRange", Ddo_br_scheme_chem_regimens_Filterisrange);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeDataList", Ddo_br_scheme_chem_regimens_Includedatalist);
            ucDdo_br_scheme_chem_regimens.SetProperty("DataListType", Ddo_br_scheme_chem_regimens_Datalisttype);
            ucDdo_br_scheme_chem_regimens.SetProperty("DataListProc", Ddo_br_scheme_chem_regimens_Datalistproc);
            ucDdo_br_scheme_chem_regimens.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters);
            ucDdo_br_scheme_chem_regimens.SetProperty("SortASC", Ddo_br_scheme_chem_regimens_Sortasc);
            ucDdo_br_scheme_chem_regimens.SetProperty("SortDSC", Ddo_br_scheme_chem_regimens_Sortdsc);
            ucDdo_br_scheme_chem_regimens.SetProperty("LoadingData", Ddo_br_scheme_chem_regimens_Loadingdata);
            ucDdo_br_scheme_chem_regimens.SetProperty("CleanFilter", Ddo_br_scheme_chem_regimens_Cleanfilter);
            ucDdo_br_scheme_chem_regimens.SetProperty("NoResultsFound", Ddo_br_scheme_chem_regimens_Noresultsfound);
            ucDdo_br_scheme_chem_regimens.SetProperty("SearchButtonText", Ddo_br_scheme_chem_regimens_Searchbuttontext);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsTitleSettingsIcons", AV33DDO_TitleSettingsIcons);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
            ucDdo_br_scheme_chem_regimens.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_chem_regimens_Internalname, sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname, AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
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
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsTitleSettingsIcons", AV33DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsData", AV46BR_Medication_RXNameTitleFilterData);
            ucDdo_br_medication_rxname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxname_Internalname, sPrefix+"DDO_BR_MEDICATION_RXNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, AV49ddo_BR_Medication_RXNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxdose.SetProperty("Caption", Ddo_br_medication_rxdose_Caption);
            ucDdo_br_medication_rxdose.SetProperty("Tooltip", Ddo_br_medication_rxdose_Tooltip);
            ucDdo_br_medication_rxdose.SetProperty("Cls", Ddo_br_medication_rxdose_Cls);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsType", Ddo_br_medication_rxdose_Dropdownoptionstype);
            ucDdo_br_medication_rxdose.SetProperty("IncludeSortASC", Ddo_br_medication_rxdose_Includesortasc);
            ucDdo_br_medication_rxdose.SetProperty("IncludeSortDSC", Ddo_br_medication_rxdose_Includesortdsc);
            ucDdo_br_medication_rxdose.SetProperty("IncludeFilter", Ddo_br_medication_rxdose_Includefilter);
            ucDdo_br_medication_rxdose.SetProperty("FilterType", Ddo_br_medication_rxdose_Filtertype);
            ucDdo_br_medication_rxdose.SetProperty("FilterIsRange", Ddo_br_medication_rxdose_Filterisrange);
            ucDdo_br_medication_rxdose.SetProperty("IncludeDataList", Ddo_br_medication_rxdose_Includedatalist);
            ucDdo_br_medication_rxdose.SetProperty("SortASC", Ddo_br_medication_rxdose_Sortasc);
            ucDdo_br_medication_rxdose.SetProperty("SortDSC", Ddo_br_medication_rxdose_Sortdsc);
            ucDdo_br_medication_rxdose.SetProperty("CleanFilter", Ddo_br_medication_rxdose_Cleanfilter);
            ucDdo_br_medication_rxdose.SetProperty("RangeFilterFrom", Ddo_br_medication_rxdose_Rangefilterfrom);
            ucDdo_br_medication_rxdose.SetProperty("RangeFilterTo", Ddo_br_medication_rxdose_Rangefilterto);
            ucDdo_br_medication_rxdose.SetProperty("SearchButtonText", Ddo_br_medication_rxdose_Searchbuttontext);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsTitleSettingsIcons", AV33DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsData", AV50BR_Medication_RXDoseTitleFilterData);
            ucDdo_br_medication_rxdose.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxdose_Internalname, sPrefix+"DDO_BR_MEDICATION_RXDOSEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname, AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
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
            ucDdo_br_medication_rxunit.SetProperty("DropDownOptionsTitleSettingsIcons", AV33DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxunit.SetProperty("DropDownOptionsData", AV54BR_Medication_RXUnitTitleFilterData);
            ucDdo_br_medication_rxunit.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxunit_Internalname, sPrefix+"DDO_BR_MEDICATION_RXUNITContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname, AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_SchemeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_SchemeID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_SchemeID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_chem_regimens_Internalname, AV18TFBR_Scheme_Chem_Regimens, StringUtil.RTrim( context.localUtil.Format( AV18TFBR_Scheme_Chem_Regimens, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_chem_regimens_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_chem_regimens_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_chem_regimens_sel_Internalname, AV19TFBR_Scheme_Chem_Regimens_Sel, StringUtil.RTrim( context.localUtil.Format( AV19TFBR_Scheme_Chem_Regimens_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_chem_regimens_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_chem_regimens_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxname_Internalname, AV47TFBR_Medication_RXName, StringUtil.RTrim( context.localUtil.Format( AV47TFBR_Medication_RXName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxname_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxname_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxname_sel_Internalname, AV48TFBR_Medication_RXName_Sel, StringUtil.RTrim( context.localUtil.Format( AV48TFBR_Medication_RXName_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxname_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxname_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxdose_Internalname, StringUtil.LTrim( StringUtil.NToC( AV51TFBR_Medication_RXDose, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV51TFBR_Medication_RXDose, "ZZZZZZZZZ.ZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxdose_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxdose_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxdose_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV52TFBR_Medication_RXDose_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV52TFBR_Medication_RXDose_To, "ZZZZZZZZZ.ZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxdose_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxdose_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxunit_Internalname, AV55TFBR_Medication_RXUnit, StringUtil.RTrim( context.localUtil.Format( AV55TFBR_Medication_RXUnit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxunit_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxunit_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxunit_sel_Internalname, AV56TFBR_Medication_RXUnit_Sel, StringUtil.RTrim( context.localUtil.Format( AV56TFBR_Medication_RXUnit_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxunit_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxunit_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_BR_Scheme_Medication.htm");
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

      protected void START6H2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Scheme_BR_Scheme_Medication", 0) ;
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
               STRUP6H0( ) ;
            }
         }
      }

      protected void WS6H2( )
      {
         START6H2( ) ;
         EVT6H2( ) ;
      }

      protected void EVT6H2( )
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
                                 STRUP6H0( ) ;
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
                                 STRUP6H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E126H2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP6H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E136H2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP6H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E146H2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP6H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E156H2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP6H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E166H2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP6H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E176H2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP6H0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname;
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP6H0( ) ;
                              }
                              nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
                              SubsflControlProps_282( ) ;
                              AV39Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV39Display)) ? AV65Display_GXI : context.convertURL( context.PathToRelativeUrl( AV39Display))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV39Display), true);
                              AV60newupdate = cgiGet( edtavNewupdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavNewupdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV60newupdate)) ? AV66Newupdate_GXI : context.convertURL( context.PathToRelativeUrl( AV60newupdate))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavNewupdate_Internalname, "SrcSet", context.GetImageSrcSet( AV60newupdate), true);
                              AV43Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV43Delete)) ? AV67Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV43Delete))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV43Delete), true);
                              A328BR_Scheme_Chem_Regimens = cgiGet( edtBR_Scheme_Chem_Regimens_Internalname);
                              n328BR_Scheme_Chem_Regimens = false;
                              A121BR_Medication_RXName = cgiGet( edtBR_Medication_RXName_Internalname);
                              n121BR_Medication_RXName = false;
                              A124BR_Medication_RXDose = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDose_Internalname), ".", ",");
                              n124BR_Medication_RXDose = false;
                              A125BR_Medication_RXUnit = cgiGet( edtBR_Medication_RXUnit_Internalname);
                              n125BR_Medication_RXUnit = false;
                              A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ","));
                              n119BR_MedicationID = false;
                              A332BR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_Scheme_MedicationID_Internalname), ".", ","));
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
                                          GX_FocusControl = edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E186H2 ();
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
                                          GX_FocusControl = edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E196H2 ();
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
                                          GX_FocusControl = edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E206H2 ();
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
                                             /* Set Refresh If Tfbr_scheme_chem_regimens Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_SCHEME_CHEM_REGIMENS"), AV18TFBR_Scheme_Chem_Regimens) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_scheme_chem_regimens_sel Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_SCHEME_CHEM_REGIMENS_SEL"), AV19TFBR_Scheme_Chem_Regimens_Sel) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_medication_rxname Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXNAME"), AV47TFBR_Medication_RXName) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_medication_rxname_sel Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXNAME_SEL"), AV48TFBR_Medication_RXName_Sel) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_medication_rxdose Changed */
                                             if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXDOSE"), ".", ",") != AV51TFBR_Medication_RXDose )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_medication_rxdose_to Changed */
                                             if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXDOSE_TO"), ".", ",") != AV52TFBR_Medication_RXDose_To )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_medication_rxunit Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXUNIT"), AV55TFBR_Medication_RXUnit) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_medication_rxunit_sel Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXUNIT_SEL"), AV56TFBR_Medication_RXUnit_Sel) != 0 )
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
                                       STRUP6H0( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname;
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

      protected void WE6H2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm6H2( ) ;
            }
         }
      }

      protected void PA6H2( )
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
               GX_FocusControl = edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname;
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
                                       String AV18TFBR_Scheme_Chem_Regimens ,
                                       String AV19TFBR_Scheme_Chem_Regimens_Sel ,
                                       String AV47TFBR_Medication_RXName ,
                                       String AV48TFBR_Medication_RXName_Sel ,
                                       decimal AV51TFBR_Medication_RXDose ,
                                       decimal AV52TFBR_Medication_RXDose_To ,
                                       String AV55TFBR_Medication_RXUnit ,
                                       String AV56TFBR_Medication_RXUnit_Sel ,
                                       long AV8BR_SchemeID ,
                                       String AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace ,
                                       String AV49ddo_BR_Medication_RXNameTitleControlIdToReplace ,
                                       String AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace ,
                                       String AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace ,
                                       String AV68Pgmname ,
                                       bool AV44IsAuthorized_Delete ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF6H2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_SCHEME_MEDICATIONID", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_SCHEME_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")));
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
         RF6H2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV68Pgmname = "BR_Scheme_BR_Scheme_Medication";
         context.Gx_err = 0;
      }

      protected void RF6H2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E196H2 ();
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
                                                 AV19TFBR_Scheme_Chem_Regimens_Sel ,
                                                 AV18TFBR_Scheme_Chem_Regimens ,
                                                 AV48TFBR_Medication_RXName_Sel ,
                                                 AV47TFBR_Medication_RXName ,
                                                 AV51TFBR_Medication_RXDose ,
                                                 AV52TFBR_Medication_RXDose_To ,
                                                 AV56TFBR_Medication_RXUnit_Sel ,
                                                 AV55TFBR_Medication_RXUnit ,
                                                 A328BR_Scheme_Chem_Regimens ,
                                                 A121BR_Medication_RXName ,
                                                 A124BR_Medication_RXDose ,
                                                 A125BR_Medication_RXUnit ,
                                                 AV14OrderedBy ,
                                                 AV15OrderedDsc ,
                                                 A327BR_SchemeID ,
                                                 AV8BR_SchemeID } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                                 TypeConstants.LONG
                                                 }
            } ) ;
            lV18TFBR_Scheme_Chem_Regimens = StringUtil.Concat( StringUtil.RTrim( AV18TFBR_Scheme_Chem_Regimens), "%", "");
            lV47TFBR_Medication_RXName = StringUtil.Concat( StringUtil.RTrim( AV47TFBR_Medication_RXName), "%", "");
            lV55TFBR_Medication_RXUnit = StringUtil.Concat( StringUtil.RTrim( AV55TFBR_Medication_RXUnit), "%", "");
            /* Using cursor H006H2 */
            pr_default.execute(0, new Object[] {AV8BR_SchemeID, lV18TFBR_Scheme_Chem_Regimens, AV19TFBR_Scheme_Chem_Regimens_Sel, lV47TFBR_Medication_RXName, AV48TFBR_Medication_RXName_Sel, AV51TFBR_Medication_RXDose, AV52TFBR_Medication_RXDose_To, lV55TFBR_Medication_RXUnit, AV56TFBR_Medication_RXUnit_Sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A327BR_SchemeID = H006H2_A327BR_SchemeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
               n327BR_SchemeID = H006H2_n327BR_SchemeID[0];
               A332BR_Scheme_MedicationID = H006H2_A332BR_Scheme_MedicationID[0];
               A119BR_MedicationID = H006H2_A119BR_MedicationID[0];
               n119BR_MedicationID = H006H2_n119BR_MedicationID[0];
               A125BR_Medication_RXUnit = H006H2_A125BR_Medication_RXUnit[0];
               n125BR_Medication_RXUnit = H006H2_n125BR_Medication_RXUnit[0];
               A124BR_Medication_RXDose = H006H2_A124BR_Medication_RXDose[0];
               n124BR_Medication_RXDose = H006H2_n124BR_Medication_RXDose[0];
               A121BR_Medication_RXName = H006H2_A121BR_Medication_RXName[0];
               n121BR_Medication_RXName = H006H2_n121BR_Medication_RXName[0];
               A328BR_Scheme_Chem_Regimens = H006H2_A328BR_Scheme_Chem_Regimens[0];
               n328BR_Scheme_Chem_Regimens = H006H2_n328BR_Scheme_Chem_Regimens[0];
               A328BR_Scheme_Chem_Regimens = H006H2_A328BR_Scheme_Chem_Regimens[0];
               n328BR_Scheme_Chem_Regimens = H006H2_n328BR_Scheme_Chem_Regimens[0];
               A125BR_Medication_RXUnit = H006H2_A125BR_Medication_RXUnit[0];
               n125BR_Medication_RXUnit = H006H2_n125BR_Medication_RXUnit[0];
               A124BR_Medication_RXDose = H006H2_A124BR_Medication_RXDose[0];
               n124BR_Medication_RXDose = H006H2_n124BR_Medication_RXDose[0];
               A121BR_Medication_RXName = H006H2_A121BR_Medication_RXName[0];
               n121BR_Medication_RXName = H006H2_n121BR_Medication_RXName[0];
               E206H2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB6H0( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes6H2( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_SCHEME_MEDICATIONID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sPrefix+sGXsfl_28_idx, context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
                                              AV19TFBR_Scheme_Chem_Regimens_Sel ,
                                              AV18TFBR_Scheme_Chem_Regimens ,
                                              AV48TFBR_Medication_RXName_Sel ,
                                              AV47TFBR_Medication_RXName ,
                                              AV51TFBR_Medication_RXDose ,
                                              AV52TFBR_Medication_RXDose_To ,
                                              AV56TFBR_Medication_RXUnit_Sel ,
                                              AV55TFBR_Medication_RXUnit ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A121BR_Medication_RXName ,
                                              A124BR_Medication_RXDose ,
                                              A125BR_Medication_RXUnit ,
                                              AV14OrderedBy ,
                                              AV15OrderedDsc ,
                                              A327BR_SchemeID ,
                                              AV8BR_SchemeID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG
                                              }
         } ) ;
         lV18TFBR_Scheme_Chem_Regimens = StringUtil.Concat( StringUtil.RTrim( AV18TFBR_Scheme_Chem_Regimens), "%", "");
         lV47TFBR_Medication_RXName = StringUtil.Concat( StringUtil.RTrim( AV47TFBR_Medication_RXName), "%", "");
         lV55TFBR_Medication_RXUnit = StringUtil.Concat( StringUtil.RTrim( AV55TFBR_Medication_RXUnit), "%", "");
         /* Using cursor H006H3 */
         pr_default.execute(1, new Object[] {AV8BR_SchemeID, lV18TFBR_Scheme_Chem_Regimens, AV19TFBR_Scheme_Chem_Regimens_Sel, lV47TFBR_Medication_RXName, AV48TFBR_Medication_RXName_Sel, AV51TFBR_Medication_RXDose, AV52TFBR_Medication_RXDose_To, lV55TFBR_Medication_RXUnit, AV56TFBR_Medication_RXUnit_Sel});
         GRID_nRecordCount = H006H3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_Scheme_Chem_Regimens, AV19TFBR_Scheme_Chem_Regimens_Sel, AV47TFBR_Medication_RXName, AV48TFBR_Medication_RXName_Sel, AV51TFBR_Medication_RXDose, AV52TFBR_Medication_RXDose_To, AV55TFBR_Medication_RXUnit, AV56TFBR_Medication_RXUnit_Sel, AV8BR_SchemeID, AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV49ddo_BR_Medication_RXNameTitleControlIdToReplace, AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV68Pgmname, AV44IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_Scheme_Chem_Regimens, AV19TFBR_Scheme_Chem_Regimens_Sel, AV47TFBR_Medication_RXName, AV48TFBR_Medication_RXName_Sel, AV51TFBR_Medication_RXDose, AV52TFBR_Medication_RXDose_To, AV55TFBR_Medication_RXUnit, AV56TFBR_Medication_RXUnit_Sel, AV8BR_SchemeID, AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV49ddo_BR_Medication_RXNameTitleControlIdToReplace, AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV68Pgmname, AV44IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_Scheme_Chem_Regimens, AV19TFBR_Scheme_Chem_Regimens_Sel, AV47TFBR_Medication_RXName, AV48TFBR_Medication_RXName_Sel, AV51TFBR_Medication_RXDose, AV52TFBR_Medication_RXDose_To, AV55TFBR_Medication_RXUnit, AV56TFBR_Medication_RXUnit_Sel, AV8BR_SchemeID, AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV49ddo_BR_Medication_RXNameTitleControlIdToReplace, AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV68Pgmname, AV44IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_Scheme_Chem_Regimens, AV19TFBR_Scheme_Chem_Regimens_Sel, AV47TFBR_Medication_RXName, AV48TFBR_Medication_RXName_Sel, AV51TFBR_Medication_RXDose, AV52TFBR_Medication_RXDose_To, AV55TFBR_Medication_RXUnit, AV56TFBR_Medication_RXUnit_Sel, AV8BR_SchemeID, AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV49ddo_BR_Medication_RXNameTitleControlIdToReplace, AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV68Pgmname, AV44IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_Scheme_Chem_Regimens, AV19TFBR_Scheme_Chem_Regimens_Sel, AV47TFBR_Medication_RXName, AV48TFBR_Medication_RXName_Sel, AV51TFBR_Medication_RXDose, AV52TFBR_Medication_RXDose_To, AV55TFBR_Medication_RXUnit, AV56TFBR_Medication_RXUnit_Sel, AV8BR_SchemeID, AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV49ddo_BR_Medication_RXNameTitleControlIdToReplace, AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV68Pgmname, AV44IsAuthorized_Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP6H0( )
      {
         /* Before Start, stand alone formulas. */
         AV68Pgmname = "BR_Scheme_BR_Scheme_Medication";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E186H2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV33DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA"), AV17BR_Scheme_Chem_RegimensTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICATION_RXNAMETITLEFILTERDATA"), AV46BR_Medication_RXNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICATION_RXDOSETITLEFILTERDATA"), AV50BR_Medication_RXDoseTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICATION_RXUNITTITLEFILTERDATA"), AV54BR_Medication_RXUnitTitleFilterData);
            /* Read variables values. */
            AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace", AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace);
            AV49ddo_BR_Medication_RXNameTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV49ddo_BR_Medication_RXNameTitleControlIdToReplace", AV49ddo_BR_Medication_RXNameTitleControlIdToReplace);
            AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace", AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace);
            AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace", AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace);
            A327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_SchemeID_Internalname), ".", ","));
            n327BR_SchemeID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
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
            AV18TFBR_Scheme_Chem_Regimens = cgiGet( edtavTfbr_scheme_chem_regimens_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TFBR_Scheme_Chem_Regimens", AV18TFBR_Scheme_Chem_Regimens);
            AV19TFBR_Scheme_Chem_Regimens_Sel = cgiGet( edtavTfbr_scheme_chem_regimens_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19TFBR_Scheme_Chem_Regimens_Sel", AV19TFBR_Scheme_Chem_Regimens_Sel);
            AV47TFBR_Medication_RXName = cgiGet( edtavTfbr_medication_rxname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV47TFBR_Medication_RXName", AV47TFBR_Medication_RXName);
            AV48TFBR_Medication_RXName_Sel = cgiGet( edtavTfbr_medication_rxname_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV48TFBR_Medication_RXName_Sel", AV48TFBR_Medication_RXName_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_RXDOSE");
               GX_FocusControl = edtavTfbr_medication_rxdose_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV51TFBR_Medication_RXDose = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV51TFBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV51TFBR_Medication_RXDose, 15, 5)));
            }
            else
            {
               AV51TFBR_Medication_RXDose = context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV51TFBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV51TFBR_Medication_RXDose, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_RXDOSE_TO");
               GX_FocusControl = edtavTfbr_medication_rxdose_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV52TFBR_Medication_RXDose_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV52TFBR_Medication_RXDose_To", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Medication_RXDose_To, 15, 5)));
            }
            else
            {
               AV52TFBR_Medication_RXDose_To = context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV52TFBR_Medication_RXDose_To", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Medication_RXDose_To, 15, 5)));
            }
            AV55TFBR_Medication_RXUnit = cgiGet( edtavTfbr_medication_rxunit_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV55TFBR_Medication_RXUnit", AV55TFBR_Medication_RXUnit);
            AV56TFBR_Medication_RXUnit_Sel = cgiGet( edtavTfbr_medication_rxunit_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV56TFBR_Medication_RXUnit_Sel", AV56TFBR_Medication_RXUnit_Sel);
            /* Read saved values. */
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_28"), ".", ","));
            AV36GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV38GridRecordCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDRECORDCOUNT"), ".", ","));
            AV37GridPageSize = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGESIZE"), ".", ","));
            wcpOAV8BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_SchemeID"), ".", ","));
            AV8BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vBR_SCHEMEID"), ".", ","));
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
            Ddo_br_scheme_chem_regimens_Caption = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Caption");
            Ddo_br_scheme_chem_regimens_Tooltip = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Tooltip");
            Ddo_br_scheme_chem_regimens_Cls = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Cls");
            Ddo_br_scheme_chem_regimens_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_set");
            Ddo_br_scheme_chem_regimens_Selectedvalue_set = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_set");
            Ddo_br_scheme_chem_regimens_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Dropdownoptionstype");
            Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Titlecontrolidtoreplace");
            Ddo_br_scheme_chem_regimens_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Includesortasc"));
            Ddo_br_scheme_chem_regimens_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Includesortdsc"));
            Ddo_br_scheme_chem_regimens_Sortedstatus = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Sortedstatus");
            Ddo_br_scheme_chem_regimens_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Includefilter"));
            Ddo_br_scheme_chem_regimens_Filtertype = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Filtertype");
            Ddo_br_scheme_chem_regimens_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Filterisrange"));
            Ddo_br_scheme_chem_regimens_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Includedatalist"));
            Ddo_br_scheme_chem_regimens_Datalisttype = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Datalisttype");
            Ddo_br_scheme_chem_regimens_Datalistproc = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Datalistproc");
            Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_scheme_chem_regimens_Sortasc = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Sortasc");
            Ddo_br_scheme_chem_regimens_Sortdsc = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Sortdsc");
            Ddo_br_scheme_chem_regimens_Loadingdata = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Loadingdata");
            Ddo_br_scheme_chem_regimens_Cleanfilter = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Cleanfilter");
            Ddo_br_scheme_chem_regimens_Noresultsfound = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Noresultsfound");
            Ddo_br_scheme_chem_regimens_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Searchbuttontext");
            Ddo_br_medication_rxname_Caption = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Caption");
            Ddo_br_medication_rxname_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Tooltip");
            Ddo_br_medication_rxname_Cls = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Cls");
            Ddo_br_medication_rxname_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Filteredtext_set");
            Ddo_br_medication_rxname_Selectedvalue_set = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Selectedvalue_set");
            Ddo_br_medication_rxname_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Dropdownoptionstype");
            Ddo_br_medication_rxname_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Titlecontrolidtoreplace");
            Ddo_br_medication_rxname_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Includesortasc"));
            Ddo_br_medication_rxname_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Includesortdsc"));
            Ddo_br_medication_rxname_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortedstatus");
            Ddo_br_medication_rxname_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Includefilter"));
            Ddo_br_medication_rxname_Filtertype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Filtertype");
            Ddo_br_medication_rxname_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Filterisrange"));
            Ddo_br_medication_rxname_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Includedatalist"));
            Ddo_br_medication_rxname_Datalisttype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Datalisttype");
            Ddo_br_medication_rxname_Datalistproc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Datalistproc");
            Ddo_br_medication_rxname_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_rxname_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortasc");
            Ddo_br_medication_rxname_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortdsc");
            Ddo_br_medication_rxname_Loadingdata = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Loadingdata");
            Ddo_br_medication_rxname_Cleanfilter = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Cleanfilter");
            Ddo_br_medication_rxname_Noresultsfound = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Noresultsfound");
            Ddo_br_medication_rxname_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Searchbuttontext");
            Ddo_br_medication_rxdose_Caption = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Caption");
            Ddo_br_medication_rxdose_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Tooltip");
            Ddo_br_medication_rxdose_Cls = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Cls");
            Ddo_br_medication_rxdose_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filteredtext_set");
            Ddo_br_medication_rxdose_Filteredtextto_set = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filteredtextto_set");
            Ddo_br_medication_rxdose_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Dropdownoptionstype");
            Ddo_br_medication_rxdose_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Titlecontrolidtoreplace");
            Ddo_br_medication_rxdose_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includesortasc"));
            Ddo_br_medication_rxdose_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includesortdsc"));
            Ddo_br_medication_rxdose_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortedstatus");
            Ddo_br_medication_rxdose_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includefilter"));
            Ddo_br_medication_rxdose_Filtertype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filtertype");
            Ddo_br_medication_rxdose_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filterisrange"));
            Ddo_br_medication_rxdose_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includedatalist"));
            Ddo_br_medication_rxdose_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortasc");
            Ddo_br_medication_rxdose_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortdsc");
            Ddo_br_medication_rxdose_Cleanfilter = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Cleanfilter");
            Ddo_br_medication_rxdose_Rangefilterfrom = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Rangefilterfrom");
            Ddo_br_medication_rxdose_Rangefilterto = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Rangefilterto");
            Ddo_br_medication_rxdose_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Searchbuttontext");
            Ddo_br_medication_rxunit_Caption = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Caption");
            Ddo_br_medication_rxunit_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Tooltip");
            Ddo_br_medication_rxunit_Cls = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Cls");
            Ddo_br_medication_rxunit_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Filteredtext_set");
            Ddo_br_medication_rxunit_Selectedvalue_set = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Selectedvalue_set");
            Ddo_br_medication_rxunit_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Dropdownoptionstype");
            Ddo_br_medication_rxunit_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Titlecontrolidtoreplace");
            Ddo_br_medication_rxunit_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Includesortasc"));
            Ddo_br_medication_rxunit_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Includesortdsc"));
            Ddo_br_medication_rxunit_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Sortedstatus");
            Ddo_br_medication_rxunit_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Includefilter"));
            Ddo_br_medication_rxunit_Filtertype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Filtertype");
            Ddo_br_medication_rxunit_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Filterisrange"));
            Ddo_br_medication_rxunit_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Includedatalist"));
            Ddo_br_medication_rxunit_Datalisttype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Datalisttype");
            Ddo_br_medication_rxunit_Datalistproc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Datalistproc");
            Ddo_br_medication_rxunit_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_rxunit_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Sortasc");
            Ddo_br_medication_rxunit_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Sortdsc");
            Ddo_br_medication_rxunit_Loadingdata = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Loadingdata");
            Ddo_br_medication_rxunit_Cleanfilter = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Cleanfilter");
            Ddo_br_medication_rxunit_Noresultsfound = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Noresultsfound");
            Ddo_br_medication_rxunit_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_scheme_chem_regimens_Activeeventkey = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey");
            Ddo_br_scheme_chem_regimens_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_get");
            Ddo_br_scheme_chem_regimens_Selectedvalue_get = cgiGet( sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_get");
            Ddo_br_medication_rxname_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Activeeventkey");
            Ddo_br_medication_rxname_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Filteredtext_get");
            Ddo_br_medication_rxname_Selectedvalue_get = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Selectedvalue_get");
            Ddo_br_medication_rxdose_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Activeeventkey");
            Ddo_br_medication_rxdose_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filteredtext_get");
            Ddo_br_medication_rxdose_Filteredtextto_get = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Filteredtextto_get");
            Ddo_br_medication_rxunit_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Activeeventkey");
            Ddo_br_medication_rxunit_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Filteredtext_get");
            Ddo_br_medication_rxunit_Selectedvalue_get = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXUNIT_Selectedvalue_get");
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
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_SCHEME_CHEM_REGIMENS"), AV18TFBR_Scheme_Chem_Regimens) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_SCHEME_CHEM_REGIMENS_SEL"), AV19TFBR_Scheme_Chem_Regimens_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXNAME"), AV47TFBR_Medication_RXName) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXNAME_SEL"), AV48TFBR_Medication_RXName_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXDOSE"), ".", ",") != AV51TFBR_Medication_RXDose )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXDOSE_TO"), ".", ",") != AV52TFBR_Medication_RXDose_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXUNIT"), AV55TFBR_Medication_RXUnit) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFBR_MEDICATION_RXUNIT_SEL"), AV56TFBR_Medication_RXUnit_Sel) != 0 )
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
         E186H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E186H2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_scheme_chem_regimens_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_scheme_chem_regimens_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_chem_regimens_Visible), 5, 0)), true);
         edtavTfbr_scheme_chem_regimens_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_scheme_chem_regimens_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_chem_regimens_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_rxname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_medication_rxname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxname_Visible), 5, 0)), true);
         edtavTfbr_medication_rxname_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_medication_rxname_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxname_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_rxdose_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_medication_rxdose_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxdose_Visible), 5, 0)), true);
         edtavTfbr_medication_rxdose_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_medication_rxdose_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxdose_to_Visible), 5, 0)), true);
         edtavTfbr_medication_rxunit_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_medication_rxunit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxunit_Visible), 5, 0)), true);
         edtavTfbr_medication_rxunit_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_medication_rxunit_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxunit_sel_Visible), 5, 0)), true);
         Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Chem_Regimens";
         ucDdo_br_scheme_chem_regimens.SendProperty(context, sPrefix, false, Ddo_br_scheme_chem_regimens_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace);
         AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace", AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace);
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxname_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXName";
         ucDdo_br_medication_rxname.SendProperty(context, sPrefix, false, Ddo_br_medication_rxname_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxname_Titlecontrolidtoreplace);
         AV49ddo_BR_Medication_RXNameTitleControlIdToReplace = Ddo_br_medication_rxname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV49ddo_BR_Medication_RXNameTitleControlIdToReplace", AV49ddo_BR_Medication_RXNameTitleControlIdToReplace);
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxdose_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXDose";
         ucDdo_br_medication_rxdose.SendProperty(context, sPrefix, false, Ddo_br_medication_rxdose_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxdose_Titlecontrolidtoreplace);
         AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace = Ddo_br_medication_rxdose_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace", AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace);
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxunit_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXUnit";
         ucDdo_br_medication_rxunit.SendProperty(context, sPrefix, false, Ddo_br_medication_rxunit_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxunit_Titlecontrolidtoreplace);
         AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace = Ddo_br_medication_rxunit_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace", AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace);
         edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible), 5, 0)), true);
         edtBR_SchemeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_SchemeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_SchemeID_Visible), 5, 0)), true);
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
         AV58tEncounterType = StringUtil.Trim( AV59WebSession.Get("Br_EncounterType"));
         if ( StringUtil.StrCmp(AV58tEncounterType, "check") == 0 )
         {
            divTableheader_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divTableheader_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableheader_Visible), 5, 0)), true);
            edtavNewupdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavNewupdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNewupdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
      }

      protected void E196H2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV17BR_Scheme_Chem_RegimensTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_Medication_RXDoseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54BR_Medication_RXUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Scheme_Chem_Regimens_Titleformat = 2;
         edtBR_Scheme_Chem_Regimens_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案", AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Scheme_Chem_Regimens_Internalname, "Title", edtBR_Scheme_Chem_Regimens_Title, !bGXsfl_28_Refreshing);
         edtBR_Medication_RXName_Titleformat = 2;
         edtBR_Medication_RXName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物名称", AV49ddo_BR_Medication_RXNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Medication_RXName_Internalname, "Title", edtBR_Medication_RXName_Title, !bGXsfl_28_Refreshing);
         edtBR_Medication_RXDose_Titleformat = 2;
         edtBR_Medication_RXDose_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物剂量", AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Medication_RXDose_Internalname, "Title", edtBR_Medication_RXDose_Title, !bGXsfl_28_Refreshing);
         edtBR_Medication_RXUnit_Titleformat = 2;
         edtBR_Medication_RXUnit_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "计量单位", AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Medication_RXUnit_Internalname, "Title", edtBR_Medication_RXUnit_Title, !bGXsfl_28_Refreshing);
         AV36GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV36GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36GridCurrentPage), 10, 0)));
         AV37GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV37GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV37GridPageSize), 10, 0)));
         AV38GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV38GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV46BR_Medication_RXNameTitleFilterData", AV46BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV50BR_Medication_RXDoseTitleFilterData", AV50BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV54BR_Medication_RXUnitTitleFilterData", AV54BR_Medication_RXUnitTitleFilterData);
      }

      protected void E126H2( )
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

      protected void E136H2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E146H2( )
      {
         /* Ddo_br_scheme_chem_regimens_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_scheme_chem_regimens_Sortedstatus = "ASC";
            ucDdo_br_scheme_chem_regimens.SendProperty(context, sPrefix, false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_scheme_chem_regimens_Sortedstatus = "DSC";
            ucDdo_br_scheme_chem_regimens.SendProperty(context, sPrefix, false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV18TFBR_Scheme_Chem_Regimens = Ddo_br_scheme_chem_regimens_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TFBR_Scheme_Chem_Regimens", AV18TFBR_Scheme_Chem_Regimens);
            AV19TFBR_Scheme_Chem_Regimens_Sel = Ddo_br_scheme_chem_regimens_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19TFBR_Scheme_Chem_Regimens_Sel", AV19TFBR_Scheme_Chem_Regimens_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV46BR_Medication_RXNameTitleFilterData", AV46BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV50BR_Medication_RXDoseTitleFilterData", AV50BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV54BR_Medication_RXUnitTitleFilterData", AV54BR_Medication_RXUnitTitleFilterData);
      }

      protected void E156H2( )
      {
         /* Ddo_br_medication_rxname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_rxname_Sortedstatus = "ASC";
            ucDdo_br_medication_rxname.SendProperty(context, sPrefix, false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_rxname_Sortedstatus = "DSC";
            ucDdo_br_medication_rxname.SendProperty(context, sPrefix, false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV47TFBR_Medication_RXName = Ddo_br_medication_rxname_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV47TFBR_Medication_RXName", AV47TFBR_Medication_RXName);
            AV48TFBR_Medication_RXName_Sel = Ddo_br_medication_rxname_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV48TFBR_Medication_RXName_Sel", AV48TFBR_Medication_RXName_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV46BR_Medication_RXNameTitleFilterData", AV46BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV50BR_Medication_RXDoseTitleFilterData", AV50BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV54BR_Medication_RXUnitTitleFilterData", AV54BR_Medication_RXUnitTitleFilterData);
      }

      protected void E166H2( )
      {
         /* Ddo_br_medication_rxdose_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_rxdose_Sortedstatus = "ASC";
            ucDdo_br_medication_rxdose.SendProperty(context, sPrefix, false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_rxdose_Sortedstatus = "DSC";
            ucDdo_br_medication_rxdose.SendProperty(context, sPrefix, false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV51TFBR_Medication_RXDose = NumberUtil.Val( Ddo_br_medication_rxdose_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV51TFBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV51TFBR_Medication_RXDose, 15, 5)));
            AV52TFBR_Medication_RXDose_To = NumberUtil.Val( Ddo_br_medication_rxdose_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV52TFBR_Medication_RXDose_To", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Medication_RXDose_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV46BR_Medication_RXNameTitleFilterData", AV46BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV50BR_Medication_RXDoseTitleFilterData", AV50BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV54BR_Medication_RXUnitTitleFilterData", AV54BR_Medication_RXUnitTitleFilterData);
      }

      protected void E176H2( )
      {
         /* Ddo_br_medication_rxunit_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxunit_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_rxunit_Sortedstatus = "ASC";
            ucDdo_br_medication_rxunit.SendProperty(context, sPrefix, false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxunit_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_rxunit_Sortedstatus = "DSC";
            ucDdo_br_medication_rxunit.SendProperty(context, sPrefix, false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxunit_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV55TFBR_Medication_RXUnit = Ddo_br_medication_rxunit_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV55TFBR_Medication_RXUnit", AV55TFBR_Medication_RXUnit);
            AV56TFBR_Medication_RXUnit_Sel = Ddo_br_medication_rxunit_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV56TFBR_Medication_RXUnit_Sel", AV56TFBR_Medication_RXUnit_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Scheme_Chem_RegimensTitleFilterData", AV17BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV46BR_Medication_RXNameTitleFilterData", AV46BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV50BR_Medication_RXDoseTitleFilterData", AV50BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV54BR_Medication_RXUnitTitleFilterData", AV54BR_Medication_RXUnitTitleFilterData);
      }

      private void E206H2( )
      {
         /* Grid_Load Routine */
         AV39Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDisplay_Internalname, AV39Display);
         AV65Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_scheme_medicationview.aspx") + "?" + UrlEncode("" +A332BR_Scheme_MedicationID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV60newupdate = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavNewupdate_Internalname, AV60newupdate);
         AV66Newupdate_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavNewupdate_Tooltiptext = "";
         AV43Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDelete_Internalname, AV43Delete);
         AV67Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV44IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_scheme_medication.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A332BR_Scheme_MedicationID);
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

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_scheme_chem_regimens_Sortedstatus = "";
         ucDdo_br_scheme_chem_regimens.SendProperty(context, sPrefix, false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
         Ddo_br_medication_rxname_Sortedstatus = "";
         ucDdo_br_medication_rxname.SendProperty(context, sPrefix, false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
         Ddo_br_medication_rxdose_Sortedstatus = "";
         ucDdo_br_medication_rxdose.SendProperty(context, sPrefix, false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
         Ddo_br_medication_rxunit_Sortedstatus = "";
         ucDdo_br_medication_rxunit.SendProperty(context, sPrefix, false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
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
            Ddo_br_scheme_chem_regimens_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_scheme_chem_regimens.SendProperty(context, sPrefix, false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
         }
         else if ( AV14OrderedBy == 2 )
         {
            Ddo_br_medication_rxname_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxname.SendProperty(context, sPrefix, false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
         }
         else if ( AV14OrderedBy == 3 )
         {
            Ddo_br_medication_rxdose_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxdose.SendProperty(context, sPrefix, false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
         }
         else if ( AV14OrderedBy == 4 )
         {
            Ddo_br_medication_rxunit_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxunit.SendProperty(context, sPrefix, false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV61IsAuthorized_newupdate;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean2) ;
         AV61IsAuthorized_newupdate = GXt_boolean2;
         if ( ! ( AV61IsAuthorized_newupdate ) )
         {
            edtavNewupdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavNewupdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNewupdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV44IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean2) ;
         AV44IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV44IsAuthorized_Delete", AV44IsAuthorized_Delete);
         if ( ! ( AV44IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV45TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean2) ;
         AV45TempBoolean = GXt_boolean2;
         if ( ! ( AV45TempBoolean ) )
         {
            bttBtnmineinsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtnmineinsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnmineinsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV68Pgmname+"GridState"), "") == 0 )
         {
            AV12GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV68Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV12GridState.FromXml(AV16Session.Get(AV68Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV69GXV1 = 1;
         while ( AV69GXV1 <= AV12GridState.gxTpr_Filtervalues.Count )
         {
            AV13GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV12GridState.gxTpr_Filtervalues.Item(AV69GXV1));
            if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS") == 0 )
            {
               AV18TFBR_Scheme_Chem_Regimens = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TFBR_Scheme_Chem_Regimens", AV18TFBR_Scheme_Chem_Regimens);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV18TFBR_Scheme_Chem_Regimens)) )
               {
                  Ddo_br_scheme_chem_regimens_Filteredtext_set = AV18TFBR_Scheme_Chem_Regimens;
                  ucDdo_br_scheme_chem_regimens.SendProperty(context, sPrefix, false, Ddo_br_scheme_chem_regimens_Internalname, "FilteredText_set", Ddo_br_scheme_chem_regimens_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS_SEL") == 0 )
            {
               AV19TFBR_Scheme_Chem_Regimens_Sel = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19TFBR_Scheme_Chem_Regimens_Sel", AV19TFBR_Scheme_Chem_Regimens_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19TFBR_Scheme_Chem_Regimens_Sel)) )
               {
                  Ddo_br_scheme_chem_regimens_Selectedvalue_set = AV19TFBR_Scheme_Chem_Regimens_Sel;
                  ucDdo_br_scheme_chem_regimens.SendProperty(context, sPrefix, false, Ddo_br_scheme_chem_regimens_Internalname, "SelectedValue_set", Ddo_br_scheme_chem_regimens_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME") == 0 )
            {
               AV47TFBR_Medication_RXName = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV47TFBR_Medication_RXName", AV47TFBR_Medication_RXName);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47TFBR_Medication_RXName)) )
               {
                  Ddo_br_medication_rxname_Filteredtext_set = AV47TFBR_Medication_RXName;
                  ucDdo_br_medication_rxname.SendProperty(context, sPrefix, false, Ddo_br_medication_rxname_Internalname, "FilteredText_set", Ddo_br_medication_rxname_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME_SEL") == 0 )
            {
               AV48TFBR_Medication_RXName_Sel = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV48TFBR_Medication_RXName_Sel", AV48TFBR_Medication_RXName_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48TFBR_Medication_RXName_Sel)) )
               {
                  Ddo_br_medication_rxname_Selectedvalue_set = AV48TFBR_Medication_RXName_Sel;
                  ucDdo_br_medication_rxname.SendProperty(context, sPrefix, false, Ddo_br_medication_rxname_Internalname, "SelectedValue_set", Ddo_br_medication_rxname_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXDOSE") == 0 )
            {
               AV51TFBR_Medication_RXDose = NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV51TFBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV51TFBR_Medication_RXDose, 15, 5)));
               AV52TFBR_Medication_RXDose_To = NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV52TFBR_Medication_RXDose_To", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Medication_RXDose_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV51TFBR_Medication_RXDose) )
               {
                  Ddo_br_medication_rxdose_Filteredtext_set = StringUtil.Str( AV51TFBR_Medication_RXDose, 15, 5);
                  ucDdo_br_medication_rxdose.SendProperty(context, sPrefix, false, Ddo_br_medication_rxdose_Internalname, "FilteredText_set", Ddo_br_medication_rxdose_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV52TFBR_Medication_RXDose_To) )
               {
                  Ddo_br_medication_rxdose_Filteredtextto_set = StringUtil.Str( AV52TFBR_Medication_RXDose_To, 15, 5);
                  ucDdo_br_medication_rxdose.SendProperty(context, sPrefix, false, Ddo_br_medication_rxdose_Internalname, "FilteredTextTo_set", Ddo_br_medication_rxdose_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXUNIT") == 0 )
            {
               AV55TFBR_Medication_RXUnit = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV55TFBR_Medication_RXUnit", AV55TFBR_Medication_RXUnit);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55TFBR_Medication_RXUnit)) )
               {
                  Ddo_br_medication_rxunit_Filteredtext_set = AV55TFBR_Medication_RXUnit;
                  ucDdo_br_medication_rxunit.SendProperty(context, sPrefix, false, Ddo_br_medication_rxunit_Internalname, "FilteredText_set", Ddo_br_medication_rxunit_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXUNIT_SEL") == 0 )
            {
               AV56TFBR_Medication_RXUnit_Sel = AV13GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV56TFBR_Medication_RXUnit_Sel", AV56TFBR_Medication_RXUnit_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56TFBR_Medication_RXUnit_Sel)) )
               {
                  Ddo_br_medication_rxunit_Selectedvalue_set = AV56TFBR_Medication_RXUnit_Sel;
                  ucDdo_br_medication_rxunit.SendProperty(context, sPrefix, false, Ddo_br_medication_rxunit_Internalname, "SelectedValue_set", Ddo_br_medication_rxunit_Selectedvalue_set);
               }
            }
            AV69GXV1 = (int)(AV69GXV1+1);
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
         AV12GridState.FromXml(AV16Session.Get(AV68Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV12GridState.gxTpr_Orderedby = AV14OrderedBy;
         AV12GridState.gxTpr_Ordereddsc = AV15OrderedDsc;
         AV12GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV18TFBR_Scheme_Chem_Regimens)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_CHEM_REGIMENS";
            AV13GridStateFilterValue.gxTpr_Value = AV18TFBR_Scheme_Chem_Regimens;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19TFBR_Scheme_Chem_Regimens_Sel)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_CHEM_REGIMENS_SEL";
            AV13GridStateFilterValue.gxTpr_Value = AV19TFBR_Scheme_Chem_Regimens_Sel;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47TFBR_Medication_RXName)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXNAME";
            AV13GridStateFilterValue.gxTpr_Value = AV47TFBR_Medication_RXName;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48TFBR_Medication_RXName_Sel)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXNAME_SEL";
            AV13GridStateFilterValue.gxTpr_Value = AV48TFBR_Medication_RXName_Sel;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV51TFBR_Medication_RXDose) && (Convert.ToDecimal(0)==AV52TFBR_Medication_RXDose_To) ) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXDOSE";
            AV13GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV51TFBR_Medication_RXDose, 15, 5);
            AV13GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV52TFBR_Medication_RXDose_To, 15, 5);
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55TFBR_Medication_RXUnit)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXUNIT";
            AV13GridStateFilterValue.gxTpr_Value = AV55TFBR_Medication_RXUnit;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56TFBR_Medication_RXUnit_Sel)) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXUNIT_SEL";
            AV13GridStateFilterValue.gxTpr_Value = AV56TFBR_Medication_RXUnit_Sel;
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! (0==AV8BR_SchemeID) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "PARM_&BR_SCHEMEID";
            AV13GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV8BR_SchemeID), 18, 0);
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         AV12GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV68Pgmname+"GridState",  AV12GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV68Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "BR_Scheme_Medication";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "BR_SchemeID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_SchemeID), 18, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV16Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8BR_SchemeID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_SchemeID), 18, 0)));
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
         PA6H2( ) ;
         WS6H2( ) ;
         WE6H2( ) ;
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
         sCtrlAV8BR_SchemeID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA6H2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_scheme_br_scheme_medication", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA6H2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV8BR_SchemeID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_SchemeID), 18, 0)));
         }
         wcpOAV8BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_SchemeID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( AV8BR_SchemeID != wcpOAV8BR_SchemeID ) ) )
         {
            setjustcreated();
         }
         wcpOAV8BR_SchemeID = AV8BR_SchemeID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV8BR_SchemeID = cgiGet( sPrefix+"AV8BR_SchemeID_CTRL");
         if ( StringUtil.Len( sCtrlAV8BR_SchemeID) > 0 )
         {
            AV8BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( sCtrlAV8BR_SchemeID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_SchemeID), 18, 0)));
         }
         else
         {
            AV8BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"AV8BR_SchemeID_PARM"), ".", ","));
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
         PA6H2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS6H2( ) ;
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
         WS6H2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_SchemeID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_SchemeID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8BR_SchemeID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_SchemeID_CTRL", StringUtil.RTrim( sCtrlAV8BR_SchemeID));
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
         WE6H2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711581695", true);
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
         context.AddJavascriptSource("br_scheme_br_scheme_medication.js", "?202022711581695", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_idx;
         edtavNewupdate_Internalname = sPrefix+"vNEWUPDATE_"+sGXsfl_28_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_28_idx;
         edtBR_Scheme_Chem_Regimens_Internalname = sPrefix+"BR_SCHEME_CHEM_REGIMENS_"+sGXsfl_28_idx;
         edtBR_Medication_RXName_Internalname = sPrefix+"BR_MEDICATION_RXNAME_"+sGXsfl_28_idx;
         edtBR_Medication_RXDose_Internalname = sPrefix+"BR_MEDICATION_RXDOSE_"+sGXsfl_28_idx;
         edtBR_Medication_RXUnit_Internalname = sPrefix+"BR_MEDICATION_RXUNIT_"+sGXsfl_28_idx;
         edtBR_MedicationID_Internalname = sPrefix+"BR_MEDICATIONID_"+sGXsfl_28_idx;
         edtBR_Scheme_MedicationID_Internalname = sPrefix+"BR_SCHEME_MEDICATIONID_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_fel_idx;
         edtavNewupdate_Internalname = sPrefix+"vNEWUPDATE_"+sGXsfl_28_fel_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_28_fel_idx;
         edtBR_Scheme_Chem_Regimens_Internalname = sPrefix+"BR_SCHEME_CHEM_REGIMENS_"+sGXsfl_28_fel_idx;
         edtBR_Medication_RXName_Internalname = sPrefix+"BR_MEDICATION_RXNAME_"+sGXsfl_28_fel_idx;
         edtBR_Medication_RXDose_Internalname = sPrefix+"BR_MEDICATION_RXDOSE_"+sGXsfl_28_fel_idx;
         edtBR_Medication_RXUnit_Internalname = sPrefix+"BR_MEDICATION_RXUNIT_"+sGXsfl_28_fel_idx;
         edtBR_MedicationID_Internalname = sPrefix+"BR_MEDICATIONID_"+sGXsfl_28_fel_idx;
         edtBR_Scheme_MedicationID_Internalname = sPrefix+"BR_SCHEME_MEDICATIONID_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB6H0( ) ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV39Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV39Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV65Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV39Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV39Display)) ? AV65Display_GXI : context.PathToRelativeUrl( AV39Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV39Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavNewupdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavNewupdate_Enabled!=0)&&(edtavNewupdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV60newupdate_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV60newupdate))&&String.IsNullOrEmpty(StringUtil.RTrim( AV66Newupdate_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV60newupdate)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV60newupdate)) ? AV66Newupdate_GXI : context.PathToRelativeUrl( AV60newupdate));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavNewupdate_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavNewupdate_Visible,(short)1,(String)"",(String)edtavNewupdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavNewupdate_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+"e216h2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV60newupdate_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDelete_Enabled!=0)&&(edtavDelete_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV43Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV43Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV67Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV43Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV43Delete)) ? AV67Delete_GXI : context.PathToRelativeUrl( AV43Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavDelete_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+"e226h2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV43Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Chem_Regimens_Internalname,(String)A328BR_Scheme_Chem_Regimens,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_Chem_Regimens_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXName_Internalname,(String)A121BR_Medication_RXName,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXDose_Internalname,StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")),context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXDose_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXUnit_Internalname,(String)A125BR_Medication_RXUnit,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXUnit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicationID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicationID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_MedicationID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_MedicationID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            send_integrity_lvl_hashes6H2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_28_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
         }
         /* End function sendrow_282 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtnmineinsert_Internalname = sPrefix+"BTNMINEINSERT";
         divTableactions_Internalname = sPrefix+"TABLEACTIONS";
         divTableheader_Internalname = sPrefix+"TABLEHEADER";
         divLayout_tableheader_Internalname = sPrefix+"LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = sPrefix+"DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = sPrefix+"HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = sPrefix+"vDISPLAY";
         edtavNewupdate_Internalname = sPrefix+"vNEWUPDATE";
         edtavDelete_Internalname = sPrefix+"vDELETE";
         edtBR_Scheme_Chem_Regimens_Internalname = sPrefix+"BR_SCHEME_CHEM_REGIMENS";
         edtBR_Medication_RXName_Internalname = sPrefix+"BR_MEDICATION_RXNAME";
         edtBR_Medication_RXDose_Internalname = sPrefix+"BR_MEDICATION_RXDOSE";
         edtBR_Medication_RXUnit_Internalname = sPrefix+"BR_MEDICATION_RXUNIT";
         edtBR_MedicationID_Internalname = sPrefix+"BR_MEDICATIONID";
         edtBR_Scheme_MedicationID_Internalname = sPrefix+"BR_SCHEME_MEDICATIONID";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divUnnamedtable1_Internalname = sPrefix+"UNNAMEDTABLE1";
         Ddo_br_scheme_chem_regimens_Internalname = sPrefix+"DDO_BR_SCHEME_CHEM_REGIMENS";
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxname_Internalname = sPrefix+"DDO_BR_MEDICATION_RXNAME";
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxdose_Internalname = sPrefix+"DDO_BR_MEDICATION_RXDOSE";
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxunit_Internalname = sPrefix+"DDO_BR_MEDICATION_RXUNIT";
         edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE";
         edtBR_SchemeID_Internalname = sPrefix+"BR_SCHEMEID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         edtavTfbr_scheme_chem_regimens_Internalname = sPrefix+"vTFBR_SCHEME_CHEM_REGIMENS";
         edtavTfbr_scheme_chem_regimens_sel_Internalname = sPrefix+"vTFBR_SCHEME_CHEM_REGIMENS_SEL";
         edtavTfbr_medication_rxname_Internalname = sPrefix+"vTFBR_MEDICATION_RXNAME";
         edtavTfbr_medication_rxname_sel_Internalname = sPrefix+"vTFBR_MEDICATION_RXNAME_SEL";
         edtavTfbr_medication_rxdose_Internalname = sPrefix+"vTFBR_MEDICATION_RXDOSE";
         edtavTfbr_medication_rxdose_to_Internalname = sPrefix+"vTFBR_MEDICATION_RXDOSE_TO";
         edtavTfbr_medication_rxunit_Internalname = sPrefix+"vTFBR_MEDICATION_RXUNIT";
         edtavTfbr_medication_rxunit_sel_Internalname = sPrefix+"vTFBR_MEDICATION_RXUNIT_SEL";
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
         edtBR_Scheme_MedicationID_Jsonclick = "";
         edtBR_MedicationID_Jsonclick = "";
         edtBR_Medication_RXUnit_Jsonclick = "";
         edtBR_Medication_RXDose_Jsonclick = "";
         edtBR_Medication_RXName_Jsonclick = "";
         edtBR_Scheme_Chem_Regimens_Jsonclick = "";
         edtavDelete_Jsonclick = "";
         edtavDelete_Enabled = 1;
         edtavNewupdate_Jsonclick = "";
         edtavNewupdate_Enabled = 1;
         edtavTfbr_medication_rxunit_sel_Jsonclick = "";
         edtavTfbr_medication_rxunit_sel_Visible = 1;
         edtavTfbr_medication_rxunit_Jsonclick = "";
         edtavTfbr_medication_rxunit_Visible = 1;
         edtavTfbr_medication_rxdose_to_Jsonclick = "";
         edtavTfbr_medication_rxdose_to_Visible = 1;
         edtavTfbr_medication_rxdose_Jsonclick = "";
         edtavTfbr_medication_rxdose_Visible = 1;
         edtavTfbr_medication_rxname_sel_Jsonclick = "";
         edtavTfbr_medication_rxname_sel_Visible = 1;
         edtavTfbr_medication_rxname_Jsonclick = "";
         edtavTfbr_medication_rxname_Visible = 1;
         edtavTfbr_scheme_chem_regimens_sel_Jsonclick = "";
         edtavTfbr_scheme_chem_regimens_sel_Visible = 1;
         edtavTfbr_scheme_chem_regimens_Jsonclick = "";
         edtavTfbr_scheme_chem_regimens_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtBR_SchemeID_Jsonclick = "";
         edtBR_SchemeID_Visible = 1;
         edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavNewupdate_Tooltiptext = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
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
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtnmineinsert_Visible = 1;
         divTableheader_Visible = 1;
         Ddo_br_medication_rxunit_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxunit_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_rxunit_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_rxunit_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_rxunit_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxunit_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxunit_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_rxunit_Datalistproc = "BR_Scheme_BR_Scheme_MedicationGetFilterData";
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
         Ddo_br_medication_rxdose_Rangefilterto = "WWP_TSTo";
         Ddo_br_medication_rxdose_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medication_rxdose_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_rxdose_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxdose_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxdose_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxdose_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdose_Filtertype = "Numeric";
         Ddo_br_medication_rxdose_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdose_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdose_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdose_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxdose_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxdose_Cls = "ColumnSettings";
         Ddo_br_medication_rxdose_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxdose_Caption = "";
         Ddo_br_medication_rxname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxname_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_rxname_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_rxname_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_rxname_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxname_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxname_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_rxname_Datalistproc = "BR_Scheme_BR_Scheme_MedicationGetFilterData";
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
         Ddo_br_scheme_chem_regimens_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_chem_regimens_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_scheme_chem_regimens_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_scheme_chem_regimens_Loadingdata = "WWP_TSLoading";
         Ddo_br_scheme_chem_regimens_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_chem_regimens_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters = 0;
         Ddo_br_scheme_chem_regimens_Datalistproc = "BR_Scheme_BR_Scheme_MedicationGetFilterData";
         Ddo_br_scheme_chem_regimens_Datalisttype = "Dynamic";
         Ddo_br_scheme_chem_regimens_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_regimens_Filtertype = "Character";
         Ddo_br_scheme_chem_regimens_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_chem_regimens_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_chem_regimens_Cls = "ColumnSettings";
         Ddo_br_scheme_chem_regimens_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_chem_regimens_Caption = "";
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
         edtavDelete_Visible = -1;
         edtavNewupdate_Visible = -1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV46BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNMINEINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E126H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E136H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED","{handler:'E146H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_scheme_chem_regimens_Activeeventkey',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'ActiveEventKey'},{av:'Ddo_br_scheme_chem_regimens_Filteredtext_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'FilteredText_get'},{av:'Ddo_br_scheme_chem_regimens_Selectedvalue_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV46BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNMINEINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED","{handler:'E156H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_medication_rxname_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxname_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxname_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV46BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNMINEINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED","{handler:'E166H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_medication_rxdose_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxdose_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxdose_Filteredtextto_get',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV46BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNMINEINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED","{handler:'E176H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV19TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV47TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV48TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV51TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV52TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_medication_rxunit_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxunit_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxunit_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV55TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV56TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV17BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV46BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV36GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV37GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV38GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavNewupdate_Visible',ctrl:'vNEWUPDATE',prop:'Visible'},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNMINEINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E206H2',iparms:[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV44IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV39Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV60newupdate',fld:'vNEWUPDATE',pic:''},{av:'edtavNewupdate_Tooltiptext',ctrl:'vNEWUPDATE',prop:'Tooltiptext'},{av:'AV43Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'}]}");
         setEventMetadata("'DOMINEINSERT'","{handler:'E116H1',iparms:[{av:'AV8BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOMINEINSERT'",",oparms:[]}");
         setEventMetadata("VNEWUPDATE.CLICK","{handler:'E216H2',iparms:[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VNEWUPDATE.CLICK",",oparms:[]}");
         setEventMetadata("VDELETE.CLICK","{handler:'E226H2',iparms:[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_scheme_chem_regimens_Activeeventkey = "";
         Ddo_br_scheme_chem_regimens_Filteredtext_get = "";
         Ddo_br_scheme_chem_regimens_Selectedvalue_get = "";
         Ddo_br_medication_rxname_Activeeventkey = "";
         Ddo_br_medication_rxname_Filteredtext_get = "";
         Ddo_br_medication_rxname_Selectedvalue_get = "";
         Ddo_br_medication_rxdose_Activeeventkey = "";
         Ddo_br_medication_rxdose_Filteredtext_get = "";
         Ddo_br_medication_rxdose_Filteredtextto_get = "";
         Ddo_br_medication_rxunit_Activeeventkey = "";
         Ddo_br_medication_rxunit_Filteredtext_get = "";
         Ddo_br_medication_rxunit_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV18TFBR_Scheme_Chem_Regimens = "";
         AV19TFBR_Scheme_Chem_Regimens_Sel = "";
         AV47TFBR_Medication_RXName = "";
         AV48TFBR_Medication_RXName_Sel = "";
         AV55TFBR_Medication_RXUnit = "";
         AV56TFBR_Medication_RXUnit_Sel = "";
         AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "";
         AV49ddo_BR_Medication_RXNameTitleControlIdToReplace = "";
         AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace = "";
         AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace = "";
         AV68Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV33DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV17BR_Scheme_Chem_RegimensTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_Medication_RXDoseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54BR_Medication_RXUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_scheme_chem_regimens_Filteredtext_set = "";
         Ddo_br_scheme_chem_regimens_Selectedvalue_set = "";
         Ddo_br_scheme_chem_regimens_Sortedstatus = "";
         Ddo_br_medication_rxname_Filteredtext_set = "";
         Ddo_br_medication_rxname_Selectedvalue_set = "";
         Ddo_br_medication_rxname_Sortedstatus = "";
         Ddo_br_medication_rxdose_Filteredtext_set = "";
         Ddo_br_medication_rxdose_Filteredtextto_set = "";
         Ddo_br_medication_rxdose_Sortedstatus = "";
         Ddo_br_medication_rxunit_Filteredtext_set = "";
         Ddo_br_medication_rxunit_Selectedvalue_set = "";
         Ddo_br_medication_rxunit_Sortedstatus = "";
         GX_FocusControl = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnmineinsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV39Display = "";
         AV60newupdate = "";
         AV43Delete = "";
         A328BR_Scheme_Chem_Regimens = "";
         A121BR_Medication_RXName = "";
         A125BR_Medication_RXUnit = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_scheme_chem_regimens = new GXUserControl();
         ucDdo_br_medication_rxname = new GXUserControl();
         ucDdo_br_medication_rxdose = new GXUserControl();
         ucDdo_br_medication_rxunit = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV65Display_GXI = "";
         AV66Newupdate_GXI = "";
         AV67Delete_GXI = "";
         scmdbuf = "";
         lV18TFBR_Scheme_Chem_Regimens = "";
         lV47TFBR_Medication_RXName = "";
         lV55TFBR_Medication_RXUnit = "";
         H006H2_A327BR_SchemeID = new long[1] ;
         H006H2_n327BR_SchemeID = new bool[] {false} ;
         H006H2_A332BR_Scheme_MedicationID = new long[1] ;
         H006H2_A119BR_MedicationID = new long[1] ;
         H006H2_n119BR_MedicationID = new bool[] {false} ;
         H006H2_A125BR_Medication_RXUnit = new String[] {""} ;
         H006H2_n125BR_Medication_RXUnit = new bool[] {false} ;
         H006H2_A124BR_Medication_RXDose = new decimal[1] ;
         H006H2_n124BR_Medication_RXDose = new bool[] {false} ;
         H006H2_A121BR_Medication_RXName = new String[] {""} ;
         H006H2_n121BR_Medication_RXName = new bool[] {false} ;
         H006H2_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         H006H2_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         H006H3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV58tEncounterType = "";
         AV59WebSession = context.GetSession();
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
         sCtrlAV8BR_SchemeID = "";
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_br_scheme_medication__default(),
            new Object[][] {
                new Object[] {
               H006H2_A327BR_SchemeID, H006H2_n327BR_SchemeID, H006H2_A332BR_Scheme_MedicationID, H006H2_A119BR_MedicationID, H006H2_n119BR_MedicationID, H006H2_A125BR_Medication_RXUnit, H006H2_n125BR_Medication_RXUnit, H006H2_A124BR_Medication_RXDose, H006H2_n124BR_Medication_RXDose, H006H2_A121BR_Medication_RXName,
               H006H2_n121BR_Medication_RXName, H006H2_A328BR_Scheme_Chem_Regimens, H006H2_n328BR_Scheme_Chem_Regimens
               }
               , new Object[] {
               H006H3_AGRID_nRecordCount
               }
            }
         );
         AV68Pgmname = "BR_Scheme_BR_Scheme_Medication";
         /* GeneXus formulas. */
         AV68Pgmname = "BR_Scheme_BR_Scheme_Medication";
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
      private short edtBR_Scheme_Chem_Regimens_Titleformat ;
      private short edtBR_Medication_RXName_Titleformat ;
      private short edtBR_Medication_RXDose_Titleformat ;
      private short edtBR_Medication_RXUnit_Titleformat ;
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
      private int edtavNewupdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters ;
      private int Ddo_br_medication_rxname_Datalistupdateminimumcharacters ;
      private int Ddo_br_medication_rxunit_Datalistupdateminimumcharacters ;
      private int divTableheader_Visible ;
      private int bttBtnmineinsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible ;
      private int edtBR_SchemeID_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_scheme_chem_regimens_Visible ;
      private int edtavTfbr_scheme_chem_regimens_sel_Visible ;
      private int edtavTfbr_medication_rxname_Visible ;
      private int edtavTfbr_medication_rxname_sel_Visible ;
      private int edtavTfbr_medication_rxdose_Visible ;
      private int edtavTfbr_medication_rxdose_to_Visible ;
      private int edtavTfbr_medication_rxunit_Visible ;
      private int edtavTfbr_medication_rxunit_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV35PageToGo ;
      private int AV69GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavNewupdate_Enabled ;
      private int edtavDelete_Enabled ;
      private long AV8BR_SchemeID ;
      private long wcpOAV8BR_SchemeID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV36GridCurrentPage ;
      private long AV38GridRecordCount ;
      private long AV37GridPageSize ;
      private long A119BR_MedicationID ;
      private long A332BR_Scheme_MedicationID ;
      private long A327BR_SchemeID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal AV51TFBR_Medication_RXDose ;
      private decimal AV52TFBR_Medication_RXDose_To ;
      private decimal A124BR_Medication_RXDose ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_scheme_chem_regimens_Activeeventkey ;
      private String Ddo_br_scheme_chem_regimens_Filteredtext_get ;
      private String Ddo_br_scheme_chem_regimens_Selectedvalue_get ;
      private String Ddo_br_medication_rxname_Activeeventkey ;
      private String Ddo_br_medication_rxname_Filteredtext_get ;
      private String Ddo_br_medication_rxname_Selectedvalue_get ;
      private String Ddo_br_medication_rxdose_Activeeventkey ;
      private String Ddo_br_medication_rxdose_Filteredtext_get ;
      private String Ddo_br_medication_rxdose_Filteredtextto_get ;
      private String Ddo_br_medication_rxunit_Activeeventkey ;
      private String Ddo_br_medication_rxunit_Filteredtext_get ;
      private String Ddo_br_medication_rxunit_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_28_idx="0001" ;
      private String edtavNewupdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String AV68Pgmname ;
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
      private String Ddo_br_scheme_chem_regimens_Caption ;
      private String Ddo_br_scheme_chem_regimens_Tooltip ;
      private String Ddo_br_scheme_chem_regimens_Cls ;
      private String Ddo_br_scheme_chem_regimens_Filteredtext_set ;
      private String Ddo_br_scheme_chem_regimens_Selectedvalue_set ;
      private String Ddo_br_scheme_chem_regimens_Dropdownoptionstype ;
      private String Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_chem_regimens_Sortedstatus ;
      private String Ddo_br_scheme_chem_regimens_Filtertype ;
      private String Ddo_br_scheme_chem_regimens_Datalisttype ;
      private String Ddo_br_scheme_chem_regimens_Datalistproc ;
      private String Ddo_br_scheme_chem_regimens_Sortasc ;
      private String Ddo_br_scheme_chem_regimens_Sortdsc ;
      private String Ddo_br_scheme_chem_regimens_Loadingdata ;
      private String Ddo_br_scheme_chem_regimens_Cleanfilter ;
      private String Ddo_br_scheme_chem_regimens_Noresultsfound ;
      private String Ddo_br_scheme_chem_regimens_Searchbuttontext ;
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
      private String Ddo_br_medication_rxdose_Caption ;
      private String Ddo_br_medication_rxdose_Tooltip ;
      private String Ddo_br_medication_rxdose_Cls ;
      private String Ddo_br_medication_rxdose_Filteredtext_set ;
      private String Ddo_br_medication_rxdose_Filteredtextto_set ;
      private String Ddo_br_medication_rxdose_Dropdownoptionstype ;
      private String Ddo_br_medication_rxdose_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxdose_Sortedstatus ;
      private String Ddo_br_medication_rxdose_Filtertype ;
      private String Ddo_br_medication_rxdose_Sortasc ;
      private String Ddo_br_medication_rxdose_Sortdsc ;
      private String Ddo_br_medication_rxdose_Cleanfilter ;
      private String Ddo_br_medication_rxdose_Rangefilterfrom ;
      private String Ddo_br_medication_rxdose_Rangefilterto ;
      private String Ddo_br_medication_rxdose_Searchbuttontext ;
      private String Ddo_br_medication_rxunit_Caption ;
      private String Ddo_br_medication_rxunit_Tooltip ;
      private String Ddo_br_medication_rxunit_Cls ;
      private String Ddo_br_medication_rxunit_Filteredtext_set ;
      private String Ddo_br_medication_rxunit_Selectedvalue_set ;
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
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnmineinsert_Internalname ;
      private String bttBtnmineinsert_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Scheme_Chem_Regimens_Title ;
      private String edtBR_Medication_RXName_Title ;
      private String edtBR_Medication_RXDose_Title ;
      private String edtBR_Medication_RXUnit_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavNewupdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_scheme_chem_regimens_Internalname ;
      private String edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxname_Internalname ;
      private String edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxdose_Internalname ;
      private String edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxunit_Internalname ;
      private String edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname ;
      private String edtBR_SchemeID_Internalname ;
      private String edtBR_SchemeID_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_scheme_chem_regimens_Internalname ;
      private String edtavTfbr_scheme_chem_regimens_Jsonclick ;
      private String edtavTfbr_scheme_chem_regimens_sel_Internalname ;
      private String edtavTfbr_scheme_chem_regimens_sel_Jsonclick ;
      private String edtavTfbr_medication_rxname_Internalname ;
      private String edtavTfbr_medication_rxname_Jsonclick ;
      private String edtavTfbr_medication_rxname_sel_Internalname ;
      private String edtavTfbr_medication_rxname_sel_Jsonclick ;
      private String edtavTfbr_medication_rxdose_Internalname ;
      private String edtavTfbr_medication_rxdose_Jsonclick ;
      private String edtavTfbr_medication_rxdose_to_Internalname ;
      private String edtavTfbr_medication_rxdose_to_Jsonclick ;
      private String edtavTfbr_medication_rxunit_Internalname ;
      private String edtavTfbr_medication_rxunit_Jsonclick ;
      private String edtavTfbr_medication_rxunit_sel_Internalname ;
      private String edtavTfbr_medication_rxunit_sel_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtBR_Scheme_Chem_Regimens_Internalname ;
      private String edtBR_Medication_RXName_Internalname ;
      private String edtBR_Medication_RXDose_Internalname ;
      private String edtBR_Medication_RXUnit_Internalname ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_Scheme_MedicationID_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV8BR_SchemeID ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavNewupdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Scheme_Chem_Regimens_Jsonclick ;
      private String edtBR_Medication_RXName_Jsonclick ;
      private String edtBR_Medication_RXDose_Jsonclick ;
      private String edtBR_Medication_RXUnit_Jsonclick ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_Scheme_MedicationID_Jsonclick ;
      private bool entryPointCalled ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool AV15OrderedDsc ;
      private bool AV44IsAuthorized_Delete ;
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
      private bool Ddo_br_scheme_chem_regimens_Includesortasc ;
      private bool Ddo_br_scheme_chem_regimens_Includesortdsc ;
      private bool Ddo_br_scheme_chem_regimens_Includefilter ;
      private bool Ddo_br_scheme_chem_regimens_Filterisrange ;
      private bool Ddo_br_scheme_chem_regimens_Includedatalist ;
      private bool Ddo_br_medication_rxname_Includesortasc ;
      private bool Ddo_br_medication_rxname_Includesortdsc ;
      private bool Ddo_br_medication_rxname_Includefilter ;
      private bool Ddo_br_medication_rxname_Filterisrange ;
      private bool Ddo_br_medication_rxname_Includedatalist ;
      private bool Ddo_br_medication_rxdose_Includesortasc ;
      private bool Ddo_br_medication_rxdose_Includesortdsc ;
      private bool Ddo_br_medication_rxdose_Includefilter ;
      private bool Ddo_br_medication_rxdose_Filterisrange ;
      private bool Ddo_br_medication_rxdose_Includedatalist ;
      private bool Ddo_br_medication_rxunit_Includesortasc ;
      private bool Ddo_br_medication_rxunit_Includesortdsc ;
      private bool Ddo_br_medication_rxunit_Includefilter ;
      private bool Ddo_br_medication_rxunit_Filterisrange ;
      private bool Ddo_br_medication_rxunit_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n121BR_Medication_RXName ;
      private bool n124BR_Medication_RXDose ;
      private bool n125BR_Medication_RXUnit ;
      private bool n119BR_MedicationID ;
      private bool gxdyncontrolsrefreshing ;
      private bool n327BR_SchemeID ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV61IsAuthorized_newupdate ;
      private bool AV45TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV39Display_IsBlob ;
      private bool AV60newupdate_IsBlob ;
      private bool AV43Delete_IsBlob ;
      private String AV18TFBR_Scheme_Chem_Regimens ;
      private String AV19TFBR_Scheme_Chem_Regimens_Sel ;
      private String AV47TFBR_Medication_RXName ;
      private String AV48TFBR_Medication_RXName_Sel ;
      private String AV55TFBR_Medication_RXUnit ;
      private String AV56TFBR_Medication_RXUnit_Sel ;
      private String AV20ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace ;
      private String AV49ddo_BR_Medication_RXNameTitleControlIdToReplace ;
      private String AV53ddo_BR_Medication_RXDoseTitleControlIdToReplace ;
      private String AV57ddo_BR_Medication_RXUnitTitleControlIdToReplace ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String A121BR_Medication_RXName ;
      private String A125BR_Medication_RXUnit ;
      private String AV65Display_GXI ;
      private String AV66Newupdate_GXI ;
      private String AV67Delete_GXI ;
      private String lV18TFBR_Scheme_Chem_Regimens ;
      private String lV47TFBR_Medication_RXName ;
      private String lV55TFBR_Medication_RXUnit ;
      private String AV58tEncounterType ;
      private String AV39Display ;
      private String AV60newupdate ;
      private String AV43Delete ;
      private IGxSession AV59WebSession ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_scheme_chem_regimens ;
      private GXUserControl ucDdo_br_medication_rxname ;
      private GXUserControl ucDdo_br_medication_rxdose ;
      private GXUserControl ucDdo_br_medication_rxunit ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H006H2_A327BR_SchemeID ;
      private bool[] H006H2_n327BR_SchemeID ;
      private long[] H006H2_A332BR_Scheme_MedicationID ;
      private long[] H006H2_A119BR_MedicationID ;
      private bool[] H006H2_n119BR_MedicationID ;
      private String[] H006H2_A125BR_Medication_RXUnit ;
      private bool[] H006H2_n125BR_Medication_RXUnit ;
      private decimal[] H006H2_A124BR_Medication_RXDose ;
      private bool[] H006H2_n124BR_Medication_RXDose ;
      private String[] H006H2_A121BR_Medication_RXName ;
      private bool[] H006H2_n121BR_Medication_RXName ;
      private String[] H006H2_A328BR_Scheme_Chem_Regimens ;
      private bool[] H006H2_n328BR_Scheme_Chem_Regimens ;
      private long[] H006H3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Scheme_Chem_RegimensTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV46BR_Medication_RXNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV50BR_Medication_RXDoseTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV54BR_Medication_RXUnitTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV13GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV33DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_scheme_br_scheme_medication__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H006H2( IGxContext context ,
                                             String AV19TFBR_Scheme_Chem_Regimens_Sel ,
                                             String AV18TFBR_Scheme_Chem_Regimens ,
                                             String AV48TFBR_Medication_RXName_Sel ,
                                             String AV47TFBR_Medication_RXName ,
                                             decimal AV51TFBR_Medication_RXDose ,
                                             decimal AV52TFBR_Medication_RXDose_To ,
                                             String AV56TFBR_Medication_RXUnit_Sel ,
                                             String AV55TFBR_Medication_RXUnit ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A121BR_Medication_RXName ,
                                             decimal A124BR_Medication_RXDose ,
                                             String A125BR_Medication_RXUnit ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A327BR_SchemeID ,
                                             long AV8BR_SchemeID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [12] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[BR_SchemeID], T1.[BR_Scheme_MedicationID], T1.[BR_MedicationID], T3.[BR_Medication_RXUnit], T3.[BR_Medication_RXDose], T3.[BR_Medication_RXName], T2.[BR_Scheme_Chem_Regimens]";
         sFromString = " FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Scheme] T2 WITH (NOLOCK) ON T2.[BR_SchemeID] = T1.[BR_SchemeID]) LEFT JOIN [BR_Medication] T3 WITH (NOLOCK) ON T3.[BR_MedicationID] = T1.[BR_MedicationID])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[BR_SchemeID] = @AV8BR_SchemeID)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV19TFBR_Scheme_Chem_Regimens_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV18TFBR_Scheme_Chem_Regimens)) ) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Scheme_Chem_Regimens] like @lV18TFBR_Scheme_Chem_Regimens)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19TFBR_Scheme_Chem_Regimens_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Scheme_Chem_Regimens] = @AV19TFBR_Scheme_Chem_Regimens_Sel)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48TFBR_Medication_RXName_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47TFBR_Medication_RXName)) ) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXName] like @lV47TFBR_Medication_RXName)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48TFBR_Medication_RXName_Sel)) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXName] = @AV48TFBR_Medication_RXName_Sel)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV51TFBR_Medication_RXDose) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXDose] >= @AV51TFBR_Medication_RXDose)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV52TFBR_Medication_RXDose_To) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXDose] <= @AV52TFBR_Medication_RXDose_To)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56TFBR_Medication_RXUnit_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55TFBR_Medication_RXUnit)) ) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXUnit] like @lV55TFBR_Medication_RXUnit)";
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56TFBR_Medication_RXUnit_Sel)) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXUnit] = @AV56TFBR_Medication_RXUnit_Sel)";
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Scheme_MedicationID] DESC";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Scheme_MedicationID]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_SchemeID], T3.[BR_Medication_RXName]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_SchemeID] DESC, T3.[BR_Medication_RXName] DESC";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_SchemeID], T3.[BR_Medication_RXDose]";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_SchemeID] DESC, T3.[BR_Medication_RXDose] DESC";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_SchemeID], T3.[BR_Medication_RXUnit]";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_SchemeID] DESC, T3.[BR_Medication_RXUnit] DESC";
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

      protected Object[] conditional_H006H3( IGxContext context ,
                                             String AV19TFBR_Scheme_Chem_Regimens_Sel ,
                                             String AV18TFBR_Scheme_Chem_Regimens ,
                                             String AV48TFBR_Medication_RXName_Sel ,
                                             String AV47TFBR_Medication_RXName ,
                                             decimal AV51TFBR_Medication_RXDose ,
                                             decimal AV52TFBR_Medication_RXDose_To ,
                                             String AV56TFBR_Medication_RXUnit_Sel ,
                                             String AV55TFBR_Medication_RXUnit ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A121BR_Medication_RXName ,
                                             decimal A124BR_Medication_RXDose ,
                                             String A125BR_Medication_RXUnit ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A327BR_SchemeID ,
                                             long AV8BR_SchemeID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [9] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Scheme] T2 WITH (NOLOCK) ON T2.[BR_SchemeID] = T1.[BR_SchemeID]) LEFT JOIN [BR_Medication] T3 WITH (NOLOCK) ON T3.[BR_MedicationID] = T1.[BR_MedicationID])";
         scmdbuf = scmdbuf + " WHERE (T1.[BR_SchemeID] = @AV8BR_SchemeID)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV19TFBR_Scheme_Chem_Regimens_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV18TFBR_Scheme_Chem_Regimens)) ) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Scheme_Chem_Regimens] like @lV18TFBR_Scheme_Chem_Regimens)";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19TFBR_Scheme_Chem_Regimens_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Scheme_Chem_Regimens] = @AV19TFBR_Scheme_Chem_Regimens_Sel)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48TFBR_Medication_RXName_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47TFBR_Medication_RXName)) ) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXName] like @lV47TFBR_Medication_RXName)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48TFBR_Medication_RXName_Sel)) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXName] = @AV48TFBR_Medication_RXName_Sel)";
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV51TFBR_Medication_RXDose) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXDose] >= @AV51TFBR_Medication_RXDose)";
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV52TFBR_Medication_RXDose_To) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXDose] <= @AV52TFBR_Medication_RXDose_To)";
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56TFBR_Medication_RXUnit_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55TFBR_Medication_RXUnit)) ) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXUnit] like @lV55TFBR_Medication_RXUnit)";
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56TFBR_Medication_RXUnit_Sel)) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Medication_RXUnit] = @AV56TFBR_Medication_RXUnit_Sel)";
         }
         else
         {
            GXv_int5[8] = 1;
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
                     return conditional_H006H2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (decimal)dynConstraints[4] , (decimal)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] );
               case 1 :
                     return conditional_H006H3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (decimal)dynConstraints[4] , (decimal)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] );
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
          Object[] prmH006H2 ;
          prmH006H2 = new Object[] {
          new Object[] {"@AV8BR_SchemeID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV18TFBR_Scheme_Chem_Regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV19TFBR_Scheme_Chem_Regimens_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV47TFBR_Medication_RXName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV48TFBR_Medication_RXName_Sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV51TFBR_Medication_RXDose",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV52TFBR_Medication_RXDose_To",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV55TFBR_Medication_RXUnit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV56TFBR_Medication_RXUnit_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH006H3 ;
          prmH006H3 = new Object[] {
          new Object[] {"@AV8BR_SchemeID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV18TFBR_Scheme_Chem_Regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV19TFBR_Scheme_Chem_Regimens_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV47TFBR_Medication_RXName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV48TFBR_Medication_RXName_Sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV51TFBR_Medication_RXDose",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV52TFBR_Medication_RXDose_To",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV55TFBR_Medication_RXUnit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV56TFBR_Medication_RXUnit_Sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H006H2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006H2,11,0,true,false )
             ,new CursorDef("H006H3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006H3,1,0,true,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
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
                   stmt.SetParameter(sIdx, (long)parms[12]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[23]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                return;
       }
    }

 }

}
