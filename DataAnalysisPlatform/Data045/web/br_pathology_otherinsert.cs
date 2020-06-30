/*
               File: BR_Pathology_OtherInsert
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:17:3.77
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
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_pathology_otherinsert : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathology_otherinsert( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_otherinsert( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_PathologyID )
      {
         this.AV17BR_PathologyID = aP0_BR_PathologyID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavZlname = new GXCombobox();
         dynavBr_pathology_other_br_pathology_other_bionumunit = new GXCombobox();
         dynavVname = new GXCombobox();
         dynavBr_pathology_other_br_pathology_other_bio = new GXCombobox();
         dynavBr_pathology_other_br_pathology_other_bioqual = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vZLNAME") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvZLNAME952( AV16tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT952( AV16tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVNAME") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVNAME952( AV16tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO952( AV16tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL952( AV16tCurrentCode) ;
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
               AV17BR_PathologyID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17BR_PathologyID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA952( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START952( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281517384", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_otherinsert.aspx") + "?" + UrlEncode("" +AV17BR_PathologyID)+"\">") ;
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
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_pathology_other", AV10BR_Pathology_Other);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_pathology_other", AV10BR_Pathology_Other);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER", AV10BR_Pathology_Other);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER", AV10BR_Pathology_Other);
         }
         GxWebStd.gx_hidden_field( context, "vBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV16tCurrentCode);
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
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
            WE952( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT952( ) ;
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
         return formatLink("br_pathology_otherinsert.aspx") + "?" + UrlEncode("" +AV17BR_PathologyID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Pathology_OtherInsert" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB950( )
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableattributes.SetProperty("Width", Dvpanel_tableattributes_Width);
            ucDvpanel_tableattributes.SetProperty("AutoWidth", Dvpanel_tableattributes_Autowidth);
            ucDvpanel_tableattributes.SetProperty("AutoHeight", Dvpanel_tableattributes_Autoheight);
            ucDvpanel_tableattributes.SetProperty("Cls", Dvpanel_tableattributes_Cls);
            ucDvpanel_tableattributes.SetProperty("Title", Dvpanel_tableattributes_Title);
            ucDvpanel_tableattributes.SetProperty("Collapsible", Dvpanel_tableattributes_Collapsible);
            ucDvpanel_tableattributes.SetProperty("Collapsed", Dvpanel_tableattributes_Collapsed);
            ucDvpanel_tableattributes.SetProperty("ShowCollapseIcon", Dvpanel_tableattributes_Showcollapseicon);
            ucDvpanel_tableattributes.SetProperty("IconPosition", Dvpanel_tableattributes_Iconposition);
            ucDvpanel_tableattributes.SetProperty("AutoScroll", Dvpanel_tableattributes_Autoscroll);
            ucDvpanel_tableattributes.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableattributes_Internalname, "DVPANEL_TABLEATTRIBUTESContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedzlname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockzlname_Internalname, "肿瘤标志物", "", "", lblTextblockzlname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            wb_table1_25_952( true) ;
         }
         else
         {
            wb_table1_25_952( false) ;
         }
         return  ;
      }

      protected void wb_table1_25_952e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_br_pathology_other_bionum_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_br_pathology_other_bionum_Internalname, "定量结果", "", "", lblTextblockbr_pathology_other_br_pathology_other_bionum_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_other_br_pathology_other_bionum_Internalname, "定量结果", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathology_other_bionum_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum, 15, 5, ".", "")), ((edtavBr_pathology_other_br_pathology_other_bionum_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathology_other_bionum_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_pathology_other_br_pathology_other_bionum_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_br_pathology_other_bionumunit_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_br_pathology_other_bionumunit_Internalname, "定量结果单位", "", "", lblTextblockbr_pathology_other_br_pathology_other_bionumunit_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_pathology_other_br_pathology_other_bionumunit_Internalname, "定量结果单位", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_pathology_other_br_pathology_other_bionumunit, dynavBr_pathology_other_br_pathology_other_bionumunit_Internalname, StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionumunit), 1, dynavBr_pathology_other_br_pathology_other_bionumunit_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_pathology_other_br_pathology_other_bionumunit.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "", true, "HLP_BR_Pathology_OtherInsert.htm");
            dynavBr_pathology_other_br_pathology_other_bionumunit.CurrentValue = StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionumunit);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_pathology_other_br_pathology_other_bionumunit_Internalname, "Values", (String)(dynavBr_pathology_other_br_pathology_other_bionumunit.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_br_pathology_other_low_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_br_pathology_other_low_Internalname, "参考上限", "", "", lblTextblockbr_pathology_other_br_pathology_other_low_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_other_br_pathology_other_low_Internalname, "参考上限", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathology_other_low_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low, 15, 5, ".", "")), ((edtavBr_pathology_other_br_pathology_other_low_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathology_other_low_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_pathology_other_br_pathology_other_low_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_br_pathology_other_high_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_br_pathology_other_high_Internalname, "参考下限", "", "", lblTextblockbr_pathology_other_br_pathology_other_high_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_other_br_pathology_other_high_Internalname, "参考下限", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathology_other_high_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high, 15, 5, ".", "")), ((edtavBr_pathology_other_br_pathology_other_high_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathology_other_high_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_pathology_other_br_pathology_other_high_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_br_pathology_other_abnind_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_br_pathology_other_abnind_Internalname, "结果提示", "", "", lblTextblockbr_pathology_other_br_pathology_other_abnind_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_other_br_pathology_other_abnind_Internalname, "结果提示", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathology_other_abnind_Internalname, AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind, StringUtil.RTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathology_other_abnind_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_pathology_other_br_pathology_other_abnind_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedvname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvname_Internalname, "定性结果", "", "", lblTextblockvname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            wb_table2_82_952( true) ;
         }
         else
         {
            wb_table2_82_952( false) ;
         }
         return  ;
      }

      protected void wb_table2_82_952e( bool wbgen )
      {
         if ( wbgen )
         {
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "保存", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_OtherInsert.htm");
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
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathology_otherid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Pathology_Other.gxTpr_Br_pathology_otherid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Pathology_Other.gxTpr_Br_pathology_otherid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathology_otherid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_pathology_other_br_pathology_otherid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherInsert.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathologyid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Pathology_Other.gxTpr_Br_pathologyid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Pathology_Other.gxTpr_Br_pathologyid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathologyid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_pathology_other_br_pathologyid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherInsert.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_pathology_other_br_pathology_other_bio, dynavBr_pathology_other_br_pathology_other_bio_Internalname, StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio), 1, dynavBr_pathology_other_br_pathology_other_bio_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", dynavBr_pathology_other_br_pathology_other_bio.Visible, 1, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,104);\"", "", true, "HLP_BR_Pathology_OtherInsert.htm");
            dynavBr_pathology_other_br_pathology_other_bio.CurrentValue = StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_pathology_other_br_pathology_other_bio_Internalname, "Values", (String)(dynavBr_pathology_other_br_pathology_other_bio.ToJavascriptSource()), true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 105,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_pathology_other_br_pathology_other_bioqual, dynavBr_pathology_other_br_pathology_other_bioqual_Internalname, StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual), 1, dynavBr_pathology_other_br_pathology_other_bioqual_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", dynavBr_pathology_other_br_pathology_other_bioqual.Visible, 1, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,105);\"", "", true, "HLP_BR_Pathology_OtherInsert.htm");
            dynavBr_pathology_other_br_pathology_other_bioqual.CurrentValue = StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_pathology_other_br_pathology_other_bioqual_Internalname, "Values", (String)(dynavBr_pathology_other_br_pathology_other_bioqual.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START952( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP950( ) ;
      }

      protected void WS952( )
      {
         START952( ) ;
         EVT952( ) ;
      }

      protected void EVT952( )
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E11952 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E12952 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: Enter */
                                    E13952 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E14952 ();
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
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE952( )
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

      protected void PA952( )
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
               GX_FocusControl = dynavZlname_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvZLNAME952( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvZLNAME_data952( AV16tCurrentCode) ;
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

      protected void GXVvZLNAME_html952( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvZLNAME_data952( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavZlname.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavZlname.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvZLNAME_data952( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H00952 */
         pr_default.execute(0, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00952_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00952_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT952( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT_data952( AV16tCurrentCode) ;
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

      protected void GXVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT_html952( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT_data952( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_pathology_other_br_pathology_other_bionumunit.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_pathology_other_br_pathology_other_bionumunit.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT_data952( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H00953 */
         pr_default.execute(1, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00953_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00953_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVvVNAME952( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVNAME_data952( AV16tCurrentCode) ;
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

      protected void GXVvVNAME_html952( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVNAME_data952( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVname.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVname.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVNAME_data952( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H00954 */
         pr_default.execute(2, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00954_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00954_A168XT_DefineCodeName[0]);
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO952( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO_data952( AV16tCurrentCode) ;
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

      protected void GXVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO_html952( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO_data952( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_pathology_other_br_pathology_other_bio.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_pathology_other_br_pathology_other_bio.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO_data952( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H00955 */
         pr_default.execute(3, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(3) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00955_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00955_A168XT_DefineCodeName[0]);
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL952( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL_data952( AV16tCurrentCode) ;
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

      protected void GXVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL_html952( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL_data952( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_pathology_other_br_pathology_other_bioqual.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_pathology_other_br_pathology_other_bioqual.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL_data952( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H00956 */
         pr_default.execute(4, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(4) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00956_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00956_A168XT_DefineCodeName[0]);
            pr_default.readNext(4);
         }
         pr_default.close(4);
      }

      protected void send_integrity_hashes( )
      {
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
         if ( dynavZlname.ItemCount > 0 )
         {
            AV11zlName = dynavZlname.getValidValue(AV11zlName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11zlName", AV11zlName);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavZlname.CurrentValue = StringUtil.RTrim( AV11zlName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavZlname_Internalname, "Values", dynavZlname.ToJavascriptSource(), true);
         }
         if ( dynavBr_pathology_other_br_pathology_other_bionumunit.ItemCount > 0 )
         {
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionumunit = dynavBr_pathology_other_br_pathology_other_bionumunit.getValidValue(AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionumunit);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_pathology_other_br_pathology_other_bionumunit.CurrentValue = StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionumunit);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_pathology_other_br_pathology_other_bionumunit_Internalname, "Values", dynavBr_pathology_other_br_pathology_other_bionumunit.ToJavascriptSource(), true);
         }
         if ( dynavVname.ItemCount > 0 )
         {
            AV13vName = dynavVname.getValidValue(AV13vName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vName", AV13vName);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVname.CurrentValue = StringUtil.RTrim( AV13vName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVname_Internalname, "Values", dynavVname.ToJavascriptSource(), true);
         }
         if ( dynavBr_pathology_other_br_pathology_other_bio.ItemCount > 0 )
         {
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio = dynavBr_pathology_other_br_pathology_other_bio.getValidValue(AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_pathology_other_br_pathology_other_bio.CurrentValue = StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_pathology_other_br_pathology_other_bio_Internalname, "Values", dynavBr_pathology_other_br_pathology_other_bio.ToJavascriptSource(), true);
         }
         if ( dynavBr_pathology_other_br_pathology_other_bioqual.ItemCount > 0 )
         {
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual = dynavBr_pathology_other_br_pathology_other_bioqual.getValidValue(AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_pathology_other_br_pathology_other_bioqual.CurrentValue = StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_pathology_other_br_pathology_other_bioqual_Internalname, "Values", dynavBr_pathology_other_br_pathology_other_bioqual.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF952( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF952( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E12952 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E14952 ();
            WB950( ) ;
         }
      }

      protected void send_integrity_lvl_hashes952( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP950( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11952 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVvZLNAME_html952( AV16tCurrentCode) ;
         GXVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT_html952( AV16tCurrentCode) ;
         GXVvVNAME_html952( AV16tCurrentCode) ;
         GXVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO_html952( AV16tCurrentCode) ;
         GXVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL_html952( AV16tCurrentCode) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_pathology_other"), AV10BR_Pathology_Other);
            /* Read variables values. */
            dynavZlname.CurrentValue = cgiGet( dynavZlname_Internalname);
            AV11zlName = cgiGet( dynavZlname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11zlName", AV11zlName);
            AV12bzName = cgiGet( edtavBzname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12bzName", AV12bzName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_bionum_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_bionum_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM");
               GX_FocusControl = edtavBr_pathology_other_br_pathology_other_bionum_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum = 0;
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum = context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_bionum_Internalname), ".", ",");
            }
            dynavBr_pathology_other_br_pathology_other_bionumunit.CurrentValue = cgiGet( dynavBr_pathology_other_br_pathology_other_bionumunit_Internalname);
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionumunit = cgiGet( dynavBr_pathology_other_br_pathology_other_bionumunit_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_low_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_low_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW");
               GX_FocusControl = edtavBr_pathology_other_br_pathology_other_low_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low = 0;
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low = context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_low_Internalname), ".", ",");
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_high_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_high_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH");
               GX_FocusControl = edtavBr_pathology_other_br_pathology_other_high_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high = 0;
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high = context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_high_Internalname), ".", ",");
            }
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind = cgiGet( edtavBr_pathology_other_br_pathology_other_abnind_Internalname);
            dynavVname.CurrentValue = cgiGet( dynavVname_Internalname);
            AV13vName = cgiGet( dynavVname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vName", AV13vName);
            AV14vOtherName = cgiGet( edtavVothername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vOtherName", AV14vOtherName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_otherid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_otherid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID");
               GX_FocusControl = edtavBr_pathology_other_br_pathology_otherid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology_Other.gxTpr_Br_pathology_otherid = 0;
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathology_otherid = (long)(context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_otherid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathologyid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathologyid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BR_PATHOLOGYID");
               GX_FocusControl = edtavBr_pathology_other_br_pathologyid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology_Other.gxTpr_Br_pathologyid = 0;
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathologyid = (long)(context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathologyid_Internalname), ".", ","));
            }
            dynavBr_pathology_other_br_pathology_other_bio.CurrentValue = cgiGet( dynavBr_pathology_other_br_pathology_other_bio_Internalname);
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio = cgiGet( dynavBr_pathology_other_br_pathology_other_bio_Internalname);
            dynavBr_pathology_other_br_pathology_other_bioqual.CurrentValue = cgiGet( dynavBr_pathology_other_br_pathology_other_bioqual_Internalname);
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual = cgiGet( dynavBr_pathology_other_br_pathology_other_bioqual_Internalname);
            /* Read saved values. */
            Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
            Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
            Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
            Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
            Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
            Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
            Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
            Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
            Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
            Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            GXVvZLNAME_html952( AV16tCurrentCode) ;
            GXVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT_html952( AV16tCurrentCode) ;
            GXVvVNAME_html952( AV16tCurrentCode) ;
            GXVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO_html952( AV16tCurrentCode) ;
            GXVBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL_html952( AV16tCurrentCode) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E11952 ();
         if (returnInSub) return;
      }

      protected void E11952( )
      {
         /* Start Routine */
         GXt_char1 = AV16tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV16tCurrentCode = GXt_char1;
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         edtavBr_pathology_other_br_pathology_otherid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathology_otherid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathology_otherid_Visible), 5, 0)), true);
         edtavBr_pathology_other_br_pathologyid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathologyid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathologyid_Visible), 5, 0)), true);
         dynavBr_pathology_other_br_pathology_other_bio.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_pathology_other_br_pathology_other_bio_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_pathology_other_br_pathology_other_bio.Visible), 5, 0)), true);
         dynavBr_pathology_other_br_pathology_other_bioqual.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_pathology_other_br_pathology_other_bioqual_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_pathology_other_br_pathology_other_bioqual.Visible), 5, 0)), true);
         edtavVothername_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVothername_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVothername_Visible), 5, 0)), true);
         edtavBzname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBzname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBzname_Visible), 5, 0)), true);
      }

      protected void S122( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV15CheckRequiredFieldsResult = true;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV11zlName)) )
         {
            GX_msglist.addItem("肿瘤标志物是必须填写的。");
            AV15CheckRequiredFieldsResult = false;
         }
         if ( ( ( StringUtil.StrCmp(AV11zlName, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV12bzName)) )
         {
            GX_msglist.addItem("");
            AV15CheckRequiredFieldsResult = false;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV13vName)) )
         {
            GX_msglist.addItem("定性结果是必须填写的。");
            AV15CheckRequiredFieldsResult = false;
         }
         if ( ( ( StringUtil.StrCmp(AV13vName, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV14vOtherName)) )
         {
            GX_msglist.addItem("");
            AV15CheckRequiredFieldsResult = false;
         }
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( StringUtil.StrCmp(AV11zlName, "其它") == 0 )
         {
            cellBzname_cell_Class = "RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
         }
         else
         {
            cellBzname_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
         }
         if ( StringUtil.StrCmp(AV13vName, "其它") == 0 )
         {
            cellVothername_cell_Class = "RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVothername_cell_Internalname, "Class", cellVothername_cell_Class, true);
         }
         else
         {
            cellVothername_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVothername_cell_Internalname, "Class", cellVothername_cell_Class, true);
         }
      }

      protected void S132( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV33GXV10 = 1;
         while ( AV33GXV10 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV33GXV10));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV33GXV10 = (int)(AV33GXV10+1);
         }
      }

      protected void E12952( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E13952 ();
         if (returnInSub) return;
      }

      protected void E13952( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV21tCheckFlag) ;
         if ( ! AV21tCheckFlag )
         {
            AV19tFlag = true;
            if ( ( StringUtil.StrCmp(AV13vName, "其它") == 0 ) && ( AV19tFlag ) )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV14vOtherName)) )
               {
                  GX_msglist.addItem("其它定性结果是必填的");
                  AV19tFlag = false;
               }
               else
               {
                  AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual = AV14vOtherName;
               }
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual = AV13vName;
            }
            if ( ( StringUtil.StrCmp(AV11zlName, "其它") == 0 ) && ( AV19tFlag ) )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12bzName)) )
               {
                  GX_msglist.addItem("其它肿瘤标志物是必填的");
                  AV19tFlag = false;
               }
               else
               {
                  AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio = AV12bzName;
               }
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio = AV11zlName;
            }
            AV10BR_Pathology_Other.gxTpr_Br_pathologyid = AV17BR_PathologyID;
            if ( AV19tFlag )
            {
               AV10BR_Pathology_Other.Save();
               if ( AV10BR_Pathology_Other.Success() )
               {
                  context.CommitDataStores("br_pathology_otherinsert",pr_default);
                  context.setWebReturnParms(new Object[] {});
                  context.setWebReturnParmsMetadata(new Object[] {});
                  context.wjLocDisableFrm = 1;
                  context.nUserReturn = 1;
                  returnInSub = true;
                  if (true) return;
               }
               else
               {
                  AV20ErrorMsg = "";
                  AV35GXV12 = 1;
                  AV34GXV11 = AV10BR_Pathology_Other.GetMessages();
                  while ( AV35GXV12 <= AV34GXV11.Count )
                  {
                     AV7Message = ((SdtMessages_Message)AV34GXV11.Item(AV35GXV12));
                     AV20ErrorMsg = AV20ErrorMsg + StringUtil.Trim( AV7Message.gxTpr_Description);
                     AV35GXV12 = (int)(AV35GXV12+1);
                  }
                  GX_msglist.addItem(StringUtil.Trim( AV20ErrorMsg));
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10BR_Pathology_Other", AV10BR_Pathology_Other);
      }

      protected void nextLoad( )
      {
      }

      protected void E14952( )
      {
         /* Load Routine */
         AV10BR_Pathology_Other.Load(AV18BR_Pathology_OtherID);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio)) )
         {
            dynavZlname.addItem(AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio, AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio, 0);
            AV11zlName = AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11zlName", AV11zlName);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual)) )
         {
            dynavVname.addItem(AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual, AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual, 0);
            AV13vName = AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vName", AV13vName);
         }
      }

      protected void wb_table2_82_952( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvname_Internalname, tblTablemergedvname_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVname_Internalname, "v Name", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVname, dynavVname_Internalname, StringUtil.RTrim( AV13vName), 1, dynavVname_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVname.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "", true, "HLP_BR_Pathology_OtherInsert.htm");
            dynavVname.CurrentValue = StringUtil.RTrim( AV13vName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVname_Internalname, "Values", (String)(dynavVname.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVothername_cell_Internalname+"\"  class='"+cellVothername_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVothername_Internalname, "v Other Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVothername_Internalname, AV14vOtherName, StringUtil.RTrim( context.localUtil.Format( AV14vOtherName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它定性结果", edtavVothername_Jsonclick, 0, "Attribute", "", "", "", "", edtavVothername_Visible, edtavVothername_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            ClassString = "bangzhu";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbeizhu_Internalname, "", "帮助", bttBtnbeizhu_Jsonclick, 7, "帮助", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e15951_client"+"'", TempTags, "", 2, "HLP_BR_Pathology_OtherInsert.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_82_952e( true) ;
         }
         else
         {
            wb_table2_82_952e( false) ;
         }
      }

      protected void wb_table1_25_952( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedzlname_Internalname, tblTablemergedzlname_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavZlname_Internalname, "zl Name", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavZlname, dynavZlname_Internalname, StringUtil.RTrim( AV11zlName), 1, dynavZlname_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavZlname.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "", true, "HLP_BR_Pathology_OtherInsert.htm");
            dynavZlname.CurrentValue = StringUtil.RTrim( AV11zlName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavZlname_Internalname, "Values", (String)(dynavZlname.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellBzname_cell_Internalname+"\"  class='"+cellBzname_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBzname_Internalname, "bz Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBzname_Internalname, AV12bzName, StringUtil.RTrim( context.localUtil.Format( AV12bzName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它肿瘤标志物", edtavBzname_Jsonclick, 0, "Attribute", "", "", "", "", edtavBzname_Visible, edtavBzname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_25_952e( true) ;
         }
         else
         {
            wb_table1_25_952e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV17BR_PathologyID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17BR_PathologyID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA952( ) ;
         WS952( ) ;
         WE952( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281517581", true);
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
         context.AddJavascriptSource("br_pathology_otherinsert.js", "?20202281517582", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavZlname.Name = "vZLNAME";
         dynavZlname.WebTags = "";
         dynavBr_pathology_other_br_pathology_other_bionumunit.Name = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT";
         dynavBr_pathology_other_br_pathology_other_bionumunit.WebTags = "";
         dynavVname.Name = "vVNAME";
         dynavVname.WebTags = "";
         dynavBr_pathology_other_br_pathology_other_bio.Name = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO";
         dynavBr_pathology_other_br_pathology_other_bio.WebTags = "";
         dynavBr_pathology_other_br_pathology_other_bioqual.Name = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL";
         dynavBr_pathology_other_br_pathology_other_bioqual.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockzlname_Internalname = "TEXTBLOCKZLNAME";
         dynavZlname_Internalname = "vZLNAME";
         edtavBzname_Internalname = "vBZNAME";
         cellBzname_cell_Internalname = "BZNAME_CELL";
         tblTablemergedzlname_Internalname = "TABLEMERGEDZLNAME";
         divTablesplittedzlname_Internalname = "TABLESPLITTEDZLNAME";
         lblTextblockbr_pathology_other_br_pathology_other_bionum_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM";
         edtavBr_pathology_other_br_pathology_other_bionum_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM";
         divUnnamedtablebr_pathology_other_br_pathology_other_bionum_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM";
         lblTextblockbr_pathology_other_br_pathology_other_bionumunit_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT";
         dynavBr_pathology_other_br_pathology_other_bionumunit_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT";
         divUnnamedtablebr_pathology_other_br_pathology_other_bionumunit_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUMUNIT";
         lblTextblockbr_pathology_other_br_pathology_other_low_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW";
         edtavBr_pathology_other_br_pathology_other_low_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW";
         divUnnamedtablebr_pathology_other_br_pathology_other_low_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW";
         lblTextblockbr_pathology_other_br_pathology_other_high_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH";
         edtavBr_pathology_other_br_pathology_other_high_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH";
         divUnnamedtablebr_pathology_other_br_pathology_other_high_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH";
         lblTextblockbr_pathology_other_br_pathology_other_abnind_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND";
         edtavBr_pathology_other_br_pathology_other_abnind_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND";
         divUnnamedtablebr_pathology_other_br_pathology_other_abnind_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND";
         lblTextblockvname_Internalname = "TEXTBLOCKVNAME";
         dynavVname_Internalname = "vVNAME";
         edtavVothername_Internalname = "vVOTHERNAME";
         cellVothername_cell_Internalname = "VOTHERNAME_CELL";
         bttBtnbeizhu_Internalname = "BTNBEIZHU";
         tblTablemergedvname_Internalname = "TABLEMERGEDVNAME";
         divTablesplittedvname_Internalname = "TABLESPLITTEDVNAME";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavBr_pathology_other_br_pathology_otherid_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID";
         edtavBr_pathology_other_br_pathologyid_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGYID";
         dynavBr_pathology_other_br_pathology_other_bio_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIO";
         dynavBr_pathology_other_br_pathology_other_bioqual_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIOQUAL";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavBzname_Jsonclick = "";
         edtavBzname_Enabled = 1;
         cellBzname_cell_Class = "";
         dynavZlname_Jsonclick = "";
         dynavZlname.Enabled = 1;
         edtavVothername_Jsonclick = "";
         edtavVothername_Enabled = 1;
         cellVothername_cell_Class = "";
         dynavVname_Jsonclick = "";
         dynavVname.Enabled = 1;
         edtavBzname_Visible = 1;
         edtavVothername_Visible = 1;
         dynavBr_pathology_other_br_pathology_other_bioqual_Jsonclick = "";
         dynavBr_pathology_other_br_pathology_other_bioqual.Visible = 1;
         dynavBr_pathology_other_br_pathology_other_bio_Jsonclick = "";
         dynavBr_pathology_other_br_pathology_other_bio.Visible = 1;
         edtavBr_pathology_other_br_pathologyid_Jsonclick = "";
         edtavBr_pathology_other_br_pathologyid_Visible = 1;
         edtavBr_pathology_other_br_pathology_otherid_Jsonclick = "";
         edtavBr_pathology_other_br_pathology_otherid_Visible = 1;
         edtavBr_pathology_other_br_pathology_other_abnind_Jsonclick = "";
         edtavBr_pathology_other_br_pathology_other_abnind_Enabled = 1;
         edtavBr_pathology_other_br_pathology_other_high_Jsonclick = "";
         edtavBr_pathology_other_br_pathology_other_high_Enabled = 1;
         edtavBr_pathology_other_br_pathology_other_low_Jsonclick = "";
         edtavBr_pathology_other_br_pathology_other_low_Enabled = 1;
         dynavBr_pathology_other_br_pathology_other_bionumunit_Jsonclick = "";
         dynavBr_pathology_other_br_pathology_other_bionumunit.Enabled = 1;
         edtavBr_pathology_other_br_pathology_other_bionum_Jsonclick = "";
         edtavBr_pathology_other_br_pathology_other_bionum_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "病理学其它信息";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV17BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOBEIZHU'","{handler:'E15951',iparms:[]");
         setEventMetadata("'DOBEIZHU'",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E13952',iparms:[{av:'dynavVname'},{av:'AV13vName',fld:'vVNAME',pic:''},{av:'AV14vOtherName',fld:'vVOTHERNAME',pic:''},{av:'AV10BR_Pathology_Other',fld:'vBR_PATHOLOGY_OTHER',pic:''},{av:'dynavZlname'},{av:'AV11zlName',fld:'vZLNAME',pic:''},{av:'AV12bzName',fld:'vBZNAME',pic:''},{av:'AV17BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV10BR_Pathology_Other',fld:'vBR_PATHOLOGY_OTHER',pic:''}]}");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV16tCurrentCode = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV10BR_Pathology_Other = new SdtBR_Pathology_Other(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockzlname_Jsonclick = "";
         lblTextblockbr_pathology_other_br_pathology_other_bionum_Jsonclick = "";
         TempTags = "";
         lblTextblockbr_pathology_other_br_pathology_other_bionumunit_Jsonclick = "";
         lblTextblockbr_pathology_other_br_pathology_other_low_Jsonclick = "";
         lblTextblockbr_pathology_other_br_pathology_other_high_Jsonclick = "";
         lblTextblockbr_pathology_other_br_pathology_other_abnind_Jsonclick = "";
         lblTextblockvname_Jsonclick = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H00952_A167XT_DefineCodeID = new long[1] ;
         H00952_A168XT_DefineCodeName = new String[] {""} ;
         H00952_n168XT_DefineCodeName = new bool[] {false} ;
         H00952_A165XT_DefindcodeTypeID = new long[1] ;
         H00952_A432XT_TenantCode = new String[] {""} ;
         H00952_n432XT_TenantCode = new bool[] {false} ;
         H00953_A167XT_DefineCodeID = new long[1] ;
         H00953_A168XT_DefineCodeName = new String[] {""} ;
         H00953_n168XT_DefineCodeName = new bool[] {false} ;
         H00953_A165XT_DefindcodeTypeID = new long[1] ;
         H00953_A432XT_TenantCode = new String[] {""} ;
         H00953_n432XT_TenantCode = new bool[] {false} ;
         H00954_A167XT_DefineCodeID = new long[1] ;
         H00954_A168XT_DefineCodeName = new String[] {""} ;
         H00954_n168XT_DefineCodeName = new bool[] {false} ;
         H00954_A165XT_DefindcodeTypeID = new long[1] ;
         H00954_A432XT_TenantCode = new String[] {""} ;
         H00954_n432XT_TenantCode = new bool[] {false} ;
         H00955_A167XT_DefineCodeID = new long[1] ;
         H00955_A168XT_DefineCodeName = new String[] {""} ;
         H00955_n168XT_DefineCodeName = new bool[] {false} ;
         H00955_A165XT_DefindcodeTypeID = new long[1] ;
         H00955_A432XT_TenantCode = new String[] {""} ;
         H00955_n432XT_TenantCode = new bool[] {false} ;
         H00956_A167XT_DefineCodeID = new long[1] ;
         H00956_A168XT_DefineCodeName = new String[] {""} ;
         H00956_n168XT_DefineCodeName = new bool[] {false} ;
         H00956_A165XT_DefindcodeTypeID = new long[1] ;
         H00956_A432XT_TenantCode = new String[] {""} ;
         H00956_n432XT_TenantCode = new bool[] {false} ;
         AV11zlName = "";
         AV13vName = "";
         AV12bzName = "";
         AV14vOtherName = "";
         GXt_char1 = "";
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV20ErrorMsg = "";
         AV34GXV11 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         sStyleString = "";
         bttBtnbeizhu_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_otherinsert__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_otherinsert__default(),
            new Object[][] {
                new Object[] {
               H00952_A167XT_DefineCodeID, H00952_A168XT_DefineCodeName, H00952_n168XT_DefineCodeName, H00952_A165XT_DefindcodeTypeID, H00952_A432XT_TenantCode, H00952_n432XT_TenantCode
               }
               , new Object[] {
               H00953_A167XT_DefineCodeID, H00953_A168XT_DefineCodeName, H00953_n168XT_DefineCodeName, H00953_A165XT_DefindcodeTypeID, H00953_A432XT_TenantCode, H00953_n432XT_TenantCode
               }
               , new Object[] {
               H00954_A167XT_DefineCodeID, H00954_A168XT_DefineCodeName, H00954_n168XT_DefineCodeName, H00954_A165XT_DefindcodeTypeID, H00954_A432XT_TenantCode, H00954_n432XT_TenantCode
               }
               , new Object[] {
               H00955_A167XT_DefineCodeID, H00955_A168XT_DefineCodeName, H00955_n168XT_DefineCodeName, H00955_A165XT_DefindcodeTypeID, H00955_A432XT_TenantCode, H00955_n432XT_TenantCode
               }
               , new Object[] {
               H00956_A167XT_DefineCodeID, H00956_A168XT_DefineCodeName, H00956_n168XT_DefineCodeName, H00956_A165XT_DefindcodeTypeID, H00956_A432XT_TenantCode, H00956_n432XT_TenantCode
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavBr_pathology_other_br_pathology_other_bionum_Enabled ;
      private int edtavBr_pathology_other_br_pathology_other_low_Enabled ;
      private int edtavBr_pathology_other_br_pathology_other_high_Enabled ;
      private int edtavBr_pathology_other_br_pathology_other_abnind_Enabled ;
      private int edtavBr_pathology_other_br_pathology_otherid_Visible ;
      private int edtavBr_pathology_other_br_pathologyid_Visible ;
      private int gxdynajaxindex ;
      private int edtavVothername_Visible ;
      private int edtavBzname_Visible ;
      private int AV33GXV10 ;
      private int AV35GXV12 ;
      private int edtavVothername_Enabled ;
      private int edtavBzname_Enabled ;
      private int idxLst ;
      private long AV17BR_PathologyID ;
      private long wcpOAV17BR_PathologyID ;
      private long AV18BR_Pathology_OtherID ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String divTablesplittedzlname_Internalname ;
      private String lblTextblockzlname_Internalname ;
      private String lblTextblockzlname_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_br_pathology_other_bionum_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_bionum_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_bionum_Jsonclick ;
      private String edtavBr_pathology_other_br_pathology_other_bionum_Internalname ;
      private String TempTags ;
      private String edtavBr_pathology_other_br_pathology_other_bionum_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_br_pathology_other_bionumunit_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_bionumunit_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_bionumunit_Jsonclick ;
      private String dynavBr_pathology_other_br_pathology_other_bionumunit_Internalname ;
      private String dynavBr_pathology_other_br_pathology_other_bionumunit_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_br_pathology_other_low_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_low_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_low_Jsonclick ;
      private String edtavBr_pathology_other_br_pathology_other_low_Internalname ;
      private String edtavBr_pathology_other_br_pathology_other_low_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_br_pathology_other_high_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_high_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_high_Jsonclick ;
      private String edtavBr_pathology_other_br_pathology_other_high_Internalname ;
      private String edtavBr_pathology_other_br_pathology_other_high_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_br_pathology_other_abnind_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_abnind_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_abnind_Jsonclick ;
      private String edtavBr_pathology_other_br_pathology_other_abnind_Internalname ;
      private String edtavBr_pathology_other_br_pathology_other_abnind_Jsonclick ;
      private String divTablesplittedvname_Internalname ;
      private String lblTextblockvname_Internalname ;
      private String lblTextblockvname_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_pathology_other_br_pathology_otherid_Internalname ;
      private String edtavBr_pathology_other_br_pathology_otherid_Jsonclick ;
      private String edtavBr_pathology_other_br_pathologyid_Internalname ;
      private String edtavBr_pathology_other_br_pathologyid_Jsonclick ;
      private String dynavBr_pathology_other_br_pathology_other_bio_Internalname ;
      private String dynavBr_pathology_other_br_pathology_other_bio_Jsonclick ;
      private String dynavBr_pathology_other_br_pathology_other_bioqual_Internalname ;
      private String dynavBr_pathology_other_br_pathology_other_bioqual_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String dynavZlname_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String dynavVname_Internalname ;
      private String edtavBzname_Internalname ;
      private String edtavVothername_Internalname ;
      private String GXt_char1 ;
      private String cellBzname_cell_Class ;
      private String cellBzname_cell_Internalname ;
      private String cellVothername_cell_Class ;
      private String cellVothername_cell_Internalname ;
      private String sStyleString ;
      private String tblTablemergedvname_Internalname ;
      private String dynavVname_Jsonclick ;
      private String edtavVothername_Jsonclick ;
      private String bttBtnbeizhu_Internalname ;
      private String bttBtnbeizhu_Jsonclick ;
      private String tblTablemergedzlname_Internalname ;
      private String dynavZlname_Jsonclick ;
      private String edtavBzname_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV15CheckRequiredFieldsResult ;
      private bool AV21tCheckFlag ;
      private bool AV19tFlag ;
      private String AV16tCurrentCode ;
      private String AV11zlName ;
      private String AV13vName ;
      private String AV12bzName ;
      private String AV14vOtherName ;
      private String AV20ErrorMsg ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavZlname ;
      private GXCombobox dynavBr_pathology_other_br_pathology_other_bionumunit ;
      private GXCombobox dynavVname ;
      private GXCombobox dynavBr_pathology_other_br_pathology_other_bio ;
      private GXCombobox dynavBr_pathology_other_br_pathology_other_bioqual ;
      private IDataStoreProvider pr_default ;
      private long[] H00952_A167XT_DefineCodeID ;
      private String[] H00952_A168XT_DefineCodeName ;
      private bool[] H00952_n168XT_DefineCodeName ;
      private long[] H00952_A165XT_DefindcodeTypeID ;
      private String[] H00952_A432XT_TenantCode ;
      private bool[] H00952_n432XT_TenantCode ;
      private long[] H00953_A167XT_DefineCodeID ;
      private String[] H00953_A168XT_DefineCodeName ;
      private bool[] H00953_n168XT_DefineCodeName ;
      private long[] H00953_A165XT_DefindcodeTypeID ;
      private String[] H00953_A432XT_TenantCode ;
      private bool[] H00953_n432XT_TenantCode ;
      private long[] H00954_A167XT_DefineCodeID ;
      private String[] H00954_A168XT_DefineCodeName ;
      private bool[] H00954_n168XT_DefineCodeName ;
      private long[] H00954_A165XT_DefindcodeTypeID ;
      private String[] H00954_A432XT_TenantCode ;
      private bool[] H00954_n432XT_TenantCode ;
      private long[] H00955_A167XT_DefineCodeID ;
      private String[] H00955_A168XT_DefineCodeName ;
      private bool[] H00955_n168XT_DefineCodeName ;
      private long[] H00955_A165XT_DefindcodeTypeID ;
      private String[] H00955_A432XT_TenantCode ;
      private bool[] H00955_n432XT_TenantCode ;
      private long[] H00956_A167XT_DefineCodeID ;
      private String[] H00956_A168XT_DefineCodeName ;
      private bool[] H00956_n168XT_DefineCodeName ;
      private long[] H00956_A165XT_DefindcodeTypeID ;
      private String[] H00956_A432XT_TenantCode ;
      private bool[] H00956_n432XT_TenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXBaseCollection<SdtMessages_Message> AV34GXV11 ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtBR_Pathology_Other AV10BR_Pathology_Other ;
   }

   public class br_pathology_otherinsert__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class br_pathology_otherinsert__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmH00952 ;
        prmH00952 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH00953 ;
        prmH00953 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH00954 ;
        prmH00954 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH00955 ;
        prmH00955 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH00956 ;
        prmH00956 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H00952", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 35) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00952,0,0,true,false )
           ,new CursorDef("H00953", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 28) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00953,0,0,true,false )
           ,new CursorDef("H00954", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 36) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00954,0,0,true,false )
           ,new CursorDef("H00955", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 35) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00955,0,0,true,false )
           ,new CursorDef("H00956", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 36) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00956,0,0,true,false )
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
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
           case 0 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
     }
  }

}

}
