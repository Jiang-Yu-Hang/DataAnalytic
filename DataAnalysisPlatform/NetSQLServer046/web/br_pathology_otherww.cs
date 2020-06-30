/*
               File: BR_Pathology_OtherWW
        Description:  病理学其它信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:2:26.10
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
   public class br_pathology_otherww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathology_otherww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_otherww( IGxContext context )
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
               AV17TFBR_Pathology_OtherID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_Pathology_OtherID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_PathologyID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_Pathology_Other_Bio = GetNextPar( );
               AV26TFBR_Pathology_Other_Bio_Sel = GetNextPar( );
               AV29TFBR_Pathology_Other_BioNum = NumberUtil.Val( GetNextPar( ), ".");
               AV30TFBR_Pathology_Other_BioNum_To = NumberUtil.Val( GetNextPar( ), ".");
               AV33TFBR_Pathology_Other_BioNumUnit = GetNextPar( );
               AV34TFBR_Pathology_Other_BioNumUnit_Sel = GetNextPar( );
               AV37TFBR_Pathology_Other_BioQual = GetNextPar( );
               AV38TFBR_Pathology_Other_BioQual_Sel = GetNextPar( );
               AV41TFBR_Pathology_Other_Low = NumberUtil.Val( GetNextPar( ), ".");
               AV42TFBR_Pathology_Other_Low_To = NumberUtil.Val( GetNextPar( ), ".");
               AV45TFBR_Pathology_Other_High = NumberUtil.Val( GetNextPar( ), ".");
               AV46TFBR_Pathology_Other_High_To = NumberUtil.Val( GetNextPar( ), ".");
               AV49TFBR_Pathology_Other_AbnInd = GetNextPar( );
               AV50TFBR_Pathology_Other_AbnInd_Sel = GetNextPar( );
               AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_PathologyIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = GetNextPar( );
               AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace = GetNextPar( );
               AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace = GetNextPar( );
               AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace = GetNextPar( );
               AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = GetNextPar( );
               AV86Pgmname = GetNextPar( );
               AV59IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV61IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_OtherID, AV18TFBR_Pathology_OtherID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Other_Bio, AV26TFBR_Pathology_Other_Bio_Sel, AV29TFBR_Pathology_Other_BioNum, AV30TFBR_Pathology_Other_BioNum_To, AV33TFBR_Pathology_Other_BioNumUnit, AV34TFBR_Pathology_Other_BioNumUnit_Sel, AV37TFBR_Pathology_Other_BioQual, AV38TFBR_Pathology_Other_BioQual_Sel, AV41TFBR_Pathology_Other_Low, AV42TFBR_Pathology_Other_Low_To, AV45TFBR_Pathology_Other_High, AV46TFBR_Pathology_Other_High_To, AV49TFBR_Pathology_Other_AbnInd, AV50TFBR_Pathology_Other_AbnInd_Sel, AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV86Pgmname, AV59IsAuthorized_Update, AV61IsAuthorized_Delete) ;
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
         PA572( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START572( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271222662", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_otherww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Pathology_OtherID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Pathology_OtherID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_PathologyID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_BIO", AV25TFBR_Pathology_Other_Bio);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_BIO_SEL", AV26TFBR_Pathology_Other_Bio_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_BIONUM", StringUtil.LTrim( StringUtil.NToC( AV29TFBR_Pathology_Other_BioNum, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_BIONUM_TO", StringUtil.LTrim( StringUtil.NToC( AV30TFBR_Pathology_Other_BioNum_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_BIONUMUNIT", AV33TFBR_Pathology_Other_BioNumUnit);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL", AV34TFBR_Pathology_Other_BioNumUnit_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_BIOQUAL", AV37TFBR_Pathology_Other_BioQual);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL", AV38TFBR_Pathology_Other_BioQual_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_LOW", StringUtil.LTrim( StringUtil.NToC( AV41TFBR_Pathology_Other_Low, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_LOW_TO", StringUtil.LTrim( StringUtil.NToC( AV42TFBR_Pathology_Other_Low_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_HIGH", StringUtil.LTrim( StringUtil.NToC( AV45TFBR_Pathology_Other_High, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_HIGH_TO", StringUtil.LTrim( StringUtil.NToC( AV46TFBR_Pathology_Other_High_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_ABNIND", AV49TFBR_Pathology_Other_AbnInd);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_OTHER_ABNIND_SEL", AV50TFBR_Pathology_Other_AbnInd_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV54GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV56GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV55GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV52DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV52DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA", AV16BR_Pathology_OtherIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA", AV16BR_Pathology_OtherIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYIDTITLEFILTERDATA", AV20BR_PathologyIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYIDTITLEFILTERDATA", AV20BR_PathologyIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA", AV24BR_Pathology_Other_BioTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA", AV24BR_Pathology_Other_BioTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA", AV28BR_Pathology_Other_BioNumTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA", AV28BR_Pathology_Other_BioNumTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA", AV36BR_Pathology_Other_BioQualTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA", AV36BR_Pathology_Other_BioQualTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA", AV40BR_Pathology_Other_LowTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA", AV40BR_Pathology_Other_LowTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA", AV44BR_Pathology_Other_HighTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA", AV44BR_Pathology_Other_HighTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA", AV48BR_Pathology_Other_AbnIndTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA", AV48BR_Pathology_Other_AbnIndTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV86Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV59IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV61IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Caption", StringUtil.RTrim( Ddo_br_pathology_otherid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Tooltip", StringUtil.RTrim( Ddo_br_pathology_otherid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Cls", StringUtil.RTrim( Ddo_br_pathology_otherid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_otherid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathology_otherid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_otherid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_otherid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_otherid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_otherid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_otherid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_otherid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Filtertype", StringUtil.RTrim( Ddo_br_pathology_otherid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_otherid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_otherid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Sortasc", StringUtil.RTrim( Ddo_br_pathology_otherid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_otherid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_otherid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathology_otherid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Rangefilterto", StringUtil.RTrim( Ddo_br_pathology_otherid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_otherid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Caption", StringUtil.RTrim( Ddo_br_pathologyid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Cls", StringUtil.RTrim( Ddo_br_pathologyid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filtertype", StringUtil.RTrim( Ddo_br_pathologyid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathologyid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Cleanfilter", StringUtil.RTrim( Ddo_br_pathologyid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathologyid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Rangefilterto", StringUtil.RTrim( Ddo_br_pathologyid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bio_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bio_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bio_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_other_bio_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_other_bio_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bio_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bio_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bio_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Filtertype", StringUtil.RTrim( Ddo_br_pathology_other_bio_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_other_bio_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_other_bio_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_other_bio_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bio_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bio_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_other_bio_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_other_bio_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_other_bio_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bio_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filtertype", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Rangefilterto", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Filtertype", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_other_bionumunit_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bioqual_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bioqual_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bioqual_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Filtertype", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_other_bioqual_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bioqual_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_other_bioqual_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Caption", StringUtil.RTrim( Ddo_br_pathology_other_low_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_low_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Cls", StringUtil.RTrim( Ddo_br_pathology_other_low_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_other_low_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathology_other_low_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_low_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_low_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_low_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_low_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_low_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_low_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Filtertype", StringUtil.RTrim( Ddo_br_pathology_other_low_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_other_low_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_low_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_low_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_low_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_other_low_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathology_other_low_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Rangefilterto", StringUtil.RTrim( Ddo_br_pathology_other_low_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_low_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Caption", StringUtil.RTrim( Ddo_br_pathology_other_high_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_high_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Cls", StringUtil.RTrim( Ddo_br_pathology_other_high_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_other_high_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathology_other_high_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_high_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_high_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_high_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_high_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_high_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_high_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Filtertype", StringUtil.RTrim( Ddo_br_pathology_other_high_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_other_high_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_high_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_high_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_high_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_other_high_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathology_other_high_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Rangefilterto", StringUtil.RTrim( Ddo_br_pathology_other_high_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_high_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Caption", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Cls", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Filtertype", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_other_abnind_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_otherid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_otherid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_otherid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bio_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_bio_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_other_bio_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_low_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_low_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_other_low_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_high_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_high_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_other_high_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_otherid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_otherid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_otherid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bio_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_bio_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIO_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_other_bio_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_other_bioqual_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_low_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_low_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_LOW_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_other_low_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_high_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_high_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_HIGH_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_other_high_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_OTHER_ABNIND_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Selectedvalue_get));
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
            WE572( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT572( ) ;
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
         return formatLink("br_pathology_otherww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Pathology_OtherWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 病理学其它信息" ;
      }

      protected void WB570( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_OtherWW.htm");
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV57Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV58Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV60Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV54GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV56GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV55GridPageSize);
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
            ucDdo_br_pathology_otherid.SetProperty("FilterType", Ddo_br_pathology_otherid_Filtertype);
            ucDdo_br_pathology_otherid.SetProperty("FilterIsRange", Ddo_br_pathology_otherid_Filterisrange);
            ucDdo_br_pathology_otherid.SetProperty("IncludeDataList", Ddo_br_pathology_otherid_Includedatalist);
            ucDdo_br_pathology_otherid.SetProperty("SortASC", Ddo_br_pathology_otherid_Sortasc);
            ucDdo_br_pathology_otherid.SetProperty("SortDSC", Ddo_br_pathology_otherid_Sortdsc);
            ucDdo_br_pathology_otherid.SetProperty("CleanFilter", Ddo_br_pathology_otherid_Cleanfilter);
            ucDdo_br_pathology_otherid.SetProperty("RangeFilterFrom", Ddo_br_pathology_otherid_Rangefilterfrom);
            ucDdo_br_pathology_otherid.SetProperty("RangeFilterTo", Ddo_br_pathology_otherid_Rangefilterto);
            ucDdo_br_pathology_otherid.SetProperty("SearchButtonText", Ddo_br_pathology_otherid_Searchbuttontext);
            ucDdo_br_pathology_otherid.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_pathology_otherid.SetProperty("DropDownOptionsData", AV16BR_Pathology_OtherIDTitleFilterData);
            ucDdo_br_pathology_otherid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_otherid_Internalname, "DDO_BR_PATHOLOGY_OTHERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherWW.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid.SetProperty("Caption", Ddo_br_pathologyid_Caption);
            ucDdo_br_pathologyid.SetProperty("Tooltip", Ddo_br_pathologyid_Tooltip);
            ucDdo_br_pathologyid.SetProperty("Cls", Ddo_br_pathologyid_Cls);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_Dropdownoptionstype);
            ucDdo_br_pathologyid.SetProperty("IncludeSortASC", Ddo_br_pathologyid_Includesortasc);
            ucDdo_br_pathologyid.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_Includesortdsc);
            ucDdo_br_pathologyid.SetProperty("IncludeFilter", Ddo_br_pathologyid_Includefilter);
            ucDdo_br_pathologyid.SetProperty("FilterType", Ddo_br_pathologyid_Filtertype);
            ucDdo_br_pathologyid.SetProperty("FilterIsRange", Ddo_br_pathologyid_Filterisrange);
            ucDdo_br_pathologyid.SetProperty("IncludeDataList", Ddo_br_pathologyid_Includedatalist);
            ucDdo_br_pathologyid.SetProperty("SortASC", Ddo_br_pathologyid_Sortasc);
            ucDdo_br_pathologyid.SetProperty("SortDSC", Ddo_br_pathologyid_Sortdsc);
            ucDdo_br_pathologyid.SetProperty("CleanFilter", Ddo_br_pathologyid_Cleanfilter);
            ucDdo_br_pathologyid.SetProperty("RangeFilterFrom", Ddo_br_pathologyid_Rangefilterfrom);
            ucDdo_br_pathologyid.SetProperty("RangeFilterTo", Ddo_br_pathologyid_Rangefilterto);
            ucDdo_br_pathologyid.SetProperty("SearchButtonText", Ddo_br_pathologyid_Searchbuttontext);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsData", AV20BR_PathologyIDTitleFilterData);
            ucDdo_br_pathologyid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_Internalname, "DDO_BR_PATHOLOGYIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, AV23ddo_BR_PathologyIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_bio.SetProperty("Caption", Ddo_br_pathology_other_bio_Caption);
            ucDdo_br_pathology_other_bio.SetProperty("Tooltip", Ddo_br_pathology_other_bio_Tooltip);
            ucDdo_br_pathology_other_bio.SetProperty("Cls", Ddo_br_pathology_other_bio_Cls);
            ucDdo_br_pathology_other_bio.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bio_Dropdownoptionstype);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bio_Includesortasc);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bio_Includesortdsc);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeFilter", Ddo_br_pathology_other_bio_Includefilter);
            ucDdo_br_pathology_other_bio.SetProperty("FilterType", Ddo_br_pathology_other_bio_Filtertype);
            ucDdo_br_pathology_other_bio.SetProperty("FilterIsRange", Ddo_br_pathology_other_bio_Filterisrange);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeDataList", Ddo_br_pathology_other_bio_Includedatalist);
            ucDdo_br_pathology_other_bio.SetProperty("DataListType", Ddo_br_pathology_other_bio_Datalisttype);
            ucDdo_br_pathology_other_bio.SetProperty("DataListProc", Ddo_br_pathology_other_bio_Datalistproc);
            ucDdo_br_pathology_other_bio.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_other_bio_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_other_bio.SetProperty("SortASC", Ddo_br_pathology_other_bio_Sortasc);
            ucDdo_br_pathology_other_bio.SetProperty("SortDSC", Ddo_br_pathology_other_bio_Sortdsc);
            ucDdo_br_pathology_other_bio.SetProperty("LoadingData", Ddo_br_pathology_other_bio_Loadingdata);
            ucDdo_br_pathology_other_bio.SetProperty("CleanFilter", Ddo_br_pathology_other_bio_Cleanfilter);
            ucDdo_br_pathology_other_bio.SetProperty("NoResultsFound", Ddo_br_pathology_other_bio_Noresultsfound);
            ucDdo_br_pathology_other_bio.SetProperty("SearchButtonText", Ddo_br_pathology_other_bio_Searchbuttontext);
            ucDdo_br_pathology_other_bio.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bio.SetProperty("DropDownOptionsData", AV24BR_Pathology_Other_BioTitleFilterData);
            ucDdo_br_pathology_other_bio.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bio_Internalname, "DDO_BR_PATHOLOGY_OTHER_BIOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname, AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_bionum.SetProperty("Caption", Ddo_br_pathology_other_bionum_Caption);
            ucDdo_br_pathology_other_bionum.SetProperty("Tooltip", Ddo_br_pathology_other_bionum_Tooltip);
            ucDdo_br_pathology_other_bionum.SetProperty("Cls", Ddo_br_pathology_other_bionum_Cls);
            ucDdo_br_pathology_other_bionum.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bionum_Dropdownoptionstype);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bionum_Includesortasc);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bionum_Includesortdsc);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeFilter", Ddo_br_pathology_other_bionum_Includefilter);
            ucDdo_br_pathology_other_bionum.SetProperty("FilterType", Ddo_br_pathology_other_bionum_Filtertype);
            ucDdo_br_pathology_other_bionum.SetProperty("FilterIsRange", Ddo_br_pathology_other_bionum_Filterisrange);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeDataList", Ddo_br_pathology_other_bionum_Includedatalist);
            ucDdo_br_pathology_other_bionum.SetProperty("SortASC", Ddo_br_pathology_other_bionum_Sortasc);
            ucDdo_br_pathology_other_bionum.SetProperty("SortDSC", Ddo_br_pathology_other_bionum_Sortdsc);
            ucDdo_br_pathology_other_bionum.SetProperty("CleanFilter", Ddo_br_pathology_other_bionum_Cleanfilter);
            ucDdo_br_pathology_other_bionum.SetProperty("RangeFilterFrom", Ddo_br_pathology_other_bionum_Rangefilterfrom);
            ucDdo_br_pathology_other_bionum.SetProperty("RangeFilterTo", Ddo_br_pathology_other_bionum_Rangefilterto);
            ucDdo_br_pathology_other_bionum.SetProperty("SearchButtonText", Ddo_br_pathology_other_bionum_Searchbuttontext);
            ucDdo_br_pathology_other_bionum.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bionum.SetProperty("DropDownOptionsData", AV28BR_Pathology_Other_BioNumTitleFilterData);
            ucDdo_br_pathology_other_bionum.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bionum_Internalname, "DDO_BR_PATHOLOGY_OTHER_BIONUMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname, AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", 0, edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_bionumunit.SetProperty("Caption", Ddo_br_pathology_other_bionumunit_Caption);
            ucDdo_br_pathology_other_bionumunit.SetProperty("Tooltip", Ddo_br_pathology_other_bionumunit_Tooltip);
            ucDdo_br_pathology_other_bionumunit.SetProperty("Cls", Ddo_br_pathology_other_bionumunit_Cls);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bionumunit_Dropdownoptionstype);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bionumunit_Includesortasc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bionumunit_Includesortdsc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeFilter", Ddo_br_pathology_other_bionumunit_Includefilter);
            ucDdo_br_pathology_other_bionumunit.SetProperty("FilterType", Ddo_br_pathology_other_bionumunit_Filtertype);
            ucDdo_br_pathology_other_bionumunit.SetProperty("FilterIsRange", Ddo_br_pathology_other_bionumunit_Filterisrange);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeDataList", Ddo_br_pathology_other_bionumunit_Includedatalist);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DataListType", Ddo_br_pathology_other_bionumunit_Datalisttype);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DataListProc", Ddo_br_pathology_other_bionumunit_Datalistproc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_other_bionumunit_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_other_bionumunit.SetProperty("SortASC", Ddo_br_pathology_other_bionumunit_Sortasc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("SortDSC", Ddo_br_pathology_other_bionumunit_Sortdsc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("LoadingData", Ddo_br_pathology_other_bionumunit_Loadingdata);
            ucDdo_br_pathology_other_bionumunit.SetProperty("CleanFilter", Ddo_br_pathology_other_bionumunit_Cleanfilter);
            ucDdo_br_pathology_other_bionumunit.SetProperty("NoResultsFound", Ddo_br_pathology_other_bionumunit_Noresultsfound);
            ucDdo_br_pathology_other_bionumunit.SetProperty("SearchButtonText", Ddo_br_pathology_other_bionumunit_Searchbuttontext);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DropDownOptionsData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
            ucDdo_br_pathology_other_bionumunit.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bionumunit_Internalname, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNITContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname, AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", 0, edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_bioqual.SetProperty("Caption", Ddo_br_pathology_other_bioqual_Caption);
            ucDdo_br_pathology_other_bioqual.SetProperty("Tooltip", Ddo_br_pathology_other_bioqual_Tooltip);
            ucDdo_br_pathology_other_bioqual.SetProperty("Cls", Ddo_br_pathology_other_bioqual_Cls);
            ucDdo_br_pathology_other_bioqual.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bioqual_Dropdownoptionstype);
            ucDdo_br_pathology_other_bioqual.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bioqual_Includesortasc);
            ucDdo_br_pathology_other_bioqual.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bioqual_Includesortdsc);
            ucDdo_br_pathology_other_bioqual.SetProperty("IncludeFilter", Ddo_br_pathology_other_bioqual_Includefilter);
            ucDdo_br_pathology_other_bioqual.SetProperty("FilterType", Ddo_br_pathology_other_bioqual_Filtertype);
            ucDdo_br_pathology_other_bioqual.SetProperty("FilterIsRange", Ddo_br_pathology_other_bioqual_Filterisrange);
            ucDdo_br_pathology_other_bioqual.SetProperty("IncludeDataList", Ddo_br_pathology_other_bioqual_Includedatalist);
            ucDdo_br_pathology_other_bioqual.SetProperty("DataListType", Ddo_br_pathology_other_bioqual_Datalisttype);
            ucDdo_br_pathology_other_bioqual.SetProperty("DataListProc", Ddo_br_pathology_other_bioqual_Datalistproc);
            ucDdo_br_pathology_other_bioqual.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_other_bioqual_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_other_bioqual.SetProperty("SortASC", Ddo_br_pathology_other_bioqual_Sortasc);
            ucDdo_br_pathology_other_bioqual.SetProperty("SortDSC", Ddo_br_pathology_other_bioqual_Sortdsc);
            ucDdo_br_pathology_other_bioqual.SetProperty("LoadingData", Ddo_br_pathology_other_bioqual_Loadingdata);
            ucDdo_br_pathology_other_bioqual.SetProperty("CleanFilter", Ddo_br_pathology_other_bioqual_Cleanfilter);
            ucDdo_br_pathology_other_bioqual.SetProperty("NoResultsFound", Ddo_br_pathology_other_bioqual_Noresultsfound);
            ucDdo_br_pathology_other_bioqual.SetProperty("SearchButtonText", Ddo_br_pathology_other_bioqual_Searchbuttontext);
            ucDdo_br_pathology_other_bioqual.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bioqual.SetProperty("DropDownOptionsData", AV36BR_Pathology_Other_BioQualTitleFilterData);
            ucDdo_br_pathology_other_bioqual.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bioqual_Internalname, "DDO_BR_PATHOLOGY_OTHER_BIOQUALContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Internalname, AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", 0, edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_low.SetProperty("Caption", Ddo_br_pathology_other_low_Caption);
            ucDdo_br_pathology_other_low.SetProperty("Tooltip", Ddo_br_pathology_other_low_Tooltip);
            ucDdo_br_pathology_other_low.SetProperty("Cls", Ddo_br_pathology_other_low_Cls);
            ucDdo_br_pathology_other_low.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_low_Dropdownoptionstype);
            ucDdo_br_pathology_other_low.SetProperty("IncludeSortASC", Ddo_br_pathology_other_low_Includesortasc);
            ucDdo_br_pathology_other_low.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_low_Includesortdsc);
            ucDdo_br_pathology_other_low.SetProperty("IncludeFilter", Ddo_br_pathology_other_low_Includefilter);
            ucDdo_br_pathology_other_low.SetProperty("FilterType", Ddo_br_pathology_other_low_Filtertype);
            ucDdo_br_pathology_other_low.SetProperty("FilterIsRange", Ddo_br_pathology_other_low_Filterisrange);
            ucDdo_br_pathology_other_low.SetProperty("IncludeDataList", Ddo_br_pathology_other_low_Includedatalist);
            ucDdo_br_pathology_other_low.SetProperty("SortASC", Ddo_br_pathology_other_low_Sortasc);
            ucDdo_br_pathology_other_low.SetProperty("SortDSC", Ddo_br_pathology_other_low_Sortdsc);
            ucDdo_br_pathology_other_low.SetProperty("CleanFilter", Ddo_br_pathology_other_low_Cleanfilter);
            ucDdo_br_pathology_other_low.SetProperty("RangeFilterFrom", Ddo_br_pathology_other_low_Rangefilterfrom);
            ucDdo_br_pathology_other_low.SetProperty("RangeFilterTo", Ddo_br_pathology_other_low_Rangefilterto);
            ucDdo_br_pathology_other_low.SetProperty("SearchButtonText", Ddo_br_pathology_other_low_Searchbuttontext);
            ucDdo_br_pathology_other_low.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_low.SetProperty("DropDownOptionsData", AV40BR_Pathology_Other_LowTitleFilterData);
            ucDdo_br_pathology_other_low.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_low_Internalname, "DDO_BR_PATHOLOGY_OTHER_LOWContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Internalname, AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", 0, edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_high.SetProperty("Caption", Ddo_br_pathology_other_high_Caption);
            ucDdo_br_pathology_other_high.SetProperty("Tooltip", Ddo_br_pathology_other_high_Tooltip);
            ucDdo_br_pathology_other_high.SetProperty("Cls", Ddo_br_pathology_other_high_Cls);
            ucDdo_br_pathology_other_high.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_high_Dropdownoptionstype);
            ucDdo_br_pathology_other_high.SetProperty("IncludeSortASC", Ddo_br_pathology_other_high_Includesortasc);
            ucDdo_br_pathology_other_high.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_high_Includesortdsc);
            ucDdo_br_pathology_other_high.SetProperty("IncludeFilter", Ddo_br_pathology_other_high_Includefilter);
            ucDdo_br_pathology_other_high.SetProperty("FilterType", Ddo_br_pathology_other_high_Filtertype);
            ucDdo_br_pathology_other_high.SetProperty("FilterIsRange", Ddo_br_pathology_other_high_Filterisrange);
            ucDdo_br_pathology_other_high.SetProperty("IncludeDataList", Ddo_br_pathology_other_high_Includedatalist);
            ucDdo_br_pathology_other_high.SetProperty("SortASC", Ddo_br_pathology_other_high_Sortasc);
            ucDdo_br_pathology_other_high.SetProperty("SortDSC", Ddo_br_pathology_other_high_Sortdsc);
            ucDdo_br_pathology_other_high.SetProperty("CleanFilter", Ddo_br_pathology_other_high_Cleanfilter);
            ucDdo_br_pathology_other_high.SetProperty("RangeFilterFrom", Ddo_br_pathology_other_high_Rangefilterfrom);
            ucDdo_br_pathology_other_high.SetProperty("RangeFilterTo", Ddo_br_pathology_other_high_Rangefilterto);
            ucDdo_br_pathology_other_high.SetProperty("SearchButtonText", Ddo_br_pathology_other_high_Searchbuttontext);
            ucDdo_br_pathology_other_high.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_high.SetProperty("DropDownOptionsData", AV44BR_Pathology_Other_HighTitleFilterData);
            ucDdo_br_pathology_other_high.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_high_Internalname, "DDO_BR_PATHOLOGY_OTHER_HIGHContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Internalname, AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", 0, edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_abnind.SetProperty("Caption", Ddo_br_pathology_other_abnind_Caption);
            ucDdo_br_pathology_other_abnind.SetProperty("Tooltip", Ddo_br_pathology_other_abnind_Tooltip);
            ucDdo_br_pathology_other_abnind.SetProperty("Cls", Ddo_br_pathology_other_abnind_Cls);
            ucDdo_br_pathology_other_abnind.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_abnind_Dropdownoptionstype);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeSortASC", Ddo_br_pathology_other_abnind_Includesortasc);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_abnind_Includesortdsc);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeFilter", Ddo_br_pathology_other_abnind_Includefilter);
            ucDdo_br_pathology_other_abnind.SetProperty("FilterType", Ddo_br_pathology_other_abnind_Filtertype);
            ucDdo_br_pathology_other_abnind.SetProperty("FilterIsRange", Ddo_br_pathology_other_abnind_Filterisrange);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeDataList", Ddo_br_pathology_other_abnind_Includedatalist);
            ucDdo_br_pathology_other_abnind.SetProperty("DataListType", Ddo_br_pathology_other_abnind_Datalisttype);
            ucDdo_br_pathology_other_abnind.SetProperty("DataListProc", Ddo_br_pathology_other_abnind_Datalistproc);
            ucDdo_br_pathology_other_abnind.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_other_abnind_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_other_abnind.SetProperty("SortASC", Ddo_br_pathology_other_abnind_Sortasc);
            ucDdo_br_pathology_other_abnind.SetProperty("SortDSC", Ddo_br_pathology_other_abnind_Sortdsc);
            ucDdo_br_pathology_other_abnind.SetProperty("LoadingData", Ddo_br_pathology_other_abnind_Loadingdata);
            ucDdo_br_pathology_other_abnind.SetProperty("CleanFilter", Ddo_br_pathology_other_abnind_Cleanfilter);
            ucDdo_br_pathology_other_abnind.SetProperty("NoResultsFound", Ddo_br_pathology_other_abnind_Noresultsfound);
            ucDdo_br_pathology_other_abnind.SetProperty("SearchButtonText", Ddo_br_pathology_other_abnind_Searchbuttontext);
            ucDdo_br_pathology_other_abnind.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_abnind.SetProperty("DropDownOptionsData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
            ucDdo_br_pathology_other_abnind.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_abnind_Internalname, "DDO_BR_PATHOLOGY_OTHER_ABNINDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname, AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", 0, edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_OtherWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_otherid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Pathology_OtherID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_otherid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_otherid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_otherid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Pathology_OtherID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_Pathology_OtherID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_otherid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_otherid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_PathologyID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_PathologyID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_PathologyID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_PathologyID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_bio_Internalname, AV25TFBR_Pathology_Other_Bio, StringUtil.RTrim( context.localUtil.Format( AV25TFBR_Pathology_Other_Bio, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_bio_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_bio_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_bio_sel_Internalname, AV26TFBR_Pathology_Other_Bio_Sel, StringUtil.RTrim( context.localUtil.Format( AV26TFBR_Pathology_Other_Bio_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_bio_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_bio_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_bionum_Internalname, StringUtil.LTrim( StringUtil.NToC( AV29TFBR_Pathology_Other_BioNum, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV29TFBR_Pathology_Other_BioNum, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_bionum_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_bionum_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_bionum_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV30TFBR_Pathology_Other_BioNum_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV30TFBR_Pathology_Other_BioNum_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_bionum_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_bionum_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_bionumunit_Internalname, AV33TFBR_Pathology_Other_BioNumUnit, StringUtil.RTrim( context.localUtil.Format( AV33TFBR_Pathology_Other_BioNumUnit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_bionumunit_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_bionumunit_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_bionumunit_sel_Internalname, AV34TFBR_Pathology_Other_BioNumUnit_Sel, StringUtil.RTrim( context.localUtil.Format( AV34TFBR_Pathology_Other_BioNumUnit_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_bionumunit_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_bionumunit_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_bioqual_Internalname, AV37TFBR_Pathology_Other_BioQual, StringUtil.RTrim( context.localUtil.Format( AV37TFBR_Pathology_Other_BioQual, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_bioqual_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_bioqual_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_bioqual_sel_Internalname, AV38TFBR_Pathology_Other_BioQual_Sel, StringUtil.RTrim( context.localUtil.Format( AV38TFBR_Pathology_Other_BioQual_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_bioqual_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_bioqual_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_low_Internalname, StringUtil.LTrim( StringUtil.NToC( AV41TFBR_Pathology_Other_Low, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV41TFBR_Pathology_Other_Low, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_low_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_low_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_low_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV42TFBR_Pathology_Other_Low_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV42TFBR_Pathology_Other_Low_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_low_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_low_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_high_Internalname, StringUtil.LTrim( StringUtil.NToC( AV45TFBR_Pathology_Other_High, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV45TFBR_Pathology_Other_High, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_high_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_high_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_high_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV46TFBR_Pathology_Other_High_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV46TFBR_Pathology_Other_High_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,87);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_high_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_high_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_abnind_Internalname, AV49TFBR_Pathology_Other_AbnInd, StringUtil.RTrim( context.localUtil.Format( AV49TFBR_Pathology_Other_AbnInd, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_abnind_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_abnind_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_other_abnind_sel_Internalname, AV50TFBR_Pathology_Other_AbnInd_Sel, StringUtil.RTrim( context.localUtil.Format( AV50TFBR_Pathology_Other_AbnInd_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_other_abnind_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_other_abnind_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherWW.htm");
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

      protected void START572( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 病理学其它信息", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP570( ) ;
      }

      protected void WS572( )
      {
         START572( ) ;
         EVT572( ) ;
      }

      protected void EVT572( )
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
                              E11572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIONUM.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E17572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIOQUAL.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_LOW.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E19572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_HIGH.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E20572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_ABNIND.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E21572 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E22572 ();
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
                              AV57Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV57Display)) ? AV83Display_GXI : context.convertURL( context.PathToRelativeUrl( AV57Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV57Display), true);
                              AV58Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV58Update)) ? AV84Update_GXI : context.convertURL( context.PathToRelativeUrl( AV58Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV58Update), true);
                              AV60Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV60Delete)) ? AV85Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV60Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV60Delete), true);
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
                                    E23572 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E24572 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E25572 ();
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
                                       /* Set Refresh If Tfbr_pathology_otherid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHERID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Pathology_OtherID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_otherid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHERID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Pathology_OtherID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID"), ".", ",") != Convert.ToDecimal( AV21TFBR_PathologyID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_PathologyID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_bio Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIO"), AV25TFBR_Pathology_Other_Bio) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_bio_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIO_SEL"), AV26TFBR_Pathology_Other_Bio_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_bionum Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIONUM"), ".", ",") != AV29TFBR_Pathology_Other_BioNum )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_bionum_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIONUM_TO"), ".", ",") != AV30TFBR_Pathology_Other_BioNum_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_bionumunit Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIONUMUNIT"), AV33TFBR_Pathology_Other_BioNumUnit) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_bionumunit_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL"), AV34TFBR_Pathology_Other_BioNumUnit_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_bioqual Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIOQUAL"), AV37TFBR_Pathology_Other_BioQual) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_bioqual_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL"), AV38TFBR_Pathology_Other_BioQual_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_low Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_LOW"), ".", ",") != AV41TFBR_Pathology_Other_Low )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_low_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_LOW_TO"), ".", ",") != AV42TFBR_Pathology_Other_Low_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_high Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_HIGH"), ".", ",") != AV45TFBR_Pathology_Other_High )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_high_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_HIGH_TO"), ".", ",") != AV46TFBR_Pathology_Other_High_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_abnind Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_ABNIND"), AV49TFBR_Pathology_Other_AbnInd) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_other_abnind_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_ABNIND_SEL"), AV50TFBR_Pathology_Other_AbnInd_Sel) != 0 )
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

      protected void WE572( )
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

      protected void PA572( )
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
                                       long AV17TFBR_Pathology_OtherID ,
                                       long AV18TFBR_Pathology_OtherID_To ,
                                       long AV21TFBR_PathologyID ,
                                       long AV22TFBR_PathologyID_To ,
                                       String AV25TFBR_Pathology_Other_Bio ,
                                       String AV26TFBR_Pathology_Other_Bio_Sel ,
                                       decimal AV29TFBR_Pathology_Other_BioNum ,
                                       decimal AV30TFBR_Pathology_Other_BioNum_To ,
                                       String AV33TFBR_Pathology_Other_BioNumUnit ,
                                       String AV34TFBR_Pathology_Other_BioNumUnit_Sel ,
                                       String AV37TFBR_Pathology_Other_BioQual ,
                                       String AV38TFBR_Pathology_Other_BioQual_Sel ,
                                       decimal AV41TFBR_Pathology_Other_Low ,
                                       decimal AV42TFBR_Pathology_Other_Low_To ,
                                       decimal AV45TFBR_Pathology_Other_High ,
                                       decimal AV46TFBR_Pathology_Other_High_To ,
                                       String AV49TFBR_Pathology_Other_AbnInd ,
                                       String AV50TFBR_Pathology_Other_AbnInd_Sel ,
                                       String AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_PathologyIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace ,
                                       String AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace ,
                                       String AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace ,
                                       String AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace ,
                                       String AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace ,
                                       String AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace ,
                                       String AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace ,
                                       String AV86Pgmname ,
                                       bool AV59IsAuthorized_Update ,
                                       bool AV61IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF572( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_OTHERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_OTHERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")));
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
         RF572( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV86Pgmname = "BR_Pathology_OtherWW";
         context.Gx_err = 0;
      }

      protected void RF572( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E24572 ();
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
                                                 AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                                 AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                                 AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                                 AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                                 AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                                 AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                                 AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                                 AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                                 AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                                 AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                                 AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                                 AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                                 AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                                 AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                                 AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                                 AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                                 AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                                 AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                                 A288BR_Pathology_OtherID ,
                                                 A226BR_PathologyID ,
                                                 A289BR_Pathology_Other_Bio ,
                                                 A290BR_Pathology_Other_BioNum ,
                                                 A291BR_Pathology_Other_BioNumUnit ,
                                                 A292BR_Pathology_Other_BioQual ,
                                                 A293BR_Pathology_Other_Low ,
                                                 A294BR_Pathology_Other_High ,
                                                 A295BR_Pathology_Other_AbnInd ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL,
                                                 TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = StringUtil.Concat( StringUtil.RTrim( AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio), "%", "");
            lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = StringUtil.Concat( StringUtil.RTrim( AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit), "%", "");
            lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = StringUtil.Concat( StringUtil.RTrim( AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual), "%", "");
            lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = StringUtil.Concat( StringUtil.RTrim( AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind), "%", "");
            /* Using cursor H00572 */
            pr_default.execute(0, new Object[] {AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid, AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to, AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid, AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to, lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio, AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel, AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum, AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to, lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit, AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel, lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual, AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel, AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low, AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to, AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high, AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to, lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind, AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A295BR_Pathology_Other_AbnInd = H00572_A295BR_Pathology_Other_AbnInd[0];
               n295BR_Pathology_Other_AbnInd = H00572_n295BR_Pathology_Other_AbnInd[0];
               A294BR_Pathology_Other_High = H00572_A294BR_Pathology_Other_High[0];
               n294BR_Pathology_Other_High = H00572_n294BR_Pathology_Other_High[0];
               A293BR_Pathology_Other_Low = H00572_A293BR_Pathology_Other_Low[0];
               n293BR_Pathology_Other_Low = H00572_n293BR_Pathology_Other_Low[0];
               A292BR_Pathology_Other_BioQual = H00572_A292BR_Pathology_Other_BioQual[0];
               n292BR_Pathology_Other_BioQual = H00572_n292BR_Pathology_Other_BioQual[0];
               A291BR_Pathology_Other_BioNumUnit = H00572_A291BR_Pathology_Other_BioNumUnit[0];
               n291BR_Pathology_Other_BioNumUnit = H00572_n291BR_Pathology_Other_BioNumUnit[0];
               A290BR_Pathology_Other_BioNum = H00572_A290BR_Pathology_Other_BioNum[0];
               n290BR_Pathology_Other_BioNum = H00572_n290BR_Pathology_Other_BioNum[0];
               A289BR_Pathology_Other_Bio = H00572_A289BR_Pathology_Other_Bio[0];
               n289BR_Pathology_Other_Bio = H00572_n289BR_Pathology_Other_Bio[0];
               A226BR_PathologyID = H00572_A226BR_PathologyID[0];
               n226BR_PathologyID = H00572_n226BR_PathologyID[0];
               A288BR_Pathology_OtherID = H00572_A288BR_Pathology_OtherID[0];
               E25572 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB570( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes572( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_OTHERID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV17TFBR_Pathology_OtherID;
         AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV18TFBR_Pathology_OtherID_To;
         AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV25TFBR_Pathology_Other_Bio;
         AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV26TFBR_Pathology_Other_Bio_Sel;
         AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV29TFBR_Pathology_Other_BioNum;
         AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV30TFBR_Pathology_Other_BioNum_To;
         AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV33TFBR_Pathology_Other_BioNumUnit;
         AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV34TFBR_Pathology_Other_BioNumUnit_Sel;
         AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV37TFBR_Pathology_Other_BioQual;
         AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV38TFBR_Pathology_Other_BioQual_Sel;
         AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV41TFBR_Pathology_Other_Low;
         AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV42TFBR_Pathology_Other_Low_To;
         AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV45TFBR_Pathology_Other_High;
         AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV46TFBR_Pathology_Other_High_To;
         AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV49TFBR_Pathology_Other_AbnInd;
         AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV50TFBR_Pathology_Other_AbnInd_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                              AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                              AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                              AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                              AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                              AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                              AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                              AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                              AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                              AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                              AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                              AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                              AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                              AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                              AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                              AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                              AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                              AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                              A288BR_Pathology_OtherID ,
                                              A226BR_PathologyID ,
                                              A289BR_Pathology_Other_Bio ,
                                              A290BR_Pathology_Other_BioNum ,
                                              A291BR_Pathology_Other_BioNumUnit ,
                                              A292BR_Pathology_Other_BioQual ,
                                              A293BR_Pathology_Other_Low ,
                                              A294BR_Pathology_Other_High ,
                                              A295BR_Pathology_Other_AbnInd ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL,
                                              TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = StringUtil.Concat( StringUtil.RTrim( AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio), "%", "");
         lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = StringUtil.Concat( StringUtil.RTrim( AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit), "%", "");
         lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = StringUtil.Concat( StringUtil.RTrim( AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual), "%", "");
         lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = StringUtil.Concat( StringUtil.RTrim( AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind), "%", "");
         /* Using cursor H00573 */
         pr_default.execute(1, new Object[] {AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid, AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to, AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid, AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to, lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio, AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel, AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum, AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to, lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit, AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel, lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual, AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel, AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low, AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to, AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high, AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to, lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind, AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel});
         GRID_nRecordCount = H00573_AGRID_nRecordCount[0];
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
         AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV17TFBR_Pathology_OtherID;
         AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV18TFBR_Pathology_OtherID_To;
         AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV25TFBR_Pathology_Other_Bio;
         AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV26TFBR_Pathology_Other_Bio_Sel;
         AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV29TFBR_Pathology_Other_BioNum;
         AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV30TFBR_Pathology_Other_BioNum_To;
         AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV33TFBR_Pathology_Other_BioNumUnit;
         AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV34TFBR_Pathology_Other_BioNumUnit_Sel;
         AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV37TFBR_Pathology_Other_BioQual;
         AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV38TFBR_Pathology_Other_BioQual_Sel;
         AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV41TFBR_Pathology_Other_Low;
         AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV42TFBR_Pathology_Other_Low_To;
         AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV45TFBR_Pathology_Other_High;
         AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV46TFBR_Pathology_Other_High_To;
         AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV49TFBR_Pathology_Other_AbnInd;
         AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV50TFBR_Pathology_Other_AbnInd_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_OtherID, AV18TFBR_Pathology_OtherID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Other_Bio, AV26TFBR_Pathology_Other_Bio_Sel, AV29TFBR_Pathology_Other_BioNum, AV30TFBR_Pathology_Other_BioNum_To, AV33TFBR_Pathology_Other_BioNumUnit, AV34TFBR_Pathology_Other_BioNumUnit_Sel, AV37TFBR_Pathology_Other_BioQual, AV38TFBR_Pathology_Other_BioQual_Sel, AV41TFBR_Pathology_Other_Low, AV42TFBR_Pathology_Other_Low_To, AV45TFBR_Pathology_Other_High, AV46TFBR_Pathology_Other_High_To, AV49TFBR_Pathology_Other_AbnInd, AV50TFBR_Pathology_Other_AbnInd_Sel, AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV86Pgmname, AV59IsAuthorized_Update, AV61IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV17TFBR_Pathology_OtherID;
         AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV18TFBR_Pathology_OtherID_To;
         AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV25TFBR_Pathology_Other_Bio;
         AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV26TFBR_Pathology_Other_Bio_Sel;
         AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV29TFBR_Pathology_Other_BioNum;
         AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV30TFBR_Pathology_Other_BioNum_To;
         AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV33TFBR_Pathology_Other_BioNumUnit;
         AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV34TFBR_Pathology_Other_BioNumUnit_Sel;
         AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV37TFBR_Pathology_Other_BioQual;
         AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV38TFBR_Pathology_Other_BioQual_Sel;
         AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV41TFBR_Pathology_Other_Low;
         AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV42TFBR_Pathology_Other_Low_To;
         AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV45TFBR_Pathology_Other_High;
         AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV46TFBR_Pathology_Other_High_To;
         AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV49TFBR_Pathology_Other_AbnInd;
         AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV50TFBR_Pathology_Other_AbnInd_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_OtherID, AV18TFBR_Pathology_OtherID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Other_Bio, AV26TFBR_Pathology_Other_Bio_Sel, AV29TFBR_Pathology_Other_BioNum, AV30TFBR_Pathology_Other_BioNum_To, AV33TFBR_Pathology_Other_BioNumUnit, AV34TFBR_Pathology_Other_BioNumUnit_Sel, AV37TFBR_Pathology_Other_BioQual, AV38TFBR_Pathology_Other_BioQual_Sel, AV41TFBR_Pathology_Other_Low, AV42TFBR_Pathology_Other_Low_To, AV45TFBR_Pathology_Other_High, AV46TFBR_Pathology_Other_High_To, AV49TFBR_Pathology_Other_AbnInd, AV50TFBR_Pathology_Other_AbnInd_Sel, AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV86Pgmname, AV59IsAuthorized_Update, AV61IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV17TFBR_Pathology_OtherID;
         AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV18TFBR_Pathology_OtherID_To;
         AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV25TFBR_Pathology_Other_Bio;
         AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV26TFBR_Pathology_Other_Bio_Sel;
         AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV29TFBR_Pathology_Other_BioNum;
         AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV30TFBR_Pathology_Other_BioNum_To;
         AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV33TFBR_Pathology_Other_BioNumUnit;
         AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV34TFBR_Pathology_Other_BioNumUnit_Sel;
         AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV37TFBR_Pathology_Other_BioQual;
         AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV38TFBR_Pathology_Other_BioQual_Sel;
         AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV41TFBR_Pathology_Other_Low;
         AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV42TFBR_Pathology_Other_Low_To;
         AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV45TFBR_Pathology_Other_High;
         AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV46TFBR_Pathology_Other_High_To;
         AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV49TFBR_Pathology_Other_AbnInd;
         AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV50TFBR_Pathology_Other_AbnInd_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_OtherID, AV18TFBR_Pathology_OtherID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Other_Bio, AV26TFBR_Pathology_Other_Bio_Sel, AV29TFBR_Pathology_Other_BioNum, AV30TFBR_Pathology_Other_BioNum_To, AV33TFBR_Pathology_Other_BioNumUnit, AV34TFBR_Pathology_Other_BioNumUnit_Sel, AV37TFBR_Pathology_Other_BioQual, AV38TFBR_Pathology_Other_BioQual_Sel, AV41TFBR_Pathology_Other_Low, AV42TFBR_Pathology_Other_Low_To, AV45TFBR_Pathology_Other_High, AV46TFBR_Pathology_Other_High_To, AV49TFBR_Pathology_Other_AbnInd, AV50TFBR_Pathology_Other_AbnInd_Sel, AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV86Pgmname, AV59IsAuthorized_Update, AV61IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV17TFBR_Pathology_OtherID;
         AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV18TFBR_Pathology_OtherID_To;
         AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV25TFBR_Pathology_Other_Bio;
         AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV26TFBR_Pathology_Other_Bio_Sel;
         AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV29TFBR_Pathology_Other_BioNum;
         AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV30TFBR_Pathology_Other_BioNum_To;
         AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV33TFBR_Pathology_Other_BioNumUnit;
         AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV34TFBR_Pathology_Other_BioNumUnit_Sel;
         AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV37TFBR_Pathology_Other_BioQual;
         AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV38TFBR_Pathology_Other_BioQual_Sel;
         AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV41TFBR_Pathology_Other_Low;
         AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV42TFBR_Pathology_Other_Low_To;
         AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV45TFBR_Pathology_Other_High;
         AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV46TFBR_Pathology_Other_High_To;
         AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV49TFBR_Pathology_Other_AbnInd;
         AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV50TFBR_Pathology_Other_AbnInd_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_OtherID, AV18TFBR_Pathology_OtherID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Other_Bio, AV26TFBR_Pathology_Other_Bio_Sel, AV29TFBR_Pathology_Other_BioNum, AV30TFBR_Pathology_Other_BioNum_To, AV33TFBR_Pathology_Other_BioNumUnit, AV34TFBR_Pathology_Other_BioNumUnit_Sel, AV37TFBR_Pathology_Other_BioQual, AV38TFBR_Pathology_Other_BioQual_Sel, AV41TFBR_Pathology_Other_Low, AV42TFBR_Pathology_Other_Low_To, AV45TFBR_Pathology_Other_High, AV46TFBR_Pathology_Other_High_To, AV49TFBR_Pathology_Other_AbnInd, AV50TFBR_Pathology_Other_AbnInd_Sel, AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV86Pgmname, AV59IsAuthorized_Update, AV61IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV17TFBR_Pathology_OtherID;
         AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV18TFBR_Pathology_OtherID_To;
         AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV25TFBR_Pathology_Other_Bio;
         AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV26TFBR_Pathology_Other_Bio_Sel;
         AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV29TFBR_Pathology_Other_BioNum;
         AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV30TFBR_Pathology_Other_BioNum_To;
         AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV33TFBR_Pathology_Other_BioNumUnit;
         AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV34TFBR_Pathology_Other_BioNumUnit_Sel;
         AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV37TFBR_Pathology_Other_BioQual;
         AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV38TFBR_Pathology_Other_BioQual_Sel;
         AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV41TFBR_Pathology_Other_Low;
         AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV42TFBR_Pathology_Other_Low_To;
         AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV45TFBR_Pathology_Other_High;
         AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV46TFBR_Pathology_Other_High_To;
         AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV49TFBR_Pathology_Other_AbnInd;
         AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV50TFBR_Pathology_Other_AbnInd_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_OtherID, AV18TFBR_Pathology_OtherID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Other_Bio, AV26TFBR_Pathology_Other_Bio_Sel, AV29TFBR_Pathology_Other_BioNum, AV30TFBR_Pathology_Other_BioNum_To, AV33TFBR_Pathology_Other_BioNumUnit, AV34TFBR_Pathology_Other_BioNumUnit_Sel, AV37TFBR_Pathology_Other_BioQual, AV38TFBR_Pathology_Other_BioQual_Sel, AV41TFBR_Pathology_Other_Low, AV42TFBR_Pathology_Other_Low_To, AV45TFBR_Pathology_Other_High, AV46TFBR_Pathology_Other_High_To, AV49TFBR_Pathology_Other_AbnInd, AV50TFBR_Pathology_Other_AbnInd_Sel, AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace, AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace, AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV86Pgmname, AV59IsAuthorized_Update, AV61IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP570( )
      {
         /* Before Start, stand alone formulas. */
         AV86Pgmname = "BR_Pathology_OtherWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E23572 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV52DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA"), AV16BR_Pathology_OtherIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYIDTITLEFILTERDATA"), AV20BR_PathologyIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA"), AV24BR_Pathology_Other_BioTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA"), AV28BR_Pathology_Other_BioNumTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA"), AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA"), AV36BR_Pathology_Other_BioQualTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA"), AV40BR_Pathology_Other_LowTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA"), AV44BR_Pathology_Other_HighTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA"), AV48BR_Pathology_Other_AbnIndTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace", AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace);
            AV23ddo_BR_PathologyIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_PathologyIDTitleControlIdToReplace", AV23ddo_BR_PathologyIDTitleControlIdToReplace);
            AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace", AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace);
            AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace", AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace);
            AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace", AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace);
            AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace", AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace);
            AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace", AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace);
            AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace", AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace);
            AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace", AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_otherid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_otherid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_OTHERID");
               GX_FocusControl = edtavTfbr_pathology_otherid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_Pathology_OtherID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_OtherID), 18, 0)));
            }
            else
            {
               AV17TFBR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathology_otherid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_OtherID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_otherid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_otherid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_OTHERID_TO");
               GX_FocusControl = edtavTfbr_pathology_otherid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_Pathology_OtherID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_OtherID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_OtherID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_Pathology_OtherID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathology_otherid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_OtherID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_OtherID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGYID");
               GX_FocusControl = edtavTfbr_pathologyid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_PathologyID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0)));
            }
            else
            {
               AV21TFBR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGYID_TO");
               GX_FocusControl = edtavTfbr_pathologyid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_PathologyID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_PathologyID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0)));
            }
            AV25TFBR_Pathology_Other_Bio = cgiGet( edtavTfbr_pathology_other_bio_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Pathology_Other_Bio", AV25TFBR_Pathology_Other_Bio);
            AV26TFBR_Pathology_Other_Bio_Sel = cgiGet( edtavTfbr_pathology_other_bio_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Pathology_Other_Bio_Sel", AV26TFBR_Pathology_Other_Bio_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_bionum_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_bionum_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_OTHER_BIONUM");
               GX_FocusControl = edtavTfbr_pathology_other_bionum_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29TFBR_Pathology_Other_BioNum = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Pathology_Other_BioNum, 15, 5)));
            }
            else
            {
               AV29TFBR_Pathology_Other_BioNum = context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_bionum_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Pathology_Other_BioNum, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_bionum_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_bionum_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_OTHER_BIONUM_TO");
               GX_FocusControl = edtavTfbr_pathology_other_bionum_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV30TFBR_Pathology_Other_BioNum_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Pathology_Other_BioNum_To", StringUtil.LTrim( StringUtil.Str( AV30TFBR_Pathology_Other_BioNum_To, 15, 5)));
            }
            else
            {
               AV30TFBR_Pathology_Other_BioNum_To = context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_bionum_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Pathology_Other_BioNum_To", StringUtil.LTrim( StringUtil.Str( AV30TFBR_Pathology_Other_BioNum_To, 15, 5)));
            }
            AV33TFBR_Pathology_Other_BioNumUnit = cgiGet( edtavTfbr_pathology_other_bionumunit_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Pathology_Other_BioNumUnit", AV33TFBR_Pathology_Other_BioNumUnit);
            AV34TFBR_Pathology_Other_BioNumUnit_Sel = cgiGet( edtavTfbr_pathology_other_bionumunit_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Pathology_Other_BioNumUnit_Sel", AV34TFBR_Pathology_Other_BioNumUnit_Sel);
            AV37TFBR_Pathology_Other_BioQual = cgiGet( edtavTfbr_pathology_other_bioqual_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Pathology_Other_BioQual", AV37TFBR_Pathology_Other_BioQual);
            AV38TFBR_Pathology_Other_BioQual_Sel = cgiGet( edtavTfbr_pathology_other_bioqual_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Pathology_Other_BioQual_Sel", AV38TFBR_Pathology_Other_BioQual_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_low_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_low_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_OTHER_LOW");
               GX_FocusControl = edtavTfbr_pathology_other_low_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV41TFBR_Pathology_Other_Low = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFBR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( AV41TFBR_Pathology_Other_Low, 15, 5)));
            }
            else
            {
               AV41TFBR_Pathology_Other_Low = context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_low_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFBR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( AV41TFBR_Pathology_Other_Low, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_low_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_low_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_OTHER_LOW_TO");
               GX_FocusControl = edtavTfbr_pathology_other_low_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV42TFBR_Pathology_Other_Low_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFBR_Pathology_Other_Low_To", StringUtil.LTrim( StringUtil.Str( AV42TFBR_Pathology_Other_Low_To, 15, 5)));
            }
            else
            {
               AV42TFBR_Pathology_Other_Low_To = context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_low_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFBR_Pathology_Other_Low_To", StringUtil.LTrim( StringUtil.Str( AV42TFBR_Pathology_Other_Low_To, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_high_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_high_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_OTHER_HIGH");
               GX_FocusControl = edtavTfbr_pathology_other_high_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV45TFBR_Pathology_Other_High = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45TFBR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( AV45TFBR_Pathology_Other_High, 15, 5)));
            }
            else
            {
               AV45TFBR_Pathology_Other_High = context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_high_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45TFBR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( AV45TFBR_Pathology_Other_High, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_high_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_high_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_OTHER_HIGH_TO");
               GX_FocusControl = edtavTfbr_pathology_other_high_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV46TFBR_Pathology_Other_High_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFBR_Pathology_Other_High_To", StringUtil.LTrim( StringUtil.Str( AV46TFBR_Pathology_Other_High_To, 15, 5)));
            }
            else
            {
               AV46TFBR_Pathology_Other_High_To = context.localUtil.CToN( cgiGet( edtavTfbr_pathology_other_high_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFBR_Pathology_Other_High_To", StringUtil.LTrim( StringUtil.Str( AV46TFBR_Pathology_Other_High_To, 15, 5)));
            }
            AV49TFBR_Pathology_Other_AbnInd = cgiGet( edtavTfbr_pathology_other_abnind_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49TFBR_Pathology_Other_AbnInd", AV49TFBR_Pathology_Other_AbnInd);
            AV50TFBR_Pathology_Other_AbnInd_Sel = cgiGet( edtavTfbr_pathology_other_abnind_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TFBR_Pathology_Other_AbnInd_Sel", AV50TFBR_Pathology_Other_AbnInd_Sel);
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV54GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV56GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV55GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_pathology_otherid_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Caption");
            Ddo_br_pathology_otherid_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Tooltip");
            Ddo_br_pathology_otherid_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Cls");
            Ddo_br_pathology_otherid_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Filteredtext_set");
            Ddo_br_pathology_otherid_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Filteredtextto_set");
            Ddo_br_pathology_otherid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Dropdownoptionstype");
            Ddo_br_pathology_otherid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Titlecontrolidtoreplace");
            Ddo_br_pathology_otherid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Includesortasc"));
            Ddo_br_pathology_otherid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Includesortdsc"));
            Ddo_br_pathology_otherid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Sortedstatus");
            Ddo_br_pathology_otherid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Includefilter"));
            Ddo_br_pathology_otherid_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Filtertype");
            Ddo_br_pathology_otherid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Filterisrange"));
            Ddo_br_pathology_otherid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Includedatalist"));
            Ddo_br_pathology_otherid_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Sortasc");
            Ddo_br_pathology_otherid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Sortdsc");
            Ddo_br_pathology_otherid_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Cleanfilter");
            Ddo_br_pathology_otherid_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Rangefilterfrom");
            Ddo_br_pathology_otherid_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Rangefilterto");
            Ddo_br_pathology_otherid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Searchbuttontext");
            Ddo_br_pathologyid_Caption = cgiGet( "DDO_BR_PATHOLOGYID_Caption");
            Ddo_br_pathologyid_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_Tooltip");
            Ddo_br_pathologyid_Cls = cgiGet( "DDO_BR_PATHOLOGYID_Cls");
            Ddo_br_pathologyid_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtext_set");
            Ddo_br_pathologyid_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtextto_set");
            Ddo_br_pathologyid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_Dropdownoptionstype");
            Ddo_br_pathologyid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includesortasc"));
            Ddo_br_pathologyid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includesortdsc"));
            Ddo_br_pathologyid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_Sortedstatus");
            Ddo_br_pathologyid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includefilter"));
            Ddo_br_pathologyid_Filtertype = cgiGet( "DDO_BR_PATHOLOGYID_Filtertype");
            Ddo_br_pathologyid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Filterisrange"));
            Ddo_br_pathologyid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includedatalist"));
            Ddo_br_pathologyid_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_Sortasc");
            Ddo_br_pathologyid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_Sortdsc");
            Ddo_br_pathologyid_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGYID_Cleanfilter");
            Ddo_br_pathologyid_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGYID_Rangefilterfrom");
            Ddo_br_pathologyid_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGYID_Rangefilterto");
            Ddo_br_pathologyid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_Searchbuttontext");
            Ddo_br_pathology_other_bio_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Caption");
            Ddo_br_pathology_other_bio_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Tooltip");
            Ddo_br_pathology_other_bio_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Cls");
            Ddo_br_pathology_other_bio_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Filteredtext_set");
            Ddo_br_pathology_other_bio_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Selectedvalue_set");
            Ddo_br_pathology_other_bio_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Dropdownoptionstype");
            Ddo_br_pathology_other_bio_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bio_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Includesortasc"));
            Ddo_br_pathology_other_bio_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Includesortdsc"));
            Ddo_br_pathology_other_bio_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Sortedstatus");
            Ddo_br_pathology_other_bio_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Includefilter"));
            Ddo_br_pathology_other_bio_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Filtertype");
            Ddo_br_pathology_other_bio_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Filterisrange"));
            Ddo_br_pathology_other_bio_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Includedatalist"));
            Ddo_br_pathology_other_bio_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Datalisttype");
            Ddo_br_pathology_other_bio_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Datalistproc");
            Ddo_br_pathology_other_bio_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_other_bio_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Sortasc");
            Ddo_br_pathology_other_bio_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Sortdsc");
            Ddo_br_pathology_other_bio_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Loadingdata");
            Ddo_br_pathology_other_bio_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Cleanfilter");
            Ddo_br_pathology_other_bio_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Noresultsfound");
            Ddo_br_pathology_other_bio_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Searchbuttontext");
            Ddo_br_pathology_other_bionum_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Caption");
            Ddo_br_pathology_other_bionum_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Tooltip");
            Ddo_br_pathology_other_bionum_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Cls");
            Ddo_br_pathology_other_bionum_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filteredtext_set");
            Ddo_br_pathology_other_bionum_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filteredtextto_set");
            Ddo_br_pathology_other_bionum_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Dropdownoptionstype");
            Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bionum_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortasc"));
            Ddo_br_pathology_other_bionum_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortdsc"));
            Ddo_br_pathology_other_bionum_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortedstatus");
            Ddo_br_pathology_other_bionum_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includefilter"));
            Ddo_br_pathology_other_bionum_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filtertype");
            Ddo_br_pathology_other_bionum_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filterisrange"));
            Ddo_br_pathology_other_bionum_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Includedatalist"));
            Ddo_br_pathology_other_bionum_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortasc");
            Ddo_br_pathology_other_bionum_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortdsc");
            Ddo_br_pathology_other_bionum_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Cleanfilter");
            Ddo_br_pathology_other_bionum_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Rangefilterfrom");
            Ddo_br_pathology_other_bionum_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Rangefilterto");
            Ddo_br_pathology_other_bionum_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Searchbuttontext");
            Ddo_br_pathology_other_bionumunit_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Caption");
            Ddo_br_pathology_other_bionumunit_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Tooltip");
            Ddo_br_pathology_other_bionumunit_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Cls");
            Ddo_br_pathology_other_bionumunit_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Filteredtext_set");
            Ddo_br_pathology_other_bionumunit_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Selectedvalue_set");
            Ddo_br_pathology_other_bionumunit_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Dropdownoptionstype");
            Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bionumunit_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortasc"));
            Ddo_br_pathology_other_bionumunit_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortdsc"));
            Ddo_br_pathology_other_bionumunit_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortedstatus");
            Ddo_br_pathology_other_bionumunit_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includefilter"));
            Ddo_br_pathology_other_bionumunit_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Filtertype");
            Ddo_br_pathology_other_bionumunit_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Filterisrange"));
            Ddo_br_pathology_other_bionumunit_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includedatalist"));
            Ddo_br_pathology_other_bionumunit_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Datalisttype");
            Ddo_br_pathology_other_bionumunit_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Datalistproc");
            Ddo_br_pathology_other_bionumunit_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_other_bionumunit_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortasc");
            Ddo_br_pathology_other_bionumunit_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortdsc");
            Ddo_br_pathology_other_bionumunit_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Loadingdata");
            Ddo_br_pathology_other_bionumunit_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Cleanfilter");
            Ddo_br_pathology_other_bionumunit_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Noresultsfound");
            Ddo_br_pathology_other_bionumunit_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Searchbuttontext");
            Ddo_br_pathology_other_bioqual_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Caption");
            Ddo_br_pathology_other_bioqual_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Tooltip");
            Ddo_br_pathology_other_bioqual_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Cls");
            Ddo_br_pathology_other_bioqual_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Filteredtext_set");
            Ddo_br_pathology_other_bioqual_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Selectedvalue_set");
            Ddo_br_pathology_other_bioqual_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Dropdownoptionstype");
            Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bioqual_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includesortasc"));
            Ddo_br_pathology_other_bioqual_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includesortdsc"));
            Ddo_br_pathology_other_bioqual_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortedstatus");
            Ddo_br_pathology_other_bioqual_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includefilter"));
            Ddo_br_pathology_other_bioqual_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Filtertype");
            Ddo_br_pathology_other_bioqual_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Filterisrange"));
            Ddo_br_pathology_other_bioqual_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Includedatalist"));
            Ddo_br_pathology_other_bioqual_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Datalisttype");
            Ddo_br_pathology_other_bioqual_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Datalistproc");
            Ddo_br_pathology_other_bioqual_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_other_bioqual_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortasc");
            Ddo_br_pathology_other_bioqual_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Sortdsc");
            Ddo_br_pathology_other_bioqual_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Loadingdata");
            Ddo_br_pathology_other_bioqual_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Cleanfilter");
            Ddo_br_pathology_other_bioqual_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Noresultsfound");
            Ddo_br_pathology_other_bioqual_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Searchbuttontext");
            Ddo_br_pathology_other_low_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Caption");
            Ddo_br_pathology_other_low_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Tooltip");
            Ddo_br_pathology_other_low_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Cls");
            Ddo_br_pathology_other_low_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Filteredtext_set");
            Ddo_br_pathology_other_low_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Filteredtextto_set");
            Ddo_br_pathology_other_low_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Dropdownoptionstype");
            Ddo_br_pathology_other_low_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_low_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Includesortasc"));
            Ddo_br_pathology_other_low_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Includesortdsc"));
            Ddo_br_pathology_other_low_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Sortedstatus");
            Ddo_br_pathology_other_low_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Includefilter"));
            Ddo_br_pathology_other_low_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Filtertype");
            Ddo_br_pathology_other_low_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Filterisrange"));
            Ddo_br_pathology_other_low_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Includedatalist"));
            Ddo_br_pathology_other_low_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Sortasc");
            Ddo_br_pathology_other_low_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Sortdsc");
            Ddo_br_pathology_other_low_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Cleanfilter");
            Ddo_br_pathology_other_low_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Rangefilterfrom");
            Ddo_br_pathology_other_low_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Rangefilterto");
            Ddo_br_pathology_other_low_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Searchbuttontext");
            Ddo_br_pathology_other_high_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Caption");
            Ddo_br_pathology_other_high_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Tooltip");
            Ddo_br_pathology_other_high_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Cls");
            Ddo_br_pathology_other_high_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Filteredtext_set");
            Ddo_br_pathology_other_high_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Filteredtextto_set");
            Ddo_br_pathology_other_high_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Dropdownoptionstype");
            Ddo_br_pathology_other_high_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_high_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Includesortasc"));
            Ddo_br_pathology_other_high_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Includesortdsc"));
            Ddo_br_pathology_other_high_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortedstatus");
            Ddo_br_pathology_other_high_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Includefilter"));
            Ddo_br_pathology_other_high_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Filtertype");
            Ddo_br_pathology_other_high_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Filterisrange"));
            Ddo_br_pathology_other_high_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Includedatalist"));
            Ddo_br_pathology_other_high_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortasc");
            Ddo_br_pathology_other_high_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Sortdsc");
            Ddo_br_pathology_other_high_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Cleanfilter");
            Ddo_br_pathology_other_high_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Rangefilterfrom");
            Ddo_br_pathology_other_high_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Rangefilterto");
            Ddo_br_pathology_other_high_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Searchbuttontext");
            Ddo_br_pathology_other_abnind_Caption = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Caption");
            Ddo_br_pathology_other_abnind_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Tooltip");
            Ddo_br_pathology_other_abnind_Cls = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Cls");
            Ddo_br_pathology_other_abnind_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Filteredtext_set");
            Ddo_br_pathology_other_abnind_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Selectedvalue_set");
            Ddo_br_pathology_other_abnind_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Dropdownoptionstype");
            Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_abnind_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortasc"));
            Ddo_br_pathology_other_abnind_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortdsc"));
            Ddo_br_pathology_other_abnind_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortedstatus");
            Ddo_br_pathology_other_abnind_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includefilter"));
            Ddo_br_pathology_other_abnind_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Filtertype");
            Ddo_br_pathology_other_abnind_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Filterisrange"));
            Ddo_br_pathology_other_abnind_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Includedatalist"));
            Ddo_br_pathology_other_abnind_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Datalisttype");
            Ddo_br_pathology_other_abnind_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Datalistproc");
            Ddo_br_pathology_other_abnind_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_other_abnind_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortasc");
            Ddo_br_pathology_other_abnind_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortdsc");
            Ddo_br_pathology_other_abnind_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Loadingdata");
            Ddo_br_pathology_other_abnind_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Cleanfilter");
            Ddo_br_pathology_other_abnind_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Noresultsfound");
            Ddo_br_pathology_other_abnind_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_pathology_otherid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Activeeventkey");
            Ddo_br_pathology_otherid_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Filteredtext_get");
            Ddo_br_pathology_otherid_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGY_OTHERID_Filteredtextto_get");
            Ddo_br_pathologyid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_Activeeventkey");
            Ddo_br_pathologyid_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtext_get");
            Ddo_br_pathologyid_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtextto_get");
            Ddo_br_pathology_other_bio_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Activeeventkey");
            Ddo_br_pathology_other_bio_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Filteredtext_get");
            Ddo_br_pathology_other_bio_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIO_Selectedvalue_get");
            Ddo_br_pathology_other_bionum_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Activeeventkey");
            Ddo_br_pathology_other_bionum_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filteredtext_get");
            Ddo_br_pathology_other_bionum_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUM_Filteredtextto_get");
            Ddo_br_pathology_other_bionumunit_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Activeeventkey");
            Ddo_br_pathology_other_bionumunit_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Filteredtext_get");
            Ddo_br_pathology_other_bionumunit_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Selectedvalue_get");
            Ddo_br_pathology_other_bioqual_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Activeeventkey");
            Ddo_br_pathology_other_bioqual_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Filteredtext_get");
            Ddo_br_pathology_other_bioqual_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_BIOQUAL_Selectedvalue_get");
            Ddo_br_pathology_other_low_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Activeeventkey");
            Ddo_br_pathology_other_low_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Filteredtext_get");
            Ddo_br_pathology_other_low_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_LOW_Filteredtextto_get");
            Ddo_br_pathology_other_high_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Activeeventkey");
            Ddo_br_pathology_other_high_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Filteredtext_get");
            Ddo_br_pathology_other_high_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_HIGH_Filteredtextto_get");
            Ddo_br_pathology_other_abnind_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Activeeventkey");
            Ddo_br_pathology_other_abnind_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Filteredtext_get");
            Ddo_br_pathology_other_abnind_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_OTHER_ABNIND_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHERID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Pathology_OtherID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHERID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Pathology_OtherID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID"), ".", ",") != Convert.ToDecimal( AV21TFBR_PathologyID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_PathologyID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIO"), AV25TFBR_Pathology_Other_Bio) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIO_SEL"), AV26TFBR_Pathology_Other_Bio_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIONUM"), ".", ",") != AV29TFBR_Pathology_Other_BioNum )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIONUM_TO"), ".", ",") != AV30TFBR_Pathology_Other_BioNum_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIONUMUNIT"), AV33TFBR_Pathology_Other_BioNumUnit) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL"), AV34TFBR_Pathology_Other_BioNumUnit_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIOQUAL"), AV37TFBR_Pathology_Other_BioQual) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL"), AV38TFBR_Pathology_Other_BioQual_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_LOW"), ".", ",") != AV41TFBR_Pathology_Other_Low )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_LOW_TO"), ".", ",") != AV42TFBR_Pathology_Other_Low_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_HIGH"), ".", ",") != AV45TFBR_Pathology_Other_High )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_HIGH_TO"), ".", ",") != AV46TFBR_Pathology_Other_High_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_ABNIND"), AV49TFBR_Pathology_Other_AbnInd) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_OTHER_ABNIND_SEL"), AV50TFBR_Pathology_Other_AbnInd_Sel) != 0 )
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
         E23572 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E23572( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_pathology_otherid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_otherid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_otherid_Visible), 5, 0)), true);
         edtavTfbr_pathology_otherid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_otherid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_otherid_to_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_to_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_bio_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_bio_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_bio_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_bio_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_bio_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_bio_sel_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_bionum_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_bionum_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_bionum_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_bionum_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_bionum_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_bionum_to_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_bionumunit_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_bionumunit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_bionumunit_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_bionumunit_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_bionumunit_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_bionumunit_sel_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_bioqual_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_bioqual_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_bioqual_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_bioqual_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_bioqual_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_bioqual_sel_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_low_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_low_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_low_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_low_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_low_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_low_to_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_high_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_high_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_high_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_high_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_high_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_high_to_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_abnind_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_abnind_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_abnind_Visible), 5, 0)), true);
         edtavTfbr_pathology_other_abnind_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_other_abnind_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_other_abnind_sel_Visible), 5, 0)), true);
         Ddo_br_pathology_otherid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_OtherID";
         ucDdo_br_pathology_otherid.SendProperty(context, "", false, Ddo_br_pathology_otherid_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_otherid_Titlecontrolidtoreplace);
         AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace = Ddo_br_pathology_otherid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace", AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace);
         edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_otheridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_Titlecontrolidtoreplace);
         AV23ddo_BR_PathologyIDTitleControlIdToReplace = Ddo_br_pathologyid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_PathologyIDTitleControlIdToReplace", AV23ddo_BR_PathologyIDTitleControlIdToReplace);
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_bio_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_Bio";
         ucDdo_br_pathology_other_bio.SendProperty(context, "", false, Ddo_br_pathology_other_bio_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bio_Titlecontrolidtoreplace);
         AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace = Ddo_br_pathology_other_bio_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace", AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace);
         edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_BioNum";
         ucDdo_br_pathology_other_bionum.SendProperty(context, "", false, Ddo_br_pathology_other_bionum_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace);
         AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace", AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace);
         edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_BioNumUnit";
         ucDdo_br_pathology_other_bionumunit.SendProperty(context, "", false, Ddo_br_pathology_other_bionumunit_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace);
         AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace", AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace);
         edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_BioQual";
         ucDdo_br_pathology_other_bioqual.SendProperty(context, "", false, Ddo_br_pathology_other_bioqual_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace);
         AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace = Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace", AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace);
         edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_bioqualtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_low_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_Low";
         ucDdo_br_pathology_other_low.SendProperty(context, "", false, Ddo_br_pathology_other_low_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_low_Titlecontrolidtoreplace);
         AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace = Ddo_br_pathology_other_low_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace", AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace);
         edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_lowtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_high_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_High";
         ucDdo_br_pathology_other_high.SendProperty(context, "", false, Ddo_br_pathology_other_high_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_high_Titlecontrolidtoreplace);
         AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace = Ddo_br_pathology_other_high_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace", AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace);
         edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_hightitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_AbnInd";
         ucDdo_br_pathology_other_abnind.SendProperty(context, "", false, Ddo_br_pathology_other_abnind_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace);
         AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace", AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace);
         edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 病理学其它信息";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV52DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV52DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E24572( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_Pathology_OtherIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Pathology_Other_BioTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Pathology_Other_BioNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Pathology_Other_BioNumUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Pathology_Other_BioQualTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Pathology_Other_LowTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV44BR_Pathology_Other_HighTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV48BR_Pathology_Other_AbnIndTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Pathology_OtherID_Titleformat = 2;
         edtBR_Pathology_OtherID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学其他信息主键", AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_OtherID_Internalname, "Title", edtBR_Pathology_OtherID_Title, !bGXsfl_31_Refreshing);
         edtBR_PathologyID_Titleformat = 2;
         edtBR_PathologyID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学主键", AV23ddo_BR_PathologyIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Title", edtBR_PathologyID_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Other_Bio_Titleformat = 2;
         edtBR_Pathology_Other_Bio_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "肿瘤标志物", AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_Bio_Internalname, "Title", edtBR_Pathology_Other_Bio_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Other_BioNum_Titleformat = 2;
         edtBR_Pathology_Other_BioNum_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "定量结果", AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_BioNum_Internalname, "Title", edtBR_Pathology_Other_BioNum_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Other_BioNumUnit_Titleformat = 2;
         edtBR_Pathology_Other_BioNumUnit_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "定量结果单位", AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_BioNumUnit_Internalname, "Title", edtBR_Pathology_Other_BioNumUnit_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Other_BioQual_Titleformat = 2;
         edtBR_Pathology_Other_BioQual_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "定性结果", AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_BioQual_Internalname, "Title", edtBR_Pathology_Other_BioQual_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Other_Low_Titleformat = 2;
         edtBR_Pathology_Other_Low_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "参考上限", AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_Low_Internalname, "Title", edtBR_Pathology_Other_Low_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Other_High_Titleformat = 2;
         edtBR_Pathology_Other_High_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "参考下限", AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_High_Internalname, "Title", edtBR_Pathology_Other_High_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Other_AbnInd_Titleformat = 2;
         edtBR_Pathology_Other_AbnInd_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "结果提示", AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_AbnInd_Internalname, "Title", edtBR_Pathology_Other_AbnInd_Title, !bGXsfl_31_Refreshing);
         AV54GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV54GridCurrentPage), 10, 0)));
         AV55GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV55GridPageSize), 10, 0)));
         AV56GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56GridRecordCount), 10, 0)));
         AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV17TFBR_Pathology_OtherID;
         AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV18TFBR_Pathology_OtherID_To;
         AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV25TFBR_Pathology_Other_Bio;
         AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV26TFBR_Pathology_Other_Bio_Sel;
         AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV29TFBR_Pathology_Other_BioNum;
         AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV30TFBR_Pathology_Other_BioNum_To;
         AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV33TFBR_Pathology_Other_BioNumUnit;
         AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV34TFBR_Pathology_Other_BioNumUnit_Sel;
         AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV37TFBR_Pathology_Other_BioQual;
         AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV38TFBR_Pathology_Other_BioQual_Sel;
         AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV41TFBR_Pathology_Other_Low;
         AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV42TFBR_Pathology_Other_Low_To;
         AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV45TFBR_Pathology_Other_High;
         AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV46TFBR_Pathology_Other_High_To;
         AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV49TFBR_Pathology_Other_AbnInd;
         AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV50TFBR_Pathology_Other_AbnInd_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_OtherIDTitleFilterData", AV16BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Other_BioTitleFilterData", AV24BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Other_BioNumTitleFilterData", AV28BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Other_BioNumUnitTitleFilterData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Other_BioQualTitleFilterData", AV36BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Other_LowTitleFilterData", AV40BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Pathology_Other_HighTitleFilterData", AV44BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Pathology_Other_AbnIndTitleFilterData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E11572( )
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
            AV53PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV53PageToGo) ;
         }
      }

      protected void E12572( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13572( )
      {
         /* Ddo_br_pathology_otherid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_otherid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathology_otherid_Sortedstatus = "ASC";
            ucDdo_br_pathology_otherid.SendProperty(context, "", false, Ddo_br_pathology_otherid_Internalname, "SortedStatus", Ddo_br_pathology_otherid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_otherid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathology_otherid_Sortedstatus = "DSC";
            ucDdo_br_pathology_otherid.SendProperty(context, "", false, Ddo_br_pathology_otherid_Internalname, "SortedStatus", Ddo_br_pathology_otherid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_otherid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_Pathology_OtherID = (long)(NumberUtil.Val( Ddo_br_pathology_otherid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_OtherID), 18, 0)));
            AV18TFBR_Pathology_OtherID_To = (long)(NumberUtil.Val( Ddo_br_pathology_otherid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_OtherID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_OtherID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_OtherIDTitleFilterData", AV16BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Other_BioTitleFilterData", AV24BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Other_BioNumTitleFilterData", AV28BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Other_BioNumUnitTitleFilterData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Other_BioQualTitleFilterData", AV36BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Other_LowTitleFilterData", AV40BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Pathology_Other_HighTitleFilterData", AV44BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Pathology_Other_AbnIndTitleFilterData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E14572( )
      {
         /* Ddo_br_pathologyid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathologyid_Sortedstatus = "ASC";
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathologyid_Sortedstatus = "DSC";
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV21TFBR_PathologyID = (long)(NumberUtil.Val( Ddo_br_pathologyid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0)));
            AV22TFBR_PathologyID_To = (long)(NumberUtil.Val( Ddo_br_pathologyid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_OtherIDTitleFilterData", AV16BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Other_BioTitleFilterData", AV24BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Other_BioNumTitleFilterData", AV28BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Other_BioNumUnitTitleFilterData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Other_BioQualTitleFilterData", AV36BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Other_LowTitleFilterData", AV40BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Pathology_Other_HighTitleFilterData", AV44BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Pathology_Other_AbnIndTitleFilterData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E15572( )
      {
         /* Ddo_br_pathology_other_bio_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bio_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathology_other_bio_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bio.SendProperty(context, "", false, Ddo_br_pathology_other_bio_Internalname, "SortedStatus", Ddo_br_pathology_other_bio_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bio_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathology_other_bio_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bio.SendProperty(context, "", false, Ddo_br_pathology_other_bio_Internalname, "SortedStatus", Ddo_br_pathology_other_bio_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bio_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_Pathology_Other_Bio = Ddo_br_pathology_other_bio_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Pathology_Other_Bio", AV25TFBR_Pathology_Other_Bio);
            AV26TFBR_Pathology_Other_Bio_Sel = Ddo_br_pathology_other_bio_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Pathology_Other_Bio_Sel", AV26TFBR_Pathology_Other_Bio_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_OtherIDTitleFilterData", AV16BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Other_BioTitleFilterData", AV24BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Other_BioNumTitleFilterData", AV28BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Other_BioNumUnitTitleFilterData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Other_BioQualTitleFilterData", AV36BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Other_LowTitleFilterData", AV40BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Pathology_Other_HighTitleFilterData", AV44BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Pathology_Other_AbnIndTitleFilterData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E16572( )
      {
         /* Ddo_br_pathology_other_bionum_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionum_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathology_other_bionum_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bionum.SendProperty(context, "", false, Ddo_br_pathology_other_bionum_Internalname, "SortedStatus", Ddo_br_pathology_other_bionum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionum_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathology_other_bionum_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bionum.SendProperty(context, "", false, Ddo_br_pathology_other_bionum_Internalname, "SortedStatus", Ddo_br_pathology_other_bionum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionum_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFBR_Pathology_Other_BioNum = NumberUtil.Val( Ddo_br_pathology_other_bionum_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Pathology_Other_BioNum, 15, 5)));
            AV30TFBR_Pathology_Other_BioNum_To = NumberUtil.Val( Ddo_br_pathology_other_bionum_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Pathology_Other_BioNum_To", StringUtil.LTrim( StringUtil.Str( AV30TFBR_Pathology_Other_BioNum_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_OtherIDTitleFilterData", AV16BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Other_BioTitleFilterData", AV24BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Other_BioNumTitleFilterData", AV28BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Other_BioNumUnitTitleFilterData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Other_BioQualTitleFilterData", AV36BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Other_LowTitleFilterData", AV40BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Pathology_Other_HighTitleFilterData", AV44BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Pathology_Other_AbnIndTitleFilterData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E17572( )
      {
         /* Ddo_br_pathology_other_bionumunit_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionumunit_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathology_other_bionumunit_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bionumunit.SendProperty(context, "", false, Ddo_br_pathology_other_bionumunit_Internalname, "SortedStatus", Ddo_br_pathology_other_bionumunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionumunit_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathology_other_bionumunit_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bionumunit.SendProperty(context, "", false, Ddo_br_pathology_other_bionumunit_Internalname, "SortedStatus", Ddo_br_pathology_other_bionumunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionumunit_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV33TFBR_Pathology_Other_BioNumUnit = Ddo_br_pathology_other_bionumunit_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Pathology_Other_BioNumUnit", AV33TFBR_Pathology_Other_BioNumUnit);
            AV34TFBR_Pathology_Other_BioNumUnit_Sel = Ddo_br_pathology_other_bionumunit_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Pathology_Other_BioNumUnit_Sel", AV34TFBR_Pathology_Other_BioNumUnit_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_OtherIDTitleFilterData", AV16BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Other_BioTitleFilterData", AV24BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Other_BioNumTitleFilterData", AV28BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Other_BioNumUnitTitleFilterData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Other_BioQualTitleFilterData", AV36BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Other_LowTitleFilterData", AV40BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Pathology_Other_HighTitleFilterData", AV44BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Pathology_Other_AbnIndTitleFilterData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E18572( )
      {
         /* Ddo_br_pathology_other_bioqual_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bioqual_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathology_other_bioqual_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bioqual.SendProperty(context, "", false, Ddo_br_pathology_other_bioqual_Internalname, "SortedStatus", Ddo_br_pathology_other_bioqual_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bioqual_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathology_other_bioqual_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bioqual.SendProperty(context, "", false, Ddo_br_pathology_other_bioqual_Internalname, "SortedStatus", Ddo_br_pathology_other_bioqual_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bioqual_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV37TFBR_Pathology_Other_BioQual = Ddo_br_pathology_other_bioqual_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Pathology_Other_BioQual", AV37TFBR_Pathology_Other_BioQual);
            AV38TFBR_Pathology_Other_BioQual_Sel = Ddo_br_pathology_other_bioqual_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Pathology_Other_BioQual_Sel", AV38TFBR_Pathology_Other_BioQual_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_OtherIDTitleFilterData", AV16BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Other_BioTitleFilterData", AV24BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Other_BioNumTitleFilterData", AV28BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Other_BioNumUnitTitleFilterData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Other_BioQualTitleFilterData", AV36BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Other_LowTitleFilterData", AV40BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Pathology_Other_HighTitleFilterData", AV44BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Pathology_Other_AbnIndTitleFilterData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E19572( )
      {
         /* Ddo_br_pathology_other_low_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_low_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_other_low_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_low.SendProperty(context, "", false, Ddo_br_pathology_other_low_Internalname, "SortedStatus", Ddo_br_pathology_other_low_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_low_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_other_low_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_low.SendProperty(context, "", false, Ddo_br_pathology_other_low_Internalname, "SortedStatus", Ddo_br_pathology_other_low_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_low_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV41TFBR_Pathology_Other_Low = NumberUtil.Val( Ddo_br_pathology_other_low_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFBR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( AV41TFBR_Pathology_Other_Low, 15, 5)));
            AV42TFBR_Pathology_Other_Low_To = NumberUtil.Val( Ddo_br_pathology_other_low_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFBR_Pathology_Other_Low_To", StringUtil.LTrim( StringUtil.Str( AV42TFBR_Pathology_Other_Low_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_OtherIDTitleFilterData", AV16BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Other_BioTitleFilterData", AV24BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Other_BioNumTitleFilterData", AV28BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Other_BioNumUnitTitleFilterData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Other_BioQualTitleFilterData", AV36BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Other_LowTitleFilterData", AV40BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Pathology_Other_HighTitleFilterData", AV44BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Pathology_Other_AbnIndTitleFilterData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E20572( )
      {
         /* Ddo_br_pathology_other_high_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_high_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_other_high_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_high.SendProperty(context, "", false, Ddo_br_pathology_other_high_Internalname, "SortedStatus", Ddo_br_pathology_other_high_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_high_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_other_high_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_high.SendProperty(context, "", false, Ddo_br_pathology_other_high_Internalname, "SortedStatus", Ddo_br_pathology_other_high_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_high_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV45TFBR_Pathology_Other_High = NumberUtil.Val( Ddo_br_pathology_other_high_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45TFBR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( AV45TFBR_Pathology_Other_High, 15, 5)));
            AV46TFBR_Pathology_Other_High_To = NumberUtil.Val( Ddo_br_pathology_other_high_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFBR_Pathology_Other_High_To", StringUtil.LTrim( StringUtil.Str( AV46TFBR_Pathology_Other_High_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_OtherIDTitleFilterData", AV16BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Other_BioTitleFilterData", AV24BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Other_BioNumTitleFilterData", AV28BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Other_BioNumUnitTitleFilterData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Other_BioQualTitleFilterData", AV36BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Other_LowTitleFilterData", AV40BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Pathology_Other_HighTitleFilterData", AV44BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Pathology_Other_AbnIndTitleFilterData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E21572( )
      {
         /* Ddo_br_pathology_other_abnind_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_abnind_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_other_abnind_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_abnind.SendProperty(context, "", false, Ddo_br_pathology_other_abnind_Internalname, "SortedStatus", Ddo_br_pathology_other_abnind_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_abnind_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_other_abnind_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_abnind.SendProperty(context, "", false, Ddo_br_pathology_other_abnind_Internalname, "SortedStatus", Ddo_br_pathology_other_abnind_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_abnind_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV49TFBR_Pathology_Other_AbnInd = Ddo_br_pathology_other_abnind_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49TFBR_Pathology_Other_AbnInd", AV49TFBR_Pathology_Other_AbnInd);
            AV50TFBR_Pathology_Other_AbnInd_Sel = Ddo_br_pathology_other_abnind_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TFBR_Pathology_Other_AbnInd_Sel", AV50TFBR_Pathology_Other_AbnInd_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_OtherIDTitleFilterData", AV16BR_Pathology_OtherIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Other_BioTitleFilterData", AV24BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Other_BioNumTitleFilterData", AV28BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Other_BioNumUnitTitleFilterData", AV32BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Other_BioQualTitleFilterData", AV36BR_Pathology_Other_BioQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Other_LowTitleFilterData", AV40BR_Pathology_Other_LowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Pathology_Other_HighTitleFilterData", AV44BR_Pathology_Other_HighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Pathology_Other_AbnIndTitleFilterData", AV48BR_Pathology_Other_AbnIndTitleFilterData);
      }

      private void E25572( )
      {
         /* Grid_Load Routine */
         AV57Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV57Display);
         AV83Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_pathology_otherview.aspx") + "?" + UrlEncode("" +A288BR_Pathology_OtherID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV58Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV58Update);
         AV84Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV59IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_pathology_other.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A288BR_Pathology_OtherID);
         }
         AV60Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV60Delete);
         AV85Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV61IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_pathology_other.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A288BR_Pathology_OtherID);
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

      protected void E22572( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_pathology_other.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_pathology_otherid_Sortedstatus = "";
         ucDdo_br_pathology_otherid.SendProperty(context, "", false, Ddo_br_pathology_otherid_Internalname, "SortedStatus", Ddo_br_pathology_otherid_Sortedstatus);
         Ddo_br_pathologyid_Sortedstatus = "";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
         Ddo_br_pathology_other_bio_Sortedstatus = "";
         ucDdo_br_pathology_other_bio.SendProperty(context, "", false, Ddo_br_pathology_other_bio_Internalname, "SortedStatus", Ddo_br_pathology_other_bio_Sortedstatus);
         Ddo_br_pathology_other_bionum_Sortedstatus = "";
         ucDdo_br_pathology_other_bionum.SendProperty(context, "", false, Ddo_br_pathology_other_bionum_Internalname, "SortedStatus", Ddo_br_pathology_other_bionum_Sortedstatus);
         Ddo_br_pathology_other_bionumunit_Sortedstatus = "";
         ucDdo_br_pathology_other_bionumunit.SendProperty(context, "", false, Ddo_br_pathology_other_bionumunit_Internalname, "SortedStatus", Ddo_br_pathology_other_bionumunit_Sortedstatus);
         Ddo_br_pathology_other_bioqual_Sortedstatus = "";
         ucDdo_br_pathology_other_bioqual.SendProperty(context, "", false, Ddo_br_pathology_other_bioqual_Internalname, "SortedStatus", Ddo_br_pathology_other_bioqual_Sortedstatus);
         Ddo_br_pathology_other_low_Sortedstatus = "";
         ucDdo_br_pathology_other_low.SendProperty(context, "", false, Ddo_br_pathology_other_low_Internalname, "SortedStatus", Ddo_br_pathology_other_low_Sortedstatus);
         Ddo_br_pathology_other_high_Sortedstatus = "";
         ucDdo_br_pathology_other_high.SendProperty(context, "", false, Ddo_br_pathology_other_high_Internalname, "SortedStatus", Ddo_br_pathology_other_high_Sortedstatus);
         Ddo_br_pathology_other_abnind_Sortedstatus = "";
         ucDdo_br_pathology_other_abnind.SendProperty(context, "", false, Ddo_br_pathology_other_abnind_Internalname, "SortedStatus", Ddo_br_pathology_other_abnind_Sortedstatus);
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
            Ddo_br_pathology_otherid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_otherid.SendProperty(context, "", false, Ddo_br_pathology_otherid_Internalname, "SortedStatus", Ddo_br_pathology_otherid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_pathologyid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_pathology_other_bio_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_other_bio.SendProperty(context, "", false, Ddo_br_pathology_other_bio_Internalname, "SortedStatus", Ddo_br_pathology_other_bio_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_pathology_other_bionum_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_other_bionum.SendProperty(context, "", false, Ddo_br_pathology_other_bionum_Internalname, "SortedStatus", Ddo_br_pathology_other_bionum_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_pathology_other_bionumunit_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_other_bionumunit.SendProperty(context, "", false, Ddo_br_pathology_other_bionumunit_Internalname, "SortedStatus", Ddo_br_pathology_other_bionumunit_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_pathology_other_bioqual_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_other_bioqual.SendProperty(context, "", false, Ddo_br_pathology_other_bioqual_Internalname, "SortedStatus", Ddo_br_pathology_other_bioqual_Sortedstatus);
         }
         else if ( AV13OrderedBy == 7 )
         {
            Ddo_br_pathology_other_low_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_other_low.SendProperty(context, "", false, Ddo_br_pathology_other_low_Internalname, "SortedStatus", Ddo_br_pathology_other_low_Sortedstatus);
         }
         else if ( AV13OrderedBy == 8 )
         {
            Ddo_br_pathology_other_high_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_other_high.SendProperty(context, "", false, Ddo_br_pathology_other_high_Internalname, "SortedStatus", Ddo_br_pathology_other_high_Sortedstatus);
         }
         else if ( AV13OrderedBy == 9 )
         {
            Ddo_br_pathology_other_abnind_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_other_abnind.SendProperty(context, "", false, Ddo_br_pathology_other_abnind_Internalname, "SortedStatus", Ddo_br_pathology_other_abnind_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV59IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
         AV59IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59IsAuthorized_Update", AV59IsAuthorized_Update);
         if ( ! ( AV59IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV61IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
         AV61IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61IsAuthorized_Delete", AV61IsAuthorized_Delete);
         if ( ! ( AV61IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV62TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
         AV62TempBoolean = GXt_boolean2;
         if ( ! ( AV62TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV86Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV86Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV86Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV87GXV1 = 1;
         while ( AV87GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV87GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHERID") == 0 )
            {
               AV17TFBR_Pathology_OtherID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_OtherID), 18, 0)));
               AV18TFBR_Pathology_OtherID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_OtherID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_OtherID_To), 18, 0)));
               if ( ! (0==AV17TFBR_Pathology_OtherID) )
               {
                  Ddo_br_pathology_otherid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_Pathology_OtherID), 18, 0);
                  ucDdo_br_pathology_otherid.SendProperty(context, "", false, Ddo_br_pathology_otherid_Internalname, "FilteredText_set", Ddo_br_pathology_otherid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_Pathology_OtherID_To) )
               {
                  Ddo_br_pathology_otherid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_Pathology_OtherID_To), 18, 0);
                  ucDdo_br_pathology_otherid.SendProperty(context, "", false, Ddo_br_pathology_otherid_Internalname, "FilteredTextTo_set", Ddo_br_pathology_otherid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID") == 0 )
            {
               AV21TFBR_PathologyID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0)));
               AV22TFBR_PathologyID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0)));
               if ( ! (0==AV21TFBR_PathologyID) )
               {
                  Ddo_br_pathologyid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0);
                  ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "FilteredText_set", Ddo_br_pathologyid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_PathologyID_To) )
               {
                  Ddo_br_pathologyid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0);
                  ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "FilteredTextTo_set", Ddo_br_pathologyid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIO") == 0 )
            {
               AV25TFBR_Pathology_Other_Bio = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Pathology_Other_Bio", AV25TFBR_Pathology_Other_Bio);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Pathology_Other_Bio)) )
               {
                  Ddo_br_pathology_other_bio_Filteredtext_set = AV25TFBR_Pathology_Other_Bio;
                  ucDdo_br_pathology_other_bio.SendProperty(context, "", false, Ddo_br_pathology_other_bio_Internalname, "FilteredText_set", Ddo_br_pathology_other_bio_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIO_SEL") == 0 )
            {
               AV26TFBR_Pathology_Other_Bio_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Pathology_Other_Bio_Sel", AV26TFBR_Pathology_Other_Bio_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Pathology_Other_Bio_Sel)) )
               {
                  Ddo_br_pathology_other_bio_Selectedvalue_set = AV26TFBR_Pathology_Other_Bio_Sel;
                  ucDdo_br_pathology_other_bio.SendProperty(context, "", false, Ddo_br_pathology_other_bio_Internalname, "SelectedValue_set", Ddo_br_pathology_other_bio_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIONUM") == 0 )
            {
               AV29TFBR_Pathology_Other_BioNum = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Pathology_Other_BioNum, 15, 5)));
               AV30TFBR_Pathology_Other_BioNum_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Pathology_Other_BioNum_To", StringUtil.LTrim( StringUtil.Str( AV30TFBR_Pathology_Other_BioNum_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV29TFBR_Pathology_Other_BioNum) )
               {
                  Ddo_br_pathology_other_bionum_Filteredtext_set = StringUtil.Str( AV29TFBR_Pathology_Other_BioNum, 15, 5);
                  ucDdo_br_pathology_other_bionum.SendProperty(context, "", false, Ddo_br_pathology_other_bionum_Internalname, "FilteredText_set", Ddo_br_pathology_other_bionum_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV30TFBR_Pathology_Other_BioNum_To) )
               {
                  Ddo_br_pathology_other_bionum_Filteredtextto_set = StringUtil.Str( AV30TFBR_Pathology_Other_BioNum_To, 15, 5);
                  ucDdo_br_pathology_other_bionum.SendProperty(context, "", false, Ddo_br_pathology_other_bionum_Internalname, "FilteredTextTo_set", Ddo_br_pathology_other_bionum_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIONUMUNIT") == 0 )
            {
               AV33TFBR_Pathology_Other_BioNumUnit = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Pathology_Other_BioNumUnit", AV33TFBR_Pathology_Other_BioNumUnit);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFBR_Pathology_Other_BioNumUnit)) )
               {
                  Ddo_br_pathology_other_bionumunit_Filteredtext_set = AV33TFBR_Pathology_Other_BioNumUnit;
                  ucDdo_br_pathology_other_bionumunit.SendProperty(context, "", false, Ddo_br_pathology_other_bionumunit_Internalname, "FilteredText_set", Ddo_br_pathology_other_bionumunit_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL") == 0 )
            {
               AV34TFBR_Pathology_Other_BioNumUnit_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Pathology_Other_BioNumUnit_Sel", AV34TFBR_Pathology_Other_BioNumUnit_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFBR_Pathology_Other_BioNumUnit_Sel)) )
               {
                  Ddo_br_pathology_other_bionumunit_Selectedvalue_set = AV34TFBR_Pathology_Other_BioNumUnit_Sel;
                  ucDdo_br_pathology_other_bionumunit.SendProperty(context, "", false, Ddo_br_pathology_other_bionumunit_Internalname, "SelectedValue_set", Ddo_br_pathology_other_bionumunit_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIOQUAL") == 0 )
            {
               AV37TFBR_Pathology_Other_BioQual = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Pathology_Other_BioQual", AV37TFBR_Pathology_Other_BioQual);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFBR_Pathology_Other_BioQual)) )
               {
                  Ddo_br_pathology_other_bioqual_Filteredtext_set = AV37TFBR_Pathology_Other_BioQual;
                  ucDdo_br_pathology_other_bioqual.SendProperty(context, "", false, Ddo_br_pathology_other_bioqual_Internalname, "FilteredText_set", Ddo_br_pathology_other_bioqual_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIOQUAL_SEL") == 0 )
            {
               AV38TFBR_Pathology_Other_BioQual_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Pathology_Other_BioQual_Sel", AV38TFBR_Pathology_Other_BioQual_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFBR_Pathology_Other_BioQual_Sel)) )
               {
                  Ddo_br_pathology_other_bioqual_Selectedvalue_set = AV38TFBR_Pathology_Other_BioQual_Sel;
                  ucDdo_br_pathology_other_bioqual.SendProperty(context, "", false, Ddo_br_pathology_other_bioqual_Internalname, "SelectedValue_set", Ddo_br_pathology_other_bioqual_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_LOW") == 0 )
            {
               AV41TFBR_Pathology_Other_Low = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFBR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( AV41TFBR_Pathology_Other_Low, 15, 5)));
               AV42TFBR_Pathology_Other_Low_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFBR_Pathology_Other_Low_To", StringUtil.LTrim( StringUtil.Str( AV42TFBR_Pathology_Other_Low_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV41TFBR_Pathology_Other_Low) )
               {
                  Ddo_br_pathology_other_low_Filteredtext_set = StringUtil.Str( AV41TFBR_Pathology_Other_Low, 15, 5);
                  ucDdo_br_pathology_other_low.SendProperty(context, "", false, Ddo_br_pathology_other_low_Internalname, "FilteredText_set", Ddo_br_pathology_other_low_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV42TFBR_Pathology_Other_Low_To) )
               {
                  Ddo_br_pathology_other_low_Filteredtextto_set = StringUtil.Str( AV42TFBR_Pathology_Other_Low_To, 15, 5);
                  ucDdo_br_pathology_other_low.SendProperty(context, "", false, Ddo_br_pathology_other_low_Internalname, "FilteredTextTo_set", Ddo_br_pathology_other_low_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_HIGH") == 0 )
            {
               AV45TFBR_Pathology_Other_High = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45TFBR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( AV45TFBR_Pathology_Other_High, 15, 5)));
               AV46TFBR_Pathology_Other_High_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFBR_Pathology_Other_High_To", StringUtil.LTrim( StringUtil.Str( AV46TFBR_Pathology_Other_High_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV45TFBR_Pathology_Other_High) )
               {
                  Ddo_br_pathology_other_high_Filteredtext_set = StringUtil.Str( AV45TFBR_Pathology_Other_High, 15, 5);
                  ucDdo_br_pathology_other_high.SendProperty(context, "", false, Ddo_br_pathology_other_high_Internalname, "FilteredText_set", Ddo_br_pathology_other_high_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV46TFBR_Pathology_Other_High_To) )
               {
                  Ddo_br_pathology_other_high_Filteredtextto_set = StringUtil.Str( AV46TFBR_Pathology_Other_High_To, 15, 5);
                  ucDdo_br_pathology_other_high.SendProperty(context, "", false, Ddo_br_pathology_other_high_Internalname, "FilteredTextTo_set", Ddo_br_pathology_other_high_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_ABNIND") == 0 )
            {
               AV49TFBR_Pathology_Other_AbnInd = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49TFBR_Pathology_Other_AbnInd", AV49TFBR_Pathology_Other_AbnInd);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49TFBR_Pathology_Other_AbnInd)) )
               {
                  Ddo_br_pathology_other_abnind_Filteredtext_set = AV49TFBR_Pathology_Other_AbnInd;
                  ucDdo_br_pathology_other_abnind.SendProperty(context, "", false, Ddo_br_pathology_other_abnind_Internalname, "FilteredText_set", Ddo_br_pathology_other_abnind_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_ABNIND_SEL") == 0 )
            {
               AV50TFBR_Pathology_Other_AbnInd_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TFBR_Pathology_Other_AbnInd_Sel", AV50TFBR_Pathology_Other_AbnInd_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50TFBR_Pathology_Other_AbnInd_Sel)) )
               {
                  Ddo_br_pathology_other_abnind_Selectedvalue_set = AV50TFBR_Pathology_Other_AbnInd_Sel;
                  ucDdo_br_pathology_other_abnind.SendProperty(context, "", false, Ddo_br_pathology_other_abnind_Internalname, "SelectedValue_set", Ddo_br_pathology_other_abnind_Selectedvalue_set);
               }
            }
            AV87GXV1 = (int)(AV87GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV86Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_Pathology_OtherID) && (0==AV18TFBR_Pathology_OtherID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHERID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_Pathology_OtherID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_Pathology_OtherID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_PathologyID) && (0==AV22TFBR_PathologyID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Pathology_Other_Bio)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_BIO";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFBR_Pathology_Other_Bio;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Pathology_Other_Bio_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_BIO_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFBR_Pathology_Other_Bio_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV29TFBR_Pathology_Other_BioNum) && (Convert.ToDecimal(0)==AV30TFBR_Pathology_Other_BioNum_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_BIONUM";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV29TFBR_Pathology_Other_BioNum, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV30TFBR_Pathology_Other_BioNum_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFBR_Pathology_Other_BioNumUnit)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_BIONUMUNIT";
            AV12GridStateFilterValue.gxTpr_Value = AV33TFBR_Pathology_Other_BioNumUnit;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFBR_Pathology_Other_BioNumUnit_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV34TFBR_Pathology_Other_BioNumUnit_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFBR_Pathology_Other_BioQual)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_BIOQUAL";
            AV12GridStateFilterValue.gxTpr_Value = AV37TFBR_Pathology_Other_BioQual;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFBR_Pathology_Other_BioQual_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_BIOQUAL_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV38TFBR_Pathology_Other_BioQual_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV41TFBR_Pathology_Other_Low) && (Convert.ToDecimal(0)==AV42TFBR_Pathology_Other_Low_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_LOW";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV41TFBR_Pathology_Other_Low, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV42TFBR_Pathology_Other_Low_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV45TFBR_Pathology_Other_High) && (Convert.ToDecimal(0)==AV46TFBR_Pathology_Other_High_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_HIGH";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV45TFBR_Pathology_Other_High, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV46TFBR_Pathology_Other_High_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49TFBR_Pathology_Other_AbnInd)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_ABNIND";
            AV12GridStateFilterValue.gxTpr_Value = AV49TFBR_Pathology_Other_AbnInd;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50TFBR_Pathology_Other_AbnInd_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_OTHER_ABNIND_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV50TFBR_Pathology_Other_AbnInd_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV86Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV86Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Pathology_Other";
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
         PA572( ) ;
         WS572( ) ;
         WE572( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271225178", true);
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
         context.AddJavascriptSource("br_pathology_otherww.js", "?20202271225178", false);
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
         edtBR_Pathology_OtherID_Internalname = "BR_PATHOLOGY_OTHERID_"+sGXsfl_31_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_31_idx;
         edtBR_Pathology_Other_Bio_Internalname = "BR_PATHOLOGY_OTHER_BIO_"+sGXsfl_31_idx;
         edtBR_Pathology_Other_BioNum_Internalname = "BR_PATHOLOGY_OTHER_BIONUM_"+sGXsfl_31_idx;
         edtBR_Pathology_Other_BioNumUnit_Internalname = "BR_PATHOLOGY_OTHER_BIONUMUNIT_"+sGXsfl_31_idx;
         edtBR_Pathology_Other_BioQual_Internalname = "BR_PATHOLOGY_OTHER_BIOQUAL_"+sGXsfl_31_idx;
         edtBR_Pathology_Other_Low_Internalname = "BR_PATHOLOGY_OTHER_LOW_"+sGXsfl_31_idx;
         edtBR_Pathology_Other_High_Internalname = "BR_PATHOLOGY_OTHER_HIGH_"+sGXsfl_31_idx;
         edtBR_Pathology_Other_AbnInd_Internalname = "BR_PATHOLOGY_OTHER_ABNIND_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_OtherID_Internalname = "BR_PATHOLOGY_OTHERID_"+sGXsfl_31_fel_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Other_Bio_Internalname = "BR_PATHOLOGY_OTHER_BIO_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Other_BioNum_Internalname = "BR_PATHOLOGY_OTHER_BIONUM_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Other_BioNumUnit_Internalname = "BR_PATHOLOGY_OTHER_BIONUMUNIT_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Other_BioQual_Internalname = "BR_PATHOLOGY_OTHER_BIOQUAL_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Other_Low_Internalname = "BR_PATHOLOGY_OTHER_LOW_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Other_High_Internalname = "BR_PATHOLOGY_OTHER_HIGH_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Other_AbnInd_Internalname = "BR_PATHOLOGY_OTHER_ABNIND_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB570( ) ;
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
            AV57Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV57Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV83Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV57Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV57Display)) ? AV83Display_GXI : context.PathToRelativeUrl( AV57Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV57Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV58Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV58Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV84Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV58Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV58Update)) ? AV84Update_GXI : context.PathToRelativeUrl( AV58Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV58Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV60Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV60Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV85Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV60Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV60Delete)) ? AV85Delete_GXI : context.PathToRelativeUrl( AV60Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV60Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_OtherID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_OtherID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_Bio_Internalname,(String)A289BR_Pathology_Other_Bio,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_Bio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_BioNum_Internalname,StringUtil.LTrim( StringUtil.NToC( A290BR_Pathology_Other_BioNum, 15, 5, ".", "")),context.localUtil.Format( A290BR_Pathology_Other_BioNum, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_BioNum_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_BioNumUnit_Internalname,(String)A291BR_Pathology_Other_BioNumUnit,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_BioNumUnit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_BioQual_Internalname,(String)A292BR_Pathology_Other_BioQual,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_BioQual_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_Low_Internalname,StringUtil.LTrim( StringUtil.NToC( A293BR_Pathology_Other_Low, 15, 5, ".", "")),context.localUtil.Format( A293BR_Pathology_Other_Low, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_Low_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_High_Internalname,StringUtil.LTrim( StringUtil.NToC( A294BR_Pathology_Other_High, 15, 5, ".", "")),context.localUtil.Format( A294BR_Pathology_Other_High, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_High_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_AbnInd_Internalname,(String)A295BR_Pathology_Other_AbnInd,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_AbnInd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes572( ) ;
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
         edtavTfbr_pathology_otherid_Internalname = "vTFBR_PATHOLOGY_OTHERID";
         edtavTfbr_pathology_otherid_to_Internalname = "vTFBR_PATHOLOGY_OTHERID_TO";
         edtavTfbr_pathologyid_Internalname = "vTFBR_PATHOLOGYID";
         edtavTfbr_pathologyid_to_Internalname = "vTFBR_PATHOLOGYID_TO";
         edtavTfbr_pathology_other_bio_Internalname = "vTFBR_PATHOLOGY_OTHER_BIO";
         edtavTfbr_pathology_other_bio_sel_Internalname = "vTFBR_PATHOLOGY_OTHER_BIO_SEL";
         edtavTfbr_pathology_other_bionum_Internalname = "vTFBR_PATHOLOGY_OTHER_BIONUM";
         edtavTfbr_pathology_other_bionum_to_Internalname = "vTFBR_PATHOLOGY_OTHER_BIONUM_TO";
         edtavTfbr_pathology_other_bionumunit_Internalname = "vTFBR_PATHOLOGY_OTHER_BIONUMUNIT";
         edtavTfbr_pathology_other_bionumunit_sel_Internalname = "vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL";
         edtavTfbr_pathology_other_bioqual_Internalname = "vTFBR_PATHOLOGY_OTHER_BIOQUAL";
         edtavTfbr_pathology_other_bioqual_sel_Internalname = "vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL";
         edtavTfbr_pathology_other_low_Internalname = "vTFBR_PATHOLOGY_OTHER_LOW";
         edtavTfbr_pathology_other_low_to_Internalname = "vTFBR_PATHOLOGY_OTHER_LOW_TO";
         edtavTfbr_pathology_other_high_Internalname = "vTFBR_PATHOLOGY_OTHER_HIGH";
         edtavTfbr_pathology_other_high_to_Internalname = "vTFBR_PATHOLOGY_OTHER_HIGH_TO";
         edtavTfbr_pathology_other_abnind_Internalname = "vTFBR_PATHOLOGY_OTHER_ABNIND";
         edtavTfbr_pathology_other_abnind_sel_Internalname = "vTFBR_PATHOLOGY_OTHER_ABNIND_SEL";
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
         edtavTfbr_pathology_other_abnind_sel_Jsonclick = "";
         edtavTfbr_pathology_other_abnind_sel_Visible = 1;
         edtavTfbr_pathology_other_abnind_Jsonclick = "";
         edtavTfbr_pathology_other_abnind_Visible = 1;
         edtavTfbr_pathology_other_high_to_Jsonclick = "";
         edtavTfbr_pathology_other_high_to_Visible = 1;
         edtavTfbr_pathology_other_high_Jsonclick = "";
         edtavTfbr_pathology_other_high_Visible = 1;
         edtavTfbr_pathology_other_low_to_Jsonclick = "";
         edtavTfbr_pathology_other_low_to_Visible = 1;
         edtavTfbr_pathology_other_low_Jsonclick = "";
         edtavTfbr_pathology_other_low_Visible = 1;
         edtavTfbr_pathology_other_bioqual_sel_Jsonclick = "";
         edtavTfbr_pathology_other_bioqual_sel_Visible = 1;
         edtavTfbr_pathology_other_bioqual_Jsonclick = "";
         edtavTfbr_pathology_other_bioqual_Visible = 1;
         edtavTfbr_pathology_other_bionumunit_sel_Jsonclick = "";
         edtavTfbr_pathology_other_bionumunit_sel_Visible = 1;
         edtavTfbr_pathology_other_bionumunit_Jsonclick = "";
         edtavTfbr_pathology_other_bionumunit_Visible = 1;
         edtavTfbr_pathology_other_bionum_to_Jsonclick = "";
         edtavTfbr_pathology_other_bionum_to_Visible = 1;
         edtavTfbr_pathology_other_bionum_Jsonclick = "";
         edtavTfbr_pathology_other_bionum_Visible = 1;
         edtavTfbr_pathology_other_bio_sel_Jsonclick = "";
         edtavTfbr_pathology_other_bio_sel_Visible = 1;
         edtavTfbr_pathology_other_bio_Jsonclick = "";
         edtavTfbr_pathology_other_bio_Visible = 1;
         edtavTfbr_pathologyid_to_Jsonclick = "";
         edtavTfbr_pathologyid_to_Visible = 1;
         edtavTfbr_pathologyid_Jsonclick = "";
         edtavTfbr_pathologyid_Visible = 1;
         edtavTfbr_pathology_otherid_to_Jsonclick = "";
         edtavTfbr_pathology_otherid_to_Visible = 1;
         edtavTfbr_pathology_otherid_Jsonclick = "";
         edtavTfbr_pathology_otherid_Visible = 1;
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
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
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
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_pathology_other_abnind_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_abnind_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_other_abnind_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_other_abnind_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_other_abnind_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_abnind_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_abnind_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_other_abnind_Datalistproc = "BR_Pathology_OtherWWGetFilterData";
         Ddo_br_pathology_other_abnind_Datalisttype = "Dynamic";
         Ddo_br_pathology_other_abnind_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_abnind_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_abnind_Filtertype = "Character";
         Ddo_br_pathology_other_abnind_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_abnind_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_abnind_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_abnind_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_abnind_Cls = "ColumnSettings";
         Ddo_br_pathology_other_abnind_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_abnind_Caption = "";
         Ddo_br_pathology_other_high_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_high_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathology_other_high_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathology_other_high_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_other_high_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_high_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_high_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_high_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_high_Filtertype = "Numeric";
         Ddo_br_pathology_other_high_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_high_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_high_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_high_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_high_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_high_Cls = "ColumnSettings";
         Ddo_br_pathology_other_high_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_high_Caption = "";
         Ddo_br_pathology_other_low_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_low_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathology_other_low_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathology_other_low_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_other_low_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_low_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_low_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_low_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_low_Filtertype = "Numeric";
         Ddo_br_pathology_other_low_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_low_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_low_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_low_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_low_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_low_Cls = "ColumnSettings";
         Ddo_br_pathology_other_low_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_low_Caption = "";
         Ddo_br_pathology_other_bioqual_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bioqual_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_other_bioqual_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_other_bioqual_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_other_bioqual_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bioqual_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bioqual_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_other_bioqual_Datalistproc = "BR_Pathology_OtherWWGetFilterData";
         Ddo_br_pathology_other_bioqual_Datalisttype = "Dynamic";
         Ddo_br_pathology_other_bioqual_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bioqual_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bioqual_Filtertype = "Character";
         Ddo_br_pathology_other_bioqual_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bioqual_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bioqual_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bioqual_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bioqual_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bioqual_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bioqual_Caption = "";
         Ddo_br_pathology_other_bionumunit_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bionumunit_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_other_bionumunit_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_other_bionumunit_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_other_bionumunit_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bionumunit_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bionumunit_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_other_bionumunit_Datalistproc = "BR_Pathology_OtherWWGetFilterData";
         Ddo_br_pathology_other_bionumunit_Datalisttype = "Dynamic";
         Ddo_br_pathology_other_bionumunit_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionumunit_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bionumunit_Filtertype = "Character";
         Ddo_br_pathology_other_bionumunit_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionumunit_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionumunit_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bionumunit_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bionumunit_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bionumunit_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bionumunit_Caption = "";
         Ddo_br_pathology_other_bionum_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bionum_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathology_other_bionum_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathology_other_bionum_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_other_bionum_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bionum_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bionum_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bionum_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionum_Filtertype = "Numeric";
         Ddo_br_pathology_other_bionum_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionum_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionum_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bionum_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bionum_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bionum_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bionum_Caption = "";
         Ddo_br_pathology_other_bio_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bio_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_other_bio_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_other_bio_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_other_bio_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bio_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bio_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_other_bio_Datalistproc = "BR_Pathology_OtherWWGetFilterData";
         Ddo_br_pathology_other_bio_Datalisttype = "Dynamic";
         Ddo_br_pathology_other_bio_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bio_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bio_Filtertype = "Character";
         Ddo_br_pathology_other_bio_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bio_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bio_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bio_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bio_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bio_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bio_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bio_Caption = "";
         Ddo_br_pathologyid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathologyid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathologyid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathologyid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Filtertype = "Numeric";
         Ddo_br_pathologyid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_Cls = "ColumnSettings";
         Ddo_br_pathologyid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_Caption = "";
         Ddo_br_pathology_otherid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_otherid_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathology_otherid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathology_otherid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_otherid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_otherid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_otherid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_otherid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathology_otherid_Filtertype = "Numeric";
         Ddo_br_pathology_otherid_Includefilter = Convert.ToBoolean( -1);
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
         Form.Caption = " 病理学其它信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV44BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV48BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHERID.ONOPTIONCLICKED","{handler:'E13572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_otherid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_otherid_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'FilteredText_get'},{av:'Ddo_br_pathology_otherid_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_otherid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'SortedStatus'},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bioqual_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_low_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_high_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV16BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV44BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV48BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED","{handler:'E14572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathologyid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID',prop:'ActiveEventKey'},{av:'Ddo_br_pathologyid_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredText_get'},{av:'Ddo_br_pathologyid_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_pathology_otherid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bioqual_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_low_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_high_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV16BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV44BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV48BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIO.ONOPTIONCLICKED","{handler:'E15572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_other_bio_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_other_bio_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'FilteredText_get'},{av:'Ddo_br_pathology_other_bio_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIO.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'Ddo_br_pathology_otherid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bioqual_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_low_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_high_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV16BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV44BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV48BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUM.ONOPTIONCLICKED","{handler:'E16572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_other_bionum_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_other_bionum_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'FilteredText_get'},{av:'Ddo_br_pathology_other_bionum_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUM.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_pathology_otherid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bioqual_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_low_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_high_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV16BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV44BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV48BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT.ONOPTIONCLICKED","{handler:'E17572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_other_bionumunit_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_other_bionumunit_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'FilteredText_get'},{av:'Ddo_br_pathology_other_bionumunit_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'Ddo_br_pathology_otherid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bioqual_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_low_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_high_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV16BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV44BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV48BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIOQUAL.ONOPTIONCLICKED","{handler:'E18572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_other_bioqual_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_other_bioqual_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'FilteredText_get'},{av:'Ddo_br_pathology_other_bioqual_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIOQUAL.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bioqual_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SortedStatus'},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'Ddo_br_pathology_otherid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_low_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_high_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV16BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV44BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV48BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_LOW.ONOPTIONCLICKED","{handler:'E19572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_other_low_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_other_low_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'FilteredText_get'},{av:'Ddo_br_pathology_other_low_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_LOW.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_low_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'SortedStatus'},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_pathology_otherid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bioqual_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_high_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV16BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV44BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV48BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_HIGH.ONOPTIONCLICKED","{handler:'E20572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_other_high_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_other_high_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'FilteredText_get'},{av:'Ddo_br_pathology_other_high_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_HIGH.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_high_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'SortedStatus'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_pathology_otherid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bioqual_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_low_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV16BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV44BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV48BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_ABNIND.ONOPTIONCLICKED","{handler:'E21572',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_OtherID',fld:'vTFBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_OtherID_To',fld:'vTFBR_PATHOLOGY_OTHERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Other_Bio',fld:'vTFBR_PATHOLOGY_OTHER_BIO',pic:''},{av:'AV26TFBR_Pathology_Other_Bio_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIO_SEL',pic:''},{av:'AV29TFBR_Pathology_Other_BioNum',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV30TFBR_Pathology_Other_BioNum_To',fld:'vTFBR_PATHOLOGY_OTHER_BIONUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Pathology_Other_BioNumUnit',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT',pic:''},{av:'AV34TFBR_Pathology_Other_BioNumUnit_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL',pic:''},{av:'AV37TFBR_Pathology_Other_BioQual',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL',pic:''},{av:'AV38TFBR_Pathology_Other_BioQual_Sel',fld:'vTFBR_PATHOLOGY_OTHER_BIOQUAL_SEL',pic:''},{av:'AV41TFBR_Pathology_Other_Low',fld:'vTFBR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV42TFBR_Pathology_Other_Low_To',fld:'vTFBR_PATHOLOGY_OTHER_LOW_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV45TFBR_Pathology_Other_High',fld:'vTFBR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV46TFBR_Pathology_Other_High_To',fld:'vTFBR_PATHOLOGY_OTHER_HIGH_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_LOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_HIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86Pgmname',fld:'vPGMNAME',pic:''},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_other_abnind_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_other_abnind_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'FilteredText_get'},{av:'Ddo_br_pathology_other_abnind_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_ABNIND.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV49TFBR_Pathology_Other_AbnInd',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND',pic:''},{av:'AV50TFBR_Pathology_Other_AbnInd_Sel',fld:'vTFBR_PATHOLOGY_OTHER_ABNIND_SEL',pic:''},{av:'Ddo_br_pathology_otherid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHERID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_bioqual_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIOQUAL',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_low_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_LOW',prop:'SortedStatus'},{av:'Ddo_br_pathology_other_high_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_HIGH',prop:'SortedStatus'},{av:'AV16BR_Pathology_OtherIDTitleFilterData',fld:'vBR_PATHOLOGY_OTHERIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Other_BioQualTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOQUALTITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Other_LowTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_LOWTITLEFILTERDATA',pic:''},{av:'AV44BR_Pathology_Other_HighTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_HIGHTITLEFILTERDATA',pic:''},{av:'AV48BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_OtherID_Titleformat',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Titleformat'},{av:'edtBR_Pathology_OtherID_Title',ctrl:'BR_PATHOLOGY_OTHERID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_BioQual_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioQual_Title',ctrl:'BR_PATHOLOGY_OTHER_BIOQUAL',prop:'Title'},{av:'edtBR_Pathology_Other_Low_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Low_Title',ctrl:'BR_PATHOLOGY_OTHER_LOW',prop:'Title'},{av:'edtBR_Pathology_Other_High_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Titleformat'},{av:'edtBR_Pathology_Other_High_Title',ctrl:'BR_PATHOLOGY_OTHER_HIGH',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E25572',iparms:[{av:'A288BR_Pathology_OtherID',fld:'BR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV59IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV61IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV57Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV58Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV60Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E22572',iparms:[{av:'A288BR_Pathology_OtherID',fld:'BR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_pathology_otherid_Activeeventkey = "";
         Ddo_br_pathology_otherid_Filteredtext_get = "";
         Ddo_br_pathology_otherid_Filteredtextto_get = "";
         Ddo_br_pathologyid_Activeeventkey = "";
         Ddo_br_pathologyid_Filteredtext_get = "";
         Ddo_br_pathologyid_Filteredtextto_get = "";
         Ddo_br_pathology_other_bio_Activeeventkey = "";
         Ddo_br_pathology_other_bio_Filteredtext_get = "";
         Ddo_br_pathology_other_bio_Selectedvalue_get = "";
         Ddo_br_pathology_other_bionum_Activeeventkey = "";
         Ddo_br_pathology_other_bionum_Filteredtext_get = "";
         Ddo_br_pathology_other_bionum_Filteredtextto_get = "";
         Ddo_br_pathology_other_bionumunit_Activeeventkey = "";
         Ddo_br_pathology_other_bionumunit_Filteredtext_get = "";
         Ddo_br_pathology_other_bionumunit_Selectedvalue_get = "";
         Ddo_br_pathology_other_bioqual_Activeeventkey = "";
         Ddo_br_pathology_other_bioqual_Filteredtext_get = "";
         Ddo_br_pathology_other_bioqual_Selectedvalue_get = "";
         Ddo_br_pathology_other_low_Activeeventkey = "";
         Ddo_br_pathology_other_low_Filteredtext_get = "";
         Ddo_br_pathology_other_low_Filteredtextto_get = "";
         Ddo_br_pathology_other_high_Activeeventkey = "";
         Ddo_br_pathology_other_high_Filteredtext_get = "";
         Ddo_br_pathology_other_high_Filteredtextto_get = "";
         Ddo_br_pathology_other_abnind_Activeeventkey = "";
         Ddo_br_pathology_other_abnind_Filteredtext_get = "";
         Ddo_br_pathology_other_abnind_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25TFBR_Pathology_Other_Bio = "";
         AV26TFBR_Pathology_Other_Bio_Sel = "";
         AV33TFBR_Pathology_Other_BioNumUnit = "";
         AV34TFBR_Pathology_Other_BioNumUnit_Sel = "";
         AV37TFBR_Pathology_Other_BioQual = "";
         AV38TFBR_Pathology_Other_BioQual_Sel = "";
         AV49TFBR_Pathology_Other_AbnInd = "";
         AV50TFBR_Pathology_Other_AbnInd_Sel = "";
         AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace = "";
         AV23ddo_BR_PathologyIDTitleControlIdToReplace = "";
         AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace = "";
         AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = "";
         AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = "";
         AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace = "";
         AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace = "";
         AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace = "";
         AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = "";
         AV86Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV52DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_Pathology_OtherIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Pathology_Other_BioTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Pathology_Other_BioNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Pathology_Other_BioNumUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Pathology_Other_BioQualTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Pathology_Other_LowTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV44BR_Pathology_Other_HighTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV48BR_Pathology_Other_AbnIndTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_pathology_otherid_Filteredtext_set = "";
         Ddo_br_pathology_otherid_Filteredtextto_set = "";
         Ddo_br_pathology_otherid_Sortedstatus = "";
         Ddo_br_pathologyid_Filteredtext_set = "";
         Ddo_br_pathologyid_Filteredtextto_set = "";
         Ddo_br_pathologyid_Sortedstatus = "";
         Ddo_br_pathology_other_bio_Filteredtext_set = "";
         Ddo_br_pathology_other_bio_Selectedvalue_set = "";
         Ddo_br_pathology_other_bio_Sortedstatus = "";
         Ddo_br_pathology_other_bionum_Filteredtext_set = "";
         Ddo_br_pathology_other_bionum_Filteredtextto_set = "";
         Ddo_br_pathology_other_bionum_Sortedstatus = "";
         Ddo_br_pathology_other_bionumunit_Filteredtext_set = "";
         Ddo_br_pathology_other_bionumunit_Selectedvalue_set = "";
         Ddo_br_pathology_other_bionumunit_Sortedstatus = "";
         Ddo_br_pathology_other_bioqual_Filteredtext_set = "";
         Ddo_br_pathology_other_bioqual_Selectedvalue_set = "";
         Ddo_br_pathology_other_bioqual_Sortedstatus = "";
         Ddo_br_pathology_other_low_Filteredtext_set = "";
         Ddo_br_pathology_other_low_Filteredtextto_set = "";
         Ddo_br_pathology_other_low_Sortedstatus = "";
         Ddo_br_pathology_other_high_Filteredtext_set = "";
         Ddo_br_pathology_other_high_Filteredtextto_set = "";
         Ddo_br_pathology_other_high_Sortedstatus = "";
         Ddo_br_pathology_other_abnind_Filteredtext_set = "";
         Ddo_br_pathology_other_abnind_Selectedvalue_set = "";
         Ddo_br_pathology_other_abnind_Sortedstatus = "";
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
         AV57Display = "";
         AV58Update = "";
         AV60Delete = "";
         A289BR_Pathology_Other_Bio = "";
         A291BR_Pathology_Other_BioNumUnit = "";
         A292BR_Pathology_Other_BioQual = "";
         A295BR_Pathology_Other_AbnInd = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_pathology_otherid = new GXUserControl();
         ucDdo_br_pathologyid = new GXUserControl();
         ucDdo_br_pathology_other_bio = new GXUserControl();
         ucDdo_br_pathology_other_bionum = new GXUserControl();
         ucDdo_br_pathology_other_bionumunit = new GXUserControl();
         ucDdo_br_pathology_other_bioqual = new GXUserControl();
         ucDdo_br_pathology_other_low = new GXUserControl();
         ucDdo_br_pathology_other_high = new GXUserControl();
         ucDdo_br_pathology_other_abnind = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV83Display_GXI = "";
         AV84Update_GXI = "";
         AV85Delete_GXI = "";
         scmdbuf = "";
         lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = "";
         lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = "";
         lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = "";
         lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = "";
         AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = "";
         AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = "";
         AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = "";
         AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = "";
         AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = "";
         AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = "";
         AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = "";
         AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = "";
         H00572_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         H00572_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         H00572_A294BR_Pathology_Other_High = new decimal[1] ;
         H00572_n294BR_Pathology_Other_High = new bool[] {false} ;
         H00572_A293BR_Pathology_Other_Low = new decimal[1] ;
         H00572_n293BR_Pathology_Other_Low = new bool[] {false} ;
         H00572_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         H00572_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         H00572_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         H00572_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         H00572_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         H00572_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         H00572_A289BR_Pathology_Other_Bio = new String[] {""} ;
         H00572_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         H00572_A226BR_PathologyID = new long[1] ;
         H00572_n226BR_PathologyID = new bool[] {false} ;
         H00572_A288BR_Pathology_OtherID = new long[1] ;
         H00573_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_otherww__default(),
            new Object[][] {
                new Object[] {
               H00572_A295BR_Pathology_Other_AbnInd, H00572_n295BR_Pathology_Other_AbnInd, H00572_A294BR_Pathology_Other_High, H00572_n294BR_Pathology_Other_High, H00572_A293BR_Pathology_Other_Low, H00572_n293BR_Pathology_Other_Low, H00572_A292BR_Pathology_Other_BioQual, H00572_n292BR_Pathology_Other_BioQual, H00572_A291BR_Pathology_Other_BioNumUnit, H00572_n291BR_Pathology_Other_BioNumUnit,
               H00572_A290BR_Pathology_Other_BioNum, H00572_n290BR_Pathology_Other_BioNum, H00572_A289BR_Pathology_Other_Bio, H00572_n289BR_Pathology_Other_Bio, H00572_A226BR_PathologyID, H00572_n226BR_PathologyID, H00572_A288BR_Pathology_OtherID
               }
               , new Object[] {
               H00573_AGRID_nRecordCount
               }
            }
         );
         AV86Pgmname = "BR_Pathology_OtherWW";
         /* GeneXus formulas. */
         AV86Pgmname = "BR_Pathology_OtherWW";
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
      private int Ddo_br_pathology_other_bio_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathology_other_bionumunit_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathology_other_bioqual_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathology_other_abnind_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
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
      private int edtavTfbr_pathology_otherid_Visible ;
      private int edtavTfbr_pathology_otherid_to_Visible ;
      private int edtavTfbr_pathologyid_Visible ;
      private int edtavTfbr_pathologyid_to_Visible ;
      private int edtavTfbr_pathology_other_bio_Visible ;
      private int edtavTfbr_pathology_other_bio_sel_Visible ;
      private int edtavTfbr_pathology_other_bionum_Visible ;
      private int edtavTfbr_pathology_other_bionum_to_Visible ;
      private int edtavTfbr_pathology_other_bionumunit_Visible ;
      private int edtavTfbr_pathology_other_bionumunit_sel_Visible ;
      private int edtavTfbr_pathology_other_bioqual_Visible ;
      private int edtavTfbr_pathology_other_bioqual_sel_Visible ;
      private int edtavTfbr_pathology_other_low_Visible ;
      private int edtavTfbr_pathology_other_low_to_Visible ;
      private int edtavTfbr_pathology_other_high_Visible ;
      private int edtavTfbr_pathology_other_high_to_Visible ;
      private int edtavTfbr_pathology_other_abnind_Visible ;
      private int edtavTfbr_pathology_other_abnind_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV53PageToGo ;
      private int AV87GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_Pathology_OtherID ;
      private long AV18TFBR_Pathology_OtherID_To ;
      private long AV21TFBR_PathologyID ;
      private long AV22TFBR_PathologyID_To ;
      private long AV54GridCurrentPage ;
      private long AV56GridRecordCount ;
      private long AV55GridPageSize ;
      private long A288BR_Pathology_OtherID ;
      private long A226BR_PathologyID ;
      private long GRID_nCurrentRecord ;
      private long AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ;
      private long AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ;
      private long AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ;
      private long AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ;
      private long GRID_nRecordCount ;
      private decimal AV29TFBR_Pathology_Other_BioNum ;
      private decimal AV30TFBR_Pathology_Other_BioNum_To ;
      private decimal AV41TFBR_Pathology_Other_Low ;
      private decimal AV42TFBR_Pathology_Other_Low_To ;
      private decimal AV45TFBR_Pathology_Other_High ;
      private decimal AV46TFBR_Pathology_Other_High_To ;
      private decimal A290BR_Pathology_Other_BioNum ;
      private decimal A293BR_Pathology_Other_Low ;
      private decimal A294BR_Pathology_Other_High ;
      private decimal AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ;
      private decimal AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ;
      private decimal AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ;
      private decimal AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ;
      private decimal AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ;
      private decimal AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_pathology_otherid_Activeeventkey ;
      private String Ddo_br_pathology_otherid_Filteredtext_get ;
      private String Ddo_br_pathology_otherid_Filteredtextto_get ;
      private String Ddo_br_pathologyid_Activeeventkey ;
      private String Ddo_br_pathologyid_Filteredtext_get ;
      private String Ddo_br_pathologyid_Filteredtextto_get ;
      private String Ddo_br_pathology_other_bio_Activeeventkey ;
      private String Ddo_br_pathology_other_bio_Filteredtext_get ;
      private String Ddo_br_pathology_other_bio_Selectedvalue_get ;
      private String Ddo_br_pathology_other_bionum_Activeeventkey ;
      private String Ddo_br_pathology_other_bionum_Filteredtext_get ;
      private String Ddo_br_pathology_other_bionum_Filteredtextto_get ;
      private String Ddo_br_pathology_other_bionumunit_Activeeventkey ;
      private String Ddo_br_pathology_other_bionumunit_Filteredtext_get ;
      private String Ddo_br_pathology_other_bionumunit_Selectedvalue_get ;
      private String Ddo_br_pathology_other_bioqual_Activeeventkey ;
      private String Ddo_br_pathology_other_bioqual_Filteredtext_get ;
      private String Ddo_br_pathology_other_bioqual_Selectedvalue_get ;
      private String Ddo_br_pathology_other_low_Activeeventkey ;
      private String Ddo_br_pathology_other_low_Filteredtext_get ;
      private String Ddo_br_pathology_other_low_Filteredtextto_get ;
      private String Ddo_br_pathology_other_high_Activeeventkey ;
      private String Ddo_br_pathology_other_high_Filteredtext_get ;
      private String Ddo_br_pathology_other_high_Filteredtextto_get ;
      private String Ddo_br_pathology_other_abnind_Activeeventkey ;
      private String Ddo_br_pathology_other_abnind_Filteredtext_get ;
      private String Ddo_br_pathology_other_abnind_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV86Pgmname ;
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
      private String Ddo_br_pathology_otherid_Caption ;
      private String Ddo_br_pathology_otherid_Tooltip ;
      private String Ddo_br_pathology_otherid_Cls ;
      private String Ddo_br_pathology_otherid_Filteredtext_set ;
      private String Ddo_br_pathology_otherid_Filteredtextto_set ;
      private String Ddo_br_pathology_otherid_Dropdownoptionstype ;
      private String Ddo_br_pathology_otherid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_otherid_Sortedstatus ;
      private String Ddo_br_pathology_otherid_Filtertype ;
      private String Ddo_br_pathology_otherid_Sortasc ;
      private String Ddo_br_pathology_otherid_Sortdsc ;
      private String Ddo_br_pathology_otherid_Cleanfilter ;
      private String Ddo_br_pathology_otherid_Rangefilterfrom ;
      private String Ddo_br_pathology_otherid_Rangefilterto ;
      private String Ddo_br_pathology_otherid_Searchbuttontext ;
      private String Ddo_br_pathologyid_Caption ;
      private String Ddo_br_pathologyid_Tooltip ;
      private String Ddo_br_pathologyid_Cls ;
      private String Ddo_br_pathologyid_Filteredtext_set ;
      private String Ddo_br_pathologyid_Filteredtextto_set ;
      private String Ddo_br_pathologyid_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_Sortedstatus ;
      private String Ddo_br_pathologyid_Filtertype ;
      private String Ddo_br_pathologyid_Sortasc ;
      private String Ddo_br_pathologyid_Sortdsc ;
      private String Ddo_br_pathologyid_Cleanfilter ;
      private String Ddo_br_pathologyid_Rangefilterfrom ;
      private String Ddo_br_pathologyid_Rangefilterto ;
      private String Ddo_br_pathologyid_Searchbuttontext ;
      private String Ddo_br_pathology_other_bio_Caption ;
      private String Ddo_br_pathology_other_bio_Tooltip ;
      private String Ddo_br_pathology_other_bio_Cls ;
      private String Ddo_br_pathology_other_bio_Filteredtext_set ;
      private String Ddo_br_pathology_other_bio_Selectedvalue_set ;
      private String Ddo_br_pathology_other_bio_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bio_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bio_Sortedstatus ;
      private String Ddo_br_pathology_other_bio_Filtertype ;
      private String Ddo_br_pathology_other_bio_Datalisttype ;
      private String Ddo_br_pathology_other_bio_Datalistproc ;
      private String Ddo_br_pathology_other_bio_Sortasc ;
      private String Ddo_br_pathology_other_bio_Sortdsc ;
      private String Ddo_br_pathology_other_bio_Loadingdata ;
      private String Ddo_br_pathology_other_bio_Cleanfilter ;
      private String Ddo_br_pathology_other_bio_Noresultsfound ;
      private String Ddo_br_pathology_other_bio_Searchbuttontext ;
      private String Ddo_br_pathology_other_bionum_Caption ;
      private String Ddo_br_pathology_other_bionum_Tooltip ;
      private String Ddo_br_pathology_other_bionum_Cls ;
      private String Ddo_br_pathology_other_bionum_Filteredtext_set ;
      private String Ddo_br_pathology_other_bionum_Filteredtextto_set ;
      private String Ddo_br_pathology_other_bionum_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bionum_Sortedstatus ;
      private String Ddo_br_pathology_other_bionum_Filtertype ;
      private String Ddo_br_pathology_other_bionum_Sortasc ;
      private String Ddo_br_pathology_other_bionum_Sortdsc ;
      private String Ddo_br_pathology_other_bionum_Cleanfilter ;
      private String Ddo_br_pathology_other_bionum_Rangefilterfrom ;
      private String Ddo_br_pathology_other_bionum_Rangefilterto ;
      private String Ddo_br_pathology_other_bionum_Searchbuttontext ;
      private String Ddo_br_pathology_other_bionumunit_Caption ;
      private String Ddo_br_pathology_other_bionumunit_Tooltip ;
      private String Ddo_br_pathology_other_bionumunit_Cls ;
      private String Ddo_br_pathology_other_bionumunit_Filteredtext_set ;
      private String Ddo_br_pathology_other_bionumunit_Selectedvalue_set ;
      private String Ddo_br_pathology_other_bionumunit_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bionumunit_Sortedstatus ;
      private String Ddo_br_pathology_other_bionumunit_Filtertype ;
      private String Ddo_br_pathology_other_bionumunit_Datalisttype ;
      private String Ddo_br_pathology_other_bionumunit_Datalistproc ;
      private String Ddo_br_pathology_other_bionumunit_Sortasc ;
      private String Ddo_br_pathology_other_bionumunit_Sortdsc ;
      private String Ddo_br_pathology_other_bionumunit_Loadingdata ;
      private String Ddo_br_pathology_other_bionumunit_Cleanfilter ;
      private String Ddo_br_pathology_other_bionumunit_Noresultsfound ;
      private String Ddo_br_pathology_other_bionumunit_Searchbuttontext ;
      private String Ddo_br_pathology_other_bioqual_Caption ;
      private String Ddo_br_pathology_other_bioqual_Tooltip ;
      private String Ddo_br_pathology_other_bioqual_Cls ;
      private String Ddo_br_pathology_other_bioqual_Filteredtext_set ;
      private String Ddo_br_pathology_other_bioqual_Selectedvalue_set ;
      private String Ddo_br_pathology_other_bioqual_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bioqual_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bioqual_Sortedstatus ;
      private String Ddo_br_pathology_other_bioqual_Filtertype ;
      private String Ddo_br_pathology_other_bioqual_Datalisttype ;
      private String Ddo_br_pathology_other_bioqual_Datalistproc ;
      private String Ddo_br_pathology_other_bioqual_Sortasc ;
      private String Ddo_br_pathology_other_bioqual_Sortdsc ;
      private String Ddo_br_pathology_other_bioqual_Loadingdata ;
      private String Ddo_br_pathology_other_bioqual_Cleanfilter ;
      private String Ddo_br_pathology_other_bioqual_Noresultsfound ;
      private String Ddo_br_pathology_other_bioqual_Searchbuttontext ;
      private String Ddo_br_pathology_other_low_Caption ;
      private String Ddo_br_pathology_other_low_Tooltip ;
      private String Ddo_br_pathology_other_low_Cls ;
      private String Ddo_br_pathology_other_low_Filteredtext_set ;
      private String Ddo_br_pathology_other_low_Filteredtextto_set ;
      private String Ddo_br_pathology_other_low_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_low_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_low_Sortedstatus ;
      private String Ddo_br_pathology_other_low_Filtertype ;
      private String Ddo_br_pathology_other_low_Sortasc ;
      private String Ddo_br_pathology_other_low_Sortdsc ;
      private String Ddo_br_pathology_other_low_Cleanfilter ;
      private String Ddo_br_pathology_other_low_Rangefilterfrom ;
      private String Ddo_br_pathology_other_low_Rangefilterto ;
      private String Ddo_br_pathology_other_low_Searchbuttontext ;
      private String Ddo_br_pathology_other_high_Caption ;
      private String Ddo_br_pathology_other_high_Tooltip ;
      private String Ddo_br_pathology_other_high_Cls ;
      private String Ddo_br_pathology_other_high_Filteredtext_set ;
      private String Ddo_br_pathology_other_high_Filteredtextto_set ;
      private String Ddo_br_pathology_other_high_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_high_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_high_Sortedstatus ;
      private String Ddo_br_pathology_other_high_Filtertype ;
      private String Ddo_br_pathology_other_high_Sortasc ;
      private String Ddo_br_pathology_other_high_Sortdsc ;
      private String Ddo_br_pathology_other_high_Cleanfilter ;
      private String Ddo_br_pathology_other_high_Rangefilterfrom ;
      private String Ddo_br_pathology_other_high_Rangefilterto ;
      private String Ddo_br_pathology_other_high_Searchbuttontext ;
      private String Ddo_br_pathology_other_abnind_Caption ;
      private String Ddo_br_pathology_other_abnind_Tooltip ;
      private String Ddo_br_pathology_other_abnind_Cls ;
      private String Ddo_br_pathology_other_abnind_Filteredtext_set ;
      private String Ddo_br_pathology_other_abnind_Selectedvalue_set ;
      private String Ddo_br_pathology_other_abnind_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_abnind_Sortedstatus ;
      private String Ddo_br_pathology_other_abnind_Filtertype ;
      private String Ddo_br_pathology_other_abnind_Datalisttype ;
      private String Ddo_br_pathology_other_abnind_Datalistproc ;
      private String Ddo_br_pathology_other_abnind_Sortasc ;
      private String Ddo_br_pathology_other_abnind_Sortdsc ;
      private String Ddo_br_pathology_other_abnind_Loadingdata ;
      private String Ddo_br_pathology_other_abnind_Cleanfilter ;
      private String Ddo_br_pathology_other_abnind_Noresultsfound ;
      private String Ddo_br_pathology_other_abnind_Searchbuttontext ;
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
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_pathology_otherid_Internalname ;
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
      private String edtavTfbr_pathology_otherid_Internalname ;
      private String edtavTfbr_pathology_otherid_Jsonclick ;
      private String edtavTfbr_pathology_otherid_to_Internalname ;
      private String edtavTfbr_pathology_otherid_to_Jsonclick ;
      private String edtavTfbr_pathologyid_Internalname ;
      private String edtavTfbr_pathologyid_Jsonclick ;
      private String edtavTfbr_pathologyid_to_Internalname ;
      private String edtavTfbr_pathologyid_to_Jsonclick ;
      private String edtavTfbr_pathology_other_bio_Internalname ;
      private String edtavTfbr_pathology_other_bio_Jsonclick ;
      private String edtavTfbr_pathology_other_bio_sel_Internalname ;
      private String edtavTfbr_pathology_other_bio_sel_Jsonclick ;
      private String edtavTfbr_pathology_other_bionum_Internalname ;
      private String edtavTfbr_pathology_other_bionum_Jsonclick ;
      private String edtavTfbr_pathology_other_bionum_to_Internalname ;
      private String edtavTfbr_pathology_other_bionum_to_Jsonclick ;
      private String edtavTfbr_pathology_other_bionumunit_Internalname ;
      private String edtavTfbr_pathology_other_bionumunit_Jsonclick ;
      private String edtavTfbr_pathology_other_bionumunit_sel_Internalname ;
      private String edtavTfbr_pathology_other_bionumunit_sel_Jsonclick ;
      private String edtavTfbr_pathology_other_bioqual_Internalname ;
      private String edtavTfbr_pathology_other_bioqual_Jsonclick ;
      private String edtavTfbr_pathology_other_bioqual_sel_Internalname ;
      private String edtavTfbr_pathology_other_bioqual_sel_Jsonclick ;
      private String edtavTfbr_pathology_other_low_Internalname ;
      private String edtavTfbr_pathology_other_low_Jsonclick ;
      private String edtavTfbr_pathology_other_low_to_Internalname ;
      private String edtavTfbr_pathology_other_low_to_Jsonclick ;
      private String edtavTfbr_pathology_other_high_Internalname ;
      private String edtavTfbr_pathology_other_high_Jsonclick ;
      private String edtavTfbr_pathology_other_high_to_Internalname ;
      private String edtavTfbr_pathology_other_high_to_Jsonclick ;
      private String edtavTfbr_pathology_other_abnind_Internalname ;
      private String edtavTfbr_pathology_other_abnind_Jsonclick ;
      private String edtavTfbr_pathology_other_abnind_sel_Internalname ;
      private String edtavTfbr_pathology_other_abnind_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
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
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
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
      private bool AV14OrderedDsc ;
      private bool AV59IsAuthorized_Update ;
      private bool AV61IsAuthorized_Delete ;
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
      private bool Ddo_br_pathology_otherid_Includesortasc ;
      private bool Ddo_br_pathology_otherid_Includesortdsc ;
      private bool Ddo_br_pathology_otherid_Includefilter ;
      private bool Ddo_br_pathology_otherid_Filterisrange ;
      private bool Ddo_br_pathology_otherid_Includedatalist ;
      private bool Ddo_br_pathologyid_Includesortasc ;
      private bool Ddo_br_pathologyid_Includesortdsc ;
      private bool Ddo_br_pathologyid_Includefilter ;
      private bool Ddo_br_pathologyid_Filterisrange ;
      private bool Ddo_br_pathologyid_Includedatalist ;
      private bool Ddo_br_pathology_other_bio_Includesortasc ;
      private bool Ddo_br_pathology_other_bio_Includesortdsc ;
      private bool Ddo_br_pathology_other_bio_Includefilter ;
      private bool Ddo_br_pathology_other_bio_Filterisrange ;
      private bool Ddo_br_pathology_other_bio_Includedatalist ;
      private bool Ddo_br_pathology_other_bionum_Includesortasc ;
      private bool Ddo_br_pathology_other_bionum_Includesortdsc ;
      private bool Ddo_br_pathology_other_bionum_Includefilter ;
      private bool Ddo_br_pathology_other_bionum_Filterisrange ;
      private bool Ddo_br_pathology_other_bionum_Includedatalist ;
      private bool Ddo_br_pathology_other_bionumunit_Includesortasc ;
      private bool Ddo_br_pathology_other_bionumunit_Includesortdsc ;
      private bool Ddo_br_pathology_other_bionumunit_Includefilter ;
      private bool Ddo_br_pathology_other_bionumunit_Filterisrange ;
      private bool Ddo_br_pathology_other_bionumunit_Includedatalist ;
      private bool Ddo_br_pathology_other_bioqual_Includesortasc ;
      private bool Ddo_br_pathology_other_bioqual_Includesortdsc ;
      private bool Ddo_br_pathology_other_bioqual_Includefilter ;
      private bool Ddo_br_pathology_other_bioqual_Filterisrange ;
      private bool Ddo_br_pathology_other_bioqual_Includedatalist ;
      private bool Ddo_br_pathology_other_low_Includesortasc ;
      private bool Ddo_br_pathology_other_low_Includesortdsc ;
      private bool Ddo_br_pathology_other_low_Includefilter ;
      private bool Ddo_br_pathology_other_low_Filterisrange ;
      private bool Ddo_br_pathology_other_low_Includedatalist ;
      private bool Ddo_br_pathology_other_high_Includesortasc ;
      private bool Ddo_br_pathology_other_high_Includesortdsc ;
      private bool Ddo_br_pathology_other_high_Includefilter ;
      private bool Ddo_br_pathology_other_high_Filterisrange ;
      private bool Ddo_br_pathology_other_high_Includedatalist ;
      private bool Ddo_br_pathology_other_abnind_Includesortasc ;
      private bool Ddo_br_pathology_other_abnind_Includesortdsc ;
      private bool Ddo_br_pathology_other_abnind_Includefilter ;
      private bool Ddo_br_pathology_other_abnind_Filterisrange ;
      private bool Ddo_br_pathology_other_abnind_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
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
      private bool gx_refresh_fired ;
      private bool AV62TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV57Display_IsBlob ;
      private bool AV58Update_IsBlob ;
      private bool AV60Delete_IsBlob ;
      private String AV25TFBR_Pathology_Other_Bio ;
      private String AV26TFBR_Pathology_Other_Bio_Sel ;
      private String AV33TFBR_Pathology_Other_BioNumUnit ;
      private String AV34TFBR_Pathology_Other_BioNumUnit_Sel ;
      private String AV37TFBR_Pathology_Other_BioQual ;
      private String AV38TFBR_Pathology_Other_BioQual_Sel ;
      private String AV49TFBR_Pathology_Other_AbnInd ;
      private String AV50TFBR_Pathology_Other_AbnInd_Sel ;
      private String AV19ddo_BR_Pathology_OtherIDTitleControlIdToReplace ;
      private String AV23ddo_BR_PathologyIDTitleControlIdToReplace ;
      private String AV27ddo_BR_Pathology_Other_BioTitleControlIdToReplace ;
      private String AV31ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace ;
      private String AV35ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace ;
      private String AV39ddo_BR_Pathology_Other_BioQualTitleControlIdToReplace ;
      private String AV43ddo_BR_Pathology_Other_LowTitleControlIdToReplace ;
      private String AV47ddo_BR_Pathology_Other_HighTitleControlIdToReplace ;
      private String AV51ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace ;
      private String A289BR_Pathology_Other_Bio ;
      private String A291BR_Pathology_Other_BioNumUnit ;
      private String A292BR_Pathology_Other_BioQual ;
      private String A295BR_Pathology_Other_AbnInd ;
      private String AV83Display_GXI ;
      private String AV84Update_GXI ;
      private String AV85Delete_GXI ;
      private String lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ;
      private String lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ;
      private String lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ;
      private String lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ;
      private String AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ;
      private String AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ;
      private String AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ;
      private String AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ;
      private String AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ;
      private String AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ;
      private String AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ;
      private String AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ;
      private String AV57Display ;
      private String AV58Update ;
      private String AV60Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
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
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00572_A295BR_Pathology_Other_AbnInd ;
      private bool[] H00572_n295BR_Pathology_Other_AbnInd ;
      private decimal[] H00572_A294BR_Pathology_Other_High ;
      private bool[] H00572_n294BR_Pathology_Other_High ;
      private decimal[] H00572_A293BR_Pathology_Other_Low ;
      private bool[] H00572_n293BR_Pathology_Other_Low ;
      private String[] H00572_A292BR_Pathology_Other_BioQual ;
      private bool[] H00572_n292BR_Pathology_Other_BioQual ;
      private String[] H00572_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] H00572_n291BR_Pathology_Other_BioNumUnit ;
      private decimal[] H00572_A290BR_Pathology_Other_BioNum ;
      private bool[] H00572_n290BR_Pathology_Other_BioNum ;
      private String[] H00572_A289BR_Pathology_Other_Bio ;
      private bool[] H00572_n289BR_Pathology_Other_Bio ;
      private long[] H00572_A226BR_PathologyID ;
      private bool[] H00572_n226BR_PathologyID ;
      private long[] H00572_A288BR_Pathology_OtherID ;
      private long[] H00573_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Pathology_OtherIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_PathologyIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Pathology_Other_BioTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Pathology_Other_BioNumTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Pathology_Other_BioNumUnitTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36BR_Pathology_Other_BioQualTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV40BR_Pathology_Other_LowTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV44BR_Pathology_Other_HighTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV48BR_Pathology_Other_AbnIndTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV52DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_pathology_otherww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00572( IGxContext context ,
                                             long AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                             long AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                             long AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                             long AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                             String AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                             String AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                             decimal AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                             decimal AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                             String AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                             String AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                             String AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                             String AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                             decimal AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                             decimal AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                             decimal AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                             decimal AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                             String AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                             String AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                             long A288BR_Pathology_OtherID ,
                                             long A226BR_PathologyID ,
                                             String A289BR_Pathology_Other_Bio ,
                                             decimal A290BR_Pathology_Other_BioNum ,
                                             String A291BR_Pathology_Other_BioNumUnit ,
                                             String A292BR_Pathology_Other_BioQual ,
                                             decimal A293BR_Pathology_Other_Low ,
                                             decimal A294BR_Pathology_Other_High ,
                                             String A295BR_Pathology_Other_AbnInd ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [21] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Pathology_Other_AbnInd], [BR_Pathology_Other_High], [BR_Pathology_Other_Low], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_Bio], [BR_PathologyID], [BR_Pathology_OtherID]";
         sFromString = " FROM [BR_Pathology_Other] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] >= @AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] >= @AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] <= @AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] <= @AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] like @lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] like @lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] = @AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] = @AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] >= @AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] >= @AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] <= @AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] <= @AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] like @lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] like @lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] = @AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] = @AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] like @lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] like @lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] = @AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] = @AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] >= @AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] >= @AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] <= @AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] <= @AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] >= @AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] >= @AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
         }
         else
         {
            GXv_int3[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] <= @AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] <= @AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
         }
         else
         {
            GXv_int3[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] like @lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] like @lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
         }
         else
         {
            GXv_int3[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] = @AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] = @AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
         }
         else
         {
            GXv_int3[17] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_OtherID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_OtherID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_Bio]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_Bio] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioNum]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioNum] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioNumUnit]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioNumUnit] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioQual]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_BioQual] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_Low]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_Low] DESC";
         }
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_High]";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_High] DESC";
         }
         else if ( ( AV13OrderedBy == 9 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Other_AbnInd]";
         }
         else if ( ( AV13OrderedBy == 9 ) && ( AV14OrderedDsc ) )
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

      protected Object[] conditional_H00573( IGxContext context ,
                                             long AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                             long AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                             long AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                             long AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                             String AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                             String AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                             decimal AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                             decimal AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                             String AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                             String AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                             String AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                             String AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                             decimal AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                             decimal AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                             decimal AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                             decimal AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                             String AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                             String AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                             long A288BR_Pathology_OtherID ,
                                             long A226BR_PathologyID ,
                                             String A289BR_Pathology_Other_Bio ,
                                             decimal A290BR_Pathology_Other_BioNum ,
                                             String A291BR_Pathology_Other_BioNumUnit ,
                                             String A292BR_Pathology_Other_BioQual ,
                                             decimal A293BR_Pathology_Other_Low ,
                                             decimal A294BR_Pathology_Other_High ,
                                             String A295BR_Pathology_Other_AbnInd ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [18] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Pathology_Other] WITH (NOLOCK)";
         if ( ! (0==AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] >= @AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] >= @AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] <= @AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] <= @AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] like @lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] like @lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] = @AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] = @AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] >= @AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] >= @AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] <= @AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] <= @AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] like @lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] like @lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] = @AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] = @AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] like @lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] like @lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] = @AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] = @AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] >= @AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] >= @AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] <= @AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] <= @AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
         }
         else
         {
            GXv_int5[13] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] >= @AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] >= @AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
         }
         else
         {
            GXv_int5[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] <= @AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] <= @AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
         }
         else
         {
            GXv_int5[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] like @lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] like @lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
         }
         else
         {
            GXv_int5[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] = @AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] = @AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
         }
         else
         {
            GXv_int5[17] = 1;
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
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 9 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 9 ) && ( AV14OrderedDsc ) )
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
                     return conditional_H00572(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (decimal)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (long)dynConstraints[18] , (long)dynConstraints[19] , (String)dynConstraints[20] , (decimal)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (String)dynConstraints[26] , (short)dynConstraints[27] , (bool)dynConstraints[28] );
               case 1 :
                     return conditional_H00573(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (decimal)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (long)dynConstraints[18] , (long)dynConstraints[19] , (String)dynConstraints[20] , (decimal)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (String)dynConstraints[26] , (short)dynConstraints[27] , (bool)dynConstraints[28] );
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
          Object[] prmH00572 ;
          prmH00572 = new Object[] {
          new Object[] {"@AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00573 ;
          prmH00573 = new Object[] {
          new Object[] {"@AV65BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV67BR_Pathology_OtherWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV68BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV69BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV70BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV71BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV72BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV73BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV74BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV75BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV76BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV77BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV78BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV79BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV80BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV81BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV82BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00572", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00572,11,0,true,false )
             ,new CursorDef("H00573", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00573,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (long)parms[21]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[24]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[27]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[28]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[30]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[31]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[33]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[34]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[35]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[36]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[39]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[40]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[41]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[21]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[24]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[25]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[30]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[31]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[32]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[33]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                return;
       }
    }

 }

}
