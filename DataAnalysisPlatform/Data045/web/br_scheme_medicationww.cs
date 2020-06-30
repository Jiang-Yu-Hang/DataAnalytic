/*
               File: BR_Scheme_MedicationWW
        Description:  化疗方案药物详情
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:15:29.98
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
   public class br_scheme_medicationww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_scheme_medicationww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_scheme_medicationww( IGxContext context )
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
               nRC_GXsfl_31 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_31_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_31_idx = GetNextPar( );
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
               AV17TFBR_Scheme_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_Scheme_MedicationID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_SchemeID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV26TFBR_MedicationID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV29TFBR_Scheme_Chem_Regimens = GetNextPar( );
               AV30TFBR_Scheme_Chem_Regimens_Sel = GetNextPar( );
               AV33TFBR_Medication_RXName = GetNextPar( );
               AV34TFBR_Medication_RXName_Sel = GetNextPar( );
               AV37TFBR_Medication_RXDose = NumberUtil.Val( GetNextPar( ), ".");
               AV38TFBR_Medication_RXDose_To = NumberUtil.Val( GetNextPar( ), ".");
               AV41TFBR_Medication_RXUnit = GetNextPar( );
               AV42TFBR_Medication_RXUnit_Sel = GetNextPar( );
               AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_SchemeIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_MedicationIDTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_Medication_RXNameTitleControlIdToReplace = GetNextPar( );
               AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace = GetNextPar( );
               AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace = GetNextPar( );
               AV76Pgmname = GetNextPar( );
               AV56IsAuthorized_BR_Scheme_MedicationID = StringUtil.StrToBool( GetNextPar( ));
               AV54IsAuthorized_BR_Scheme_Chem_Regimens = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Scheme_MedicationID, AV18TFBR_Scheme_MedicationID_To, AV21TFBR_SchemeID, AV22TFBR_SchemeID_To, AV25TFBR_MedicationID, AV26TFBR_MedicationID_To, AV29TFBR_Scheme_Chem_Regimens, AV30TFBR_Scheme_Chem_Regimens_Sel, AV33TFBR_Medication_RXName, AV34TFBR_Medication_RXName_Sel, AV37TFBR_Medication_RXDose, AV38TFBR_Medication_RXDose_To, AV41TFBR_Medication_RXUnit, AV42TFBR_Medication_RXUnit_Sel, AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV23ddo_BR_SchemeIDTitleControlIdToReplace, AV27ddo_BR_MedicationIDTitleControlIdToReplace, AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV35ddo_BR_Medication_RXNameTitleControlIdToReplace, AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV76Pgmname, AV56IsAuthorized_BR_Scheme_MedicationID, AV54IsAuthorized_BR_Scheme_Chem_Regimens) ;
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
         PA6J2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START6J2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815153030", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_scheme_medicationww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Scheme_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_MEDICATIONID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Scheme_MedicationID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEMEID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_SchemeID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25TFBR_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATIONID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26TFBR_MedicationID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_CHEM_REGIMENS", AV29TFBR_Scheme_Chem_Regimens);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_CHEM_REGIMENS_SEL", AV30TFBR_Scheme_Chem_Regimens_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXNAME", AV33TFBR_Medication_RXName);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXNAME_SEL", AV34TFBR_Medication_RXName_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXDOSE", StringUtil.LTrim( StringUtil.NToC( AV37TFBR_Medication_RXDose, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXDOSE_TO", StringUtil.LTrim( StringUtil.NToC( AV38TFBR_Medication_RXDose_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXUNIT", AV41TFBR_Medication_RXUnit);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXUNIT_SEL", AV42TFBR_Medication_RXUnit_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV46GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV48GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV47GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV44DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV44DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA", AV16BR_Scheme_MedicationIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA", AV16BR_Scheme_MedicationIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEMEIDTITLEFILTERDATA", AV20BR_SchemeIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEMEIDTITLEFILTERDATA", AV20BR_SchemeIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATIONIDTITLEFILTERDATA", AV24BR_MedicationIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATIONIDTITLEFILTERDATA", AV24BR_MedicationIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", AV28BR_Scheme_Chem_RegimensTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", AV28BR_Scheme_Chem_RegimensTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXNAMETITLEFILTERDATA", AV32BR_Medication_RXNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXNAMETITLEFILTERDATA", AV32BR_Medication_RXNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXDOSETITLEFILTERDATA", AV36BR_Medication_RXDoseTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXDOSETITLEFILTERDATA", AV36BR_Medication_RXDoseTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXUNITTITLEFILTERDATA", AV40BR_Medication_RXUnitTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXUNITTITLEFILTERDATA", AV40BR_Medication_RXUnitTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV76Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_SCHEME_MEDICATIONID", AV56IsAuthorized_BR_Scheme_MedicationID);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_SCHEME_MEDICATIONID", GetSecureSignedToken( "", AV56IsAuthorized_BR_Scheme_MedicationID, context));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS", AV54IsAuthorized_BR_Scheme_Chem_Regimens);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS", GetSecureSignedToken( "", AV54IsAuthorized_BR_Scheme_Chem_Regimens, context));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Filteredtext_set", StringUtil.RTrim( Ddo_br_scheme_medicationid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_scheme_medicationid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_medicationid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_medicationid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_medicationid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_medicationid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_medicationid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_medicationid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Filtertype", StringUtil.RTrim( Ddo_br_scheme_medicationid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Filterisrange", StringUtil.BoolToStr( Ddo_br_scheme_medicationid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_medicationid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Sortasc", StringUtil.RTrim( Ddo_br_scheme_medicationid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_medicationid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Cleanfilter", StringUtil.RTrim( Ddo_br_scheme_medicationid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_scheme_medicationid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Rangefilterto", StringUtil.RTrim( Ddo_br_scheme_medicationid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_medicationid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Caption", StringUtil.RTrim( Ddo_br_schemeid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Tooltip", StringUtil.RTrim( Ddo_br_schemeid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Cls", StringUtil.RTrim( Ddo_br_schemeid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtext_set", StringUtil.RTrim( Ddo_br_schemeid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_schemeid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_schemeid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_schemeid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includesortasc", StringUtil.BoolToStr( Ddo_br_schemeid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_schemeid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortedstatus", StringUtil.RTrim( Ddo_br_schemeid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includefilter", StringUtil.BoolToStr( Ddo_br_schemeid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filtertype", StringUtil.RTrim( Ddo_br_schemeid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filterisrange", StringUtil.BoolToStr( Ddo_br_schemeid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includedatalist", StringUtil.BoolToStr( Ddo_br_schemeid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortasc", StringUtil.RTrim( Ddo_br_schemeid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortdsc", StringUtil.RTrim( Ddo_br_schemeid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Cleanfilter", StringUtil.RTrim( Ddo_br_schemeid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_schemeid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Rangefilterto", StringUtil.RTrim( Ddo_br_schemeid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Searchbuttontext", StringUtil.RTrim( Ddo_br_schemeid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Caption", StringUtil.RTrim( Ddo_br_medicationid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Tooltip", StringUtil.RTrim( Ddo_br_medicationid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Cls", StringUtil.RTrim( Ddo_br_medicationid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filteredtext_set", StringUtil.RTrim( Ddo_br_medicationid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medicationid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicationid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicationid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicationid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicationid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Sortedstatus", StringUtil.RTrim( Ddo_br_medicationid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Includefilter", StringUtil.BoolToStr( Ddo_br_medicationid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filtertype", StringUtil.RTrim( Ddo_br_medicationid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filterisrange", StringUtil.BoolToStr( Ddo_br_medicationid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicationid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Sortasc", StringUtil.RTrim( Ddo_br_medicationid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Sortdsc", StringUtil.RTrim( Ddo_br_medicationid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Cleanfilter", StringUtil.RTrim( Ddo_br_medicationid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medicationid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Rangefilterto", StringUtil.RTrim( Ddo_br_medicationid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicationid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Caption", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Tooltip", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Cls", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_set", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_set", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Filtertype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Filterisrange", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Datalisttype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Datalistproc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortasc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Loadingdata", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Cleanfilter", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Noresultsfound", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Caption", StringUtil.RTrim( Ddo_br_medication_rxdose_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxdose_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Cls", StringUtil.RTrim( Ddo_br_medication_rxdose_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxdose_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxdose_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxdose_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxdose_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medication_rxdose_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Rangefilterto", StringUtil.RTrim( Ddo_br_medication_rxdose_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxdose_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Caption", StringUtil.RTrim( Ddo_br_medication_rxunit_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxunit_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Cls", StringUtil.RTrim( Ddo_br_medication_rxunit_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_rxunit_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_rxunit_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxunit_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxunit_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxunit_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Datalisttype", StringUtil.RTrim( Ddo_br_medication_rxunit_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Datalistproc", StringUtil.RTrim( Ddo_br_medication_rxunit_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_rxunit_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Loadingdata", StringUtil.RTrim( Ddo_br_medication_rxunit_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxunit_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_rxunit_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxunit_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_medicationid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_scheme_medicationid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtext_get", StringUtil.RTrim( Ddo_br_schemeid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_schemeid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicationid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medicationid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxname_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxname_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdose_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_medicationid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_scheme_medicationid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtext_get", StringUtil.RTrim( Ddo_br_schemeid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_schemeid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicationid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medicationid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxname_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxname_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdose_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_rxdose_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Selectedvalue_get));
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
            WE6J2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT6J2( ) ;
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
         return formatLink("br_scheme_medicationww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Scheme_MedicationWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 化疗方案药物详情" ;
      }

      protected void WB6J0( )
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
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
            ucDvpanel_tableheader.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableheader_Internalname, "DVPANEL_TABLEHEADERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEHEADERContainer"+"Body"+"\" style=\"display:none;\">") ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupColoredActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Scheme_MedicationWW.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"31\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV49Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV50Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV52Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_MedicationID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_MedicationID_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Scheme_MedicationID_Link));
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
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Scheme_Chem_Regimens_Link));
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
         if ( wbEnd == 31 )
         {
            wbEnd = 0;
            nRC_GXsfl_31 = (short)(nGXsfl_31_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV46GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV48GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV47GridPageSize);
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
            ucDdo_br_scheme_medicationid.SetProperty("FilterType", Ddo_br_scheme_medicationid_Filtertype);
            ucDdo_br_scheme_medicationid.SetProperty("FilterIsRange", Ddo_br_scheme_medicationid_Filterisrange);
            ucDdo_br_scheme_medicationid.SetProperty("IncludeDataList", Ddo_br_scheme_medicationid_Includedatalist);
            ucDdo_br_scheme_medicationid.SetProperty("SortASC", Ddo_br_scheme_medicationid_Sortasc);
            ucDdo_br_scheme_medicationid.SetProperty("SortDSC", Ddo_br_scheme_medicationid_Sortdsc);
            ucDdo_br_scheme_medicationid.SetProperty("CleanFilter", Ddo_br_scheme_medicationid_Cleanfilter);
            ucDdo_br_scheme_medicationid.SetProperty("RangeFilterFrom", Ddo_br_scheme_medicationid_Rangefilterfrom);
            ucDdo_br_scheme_medicationid.SetProperty("RangeFilterTo", Ddo_br_scheme_medicationid_Rangefilterto);
            ucDdo_br_scheme_medicationid.SetProperty("SearchButtonText", Ddo_br_scheme_medicationid_Searchbuttontext);
            ucDdo_br_scheme_medicationid.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_br_scheme_medicationid.SetProperty("DropDownOptionsData", AV16BR_Scheme_MedicationIDTitleFilterData);
            ucDdo_br_scheme_medicationid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_medicationid_Internalname, "DDO_BR_SCHEME_MEDICATIONIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationWW.htm");
            /* User Defined Control */
            ucDdo_br_schemeid.SetProperty("Caption", Ddo_br_schemeid_Caption);
            ucDdo_br_schemeid.SetProperty("Tooltip", Ddo_br_schemeid_Tooltip);
            ucDdo_br_schemeid.SetProperty("Cls", Ddo_br_schemeid_Cls);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsType", Ddo_br_schemeid_Dropdownoptionstype);
            ucDdo_br_schemeid.SetProperty("IncludeSortASC", Ddo_br_schemeid_Includesortasc);
            ucDdo_br_schemeid.SetProperty("IncludeSortDSC", Ddo_br_schemeid_Includesortdsc);
            ucDdo_br_schemeid.SetProperty("IncludeFilter", Ddo_br_schemeid_Includefilter);
            ucDdo_br_schemeid.SetProperty("FilterType", Ddo_br_schemeid_Filtertype);
            ucDdo_br_schemeid.SetProperty("FilterIsRange", Ddo_br_schemeid_Filterisrange);
            ucDdo_br_schemeid.SetProperty("IncludeDataList", Ddo_br_schemeid_Includedatalist);
            ucDdo_br_schemeid.SetProperty("SortASC", Ddo_br_schemeid_Sortasc);
            ucDdo_br_schemeid.SetProperty("SortDSC", Ddo_br_schemeid_Sortdsc);
            ucDdo_br_schemeid.SetProperty("CleanFilter", Ddo_br_schemeid_Cleanfilter);
            ucDdo_br_schemeid.SetProperty("RangeFilterFrom", Ddo_br_schemeid_Rangefilterfrom);
            ucDdo_br_schemeid.SetProperty("RangeFilterTo", Ddo_br_schemeid_Rangefilterto);
            ucDdo_br_schemeid.SetProperty("SearchButtonText", Ddo_br_schemeid_Searchbuttontext);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsData", AV20BR_SchemeIDTitleFilterData);
            ucDdo_br_schemeid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_schemeid_Internalname, "DDO_BR_SCHEMEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname, AV23ddo_BR_SchemeIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationWW.htm");
            /* User Defined Control */
            ucDdo_br_medicationid.SetProperty("Caption", Ddo_br_medicationid_Caption);
            ucDdo_br_medicationid.SetProperty("Tooltip", Ddo_br_medicationid_Tooltip);
            ucDdo_br_medicationid.SetProperty("Cls", Ddo_br_medicationid_Cls);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsType", Ddo_br_medicationid_Dropdownoptionstype);
            ucDdo_br_medicationid.SetProperty("IncludeSortASC", Ddo_br_medicationid_Includesortasc);
            ucDdo_br_medicationid.SetProperty("IncludeSortDSC", Ddo_br_medicationid_Includesortdsc);
            ucDdo_br_medicationid.SetProperty("IncludeFilter", Ddo_br_medicationid_Includefilter);
            ucDdo_br_medicationid.SetProperty("FilterType", Ddo_br_medicationid_Filtertype);
            ucDdo_br_medicationid.SetProperty("FilterIsRange", Ddo_br_medicationid_Filterisrange);
            ucDdo_br_medicationid.SetProperty("IncludeDataList", Ddo_br_medicationid_Includedatalist);
            ucDdo_br_medicationid.SetProperty("SortASC", Ddo_br_medicationid_Sortasc);
            ucDdo_br_medicationid.SetProperty("SortDSC", Ddo_br_medicationid_Sortdsc);
            ucDdo_br_medicationid.SetProperty("CleanFilter", Ddo_br_medicationid_Cleanfilter);
            ucDdo_br_medicationid.SetProperty("RangeFilterFrom", Ddo_br_medicationid_Rangefilterfrom);
            ucDdo_br_medicationid.SetProperty("RangeFilterTo", Ddo_br_medicationid_Rangefilterto);
            ucDdo_br_medicationid.SetProperty("SearchButtonText", Ddo_br_medicationid_Searchbuttontext);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsData", AV24BR_MedicationIDTitleFilterData);
            ucDdo_br_medicationid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicationid_Internalname, "DDO_BR_MEDICATIONIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname, AV27ddo_BR_MedicationIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationWW.htm");
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
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsData", AV28BR_Scheme_Chem_RegimensTitleFilterData);
            ucDdo_br_scheme_chem_regimens.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_chem_regimens_Internalname, "DDO_BR_SCHEME_CHEM_REGIMENSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname, AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationWW.htm");
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
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsData", AV32BR_Medication_RXNameTitleFilterData);
            ucDdo_br_medication_rxname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxname_Internalname, "DDO_BR_MEDICATION_RXNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, AV35ddo_BR_Medication_RXNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", 0, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationWW.htm");
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
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsData", AV36BR_Medication_RXDoseTitleFilterData);
            ucDdo_br_medication_rxdose.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxdose_Internalname, "DDO_BR_MEDICATION_RXDOSEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname, AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", 0, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationWW.htm");
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
            ucDdo_br_medication_rxunit.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxunit.SetProperty("DropDownOptionsData", AV40BR_Medication_RXUnitTitleFilterData);
            ucDdo_br_medication_rxunit.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxunit_Internalname, "DDO_BR_MEDICATION_RXUNITContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname, AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", 0, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_medicationid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Scheme_MedicationID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_medicationid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_medicationid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_medicationid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Scheme_MedicationID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_Scheme_MedicationID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_medicationid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_medicationid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_schemeid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_SchemeID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_SchemeID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_schemeid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_schemeid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_schemeid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_SchemeID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_SchemeID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_schemeid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_schemeid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicationid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25TFBR_MedicationID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV25TFBR_MedicationID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicationid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicationid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicationid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26TFBR_MedicationID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV26TFBR_MedicationID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicationid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicationid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_chem_regimens_Internalname, AV29TFBR_Scheme_Chem_Regimens, StringUtil.RTrim( context.localUtil.Format( AV29TFBR_Scheme_Chem_Regimens, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_chem_regimens_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_chem_regimens_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_chem_regimens_sel_Internalname, AV30TFBR_Scheme_Chem_Regimens_Sel, StringUtil.RTrim( context.localUtil.Format( AV30TFBR_Scheme_Chem_Regimens_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_chem_regimens_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_chem_regimens_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxname_Internalname, AV33TFBR_Medication_RXName, StringUtil.RTrim( context.localUtil.Format( AV33TFBR_Medication_RXName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxname_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxname_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxname_sel_Internalname, AV34TFBR_Medication_RXName_Sel, StringUtil.RTrim( context.localUtil.Format( AV34TFBR_Medication_RXName_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxname_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxname_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxdose_Internalname, StringUtil.LTrim( StringUtil.NToC( AV37TFBR_Medication_RXDose, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV37TFBR_Medication_RXDose, "ZZZZZZZZZ.ZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxdose_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxdose_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxdose_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV38TFBR_Medication_RXDose_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV38TFBR_Medication_RXDose_To, "ZZZZZZZZZ.ZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxdose_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxdose_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxunit_Internalname, AV41TFBR_Medication_RXUnit, StringUtil.RTrim( context.localUtil.Format( AV41TFBR_Medication_RXUnit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxunit_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxunit_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxunit_sel_Internalname, AV42TFBR_Medication_RXUnit_Sel, StringUtil.RTrim( context.localUtil.Format( AV42TFBR_Medication_RXUnit_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxunit_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxunit_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 31 )
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

      protected void START6J2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 化疗方案药物详情", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP6J0( ) ;
      }

      protected void WS6J2( )
      {
         START6J2( ) ;
         EVT6J2( ) ;
      }

      protected void EVT6J2( )
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
                              E116J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E126J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E136J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEMEID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E146J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATIONID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E156J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E166J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E176J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E186J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E196J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E206J2 ();
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
                              nGXsfl_31_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
                              SubsflControlProps_312( ) ;
                              AV49Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV49Display)) ? AV73Display_GXI : context.convertURL( context.PathToRelativeUrl( AV49Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV49Display), true);
                              AV50Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV50Update)) ? AV74Update_GXI : context.convertURL( context.PathToRelativeUrl( AV50Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV50Update), true);
                              AV52Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV52Delete)) ? AV75Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV52Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV52Delete), true);
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
                                    E216J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E226J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E236J2 ();
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
                                       /* Set Refresh If Tfbr_scheme_medicationid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEME_MEDICATIONID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Scheme_MedicationID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_medicationid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEME_MEDICATIONID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Scheme_MedicationID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_schemeid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEMEID"), ".", ",") != Convert.ToDecimal( AV21TFBR_SchemeID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_schemeid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEMEID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_SchemeID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicationid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATIONID"), ".", ",") != Convert.ToDecimal( AV25TFBR_MedicationID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicationid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATIONID_TO"), ".", ",") != Convert.ToDecimal( AV26TFBR_MedicationID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_chem_regimens Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_REGIMENS"), AV29TFBR_Scheme_Chem_Regimens) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_chem_regimens_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_REGIMENS_SEL"), AV30TFBR_Scheme_Chem_Regimens_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxname Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXNAME"), AV33TFBR_Medication_RXName) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxname_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXNAME_SEL"), AV34TFBR_Medication_RXName_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxdose Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_RXDOSE"), ".", ",") != AV37TFBR_Medication_RXDose )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxdose_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_RXDOSE_TO"), ".", ",") != AV38TFBR_Medication_RXDose_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxunit Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXUNIT"), AV41TFBR_Medication_RXUnit) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxunit_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXUNIT_SEL"), AV42TFBR_Medication_RXUnit_Sel) != 0 )
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

      protected void WE6J2( )
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

      protected void PA6J2( )
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
         SubsflControlProps_312( ) ;
         while ( nGXsfl_31_idx <= nRC_GXsfl_31 )
         {
            sendrow_312( ) ;
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV17TFBR_Scheme_MedicationID ,
                                       long AV18TFBR_Scheme_MedicationID_To ,
                                       long AV21TFBR_SchemeID ,
                                       long AV22TFBR_SchemeID_To ,
                                       long AV25TFBR_MedicationID ,
                                       long AV26TFBR_MedicationID_To ,
                                       String AV29TFBR_Scheme_Chem_Regimens ,
                                       String AV30TFBR_Scheme_Chem_Regimens_Sel ,
                                       String AV33TFBR_Medication_RXName ,
                                       String AV34TFBR_Medication_RXName_Sel ,
                                       decimal AV37TFBR_Medication_RXDose ,
                                       decimal AV38TFBR_Medication_RXDose_To ,
                                       String AV41TFBR_Medication_RXUnit ,
                                       String AV42TFBR_Medication_RXUnit_Sel ,
                                       String AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_SchemeIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_MedicationIDTitleControlIdToReplace ,
                                       String AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace ,
                                       String AV35ddo_BR_Medication_RXNameTitleControlIdToReplace ,
                                       String AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace ,
                                       String AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace ,
                                       String AV76Pgmname ,
                                       bool AV56IsAuthorized_BR_Scheme_MedicationID ,
                                       bool AV54IsAuthorized_BR_Scheme_Chem_Regimens )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF6J2( ) ;
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
         RF6J2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV76Pgmname = "BR_Scheme_MedicationWW";
         context.Gx_err = 0;
      }

      protected void RF6J2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E226J2 ();
         nGXsfl_31_idx = 1;
         sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
         SubsflControlProps_312( ) ;
         bGXsfl_31_Refreshing = true;
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
            SubsflControlProps_312( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ,
                                                 AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ,
                                                 AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ,
                                                 AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ,
                                                 AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ,
                                                 AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ,
                                                 AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ,
                                                 AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ,
                                                 AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ,
                                                 AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ,
                                                 AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ,
                                                 AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ,
                                                 AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ,
                                                 AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ,
                                                 A332BR_Scheme_MedicationID ,
                                                 A327BR_SchemeID ,
                                                 A119BR_MedicationID ,
                                                 A328BR_Scheme_Chem_Regimens ,
                                                 A121BR_Medication_RXName ,
                                                 A124BR_Medication_RXDose ,
                                                 A125BR_Medication_RXUnit ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = StringUtil.Concat( StringUtil.RTrim( AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens), "%", "");
            lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname), "%", "");
            lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = StringUtil.Concat( StringUtil.RTrim( AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit), "%", "");
            /* Using cursor H006J2 */
            pr_default.execute(0, new Object[] {AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid, AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to, AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid, AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to, AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid, AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to, lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens, AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel, lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname, AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel, AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose, AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to, lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit, AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A125BR_Medication_RXUnit = H006J2_A125BR_Medication_RXUnit[0];
               n125BR_Medication_RXUnit = H006J2_n125BR_Medication_RXUnit[0];
               A124BR_Medication_RXDose = H006J2_A124BR_Medication_RXDose[0];
               n124BR_Medication_RXDose = H006J2_n124BR_Medication_RXDose[0];
               A121BR_Medication_RXName = H006J2_A121BR_Medication_RXName[0];
               n121BR_Medication_RXName = H006J2_n121BR_Medication_RXName[0];
               A328BR_Scheme_Chem_Regimens = H006J2_A328BR_Scheme_Chem_Regimens[0];
               n328BR_Scheme_Chem_Regimens = H006J2_n328BR_Scheme_Chem_Regimens[0];
               A119BR_MedicationID = H006J2_A119BR_MedicationID[0];
               n119BR_MedicationID = H006J2_n119BR_MedicationID[0];
               A327BR_SchemeID = H006J2_A327BR_SchemeID[0];
               n327BR_SchemeID = H006J2_n327BR_SchemeID[0];
               A332BR_Scheme_MedicationID = H006J2_A332BR_Scheme_MedicationID[0];
               A125BR_Medication_RXUnit = H006J2_A125BR_Medication_RXUnit[0];
               n125BR_Medication_RXUnit = H006J2_n125BR_Medication_RXUnit[0];
               A124BR_Medication_RXDose = H006J2_A124BR_Medication_RXDose[0];
               n124BR_Medication_RXDose = H006J2_n124BR_Medication_RXDose[0];
               A121BR_Medication_RXName = H006J2_A121BR_Medication_RXName[0];
               n121BR_Medication_RXName = H006J2_n121BR_Medication_RXName[0];
               A328BR_Scheme_Chem_Regimens = H006J2_A328BR_Scheme_Chem_Regimens[0];
               n328BR_Scheme_Chem_Regimens = H006J2_n328BR_Scheme_Chem_Regimens[0];
               E236J2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB6J0( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes6J2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_SCHEME_MEDICATIONID", AV56IsAuthorized_BR_Scheme_MedicationID);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_SCHEME_MEDICATIONID", GetSecureSignedToken( "", AV56IsAuthorized_BR_Scheme_MedicationID, context));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS", AV54IsAuthorized_BR_Scheme_Chem_Regimens);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS", GetSecureSignedToken( "", AV54IsAuthorized_BR_Scheme_Chem_Regimens, context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_SCHEME_MEDICATIONID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid = AV17TFBR_Scheme_MedicationID;
         AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to = AV18TFBR_Scheme_MedicationID_To;
         AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid = AV21TFBR_SchemeID;
         AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to = AV22TFBR_SchemeID_To;
         AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid = AV25TFBR_MedicationID;
         AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to = AV26TFBR_MedicationID_To;
         AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = AV29TFBR_Scheme_Chem_Regimens;
         AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = AV30TFBR_Scheme_Chem_Regimens_Sel;
         AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = AV33TFBR_Medication_RXName;
         AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = AV34TFBR_Medication_RXName_Sel;
         AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose = AV37TFBR_Medication_RXDose;
         AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to = AV38TFBR_Medication_RXDose_To;
         AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = AV41TFBR_Medication_RXUnit;
         AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = AV42TFBR_Medication_RXUnit_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ,
                                              AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ,
                                              AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ,
                                              AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ,
                                              AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ,
                                              AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ,
                                              AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ,
                                              AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ,
                                              AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ,
                                              AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ,
                                              AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ,
                                              AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ,
                                              AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ,
                                              AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ,
                                              A332BR_Scheme_MedicationID ,
                                              A327BR_SchemeID ,
                                              A119BR_MedicationID ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A121BR_Medication_RXName ,
                                              A124BR_Medication_RXDose ,
                                              A125BR_Medication_RXUnit ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = StringUtil.Concat( StringUtil.RTrim( AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens), "%", "");
         lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname), "%", "");
         lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = StringUtil.Concat( StringUtil.RTrim( AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit), "%", "");
         /* Using cursor H006J3 */
         pr_default.execute(1, new Object[] {AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid, AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to, AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid, AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to, AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid, AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to, lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens, AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel, lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname, AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel, AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose, AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to, lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit, AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel});
         GRID_nRecordCount = H006J3_AGRID_nRecordCount[0];
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
         AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid = AV17TFBR_Scheme_MedicationID;
         AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to = AV18TFBR_Scheme_MedicationID_To;
         AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid = AV21TFBR_SchemeID;
         AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to = AV22TFBR_SchemeID_To;
         AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid = AV25TFBR_MedicationID;
         AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to = AV26TFBR_MedicationID_To;
         AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = AV29TFBR_Scheme_Chem_Regimens;
         AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = AV30TFBR_Scheme_Chem_Regimens_Sel;
         AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = AV33TFBR_Medication_RXName;
         AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = AV34TFBR_Medication_RXName_Sel;
         AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose = AV37TFBR_Medication_RXDose;
         AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to = AV38TFBR_Medication_RXDose_To;
         AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = AV41TFBR_Medication_RXUnit;
         AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = AV42TFBR_Medication_RXUnit_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Scheme_MedicationID, AV18TFBR_Scheme_MedicationID_To, AV21TFBR_SchemeID, AV22TFBR_SchemeID_To, AV25TFBR_MedicationID, AV26TFBR_MedicationID_To, AV29TFBR_Scheme_Chem_Regimens, AV30TFBR_Scheme_Chem_Regimens_Sel, AV33TFBR_Medication_RXName, AV34TFBR_Medication_RXName_Sel, AV37TFBR_Medication_RXDose, AV38TFBR_Medication_RXDose_To, AV41TFBR_Medication_RXUnit, AV42TFBR_Medication_RXUnit_Sel, AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV23ddo_BR_SchemeIDTitleControlIdToReplace, AV27ddo_BR_MedicationIDTitleControlIdToReplace, AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV35ddo_BR_Medication_RXNameTitleControlIdToReplace, AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV76Pgmname, AV56IsAuthorized_BR_Scheme_MedicationID, AV54IsAuthorized_BR_Scheme_Chem_Regimens) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid = AV17TFBR_Scheme_MedicationID;
         AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to = AV18TFBR_Scheme_MedicationID_To;
         AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid = AV21TFBR_SchemeID;
         AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to = AV22TFBR_SchemeID_To;
         AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid = AV25TFBR_MedicationID;
         AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to = AV26TFBR_MedicationID_To;
         AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = AV29TFBR_Scheme_Chem_Regimens;
         AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = AV30TFBR_Scheme_Chem_Regimens_Sel;
         AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = AV33TFBR_Medication_RXName;
         AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = AV34TFBR_Medication_RXName_Sel;
         AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose = AV37TFBR_Medication_RXDose;
         AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to = AV38TFBR_Medication_RXDose_To;
         AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = AV41TFBR_Medication_RXUnit;
         AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = AV42TFBR_Medication_RXUnit_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Scheme_MedicationID, AV18TFBR_Scheme_MedicationID_To, AV21TFBR_SchemeID, AV22TFBR_SchemeID_To, AV25TFBR_MedicationID, AV26TFBR_MedicationID_To, AV29TFBR_Scheme_Chem_Regimens, AV30TFBR_Scheme_Chem_Regimens_Sel, AV33TFBR_Medication_RXName, AV34TFBR_Medication_RXName_Sel, AV37TFBR_Medication_RXDose, AV38TFBR_Medication_RXDose_To, AV41TFBR_Medication_RXUnit, AV42TFBR_Medication_RXUnit_Sel, AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV23ddo_BR_SchemeIDTitleControlIdToReplace, AV27ddo_BR_MedicationIDTitleControlIdToReplace, AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV35ddo_BR_Medication_RXNameTitleControlIdToReplace, AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV76Pgmname, AV56IsAuthorized_BR_Scheme_MedicationID, AV54IsAuthorized_BR_Scheme_Chem_Regimens) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid = AV17TFBR_Scheme_MedicationID;
         AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to = AV18TFBR_Scheme_MedicationID_To;
         AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid = AV21TFBR_SchemeID;
         AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to = AV22TFBR_SchemeID_To;
         AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid = AV25TFBR_MedicationID;
         AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to = AV26TFBR_MedicationID_To;
         AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = AV29TFBR_Scheme_Chem_Regimens;
         AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = AV30TFBR_Scheme_Chem_Regimens_Sel;
         AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = AV33TFBR_Medication_RXName;
         AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = AV34TFBR_Medication_RXName_Sel;
         AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose = AV37TFBR_Medication_RXDose;
         AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to = AV38TFBR_Medication_RXDose_To;
         AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = AV41TFBR_Medication_RXUnit;
         AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = AV42TFBR_Medication_RXUnit_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Scheme_MedicationID, AV18TFBR_Scheme_MedicationID_To, AV21TFBR_SchemeID, AV22TFBR_SchemeID_To, AV25TFBR_MedicationID, AV26TFBR_MedicationID_To, AV29TFBR_Scheme_Chem_Regimens, AV30TFBR_Scheme_Chem_Regimens_Sel, AV33TFBR_Medication_RXName, AV34TFBR_Medication_RXName_Sel, AV37TFBR_Medication_RXDose, AV38TFBR_Medication_RXDose_To, AV41TFBR_Medication_RXUnit, AV42TFBR_Medication_RXUnit_Sel, AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV23ddo_BR_SchemeIDTitleControlIdToReplace, AV27ddo_BR_MedicationIDTitleControlIdToReplace, AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV35ddo_BR_Medication_RXNameTitleControlIdToReplace, AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV76Pgmname, AV56IsAuthorized_BR_Scheme_MedicationID, AV54IsAuthorized_BR_Scheme_Chem_Regimens) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid = AV17TFBR_Scheme_MedicationID;
         AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to = AV18TFBR_Scheme_MedicationID_To;
         AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid = AV21TFBR_SchemeID;
         AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to = AV22TFBR_SchemeID_To;
         AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid = AV25TFBR_MedicationID;
         AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to = AV26TFBR_MedicationID_To;
         AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = AV29TFBR_Scheme_Chem_Regimens;
         AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = AV30TFBR_Scheme_Chem_Regimens_Sel;
         AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = AV33TFBR_Medication_RXName;
         AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = AV34TFBR_Medication_RXName_Sel;
         AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose = AV37TFBR_Medication_RXDose;
         AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to = AV38TFBR_Medication_RXDose_To;
         AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = AV41TFBR_Medication_RXUnit;
         AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = AV42TFBR_Medication_RXUnit_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Scheme_MedicationID, AV18TFBR_Scheme_MedicationID_To, AV21TFBR_SchemeID, AV22TFBR_SchemeID_To, AV25TFBR_MedicationID, AV26TFBR_MedicationID_To, AV29TFBR_Scheme_Chem_Regimens, AV30TFBR_Scheme_Chem_Regimens_Sel, AV33TFBR_Medication_RXName, AV34TFBR_Medication_RXName_Sel, AV37TFBR_Medication_RXDose, AV38TFBR_Medication_RXDose_To, AV41TFBR_Medication_RXUnit, AV42TFBR_Medication_RXUnit_Sel, AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV23ddo_BR_SchemeIDTitleControlIdToReplace, AV27ddo_BR_MedicationIDTitleControlIdToReplace, AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV35ddo_BR_Medication_RXNameTitleControlIdToReplace, AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV76Pgmname, AV56IsAuthorized_BR_Scheme_MedicationID, AV54IsAuthorized_BR_Scheme_Chem_Regimens) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid = AV17TFBR_Scheme_MedicationID;
         AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to = AV18TFBR_Scheme_MedicationID_To;
         AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid = AV21TFBR_SchemeID;
         AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to = AV22TFBR_SchemeID_To;
         AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid = AV25TFBR_MedicationID;
         AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to = AV26TFBR_MedicationID_To;
         AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = AV29TFBR_Scheme_Chem_Regimens;
         AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = AV30TFBR_Scheme_Chem_Regimens_Sel;
         AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = AV33TFBR_Medication_RXName;
         AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = AV34TFBR_Medication_RXName_Sel;
         AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose = AV37TFBR_Medication_RXDose;
         AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to = AV38TFBR_Medication_RXDose_To;
         AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = AV41TFBR_Medication_RXUnit;
         AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = AV42TFBR_Medication_RXUnit_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Scheme_MedicationID, AV18TFBR_Scheme_MedicationID_To, AV21TFBR_SchemeID, AV22TFBR_SchemeID_To, AV25TFBR_MedicationID, AV26TFBR_MedicationID_To, AV29TFBR_Scheme_Chem_Regimens, AV30TFBR_Scheme_Chem_Regimens_Sel, AV33TFBR_Medication_RXName, AV34TFBR_Medication_RXName_Sel, AV37TFBR_Medication_RXDose, AV38TFBR_Medication_RXDose_To, AV41TFBR_Medication_RXUnit, AV42TFBR_Medication_RXUnit_Sel, AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV23ddo_BR_SchemeIDTitleControlIdToReplace, AV27ddo_BR_MedicationIDTitleControlIdToReplace, AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV35ddo_BR_Medication_RXNameTitleControlIdToReplace, AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV76Pgmname, AV56IsAuthorized_BR_Scheme_MedicationID, AV54IsAuthorized_BR_Scheme_Chem_Regimens) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP6J0( )
      {
         /* Before Start, stand alone formulas. */
         AV76Pgmname = "BR_Scheme_MedicationWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E216J2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV44DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA"), AV16BR_Scheme_MedicationIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEMEIDTITLEFILTERDATA"), AV20BR_SchemeIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATIONIDTITLEFILTERDATA"), AV24BR_MedicationIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA"), AV28BR_Scheme_Chem_RegimensTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXNAMETITLEFILTERDATA"), AV32BR_Medication_RXNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXDOSETITLEFILTERDATA"), AV36BR_Medication_RXDoseTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXUNITTITLEFILTERDATA"), AV40BR_Medication_RXUnitTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace", AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace);
            AV23ddo_BR_SchemeIDTitleControlIdToReplace = cgiGet( edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_SchemeIDTitleControlIdToReplace", AV23ddo_BR_SchemeIDTitleControlIdToReplace);
            AV27ddo_BR_MedicationIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_MedicationIDTitleControlIdToReplace", AV27ddo_BR_MedicationIDTitleControlIdToReplace);
            AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace", AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace);
            AV35ddo_BR_Medication_RXNameTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Medication_RXNameTitleControlIdToReplace", AV35ddo_BR_Medication_RXNameTitleControlIdToReplace);
            AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace", AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace);
            AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace", AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_scheme_medicationid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_scheme_medicationid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_SCHEME_MEDICATIONID");
               GX_FocusControl = edtavTfbr_scheme_medicationid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_Scheme_MedicationID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Scheme_MedicationID), 18, 0)));
            }
            else
            {
               AV17TFBR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_scheme_medicationid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Scheme_MedicationID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_scheme_medicationid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_scheme_medicationid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_SCHEME_MEDICATIONID_TO");
               GX_FocusControl = edtavTfbr_scheme_medicationid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_Scheme_MedicationID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Scheme_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Scheme_MedicationID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_Scheme_MedicationID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_scheme_medicationid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Scheme_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Scheme_MedicationID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_SCHEMEID");
               GX_FocusControl = edtavTfbr_schemeid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_SchemeID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_SchemeID), 18, 0)));
            }
            else
            {
               AV21TFBR_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_SchemeID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_SCHEMEID_TO");
               GX_FocusControl = edtavTfbr_schemeid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_SchemeID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_SchemeID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_SchemeID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_SchemeID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATIONID");
               GX_FocusControl = edtavTfbr_medicationid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25TFBR_MedicationID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TFBR_MedicationID), 18, 0)));
            }
            else
            {
               AV25TFBR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TFBR_MedicationID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATIONID_TO");
               GX_FocusControl = edtavTfbr_medicationid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV26TFBR_MedicationID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26TFBR_MedicationID_To), 18, 0)));
            }
            else
            {
               AV26TFBR_MedicationID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26TFBR_MedicationID_To), 18, 0)));
            }
            AV29TFBR_Scheme_Chem_Regimens = cgiGet( edtavTfbr_scheme_chem_regimens_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Scheme_Chem_Regimens", AV29TFBR_Scheme_Chem_Regimens);
            AV30TFBR_Scheme_Chem_Regimens_Sel = cgiGet( edtavTfbr_scheme_chem_regimens_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Scheme_Chem_Regimens_Sel", AV30TFBR_Scheme_Chem_Regimens_Sel);
            AV33TFBR_Medication_RXName = cgiGet( edtavTfbr_medication_rxname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Medication_RXName", AV33TFBR_Medication_RXName);
            AV34TFBR_Medication_RXName_Sel = cgiGet( edtavTfbr_medication_rxname_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Medication_RXName_Sel", AV34TFBR_Medication_RXName_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_RXDOSE");
               GX_FocusControl = edtavTfbr_medication_rxdose_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV37TFBR_Medication_RXDose = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV37TFBR_Medication_RXDose, 15, 5)));
            }
            else
            {
               AV37TFBR_Medication_RXDose = context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV37TFBR_Medication_RXDose, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_RXDOSE_TO");
               GX_FocusControl = edtavTfbr_medication_rxdose_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV38TFBR_Medication_RXDose_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Medication_RXDose_To", StringUtil.LTrim( StringUtil.Str( AV38TFBR_Medication_RXDose_To, 15, 5)));
            }
            else
            {
               AV38TFBR_Medication_RXDose_To = context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdose_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Medication_RXDose_To", StringUtil.LTrim( StringUtil.Str( AV38TFBR_Medication_RXDose_To, 15, 5)));
            }
            AV41TFBR_Medication_RXUnit = cgiGet( edtavTfbr_medication_rxunit_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFBR_Medication_RXUnit", AV41TFBR_Medication_RXUnit);
            AV42TFBR_Medication_RXUnit_Sel = cgiGet( edtavTfbr_medication_rxunit_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFBR_Medication_RXUnit_Sel", AV42TFBR_Medication_RXUnit_Sel);
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV46GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV48GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV47GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_tableheader_Width = cgiGet( "DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Cls = cgiGet( "DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( "DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( "DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoscroll"));
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
            Ddo_br_scheme_medicationid_Filteredtext_set = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Filteredtext_set");
            Ddo_br_scheme_medicationid_Filteredtextto_set = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Filteredtextto_set");
            Ddo_br_scheme_medicationid_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Dropdownoptionstype");
            Ddo_br_scheme_medicationid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Titlecontrolidtoreplace");
            Ddo_br_scheme_medicationid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Includesortasc"));
            Ddo_br_scheme_medicationid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Includesortdsc"));
            Ddo_br_scheme_medicationid_Sortedstatus = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Sortedstatus");
            Ddo_br_scheme_medicationid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Includefilter"));
            Ddo_br_scheme_medicationid_Filtertype = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Filtertype");
            Ddo_br_scheme_medicationid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Filterisrange"));
            Ddo_br_scheme_medicationid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Includedatalist"));
            Ddo_br_scheme_medicationid_Sortasc = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Sortasc");
            Ddo_br_scheme_medicationid_Sortdsc = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Sortdsc");
            Ddo_br_scheme_medicationid_Cleanfilter = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Cleanfilter");
            Ddo_br_scheme_medicationid_Rangefilterfrom = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Rangefilterfrom");
            Ddo_br_scheme_medicationid_Rangefilterto = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Rangefilterto");
            Ddo_br_scheme_medicationid_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Searchbuttontext");
            Ddo_br_schemeid_Caption = cgiGet( "DDO_BR_SCHEMEID_Caption");
            Ddo_br_schemeid_Tooltip = cgiGet( "DDO_BR_SCHEMEID_Tooltip");
            Ddo_br_schemeid_Cls = cgiGet( "DDO_BR_SCHEMEID_Cls");
            Ddo_br_schemeid_Filteredtext_set = cgiGet( "DDO_BR_SCHEMEID_Filteredtext_set");
            Ddo_br_schemeid_Filteredtextto_set = cgiGet( "DDO_BR_SCHEMEID_Filteredtextto_set");
            Ddo_br_schemeid_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEMEID_Dropdownoptionstype");
            Ddo_br_schemeid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEMEID_Titlecontrolidtoreplace");
            Ddo_br_schemeid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includesortasc"));
            Ddo_br_schemeid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includesortdsc"));
            Ddo_br_schemeid_Sortedstatus = cgiGet( "DDO_BR_SCHEMEID_Sortedstatus");
            Ddo_br_schemeid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includefilter"));
            Ddo_br_schemeid_Filtertype = cgiGet( "DDO_BR_SCHEMEID_Filtertype");
            Ddo_br_schemeid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Filterisrange"));
            Ddo_br_schemeid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includedatalist"));
            Ddo_br_schemeid_Sortasc = cgiGet( "DDO_BR_SCHEMEID_Sortasc");
            Ddo_br_schemeid_Sortdsc = cgiGet( "DDO_BR_SCHEMEID_Sortdsc");
            Ddo_br_schemeid_Cleanfilter = cgiGet( "DDO_BR_SCHEMEID_Cleanfilter");
            Ddo_br_schemeid_Rangefilterfrom = cgiGet( "DDO_BR_SCHEMEID_Rangefilterfrom");
            Ddo_br_schemeid_Rangefilterto = cgiGet( "DDO_BR_SCHEMEID_Rangefilterto");
            Ddo_br_schemeid_Searchbuttontext = cgiGet( "DDO_BR_SCHEMEID_Searchbuttontext");
            Ddo_br_medicationid_Caption = cgiGet( "DDO_BR_MEDICATIONID_Caption");
            Ddo_br_medicationid_Tooltip = cgiGet( "DDO_BR_MEDICATIONID_Tooltip");
            Ddo_br_medicationid_Cls = cgiGet( "DDO_BR_MEDICATIONID_Cls");
            Ddo_br_medicationid_Filteredtext_set = cgiGet( "DDO_BR_MEDICATIONID_Filteredtext_set");
            Ddo_br_medicationid_Filteredtextto_set = cgiGet( "DDO_BR_MEDICATIONID_Filteredtextto_set");
            Ddo_br_medicationid_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATIONID_Dropdownoptionstype");
            Ddo_br_medicationid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATIONID_Titlecontrolidtoreplace");
            Ddo_br_medicationid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATIONID_Includesortasc"));
            Ddo_br_medicationid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATIONID_Includesortdsc"));
            Ddo_br_medicationid_Sortedstatus = cgiGet( "DDO_BR_MEDICATIONID_Sortedstatus");
            Ddo_br_medicationid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATIONID_Includefilter"));
            Ddo_br_medicationid_Filtertype = cgiGet( "DDO_BR_MEDICATIONID_Filtertype");
            Ddo_br_medicationid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATIONID_Filterisrange"));
            Ddo_br_medicationid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATIONID_Includedatalist"));
            Ddo_br_medicationid_Sortasc = cgiGet( "DDO_BR_MEDICATIONID_Sortasc");
            Ddo_br_medicationid_Sortdsc = cgiGet( "DDO_BR_MEDICATIONID_Sortdsc");
            Ddo_br_medicationid_Cleanfilter = cgiGet( "DDO_BR_MEDICATIONID_Cleanfilter");
            Ddo_br_medicationid_Rangefilterfrom = cgiGet( "DDO_BR_MEDICATIONID_Rangefilterfrom");
            Ddo_br_medicationid_Rangefilterto = cgiGet( "DDO_BR_MEDICATIONID_Rangefilterto");
            Ddo_br_medicationid_Searchbuttontext = cgiGet( "DDO_BR_MEDICATIONID_Searchbuttontext");
            Ddo_br_scheme_chem_regimens_Caption = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Caption");
            Ddo_br_scheme_chem_regimens_Tooltip = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Tooltip");
            Ddo_br_scheme_chem_regimens_Cls = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Cls");
            Ddo_br_scheme_chem_regimens_Filteredtext_set = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_set");
            Ddo_br_scheme_chem_regimens_Selectedvalue_set = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_set");
            Ddo_br_scheme_chem_regimens_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Dropdownoptionstype");
            Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Titlecontrolidtoreplace");
            Ddo_br_scheme_chem_regimens_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortasc"));
            Ddo_br_scheme_chem_regimens_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortdsc"));
            Ddo_br_scheme_chem_regimens_Sortedstatus = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortedstatus");
            Ddo_br_scheme_chem_regimens_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includefilter"));
            Ddo_br_scheme_chem_regimens_Filtertype = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Filtertype");
            Ddo_br_scheme_chem_regimens_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Filterisrange"));
            Ddo_br_scheme_chem_regimens_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includedatalist"));
            Ddo_br_scheme_chem_regimens_Datalisttype = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Datalisttype");
            Ddo_br_scheme_chem_regimens_Datalistproc = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Datalistproc");
            Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_scheme_chem_regimens_Sortasc = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortasc");
            Ddo_br_scheme_chem_regimens_Sortdsc = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortdsc");
            Ddo_br_scheme_chem_regimens_Loadingdata = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Loadingdata");
            Ddo_br_scheme_chem_regimens_Cleanfilter = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Cleanfilter");
            Ddo_br_scheme_chem_regimens_Noresultsfound = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Noresultsfound");
            Ddo_br_scheme_chem_regimens_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Searchbuttontext");
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
            Ddo_br_medication_rxdose_Caption = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Caption");
            Ddo_br_medication_rxdose_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Tooltip");
            Ddo_br_medication_rxdose_Cls = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Cls");
            Ddo_br_medication_rxdose_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Filteredtext_set");
            Ddo_br_medication_rxdose_Filteredtextto_set = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Filteredtextto_set");
            Ddo_br_medication_rxdose_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Dropdownoptionstype");
            Ddo_br_medication_rxdose_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Titlecontrolidtoreplace");
            Ddo_br_medication_rxdose_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDOSE_Includesortasc"));
            Ddo_br_medication_rxdose_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDOSE_Includesortdsc"));
            Ddo_br_medication_rxdose_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Sortedstatus");
            Ddo_br_medication_rxdose_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDOSE_Includefilter"));
            Ddo_br_medication_rxdose_Filtertype = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Filtertype");
            Ddo_br_medication_rxdose_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDOSE_Filterisrange"));
            Ddo_br_medication_rxdose_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDOSE_Includedatalist"));
            Ddo_br_medication_rxdose_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Sortasc");
            Ddo_br_medication_rxdose_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Sortdsc");
            Ddo_br_medication_rxdose_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Cleanfilter");
            Ddo_br_medication_rxdose_Rangefilterfrom = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Rangefilterfrom");
            Ddo_br_medication_rxdose_Rangefilterto = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Rangefilterto");
            Ddo_br_medication_rxdose_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Searchbuttontext");
            Ddo_br_medication_rxunit_Caption = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Caption");
            Ddo_br_medication_rxunit_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Tooltip");
            Ddo_br_medication_rxunit_Cls = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Cls");
            Ddo_br_medication_rxunit_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Filteredtext_set");
            Ddo_br_medication_rxunit_Selectedvalue_set = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Selectedvalue_set");
            Ddo_br_medication_rxunit_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Dropdownoptionstype");
            Ddo_br_medication_rxunit_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Titlecontrolidtoreplace");
            Ddo_br_medication_rxunit_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Includesortasc"));
            Ddo_br_medication_rxunit_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Includesortdsc"));
            Ddo_br_medication_rxunit_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Sortedstatus");
            Ddo_br_medication_rxunit_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Includefilter"));
            Ddo_br_medication_rxunit_Filtertype = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Filtertype");
            Ddo_br_medication_rxunit_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Filterisrange"));
            Ddo_br_medication_rxunit_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Includedatalist"));
            Ddo_br_medication_rxunit_Datalisttype = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Datalisttype");
            Ddo_br_medication_rxunit_Datalistproc = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Datalistproc");
            Ddo_br_medication_rxunit_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_rxunit_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Sortasc");
            Ddo_br_medication_rxunit_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Sortdsc");
            Ddo_br_medication_rxunit_Loadingdata = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Loadingdata");
            Ddo_br_medication_rxunit_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Cleanfilter");
            Ddo_br_medication_rxunit_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Noresultsfound");
            Ddo_br_medication_rxunit_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_scheme_medicationid_Activeeventkey = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Activeeventkey");
            Ddo_br_scheme_medicationid_Filteredtext_get = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Filteredtext_get");
            Ddo_br_scheme_medicationid_Filteredtextto_get = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Filteredtextto_get");
            Ddo_br_schemeid_Activeeventkey = cgiGet( "DDO_BR_SCHEMEID_Activeeventkey");
            Ddo_br_schemeid_Filteredtext_get = cgiGet( "DDO_BR_SCHEMEID_Filteredtext_get");
            Ddo_br_schemeid_Filteredtextto_get = cgiGet( "DDO_BR_SCHEMEID_Filteredtextto_get");
            Ddo_br_medicationid_Activeeventkey = cgiGet( "DDO_BR_MEDICATIONID_Activeeventkey");
            Ddo_br_medicationid_Filteredtext_get = cgiGet( "DDO_BR_MEDICATIONID_Filteredtext_get");
            Ddo_br_medicationid_Filteredtextto_get = cgiGet( "DDO_BR_MEDICATIONID_Filteredtextto_get");
            Ddo_br_scheme_chem_regimens_Activeeventkey = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey");
            Ddo_br_scheme_chem_regimens_Filteredtext_get = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_get");
            Ddo_br_scheme_chem_regimens_Selectedvalue_get = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_get");
            Ddo_br_medication_rxname_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXNAME_Activeeventkey");
            Ddo_br_medication_rxname_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_RXNAME_Filteredtext_get");
            Ddo_br_medication_rxname_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_RXNAME_Selectedvalue_get");
            Ddo_br_medication_rxdose_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Activeeventkey");
            Ddo_br_medication_rxdose_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Filteredtext_get");
            Ddo_br_medication_rxdose_Filteredtextto_get = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Filteredtextto_get");
            Ddo_br_medication_rxunit_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Activeeventkey");
            Ddo_br_medication_rxunit_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Filteredtext_get");
            Ddo_br_medication_rxunit_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEME_MEDICATIONID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Scheme_MedicationID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEME_MEDICATIONID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Scheme_MedicationID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEMEID"), ".", ",") != Convert.ToDecimal( AV21TFBR_SchemeID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEMEID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_SchemeID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATIONID"), ".", ",") != Convert.ToDecimal( AV25TFBR_MedicationID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATIONID_TO"), ".", ",") != Convert.ToDecimal( AV26TFBR_MedicationID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_REGIMENS"), AV29TFBR_Scheme_Chem_Regimens) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_REGIMENS_SEL"), AV30TFBR_Scheme_Chem_Regimens_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXNAME"), AV33TFBR_Medication_RXName) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXNAME_SEL"), AV34TFBR_Medication_RXName_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_RXDOSE"), ".", ",") != AV37TFBR_Medication_RXDose )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_RXDOSE_TO"), ".", ",") != AV38TFBR_Medication_RXDose_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXUNIT"), AV41TFBR_Medication_RXUnit) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXUNIT_SEL"), AV42TFBR_Medication_RXUnit_Sel) != 0 )
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
         E216J2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E216J2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_boolean1 = AV56IsAuthorized_BR_Scheme_MedicationID;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Scheme_Medication", out  GXt_boolean1) ;
         AV56IsAuthorized_BR_Scheme_MedicationID = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56IsAuthorized_BR_Scheme_MedicationID", AV56IsAuthorized_BR_Scheme_MedicationID);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_BR_SCHEME_MEDICATIONID", GetSecureSignedToken( "", AV56IsAuthorized_BR_Scheme_MedicationID, context));
         GXt_boolean1 = AV54IsAuthorized_BR_Scheme_Chem_Regimens;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Scheme", out  GXt_boolean1) ;
         AV54IsAuthorized_BR_Scheme_Chem_Regimens = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54IsAuthorized_BR_Scheme_Chem_Regimens", AV54IsAuthorized_BR_Scheme_Chem_Regimens);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS", GetSecureSignedToken( "", AV54IsAuthorized_BR_Scheme_Chem_Regimens, context));
         edtavTfbr_scheme_medicationid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_medicationid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_medicationid_Visible), 5, 0)), true);
         edtavTfbr_scheme_medicationid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_medicationid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_medicationid_to_Visible), 5, 0)), true);
         edtavTfbr_schemeid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_schemeid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_schemeid_Visible), 5, 0)), true);
         edtavTfbr_schemeid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_schemeid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_schemeid_to_Visible), 5, 0)), true);
         edtavTfbr_medicationid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicationid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicationid_Visible), 5, 0)), true);
         edtavTfbr_medicationid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicationid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicationid_to_Visible), 5, 0)), true);
         edtavTfbr_scheme_chem_regimens_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_chem_regimens_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_chem_regimens_Visible), 5, 0)), true);
         edtavTfbr_scheme_chem_regimens_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_chem_regimens_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_chem_regimens_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_rxname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxname_Visible), 5, 0)), true);
         edtavTfbr_medication_rxname_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxname_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxname_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_rxdose_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxdose_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxdose_Visible), 5, 0)), true);
         edtavTfbr_medication_rxdose_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxdose_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxdose_to_Visible), 5, 0)), true);
         edtavTfbr_medication_rxunit_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxunit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxunit_Visible), 5, 0)), true);
         edtavTfbr_medication_rxunit_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxunit_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxunit_sel_Visible), 5, 0)), true);
         Ddo_br_scheme_medicationid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_MedicationID";
         ucDdo_br_scheme_medicationid.SendProperty(context, "", false, Ddo_br_scheme_medicationid_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_medicationid_Titlecontrolidtoreplace);
         AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = Ddo_br_scheme_medicationid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace", AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace);
         edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_schemeid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_SchemeID";
         ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "TitleControlIdToReplace", Ddo_br_schemeid_Titlecontrolidtoreplace);
         AV23ddo_BR_SchemeIDTitleControlIdToReplace = Ddo_br_schemeid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_SchemeIDTitleControlIdToReplace", AV23ddo_BR_SchemeIDTitleControlIdToReplace);
         edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicationid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicationID";
         ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "TitleControlIdToReplace", Ddo_br_medicationid_Titlecontrolidtoreplace);
         AV27ddo_BR_MedicationIDTitleControlIdToReplace = Ddo_br_medicationid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_MedicationIDTitleControlIdToReplace", AV27ddo_BR_MedicationIDTitleControlIdToReplace);
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Chem_Regimens";
         ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace);
         AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace", AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace);
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxname_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXName";
         ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxname_Titlecontrolidtoreplace);
         AV35ddo_BR_Medication_RXNameTitleControlIdToReplace = Ddo_br_medication_rxname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Medication_RXNameTitleControlIdToReplace", AV35ddo_BR_Medication_RXNameTitleControlIdToReplace);
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxdose_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXDose";
         ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxdose_Titlecontrolidtoreplace);
         AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace = Ddo_br_medication_rxdose_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace", AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace);
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxunit_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXUnit";
         ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxunit_Titlecontrolidtoreplace);
         AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace = Ddo_br_medication_rxunit_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace", AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace);
         edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 化疗方案药物详情";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV44DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV44DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E226J2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_Scheme_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Scheme_Chem_RegimensTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Medication_RXDoseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Medication_RXUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtBR_Scheme_MedicationID_Titleformat = 2;
         edtBR_Scheme_MedicationID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案药物详情主键", AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_MedicationID_Internalname, "Title", edtBR_Scheme_MedicationID_Title, !bGXsfl_31_Refreshing);
         edtBR_SchemeID_Titleformat = 2;
         edtBR_SchemeID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案主键", AV23ddo_BR_SchemeIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Title", edtBR_SchemeID_Title, !bGXsfl_31_Refreshing);
         edtBR_MedicationID_Titleformat = 2;
         edtBR_MedicationID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物治疗主键", AV27ddo_BR_MedicationIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Title", edtBR_MedicationID_Title, !bGXsfl_31_Refreshing);
         edtBR_Scheme_Chem_Regimens_Titleformat = 2;
         edtBR_Scheme_Chem_Regimens_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案", AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Regimens_Internalname, "Title", edtBR_Scheme_Chem_Regimens_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_RXName_Titleformat = 2;
         edtBR_Medication_RXName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物名称", AV35ddo_BR_Medication_RXNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXName_Internalname, "Title", edtBR_Medication_RXName_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_RXDose_Titleformat = 2;
         edtBR_Medication_RXDose_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物剂量", AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXDose_Internalname, "Title", edtBR_Medication_RXDose_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_RXUnit_Titleformat = 2;
         edtBR_Medication_RXUnit_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "计量单位", AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXUnit_Internalname, "Title", edtBR_Medication_RXUnit_Title, !bGXsfl_31_Refreshing);
         AV46GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46GridCurrentPage), 10, 0)));
         AV47GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV47GridPageSize), 10, 0)));
         AV48GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV48GridRecordCount), 10, 0)));
         AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid = AV17TFBR_Scheme_MedicationID;
         AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to = AV18TFBR_Scheme_MedicationID_To;
         AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid = AV21TFBR_SchemeID;
         AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to = AV22TFBR_SchemeID_To;
         AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid = AV25TFBR_MedicationID;
         AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to = AV26TFBR_MedicationID_To;
         AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = AV29TFBR_Scheme_Chem_Regimens;
         AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = AV30TFBR_Scheme_Chem_Regimens_Sel;
         AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = AV33TFBR_Medication_RXName;
         AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = AV34TFBR_Medication_RXName_Sel;
         AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose = AV37TFBR_Medication_RXDose;
         AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to = AV38TFBR_Medication_RXDose_To;
         AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = AV41TFBR_Medication_RXUnit;
         AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = AV42TFBR_Medication_RXUnit_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Scheme_MedicationIDTitleFilterData", AV16BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_SchemeIDTitleFilterData", AV20BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicationIDTitleFilterData", AV24BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Chem_RegimensTitleFilterData", AV28BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXNameTitleFilterData", AV32BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_RXDoseTitleFilterData", AV36BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_RXUnitTitleFilterData", AV40BR_Medication_RXUnitTitleFilterData);
      }

      protected void E116J2( )
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
            AV45PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV45PageToGo) ;
         }
      }

      protected void E126J2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E136J2( )
      {
         /* Ddo_br_scheme_medicationid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_medicationid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_scheme_medicationid_Sortedstatus = "ASC";
            ucDdo_br_scheme_medicationid.SendProperty(context, "", false, Ddo_br_scheme_medicationid_Internalname, "SortedStatus", Ddo_br_scheme_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_medicationid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_scheme_medicationid_Sortedstatus = "DSC";
            ucDdo_br_scheme_medicationid.SendProperty(context, "", false, Ddo_br_scheme_medicationid_Internalname, "SortedStatus", Ddo_br_scheme_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_medicationid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_Scheme_MedicationID = (long)(NumberUtil.Val( Ddo_br_scheme_medicationid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Scheme_MedicationID), 18, 0)));
            AV18TFBR_Scheme_MedicationID_To = (long)(NumberUtil.Val( Ddo_br_scheme_medicationid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Scheme_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Scheme_MedicationID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Scheme_MedicationIDTitleFilterData", AV16BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_SchemeIDTitleFilterData", AV20BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicationIDTitleFilterData", AV24BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Chem_RegimensTitleFilterData", AV28BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXNameTitleFilterData", AV32BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_RXDoseTitleFilterData", AV36BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_RXUnitTitleFilterData", AV40BR_Medication_RXUnitTitleFilterData);
      }

      protected void E146J2( )
      {
         /* Ddo_br_schemeid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_schemeid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_schemeid_Sortedstatus = "ASC";
            ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_schemeid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_schemeid_Sortedstatus = "DSC";
            ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_schemeid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV21TFBR_SchemeID = (long)(NumberUtil.Val( Ddo_br_schemeid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_SchemeID), 18, 0)));
            AV22TFBR_SchemeID_To = (long)(NumberUtil.Val( Ddo_br_schemeid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_SchemeID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Scheme_MedicationIDTitleFilterData", AV16BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_SchemeIDTitleFilterData", AV20BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicationIDTitleFilterData", AV24BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Chem_RegimensTitleFilterData", AV28BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXNameTitleFilterData", AV32BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_RXDoseTitleFilterData", AV36BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_RXUnitTitleFilterData", AV40BR_Medication_RXUnitTitleFilterData);
      }

      protected void E156J2( )
      {
         /* Ddo_br_medicationid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medicationid_Sortedstatus = "ASC";
            ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medicationid_Sortedstatus = "DSC";
            ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_MedicationID = (long)(NumberUtil.Val( Ddo_br_medicationid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TFBR_MedicationID), 18, 0)));
            AV26TFBR_MedicationID_To = (long)(NumberUtil.Val( Ddo_br_medicationid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26TFBR_MedicationID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Scheme_MedicationIDTitleFilterData", AV16BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_SchemeIDTitleFilterData", AV20BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicationIDTitleFilterData", AV24BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Chem_RegimensTitleFilterData", AV28BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXNameTitleFilterData", AV32BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_RXDoseTitleFilterData", AV36BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_RXUnitTitleFilterData", AV40BR_Medication_RXUnitTitleFilterData);
      }

      protected void E166J2( )
      {
         /* Ddo_br_scheme_chem_regimens_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_scheme_chem_regimens_Sortedstatus = "ASC";
            ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_scheme_chem_regimens_Sortedstatus = "DSC";
            ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFBR_Scheme_Chem_Regimens = Ddo_br_scheme_chem_regimens_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Scheme_Chem_Regimens", AV29TFBR_Scheme_Chem_Regimens);
            AV30TFBR_Scheme_Chem_Regimens_Sel = Ddo_br_scheme_chem_regimens_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Scheme_Chem_Regimens_Sel", AV30TFBR_Scheme_Chem_Regimens_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Scheme_MedicationIDTitleFilterData", AV16BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_SchemeIDTitleFilterData", AV20BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicationIDTitleFilterData", AV24BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Chem_RegimensTitleFilterData", AV28BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXNameTitleFilterData", AV32BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_RXDoseTitleFilterData", AV36BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_RXUnitTitleFilterData", AV40BR_Medication_RXUnitTitleFilterData);
      }

      protected void E176J2( )
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
            AV13OrderedBy = 5;
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
            AV13OrderedBy = 5;
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
            AV33TFBR_Medication_RXName = Ddo_br_medication_rxname_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Medication_RXName", AV33TFBR_Medication_RXName);
            AV34TFBR_Medication_RXName_Sel = Ddo_br_medication_rxname_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Medication_RXName_Sel", AV34TFBR_Medication_RXName_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Scheme_MedicationIDTitleFilterData", AV16BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_SchemeIDTitleFilterData", AV20BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicationIDTitleFilterData", AV24BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Chem_RegimensTitleFilterData", AV28BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXNameTitleFilterData", AV32BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_RXDoseTitleFilterData", AV36BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_RXUnitTitleFilterData", AV40BR_Medication_RXUnitTitleFilterData);
      }

      protected void E186J2( )
      {
         /* Ddo_br_medication_rxdose_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_rxdose_Sortedstatus = "ASC";
            ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_rxdose_Sortedstatus = "DSC";
            ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV37TFBR_Medication_RXDose = NumberUtil.Val( Ddo_br_medication_rxdose_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV37TFBR_Medication_RXDose, 15, 5)));
            AV38TFBR_Medication_RXDose_To = NumberUtil.Val( Ddo_br_medication_rxdose_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Medication_RXDose_To", StringUtil.LTrim( StringUtil.Str( AV38TFBR_Medication_RXDose_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Scheme_MedicationIDTitleFilterData", AV16BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_SchemeIDTitleFilterData", AV20BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicationIDTitleFilterData", AV24BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Chem_RegimensTitleFilterData", AV28BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXNameTitleFilterData", AV32BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_RXDoseTitleFilterData", AV36BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_RXUnitTitleFilterData", AV40BR_Medication_RXUnitTitleFilterData);
      }

      protected void E196J2( )
      {
         /* Ddo_br_medication_rxunit_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxunit_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxunit_Sortedstatus = "ASC";
            ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxunit_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxunit_Sortedstatus = "DSC";
            ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxunit_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV41TFBR_Medication_RXUnit = Ddo_br_medication_rxunit_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFBR_Medication_RXUnit", AV41TFBR_Medication_RXUnit);
            AV42TFBR_Medication_RXUnit_Sel = Ddo_br_medication_rxunit_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFBR_Medication_RXUnit_Sel", AV42TFBR_Medication_RXUnit_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Scheme_MedicationIDTitleFilterData", AV16BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_SchemeIDTitleFilterData", AV20BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicationIDTitleFilterData", AV24BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Chem_RegimensTitleFilterData", AV28BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXNameTitleFilterData", AV32BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_RXDoseTitleFilterData", AV36BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_RXUnitTitleFilterData", AV40BR_Medication_RXUnitTitleFilterData);
      }

      private void E236J2( )
      {
         /* Grid_Load Routine */
         AV49Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV49Display);
         AV73Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_scheme_medicationview.aspx") + "?" + UrlEncode("" +A332BR_Scheme_MedicationID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV50Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV50Update);
         AV74Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = formatLink("br_scheme_medication.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A332BR_Scheme_MedicationID);
         AV52Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV52Delete);
         AV75Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = formatLink("br_scheme_medication.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A332BR_Scheme_MedicationID);
         if ( AV56IsAuthorized_BR_Scheme_MedicationID )
         {
            edtBR_Scheme_MedicationID_Link = formatLink("br_scheme_medicationview.aspx") + "?" + UrlEncode("" +A332BR_Scheme_MedicationID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         if ( AV54IsAuthorized_BR_Scheme_Chem_Regimens )
         {
            edtBR_Scheme_Chem_Regimens_Link = formatLink("br_schemeview.aspx") + "?" + UrlEncode("" +A327BR_SchemeID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 31;
         }
         sendrow_312( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_31_Refreshing )
         {
            context.DoAjaxLoad(31, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E206J2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_scheme_medication.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S152( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_scheme_medicationid_Sortedstatus = "";
         ucDdo_br_scheme_medicationid.SendProperty(context, "", false, Ddo_br_scheme_medicationid_Internalname, "SortedStatus", Ddo_br_scheme_medicationid_Sortedstatus);
         Ddo_br_schemeid_Sortedstatus = "";
         ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
         Ddo_br_medicationid_Sortedstatus = "";
         ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
         Ddo_br_scheme_chem_regimens_Sortedstatus = "";
         ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
         Ddo_br_medication_rxname_Sortedstatus = "";
         ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
         Ddo_br_medication_rxdose_Sortedstatus = "";
         ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
         Ddo_br_medication_rxunit_Sortedstatus = "";
         ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
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
            Ddo_br_scheme_medicationid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_scheme_medicationid.SendProperty(context, "", false, Ddo_br_scheme_medicationid_Internalname, "SortedStatus", Ddo_br_scheme_medicationid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_schemeid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_medicationid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_scheme_chem_regimens_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_medication_rxname_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_medication_rxdose_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
         }
         else if ( AV13OrderedBy == 7 )
         {
            Ddo_br_medication_rxunit_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV76Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV76Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV76Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV77GXV1 = 1;
         while ( AV77GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV77GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_MEDICATIONID") == 0 )
            {
               AV17TFBR_Scheme_MedicationID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Scheme_MedicationID), 18, 0)));
               AV18TFBR_Scheme_MedicationID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Scheme_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Scheme_MedicationID_To), 18, 0)));
               if ( ! (0==AV17TFBR_Scheme_MedicationID) )
               {
                  Ddo_br_scheme_medicationid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_Scheme_MedicationID), 18, 0);
                  ucDdo_br_scheme_medicationid.SendProperty(context, "", false, Ddo_br_scheme_medicationid_Internalname, "FilteredText_set", Ddo_br_scheme_medicationid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_Scheme_MedicationID_To) )
               {
                  Ddo_br_scheme_medicationid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_Scheme_MedicationID_To), 18, 0);
                  ucDdo_br_scheme_medicationid.SendProperty(context, "", false, Ddo_br_scheme_medicationid_Internalname, "FilteredTextTo_set", Ddo_br_scheme_medicationid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEMEID") == 0 )
            {
               AV21TFBR_SchemeID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_SchemeID), 18, 0)));
               AV22TFBR_SchemeID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_SchemeID_To), 18, 0)));
               if ( ! (0==AV21TFBR_SchemeID) )
               {
                  Ddo_br_schemeid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_SchemeID), 18, 0);
                  ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "FilteredText_set", Ddo_br_schemeid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_SchemeID_To) )
               {
                  Ddo_br_schemeid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_SchemeID_To), 18, 0);
                  ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "FilteredTextTo_set", Ddo_br_schemeid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATIONID") == 0 )
            {
               AV25TFBR_MedicationID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TFBR_MedicationID), 18, 0)));
               AV26TFBR_MedicationID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26TFBR_MedicationID_To), 18, 0)));
               if ( ! (0==AV25TFBR_MedicationID) )
               {
                  Ddo_br_medicationid_Filteredtext_set = StringUtil.Str( (decimal)(AV25TFBR_MedicationID), 18, 0);
                  ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "FilteredText_set", Ddo_br_medicationid_Filteredtext_set);
               }
               if ( ! (0==AV26TFBR_MedicationID_To) )
               {
                  Ddo_br_medicationid_Filteredtextto_set = StringUtil.Str( (decimal)(AV26TFBR_MedicationID_To), 18, 0);
                  ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "FilteredTextTo_set", Ddo_br_medicationid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS") == 0 )
            {
               AV29TFBR_Scheme_Chem_Regimens = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Scheme_Chem_Regimens", AV29TFBR_Scheme_Chem_Regimens);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_Scheme_Chem_Regimens)) )
               {
                  Ddo_br_scheme_chem_regimens_Filteredtext_set = AV29TFBR_Scheme_Chem_Regimens;
                  ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "FilteredText_set", Ddo_br_scheme_chem_regimens_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS_SEL") == 0 )
            {
               AV30TFBR_Scheme_Chem_Regimens_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Scheme_Chem_Regimens_Sel", AV30TFBR_Scheme_Chem_Regimens_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFBR_Scheme_Chem_Regimens_Sel)) )
               {
                  Ddo_br_scheme_chem_regimens_Selectedvalue_set = AV30TFBR_Scheme_Chem_Regimens_Sel;
                  ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SelectedValue_set", Ddo_br_scheme_chem_regimens_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME") == 0 )
            {
               AV33TFBR_Medication_RXName = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Medication_RXName", AV33TFBR_Medication_RXName);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFBR_Medication_RXName)) )
               {
                  Ddo_br_medication_rxname_Filteredtext_set = AV33TFBR_Medication_RXName;
                  ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "FilteredText_set", Ddo_br_medication_rxname_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME_SEL") == 0 )
            {
               AV34TFBR_Medication_RXName_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Medication_RXName_Sel", AV34TFBR_Medication_RXName_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFBR_Medication_RXName_Sel)) )
               {
                  Ddo_br_medication_rxname_Selectedvalue_set = AV34TFBR_Medication_RXName_Sel;
                  ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SelectedValue_set", Ddo_br_medication_rxname_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXDOSE") == 0 )
            {
               AV37TFBR_Medication_RXDose = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV37TFBR_Medication_RXDose, 15, 5)));
               AV38TFBR_Medication_RXDose_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Medication_RXDose_To", StringUtil.LTrim( StringUtil.Str( AV38TFBR_Medication_RXDose_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV37TFBR_Medication_RXDose) )
               {
                  Ddo_br_medication_rxdose_Filteredtext_set = StringUtil.Str( AV37TFBR_Medication_RXDose, 15, 5);
                  ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "FilteredText_set", Ddo_br_medication_rxdose_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV38TFBR_Medication_RXDose_To) )
               {
                  Ddo_br_medication_rxdose_Filteredtextto_set = StringUtil.Str( AV38TFBR_Medication_RXDose_To, 15, 5);
                  ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "FilteredTextTo_set", Ddo_br_medication_rxdose_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXUNIT") == 0 )
            {
               AV41TFBR_Medication_RXUnit = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFBR_Medication_RXUnit", AV41TFBR_Medication_RXUnit);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV41TFBR_Medication_RXUnit)) )
               {
                  Ddo_br_medication_rxunit_Filteredtext_set = AV41TFBR_Medication_RXUnit;
                  ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "FilteredText_set", Ddo_br_medication_rxunit_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXUNIT_SEL") == 0 )
            {
               AV42TFBR_Medication_RXUnit_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFBR_Medication_RXUnit_Sel", AV42TFBR_Medication_RXUnit_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV42TFBR_Medication_RXUnit_Sel)) )
               {
                  Ddo_br_medication_rxunit_Selectedvalue_set = AV42TFBR_Medication_RXUnit_Sel;
                  ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "SelectedValue_set", Ddo_br_medication_rxunit_Selectedvalue_set);
               }
            }
            AV77GXV1 = (int)(AV77GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV76Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_Scheme_MedicationID) && (0==AV18TFBR_Scheme_MedicationID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_MEDICATIONID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_Scheme_MedicationID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_Scheme_MedicationID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_SchemeID) && (0==AV22TFBR_SchemeID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEMEID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_SchemeID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_SchemeID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV25TFBR_MedicationID) && (0==AV26TFBR_MedicationID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATIONID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV25TFBR_MedicationID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV26TFBR_MedicationID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_Scheme_Chem_Regimens)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_CHEM_REGIMENS";
            AV12GridStateFilterValue.gxTpr_Value = AV29TFBR_Scheme_Chem_Regimens;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFBR_Scheme_Chem_Regimens_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_CHEM_REGIMENS_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV30TFBR_Scheme_Chem_Regimens_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFBR_Medication_RXName)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXNAME";
            AV12GridStateFilterValue.gxTpr_Value = AV33TFBR_Medication_RXName;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFBR_Medication_RXName_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXNAME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV34TFBR_Medication_RXName_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV37TFBR_Medication_RXDose) && (Convert.ToDecimal(0)==AV38TFBR_Medication_RXDose_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXDOSE";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV37TFBR_Medication_RXDose, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV38TFBR_Medication_RXDose_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV41TFBR_Medication_RXUnit)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXUNIT";
            AV12GridStateFilterValue.gxTpr_Value = AV41TFBR_Medication_RXUnit;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV42TFBR_Medication_RXUnit_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXUNIT_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV42TFBR_Medication_RXUnit_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV76Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV76Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Scheme_Medication";
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
         PA6J2( ) ;
         WS6J2( ) ;
         WE6J2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815154681", true);
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
         context.AddJavascriptSource("br_scheme_medicationww.js", "?202022815154681", false);
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

      protected void SubsflControlProps_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_idx;
         edtBR_Scheme_MedicationID_Internalname = "BR_SCHEME_MEDICATIONID_"+sGXsfl_31_idx;
         edtBR_SchemeID_Internalname = "BR_SCHEMEID_"+sGXsfl_31_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_31_idx;
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS_"+sGXsfl_31_idx;
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME_"+sGXsfl_31_idx;
         edtBR_Medication_RXDose_Internalname = "BR_MEDICATION_RXDOSE_"+sGXsfl_31_idx;
         edtBR_Medication_RXUnit_Internalname = "BR_MEDICATION_RXUNIT_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_Scheme_MedicationID_Internalname = "BR_SCHEME_MEDICATIONID_"+sGXsfl_31_fel_idx;
         edtBR_SchemeID_Internalname = "BR_SCHEMEID_"+sGXsfl_31_fel_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_31_fel_idx;
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS_"+sGXsfl_31_fel_idx;
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME_"+sGXsfl_31_fel_idx;
         edtBR_Medication_RXDose_Internalname = "BR_MEDICATION_RXDOSE_"+sGXsfl_31_fel_idx;
         edtBR_Medication_RXUnit_Internalname = "BR_MEDICATION_RXUNIT_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB6J0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_31_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_31_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_31_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV49Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV49Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV73Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV49Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV49Display)) ? AV73Display_GXI : context.PathToRelativeUrl( AV49Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV49Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV50Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV50Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV74Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV50Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV50Update)) ? AV74Update_GXI : context.PathToRelativeUrl( AV50Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV50Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV52Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV52Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV75Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV52Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV52Delete)) ? AV75Delete_GXI : context.PathToRelativeUrl( AV52Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV52Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_MedicationID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Scheme_MedicationID_Link,(String)"",(String)"",(String)"",(String)edtBR_Scheme_MedicationID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_SchemeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_SchemeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicationID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicationID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Chem_Regimens_Internalname,(String)A328BR_Scheme_Chem_Regimens,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Scheme_Chem_Regimens_Link,(String)"",(String)"",(String)"",(String)edtBR_Scheme_Chem_Regimens_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXName_Internalname,(String)A121BR_Medication_RXName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXDose_Internalname,StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")),context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXDose_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXUnit_Internalname,(String)A125BR_Medication_RXUnit,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXUnit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes6J2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         /* End function sendrow_312 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
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
         edtavTfbr_scheme_medicationid_Internalname = "vTFBR_SCHEME_MEDICATIONID";
         edtavTfbr_scheme_medicationid_to_Internalname = "vTFBR_SCHEME_MEDICATIONID_TO";
         edtavTfbr_schemeid_Internalname = "vTFBR_SCHEMEID";
         edtavTfbr_schemeid_to_Internalname = "vTFBR_SCHEMEID_TO";
         edtavTfbr_medicationid_Internalname = "vTFBR_MEDICATIONID";
         edtavTfbr_medicationid_to_Internalname = "vTFBR_MEDICATIONID_TO";
         edtavTfbr_scheme_chem_regimens_Internalname = "vTFBR_SCHEME_CHEM_REGIMENS";
         edtavTfbr_scheme_chem_regimens_sel_Internalname = "vTFBR_SCHEME_CHEM_REGIMENS_SEL";
         edtavTfbr_medication_rxname_Internalname = "vTFBR_MEDICATION_RXNAME";
         edtavTfbr_medication_rxname_sel_Internalname = "vTFBR_MEDICATION_RXNAME_SEL";
         edtavTfbr_medication_rxdose_Internalname = "vTFBR_MEDICATION_RXDOSE";
         edtavTfbr_medication_rxdose_to_Internalname = "vTFBR_MEDICATION_RXDOSE_TO";
         edtavTfbr_medication_rxunit_Internalname = "vTFBR_MEDICATION_RXUNIT";
         edtavTfbr_medication_rxunit_sel_Internalname = "vTFBR_MEDICATION_RXUNIT_SEL";
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
         edtavTfbr_medicationid_to_Jsonclick = "";
         edtavTfbr_medicationid_to_Visible = 1;
         edtavTfbr_medicationid_Jsonclick = "";
         edtavTfbr_medicationid_Visible = 1;
         edtavTfbr_schemeid_to_Jsonclick = "";
         edtavTfbr_schemeid_to_Visible = 1;
         edtavTfbr_schemeid_Jsonclick = "";
         edtavTfbr_schemeid_Visible = 1;
         edtavTfbr_scheme_medicationid_to_Jsonclick = "";
         edtavTfbr_scheme_medicationid_to_Visible = 1;
         edtavTfbr_scheme_medicationid_Jsonclick = "";
         edtavTfbr_scheme_medicationid_Visible = 1;
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
         edtBR_Scheme_Chem_Regimens_Link = "";
         edtBR_Scheme_MedicationID_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
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
         edtBR_MedicationID_Titleformat = 0;
         edtBR_MedicationID_Title = "药物治疗主键";
         edtBR_SchemeID_Titleformat = 0;
         edtBR_SchemeID_Title = "化疗方案主键";
         edtBR_Scheme_MedicationID_Titleformat = 0;
         edtBR_Scheme_MedicationID_Title = "化疗方案药物详情主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_br_medication_rxunit_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxunit_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_rxunit_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_rxunit_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_rxunit_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxunit_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxunit_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_rxunit_Datalistproc = "BR_Scheme_MedicationWWGetFilterData";
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
         Ddo_br_medication_rxname_Datalistproc = "BR_Scheme_MedicationWWGetFilterData";
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
         Ddo_br_scheme_chem_regimens_Datalistproc = "BR_Scheme_MedicationWWGetFilterData";
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
         Ddo_br_medicationid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicationid_Rangefilterto = "WWP_TSTo";
         Ddo_br_medicationid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medicationid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medicationid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicationid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicationid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicationid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medicationid_Filtertype = "Numeric";
         Ddo_br_medicationid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medicationid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicationid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicationid_Titlecontrolidtoreplace = "";
         Ddo_br_medicationid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicationid_Cls = "ColumnSettings";
         Ddo_br_medicationid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicationid_Caption = "";
         Ddo_br_schemeid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_schemeid_Rangefilterto = "WWP_TSTo";
         Ddo_br_schemeid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_schemeid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_schemeid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_schemeid_Sortasc = "WWP_TSSortASC";
         Ddo_br_schemeid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_schemeid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Filtertype = "Numeric";
         Ddo_br_schemeid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Titlecontrolidtoreplace = "";
         Ddo_br_schemeid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_schemeid_Cls = "ColumnSettings";
         Ddo_br_schemeid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_schemeid_Caption = "";
         Ddo_br_scheme_medicationid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_medicationid_Rangefilterto = "WWP_TSTo";
         Ddo_br_scheme_medicationid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_scheme_medicationid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_scheme_medicationid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_medicationid_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_medicationid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_scheme_medicationid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_scheme_medicationid_Filtertype = "Numeric";
         Ddo_br_scheme_medicationid_Includefilter = Convert.ToBoolean( -1);
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = " 化疗方案药物详情";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E116J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E126J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED","{handler:'E136J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'Ddo_br_scheme_medicationid_Activeeventkey',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'ActiveEventKey'},{av:'Ddo_br_scheme_medicationid_Filteredtext_get',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'FilteredText_get'},{av:'Ddo_br_scheme_medicationid_Filteredtextto_get',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_medicationid_Sortedstatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_SCHEMEID.ONOPTIONCLICKED","{handler:'E146J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'Ddo_br_schemeid_Activeeventkey',ctrl:'DDO_BR_SCHEMEID',prop:'ActiveEventKey'},{av:'Ddo_br_schemeid_Filteredtext_get',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredText_get'},{av:'Ddo_br_schemeid_Filteredtextto_get',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_SCHEMEID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_scheme_medicationid_Sortedstatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATIONID.ONOPTIONCLICKED","{handler:'E156J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'Ddo_br_medicationid_Activeeventkey',ctrl:'DDO_BR_MEDICATIONID',prop:'ActiveEventKey'},{av:'Ddo_br_medicationid_Filteredtext_get',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredText_get'},{av:'Ddo_br_medicationid_Filteredtextto_get',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATIONID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_scheme_medicationid_Sortedstatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED","{handler:'E166J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'Ddo_br_scheme_chem_regimens_Activeeventkey',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'ActiveEventKey'},{av:'Ddo_br_scheme_chem_regimens_Filteredtext_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'FilteredText_get'},{av:'Ddo_br_scheme_chem_regimens_Selectedvalue_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'Ddo_br_scheme_medicationid_Sortedstatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED","{handler:'E176J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'Ddo_br_medication_rxname_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxname_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxname_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'Ddo_br_scheme_medicationid_Sortedstatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED","{handler:'E186J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'Ddo_br_medication_rxdose_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxdose_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxdose_Filteredtextto_get',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'Ddo_br_scheme_medicationid_Sortedstatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED","{handler:'E196J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Scheme_MedicationID',fld:'vTFBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Scheme_MedicationID_To',fld:'vTFBR_SCHEME_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV26TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV30TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV33TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV34TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV37TFBR_Medication_RXDose',fld:'vTFBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV38TFBR_Medication_RXDose_To',fld:'vTFBR_MEDICATION_RXDOSE_TO',pic:'ZZZZZZZZZ.ZZ'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76Pgmname',fld:'vPGMNAME',pic:''},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'Ddo_br_medication_rxunit_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxunit_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxunit_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV41TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV42TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'Ddo_br_scheme_medicationid_Sortedstatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV16BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV48GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E236J2',iparms:[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV56IsAuthorized_BR_Scheme_MedicationID',fld:'vISAUTHORIZED_BR_SCHEME_MEDICATIONID',pic:'',hsh:true},{av:'AV54IsAuthorized_BR_Scheme_Chem_Regimens',fld:'vISAUTHORIZED_BR_SCHEME_CHEM_REGIMENS',pic:'',hsh:true},{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV49Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV50Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV52Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_Scheme_MedicationID_Link',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Link'},{av:'edtBR_Scheme_Chem_Regimens_Link',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E206J2',iparms:[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
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
         Ddo_br_scheme_medicationid_Filteredtext_get = "";
         Ddo_br_scheme_medicationid_Filteredtextto_get = "";
         Ddo_br_schemeid_Activeeventkey = "";
         Ddo_br_schemeid_Filteredtext_get = "";
         Ddo_br_schemeid_Filteredtextto_get = "";
         Ddo_br_medicationid_Activeeventkey = "";
         Ddo_br_medicationid_Filteredtext_get = "";
         Ddo_br_medicationid_Filteredtextto_get = "";
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
         AV29TFBR_Scheme_Chem_Regimens = "";
         AV30TFBR_Scheme_Chem_Regimens_Sel = "";
         AV33TFBR_Medication_RXName = "";
         AV34TFBR_Medication_RXName_Sel = "";
         AV41TFBR_Medication_RXUnit = "";
         AV42TFBR_Medication_RXUnit_Sel = "";
         AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = "";
         AV23ddo_BR_SchemeIDTitleControlIdToReplace = "";
         AV27ddo_BR_MedicationIDTitleControlIdToReplace = "";
         AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "";
         AV35ddo_BR_Medication_RXNameTitleControlIdToReplace = "";
         AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace = "";
         AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace = "";
         AV76Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV44DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_Scheme_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Scheme_Chem_RegimensTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Medication_RXDoseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Medication_RXUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_scheme_medicationid_Filteredtext_set = "";
         Ddo_br_scheme_medicationid_Filteredtextto_set = "";
         Ddo_br_scheme_medicationid_Sortedstatus = "";
         Ddo_br_schemeid_Filteredtext_set = "";
         Ddo_br_schemeid_Filteredtextto_set = "";
         Ddo_br_schemeid_Sortedstatus = "";
         Ddo_br_medicationid_Filteredtext_set = "";
         Ddo_br_medicationid_Filteredtextto_set = "";
         Ddo_br_medicationid_Sortedstatus = "";
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
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV49Display = "";
         AV50Update = "";
         AV52Delete = "";
         A328BR_Scheme_Chem_Regimens = "";
         A121BR_Medication_RXName = "";
         A125BR_Medication_RXUnit = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_scheme_medicationid = new GXUserControl();
         ucDdo_br_schemeid = new GXUserControl();
         ucDdo_br_medicationid = new GXUserControl();
         ucDdo_br_scheme_chem_regimens = new GXUserControl();
         ucDdo_br_medication_rxname = new GXUserControl();
         ucDdo_br_medication_rxdose = new GXUserControl();
         ucDdo_br_medication_rxunit = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV73Display_GXI = "";
         AV74Update_GXI = "";
         AV75Delete_GXI = "";
         scmdbuf = "";
         lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = "";
         lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = "";
         lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = "";
         AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = "";
         AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = "";
         AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = "";
         AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = "";
         AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = "";
         AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = "";
         H006J2_A125BR_Medication_RXUnit = new String[] {""} ;
         H006J2_n125BR_Medication_RXUnit = new bool[] {false} ;
         H006J2_A124BR_Medication_RXDose = new decimal[1] ;
         H006J2_n124BR_Medication_RXDose = new bool[] {false} ;
         H006J2_A121BR_Medication_RXName = new String[] {""} ;
         H006J2_n121BR_Medication_RXName = new bool[] {false} ;
         H006J2_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         H006J2_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         H006J2_A119BR_MedicationID = new long[1] ;
         H006J2_n119BR_MedicationID = new bool[] {false} ;
         H006J2_A327BR_SchemeID = new long[1] ;
         H006J2_n327BR_SchemeID = new bool[] {false} ;
         H006J2_A332BR_Scheme_MedicationID = new long[1] ;
         H006J3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_medicationww__default(),
            new Object[][] {
                new Object[] {
               H006J2_A125BR_Medication_RXUnit, H006J2_n125BR_Medication_RXUnit, H006J2_A124BR_Medication_RXDose, H006J2_n124BR_Medication_RXDose, H006J2_A121BR_Medication_RXName, H006J2_n121BR_Medication_RXName, H006J2_A328BR_Scheme_Chem_Regimens, H006J2_n328BR_Scheme_Chem_Regimens, H006J2_A119BR_MedicationID, H006J2_n119BR_MedicationID,
               H006J2_A327BR_SchemeID, H006J2_n327BR_SchemeID, H006J2_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               H006J3_AGRID_nRecordCount
               }
            }
         );
         AV76Pgmname = "BR_Scheme_MedicationWW";
         /* GeneXus formulas. */
         AV76Pgmname = "BR_Scheme_MedicationWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_31 ;
      private short nGXsfl_31_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
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
      private int Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters ;
      private int Ddo_br_medication_rxname_Datalistupdateminimumcharacters ;
      private int Ddo_br_medication_rxunit_Datalistupdateminimumcharacters ;
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
      private int edtavTfbr_scheme_medicationid_Visible ;
      private int edtavTfbr_scheme_medicationid_to_Visible ;
      private int edtavTfbr_schemeid_Visible ;
      private int edtavTfbr_schemeid_to_Visible ;
      private int edtavTfbr_medicationid_Visible ;
      private int edtavTfbr_medicationid_to_Visible ;
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
      private int AV45PageToGo ;
      private int AV77GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_Scheme_MedicationID ;
      private long AV18TFBR_Scheme_MedicationID_To ;
      private long AV21TFBR_SchemeID ;
      private long AV22TFBR_SchemeID_To ;
      private long AV25TFBR_MedicationID ;
      private long AV26TFBR_MedicationID_To ;
      private long AV46GridCurrentPage ;
      private long AV48GridRecordCount ;
      private long AV47GridPageSize ;
      private long A332BR_Scheme_MedicationID ;
      private long A327BR_SchemeID ;
      private long A119BR_MedicationID ;
      private long GRID_nCurrentRecord ;
      private long AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ;
      private long AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ;
      private long AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ;
      private long AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ;
      private long AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ;
      private long AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ;
      private long GRID_nRecordCount ;
      private decimal AV37TFBR_Medication_RXDose ;
      private decimal AV38TFBR_Medication_RXDose_To ;
      private decimal A124BR_Medication_RXDose ;
      private decimal AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ;
      private decimal AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_scheme_medicationid_Activeeventkey ;
      private String Ddo_br_scheme_medicationid_Filteredtext_get ;
      private String Ddo_br_scheme_medicationid_Filteredtextto_get ;
      private String Ddo_br_schemeid_Activeeventkey ;
      private String Ddo_br_schemeid_Filteredtext_get ;
      private String Ddo_br_schemeid_Filteredtextto_get ;
      private String Ddo_br_medicationid_Activeeventkey ;
      private String Ddo_br_medicationid_Filteredtext_get ;
      private String Ddo_br_medicationid_Filteredtextto_get ;
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
      private String sGXsfl_31_idx="0001" ;
      private String AV76Pgmname ;
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
      private String Ddo_br_scheme_medicationid_Caption ;
      private String Ddo_br_scheme_medicationid_Tooltip ;
      private String Ddo_br_scheme_medicationid_Cls ;
      private String Ddo_br_scheme_medicationid_Filteredtext_set ;
      private String Ddo_br_scheme_medicationid_Filteredtextto_set ;
      private String Ddo_br_scheme_medicationid_Dropdownoptionstype ;
      private String Ddo_br_scheme_medicationid_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_medicationid_Sortedstatus ;
      private String Ddo_br_scheme_medicationid_Filtertype ;
      private String Ddo_br_scheme_medicationid_Sortasc ;
      private String Ddo_br_scheme_medicationid_Sortdsc ;
      private String Ddo_br_scheme_medicationid_Cleanfilter ;
      private String Ddo_br_scheme_medicationid_Rangefilterfrom ;
      private String Ddo_br_scheme_medicationid_Rangefilterto ;
      private String Ddo_br_scheme_medicationid_Searchbuttontext ;
      private String Ddo_br_schemeid_Caption ;
      private String Ddo_br_schemeid_Tooltip ;
      private String Ddo_br_schemeid_Cls ;
      private String Ddo_br_schemeid_Filteredtext_set ;
      private String Ddo_br_schemeid_Filteredtextto_set ;
      private String Ddo_br_schemeid_Dropdownoptionstype ;
      private String Ddo_br_schemeid_Titlecontrolidtoreplace ;
      private String Ddo_br_schemeid_Sortedstatus ;
      private String Ddo_br_schemeid_Filtertype ;
      private String Ddo_br_schemeid_Sortasc ;
      private String Ddo_br_schemeid_Sortdsc ;
      private String Ddo_br_schemeid_Cleanfilter ;
      private String Ddo_br_schemeid_Rangefilterfrom ;
      private String Ddo_br_schemeid_Rangefilterto ;
      private String Ddo_br_schemeid_Searchbuttontext ;
      private String Ddo_br_medicationid_Caption ;
      private String Ddo_br_medicationid_Tooltip ;
      private String Ddo_br_medicationid_Cls ;
      private String Ddo_br_medicationid_Filteredtext_set ;
      private String Ddo_br_medicationid_Filteredtextto_set ;
      private String Ddo_br_medicationid_Dropdownoptionstype ;
      private String Ddo_br_medicationid_Titlecontrolidtoreplace ;
      private String Ddo_br_medicationid_Sortedstatus ;
      private String Ddo_br_medicationid_Filtertype ;
      private String Ddo_br_medicationid_Sortasc ;
      private String Ddo_br_medicationid_Sortdsc ;
      private String Ddo_br_medicationid_Cleanfilter ;
      private String Ddo_br_medicationid_Rangefilterfrom ;
      private String Ddo_br_medicationid_Rangefilterto ;
      private String Ddo_br_medicationid_Searchbuttontext ;
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
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
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
      private String edtBR_Scheme_MedicationID_Title ;
      private String edtBR_SchemeID_Title ;
      private String edtBR_MedicationID_Title ;
      private String edtBR_Scheme_Chem_Regimens_Title ;
      private String edtBR_Medication_RXName_Title ;
      private String edtBR_Medication_RXDose_Title ;
      private String edtBR_Medication_RXUnit_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_Scheme_MedicationID_Link ;
      private String edtBR_Scheme_Chem_Regimens_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_scheme_medicationid_Internalname ;
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
      private String edtavTfbr_scheme_medicationid_Internalname ;
      private String edtavTfbr_scheme_medicationid_Jsonclick ;
      private String edtavTfbr_scheme_medicationid_to_Internalname ;
      private String edtavTfbr_scheme_medicationid_to_Jsonclick ;
      private String edtavTfbr_schemeid_Internalname ;
      private String edtavTfbr_schemeid_Jsonclick ;
      private String edtavTfbr_schemeid_to_Internalname ;
      private String edtavTfbr_schemeid_to_Jsonclick ;
      private String edtavTfbr_medicationid_Internalname ;
      private String edtavTfbr_medicationid_Jsonclick ;
      private String edtavTfbr_medicationid_to_Internalname ;
      private String edtavTfbr_medicationid_to_Jsonclick ;
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
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_Scheme_MedicationID_Internalname ;
      private String edtBR_SchemeID_Internalname ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_Scheme_Chem_Regimens_Internalname ;
      private String edtBR_Medication_RXName_Internalname ;
      private String edtBR_Medication_RXDose_Internalname ;
      private String edtBR_Medication_RXUnit_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_Scheme_MedicationID_Jsonclick ;
      private String edtBR_SchemeID_Jsonclick ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_Scheme_Chem_Regimens_Jsonclick ;
      private String edtBR_Medication_RXName_Jsonclick ;
      private String edtBR_Medication_RXDose_Jsonclick ;
      private String edtBR_Medication_RXUnit_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV56IsAuthorized_BR_Scheme_MedicationID ;
      private bool AV54IsAuthorized_BR_Scheme_Chem_Regimens ;
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
      private bool Ddo_br_scheme_medicationid_Includesortasc ;
      private bool Ddo_br_scheme_medicationid_Includesortdsc ;
      private bool Ddo_br_scheme_medicationid_Includefilter ;
      private bool Ddo_br_scheme_medicationid_Filterisrange ;
      private bool Ddo_br_scheme_medicationid_Includedatalist ;
      private bool Ddo_br_schemeid_Includesortasc ;
      private bool Ddo_br_schemeid_Includesortdsc ;
      private bool Ddo_br_schemeid_Includefilter ;
      private bool Ddo_br_schemeid_Filterisrange ;
      private bool Ddo_br_schemeid_Includedatalist ;
      private bool Ddo_br_medicationid_Includesortasc ;
      private bool Ddo_br_medicationid_Includesortdsc ;
      private bool Ddo_br_medicationid_Includefilter ;
      private bool Ddo_br_medicationid_Filterisrange ;
      private bool Ddo_br_medicationid_Includedatalist ;
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
      private bool bGXsfl_31_Refreshing=false ;
      private bool n327BR_SchemeID ;
      private bool n119BR_MedicationID ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n121BR_Medication_RXName ;
      private bool n124BR_Medication_RXDose ;
      private bool n125BR_Medication_RXUnit ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV49Display_IsBlob ;
      private bool AV50Update_IsBlob ;
      private bool AV52Delete_IsBlob ;
      private String AV29TFBR_Scheme_Chem_Regimens ;
      private String AV30TFBR_Scheme_Chem_Regimens_Sel ;
      private String AV33TFBR_Medication_RXName ;
      private String AV34TFBR_Medication_RXName_Sel ;
      private String AV41TFBR_Medication_RXUnit ;
      private String AV42TFBR_Medication_RXUnit_Sel ;
      private String AV19ddo_BR_Scheme_MedicationIDTitleControlIdToReplace ;
      private String AV23ddo_BR_SchemeIDTitleControlIdToReplace ;
      private String AV27ddo_BR_MedicationIDTitleControlIdToReplace ;
      private String AV31ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace ;
      private String AV35ddo_BR_Medication_RXNameTitleControlIdToReplace ;
      private String AV39ddo_BR_Medication_RXDoseTitleControlIdToReplace ;
      private String AV43ddo_BR_Medication_RXUnitTitleControlIdToReplace ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String A121BR_Medication_RXName ;
      private String A125BR_Medication_RXUnit ;
      private String AV73Display_GXI ;
      private String AV74Update_GXI ;
      private String AV75Delete_GXI ;
      private String lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ;
      private String lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ;
      private String lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ;
      private String AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ;
      private String AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ;
      private String AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ;
      private String AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ;
      private String AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ;
      private String AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ;
      private String AV49Display ;
      private String AV50Update ;
      private String AV52Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_scheme_medicationid ;
      private GXUserControl ucDdo_br_schemeid ;
      private GXUserControl ucDdo_br_medicationid ;
      private GXUserControl ucDdo_br_scheme_chem_regimens ;
      private GXUserControl ucDdo_br_medication_rxname ;
      private GXUserControl ucDdo_br_medication_rxdose ;
      private GXUserControl ucDdo_br_medication_rxunit ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H006J2_A125BR_Medication_RXUnit ;
      private bool[] H006J2_n125BR_Medication_RXUnit ;
      private decimal[] H006J2_A124BR_Medication_RXDose ;
      private bool[] H006J2_n124BR_Medication_RXDose ;
      private String[] H006J2_A121BR_Medication_RXName ;
      private bool[] H006J2_n121BR_Medication_RXName ;
      private String[] H006J2_A328BR_Scheme_Chem_Regimens ;
      private bool[] H006J2_n328BR_Scheme_Chem_Regimens ;
      private long[] H006J2_A119BR_MedicationID ;
      private bool[] H006J2_n119BR_MedicationID ;
      private long[] H006J2_A327BR_SchemeID ;
      private bool[] H006J2_n327BR_SchemeID ;
      private long[] H006J2_A332BR_Scheme_MedicationID ;
      private long[] H006J3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Scheme_MedicationIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_SchemeIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_MedicationIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Scheme_Chem_RegimensTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Medication_RXNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36BR_Medication_RXDoseTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV40BR_Medication_RXUnitTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV44DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_scheme_medicationww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H006J2( IGxContext context ,
                                             long AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ,
                                             long AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ,
                                             long AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ,
                                             long AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ,
                                             long AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ,
                                             long AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ,
                                             String AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ,
                                             String AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ,
                                             String AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ,
                                             String AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ,
                                             decimal AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ,
                                             decimal AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ,
                                             String AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ,
                                             String AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ,
                                             long A332BR_Scheme_MedicationID ,
                                             long A327BR_SchemeID ,
                                             long A119BR_MedicationID ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A121BR_Medication_RXName ,
                                             decimal A124BR_Medication_RXDose ,
                                             String A125BR_Medication_RXUnit ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [17] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T2.[BR_Medication_RXUnit], T2.[BR_Medication_RXDose], T2.[BR_Medication_RXName], T3.[BR_Scheme_Chem_Regimens], T1.[BR_MedicationID], T1.[BR_SchemeID], T1.[BR_Scheme_MedicationID]";
         sFromString = " FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Medication] T2 WITH (NOLOCK) ON T2.[BR_MedicationID] = T1.[BR_MedicationID]) LEFT JOIN [BR_Scheme] T3 WITH (NOLOCK) ON T3.[BR_SchemeID] = T1.[BR_SchemeID])";
         sOrderString = "";
         if ( ! (0==AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Scheme_MedicationID] >= @AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Scheme_MedicationID] >= @AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Scheme_MedicationID] <= @AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Scheme_MedicationID] <= @AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_SchemeID] >= @AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_SchemeID] >= @AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_SchemeID] <= @AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_SchemeID] <= @AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_MedicationID] >= @AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_MedicationID] >= @AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_MedicationID] <= @AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_MedicationID] <= @AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] like @lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Scheme_Chem_Regimens] like @lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] = @AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Scheme_Chem_Regimens] = @AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] like @lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXName] like @lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] = @AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXName] = @AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] >= @AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXDose] >= @AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] <= @AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXDose] <= @AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] like @lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXUnit] like @lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)";
            }
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] = @AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXUnit] = @AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)";
            }
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Scheme_MedicationID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Scheme_MedicationID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_SchemeID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_SchemeID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicationID]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicationID] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Scheme_Chem_Regimens]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Scheme_Chem_Regimens] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXName]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXName] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXDose]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXDose] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXUnit]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
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

      protected Object[] conditional_H006J3( IGxContext context ,
                                             long AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ,
                                             long AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ,
                                             long AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ,
                                             long AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ,
                                             long AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ,
                                             long AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ,
                                             String AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ,
                                             String AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ,
                                             String AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ,
                                             String AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ,
                                             decimal AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ,
                                             decimal AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ,
                                             String AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ,
                                             String AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ,
                                             long A332BR_Scheme_MedicationID ,
                                             long A327BR_SchemeID ,
                                             long A119BR_MedicationID ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A121BR_Medication_RXName ,
                                             decimal A124BR_Medication_RXDose ,
                                             String A125BR_Medication_RXUnit ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [14] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Medication] T3 WITH (NOLOCK) ON T3.[BR_MedicationID] = T1.[BR_MedicationID]) LEFT JOIN [BR_Scheme] T2 WITH (NOLOCK) ON T2.[BR_SchemeID] = T1.[BR_SchemeID])";
         if ( ! (0==AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Scheme_MedicationID] >= @AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Scheme_MedicationID] >= @AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Scheme_MedicationID] <= @AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Scheme_MedicationID] <= @AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_SchemeID] >= @AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_SchemeID] >= @AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_SchemeID] <= @AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_SchemeID] <= @AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! (0==AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_MedicationID] >= @AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_MedicationID] >= @AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! (0==AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_MedicationID] <= @AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_MedicationID] <= @AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Scheme_Chem_Regimens] like @lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Scheme_Chem_Regimens] like @lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Scheme_Chem_Regimens] = @AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Scheme_Chem_Regimens] = @AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXName] like @lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXName] like @lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXName] = @AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXName] = @AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXDose] >= @AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXDose] >= @AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXDose] <= @AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXDose] <= @AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXUnit] like @lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXUnit] like @lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)";
            }
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXUnit] = @AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXUnit] = @AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)";
            }
         }
         else
         {
            GXv_int5[13] = 1;
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
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
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
                     return conditional_H006J2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (long)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (decimal)dynConstraints[19] , (String)dynConstraints[20] , (short)dynConstraints[21] , (bool)dynConstraints[22] );
               case 1 :
                     return conditional_H006J3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (long)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (decimal)dynConstraints[19] , (String)dynConstraints[20] , (short)dynConstraints[21] , (bool)dynConstraints[22] );
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
          Object[] prmH006J2 ;
          prmH006J2 = new Object[] {
          new Object[] {"@AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH006J3 ;
          prmH006J3 = new Object[] {
          new Object[] {"@AV59BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV60BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV61BR_Scheme_MedicationWWDS_3_Tfbr_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV62BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV63BR_Scheme_MedicationWWDS_5_Tfbr_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV64BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV65BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV66BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV67BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV69BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV70BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV71BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV72BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H006J2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006J2,11,0,true,false )
             ,new CursorDef("H006J3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006J3,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[21]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[27]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[28]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[30]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[31]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[32]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[33]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[25]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                return;
       }
    }

 }

}
