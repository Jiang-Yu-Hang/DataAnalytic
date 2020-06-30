/*
               File: BR_Medication_DetailWW
        Description:  药物治疗药物详情
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:1:59.11
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
   public class br_medication_detailww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_medication_detailww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_detailww( IGxContext context )
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
               AV17TFBR_Medication_DetailID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_Medication_DetailID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_Medication_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_Medication_SchemeID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV48TFBR_Medication_Drug_Name = GetNextPar( );
               AV49TFBR_Medication_Drug_Name_Sel = GetNextPar( );
               AV52TFBR_Medication_Drug_Num = NumberUtil.Val( GetNextPar( ), ".");
               AV53TFBR_Medication_Drug_Num_To = NumberUtil.Val( GetNextPar( ), ".");
               AV56TFBR_Medication_Drug_Unit = GetNextPar( );
               AV57TFBR_Medication_Drug_Unit_Sel = GetNextPar( );
               AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace = GetNextPar( );
               AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace = GetNextPar( );
               AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace = GetNextPar( );
               AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = GetNextPar( );
               AV74Pgmname = GetNextPar( );
               AV43IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV45IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_DetailID, AV18TFBR_Medication_DetailID_To, AV21TFBR_Medication_SchemeID, AV22TFBR_Medication_SchemeID_To, AV48TFBR_Medication_Drug_Name, AV49TFBR_Medication_Drug_Name_Sel, AV52TFBR_Medication_Drug_Num, AV53TFBR_Medication_Drug_Num_To, AV56TFBR_Medication_Drug_Unit, AV57TFBR_Medication_Drug_Unit_Sel, AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace, AV74Pgmname, AV43IsAuthorized_Update, AV45IsAuthorized_Delete) ;
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
         PA4W2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4W2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271215938", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medication_detailww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_DETAILID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Medication_DetailID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_DETAILID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Medication_DetailID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_Medication_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_SCHEMEID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_Medication_SchemeID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_DRUG_NAME", AV48TFBR_Medication_Drug_Name);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_DRUG_NAME_SEL", AV49TFBR_Medication_Drug_Name_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_DRUG_NUM", StringUtil.LTrim( StringUtil.NToC( AV52TFBR_Medication_Drug_Num, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_DRUG_NUM_TO", StringUtil.LTrim( StringUtil.NToC( AV53TFBR_Medication_Drug_Num_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_DRUG_UNIT", AV56TFBR_Medication_Drug_Unit);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_DRUG_UNIT_SEL", AV57TFBR_Medication_Drug_Unit_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV40GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV39GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV36DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV36DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_DETAILIDTITLEFILTERDATA", AV16BR_Medication_DetailIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_DETAILIDTITLEFILTERDATA", AV16BR_Medication_DetailIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA", AV20BR_Medication_SchemeIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA", AV20BR_Medication_SchemeIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA", AV47BR_Medication_Drug_NameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA", AV47BR_Medication_Drug_NameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA", AV51BR_Medication_Drug_NumTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA", AV51BR_Medication_Drug_NumTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA", AV55BR_Medication_Drug_UnitTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA", AV55BR_Medication_Drug_UnitTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV74Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV43IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV45IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Caption", StringUtil.RTrim( Ddo_br_medication_detailid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Tooltip", StringUtil.RTrim( Ddo_br_medication_detailid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Cls", StringUtil.RTrim( Ddo_br_medication_detailid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_detailid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medication_detailid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_detailid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_detailid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_detailid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_detailid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_detailid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_detailid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Filtertype", StringUtil.RTrim( Ddo_br_medication_detailid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_detailid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_detailid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Sortasc", StringUtil.RTrim( Ddo_br_medication_detailid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Sortdsc", StringUtil.RTrim( Ddo_br_medication_detailid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_detailid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medication_detailid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Rangefilterto", StringUtil.RTrim( Ddo_br_medication_detailid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_detailid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Caption", StringUtil.RTrim( Ddo_br_medication_drug_name_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Tooltip", StringUtil.RTrim( Ddo_br_medication_drug_name_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Cls", StringUtil.RTrim( Ddo_br_medication_drug_name_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_drug_name_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_drug_name_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_drug_name_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_drug_name_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_drug_name_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_drug_name_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_drug_name_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_drug_name_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Filtertype", StringUtil.RTrim( Ddo_br_medication_drug_name_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_drug_name_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_drug_name_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Datalisttype", StringUtil.RTrim( Ddo_br_medication_drug_name_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Datalistproc", StringUtil.RTrim( Ddo_br_medication_drug_name_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_drug_name_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Sortasc", StringUtil.RTrim( Ddo_br_medication_drug_name_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Sortdsc", StringUtil.RTrim( Ddo_br_medication_drug_name_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Loadingdata", StringUtil.RTrim( Ddo_br_medication_drug_name_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_drug_name_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_drug_name_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_drug_name_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Caption", StringUtil.RTrim( Ddo_br_medication_drug_num_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Tooltip", StringUtil.RTrim( Ddo_br_medication_drug_num_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Cls", StringUtil.RTrim( Ddo_br_medication_drug_num_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_drug_num_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medication_drug_num_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_drug_num_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_drug_num_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_drug_num_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_drug_num_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_drug_num_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_drug_num_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Filtertype", StringUtil.RTrim( Ddo_br_medication_drug_num_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_drug_num_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_drug_num_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Sortasc", StringUtil.RTrim( Ddo_br_medication_drug_num_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Sortdsc", StringUtil.RTrim( Ddo_br_medication_drug_num_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_drug_num_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medication_drug_num_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Rangefilterto", StringUtil.RTrim( Ddo_br_medication_drug_num_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_drug_num_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Caption", StringUtil.RTrim( Ddo_br_medication_drug_unit_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Tooltip", StringUtil.RTrim( Ddo_br_medication_drug_unit_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Cls", StringUtil.RTrim( Ddo_br_medication_drug_unit_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_drug_unit_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_drug_unit_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_drug_unit_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_drug_unit_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_drug_unit_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_drug_unit_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_drug_unit_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_drug_unit_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Filtertype", StringUtil.RTrim( Ddo_br_medication_drug_unit_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_drug_unit_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_drug_unit_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Datalisttype", StringUtil.RTrim( Ddo_br_medication_drug_unit_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Datalistproc", StringUtil.RTrim( Ddo_br_medication_drug_unit_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_drug_unit_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Sortasc", StringUtil.RTrim( Ddo_br_medication_drug_unit_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Sortdsc", StringUtil.RTrim( Ddo_br_medication_drug_unit_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Loadingdata", StringUtil.RTrim( Ddo_br_medication_drug_unit_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_drug_unit_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_drug_unit_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_drug_unit_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_detailid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_detailid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_detailid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_schemeid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_schemeid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_drug_name_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_drug_name_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_num_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_drug_num_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_drug_num_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_unit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_drug_unit_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_drug_unit_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_detailid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_detailid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_detailid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_schemeid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_schemeid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_drug_name_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_drug_name_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_num_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_drug_num_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_drug_num_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_unit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_drug_unit_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_drug_unit_Selectedvalue_get));
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
            WE4W2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4W2( ) ;
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
         return formatLink("br_medication_detailww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Medication_DetailWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 药物治疗药物详情" ;
      }

      protected void WB4W0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication_DetailWW.htm");
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV41Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV42Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV44Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV38GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV40GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV39GridPageSize);
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
            ucDdo_br_medication_detailid.SetProperty("FilterType", Ddo_br_medication_detailid_Filtertype);
            ucDdo_br_medication_detailid.SetProperty("FilterIsRange", Ddo_br_medication_detailid_Filterisrange);
            ucDdo_br_medication_detailid.SetProperty("IncludeDataList", Ddo_br_medication_detailid_Includedatalist);
            ucDdo_br_medication_detailid.SetProperty("SortASC", Ddo_br_medication_detailid_Sortasc);
            ucDdo_br_medication_detailid.SetProperty("SortDSC", Ddo_br_medication_detailid_Sortdsc);
            ucDdo_br_medication_detailid.SetProperty("CleanFilter", Ddo_br_medication_detailid_Cleanfilter);
            ucDdo_br_medication_detailid.SetProperty("RangeFilterFrom", Ddo_br_medication_detailid_Rangefilterfrom);
            ucDdo_br_medication_detailid.SetProperty("RangeFilterTo", Ddo_br_medication_detailid_Rangefilterto);
            ucDdo_br_medication_detailid.SetProperty("SearchButtonText", Ddo_br_medication_detailid_Searchbuttontext);
            ucDdo_br_medication_detailid.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medication_detailid.SetProperty("DropDownOptionsData", AV16BR_Medication_DetailIDTitleFilterData);
            ucDdo_br_medication_detailid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_detailid_Internalname, "DDO_BR_MEDICATION_DETAILIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_DetailWW.htm");
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
            ucDdo_br_medication_schemeid.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medication_schemeid.SetProperty("DropDownOptionsData", AV20BR_Medication_SchemeIDTitleFilterData);
            ucDdo_br_medication_schemeid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_schemeid_Internalname, "DDO_BR_MEDICATION_SCHEMEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname, AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_DetailWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_drug_name.SetProperty("Caption", Ddo_br_medication_drug_name_Caption);
            ucDdo_br_medication_drug_name.SetProperty("Tooltip", Ddo_br_medication_drug_name_Tooltip);
            ucDdo_br_medication_drug_name.SetProperty("Cls", Ddo_br_medication_drug_name_Cls);
            ucDdo_br_medication_drug_name.SetProperty("DropDownOptionsType", Ddo_br_medication_drug_name_Dropdownoptionstype);
            ucDdo_br_medication_drug_name.SetProperty("IncludeSortASC", Ddo_br_medication_drug_name_Includesortasc);
            ucDdo_br_medication_drug_name.SetProperty("IncludeSortDSC", Ddo_br_medication_drug_name_Includesortdsc);
            ucDdo_br_medication_drug_name.SetProperty("IncludeFilter", Ddo_br_medication_drug_name_Includefilter);
            ucDdo_br_medication_drug_name.SetProperty("FilterType", Ddo_br_medication_drug_name_Filtertype);
            ucDdo_br_medication_drug_name.SetProperty("FilterIsRange", Ddo_br_medication_drug_name_Filterisrange);
            ucDdo_br_medication_drug_name.SetProperty("IncludeDataList", Ddo_br_medication_drug_name_Includedatalist);
            ucDdo_br_medication_drug_name.SetProperty("DataListType", Ddo_br_medication_drug_name_Datalisttype);
            ucDdo_br_medication_drug_name.SetProperty("DataListProc", Ddo_br_medication_drug_name_Datalistproc);
            ucDdo_br_medication_drug_name.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medication_drug_name_Datalistupdateminimumcharacters);
            ucDdo_br_medication_drug_name.SetProperty("SortASC", Ddo_br_medication_drug_name_Sortasc);
            ucDdo_br_medication_drug_name.SetProperty("SortDSC", Ddo_br_medication_drug_name_Sortdsc);
            ucDdo_br_medication_drug_name.SetProperty("LoadingData", Ddo_br_medication_drug_name_Loadingdata);
            ucDdo_br_medication_drug_name.SetProperty("CleanFilter", Ddo_br_medication_drug_name_Cleanfilter);
            ucDdo_br_medication_drug_name.SetProperty("NoResultsFound", Ddo_br_medication_drug_name_Noresultsfound);
            ucDdo_br_medication_drug_name.SetProperty("SearchButtonText", Ddo_br_medication_drug_name_Searchbuttontext);
            ucDdo_br_medication_drug_name.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medication_drug_name.SetProperty("DropDownOptionsData", AV47BR_Medication_Drug_NameTitleFilterData);
            ucDdo_br_medication_drug_name.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_drug_name_Internalname, "DDO_BR_MEDICATION_DRUG_NAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Internalname, AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_DetailWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_drug_num.SetProperty("Caption", Ddo_br_medication_drug_num_Caption);
            ucDdo_br_medication_drug_num.SetProperty("Tooltip", Ddo_br_medication_drug_num_Tooltip);
            ucDdo_br_medication_drug_num.SetProperty("Cls", Ddo_br_medication_drug_num_Cls);
            ucDdo_br_medication_drug_num.SetProperty("DropDownOptionsType", Ddo_br_medication_drug_num_Dropdownoptionstype);
            ucDdo_br_medication_drug_num.SetProperty("IncludeSortASC", Ddo_br_medication_drug_num_Includesortasc);
            ucDdo_br_medication_drug_num.SetProperty("IncludeSortDSC", Ddo_br_medication_drug_num_Includesortdsc);
            ucDdo_br_medication_drug_num.SetProperty("IncludeFilter", Ddo_br_medication_drug_num_Includefilter);
            ucDdo_br_medication_drug_num.SetProperty("FilterType", Ddo_br_medication_drug_num_Filtertype);
            ucDdo_br_medication_drug_num.SetProperty("FilterIsRange", Ddo_br_medication_drug_num_Filterisrange);
            ucDdo_br_medication_drug_num.SetProperty("IncludeDataList", Ddo_br_medication_drug_num_Includedatalist);
            ucDdo_br_medication_drug_num.SetProperty("SortASC", Ddo_br_medication_drug_num_Sortasc);
            ucDdo_br_medication_drug_num.SetProperty("SortDSC", Ddo_br_medication_drug_num_Sortdsc);
            ucDdo_br_medication_drug_num.SetProperty("CleanFilter", Ddo_br_medication_drug_num_Cleanfilter);
            ucDdo_br_medication_drug_num.SetProperty("RangeFilterFrom", Ddo_br_medication_drug_num_Rangefilterfrom);
            ucDdo_br_medication_drug_num.SetProperty("RangeFilterTo", Ddo_br_medication_drug_num_Rangefilterto);
            ucDdo_br_medication_drug_num.SetProperty("SearchButtonText", Ddo_br_medication_drug_num_Searchbuttontext);
            ucDdo_br_medication_drug_num.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medication_drug_num.SetProperty("DropDownOptionsData", AV51BR_Medication_Drug_NumTitleFilterData);
            ucDdo_br_medication_drug_num.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_drug_num_Internalname, "DDO_BR_MEDICATION_DRUG_NUMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Internalname, AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_DetailWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_drug_unit.SetProperty("Caption", Ddo_br_medication_drug_unit_Caption);
            ucDdo_br_medication_drug_unit.SetProperty("Tooltip", Ddo_br_medication_drug_unit_Tooltip);
            ucDdo_br_medication_drug_unit.SetProperty("Cls", Ddo_br_medication_drug_unit_Cls);
            ucDdo_br_medication_drug_unit.SetProperty("DropDownOptionsType", Ddo_br_medication_drug_unit_Dropdownoptionstype);
            ucDdo_br_medication_drug_unit.SetProperty("IncludeSortASC", Ddo_br_medication_drug_unit_Includesortasc);
            ucDdo_br_medication_drug_unit.SetProperty("IncludeSortDSC", Ddo_br_medication_drug_unit_Includesortdsc);
            ucDdo_br_medication_drug_unit.SetProperty("IncludeFilter", Ddo_br_medication_drug_unit_Includefilter);
            ucDdo_br_medication_drug_unit.SetProperty("FilterType", Ddo_br_medication_drug_unit_Filtertype);
            ucDdo_br_medication_drug_unit.SetProperty("FilterIsRange", Ddo_br_medication_drug_unit_Filterisrange);
            ucDdo_br_medication_drug_unit.SetProperty("IncludeDataList", Ddo_br_medication_drug_unit_Includedatalist);
            ucDdo_br_medication_drug_unit.SetProperty("DataListType", Ddo_br_medication_drug_unit_Datalisttype);
            ucDdo_br_medication_drug_unit.SetProperty("DataListProc", Ddo_br_medication_drug_unit_Datalistproc);
            ucDdo_br_medication_drug_unit.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medication_drug_unit_Datalistupdateminimumcharacters);
            ucDdo_br_medication_drug_unit.SetProperty("SortASC", Ddo_br_medication_drug_unit_Sortasc);
            ucDdo_br_medication_drug_unit.SetProperty("SortDSC", Ddo_br_medication_drug_unit_Sortdsc);
            ucDdo_br_medication_drug_unit.SetProperty("LoadingData", Ddo_br_medication_drug_unit_Loadingdata);
            ucDdo_br_medication_drug_unit.SetProperty("CleanFilter", Ddo_br_medication_drug_unit_Cleanfilter);
            ucDdo_br_medication_drug_unit.SetProperty("NoResultsFound", Ddo_br_medication_drug_unit_Noresultsfound);
            ucDdo_br_medication_drug_unit.SetProperty("SearchButtonText", Ddo_br_medication_drug_unit_Searchbuttontext);
            ucDdo_br_medication_drug_unit.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medication_drug_unit.SetProperty("DropDownOptionsData", AV55BR_Medication_Drug_UnitTitleFilterData);
            ucDdo_br_medication_drug_unit.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_drug_unit_Internalname, "DDO_BR_MEDICATION_DRUG_UNITContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Internalname, AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_DetailWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_detailid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Medication_DetailID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_detailid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_detailid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_detailid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Medication_DetailID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_Medication_DetailID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_detailid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_detailid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_schemeid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_Medication_SchemeID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_schemeid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_schemeid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_schemeid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_Medication_SchemeID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_Medication_SchemeID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_schemeid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_schemeid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_drug_name_Internalname, AV48TFBR_Medication_Drug_Name, StringUtil.RTrim( context.localUtil.Format( AV48TFBR_Medication_Drug_Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_drug_name_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_drug_name_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_drug_name_sel_Internalname, AV49TFBR_Medication_Drug_Name_Sel, StringUtil.RTrim( context.localUtil.Format( AV49TFBR_Medication_Drug_Name_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_drug_name_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_drug_name_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_drug_num_Internalname, StringUtil.LTrim( StringUtil.NToC( AV52TFBR_Medication_Drug_Num, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV52TFBR_Medication_Drug_Num, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_drug_num_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_drug_num_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_drug_num_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV53TFBR_Medication_Drug_Num_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV53TFBR_Medication_Drug_Num_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_drug_num_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_drug_num_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_drug_unit_Internalname, AV56TFBR_Medication_Drug_Unit, StringUtil.RTrim( context.localUtil.Format( AV56TFBR_Medication_Drug_Unit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_drug_unit_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_drug_unit_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_DetailWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_drug_unit_sel_Internalname, AV57TFBR_Medication_Drug_Unit_Sel, StringUtil.RTrim( context.localUtil.Format( AV57TFBR_Medication_Drug_Unit_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_drug_unit_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_drug_unit_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_DetailWW.htm");
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

      protected void START4W2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 药物治疗药物详情", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP4W0( ) ;
      }

      protected void WS4W2( )
      {
         START4W2( ) ;
         EVT4W2( ) ;
      }

      protected void EVT4W2( )
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
                              E114W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E124W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_DETAILID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E134W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E144W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E154W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E164W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E174W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E184W2 ();
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
                              AV41Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV41Display)) ? AV71Display_GXI : context.convertURL( context.PathToRelativeUrl( AV41Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV41Display), true);
                              AV42Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV42Update)) ? AV72Update_GXI : context.convertURL( context.PathToRelativeUrl( AV42Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV42Update), true);
                              AV44Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV44Delete)) ? AV73Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV44Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV44Delete), true);
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
                                    E194W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E204W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E214W2 ();
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
                                       /* Set Refresh If Tfbr_medication_detailid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_DETAILID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Medication_DetailID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_detailid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_DETAILID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Medication_DetailID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_schemeid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_SCHEMEID"), ".", ",") != Convert.ToDecimal( AV21TFBR_Medication_SchemeID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_schemeid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_SCHEMEID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_Medication_SchemeID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_drug_name Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_DRUG_NAME"), AV48TFBR_Medication_Drug_Name) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_drug_name_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_DRUG_NAME_SEL"), AV49TFBR_Medication_Drug_Name_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_drug_num Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_DRUG_NUM"), ".", ",") != AV52TFBR_Medication_Drug_Num )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_drug_num_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_DRUG_NUM_TO"), ".", ",") != AV53TFBR_Medication_Drug_Num_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_drug_unit Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_DRUG_UNIT"), AV56TFBR_Medication_Drug_Unit) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_drug_unit_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_DRUG_UNIT_SEL"), AV57TFBR_Medication_Drug_Unit_Sel) != 0 )
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

      protected void WE4W2( )
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

      protected void PA4W2( )
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
                                       long AV17TFBR_Medication_DetailID ,
                                       long AV18TFBR_Medication_DetailID_To ,
                                       long AV21TFBR_Medication_SchemeID ,
                                       long AV22TFBR_Medication_SchemeID_To ,
                                       String AV48TFBR_Medication_Drug_Name ,
                                       String AV49TFBR_Medication_Drug_Name_Sel ,
                                       decimal AV52TFBR_Medication_Drug_Num ,
                                       decimal AV53TFBR_Medication_Drug_Num_To ,
                                       String AV56TFBR_Medication_Drug_Unit ,
                                       String AV57TFBR_Medication_Drug_Unit_Sel ,
                                       String AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace ,
                                       String AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace ,
                                       String AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace ,
                                       String AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace ,
                                       String AV74Pgmname ,
                                       bool AV43IsAuthorized_Update ,
                                       bool AV45IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF4W2( ) ;
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
         RF4W2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV74Pgmname = "BR_Medication_DetailWW";
         context.Gx_err = 0;
      }

      protected void RF4W2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E204W2 ();
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
                                                 AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid ,
                                                 AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to ,
                                                 AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid ,
                                                 AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to ,
                                                 AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel ,
                                                 AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ,
                                                 AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num ,
                                                 AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to ,
                                                 AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel ,
                                                 AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ,
                                                 A301BR_Medication_DetailID ,
                                                 A296BR_Medication_SchemeID ,
                                                 A310BR_Medication_Drug_Name ,
                                                 A311BR_Medication_Drug_Num ,
                                                 A312BR_Medication_Drug_Unit ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT,
                                                 TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = StringUtil.Concat( StringUtil.RTrim( AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name), "%", "");
            lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = StringUtil.Concat( StringUtil.RTrim( AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit), "%", "");
            /* Using cursor H004W2 */
            pr_default.execute(0, new Object[] {AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid, AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to, AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid, AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to, lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name, AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel, AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num, AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to, lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit, AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A312BR_Medication_Drug_Unit = H004W2_A312BR_Medication_Drug_Unit[0];
               n312BR_Medication_Drug_Unit = H004W2_n312BR_Medication_Drug_Unit[0];
               A311BR_Medication_Drug_Num = H004W2_A311BR_Medication_Drug_Num[0];
               n311BR_Medication_Drug_Num = H004W2_n311BR_Medication_Drug_Num[0];
               A310BR_Medication_Drug_Name = H004W2_A310BR_Medication_Drug_Name[0];
               n310BR_Medication_Drug_Name = H004W2_n310BR_Medication_Drug_Name[0];
               A296BR_Medication_SchemeID = H004W2_A296BR_Medication_SchemeID[0];
               n296BR_Medication_SchemeID = H004W2_n296BR_Medication_SchemeID[0];
               A301BR_Medication_DetailID = H004W2_A301BR_Medication_DetailID[0];
               E214W2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB4W0( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes4W2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_DETAILID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid = AV17TFBR_Medication_DetailID;
         AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to = AV18TFBR_Medication_DetailID_To;
         AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid = AV21TFBR_Medication_SchemeID;
         AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to = AV22TFBR_Medication_SchemeID_To;
         AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = AV48TFBR_Medication_Drug_Name;
         AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = AV49TFBR_Medication_Drug_Name_Sel;
         AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num = AV52TFBR_Medication_Drug_Num;
         AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to = AV53TFBR_Medication_Drug_Num_To;
         AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = AV56TFBR_Medication_Drug_Unit;
         AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = AV57TFBR_Medication_Drug_Unit_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid ,
                                              AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to ,
                                              AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid ,
                                              AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to ,
                                              AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel ,
                                              AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ,
                                              AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num ,
                                              AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to ,
                                              AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel ,
                                              AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ,
                                              A301BR_Medication_DetailID ,
                                              A296BR_Medication_SchemeID ,
                                              A310BR_Medication_Drug_Name ,
                                              A311BR_Medication_Drug_Num ,
                                              A312BR_Medication_Drug_Unit ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = StringUtil.Concat( StringUtil.RTrim( AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name), "%", "");
         lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = StringUtil.Concat( StringUtil.RTrim( AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit), "%", "");
         /* Using cursor H004W3 */
         pr_default.execute(1, new Object[] {AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid, AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to, AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid, AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to, lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name, AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel, AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num, AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to, lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit, AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel});
         GRID_nRecordCount = H004W3_AGRID_nRecordCount[0];
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
         AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid = AV17TFBR_Medication_DetailID;
         AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to = AV18TFBR_Medication_DetailID_To;
         AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid = AV21TFBR_Medication_SchemeID;
         AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to = AV22TFBR_Medication_SchemeID_To;
         AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = AV48TFBR_Medication_Drug_Name;
         AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = AV49TFBR_Medication_Drug_Name_Sel;
         AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num = AV52TFBR_Medication_Drug_Num;
         AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to = AV53TFBR_Medication_Drug_Num_To;
         AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = AV56TFBR_Medication_Drug_Unit;
         AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = AV57TFBR_Medication_Drug_Unit_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_DetailID, AV18TFBR_Medication_DetailID_To, AV21TFBR_Medication_SchemeID, AV22TFBR_Medication_SchemeID_To, AV48TFBR_Medication_Drug_Name, AV49TFBR_Medication_Drug_Name_Sel, AV52TFBR_Medication_Drug_Num, AV53TFBR_Medication_Drug_Num_To, AV56TFBR_Medication_Drug_Unit, AV57TFBR_Medication_Drug_Unit_Sel, AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace, AV74Pgmname, AV43IsAuthorized_Update, AV45IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid = AV17TFBR_Medication_DetailID;
         AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to = AV18TFBR_Medication_DetailID_To;
         AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid = AV21TFBR_Medication_SchemeID;
         AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to = AV22TFBR_Medication_SchemeID_To;
         AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = AV48TFBR_Medication_Drug_Name;
         AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = AV49TFBR_Medication_Drug_Name_Sel;
         AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num = AV52TFBR_Medication_Drug_Num;
         AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to = AV53TFBR_Medication_Drug_Num_To;
         AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = AV56TFBR_Medication_Drug_Unit;
         AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = AV57TFBR_Medication_Drug_Unit_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_DetailID, AV18TFBR_Medication_DetailID_To, AV21TFBR_Medication_SchemeID, AV22TFBR_Medication_SchemeID_To, AV48TFBR_Medication_Drug_Name, AV49TFBR_Medication_Drug_Name_Sel, AV52TFBR_Medication_Drug_Num, AV53TFBR_Medication_Drug_Num_To, AV56TFBR_Medication_Drug_Unit, AV57TFBR_Medication_Drug_Unit_Sel, AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace, AV74Pgmname, AV43IsAuthorized_Update, AV45IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid = AV17TFBR_Medication_DetailID;
         AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to = AV18TFBR_Medication_DetailID_To;
         AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid = AV21TFBR_Medication_SchemeID;
         AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to = AV22TFBR_Medication_SchemeID_To;
         AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = AV48TFBR_Medication_Drug_Name;
         AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = AV49TFBR_Medication_Drug_Name_Sel;
         AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num = AV52TFBR_Medication_Drug_Num;
         AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to = AV53TFBR_Medication_Drug_Num_To;
         AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = AV56TFBR_Medication_Drug_Unit;
         AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = AV57TFBR_Medication_Drug_Unit_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_DetailID, AV18TFBR_Medication_DetailID_To, AV21TFBR_Medication_SchemeID, AV22TFBR_Medication_SchemeID_To, AV48TFBR_Medication_Drug_Name, AV49TFBR_Medication_Drug_Name_Sel, AV52TFBR_Medication_Drug_Num, AV53TFBR_Medication_Drug_Num_To, AV56TFBR_Medication_Drug_Unit, AV57TFBR_Medication_Drug_Unit_Sel, AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace, AV74Pgmname, AV43IsAuthorized_Update, AV45IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid = AV17TFBR_Medication_DetailID;
         AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to = AV18TFBR_Medication_DetailID_To;
         AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid = AV21TFBR_Medication_SchemeID;
         AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to = AV22TFBR_Medication_SchemeID_To;
         AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = AV48TFBR_Medication_Drug_Name;
         AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = AV49TFBR_Medication_Drug_Name_Sel;
         AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num = AV52TFBR_Medication_Drug_Num;
         AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to = AV53TFBR_Medication_Drug_Num_To;
         AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = AV56TFBR_Medication_Drug_Unit;
         AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = AV57TFBR_Medication_Drug_Unit_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_DetailID, AV18TFBR_Medication_DetailID_To, AV21TFBR_Medication_SchemeID, AV22TFBR_Medication_SchemeID_To, AV48TFBR_Medication_Drug_Name, AV49TFBR_Medication_Drug_Name_Sel, AV52TFBR_Medication_Drug_Num, AV53TFBR_Medication_Drug_Num_To, AV56TFBR_Medication_Drug_Unit, AV57TFBR_Medication_Drug_Unit_Sel, AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace, AV74Pgmname, AV43IsAuthorized_Update, AV45IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid = AV17TFBR_Medication_DetailID;
         AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to = AV18TFBR_Medication_DetailID_To;
         AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid = AV21TFBR_Medication_SchemeID;
         AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to = AV22TFBR_Medication_SchemeID_To;
         AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = AV48TFBR_Medication_Drug_Name;
         AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = AV49TFBR_Medication_Drug_Name_Sel;
         AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num = AV52TFBR_Medication_Drug_Num;
         AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to = AV53TFBR_Medication_Drug_Num_To;
         AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = AV56TFBR_Medication_Drug_Unit;
         AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = AV57TFBR_Medication_Drug_Unit_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Medication_DetailID, AV18TFBR_Medication_DetailID_To, AV21TFBR_Medication_SchemeID, AV22TFBR_Medication_SchemeID_To, AV48TFBR_Medication_Drug_Name, AV49TFBR_Medication_Drug_Name_Sel, AV52TFBR_Medication_Drug_Num, AV53TFBR_Medication_Drug_Num_To, AV56TFBR_Medication_Drug_Unit, AV57TFBR_Medication_Drug_Unit_Sel, AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace, AV74Pgmname, AV43IsAuthorized_Update, AV45IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP4W0( )
      {
         /* Before Start, stand alone formulas. */
         AV74Pgmname = "BR_Medication_DetailWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E194W2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV36DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_DETAILIDTITLEFILTERDATA"), AV16BR_Medication_DetailIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA"), AV20BR_Medication_SchemeIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA"), AV47BR_Medication_Drug_NameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA"), AV51BR_Medication_Drug_NumTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA"), AV55BR_Medication_Drug_UnitTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace", AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace);
            AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace", AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace);
            AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace", AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace);
            AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace", AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace);
            AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace", AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_detailid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_detailid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_DETAILID");
               GX_FocusControl = edtavTfbr_medication_detailid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_Medication_DetailID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Medication_DetailID), 18, 0)));
            }
            else
            {
               AV17TFBR_Medication_DetailID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medication_detailid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Medication_DetailID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_detailid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_detailid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_DETAILID_TO");
               GX_FocusControl = edtavTfbr_medication_detailid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_Medication_DetailID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Medication_DetailID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Medication_DetailID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_Medication_DetailID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medication_detailid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Medication_DetailID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Medication_DetailID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_SCHEMEID");
               GX_FocusControl = edtavTfbr_medication_schemeid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_Medication_SchemeID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_Medication_SchemeID), 18, 0)));
            }
            else
            {
               AV21TFBR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_Medication_SchemeID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_SCHEMEID_TO");
               GX_FocusControl = edtavTfbr_medication_schemeid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_Medication_SchemeID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_Medication_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_Medication_SchemeID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_Medication_SchemeID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medication_schemeid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_Medication_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_Medication_SchemeID_To), 18, 0)));
            }
            AV48TFBR_Medication_Drug_Name = cgiGet( edtavTfbr_medication_drug_name_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48TFBR_Medication_Drug_Name", AV48TFBR_Medication_Drug_Name);
            AV49TFBR_Medication_Drug_Name_Sel = cgiGet( edtavTfbr_medication_drug_name_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49TFBR_Medication_Drug_Name_Sel", AV49TFBR_Medication_Drug_Name_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_drug_num_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_drug_num_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_DRUG_NUM");
               GX_FocusControl = edtavTfbr_medication_drug_num_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV52TFBR_Medication_Drug_Num = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Medication_Drug_Num", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Medication_Drug_Num, 15, 5)));
            }
            else
            {
               AV52TFBR_Medication_Drug_Num = context.localUtil.CToN( cgiGet( edtavTfbr_medication_drug_num_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Medication_Drug_Num", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Medication_Drug_Num, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_drug_num_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_drug_num_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_DRUG_NUM_TO");
               GX_FocusControl = edtavTfbr_medication_drug_num_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV53TFBR_Medication_Drug_Num_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53TFBR_Medication_Drug_Num_To", StringUtil.LTrim( StringUtil.Str( AV53TFBR_Medication_Drug_Num_To, 15, 5)));
            }
            else
            {
               AV53TFBR_Medication_Drug_Num_To = context.localUtil.CToN( cgiGet( edtavTfbr_medication_drug_num_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53TFBR_Medication_Drug_Num_To", StringUtil.LTrim( StringUtil.Str( AV53TFBR_Medication_Drug_Num_To, 15, 5)));
            }
            AV56TFBR_Medication_Drug_Unit = cgiGet( edtavTfbr_medication_drug_unit_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Medication_Drug_Unit", AV56TFBR_Medication_Drug_Unit);
            AV57TFBR_Medication_Drug_Unit_Sel = cgiGet( edtavTfbr_medication_drug_unit_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFBR_Medication_Drug_Unit_Sel", AV57TFBR_Medication_Drug_Unit_Sel);
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV38GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV40GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV39GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_medication_detailid_Caption = cgiGet( "DDO_BR_MEDICATION_DETAILID_Caption");
            Ddo_br_medication_detailid_Tooltip = cgiGet( "DDO_BR_MEDICATION_DETAILID_Tooltip");
            Ddo_br_medication_detailid_Cls = cgiGet( "DDO_BR_MEDICATION_DETAILID_Cls");
            Ddo_br_medication_detailid_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_DETAILID_Filteredtext_set");
            Ddo_br_medication_detailid_Filteredtextto_set = cgiGet( "DDO_BR_MEDICATION_DETAILID_Filteredtextto_set");
            Ddo_br_medication_detailid_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_DETAILID_Dropdownoptionstype");
            Ddo_br_medication_detailid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_DETAILID_Titlecontrolidtoreplace");
            Ddo_br_medication_detailid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DETAILID_Includesortasc"));
            Ddo_br_medication_detailid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DETAILID_Includesortdsc"));
            Ddo_br_medication_detailid_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_DETAILID_Sortedstatus");
            Ddo_br_medication_detailid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DETAILID_Includefilter"));
            Ddo_br_medication_detailid_Filtertype = cgiGet( "DDO_BR_MEDICATION_DETAILID_Filtertype");
            Ddo_br_medication_detailid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DETAILID_Filterisrange"));
            Ddo_br_medication_detailid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DETAILID_Includedatalist"));
            Ddo_br_medication_detailid_Sortasc = cgiGet( "DDO_BR_MEDICATION_DETAILID_Sortasc");
            Ddo_br_medication_detailid_Sortdsc = cgiGet( "DDO_BR_MEDICATION_DETAILID_Sortdsc");
            Ddo_br_medication_detailid_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_DETAILID_Cleanfilter");
            Ddo_br_medication_detailid_Rangefilterfrom = cgiGet( "DDO_BR_MEDICATION_DETAILID_Rangefilterfrom");
            Ddo_br_medication_detailid_Rangefilterto = cgiGet( "DDO_BR_MEDICATION_DETAILID_Rangefilterto");
            Ddo_br_medication_detailid_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_DETAILID_Searchbuttontext");
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
            Ddo_br_medication_drug_name_Caption = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Caption");
            Ddo_br_medication_drug_name_Tooltip = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Tooltip");
            Ddo_br_medication_drug_name_Cls = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Cls");
            Ddo_br_medication_drug_name_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Filteredtext_set");
            Ddo_br_medication_drug_name_Selectedvalue_set = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Selectedvalue_set");
            Ddo_br_medication_drug_name_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Dropdownoptionstype");
            Ddo_br_medication_drug_name_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Titlecontrolidtoreplace");
            Ddo_br_medication_drug_name_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Includesortasc"));
            Ddo_br_medication_drug_name_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Includesortdsc"));
            Ddo_br_medication_drug_name_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Sortedstatus");
            Ddo_br_medication_drug_name_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Includefilter"));
            Ddo_br_medication_drug_name_Filtertype = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Filtertype");
            Ddo_br_medication_drug_name_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Filterisrange"));
            Ddo_br_medication_drug_name_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Includedatalist"));
            Ddo_br_medication_drug_name_Datalisttype = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Datalisttype");
            Ddo_br_medication_drug_name_Datalistproc = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Datalistproc");
            Ddo_br_medication_drug_name_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_drug_name_Sortasc = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Sortasc");
            Ddo_br_medication_drug_name_Sortdsc = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Sortdsc");
            Ddo_br_medication_drug_name_Loadingdata = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Loadingdata");
            Ddo_br_medication_drug_name_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Cleanfilter");
            Ddo_br_medication_drug_name_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Noresultsfound");
            Ddo_br_medication_drug_name_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Searchbuttontext");
            Ddo_br_medication_drug_num_Caption = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Caption");
            Ddo_br_medication_drug_num_Tooltip = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Tooltip");
            Ddo_br_medication_drug_num_Cls = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Cls");
            Ddo_br_medication_drug_num_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Filteredtext_set");
            Ddo_br_medication_drug_num_Filteredtextto_set = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Filteredtextto_set");
            Ddo_br_medication_drug_num_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Dropdownoptionstype");
            Ddo_br_medication_drug_num_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Titlecontrolidtoreplace");
            Ddo_br_medication_drug_num_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Includesortasc"));
            Ddo_br_medication_drug_num_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Includesortdsc"));
            Ddo_br_medication_drug_num_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Sortedstatus");
            Ddo_br_medication_drug_num_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Includefilter"));
            Ddo_br_medication_drug_num_Filtertype = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Filtertype");
            Ddo_br_medication_drug_num_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Filterisrange"));
            Ddo_br_medication_drug_num_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Includedatalist"));
            Ddo_br_medication_drug_num_Sortasc = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Sortasc");
            Ddo_br_medication_drug_num_Sortdsc = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Sortdsc");
            Ddo_br_medication_drug_num_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Cleanfilter");
            Ddo_br_medication_drug_num_Rangefilterfrom = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Rangefilterfrom");
            Ddo_br_medication_drug_num_Rangefilterto = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Rangefilterto");
            Ddo_br_medication_drug_num_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Searchbuttontext");
            Ddo_br_medication_drug_unit_Caption = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Caption");
            Ddo_br_medication_drug_unit_Tooltip = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Tooltip");
            Ddo_br_medication_drug_unit_Cls = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Cls");
            Ddo_br_medication_drug_unit_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Filteredtext_set");
            Ddo_br_medication_drug_unit_Selectedvalue_set = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Selectedvalue_set");
            Ddo_br_medication_drug_unit_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Dropdownoptionstype");
            Ddo_br_medication_drug_unit_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Titlecontrolidtoreplace");
            Ddo_br_medication_drug_unit_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Includesortasc"));
            Ddo_br_medication_drug_unit_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Includesortdsc"));
            Ddo_br_medication_drug_unit_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Sortedstatus");
            Ddo_br_medication_drug_unit_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Includefilter"));
            Ddo_br_medication_drug_unit_Filtertype = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Filtertype");
            Ddo_br_medication_drug_unit_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Filterisrange"));
            Ddo_br_medication_drug_unit_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Includedatalist"));
            Ddo_br_medication_drug_unit_Datalisttype = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Datalisttype");
            Ddo_br_medication_drug_unit_Datalistproc = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Datalistproc");
            Ddo_br_medication_drug_unit_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_drug_unit_Sortasc = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Sortasc");
            Ddo_br_medication_drug_unit_Sortdsc = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Sortdsc");
            Ddo_br_medication_drug_unit_Loadingdata = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Loadingdata");
            Ddo_br_medication_drug_unit_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Cleanfilter");
            Ddo_br_medication_drug_unit_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Noresultsfound");
            Ddo_br_medication_drug_unit_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medication_detailid_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_DETAILID_Activeeventkey");
            Ddo_br_medication_detailid_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_DETAILID_Filteredtext_get");
            Ddo_br_medication_detailid_Filteredtextto_get = cgiGet( "DDO_BR_MEDICATION_DETAILID_Filteredtextto_get");
            Ddo_br_medication_schemeid_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey");
            Ddo_br_medication_schemeid_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Filteredtext_get");
            Ddo_br_medication_schemeid_Filteredtextto_get = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Filteredtextto_get");
            Ddo_br_medication_drug_name_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Activeeventkey");
            Ddo_br_medication_drug_name_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Filteredtext_get");
            Ddo_br_medication_drug_name_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Selectedvalue_get");
            Ddo_br_medication_drug_num_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Activeeventkey");
            Ddo_br_medication_drug_num_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Filteredtext_get");
            Ddo_br_medication_drug_num_Filteredtextto_get = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Filteredtextto_get");
            Ddo_br_medication_drug_unit_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Activeeventkey");
            Ddo_br_medication_drug_unit_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Filteredtext_get");
            Ddo_br_medication_drug_unit_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_DETAILID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Medication_DetailID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_DETAILID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Medication_DetailID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_SCHEMEID"), ".", ",") != Convert.ToDecimal( AV21TFBR_Medication_SchemeID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_SCHEMEID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_Medication_SchemeID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_DRUG_NAME"), AV48TFBR_Medication_Drug_Name) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_DRUG_NAME_SEL"), AV49TFBR_Medication_Drug_Name_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_DRUG_NUM"), ".", ",") != AV52TFBR_Medication_Drug_Num )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_DRUG_NUM_TO"), ".", ",") != AV53TFBR_Medication_Drug_Num_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_DRUG_UNIT"), AV56TFBR_Medication_Drug_Unit) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_DRUG_UNIT_SEL"), AV57TFBR_Medication_Drug_Unit_Sel) != 0 )
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
         E194W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E194W2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_medication_detailid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_detailid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_detailid_Visible), 5, 0)), true);
         edtavTfbr_medication_detailid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_detailid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_detailid_to_Visible), 5, 0)), true);
         edtavTfbr_medication_schemeid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_schemeid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_schemeid_Visible), 5, 0)), true);
         edtavTfbr_medication_schemeid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_schemeid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_schemeid_to_Visible), 5, 0)), true);
         edtavTfbr_medication_drug_name_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_drug_name_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_drug_name_Visible), 5, 0)), true);
         edtavTfbr_medication_drug_name_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_drug_name_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_drug_name_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_drug_num_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_drug_num_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_drug_num_Visible), 5, 0)), true);
         edtavTfbr_medication_drug_num_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_drug_num_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_drug_num_to_Visible), 5, 0)), true);
         edtavTfbr_medication_drug_unit_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_drug_unit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_drug_unit_Visible), 5, 0)), true);
         edtavTfbr_medication_drug_unit_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_drug_unit_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_drug_unit_sel_Visible), 5, 0)), true);
         Ddo_br_medication_detailid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_DetailID";
         ucDdo_br_medication_detailid.SendProperty(context, "", false, Ddo_br_medication_detailid_Internalname, "TitleControlIdToReplace", Ddo_br_medication_detailid_Titlecontrolidtoreplace);
         AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace = Ddo_br_medication_detailid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace", AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace);
         edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_schemeid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_SchemeID";
         ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "TitleControlIdToReplace", Ddo_br_medication_schemeid_Titlecontrolidtoreplace);
         AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace = Ddo_br_medication_schemeid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace", AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace);
         edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_drug_name_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Drug_Name";
         ucDdo_br_medication_drug_name.SendProperty(context, "", false, Ddo_br_medication_drug_name_Internalname, "TitleControlIdToReplace", Ddo_br_medication_drug_name_Titlecontrolidtoreplace);
         AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace = Ddo_br_medication_drug_name_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace", AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace);
         edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_drug_num_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Drug_Num";
         ucDdo_br_medication_drug_num.SendProperty(context, "", false, Ddo_br_medication_drug_num_Internalname, "TitleControlIdToReplace", Ddo_br_medication_drug_num_Titlecontrolidtoreplace);
         AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace = Ddo_br_medication_drug_num_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace", AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace);
         edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_drug_unit_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Drug_Unit";
         ucDdo_br_medication_drug_unit.SendProperty(context, "", false, Ddo_br_medication_drug_unit_Internalname, "TitleControlIdToReplace", Ddo_br_medication_drug_unit_Titlecontrolidtoreplace);
         AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = Ddo_br_medication_drug_unit_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace", AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace);
         edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 药物治疗药物详情";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV36DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV36DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E204W2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_Medication_DetailIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Medication_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV47BR_Medication_Drug_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV51BR_Medication_Drug_NumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV55BR_Medication_Drug_UnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Medication_DetailID_Titleformat = 2;
         edtBR_Medication_DetailID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物治疗药物详情主键", AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_DetailID_Internalname, "Title", edtBR_Medication_DetailID_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_SchemeID_Titleformat = 2;
         edtBR_Medication_SchemeID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物治疗化疗方案主键", AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Title", edtBR_Medication_SchemeID_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_Drug_Name_Titleformat = 2;
         edtBR_Medication_Drug_Name_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物名称", AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Drug_Name_Internalname, "Title", edtBR_Medication_Drug_Name_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_Drug_Num_Titleformat = 2;
         edtBR_Medication_Drug_Num_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "数量", AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Drug_Num_Internalname, "Title", edtBR_Medication_Drug_Num_Title, !bGXsfl_31_Refreshing);
         edtBR_Medication_Drug_Unit_Titleformat = 2;
         edtBR_Medication_Drug_Unit_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "单位", AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Drug_Unit_Internalname, "Title", edtBR_Medication_Drug_Unit_Title, !bGXsfl_31_Refreshing);
         AV38GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
         AV39GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV39GridPageSize), 10, 0)));
         AV40GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV40GridRecordCount), 10, 0)));
         AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid = AV17TFBR_Medication_DetailID;
         AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to = AV18TFBR_Medication_DetailID_To;
         AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid = AV21TFBR_Medication_SchemeID;
         AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to = AV22TFBR_Medication_SchemeID_To;
         AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = AV48TFBR_Medication_Drug_Name;
         AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = AV49TFBR_Medication_Drug_Name_Sel;
         AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num = AV52TFBR_Medication_Drug_Num;
         AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to = AV53TFBR_Medication_Drug_Num_To;
         AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = AV56TFBR_Medication_Drug_Unit;
         AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = AV57TFBR_Medication_Drug_Unit_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_DetailIDTitleFilterData", AV16BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_SchemeIDTitleFilterData", AV20BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Medication_Drug_NameTitleFilterData", AV47BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Drug_NumTitleFilterData", AV51BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Drug_UnitTitleFilterData", AV55BR_Medication_Drug_UnitTitleFilterData);
      }

      protected void E114W2( )
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
            AV37PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV37PageToGo) ;
         }
      }

      protected void E124W2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E134W2( )
      {
         /* Ddo_br_medication_detailid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_detailid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_detailid_Sortedstatus = "ASC";
            ucDdo_br_medication_detailid.SendProperty(context, "", false, Ddo_br_medication_detailid_Internalname, "SortedStatus", Ddo_br_medication_detailid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_detailid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_detailid_Sortedstatus = "DSC";
            ucDdo_br_medication_detailid.SendProperty(context, "", false, Ddo_br_medication_detailid_Internalname, "SortedStatus", Ddo_br_medication_detailid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_detailid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_Medication_DetailID = (long)(NumberUtil.Val( Ddo_br_medication_detailid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Medication_DetailID), 18, 0)));
            AV18TFBR_Medication_DetailID_To = (long)(NumberUtil.Val( Ddo_br_medication_detailid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Medication_DetailID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Medication_DetailID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_DetailIDTitleFilterData", AV16BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_SchemeIDTitleFilterData", AV20BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Medication_Drug_NameTitleFilterData", AV47BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Drug_NumTitleFilterData", AV51BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Drug_UnitTitleFilterData", AV55BR_Medication_Drug_UnitTitleFilterData);
      }

      protected void E144W2( )
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
            AV13OrderedBy = 2;
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
            AV13OrderedBy = 2;
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
            AV21TFBR_Medication_SchemeID = (long)(NumberUtil.Val( Ddo_br_medication_schemeid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_Medication_SchemeID), 18, 0)));
            AV22TFBR_Medication_SchemeID_To = (long)(NumberUtil.Val( Ddo_br_medication_schemeid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_Medication_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_Medication_SchemeID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_DetailIDTitleFilterData", AV16BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_SchemeIDTitleFilterData", AV20BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Medication_Drug_NameTitleFilterData", AV47BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Drug_NumTitleFilterData", AV51BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Drug_UnitTitleFilterData", AV55BR_Medication_Drug_UnitTitleFilterData);
      }

      protected void E154W2( )
      {
         /* Ddo_br_medication_drug_name_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_drug_name_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_drug_name_Sortedstatus = "ASC";
            ucDdo_br_medication_drug_name.SendProperty(context, "", false, Ddo_br_medication_drug_name_Internalname, "SortedStatus", Ddo_br_medication_drug_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_drug_name_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_drug_name_Sortedstatus = "DSC";
            ucDdo_br_medication_drug_name.SendProperty(context, "", false, Ddo_br_medication_drug_name_Internalname, "SortedStatus", Ddo_br_medication_drug_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_drug_name_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV48TFBR_Medication_Drug_Name = Ddo_br_medication_drug_name_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48TFBR_Medication_Drug_Name", AV48TFBR_Medication_Drug_Name);
            AV49TFBR_Medication_Drug_Name_Sel = Ddo_br_medication_drug_name_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49TFBR_Medication_Drug_Name_Sel", AV49TFBR_Medication_Drug_Name_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_DetailIDTitleFilterData", AV16BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_SchemeIDTitleFilterData", AV20BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Medication_Drug_NameTitleFilterData", AV47BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Drug_NumTitleFilterData", AV51BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Drug_UnitTitleFilterData", AV55BR_Medication_Drug_UnitTitleFilterData);
      }

      protected void E164W2( )
      {
         /* Ddo_br_medication_drug_num_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_drug_num_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_drug_num_Sortedstatus = "ASC";
            ucDdo_br_medication_drug_num.SendProperty(context, "", false, Ddo_br_medication_drug_num_Internalname, "SortedStatus", Ddo_br_medication_drug_num_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_drug_num_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_drug_num_Sortedstatus = "DSC";
            ucDdo_br_medication_drug_num.SendProperty(context, "", false, Ddo_br_medication_drug_num_Internalname, "SortedStatus", Ddo_br_medication_drug_num_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_drug_num_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV52TFBR_Medication_Drug_Num = NumberUtil.Val( Ddo_br_medication_drug_num_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Medication_Drug_Num", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Medication_Drug_Num, 15, 5)));
            AV53TFBR_Medication_Drug_Num_To = NumberUtil.Val( Ddo_br_medication_drug_num_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53TFBR_Medication_Drug_Num_To", StringUtil.LTrim( StringUtil.Str( AV53TFBR_Medication_Drug_Num_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_DetailIDTitleFilterData", AV16BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_SchemeIDTitleFilterData", AV20BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Medication_Drug_NameTitleFilterData", AV47BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Drug_NumTitleFilterData", AV51BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Drug_UnitTitleFilterData", AV55BR_Medication_Drug_UnitTitleFilterData);
      }

      protected void E174W2( )
      {
         /* Ddo_br_medication_drug_unit_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_drug_unit_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medication_drug_unit_Sortedstatus = "ASC";
            ucDdo_br_medication_drug_unit.SendProperty(context, "", false, Ddo_br_medication_drug_unit_Internalname, "SortedStatus", Ddo_br_medication_drug_unit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_drug_unit_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medication_drug_unit_Sortedstatus = "DSC";
            ucDdo_br_medication_drug_unit.SendProperty(context, "", false, Ddo_br_medication_drug_unit_Internalname, "SortedStatus", Ddo_br_medication_drug_unit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_drug_unit_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV56TFBR_Medication_Drug_Unit = Ddo_br_medication_drug_unit_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Medication_Drug_Unit", AV56TFBR_Medication_Drug_Unit);
            AV57TFBR_Medication_Drug_Unit_Sel = Ddo_br_medication_drug_unit_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFBR_Medication_Drug_Unit_Sel", AV57TFBR_Medication_Drug_Unit_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Medication_DetailIDTitleFilterData", AV16BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_SchemeIDTitleFilterData", AV20BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Medication_Drug_NameTitleFilterData", AV47BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV51BR_Medication_Drug_NumTitleFilterData", AV51BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55BR_Medication_Drug_UnitTitleFilterData", AV55BR_Medication_Drug_UnitTitleFilterData);
      }

      private void E214W2( )
      {
         /* Grid_Load Routine */
         AV41Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV41Display);
         AV71Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_medication_detailview.aspx") + "?" + UrlEncode("" +A301BR_Medication_DetailID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV42Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV42Update);
         AV72Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV43IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_medication_detail.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A301BR_Medication_DetailID);
         }
         AV44Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV44Delete);
         AV73Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV45IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_medication_detail.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A301BR_Medication_DetailID);
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

      protected void E184W2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_medication_detail.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_medication_detailid_Sortedstatus = "";
         ucDdo_br_medication_detailid.SendProperty(context, "", false, Ddo_br_medication_detailid_Internalname, "SortedStatus", Ddo_br_medication_detailid_Sortedstatus);
         Ddo_br_medication_schemeid_Sortedstatus = "";
         ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "SortedStatus", Ddo_br_medication_schemeid_Sortedstatus);
         Ddo_br_medication_drug_name_Sortedstatus = "";
         ucDdo_br_medication_drug_name.SendProperty(context, "", false, Ddo_br_medication_drug_name_Internalname, "SortedStatus", Ddo_br_medication_drug_name_Sortedstatus);
         Ddo_br_medication_drug_num_Sortedstatus = "";
         ucDdo_br_medication_drug_num.SendProperty(context, "", false, Ddo_br_medication_drug_num_Internalname, "SortedStatus", Ddo_br_medication_drug_num_Sortedstatus);
         Ddo_br_medication_drug_unit_Sortedstatus = "";
         ucDdo_br_medication_drug_unit.SendProperty(context, "", false, Ddo_br_medication_drug_unit_Internalname, "SortedStatus", Ddo_br_medication_drug_unit_Sortedstatus);
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
            Ddo_br_medication_detailid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_detailid.SendProperty(context, "", false, Ddo_br_medication_detailid_Internalname, "SortedStatus", Ddo_br_medication_detailid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_medication_schemeid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "SortedStatus", Ddo_br_medication_schemeid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_medication_drug_name_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_drug_name.SendProperty(context, "", false, Ddo_br_medication_drug_name_Internalname, "SortedStatus", Ddo_br_medication_drug_name_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_medication_drug_num_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_drug_num.SendProperty(context, "", false, Ddo_br_medication_drug_num_Internalname, "SortedStatus", Ddo_br_medication_drug_num_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_medication_drug_unit_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_drug_unit.SendProperty(context, "", false, Ddo_br_medication_drug_unit_Internalname, "SortedStatus", Ddo_br_medication_drug_unit_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV43IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail_Update", out  GXt_boolean2) ;
         AV43IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43IsAuthorized_Update", AV43IsAuthorized_Update);
         if ( ! ( AV43IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV45IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail_Delete", out  GXt_boolean2) ;
         AV45IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45IsAuthorized_Delete", AV45IsAuthorized_Delete);
         if ( ! ( AV45IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV46TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail_Insert", out  GXt_boolean2) ;
         AV46TempBoolean = GXt_boolean2;
         if ( ! ( AV46TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV74Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV74Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV74Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV75GXV1 = 1;
         while ( AV75GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV75GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DETAILID") == 0 )
            {
               AV17TFBR_Medication_DetailID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Medication_DetailID), 18, 0)));
               AV18TFBR_Medication_DetailID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Medication_DetailID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Medication_DetailID_To), 18, 0)));
               if ( ! (0==AV17TFBR_Medication_DetailID) )
               {
                  Ddo_br_medication_detailid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_Medication_DetailID), 18, 0);
                  ucDdo_br_medication_detailid.SendProperty(context, "", false, Ddo_br_medication_detailid_Internalname, "FilteredText_set", Ddo_br_medication_detailid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_Medication_DetailID_To) )
               {
                  Ddo_br_medication_detailid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_Medication_DetailID_To), 18, 0);
                  ucDdo_br_medication_detailid.SendProperty(context, "", false, Ddo_br_medication_detailid_Internalname, "FilteredTextTo_set", Ddo_br_medication_detailid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_SCHEMEID") == 0 )
            {
               AV21TFBR_Medication_SchemeID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_Medication_SchemeID), 18, 0)));
               AV22TFBR_Medication_SchemeID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_Medication_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_Medication_SchemeID_To), 18, 0)));
               if ( ! (0==AV21TFBR_Medication_SchemeID) )
               {
                  Ddo_br_medication_schemeid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_Medication_SchemeID), 18, 0);
                  ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "FilteredText_set", Ddo_br_medication_schemeid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_Medication_SchemeID_To) )
               {
                  Ddo_br_medication_schemeid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_Medication_SchemeID_To), 18, 0);
                  ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "FilteredTextTo_set", Ddo_br_medication_schemeid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DRUG_NAME") == 0 )
            {
               AV48TFBR_Medication_Drug_Name = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48TFBR_Medication_Drug_Name", AV48TFBR_Medication_Drug_Name);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48TFBR_Medication_Drug_Name)) )
               {
                  Ddo_br_medication_drug_name_Filteredtext_set = AV48TFBR_Medication_Drug_Name;
                  ucDdo_br_medication_drug_name.SendProperty(context, "", false, Ddo_br_medication_drug_name_Internalname, "FilteredText_set", Ddo_br_medication_drug_name_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DRUG_NAME_SEL") == 0 )
            {
               AV49TFBR_Medication_Drug_Name_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49TFBR_Medication_Drug_Name_Sel", AV49TFBR_Medication_Drug_Name_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49TFBR_Medication_Drug_Name_Sel)) )
               {
                  Ddo_br_medication_drug_name_Selectedvalue_set = AV49TFBR_Medication_Drug_Name_Sel;
                  ucDdo_br_medication_drug_name.SendProperty(context, "", false, Ddo_br_medication_drug_name_Internalname, "SelectedValue_set", Ddo_br_medication_drug_name_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DRUG_NUM") == 0 )
            {
               AV52TFBR_Medication_Drug_Num = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Medication_Drug_Num", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Medication_Drug_Num, 15, 5)));
               AV53TFBR_Medication_Drug_Num_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53TFBR_Medication_Drug_Num_To", StringUtil.LTrim( StringUtil.Str( AV53TFBR_Medication_Drug_Num_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV52TFBR_Medication_Drug_Num) )
               {
                  Ddo_br_medication_drug_num_Filteredtext_set = StringUtil.Str( AV52TFBR_Medication_Drug_Num, 15, 5);
                  ucDdo_br_medication_drug_num.SendProperty(context, "", false, Ddo_br_medication_drug_num_Internalname, "FilteredText_set", Ddo_br_medication_drug_num_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV53TFBR_Medication_Drug_Num_To) )
               {
                  Ddo_br_medication_drug_num_Filteredtextto_set = StringUtil.Str( AV53TFBR_Medication_Drug_Num_To, 15, 5);
                  ucDdo_br_medication_drug_num.SendProperty(context, "", false, Ddo_br_medication_drug_num_Internalname, "FilteredTextTo_set", Ddo_br_medication_drug_num_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DRUG_UNIT") == 0 )
            {
               AV56TFBR_Medication_Drug_Unit = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Medication_Drug_Unit", AV56TFBR_Medication_Drug_Unit);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56TFBR_Medication_Drug_Unit)) )
               {
                  Ddo_br_medication_drug_unit_Filteredtext_set = AV56TFBR_Medication_Drug_Unit;
                  ucDdo_br_medication_drug_unit.SendProperty(context, "", false, Ddo_br_medication_drug_unit_Internalname, "FilteredText_set", Ddo_br_medication_drug_unit_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DRUG_UNIT_SEL") == 0 )
            {
               AV57TFBR_Medication_Drug_Unit_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFBR_Medication_Drug_Unit_Sel", AV57TFBR_Medication_Drug_Unit_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57TFBR_Medication_Drug_Unit_Sel)) )
               {
                  Ddo_br_medication_drug_unit_Selectedvalue_set = AV57TFBR_Medication_Drug_Unit_Sel;
                  ucDdo_br_medication_drug_unit.SendProperty(context, "", false, Ddo_br_medication_drug_unit_Internalname, "SelectedValue_set", Ddo_br_medication_drug_unit_Selectedvalue_set);
               }
            }
            AV75GXV1 = (int)(AV75GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV74Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_Medication_DetailID) && (0==AV18TFBR_Medication_DetailID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_DETAILID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_Medication_DetailID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_Medication_DetailID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_Medication_SchemeID) && (0==AV22TFBR_Medication_SchemeID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_SCHEMEID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_Medication_SchemeID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_Medication_SchemeID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48TFBR_Medication_Drug_Name)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_DRUG_NAME";
            AV12GridStateFilterValue.gxTpr_Value = AV48TFBR_Medication_Drug_Name;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49TFBR_Medication_Drug_Name_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_DRUG_NAME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV49TFBR_Medication_Drug_Name_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV52TFBR_Medication_Drug_Num) && (Convert.ToDecimal(0)==AV53TFBR_Medication_Drug_Num_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_DRUG_NUM";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV52TFBR_Medication_Drug_Num, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV53TFBR_Medication_Drug_Num_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56TFBR_Medication_Drug_Unit)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_DRUG_UNIT";
            AV12GridStateFilterValue.gxTpr_Value = AV56TFBR_Medication_Drug_Unit;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57TFBR_Medication_Drug_Unit_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_DRUG_UNIT_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV57TFBR_Medication_Drug_Unit_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV74Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV74Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Medication_Detail";
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
         PA4W2( ) ;
         WS4W2( ) ;
         WE4W2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271221343", true);
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
         context.AddJavascriptSource("br_medication_detailww.js", "?20202271221343", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_idx;
         edtBR_Medication_DetailID_Internalname = "BR_MEDICATION_DETAILID_"+sGXsfl_31_idx;
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID_"+sGXsfl_31_idx;
         edtBR_Medication_Drug_Name_Internalname = "BR_MEDICATION_DRUG_NAME_"+sGXsfl_31_idx;
         edtBR_Medication_Drug_Num_Internalname = "BR_MEDICATION_DRUG_NUM_"+sGXsfl_31_idx;
         edtBR_Medication_Drug_Unit_Internalname = "BR_MEDICATION_DRUG_UNIT_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_Medication_DetailID_Internalname = "BR_MEDICATION_DETAILID_"+sGXsfl_31_fel_idx;
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID_"+sGXsfl_31_fel_idx;
         edtBR_Medication_Drug_Name_Internalname = "BR_MEDICATION_DRUG_NAME_"+sGXsfl_31_fel_idx;
         edtBR_Medication_Drug_Num_Internalname = "BR_MEDICATION_DRUG_NUM_"+sGXsfl_31_fel_idx;
         edtBR_Medication_Drug_Unit_Internalname = "BR_MEDICATION_DRUG_UNIT_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB4W0( ) ;
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
            AV41Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV41Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV71Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV41Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV41Display)) ? AV71Display_GXI : context.PathToRelativeUrl( AV41Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV41Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV42Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV42Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV72Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV42Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV42Update)) ? AV72Update_GXI : context.PathToRelativeUrl( AV42Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV42Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV44Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV44Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV73Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV44Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV44Delete)) ? AV73Delete_GXI : context.PathToRelativeUrl( AV44Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV44Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_DetailID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A301BR_Medication_DetailID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_DetailID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Drug_Name_Internalname,(String)A310BR_Medication_Drug_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Drug_Name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Drug_Num_Internalname,StringUtil.LTrim( StringUtil.NToC( A311BR_Medication_Drug_Num, 15, 5, ".", "")),context.localUtil.Format( A311BR_Medication_Drug_Num, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Drug_Num_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Drug_Unit_Internalname,(String)A312BR_Medication_Drug_Unit,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Drug_Unit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes4W2( ) ;
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
         edtavTfbr_medication_detailid_Internalname = "vTFBR_MEDICATION_DETAILID";
         edtavTfbr_medication_detailid_to_Internalname = "vTFBR_MEDICATION_DETAILID_TO";
         edtavTfbr_medication_schemeid_Internalname = "vTFBR_MEDICATION_SCHEMEID";
         edtavTfbr_medication_schemeid_to_Internalname = "vTFBR_MEDICATION_SCHEMEID_TO";
         edtavTfbr_medication_drug_name_Internalname = "vTFBR_MEDICATION_DRUG_NAME";
         edtavTfbr_medication_drug_name_sel_Internalname = "vTFBR_MEDICATION_DRUG_NAME_SEL";
         edtavTfbr_medication_drug_num_Internalname = "vTFBR_MEDICATION_DRUG_NUM";
         edtavTfbr_medication_drug_num_to_Internalname = "vTFBR_MEDICATION_DRUG_NUM_TO";
         edtavTfbr_medication_drug_unit_Internalname = "vTFBR_MEDICATION_DRUG_UNIT";
         edtavTfbr_medication_drug_unit_sel_Internalname = "vTFBR_MEDICATION_DRUG_UNIT_SEL";
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
         edtavTfbr_medication_drug_unit_sel_Jsonclick = "";
         edtavTfbr_medication_drug_unit_sel_Visible = 1;
         edtavTfbr_medication_drug_unit_Jsonclick = "";
         edtavTfbr_medication_drug_unit_Visible = 1;
         edtavTfbr_medication_drug_num_to_Jsonclick = "";
         edtavTfbr_medication_drug_num_to_Visible = 1;
         edtavTfbr_medication_drug_num_Jsonclick = "";
         edtavTfbr_medication_drug_num_Visible = 1;
         edtavTfbr_medication_drug_name_sel_Jsonclick = "";
         edtavTfbr_medication_drug_name_sel_Visible = 1;
         edtavTfbr_medication_drug_name_Jsonclick = "";
         edtavTfbr_medication_drug_name_Visible = 1;
         edtavTfbr_medication_schemeid_to_Jsonclick = "";
         edtavTfbr_medication_schemeid_to_Visible = 1;
         edtavTfbr_medication_schemeid_Jsonclick = "";
         edtavTfbr_medication_schemeid_Visible = 1;
         edtavTfbr_medication_detailid_to_Jsonclick = "";
         edtavTfbr_medication_detailid_to_Visible = 1;
         edtavTfbr_medication_detailid_Jsonclick = "";
         edtavTfbr_medication_detailid_Visible = 1;
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
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
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
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_medication_drug_unit_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_drug_unit_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_drug_unit_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_drug_unit_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_drug_unit_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_drug_unit_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_drug_unit_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_drug_unit_Datalistproc = "BR_Medication_DetailWWGetFilterData";
         Ddo_br_medication_drug_unit_Datalisttype = "Dynamic";
         Ddo_br_medication_drug_unit_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_unit_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medication_drug_unit_Filtertype = "Character";
         Ddo_br_medication_drug_unit_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_unit_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_unit_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_unit_Titlecontrolidtoreplace = "";
         Ddo_br_medication_drug_unit_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_drug_unit_Cls = "ColumnSettings";
         Ddo_br_medication_drug_unit_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_drug_unit_Caption = "";
         Ddo_br_medication_drug_num_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_drug_num_Rangefilterto = "WWP_TSTo";
         Ddo_br_medication_drug_num_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medication_drug_num_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_drug_num_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_drug_num_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_drug_num_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_drug_num_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_num_Filtertype = "Numeric";
         Ddo_br_medication_drug_num_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_num_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_num_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_num_Titlecontrolidtoreplace = "";
         Ddo_br_medication_drug_num_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_drug_num_Cls = "ColumnSettings";
         Ddo_br_medication_drug_num_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_drug_num_Caption = "";
         Ddo_br_medication_drug_name_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_drug_name_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_drug_name_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_drug_name_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_drug_name_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_drug_name_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_drug_name_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_drug_name_Datalistproc = "BR_Medication_DetailWWGetFilterData";
         Ddo_br_medication_drug_name_Datalisttype = "Dynamic";
         Ddo_br_medication_drug_name_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_name_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medication_drug_name_Filtertype = "Character";
         Ddo_br_medication_drug_name_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_name_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_name_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_name_Titlecontrolidtoreplace = "";
         Ddo_br_medication_drug_name_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_drug_name_Cls = "ColumnSettings";
         Ddo_br_medication_drug_name_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_drug_name_Caption = "";
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
         Ddo_br_medication_detailid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_detailid_Rangefilterto = "WWP_TSTo";
         Ddo_br_medication_detailid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medication_detailid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_detailid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_detailid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_detailid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_detailid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medication_detailid_Filtertype = "Numeric";
         Ddo_br_medication_detailid_Includefilter = Convert.ToBoolean( -1);
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
         Form.Caption = " 药物治疗药物详情";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E114W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E124W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICATION_DETAILID.ONOPTIONCLICKED","{handler:'E134W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medication_detailid_Activeeventkey',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'ActiveEventKey'},{av:'Ddo_br_medication_detailid_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'FilteredText_get'},{av:'Ddo_br_medication_detailid_Filteredtextto_get',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_DETAILID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_detailid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_num_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_unit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED","{handler:'E144W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medication_schemeid_Activeeventkey',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'ActiveEventKey'},{av:'Ddo_br_medication_schemeid_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredText_get'},{av:'Ddo_br_medication_schemeid_Filteredtextto_get',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_medication_detailid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_num_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_unit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED","{handler:'E154W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medication_drug_name_Activeeventkey',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'ActiveEventKey'},{av:'Ddo_br_medication_drug_name_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'FilteredText_get'},{av:'Ddo_br_medication_drug_name_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_drug_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'Ddo_br_medication_detailid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_num_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_unit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED","{handler:'E164W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medication_drug_num_Activeeventkey',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'ActiveEventKey'},{av:'Ddo_br_medication_drug_num_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'FilteredText_get'},{av:'Ddo_br_medication_drug_num_Filteredtextto_get',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_drug_num_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_medication_detailid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_unit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED","{handler:'E174W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Medication_DetailID',fld:'vTFBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Medication_DetailID_To',fld:'vTFBR_MEDICATION_DETAILID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_Medication_SchemeID',fld:'vTFBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Medication_SchemeID_To',fld:'vTFBR_MEDICATION_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV48TFBR_Medication_Drug_Name',fld:'vTFBR_MEDICATION_DRUG_NAME',pic:''},{av:'AV49TFBR_Medication_Drug_Name_Sel',fld:'vTFBR_MEDICATION_DRUG_NAME_SEL',pic:''},{av:'AV52TFBR_Medication_Drug_Num',fld:'vTFBR_MEDICATION_DRUG_NUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV53TFBR_Medication_Drug_Num_To',fld:'vTFBR_MEDICATION_DRUG_NUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_medication_drug_unit_Activeeventkey',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'ActiveEventKey'},{av:'Ddo_br_medication_drug_unit_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'FilteredText_get'},{av:'Ddo_br_medication_drug_unit_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_drug_unit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV56TFBR_Medication_Drug_Unit',fld:'vTFBR_MEDICATION_DRUG_UNIT',pic:''},{av:'AV57TFBR_Medication_Drug_Unit_Sel',fld:'vTFBR_MEDICATION_DRUG_UNIT_SEL',pic:''},{av:'Ddo_br_medication_detailid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'Ddo_br_medication_drug_num_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'AV16BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV47BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV51BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV55BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E214W2',iparms:[{av:'A301BR_Medication_DetailID',fld:'BR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV41Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV42Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV44Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E184W2',iparms:[{av:'A301BR_Medication_DetailID',fld:'BR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_medication_detailid_Activeeventkey = "";
         Ddo_br_medication_detailid_Filteredtext_get = "";
         Ddo_br_medication_detailid_Filteredtextto_get = "";
         Ddo_br_medication_schemeid_Activeeventkey = "";
         Ddo_br_medication_schemeid_Filteredtext_get = "";
         Ddo_br_medication_schemeid_Filteredtextto_get = "";
         Ddo_br_medication_drug_name_Activeeventkey = "";
         Ddo_br_medication_drug_name_Filteredtext_get = "";
         Ddo_br_medication_drug_name_Selectedvalue_get = "";
         Ddo_br_medication_drug_num_Activeeventkey = "";
         Ddo_br_medication_drug_num_Filteredtext_get = "";
         Ddo_br_medication_drug_num_Filteredtextto_get = "";
         Ddo_br_medication_drug_unit_Activeeventkey = "";
         Ddo_br_medication_drug_unit_Filteredtext_get = "";
         Ddo_br_medication_drug_unit_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV48TFBR_Medication_Drug_Name = "";
         AV49TFBR_Medication_Drug_Name_Sel = "";
         AV56TFBR_Medication_Drug_Unit = "";
         AV57TFBR_Medication_Drug_Unit_Sel = "";
         AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace = "";
         AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "";
         AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace = "";
         AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace = "";
         AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = "";
         AV74Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV36DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_Medication_DetailIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Medication_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV47BR_Medication_Drug_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV51BR_Medication_Drug_NumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV55BR_Medication_Drug_UnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medication_detailid_Filteredtext_set = "";
         Ddo_br_medication_detailid_Filteredtextto_set = "";
         Ddo_br_medication_detailid_Sortedstatus = "";
         Ddo_br_medication_schemeid_Filteredtext_set = "";
         Ddo_br_medication_schemeid_Filteredtextto_set = "";
         Ddo_br_medication_schemeid_Sortedstatus = "";
         Ddo_br_medication_drug_name_Filteredtext_set = "";
         Ddo_br_medication_drug_name_Selectedvalue_set = "";
         Ddo_br_medication_drug_name_Sortedstatus = "";
         Ddo_br_medication_drug_num_Filteredtext_set = "";
         Ddo_br_medication_drug_num_Filteredtextto_set = "";
         Ddo_br_medication_drug_num_Sortedstatus = "";
         Ddo_br_medication_drug_unit_Filteredtext_set = "";
         Ddo_br_medication_drug_unit_Selectedvalue_set = "";
         Ddo_br_medication_drug_unit_Sortedstatus = "";
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
         AV41Display = "";
         AV42Update = "";
         AV44Delete = "";
         A310BR_Medication_Drug_Name = "";
         A312BR_Medication_Drug_Unit = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medication_detailid = new GXUserControl();
         ucDdo_br_medication_schemeid = new GXUserControl();
         ucDdo_br_medication_drug_name = new GXUserControl();
         ucDdo_br_medication_drug_num = new GXUserControl();
         ucDdo_br_medication_drug_unit = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV71Display_GXI = "";
         AV72Update_GXI = "";
         AV73Delete_GXI = "";
         scmdbuf = "";
         lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = "";
         lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = "";
         AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = "";
         AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = "";
         AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = "";
         AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = "";
         H004W2_A312BR_Medication_Drug_Unit = new String[] {""} ;
         H004W2_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         H004W2_A311BR_Medication_Drug_Num = new decimal[1] ;
         H004W2_n311BR_Medication_Drug_Num = new bool[] {false} ;
         H004W2_A310BR_Medication_Drug_Name = new String[] {""} ;
         H004W2_n310BR_Medication_Drug_Name = new bool[] {false} ;
         H004W2_A296BR_Medication_SchemeID = new long[1] ;
         H004W2_n296BR_Medication_SchemeID = new bool[] {false} ;
         H004W2_A301BR_Medication_DetailID = new long[1] ;
         H004W3_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_detailww__default(),
            new Object[][] {
                new Object[] {
               H004W2_A312BR_Medication_Drug_Unit, H004W2_n312BR_Medication_Drug_Unit, H004W2_A311BR_Medication_Drug_Num, H004W2_n311BR_Medication_Drug_Num, H004W2_A310BR_Medication_Drug_Name, H004W2_n310BR_Medication_Drug_Name, H004W2_A296BR_Medication_SchemeID, H004W2_n296BR_Medication_SchemeID, H004W2_A301BR_Medication_DetailID
               }
               , new Object[] {
               H004W3_AGRID_nRecordCount
               }
            }
         );
         AV74Pgmname = "BR_Medication_DetailWW";
         /* GeneXus formulas. */
         AV74Pgmname = "BR_Medication_DetailWW";
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
      private int Ddo_br_medication_drug_name_Datalistupdateminimumcharacters ;
      private int Ddo_br_medication_drug_unit_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
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
      private int edtavTfbr_medication_detailid_Visible ;
      private int edtavTfbr_medication_detailid_to_Visible ;
      private int edtavTfbr_medication_schemeid_Visible ;
      private int edtavTfbr_medication_schemeid_to_Visible ;
      private int edtavTfbr_medication_drug_name_Visible ;
      private int edtavTfbr_medication_drug_name_sel_Visible ;
      private int edtavTfbr_medication_drug_num_Visible ;
      private int edtavTfbr_medication_drug_num_to_Visible ;
      private int edtavTfbr_medication_drug_unit_Visible ;
      private int edtavTfbr_medication_drug_unit_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV37PageToGo ;
      private int AV75GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_Medication_DetailID ;
      private long AV18TFBR_Medication_DetailID_To ;
      private long AV21TFBR_Medication_SchemeID ;
      private long AV22TFBR_Medication_SchemeID_To ;
      private long AV38GridCurrentPage ;
      private long AV40GridRecordCount ;
      private long AV39GridPageSize ;
      private long A301BR_Medication_DetailID ;
      private long A296BR_Medication_SchemeID ;
      private long GRID_nCurrentRecord ;
      private long AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid ;
      private long AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to ;
      private long AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid ;
      private long AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to ;
      private long GRID_nRecordCount ;
      private decimal AV52TFBR_Medication_Drug_Num ;
      private decimal AV53TFBR_Medication_Drug_Num_To ;
      private decimal A311BR_Medication_Drug_Num ;
      private decimal AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num ;
      private decimal AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medication_detailid_Activeeventkey ;
      private String Ddo_br_medication_detailid_Filteredtext_get ;
      private String Ddo_br_medication_detailid_Filteredtextto_get ;
      private String Ddo_br_medication_schemeid_Activeeventkey ;
      private String Ddo_br_medication_schemeid_Filteredtext_get ;
      private String Ddo_br_medication_schemeid_Filteredtextto_get ;
      private String Ddo_br_medication_drug_name_Activeeventkey ;
      private String Ddo_br_medication_drug_name_Filteredtext_get ;
      private String Ddo_br_medication_drug_name_Selectedvalue_get ;
      private String Ddo_br_medication_drug_num_Activeeventkey ;
      private String Ddo_br_medication_drug_num_Filteredtext_get ;
      private String Ddo_br_medication_drug_num_Filteredtextto_get ;
      private String Ddo_br_medication_drug_unit_Activeeventkey ;
      private String Ddo_br_medication_drug_unit_Filteredtext_get ;
      private String Ddo_br_medication_drug_unit_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV74Pgmname ;
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
      private String Ddo_br_medication_detailid_Caption ;
      private String Ddo_br_medication_detailid_Tooltip ;
      private String Ddo_br_medication_detailid_Cls ;
      private String Ddo_br_medication_detailid_Filteredtext_set ;
      private String Ddo_br_medication_detailid_Filteredtextto_set ;
      private String Ddo_br_medication_detailid_Dropdownoptionstype ;
      private String Ddo_br_medication_detailid_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_detailid_Sortedstatus ;
      private String Ddo_br_medication_detailid_Filtertype ;
      private String Ddo_br_medication_detailid_Sortasc ;
      private String Ddo_br_medication_detailid_Sortdsc ;
      private String Ddo_br_medication_detailid_Cleanfilter ;
      private String Ddo_br_medication_detailid_Rangefilterfrom ;
      private String Ddo_br_medication_detailid_Rangefilterto ;
      private String Ddo_br_medication_detailid_Searchbuttontext ;
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
      private String Ddo_br_medication_drug_name_Caption ;
      private String Ddo_br_medication_drug_name_Tooltip ;
      private String Ddo_br_medication_drug_name_Cls ;
      private String Ddo_br_medication_drug_name_Filteredtext_set ;
      private String Ddo_br_medication_drug_name_Selectedvalue_set ;
      private String Ddo_br_medication_drug_name_Dropdownoptionstype ;
      private String Ddo_br_medication_drug_name_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_drug_name_Sortedstatus ;
      private String Ddo_br_medication_drug_name_Filtertype ;
      private String Ddo_br_medication_drug_name_Datalisttype ;
      private String Ddo_br_medication_drug_name_Datalistproc ;
      private String Ddo_br_medication_drug_name_Sortasc ;
      private String Ddo_br_medication_drug_name_Sortdsc ;
      private String Ddo_br_medication_drug_name_Loadingdata ;
      private String Ddo_br_medication_drug_name_Cleanfilter ;
      private String Ddo_br_medication_drug_name_Noresultsfound ;
      private String Ddo_br_medication_drug_name_Searchbuttontext ;
      private String Ddo_br_medication_drug_num_Caption ;
      private String Ddo_br_medication_drug_num_Tooltip ;
      private String Ddo_br_medication_drug_num_Cls ;
      private String Ddo_br_medication_drug_num_Filteredtext_set ;
      private String Ddo_br_medication_drug_num_Filteredtextto_set ;
      private String Ddo_br_medication_drug_num_Dropdownoptionstype ;
      private String Ddo_br_medication_drug_num_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_drug_num_Sortedstatus ;
      private String Ddo_br_medication_drug_num_Filtertype ;
      private String Ddo_br_medication_drug_num_Sortasc ;
      private String Ddo_br_medication_drug_num_Sortdsc ;
      private String Ddo_br_medication_drug_num_Cleanfilter ;
      private String Ddo_br_medication_drug_num_Rangefilterfrom ;
      private String Ddo_br_medication_drug_num_Rangefilterto ;
      private String Ddo_br_medication_drug_num_Searchbuttontext ;
      private String Ddo_br_medication_drug_unit_Caption ;
      private String Ddo_br_medication_drug_unit_Tooltip ;
      private String Ddo_br_medication_drug_unit_Cls ;
      private String Ddo_br_medication_drug_unit_Filteredtext_set ;
      private String Ddo_br_medication_drug_unit_Selectedvalue_set ;
      private String Ddo_br_medication_drug_unit_Dropdownoptionstype ;
      private String Ddo_br_medication_drug_unit_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_drug_unit_Sortedstatus ;
      private String Ddo_br_medication_drug_unit_Filtertype ;
      private String Ddo_br_medication_drug_unit_Datalisttype ;
      private String Ddo_br_medication_drug_unit_Datalistproc ;
      private String Ddo_br_medication_drug_unit_Sortasc ;
      private String Ddo_br_medication_drug_unit_Sortdsc ;
      private String Ddo_br_medication_drug_unit_Loadingdata ;
      private String Ddo_br_medication_drug_unit_Cleanfilter ;
      private String Ddo_br_medication_drug_unit_Noresultsfound ;
      private String Ddo_br_medication_drug_unit_Searchbuttontext ;
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
      private String edtBR_Medication_DetailID_Title ;
      private String edtBR_Medication_SchemeID_Title ;
      private String edtBR_Medication_Drug_Name_Title ;
      private String edtBR_Medication_Drug_Num_Title ;
      private String edtBR_Medication_Drug_Unit_Title ;
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
      private String Ddo_br_medication_detailid_Internalname ;
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
      private String edtavTfbr_medication_detailid_Internalname ;
      private String edtavTfbr_medication_detailid_Jsonclick ;
      private String edtavTfbr_medication_detailid_to_Internalname ;
      private String edtavTfbr_medication_detailid_to_Jsonclick ;
      private String edtavTfbr_medication_schemeid_Internalname ;
      private String edtavTfbr_medication_schemeid_Jsonclick ;
      private String edtavTfbr_medication_schemeid_to_Internalname ;
      private String edtavTfbr_medication_schemeid_to_Jsonclick ;
      private String edtavTfbr_medication_drug_name_Internalname ;
      private String edtavTfbr_medication_drug_name_Jsonclick ;
      private String edtavTfbr_medication_drug_name_sel_Internalname ;
      private String edtavTfbr_medication_drug_name_sel_Jsonclick ;
      private String edtavTfbr_medication_drug_num_Internalname ;
      private String edtavTfbr_medication_drug_num_Jsonclick ;
      private String edtavTfbr_medication_drug_num_to_Internalname ;
      private String edtavTfbr_medication_drug_num_to_Jsonclick ;
      private String edtavTfbr_medication_drug_unit_Internalname ;
      private String edtavTfbr_medication_drug_unit_Jsonclick ;
      private String edtavTfbr_medication_drug_unit_sel_Internalname ;
      private String edtavTfbr_medication_drug_unit_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_Medication_DetailID_Internalname ;
      private String edtBR_Medication_SchemeID_Internalname ;
      private String edtBR_Medication_Drug_Name_Internalname ;
      private String edtBR_Medication_Drug_Num_Internalname ;
      private String edtBR_Medication_Drug_Unit_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_Medication_DetailID_Jsonclick ;
      private String edtBR_Medication_SchemeID_Jsonclick ;
      private String edtBR_Medication_Drug_Name_Jsonclick ;
      private String edtBR_Medication_Drug_Num_Jsonclick ;
      private String edtBR_Medication_Drug_Unit_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV43IsAuthorized_Update ;
      private bool AV45IsAuthorized_Delete ;
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
      private bool Ddo_br_medication_detailid_Includesortasc ;
      private bool Ddo_br_medication_detailid_Includesortdsc ;
      private bool Ddo_br_medication_detailid_Includefilter ;
      private bool Ddo_br_medication_detailid_Filterisrange ;
      private bool Ddo_br_medication_detailid_Includedatalist ;
      private bool Ddo_br_medication_schemeid_Includesortasc ;
      private bool Ddo_br_medication_schemeid_Includesortdsc ;
      private bool Ddo_br_medication_schemeid_Includefilter ;
      private bool Ddo_br_medication_schemeid_Filterisrange ;
      private bool Ddo_br_medication_schemeid_Includedatalist ;
      private bool Ddo_br_medication_drug_name_Includesortasc ;
      private bool Ddo_br_medication_drug_name_Includesortdsc ;
      private bool Ddo_br_medication_drug_name_Includefilter ;
      private bool Ddo_br_medication_drug_name_Filterisrange ;
      private bool Ddo_br_medication_drug_name_Includedatalist ;
      private bool Ddo_br_medication_drug_num_Includesortasc ;
      private bool Ddo_br_medication_drug_num_Includesortdsc ;
      private bool Ddo_br_medication_drug_num_Includefilter ;
      private bool Ddo_br_medication_drug_num_Filterisrange ;
      private bool Ddo_br_medication_drug_num_Includedatalist ;
      private bool Ddo_br_medication_drug_unit_Includesortasc ;
      private bool Ddo_br_medication_drug_unit_Includesortdsc ;
      private bool Ddo_br_medication_drug_unit_Includefilter ;
      private bool Ddo_br_medication_drug_unit_Filterisrange ;
      private bool Ddo_br_medication_drug_unit_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n296BR_Medication_SchemeID ;
      private bool n310BR_Medication_Drug_Name ;
      private bool n311BR_Medication_Drug_Num ;
      private bool n312BR_Medication_Drug_Unit ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV46TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV41Display_IsBlob ;
      private bool AV42Update_IsBlob ;
      private bool AV44Delete_IsBlob ;
      private String AV48TFBR_Medication_Drug_Name ;
      private String AV49TFBR_Medication_Drug_Name_Sel ;
      private String AV56TFBR_Medication_Drug_Unit ;
      private String AV57TFBR_Medication_Drug_Unit_Sel ;
      private String AV19ddo_BR_Medication_DetailIDTitleControlIdToReplace ;
      private String AV23ddo_BR_Medication_SchemeIDTitleControlIdToReplace ;
      private String AV50ddo_BR_Medication_Drug_NameTitleControlIdToReplace ;
      private String AV54ddo_BR_Medication_Drug_NumTitleControlIdToReplace ;
      private String AV58ddo_BR_Medication_Drug_UnitTitleControlIdToReplace ;
      private String A310BR_Medication_Drug_Name ;
      private String A312BR_Medication_Drug_Unit ;
      private String AV71Display_GXI ;
      private String AV72Update_GXI ;
      private String AV73Delete_GXI ;
      private String lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ;
      private String lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ;
      private String AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel ;
      private String AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ;
      private String AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel ;
      private String AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ;
      private String AV41Display ;
      private String AV42Update ;
      private String AV44Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medication_detailid ;
      private GXUserControl ucDdo_br_medication_schemeid ;
      private GXUserControl ucDdo_br_medication_drug_name ;
      private GXUserControl ucDdo_br_medication_drug_num ;
      private GXUserControl ucDdo_br_medication_drug_unit ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H004W2_A312BR_Medication_Drug_Unit ;
      private bool[] H004W2_n312BR_Medication_Drug_Unit ;
      private decimal[] H004W2_A311BR_Medication_Drug_Num ;
      private bool[] H004W2_n311BR_Medication_Drug_Num ;
      private String[] H004W2_A310BR_Medication_Drug_Name ;
      private bool[] H004W2_n310BR_Medication_Drug_Name ;
      private long[] H004W2_A296BR_Medication_SchemeID ;
      private bool[] H004W2_n296BR_Medication_SchemeID ;
      private long[] H004W2_A301BR_Medication_DetailID ;
      private long[] H004W3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Medication_DetailIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_Medication_SchemeIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV47BR_Medication_Drug_NameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV51BR_Medication_Drug_NumTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV55BR_Medication_Drug_UnitTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV36DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_medication_detailww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H004W2( IGxContext context ,
                                             long AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid ,
                                             long AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to ,
                                             long AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid ,
                                             long AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to ,
                                             String AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel ,
                                             String AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ,
                                             decimal AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num ,
                                             decimal AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to ,
                                             String AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel ,
                                             String AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ,
                                             long A301BR_Medication_DetailID ,
                                             long A296BR_Medication_SchemeID ,
                                             String A310BR_Medication_Drug_Name ,
                                             decimal A311BR_Medication_Drug_Num ,
                                             String A312BR_Medication_Drug_Unit ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [13] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Medication_Drug_Unit], [BR_Medication_Drug_Num], [BR_Medication_Drug_Name], [BR_Medication_SchemeID], [BR_Medication_DetailID]";
         sFromString = " FROM [BR_Medication_Detail] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_DetailID] >= @AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_DetailID] >= @AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_DetailID] <= @AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_DetailID] <= @AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] >= @AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] >= @AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] <= @AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] <= @AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Name] like @lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Name] like @lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Name] = @AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Name] = @AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Num] >= @AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Num] >= @AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Num] <= @AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Num] <= @AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Unit] like @lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Unit] like @lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Unit] = @AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Unit] = @AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_DetailID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_DetailID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_SchemeID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_SchemeID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Name]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Name] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Num]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Num] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Unit]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
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

      protected Object[] conditional_H004W3( IGxContext context ,
                                             long AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid ,
                                             long AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to ,
                                             long AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid ,
                                             long AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to ,
                                             String AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel ,
                                             String AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ,
                                             decimal AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num ,
                                             decimal AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to ,
                                             String AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel ,
                                             String AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ,
                                             long A301BR_Medication_DetailID ,
                                             long A296BR_Medication_SchemeID ,
                                             String A310BR_Medication_Drug_Name ,
                                             decimal A311BR_Medication_Drug_Num ,
                                             String A312BR_Medication_Drug_Unit ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [10] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Medication_Detail] WITH (NOLOCK)";
         if ( ! (0==AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_DetailID] >= @AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_DetailID] >= @AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_DetailID] <= @AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_DetailID] <= @AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] >= @AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] >= @AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] <= @AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] <= @AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Name] like @lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Name] like @lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Name] = @AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Name] = @AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Num] >= @AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Num] >= @AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Num] <= @AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Num] <= @AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Unit] like @lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Unit] like @lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Unit] = @AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Unit] = @AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
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
                     return conditional_H004W2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (decimal)dynConstraints[13] , (String)dynConstraints[14] , (short)dynConstraints[15] , (bool)dynConstraints[16] );
               case 1 :
                     return conditional_H004W3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (decimal)dynConstraints[13] , (String)dynConstraints[14] , (short)dynConstraints[15] , (bool)dynConstraints[16] );
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
          Object[] prmH004W2 ;
          prmH004W2 = new Object[] {
          new Object[] {"@AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH004W3 ;
          prmH004W3 = new Object[] {
          new Object[] {"@AV61BR_Medication_DetailWWDS_1_Tfbr_medication_detailid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV62BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV63BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV64BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV65BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV66BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV67BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV68BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV69BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV70BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004W2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004W2,11,0,true,false )
             ,new CursorDef("H004W3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004W3,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[25]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                return;
       }
    }

 }

}
