/*
               File: BR_MedicationUpdate
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:50.64
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
   public class br_medicationupdate : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_medicationupdate( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicationupdate( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_MedicationID )
      {
         this.AV25BR_MedicationID = aP0_BR_MedicationID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavVmedicationname = new GXCombobox();
         dynavVrxfrequency = new GXCombobox();
         dynavVupdaterxroute = new GXCombobox();
         cmbavBr_medication_br_medication_inpatientchemo = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVMEDICATIONNAME") == 0 )
            {
               AV22tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVMEDICATIONNAME2Z2( AV22tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVRXFREQUENCY") == 0 )
            {
               AV22tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVRXFREQUENCY2Z2( AV22tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVUPDATERXROUTE") == 0 )
            {
               AV22tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVUPDATERXROUTE2Z2( AV22tCurrentCode) ;
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
               AV25BR_MedicationID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25BR_MedicationID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_MEDICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA2Z2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2Z2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281595072", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicationupdate.aspx") + "?" + UrlEncode("" +AV25BR_MedicationID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_medication", AV10BR_Medication);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_medication", AV10BR_Medication);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION", AV10BR_Medication);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION", AV10BR_Medication);
         }
         GxWebStd.gx_hidden_field( context, "vBR_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25BR_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_MEDICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV22tCurrentCode);
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
            WE2Z2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2Z2( ) ;
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
         return formatLink("br_medicationupdate.aspx") + "?" + UrlEncode("" +AV25BR_MedicationID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_MedicationUpdate" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB2Z0( )
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
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedvmedicationname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvmedicationname_Internalname, "药物名称", "", "", lblTextblockvmedicationname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_28_2Z2( true) ;
         }
         else
         {
            wb_table1_28_2Z2( false) ;
         }
         return  ;
      }

      protected void wb_table1_28_2Z2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medication_br_medication_rxcode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medication_br_medication_rxcode_Internalname, "药物代码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_medication_rxcode_Internalname, AV10BR_Medication.gxTpr_Br_medication_rxcode, StringUtil.RTrim( context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_rxcode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_medication_rxcode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_medication_br_medication_rxcode_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medication_br_medication_rxtype_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medication_br_medication_rxtype_Internalname, "药物类别", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_medication_rxtype_Internalname, AV10BR_Medication.gxTpr_Br_medication_rxtype, StringUtil.RTrim( context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_rxtype, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_medication_rxtype_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_medication_br_medication_rxtype_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medication_br_medication_rxdose_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medication_br_medication_rxdose_Internalname, "药物剂量", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_medication_rxdose_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Medication.gxTpr_Br_medication_rxdose, 15, 5, ".", "")), ((edtavBr_medication_br_medication_rxdose_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_rxdose, "ZZZZZZZZZ.ZZ")) : context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_rxdose, "ZZZZZZZZZ.ZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_medication_rxdose_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_medication_br_medication_rxdose_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medication_br_medication_rxunit_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medication_br_medication_rxunit_Internalname, "计量单位", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_medication_rxunit_Internalname, AV10BR_Medication.gxTpr_Br_medication_rxunit, StringUtil.RTrim( context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_rxunit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_medication_rxunit_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_medication_br_medication_rxunit_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedvrxfrequency_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvrxfrequency_Internalname, "服药频率", "", "", lblTextblockvrxfrequency_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table2_60_2Z2( true) ;
         }
         else
         {
            wb_table2_60_2Z2( false) ;
         }
         return  ;
      }

      protected void wb_table2_60_2Z2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medication_br_medication_rxquantity_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medication_br_medication_rxquantity_Internalname, "用药量", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_medication_rxquantity_Internalname, AV10BR_Medication.gxTpr_Br_medication_rxquantity, StringUtil.RTrim( context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_rxquantity, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_medication_rxquantity_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_medication_br_medication_rxquantity_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medication_br_medication_rxdayssupply_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medication_br_medication_rxdayssupply_Internalname, "服药天数", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_medication_rxdayssupply_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Medication.gxTpr_Br_medication_rxdayssupply, 15, 5, ".", "")), ((edtavBr_medication_br_medication_rxdayssupply_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_rxdayssupply, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_rxdayssupply, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_medication_rxdayssupply_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_medication_br_medication_rxdayssupply_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedvupdaterxroute_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvupdaterxroute_Internalname, "给药途径", "", "", lblTextblockvupdaterxroute_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table3_84_2Z2( true) ;
         }
         else
         {
            wb_table3_84_2Z2( false) ;
         }
         return  ;
      }

      protected void wb_table3_84_2Z2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medication_br_medication_prescriptiondate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medication_br_medication_prescriptiondate_Internalname, "处方日期", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_medication_br_medication_prescriptiondate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_medication_prescriptiondate_Internalname, context.localUtil.Format(AV10BR_Medication.gxTpr_Br_medication_prescriptiondate, "9999/99/99"), context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_prescriptiondate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,95);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_medication_prescriptiondate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_medication_br_medication_prescriptiondate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_bitmap( context, edtavBr_medication_br_medication_prescriptiondate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_medication_br_medication_prescriptiondate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicationUpdate.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medication_br_medication_admitstartdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medication_br_medication_admitstartdate_Internalname, "服药日期", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_medication_br_medication_admitstartdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_medication_admitstartdate_Internalname, context.localUtil.Format(AV10BR_Medication.gxTpr_Br_medication_admitstartdate, "9999/99/99"), context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_admitstartdate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,100);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_medication_admitstartdate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_medication_br_medication_admitstartdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_bitmap( context, edtavBr_medication_br_medication_admitstartdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_medication_br_medication_admitstartdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicationUpdate.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medication_br_medication_admitenddate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medication_br_medication_admitenddate_Internalname, "停药日期", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_medication_br_medication_admitenddate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_medication_admitenddate_Internalname, context.localUtil.Format(AV10BR_Medication.gxTpr_Br_medication_admitenddate, "9999/99/99"), context.localUtil.Format( AV10BR_Medication.gxTpr_Br_medication_admitenddate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_medication_admitenddate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_medication_br_medication_admitenddate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_bitmap( context, edtavBr_medication_br_medication_admitenddate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_medication_br_medication_admitenddate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicationUpdate.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_medication_br_medication_inpatientchemo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_medication_br_medication_inpatientchemo_Internalname, "是否接受住院化疗", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_medication_br_medication_inpatientchemo, cmbavBr_medication_br_medication_inpatientchemo_Internalname, StringUtil.RTrim( AV10BR_Medication.gxTpr_Br_medication_inpatientchemo), 1, cmbavBr_medication_br_medication_inpatientchemo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_medication_br_medication_inpatientchemo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,109);\"", "", true, "HLP_BR_MedicationUpdate.htm");
            cmbavBr_medication_br_medication_inpatientchemo.CurrentValue = StringUtil.RTrim( AV10BR_Medication.gxTpr_Br_medication_inpatientchemo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_medication_br_medication_inpatientchemo_Internalname, "Values", (String)(cmbavBr_medication_br_medication_inpatientchemo.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "保存", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_MedicationUpdate.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_medicationid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Medication.gxTpr_Br_medicationid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Medication.gxTpr_Br_medicationid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,120);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_medicationid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_medication_br_medicationid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 121,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Medication.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Medication.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,121);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_medication_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_br_information_patientno_Internalname, AV10BR_Medication.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV10BR_Medication.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,122);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_medication_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START2Z2( )
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
         STRUP2Z0( ) ;
      }

      protected void WS2Z2( )
      {
         START2Z2( ) ;
         EVT2Z2( ) ;
      }

      protected void EVT2Z2( )
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
                              E112Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E122Z2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E132Z2 ();
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
                                    E142Z2 ();
                                 }
                                 dynload_actions( ) ;
                              }
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

      protected void WE2Z2( )
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

      protected void PA2Z2( )
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
               GX_FocusControl = dynavVmedicationname_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvVMEDICATIONNAME2Z2( String AV22tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVMEDICATIONNAME_data2Z2( AV22tCurrentCode) ;
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

      protected void GXVvVMEDICATIONNAME_html2Z2( String AV22tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVMEDICATIONNAME_data2Z2( AV22tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVmedicationname.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVmedicationname.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVMEDICATIONNAME_data2Z2( String AV22tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H002Z2 */
         pr_default.execute(0, new Object[] {AV22tCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H002Z2_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H002Z2_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvVRXFREQUENCY2Z2( String AV22tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVRXFREQUENCY_data2Z2( AV22tCurrentCode) ;
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

      protected void GXVvVRXFREQUENCY_html2Z2( String AV22tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVRXFREQUENCY_data2Z2( AV22tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVrxfrequency.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVrxfrequency.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVRXFREQUENCY_data2Z2( String AV22tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H002Z3 */
         pr_default.execute(1, new Object[] {AV22tCurrentCode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H002Z3_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H002Z3_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVvVUPDATERXROUTE2Z2( String AV22tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVUPDATERXROUTE_data2Z2( AV22tCurrentCode) ;
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

      protected void GXVvVUPDATERXROUTE_html2Z2( String AV22tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVUPDATERXROUTE_data2Z2( AV22tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVupdaterxroute.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVupdaterxroute.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVUPDATERXROUTE_data2Z2( String AV22tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H002Z4 */
         pr_default.execute(2, new Object[] {AV22tCurrentCode});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H002Z4_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H002Z4_A168XT_DefineCodeName[0]);
            pr_default.readNext(2);
         }
         pr_default.close(2);
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
         if ( dynavVmedicationname.ItemCount > 0 )
         {
            AV20vMedicationName = dynavVmedicationname.getValidValue(AV20vMedicationName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vMedicationName", AV20vMedicationName);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVmedicationname.CurrentValue = StringUtil.RTrim( AV20vMedicationName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVmedicationname_Internalname, "Values", dynavVmedicationname.ToJavascriptSource(), true);
         }
         if ( dynavVrxfrequency.ItemCount > 0 )
         {
            AV17vRXFrequency = dynavVrxfrequency.getValidValue(AV17vRXFrequency);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vRXFrequency", AV17vRXFrequency);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVrxfrequency.CurrentValue = StringUtil.RTrim( AV17vRXFrequency);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVrxfrequency_Internalname, "Values", dynavVrxfrequency.ToJavascriptSource(), true);
         }
         if ( dynavVupdaterxroute.ItemCount > 0 )
         {
            AV14vUpdateRXRoute = dynavVupdaterxroute.getValidValue(AV14vUpdateRXRoute);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vUpdateRXRoute", AV14vUpdateRXRoute);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVupdaterxroute.CurrentValue = StringUtil.RTrim( AV14vUpdateRXRoute);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVupdaterxroute_Internalname, "Values", dynavVupdaterxroute.ToJavascriptSource(), true);
         }
         if ( cmbavBr_medication_br_medication_inpatientchemo.ItemCount > 0 )
         {
            AV10BR_Medication.gxTpr_Br_medication_inpatientchemo = cmbavBr_medication_br_medication_inpatientchemo.getValidValue(AV10BR_Medication.gxTpr_Br_medication_inpatientchemo);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_medication_br_medication_inpatientchemo.CurrentValue = StringUtil.RTrim( AV10BR_Medication.gxTpr_Br_medication_inpatientchemo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_medication_br_medication_inpatientchemo_Internalname, "Values", cmbavBr_medication_br_medication_inpatientchemo.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2Z2( ) ;
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

      protected void RF2Z2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E122Z2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E132Z2 ();
            WB2Z0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes2Z2( )
      {
      }

      protected void STRUP2Z0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E112Z2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVvVMEDICATIONNAME_html2Z2( AV22tCurrentCode) ;
         GXVvVRXFREQUENCY_html2Z2( AV22tCurrentCode) ;
         GXVvVUPDATERXROUTE_html2Z2( AV22tCurrentCode) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_medication"), AV10BR_Medication);
            /* Read variables values. */
            dynavVmedicationname.CurrentValue = cgiGet( dynavVmedicationname_Internalname);
            AV20vMedicationName = cgiGet( dynavVmedicationname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vMedicationName", AV20vMedicationName);
            AV21vOtherMedicationName = cgiGet( edtavVothermedicationname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21vOtherMedicationName", AV21vOtherMedicationName);
            AV10BR_Medication.gxTpr_Br_medication_rxcode = cgiGet( edtavBr_medication_br_medication_rxcode_Internalname);
            AV10BR_Medication.gxTpr_Br_medication_rxtype = cgiGet( edtavBr_medication_br_medication_rxtype_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_medication_br_medication_rxdose_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_medication_br_medication_rxdose_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICATION_BR_MEDICATION_RXDOSE");
               GX_FocusControl = edtavBr_medication_br_medication_rxdose_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Medication.gxTpr_Br_medication_rxdose = 0;
            }
            else
            {
               AV10BR_Medication.gxTpr_Br_medication_rxdose = context.localUtil.CToN( cgiGet( edtavBr_medication_br_medication_rxdose_Internalname), ".", ",");
            }
            AV10BR_Medication.gxTpr_Br_medication_rxunit = cgiGet( edtavBr_medication_br_medication_rxunit_Internalname);
            dynavVrxfrequency.CurrentValue = cgiGet( dynavVrxfrequency_Internalname);
            AV17vRXFrequency = cgiGet( dynavVrxfrequency_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vRXFrequency", AV17vRXFrequency);
            AV18vOtherRXFrequency = cgiGet( edtavVotherrxfrequency_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vOtherRXFrequency", AV18vOtherRXFrequency);
            AV10BR_Medication.gxTpr_Br_medication_rxquantity = cgiGet( edtavBr_medication_br_medication_rxquantity_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_medication_br_medication_rxdayssupply_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_medication_br_medication_rxdayssupply_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICATION_BR_MEDICATION_RXDAYSSUPPLY");
               GX_FocusControl = edtavBr_medication_br_medication_rxdayssupply_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Medication.gxTpr_Br_medication_rxdayssupply = 0;
            }
            else
            {
               AV10BR_Medication.gxTpr_Br_medication_rxdayssupply = context.localUtil.CToN( cgiGet( edtavBr_medication_br_medication_rxdayssupply_Internalname), ".", ",");
            }
            dynavVupdaterxroute.CurrentValue = cgiGet( dynavVupdaterxroute_Internalname);
            AV14vUpdateRXRoute = cgiGet( dynavVupdaterxroute_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vUpdateRXRoute", AV14vUpdateRXRoute);
            AV15vRXRoute = cgiGet( edtavVrxroute_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vRXRoute", AV15vRXRoute);
            if ( context.localUtil.VCDate( cgiGet( edtavBr_medication_br_medication_prescriptiondate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"处方日期"}), 1, "BR_MEDICATION_BR_MEDICATION_PRESCRIPTIONDATE");
               GX_FocusControl = edtavBr_medication_br_medication_prescriptiondate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Medication.gxTpr_Br_medication_prescriptiondate = DateTime.MinValue;
            }
            else
            {
               AV10BR_Medication.gxTpr_Br_medication_prescriptiondate = context.localUtil.CToD( cgiGet( edtavBr_medication_br_medication_prescriptiondate_Internalname), 0);
            }
            if ( context.localUtil.VCDate( cgiGet( edtavBr_medication_br_medication_admitstartdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"服药日期"}), 1, "BR_MEDICATION_BR_MEDICATION_ADMITSTARTDATE");
               GX_FocusControl = edtavBr_medication_br_medication_admitstartdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Medication.gxTpr_Br_medication_admitstartdate = DateTime.MinValue;
            }
            else
            {
               AV10BR_Medication.gxTpr_Br_medication_admitstartdate = context.localUtil.CToD( cgiGet( edtavBr_medication_br_medication_admitstartdate_Internalname), 0);
            }
            if ( context.localUtil.VCDate( cgiGet( edtavBr_medication_br_medication_admitenddate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"停药日期"}), 1, "BR_MEDICATION_BR_MEDICATION_ADMITENDDATE");
               GX_FocusControl = edtavBr_medication_br_medication_admitenddate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Medication.gxTpr_Br_medication_admitenddate = DateTime.MinValue;
            }
            else
            {
               AV10BR_Medication.gxTpr_Br_medication_admitenddate = context.localUtil.CToD( cgiGet( edtavBr_medication_br_medication_admitenddate_Internalname), 0);
            }
            cmbavBr_medication_br_medication_inpatientchemo.CurrentValue = cgiGet( cmbavBr_medication_br_medication_inpatientchemo_Internalname);
            AV10BR_Medication.gxTpr_Br_medication_inpatientchemo = cgiGet( cmbavBr_medication_br_medication_inpatientchemo_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_medication_br_medicationid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_medication_br_medicationid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICATION_BR_MEDICATIONID");
               GX_FocusControl = edtavBr_medication_br_medicationid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Medication.gxTpr_Br_medicationid = 0;
            }
            else
            {
               AV10BR_Medication.gxTpr_Br_medicationid = (long)(context.localUtil.CToN( cgiGet( edtavBr_medication_br_medicationid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_medication_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_medication_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICATION_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_medication_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Medication.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV10BR_Medication.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_medication_br_encounterid_Internalname), ".", ","));
            }
            AV10BR_Medication.gxTpr_Br_information_patientno = cgiGet( edtavBr_medication_br_information_patientno_Internalname);
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
            GXVvVMEDICATIONNAME_html2Z2( AV22tCurrentCode) ;
            GXVvVRXFREQUENCY_html2Z2( AV22tCurrentCode) ;
            GXVvVUPDATERXROUTE_html2Z2( AV22tCurrentCode) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E112Z2 ();
         if (returnInSub) return;
      }

      protected void E112Z2( )
      {
         /* Start Routine */
         GXt_char1 = AV22tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV22tCurrentCode = GXt_char1;
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         edtavBr_medication_br_medicationid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_medication_br_medicationid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_medication_br_medicationid_Visible), 5, 0)), true);
         edtavBr_medication_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_medication_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_medication_br_encounterid_Visible), 5, 0)), true);
         edtavBr_medication_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_medication_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_medication_br_information_patientno_Visible), 5, 0)), true);
         AV10BR_Medication.Load(AV25BR_MedicationID);
         edtavVrxroute_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVrxroute_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVrxroute_Visible), 5, 0)), true);
         edtavVotherrxfrequency_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherrxfrequency_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherrxfrequency_Visible), 5, 0)), true);
         edtavVothermedicationname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVothermedicationname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVothermedicationname_Visible), 5, 0)), true);
      }

      protected void S122( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV12CheckRequiredFieldsResult = true;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV20vMedicationName)) )
         {
            GX_msglist.addItem("药物名称是必须填写的。");
            AV12CheckRequiredFieldsResult = false;
         }
         if ( ( ( StringUtil.StrCmp(AV20vMedicationName, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV21vOtherMedicationName)) )
         {
            GX_msglist.addItem("其它药物名称是必填的");
            AV12CheckRequiredFieldsResult = false;
         }
         if ( ( ( StringUtil.StrCmp(AV17vRXFrequency, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV18vOtherRXFrequency)) )
         {
            GX_msglist.addItem("其它服药频率是必填的");
            AV12CheckRequiredFieldsResult = false;
         }
         if ( ( ( StringUtil.StrCmp(AV14vUpdateRXRoute, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV15vRXRoute)) )
         {
            GX_msglist.addItem("其它给药途径是必填的");
            AV12CheckRequiredFieldsResult = false;
         }
         if ( (DateTime.MinValue==AV10BR_Medication.gxTpr_Br_medication_admitstartdate) )
         {
            GX_msglist.addItem("服药日期是必须填写的。");
            AV12CheckRequiredFieldsResult = false;
         }
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( StringUtil.StrCmp(AV20vMedicationName, "其它") == 0 )
         {
            cellVothermedicationname_cell_Class = "RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVothermedicationname_cell_Internalname, "Class", cellVothermedicationname_cell_Class, true);
         }
         else
         {
            cellVothermedicationname_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVothermedicationname_cell_Internalname, "Class", cellVothermedicationname_cell_Class, true);
         }
         if ( StringUtil.StrCmp(AV17vRXFrequency, "其它") == 0 )
         {
            cellVotherrxfrequency_cell_Class = "RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVotherrxfrequency_cell_Internalname, "Class", cellVotherrxfrequency_cell_Class, true);
         }
         else
         {
            cellVotherrxfrequency_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVotherrxfrequency_cell_Internalname, "Class", cellVotherrxfrequency_cell_Class, true);
         }
         if ( StringUtil.StrCmp(AV14vUpdateRXRoute, "其它") == 0 )
         {
            cellVrxroute_cell_Class = "RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
         }
         else
         {
            cellVrxroute_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
         }
      }

      protected void S132( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV41GXV14 = 1;
         while ( AV41GXV14 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV41GXV14));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV41GXV14 = (int)(AV41GXV14+1);
         }
      }

      protected void E122Z2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      protected void nextLoad( )
      {
      }

      protected void E132Z2( )
      {
         /* Load Routine */
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Medication.gxTpr_Br_medication_rxroute)) )
         {
            dynavVupdaterxroute.addItem(AV10BR_Medication.gxTpr_Br_medication_rxroute, AV10BR_Medication.gxTpr_Br_medication_rxroute, 0);
            AV14vUpdateRXRoute = AV10BR_Medication.gxTpr_Br_medication_rxroute;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vUpdateRXRoute", AV14vUpdateRXRoute);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Medication.gxTpr_Br_medication_rxfrequency)) )
         {
            dynavVrxfrequency.addItem(AV10BR_Medication.gxTpr_Br_medication_rxfrequency, AV10BR_Medication.gxTpr_Br_medication_rxfrequency, 0);
            AV17vRXFrequency = AV10BR_Medication.gxTpr_Br_medication_rxfrequency;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vRXFrequency", AV17vRXFrequency);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Medication.gxTpr_Br_medication_rxname)) )
         {
            dynavVmedicationname.addItem(AV10BR_Medication.gxTpr_Br_medication_rxname, AV10BR_Medication.gxTpr_Br_medication_rxname, 0);
            AV20vMedicationName = AV10BR_Medication.gxTpr_Br_medication_rxname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vMedicationName", AV20vMedicationName);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E142Z2 ();
         if (returnInSub) return;
      }

      protected void E142Z2( )
      {
         /* Enter Routine */
         AV16tFlag = true;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV20vMedicationName)) )
         {
            GX_msglist.addItem("药物名称是必填的");
            AV16tFlag = false;
         }
         else
         {
            if ( StringUtil.StrCmp(AV20vMedicationName, "其它") == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV21vOtherMedicationName)) )
               {
                  GX_msglist.addItem("其它药物名称是必填的");
                  AV16tFlag = false;
               }
               else
               {
                  AV10BR_Medication.gxTpr_Br_medication_rxname = AV21vOtherMedicationName;
               }
            }
            else
            {
               AV10BR_Medication.gxTpr_Br_medication_rxname = AV20vMedicationName;
            }
         }
         if ( ( AV16tFlag ) && (DateTime.MinValue==AV10BR_Medication.gxTpr_Br_medication_admitstartdate) )
         {
            GX_msglist.addItem("服药日期是必填的");
            AV16tFlag = false;
         }
         if ( AV16tFlag )
         {
            if ( StringUtil.StrCmp(AV17vRXFrequency, "其它") == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV18vOtherRXFrequency)) )
               {
                  GX_msglist.addItem("其它服药频率是必填的");
                  AV16tFlag = false;
               }
               else
               {
                  AV10BR_Medication.gxTpr_Br_medication_rxfrequency = AV18vOtherRXFrequency;
               }
            }
            else
            {
               AV10BR_Medication.gxTpr_Br_medication_rxfrequency = AV17vRXFrequency;
            }
         }
         if ( AV16tFlag )
         {
            if ( StringUtil.StrCmp(AV14vUpdateRXRoute, "其它") == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV15vRXRoute)) )
               {
                  GX_msglist.addItem("其它给药途径是必填的");
                  AV16tFlag = false;
               }
               else
               {
                  AV10BR_Medication.gxTpr_Br_medication_rxroute = AV15vRXRoute;
               }
            }
            else
            {
               AV10BR_Medication.gxTpr_Br_medication_rxroute = AV14vUpdateRXRoute;
            }
         }
         if ( AV16tFlag )
         {
            if ( (DateTime.MinValue==AV10BR_Medication.gxTpr_Br_medication_prescriptiondate) )
            {
               AV10BR_Medication.gxTv_SdtBR_Medication_Br_medication_prescriptiondate_SetNull();
            }
            if ( (DateTime.MinValue==AV10BR_Medication.gxTpr_Br_medication_admitenddate) )
            {
               AV10BR_Medication.gxTv_SdtBR_Medication_Br_medication_admitenddate_SetNull();
            }
            if ( (DateTime.MinValue==AV10BR_Medication.gxTpr_Br_medication_admitstartdate) )
            {
               AV10BR_Medication.gxTv_SdtBR_Medication_Br_medication_admitstartdate_SetNull();
            }
            AV10BR_Medication.Save();
            if ( AV10BR_Medication.Success() )
            {
               new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV10BR_Medication.gxTpr_Br_encounterid), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(AV10BR_Medication.gxTpr_Br_medicationid), 18, 0)),  "药物治疗",  "Update",  1) ;
               context.CommitDataStores("br_medicationupdate",pr_default);
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
            else
            {
               AV19tErrorMsg = "";
               AV43GXV16 = 1;
               AV42GXV15 = AV10BR_Medication.GetMessages();
               while ( AV43GXV16 <= AV42GXV15.Count )
               {
                  AV7Message = ((SdtMessages_Message)AV42GXV15.Item(AV43GXV16));
                  AV19tErrorMsg = AV19tErrorMsg + StringUtil.Trim( AV7Message.gxTpr_Description);
                  AV43GXV16 = (int)(AV43GXV16+1);
               }
               GX_msglist.addItem(AV19tErrorMsg);
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10BR_Medication", AV10BR_Medication);
      }

      protected void wb_table3_84_2Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvupdaterxroute_Internalname, tblTablemergedvupdaterxroute_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVupdaterxroute_Internalname, "v Update RXRoute", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVupdaterxroute, dynavVupdaterxroute_Internalname, StringUtil.RTrim( AV14vUpdateRXRoute), 1, dynavVupdaterxroute_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVupdaterxroute.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", "", true, "HLP_BR_MedicationUpdate.htm");
            dynavVupdaterxroute.CurrentValue = StringUtil.RTrim( AV14vUpdateRXRoute);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVupdaterxroute_Internalname, "Values", (String)(dynavVupdaterxroute.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVrxroute_cell_Internalname+"\"  class='"+cellVrxroute_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVrxroute_Internalname, "v RXRoute", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVrxroute_Internalname, AV15vRXRoute, StringUtil.RTrim( context.localUtil.Format( AV15vRXRoute, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它给药途径", edtavVrxroute_Jsonclick, 0, "Attribute", "", "", "", "", edtavVrxroute_Visible, edtavVrxroute_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_84_2Z2e( true) ;
         }
         else
         {
            wb_table3_84_2Z2e( false) ;
         }
      }

      protected void wb_table2_60_2Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvrxfrequency_Internalname, tblTablemergedvrxfrequency_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVrxfrequency_Internalname, "服药频率", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVrxfrequency, dynavVrxfrequency_Internalname, StringUtil.RTrim( AV17vRXFrequency), 1, dynavVrxfrequency_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVrxfrequency.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "", true, "HLP_BR_MedicationUpdate.htm");
            dynavVrxfrequency.CurrentValue = StringUtil.RTrim( AV17vRXFrequency);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVrxfrequency_Internalname, "Values", (String)(dynavVrxfrequency.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVotherrxfrequency_cell_Internalname+"\"  class='"+cellVotherrxfrequency_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherrxfrequency_Internalname, "v Other RXFrequency", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherrxfrequency_Internalname, AV18vOtherRXFrequency, StringUtil.RTrim( context.localUtil.Format( AV18vOtherRXFrequency, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它服药频率", edtavVotherrxfrequency_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherrxfrequency_Visible, edtavVotherrxfrequency_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_60_2Z2e( true) ;
         }
         else
         {
            wb_table2_60_2Z2e( false) ;
         }
      }

      protected void wb_table1_28_2Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvmedicationname_Internalname, tblTablemergedvmedicationname_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVmedicationname_Internalname, "v Medication Name", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVmedicationname, dynavVmedicationname_Internalname, StringUtil.RTrim( AV20vMedicationName), 1, dynavVmedicationname_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVmedicationname.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", "", true, "HLP_BR_MedicationUpdate.htm");
            dynavVmedicationname.CurrentValue = StringUtil.RTrim( AV20vMedicationName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVmedicationname_Internalname, "Values", (String)(dynavVmedicationname.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVothermedicationname_cell_Internalname+"\"  class='"+cellVothermedicationname_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVothermedicationname_Internalname, "v Other Medication Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVothermedicationname_Internalname, AV21vOtherMedicationName, StringUtil.RTrim( context.localUtil.Format( AV21vOtherMedicationName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它药物名称", edtavVothermedicationname_Jsonclick, 0, "Attribute", "", "", "", "", edtavVothermedicationname_Visible, edtavVothermedicationname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_28_2Z2e( true) ;
         }
         else
         {
            wb_table1_28_2Z2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV25BR_MedicationID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25BR_MedicationID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_MEDICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA2Z2( ) ;
         WS2Z2( ) ;
         WE2Z2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281595323", true);
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
         context.AddJavascriptSource("br_medicationupdate.js", "?20202281595323", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavVmedicationname.Name = "vVMEDICATIONNAME";
         dynavVmedicationname.WebTags = "";
         dynavVrxfrequency.Name = "vVRXFREQUENCY";
         dynavVrxfrequency.WebTags = "";
         dynavVupdaterxroute.Name = "vVUPDATERXROUTE";
         dynavVupdaterxroute.WebTags = "";
         cmbavBr_medication_br_medication_inpatientchemo.Name = "BR_MEDICATION_BR_MEDICATION_INPATIENTCHEMO";
         cmbavBr_medication_br_medication_inpatientchemo.WebTags = "";
         cmbavBr_medication_br_medication_inpatientchemo.addItem("", "(请选择)", 0);
         cmbavBr_medication_br_medication_inpatientchemo.addItem("否", "否", 0);
         cmbavBr_medication_br_medication_inpatientchemo.addItem("是", "是", 0);
         cmbavBr_medication_br_medication_inpatientchemo.addItem("不详", "不详", 0);
         if ( cmbavBr_medication_br_medication_inpatientchemo.ItemCount > 0 )
         {
            AV10BR_Medication.gxTpr_Br_medication_inpatientchemo = cmbavBr_medication_br_medication_inpatientchemo.getValidValue(AV10BR_Medication.gxTpr_Br_medication_inpatientchemo);
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockvmedicationname_Internalname = "TEXTBLOCKVMEDICATIONNAME";
         dynavVmedicationname_Internalname = "vVMEDICATIONNAME";
         edtavVothermedicationname_Internalname = "vVOTHERMEDICATIONNAME";
         cellVothermedicationname_cell_Internalname = "VOTHERMEDICATIONNAME_CELL";
         tblTablemergedvmedicationname_Internalname = "TABLEMERGEDVMEDICATIONNAME";
         divTablesplittedvmedicationname_Internalname = "TABLESPLITTEDVMEDICATIONNAME";
         edtavBr_medication_br_medication_rxcode_Internalname = "BR_MEDICATION_BR_MEDICATION_RXCODE";
         edtavBr_medication_br_medication_rxtype_Internalname = "BR_MEDICATION_BR_MEDICATION_RXTYPE";
         edtavBr_medication_br_medication_rxdose_Internalname = "BR_MEDICATION_BR_MEDICATION_RXDOSE";
         edtavBr_medication_br_medication_rxunit_Internalname = "BR_MEDICATION_BR_MEDICATION_RXUNIT";
         lblTextblockvrxfrequency_Internalname = "TEXTBLOCKVRXFREQUENCY";
         dynavVrxfrequency_Internalname = "vVRXFREQUENCY";
         edtavVotherrxfrequency_Internalname = "vVOTHERRXFREQUENCY";
         cellVotherrxfrequency_cell_Internalname = "VOTHERRXFREQUENCY_CELL";
         tblTablemergedvrxfrequency_Internalname = "TABLEMERGEDVRXFREQUENCY";
         divTablesplittedvrxfrequency_Internalname = "TABLESPLITTEDVRXFREQUENCY";
         edtavBr_medication_br_medication_rxquantity_Internalname = "BR_MEDICATION_BR_MEDICATION_RXQUANTITY";
         edtavBr_medication_br_medication_rxdayssupply_Internalname = "BR_MEDICATION_BR_MEDICATION_RXDAYSSUPPLY";
         lblTextblockvupdaterxroute_Internalname = "TEXTBLOCKVUPDATERXROUTE";
         dynavVupdaterxroute_Internalname = "vVUPDATERXROUTE";
         edtavVrxroute_Internalname = "vVRXROUTE";
         cellVrxroute_cell_Internalname = "VRXROUTE_CELL";
         tblTablemergedvupdaterxroute_Internalname = "TABLEMERGEDVUPDATERXROUTE";
         divTablesplittedvupdaterxroute_Internalname = "TABLESPLITTEDVUPDATERXROUTE";
         edtavBr_medication_br_medication_prescriptiondate_Internalname = "BR_MEDICATION_BR_MEDICATION_PRESCRIPTIONDATE";
         edtavBr_medication_br_medication_admitstartdate_Internalname = "BR_MEDICATION_BR_MEDICATION_ADMITSTARTDATE";
         edtavBr_medication_br_medication_admitenddate_Internalname = "BR_MEDICATION_BR_MEDICATION_ADMITENDDATE";
         cmbavBr_medication_br_medication_inpatientchemo_Internalname = "BR_MEDICATION_BR_MEDICATION_INPATIENTCHEMO";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavBr_medication_br_medicationid_Internalname = "BR_MEDICATION_BR_MEDICATIONID";
         edtavBr_medication_br_encounterid_Internalname = "BR_MEDICATION_BR_ENCOUNTERID";
         edtavBr_medication_br_information_patientno_Internalname = "BR_MEDICATION_BR_INFORMATION_PATIENTNO";
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
         edtavVothermedicationname_Jsonclick = "";
         edtavVothermedicationname_Enabled = 1;
         cellVothermedicationname_cell_Class = "";
         dynavVmedicationname_Jsonclick = "";
         dynavVmedicationname.Enabled = 1;
         edtavVotherrxfrequency_Jsonclick = "";
         edtavVotherrxfrequency_Enabled = 1;
         cellVotherrxfrequency_cell_Class = "";
         dynavVrxfrequency_Jsonclick = "";
         dynavVrxfrequency.Enabled = 1;
         edtavVrxroute_Jsonclick = "";
         edtavVrxroute_Enabled = 1;
         cellVrxroute_cell_Class = "";
         dynavVupdaterxroute_Jsonclick = "";
         dynavVupdaterxroute.Enabled = 1;
         edtavVothermedicationname_Visible = 1;
         edtavVotherrxfrequency_Visible = 1;
         edtavVrxroute_Visible = 1;
         edtavBr_medication_br_information_patientno_Jsonclick = "";
         edtavBr_medication_br_information_patientno_Visible = 1;
         edtavBr_medication_br_encounterid_Jsonclick = "";
         edtavBr_medication_br_encounterid_Visible = 1;
         edtavBr_medication_br_medicationid_Jsonclick = "";
         edtavBr_medication_br_medicationid_Visible = 1;
         cmbavBr_medication_br_medication_inpatientchemo_Jsonclick = "";
         cmbavBr_medication_br_medication_inpatientchemo.Enabled = 1;
         edtavBr_medication_br_medication_admitenddate_Jsonclick = "";
         edtavBr_medication_br_medication_admitenddate_Enabled = 1;
         edtavBr_medication_br_medication_admitstartdate_Jsonclick = "";
         edtavBr_medication_br_medication_admitstartdate_Enabled = 1;
         edtavBr_medication_br_medication_prescriptiondate_Jsonclick = "";
         edtavBr_medication_br_medication_prescriptiondate_Enabled = 1;
         edtavBr_medication_br_medication_rxdayssupply_Jsonclick = "";
         edtavBr_medication_br_medication_rxdayssupply_Enabled = 1;
         edtavBr_medication_br_medication_rxquantity_Jsonclick = "";
         edtavBr_medication_br_medication_rxquantity_Enabled = 1;
         edtavBr_medication_br_medication_rxunit_Jsonclick = "";
         edtavBr_medication_br_medication_rxunit_Enabled = 1;
         edtavBr_medication_br_medication_rxdose_Jsonclick = "";
         edtavBr_medication_br_medication_rxdose_Enabled = 1;
         edtavBr_medication_br_medication_rxtype_Jsonclick = "";
         edtavBr_medication_br_medication_rxtype_Enabled = 1;
         edtavBr_medication_br_medication_rxcode_Jsonclick = "";
         edtavBr_medication_br_medication_rxcode_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "药物治疗";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV25BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E142Z2',iparms:[{av:'dynavVmedicationname'},{av:'AV20vMedicationName',fld:'vVMEDICATIONNAME',pic:''},{av:'AV21vOtherMedicationName',fld:'vVOTHERMEDICATIONNAME',pic:''},{av:'AV10BR_Medication',fld:'vBR_MEDICATION',pic:''},{av:'dynavVrxfrequency'},{av:'AV17vRXFrequency',fld:'vVRXFREQUENCY',pic:''},{av:'AV18vOtherRXFrequency',fld:'vVOTHERRXFREQUENCY',pic:''},{av:'dynavVupdaterxroute'},{av:'AV14vUpdateRXRoute',fld:'vVUPDATERXROUTE',pic:''},{av:'AV15vRXRoute',fld:'vVRXROUTE',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV10BR_Medication',fld:'vBR_MEDICATION',pic:''}]}");
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
         AV22tCurrentCode = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV10BR_Medication = new SdtBR_Medication(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockvmedicationname_Jsonclick = "";
         TempTags = "";
         lblTextblockvrxfrequency_Jsonclick = "";
         lblTextblockvupdaterxroute_Jsonclick = "";
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
         H002Z2_A167XT_DefineCodeID = new long[1] ;
         H002Z2_A168XT_DefineCodeName = new String[] {""} ;
         H002Z2_n168XT_DefineCodeName = new bool[] {false} ;
         H002Z2_A165XT_DefindcodeTypeID = new long[1] ;
         H002Z2_A432XT_TenantCode = new String[] {""} ;
         H002Z2_n432XT_TenantCode = new bool[] {false} ;
         AV17vRXFrequency = "";
         H002Z3_A167XT_DefineCodeID = new long[1] ;
         H002Z3_A168XT_DefineCodeName = new String[] {""} ;
         H002Z3_n168XT_DefineCodeName = new bool[] {false} ;
         H002Z3_A165XT_DefindcodeTypeID = new long[1] ;
         H002Z3_A432XT_TenantCode = new String[] {""} ;
         H002Z3_n432XT_TenantCode = new bool[] {false} ;
         AV14vUpdateRXRoute = "";
         H002Z4_A167XT_DefineCodeID = new long[1] ;
         H002Z4_A168XT_DefineCodeName = new String[] {""} ;
         H002Z4_n168XT_DefineCodeName = new bool[] {false} ;
         H002Z4_A165XT_DefindcodeTypeID = new long[1] ;
         H002Z4_A432XT_TenantCode = new String[] {""} ;
         H002Z4_n432XT_TenantCode = new bool[] {false} ;
         AV20vMedicationName = "";
         AV21vOtherMedicationName = "";
         AV18vOtherRXFrequency = "";
         AV15vRXRoute = "";
         GXt_char1 = "";
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV19tErrorMsg = "";
         AV42GXV15 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         sStyleString = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medicationupdate__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicationupdate__default(),
            new Object[][] {
                new Object[] {
               H002Z2_A167XT_DefineCodeID, H002Z2_A168XT_DefineCodeName, H002Z2_n168XT_DefineCodeName, H002Z2_A165XT_DefindcodeTypeID, H002Z2_A432XT_TenantCode, H002Z2_n432XT_TenantCode
               }
               , new Object[] {
               H002Z3_A167XT_DefineCodeID, H002Z3_A168XT_DefineCodeName, H002Z3_n168XT_DefineCodeName, H002Z3_A165XT_DefindcodeTypeID, H002Z3_A432XT_TenantCode, H002Z3_n432XT_TenantCode
               }
               , new Object[] {
               H002Z4_A167XT_DefineCodeID, H002Z4_A168XT_DefineCodeName, H002Z4_n168XT_DefineCodeName, H002Z4_A165XT_DefindcodeTypeID, H002Z4_A432XT_TenantCode, H002Z4_n432XT_TenantCode
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
      private int edtavBr_medication_br_medication_rxcode_Enabled ;
      private int edtavBr_medication_br_medication_rxtype_Enabled ;
      private int edtavBr_medication_br_medication_rxdose_Enabled ;
      private int edtavBr_medication_br_medication_rxunit_Enabled ;
      private int edtavBr_medication_br_medication_rxquantity_Enabled ;
      private int edtavBr_medication_br_medication_rxdayssupply_Enabled ;
      private int edtavBr_medication_br_medication_prescriptiondate_Enabled ;
      private int edtavBr_medication_br_medication_admitstartdate_Enabled ;
      private int edtavBr_medication_br_medication_admitenddate_Enabled ;
      private int edtavBr_medication_br_medicationid_Visible ;
      private int edtavBr_medication_br_encounterid_Visible ;
      private int edtavBr_medication_br_information_patientno_Visible ;
      private int gxdynajaxindex ;
      private int edtavVrxroute_Visible ;
      private int edtavVotherrxfrequency_Visible ;
      private int edtavVothermedicationname_Visible ;
      private int AV41GXV14 ;
      private int AV43GXV16 ;
      private int edtavVrxroute_Enabled ;
      private int edtavVotherrxfrequency_Enabled ;
      private int edtavVothermedicationname_Enabled ;
      private int idxLst ;
      private long AV25BR_MedicationID ;
      private long wcpOAV25BR_MedicationID ;
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
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String divTablesplittedvmedicationname_Internalname ;
      private String lblTextblockvmedicationname_Internalname ;
      private String lblTextblockvmedicationname_Jsonclick ;
      private String edtavBr_medication_br_medication_rxcode_Internalname ;
      private String TempTags ;
      private String edtavBr_medication_br_medication_rxcode_Jsonclick ;
      private String edtavBr_medication_br_medication_rxtype_Internalname ;
      private String edtavBr_medication_br_medication_rxtype_Jsonclick ;
      private String edtavBr_medication_br_medication_rxdose_Internalname ;
      private String edtavBr_medication_br_medication_rxdose_Jsonclick ;
      private String edtavBr_medication_br_medication_rxunit_Internalname ;
      private String edtavBr_medication_br_medication_rxunit_Jsonclick ;
      private String divTablesplittedvrxfrequency_Internalname ;
      private String lblTextblockvrxfrequency_Internalname ;
      private String lblTextblockvrxfrequency_Jsonclick ;
      private String edtavBr_medication_br_medication_rxquantity_Internalname ;
      private String edtavBr_medication_br_medication_rxquantity_Jsonclick ;
      private String edtavBr_medication_br_medication_rxdayssupply_Internalname ;
      private String edtavBr_medication_br_medication_rxdayssupply_Jsonclick ;
      private String divTablesplittedvupdaterxroute_Internalname ;
      private String lblTextblockvupdaterxroute_Internalname ;
      private String lblTextblockvupdaterxroute_Jsonclick ;
      private String edtavBr_medication_br_medication_prescriptiondate_Internalname ;
      private String edtavBr_medication_br_medication_prescriptiondate_Jsonclick ;
      private String edtavBr_medication_br_medication_admitstartdate_Internalname ;
      private String edtavBr_medication_br_medication_admitstartdate_Jsonclick ;
      private String edtavBr_medication_br_medication_admitenddate_Internalname ;
      private String edtavBr_medication_br_medication_admitenddate_Jsonclick ;
      private String cmbavBr_medication_br_medication_inpatientchemo_Internalname ;
      private String cmbavBr_medication_br_medication_inpatientchemo_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_medication_br_medicationid_Internalname ;
      private String edtavBr_medication_br_medicationid_Jsonclick ;
      private String edtavBr_medication_br_encounterid_Internalname ;
      private String edtavBr_medication_br_encounterid_Jsonclick ;
      private String edtavBr_medication_br_information_patientno_Internalname ;
      private String edtavBr_medication_br_information_patientno_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String dynavVmedicationname_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String dynavVrxfrequency_Internalname ;
      private String dynavVupdaterxroute_Internalname ;
      private String edtavVothermedicationname_Internalname ;
      private String edtavVotherrxfrequency_Internalname ;
      private String edtavVrxroute_Internalname ;
      private String GXt_char1 ;
      private String cellVothermedicationname_cell_Class ;
      private String cellVothermedicationname_cell_Internalname ;
      private String cellVotherrxfrequency_cell_Class ;
      private String cellVotherrxfrequency_cell_Internalname ;
      private String cellVrxroute_cell_Class ;
      private String cellVrxroute_cell_Internalname ;
      private String sStyleString ;
      private String tblTablemergedvupdaterxroute_Internalname ;
      private String dynavVupdaterxroute_Jsonclick ;
      private String edtavVrxroute_Jsonclick ;
      private String tblTablemergedvrxfrequency_Internalname ;
      private String dynavVrxfrequency_Jsonclick ;
      private String edtavVotherrxfrequency_Jsonclick ;
      private String tblTablemergedvmedicationname_Internalname ;
      private String dynavVmedicationname_Jsonclick ;
      private String edtavVothermedicationname_Jsonclick ;
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
      private bool AV12CheckRequiredFieldsResult ;
      private bool AV16tFlag ;
      private String AV22tCurrentCode ;
      private String AV17vRXFrequency ;
      private String AV14vUpdateRXRoute ;
      private String AV20vMedicationName ;
      private String AV21vOtherMedicationName ;
      private String AV18vOtherRXFrequency ;
      private String AV15vRXRoute ;
      private String AV19tErrorMsg ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavVmedicationname ;
      private GXCombobox dynavVrxfrequency ;
      private GXCombobox dynavVupdaterxroute ;
      private GXCombobox cmbavBr_medication_br_medication_inpatientchemo ;
      private IDataStoreProvider pr_default ;
      private long[] H002Z2_A167XT_DefineCodeID ;
      private String[] H002Z2_A168XT_DefineCodeName ;
      private bool[] H002Z2_n168XT_DefineCodeName ;
      private long[] H002Z2_A165XT_DefindcodeTypeID ;
      private String[] H002Z2_A432XT_TenantCode ;
      private bool[] H002Z2_n432XT_TenantCode ;
      private long[] H002Z3_A167XT_DefineCodeID ;
      private String[] H002Z3_A168XT_DefineCodeName ;
      private bool[] H002Z3_n168XT_DefineCodeName ;
      private long[] H002Z3_A165XT_DefindcodeTypeID ;
      private String[] H002Z3_A432XT_TenantCode ;
      private bool[] H002Z3_n432XT_TenantCode ;
      private long[] H002Z4_A167XT_DefineCodeID ;
      private String[] H002Z4_A168XT_DefineCodeName ;
      private bool[] H002Z4_n168XT_DefineCodeName ;
      private long[] H002Z4_A165XT_DefindcodeTypeID ;
      private String[] H002Z4_A432XT_TenantCode ;
      private bool[] H002Z4_n432XT_TenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXBaseCollection<SdtMessages_Message> AV42GXV15 ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtBR_Medication AV10BR_Medication ;
   }

   public class br_medicationupdate__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_medicationupdate__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmH002Z2 ;
        prmH002Z2 = new Object[] {
        new Object[] {"@AV22tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH002Z3 ;
        prmH002Z3 = new Object[] {
        new Object[] {"@AV22tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH002Z4 ;
        prmH002Z4 = new Object[] {
        new Object[] {"@AV22tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H002Z2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 33) AND ([XT_TenantCode] = @AV22tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Z2,0,0,true,false )
           ,new CursorDef("H002Z3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 25) AND ([XT_TenantCode] = @AV22tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Z3,0,0,true,false )
           ,new CursorDef("H002Z4", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 26) AND ([XT_TenantCode] = @AV22tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Z4,0,0,true,false )
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
     }
  }

}

}
