/*
               File: BR_Medication_SchemeWW
        Description:  药物治疗化疗方案
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:2:1.64
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
   public class br_medication_schemeww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_medication_schemeww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_schemeww( IGxContext context )
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
               AV17TFBR_Medication_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_Medication_SchemeID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_MedicationID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV52TFBR_Medication_Chem_Name = GetNextPar( );
               AV53TFBR_Medication_Chem_Name_Sel = GetNextPar( );
               AV56TFBR_Medication_Chem_Cycle = NumberUtil.Val( GetNextPar( ), ".");
               AV57TFBR_Medication_Chem_Cycle_To = NumberUtil.Val( GetNextPar( ), ".");
               AV60TFBR_Medication_Chem_Line = GetNextPar( );
               AV61TFBR_Medication_Chem_Line_Sel = GetNextPar( );
               AV68TFBR_Medication_Chem_Detail = GetNextPar( );
               AV69TFBR_Medication_Chem_Detail_Sel = GetNextPar( );
               AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_MedicationIDTitleControlIdToReplace = GetNextPar( );
               AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace = GetNextPar( );
               AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = GetNextPar( );
               AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace = GetNextPar( );
               AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = GetNextPar( );
               AV88Pgmname = GetNextPar( );
               AV47IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV49IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_SchemeID, AV18TFBR_Medication_SchemeID_To, AV21TFBR_MedicationID, AV22TFBR_MedicationID_To, AV52TFBR_Medication_Chem_Name, AV53TFBR_Medication_Chem_Name_Sel, AV56TFBR_Medication_Chem_Cycle, AV57TFBR_Medication_Chem_Cycle_To, AV60TFBR_Medication_Chem_Line, AV61TFBR_Medication_Chem_Line_Sel, AV68TFBR_Medication_Chem_Detail, AV69TFBR_Medication_Chem_Detail_Sel, AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV23ddo_BR_MedicationIDTitleControlIdToReplace, AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace, AV88Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
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
         PA4Z2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4Z2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227122194", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medication_schemeww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Medication_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_SCHEMEID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Medication_SchemeID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATIONID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_MedicationID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_CHEM_NAME", AV52TFBR_Medication_Chem_Name);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_CHEM_NAME_SEL", AV53TFBR_Medication_Chem_Name_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_CHEM_CYCLE", StringUtil.LTrim( StringUtil.NToC( AV56TFBR_Medication_Chem_Cycle, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_CHEM_CYCLE_TO", StringUtil.LTrim( StringUtil.NToC( AV57TFBR_Medication_Chem_Cycle_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_CHEM_LINE", AV60TFBR_Medication_Chem_Line);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_CHEM_LINE_SEL", AV61TFBR_Medication_Chem_Line_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_CHEM_DETAIL", AV68TFBR_Medication_Chem_Detail);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_CHEM_DETAIL_SEL", AV69TFBR_Medication_Chem_Detail_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA", AV16BR_Medication_SchemeIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA", AV16BR_Medication_SchemeIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATIONIDTITLEFILTERDATA", AV20BR_MedicationIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATIONIDTITLEFILTERDATA", AV20BR_MedicationIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA", AV51BR_Medication_Chem_NameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA", AV51BR_Medication_Chem_NameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA", AV55BR_Medication_Chem_CycleTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA", AV55BR_Medication_Chem_CycleTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_CHEM_LINETITLEFILTERDATA", AV59BR_Medication_Chem_LineTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_CHEM_LINETITLEFILTERDATA", AV59BR_Medication_Chem_LineTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA", AV67BR_Medication_Chem_DetailTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA", AV67BR_Medication_Chem_DetailTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV88Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV47IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV49IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Caption", StringUtil.RTrim( Ddo_br_medication_schemeid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Tooltip", StringUtil.RTrim( Ddo_br_medication_schemeid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Cls", StringUtil.RTrim( Ddo_br_medication_schemeid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_schemeid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medication_schemeid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_schemeid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_schemeid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_schemeid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_schemeid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_schemeid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_schemeid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filtertype", StringUtil.RTrim( Ddo_br_medication_schemeid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_schemeid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_schemeid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Sortasc", StringUtil.RTrim( Ddo_br_medication_schemeid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Sortdsc", StringUtil.RTrim( Ddo_br_medication_schemeid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_schemeid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medication_schemeid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Rangefilterto", StringUtil.RTrim( Ddo_br_medication_schemeid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_schemeid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Caption", StringUtil.RTrim( Ddo_br_medication_chem_name_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Tooltip", StringUtil.RTrim( Ddo_br_medication_chem_name_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Cls", StringUtil.RTrim( Ddo_br_medication_chem_name_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_chem_name_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_chem_name_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_chem_name_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_chem_name_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_chem_name_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_chem_name_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_chem_name_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_chem_name_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Filtertype", StringUtil.RTrim( Ddo_br_medication_chem_name_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_chem_name_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_chem_name_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Datalisttype", StringUtil.RTrim( Ddo_br_medication_chem_name_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Datalistproc", StringUtil.RTrim( Ddo_br_medication_chem_name_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_chem_name_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Sortasc", StringUtil.RTrim( Ddo_br_medication_chem_name_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Sortdsc", StringUtil.RTrim( Ddo_br_medication_chem_name_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Loadingdata", StringUtil.RTrim( Ddo_br_medication_chem_name_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_chem_name_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_chem_name_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_chem_name_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Caption", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Tooltip", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Cls", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_chem_cycle_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_chem_cycle_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_chem_cycle_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Filtertype", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_chem_cycle_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_chem_cycle_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Sortasc", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Rangefilterto", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Caption", StringUtil.RTrim( Ddo_br_medication_chem_line_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Tooltip", StringUtil.RTrim( Ddo_br_medication_chem_line_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Cls", StringUtil.RTrim( Ddo_br_medication_chem_line_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_chem_line_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_chem_line_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_chem_line_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_chem_line_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_chem_line_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_chem_line_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_chem_line_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_chem_line_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Filtertype", StringUtil.RTrim( Ddo_br_medication_chem_line_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_chem_line_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_chem_line_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Datalisttype", StringUtil.RTrim( Ddo_br_medication_chem_line_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Datalistproc", StringUtil.RTrim( Ddo_br_medication_chem_line_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_chem_line_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Sortasc", StringUtil.RTrim( Ddo_br_medication_chem_line_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_chem_line_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Loadingdata", StringUtil.RTrim( Ddo_br_medication_chem_line_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_chem_line_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_chem_line_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_chem_line_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Caption", StringUtil.RTrim( Ddo_br_medication_chem_detail_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Tooltip", StringUtil.RTrim( Ddo_br_medication_chem_detail_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Cls", StringUtil.RTrim( Ddo_br_medication_chem_detail_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_chem_detail_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_chem_detail_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_chem_detail_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_chem_detail_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_chem_detail_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_chem_detail_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_chem_detail_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_chem_detail_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Filtertype", StringUtil.RTrim( Ddo_br_medication_chem_detail_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_chem_detail_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_chem_detail_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Datalisttype", StringUtil.RTrim( Ddo_br_medication_chem_detail_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Datalistproc", StringUtil.RTrim( Ddo_br_medication_chem_detail_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_chem_detail_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Sortasc", StringUtil.RTrim( Ddo_br_medication_chem_detail_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Sortdsc", StringUtil.RTrim( Ddo_br_medication_chem_detail_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Loadingdata", StringUtil.RTrim( Ddo_br_medication_chem_detail_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_chem_detail_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_chem_detail_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_chem_detail_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_schemeid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_schemeid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicationid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medicationid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_chem_name_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_chem_name_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_line_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_chem_line_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_chem_line_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_detail_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_chem_detail_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_chem_detail_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_schemeid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_schemeid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicationid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medicationid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_chem_name_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_chem_name_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_line_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_chem_line_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_chem_line_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_detail_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_chem_detail_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_chem_detail_Selectedvalue_get));
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
            WE4Z2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4Z2( ) ;
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
         return formatLink("br_medication_schemeww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Medication_SchemeWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 药物治疗化疗方案" ;
      }

      protected void WB4Z0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication_SchemeWW.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV45Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV46Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV48Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
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
            ucDdo_br_medication_schemeid.SetProperty("Caption", Ddo_br_medication_schemeid_Caption);
            ucDdo_br_medication_schemeid.SetProperty("Tooltip", Ddo_br_medication_schemeid_Tooltip);
            ucDdo_br_medication_schemeid.SetProperty("Cls", Ddo_br_medication_schemeid_Cls);
            ucDdo_br_medication_schemeid.SetProperty("DropDownOptionsType", Ddo_br_medication_schemeid_Dropdownoptionstype);
            ucDdo_br_medication_schemeid.SetProperty("IncludeSortASC", Ddo_br_medication_schemeid_Includesortasc);
            ucDdo_br_medication_schemeid.SetProperty("IncludeSortDSC", Ddo_br_medication_schemeid_Includesortdsc);
            ucDdo_br_medication_schemeid.SetProperty("IncludeFilter", Ddo_br_medication_schemeid_Includefilter);
            ucDdo_br_medication_schemeid.SetProperty("FilterType", Ddo_br_medication_schemeid_Filtertype);
            ucDdo_br_medication_schemeid.SetProperty("FilterIsRange", Ddo_br_medication_schemeid_Filterisrange);
            ucDdo_br_medication_schemeid.SetProperty("IncludeDataList", Ddo_br_medication_schemeid_Includedatalist);
            ucDdo_br_medication_schemeid.SetProperty("SortASC", Ddo_br_medication_schemeid_Sortasc);
            ucDdo_br_medication_schemeid.SetProperty("SortDSC", Ddo_br_medication_schemeid_Sortdsc);
            ucDdo_br_medication_schemeid.SetProperty("CleanFilter", Ddo_br_medication_schemeid_Cleanfilter);
            ucDdo_br_medication_schemeid.SetProperty("RangeFilterFrom", Ddo_br_medication_schemeid_Rangefilterfrom);
            ucDdo_br_medication_schemeid.SetProperty("RangeFilterTo", Ddo_br_medication_schemeid_Rangefilterto);
            ucDdo_br_medication_schemeid.SetProperty("SearchButtonText", Ddo_br_medication_schemeid_Searchbuttontext);
            ucDdo_br_medication_schemeid.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_medication_schemeid.SetProperty("DropDownOptionsData", AV16BR_Medication_SchemeIDTitleFilterData);
            ucDdo_br_medication_schemeid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_schemeid_Internalname, "DDO_BR_MEDICATION_SCHEMEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemeWW.htm");
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
            ucDdo_br_medicationid.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsData", AV20BR_MedicationIDTitleFilterData);
            ucDdo_br_medicationid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicationid_Internalname, "DDO_BR_MEDICATIONIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname, AV23ddo_BR_MedicationIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemeWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_chem_name.SetProperty("Caption", Ddo_br_medication_chem_name_Caption);
            ucDdo_br_medication_chem_name.SetProperty("Tooltip", Ddo_br_medication_chem_name_Tooltip);
            ucDdo_br_medication_chem_name.SetProperty("Cls", Ddo_br_medication_chem_name_Cls);
            ucDdo_br_medication_chem_name.SetProperty("DropDownOptionsType", Ddo_br_medication_chem_name_Dropdownoptionstype);
            ucDdo_br_medication_chem_name.SetProperty("IncludeSortASC", Ddo_br_medication_chem_name_Includesortasc);
            ucDdo_br_medication_chem_name.SetProperty("IncludeSortDSC", Ddo_br_medication_chem_name_Includesortdsc);
            ucDdo_br_medication_chem_name.SetProperty("IncludeFilter", Ddo_br_medication_chem_name_Includefilter);
            ucDdo_br_medication_chem_name.SetProperty("FilterType", Ddo_br_medication_chem_name_Filtertype);
            ucDdo_br_medication_chem_name.SetProperty("FilterIsRange", Ddo_br_medication_chem_name_Filterisrange);
            ucDdo_br_medication_chem_name.SetProperty("IncludeDataList", Ddo_br_medication_chem_name_Includedatalist);
            ucDdo_br_medication_chem_name.SetProperty("DataListType", Ddo_br_medication_chem_name_Datalisttype);
            ucDdo_br_medication_chem_name.SetProperty("DataListProc", Ddo_br_medication_chem_name_Datalistproc);
            ucDdo_br_medication_chem_name.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medication_chem_name_Datalistupdateminimumcharacters);
            ucDdo_br_medication_chem_name.SetProperty("SortASC", Ddo_br_medication_chem_name_Sortasc);
            ucDdo_br_medication_chem_name.SetProperty("SortDSC", Ddo_br_medication_chem_name_Sortdsc);
            ucDdo_br_medication_chem_name.SetProperty("LoadingData", Ddo_br_medication_chem_name_Loadingdata);
            ucDdo_br_medication_chem_name.SetProperty("CleanFilter", Ddo_br_medication_chem_name_Cleanfilter);
            ucDdo_br_medication_chem_name.SetProperty("NoResultsFound", Ddo_br_medication_chem_name_Noresultsfound);
            ucDdo_br_medication_chem_name.SetProperty("SearchButtonText", Ddo_br_medication_chem_name_Searchbuttontext);
            ucDdo_br_medication_chem_name.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_medication_chem_name.SetProperty("DropDownOptionsData", AV51BR_Medication_Chem_NameTitleFilterData);
            ucDdo_br_medication_chem_name.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_chem_name_Internalname, "DDO_BR_MEDICATION_CHEM_NAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Internalname, AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemeWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_chem_cycle.SetProperty("Caption", Ddo_br_medication_chem_cycle_Caption);
            ucDdo_br_medication_chem_cycle.SetProperty("Tooltip", Ddo_br_medication_chem_cycle_Tooltip);
            ucDdo_br_medication_chem_cycle.SetProperty("Cls", Ddo_br_medication_chem_cycle_Cls);
            ucDdo_br_medication_chem_cycle.SetProperty("DropDownOptionsType", Ddo_br_medication_chem_cycle_Dropdownoptionstype);
            ucDdo_br_medication_chem_cycle.SetProperty("IncludeSortASC", Ddo_br_medication_chem_cycle_Includesortasc);
            ucDdo_br_medication_chem_cycle.SetProperty("IncludeSortDSC", Ddo_br_medication_chem_cycle_Includesortdsc);
            ucDdo_br_medication_chem_cycle.SetProperty("IncludeFilter", Ddo_br_medication_chem_cycle_Includefilter);
            ucDdo_br_medication_chem_cycle.SetProperty("FilterType", Ddo_br_medication_chem_cycle_Filtertype);
            ucDdo_br_medication_chem_cycle.SetProperty("FilterIsRange", Ddo_br_medication_chem_cycle_Filterisrange);
            ucDdo_br_medication_chem_cycle.SetProperty("IncludeDataList", Ddo_br_medication_chem_cycle_Includedatalist);
            ucDdo_br_medication_chem_cycle.SetProperty("SortASC", Ddo_br_medication_chem_cycle_Sortasc);
            ucDdo_br_medication_chem_cycle.SetProperty("SortDSC", Ddo_br_medication_chem_cycle_Sortdsc);
            ucDdo_br_medication_chem_cycle.SetProperty("CleanFilter", Ddo_br_medication_chem_cycle_Cleanfilter);
            ucDdo_br_medication_chem_cycle.SetProperty("RangeFilterFrom", Ddo_br_medication_chem_cycle_Rangefilterfrom);
            ucDdo_br_medication_chem_cycle.SetProperty("RangeFilterTo", Ddo_br_medication_chem_cycle_Rangefilterto);
            ucDdo_br_medication_chem_cycle.SetProperty("SearchButtonText", Ddo_br_medication_chem_cycle_Searchbuttontext);
            ucDdo_br_medication_chem_cycle.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_medication_chem_cycle.SetProperty("DropDownOptionsData", AV55BR_Medication_Chem_CycleTitleFilterData);
            ucDdo_br_medication_chem_cycle.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_chem_cycle_Internalname, "DDO_BR_MEDICATION_CHEM_CYCLEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Internalname, AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemeWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_chem_line.SetProperty("Caption", Ddo_br_medication_chem_line_Caption);
            ucDdo_br_medication_chem_line.SetProperty("Tooltip", Ddo_br_medication_chem_line_Tooltip);
            ucDdo_br_medication_chem_line.SetProperty("Cls", Ddo_br_medication_chem_line_Cls);
            ucDdo_br_medication_chem_line.SetProperty("DropDownOptionsType", Ddo_br_medication_chem_line_Dropdownoptionstype);
            ucDdo_br_medication_chem_line.SetProperty("IncludeSortASC", Ddo_br_medication_chem_line_Includesortasc);
            ucDdo_br_medication_chem_line.SetProperty("IncludeSortDSC", Ddo_br_medication_chem_line_Includesortdsc);
            ucDdo_br_medication_chem_line.SetProperty("IncludeFilter", Ddo_br_medication_chem_line_Includefilter);
            ucDdo_br_medication_chem_line.SetProperty("FilterType", Ddo_br_medication_chem_line_Filtertype);
            ucDdo_br_medication_chem_line.SetProperty("FilterIsRange", Ddo_br_medication_chem_line_Filterisrange);
            ucDdo_br_medication_chem_line.SetProperty("IncludeDataList", Ddo_br_medication_chem_line_Includedatalist);
            ucDdo_br_medication_chem_line.SetProperty("DataListType", Ddo_br_medication_chem_line_Datalisttype);
            ucDdo_br_medication_chem_line.SetProperty("DataListProc", Ddo_br_medication_chem_line_Datalistproc);
            ucDdo_br_medication_chem_line.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medication_chem_line_Datalistupdateminimumcharacters);
            ucDdo_br_medication_chem_line.SetProperty("SortASC", Ddo_br_medication_chem_line_Sortasc);
            ucDdo_br_medication_chem_line.SetProperty("SortDSC", Ddo_br_medication_chem_line_Sortdsc);
            ucDdo_br_medication_chem_line.SetProperty("LoadingData", Ddo_br_medication_chem_line_Loadingdata);
            ucDdo_br_medication_chem_line.SetProperty("CleanFilter", Ddo_br_medication_chem_line_Cleanfilter);
            ucDdo_br_medication_chem_line.SetProperty("NoResultsFound", Ddo_br_medication_chem_line_Noresultsfound);
            ucDdo_br_medication_chem_line.SetProperty("SearchButtonText", Ddo_br_medication_chem_line_Searchbuttontext);
            ucDdo_br_medication_chem_line.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_medication_chem_line.SetProperty("DropDownOptionsData", AV59BR_Medication_Chem_LineTitleFilterData);
            ucDdo_br_medication_chem_line.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_chem_line_Internalname, "DDO_BR_MEDICATION_CHEM_LINEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Internalname, AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemeWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_chem_detail.SetProperty("Caption", Ddo_br_medication_chem_detail_Caption);
            ucDdo_br_medication_chem_detail.SetProperty("Tooltip", Ddo_br_medication_chem_detail_Tooltip);
            ucDdo_br_medication_chem_detail.SetProperty("Cls", Ddo_br_medication_chem_detail_Cls);
            ucDdo_br_medication_chem_detail.SetProperty("DropDownOptionsType", Ddo_br_medication_chem_detail_Dropdownoptionstype);
            ucDdo_br_medication_chem_detail.SetProperty("IncludeSortASC", Ddo_br_medication_chem_detail_Includesortasc);
            ucDdo_br_medication_chem_detail.SetProperty("IncludeSortDSC", Ddo_br_medication_chem_detail_Includesortdsc);
            ucDdo_br_medication_chem_detail.SetProperty("IncludeFilter", Ddo_br_medication_chem_detail_Includefilter);
            ucDdo_br_medication_chem_detail.SetProperty("FilterType", Ddo_br_medication_chem_detail_Filtertype);
            ucDdo_br_medication_chem_detail.SetProperty("FilterIsRange", Ddo_br_medication_chem_detail_Filterisrange);
            ucDdo_br_medication_chem_detail.SetProperty("IncludeDataList", Ddo_br_medication_chem_detail_Includedatalist);
            ucDdo_br_medication_chem_detail.SetProperty("DataListType", Ddo_br_medication_chem_detail_Datalisttype);
            ucDdo_br_medication_chem_detail.SetProperty("DataListProc", Ddo_br_medication_chem_detail_Datalistproc);
            ucDdo_br_medication_chem_detail.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medication_chem_detail_Datalistupdateminimumcharacters);
            ucDdo_br_medication_chem_detail.SetProperty("SortASC", Ddo_br_medication_chem_detail_Sortasc);
            ucDdo_br_medication_chem_detail.SetProperty("SortDSC", Ddo_br_medication_chem_detail_Sortdsc);
            ucDdo_br_medication_chem_detail.SetProperty("LoadingData", Ddo_br_medication_chem_detail_Loadingdata);
            ucDdo_br_medication_chem_detail.SetProperty("CleanFilter", Ddo_br_medication_chem_detail_Cleanfilter);
            ucDdo_br_medication_chem_detail.SetProperty("NoResultsFound", Ddo_br_medication_chem_detail_Noresultsfound);
            ucDdo_br_medication_chem_detail.SetProperty("SearchButtonText", Ddo_br_medication_chem_detail_Searchbuttontext);
            ucDdo_br_medication_chem_detail.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_medication_chem_detail.SetProperty("DropDownOptionsData", AV67BR_Medication_Chem_DetailTitleFilterData);
            ucDdo_br_medication_chem_detail.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_chem_detail_Internalname, "DDO_BR_MEDICATION_CHEM_DETAILContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Internalname, AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemeWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_schemeid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Medication_SchemeID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_schemeid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_schemeid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_schemeid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Medication_SchemeID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_Medication_SchemeID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_schemeid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_schemeid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicationid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_MedicationID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_MedicationID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicationid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicationid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicationid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_MedicationID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_MedicationID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicationid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicationid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_chem_name_Internalname, AV52TFBR_Medication_Chem_Name, StringUtil.RTrim( context.localUtil.Format( AV52TFBR_Medication_Chem_Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_chem_name_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_chem_name_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_chem_name_sel_Internalname, AV53TFBR_Medication_Chem_Name_Sel, StringUtil.RTrim( context.localUtil.Format( AV53TFBR_Medication_Chem_Name_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_chem_name_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_chem_name_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_chem_cycle_Internalname, StringUtil.LTrim( StringUtil.NToC( AV56TFBR_Medication_Chem_Cycle, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV56TFBR_Medication_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_chem_cycle_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_chem_cycle_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_chem_cycle_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV57TFBR_Medication_Chem_Cycle_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV57TFBR_Medication_Chem_Cycle_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_chem_cycle_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_chem_cycle_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_chem_line_Internalname, AV60TFBR_Medication_Chem_Line, StringUtil.RTrim( context.localUtil.Format( AV60TFBR_Medication_Chem_Line, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_chem_line_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_chem_line_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_chem_line_sel_Internalname, AV61TFBR_Medication_Chem_Line_Sel, StringUtil.RTrim( context.localUtil.Format( AV61TFBR_Medication_Chem_Line_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_chem_line_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_chem_line_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_chem_detail_Internalname, AV68TFBR_Medication_Chem_Detail, StringUtil.RTrim( context.localUtil.Format( AV68TFBR_Medication_Chem_Detail, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_chem_detail_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_chem_detail_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_chem_detail_sel_Internalname, AV69TFBR_Medication_Chem_Detail_Sel, StringUtil.RTrim( context.localUtil.Format( AV69TFBR_Medication_Chem_Detail_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_chem_detail_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_chem_detail_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_SchemeWW.htm");
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

      protected void START4Z2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 药物治疗化疗方案", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP4Z0( ) ;
      }

      protected void WS4Z2( )
      {
         START4Z2( ) ;
         EVT4Z2( ) ;
      }

      protected void EVT4Z2( )
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
                              E114Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E124Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E134Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATIONID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E144Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_CHEM_NAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E154Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_CHEM_CYCLE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E164Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_CHEM_LINE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E174Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_CHEM_DETAIL.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E184Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E194Z2 ();
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
                              AV45Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV45Display)) ? AV85Display_GXI : context.convertURL( context.PathToRelativeUrl( AV45Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV45Display), true);
                              AV46Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)) ? AV86Update_GXI : context.convertURL( context.PathToRelativeUrl( AV46Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV46Update), true);
                              AV48Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete)) ? AV87Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV48Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV48Delete), true);
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
                                    E204Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E214Z2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E224Z2 ();
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
                                       /* Set Refresh If Tfbr_medication_schemeid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_SCHEMEID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Medication_SchemeID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_schemeid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_SCHEMEID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Medication_SchemeID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicationid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATIONID"), ".", ",") != Convert.ToDecimal( AV21TFBR_MedicationID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicationid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATIONID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_MedicationID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_chem_name Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_NAME"), AV52TFBR_Medication_Chem_Name) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_chem_name_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_NAME_SEL"), AV53TFBR_Medication_Chem_Name_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_chem_cycle Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_CHEM_CYCLE"), ".", ",") != AV56TFBR_Medication_Chem_Cycle )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_chem_cycle_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_CHEM_CYCLE_TO"), ".", ",") != AV57TFBR_Medication_Chem_Cycle_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_chem_line Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_LINE"), AV60TFBR_Medication_Chem_Line) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_chem_line_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_LINE_SEL"), AV61TFBR_Medication_Chem_Line_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_chem_detail Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_DETAIL"), AV68TFBR_Medication_Chem_Detail) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_chem_detail_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_DETAIL_SEL"), AV69TFBR_Medication_Chem_Detail_Sel) != 0 )
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

      protected void WE4Z2( )
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

      protected void PA4Z2( )
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
                                       long AV17TFBR_Medication_SchemeID ,
                                       long AV18TFBR_Medication_SchemeID_To ,
                                       long AV21TFBR_MedicationID ,
                                       long AV22TFBR_MedicationID_To ,
                                       String AV52TFBR_Medication_Chem_Name ,
                                       String AV53TFBR_Medication_Chem_Name_Sel ,
                                       decimal AV56TFBR_Medication_Chem_Cycle ,
                                       decimal AV57TFBR_Medication_Chem_Cycle_To ,
                                       String AV60TFBR_Medication_Chem_Line ,
                                       String AV61TFBR_Medication_Chem_Line_Sel ,
                                       String AV68TFBR_Medication_Chem_Detail ,
                                       String AV69TFBR_Medication_Chem_Detail_Sel ,
                                       String AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_MedicationIDTitleControlIdToReplace ,
                                       String AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace ,
                                       String AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace ,
                                       String AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace ,
                                       String AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace ,
                                       String AV88Pgmname ,
                                       bool AV47IsAuthorized_Update ,
                                       bool AV49IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF4Z2( ) ;
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
         RF4Z2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV88Pgmname = "BR_Medication_SchemeWW";
         context.Gx_err = 0;
      }

      protected void RF4Z2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E214Z2 ();
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
                                                 AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ,
                                                 AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ,
                                                 AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid ,
                                                 AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ,
                                                 AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ,
                                                 AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ,
                                                 AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ,
                                                 AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ,
                                                 AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ,
                                                 AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ,
                                                 AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ,
                                                 AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ,
                                                 A296BR_Medication_SchemeID ,
                                                 A119BR_MedicationID ,
                                                 A305BR_Medication_Chem_Name ,
                                                 A306BR_Medication_Chem_Cycle ,
                                                 A307BR_Medication_Chem_Line ,
                                                 A313BR_Medication_Chem_Detail ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = StringUtil.Concat( StringUtil.RTrim( AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name), "%", "");
            lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = StringUtil.Concat( StringUtil.RTrim( AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line), "%", "");
            lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = StringUtil.Concat( StringUtil.RTrim( AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail), "%", "");
            /* Using cursor H004Z2 */
            pr_default.execute(0, new Object[] {AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid, AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to, AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid, AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to, lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name, AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel, AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle, AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to, lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line, AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel, lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail, AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A313BR_Medication_Chem_Detail = H004Z2_A313BR_Medication_Chem_Detail[0];
               n313BR_Medication_Chem_Detail = H004Z2_n313BR_Medication_Chem_Detail[0];
               A307BR_Medication_Chem_Line = H004Z2_A307BR_Medication_Chem_Line[0];
               n307BR_Medication_Chem_Line = H004Z2_n307BR_Medication_Chem_Line[0];
               A306BR_Medication_Chem_Cycle = H004Z2_A306BR_Medication_Chem_Cycle[0];
               n306BR_Medication_Chem_Cycle = H004Z2_n306BR_Medication_Chem_Cycle[0];
               A305BR_Medication_Chem_Name = H004Z2_A305BR_Medication_Chem_Name[0];
               n305BR_Medication_Chem_Name = H004Z2_n305BR_Medication_Chem_Name[0];
               A119BR_MedicationID = H004Z2_A119BR_MedicationID[0];
               n119BR_MedicationID = H004Z2_n119BR_MedicationID[0];
               A296BR_Medication_SchemeID = H004Z2_A296BR_Medication_SchemeID[0];
               E224Z2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB4Z0( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes4Z2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_SCHEMEID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid = AV17TFBR_Medication_SchemeID;
         AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to = AV18TFBR_Medication_SchemeID_To;
         AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid = AV21TFBR_MedicationID;
         AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to = AV22TFBR_MedicationID_To;
         AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = AV52TFBR_Medication_Chem_Name;
         AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = AV53TFBR_Medication_Chem_Name_Sel;
         AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle = AV56TFBR_Medication_Chem_Cycle;
         AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to = AV57TFBR_Medication_Chem_Cycle_To;
         AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = AV60TFBR_Medication_Chem_Line;
         AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = AV61TFBR_Medication_Chem_Line_Sel;
         AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = AV68TFBR_Medication_Chem_Detail;
         AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = AV69TFBR_Medication_Chem_Detail_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ,
                                              AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ,
                                              AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid ,
                                              AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ,
                                              AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ,
                                              AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ,
                                              AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ,
                                              AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ,
                                              AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ,
                                              AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ,
                                              AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ,
                                              AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ,
                                              A296BR_Medication_SchemeID ,
                                              A119BR_MedicationID ,
                                              A305BR_Medication_Chem_Name ,
                                              A306BR_Medication_Chem_Cycle ,
                                              A307BR_Medication_Chem_Line ,
                                              A313BR_Medication_Chem_Detail ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = StringUtil.Concat( StringUtil.RTrim( AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name), "%", "");
         lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = StringUtil.Concat( StringUtil.RTrim( AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line), "%", "");
         lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = StringUtil.Concat( StringUtil.RTrim( AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail), "%", "");
         /* Using cursor H004Z3 */
         pr_default.execute(1, new Object[] {AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid, AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to, AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid, AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to, lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name, AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel, AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle, AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to, lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line, AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel, lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail, AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel});
         GRID_nRecordCount = H004Z3_AGRID_nRecordCount[0];
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
         AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid = AV17TFBR_Medication_SchemeID;
         AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to = AV18TFBR_Medication_SchemeID_To;
         AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid = AV21TFBR_MedicationID;
         AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to = AV22TFBR_MedicationID_To;
         AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = AV52TFBR_Medication_Chem_Name;
         AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = AV53TFBR_Medication_Chem_Name_Sel;
         AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle = AV56TFBR_Medication_Chem_Cycle;
         AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to = AV57TFBR_Medication_Chem_Cycle_To;
         AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = AV60TFBR_Medication_Chem_Line;
         AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = AV61TFBR_Medication_Chem_Line_Sel;
         AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = AV68TFBR_Medication_Chem_Detail;
         AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = AV69TFBR_Medication_Chem_Detail_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_SchemeID, AV18TFBR_Medication_SchemeID_To, AV21TFBR_MedicationID, AV22TFBR_MedicationID_To, AV52TFBR_Medication_Chem_Name, AV53TFBR_Medication_Chem_Name_Sel, AV56TFBR_Medication_Chem_Cycle, AV57TFBR_Medication_Chem_Cycle_To, AV60TFBR_Medication_Chem_Line, AV61TFBR_Medication_Chem_Line_Sel, AV68TFBR_Medication_Chem_Detail, AV69TFBR_Medication_Chem_Detail_Sel, AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV23ddo_BR_MedicationIDTitleControlIdToReplace, AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace, AV88Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid = AV17TFBR_Medication_SchemeID;
         AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to = AV18TFBR_Medication_SchemeID_To;
         AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid = AV21TFBR_MedicationID;
         AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to = AV22TFBR_MedicationID_To;
         AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = AV52TFBR_Medication_Chem_Name;
         AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = AV53TFBR_Medication_Chem_Name_Sel;
         AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle = AV56TFBR_Medication_Chem_Cycle;
         AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to = AV57TFBR_Medication_Chem_Cycle_To;
         AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = AV60TFBR_Medication_Chem_Line;
         AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = AV61TFBR_Medication_Chem_Line_Sel;
         AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = AV68TFBR_Medication_Chem_Detail;
         AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = AV69TFBR_Medication_Chem_Detail_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_SchemeID, AV18TFBR_Medication_SchemeID_To, AV21TFBR_MedicationID, AV22TFBR_MedicationID_To, AV52TFBR_Medication_Chem_Name, AV53TFBR_Medication_Chem_Name_Sel, AV56TFBR_Medication_Chem_Cycle, AV57TFBR_Medication_Chem_Cycle_To, AV60TFBR_Medication_Chem_Line, AV61TFBR_Medication_Chem_Line_Sel, AV68TFBR_Medication_Chem_Detail, AV69TFBR_Medication_Chem_Detail_Sel, AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV23ddo_BR_MedicationIDTitleControlIdToReplace, AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace, AV88Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid = AV17TFBR_Medication_SchemeID;
         AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to = AV18TFBR_Medication_SchemeID_To;
         AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid = AV21TFBR_MedicationID;
         AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to = AV22TFBR_MedicationID_To;
         AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = AV52TFBR_Medication_Chem_Name;
         AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = AV53TFBR_Medication_Chem_Name_Sel;
         AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle = AV56TFBR_Medication_Chem_Cycle;
         AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to = AV57TFBR_Medication_Chem_Cycle_To;
         AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = AV60TFBR_Medication_Chem_Line;
         AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = AV61TFBR_Medication_Chem_Line_Sel;
         AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = AV68TFBR_Medication_Chem_Detail;
         AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = AV69TFBR_Medication_Chem_Detail_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_SchemeID, AV18TFBR_Medication_SchemeID_To, AV21TFBR_MedicationID, AV22TFBR_MedicationID_To, AV52TFBR_Medication_Chem_Name, AV53TFBR_Medication_Chem_Name_Sel, AV56TFBR_Medication_Chem_Cycle, AV57TFBR_Medication_Chem_Cycle_To, AV60TFBR_Medication_Chem_Line, AV61TFBR_Medication_Chem_Line_Sel, AV68TFBR_Medication_Chem_Detail, AV69TFBR_Medication_Chem_Detail_Sel, AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV23ddo_BR_MedicationIDTitleControlIdToReplace, AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace, AV88Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid = AV17TFBR_Medication_SchemeID;
         AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to = AV18TFBR_Medication_SchemeID_To;
         AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid = AV21TFBR_MedicationID;
         AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to = AV22TFBR_MedicationID_To;
         AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = AV52TFBR_Medication_Chem_Name;
         AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = AV53TFBR_Medication_Chem_Name_Sel;
         AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle = AV56TFBR_Medication_Chem_Cycle;
         AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to = AV57TFBR_Medication_Chem_Cycle_To;
         AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = AV60TFBR_Medication_Chem_Line;
         AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = AV61TFBR_Medication_Chem_Line_Sel;
         AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = AV68TFBR_Medication_Chem_Detail;
         AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = AV69TFBR_Medication_Chem_Detail_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_SchemeID, AV18TFBR_Medication_SchemeID_To, AV21TFBR_MedicationID, AV22TFBR_MedicationID_To, AV52TFBR_Medication_Chem_Name, AV53TFBR_Medication_Chem_Name_Sel, AV56TFBR_Medication_Chem_Cycle, AV57TFBR_Medication_Chem_Cycle_To, AV60TFBR_Medication_Chem_Line, AV61TFBR_Medication_Chem_Line_Sel, AV68TFBR_Medication_Chem_Detail, AV69TFBR_Medication_Chem_Detail_Sel, AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV23ddo_BR_MedicationIDTitleControlIdToReplace, AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace, AV88Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid = AV17TFBR_Medication_SchemeID;
         AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to = AV18TFBR_Medication_SchemeID_To;
         AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid = AV21TFBR_MedicationID;
         AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to = AV22TFBR_MedicationID_To;
         AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = AV52TFBR_Medication_Chem_Name;
         AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = AV53TFBR_Medication_Chem_Name_Sel;
         AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle = AV56TFBR_Medication_Chem_Cycle;
         AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to = AV57TFBR_Medication_Chem_Cycle_To;
         AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = AV60TFBR_Medication_Chem_Line;
         AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = AV61TFBR_Medication_Chem_Line_Sel;
         AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = AV68TFBR_Medication_Chem_Detail;
         AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = AV69TFBR_Medication_Chem_Detail_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_SchemeID, AV18TFBR_Medication_SchemeID_To, AV21TFBR_MedicationID, AV22TFBR_MedicationID_To, AV52TFBR_Medication_Chem_Name, AV53TFBR_Medication_Chem_Name_Sel, AV56TFBR_Medication_Chem_Cycle, AV57TFBR_Medication_Chem_Cycle_To, AV60TFBR_Medication_Chem_Line, AV61TFBR_Medication_Chem_Line_Sel, AV68TFBR_Medication_Chem_Detail, AV69TFBR_Medication_Chem_Detail_Sel, AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV23ddo_BR_MedicationIDTitleControlIdToReplace, AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace, AV88Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP4Z0( )
      {
         /* Before Start, stand alone formulas. */
         AV88Pgmname = "BR_Medication_SchemeWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E204Z2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV40DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA"), AV16BR_Medication_SchemeIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATIONIDTITLEFILTERDATA"), AV20BR_MedicationIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA"), AV51BR_Medication_Chem_NameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA"), AV55BR_Medication_Chem_CycleTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_CHEM_LINETITLEFILTERDATA"), AV59BR_Medication_Chem_LineTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA"), AV67BR_Medication_Chem_DetailTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace", AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace);
            AV23ddo_BR_MedicationIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_MedicationIDTitleControlIdToReplace", AV23ddo_BR_MedicationIDTitleControlIdToReplace);
            AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace", AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace);
            AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace", AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace);
            AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace", AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace);
            AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace", AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_SCHEMEID");
               GX_FocusControl = edtavTfbr_medication_schemeid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_Medication_SchemeID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Medication_SchemeID), 18, 0)));
            }
            else
            {
               AV17TFBR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Medication_SchemeID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_SCHEMEID_TO");
               GX_FocusControl = edtavTfbr_medication_schemeid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_Medication_SchemeID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Medication_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Medication_SchemeID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_Medication_SchemeID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Medication_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Medication_SchemeID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATIONID");
               GX_FocusControl = edtavTfbr_medicationid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_MedicationID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_MedicationID), 18, 0)));
            }
            else
            {
               AV21TFBR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_MedicationID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATIONID_TO");
               GX_FocusControl = edtavTfbr_medicationid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_MedicationID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_MedicationID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_MedicationID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medicationid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_MedicationID_To), 18, 0)));
            }
            AV52TFBR_Medication_Chem_Name = cgiGet( edtavTfbr_medication_chem_name_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Medication_Chem_Name", AV52TFBR_Medication_Chem_Name);
            AV53TFBR_Medication_Chem_Name_Sel = cgiGet( edtavTfbr_medication_chem_name_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53TFBR_Medication_Chem_Name_Sel", AV53TFBR_Medication_Chem_Name_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_chem_cycle_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_chem_cycle_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_CHEM_CYCLE");
               GX_FocusControl = edtavTfbr_medication_chem_cycle_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV56TFBR_Medication_Chem_Cycle = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( AV56TFBR_Medication_Chem_Cycle, 15, 5)));
            }
            else
            {
               AV56TFBR_Medication_Chem_Cycle = context.localUtil.CToN( cgiGet( edtavTfbr_medication_chem_cycle_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( AV56TFBR_Medication_Chem_Cycle, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_chem_cycle_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_chem_cycle_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_CHEM_CYCLE_TO");
               GX_FocusControl = edtavTfbr_medication_chem_cycle_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV57TFBR_Medication_Chem_Cycle_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFBR_Medication_Chem_Cycle_To", StringUtil.LTrim( StringUtil.Str( AV57TFBR_Medication_Chem_Cycle_To, 15, 5)));
            }
            else
            {
               AV57TFBR_Medication_Chem_Cycle_To = context.localUtil.CToN( cgiGet( edtavTfbr_medication_chem_cycle_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFBR_Medication_Chem_Cycle_To", StringUtil.LTrim( StringUtil.Str( AV57TFBR_Medication_Chem_Cycle_To, 15, 5)));
            }
            AV60TFBR_Medication_Chem_Line = cgiGet( edtavTfbr_medication_chem_line_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Medication_Chem_Line", AV60TFBR_Medication_Chem_Line);
            AV61TFBR_Medication_Chem_Line_Sel = cgiGet( edtavTfbr_medication_chem_line_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61TFBR_Medication_Chem_Line_Sel", AV61TFBR_Medication_Chem_Line_Sel);
            AV68TFBR_Medication_Chem_Detail = cgiGet( edtavTfbr_medication_chem_detail_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFBR_Medication_Chem_Detail", AV68TFBR_Medication_Chem_Detail);
            AV69TFBR_Medication_Chem_Detail_Sel = cgiGet( edtavTfbr_medication_chem_detail_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFBR_Medication_Chem_Detail_Sel", AV69TFBR_Medication_Chem_Detail_Sel);
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
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
            Ddo_br_medication_schemeid_Caption = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Caption");
            Ddo_br_medication_schemeid_Tooltip = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Tooltip");
            Ddo_br_medication_schemeid_Cls = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Cls");
            Ddo_br_medication_schemeid_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Filteredtext_set");
            Ddo_br_medication_schemeid_Filteredtextto_set = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Filteredtextto_set");
            Ddo_br_medication_schemeid_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Dropdownoptionstype");
            Ddo_br_medication_schemeid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Titlecontrolidtoreplace");
            Ddo_br_medication_schemeid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Includesortasc"));
            Ddo_br_medication_schemeid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Includesortdsc"));
            Ddo_br_medication_schemeid_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Sortedstatus");
            Ddo_br_medication_schemeid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Includefilter"));
            Ddo_br_medication_schemeid_Filtertype = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Filtertype");
            Ddo_br_medication_schemeid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Filterisrange"));
            Ddo_br_medication_schemeid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Includedatalist"));
            Ddo_br_medication_schemeid_Sortasc = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Sortasc");
            Ddo_br_medication_schemeid_Sortdsc = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Sortdsc");
            Ddo_br_medication_schemeid_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Cleanfilter");
            Ddo_br_medication_schemeid_Rangefilterfrom = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Rangefilterfrom");
            Ddo_br_medication_schemeid_Rangefilterto = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Rangefilterto");
            Ddo_br_medication_schemeid_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Searchbuttontext");
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
            Ddo_br_medication_chem_name_Caption = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Caption");
            Ddo_br_medication_chem_name_Tooltip = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Tooltip");
            Ddo_br_medication_chem_name_Cls = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Cls");
            Ddo_br_medication_chem_name_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Filteredtext_set");
            Ddo_br_medication_chem_name_Selectedvalue_set = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Selectedvalue_set");
            Ddo_br_medication_chem_name_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Dropdownoptionstype");
            Ddo_br_medication_chem_name_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Titlecontrolidtoreplace");
            Ddo_br_medication_chem_name_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Includesortasc"));
            Ddo_br_medication_chem_name_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Includesortdsc"));
            Ddo_br_medication_chem_name_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Sortedstatus");
            Ddo_br_medication_chem_name_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Includefilter"));
            Ddo_br_medication_chem_name_Filtertype = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Filtertype");
            Ddo_br_medication_chem_name_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Filterisrange"));
            Ddo_br_medication_chem_name_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Includedatalist"));
            Ddo_br_medication_chem_name_Datalisttype = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Datalisttype");
            Ddo_br_medication_chem_name_Datalistproc = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Datalistproc");
            Ddo_br_medication_chem_name_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_chem_name_Sortasc = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Sortasc");
            Ddo_br_medication_chem_name_Sortdsc = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Sortdsc");
            Ddo_br_medication_chem_name_Loadingdata = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Loadingdata");
            Ddo_br_medication_chem_name_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Cleanfilter");
            Ddo_br_medication_chem_name_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Noresultsfound");
            Ddo_br_medication_chem_name_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Searchbuttontext");
            Ddo_br_medication_chem_cycle_Caption = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Caption");
            Ddo_br_medication_chem_cycle_Tooltip = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Tooltip");
            Ddo_br_medication_chem_cycle_Cls = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Cls");
            Ddo_br_medication_chem_cycle_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Filteredtext_set");
            Ddo_br_medication_chem_cycle_Filteredtextto_set = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Filteredtextto_set");
            Ddo_br_medication_chem_cycle_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Dropdownoptionstype");
            Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Titlecontrolidtoreplace");
            Ddo_br_medication_chem_cycle_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Includesortasc"));
            Ddo_br_medication_chem_cycle_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Includesortdsc"));
            Ddo_br_medication_chem_cycle_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Sortedstatus");
            Ddo_br_medication_chem_cycle_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Includefilter"));
            Ddo_br_medication_chem_cycle_Filtertype = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Filtertype");
            Ddo_br_medication_chem_cycle_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Filterisrange"));
            Ddo_br_medication_chem_cycle_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Includedatalist"));
            Ddo_br_medication_chem_cycle_Sortasc = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Sortasc");
            Ddo_br_medication_chem_cycle_Sortdsc = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Sortdsc");
            Ddo_br_medication_chem_cycle_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Cleanfilter");
            Ddo_br_medication_chem_cycle_Rangefilterfrom = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Rangefilterfrom");
            Ddo_br_medication_chem_cycle_Rangefilterto = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Rangefilterto");
            Ddo_br_medication_chem_cycle_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Searchbuttontext");
            Ddo_br_medication_chem_line_Caption = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Caption");
            Ddo_br_medication_chem_line_Tooltip = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Tooltip");
            Ddo_br_medication_chem_line_Cls = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Cls");
            Ddo_br_medication_chem_line_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Filteredtext_set");
            Ddo_br_medication_chem_line_Selectedvalue_set = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Selectedvalue_set");
            Ddo_br_medication_chem_line_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Dropdownoptionstype");
            Ddo_br_medication_chem_line_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Titlecontrolidtoreplace");
            Ddo_br_medication_chem_line_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Includesortasc"));
            Ddo_br_medication_chem_line_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Includesortdsc"));
            Ddo_br_medication_chem_line_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Sortedstatus");
            Ddo_br_medication_chem_line_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Includefilter"));
            Ddo_br_medication_chem_line_Filtertype = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Filtertype");
            Ddo_br_medication_chem_line_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Filterisrange"));
            Ddo_br_medication_chem_line_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Includedatalist"));
            Ddo_br_medication_chem_line_Datalisttype = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Datalisttype");
            Ddo_br_medication_chem_line_Datalistproc = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Datalistproc");
            Ddo_br_medication_chem_line_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_chem_line_Sortasc = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Sortasc");
            Ddo_br_medication_chem_line_Sortdsc = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Sortdsc");
            Ddo_br_medication_chem_line_Loadingdata = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Loadingdata");
            Ddo_br_medication_chem_line_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Cleanfilter");
            Ddo_br_medication_chem_line_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Noresultsfound");
            Ddo_br_medication_chem_line_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Searchbuttontext");
            Ddo_br_medication_chem_detail_Caption = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Caption");
            Ddo_br_medication_chem_detail_Tooltip = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Tooltip");
            Ddo_br_medication_chem_detail_Cls = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Cls");
            Ddo_br_medication_chem_detail_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Filteredtext_set");
            Ddo_br_medication_chem_detail_Selectedvalue_set = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Selectedvalue_set");
            Ddo_br_medication_chem_detail_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Dropdownoptionstype");
            Ddo_br_medication_chem_detail_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Titlecontrolidtoreplace");
            Ddo_br_medication_chem_detail_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Includesortasc"));
            Ddo_br_medication_chem_detail_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Includesortdsc"));
            Ddo_br_medication_chem_detail_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Sortedstatus");
            Ddo_br_medication_chem_detail_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Includefilter"));
            Ddo_br_medication_chem_detail_Filtertype = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Filtertype");
            Ddo_br_medication_chem_detail_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Filterisrange"));
            Ddo_br_medication_chem_detail_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Includedatalist"));
            Ddo_br_medication_chem_detail_Datalisttype = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Datalisttype");
            Ddo_br_medication_chem_detail_Datalistproc = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Datalistproc");
            Ddo_br_medication_chem_detail_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_chem_detail_Sortasc = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Sortasc");
            Ddo_br_medication_chem_detail_Sortdsc = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Sortdsc");
            Ddo_br_medication_chem_detail_Loadingdata = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Loadingdata");
            Ddo_br_medication_chem_detail_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Cleanfilter");
            Ddo_br_medication_chem_detail_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Noresultsfound");
            Ddo_br_medication_chem_detail_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medication_schemeid_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey");
            Ddo_br_medication_schemeid_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Filteredtext_get");
            Ddo_br_medication_schemeid_Filteredtextto_get = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Filteredtextto_get");
            Ddo_br_medicationid_Activeeventkey = cgiGet( "DDO_BR_MEDICATIONID_Activeeventkey");
            Ddo_br_medicationid_Filteredtext_get = cgiGet( "DDO_BR_MEDICATIONID_Filteredtext_get");
            Ddo_br_medicationid_Filteredtextto_get = cgiGet( "DDO_BR_MEDICATIONID_Filteredtextto_get");
            Ddo_br_medication_chem_name_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Activeeventkey");
            Ddo_br_medication_chem_name_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Filteredtext_get");
            Ddo_br_medication_chem_name_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Selectedvalue_get");
            Ddo_br_medication_chem_cycle_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Activeeventkey");
            Ddo_br_medication_chem_cycle_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Filteredtext_get");
            Ddo_br_medication_chem_cycle_Filteredtextto_get = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Filteredtextto_get");
            Ddo_br_medication_chem_line_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Activeeventkey");
            Ddo_br_medication_chem_line_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Filteredtext_get");
            Ddo_br_medication_chem_line_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Selectedvalue_get");
            Ddo_br_medication_chem_detail_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Activeeventkey");
            Ddo_br_medication_chem_detail_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Filteredtext_get");
            Ddo_br_medication_chem_detail_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_SCHEMEID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Medication_SchemeID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_SCHEMEID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Medication_SchemeID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATIONID"), ".", ",") != Convert.ToDecimal( AV21TFBR_MedicationID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATIONID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_MedicationID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_NAME"), AV52TFBR_Medication_Chem_Name) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_NAME_SEL"), AV53TFBR_Medication_Chem_Name_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_CHEM_CYCLE"), ".", ",") != AV56TFBR_Medication_Chem_Cycle )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_CHEM_CYCLE_TO"), ".", ",") != AV57TFBR_Medication_Chem_Cycle_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_LINE"), AV60TFBR_Medication_Chem_Line) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_LINE_SEL"), AV61TFBR_Medication_Chem_Line_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_DETAIL"), AV68TFBR_Medication_Chem_Detail) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_CHEM_DETAIL_SEL"), AV69TFBR_Medication_Chem_Detail_Sel) != 0 )
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
         E204Z2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E204Z2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_medication_schemeid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_schemeid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_schemeid_Visible), 5, 0)), true);
         edtavTfbr_medication_schemeid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_schemeid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_schemeid_to_Visible), 5, 0)), true);
         edtavTfbr_medicationid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicationid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicationid_Visible), 5, 0)), true);
         edtavTfbr_medicationid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicationid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicationid_to_Visible), 5, 0)), true);
         edtavTfbr_medication_chem_name_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_chem_name_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_chem_name_Visible), 5, 0)), true);
         edtavTfbr_medication_chem_name_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_chem_name_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_chem_name_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_chem_cycle_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_chem_cycle_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_chem_cycle_Visible), 5, 0)), true);
         edtavTfbr_medication_chem_cycle_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_chem_cycle_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_chem_cycle_to_Visible), 5, 0)), true);
         edtavTfbr_medication_chem_line_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_chem_line_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_chem_line_Visible), 5, 0)), true);
         edtavTfbr_medication_chem_line_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_chem_line_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_chem_line_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_chem_detail_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_chem_detail_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_chem_detail_Visible), 5, 0)), true);
         edtavTfbr_medication_chem_detail_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_chem_detail_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_chem_detail_sel_Visible), 5, 0)), true);
         Ddo_br_medication_schemeid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_SchemeID";
         ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "TitleControlIdToReplace", Ddo_br_medication_schemeid_Titlecontrolidtoreplace);
         AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace = Ddo_br_medication_schemeid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace", AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace);
         edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicationid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicationID";
         ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "TitleControlIdToReplace", Ddo_br_medicationid_Titlecontrolidtoreplace);
         AV23ddo_BR_MedicationIDTitleControlIdToReplace = Ddo_br_medicationid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_MedicationIDTitleControlIdToReplace", AV23ddo_BR_MedicationIDTitleControlIdToReplace);
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_chem_name_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Chem_Name";
         ucDdo_br_medication_chem_name.SendProperty(context, "", false, Ddo_br_medication_chem_name_Internalname, "TitleControlIdToReplace", Ddo_br_medication_chem_name_Titlecontrolidtoreplace);
         AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace = Ddo_br_medication_chem_name_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace", AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace);
         edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Chem_Cycle";
         ucDdo_br_medication_chem_cycle.SendProperty(context, "", false, Ddo_br_medication_chem_cycle_Internalname, "TitleControlIdToReplace", Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace);
         AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace", AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace);
         edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_chem_line_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Chem_Line";
         ucDdo_br_medication_chem_line.SendProperty(context, "", false, Ddo_br_medication_chem_line_Internalname, "TitleControlIdToReplace", Ddo_br_medication_chem_line_Titlecontrolidtoreplace);
         AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace = Ddo_br_medication_chem_line_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace", AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace);
         edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_chem_detail_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Chem_Detail";
         ucDdo_br_medication_chem_detail.SendProperty(context, "", false, Ddo_br_medication_chem_detail_Internalname, "TitleControlIdToReplace", Ddo_br_medication_chem_detail_Titlecontrolidtoreplace);
         AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = Ddo_br_medication_chem_detail_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace", AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace);
         edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 药物治疗化疗方案";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV40DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV40DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E214Z2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_Medication_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV51BR_Medication_Chem_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV55BR_Medication_Chem_CycleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV59BR_Medication_Chem_LineTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV67BR_Medication_Chem_DetailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Medication_SchemeID_Titleformat = 2;
         edtBR_Medication_SchemeID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物治疗化疗方案主键", AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Title", edtBR_Medication_SchemeID_Title, !bGXsfl_31_Refreshing);
         edtBR_MedicationID_Titleformat = 2;
         edtBR_MedicationID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物治疗主键", AV23ddo_BR_MedicationIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Title", edtBR_MedicationID_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_Chem_Name_Titleformat = 2;
         edtBR_Medication_Chem_Name_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案名称", AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Name_Internalname, "Title", edtBR_Medication_Chem_Name_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_Chem_Cycle_Titleformat = 2;
         edtBR_Medication_Chem_Cycle_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "周期", AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Cycle_Internalname, "Title", edtBR_Medication_Chem_Cycle_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_Chem_Line_Titleformat = 2;
         edtBR_Medication_Chem_Line_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "线级", AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Line_Internalname, "Title", edtBR_Medication_Chem_Line_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_Chem_Detail_Titleformat = 2;
         edtBR_Medication_Chem_Detail_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "描述化疗方案", AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Detail_Internalname, "Title", edtBR_Medication_Chem_Detail_Title, !bGXsfl_31_Refreshing);
         AV42GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridCurrentPage), 10, 0)));
         AV43GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridPageSize), 10, 0)));
         AV44GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44GridRecordCount), 10, 0)));
         AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid = AV17TFBR_Medication_SchemeID;
         AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to = AV18TFBR_Medication_SchemeID_To;
         AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid = AV21TFBR_MedicationID;
         AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to = AV22TFBR_MedicationID_To;
         AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = AV52TFBR_Medication_Chem_Name;
         AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = AV53TFBR_Medication_Chem_Name_Sel;
         AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle = AV56TFBR_Medication_Chem_Cycle;
         AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to = AV57TFBR_Medication_Chem_Cycle_To;
         AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = AV60TFBR_Medication_Chem_Line;
         AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = AV61TFBR_Medication_Chem_Line_Sel;
         AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = AV68TFBR_Medication_Chem_Detail;
         AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = AV69TFBR_Medication_Chem_Detail_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_SchemeIDTitleFilterData", AV16BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicationIDTitleFilterData", AV20BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Chem_NameTitleFilterData", AV51BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Chem_CycleTitleFilterData", AV55BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59BR_Medication_Chem_LineTitleFilterData", AV59BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67BR_Medication_Chem_DetailTitleFilterData", AV67BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E114Z2( )
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
            AV41PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV41PageToGo) ;
         }
      }

      protected void E124Z2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E134Z2( )
      {
         /* Ddo_br_medication_schemeid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_schemeid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_schemeid_Sortedstatus = "ASC";
            ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "SortedStatus", Ddo_br_medication_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_schemeid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_schemeid_Sortedstatus = "DSC";
            ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "SortedStatus", Ddo_br_medication_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_schemeid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_Medication_SchemeID = (long)(NumberUtil.Val( Ddo_br_medication_schemeid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Medication_SchemeID), 18, 0)));
            AV18TFBR_Medication_SchemeID_To = (long)(NumberUtil.Val( Ddo_br_medication_schemeid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Medication_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Medication_SchemeID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_SchemeIDTitleFilterData", AV16BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicationIDTitleFilterData", AV20BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Chem_NameTitleFilterData", AV51BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Chem_CycleTitleFilterData", AV55BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59BR_Medication_Chem_LineTitleFilterData", AV59BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67BR_Medication_Chem_DetailTitleFilterData", AV67BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E144Z2( )
      {
         /* Ddo_br_medicationid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medicationid_Sortedstatus = "ASC";
            ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medicationid_Sortedstatus = "DSC";
            ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV21TFBR_MedicationID = (long)(NumberUtil.Val( Ddo_br_medicationid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_MedicationID), 18, 0)));
            AV22TFBR_MedicationID_To = (long)(NumberUtil.Val( Ddo_br_medicationid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_MedicationID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_SchemeIDTitleFilterData", AV16BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicationIDTitleFilterData", AV20BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Chem_NameTitleFilterData", AV51BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Chem_CycleTitleFilterData", AV55BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59BR_Medication_Chem_LineTitleFilterData", AV59BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67BR_Medication_Chem_DetailTitleFilterData", AV67BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E154Z2( )
      {
         /* Ddo_br_medication_chem_name_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_chem_name_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_chem_name_Sortedstatus = "ASC";
            ucDdo_br_medication_chem_name.SendProperty(context, "", false, Ddo_br_medication_chem_name_Internalname, "SortedStatus", Ddo_br_medication_chem_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_name_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_chem_name_Sortedstatus = "DSC";
            ucDdo_br_medication_chem_name.SendProperty(context, "", false, Ddo_br_medication_chem_name_Internalname, "SortedStatus", Ddo_br_medication_chem_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_name_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV52TFBR_Medication_Chem_Name = Ddo_br_medication_chem_name_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Medication_Chem_Name", AV52TFBR_Medication_Chem_Name);
            AV53TFBR_Medication_Chem_Name_Sel = Ddo_br_medication_chem_name_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53TFBR_Medication_Chem_Name_Sel", AV53TFBR_Medication_Chem_Name_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_SchemeIDTitleFilterData", AV16BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicationIDTitleFilterData", AV20BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Chem_NameTitleFilterData", AV51BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Chem_CycleTitleFilterData", AV55BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59BR_Medication_Chem_LineTitleFilterData", AV59BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67BR_Medication_Chem_DetailTitleFilterData", AV67BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E164Z2( )
      {
         /* Ddo_br_medication_chem_cycle_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_chem_cycle_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_chem_cycle_Sortedstatus = "ASC";
            ucDdo_br_medication_chem_cycle.SendProperty(context, "", false, Ddo_br_medication_chem_cycle_Internalname, "SortedStatus", Ddo_br_medication_chem_cycle_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_cycle_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_chem_cycle_Sortedstatus = "DSC";
            ucDdo_br_medication_chem_cycle.SendProperty(context, "", false, Ddo_br_medication_chem_cycle_Internalname, "SortedStatus", Ddo_br_medication_chem_cycle_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_cycle_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV56TFBR_Medication_Chem_Cycle = NumberUtil.Val( Ddo_br_medication_chem_cycle_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( AV56TFBR_Medication_Chem_Cycle, 15, 5)));
            AV57TFBR_Medication_Chem_Cycle_To = NumberUtil.Val( Ddo_br_medication_chem_cycle_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFBR_Medication_Chem_Cycle_To", StringUtil.LTrim( StringUtil.Str( AV57TFBR_Medication_Chem_Cycle_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_SchemeIDTitleFilterData", AV16BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicationIDTitleFilterData", AV20BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Chem_NameTitleFilterData", AV51BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Chem_CycleTitleFilterData", AV55BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59BR_Medication_Chem_LineTitleFilterData", AV59BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67BR_Medication_Chem_DetailTitleFilterData", AV67BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E174Z2( )
      {
         /* Ddo_br_medication_chem_line_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_chem_line_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_chem_line_Sortedstatus = "ASC";
            ucDdo_br_medication_chem_line.SendProperty(context, "", false, Ddo_br_medication_chem_line_Internalname, "SortedStatus", Ddo_br_medication_chem_line_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_line_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_chem_line_Sortedstatus = "DSC";
            ucDdo_br_medication_chem_line.SendProperty(context, "", false, Ddo_br_medication_chem_line_Internalname, "SortedStatus", Ddo_br_medication_chem_line_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_line_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV60TFBR_Medication_Chem_Line = Ddo_br_medication_chem_line_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Medication_Chem_Line", AV60TFBR_Medication_Chem_Line);
            AV61TFBR_Medication_Chem_Line_Sel = Ddo_br_medication_chem_line_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61TFBR_Medication_Chem_Line_Sel", AV61TFBR_Medication_Chem_Line_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_SchemeIDTitleFilterData", AV16BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicationIDTitleFilterData", AV20BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Chem_NameTitleFilterData", AV51BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Chem_CycleTitleFilterData", AV55BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59BR_Medication_Chem_LineTitleFilterData", AV59BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67BR_Medication_Chem_DetailTitleFilterData", AV67BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E184Z2( )
      {
         /* Ddo_br_medication_chem_detail_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_chem_detail_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_chem_detail_Sortedstatus = "ASC";
            ucDdo_br_medication_chem_detail.SendProperty(context, "", false, Ddo_br_medication_chem_detail_Internalname, "SortedStatus", Ddo_br_medication_chem_detail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_detail_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_chem_detail_Sortedstatus = "DSC";
            ucDdo_br_medication_chem_detail.SendProperty(context, "", false, Ddo_br_medication_chem_detail_Internalname, "SortedStatus", Ddo_br_medication_chem_detail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_detail_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV68TFBR_Medication_Chem_Detail = Ddo_br_medication_chem_detail_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFBR_Medication_Chem_Detail", AV68TFBR_Medication_Chem_Detail);
            AV69TFBR_Medication_Chem_Detail_Sel = Ddo_br_medication_chem_detail_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFBR_Medication_Chem_Detail_Sel", AV69TFBR_Medication_Chem_Detail_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_SchemeIDTitleFilterData", AV16BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicationIDTitleFilterData", AV20BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Chem_NameTitleFilterData", AV51BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Chem_CycleTitleFilterData", AV55BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59BR_Medication_Chem_LineTitleFilterData", AV59BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67BR_Medication_Chem_DetailTitleFilterData", AV67BR_Medication_Chem_DetailTitleFilterData);
      }

      private void E224Z2( )
      {
         /* Grid_Load Routine */
         AV45Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV45Display);
         AV85Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_medication_schemeview.aspx") + "?" + UrlEncode("" +A296BR_Medication_SchemeID) + "," + UrlEncode("" +A119BR_MedicationID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV46Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV46Update);
         AV86Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV47IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_medication_scheme.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A296BR_Medication_SchemeID);
         }
         AV48Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV48Delete);
         AV87Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV49IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_medication_scheme.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A296BR_Medication_SchemeID);
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

      protected void E194Z2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_medication_scheme.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_medication_schemeid_Sortedstatus = "";
         ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "SortedStatus", Ddo_br_medication_schemeid_Sortedstatus);
         Ddo_br_medicationid_Sortedstatus = "";
         ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
         Ddo_br_medication_chem_name_Sortedstatus = "";
         ucDdo_br_medication_chem_name.SendProperty(context, "", false, Ddo_br_medication_chem_name_Internalname, "SortedStatus", Ddo_br_medication_chem_name_Sortedstatus);
         Ddo_br_medication_chem_cycle_Sortedstatus = "";
         ucDdo_br_medication_chem_cycle.SendProperty(context, "", false, Ddo_br_medication_chem_cycle_Internalname, "SortedStatus", Ddo_br_medication_chem_cycle_Sortedstatus);
         Ddo_br_medication_chem_line_Sortedstatus = "";
         ucDdo_br_medication_chem_line.SendProperty(context, "", false, Ddo_br_medication_chem_line_Internalname, "SortedStatus", Ddo_br_medication_chem_line_Sortedstatus);
         Ddo_br_medication_chem_detail_Sortedstatus = "";
         ucDdo_br_medication_chem_detail.SendProperty(context, "", false, Ddo_br_medication_chem_detail_Internalname, "SortedStatus", Ddo_br_medication_chem_detail_Sortedstatus);
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
            Ddo_br_medication_schemeid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "SortedStatus", Ddo_br_medication_schemeid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_medicationid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_medication_chem_name_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_chem_name.SendProperty(context, "", false, Ddo_br_medication_chem_name_Internalname, "SortedStatus", Ddo_br_medication_chem_name_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_medication_chem_cycle_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_chem_cycle.SendProperty(context, "", false, Ddo_br_medication_chem_cycle_Internalname, "SortedStatus", Ddo_br_medication_chem_cycle_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_medication_chem_line_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_chem_line.SendProperty(context, "", false, Ddo_br_medication_chem_line_Internalname, "SortedStatus", Ddo_br_medication_chem_line_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_medication_chem_detail_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_chem_detail.SendProperty(context, "", false, Ddo_br_medication_chem_detail_Internalname, "SortedStatus", Ddo_br_medication_chem_detail_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV47IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme_Update", out  GXt_boolean2) ;
         AV47IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47IsAuthorized_Update", AV47IsAuthorized_Update);
         if ( ! ( AV47IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV49IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme_Delete", out  GXt_boolean2) ;
         AV49IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49IsAuthorized_Delete", AV49IsAuthorized_Delete);
         if ( ! ( AV49IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV50TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme_Insert", out  GXt_boolean2) ;
         AV50TempBoolean = GXt_boolean2;
         if ( ! ( AV50TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV88Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV88Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV88Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV89GXV1 = 1;
         while ( AV89GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV89GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_SCHEMEID") == 0 )
            {
               AV17TFBR_Medication_SchemeID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Medication_SchemeID), 18, 0)));
               AV18TFBR_Medication_SchemeID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Medication_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Medication_SchemeID_To), 18, 0)));
               if ( ! (0==AV17TFBR_Medication_SchemeID) )
               {
                  Ddo_br_medication_schemeid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_Medication_SchemeID), 18, 0);
                  ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "FilteredText_set", Ddo_br_medication_schemeid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_Medication_SchemeID_To) )
               {
                  Ddo_br_medication_schemeid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_Medication_SchemeID_To), 18, 0);
                  ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "FilteredTextTo_set", Ddo_br_medication_schemeid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATIONID") == 0 )
            {
               AV21TFBR_MedicationID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_MedicationID), 18, 0)));
               AV22TFBR_MedicationID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_MedicationID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_MedicationID_To), 18, 0)));
               if ( ! (0==AV21TFBR_MedicationID) )
               {
                  Ddo_br_medicationid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_MedicationID), 18, 0);
                  ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "FilteredText_set", Ddo_br_medicationid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_MedicationID_To) )
               {
                  Ddo_br_medicationid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_MedicationID_To), 18, 0);
                  ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "FilteredTextTo_set", Ddo_br_medicationid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_NAME") == 0 )
            {
               AV52TFBR_Medication_Chem_Name = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Medication_Chem_Name", AV52TFBR_Medication_Chem_Name);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52TFBR_Medication_Chem_Name)) )
               {
                  Ddo_br_medication_chem_name_Filteredtext_set = AV52TFBR_Medication_Chem_Name;
                  ucDdo_br_medication_chem_name.SendProperty(context, "", false, Ddo_br_medication_chem_name_Internalname, "FilteredText_set", Ddo_br_medication_chem_name_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_NAME_SEL") == 0 )
            {
               AV53TFBR_Medication_Chem_Name_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53TFBR_Medication_Chem_Name_Sel", AV53TFBR_Medication_Chem_Name_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53TFBR_Medication_Chem_Name_Sel)) )
               {
                  Ddo_br_medication_chem_name_Selectedvalue_set = AV53TFBR_Medication_Chem_Name_Sel;
                  ucDdo_br_medication_chem_name.SendProperty(context, "", false, Ddo_br_medication_chem_name_Internalname, "SelectedValue_set", Ddo_br_medication_chem_name_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_CYCLE") == 0 )
            {
               AV56TFBR_Medication_Chem_Cycle = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( AV56TFBR_Medication_Chem_Cycle, 15, 5)));
               AV57TFBR_Medication_Chem_Cycle_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFBR_Medication_Chem_Cycle_To", StringUtil.LTrim( StringUtil.Str( AV57TFBR_Medication_Chem_Cycle_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV56TFBR_Medication_Chem_Cycle) )
               {
                  Ddo_br_medication_chem_cycle_Filteredtext_set = StringUtil.Str( AV56TFBR_Medication_Chem_Cycle, 15, 5);
                  ucDdo_br_medication_chem_cycle.SendProperty(context, "", false, Ddo_br_medication_chem_cycle_Internalname, "FilteredText_set", Ddo_br_medication_chem_cycle_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV57TFBR_Medication_Chem_Cycle_To) )
               {
                  Ddo_br_medication_chem_cycle_Filteredtextto_set = StringUtil.Str( AV57TFBR_Medication_Chem_Cycle_To, 15, 5);
                  ucDdo_br_medication_chem_cycle.SendProperty(context, "", false, Ddo_br_medication_chem_cycle_Internalname, "FilteredTextTo_set", Ddo_br_medication_chem_cycle_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_LINE") == 0 )
            {
               AV60TFBR_Medication_Chem_Line = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Medication_Chem_Line", AV60TFBR_Medication_Chem_Line);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60TFBR_Medication_Chem_Line)) )
               {
                  Ddo_br_medication_chem_line_Filteredtext_set = AV60TFBR_Medication_Chem_Line;
                  ucDdo_br_medication_chem_line.SendProperty(context, "", false, Ddo_br_medication_chem_line_Internalname, "FilteredText_set", Ddo_br_medication_chem_line_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_LINE_SEL") == 0 )
            {
               AV61TFBR_Medication_Chem_Line_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61TFBR_Medication_Chem_Line_Sel", AV61TFBR_Medication_Chem_Line_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61TFBR_Medication_Chem_Line_Sel)) )
               {
                  Ddo_br_medication_chem_line_Selectedvalue_set = AV61TFBR_Medication_Chem_Line_Sel;
                  ucDdo_br_medication_chem_line.SendProperty(context, "", false, Ddo_br_medication_chem_line_Internalname, "SelectedValue_set", Ddo_br_medication_chem_line_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_DETAIL") == 0 )
            {
               AV68TFBR_Medication_Chem_Detail = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFBR_Medication_Chem_Detail", AV68TFBR_Medication_Chem_Detail);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68TFBR_Medication_Chem_Detail)) )
               {
                  Ddo_br_medication_chem_detail_Filteredtext_set = AV68TFBR_Medication_Chem_Detail;
                  ucDdo_br_medication_chem_detail.SendProperty(context, "", false, Ddo_br_medication_chem_detail_Internalname, "FilteredText_set", Ddo_br_medication_chem_detail_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_DETAIL_SEL") == 0 )
            {
               AV69TFBR_Medication_Chem_Detail_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFBR_Medication_Chem_Detail_Sel", AV69TFBR_Medication_Chem_Detail_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69TFBR_Medication_Chem_Detail_Sel)) )
               {
                  Ddo_br_medication_chem_detail_Selectedvalue_set = AV69TFBR_Medication_Chem_Detail_Sel;
                  ucDdo_br_medication_chem_detail.SendProperty(context, "", false, Ddo_br_medication_chem_detail_Internalname, "SelectedValue_set", Ddo_br_medication_chem_detail_Selectedvalue_set);
               }
            }
            AV89GXV1 = (int)(AV89GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV88Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_Medication_SchemeID) && (0==AV18TFBR_Medication_SchemeID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_SCHEMEID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_Medication_SchemeID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_Medication_SchemeID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_MedicationID) && (0==AV22TFBR_MedicationID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATIONID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_MedicationID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_MedicationID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52TFBR_Medication_Chem_Name)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_CHEM_NAME";
            AV12GridStateFilterValue.gxTpr_Value = AV52TFBR_Medication_Chem_Name;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53TFBR_Medication_Chem_Name_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_CHEM_NAME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV53TFBR_Medication_Chem_Name_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV56TFBR_Medication_Chem_Cycle) && (Convert.ToDecimal(0)==AV57TFBR_Medication_Chem_Cycle_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_CHEM_CYCLE";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV56TFBR_Medication_Chem_Cycle, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV57TFBR_Medication_Chem_Cycle_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60TFBR_Medication_Chem_Line)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_CHEM_LINE";
            AV12GridStateFilterValue.gxTpr_Value = AV60TFBR_Medication_Chem_Line;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61TFBR_Medication_Chem_Line_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_CHEM_LINE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV61TFBR_Medication_Chem_Line_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68TFBR_Medication_Chem_Detail)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_CHEM_DETAIL";
            AV12GridStateFilterValue.gxTpr_Value = AV68TFBR_Medication_Chem_Detail;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69TFBR_Medication_Chem_Detail_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_CHEM_DETAIL_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV69TFBR_Medication_Chem_Detail_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV88Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV88Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Medication_Scheme";
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
         PA4Z2( ) ;
         WS4Z2( ) ;
         WE4Z2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271221827", true);
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
         context.AddJavascriptSource("br_medication_schemeww.js", "?20202271221827", false);
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

      protected void SubsflControlProps_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_idx;
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID_"+sGXsfl_31_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_31_idx;
         edtBR_Medication_Chem_Name_Internalname = "BR_MEDICATION_CHEM_NAME_"+sGXsfl_31_idx;
         edtBR_Medication_Chem_Cycle_Internalname = "BR_MEDICATION_CHEM_CYCLE_"+sGXsfl_31_idx;
         edtBR_Medication_Chem_Line_Internalname = "BR_MEDICATION_CHEM_LINE_"+sGXsfl_31_idx;
         edtBR_Medication_Chem_Detail_Internalname = "BR_MEDICATION_CHEM_DETAIL_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID_"+sGXsfl_31_fel_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_31_fel_idx;
         edtBR_Medication_Chem_Name_Internalname = "BR_MEDICATION_CHEM_NAME_"+sGXsfl_31_fel_idx;
         edtBR_Medication_Chem_Cycle_Internalname = "BR_MEDICATION_CHEM_CYCLE_"+sGXsfl_31_fel_idx;
         edtBR_Medication_Chem_Line_Internalname = "BR_MEDICATION_CHEM_LINE_"+sGXsfl_31_fel_idx;
         edtBR_Medication_Chem_Detail_Internalname = "BR_MEDICATION_CHEM_DETAIL_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB4Z0( ) ;
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
            AV45Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV45Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV85Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV45Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV45Display)) ? AV85Display_GXI : context.PathToRelativeUrl( AV45Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV45Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV46Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV46Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV86Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)) ? AV86Update_GXI : context.PathToRelativeUrl( AV46Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV46Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV48Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV87Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete)) ? AV87Delete_GXI : context.PathToRelativeUrl( AV48Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV48Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_SchemeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A296BR_Medication_SchemeID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_SchemeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Chem_Name_Internalname,(String)A305BR_Medication_Chem_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Chem_Name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Chem_Cycle_Internalname,StringUtil.LTrim( StringUtil.NToC( A306BR_Medication_Chem_Cycle, 15, 5, ".", "")),context.localUtil.Format( A306BR_Medication_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Chem_Cycle_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Chem_Line_Internalname,(String)A307BR_Medication_Chem_Line,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Chem_Line_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Chem_Detail_Internalname,(String)A313BR_Medication_Chem_Detail,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Chem_Detail_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes4Z2( ) ;
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
         edtavTfbr_medication_schemeid_Internalname = "vTFBR_MEDICATION_SCHEMEID";
         edtavTfbr_medication_schemeid_to_Internalname = "vTFBR_MEDICATION_SCHEMEID_TO";
         edtavTfbr_medicationid_Internalname = "vTFBR_MEDICATIONID";
         edtavTfbr_medicationid_to_Internalname = "vTFBR_MEDICATIONID_TO";
         edtavTfbr_medication_chem_name_Internalname = "vTFBR_MEDICATION_CHEM_NAME";
         edtavTfbr_medication_chem_name_sel_Internalname = "vTFBR_MEDICATION_CHEM_NAME_SEL";
         edtavTfbr_medication_chem_cycle_Internalname = "vTFBR_MEDICATION_CHEM_CYCLE";
         edtavTfbr_medication_chem_cycle_to_Internalname = "vTFBR_MEDICATION_CHEM_CYCLE_TO";
         edtavTfbr_medication_chem_line_Internalname = "vTFBR_MEDICATION_CHEM_LINE";
         edtavTfbr_medication_chem_line_sel_Internalname = "vTFBR_MEDICATION_CHEM_LINE_SEL";
         edtavTfbr_medication_chem_detail_Internalname = "vTFBR_MEDICATION_CHEM_DETAIL";
         edtavTfbr_medication_chem_detail_sel_Internalname = "vTFBR_MEDICATION_CHEM_DETAIL_SEL";
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
         edtavTfbr_medication_chem_detail_sel_Jsonclick = "";
         edtavTfbr_medication_chem_detail_sel_Visible = 1;
         edtavTfbr_medication_chem_detail_Jsonclick = "";
         edtavTfbr_medication_chem_detail_Visible = 1;
         edtavTfbr_medication_chem_line_sel_Jsonclick = "";
         edtavTfbr_medication_chem_line_sel_Visible = 1;
         edtavTfbr_medication_chem_line_Jsonclick = "";
         edtavTfbr_medication_chem_line_Visible = 1;
         edtavTfbr_medication_chem_cycle_to_Jsonclick = "";
         edtavTfbr_medication_chem_cycle_to_Visible = 1;
         edtavTfbr_medication_chem_cycle_Jsonclick = "";
         edtavTfbr_medication_chem_cycle_Visible = 1;
         edtavTfbr_medication_chem_name_sel_Jsonclick = "";
         edtavTfbr_medication_chem_name_sel_Visible = 1;
         edtavTfbr_medication_chem_name_Jsonclick = "";
         edtavTfbr_medication_chem_name_Visible = 1;
         edtavTfbr_medicationid_to_Jsonclick = "";
         edtavTfbr_medicationid_to_Visible = 1;
         edtavTfbr_medicationid_Jsonclick = "";
         edtavTfbr_medicationid_Visible = 1;
         edtavTfbr_medication_schemeid_to_Jsonclick = "";
         edtavTfbr_medication_schemeid_to_Visible = 1;
         edtavTfbr_medication_schemeid_Jsonclick = "";
         edtavTfbr_medication_schemeid_Visible = 1;
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
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
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
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_medication_chem_detail_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_chem_detail_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_chem_detail_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_chem_detail_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_chem_detail_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_chem_detail_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_chem_detail_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_chem_detail_Datalistproc = "BR_Medication_SchemeWWGetFilterData";
         Ddo_br_medication_chem_detail_Datalisttype = "Dynamic";
         Ddo_br_medication_chem_detail_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_detail_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_detail_Filtertype = "Character";
         Ddo_br_medication_chem_detail_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_detail_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_detail_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_detail_Titlecontrolidtoreplace = "";
         Ddo_br_medication_chem_detail_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_chem_detail_Cls = "ColumnSettings";
         Ddo_br_medication_chem_detail_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_chem_detail_Caption = "";
         Ddo_br_medication_chem_line_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_chem_line_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_chem_line_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_chem_line_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_chem_line_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_chem_line_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_chem_line_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_chem_line_Datalistproc = "BR_Medication_SchemeWWGetFilterData";
         Ddo_br_medication_chem_line_Datalisttype = "Dynamic";
         Ddo_br_medication_chem_line_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_line_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_line_Filtertype = "Character";
         Ddo_br_medication_chem_line_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_line_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_line_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_line_Titlecontrolidtoreplace = "";
         Ddo_br_medication_chem_line_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_chem_line_Cls = "ColumnSettings";
         Ddo_br_medication_chem_line_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_chem_line_Caption = "";
         Ddo_br_medication_chem_cycle_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_chem_cycle_Rangefilterto = "WWP_TSTo";
         Ddo_br_medication_chem_cycle_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medication_chem_cycle_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_chem_cycle_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_chem_cycle_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_chem_cycle_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_cycle_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_cycle_Filtertype = "Numeric";
         Ddo_br_medication_chem_cycle_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_cycle_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_cycle_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace = "";
         Ddo_br_medication_chem_cycle_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_chem_cycle_Cls = "ColumnSettings";
         Ddo_br_medication_chem_cycle_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_chem_cycle_Caption = "";
         Ddo_br_medication_chem_name_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_chem_name_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_chem_name_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_chem_name_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_chem_name_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_chem_name_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_chem_name_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_chem_name_Datalistproc = "BR_Medication_SchemeWWGetFilterData";
         Ddo_br_medication_chem_name_Datalisttype = "Dynamic";
         Ddo_br_medication_chem_name_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_name_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_name_Filtertype = "Character";
         Ddo_br_medication_chem_name_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_name_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_name_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_name_Titlecontrolidtoreplace = "";
         Ddo_br_medication_chem_name_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_chem_name_Cls = "ColumnSettings";
         Ddo_br_medication_chem_name_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_chem_name_Caption = "";
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
         Ddo_br_medication_schemeid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_schemeid_Rangefilterto = "WWP_TSTo";
         Ddo_br_medication_schemeid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medication_schemeid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_schemeid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_schemeid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_schemeid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_schemeid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medication_schemeid_Filtertype = "Numeric";
         Ddo_br_medication_schemeid_Includefilter = Convert.ToBoolean( -1);
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
         Form.Caption = " 药物治疗化疗方案";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E114Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E124Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED","{handler:'E134Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medication_schemeid_Activeeventkey',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'ActiveEventKey'},{av:'Ddo_br_medication_schemeid_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredText_get'},{av:'Ddo_br_medication_schemeid_Filteredtextto_get',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_cycle_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_line_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_detail_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATIONID.ONOPTIONCLICKED","{handler:'E144Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medicationid_Activeeventkey',ctrl:'DDO_BR_MEDICATIONID',prop:'ActiveEventKey'},{av:'Ddo_br_medicationid_Filteredtext_get',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredText_get'},{av:'Ddo_br_medicationid_Filteredtextto_get',ctrl:'DDO_BR_MEDICATIONID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATIONID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_cycle_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_line_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_detail_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_NAME.ONOPTIONCLICKED","{handler:'E154Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medication_chem_name_Activeeventkey',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'ActiveEventKey'},{av:'Ddo_br_medication_chem_name_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'FilteredText_get'},{av:'Ddo_br_medication_chem_name_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_NAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_chem_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_cycle_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_line_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_detail_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_CYCLE.ONOPTIONCLICKED","{handler:'E164Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medication_chem_cycle_Activeeventkey',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'ActiveEventKey'},{av:'Ddo_br_medication_chem_cycle_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'FilteredText_get'},{av:'Ddo_br_medication_chem_cycle_Filteredtextto_get',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_CYCLE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_chem_cycle_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_line_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_detail_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_LINE.ONOPTIONCLICKED","{handler:'E174Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medication_chem_line_Activeeventkey',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'ActiveEventKey'},{av:'Ddo_br_medication_chem_line_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'FilteredText_get'},{av:'Ddo_br_medication_chem_line_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_LINE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_chem_line_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_cycle_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_detail_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_DETAIL.ONOPTIONCLICKED","{handler:'E184Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicationID',fld:'vTFBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicationID_To',fld:'vTFBR_MEDICATIONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV52TFBR_Medication_Chem_Name',fld:'vTFBR_MEDICATION_CHEM_NAME',pic:''},{av:'AV53TFBR_Medication_Chem_Name_Sel',fld:'vTFBR_MEDICATION_CHEM_NAME_SEL',pic:''},{av:'AV56TFBR_Medication_Chem_Cycle',fld:'vTFBR_MEDICATION_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV57TFBR_Medication_Chem_Cycle_To',fld:'vTFBR_MEDICATION_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_Chem_Line',fld:'vTFBR_MEDICATION_CHEM_LINE',pic:''},{av:'AV61TFBR_Medication_Chem_Line_Sel',fld:'vTFBR_MEDICATION_CHEM_LINE_SEL',pic:''},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV88Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medication_chem_detail_Activeeventkey',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'ActiveEventKey'},{av:'Ddo_br_medication_chem_detail_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'FilteredText_get'},{av:'Ddo_br_medication_chem_detail_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_DETAIL.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_chem_detail_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV68TFBR_Medication_Chem_Detail',fld:'vTFBR_MEDICATION_CHEM_DETAIL',pic:''},{av:'AV69TFBR_Medication_Chem_Detail_Sel',fld:'vTFBR_MEDICATION_CHEM_DETAIL_SEL',pic:''},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_cycle_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'Ddo_br_medication_chem_line_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'AV16BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV59BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV67BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E224Z2',iparms:[{av:'A296BR_Medication_SchemeID',fld:'BR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A119BR_MedicationID',fld:'BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV45Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV46Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV48Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E194Z2',iparms:[{av:'A296BR_Medication_SchemeID',fld:'BR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_medication_schemeid_Activeeventkey = "";
         Ddo_br_medication_schemeid_Filteredtext_get = "";
         Ddo_br_medication_schemeid_Filteredtextto_get = "";
         Ddo_br_medicationid_Activeeventkey = "";
         Ddo_br_medicationid_Filteredtext_get = "";
         Ddo_br_medicationid_Filteredtextto_get = "";
         Ddo_br_medication_chem_name_Activeeventkey = "";
         Ddo_br_medication_chem_name_Filteredtext_get = "";
         Ddo_br_medication_chem_name_Selectedvalue_get = "";
         Ddo_br_medication_chem_cycle_Activeeventkey = "";
         Ddo_br_medication_chem_cycle_Filteredtext_get = "";
         Ddo_br_medication_chem_cycle_Filteredtextto_get = "";
         Ddo_br_medication_chem_line_Activeeventkey = "";
         Ddo_br_medication_chem_line_Filteredtext_get = "";
         Ddo_br_medication_chem_line_Selectedvalue_get = "";
         Ddo_br_medication_chem_detail_Activeeventkey = "";
         Ddo_br_medication_chem_detail_Filteredtext_get = "";
         Ddo_br_medication_chem_detail_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV52TFBR_Medication_Chem_Name = "";
         AV53TFBR_Medication_Chem_Name_Sel = "";
         AV60TFBR_Medication_Chem_Line = "";
         AV61TFBR_Medication_Chem_Line_Sel = "";
         AV68TFBR_Medication_Chem_Detail = "";
         AV69TFBR_Medication_Chem_Detail_Sel = "";
         AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "";
         AV23ddo_BR_MedicationIDTitleControlIdToReplace = "";
         AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace = "";
         AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = "";
         AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace = "";
         AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = "";
         AV88Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV40DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_Medication_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV51BR_Medication_Chem_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV55BR_Medication_Chem_CycleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV59BR_Medication_Chem_LineTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV67BR_Medication_Chem_DetailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medication_schemeid_Filteredtext_set = "";
         Ddo_br_medication_schemeid_Filteredtextto_set = "";
         Ddo_br_medication_schemeid_Sortedstatus = "";
         Ddo_br_medicationid_Filteredtext_set = "";
         Ddo_br_medicationid_Filteredtextto_set = "";
         Ddo_br_medicationid_Sortedstatus = "";
         Ddo_br_medication_chem_name_Filteredtext_set = "";
         Ddo_br_medication_chem_name_Selectedvalue_set = "";
         Ddo_br_medication_chem_name_Sortedstatus = "";
         Ddo_br_medication_chem_cycle_Filteredtext_set = "";
         Ddo_br_medication_chem_cycle_Filteredtextto_set = "";
         Ddo_br_medication_chem_cycle_Sortedstatus = "";
         Ddo_br_medication_chem_line_Filteredtext_set = "";
         Ddo_br_medication_chem_line_Selectedvalue_set = "";
         Ddo_br_medication_chem_line_Sortedstatus = "";
         Ddo_br_medication_chem_detail_Filteredtext_set = "";
         Ddo_br_medication_chem_detail_Selectedvalue_set = "";
         Ddo_br_medication_chem_detail_Sortedstatus = "";
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
         AV45Display = "";
         AV46Update = "";
         AV48Delete = "";
         A305BR_Medication_Chem_Name = "";
         A307BR_Medication_Chem_Line = "";
         A313BR_Medication_Chem_Detail = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medication_schemeid = new GXUserControl();
         ucDdo_br_medicationid = new GXUserControl();
         ucDdo_br_medication_chem_name = new GXUserControl();
         ucDdo_br_medication_chem_cycle = new GXUserControl();
         ucDdo_br_medication_chem_line = new GXUserControl();
         ucDdo_br_medication_chem_detail = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV85Display_GXI = "";
         AV86Update_GXI = "";
         AV87Delete_GXI = "";
         scmdbuf = "";
         lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = "";
         lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = "";
         lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = "";
         AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = "";
         AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = "";
         AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = "";
         AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = "";
         AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = "";
         AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = "";
         H004Z2_A313BR_Medication_Chem_Detail = new String[] {""} ;
         H004Z2_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         H004Z2_A307BR_Medication_Chem_Line = new String[] {""} ;
         H004Z2_n307BR_Medication_Chem_Line = new bool[] {false} ;
         H004Z2_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         H004Z2_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         H004Z2_A305BR_Medication_Chem_Name = new String[] {""} ;
         H004Z2_n305BR_Medication_Chem_Name = new bool[] {false} ;
         H004Z2_A119BR_MedicationID = new long[1] ;
         H004Z2_n119BR_MedicationID = new bool[] {false} ;
         H004Z2_A296BR_Medication_SchemeID = new long[1] ;
         H004Z3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_schemeww__default(),
            new Object[][] {
                new Object[] {
               H004Z2_A313BR_Medication_Chem_Detail, H004Z2_n313BR_Medication_Chem_Detail, H004Z2_A307BR_Medication_Chem_Line, H004Z2_n307BR_Medication_Chem_Line, H004Z2_A306BR_Medication_Chem_Cycle, H004Z2_n306BR_Medication_Chem_Cycle, H004Z2_A305BR_Medication_Chem_Name, H004Z2_n305BR_Medication_Chem_Name, H004Z2_A119BR_MedicationID, H004Z2_n119BR_MedicationID,
               H004Z2_A296BR_Medication_SchemeID
               }
               , new Object[] {
               H004Z3_AGRID_nRecordCount
               }
            }
         );
         AV88Pgmname = "BR_Medication_SchemeWW";
         /* GeneXus formulas. */
         AV88Pgmname = "BR_Medication_SchemeWW";
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
      private int Ddo_br_medication_chem_name_Datalistupdateminimumcharacters ;
      private int Ddo_br_medication_chem_line_Datalistupdateminimumcharacters ;
      private int Ddo_br_medication_chem_detail_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
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
      private int edtavTfbr_medication_schemeid_Visible ;
      private int edtavTfbr_medication_schemeid_to_Visible ;
      private int edtavTfbr_medicationid_Visible ;
      private int edtavTfbr_medicationid_to_Visible ;
      private int edtavTfbr_medication_chem_name_Visible ;
      private int edtavTfbr_medication_chem_name_sel_Visible ;
      private int edtavTfbr_medication_chem_cycle_Visible ;
      private int edtavTfbr_medication_chem_cycle_to_Visible ;
      private int edtavTfbr_medication_chem_line_Visible ;
      private int edtavTfbr_medication_chem_line_sel_Visible ;
      private int edtavTfbr_medication_chem_detail_Visible ;
      private int edtavTfbr_medication_chem_detail_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV41PageToGo ;
      private int AV89GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_Medication_SchemeID ;
      private long AV18TFBR_Medication_SchemeID_To ;
      private long AV21TFBR_MedicationID ;
      private long AV22TFBR_MedicationID_To ;
      private long AV42GridCurrentPage ;
      private long AV44GridRecordCount ;
      private long AV43GridPageSize ;
      private long A296BR_Medication_SchemeID ;
      private long A119BR_MedicationID ;
      private long GRID_nCurrentRecord ;
      private long AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ;
      private long AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ;
      private long AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid ;
      private long AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ;
      private long GRID_nRecordCount ;
      private decimal AV56TFBR_Medication_Chem_Cycle ;
      private decimal AV57TFBR_Medication_Chem_Cycle_To ;
      private decimal A306BR_Medication_Chem_Cycle ;
      private decimal AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ;
      private decimal AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medication_schemeid_Activeeventkey ;
      private String Ddo_br_medication_schemeid_Filteredtext_get ;
      private String Ddo_br_medication_schemeid_Filteredtextto_get ;
      private String Ddo_br_medicationid_Activeeventkey ;
      private String Ddo_br_medicationid_Filteredtext_get ;
      private String Ddo_br_medicationid_Filteredtextto_get ;
      private String Ddo_br_medication_chem_name_Activeeventkey ;
      private String Ddo_br_medication_chem_name_Filteredtext_get ;
      private String Ddo_br_medication_chem_name_Selectedvalue_get ;
      private String Ddo_br_medication_chem_cycle_Activeeventkey ;
      private String Ddo_br_medication_chem_cycle_Filteredtext_get ;
      private String Ddo_br_medication_chem_cycle_Filteredtextto_get ;
      private String Ddo_br_medication_chem_line_Activeeventkey ;
      private String Ddo_br_medication_chem_line_Filteredtext_get ;
      private String Ddo_br_medication_chem_line_Selectedvalue_get ;
      private String Ddo_br_medication_chem_detail_Activeeventkey ;
      private String Ddo_br_medication_chem_detail_Filteredtext_get ;
      private String Ddo_br_medication_chem_detail_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV88Pgmname ;
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
      private String Ddo_br_medication_schemeid_Caption ;
      private String Ddo_br_medication_schemeid_Tooltip ;
      private String Ddo_br_medication_schemeid_Cls ;
      private String Ddo_br_medication_schemeid_Filteredtext_set ;
      private String Ddo_br_medication_schemeid_Filteredtextto_set ;
      private String Ddo_br_medication_schemeid_Dropdownoptionstype ;
      private String Ddo_br_medication_schemeid_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_schemeid_Sortedstatus ;
      private String Ddo_br_medication_schemeid_Filtertype ;
      private String Ddo_br_medication_schemeid_Sortasc ;
      private String Ddo_br_medication_schemeid_Sortdsc ;
      private String Ddo_br_medication_schemeid_Cleanfilter ;
      private String Ddo_br_medication_schemeid_Rangefilterfrom ;
      private String Ddo_br_medication_schemeid_Rangefilterto ;
      private String Ddo_br_medication_schemeid_Searchbuttontext ;
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
      private String Ddo_br_medication_chem_name_Caption ;
      private String Ddo_br_medication_chem_name_Tooltip ;
      private String Ddo_br_medication_chem_name_Cls ;
      private String Ddo_br_medication_chem_name_Filteredtext_set ;
      private String Ddo_br_medication_chem_name_Selectedvalue_set ;
      private String Ddo_br_medication_chem_name_Dropdownoptionstype ;
      private String Ddo_br_medication_chem_name_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_chem_name_Sortedstatus ;
      private String Ddo_br_medication_chem_name_Filtertype ;
      private String Ddo_br_medication_chem_name_Datalisttype ;
      private String Ddo_br_medication_chem_name_Datalistproc ;
      private String Ddo_br_medication_chem_name_Sortasc ;
      private String Ddo_br_medication_chem_name_Sortdsc ;
      private String Ddo_br_medication_chem_name_Loadingdata ;
      private String Ddo_br_medication_chem_name_Cleanfilter ;
      private String Ddo_br_medication_chem_name_Noresultsfound ;
      private String Ddo_br_medication_chem_name_Searchbuttontext ;
      private String Ddo_br_medication_chem_cycle_Caption ;
      private String Ddo_br_medication_chem_cycle_Tooltip ;
      private String Ddo_br_medication_chem_cycle_Cls ;
      private String Ddo_br_medication_chem_cycle_Filteredtext_set ;
      private String Ddo_br_medication_chem_cycle_Filteredtextto_set ;
      private String Ddo_br_medication_chem_cycle_Dropdownoptionstype ;
      private String Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_chem_cycle_Sortedstatus ;
      private String Ddo_br_medication_chem_cycle_Filtertype ;
      private String Ddo_br_medication_chem_cycle_Sortasc ;
      private String Ddo_br_medication_chem_cycle_Sortdsc ;
      private String Ddo_br_medication_chem_cycle_Cleanfilter ;
      private String Ddo_br_medication_chem_cycle_Rangefilterfrom ;
      private String Ddo_br_medication_chem_cycle_Rangefilterto ;
      private String Ddo_br_medication_chem_cycle_Searchbuttontext ;
      private String Ddo_br_medication_chem_line_Caption ;
      private String Ddo_br_medication_chem_line_Tooltip ;
      private String Ddo_br_medication_chem_line_Cls ;
      private String Ddo_br_medication_chem_line_Filteredtext_set ;
      private String Ddo_br_medication_chem_line_Selectedvalue_set ;
      private String Ddo_br_medication_chem_line_Dropdownoptionstype ;
      private String Ddo_br_medication_chem_line_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_chem_line_Sortedstatus ;
      private String Ddo_br_medication_chem_line_Filtertype ;
      private String Ddo_br_medication_chem_line_Datalisttype ;
      private String Ddo_br_medication_chem_line_Datalistproc ;
      private String Ddo_br_medication_chem_line_Sortasc ;
      private String Ddo_br_medication_chem_line_Sortdsc ;
      private String Ddo_br_medication_chem_line_Loadingdata ;
      private String Ddo_br_medication_chem_line_Cleanfilter ;
      private String Ddo_br_medication_chem_line_Noresultsfound ;
      private String Ddo_br_medication_chem_line_Searchbuttontext ;
      private String Ddo_br_medication_chem_detail_Caption ;
      private String Ddo_br_medication_chem_detail_Tooltip ;
      private String Ddo_br_medication_chem_detail_Cls ;
      private String Ddo_br_medication_chem_detail_Filteredtext_set ;
      private String Ddo_br_medication_chem_detail_Selectedvalue_set ;
      private String Ddo_br_medication_chem_detail_Dropdownoptionstype ;
      private String Ddo_br_medication_chem_detail_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_chem_detail_Sortedstatus ;
      private String Ddo_br_medication_chem_detail_Filtertype ;
      private String Ddo_br_medication_chem_detail_Datalisttype ;
      private String Ddo_br_medication_chem_detail_Datalistproc ;
      private String Ddo_br_medication_chem_detail_Sortasc ;
      private String Ddo_br_medication_chem_detail_Sortdsc ;
      private String Ddo_br_medication_chem_detail_Loadingdata ;
      private String Ddo_br_medication_chem_detail_Cleanfilter ;
      private String Ddo_br_medication_chem_detail_Noresultsfound ;
      private String Ddo_br_medication_chem_detail_Searchbuttontext ;
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
      private String edtBR_Medication_SchemeID_Title ;
      private String edtBR_MedicationID_Title ;
      private String edtBR_Medication_Chem_Name_Title ;
      private String edtBR_Medication_Chem_Cycle_Title ;
      private String edtBR_Medication_Chem_Line_Title ;
      private String edtBR_Medication_Chem_Detail_Title ;
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
      private String Ddo_br_medication_schemeid_Internalname ;
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
      private String edtavTfbr_medication_schemeid_Internalname ;
      private String edtavTfbr_medication_schemeid_Jsonclick ;
      private String edtavTfbr_medication_schemeid_to_Internalname ;
      private String edtavTfbr_medication_schemeid_to_Jsonclick ;
      private String edtavTfbr_medicationid_Internalname ;
      private String edtavTfbr_medicationid_Jsonclick ;
      private String edtavTfbr_medicationid_to_Internalname ;
      private String edtavTfbr_medicationid_to_Jsonclick ;
      private String edtavTfbr_medication_chem_name_Internalname ;
      private String edtavTfbr_medication_chem_name_Jsonclick ;
      private String edtavTfbr_medication_chem_name_sel_Internalname ;
      private String edtavTfbr_medication_chem_name_sel_Jsonclick ;
      private String edtavTfbr_medication_chem_cycle_Internalname ;
      private String edtavTfbr_medication_chem_cycle_Jsonclick ;
      private String edtavTfbr_medication_chem_cycle_to_Internalname ;
      private String edtavTfbr_medication_chem_cycle_to_Jsonclick ;
      private String edtavTfbr_medication_chem_line_Internalname ;
      private String edtavTfbr_medication_chem_line_Jsonclick ;
      private String edtavTfbr_medication_chem_line_sel_Internalname ;
      private String edtavTfbr_medication_chem_line_sel_Jsonclick ;
      private String edtavTfbr_medication_chem_detail_Internalname ;
      private String edtavTfbr_medication_chem_detail_Jsonclick ;
      private String edtavTfbr_medication_chem_detail_sel_Internalname ;
      private String edtavTfbr_medication_chem_detail_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_Medication_SchemeID_Internalname ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_Medication_Chem_Name_Internalname ;
      private String edtBR_Medication_Chem_Cycle_Internalname ;
      private String edtBR_Medication_Chem_Line_Internalname ;
      private String edtBR_Medication_Chem_Detail_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_Medication_SchemeID_Jsonclick ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_Medication_Chem_Name_Jsonclick ;
      private String edtBR_Medication_Chem_Cycle_Jsonclick ;
      private String edtBR_Medication_Chem_Line_Jsonclick ;
      private String edtBR_Medication_Chem_Detail_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV47IsAuthorized_Update ;
      private bool AV49IsAuthorized_Delete ;
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
      private bool Ddo_br_medication_schemeid_Includesortasc ;
      private bool Ddo_br_medication_schemeid_Includesortdsc ;
      private bool Ddo_br_medication_schemeid_Includefilter ;
      private bool Ddo_br_medication_schemeid_Filterisrange ;
      private bool Ddo_br_medication_schemeid_Includedatalist ;
      private bool Ddo_br_medicationid_Includesortasc ;
      private bool Ddo_br_medicationid_Includesortdsc ;
      private bool Ddo_br_medicationid_Includefilter ;
      private bool Ddo_br_medicationid_Filterisrange ;
      private bool Ddo_br_medicationid_Includedatalist ;
      private bool Ddo_br_medication_chem_name_Includesortasc ;
      private bool Ddo_br_medication_chem_name_Includesortdsc ;
      private bool Ddo_br_medication_chem_name_Includefilter ;
      private bool Ddo_br_medication_chem_name_Filterisrange ;
      private bool Ddo_br_medication_chem_name_Includedatalist ;
      private bool Ddo_br_medication_chem_cycle_Includesortasc ;
      private bool Ddo_br_medication_chem_cycle_Includesortdsc ;
      private bool Ddo_br_medication_chem_cycle_Includefilter ;
      private bool Ddo_br_medication_chem_cycle_Filterisrange ;
      private bool Ddo_br_medication_chem_cycle_Includedatalist ;
      private bool Ddo_br_medication_chem_line_Includesortasc ;
      private bool Ddo_br_medication_chem_line_Includesortdsc ;
      private bool Ddo_br_medication_chem_line_Includefilter ;
      private bool Ddo_br_medication_chem_line_Filterisrange ;
      private bool Ddo_br_medication_chem_line_Includedatalist ;
      private bool Ddo_br_medication_chem_detail_Includesortasc ;
      private bool Ddo_br_medication_chem_detail_Includesortdsc ;
      private bool Ddo_br_medication_chem_detail_Includefilter ;
      private bool Ddo_br_medication_chem_detail_Filterisrange ;
      private bool Ddo_br_medication_chem_detail_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n119BR_MedicationID ;
      private bool n305BR_Medication_Chem_Name ;
      private bool n306BR_Medication_Chem_Cycle ;
      private bool n307BR_Medication_Chem_Line ;
      private bool n313BR_Medication_Chem_Detail ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV50TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV45Display_IsBlob ;
      private bool AV46Update_IsBlob ;
      private bool AV48Delete_IsBlob ;
      private String AV52TFBR_Medication_Chem_Name ;
      private String AV53TFBR_Medication_Chem_Name_Sel ;
      private String AV60TFBR_Medication_Chem_Line ;
      private String AV61TFBR_Medication_Chem_Line_Sel ;
      private String AV68TFBR_Medication_Chem_Detail ;
      private String AV69TFBR_Medication_Chem_Detail_Sel ;
      private String AV19ddo_BR_Medication_SchemeIDTitleControlIdToReplace ;
      private String AV23ddo_BR_MedicationIDTitleControlIdToReplace ;
      private String AV54ddo_BR_Medication_Chem_NameTitleControlIdToReplace ;
      private String AV58ddo_BR_Medication_Chem_CycleTitleControlIdToReplace ;
      private String AV62ddo_BR_Medication_Chem_LineTitleControlIdToReplace ;
      private String AV70ddo_BR_Medication_Chem_DetailTitleControlIdToReplace ;
      private String A305BR_Medication_Chem_Name ;
      private String A307BR_Medication_Chem_Line ;
      private String A313BR_Medication_Chem_Detail ;
      private String AV85Display_GXI ;
      private String AV86Update_GXI ;
      private String AV87Delete_GXI ;
      private String lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ;
      private String lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ;
      private String lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ;
      private String AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ;
      private String AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ;
      private String AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ;
      private String AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ;
      private String AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ;
      private String AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ;
      private String AV45Display ;
      private String AV46Update ;
      private String AV48Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medication_schemeid ;
      private GXUserControl ucDdo_br_medicationid ;
      private GXUserControl ucDdo_br_medication_chem_name ;
      private GXUserControl ucDdo_br_medication_chem_cycle ;
      private GXUserControl ucDdo_br_medication_chem_line ;
      private GXUserControl ucDdo_br_medication_chem_detail ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H004Z2_A313BR_Medication_Chem_Detail ;
      private bool[] H004Z2_n313BR_Medication_Chem_Detail ;
      private String[] H004Z2_A307BR_Medication_Chem_Line ;
      private bool[] H004Z2_n307BR_Medication_Chem_Line ;
      private decimal[] H004Z2_A306BR_Medication_Chem_Cycle ;
      private bool[] H004Z2_n306BR_Medication_Chem_Cycle ;
      private String[] H004Z2_A305BR_Medication_Chem_Name ;
      private bool[] H004Z2_n305BR_Medication_Chem_Name ;
      private long[] H004Z2_A119BR_MedicationID ;
      private bool[] H004Z2_n119BR_MedicationID ;
      private long[] H004Z2_A296BR_Medication_SchemeID ;
      private long[] H004Z3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Medication_SchemeIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_MedicationIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV51BR_Medication_Chem_NameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV55BR_Medication_Chem_CycleTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV59BR_Medication_Chem_LineTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV67BR_Medication_Chem_DetailTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV40DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_medication_schemeww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H004Z2( IGxContext context ,
                                             long AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ,
                                             long AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ,
                                             long AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid ,
                                             long AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ,
                                             String AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ,
                                             String AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ,
                                             decimal AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ,
                                             decimal AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ,
                                             String AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ,
                                             String AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ,
                                             String AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ,
                                             String AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ,
                                             long A296BR_Medication_SchemeID ,
                                             long A119BR_MedicationID ,
                                             String A305BR_Medication_Chem_Name ,
                                             decimal A306BR_Medication_Chem_Cycle ,
                                             String A307BR_Medication_Chem_Line ,
                                             String A313BR_Medication_Chem_Detail ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [15] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Medication_Chem_Detail], [BR_Medication_Chem_Line], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Name], [BR_MedicationID], [BR_Medication_SchemeID]";
         sFromString = " FROM [BR_Medication_Scheme] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] >= @AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] >= @AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] <= @AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] <= @AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicationID] >= @AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicationID] >= @AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicationID] <= @AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicationID] <= @AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Name] like @lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Name] like @lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Name] = @AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Name] = @AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Cycle] >= @AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Cycle] >= @AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Cycle] <= @AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Cycle] <= @AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Line] like @lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Line] like @lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Line] = @AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Line] = @AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Detail] like @lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Detail] like @lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Detail] = @AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Detail] = @AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_SchemeID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_SchemeID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicationID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicationID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Name]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Name] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Cycle]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Cycle] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Line]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Line] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Detail]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
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

      protected Object[] conditional_H004Z3( IGxContext context ,
                                             long AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ,
                                             long AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ,
                                             long AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid ,
                                             long AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ,
                                             String AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ,
                                             String AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ,
                                             decimal AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ,
                                             decimal AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ,
                                             String AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ,
                                             String AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ,
                                             String AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ,
                                             String AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ,
                                             long A296BR_Medication_SchemeID ,
                                             long A119BR_MedicationID ,
                                             String A305BR_Medication_Chem_Name ,
                                             decimal A306BR_Medication_Chem_Cycle ,
                                             String A307BR_Medication_Chem_Line ,
                                             String A313BR_Medication_Chem_Detail ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [12] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Medication_Scheme] WITH (NOLOCK)";
         if ( ! (0==AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] >= @AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] >= @AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] <= @AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] <= @AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicationID] >= @AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicationID] >= @AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicationID] <= @AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicationID] <= @AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Name] like @lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Name] like @lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Name] = @AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Name] = @AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Cycle] >= @AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Cycle] >= @AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Cycle] <= @AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Cycle] <= @AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Line] like @lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Line] like @lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Line] = @AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Line] = @AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Detail] like @lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Detail] like @lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Detail] = @AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Detail] = @AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
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
                     return conditional_H004Z2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
               case 1 :
                     return conditional_H004Z3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
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
          Object[] prmH004Z2 ;
          prmH004Z2 = new Object[] {
          new Object[] {"@AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH004Z3 ;
          prmH004Z3 = new Object[] {
          new Object[] {"@AV73BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV74BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_Medication_SchemeWWDS_3_Tfbr_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV77BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV78BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV79BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV80BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV81BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV83BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV84BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004Z2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004Z2,11,0,true,false )
             ,new CursorDef("H004Z3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004Z3,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[21]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[22]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[27]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[28]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[29]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
       }
    }

 }

}
