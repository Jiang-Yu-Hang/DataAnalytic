/*
               File: BR_InformationList
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:17:13.66
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
   public class br_informationlist : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_informationlist( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_informationlist( IGxContext context )
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
         cmbavView_lpi_br_demographics_birthdateoperator = new GXCombobox();
         dynavView_lpi_br_demographics_ethnic = new GXCombobox();
         dynavView_lpi_br_demographics_sex = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC") == 0 )
            {
               AV53tTenantCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVIEW_LPI_BR_DEMOGRAPHICS_ETHNICA02( AV53tTenantCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVIEW_LPI_BR_DEMOGRAPHICS_SEX") == 0 )
            {
               AV53tTenantCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVIEW_LPI_BR_DEMOGRAPHICS_SEXA02( AV53tTenantCode) ;
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
               nRC_GXsfl_68 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_68_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_68_idx = GetNextPar( );
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
               AV15VIEW_LPI_BR_Information_PatientNo = GetNextPar( );
               AV16VIEW_LPI_BR_Demographics_BirthDateOperator = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV18VIEW_LPI_BR_Demographics_BirthDate = context.localUtil.ParseDateParm( GetNextPar( ));
               AV17VIEW_LPI_BR_Demographics_BirthDate_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV19VIEW_LPI_BR_Demographics_Ethnic = GetNextPar( );
               AV20VIEW_LPI_BR_Demographics_Sex = GetNextPar( );
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV23TFVIEW_LPI_BR_Information_PatientNo = GetNextPar( );
               AV24TFVIEW_LPI_BR_Information_PatientNo_Sel = GetNextPar( );
               AV27TFVIEW_LPI_BR_Demographics_Sex = GetNextPar( );
               AV28TFVIEW_LPI_BR_Demographics_Sex_Sel = GetNextPar( );
               AV31TFVIEW_LPI_BR_Demographics_BirthDate = context.localUtil.ParseDateParm( GetNextPar( ));
               AV32TFVIEW_LPI_BR_Demographics_BirthDate_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV37TFVIEW_LPI_BR_Demographics_Ethnic = GetNextPar( );
               AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel = GetNextPar( );
               AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace = GetNextPar( );
               AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace = GetNextPar( );
               AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace = GetNextPar( );
               AV72Pgmname = GetNextPar( );
               AV46IsAuthorized_PatientReTenant = StringUtil.StrToBool( GetNextPar( ));
               AV48IsAuthorized_Patient_Entity = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV15VIEW_LPI_BR_Information_PatientNo, AV16VIEW_LPI_BR_Demographics_BirthDateOperator, AV18VIEW_LPI_BR_Demographics_BirthDate, AV17VIEW_LPI_BR_Demographics_BirthDate_To, AV19VIEW_LPI_BR_Demographics_Ethnic, AV20VIEW_LPI_BR_Demographics_Sex, AV13OrderedBy, AV14OrderedDsc, AV23TFVIEW_LPI_BR_Information_PatientNo, AV24TFVIEW_LPI_BR_Information_PatientNo_Sel, AV27TFVIEW_LPI_BR_Demographics_Sex, AV28TFVIEW_LPI_BR_Demographics_Sex_Sel, AV31TFVIEW_LPI_BR_Demographics_BirthDate, AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, AV37TFVIEW_LPI_BR_Demographics_Ethnic, AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel, AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace, AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace, AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace, AV72Pgmname, AV46IsAuthorized_PatientReTenant, AV48IsAuthorized_Patient_Entity) ;
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
         PAA02( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            STARTA02( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815171393", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_informationlist.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vVIEW_LPI_BR_INFORMATION_PATIENTNO", AV15VIEW_LPI_BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16VIEW_LPI_BR_Demographics_BirthDateOperator), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE", context.localUtil.Format(AV18VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO", context.localUtil.Format(AV17VIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC", AV19VIEW_LPI_BR_Demographics_Ethnic);
         GxWebStd.gx_hidden_field( context, "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_SEX", AV20VIEW_LPI_BR_Demographics_Sex);
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_LPI_BR_INFORMATION_PATIENTNO", AV23TFVIEW_LPI_BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL", AV24TFVIEW_LPI_BR_Information_PatientNo_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX", AV27TFVIEW_LPI_BR_Demographics_Sex);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL", AV28TFVIEW_LPI_BR_Demographics_Sex_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE", context.localUtil.Format(AV31TFVIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO", context.localUtil.Format(AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC", AV37TFVIEW_LPI_BR_Demographics_Ethnic);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL", AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_68", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_68), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV40DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV40DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA", AV26VIEW_LPI_BR_Demographics_SexTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA", AV26VIEW_LPI_BR_Demographics_SexTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA", AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA", AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA", AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA", AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV72Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_PATIENTRETENANT", AV46IsAuthorized_PatientReTenant);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_PATIENT_ENTITY", AV48IsAuthorized_Patient_Entity);
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vTTENANTCODE", AV53tTenantCode);
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
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Caption", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Tooltip", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Cls", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Filteredtext_set", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Selectedvalue_set", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Includesortasc", StringUtil.BoolToStr( Ddo_view_lpi_br_information_patientno_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Includesortdsc", StringUtil.BoolToStr( Ddo_view_lpi_br_information_patientno_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Sortedstatus", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Includefilter", StringUtil.BoolToStr( Ddo_view_lpi_br_information_patientno_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Filtertype", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Filterisrange", StringUtil.BoolToStr( Ddo_view_lpi_br_information_patientno_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Includedatalist", StringUtil.BoolToStr( Ddo_view_lpi_br_information_patientno_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Datalisttype", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Datalistproc", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_view_lpi_br_information_patientno_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Sortasc", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Sortdsc", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Loadingdata", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Cleanfilter", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Noresultsfound", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Searchbuttontext", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Caption", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Tooltip", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Cls", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Filteredtext_set", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Selectedvalue_set", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Includesortasc", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_sex_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Includesortdsc", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_sex_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Sortedstatus", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Includefilter", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_sex_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Filtertype", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Filterisrange", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_sex_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Includedatalist", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_sex_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Datalisttype", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Datalistproc", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_view_lpi_br_demographics_sex_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Sortasc", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Sortdsc", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Loadingdata", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Cleanfilter", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Noresultsfound", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Searchbuttontext", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Caption", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Tooltip", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Cls", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filteredtext_set", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filteredtextto_set", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Includesortasc", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_birthdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_birthdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Sortedstatus", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Includefilter", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_birthdate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filtertype", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filterisrange", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_birthdate_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Includedatalist", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_birthdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Sortasc", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Sortdsc", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Cleanfilter", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Rangefilterfrom", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Rangefilterto", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Searchbuttontext", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Caption", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Tooltip", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Cls", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Filteredtext_set", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Selectedvalue_set", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Includesortasc", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_ethnic_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Includesortdsc", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_ethnic_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Sortedstatus", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Includefilter", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_ethnic_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Filtertype", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Filterisrange", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_ethnic_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Includedatalist", StringUtil.BoolToStr( Ddo_view_lpi_br_demographics_ethnic_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Datalisttype", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Datalistproc", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_view_lpi_br_demographics_ethnic_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Sortasc", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Sortdsc", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Loadingdata", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Cleanfilter", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Noresultsfound", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Searchbuttontext", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Filteredtext_get", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Selectedvalue_get", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Activeeventkey", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Filteredtext_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Selectedvalue_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Activeeventkey", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filteredtext_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Activeeventkey", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Filteredtext_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Selectedvalue_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Filteredtext_get", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Selectedvalue_get", StringUtil.RTrim( Ddo_view_lpi_br_information_patientno_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Activeeventkey", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Filteredtext_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Selectedvalue_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_sex_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Activeeventkey", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filteredtext_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Activeeventkey", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Filteredtext_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Selectedvalue_get", StringUtil.RTrim( Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_get));
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
            WEA02( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVTA02( ) ;
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
         return formatLink("br_informationlist.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_InformationList" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WBA00( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableiew_lpi_br_information_patientno_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-5 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextview_lpi_br_information_patientno_Internalname, "患者编号", "", "", lblFiltertextview_lpi_br_information_patientno_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_InformationList.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-7", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavView_lpi_br_information_patientno_Internalname, "VIEW_LPI_BR_Information_Patient No", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'" + sGXsfl_68_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavView_lpi_br_information_patientno_Internalname, AV15VIEW_LPI_BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( AV15VIEW_LPI_BR_Information_PatientNo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,23);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavView_lpi_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavView_lpi_br_information_patientno_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_InformationList.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedfiltertextview_lpi_br_demographics_birthdate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextview_lpi_br_demographics_birthdate_Internalname, "出生日期", "", "", lblFiltertextview_lpi_br_demographics_birthdate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_InformationList.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            wb_table1_30_A02( true) ;
         }
         else
         {
            wb_table1_30_A02( false) ;
         }
         return  ;
      }

      protected void wb_table1_30_A02e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableiew_lpi_br_demographics_ethnic_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-5 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextview_lpi_br_demographics_ethnic_Internalname, "民族", "", "", lblFiltertextview_lpi_br_demographics_ethnic_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_InformationList.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-7", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavView_lpi_br_demographics_ethnic_Internalname, "VIEW_LPI_BR_Demographics_Ethnic", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_68_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavView_lpi_br_demographics_ethnic, dynavView_lpi_br_demographics_ethnic_Internalname, StringUtil.RTrim( AV19VIEW_LPI_BR_Demographics_Ethnic), 1, dynavView_lpi_br_demographics_ethnic_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavView_lpi_br_demographics_ethnic.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "", true, "HLP_BR_InformationList.htm");
            dynavView_lpi_br_demographics_ethnic.CurrentValue = StringUtil.RTrim( AV19VIEW_LPI_BR_Demographics_Ethnic);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavView_lpi_br_demographics_ethnic_Internalname, "Values", (String)(dynavView_lpi_br_demographics_ethnic.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableiew_lpi_br_demographics_sex_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextview_lpi_br_demographics_sex_Internalname, "性别", "", "", lblFiltertextview_lpi_br_demographics_sex_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_InformationList.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavView_lpi_br_demographics_sex_Internalname, "VIEW_LPI_BR_Demographics_Sex", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_68_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavView_lpi_br_demographics_sex, dynavView_lpi_br_demographics_sex_Internalname, StringUtil.RTrim( AV20VIEW_LPI_BR_Demographics_Sex), 1, dynavView_lpi_br_demographics_sex_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavView_lpi_br_demographics_sex.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "", true, "HLP_BR_InformationList.htm");
            dynavView_lpi_br_demographics_sex.CurrentValue = StringUtil.RTrim( AV20VIEW_LPI_BR_Demographics_Sex);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavView_lpi_br_demographics_sex_Internalname, "Values", (String)(dynavView_lpi_br_demographics_sex.ToJavascriptSource()), true);
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"68\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavPatientretenant_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavPatient_entity_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "VIEW_LPI_BR_Information_ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtVIEW_LPI_BR_Information_PatientNo_Titleformat == 0 )
               {
                  context.SendWebValue( edtVIEW_LPI_BR_Information_PatientNo_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtVIEW_LPI_BR_Information_PatientNo_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtVIEW_LPI_BR_Demographics_Sex_Titleformat == 0 )
               {
                  context.SendWebValue( edtVIEW_LPI_BR_Demographics_Sex_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtVIEW_LPI_BR_Demographics_Sex_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtVIEW_LPI_BR_Demographics_BirthDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtVIEW_LPI_BR_Demographics_BirthDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtVIEW_LPI_BR_Demographics_BirthDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtVIEW_LPI_BR_Demographics_Ethnic_Titleformat == 0 )
               {
                  context.SendWebValue( edtVIEW_LPI_BR_Demographics_Ethnic_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtVIEW_LPI_BR_Demographics_Ethnic_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV45PatientReTenant));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavPatientretenant_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavPatientretenant_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavPatientretenant_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV47Patient_Entity));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavPatient_entity_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavPatient_entity_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavPatient_entity_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A519VIEW_LPI_BR_Information_PatientNo);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtVIEW_LPI_BR_Information_PatientNo_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtVIEW_LPI_BR_Information_PatientNo_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A522VIEW_LPI_BR_Demographics_Sex);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtVIEW_LPI_BR_Demographics_Sex_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtVIEW_LPI_BR_Demographics_Sex_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtVIEW_LPI_BR_Demographics_BirthDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtVIEW_LPI_BR_Demographics_BirthDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A524VIEW_LPI_BR_Demographics_Ethnic);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtVIEW_LPI_BR_Demographics_Ethnic_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtVIEW_LPI_BR_Demographics_Ethnic_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 68 )
         {
            wbEnd = 0;
            nRC_GXsfl_68 = (short)(nGXsfl_68_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV42GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV44GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV43GridPageSize);
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
            ucDdo_view_lpi_br_information_patientno.SetProperty("Caption", Ddo_view_lpi_br_information_patientno_Caption);
            ucDdo_view_lpi_br_information_patientno.SetProperty("Tooltip", Ddo_view_lpi_br_information_patientno_Tooltip);
            ucDdo_view_lpi_br_information_patientno.SetProperty("Cls", Ddo_view_lpi_br_information_patientno_Cls);
            ucDdo_view_lpi_br_information_patientno.SetProperty("DropDownOptionsType", Ddo_view_lpi_br_information_patientno_Dropdownoptionstype);
            ucDdo_view_lpi_br_information_patientno.SetProperty("IncludeSortASC", Ddo_view_lpi_br_information_patientno_Includesortasc);
            ucDdo_view_lpi_br_information_patientno.SetProperty("IncludeSortDSC", Ddo_view_lpi_br_information_patientno_Includesortdsc);
            ucDdo_view_lpi_br_information_patientno.SetProperty("IncludeFilter", Ddo_view_lpi_br_information_patientno_Includefilter);
            ucDdo_view_lpi_br_information_patientno.SetProperty("FilterType", Ddo_view_lpi_br_information_patientno_Filtertype);
            ucDdo_view_lpi_br_information_patientno.SetProperty("FilterIsRange", Ddo_view_lpi_br_information_patientno_Filterisrange);
            ucDdo_view_lpi_br_information_patientno.SetProperty("IncludeDataList", Ddo_view_lpi_br_information_patientno_Includedatalist);
            ucDdo_view_lpi_br_information_patientno.SetProperty("DataListType", Ddo_view_lpi_br_information_patientno_Datalisttype);
            ucDdo_view_lpi_br_information_patientno.SetProperty("DataListProc", Ddo_view_lpi_br_information_patientno_Datalistproc);
            ucDdo_view_lpi_br_information_patientno.SetProperty("DataListUpdateMinimumCharacters", Ddo_view_lpi_br_information_patientno_Datalistupdateminimumcharacters);
            ucDdo_view_lpi_br_information_patientno.SetProperty("SortASC", Ddo_view_lpi_br_information_patientno_Sortasc);
            ucDdo_view_lpi_br_information_patientno.SetProperty("SortDSC", Ddo_view_lpi_br_information_patientno_Sortdsc);
            ucDdo_view_lpi_br_information_patientno.SetProperty("LoadingData", Ddo_view_lpi_br_information_patientno_Loadingdata);
            ucDdo_view_lpi_br_information_patientno.SetProperty("CleanFilter", Ddo_view_lpi_br_information_patientno_Cleanfilter);
            ucDdo_view_lpi_br_information_patientno.SetProperty("NoResultsFound", Ddo_view_lpi_br_information_patientno_Noresultsfound);
            ucDdo_view_lpi_br_information_patientno.SetProperty("SearchButtonText", Ddo_view_lpi_br_information_patientno_Searchbuttontext);
            ucDdo_view_lpi_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_view_lpi_br_information_patientno.SetProperty("DropDownOptionsData", AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData);
            ucDdo_view_lpi_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_lpi_br_information_patientno_Internalname, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'" + sGXsfl_68_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_lpi_br_information_patientnotitlecontrolidtoreplace_Internalname, AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", 0, edtavDdo_view_lpi_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationList.htm");
            /* User Defined Control */
            ucDdo_view_lpi_br_demographics_sex.SetProperty("Caption", Ddo_view_lpi_br_demographics_sex_Caption);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("Tooltip", Ddo_view_lpi_br_demographics_sex_Tooltip);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("Cls", Ddo_view_lpi_br_demographics_sex_Cls);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("DropDownOptionsType", Ddo_view_lpi_br_demographics_sex_Dropdownoptionstype);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("IncludeSortASC", Ddo_view_lpi_br_demographics_sex_Includesortasc);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("IncludeSortDSC", Ddo_view_lpi_br_demographics_sex_Includesortdsc);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("IncludeFilter", Ddo_view_lpi_br_demographics_sex_Includefilter);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("FilterType", Ddo_view_lpi_br_demographics_sex_Filtertype);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("FilterIsRange", Ddo_view_lpi_br_demographics_sex_Filterisrange);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("IncludeDataList", Ddo_view_lpi_br_demographics_sex_Includedatalist);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("DataListType", Ddo_view_lpi_br_demographics_sex_Datalisttype);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("DataListProc", Ddo_view_lpi_br_demographics_sex_Datalistproc);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("DataListUpdateMinimumCharacters", Ddo_view_lpi_br_demographics_sex_Datalistupdateminimumcharacters);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("SortASC", Ddo_view_lpi_br_demographics_sex_Sortasc);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("SortDSC", Ddo_view_lpi_br_demographics_sex_Sortdsc);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("LoadingData", Ddo_view_lpi_br_demographics_sex_Loadingdata);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("CleanFilter", Ddo_view_lpi_br_demographics_sex_Cleanfilter);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("NoResultsFound", Ddo_view_lpi_br_demographics_sex_Noresultsfound);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("SearchButtonText", Ddo_view_lpi_br_demographics_sex_Searchbuttontext);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_view_lpi_br_demographics_sex.SetProperty("DropDownOptionsData", AV26VIEW_LPI_BR_Demographics_SexTitleFilterData);
            ucDdo_view_lpi_br_demographics_sex.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_lpi_br_demographics_sex_Internalname, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'" + sGXsfl_68_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_lpi_br_demographics_sextitlecontrolidtoreplace_Internalname, AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", 0, edtavDdo_view_lpi_br_demographics_sextitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationList.htm");
            /* User Defined Control */
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("Caption", Ddo_view_lpi_br_demographics_birthdate_Caption);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("Tooltip", Ddo_view_lpi_br_demographics_birthdate_Tooltip);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("Cls", Ddo_view_lpi_br_demographics_birthdate_Cls);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("DropDownOptionsType", Ddo_view_lpi_br_demographics_birthdate_Dropdownoptionstype);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("IncludeSortASC", Ddo_view_lpi_br_demographics_birthdate_Includesortasc);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("IncludeSortDSC", Ddo_view_lpi_br_demographics_birthdate_Includesortdsc);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("IncludeFilter", Ddo_view_lpi_br_demographics_birthdate_Includefilter);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("FilterType", Ddo_view_lpi_br_demographics_birthdate_Filtertype);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("FilterIsRange", Ddo_view_lpi_br_demographics_birthdate_Filterisrange);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("IncludeDataList", Ddo_view_lpi_br_demographics_birthdate_Includedatalist);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("SortASC", Ddo_view_lpi_br_demographics_birthdate_Sortasc);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("SortDSC", Ddo_view_lpi_br_demographics_birthdate_Sortdsc);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("CleanFilter", Ddo_view_lpi_br_demographics_birthdate_Cleanfilter);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("RangeFilterFrom", Ddo_view_lpi_br_demographics_birthdate_Rangefilterfrom);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("RangeFilterTo", Ddo_view_lpi_br_demographics_birthdate_Rangefilterto);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("SearchButtonText", Ddo_view_lpi_br_demographics_birthdate_Searchbuttontext);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_view_lpi_br_demographics_birthdate.SetProperty("DropDownOptionsData", AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData);
            ucDdo_view_lpi_br_demographics_birthdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_lpi_br_demographics_birthdate_Internalname, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'" + sGXsfl_68_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_lpi_br_demographics_birthdatetitlecontrolidtoreplace_Internalname, AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", 0, edtavDdo_view_lpi_br_demographics_birthdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationList.htm");
            /* User Defined Control */
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("Caption", Ddo_view_lpi_br_demographics_ethnic_Caption);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("Tooltip", Ddo_view_lpi_br_demographics_ethnic_Tooltip);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("Cls", Ddo_view_lpi_br_demographics_ethnic_Cls);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("DropDownOptionsType", Ddo_view_lpi_br_demographics_ethnic_Dropdownoptionstype);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("IncludeSortASC", Ddo_view_lpi_br_demographics_ethnic_Includesortasc);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("IncludeSortDSC", Ddo_view_lpi_br_demographics_ethnic_Includesortdsc);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("IncludeFilter", Ddo_view_lpi_br_demographics_ethnic_Includefilter);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("FilterType", Ddo_view_lpi_br_demographics_ethnic_Filtertype);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("FilterIsRange", Ddo_view_lpi_br_demographics_ethnic_Filterisrange);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("IncludeDataList", Ddo_view_lpi_br_demographics_ethnic_Includedatalist);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("DataListType", Ddo_view_lpi_br_demographics_ethnic_Datalisttype);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("DataListProc", Ddo_view_lpi_br_demographics_ethnic_Datalistproc);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("DataListUpdateMinimumCharacters", Ddo_view_lpi_br_demographics_ethnic_Datalistupdateminimumcharacters);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("SortASC", Ddo_view_lpi_br_demographics_ethnic_Sortasc);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("SortDSC", Ddo_view_lpi_br_demographics_ethnic_Sortdsc);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("LoadingData", Ddo_view_lpi_br_demographics_ethnic_Loadingdata);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("CleanFilter", Ddo_view_lpi_br_demographics_ethnic_Cleanfilter);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("NoResultsFound", Ddo_view_lpi_br_demographics_ethnic_Noresultsfound);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("SearchButtonText", Ddo_view_lpi_br_demographics_ethnic_Searchbuttontext);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_view_lpi_br_demographics_ethnic.SetProperty("DropDownOptionsData", AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData);
            ucDdo_view_lpi_br_demographics_ethnic.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_lpi_br_demographics_ethnic_Internalname, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'" + sGXsfl_68_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_lpi_br_demographics_ethnictitlecontrolidtoreplace_Internalname, AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,90);\"", 0, edtavDdo_view_lpi_br_demographics_ethnictitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationList.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'" + sGXsfl_68_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,92);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_InformationList.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'" + sGXsfl_68_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,93);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_InformationList.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'" + sGXsfl_68_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_lpi_br_information_patientno_Internalname, AV23TFVIEW_LPI_BR_Information_PatientNo, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,94);\"", 0, edtavTfview_lpi_br_information_patientno_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationList.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'" + sGXsfl_68_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_lpi_br_information_patientno_sel_Internalname, AV24TFVIEW_LPI_BR_Information_PatientNo_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,95);\"", 0, edtavTfview_lpi_br_information_patientno_sel_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationList.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'" + sGXsfl_68_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_lpi_br_demographics_sex_Internalname, AV27TFVIEW_LPI_BR_Demographics_Sex, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,96);\"", 0, edtavTfview_lpi_br_demographics_sex_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationList.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'" + sGXsfl_68_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_lpi_br_demographics_sex_sel_Internalname, AV28TFVIEW_LPI_BR_Demographics_Sex_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", 0, edtavTfview_lpi_br_demographics_sex_sel_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationList.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'" + sGXsfl_68_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfview_lpi_br_demographics_birthdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfview_lpi_br_demographics_birthdate_Internalname, context.localUtil.Format(AV31TFVIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"), context.localUtil.Format( AV31TFVIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,98);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_lpi_br_demographics_birthdate_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_lpi_br_demographics_birthdate_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_InformationList.htm");
            GxWebStd.gx_bitmap( context, edtavTfview_lpi_br_demographics_birthdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfview_lpi_br_demographics_birthdate_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_InformationList.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'" + sGXsfl_68_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfview_lpi_br_demographics_birthdate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfview_lpi_br_demographics_birthdate_to_Internalname, context.localUtil.Format(AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"), context.localUtil.Format( AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_lpi_br_demographics_birthdate_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_lpi_br_demographics_birthdate_to_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_InformationList.htm");
            GxWebStd.gx_bitmap( context, edtavTfview_lpi_br_demographics_birthdate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfview_lpi_br_demographics_birthdate_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_InformationList.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_view_lpi_br_demographics_birthdateauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'" + sGXsfl_68_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_view_lpi_br_demographics_birthdateauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_view_lpi_br_demographics_birthdateauxdate_Internalname, context.localUtil.Format(AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate, "9999/99/99"), context.localUtil.Format( AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,101);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_view_lpi_br_demographics_birthdateauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_InformationList.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_view_lpi_br_demographics_birthdateauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_InformationList.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'" + sGXsfl_68_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Internalname, context.localUtil.Format(AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo, "9999/99/99"), context.localUtil.Format( AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_InformationList.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_InformationList.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'" + sGXsfl_68_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_lpi_br_demographics_ethnic_Internalname, AV37TFVIEW_LPI_BR_Demographics_Ethnic, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", 0, edtavTfview_lpi_br_demographics_ethnic_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationList.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'" + sGXsfl_68_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_lpi_br_demographics_ethnic_sel_Internalname, AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,104);\"", 0, edtavTfview_lpi_br_demographics_ethnic_sel_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationList.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 68 )
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

      protected void STARTA02( )
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
         STRUPA00( ) ;
      }

      protected void WSA02( )
      {
         STARTA02( ) ;
         EVTA02( ) ;
      }

      protected void EVTA02( )
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
                              E11A02 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12A02 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13A02 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14A02 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15A02 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16A02 ();
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
                              nGXsfl_68_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx), 4, 0)), 4, "0");
                              SubsflControlProps_682( ) ;
                              AV45PatientReTenant = cgiGet( edtavPatientretenant_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPatientretenant_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV45PatientReTenant)) ? AV70Patientretenant_GXI : context.convertURL( context.PathToRelativeUrl( AV45PatientReTenant))), !bGXsfl_68_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPatientretenant_Internalname, "SrcSet", context.GetImageSrcSet( AV45PatientReTenant), true);
                              AV47Patient_Entity = cgiGet( edtavPatient_entity_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPatient_entity_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV47Patient_Entity)) ? AV71Patient_entity_GXI : context.convertURL( context.PathToRelativeUrl( AV47Patient_Entity))), !bGXsfl_68_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPatient_entity_Internalname, "SrcSet", context.GetImageSrcSet( AV47Patient_Entity), true);
                              A520VIEW_LPI_BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtVIEW_LPI_BR_Information_ID_Internalname), ".", ","));
                              A519VIEW_LPI_BR_Information_PatientNo = cgiGet( edtVIEW_LPI_BR_Information_PatientNo_Internalname);
                              A522VIEW_LPI_BR_Demographics_Sex = cgiGet( edtVIEW_LPI_BR_Demographics_Sex_Internalname);
                              A523VIEW_LPI_BR_Demographics_BirthDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtVIEW_LPI_BR_Demographics_BirthDate_Internalname), 0));
                              A524VIEW_LPI_BR_Demographics_Ethnic = cgiGet( edtVIEW_LPI_BR_Demographics_Ethnic_Internalname);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E17A02 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E18A02 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E19A02 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If View_lpi_br_information_patientno Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vVIEW_LPI_BR_INFORMATION_PATIENTNO"), AV15VIEW_LPI_BR_Information_PatientNo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If View_lpi_br_demographics_birthdateoperator Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR"), ".", ",") != Convert.ToDecimal( AV16VIEW_LPI_BR_Demographics_BirthDateOperator )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If View_lpi_br_demographics_birthdate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE"), 0) != AV18VIEW_LPI_BR_Demographics_BirthDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If View_lpi_br_demographics_birthdate_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO"), 0) != AV17VIEW_LPI_BR_Demographics_BirthDate_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If View_lpi_br_demographics_ethnic Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC"), AV19VIEW_LPI_BR_Demographics_Ethnic) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If View_lpi_br_demographics_sex Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_SEX"), AV20VIEW_LPI_BR_Demographics_Sex) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
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
                                       /* Set Refresh If Tfview_lpi_br_information_patientno Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_INFORMATION_PATIENTNO"), AV23TFVIEW_LPI_BR_Information_PatientNo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_lpi_br_information_patientno_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL"), AV24TFVIEW_LPI_BR_Information_PatientNo_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_lpi_br_demographics_sex Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX"), AV27TFVIEW_LPI_BR_Demographics_Sex) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_lpi_br_demographics_sex_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL"), AV28TFVIEW_LPI_BR_Demographics_Sex_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_lpi_br_demographics_birthdate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE"), 0) != AV31TFVIEW_LPI_BR_Demographics_BirthDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_lpi_br_demographics_birthdate_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO"), 0) != AV32TFVIEW_LPI_BR_Demographics_BirthDate_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_lpi_br_demographics_ethnic Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC"), AV37TFVIEW_LPI_BR_Demographics_Ethnic) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_lpi_br_demographics_ethnic_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL"), AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel) != 0 )
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

      protected void WEA02( )
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

      protected void PAA02( )
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
               GX_FocusControl = edtavView_lpi_br_information_patientno_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvVIEW_LPI_BR_DEMOGRAPHICS_ETHNICA02( String AV53tTenantCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_dataA02( AV53tTenantCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXVvVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_htmlA02( String AV53tTenantCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_dataA02( AV53tTenantCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavView_lpi_br_demographics_ethnic.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavView_lpi_br_demographics_ethnic.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_dataA02( String AV53tTenantCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H00A02 */
         pr_default.execute(0, new Object[] {AV53tTenantCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00A02_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00A02_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvVIEW_LPI_BR_DEMOGRAPHICS_SEXA02( String AV53tTenantCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVIEW_LPI_BR_DEMOGRAPHICS_SEX_dataA02( AV53tTenantCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXVvVIEW_LPI_BR_DEMOGRAPHICS_SEX_htmlA02( String AV53tTenantCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVIEW_LPI_BR_DEMOGRAPHICS_SEX_dataA02( AV53tTenantCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavView_lpi_br_demographics_sex.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavView_lpi_br_demographics_sex.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVIEW_LPI_BR_DEMOGRAPHICS_SEX_dataA02( String AV53tTenantCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H00A03 */
         pr_default.execute(1, new Object[] {AV53tTenantCode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00A03_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00A03_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_682( ) ;
         while ( nGXsfl_68_idx <= nRC_GXsfl_68 )
         {
            sendrow_682( ) ;
            nGXsfl_68_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_68_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_68_idx+1));
            sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx), 4, 0)), 4, "0");
            SubsflControlProps_682( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV15VIEW_LPI_BR_Information_PatientNo ,
                                       short AV16VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                       DateTime AV18VIEW_LPI_BR_Demographics_BirthDate ,
                                       DateTime AV17VIEW_LPI_BR_Demographics_BirthDate_To ,
                                       String AV19VIEW_LPI_BR_Demographics_Ethnic ,
                                       String AV20VIEW_LPI_BR_Demographics_Sex ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       String AV23TFVIEW_LPI_BR_Information_PatientNo ,
                                       String AV24TFVIEW_LPI_BR_Information_PatientNo_Sel ,
                                       String AV27TFVIEW_LPI_BR_Demographics_Sex ,
                                       String AV28TFVIEW_LPI_BR_Demographics_Sex_Sel ,
                                       DateTime AV31TFVIEW_LPI_BR_Demographics_BirthDate ,
                                       DateTime AV32TFVIEW_LPI_BR_Demographics_BirthDate_To ,
                                       String AV37TFVIEW_LPI_BR_Demographics_Ethnic ,
                                       String AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel ,
                                       String AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace ,
                                       String AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace ,
                                       String AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace ,
                                       String AV72Pgmname ,
                                       bool AV46IsAuthorized_PatientReTenant ,
                                       bool AV48IsAuthorized_Patient_Entity )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RFA02( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_VIEW_LPI_BR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A520VIEW_LPI_BR_Information_ID), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "VIEW_LPI_BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0, ".", "")));
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
         if ( cmbavView_lpi_br_demographics_birthdateoperator.ItemCount > 0 )
         {
            AV16VIEW_LPI_BR_Demographics_BirthDateOperator = (short)(NumberUtil.Val( cmbavView_lpi_br_demographics_birthdateoperator.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV16VIEW_LPI_BR_Demographics_BirthDateOperator), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16VIEW_LPI_BR_Demographics_BirthDateOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16VIEW_LPI_BR_Demographics_BirthDateOperator), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavView_lpi_br_demographics_birthdateoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV16VIEW_LPI_BR_Demographics_BirthDateOperator), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavView_lpi_br_demographics_birthdateoperator_Internalname, "Values", cmbavView_lpi_br_demographics_birthdateoperator.ToJavascriptSource(), true);
         }
         if ( dynavView_lpi_br_demographics_ethnic.ItemCount > 0 )
         {
            AV19VIEW_LPI_BR_Demographics_Ethnic = dynavView_lpi_br_demographics_ethnic.getValidValue(AV19VIEW_LPI_BR_Demographics_Ethnic);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19VIEW_LPI_BR_Demographics_Ethnic", AV19VIEW_LPI_BR_Demographics_Ethnic);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavView_lpi_br_demographics_ethnic.CurrentValue = StringUtil.RTrim( AV19VIEW_LPI_BR_Demographics_Ethnic);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavView_lpi_br_demographics_ethnic_Internalname, "Values", dynavView_lpi_br_demographics_ethnic.ToJavascriptSource(), true);
         }
         if ( dynavView_lpi_br_demographics_sex.ItemCount > 0 )
         {
            AV20VIEW_LPI_BR_Demographics_Sex = dynavView_lpi_br_demographics_sex.getValidValue(AV20VIEW_LPI_BR_Demographics_Sex);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20VIEW_LPI_BR_Demographics_Sex", AV20VIEW_LPI_BR_Demographics_Sex);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavView_lpi_br_demographics_sex.CurrentValue = StringUtil.RTrim( AV20VIEW_LPI_BR_Demographics_Sex);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavView_lpi_br_demographics_sex_Internalname, "Values", dynavView_lpi_br_demographics_sex.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RFA02( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV72Pgmname = "BR_InformationList";
         context.Gx_err = 0;
      }

      protected void RFA02( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 68;
         /* Execute user event: Refresh */
         E18A02 ();
         nGXsfl_68_idx = 1;
         sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx), 4, 0)), 4, "0");
         SubsflControlProps_682( ) ;
         bGXsfl_68_Refreshing = true;
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
            SubsflControlProps_682( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(2, new Object[]{ new Object[]{
                                                 A520VIEW_LPI_BR_Information_ID ,
                                                 AV51oBR_Information_ID ,
                                                 AV57BR_InformationListDS_1_View_lpi_br_information_patientno ,
                                                 AV16VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                                 AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate ,
                                                 AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ,
                                                 AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic ,
                                                 AV61BR_InformationListDS_5_View_lpi_br_demographics_sex ,
                                                 AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ,
                                                 AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno ,
                                                 AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ,
                                                 AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ,
                                                 AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ,
                                                 AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ,
                                                 AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ,
                                                 AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ,
                                                 A519VIEW_LPI_BR_Information_PatientNo ,
                                                 A523VIEW_LPI_BR_Demographics_BirthDate ,
                                                 A524VIEW_LPI_BR_Demographics_Ethnic ,
                                                 A522VIEW_LPI_BR_Demographics_Sex ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT,
                                                 TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV57BR_InformationListDS_1_View_lpi_br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV57BR_InformationListDS_1_View_lpi_br_information_patientno), "%", "");
            lV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno), "%", "");
            lV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex), "%", "");
            lV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic), "%", "");
            /* Using cursor H00A04 */
            pr_default.execute(2, new Object[] {lV57BR_InformationListDS_1_View_lpi_br_information_patientno, AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate, AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to, AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic, AV61BR_InformationListDS_5_View_lpi_br_demographics_sex, lV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno, AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel, lV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex, AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel, AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate, AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to, lV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic, AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_68_idx = 1;
            sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx), 4, 0)), 4, "0");
            SubsflControlProps_682( ) ;
            while ( ( (pr_default.getStatus(2) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A524VIEW_LPI_BR_Demographics_Ethnic = H00A04_A524VIEW_LPI_BR_Demographics_Ethnic[0];
               A523VIEW_LPI_BR_Demographics_BirthDate = H00A04_A523VIEW_LPI_BR_Demographics_BirthDate[0];
               A522VIEW_LPI_BR_Demographics_Sex = H00A04_A522VIEW_LPI_BR_Demographics_Sex[0];
               A519VIEW_LPI_BR_Information_PatientNo = H00A04_A519VIEW_LPI_BR_Information_PatientNo[0];
               A520VIEW_LPI_BR_Information_ID = H00A04_A520VIEW_LPI_BR_Information_ID[0];
               E19A02 ();
               pr_default.readNext(2);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(2) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(2);
            wbEnd = 68;
            WBA00( ) ;
         }
         bGXsfl_68_Refreshing = true;
      }

      protected void send_integrity_lvl_hashesA02( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_VIEW_LPI_BR_INFORMATION_ID"+"_"+sGXsfl_68_idx, GetSecureSignedToken( sGXsfl_68_idx, context.localUtil.Format( (decimal)(A520VIEW_LPI_BR_Information_ID), "ZZZZZZZZZZZZZZZZZ9"), context));
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
         AV57BR_InformationListDS_1_View_lpi_br_information_patientno = AV15VIEW_LPI_BR_Information_PatientNo;
         AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate = AV18VIEW_LPI_BR_Demographics_BirthDate;
         AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = AV17VIEW_LPI_BR_Demographics_BirthDate_To;
         AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic = AV19VIEW_LPI_BR_Demographics_Ethnic;
         AV61BR_InformationListDS_5_View_lpi_br_demographics_sex = AV20VIEW_LPI_BR_Demographics_Sex;
         AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = AV23TFVIEW_LPI_BR_Information_PatientNo;
         AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = AV24TFVIEW_LPI_BR_Information_PatientNo_Sel;
         AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = AV27TFVIEW_LPI_BR_Demographics_Sex;
         AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = AV28TFVIEW_LPI_BR_Demographics_Sex_Sel;
         AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = AV31TFVIEW_LPI_BR_Demographics_BirthDate;
         AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = AV32TFVIEW_LPI_BR_Demographics_BirthDate_To;
         AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = AV37TFVIEW_LPI_BR_Demographics_Ethnic;
         AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              A520VIEW_LPI_BR_Information_ID ,
                                              AV51oBR_Information_ID ,
                                              AV57BR_InformationListDS_1_View_lpi_br_information_patientno ,
                                              AV16VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                              AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate ,
                                              AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ,
                                              AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic ,
                                              AV61BR_InformationListDS_5_View_lpi_br_demographics_sex ,
                                              AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ,
                                              AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno ,
                                              AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ,
                                              AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ,
                                              AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ,
                                              AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ,
                                              AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ,
                                              AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ,
                                              A519VIEW_LPI_BR_Information_PatientNo ,
                                              A523VIEW_LPI_BR_Demographics_BirthDate ,
                                              A524VIEW_LPI_BR_Demographics_Ethnic ,
                                              A522VIEW_LPI_BR_Demographics_Sex ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV57BR_InformationListDS_1_View_lpi_br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV57BR_InformationListDS_1_View_lpi_br_information_patientno), "%", "");
         lV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno), "%", "");
         lV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex), "%", "");
         lV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic), "%", "");
         /* Using cursor H00A05 */
         pr_default.execute(3, new Object[] {lV57BR_InformationListDS_1_View_lpi_br_information_patientno, AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate, AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to, AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic, AV61BR_InformationListDS_5_View_lpi_br_demographics_sex, lV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno, AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel, lV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex, AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel, AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate, AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to, lV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic, AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel});
         GRID_nRecordCount = H00A05_AGRID_nRecordCount[0];
         pr_default.close(3);
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
         AV57BR_InformationListDS_1_View_lpi_br_information_patientno = AV15VIEW_LPI_BR_Information_PatientNo;
         AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate = AV18VIEW_LPI_BR_Demographics_BirthDate;
         AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = AV17VIEW_LPI_BR_Demographics_BirthDate_To;
         AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic = AV19VIEW_LPI_BR_Demographics_Ethnic;
         AV61BR_InformationListDS_5_View_lpi_br_demographics_sex = AV20VIEW_LPI_BR_Demographics_Sex;
         AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = AV23TFVIEW_LPI_BR_Information_PatientNo;
         AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = AV24TFVIEW_LPI_BR_Information_PatientNo_Sel;
         AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = AV27TFVIEW_LPI_BR_Demographics_Sex;
         AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = AV28TFVIEW_LPI_BR_Demographics_Sex_Sel;
         AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = AV31TFVIEW_LPI_BR_Demographics_BirthDate;
         AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = AV32TFVIEW_LPI_BR_Demographics_BirthDate_To;
         AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = AV37TFVIEW_LPI_BR_Demographics_Ethnic;
         AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV15VIEW_LPI_BR_Information_PatientNo, AV16VIEW_LPI_BR_Demographics_BirthDateOperator, AV18VIEW_LPI_BR_Demographics_BirthDate, AV17VIEW_LPI_BR_Demographics_BirthDate_To, AV19VIEW_LPI_BR_Demographics_Ethnic, AV20VIEW_LPI_BR_Demographics_Sex, AV13OrderedBy, AV14OrderedDsc, AV23TFVIEW_LPI_BR_Information_PatientNo, AV24TFVIEW_LPI_BR_Information_PatientNo_Sel, AV27TFVIEW_LPI_BR_Demographics_Sex, AV28TFVIEW_LPI_BR_Demographics_Sex_Sel, AV31TFVIEW_LPI_BR_Demographics_BirthDate, AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, AV37TFVIEW_LPI_BR_Demographics_Ethnic, AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel, AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace, AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace, AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace, AV72Pgmname, AV46IsAuthorized_PatientReTenant, AV48IsAuthorized_Patient_Entity) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV57BR_InformationListDS_1_View_lpi_br_information_patientno = AV15VIEW_LPI_BR_Information_PatientNo;
         AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate = AV18VIEW_LPI_BR_Demographics_BirthDate;
         AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = AV17VIEW_LPI_BR_Demographics_BirthDate_To;
         AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic = AV19VIEW_LPI_BR_Demographics_Ethnic;
         AV61BR_InformationListDS_5_View_lpi_br_demographics_sex = AV20VIEW_LPI_BR_Demographics_Sex;
         AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = AV23TFVIEW_LPI_BR_Information_PatientNo;
         AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = AV24TFVIEW_LPI_BR_Information_PatientNo_Sel;
         AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = AV27TFVIEW_LPI_BR_Demographics_Sex;
         AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = AV28TFVIEW_LPI_BR_Demographics_Sex_Sel;
         AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = AV31TFVIEW_LPI_BR_Demographics_BirthDate;
         AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = AV32TFVIEW_LPI_BR_Demographics_BirthDate_To;
         AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = AV37TFVIEW_LPI_BR_Demographics_Ethnic;
         AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV15VIEW_LPI_BR_Information_PatientNo, AV16VIEW_LPI_BR_Demographics_BirthDateOperator, AV18VIEW_LPI_BR_Demographics_BirthDate, AV17VIEW_LPI_BR_Demographics_BirthDate_To, AV19VIEW_LPI_BR_Demographics_Ethnic, AV20VIEW_LPI_BR_Demographics_Sex, AV13OrderedBy, AV14OrderedDsc, AV23TFVIEW_LPI_BR_Information_PatientNo, AV24TFVIEW_LPI_BR_Information_PatientNo_Sel, AV27TFVIEW_LPI_BR_Demographics_Sex, AV28TFVIEW_LPI_BR_Demographics_Sex_Sel, AV31TFVIEW_LPI_BR_Demographics_BirthDate, AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, AV37TFVIEW_LPI_BR_Demographics_Ethnic, AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel, AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace, AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace, AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace, AV72Pgmname, AV46IsAuthorized_PatientReTenant, AV48IsAuthorized_Patient_Entity) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV57BR_InformationListDS_1_View_lpi_br_information_patientno = AV15VIEW_LPI_BR_Information_PatientNo;
         AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate = AV18VIEW_LPI_BR_Demographics_BirthDate;
         AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = AV17VIEW_LPI_BR_Demographics_BirthDate_To;
         AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic = AV19VIEW_LPI_BR_Demographics_Ethnic;
         AV61BR_InformationListDS_5_View_lpi_br_demographics_sex = AV20VIEW_LPI_BR_Demographics_Sex;
         AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = AV23TFVIEW_LPI_BR_Information_PatientNo;
         AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = AV24TFVIEW_LPI_BR_Information_PatientNo_Sel;
         AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = AV27TFVIEW_LPI_BR_Demographics_Sex;
         AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = AV28TFVIEW_LPI_BR_Demographics_Sex_Sel;
         AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = AV31TFVIEW_LPI_BR_Demographics_BirthDate;
         AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = AV32TFVIEW_LPI_BR_Demographics_BirthDate_To;
         AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = AV37TFVIEW_LPI_BR_Demographics_Ethnic;
         AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV15VIEW_LPI_BR_Information_PatientNo, AV16VIEW_LPI_BR_Demographics_BirthDateOperator, AV18VIEW_LPI_BR_Demographics_BirthDate, AV17VIEW_LPI_BR_Demographics_BirthDate_To, AV19VIEW_LPI_BR_Demographics_Ethnic, AV20VIEW_LPI_BR_Demographics_Sex, AV13OrderedBy, AV14OrderedDsc, AV23TFVIEW_LPI_BR_Information_PatientNo, AV24TFVIEW_LPI_BR_Information_PatientNo_Sel, AV27TFVIEW_LPI_BR_Demographics_Sex, AV28TFVIEW_LPI_BR_Demographics_Sex_Sel, AV31TFVIEW_LPI_BR_Demographics_BirthDate, AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, AV37TFVIEW_LPI_BR_Demographics_Ethnic, AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel, AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace, AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace, AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace, AV72Pgmname, AV46IsAuthorized_PatientReTenant, AV48IsAuthorized_Patient_Entity) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV57BR_InformationListDS_1_View_lpi_br_information_patientno = AV15VIEW_LPI_BR_Information_PatientNo;
         AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate = AV18VIEW_LPI_BR_Demographics_BirthDate;
         AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = AV17VIEW_LPI_BR_Demographics_BirthDate_To;
         AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic = AV19VIEW_LPI_BR_Demographics_Ethnic;
         AV61BR_InformationListDS_5_View_lpi_br_demographics_sex = AV20VIEW_LPI_BR_Demographics_Sex;
         AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = AV23TFVIEW_LPI_BR_Information_PatientNo;
         AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = AV24TFVIEW_LPI_BR_Information_PatientNo_Sel;
         AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = AV27TFVIEW_LPI_BR_Demographics_Sex;
         AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = AV28TFVIEW_LPI_BR_Demographics_Sex_Sel;
         AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = AV31TFVIEW_LPI_BR_Demographics_BirthDate;
         AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = AV32TFVIEW_LPI_BR_Demographics_BirthDate_To;
         AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = AV37TFVIEW_LPI_BR_Demographics_Ethnic;
         AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV15VIEW_LPI_BR_Information_PatientNo, AV16VIEW_LPI_BR_Demographics_BirthDateOperator, AV18VIEW_LPI_BR_Demographics_BirthDate, AV17VIEW_LPI_BR_Demographics_BirthDate_To, AV19VIEW_LPI_BR_Demographics_Ethnic, AV20VIEW_LPI_BR_Demographics_Sex, AV13OrderedBy, AV14OrderedDsc, AV23TFVIEW_LPI_BR_Information_PatientNo, AV24TFVIEW_LPI_BR_Information_PatientNo_Sel, AV27TFVIEW_LPI_BR_Demographics_Sex, AV28TFVIEW_LPI_BR_Demographics_Sex_Sel, AV31TFVIEW_LPI_BR_Demographics_BirthDate, AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, AV37TFVIEW_LPI_BR_Demographics_Ethnic, AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel, AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace, AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace, AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace, AV72Pgmname, AV46IsAuthorized_PatientReTenant, AV48IsAuthorized_Patient_Entity) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV57BR_InformationListDS_1_View_lpi_br_information_patientno = AV15VIEW_LPI_BR_Information_PatientNo;
         AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate = AV18VIEW_LPI_BR_Demographics_BirthDate;
         AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = AV17VIEW_LPI_BR_Demographics_BirthDate_To;
         AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic = AV19VIEW_LPI_BR_Demographics_Ethnic;
         AV61BR_InformationListDS_5_View_lpi_br_demographics_sex = AV20VIEW_LPI_BR_Demographics_Sex;
         AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = AV23TFVIEW_LPI_BR_Information_PatientNo;
         AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = AV24TFVIEW_LPI_BR_Information_PatientNo_Sel;
         AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = AV27TFVIEW_LPI_BR_Demographics_Sex;
         AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = AV28TFVIEW_LPI_BR_Demographics_Sex_Sel;
         AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = AV31TFVIEW_LPI_BR_Demographics_BirthDate;
         AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = AV32TFVIEW_LPI_BR_Demographics_BirthDate_To;
         AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = AV37TFVIEW_LPI_BR_Demographics_Ethnic;
         AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV15VIEW_LPI_BR_Information_PatientNo, AV16VIEW_LPI_BR_Demographics_BirthDateOperator, AV18VIEW_LPI_BR_Demographics_BirthDate, AV17VIEW_LPI_BR_Demographics_BirthDate_To, AV19VIEW_LPI_BR_Demographics_Ethnic, AV20VIEW_LPI_BR_Demographics_Sex, AV13OrderedBy, AV14OrderedDsc, AV23TFVIEW_LPI_BR_Information_PatientNo, AV24TFVIEW_LPI_BR_Information_PatientNo_Sel, AV27TFVIEW_LPI_BR_Demographics_Sex, AV28TFVIEW_LPI_BR_Demographics_Sex_Sel, AV31TFVIEW_LPI_BR_Demographics_BirthDate, AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, AV37TFVIEW_LPI_BR_Demographics_Ethnic, AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel, AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace, AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace, AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace, AV72Pgmname, AV46IsAuthorized_PatientReTenant, AV48IsAuthorized_Patient_Entity) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUPA00( )
      {
         /* Before Start, stand alone formulas. */
         AV72Pgmname = "BR_InformationList";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E17A02 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVvVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_htmlA02( AV53tTenantCode) ;
         GXVvVIEW_LPI_BR_DEMOGRAPHICS_SEX_htmlA02( AV53tTenantCode) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV40DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA"), AV26VIEW_LPI_BR_Demographics_SexTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA"), AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA"), AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData);
            /* Read variables values. */
            AV15VIEW_LPI_BR_Information_PatientNo = cgiGet( edtavView_lpi_br_information_patientno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15VIEW_LPI_BR_Information_PatientNo", AV15VIEW_LPI_BR_Information_PatientNo);
            cmbavView_lpi_br_demographics_birthdateoperator.Name = cmbavView_lpi_br_demographics_birthdateoperator_Internalname;
            cmbavView_lpi_br_demographics_birthdateoperator.CurrentValue = cgiGet( cmbavView_lpi_br_demographics_birthdateoperator_Internalname);
            AV16VIEW_LPI_BR_Demographics_BirthDateOperator = (short)(NumberUtil.Val( cgiGet( cmbavView_lpi_br_demographics_birthdateoperator_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16VIEW_LPI_BR_Demographics_BirthDateOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16VIEW_LPI_BR_Demographics_BirthDateOperator), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavView_lpi_br_demographics_birthdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"VIEW_LPI_BR_Demographics_Birth Date"}), 1, "vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE");
               GX_FocusControl = edtavView_lpi_br_demographics_birthdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18VIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(AV18VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
            }
            else
            {
               AV18VIEW_LPI_BR_Demographics_BirthDate = context.localUtil.CToD( cgiGet( edtavView_lpi_br_demographics_birthdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18VIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(AV18VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavView_lpi_br_demographics_birthdate_to_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"VIEW_LPI_BR_Demographics_Birth Date_To"}), 1, "vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO");
               GX_FocusControl = edtavView_lpi_br_demographics_birthdate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17VIEW_LPI_BR_Demographics_BirthDate_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17VIEW_LPI_BR_Demographics_BirthDate_To", context.localUtil.Format(AV17VIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"));
            }
            else
            {
               AV17VIEW_LPI_BR_Demographics_BirthDate_To = context.localUtil.CToD( cgiGet( edtavView_lpi_br_demographics_birthdate_to_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17VIEW_LPI_BR_Demographics_BirthDate_To", context.localUtil.Format(AV17VIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"));
            }
            dynavView_lpi_br_demographics_ethnic.Name = dynavView_lpi_br_demographics_ethnic_Internalname;
            dynavView_lpi_br_demographics_ethnic.CurrentValue = cgiGet( dynavView_lpi_br_demographics_ethnic_Internalname);
            AV19VIEW_LPI_BR_Demographics_Ethnic = cgiGet( dynavView_lpi_br_demographics_ethnic_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19VIEW_LPI_BR_Demographics_Ethnic", AV19VIEW_LPI_BR_Demographics_Ethnic);
            dynavView_lpi_br_demographics_sex.Name = dynavView_lpi_br_demographics_sex_Internalname;
            dynavView_lpi_br_demographics_sex.CurrentValue = cgiGet( dynavView_lpi_br_demographics_sex_Internalname);
            AV20VIEW_LPI_BR_Demographics_Sex = cgiGet( dynavView_lpi_br_demographics_sex_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20VIEW_LPI_BR_Demographics_Sex", AV20VIEW_LPI_BR_Demographics_Sex);
            AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_view_lpi_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace", AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace);
            AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace = cgiGet( edtavDdo_view_lpi_br_demographics_sextitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace", AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace);
            AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace = cgiGet( edtavDdo_view_lpi_br_demographics_birthdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace", AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace);
            AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace = cgiGet( edtavDdo_view_lpi_br_demographics_ethnictitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace", AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace);
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
            AV23TFVIEW_LPI_BR_Information_PatientNo = cgiGet( edtavTfview_lpi_br_information_patientno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23TFVIEW_LPI_BR_Information_PatientNo", AV23TFVIEW_LPI_BR_Information_PatientNo);
            AV24TFVIEW_LPI_BR_Information_PatientNo_Sel = cgiGet( edtavTfview_lpi_br_information_patientno_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24TFVIEW_LPI_BR_Information_PatientNo_Sel", AV24TFVIEW_LPI_BR_Information_PatientNo_Sel);
            AV27TFVIEW_LPI_BR_Demographics_Sex = cgiGet( edtavTfview_lpi_br_demographics_sex_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27TFVIEW_LPI_BR_Demographics_Sex", AV27TFVIEW_LPI_BR_Demographics_Sex);
            AV28TFVIEW_LPI_BR_Demographics_Sex_Sel = cgiGet( edtavTfview_lpi_br_demographics_sex_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28TFVIEW_LPI_BR_Demographics_Sex_Sel", AV28TFVIEW_LPI_BR_Demographics_Sex_Sel);
            if ( context.localUtil.VCDate( cgiGet( edtavTfview_lpi_br_demographics_birthdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFVIEW_LPI_BR_Demographics_Birth Date"}), 1, "vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE");
               GX_FocusControl = edtavTfview_lpi_br_demographics_birthdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV31TFVIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31TFVIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(AV31TFVIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
            }
            else
            {
               AV31TFVIEW_LPI_BR_Demographics_BirthDate = context.localUtil.CToD( cgiGet( edtavTfview_lpi_br_demographics_birthdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31TFVIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(AV31TFVIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfview_lpi_br_demographics_birthdate_to_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFVIEW_LPI_BR_Demographics_Birth Date_To"}), 1, "vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO");
               GX_FocusControl = edtavTfview_lpi_br_demographics_birthdate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV32TFVIEW_LPI_BR_Demographics_BirthDate_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32TFVIEW_LPI_BR_Demographics_BirthDate_To", context.localUtil.Format(AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"));
            }
            else
            {
               AV32TFVIEW_LPI_BR_Demographics_BirthDate_To = context.localUtil.CToD( cgiGet( edtavTfview_lpi_br_demographics_birthdate_to_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32TFVIEW_LPI_BR_Demographics_BirthDate_To", context.localUtil.Format(AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_view_lpi_br_demographics_birthdateauxdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_VIEW_LPI_BR_Demographics_Birth Date Aux Date"}), 1, "vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATE");
               GX_FocusControl = edtavDdo_view_lpi_br_demographics_birthdateauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate", context.localUtil.Format(AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate, "9999/99/99"));
            }
            else
            {
               AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_view_lpi_br_demographics_birthdateauxdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate", context.localUtil.Format(AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_VIEW_LPI_BR_Demographics_Birth Date Aux Date To"}), 1, "vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATETO");
               GX_FocusControl = edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo", context.localUtil.Format(AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo, "9999/99/99"));
            }
            else
            {
               AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo", context.localUtil.Format(AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo, "9999/99/99"));
            }
            AV37TFVIEW_LPI_BR_Demographics_Ethnic = cgiGet( edtavTfview_lpi_br_demographics_ethnic_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFVIEW_LPI_BR_Demographics_Ethnic", AV37TFVIEW_LPI_BR_Demographics_Ethnic);
            AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel = cgiGet( edtavTfview_lpi_br_demographics_ethnic_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel", AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel);
            /* Read saved values. */
            nRC_GXsfl_68 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_68"), ".", ","));
            AV42GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV44GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV43GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_view_lpi_br_information_patientno_Caption = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Caption");
            Ddo_view_lpi_br_information_patientno_Tooltip = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Tooltip");
            Ddo_view_lpi_br_information_patientno_Cls = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Cls");
            Ddo_view_lpi_br_information_patientno_Filteredtext_set = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Filteredtext_set");
            Ddo_view_lpi_br_information_patientno_Selectedvalue_set = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Selectedvalue_set");
            Ddo_view_lpi_br_information_patientno_Dropdownoptionstype = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Dropdownoptionstype");
            Ddo_view_lpi_br_information_patientno_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace");
            Ddo_view_lpi_br_information_patientno_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Includesortasc"));
            Ddo_view_lpi_br_information_patientno_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Includesortdsc"));
            Ddo_view_lpi_br_information_patientno_Sortedstatus = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Sortedstatus");
            Ddo_view_lpi_br_information_patientno_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Includefilter"));
            Ddo_view_lpi_br_information_patientno_Filtertype = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Filtertype");
            Ddo_view_lpi_br_information_patientno_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Filterisrange"));
            Ddo_view_lpi_br_information_patientno_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Includedatalist"));
            Ddo_view_lpi_br_information_patientno_Datalisttype = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Datalisttype");
            Ddo_view_lpi_br_information_patientno_Datalistproc = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Datalistproc");
            Ddo_view_lpi_br_information_patientno_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_view_lpi_br_information_patientno_Sortasc = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Sortasc");
            Ddo_view_lpi_br_information_patientno_Sortdsc = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Sortdsc");
            Ddo_view_lpi_br_information_patientno_Loadingdata = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Loadingdata");
            Ddo_view_lpi_br_information_patientno_Cleanfilter = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Cleanfilter");
            Ddo_view_lpi_br_information_patientno_Noresultsfound = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Noresultsfound");
            Ddo_view_lpi_br_information_patientno_Searchbuttontext = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Searchbuttontext");
            Ddo_view_lpi_br_demographics_sex_Caption = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Caption");
            Ddo_view_lpi_br_demographics_sex_Tooltip = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Tooltip");
            Ddo_view_lpi_br_demographics_sex_Cls = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Cls");
            Ddo_view_lpi_br_demographics_sex_Filteredtext_set = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Filteredtext_set");
            Ddo_view_lpi_br_demographics_sex_Selectedvalue_set = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Selectedvalue_set");
            Ddo_view_lpi_br_demographics_sex_Dropdownoptionstype = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Dropdownoptionstype");
            Ddo_view_lpi_br_demographics_sex_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Titlecontrolidtoreplace");
            Ddo_view_lpi_br_demographics_sex_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Includesortasc"));
            Ddo_view_lpi_br_demographics_sex_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Includesortdsc"));
            Ddo_view_lpi_br_demographics_sex_Sortedstatus = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Sortedstatus");
            Ddo_view_lpi_br_demographics_sex_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Includefilter"));
            Ddo_view_lpi_br_demographics_sex_Filtertype = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Filtertype");
            Ddo_view_lpi_br_demographics_sex_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Filterisrange"));
            Ddo_view_lpi_br_demographics_sex_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Includedatalist"));
            Ddo_view_lpi_br_demographics_sex_Datalisttype = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Datalisttype");
            Ddo_view_lpi_br_demographics_sex_Datalistproc = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Datalistproc");
            Ddo_view_lpi_br_demographics_sex_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_view_lpi_br_demographics_sex_Sortasc = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Sortasc");
            Ddo_view_lpi_br_demographics_sex_Sortdsc = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Sortdsc");
            Ddo_view_lpi_br_demographics_sex_Loadingdata = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Loadingdata");
            Ddo_view_lpi_br_demographics_sex_Cleanfilter = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Cleanfilter");
            Ddo_view_lpi_br_demographics_sex_Noresultsfound = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Noresultsfound");
            Ddo_view_lpi_br_demographics_sex_Searchbuttontext = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Searchbuttontext");
            Ddo_view_lpi_br_demographics_birthdate_Caption = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Caption");
            Ddo_view_lpi_br_demographics_birthdate_Tooltip = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Tooltip");
            Ddo_view_lpi_br_demographics_birthdate_Cls = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Cls");
            Ddo_view_lpi_br_demographics_birthdate_Filteredtext_set = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filteredtext_set");
            Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_set = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filteredtextto_set");
            Ddo_view_lpi_br_demographics_birthdate_Dropdownoptionstype = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Dropdownoptionstype");
            Ddo_view_lpi_br_demographics_birthdate_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Titlecontrolidtoreplace");
            Ddo_view_lpi_br_demographics_birthdate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Includesortasc"));
            Ddo_view_lpi_br_demographics_birthdate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Includesortdsc"));
            Ddo_view_lpi_br_demographics_birthdate_Sortedstatus = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Sortedstatus");
            Ddo_view_lpi_br_demographics_birthdate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Includefilter"));
            Ddo_view_lpi_br_demographics_birthdate_Filtertype = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filtertype");
            Ddo_view_lpi_br_demographics_birthdate_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filterisrange"));
            Ddo_view_lpi_br_demographics_birthdate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Includedatalist"));
            Ddo_view_lpi_br_demographics_birthdate_Sortasc = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Sortasc");
            Ddo_view_lpi_br_demographics_birthdate_Sortdsc = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Sortdsc");
            Ddo_view_lpi_br_demographics_birthdate_Cleanfilter = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Cleanfilter");
            Ddo_view_lpi_br_demographics_birthdate_Rangefilterfrom = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Rangefilterfrom");
            Ddo_view_lpi_br_demographics_birthdate_Rangefilterto = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Rangefilterto");
            Ddo_view_lpi_br_demographics_birthdate_Searchbuttontext = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Searchbuttontext");
            Ddo_view_lpi_br_demographics_ethnic_Caption = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Caption");
            Ddo_view_lpi_br_demographics_ethnic_Tooltip = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Tooltip");
            Ddo_view_lpi_br_demographics_ethnic_Cls = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Cls");
            Ddo_view_lpi_br_demographics_ethnic_Filteredtext_set = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Filteredtext_set");
            Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_set = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Selectedvalue_set");
            Ddo_view_lpi_br_demographics_ethnic_Dropdownoptionstype = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Dropdownoptionstype");
            Ddo_view_lpi_br_demographics_ethnic_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Titlecontrolidtoreplace");
            Ddo_view_lpi_br_demographics_ethnic_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Includesortasc"));
            Ddo_view_lpi_br_demographics_ethnic_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Includesortdsc"));
            Ddo_view_lpi_br_demographics_ethnic_Sortedstatus = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Sortedstatus");
            Ddo_view_lpi_br_demographics_ethnic_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Includefilter"));
            Ddo_view_lpi_br_demographics_ethnic_Filtertype = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Filtertype");
            Ddo_view_lpi_br_demographics_ethnic_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Filterisrange"));
            Ddo_view_lpi_br_demographics_ethnic_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Includedatalist"));
            Ddo_view_lpi_br_demographics_ethnic_Datalisttype = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Datalisttype");
            Ddo_view_lpi_br_demographics_ethnic_Datalistproc = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Datalistproc");
            Ddo_view_lpi_br_demographics_ethnic_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_view_lpi_br_demographics_ethnic_Sortasc = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Sortasc");
            Ddo_view_lpi_br_demographics_ethnic_Sortdsc = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Sortdsc");
            Ddo_view_lpi_br_demographics_ethnic_Loadingdata = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Loadingdata");
            Ddo_view_lpi_br_demographics_ethnic_Cleanfilter = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Cleanfilter");
            Ddo_view_lpi_br_demographics_ethnic_Noresultsfound = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Noresultsfound");
            Ddo_view_lpi_br_demographics_ethnic_Searchbuttontext = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_view_lpi_br_information_patientno_Activeeventkey = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_view_lpi_br_information_patientno_Filteredtext_get = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Filteredtext_get");
            Ddo_view_lpi_br_information_patientno_Selectedvalue_get = cgiGet( "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO_Selectedvalue_get");
            Ddo_view_lpi_br_demographics_sex_Activeeventkey = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Activeeventkey");
            Ddo_view_lpi_br_demographics_sex_Filteredtext_get = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Filteredtext_get");
            Ddo_view_lpi_br_demographics_sex_Selectedvalue_get = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX_Selectedvalue_get");
            Ddo_view_lpi_br_demographics_birthdate_Activeeventkey = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Activeeventkey");
            Ddo_view_lpi_br_demographics_birthdate_Filteredtext_get = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filteredtext_get");
            Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_get = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_Filteredtextto_get");
            Ddo_view_lpi_br_demographics_ethnic_Activeeventkey = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Activeeventkey");
            Ddo_view_lpi_br_demographics_ethnic_Filteredtext_get = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Filteredtext_get");
            Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_get = cgiGet( "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_Selectedvalue_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vVIEW_LPI_BR_INFORMATION_PATIENTNO"), AV15VIEW_LPI_BR_Information_PatientNo) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR"), ".", ",") != Convert.ToDecimal( AV16VIEW_LPI_BR_Demographics_BirthDateOperator )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE"), 0) != AV18VIEW_LPI_BR_Demographics_BirthDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO"), 0) != AV17VIEW_LPI_BR_Demographics_BirthDate_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC"), AV19VIEW_LPI_BR_Demographics_Ethnic) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vVIEW_LPI_BR_DEMOGRAPHICS_SEX"), AV20VIEW_LPI_BR_Demographics_Sex) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_INFORMATION_PATIENTNO"), AV23TFVIEW_LPI_BR_Information_PatientNo) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL"), AV24TFVIEW_LPI_BR_Information_PatientNo_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX"), AV27TFVIEW_LPI_BR_Demographics_Sex) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL"), AV28TFVIEW_LPI_BR_Demographics_Sex_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE"), 0) != AV31TFVIEW_LPI_BR_Demographics_BirthDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO"), 0) != AV32TFVIEW_LPI_BR_Demographics_BirthDate_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC"), AV37TFVIEW_LPI_BR_Demographics_Ethnic) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL"), AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel) != 0 )
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
         E17A02 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E17A02( )
      {
         /* Start Routine */
         GXt_boolean1 = AV49IsManager;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
         AV49IsManager = GXt_boolean1;
         if ( ! AV49IsManager )
         {
            GXt_boolean1 = AV49IsManager;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_ReadOnlyer", out  GXt_boolean1) ;
            AV49IsManager = GXt_boolean1;
            if ( ! AV49IsManager )
            {
               GXt_boolean1 = AV49IsManager;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_AllManager", out  GXt_boolean1) ;
               AV49IsManager = GXt_boolean1;
            }
         }
         GXt_char2 = AV50tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char2) ;
         AV50tCurrentCode = GXt_char2;
         GXt_objcol_int3 = AV51oBR_Information_ID;
         new zbr_checkinfoifincode(context ).execute(  AV50tCurrentCode,  AV49IsManager, out  GXt_objcol_int3) ;
         AV51oBR_Information_ID = GXt_objcol_int3;
         AV21Session.Set("BR_InformationView_Return", "BR_InformationList");
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfview_lpi_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_lpi_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_lpi_br_information_patientno_Visible), 5, 0)), true);
         edtavTfview_lpi_br_information_patientno_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_lpi_br_information_patientno_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_lpi_br_information_patientno_sel_Visible), 5, 0)), true);
         edtavTfview_lpi_br_demographics_sex_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_lpi_br_demographics_sex_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_lpi_br_demographics_sex_Visible), 5, 0)), true);
         edtavTfview_lpi_br_demographics_sex_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_lpi_br_demographics_sex_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_lpi_br_demographics_sex_sel_Visible), 5, 0)), true);
         edtavTfview_lpi_br_demographics_birthdate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_lpi_br_demographics_birthdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_lpi_br_demographics_birthdate_Visible), 5, 0)), true);
         edtavTfview_lpi_br_demographics_birthdate_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_lpi_br_demographics_birthdate_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_lpi_br_demographics_birthdate_to_Visible), 5, 0)), true);
         edtavTfview_lpi_br_demographics_ethnic_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_lpi_br_demographics_ethnic_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_lpi_br_demographics_ethnic_Visible), 5, 0)), true);
         edtavTfview_lpi_br_demographics_ethnic_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_lpi_br_demographics_ethnic_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_lpi_br_demographics_ethnic_sel_Visible), 5, 0)), true);
         Ddo_view_lpi_br_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_VIEW_LPI_BR_Information_PatientNo";
         ucDdo_view_lpi_br_information_patientno.SendProperty(context, "", false, Ddo_view_lpi_br_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_view_lpi_br_information_patientno_Titlecontrolidtoreplace);
         AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace = Ddo_view_lpi_br_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace", AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_view_lpi_br_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_lpi_br_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_lpi_br_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_lpi_br_demographics_sex_Titlecontrolidtoreplace = subGrid_Internalname+"_VIEW_LPI_BR_Demographics_Sex";
         ucDdo_view_lpi_br_demographics_sex.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_sex_Internalname, "TitleControlIdToReplace", Ddo_view_lpi_br_demographics_sex_Titlecontrolidtoreplace);
         AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace = Ddo_view_lpi_br_demographics_sex_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace", AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace);
         edtavDdo_view_lpi_br_demographics_sextitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_lpi_br_demographics_sextitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_lpi_br_demographics_sextitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_lpi_br_demographics_birthdate_Titlecontrolidtoreplace = subGrid_Internalname+"_VIEW_LPI_BR_Demographics_BirthDate";
         ucDdo_view_lpi_br_demographics_birthdate.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_birthdate_Internalname, "TitleControlIdToReplace", Ddo_view_lpi_br_demographics_birthdate_Titlecontrolidtoreplace);
         AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace = Ddo_view_lpi_br_demographics_birthdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace", AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace);
         edtavDdo_view_lpi_br_demographics_birthdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_lpi_br_demographics_birthdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_lpi_br_demographics_birthdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_lpi_br_demographics_ethnic_Titlecontrolidtoreplace = subGrid_Internalname+"_VIEW_LPI_BR_Demographics_Ethnic";
         ucDdo_view_lpi_br_demographics_ethnic.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_ethnic_Internalname, "TitleControlIdToReplace", Ddo_view_lpi_br_demographics_ethnic_Titlecontrolidtoreplace);
         AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace = Ddo_view_lpi_br_demographics_ethnic_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace", AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace);
         edtavDdo_view_lpi_br_demographics_ethnictitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_lpi_br_demographics_ethnictitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_lpi_br_demographics_ethnictitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "Data Mgmt Portal - RAAP";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons4 = AV40DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons4) ;
         AV40DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons4;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         AV53tTenantCode = AV50tCurrentCode;
      }

      protected void E18A02( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         GXt_boolean1 = AV49IsManager;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
         AV49IsManager = GXt_boolean1;
         if ( ! AV49IsManager )
         {
            GXt_boolean1 = AV49IsManager;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_ReadOnlyer", out  GXt_boolean1) ;
            AV49IsManager = GXt_boolean1;
            if ( ! AV49IsManager )
            {
               GXt_boolean1 = AV49IsManager;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_AllManager", out  GXt_boolean1) ;
               AV49IsManager = GXt_boolean1;
            }
         }
         GXt_char2 = AV50tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char2) ;
         AV50tCurrentCode = GXt_char2;
         GXt_objcol_int3 = AV51oBR_Information_ID;
         new zbr_checkinfoifincode(context ).execute(  AV50tCurrentCode,  AV49IsManager, out  GXt_objcol_int3) ;
         AV51oBR_Information_ID = GXt_objcol_int3;
         AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26VIEW_LPI_BR_Demographics_SexTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtVIEW_LPI_BR_Information_PatientNo_Titleformat = 2;
         edtVIEW_LPI_BR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVIEW_LPI_BR_Information_PatientNo_Internalname, "Title", edtVIEW_LPI_BR_Information_PatientNo_Title, !bGXsfl_68_Refreshing);
         edtVIEW_LPI_BR_Demographics_Sex_Titleformat = 2;
         edtVIEW_LPI_BR_Demographics_Sex_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "性别", AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVIEW_LPI_BR_Demographics_Sex_Internalname, "Title", edtVIEW_LPI_BR_Demographics_Sex_Title, !bGXsfl_68_Refreshing);
         edtVIEW_LPI_BR_Demographics_BirthDate_Titleformat = 2;
         edtVIEW_LPI_BR_Demographics_BirthDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "出生日期", AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVIEW_LPI_BR_Demographics_BirthDate_Internalname, "Title", edtVIEW_LPI_BR_Demographics_BirthDate_Title, !bGXsfl_68_Refreshing);
         edtVIEW_LPI_BR_Demographics_Ethnic_Titleformat = 2;
         edtVIEW_LPI_BR_Demographics_Ethnic_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "民族", AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVIEW_LPI_BR_Demographics_Ethnic_Internalname, "Title", edtVIEW_LPI_BR_Demographics_Ethnic_Title, !bGXsfl_68_Refreshing);
         AV42GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridCurrentPage), 10, 0)));
         AV43GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridPageSize), 10, 0)));
         AV44GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44GridRecordCount), 10, 0)));
         AV57BR_InformationListDS_1_View_lpi_br_information_patientno = AV15VIEW_LPI_BR_Information_PatientNo;
         AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate = AV18VIEW_LPI_BR_Demographics_BirthDate;
         AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = AV17VIEW_LPI_BR_Demographics_BirthDate_To;
         AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic = AV19VIEW_LPI_BR_Demographics_Ethnic;
         AV61BR_InformationListDS_5_View_lpi_br_demographics_sex = AV20VIEW_LPI_BR_Demographics_Sex;
         AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = AV23TFVIEW_LPI_BR_Information_PatientNo;
         AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = AV24TFVIEW_LPI_BR_Information_PatientNo_Sel;
         AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = AV27TFVIEW_LPI_BR_Demographics_Sex;
         AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = AV28TFVIEW_LPI_BR_Demographics_Sex_Sel;
         AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = AV31TFVIEW_LPI_BR_Demographics_BirthDate;
         AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = AV32TFVIEW_LPI_BR_Demographics_BirthDate_To;
         AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = AV37TFVIEW_LPI_BR_Demographics_Ethnic;
         AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData", AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26VIEW_LPI_BR_Demographics_SexTitleFilterData", AV26VIEW_LPI_BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData", AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData", AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData);
      }

      protected void E11A02( )
      {
         /* Gridpaginationbar_Changepage Routine */
         if ( 1 == 0 )
         {
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
               AV41PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
               subgrid_gotopage( AV41PageToGo) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
            {
               subgrid_previouspage( ) ;
            }
            else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
            {
               subgrid_gotopage( subGrid_Currentpage( )+1) ;
            }
            else
            {
               AV41PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
               subgrid_gotopage( AV41PageToGo) ;
            }
         }
      }

      protected void E12A02( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13A02( )
      {
         /* Ddo_view_lpi_br_information_patientno_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_lpi_br_information_patientno_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_lpi_br_information_patientno_Sortedstatus = "ASC";
            ucDdo_view_lpi_br_information_patientno.SendProperty(context, "", false, Ddo_view_lpi_br_information_patientno_Internalname, "SortedStatus", Ddo_view_lpi_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_lpi_br_information_patientno_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_lpi_br_information_patientno_Sortedstatus = "DSC";
            ucDdo_view_lpi_br_information_patientno.SendProperty(context, "", false, Ddo_view_lpi_br_information_patientno_Internalname, "SortedStatus", Ddo_view_lpi_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_lpi_br_information_patientno_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV23TFVIEW_LPI_BR_Information_PatientNo = Ddo_view_lpi_br_information_patientno_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23TFVIEW_LPI_BR_Information_PatientNo", AV23TFVIEW_LPI_BR_Information_PatientNo);
            AV24TFVIEW_LPI_BR_Information_PatientNo_Sel = Ddo_view_lpi_br_information_patientno_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24TFVIEW_LPI_BR_Information_PatientNo_Sel", AV24TFVIEW_LPI_BR_Information_PatientNo_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData", AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26VIEW_LPI_BR_Demographics_SexTitleFilterData", AV26VIEW_LPI_BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData", AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData", AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData);
      }

      protected void E14A02( )
      {
         /* Ddo_view_lpi_br_demographics_sex_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_lpi_br_demographics_sex_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_lpi_br_demographics_sex_Sortedstatus = "ASC";
            ucDdo_view_lpi_br_demographics_sex.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_sex_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_sex_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_lpi_br_demographics_sex_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_lpi_br_demographics_sex_Sortedstatus = "DSC";
            ucDdo_view_lpi_br_demographics_sex.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_sex_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_sex_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_lpi_br_demographics_sex_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV27TFVIEW_LPI_BR_Demographics_Sex = Ddo_view_lpi_br_demographics_sex_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27TFVIEW_LPI_BR_Demographics_Sex", AV27TFVIEW_LPI_BR_Demographics_Sex);
            AV28TFVIEW_LPI_BR_Demographics_Sex_Sel = Ddo_view_lpi_br_demographics_sex_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28TFVIEW_LPI_BR_Demographics_Sex_Sel", AV28TFVIEW_LPI_BR_Demographics_Sex_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData", AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26VIEW_LPI_BR_Demographics_SexTitleFilterData", AV26VIEW_LPI_BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData", AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData", AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData);
      }

      protected void E15A02( )
      {
         /* Ddo_view_lpi_br_demographics_birthdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_lpi_br_demographics_birthdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_lpi_br_demographics_birthdate_Sortedstatus = "ASC";
            ucDdo_view_lpi_br_demographics_birthdate.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_birthdate_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_birthdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_lpi_br_demographics_birthdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_lpi_br_demographics_birthdate_Sortedstatus = "DSC";
            ucDdo_view_lpi_br_demographics_birthdate.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_birthdate_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_birthdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_lpi_br_demographics_birthdate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV31TFVIEW_LPI_BR_Demographics_BirthDate = context.localUtil.CToD( Ddo_view_lpi_br_demographics_birthdate_Filteredtext_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31TFVIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(AV31TFVIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
            AV32TFVIEW_LPI_BR_Demographics_BirthDate_To = context.localUtil.CToD( Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32TFVIEW_LPI_BR_Demographics_BirthDate_To", context.localUtil.Format(AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData", AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26VIEW_LPI_BR_Demographics_SexTitleFilterData", AV26VIEW_LPI_BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData", AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData", AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData);
      }

      protected void E16A02( )
      {
         /* Ddo_view_lpi_br_demographics_ethnic_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_lpi_br_demographics_ethnic_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_lpi_br_demographics_ethnic_Sortedstatus = "ASC";
            ucDdo_view_lpi_br_demographics_ethnic.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_ethnic_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_ethnic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_lpi_br_demographics_ethnic_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_lpi_br_demographics_ethnic_Sortedstatus = "DSC";
            ucDdo_view_lpi_br_demographics_ethnic.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_ethnic_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_ethnic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_lpi_br_demographics_ethnic_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV37TFVIEW_LPI_BR_Demographics_Ethnic = Ddo_view_lpi_br_demographics_ethnic_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFVIEW_LPI_BR_Demographics_Ethnic", AV37TFVIEW_LPI_BR_Demographics_Ethnic);
            AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel = Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel", AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData", AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26VIEW_LPI_BR_Demographics_SexTitleFilterData", AV26VIEW_LPI_BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData", AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData", AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData);
      }

      private void E19A02( )
      {
         /* Grid_Load Routine */
         AV45PatientReTenant = context.GetImagePath( "cc488df4-dfce-487a-a445-6fdd39fec85e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavPatientretenant_Internalname, AV45PatientReTenant);
         AV70Patientretenant_GXI = GXDbFile.PathToUrl( context.GetImagePath( "cc488df4-dfce-487a-a445-6fdd39fec85e", "", context.GetTheme( )));
         edtavPatientretenant_Tooltiptext = "";
         if ( AV46IsAuthorized_PatientReTenant )
         {
            edtavPatientretenant_Link = formatLink("br_informationbr_patientretenantassociation.aspx") + "?" + UrlEncode("" +A520VIEW_LPI_BR_Information_ID);
         }
         AV47Patient_Entity = context.GetImagePath( "cc488df4-dfce-487a-a445-6fdd39fec85e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavPatient_entity_Internalname, AV47Patient_Entity);
         AV71Patient_entity_GXI = GXDbFile.PathToUrl( context.GetImagePath( "cc488df4-dfce-487a-a445-6fdd39fec85e", "", context.GetTheme( )));
         edtavPatient_entity_Tooltiptext = "";
         if ( AV48IsAuthorized_Patient_Entity )
         {
            edtavPatient_entity_Link = formatLink("br_informationbr_patientreentityassociation.aspx") + "?" + UrlEncode("" +A520VIEW_LPI_BR_Information_ID);
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 68;
         }
         sendrow_682( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_68_Refreshing )
         {
            context.DoAjaxLoad(68, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_view_lpi_br_information_patientno_Sortedstatus = "";
         ucDdo_view_lpi_br_information_patientno.SendProperty(context, "", false, Ddo_view_lpi_br_information_patientno_Internalname, "SortedStatus", Ddo_view_lpi_br_information_patientno_Sortedstatus);
         Ddo_view_lpi_br_demographics_sex_Sortedstatus = "";
         ucDdo_view_lpi_br_demographics_sex.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_sex_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_sex_Sortedstatus);
         Ddo_view_lpi_br_demographics_birthdate_Sortedstatus = "";
         ucDdo_view_lpi_br_demographics_birthdate.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_birthdate_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_birthdate_Sortedstatus);
         Ddo_view_lpi_br_demographics_ethnic_Sortedstatus = "";
         ucDdo_view_lpi_br_demographics_ethnic.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_ethnic_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_ethnic_Sortedstatus);
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
         if ( AV13OrderedBy == 1 )
         {
            Ddo_view_lpi_br_information_patientno_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_lpi_br_information_patientno.SendProperty(context, "", false, Ddo_view_lpi_br_information_patientno_Internalname, "SortedStatus", Ddo_view_lpi_br_information_patientno_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_view_lpi_br_demographics_sex_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_lpi_br_demographics_sex.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_sex_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_sex_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_view_lpi_br_demographics_birthdate_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_lpi_br_demographics_birthdate.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_birthdate_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_birthdate_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_view_lpi_br_demographics_ethnic_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_lpi_br_demographics_ethnic.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_ethnic_Internalname, "SortedStatus", Ddo_view_lpi_br_demographics_ethnic_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV46IsAuthorized_PatientReTenant;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Tenant", out  GXt_boolean1) ;
         AV46IsAuthorized_PatientReTenant = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46IsAuthorized_PatientReTenant", AV46IsAuthorized_PatientReTenant);
         if ( ! ( AV46IsAuthorized_PatientReTenant ) )
         {
            edtavPatientretenant_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPatientretenant_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPatientretenant_Visible), 5, 0)), !bGXsfl_68_Refreshing);
         }
         GXt_boolean1 = AV48IsAuthorized_Patient_Entity;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Entity", out  GXt_boolean1) ;
         AV48IsAuthorized_Patient_Entity = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48IsAuthorized_Patient_Entity", AV48IsAuthorized_Patient_Entity);
         if ( ! ( AV48IsAuthorized_Patient_Entity ) )
         {
            edtavPatient_entity_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPatient_entity_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPatient_entity_Visible), 5, 0)), !bGXsfl_68_Refreshing);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV21Session.Get(AV72Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV72Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV21Session.Get(AV72Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV73GXV1 = 1;
         while ( AV73GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV73GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "VIEW_LPI_BR_INFORMATION_PATIENTNO") == 0 )
            {
               AV15VIEW_LPI_BR_Information_PatientNo = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15VIEW_LPI_BR_Information_PatientNo", AV15VIEW_LPI_BR_Information_PatientNo);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE") == 0 )
            {
               AV18VIEW_LPI_BR_Demographics_BirthDate = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18VIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(AV18VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
               AV16VIEW_LPI_BR_Demographics_BirthDateOperator = AV12GridStateFilterValue.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16VIEW_LPI_BR_Demographics_BirthDateOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16VIEW_LPI_BR_Demographics_BirthDateOperator), 4, 0)));
               AV17VIEW_LPI_BR_Demographics_BirthDate_To = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17VIEW_LPI_BR_Demographics_BirthDate_To", context.localUtil.Format(AV17VIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"));
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC") == 0 )
            {
               AV19VIEW_LPI_BR_Demographics_Ethnic = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19VIEW_LPI_BR_Demographics_Ethnic", AV19VIEW_LPI_BR_Demographics_Ethnic);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "VIEW_LPI_BR_DEMOGRAPHICS_SEX") == 0 )
            {
               AV20VIEW_LPI_BR_Demographics_Sex = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20VIEW_LPI_BR_Demographics_Sex", AV20VIEW_LPI_BR_Demographics_Sex);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_INFORMATION_PATIENTNO") == 0 )
            {
               AV23TFVIEW_LPI_BR_Information_PatientNo = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23TFVIEW_LPI_BR_Information_PatientNo", AV23TFVIEW_LPI_BR_Information_PatientNo);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23TFVIEW_LPI_BR_Information_PatientNo)) )
               {
                  Ddo_view_lpi_br_information_patientno_Filteredtext_set = AV23TFVIEW_LPI_BR_Information_PatientNo;
                  ucDdo_view_lpi_br_information_patientno.SendProperty(context, "", false, Ddo_view_lpi_br_information_patientno_Internalname, "FilteredText_set", Ddo_view_lpi_br_information_patientno_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV24TFVIEW_LPI_BR_Information_PatientNo_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24TFVIEW_LPI_BR_Information_PatientNo_Sel", AV24TFVIEW_LPI_BR_Information_PatientNo_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24TFVIEW_LPI_BR_Information_PatientNo_Sel)) )
               {
                  Ddo_view_lpi_br_information_patientno_Selectedvalue_set = AV24TFVIEW_LPI_BR_Information_PatientNo_Sel;
                  ucDdo_view_lpi_br_information_patientno.SendProperty(context, "", false, Ddo_view_lpi_br_information_patientno_Internalname, "SelectedValue_set", Ddo_view_lpi_br_information_patientno_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_DEMOGRAPHICS_SEX") == 0 )
            {
               AV27TFVIEW_LPI_BR_Demographics_Sex = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27TFVIEW_LPI_BR_Demographics_Sex", AV27TFVIEW_LPI_BR_Demographics_Sex);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27TFVIEW_LPI_BR_Demographics_Sex)) )
               {
                  Ddo_view_lpi_br_demographics_sex_Filteredtext_set = AV27TFVIEW_LPI_BR_Demographics_Sex;
                  ucDdo_view_lpi_br_demographics_sex.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_sex_Internalname, "FilteredText_set", Ddo_view_lpi_br_demographics_sex_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL") == 0 )
            {
               AV28TFVIEW_LPI_BR_Demographics_Sex_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28TFVIEW_LPI_BR_Demographics_Sex_Sel", AV28TFVIEW_LPI_BR_Demographics_Sex_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28TFVIEW_LPI_BR_Demographics_Sex_Sel)) )
               {
                  Ddo_view_lpi_br_demographics_sex_Selectedvalue_set = AV28TFVIEW_LPI_BR_Demographics_Sex_Sel;
                  ucDdo_view_lpi_br_demographics_sex.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_sex_Internalname, "SelectedValue_set", Ddo_view_lpi_br_demographics_sex_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE") == 0 )
            {
               AV31TFVIEW_LPI_BR_Demographics_BirthDate = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31TFVIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(AV31TFVIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
               AV32TFVIEW_LPI_BR_Demographics_BirthDate_To = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32TFVIEW_LPI_BR_Demographics_BirthDate_To", context.localUtil.Format(AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"));
               if ( ! (DateTime.MinValue==AV31TFVIEW_LPI_BR_Demographics_BirthDate) )
               {
                  Ddo_view_lpi_br_demographics_birthdate_Filteredtext_set = context.localUtil.DToC( AV31TFVIEW_LPI_BR_Demographics_BirthDate, 0, "/");
                  ucDdo_view_lpi_br_demographics_birthdate.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_birthdate_Internalname, "FilteredText_set", Ddo_view_lpi_br_demographics_birthdate_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV32TFVIEW_LPI_BR_Demographics_BirthDate_To) )
               {
                  Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_set = context.localUtil.DToC( AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, 0, "/");
                  ucDdo_view_lpi_br_demographics_birthdate.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_birthdate_Internalname, "FilteredTextTo_set", Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC") == 0 )
            {
               AV37TFVIEW_LPI_BR_Demographics_Ethnic = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFVIEW_LPI_BR_Demographics_Ethnic", AV37TFVIEW_LPI_BR_Demographics_Ethnic);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFVIEW_LPI_BR_Demographics_Ethnic)) )
               {
                  Ddo_view_lpi_br_demographics_ethnic_Filteredtext_set = AV37TFVIEW_LPI_BR_Demographics_Ethnic;
                  ucDdo_view_lpi_br_demographics_ethnic.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_ethnic_Internalname, "FilteredText_set", Ddo_view_lpi_br_demographics_ethnic_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL") == 0 )
            {
               AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel", AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel)) )
               {
                  Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_set = AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
                  ucDdo_view_lpi_br_demographics_ethnic.SendProperty(context, "", false, Ddo_view_lpi_br_demographics_ethnic_Internalname, "SelectedValue_set", Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_set);
               }
            }
            AV73GXV1 = (int)(AV73GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV11GridState.gxTpr_Currentpage) ;
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV21Session.Get(AV72Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15VIEW_LPI_BR_Information_PatientNo)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "VIEW_LPI_BR_INFORMATION_PATIENTNO";
            AV12GridStateFilterValue.gxTpr_Value = AV15VIEW_LPI_BR_Information_PatientNo;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (DateTime.MinValue==AV18VIEW_LPI_BR_Demographics_BirthDate) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
            AV12GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV18VIEW_LPI_BR_Demographics_BirthDate, 0, "/");
            AV12GridStateFilterValue.gxTpr_Operator = AV16VIEW_LPI_BR_Demographics_BirthDateOperator;
            AV12GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV17VIEW_LPI_BR_Demographics_BirthDate_To, 0, "/");
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19VIEW_LPI_BR_Demographics_Ethnic)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
            AV12GridStateFilterValue.gxTpr_Value = AV19VIEW_LPI_BR_Demographics_Ethnic;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV20VIEW_LPI_BR_Demographics_Sex)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "VIEW_LPI_BR_DEMOGRAPHICS_SEX";
            AV12GridStateFilterValue.gxTpr_Value = AV20VIEW_LPI_BR_Demographics_Sex;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23TFVIEW_LPI_BR_Information_PatientNo)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_LPI_BR_INFORMATION_PATIENTNO";
            AV12GridStateFilterValue.gxTpr_Value = AV23TFVIEW_LPI_BR_Information_PatientNo;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24TFVIEW_LPI_BR_Information_PatientNo_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV24TFVIEW_LPI_BR_Information_PatientNo_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27TFVIEW_LPI_BR_Demographics_Sex)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_LPI_BR_DEMOGRAPHICS_SEX";
            AV12GridStateFilterValue.gxTpr_Value = AV27TFVIEW_LPI_BR_Demographics_Sex;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28TFVIEW_LPI_BR_Demographics_Sex_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV28TFVIEW_LPI_BR_Demographics_Sex_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV31TFVIEW_LPI_BR_Demographics_BirthDate) && (DateTime.MinValue==AV32TFVIEW_LPI_BR_Demographics_BirthDate_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
            AV12GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV31TFVIEW_LPI_BR_Demographics_BirthDate, 0, "/");
            AV12GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV32TFVIEW_LPI_BR_Demographics_BirthDate_To, 0, "/");
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFVIEW_LPI_BR_Demographics_Ethnic)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
            AV12GridStateFilterValue.gxTpr_Value = AV37TFVIEW_LPI_BR_Demographics_Ethnic;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV72Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV72Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "view_lastest_patient_info";
         AV21Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void wb_table1_30_A02( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedview_lpi_br_demographics_birthdate_Internalname, tblTablemergedview_lpi_br_demographics_birthdate_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavView_lpi_br_demographics_birthdateoperator_Internalname, "VIEW_LPI_BR_Demographics_Birth Date Operator", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_68_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavView_lpi_br_demographics_birthdateoperator, cmbavView_lpi_br_demographics_birthdateoperator_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV16VIEW_LPI_BR_Demographics_BirthDateOperator), 4, 0)), 1, cmbavView_lpi_br_demographics_birthdateoperator_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavView_lpi_br_demographics_birthdateoperator.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "", true, "HLP_BR_InformationList.htm");
            cmbavView_lpi_br_demographics_birthdateoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV16VIEW_LPI_BR_Demographics_BirthDateOperator), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavView_lpi_br_demographics_birthdateoperator_Internalname, "Values", (String)(cmbavView_lpi_br_demographics_birthdateoperator.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavView_lpi_br_demographics_birthdate_Internalname, "VIEW_LPI_BR_Demographics_Birth Date", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_68_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavView_lpi_br_demographics_birthdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavView_lpi_br_demographics_birthdate_Internalname, context.localUtil.Format(AV18VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"), context.localUtil.Format( AV18VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavView_lpi_br_demographics_birthdate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavView_lpi_br_demographics_birthdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_InformationList.htm");
            GxWebStd.gx_bitmap( context, edtavView_lpi_br_demographics_birthdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavView_lpi_br_demographics_birthdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_InformationList.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellView_lpi_br_demographics_birthdate_rangemiddletext_1_cell_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblView_lpi_br_demographics_birthdate_rangemiddletext_1_Internalname, "到", "", "", lblView_lpi_br_demographics_birthdate_rangemiddletext_1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_BR_InformationList.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellView_lpi_br_demographics_birthdate_to_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavView_lpi_br_demographics_birthdate_to_Internalname, "VIEW_LPI_BR_Demographics_Birth Date_To", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'" + sGXsfl_68_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavView_lpi_br_demographics_birthdate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavView_lpi_br_demographics_birthdate_to_Internalname, context.localUtil.Format(AV17VIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"), context.localUtil.Format( AV17VIEW_LPI_BR_Demographics_BirthDate_To, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavView_lpi_br_demographics_birthdate_to_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavView_lpi_br_demographics_birthdate_to_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_InformationList.htm");
            GxWebStd.gx_bitmap( context, edtavView_lpi_br_demographics_birthdate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavView_lpi_br_demographics_birthdate_to_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_InformationList.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_30_A02e( true) ;
         }
         else
         {
            wb_table1_30_A02e( false) ;
         }
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
         PAA02( ) ;
         WSA02( ) ;
         WEA02( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815172582", true);
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
         context.AddJavascriptSource("br_informationlist.js", "?202022815172582", false);
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

      protected void SubsflControlProps_682( )
      {
         edtavPatientretenant_Internalname = "vPATIENTRETENANT_"+sGXsfl_68_idx;
         edtavPatient_entity_Internalname = "vPATIENT_ENTITY_"+sGXsfl_68_idx;
         edtVIEW_LPI_BR_Information_ID_Internalname = "VIEW_LPI_BR_INFORMATION_ID_"+sGXsfl_68_idx;
         edtVIEW_LPI_BR_Information_PatientNo_Internalname = "VIEW_LPI_BR_INFORMATION_PATIENTNO_"+sGXsfl_68_idx;
         edtVIEW_LPI_BR_Demographics_Sex_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_SEX_"+sGXsfl_68_idx;
         edtVIEW_LPI_BR_Demographics_BirthDate_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_"+sGXsfl_68_idx;
         edtVIEW_LPI_BR_Demographics_Ethnic_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_"+sGXsfl_68_idx;
      }

      protected void SubsflControlProps_fel_682( )
      {
         edtavPatientretenant_Internalname = "vPATIENTRETENANT_"+sGXsfl_68_fel_idx;
         edtavPatient_entity_Internalname = "vPATIENT_ENTITY_"+sGXsfl_68_fel_idx;
         edtVIEW_LPI_BR_Information_ID_Internalname = "VIEW_LPI_BR_INFORMATION_ID_"+sGXsfl_68_fel_idx;
         edtVIEW_LPI_BR_Information_PatientNo_Internalname = "VIEW_LPI_BR_INFORMATION_PATIENTNO_"+sGXsfl_68_fel_idx;
         edtVIEW_LPI_BR_Demographics_Sex_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_SEX_"+sGXsfl_68_fel_idx;
         edtVIEW_LPI_BR_Demographics_BirthDate_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_"+sGXsfl_68_fel_idx;
         edtVIEW_LPI_BR_Demographics_Ethnic_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_"+sGXsfl_68_fel_idx;
      }

      protected void sendrow_682( )
      {
         SubsflControlProps_682( ) ;
         WBA00( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_68_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_68_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_68_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavPatientretenant_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV45PatientReTenant_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV45PatientReTenant))&&String.IsNullOrEmpty(StringUtil.RTrim( AV70Patientretenant_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV45PatientReTenant)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV45PatientReTenant)) ? AV70Patientretenant_GXI : context.PathToRelativeUrl( AV45PatientReTenant));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavPatientretenant_Internalname,(String)sImgUrl,(String)edtavPatientretenant_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavPatientretenant_Visible,(short)1,(String)"",(String)edtavPatientretenant_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV45PatientReTenant_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavPatient_entity_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV47Patient_Entity_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV47Patient_Entity))&&String.IsNullOrEmpty(StringUtil.RTrim( AV71Patient_entity_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV47Patient_Entity)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV47Patient_Entity)) ? AV71Patient_entity_GXI : context.PathToRelativeUrl( AV47Patient_Entity));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavPatient_entity_Internalname,(String)sImgUrl,(String)edtavPatient_entity_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavPatient_entity_Visible,(short)1,(String)"",(String)edtavPatient_entity_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV47Patient_Entity_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVIEW_LPI_BR_Information_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A520VIEW_LPI_BR_Information_ID), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVIEW_LPI_BR_Information_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVIEW_LPI_BR_Information_PatientNo_Internalname,(String)A519VIEW_LPI_BR_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+"e20a02_client"+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVIEW_LPI_BR_Information_PatientNo_Jsonclick,(short)7,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVIEW_LPI_BR_Demographics_Sex_Internalname,(String)A522VIEW_LPI_BR_Demographics_Sex,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVIEW_LPI_BR_Demographics_Sex_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVIEW_LPI_BR_Demographics_BirthDate_Internalname,context.localUtil.Format(A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"),context.localUtil.Format( A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVIEW_LPI_BR_Demographics_BirthDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVIEW_LPI_BR_Demographics_Ethnic_Internalname,(String)A524VIEW_LPI_BR_Demographics_Ethnic,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVIEW_LPI_BR_Demographics_Ethnic_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashesA02( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_68_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_68_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_68_idx+1));
            sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_68_idx), 4, 0)), 4, "0");
            SubsflControlProps_682( ) ;
         }
         /* End function sendrow_682 */
      }

      protected void init_web_controls( )
      {
         cmbavView_lpi_br_demographics_birthdateoperator.Name = "vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR";
         cmbavView_lpi_br_demographics_birthdateoperator.WebTags = "";
         cmbavView_lpi_br_demographics_birthdateoperator.addItem("0", "范围", 0);
         if ( cmbavView_lpi_br_demographics_birthdateoperator.ItemCount > 0 )
         {
            AV16VIEW_LPI_BR_Demographics_BirthDateOperator = (short)(NumberUtil.Val( cmbavView_lpi_br_demographics_birthdateoperator.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV16VIEW_LPI_BR_Demographics_BirthDateOperator), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16VIEW_LPI_BR_Demographics_BirthDateOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16VIEW_LPI_BR_Demographics_BirthDateOperator), 4, 0)));
         }
         dynavView_lpi_br_demographics_ethnic.Name = "vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
         dynavView_lpi_br_demographics_ethnic.WebTags = "";
         dynavView_lpi_br_demographics_sex.Name = "vVIEW_LPI_BR_DEMOGRAPHICS_SEX";
         dynavView_lpi_br_demographics_sex.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblFiltertextview_lpi_br_information_patientno_Internalname = "FILTERTEXTVIEW_LPI_BR_INFORMATION_PATIENTNO";
         edtavView_lpi_br_information_patientno_Internalname = "vVIEW_LPI_BR_INFORMATION_PATIENTNO";
         divUnnamedtableiew_lpi_br_information_patientno_Internalname = "UNNAMEDTABLEIEW_LPI_BR_INFORMATION_PATIENTNO";
         lblFiltertextview_lpi_br_demographics_birthdate_Internalname = "FILTERTEXTVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         cmbavView_lpi_br_demographics_birthdateoperator_Internalname = "vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR";
         edtavView_lpi_br_demographics_birthdate_Internalname = "vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         lblView_lpi_br_demographics_birthdate_rangemiddletext_1_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_RANGEMIDDLETEXT_1";
         cellView_lpi_br_demographics_birthdate_rangemiddletext_1_cell_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_RANGEMIDDLETEXT_1_CELL";
         edtavView_lpi_br_demographics_birthdate_to_Internalname = "vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO";
         cellView_lpi_br_demographics_birthdate_to_cell_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO_CELL";
         tblTablemergedview_lpi_br_demographics_birthdate_Internalname = "TABLEMERGEDVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         divTablesplittedfiltertextview_lpi_br_demographics_birthdate_Internalname = "TABLESPLITTEDFILTERTEXTVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         lblFiltertextview_lpi_br_demographics_ethnic_Internalname = "FILTERTEXTVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
         dynavView_lpi_br_demographics_ethnic_Internalname = "vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
         divUnnamedtableiew_lpi_br_demographics_ethnic_Internalname = "UNNAMEDTABLEIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
         lblFiltertextview_lpi_br_demographics_sex_Internalname = "FILTERTEXTVIEW_LPI_BR_DEMOGRAPHICS_SEX";
         dynavView_lpi_br_demographics_sex_Internalname = "vVIEW_LPI_BR_DEMOGRAPHICS_SEX";
         divUnnamedtableiew_lpi_br_demographics_sex_Internalname = "UNNAMEDTABLEIEW_LPI_BR_DEMOGRAPHICS_SEX";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavPatientretenant_Internalname = "vPATIENTRETENANT";
         edtavPatient_entity_Internalname = "vPATIENT_ENTITY";
         edtVIEW_LPI_BR_Information_ID_Internalname = "VIEW_LPI_BR_INFORMATION_ID";
         edtVIEW_LPI_BR_Information_PatientNo_Internalname = "VIEW_LPI_BR_INFORMATION_PATIENTNO";
         edtVIEW_LPI_BR_Demographics_Sex_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_SEX";
         edtVIEW_LPI_BR_Demographics_BirthDate_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         edtVIEW_LPI_BR_Demographics_Ethnic_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_view_lpi_br_information_patientno_Internalname = "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO";
         edtavDdo_view_lpi_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_view_lpi_br_demographics_sex_Internalname = "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX";
         edtavDdo_view_lpi_br_demographics_sextitlecontrolidtoreplace_Internalname = "vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE";
         Ddo_view_lpi_br_demographics_birthdate_Internalname = "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         edtavDdo_view_lpi_br_demographics_birthdatetitlecontrolidtoreplace_Internalname = "vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE";
         Ddo_view_lpi_br_demographics_ethnic_Internalname = "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
         edtavDdo_view_lpi_br_demographics_ethnictitlecontrolidtoreplace_Internalname = "vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfview_lpi_br_information_patientno_Internalname = "vTFVIEW_LPI_BR_INFORMATION_PATIENTNO";
         edtavTfview_lpi_br_information_patientno_sel_Internalname = "vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL";
         edtavTfview_lpi_br_demographics_sex_Internalname = "vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX";
         edtavTfview_lpi_br_demographics_sex_sel_Internalname = "vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL";
         edtavTfview_lpi_br_demographics_birthdate_Internalname = "vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         edtavTfview_lpi_br_demographics_birthdate_to_Internalname = "vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO";
         edtavDdo_view_lpi_br_demographics_birthdateauxdate_Internalname = "vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATE";
         edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Internalname = "vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATETO";
         divDdo_view_lpi_br_demographics_birthdateauxdates_Internalname = "DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEAUXDATES";
         edtavTfview_lpi_br_demographics_ethnic_Internalname = "vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
         edtavTfview_lpi_br_demographics_ethnic_sel_Internalname = "vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL";
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
         edtVIEW_LPI_BR_Demographics_Ethnic_Jsonclick = "";
         edtVIEW_LPI_BR_Demographics_BirthDate_Jsonclick = "";
         edtVIEW_LPI_BR_Demographics_Sex_Jsonclick = "";
         edtVIEW_LPI_BR_Information_PatientNo_Jsonclick = "";
         edtVIEW_LPI_BR_Information_ID_Jsonclick = "";
         edtavView_lpi_br_demographics_birthdate_to_Jsonclick = "";
         edtavView_lpi_br_demographics_birthdate_to_Enabled = 1;
         edtavView_lpi_br_demographics_birthdate_Jsonclick = "";
         edtavView_lpi_br_demographics_birthdate_Enabled = 1;
         cmbavView_lpi_br_demographics_birthdateoperator_Jsonclick = "";
         cmbavView_lpi_br_demographics_birthdateoperator.Enabled = 1;
         edtavTfview_lpi_br_demographics_ethnic_sel_Visible = 1;
         edtavTfview_lpi_br_demographics_ethnic_Visible = 1;
         edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Jsonclick = "";
         edtavDdo_view_lpi_br_demographics_birthdateauxdate_Jsonclick = "";
         edtavTfview_lpi_br_demographics_birthdate_to_Jsonclick = "";
         edtavTfview_lpi_br_demographics_birthdate_to_Visible = 1;
         edtavTfview_lpi_br_demographics_birthdate_Jsonclick = "";
         edtavTfview_lpi_br_demographics_birthdate_Visible = 1;
         edtavTfview_lpi_br_demographics_sex_sel_Visible = 1;
         edtavTfview_lpi_br_demographics_sex_Visible = 1;
         edtavTfview_lpi_br_information_patientno_sel_Visible = 1;
         edtavTfview_lpi_br_information_patientno_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_view_lpi_br_demographics_ethnictitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_lpi_br_demographics_birthdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_lpi_br_demographics_sextitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_lpi_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavPatient_entity_Tooltiptext = "";
         edtavPatient_entity_Link = "";
         edtavPatientretenant_Tooltiptext = "";
         edtavPatientretenant_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtVIEW_LPI_BR_Demographics_Ethnic_Titleformat = 0;
         edtVIEW_LPI_BR_Demographics_Ethnic_Title = "民族";
         edtVIEW_LPI_BR_Demographics_BirthDate_Titleformat = 0;
         edtVIEW_LPI_BR_Demographics_BirthDate_Title = "出生日期";
         edtVIEW_LPI_BR_Demographics_Sex_Titleformat = 0;
         edtVIEW_LPI_BR_Demographics_Sex_Title = "性别";
         edtVIEW_LPI_BR_Information_PatientNo_Titleformat = 0;
         edtVIEW_LPI_BR_Information_PatientNo_Title = "患者编号";
         edtavPatient_entity_Visible = -1;
         edtavPatientretenant_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         dynavView_lpi_br_demographics_sex_Jsonclick = "";
         dynavView_lpi_br_demographics_sex.Enabled = 1;
         dynavView_lpi_br_demographics_ethnic_Jsonclick = "";
         dynavView_lpi_br_demographics_ethnic.Enabled = 1;
         edtavView_lpi_br_information_patientno_Jsonclick = "";
         edtavView_lpi_br_information_patientno_Enabled = 1;
         Ddo_view_lpi_br_demographics_ethnic_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_lpi_br_demographics_ethnic_Noresultsfound = "WWP_TSNoResults";
         Ddo_view_lpi_br_demographics_ethnic_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_lpi_br_demographics_ethnic_Loadingdata = "WWP_TSLoading";
         Ddo_view_lpi_br_demographics_ethnic_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_lpi_br_demographics_ethnic_Sortasc = "WWP_TSSortASC";
         Ddo_view_lpi_br_demographics_ethnic_Datalistupdateminimumcharacters = 0;
         Ddo_view_lpi_br_demographics_ethnic_Datalistproc = "BR_InformationListGetFilterData";
         Ddo_view_lpi_br_demographics_ethnic_Datalisttype = "Dynamic";
         Ddo_view_lpi_br_demographics_ethnic_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_ethnic_Filterisrange = Convert.ToBoolean( 0);
         Ddo_view_lpi_br_demographics_ethnic_Filtertype = "Character";
         Ddo_view_lpi_br_demographics_ethnic_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_ethnic_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_ethnic_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_ethnic_Titlecontrolidtoreplace = "";
         Ddo_view_lpi_br_demographics_ethnic_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_lpi_br_demographics_ethnic_Cls = "ColumnSettings";
         Ddo_view_lpi_br_demographics_ethnic_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_lpi_br_demographics_ethnic_Caption = "";
         Ddo_view_lpi_br_demographics_birthdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_lpi_br_demographics_birthdate_Rangefilterto = "WWP_TSTo";
         Ddo_view_lpi_br_demographics_birthdate_Rangefilterfrom = "WWP_TSFrom";
         Ddo_view_lpi_br_demographics_birthdate_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_lpi_br_demographics_birthdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_lpi_br_demographics_birthdate_Sortasc = "WWP_TSSortASC";
         Ddo_view_lpi_br_demographics_birthdate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_view_lpi_br_demographics_birthdate_Filterisrange = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_birthdate_Filtertype = "Date";
         Ddo_view_lpi_br_demographics_birthdate_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_birthdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_birthdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_birthdate_Titlecontrolidtoreplace = "";
         Ddo_view_lpi_br_demographics_birthdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_lpi_br_demographics_birthdate_Cls = "ColumnSettings";
         Ddo_view_lpi_br_demographics_birthdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_lpi_br_demographics_birthdate_Caption = "";
         Ddo_view_lpi_br_demographics_sex_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_lpi_br_demographics_sex_Noresultsfound = "WWP_TSNoResults";
         Ddo_view_lpi_br_demographics_sex_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_lpi_br_demographics_sex_Loadingdata = "WWP_TSLoading";
         Ddo_view_lpi_br_demographics_sex_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_lpi_br_demographics_sex_Sortasc = "WWP_TSSortASC";
         Ddo_view_lpi_br_demographics_sex_Datalistupdateminimumcharacters = 0;
         Ddo_view_lpi_br_demographics_sex_Datalistproc = "BR_InformationListGetFilterData";
         Ddo_view_lpi_br_demographics_sex_Datalisttype = "Dynamic";
         Ddo_view_lpi_br_demographics_sex_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_sex_Filterisrange = Convert.ToBoolean( 0);
         Ddo_view_lpi_br_demographics_sex_Filtertype = "Character";
         Ddo_view_lpi_br_demographics_sex_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_sex_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_sex_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_demographics_sex_Titlecontrolidtoreplace = "";
         Ddo_view_lpi_br_demographics_sex_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_lpi_br_demographics_sex_Cls = "ColumnSettings";
         Ddo_view_lpi_br_demographics_sex_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_lpi_br_demographics_sex_Caption = "";
         Ddo_view_lpi_br_information_patientno_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_lpi_br_information_patientno_Noresultsfound = "WWP_TSNoResults";
         Ddo_view_lpi_br_information_patientno_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_lpi_br_information_patientno_Loadingdata = "WWP_TSLoading";
         Ddo_view_lpi_br_information_patientno_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_lpi_br_information_patientno_Sortasc = "WWP_TSSortASC";
         Ddo_view_lpi_br_information_patientno_Datalistupdateminimumcharacters = 0;
         Ddo_view_lpi_br_information_patientno_Datalistproc = "BR_InformationListGetFilterData";
         Ddo_view_lpi_br_information_patientno_Datalisttype = "Dynamic";
         Ddo_view_lpi_br_information_patientno_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_information_patientno_Filterisrange = Convert.ToBoolean( 0);
         Ddo_view_lpi_br_information_patientno_Filtertype = "Character";
         Ddo_view_lpi_br_information_patientno_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_information_patientno_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_information_patientno_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_lpi_br_information_patientno_Titlecontrolidtoreplace = "";
         Ddo_view_lpi_br_information_patientno_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_lpi_br_information_patientno_Cls = "ColumnSettings";
         Ddo_view_lpi_br_information_patientno_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_lpi_br_information_patientno_Caption = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'dynavView_lpi_br_demographics_ethnic'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'dynavView_lpi_br_demographics_sex'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'cmbavView_lpi_br_demographics_birthdateoperator'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26VIEW_LPI_BR_Demographics_SexTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'edtVIEW_LPI_BR_Information_PatientNo_Titleformat',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Information_PatientNo_Title',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_Sex_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_Sex_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_BirthDate_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_BirthDate_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_Ethnic_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_Ethnic_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'edtavPatientretenant_Visible',ctrl:'vPATIENTRETENANT',prop:'Visible'},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'edtavPatient_entity_Visible',ctrl:'vPATIENT_ENTITY',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11A02',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavView_lpi_br_demographics_birthdateoperator'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'dynavView_lpi_br_demographics_ethnic'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'dynavView_lpi_br_demographics_sex'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12A02',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavView_lpi_br_demographics_birthdateoperator'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'dynavView_lpi_br_demographics_ethnic'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'dynavView_lpi_br_demographics_sex'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E13A02',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavView_lpi_br_demographics_birthdateoperator'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'dynavView_lpi_br_demographics_ethnic'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'dynavView_lpi_br_demographics_sex'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'Ddo_view_lpi_br_information_patientno_Activeeventkey',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'},{av:'Ddo_view_lpi_br_information_patientno_Filteredtext_get',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'FilteredText_get'},{av:'Ddo_view_lpi_br_information_patientno_Selectedvalue_get',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_lpi_br_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'Ddo_view_lpi_br_demographics_sex_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SortedStatus'},{av:'Ddo_view_lpi_br_demographics_birthdate_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'SortedStatus'},{av:'Ddo_view_lpi_br_demographics_ethnic_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SortedStatus'},{av:'AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26VIEW_LPI_BR_Demographics_SexTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'edtVIEW_LPI_BR_Information_PatientNo_Titleformat',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Information_PatientNo_Title',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_Sex_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_Sex_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_BirthDate_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_BirthDate_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_Ethnic_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_Ethnic_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'edtavPatientretenant_Visible',ctrl:'vPATIENTRETENANT',prop:'Visible'},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'edtavPatient_entity_Visible',ctrl:'vPATIENT_ENTITY',prop:'Visible'}]}");
         setEventMetadata("DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX.ONOPTIONCLICKED","{handler:'E14A02',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavView_lpi_br_demographics_birthdateoperator'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'dynavView_lpi_br_demographics_ethnic'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'dynavView_lpi_br_demographics_sex'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'Ddo_view_lpi_br_demographics_sex_Activeeventkey',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'ActiveEventKey'},{av:'Ddo_view_lpi_br_demographics_sex_Filteredtext_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'FilteredText_get'},{av:'Ddo_view_lpi_br_demographics_sex_Selectedvalue_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_lpi_br_demographics_sex_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SortedStatus'},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'Ddo_view_lpi_br_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_view_lpi_br_demographics_birthdate_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'SortedStatus'},{av:'Ddo_view_lpi_br_demographics_ethnic_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SortedStatus'},{av:'AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26VIEW_LPI_BR_Demographics_SexTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'edtVIEW_LPI_BR_Information_PatientNo_Titleformat',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Information_PatientNo_Title',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_Sex_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_Sex_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_BirthDate_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_BirthDate_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_Ethnic_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_Ethnic_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'edtavPatientretenant_Visible',ctrl:'vPATIENTRETENANT',prop:'Visible'},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'edtavPatient_entity_Visible',ctrl:'vPATIENT_ENTITY',prop:'Visible'}]}");
         setEventMetadata("DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE.ONOPTIONCLICKED","{handler:'E15A02',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavView_lpi_br_demographics_birthdateoperator'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'dynavView_lpi_br_demographics_ethnic'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'dynavView_lpi_br_demographics_sex'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'Ddo_view_lpi_br_demographics_birthdate_Activeeventkey',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'ActiveEventKey'},{av:'Ddo_view_lpi_br_demographics_birthdate_Filteredtext_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'FilteredText_get'},{av:'Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_lpi_br_demographics_birthdate_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'SortedStatus'},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'Ddo_view_lpi_br_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_view_lpi_br_demographics_sex_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SortedStatus'},{av:'Ddo_view_lpi_br_demographics_ethnic_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SortedStatus'},{av:'AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26VIEW_LPI_BR_Demographics_SexTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'edtVIEW_LPI_BR_Information_PatientNo_Titleformat',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Information_PatientNo_Title',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_Sex_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_Sex_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_BirthDate_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_BirthDate_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_Ethnic_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_Ethnic_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'edtavPatientretenant_Visible',ctrl:'vPATIENTRETENANT',prop:'Visible'},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'edtavPatient_entity_Visible',ctrl:'vPATIENT_ENTITY',prop:'Visible'}]}");
         setEventMetadata("DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC.ONOPTIONCLICKED","{handler:'E16A02',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15VIEW_LPI_BR_Information_PatientNo',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavView_lpi_br_demographics_birthdateoperator'},{av:'AV16VIEW_LPI_BR_Demographics_BirthDateOperator',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATEOPERATOR',pic:'ZZZ9'},{av:'AV18VIEW_LPI_BR_Demographics_BirthDate',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV17VIEW_LPI_BR_Demographics_BirthDate_To',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'dynavView_lpi_br_demographics_ethnic'},{av:'AV19VIEW_LPI_BR_Demographics_Ethnic',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'dynavView_lpi_br_demographics_sex'},{av:'AV20VIEW_LPI_BR_Demographics_Sex',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFVIEW_LPI_BR_Information_PatientNo',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFVIEW_LPI_BR_Information_PatientNo_Sel',fld:'vTFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFVIEW_LPI_BR_Demographics_Sex',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX',pic:''},{av:'AV28TFVIEW_LPI_BR_Demographics_Sex_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL',pic:''},{av:'AV31TFVIEW_LPI_BR_Demographics_BirthDate',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',pic:''},{av:'AV32TFVIEW_LPI_BR_Demographics_BirthDate_To',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE_TO',pic:''},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'Ddo_view_lpi_br_demographics_ethnic_Activeeventkey',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'ActiveEventKey'},{av:'Ddo_view_lpi_br_demographics_ethnic_Filteredtext_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'FilteredText_get'},{av:'Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_get',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_lpi_br_demographics_ethnic_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'SortedStatus'},{av:'AV37TFVIEW_LPI_BR_Demographics_Ethnic',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',pic:''},{av:'AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel',fld:'vTFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL',pic:''},{av:'Ddo_view_lpi_br_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_view_lpi_br_demographics_sex_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'SortedStatus'},{av:'Ddo_view_lpi_br_demographics_birthdate_Sortedstatus',ctrl:'DDO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'SortedStatus'},{av:'AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData',fld:'vVIEW_LPI_BR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26VIEW_LPI_BR_Demographics_SexTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData',fld:'vVIEW_LPI_BR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'edtVIEW_LPI_BR_Information_PatientNo_Titleformat',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Information_PatientNo_Title',ctrl:'VIEW_LPI_BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_Sex_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_Sex_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_BirthDate_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_BirthDate_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtVIEW_LPI_BR_Demographics_Ethnic_Titleformat',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtVIEW_LPI_BR_Demographics_Ethnic_Title',ctrl:'VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'edtavPatientretenant_Visible',ctrl:'vPATIENTRETENANT',prop:'Visible'},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''},{av:'edtavPatient_entity_Visible',ctrl:'vPATIENT_ENTITY',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E19A02',iparms:[{av:'AV46IsAuthorized_PatientReTenant',fld:'vISAUTHORIZED_PATIENTRETENANT',pic:''},{av:'A520VIEW_LPI_BR_Information_ID',fld:'VIEW_LPI_BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true},{av:'AV48IsAuthorized_Patient_Entity',fld:'vISAUTHORIZED_PATIENT_ENTITY',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV45PatientReTenant',fld:'vPATIENTRETENANT',pic:''},{av:'edtavPatientretenant_Tooltiptext',ctrl:'vPATIENTRETENANT',prop:'Tooltiptext'},{av:'edtavPatientretenant_Link',ctrl:'vPATIENTRETENANT',prop:'Link'},{av:'AV47Patient_Entity',fld:'vPATIENT_ENTITY',pic:''},{av:'edtavPatient_entity_Tooltiptext',ctrl:'vPATIENT_ENTITY',prop:'Tooltiptext'},{av:'edtavPatient_entity_Link',ctrl:'vPATIENT_ENTITY',prop:'Link'}]}");
         setEventMetadata("VIEW_LPI_BR_INFORMATION_PATIENTNO.CLICK","{handler:'E20A02',iparms:[{av:'A520VIEW_LPI_BR_Information_ID',fld:'VIEW_LPI_BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true}]");
         setEventMetadata("VIEW_LPI_BR_INFORMATION_PATIENTNO.CLICK",",oparms:[]}");
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
         Ddo_view_lpi_br_information_patientno_Activeeventkey = "";
         Ddo_view_lpi_br_information_patientno_Filteredtext_get = "";
         Ddo_view_lpi_br_information_patientno_Selectedvalue_get = "";
         Ddo_view_lpi_br_demographics_sex_Activeeventkey = "";
         Ddo_view_lpi_br_demographics_sex_Filteredtext_get = "";
         Ddo_view_lpi_br_demographics_sex_Selectedvalue_get = "";
         Ddo_view_lpi_br_demographics_birthdate_Activeeventkey = "";
         Ddo_view_lpi_br_demographics_birthdate_Filteredtext_get = "";
         Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_get = "";
         Ddo_view_lpi_br_demographics_ethnic_Activeeventkey = "";
         Ddo_view_lpi_br_demographics_ethnic_Filteredtext_get = "";
         Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV53tTenantCode = "";
         AV15VIEW_LPI_BR_Information_PatientNo = "";
         AV18VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         AV17VIEW_LPI_BR_Demographics_BirthDate_To = DateTime.MinValue;
         AV19VIEW_LPI_BR_Demographics_Ethnic = "";
         AV20VIEW_LPI_BR_Demographics_Sex = "";
         AV23TFVIEW_LPI_BR_Information_PatientNo = "";
         AV24TFVIEW_LPI_BR_Information_PatientNo_Sel = "";
         AV27TFVIEW_LPI_BR_Demographics_Sex = "";
         AV28TFVIEW_LPI_BR_Demographics_Sex_Sel = "";
         AV31TFVIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         AV32TFVIEW_LPI_BR_Demographics_BirthDate_To = DateTime.MinValue;
         AV37TFVIEW_LPI_BR_Demographics_Ethnic = "";
         AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel = "";
         AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace = "";
         AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace = "";
         AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace = "";
         AV72Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV40DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26VIEW_LPI_BR_Demographics_SexTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_view_lpi_br_information_patientno_Filteredtext_set = "";
         Ddo_view_lpi_br_information_patientno_Selectedvalue_set = "";
         Ddo_view_lpi_br_information_patientno_Sortedstatus = "";
         Ddo_view_lpi_br_demographics_sex_Filteredtext_set = "";
         Ddo_view_lpi_br_demographics_sex_Selectedvalue_set = "";
         Ddo_view_lpi_br_demographics_sex_Sortedstatus = "";
         Ddo_view_lpi_br_demographics_birthdate_Filteredtext_set = "";
         Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_set = "";
         Ddo_view_lpi_br_demographics_birthdate_Sortedstatus = "";
         Ddo_view_lpi_br_demographics_ethnic_Filteredtext_set = "";
         Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_set = "";
         Ddo_view_lpi_br_demographics_ethnic_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         lblFiltertextview_lpi_br_information_patientno_Jsonclick = "";
         TempTags = "";
         lblFiltertextview_lpi_br_demographics_birthdate_Jsonclick = "";
         lblFiltertextview_lpi_br_demographics_ethnic_Jsonclick = "";
         lblFiltertextview_lpi_br_demographics_sex_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV45PatientReTenant = "";
         AV47Patient_Entity = "";
         A519VIEW_LPI_BR_Information_PatientNo = "";
         A522VIEW_LPI_BR_Demographics_Sex = "";
         A523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         A524VIEW_LPI_BR_Demographics_Ethnic = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_view_lpi_br_information_patientno = new GXUserControl();
         ucDdo_view_lpi_br_demographics_sex = new GXUserControl();
         ucDdo_view_lpi_br_demographics_birthdate = new GXUserControl();
         ucDdo_view_lpi_br_demographics_ethnic = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate = DateTime.MinValue;
         AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV70Patientretenant_GXI = "";
         AV71Patient_entity_GXI = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H00A02_A167XT_DefineCodeID = new long[1] ;
         H00A02_A168XT_DefineCodeName = new String[] {""} ;
         H00A02_n168XT_DefineCodeName = new bool[] {false} ;
         H00A02_A165XT_DefindcodeTypeID = new long[1] ;
         H00A02_A432XT_TenantCode = new String[] {""} ;
         H00A02_n432XT_TenantCode = new bool[] {false} ;
         H00A03_A167XT_DefineCodeID = new long[1] ;
         H00A03_A168XT_DefineCodeName = new String[] {""} ;
         H00A03_n168XT_DefineCodeName = new bool[] {false} ;
         H00A03_A165XT_DefindcodeTypeID = new long[1] ;
         H00A03_A432XT_TenantCode = new String[] {""} ;
         H00A03_n432XT_TenantCode = new bool[] {false} ;
         lV57BR_InformationListDS_1_View_lpi_br_information_patientno = "";
         lV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = "";
         lV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = "";
         lV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = "";
         AV51oBR_Information_ID = new GxSimpleCollection<long>();
         AV57BR_InformationListDS_1_View_lpi_br_information_patientno = "";
         AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate = DateTime.MinValue;
         AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = DateTime.MinValue;
         AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic = "";
         AV61BR_InformationListDS_5_View_lpi_br_demographics_sex = "";
         AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = "";
         AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno = "";
         AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = "";
         AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = "";
         AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = DateTime.MinValue;
         AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = DateTime.MinValue;
         AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = "";
         AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = "";
         H00A04_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         H00A04_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         H00A04_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         H00A04_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         H00A04_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         H00A05_AGRID_nRecordCount = new long[1] ;
         AV50tCurrentCode = "";
         AV21Session = context.GetSession();
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons4 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         GXt_char2 = "";
         GXt_objcol_int3 = new GxSimpleCollection<long>();
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         lblView_lpi_br_demographics_birthdate_rangemiddletext_1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_informationlist__default(),
            new Object[][] {
                new Object[] {
               H00A02_A167XT_DefineCodeID, H00A02_A168XT_DefineCodeName, H00A02_n168XT_DefineCodeName, H00A02_A165XT_DefindcodeTypeID, H00A02_A432XT_TenantCode, H00A02_n432XT_TenantCode
               }
               , new Object[] {
               H00A03_A167XT_DefineCodeID, H00A03_A168XT_DefineCodeName, H00A03_n168XT_DefineCodeName, H00A03_A165XT_DefindcodeTypeID, H00A03_A432XT_TenantCode, H00A03_n432XT_TenantCode
               }
               , new Object[] {
               H00A04_A524VIEW_LPI_BR_Demographics_Ethnic, H00A04_A523VIEW_LPI_BR_Demographics_BirthDate, H00A04_A522VIEW_LPI_BR_Demographics_Sex, H00A04_A519VIEW_LPI_BR_Information_PatientNo, H00A04_A520VIEW_LPI_BR_Information_ID
               }
               , new Object[] {
               H00A05_AGRID_nRecordCount
               }
            }
         );
         AV72Pgmname = "BR_InformationList";
         /* GeneXus formulas. */
         AV72Pgmname = "BR_InformationList";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_68 ;
      private short nGXsfl_68_idx=1 ;
      private short GRID_nEOF ;
      private short AV16VIEW_LPI_BR_Demographics_BirthDateOperator ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtVIEW_LPI_BR_Information_PatientNo_Titleformat ;
      private short edtVIEW_LPI_BR_Demographics_Sex_Titleformat ;
      private short edtVIEW_LPI_BR_Demographics_BirthDate_Titleformat ;
      private short edtVIEW_LPI_BR_Demographics_Ethnic_Titleformat ;
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
      private int Ddo_view_lpi_br_information_patientno_Datalistupdateminimumcharacters ;
      private int Ddo_view_lpi_br_demographics_sex_Datalistupdateminimumcharacters ;
      private int Ddo_view_lpi_br_demographics_ethnic_Datalistupdateminimumcharacters ;
      private int edtavView_lpi_br_information_patientno_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavPatientretenant_Visible ;
      private int edtavPatient_entity_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_view_lpi_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_lpi_br_demographics_sextitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_lpi_br_demographics_birthdatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_lpi_br_demographics_ethnictitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfview_lpi_br_information_patientno_Visible ;
      private int edtavTfview_lpi_br_information_patientno_sel_Visible ;
      private int edtavTfview_lpi_br_demographics_sex_Visible ;
      private int edtavTfview_lpi_br_demographics_sex_sel_Visible ;
      private int edtavTfview_lpi_br_demographics_birthdate_Visible ;
      private int edtavTfview_lpi_br_demographics_birthdate_to_Visible ;
      private int edtavTfview_lpi_br_demographics_ethnic_Visible ;
      private int edtavTfview_lpi_br_demographics_ethnic_sel_Visible ;
      private int gxdynajaxindex ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV41PageToGo ;
      private int AV73GXV1 ;
      private int edtavView_lpi_br_demographics_birthdate_Enabled ;
      private int edtavView_lpi_br_demographics_birthdate_to_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV42GridCurrentPage ;
      private long AV44GridRecordCount ;
      private long AV43GridPageSize ;
      private long A520VIEW_LPI_BR_Information_ID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_view_lpi_br_information_patientno_Activeeventkey ;
      private String Ddo_view_lpi_br_information_patientno_Filteredtext_get ;
      private String Ddo_view_lpi_br_information_patientno_Selectedvalue_get ;
      private String Ddo_view_lpi_br_demographics_sex_Activeeventkey ;
      private String Ddo_view_lpi_br_demographics_sex_Filteredtext_get ;
      private String Ddo_view_lpi_br_demographics_sex_Selectedvalue_get ;
      private String Ddo_view_lpi_br_demographics_birthdate_Activeeventkey ;
      private String Ddo_view_lpi_br_demographics_birthdate_Filteredtext_get ;
      private String Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_get ;
      private String Ddo_view_lpi_br_demographics_ethnic_Activeeventkey ;
      private String Ddo_view_lpi_br_demographics_ethnic_Filteredtext_get ;
      private String Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_68_idx="0001" ;
      private String AV72Pgmname ;
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
      private String Ddo_view_lpi_br_information_patientno_Caption ;
      private String Ddo_view_lpi_br_information_patientno_Tooltip ;
      private String Ddo_view_lpi_br_information_patientno_Cls ;
      private String Ddo_view_lpi_br_information_patientno_Filteredtext_set ;
      private String Ddo_view_lpi_br_information_patientno_Selectedvalue_set ;
      private String Ddo_view_lpi_br_information_patientno_Dropdownoptionstype ;
      private String Ddo_view_lpi_br_information_patientno_Titlecontrolidtoreplace ;
      private String Ddo_view_lpi_br_information_patientno_Sortedstatus ;
      private String Ddo_view_lpi_br_information_patientno_Filtertype ;
      private String Ddo_view_lpi_br_information_patientno_Datalisttype ;
      private String Ddo_view_lpi_br_information_patientno_Datalistproc ;
      private String Ddo_view_lpi_br_information_patientno_Sortasc ;
      private String Ddo_view_lpi_br_information_patientno_Sortdsc ;
      private String Ddo_view_lpi_br_information_patientno_Loadingdata ;
      private String Ddo_view_lpi_br_information_patientno_Cleanfilter ;
      private String Ddo_view_lpi_br_information_patientno_Noresultsfound ;
      private String Ddo_view_lpi_br_information_patientno_Searchbuttontext ;
      private String Ddo_view_lpi_br_demographics_sex_Caption ;
      private String Ddo_view_lpi_br_demographics_sex_Tooltip ;
      private String Ddo_view_lpi_br_demographics_sex_Cls ;
      private String Ddo_view_lpi_br_demographics_sex_Filteredtext_set ;
      private String Ddo_view_lpi_br_demographics_sex_Selectedvalue_set ;
      private String Ddo_view_lpi_br_demographics_sex_Dropdownoptionstype ;
      private String Ddo_view_lpi_br_demographics_sex_Titlecontrolidtoreplace ;
      private String Ddo_view_lpi_br_demographics_sex_Sortedstatus ;
      private String Ddo_view_lpi_br_demographics_sex_Filtertype ;
      private String Ddo_view_lpi_br_demographics_sex_Datalisttype ;
      private String Ddo_view_lpi_br_demographics_sex_Datalistproc ;
      private String Ddo_view_lpi_br_demographics_sex_Sortasc ;
      private String Ddo_view_lpi_br_demographics_sex_Sortdsc ;
      private String Ddo_view_lpi_br_demographics_sex_Loadingdata ;
      private String Ddo_view_lpi_br_demographics_sex_Cleanfilter ;
      private String Ddo_view_lpi_br_demographics_sex_Noresultsfound ;
      private String Ddo_view_lpi_br_demographics_sex_Searchbuttontext ;
      private String Ddo_view_lpi_br_demographics_birthdate_Caption ;
      private String Ddo_view_lpi_br_demographics_birthdate_Tooltip ;
      private String Ddo_view_lpi_br_demographics_birthdate_Cls ;
      private String Ddo_view_lpi_br_demographics_birthdate_Filteredtext_set ;
      private String Ddo_view_lpi_br_demographics_birthdate_Filteredtextto_set ;
      private String Ddo_view_lpi_br_demographics_birthdate_Dropdownoptionstype ;
      private String Ddo_view_lpi_br_demographics_birthdate_Titlecontrolidtoreplace ;
      private String Ddo_view_lpi_br_demographics_birthdate_Sortedstatus ;
      private String Ddo_view_lpi_br_demographics_birthdate_Filtertype ;
      private String Ddo_view_lpi_br_demographics_birthdate_Sortasc ;
      private String Ddo_view_lpi_br_demographics_birthdate_Sortdsc ;
      private String Ddo_view_lpi_br_demographics_birthdate_Cleanfilter ;
      private String Ddo_view_lpi_br_demographics_birthdate_Rangefilterfrom ;
      private String Ddo_view_lpi_br_demographics_birthdate_Rangefilterto ;
      private String Ddo_view_lpi_br_demographics_birthdate_Searchbuttontext ;
      private String Ddo_view_lpi_br_demographics_ethnic_Caption ;
      private String Ddo_view_lpi_br_demographics_ethnic_Tooltip ;
      private String Ddo_view_lpi_br_demographics_ethnic_Cls ;
      private String Ddo_view_lpi_br_demographics_ethnic_Filteredtext_set ;
      private String Ddo_view_lpi_br_demographics_ethnic_Selectedvalue_set ;
      private String Ddo_view_lpi_br_demographics_ethnic_Dropdownoptionstype ;
      private String Ddo_view_lpi_br_demographics_ethnic_Titlecontrolidtoreplace ;
      private String Ddo_view_lpi_br_demographics_ethnic_Sortedstatus ;
      private String Ddo_view_lpi_br_demographics_ethnic_Filtertype ;
      private String Ddo_view_lpi_br_demographics_ethnic_Datalisttype ;
      private String Ddo_view_lpi_br_demographics_ethnic_Datalistproc ;
      private String Ddo_view_lpi_br_demographics_ethnic_Sortasc ;
      private String Ddo_view_lpi_br_demographics_ethnic_Sortdsc ;
      private String Ddo_view_lpi_br_demographics_ethnic_Loadingdata ;
      private String Ddo_view_lpi_br_demographics_ethnic_Cleanfilter ;
      private String Ddo_view_lpi_br_demographics_ethnic_Noresultsfound ;
      private String Ddo_view_lpi_br_demographics_ethnic_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divUnnamedtableiew_lpi_br_information_patientno_Internalname ;
      private String lblFiltertextview_lpi_br_information_patientno_Internalname ;
      private String lblFiltertextview_lpi_br_information_patientno_Jsonclick ;
      private String edtavView_lpi_br_information_patientno_Internalname ;
      private String TempTags ;
      private String edtavView_lpi_br_information_patientno_Jsonclick ;
      private String divTablesplittedfiltertextview_lpi_br_demographics_birthdate_Internalname ;
      private String lblFiltertextview_lpi_br_demographics_birthdate_Internalname ;
      private String lblFiltertextview_lpi_br_demographics_birthdate_Jsonclick ;
      private String divUnnamedtableiew_lpi_br_demographics_ethnic_Internalname ;
      private String lblFiltertextview_lpi_br_demographics_ethnic_Internalname ;
      private String lblFiltertextview_lpi_br_demographics_ethnic_Jsonclick ;
      private String dynavView_lpi_br_demographics_ethnic_Internalname ;
      private String dynavView_lpi_br_demographics_ethnic_Jsonclick ;
      private String divUnnamedtableiew_lpi_br_demographics_sex_Internalname ;
      private String lblFiltertextview_lpi_br_demographics_sex_Internalname ;
      private String lblFiltertextview_lpi_br_demographics_sex_Jsonclick ;
      private String dynavView_lpi_br_demographics_sex_Internalname ;
      private String dynavView_lpi_br_demographics_sex_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtVIEW_LPI_BR_Information_PatientNo_Title ;
      private String edtVIEW_LPI_BR_Demographics_Sex_Title ;
      private String edtVIEW_LPI_BR_Demographics_BirthDate_Title ;
      private String edtVIEW_LPI_BR_Demographics_Ethnic_Title ;
      private String subGrid_Header ;
      private String edtavPatientretenant_Link ;
      private String edtavPatientretenant_Tooltiptext ;
      private String edtavPatient_entity_Link ;
      private String edtavPatient_entity_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_view_lpi_br_information_patientno_Internalname ;
      private String edtavDdo_view_lpi_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_lpi_br_demographics_sex_Internalname ;
      private String edtavDdo_view_lpi_br_demographics_sextitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_lpi_br_demographics_birthdate_Internalname ;
      private String edtavDdo_view_lpi_br_demographics_birthdatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_lpi_br_demographics_ethnic_Internalname ;
      private String edtavDdo_view_lpi_br_demographics_ethnictitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfview_lpi_br_information_patientno_Internalname ;
      private String edtavTfview_lpi_br_information_patientno_sel_Internalname ;
      private String edtavTfview_lpi_br_demographics_sex_Internalname ;
      private String edtavTfview_lpi_br_demographics_sex_sel_Internalname ;
      private String edtavTfview_lpi_br_demographics_birthdate_Internalname ;
      private String edtavTfview_lpi_br_demographics_birthdate_Jsonclick ;
      private String edtavTfview_lpi_br_demographics_birthdate_to_Internalname ;
      private String edtavTfview_lpi_br_demographics_birthdate_to_Jsonclick ;
      private String divDdo_view_lpi_br_demographics_birthdateauxdates_Internalname ;
      private String edtavDdo_view_lpi_br_demographics_birthdateauxdate_Internalname ;
      private String edtavDdo_view_lpi_br_demographics_birthdateauxdate_Jsonclick ;
      private String edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Internalname ;
      private String edtavDdo_view_lpi_br_demographics_birthdateauxdateto_Jsonclick ;
      private String edtavTfview_lpi_br_demographics_ethnic_Internalname ;
      private String edtavTfview_lpi_br_demographics_ethnic_sel_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavPatientretenant_Internalname ;
      private String edtavPatient_entity_Internalname ;
      private String edtVIEW_LPI_BR_Information_ID_Internalname ;
      private String edtVIEW_LPI_BR_Information_PatientNo_Internalname ;
      private String edtVIEW_LPI_BR_Demographics_Sex_Internalname ;
      private String edtVIEW_LPI_BR_Demographics_BirthDate_Internalname ;
      private String edtVIEW_LPI_BR_Demographics_Ethnic_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String cmbavView_lpi_br_demographics_birthdateoperator_Internalname ;
      private String edtavView_lpi_br_demographics_birthdate_Internalname ;
      private String edtavView_lpi_br_demographics_birthdate_to_Internalname ;
      private String GXt_char2 ;
      private String tblTablemergedview_lpi_br_demographics_birthdate_Internalname ;
      private String cmbavView_lpi_br_demographics_birthdateoperator_Jsonclick ;
      private String edtavView_lpi_br_demographics_birthdate_Jsonclick ;
      private String cellView_lpi_br_demographics_birthdate_rangemiddletext_1_cell_Internalname ;
      private String lblView_lpi_br_demographics_birthdate_rangemiddletext_1_Internalname ;
      private String lblView_lpi_br_demographics_birthdate_rangemiddletext_1_Jsonclick ;
      private String cellView_lpi_br_demographics_birthdate_to_cell_Internalname ;
      private String edtavView_lpi_br_demographics_birthdate_to_Jsonclick ;
      private String sGXsfl_68_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtVIEW_LPI_BR_Information_ID_Jsonclick ;
      private String edtVIEW_LPI_BR_Information_PatientNo_Jsonclick ;
      private String edtVIEW_LPI_BR_Demographics_Sex_Jsonclick ;
      private String edtVIEW_LPI_BR_Demographics_BirthDate_Jsonclick ;
      private String edtVIEW_LPI_BR_Demographics_Ethnic_Jsonclick ;
      private DateTime AV18VIEW_LPI_BR_Demographics_BirthDate ;
      private DateTime AV17VIEW_LPI_BR_Demographics_BirthDate_To ;
      private DateTime AV31TFVIEW_LPI_BR_Demographics_BirthDate ;
      private DateTime AV32TFVIEW_LPI_BR_Demographics_BirthDate_To ;
      private DateTime A523VIEW_LPI_BR_Demographics_BirthDate ;
      private DateTime AV33DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDate ;
      private DateTime AV34DDO_VIEW_LPI_BR_Demographics_BirthDateAuxDateTo ;
      private DateTime AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate ;
      private DateTime AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ;
      private DateTime AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ;
      private DateTime AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV46IsAuthorized_PatientReTenant ;
      private bool AV48IsAuthorized_Patient_Entity ;
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
      private bool Ddo_view_lpi_br_information_patientno_Includesortasc ;
      private bool Ddo_view_lpi_br_information_patientno_Includesortdsc ;
      private bool Ddo_view_lpi_br_information_patientno_Includefilter ;
      private bool Ddo_view_lpi_br_information_patientno_Filterisrange ;
      private bool Ddo_view_lpi_br_information_patientno_Includedatalist ;
      private bool Ddo_view_lpi_br_demographics_sex_Includesortasc ;
      private bool Ddo_view_lpi_br_demographics_sex_Includesortdsc ;
      private bool Ddo_view_lpi_br_demographics_sex_Includefilter ;
      private bool Ddo_view_lpi_br_demographics_sex_Filterisrange ;
      private bool Ddo_view_lpi_br_demographics_sex_Includedatalist ;
      private bool Ddo_view_lpi_br_demographics_birthdate_Includesortasc ;
      private bool Ddo_view_lpi_br_demographics_birthdate_Includesortdsc ;
      private bool Ddo_view_lpi_br_demographics_birthdate_Includefilter ;
      private bool Ddo_view_lpi_br_demographics_birthdate_Filterisrange ;
      private bool Ddo_view_lpi_br_demographics_birthdate_Includedatalist ;
      private bool Ddo_view_lpi_br_demographics_ethnic_Includesortasc ;
      private bool Ddo_view_lpi_br_demographics_ethnic_Includesortdsc ;
      private bool Ddo_view_lpi_br_demographics_ethnic_Includefilter ;
      private bool Ddo_view_lpi_br_demographics_ethnic_Filterisrange ;
      private bool Ddo_view_lpi_br_demographics_ethnic_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_68_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV49IsManager ;
      private bool gx_refresh_fired ;
      private bool GXt_boolean1 ;
      private bool AV45PatientReTenant_IsBlob ;
      private bool AV47Patient_Entity_IsBlob ;
      private String AV53tTenantCode ;
      private String AV15VIEW_LPI_BR_Information_PatientNo ;
      private String AV19VIEW_LPI_BR_Demographics_Ethnic ;
      private String AV20VIEW_LPI_BR_Demographics_Sex ;
      private String AV23TFVIEW_LPI_BR_Information_PatientNo ;
      private String AV24TFVIEW_LPI_BR_Information_PatientNo_Sel ;
      private String AV27TFVIEW_LPI_BR_Demographics_Sex ;
      private String AV28TFVIEW_LPI_BR_Demographics_Sex_Sel ;
      private String AV37TFVIEW_LPI_BR_Demographics_Ethnic ;
      private String AV38TFVIEW_LPI_BR_Demographics_Ethnic_Sel ;
      private String AV25ddo_VIEW_LPI_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV29ddo_VIEW_LPI_BR_Demographics_SexTitleControlIdToReplace ;
      private String AV35ddo_VIEW_LPI_BR_Demographics_BirthDateTitleControlIdToReplace ;
      private String AV39ddo_VIEW_LPI_BR_Demographics_EthnicTitleControlIdToReplace ;
      private String A519VIEW_LPI_BR_Information_PatientNo ;
      private String A522VIEW_LPI_BR_Demographics_Sex ;
      private String A524VIEW_LPI_BR_Demographics_Ethnic ;
      private String AV70Patientretenant_GXI ;
      private String AV71Patient_entity_GXI ;
      private String lV57BR_InformationListDS_1_View_lpi_br_information_patientno ;
      private String lV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno ;
      private String lV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ;
      private String lV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ;
      private String AV57BR_InformationListDS_1_View_lpi_br_information_patientno ;
      private String AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic ;
      private String AV61BR_InformationListDS_5_View_lpi_br_demographics_sex ;
      private String AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ;
      private String AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno ;
      private String AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ;
      private String AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ;
      private String AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ;
      private String AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ;
      private String AV50tCurrentCode ;
      private String AV45PatientReTenant ;
      private String AV47Patient_Entity ;
      private GxSimpleCollection<long> AV51oBR_Information_ID ;
      private GxSimpleCollection<long> GXt_objcol_int3 ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_view_lpi_br_information_patientno ;
      private GXUserControl ucDdo_view_lpi_br_demographics_sex ;
      private GXUserControl ucDdo_view_lpi_br_demographics_birthdate ;
      private GXUserControl ucDdo_view_lpi_br_demographics_ethnic ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavView_lpi_br_demographics_birthdateoperator ;
      private GXCombobox dynavView_lpi_br_demographics_ethnic ;
      private GXCombobox dynavView_lpi_br_demographics_sex ;
      private IDataStoreProvider pr_default ;
      private long[] H00A02_A167XT_DefineCodeID ;
      private String[] H00A02_A168XT_DefineCodeName ;
      private bool[] H00A02_n168XT_DefineCodeName ;
      private long[] H00A02_A165XT_DefindcodeTypeID ;
      private String[] H00A02_A432XT_TenantCode ;
      private bool[] H00A02_n432XT_TenantCode ;
      private long[] H00A03_A167XT_DefineCodeID ;
      private String[] H00A03_A168XT_DefineCodeName ;
      private bool[] H00A03_n168XT_DefineCodeName ;
      private long[] H00A03_A165XT_DefindcodeTypeID ;
      private String[] H00A03_A432XT_TenantCode ;
      private bool[] H00A03_n432XT_TenantCode ;
      private String[] H00A04_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private DateTime[] H00A04_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] H00A04_A522VIEW_LPI_BR_Demographics_Sex ;
      private String[] H00A04_A519VIEW_LPI_BR_Information_PatientNo ;
      private long[] H00A04_A520VIEW_LPI_BR_Information_ID ;
      private long[] H00A05_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private IGxSession AV21Session ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV22VIEW_LPI_BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV26VIEW_LPI_BR_Demographics_SexTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV30VIEW_LPI_BR_Demographics_BirthDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36VIEW_LPI_BR_Demographics_EthnicTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV40DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons4 ;
   }

   public class br_informationlist__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00A04( IGxContext context ,
                                             long A520VIEW_LPI_BR_Information_ID ,
                                             GxSimpleCollection<long> AV51oBR_Information_ID ,
                                             String AV57BR_InformationListDS_1_View_lpi_br_information_patientno ,
                                             short AV16VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                             DateTime AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate ,
                                             DateTime AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ,
                                             String AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic ,
                                             String AV61BR_InformationListDS_5_View_lpi_br_demographics_sex ,
                                             String AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ,
                                             String AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno ,
                                             String AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ,
                                             String AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ,
                                             DateTime AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ,
                                             DateTime AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ,
                                             String AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ,
                                             String AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ,
                                             String A519VIEW_LPI_BR_Information_PatientNo ,
                                             DateTime A523VIEW_LPI_BR_Demographics_BirthDate ,
                                             String A524VIEW_LPI_BR_Demographics_Ethnic ,
                                             String A522VIEW_LPI_BR_Demographics_Sex ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [16] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [VIEW_LPI_BR_Demographics_Ethnic], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Information_PatientNo], [VIEW_LPI_BR_Information_ID]";
         sFromString = " FROM dbo.[view_lastest_patient_info] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV51oBR_Information_ID, "[VIEW_LPI_BR_Information_ID] IN (", ")") + ")";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57BR_InformationListDS_1_View_lpi_br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] like '%' + @lV57BR_InformationListDS_1_View_lpi_br_information_patientno + '%')";
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ( AV16VIEW_LPI_BR_Demographics_BirthDateOperator == 0 ) && ( ! (DateTime.MinValue==AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] >= @AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate)";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ( AV16VIEW_LPI_BR_Demographics_BirthDateOperator == 0 ) && ( ! (DateTime.MinValue==AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] <= @AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] = @AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_InformationListDS_5_View_lpi_br_demographics_sex)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] = @AV61BR_InformationListDS_5_View_lpi_br_demographics_sex)";
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] like @lV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno)";
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] = @AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)";
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] like @lV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex)";
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] = @AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)";
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] >= @AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate)";
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] <= @AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to)";
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] like @lV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic)";
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] = @AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)";
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [VIEW_LPI_BR_Information_PatientNo]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [VIEW_LPI_BR_Information_PatientNo] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [VIEW_LPI_BR_Demographics_Sex]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [VIEW_LPI_BR_Demographics_Sex] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [VIEW_LPI_BR_Demographics_BirthDate]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [VIEW_LPI_BR_Demographics_BirthDate] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [VIEW_LPI_BR_Demographics_Ethnic]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [VIEW_LPI_BR_Demographics_Ethnic] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [VIEW_LPI_BR_Information_ID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      protected Object[] conditional_H00A05( IGxContext context ,
                                             long A520VIEW_LPI_BR_Information_ID ,
                                             GxSimpleCollection<long> AV51oBR_Information_ID ,
                                             String AV57BR_InformationListDS_1_View_lpi_br_information_patientno ,
                                             short AV16VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                             DateTime AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate ,
                                             DateTime AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ,
                                             String AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic ,
                                             String AV61BR_InformationListDS_5_View_lpi_br_demographics_sex ,
                                             String AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ,
                                             String AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno ,
                                             String AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ,
                                             String AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ,
                                             DateTime AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ,
                                             DateTime AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ,
                                             String AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ,
                                             String AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ,
                                             String A519VIEW_LPI_BR_Information_PatientNo ,
                                             DateTime A523VIEW_LPI_BR_Demographics_BirthDate ,
                                             String A524VIEW_LPI_BR_Demographics_Ethnic ,
                                             String A522VIEW_LPI_BR_Demographics_Sex ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int7 ;
         GXv_int7 = new short [13] ;
         Object[] GXv_Object8 ;
         GXv_Object8 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM dbo.[view_lastest_patient_info] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV51oBR_Information_ID, "[VIEW_LPI_BR_Information_ID] IN (", ")") + ")";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57BR_InformationListDS_1_View_lpi_br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] like '%' + @lV57BR_InformationListDS_1_View_lpi_br_information_patientno + '%')";
         }
         else
         {
            GXv_int7[0] = 1;
         }
         if ( ( AV16VIEW_LPI_BR_Demographics_BirthDateOperator == 0 ) && ( ! (DateTime.MinValue==AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] >= @AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate)";
         }
         else
         {
            GXv_int7[1] = 1;
         }
         if ( ( AV16VIEW_LPI_BR_Demographics_BirthDateOperator == 0 ) && ( ! (DateTime.MinValue==AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] <= @AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to)";
         }
         else
         {
            GXv_int7[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] = @AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic)";
         }
         else
         {
            GXv_int7[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_InformationListDS_5_View_lpi_br_demographics_sex)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] = @AV61BR_InformationListDS_5_View_lpi_br_demographics_sex)";
         }
         else
         {
            GXv_int7[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] like @lV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno)";
         }
         else
         {
            GXv_int7[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] = @AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)";
         }
         else
         {
            GXv_int7[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] like @lV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex)";
         }
         else
         {
            GXv_int7[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] = @AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)";
         }
         else
         {
            GXv_int7[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] >= @AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate)";
         }
         else
         {
            GXv_int7[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] <= @AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to)";
         }
         else
         {
            GXv_int7[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] like @lV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic)";
         }
         else
         {
            GXv_int7[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] = @AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)";
         }
         else
         {
            GXv_int7[12] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
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
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object8[0] = scmdbuf;
         GXv_Object8[1] = GXv_int7;
         return GXv_Object8 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 2 :
                     return conditional_H00A04(context, (long)dynConstraints[0] , (GxSimpleCollection<long>)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (short)dynConstraints[20] , (bool)dynConstraints[21] );
               case 3 :
                     return conditional_H00A05(context, (long)dynConstraints[0] , (GxSimpleCollection<long>)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (short)dynConstraints[20] , (bool)dynConstraints[21] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00A02 ;
          prmH00A02 = new Object[] {
          new Object[] {"@AV53tTenantCode",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmH00A03 ;
          prmH00A03 = new Object[] {
          new Object[] {"@AV53tTenantCode",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmH00A04 ;
          prmH00A04 = new Object[] {
          new Object[] {"@lV57BR_InformationListDS_1_View_lpi_br_information_patientno",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV61BR_InformationListDS_5_View_lpi_br_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00A05 ;
          prmH00A05 = new Object[] {
          new Object[] {"@lV57BR_InformationListDS_1_View_lpi_br_information_patientno",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV58BR_InformationListDS_2_View_lpi_br_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV59BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV60BR_InformationListDS_4_View_lpi_br_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV61BR_InformationListDS_5_View_lpi_br_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV62BR_InformationListDS_6_Tfview_lpi_br_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV63BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV64BR_InformationListDS_8_Tfview_lpi_br_demographics_sex",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV65BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV66BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV67BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV68BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV69BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel",SqlDbType.NVarChar,4000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00A02", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 9) AND ([XT_TenantCode] = @AV53tTenantCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00A02,0,0,true,false )
             ,new CursorDef("H00A03", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 7) AND ([XT_TenantCode] = @AV53tTenantCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00A03,0,0,true,false )
             ,new CursorDef("H00A04", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00A04,11,0,true,false )
             ,new CursorDef("H00A05", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00A05,1,0,true,false )
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
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                return;
             case 3 :
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[18]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[25]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[26]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[29]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[30]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[31]);
                }
                return;
             case 3 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                return;
       }
    }

 }

}
