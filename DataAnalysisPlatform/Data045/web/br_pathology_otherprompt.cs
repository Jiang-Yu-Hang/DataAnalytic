/*
               File: BR_Pathology_OtherPrompt
        Description: 选择病理学其它信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:14:34.33
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
   public class br_pathology_otherprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathology_otherprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_otherprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_Pathology_OtherID ,
                           ref String aP1_InOutBR_Pathology_Other_Bio )
      {
         this.AV8InOutBR_Pathology_OtherID = aP0_InOutBR_Pathology_OtherID;
         this.AV9InOutBR_Pathology_Other_Bio = aP1_InOutBR_Pathology_Other_Bio;
         executePrivate();
         aP0_InOutBR_Pathology_OtherID=this.AV8InOutBR_Pathology_OtherID;
         aP1_InOutBR_Pathology_Other_Bio=this.AV9InOutBR_Pathology_Other_Bio;
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
               AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_PathologyIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace = GetNextPar( );
               AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = GetNextPar( );
               AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = GetNextPar( );
               AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace = GetNextPar( );
               AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace = GetNextPar( );
               AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace = GetNextPar( );
               AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace) ;
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
               AV8InOutBR_Pathology_OtherID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Pathology_OtherID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutBR_Pathology_Other_Bio = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Pathology_Other_Bio", AV9InOutBR_Pathology_Other_Bio);
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
            PA5Q2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV39Pgmname = "BR_Pathology_OtherPrompt";
               context.Gx_err = 0;
               WS5Q2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE5Q2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815143447", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_otherprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_Pathology_OtherID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutBR_Pathology_Other_Bio))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV35GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV31DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV31DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA", AV13BR_Pathology_OtherIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA", AV13BR_Pathology_OtherIDTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA", AV17BR_Pathology_Other_BioTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA", AV17BR_Pathology_Other_BioTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA", AV19BR_Pathology_Other_BioNumTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA", AV19BR_Pathology_Other_BioNumTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA", AV23BR_Pathology_Other_BioQualTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA", AV23BR_Pathology_Other_BioQualTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA", AV25BR_Pathology_Other_LowTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA", AV25BR_Pathology_Other_LowTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA", AV27BR_Pathology_Other_HighTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA", AV27BR_Pathology_Other_HighTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA", AV29BR_Pathology_Other_AbnIndTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA", AV29BR_Pathology_Other_AbnIndTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PATHOLOGY_OTHERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_Pathology_OtherID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PATHOLOGY_OTHER_BIO", AV9InOutBR_Pathology_Other_Bio);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Caption", StringUtil.RTrim( Ddo_br_pathology_otherid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Tooltip", StringUtil.RTrim( Ddo_br_pathology_otherid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Cls", StringUtil.RTrim( Ddo_br_pathology_otherid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_otherid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_otherid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_otherid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_otherid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_otherid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_otherid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_otherid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Sortasc", StringUtil.RTrim( Ddo_br_pathology_otherid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_otherid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_otherid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bio_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bio_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bio_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bio_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bio_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bio_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bio_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bio_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bio_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bioqual_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bioqual_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bioqual_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bioqual_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Caption", StringUtil.RTrim( Ddo_br_pathology_other_low_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_low_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Cls", StringUtil.RTrim( Ddo_br_pathology_other_low_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_low_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_low_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_low_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_low_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_low_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_low_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_low_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_low_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_low_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_low_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Caption", StringUtil.RTrim( Ddo_br_pathology_other_high_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_high_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Cls", StringUtil.RTrim( Ddo_br_pathology_other_high_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_high_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_high_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_high_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_high_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_high_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_high_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_high_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_high_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_high_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_high_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Caption", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Cls", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_otherid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bio_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_low_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_high_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_otherid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bio_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_low_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_high_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Activeeventkey));
      }

      protected void RenderHtmlCloseForm5Q2( )
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
         return "BR_Pathology_OtherPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择病理学其它信息" ;
      }

      protected void WB5Q0( )
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
               if ( edtBR_Pathology_OtherID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_OtherID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_OtherID_Title) ;
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
               if ( edtBR_Pathology_Other_Bio_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_Bio_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_Bio_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Other_BioNum_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_BioNum_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_BioNum_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Other_BioNumUnit_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_BioNumUnit_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_BioNumUnit_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Other_BioQual_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_BioQual_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_BioQual_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Other_Low_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_Low_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_Low_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Other_High_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_High_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_High_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Other_AbnInd_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_AbnInd_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_AbnInd_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV36Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_OtherID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_OtherID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A289BR_Pathology_Other_Bio);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_Bio_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_Bio_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A290BR_Pathology_Other_BioNum, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_BioNum_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_BioNum_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A291BR_Pathology_Other_BioNumUnit);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_BioNumUnit_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_BioNumUnit_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A292BR_Pathology_Other_BioQual);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_BioQual_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_BioQual_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A293BR_Pathology_Other_Low, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_Low_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_Low_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A294BR_Pathology_Other_High, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_High_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_High_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A295BR_Pathology_Other_AbnInd);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_AbnInd_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_AbnInd_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV33GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV35GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV34GridPageSize);
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
            ucDdo_br_pathology_otherid.SetProperty("Caption", Ddo_br_pathology_otherid_Caption);
            ucDdo_br_pathology_otherid.SetProperty("Tooltip", Ddo_br_pathology_otherid_Tooltip);
            ucDdo_br_pathology_otherid.SetProperty("Cls", Ddo_br_pathology_otherid_Cls);
            ucDdo_br_pathology_otherid.SetProperty("DropDownOptionsType", Ddo_br_pathology_otherid_Dropdownoptionstype);
            ucDdo_br_pathology_otherid.SetProperty("IncludeSortASC", Ddo_br_pathology_otherid_Includesortasc);
            ucDdo_br_pathology_otherid.SetProperty("IncludeSortDSC", Ddo_br_pathology_otherid_Includesortdsc);
            ucDdo_br_pathology_otherid.SetProperty("IncludeFilter", Ddo_br_pathology_otherid_Includefilter);
            ucDdo_br_pathology_otherid.SetProperty("IncludeDataList", Ddo_br_pathology_otherid_Includedatalist);
            ucDdo_br_pathology_otherid.SetProperty("SortASC", Ddo_br_pathology_otherid_Sortasc);
            ucDdo_br_pathology_otherid.SetProperty("SortDSC", Ddo_br_pathology_otherid_Sortdsc);
            ucDdo_br_pathology_otherid.SetProperty("SearchButtonText", Ddo_br_pathology_otherid_Searchbuttontext);
            ucDdo_br_pathology_otherid.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_otherid.SetProperty("DropDownOptionsData", AV13BR_Pathology_OtherIDTitleFilterData);
            ucDdo_br_pathology_otherid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_otherid_Internalname, "DDO_BR_PATHOLOGY_OTHERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Internalname, AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherPrompt.htm");
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
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsData", AV15BR_PathologyIDTitleFilterData);
            ucDdo_br_pathologyid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_Internalname, "DDO_BR_PATHOLOGYIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, AV16ddo_BR_PathologyIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_bio.SetProperty("Caption", Ddo_br_pathology_other_bio_Caption);
            ucDdo_br_pathology_other_bio.SetProperty("Tooltip", Ddo_br_pathology_other_bio_Tooltip);
            ucDdo_br_pathology_other_bio.SetProperty("Cls", Ddo_br_pathology_other_bio_Cls);
            ucDdo_br_pathology_other_bio.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bio_Dropdownoptionstype);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bio_Includesortasc);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bio_Includesortdsc);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeFilter", Ddo_br_pathology_other_bio_Includefilter);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeDataList", Ddo_br_pathology_other_bio_Includedatalist);
            ucDdo_br_pathology_other_bio.SetProperty("SortASC", Ddo_br_pathology_other_bio_Sortasc);
            ucDdo_br_pathology_other_bio.SetProperty("SortDSC", Ddo_br_pathology_other_bio_Sortdsc);
            ucDdo_br_pathology_other_bio.SetProperty("SearchButtonText", Ddo_br_pathology_other_bio_Searchbuttontext);
            ucDdo_br_pathology_other_bio.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bio.SetProperty("DropDownOptionsData", AV17BR_Pathology_Other_BioTitleFilterData);
            ucDdo_br_pathology_other_bio.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bio_Internalname, "DDO_BR_PATHOLOGY_OTHER_BIOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_bionum.SetProperty("Caption", Ddo_br_pathology_other_bionum_Caption);
            ucDdo_br_pathology_other_bionum.SetProperty("Tooltip", Ddo_br_pathology_other_bionum_Tooltip);
            ucDdo_br_pathology_other_bionum.SetProperty("Cls", Ddo_br_pathology_other_bionum_Cls);
            ucDdo_br_pathology_other_bionum.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bionum_Dropdownoptionstype);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bionum_Includesortasc);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bionum_Includesortdsc);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeFilter", Ddo_br_pathology_other_bionum_Includefilter);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeDataList", Ddo_br_pathology_other_bionum_Includedatalist);
            ucDdo_br_pathology_other_bionum.SetProperty("SortASC", Ddo_br_pathology_other_bionum_Sortasc);
            ucDdo_br_pathology_other_bionum.SetProperty("SortDSC", Ddo_br_pathology_other_bionum_Sortdsc);
            ucDdo_br_pathology_other_bionum.SetProperty("SearchButtonText", Ddo_br_pathology_other_bionum_Searchbuttontext);
            ucDdo_br_pathology_other_bionum.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bionum.SetProperty("DropDownOptionsData", AV19BR_Pathology_Other_BioNumTitleFilterData);
            ucDdo_br_pathology_other_bionum.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bionum_Internalname, "DDO_BR_PATHOLOGY_OTHER_BIONUMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", 0, edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_bionumunit.SetProperty("Caption", Ddo_br_pathology_other_bionumunit_Caption);
            ucDdo_br_pathology_other_bionumunit.SetProperty("Tooltip", Ddo_br_pathology_other_bionumunit_Tooltip);
            ucDdo_br_pathology_other_bionumunit.SetProperty("Cls", Ddo_br_pathology_other_bionumunit_Cls);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bionumunit_Dropdownoptionstype);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bionumunit_Includesortasc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bionumunit_Includesortdsc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeFilter", Ddo_br_pathology_other_bionumunit_Includefilter);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeDataList", Ddo_br_pathology_other_bionumunit_Includedatalist);
            ucDdo_br_pathology_other_bionumunit.SetProperty("SortASC", Ddo_br_pathology_other_bionumunit_Sortasc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("SortDSC", Ddo_br_pathology_other_bionumunit_Sortdsc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("SearchButtonText", Ddo_br_pathology_other_bionumunit_Searchbuttontext);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DropDownOptionsData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
            ucDdo_br_pathology_other_bionumunit.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bionumunit_Internalname, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNITContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_bioqual.SetProperty("Caption", Ddo_br_pathology_other_bioqual_Caption);
            ucDdo_br_pathology_other_bioqual.SetProperty("Tooltip", Ddo_br_pathology_other_bioqual_Tooltip);
            ucDdo_br_pathology_other_bioqual.SetProperty("Cls", Ddo_br_pathology_other_bioqual_Cls);
            ucDdo_br_pathology_other_bioqual.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bioqual_Dropdownoptionstype);
            ucDdo_br_pathology_other_bioqual.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bioqual_Includesortasc);
            ucDdo_br_pathology_other_bioqual.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bioqual_Includesortdsc);
            ucDdo_br_pathology_other_bioqual.SetProperty("IncludeFilter", Ddo_br_pathology_other_bioqual_Includefilter);
            ucDdo_br_pathology_other_bioqual.SetProperty("IncludeDataList", Ddo_br_pathology_other_bioqual_Includedatalist);
            ucDdo_br_pathology_other_bioqual.SetProperty("SortASC", Ddo_br_pathology_other_bioqual_Sortasc);
            ucDdo_br_pathology_other_bioqual.SetProperty("SortDSC", Ddo_br_pathology_other_bioqual_Sortdsc);
            ucDdo_br_pathology_other_bioqual.SetProperty("SearchButtonText", Ddo_br_pathology_other_bioqual_Searchbuttontext);
            ucDdo_br_pathology_other_bioqual.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bioqual.SetProperty("DropDownOptionsData", AV23BR_Pathology_Other_BioQualTitleFilterData);
            ucDdo_br_pathology_other_bioqual.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bioqual_Internalname, "DDO_BR_PATHOLOGY_OTHER_BIOQUALContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Internalname, AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", 0, edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_low.SetProperty("Caption", Ddo_br_pathology_other_low_Caption);
            ucDdo_br_pathology_other_low.SetProperty("Tooltip", Ddo_br_pathology_other_low_Tooltip);
            ucDdo_br_pathology_other_low.SetProperty("Cls", Ddo_br_pathology_other_low_Cls);
            ucDdo_br_pathology_other_low.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_low_Dropdownoptionstype);
            ucDdo_br_pathology_other_low.SetProperty("IncludeSortASC", Ddo_br_pathology_other_low_Includesortasc);
            ucDdo_br_pathology_other_low.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_low_Includesortdsc);
            ucDdo_br_pathology_other_low.SetProperty("IncludeFilter", Ddo_br_pathology_other_low_Includefilter);
            ucDdo_br_pathology_other_low.SetProperty("IncludeDataList", Ddo_br_pathology_other_low_Includedatalist);
            ucDdo_br_pathology_other_low.SetProperty("SortASC", Ddo_br_pathology_other_low_Sortasc);
            ucDdo_br_pathology_other_low.SetProperty("SortDSC", Ddo_br_pathology_other_low_Sortdsc);
            ucDdo_br_pathology_other_low.SetProperty("SearchButtonText", Ddo_br_pathology_other_low_Searchbuttontext);
            ucDdo_br_pathology_other_low.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_low.SetProperty("DropDownOptionsData", AV25BR_Pathology_Other_LowTitleFilterData);
            ucDdo_br_pathology_other_low.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_low_Internalname, "DDO_BR_PATHOLOGY_OTHER_LOWContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Internalname, AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_high.SetProperty("Caption", Ddo_br_pathology_other_high_Caption);
            ucDdo_br_pathology_other_high.SetProperty("Tooltip", Ddo_br_pathology_other_high_Tooltip);
            ucDdo_br_pathology_other_high.SetProperty("Cls", Ddo_br_pathology_other_high_Cls);
            ucDdo_br_pathology_other_high.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_high_Dropdownoptionstype);
            ucDdo_br_pathology_other_high.SetProperty("IncludeSortASC", Ddo_br_pathology_other_high_Includesortasc);
            ucDdo_br_pathology_other_high.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_high_Includesortdsc);
            ucDdo_br_pathology_other_high.SetProperty("IncludeFilter", Ddo_br_pathology_other_high_Includefilter);
            ucDdo_br_pathology_other_high.SetProperty("IncludeDataList", Ddo_br_pathology_other_high_Includedatalist);
            ucDdo_br_pathology_other_high.SetProperty("SortASC", Ddo_br_pathology_other_high_Sortasc);
            ucDdo_br_pathology_other_high.SetProperty("SortDSC", Ddo_br_pathology_other_high_Sortdsc);
            ucDdo_br_pathology_other_high.SetProperty("SearchButtonText", Ddo_br_pathology_other_high_Searchbuttontext);
            ucDdo_br_pathology_other_high.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_high.SetProperty("DropDownOptionsData", AV27BR_Pathology_Other_HighTitleFilterData);
            ucDdo_br_pathology_other_high.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_high_Internalname, "DDO_BR_PATHOLOGY_OTHER_HIGHContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Internalname, AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_abnind.SetProperty("Caption", Ddo_br_pathology_other_abnind_Caption);
            ucDdo_br_pathology_other_abnind.SetProperty("Tooltip", Ddo_br_pathology_other_abnind_Tooltip);
            ucDdo_br_pathology_other_abnind.SetProperty("Cls", Ddo_br_pathology_other_abnind_Cls);
            ucDdo_br_pathology_other_abnind.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_abnind_Dropdownoptionstype);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeSortASC", Ddo_br_pathology_other_abnind_Includesortasc);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_abnind_Includesortdsc);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeFilter", Ddo_br_pathology_other_abnind_Includefilter);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeDataList", Ddo_br_pathology_other_abnind_Includedatalist);
            ucDdo_br_pathology_other_abnind.SetProperty("SortASC", Ddo_br_pathology_other_abnind_Sortasc);
            ucDdo_br_pathology_other_abnind.SetProperty("SortDSC", Ddo_br_pathology_other_abnind_Sortdsc);
            ucDdo_br_pathology_other_abnind.SetProperty("SearchButtonText", Ddo_br_pathology_other_abnind_Searchbuttontext);
            ucDdo_br_pathology_other_abnind.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_abnind.SetProperty("DropDownOptionsData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
            ucDdo_br_pathology_other_abnind.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_abnind_Internalname, "DDO_BR_PATHOLOGY_OTHER_ABNINDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname, AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Pathology_OtherPrompt.htm");
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

      protected void START5Q2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择病理学其它信息", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5Q0( ) ;
      }

      protected void WS5Q2( )
      {
         START5Q2( ) ;
         EVT5Q2( ) ;
      }

      protected void EVT5Q2( )
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
                           E115Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E125Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E135Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E145Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E155Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIONUM.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E165Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E175Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E185Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_LOW.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E195Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_HIGH.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E205Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_ABNIND.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E215Q2 ();
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
                           AV36Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV36Select)) ? AV40Select_GXI : context.convertURL( context.PathToRelativeUrl( AV36Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV36Select), true);
                           A288BR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( edtBR_Pathology_OtherID_Internalname), ".", ","));
                           A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
                           n226BR_PathologyID = false;
                           A289BR_Pathology_Other_Bio = cgiGet( edtBR_Pathology_Other_Bio_Internalname);
                           n289BR_Pathology_Other_Bio = false;
                           A290BR_Pathology_Other_BioNum = context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_BioNum_Internalname), ".", ",");
                           n290BR_Pathology_Other_BioNum = false;
                           A291BR_Pathology_Other_BioNumUnit = cgiGet( edtBR_Pathology_Other_BioNumUnit_Internalname);
                           n291BR_Pathology_Other_BioNumUnit = false;
                           A292BR_Pathology_Other_BioQual = cgiGet( edtBR_Pathology_Other_BioQual_Internalname);
                           n292BR_Pathology_Other_BioQual = false;
                           A293BR_Pathology_Other_Low = context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_Low_Internalname), ".", ",");
                           n293BR_Pathology_Other_Low = false;
                           A294BR_Pathology_Other_High = context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_High_Internalname), ".", ",");
                           n294BR_Pathology_Other_High = false;
                           A295BR_Pathology_Other_AbnInd = cgiGet( edtBR_Pathology_Other_AbnInd_Internalname);
                           n295BR_Pathology_Other_AbnInd = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E225Q2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E235Q2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E245Q2 ();
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
                                       E255Q2 ();
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

      protected void WE5Q2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5Q2( ) ;
            }
         }
      }

      protected void PA5Q2( )
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
               GX_FocusControl = edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_PathologyIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace ,
                                       String AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace ,
                                       String AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace ,
                                       String AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace ,
                                       String AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace ,
                                       String AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace ,
                                       String AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5Q2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_OTHERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_OTHERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_OTHER_BIO", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A289BR_Pathology_Other_Bio, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_OTHER_BIO", A289BR_Pathology_Other_Bio);
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
         RF5Q2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV39Pgmname = "BR_Pathology_OtherPrompt";
         context.Gx_err = 0;
      }

      protected void RF5Q2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E235Q2 ();
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
            /* Using cursor H005Q2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A295BR_Pathology_Other_AbnInd = H005Q2_A295BR_Pathology_Other_AbnInd[0];
               n295BR_Pathology_Other_AbnInd = H005Q2_n295BR_Pathology_Other_AbnInd[0];
               A294BR_Pathology_Other_High = H005Q2_A294BR_Pathology_Other_High[0];
               n294BR_Pathology_Other_High = H005Q2_n294BR_Pathology_Other_High[0];
               A293BR_Pathology_Other_Low = H005Q2_A293BR_Pathology_Other_Low[0];
               n293BR_Pathology_Other_Low = H005Q2_n293BR_Pathology_Other_Low[0];
               A292BR_Pathology_Other_BioQual = H005Q2_A292BR_Pathology_Other_BioQual[0];
               n292BR_Pathology_Other_BioQual = H005Q2_n292BR_Pathology_Other_BioQual[0];
               A291BR_Pathology_Other_BioNumUnit = H005Q2_A291BR_Pathology_Other_BioNumUnit[0];
               n291BR_Pathology_Other_BioNumUnit = H005Q2_n291BR_Pathology_Other_BioNumUnit[0];
               A290BR_Pathology_Other_BioNum = H005Q2_A290BR_Pathology_Other_BioNum[0];
               n290BR_Pathology_Other_BioNum = H005Q2_n290BR_Pathology_Other_BioNum[0];
               A289BR_Pathology_Other_Bio = H005Q2_A289BR_Pathology_Other_Bio[0];
               n289BR_Pathology_Other_Bio = H005Q2_n289BR_Pathology_Other_Bio[0];
               A226BR_PathologyID = H005Q2_A226BR_PathologyID[0];
               n226BR_PathologyID = H005Q2_n226BR_PathologyID[0];
               A288BR_Pathology_OtherID = H005Q2_A288BR_Pathology_OtherID[0];
               E245Q2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB5Q0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5Q2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_OTHERID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_OTHER_BIO"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A289BR_Pathology_Other_Bio, "")), context));
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
         /* Using cursor H005Q3 */
         pr_default.execute(1);
         GRID_nRecordCount = H005Q3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5Q0( )
      {
         /* Before Start, stand alone formulas. */
         AV39Pgmname = "BR_Pathology_OtherPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E225Q2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV31DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA"), AV13BR_Pathology_OtherIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYIDTITLEFILTERDATA"), AV15BR_PathologyIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA"), AV17BR_Pathology_Other_BioTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA"), AV19BR_Pathology_Other_BioNumTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA"), AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA"), AV23BR_Pathology_Other_BioQualTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA"), AV25BR_Pathology_Other_LowTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA"), AV27BR_Pathology_Other_HighTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA"), AV29BR_Pathology_Other_AbnIndTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace", AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace);
            AV16ddo_BR_PathologyIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_PathologyIDTitleControlIdToReplace", AV16ddo_BR_PathologyIDTitleControlIdToReplace);
            AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace", AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace);
            AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace", AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace);
            AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace", AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace);
            AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace", AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace);
            AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace", AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace);
            AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace", AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace);
            AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace", AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace);
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
            AV33GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV35GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV34GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_pathology_otherid_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Caption");
            Ddo_br_pathology_otherid_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Tooltip");
            Ddo_br_pathology_otherid_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Cls");
            Ddo_br_pathology_otherid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Dropdownoptionstype");
            Ddo_br_pathology_otherid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Titlecontrolidtoreplace");
            Ddo_br_pathology_otherid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Includesortasc"));
            Ddo_br_pathology_otherid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Includesortdsc"));
            Ddo_br_pathology_otherid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Sortedstatus");
            Ddo_br_pathology_otherid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Includefilter"));
            Ddo_br_pathology_otherid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Includedatalist"));
            Ddo_br_pathology_otherid_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Sortasc");
            Ddo_br_pathology_otherid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Sortdsc");
            Ddo_br_pathology_otherid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Searchbuttontext");
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
            Ddo_br_pathology_other_bio_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Caption");
            Ddo_br_pathology_other_bio_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Tooltip");
            Ddo_br_pathology_other_bio_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Cls");
            Ddo_br_pathology_other_bio_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Dropdownoptionstype");
            Ddo_br_pathology_other_bio_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bio_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Includesortasc"));
            Ddo_br_pathology_other_bio_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Includesortdsc"));
            Ddo_br_pathology_other_bio_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Sortedstatus");
            Ddo_br_pathology_other_bio_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Includefilter"));
            Ddo_br_pathology_other_bio_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Includedatalist"));
            Ddo_br_pathology_other_bio_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Sortasc");
            Ddo_br_pathology_other_bio_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Sortdsc");
            Ddo_br_pathology_other_bio_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Searchbuttontext");
            Ddo_br_pathology_other_bionum_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Caption");
            Ddo_br_pathology_other_bionum_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Tooltip");
            Ddo_br_pathology_other_bionum_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Cls");
            Ddo_br_pathology_other_bionum_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Dropdownoptionstype");
            Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bionum_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortasc"));
            Ddo_br_pathology_other_bionum_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortdsc"));
            Ddo_br_pathology_other_bionum_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortedstatus");
            Ddo_br_pathology_other_bionum_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includefilter"));
            Ddo_br_pathology_other_bionum_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includedatalist"));
            Ddo_br_pathology_other_bionum_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortasc");
            Ddo_br_pathology_other_bionum_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortdsc");
            Ddo_br_pathology_other_bionum_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Searchbuttontext");
            Ddo_br_pathology_other_bionumunit_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Caption");
            Ddo_br_pathology_other_bionumunit_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Tooltip");
            Ddo_br_pathology_other_bionumunit_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Cls");
            Ddo_br_pathology_other_bionumunit_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Dropdownoptionstype");
            Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bionumunit_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortasc"));
            Ddo_br_pathology_other_bionumunit_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortdsc"));
            Ddo_br_pathology_other_bionumunit_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortedstatus");
            Ddo_br_pathology_other_bionumunit_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includefilter"));
            Ddo_br_pathology_other_bionumunit_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includedatalist"));
            Ddo_br_pathology_other_bionumunit_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortasc");
            Ddo_br_pathology_other_bionumunit_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortdsc");
            Ddo_br_pathology_other_bionumunit_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Searchbuttontext");
            Ddo_br_pathology_other_bioqual_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Caption");
            Ddo_br_pathology_other_bioqual_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Tooltip");
            Ddo_br_pathology_other_bioqual_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Cls");
            Ddo_br_pathology_other_bioqual_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Dropdownoptionstype");
            Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bioqual_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includesortasc"));
            Ddo_br_pathology_other_bioqual_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includesortdsc"));
            Ddo_br_pathology_other_bioqual_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortedstatus");
            Ddo_br_pathology_other_bioqual_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includefilter"));
            Ddo_br_pathology_other_bioqual_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includedatalist"));
            Ddo_br_pathology_other_bioqual_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortasc");
            Ddo_br_pathology_other_bioqual_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortdsc");
            Ddo_br_pathology_other_bioqual_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Searchbuttontext");
            Ddo_br_pathology_other_low_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Caption");
            Ddo_br_pathology_other_low_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Tooltip");
            Ddo_br_pathology_other_low_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Cls");
            Ddo_br_pathology_other_low_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Dropdownoptionstype");
            Ddo_br_pathology_other_low_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_low_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Includesortasc"));
            Ddo_br_pathology_other_low_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Includesortdsc"));
            Ddo_br_pathology_other_low_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Sortedstatus");
            Ddo_br_pathology_other_low_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Includefilter"));
            Ddo_br_pathology_other_low_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Includedatalist"));
            Ddo_br_pathology_other_low_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Sortasc");
            Ddo_br_pathology_other_low_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Sortdsc");
            Ddo_br_pathology_other_low_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Searchbuttontext");
            Ddo_br_pathology_other_high_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Caption");
            Ddo_br_pathology_other_high_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Tooltip");
            Ddo_br_pathology_other_high_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Cls");
            Ddo_br_pathology_other_high_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Dropdownoptionstype");
            Ddo_br_pathology_other_high_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_high_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Includesortasc"));
            Ddo_br_pathology_other_high_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Includesortdsc"));
            Ddo_br_pathology_other_high_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortedstatus");
            Ddo_br_pathology_other_high_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Includefilter"));
            Ddo_br_pathology_other_high_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Includedatalist"));
            Ddo_br_pathology_other_high_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortasc");
            Ddo_br_pathology_other_high_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortdsc");
            Ddo_br_pathology_other_high_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Searchbuttontext");
            Ddo_br_pathology_other_abnind_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Caption");
            Ddo_br_pathology_other_abnind_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Tooltip");
            Ddo_br_pathology_other_abnind_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Cls");
            Ddo_br_pathology_other_abnind_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Dropdownoptionstype");
            Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_abnind_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortasc"));
            Ddo_br_pathology_other_abnind_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortdsc"));
            Ddo_br_pathology_other_abnind_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortedstatus");
            Ddo_br_pathology_other_abnind_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includefilter"));
            Ddo_br_pathology_other_abnind_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includedatalist"));
            Ddo_br_pathology_other_abnind_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortasc");
            Ddo_br_pathology_other_abnind_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortdsc");
            Ddo_br_pathology_other_abnind_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_pathology_otherid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Activeeventkey");
            Ddo_br_pathologyid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_Activeeventkey");
            Ddo_br_pathology_other_bio_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Activeeventkey");
            Ddo_br_pathology_other_bionum_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Activeeventkey");
            Ddo_br_pathology_other_bionumunit_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Activeeventkey");
            Ddo_br_pathology_other_bioqual_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Activeeventkey");
            Ddo_br_pathology_other_low_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Activeeventkey");
            Ddo_br_pathology_other_high_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Activeeventkey");
            Ddo_br_pathology_other_abnind_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Activeeventkey");
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
         E225Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E225Q2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology_Other", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV39Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_pathology_otherid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_OtherID";
         ucDdo_br_pathology_otherid.SendProperty(context, "", false, Ddo_br_pathology_otherid_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_otherid_Titlecontrolidtoreplace);
         AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace = Ddo_br_pathology_otherid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace", AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace);
         edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_Titlecontrolidtoreplace);
         AV16ddo_BR_PathologyIDTitleControlIdToReplace = Ddo_br_pathologyid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_PathologyIDTitleControlIdToReplace", AV16ddo_BR_PathologyIDTitleControlIdToReplace);
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_bio_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_Bio";
         ucDdo_br_pathology_other_bio.SendProperty(context, "", false, Ddo_br_pathology_other_bio_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bio_Titlecontrolidtoreplace);
         AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace = Ddo_br_pathology_other_bio_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace", AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace);
         edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_BioNum";
         ucDdo_br_pathology_other_bionum.SendProperty(context, "", false, Ddo_br_pathology_other_bionum_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace);
         AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace", AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace);
         edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_BioNumUnit";
         ucDdo_br_pathology_other_bionumunit.SendProperty(context, "", false, Ddo_br_pathology_other_bionumunit_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace);
         AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace", AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace);
         edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_BioQual";
         ucDdo_br_pathology_other_bioqual.SendProperty(context, "", false, Ddo_br_pathology_other_bioqual_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace);
         AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace = Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace", AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace);
         edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_low_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_Low";
         ucDdo_br_pathology_other_low.SendProperty(context, "", false, Ddo_br_pathology_other_low_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_low_Titlecontrolidtoreplace);
         AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace = Ddo_br_pathology_other_low_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace", AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace);
         edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_high_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_High";
         ucDdo_br_pathology_other_high.SendProperty(context, "", false, Ddo_br_pathology_other_high_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_high_Titlecontrolidtoreplace);
         AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace = Ddo_br_pathology_other_high_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace", AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace);
         edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_AbnInd";
         ucDdo_br_pathology_other_abnind.SendProperty(context, "", false, Ddo_br_pathology_other_abnind_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace);
         AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace", AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace);
         edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择病理学其它信息";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV31DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV31DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E235Q2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_Pathology_OtherIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Pathology_Other_BioTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Pathology_Other_BioNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Pathology_Other_BioNumUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Pathology_Other_BioQualTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_Pathology_Other_LowTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Pathology_Other_HighTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_Pathology_Other_AbnIndTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_Pathology_OtherID_Titleformat = 2;
         edtBR_Pathology_OtherID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学其他信息主键", AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_OtherID_Internalname, "Title", edtBR_Pathology_OtherID_Title, !bGXsfl_12_Refreshing);
         edtBR_PathologyID_Titleformat = 2;
         edtBR_PathologyID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学主键", AV16ddo_BR_PathologyIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Title", edtBR_PathologyID_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_Other_Bio_Titleformat = 2;
         edtBR_Pathology_Other_Bio_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "肿瘤标志物", AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_Bio_Internalname, "Title", edtBR_Pathology_Other_Bio_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_Other_BioNum_Titleformat = 2;
         edtBR_Pathology_Other_BioNum_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "定量结果", AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_BioNum_Internalname, "Title", edtBR_Pathology_Other_BioNum_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_Other_BioNumUnit_Titleformat = 2;
         edtBR_Pathology_Other_BioNumUnit_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "定量结果单位", AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_BioNumUnit_Internalname, "Title", edtBR_Pathology_Other_BioNumUnit_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_Other_BioQual_Titleformat = 2;
         edtBR_Pathology_Other_BioQual_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "定性结果", AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_BioQual_Internalname, "Title", edtBR_Pathology_Other_BioQual_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_Other_Low_Titleformat = 2;
         edtBR_Pathology_Other_Low_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "参考上限", AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_Low_Internalname, "Title", edtBR_Pathology_Other_Low_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_Other_High_Titleformat = 2;
         edtBR_Pathology_Other_High_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "参考下限", AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_High_Internalname, "Title", edtBR_Pathology_Other_High_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_Other_AbnInd_Titleformat = 2;
         edtBR_Pathology_Other_AbnInd_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "结果提示", AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_AbnInd_Internalname, "Title", edtBR_Pathology_Other_AbnInd_Title, !bGXsfl_12_Refreshing);
         AV33GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33GridCurrentPage), 10, 0)));
         AV34GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34GridPageSize), 10, 0)));
         AV35GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_OtherIDTitleFilterData", AV13BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Pathology_Other_BioQualTitleFilterData", AV23BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Pathology_Other_LowTitleFilterData", AV25BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Pathology_Other_HighTitleFilterData", AV27BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Pathology_Other_AbnIndTitleFilterData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E115Q2( )
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
            AV32PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV32PageToGo) ;
         }
      }

      protected void E125Q2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135Q2( )
      {
         /* Ddo_br_pathology_otherid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_otherid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_otherid_Sortedstatus = "ASC";
            ucDdo_br_pathology_otherid.SendProperty(context, "", false, Ddo_br_pathology_otherid_Internalname, "SortedStatus", Ddo_br_pathology_otherid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_otherid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_otherid_Sortedstatus = "DSC";
            ucDdo_br_pathology_otherid.SendProperty(context, "", false, Ddo_br_pathology_otherid_Internalname, "SortedStatus", Ddo_br_pathology_otherid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_OtherIDTitleFilterData", AV13BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Pathology_Other_BioQualTitleFilterData", AV23BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Pathology_Other_LowTitleFilterData", AV25BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Pathology_Other_HighTitleFilterData", AV27BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Pathology_Other_AbnIndTitleFilterData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E145Q2( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_OtherIDTitleFilterData", AV13BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Pathology_Other_BioQualTitleFilterData", AV23BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Pathology_Other_LowTitleFilterData", AV25BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Pathology_Other_HighTitleFilterData", AV27BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Pathology_Other_AbnIndTitleFilterData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E155Q2( )
      {
         /* Ddo_br_pathology_other_bio_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bio_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_bio_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bio.SendProperty(context, "", false, Ddo_br_pathology_other_bio_Internalname, "SortedStatus", Ddo_br_pathology_other_bio_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bio_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_bio_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bio.SendProperty(context, "", false, Ddo_br_pathology_other_bio_Internalname, "SortedStatus", Ddo_br_pathology_other_bio_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_OtherIDTitleFilterData", AV13BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Pathology_Other_BioQualTitleFilterData", AV23BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Pathology_Other_LowTitleFilterData", AV25BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Pathology_Other_HighTitleFilterData", AV27BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Pathology_Other_AbnIndTitleFilterData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E165Q2( )
      {
         /* Ddo_br_pathology_other_bionum_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionum_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_bionum_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bionum.SendProperty(context, "", false, Ddo_br_pathology_other_bionum_Internalname, "SortedStatus", Ddo_br_pathology_other_bionum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionum_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_bionum_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bionum.SendProperty(context, "", false, Ddo_br_pathology_other_bionum_Internalname, "SortedStatus", Ddo_br_pathology_other_bionum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_OtherIDTitleFilterData", AV13BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Pathology_Other_BioQualTitleFilterData", AV23BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Pathology_Other_LowTitleFilterData", AV25BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Pathology_Other_HighTitleFilterData", AV27BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Pathology_Other_AbnIndTitleFilterData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E175Q2( )
      {
         /* Ddo_br_pathology_other_bionumunit_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionumunit_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_bionumunit_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bionumunit.SendProperty(context, "", false, Ddo_br_pathology_other_bionumunit_Internalname, "SortedStatus", Ddo_br_pathology_other_bionumunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionumunit_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_bionumunit_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bionumunit.SendProperty(context, "", false, Ddo_br_pathology_other_bionumunit_Internalname, "SortedStatus", Ddo_br_pathology_other_bionumunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_OtherIDTitleFilterData", AV13BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Pathology_Other_BioQualTitleFilterData", AV23BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Pathology_Other_LowTitleFilterData", AV25BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Pathology_Other_HighTitleFilterData", AV27BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Pathology_Other_AbnIndTitleFilterData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E185Q2( )
      {
         /* Ddo_br_pathology_other_bioqual_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bioqual_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_bioqual_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bioqual.SendProperty(context, "", false, Ddo_br_pathology_other_bioqual_Internalname, "SortedStatus", Ddo_br_pathology_other_bioqual_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bioqual_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_bioqual_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bioqual.SendProperty(context, "", false, Ddo_br_pathology_other_bioqual_Internalname, "SortedStatus", Ddo_br_pathology_other_bioqual_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_OtherIDTitleFilterData", AV13BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Pathology_Other_BioQualTitleFilterData", AV23BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Pathology_Other_LowTitleFilterData", AV25BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Pathology_Other_HighTitleFilterData", AV27BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Pathology_Other_AbnIndTitleFilterData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E195Q2( )
      {
         /* Ddo_br_pathology_other_low_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_low_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_low_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_low.SendProperty(context, "", false, Ddo_br_pathology_other_low_Internalname, "SortedStatus", Ddo_br_pathology_other_low_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_low_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_low_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_low.SendProperty(context, "", false, Ddo_br_pathology_other_low_Internalname, "SortedStatus", Ddo_br_pathology_other_low_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_OtherIDTitleFilterData", AV13BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Pathology_Other_BioQualTitleFilterData", AV23BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Pathology_Other_LowTitleFilterData", AV25BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Pathology_Other_HighTitleFilterData", AV27BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Pathology_Other_AbnIndTitleFilterData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E205Q2( )
      {
         /* Ddo_br_pathology_other_high_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_high_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_high_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_high.SendProperty(context, "", false, Ddo_br_pathology_other_high_Internalname, "SortedStatus", Ddo_br_pathology_other_high_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_high_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_high_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_high.SendProperty(context, "", false, Ddo_br_pathology_other_high_Internalname, "SortedStatus", Ddo_br_pathology_other_high_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_OtherIDTitleFilterData", AV13BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Pathology_Other_BioQualTitleFilterData", AV23BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Pathology_Other_LowTitleFilterData", AV25BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Pathology_Other_HighTitleFilterData", AV27BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Pathology_Other_AbnIndTitleFilterData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E215Q2( )
      {
         /* Ddo_br_pathology_other_abnind_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_abnind_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_abnind_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_abnind.SendProperty(context, "", false, Ddo_br_pathology_other_abnind_Internalname, "SortedStatus", Ddo_br_pathology_other_abnind_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_abnind_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_other_abnind_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_abnind.SendProperty(context, "", false, Ddo_br_pathology_other_abnind_Internalname, "SortedStatus", Ddo_br_pathology_other_abnind_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_OtherIDTitleFilterData", AV13BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Pathology_Other_BioQualTitleFilterData", AV23BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Pathology_Other_LowTitleFilterData", AV25BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Pathology_Other_HighTitleFilterData", AV27BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Pathology_Other_AbnIndTitleFilterData", AV29BR_Pathology_Other_AbnIndTitleFilterData);
      }

      private void E245Q2( )
      {
         /* Grid_Load Routine */
         AV36Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV36Select);
         AV40Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E255Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E255Q2( )
      {
         /* Enter Routine */
         AV8InOutBR_Pathology_OtherID = A288BR_Pathology_OtherID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Pathology_OtherID), 18, 0)));
         AV9InOutBR_Pathology_Other_Bio = A289BR_Pathology_Other_Bio;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Pathology_Other_Bio", AV9InOutBR_Pathology_Other_Bio);
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_Pathology_OtherID,(String)AV9InOutBR_Pathology_Other_Bio});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_Pathology_OtherID","AV9InOutBR_Pathology_Other_Bio"});
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
         AV8InOutBR_Pathology_OtherID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Pathology_OtherID), 18, 0)));
         AV9InOutBR_Pathology_Other_Bio = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Pathology_Other_Bio", AV9InOutBR_Pathology_Other_Bio);
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
         PA5Q2( ) ;
         WS5Q2( ) ;
         WE5Q2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815144988", true);
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
         context.AddJavascriptSource("br_pathology_otherprompt.js", "?202022815144989", false);
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
         edtBR_Pathology_OtherID_Internalname = "BR_PATHOLOGY_OTHERID_"+sGXsfl_12_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_12_idx;
         edtBR_Pathology_Other_Bio_Internalname = "BR_PATHOLOGY_OTHER_BIO_"+sGXsfl_12_idx;
         edtBR_Pathology_Other_BioNum_Internalname = "BR_PATHOLOGY_OTHER_BIONUM_"+sGXsfl_12_idx;
         edtBR_Pathology_Other_BioNumUnit_Internalname = "BR_PATHOLOGY_OTHER_BIONUMUNIT_"+sGXsfl_12_idx;
         edtBR_Pathology_Other_BioQual_Internalname = "BR_PATHOLOGY_OTHER_BIOQUAL_"+sGXsfl_12_idx;
         edtBR_Pathology_Other_Low_Internalname = "BR_PATHOLOGY_OTHER_LOW_"+sGXsfl_12_idx;
         edtBR_Pathology_Other_High_Internalname = "BR_PATHOLOGY_OTHER_HIGH_"+sGXsfl_12_idx;
         edtBR_Pathology_Other_AbnInd_Internalname = "BR_PATHOLOGY_OTHER_ABNIND_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_OtherID_Internalname = "BR_PATHOLOGY_OTHERID_"+sGXsfl_12_fel_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_Other_Bio_Internalname = "BR_PATHOLOGY_OTHER_BIO_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_Other_BioNum_Internalname = "BR_PATHOLOGY_OTHER_BIONUM_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_Other_BioNumUnit_Internalname = "BR_PATHOLOGY_OTHER_BIONUMUNIT_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_Other_BioQual_Internalname = "BR_PATHOLOGY_OTHER_BIOQUAL_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_Other_Low_Internalname = "BR_PATHOLOGY_OTHER_LOW_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_Other_High_Internalname = "BR_PATHOLOGY_OTHER_HIGH_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_Other_AbnInd_Internalname = "BR_PATHOLOGY_OTHER_ABNIND_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB5Q0( ) ;
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
            AV36Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV36Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV40Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV36Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV36Select)) ? AV40Select_GXI : context.PathToRelativeUrl( AV36Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV36Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_OtherID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_OtherID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_Bio_Internalname,(String)A289BR_Pathology_Other_Bio,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_Bio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_BioNum_Internalname,StringUtil.LTrim( StringUtil.NToC( A290BR_Pathology_Other_BioNum, 15, 5, ".", "")),context.localUtil.Format( A290BR_Pathology_Other_BioNum, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_BioNum_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_BioNumUnit_Internalname,(String)A291BR_Pathology_Other_BioNumUnit,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_BioNumUnit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_BioQual_Internalname,(String)A292BR_Pathology_Other_BioQual,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_BioQual_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_Low_Internalname,StringUtil.LTrim( StringUtil.NToC( A293BR_Pathology_Other_Low, 15, 5, ".", "")),context.localUtil.Format( A293BR_Pathology_Other_Low, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_Low_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_High_Internalname,StringUtil.LTrim( StringUtil.NToC( A294BR_Pathology_Other_High, 15, 5, ".", "")),context.localUtil.Format( A294BR_Pathology_Other_High, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_High_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_AbnInd_Internalname,(String)A295BR_Pathology_Other_AbnInd,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_AbnInd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes5Q2( ) ;
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
         edtBR_Pathology_OtherID_Internalname = "BR_PATHOLOGY_OTHERID";
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID";
         edtBR_Pathology_Other_Bio_Internalname = "BR_PATHOLOGY_OTHER_BIO";
         edtBR_Pathology_Other_BioNum_Internalname = "BR_PATHOLOGY_OTHER_BIONUM";
         edtBR_Pathology_Other_BioNumUnit_Internalname = "BR_PATHOLOGY_OTHER_BIONUMUNIT";
         edtBR_Pathology_Other_BioQual_Internalname = "BR_PATHOLOGY_OTHER_BIOQUAL";
         edtBR_Pathology_Other_Low_Internalname = "BR_PATHOLOGY_OTHER_LOW";
         edtBR_Pathology_Other_High_Internalname = "BR_PATHOLOGY_OTHER_HIGH";
         edtBR_Pathology_Other_AbnInd_Internalname = "BR_PATHOLOGY_OTHER_ABNIND";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_pathology_otherid_Internalname = "DDO_BR_PATHOLOGY_OTHERID";
         edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_Internalname = "DDO_BR_PATHOLOGYID";
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_other_bio_Internalname = "DDO_BR_PATHOLOGY_OTHER_BIO";
         edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_other_bionum_Internalname = "DDO_BR_PATHOLOGY_OTHER_BIONUM";
         edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_other_bionumunit_Internalname = "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT";
         edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_other_bioqual_Internalname = "DDO_BR_PATHOLOGY_OTHER_BIOQUAL";
         edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_other_low_Internalname = "DDO_BR_PATHOLOGY_OTHER_LOW";
         edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_other_high_Internalname = "DDO_BR_PATHOLOGY_OTHER_HIGH";
         edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_other_abnind_Internalname = "DDO_BR_PATHOLOGY_OTHER_ABNIND";
         edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE";
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
         edtBR_Pathology_Other_AbnInd_Jsonclick = "";
         edtBR_Pathology_Other_High_Jsonclick = "";
         edtBR_Pathology_Other_Low_Jsonclick = "";
         edtBR_Pathology_Other_BioQual_Jsonclick = "";
         edtBR_Pathology_Other_BioNumUnit_Jsonclick = "";
         edtBR_Pathology_Other_BioNum_Jsonclick = "";
         edtBR_Pathology_Other_Bio_Jsonclick = "";
         edtBR_PathologyID_Jsonclick = "";
         edtBR_Pathology_OtherID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Pathology_Other_AbnInd_Titleformat = 0;
         edtBR_Pathology_Other_AbnInd_Title = "结果提示";
         edtBR_Pathology_Other_High_Titleformat = 0;
         edtBR_Pathology_Other_High_Title = "参考下限";
         edtBR_Pathology_Other_Low_Titleformat = 0;
         edtBR_Pathology_Other_Low_Title = "参考上限";
         edtBR_Pathology_Other_BioQual_Titleformat = 0;
         edtBR_Pathology_Other_BioQual_Title = "定性结果";
         edtBR_Pathology_Other_BioNumUnit_Titleformat = 0;
         edtBR_Pathology_Other_BioNumUnit_Title = "定量结果单位";
         edtBR_Pathology_Other_BioNum_Titleformat = 0;
         edtBR_Pathology_Other_BioNum_Title = "定量结果";
         edtBR_Pathology_Other_Bio_Titleformat = 0;
         edtBR_Pathology_Other_Bio_Title = "肿瘤标志物";
         edtBR_PathologyID_Titleformat = 0;
         edtBR_PathologyID_Title = "病理学主键";
         edtBR_Pathology_OtherID_Titleformat = 0;
         edtBR_Pathology_OtherID_Title = "病理学其他信息主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_pathology_other_abnind_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_abnind_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_abnind_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_abnind_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_abnind_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_abnind_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_abnind_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_abnind_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_abnind_Cls = "ColumnSettings";
         Ddo_br_pathology_other_abnind_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_abnind_Caption = "";
         Ddo_br_pathology_other_high_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_high_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_high_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_high_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_high_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_high_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_high_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_high_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_high_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_high_Cls = "ColumnSettings";
         Ddo_br_pathology_other_high_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_high_Caption = "";
         Ddo_br_pathology_other_low_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_low_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_low_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_low_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_low_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_low_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_low_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_low_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_low_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_low_Cls = "ColumnSettings";
         Ddo_br_pathology_other_low_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_low_Caption = "";
         Ddo_br_pathology_other_bioqual_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bioqual_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bioqual_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bioqual_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bioqual_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bioqual_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bioqual_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bioqual_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bioqual_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bioqual_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bioqual_Caption = "";
         Ddo_br_pathology_other_bionumunit_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bionumunit_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bionumunit_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bionumunit_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bionumunit_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bionumunit_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionumunit_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bionumunit_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bionumunit_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bionumunit_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bionumunit_Caption = "";
         Ddo_br_pathology_other_bionum_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bionum_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bionum_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bionum_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bionum_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bionum_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionum_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bionum_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bionum_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bionum_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bionum_Caption = "";
         Ddo_br_pathology_other_bio_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bio_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bio_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bio_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bio_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bio_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bio_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bio_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bio_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bio_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bio_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bio_Caption = "";
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
         Ddo_br_pathology_otherid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_otherid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_otherid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_otherid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_otherid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_otherid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_otherid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_otherid_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_otherid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_otherid_Cls = "ColumnSettings";
         Ddo_br_pathology_otherid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_otherid_Caption = "";
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
         Form.Caption = "选择病理学其它信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV25BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV27BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV29BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHERID.ONOPTIONCLICKED","{handler:'E135Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_otherid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHERID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_otherid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'SortedStatus'},{av:'AV13BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV25BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV27BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV29BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED","{handler:'E145Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathologyid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV13BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV25BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV27BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV29BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIO.ONOPTIONCLICKED","{handler:'E155Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_other_bio_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIO.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'AV13BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV25BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV27BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV29BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUM.ONOPTIONCLICKED","{handler:'E165Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_other_bionum_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUM.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'AV13BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV25BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV27BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV29BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT.ONOPTIONCLICKED","{handler:'E175Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_other_bionumunit_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'AV13BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV25BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV27BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV29BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIOQUAL.ONOPTIONCLICKED","{handler:'E185Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_other_bioqual_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIOQUAL.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bioqual_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SortedStatus'},{av:'AV13BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV25BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV27BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV29BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_LOW.ONOPTIONCLICKED","{handler:'E195Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_other_low_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_LOW.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_low_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'SortedStatus'},{av:'AV13BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV25BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV27BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV29BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_HIGH.ONOPTIONCLICKED","{handler:'E205Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_other_high_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_HIGH.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_high_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'SortedStatus'},{av:'AV13BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV25BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV27BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV29BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_ABNIND.ONOPTIONCLICKED","{handler:'E215Q2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_other_abnind_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_ABNIND.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV13BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV25BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV27BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV29BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E245Q2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV36Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E255Q2',iparms:[{av:'A288BR_Pathology_OtherID',fld:'BR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A289BR_Pathology_Other_Bio',fld:'BR_PATHOLOGY_OTHER_BIO',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_Pathology_OtherID',fld:'vINOUTBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutBR_Pathology_Other_Bio',fld:'vINOUTBR_PATHOLOGY_OTHER_BIO',pic:''}]}");
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
         wcpOAV9InOutBR_Pathology_Other_Bio = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_pathology_otherid_Activeeventkey = "";
         Ddo_br_pathologyid_Activeeventkey = "";
         Ddo_br_pathology_other_bio_Activeeventkey = "";
         Ddo_br_pathology_other_bionum_Activeeventkey = "";
         Ddo_br_pathology_other_bionumunit_Activeeventkey = "";
         Ddo_br_pathology_other_bioqual_Activeeventkey = "";
         Ddo_br_pathology_other_low_Activeeventkey = "";
         Ddo_br_pathology_other_high_Activeeventkey = "";
         Ddo_br_pathology_other_abnind_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace = "";
         AV16ddo_BR_PathologyIDTitleControlIdToReplace = "";
         AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace = "";
         AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = "";
         AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = "";
         AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace = "";
         AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace = "";
         AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace = "";
         AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = "";
         GXKey = "";
         AV39Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV31DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_Pathology_OtherIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Pathology_Other_BioTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Pathology_Other_BioNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Pathology_Other_BioNumUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Pathology_Other_BioQualTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_Pathology_Other_LowTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Pathology_Other_HighTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_Pathology_Other_AbnIndTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_pathology_otherid_Sortedstatus = "";
         Ddo_br_pathologyid_Sortedstatus = "";
         Ddo_br_pathology_other_bio_Sortedstatus = "";
         Ddo_br_pathology_other_bionum_Sortedstatus = "";
         Ddo_br_pathology_other_bionumunit_Sortedstatus = "";
         Ddo_br_pathology_other_bioqual_Sortedstatus = "";
         Ddo_br_pathology_other_low_Sortedstatus = "";
         Ddo_br_pathology_other_high_Sortedstatus = "";
         Ddo_br_pathology_other_abnind_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV36Select = "";
         A289BR_Pathology_Other_Bio = "";
         A291BR_Pathology_Other_BioNumUnit = "";
         A292BR_Pathology_Other_BioQual = "";
         A295BR_Pathology_Other_AbnInd = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_pathology_otherid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_pathologyid = new GXUserControl();
         ucDdo_br_pathology_other_bio = new GXUserControl();
         ucDdo_br_pathology_other_bionum = new GXUserControl();
         ucDdo_br_pathology_other_bionumunit = new GXUserControl();
         ucDdo_br_pathology_other_bioqual = new GXUserControl();
         ucDdo_br_pathology_other_low = new GXUserControl();
         ucDdo_br_pathology_other_high = new GXUserControl();
         ucDdo_br_pathology_other_abnind = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV40Select_GXI = "";
         scmdbuf = "";
         H005Q2_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         H005Q2_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         H005Q2_A294BR_Pathology_Other_High = new decimal[1] ;
         H005Q2_n294BR_Pathology_Other_High = new bool[] {false} ;
         H005Q2_A293BR_Pathology_Other_Low = new decimal[1] ;
         H005Q2_n293BR_Pathology_Other_Low = new bool[] {false} ;
         H005Q2_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         H005Q2_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         H005Q2_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         H005Q2_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         H005Q2_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         H005Q2_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         H005Q2_A289BR_Pathology_Other_Bio = new String[] {""} ;
         H005Q2_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         H005Q2_A226BR_PathologyID = new long[1] ;
         H005Q2_n226BR_PathologyID = new bool[] {false} ;
         H005Q2_A288BR_Pathology_OtherID = new long[1] ;
         H005Q3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_otherprompt__default(),
            new Object[][] {
                new Object[] {
               H005Q2_A295BR_Pathology_Other_AbnInd, H005Q2_n295BR_Pathology_Other_AbnInd, H005Q2_A294BR_Pathology_Other_High, H005Q2_n294BR_Pathology_Other_High, H005Q2_A293BR_Pathology_Other_Low, H005Q2_n293BR_Pathology_Other_Low, H005Q2_A292BR_Pathology_Other_BioQual, H005Q2_n292BR_Pathology_Other_BioQual, H005Q2_A291BR_Pathology_Other_BioNumUnit, H005Q2_n291BR_Pathology_Other_BioNumUnit,
               H005Q2_A290BR_Pathology_Other_BioNum, H005Q2_n290BR_Pathology_Other_BioNum, H005Q2_A289BR_Pathology_Other_Bio, H005Q2_n289BR_Pathology_Other_Bio, H005Q2_A226BR_PathologyID, H005Q2_n226BR_PathologyID, H005Q2_A288BR_Pathology_OtherID
               }
               , new Object[] {
               H005Q3_AGRID_nRecordCount
               }
            }
         );
         AV39Pgmname = "BR_Pathology_OtherPrompt";
         /* GeneXus formulas. */
         AV39Pgmname = "BR_Pathology_OtherPrompt";
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
      private short edtBR_Pathology_OtherID_Titleformat ;
      private short edtBR_PathologyID_Titleformat ;
      private short edtBR_Pathology_Other_Bio_Titleformat ;
      private short edtBR_Pathology_Other_BioNum_Titleformat ;
      private short edtBR_Pathology_Other_BioNumUnit_Titleformat ;
      private short edtBR_Pathology_Other_BioQual_Titleformat ;
      private short edtBR_Pathology_Other_Low_Titleformat ;
      private short edtBR_Pathology_Other_High_Titleformat ;
      private short edtBR_Pathology_Other_AbnInd_Titleformat ;
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
      private int edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV32PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_Pathology_OtherID ;
      private long wcpOAV8InOutBR_Pathology_OtherID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV33GridCurrentPage ;
      private long AV35GridRecordCount ;
      private long AV34GridPageSize ;
      private long A288BR_Pathology_OtherID ;
      private long A226BR_PathologyID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A290BR_Pathology_Other_BioNum ;
      private decimal A293BR_Pathology_Other_Low ;
      private decimal A294BR_Pathology_Other_High ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_pathology_otherid_Activeeventkey ;
      private String Ddo_br_pathologyid_Activeeventkey ;
      private String Ddo_br_pathology_other_bio_Activeeventkey ;
      private String Ddo_br_pathology_other_bionum_Activeeventkey ;
      private String Ddo_br_pathology_other_bionumunit_Activeeventkey ;
      private String Ddo_br_pathology_other_bioqual_Activeeventkey ;
      private String Ddo_br_pathology_other_low_Activeeventkey ;
      private String Ddo_br_pathology_other_high_Activeeventkey ;
      private String Ddo_br_pathology_other_abnind_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV39Pgmname ;
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
      private String Ddo_br_pathology_otherid_Caption ;
      private String Ddo_br_pathology_otherid_Tooltip ;
      private String Ddo_br_pathology_otherid_Cls ;
      private String Ddo_br_pathology_otherid_Dropdownoptionstype ;
      private String Ddo_br_pathology_otherid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_otherid_Sortedstatus ;
      private String Ddo_br_pathology_otherid_Sortasc ;
      private String Ddo_br_pathology_otherid_Sortdsc ;
      private String Ddo_br_pathology_otherid_Searchbuttontext ;
      private String Ddo_br_pathologyid_Caption ;
      private String Ddo_br_pathologyid_Tooltip ;
      private String Ddo_br_pathologyid_Cls ;
      private String Ddo_br_pathologyid_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_Sortedstatus ;
      private String Ddo_br_pathologyid_Sortasc ;
      private String Ddo_br_pathologyid_Sortdsc ;
      private String Ddo_br_pathologyid_Searchbuttontext ;
      private String Ddo_br_pathology_other_bio_Caption ;
      private String Ddo_br_pathology_other_bio_Tooltip ;
      private String Ddo_br_pathology_other_bio_Cls ;
      private String Ddo_br_pathology_other_bio_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bio_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bio_Sortedstatus ;
      private String Ddo_br_pathology_other_bio_Sortasc ;
      private String Ddo_br_pathology_other_bio_Sortdsc ;
      private String Ddo_br_pathology_other_bio_Searchbuttontext ;
      private String Ddo_br_pathology_other_bionum_Caption ;
      private String Ddo_br_pathology_other_bionum_Tooltip ;
      private String Ddo_br_pathology_other_bionum_Cls ;
      private String Ddo_br_pathology_other_bionum_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bionum_Sortedstatus ;
      private String Ddo_br_pathology_other_bionum_Sortasc ;
      private String Ddo_br_pathology_other_bionum_Sortdsc ;
      private String Ddo_br_pathology_other_bionum_Searchbuttontext ;
      private String Ddo_br_pathology_other_bionumunit_Caption ;
      private String Ddo_br_pathology_other_bionumunit_Tooltip ;
      private String Ddo_br_pathology_other_bionumunit_Cls ;
      private String Ddo_br_pathology_other_bionumunit_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bionumunit_Sortedstatus ;
      private String Ddo_br_pathology_other_bionumunit_Sortasc ;
      private String Ddo_br_pathology_other_bionumunit_Sortdsc ;
      private String Ddo_br_pathology_other_bionumunit_Searchbuttontext ;
      private String Ddo_br_pathology_other_bioqual_Caption ;
      private String Ddo_br_pathology_other_bioqual_Tooltip ;
      private String Ddo_br_pathology_other_bioqual_Cls ;
      private String Ddo_br_pathology_other_bioqual_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bioqual_Sortedstatus ;
      private String Ddo_br_pathology_other_bioqual_Sortasc ;
      private String Ddo_br_pathology_other_bioqual_Sortdsc ;
      private String Ddo_br_pathology_other_bioqual_Searchbuttontext ;
      private String Ddo_br_pathology_other_low_Caption ;
      private String Ddo_br_pathology_other_low_Tooltip ;
      private String Ddo_br_pathology_other_low_Cls ;
      private String Ddo_br_pathology_other_low_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_low_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_low_Sortedstatus ;
      private String Ddo_br_pathology_other_low_Sortasc ;
      private String Ddo_br_pathology_other_low_Sortdsc ;
      private String Ddo_br_pathology_other_low_Searchbuttontext ;
      private String Ddo_br_pathology_other_high_Caption ;
      private String Ddo_br_pathology_other_high_Tooltip ;
      private String Ddo_br_pathology_other_high_Cls ;
      private String Ddo_br_pathology_other_high_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_high_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_high_Sortedstatus ;
      private String Ddo_br_pathology_other_high_Sortasc ;
      private String Ddo_br_pathology_other_high_Sortdsc ;
      private String Ddo_br_pathology_other_high_Searchbuttontext ;
      private String Ddo_br_pathology_other_abnind_Caption ;
      private String Ddo_br_pathology_other_abnind_Tooltip ;
      private String Ddo_br_pathology_other_abnind_Cls ;
      private String Ddo_br_pathology_other_abnind_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_abnind_Sortedstatus ;
      private String Ddo_br_pathology_other_abnind_Sortasc ;
      private String Ddo_br_pathology_other_abnind_Sortdsc ;
      private String Ddo_br_pathology_other_abnind_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Pathology_OtherID_Title ;
      private String edtBR_PathologyID_Title ;
      private String edtBR_Pathology_Other_Bio_Title ;
      private String edtBR_Pathology_Other_BioNum_Title ;
      private String edtBR_Pathology_Other_BioNumUnit_Title ;
      private String edtBR_Pathology_Other_BioQual_Title ;
      private String edtBR_Pathology_Other_Low_Title ;
      private String edtBR_Pathology_Other_High_Title ;
      private String edtBR_Pathology_Other_AbnInd_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_pathology_otherid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_Internalname ;
      private String edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_other_bio_Internalname ;
      private String edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_other_bionum_Internalname ;
      private String edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_other_bionumunit_Internalname ;
      private String edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_other_bioqual_Internalname ;
      private String edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_other_low_Internalname ;
      private String edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_other_high_Internalname ;
      private String edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_other_abnind_Internalname ;
      private String edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_Pathology_OtherID_Internalname ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_Pathology_Other_Bio_Internalname ;
      private String edtBR_Pathology_Other_BioNum_Internalname ;
      private String edtBR_Pathology_Other_BioNumUnit_Internalname ;
      private String edtBR_Pathology_Other_BioQual_Internalname ;
      private String edtBR_Pathology_Other_Low_Internalname ;
      private String edtBR_Pathology_Other_High_Internalname ;
      private String edtBR_Pathology_Other_AbnInd_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Pathology_OtherID_Jsonclick ;
      private String edtBR_PathologyID_Jsonclick ;
      private String edtBR_Pathology_Other_Bio_Jsonclick ;
      private String edtBR_Pathology_Other_BioNum_Jsonclick ;
      private String edtBR_Pathology_Other_BioNumUnit_Jsonclick ;
      private String edtBR_Pathology_Other_BioQual_Jsonclick ;
      private String edtBR_Pathology_Other_Low_Jsonclick ;
      private String edtBR_Pathology_Other_High_Jsonclick ;
      private String edtBR_Pathology_Other_AbnInd_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_pathology_otherid_Includesortasc ;
      private bool Ddo_br_pathology_otherid_Includesortdsc ;
      private bool Ddo_br_pathology_otherid_Includefilter ;
      private bool Ddo_br_pathology_otherid_Includedatalist ;
      private bool Ddo_br_pathologyid_Includesortasc ;
      private bool Ddo_br_pathologyid_Includesortdsc ;
      private bool Ddo_br_pathologyid_Includefilter ;
      private bool Ddo_br_pathologyid_Includedatalist ;
      private bool Ddo_br_pathology_other_bio_Includesortasc ;
      private bool Ddo_br_pathology_other_bio_Includesortdsc ;
      private bool Ddo_br_pathology_other_bio_Includefilter ;
      private bool Ddo_br_pathology_other_bio_Includedatalist ;
      private bool Ddo_br_pathology_other_bionum_Includesortasc ;
      private bool Ddo_br_pathology_other_bionum_Includesortdsc ;
      private bool Ddo_br_pathology_other_bionum_Includefilter ;
      private bool Ddo_br_pathology_other_bionum_Includedatalist ;
      private bool Ddo_br_pathology_other_bionumunit_Includesortasc ;
      private bool Ddo_br_pathology_other_bionumunit_Includesortdsc ;
      private bool Ddo_br_pathology_other_bionumunit_Includefilter ;
      private bool Ddo_br_pathology_other_bionumunit_Includedatalist ;
      private bool Ddo_br_pathology_other_bioqual_Includesortasc ;
      private bool Ddo_br_pathology_other_bioqual_Includesortdsc ;
      private bool Ddo_br_pathology_other_bioqual_Includefilter ;
      private bool Ddo_br_pathology_other_bioqual_Includedatalist ;
      private bool Ddo_br_pathology_other_low_Includesortasc ;
      private bool Ddo_br_pathology_other_low_Includesortdsc ;
      private bool Ddo_br_pathology_other_low_Includefilter ;
      private bool Ddo_br_pathology_other_low_Includedatalist ;
      private bool Ddo_br_pathology_other_high_Includesortasc ;
      private bool Ddo_br_pathology_other_high_Includesortdsc ;
      private bool Ddo_br_pathology_other_high_Includefilter ;
      private bool Ddo_br_pathology_other_high_Includedatalist ;
      private bool Ddo_br_pathology_other_abnind_Includesortasc ;
      private bool Ddo_br_pathology_other_abnind_Includesortdsc ;
      private bool Ddo_br_pathology_other_abnind_Includefilter ;
      private bool Ddo_br_pathology_other_abnind_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n226BR_PathologyID ;
      private bool n289BR_Pathology_Other_Bio ;
      private bool n290BR_Pathology_Other_BioNum ;
      private bool n291BR_Pathology_Other_BioNumUnit ;
      private bool n292BR_Pathology_Other_BioQual ;
      private bool n293BR_Pathology_Other_Low ;
      private bool n294BR_Pathology_Other_High ;
      private bool n295BR_Pathology_Other_AbnInd ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV36Select_IsBlob ;
      private String AV9InOutBR_Pathology_Other_Bio ;
      private String wcpOAV9InOutBR_Pathology_Other_Bio ;
      private String AV14ddo_BR_Pathology_OtherIDTitleControlIdToReplace ;
      private String AV16ddo_BR_PathologyIDTitleControlIdToReplace ;
      private String AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace ;
      private String AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace ;
      private String AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace ;
      private String AV24ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace ;
      private String AV26ddo_BR_Pathology_Other_LowTitleControlIdToReplace ;
      private String AV28ddo_BR_Pathology_Other_HighTitleControlIdToReplace ;
      private String AV30ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace ;
      private String A289BR_Pathology_Other_Bio ;
      private String A291BR_Pathology_Other_BioNumUnit ;
      private String A292BR_Pathology_Other_BioQual ;
      private String A295BR_Pathology_Other_AbnInd ;
      private String AV40Select_GXI ;
      private String AV36Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_pathology_otherid ;
      private GXUserControl ucDdo_br_pathologyid ;
      private GXUserControl ucDdo_br_pathology_other_bio ;
      private GXUserControl ucDdo_br_pathology_other_bionum ;
      private GXUserControl ucDdo_br_pathology_other_bionumunit ;
      private GXUserControl ucDdo_br_pathology_other_bioqual ;
      private GXUserControl ucDdo_br_pathology_other_low ;
      private GXUserControl ucDdo_br_pathology_other_high ;
      private GXUserControl ucDdo_br_pathology_other_abnind ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_Pathology_OtherID ;
      private String aP1_InOutBR_Pathology_Other_Bio ;
      private IDataStoreProvider pr_default ;
      private String[] H005Q2_A295BR_Pathology_Other_AbnInd ;
      private bool[] H005Q2_n295BR_Pathology_Other_AbnInd ;
      private decimal[] H005Q2_A294BR_Pathology_Other_High ;
      private bool[] H005Q2_n294BR_Pathology_Other_High ;
      private decimal[] H005Q2_A293BR_Pathology_Other_Low ;
      private bool[] H005Q2_n293BR_Pathology_Other_Low ;
      private String[] H005Q2_A292BR_Pathology_Other_BioQual ;
      private bool[] H005Q2_n292BR_Pathology_Other_BioQual ;
      private String[] H005Q2_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] H005Q2_n291BR_Pathology_Other_BioNumUnit ;
      private decimal[] H005Q2_A290BR_Pathology_Other_BioNum ;
      private bool[] H005Q2_n290BR_Pathology_Other_BioNum ;
      private String[] H005Q2_A289BR_Pathology_Other_Bio ;
      private bool[] H005Q2_n289BR_Pathology_Other_Bio ;
      private long[] H005Q2_A226BR_PathologyID ;
      private bool[] H005Q2_n226BR_PathologyID ;
      private long[] H005Q2_A288BR_Pathology_OtherID ;
      private long[] H005Q3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_Pathology_OtherIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_PathologyIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Pathology_Other_BioTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_Pathology_Other_BioNumTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Pathology_Other_BioNumUnitTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_Pathology_Other_BioQualTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25BR_Pathology_Other_LowTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27BR_Pathology_Other_HighTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV29BR_Pathology_Other_AbnIndTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV31DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_pathology_otherprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005Q2( IGxContext context ,
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
         sSelectString = " [BR_Pathology_Other_AbnInd], [BR_Pathology_Other_High], [BR_Pathology_Other_Low], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_Bio], [BR_PathologyID], [BR_Pathology_OtherID]";
         sFromString = " FROM [BR_Pathology_Other] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_OtherID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_OtherID] DESC";
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
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_Bio]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_Bio] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioNum]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioNum] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioNumUnit]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioNumUnit] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioQual]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioQual] DESC";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_Low]";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_Low] DESC";
         }
         else if ( ( AV11OrderedBy == 8 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_High]";
         }
         else if ( ( AV11OrderedBy == 8 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_High] DESC";
         }
         else if ( ( AV11OrderedBy == 9 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_AbnInd]";
         }
         else if ( ( AV11OrderedBy == 9 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_AbnInd] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_OtherID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005Q3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Pathology_Other] WITH (NOLOCK)";
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
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 8 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 8 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 9 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 9 ) && ( AV12OrderedDsc ) )
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
                     return conditional_H005Q2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H005Q3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH005Q2 ;
          prmH005Q2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005Q3 ;
          prmH005Q3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H005Q2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005Q2,11,0,true,false )
             ,new CursorDef("H005Q3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005Q3,1,0,true,false )
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
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
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
