/*
               File: BR_DiagnosisInsert
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:16:42.18
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
   public class br_diagnosisinsert : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_diagnosisinsert( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_diagnosisinsert( IGxContext context )
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
         this.AV6BR_EncounterID = aP0_BR_EncounterID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavVdxtsource = new GXCombobox();
         dynavVdxtype = new GXCombobox();
         cmbavBr_diagnosis_br_diagnosis_initialdx = new GXCombobox();
         cmbavVmetastasesdx = new GXCombobox();
         dynavBr_diagnosis_br_diagnosis_dxtsource = new GXCombobox();
         dynavBr_diagnosis_br_diagnosis_dxtype = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVDXTSOURCE") == 0 )
            {
               AV14tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVDXTSOURCE8N2( AV14tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVDXTYPE") == 0 )
            {
               AV14tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVDXTYPE8N2( AV14tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE") == 0 )
            {
               AV14tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE8N2( AV14tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE") == 0 )
            {
               AV14tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE8N2( AV14tCurrentCode) ;
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
               AV6BR_EncounterID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6BR_EncounterID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA8N2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START8N2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815164224", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_diagnosisinsert.aspx") + "?" + UrlEncode("" +AV6BR_EncounterID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_diagnosis", AV5BR_Diagnosis);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_diagnosis", AV5BR_Diagnosis);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS", AV5BR_Diagnosis);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS", AV5BR_Diagnosis);
         }
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV14tCurrentCode);
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
            WE8N2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT8N2( ) ;
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
         return formatLink("br_diagnosisinsert.aspx") + "?" + UrlEncode("" +AV6BR_EncounterID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_DiagnosisInsert" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB8N0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_diagnosis_br_diagnosis_no_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_diagnosis_br_diagnosis_no_Internalname, "诊断次序", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_diagnosis_br_diagnosis_no_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5BR_Diagnosis.gxTpr_Br_diagnosis_no), 10, 0, ".", "")), ((edtavBr_diagnosis_br_diagnosis_no_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV5BR_Diagnosis.gxTpr_Br_diagnosis_no), "ZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(AV5BR_Diagnosis.gxTpr_Br_diagnosis_no), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_diagnosis_br_diagnosis_no_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_diagnosis_br_diagnosis_no_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_DiagnosisInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_diagnosis_br_diagnosis_dxdescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_diagnosis_br_diagnosis_dxdescription_Internalname, "诊断名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_diagnosis_br_diagnosis_dxdescription_Internalname, AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxdescription, StringUtil.RTrim( context.localUtil.Format( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxdescription, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_diagnosis_br_diagnosis_dxdescription_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_diagnosis_br_diagnosis_dxdescription_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavVdxtsource_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVdxtsource_Internalname, "诊断来源", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVdxtsource, dynavVdxtsource_Internalname, StringUtil.RTrim( AV13vDXTsource), 1, dynavVdxtsource_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVdxtsource.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "", true, "HLP_BR_DiagnosisInsert.htm");
            dynavVdxtsource.CurrentValue = StringUtil.RTrim( AV13vDXTsource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdxtsource_Internalname, "Values", (String)(dynavVdxtsource.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_diagnosis_br_diagnosis_dxid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_diagnosis_br_diagnosis_dxid_Internalname, "疾病序号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_diagnosis_br_diagnosis_dxid_Internalname, AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxid, StringUtil.RTrim( context.localUtil.Format( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxid, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_diagnosis_br_diagnosis_dxid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_diagnosis_br_diagnosis_dxid_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_diagnosis_br_diagnosis_dxcode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_diagnosis_br_diagnosis_dxcode_Internalname, "疾病代码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_diagnosis_br_diagnosis_dxcode_Internalname, AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxcode, StringUtil.RTrim( context.localUtil.Format( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxcode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_diagnosis_br_diagnosis_dxcode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_diagnosis_br_diagnosis_dxcode_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavVdxtype_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVdxtype_Internalname, "疾病类型", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVdxtype, dynavVdxtype_Internalname, StringUtil.RTrim( AV15vDXType), 1, dynavVdxtype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVdxtype.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "", true, "HLP_BR_DiagnosisInsert.htm");
            dynavVdxtype.CurrentValue = StringUtil.RTrim( AV15vDXType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdxtype_Internalname, "Values", (String)(dynavVdxtype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_diagnosis_br_diagnosis_initialdx_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_diagnosis_br_diagnosis_initialdx_Internalname, "是否为原发肿瘤", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_diagnosis_br_diagnosis_initialdx, cmbavBr_diagnosis_br_diagnosis_initialdx_Internalname, StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_initialdx), 1, cmbavBr_diagnosis_br_diagnosis_initialdx_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_diagnosis_br_diagnosis_initialdx.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "", true, "HLP_BR_DiagnosisInsert.htm");
            cmbavBr_diagnosis_br_diagnosis_initialdx.CurrentValue = StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_initialdx);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_diagnosis_br_diagnosis_initialdx_Internalname, "Values", (String)(cmbavBr_diagnosis_br_diagnosis_initialdx.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavVmetastasesdx_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavVmetastasesdx_Internalname, "是否为转移肿瘤", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavVmetastasesdx, cmbavVmetastasesdx_Internalname, StringUtil.RTrim( AV18vMetastasesDX), 1, cmbavVmetastasesdx_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavVmetastasesdx.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "", true, "HLP_BR_DiagnosisInsert.htm");
            cmbavVmetastasesdx.CurrentValue = StringUtil.RTrim( AV18vMetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVmetastasesdx_Internalname, "Values", (String)(cmbavVmetastasesdx.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavVdxsource_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVdxsource_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVdxsource_Internalname, "转移肿瘤来源", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVdxsource_Internalname, AV19vDXSource, StringUtil.RTrim( context.localUtil.Format( AV19vDXSource, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVdxsource_Jsonclick, 0, "Attribute", "", "", "", "", edtavVdxsource_Visible, edtavVdxsource_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Internalname, "肿瘤临床分期", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Internalname, AV5BR_Diagnosis.gxTpr_Br_diagnosis_tumorstageclinical, StringUtil.RTrim( context.localUtil.Format( AV5BR_Diagnosis.gxTpr_Br_diagnosis_tumorstageclinical, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisInsert.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "保存", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_DiagnosisInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_DiagnosisInsert.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_diagnosis_br_diagnosisid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5BR_Diagnosis.gxTpr_Br_diagnosisid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV5BR_Diagnosis.gxTpr_Br_diagnosisid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_diagnosis_br_diagnosisid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_diagnosis_br_diagnosisid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_DiagnosisInsert.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_diagnosis_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5BR_Diagnosis.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV5BR_Diagnosis.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_diagnosis_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_diagnosis_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_DiagnosisInsert.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_diagnosis_br_information_patientno_Internalname, AV5BR_Diagnosis.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV5BR_Diagnosis.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_diagnosis_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_diagnosis_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisInsert.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_diagnosis_br_diagnosis_dxtsource, dynavBr_diagnosis_br_diagnosis_dxtsource_Internalname, StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource), 1, dynavBr_diagnosis_br_diagnosis_dxtsource_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", dynavBr_diagnosis_br_diagnosis_dxtsource.Visible, 1, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "", true, "HLP_BR_DiagnosisInsert.htm");
            dynavBr_diagnosis_br_diagnosis_dxtsource.CurrentValue = StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_diagnosis_br_diagnosis_dxtsource_Internalname, "Values", (String)(dynavBr_diagnosis_br_diagnosis_dxtsource.ToJavascriptSource()), true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_diagnosis_br_diagnosis_dxtype, dynavBr_diagnosis_br_diagnosis_dxtype_Internalname, StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype), 1, dynavBr_diagnosis_br_diagnosis_dxtype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", dynavBr_diagnosis_br_diagnosis_dxtype.Visible, 1, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "", true, "HLP_BR_DiagnosisInsert.htm");
            dynavBr_diagnosis_br_diagnosis_dxtype.CurrentValue = StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_diagnosis_br_diagnosis_dxtype_Internalname, "Values", (String)(dynavBr_diagnosis_br_diagnosis_dxtype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START8N2( )
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
         STRUP8N0( ) ;
      }

      protected void WS8N2( )
      {
         START8N2( ) ;
         EVT8N2( ) ;
      }

      protected void EVT8N2( )
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
                              E118N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E128N2 ();
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
                                    E138N2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E148N2 ();
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

      protected void WE8N2( )
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

      protected void PA8N2( )
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
               GX_FocusControl = edtavBr_diagnosis_br_diagnosis_no_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvVDXTSOURCE8N2( String AV14tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVDXTSOURCE_data8N2( AV14tCurrentCode) ;
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

      protected void GXVvVDXTSOURCE_html8N2( String AV14tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVDXTSOURCE_data8N2( AV14tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVdxtsource.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVdxtsource.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVDXTSOURCE_data8N2( String AV14tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H008N2 */
         pr_default.execute(0, new Object[] {AV14tCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008N2_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008N2_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvVDXTYPE8N2( String AV14tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVDXTYPE_data8N2( AV14tCurrentCode) ;
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

      protected void GXVvVDXTYPE_html8N2( String AV14tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVDXTYPE_data8N2( AV14tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVdxtype.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVdxtype.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVDXTYPE_data8N2( String AV14tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008N3 */
         pr_default.execute(1, new Object[] {AV14tCurrentCode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008N3_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008N3_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE8N2( String AV14tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE_data8N2( AV14tCurrentCode) ;
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

      protected void GXVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE_html8N2( String AV14tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE_data8N2( AV14tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_diagnosis_br_diagnosis_dxtsource.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_diagnosis_br_diagnosis_dxtsource.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE_data8N2( String AV14tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H008N4 */
         pr_default.execute(2, new Object[] {AV14tCurrentCode});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008N4_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008N4_A168XT_DefineCodeName[0]);
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void GXDLVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE8N2( String AV14tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE_data8N2( AV14tCurrentCode) ;
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

      protected void GXVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE_html8N2( String AV14tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE_data8N2( AV14tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_diagnosis_br_diagnosis_dxtype.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_diagnosis_br_diagnosis_dxtype.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE_data8N2( String AV14tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008N5 */
         pr_default.execute(3, new Object[] {AV14tCurrentCode});
         while ( (pr_default.getStatus(3) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008N5_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008N5_A168XT_DefineCodeName[0]);
            pr_default.readNext(3);
         }
         pr_default.close(3);
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
         if ( dynavVdxtsource.ItemCount > 0 )
         {
            AV13vDXTsource = dynavVdxtsource.getValidValue(AV13vDXTsource);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vDXTsource", AV13vDXTsource);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVdxtsource.CurrentValue = StringUtil.RTrim( AV13vDXTsource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdxtsource_Internalname, "Values", dynavVdxtsource.ToJavascriptSource(), true);
         }
         if ( dynavVdxtype.ItemCount > 0 )
         {
            AV15vDXType = dynavVdxtype.getValidValue(AV15vDXType);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vDXType", AV15vDXType);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVdxtype.CurrentValue = StringUtil.RTrim( AV15vDXType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdxtype_Internalname, "Values", dynavVdxtype.ToJavascriptSource(), true);
         }
         if ( cmbavBr_diagnosis_br_diagnosis_initialdx.ItemCount > 0 )
         {
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_initialdx = cmbavBr_diagnosis_br_diagnosis_initialdx.getValidValue(AV5BR_Diagnosis.gxTpr_Br_diagnosis_initialdx);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_diagnosis_br_diagnosis_initialdx.CurrentValue = StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_initialdx);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_diagnosis_br_diagnosis_initialdx_Internalname, "Values", cmbavBr_diagnosis_br_diagnosis_initialdx.ToJavascriptSource(), true);
         }
         if ( cmbavVmetastasesdx.ItemCount > 0 )
         {
            AV18vMetastasesDX = cmbavVmetastasesdx.getValidValue(AV18vMetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vMetastasesDX", AV18vMetastasesDX);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavVmetastasesdx.CurrentValue = StringUtil.RTrim( AV18vMetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVmetastasesdx_Internalname, "Values", cmbavVmetastasesdx.ToJavascriptSource(), true);
         }
         if ( dynavBr_diagnosis_br_diagnosis_dxtsource.ItemCount > 0 )
         {
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource = dynavBr_diagnosis_br_diagnosis_dxtsource.getValidValue(AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_diagnosis_br_diagnosis_dxtsource.CurrentValue = StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_diagnosis_br_diagnosis_dxtsource_Internalname, "Values", dynavBr_diagnosis_br_diagnosis_dxtsource.ToJavascriptSource(), true);
         }
         if ( dynavBr_diagnosis_br_diagnosis_dxtype.ItemCount > 0 )
         {
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype = dynavBr_diagnosis_br_diagnosis_dxtype.getValidValue(AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_diagnosis_br_diagnosis_dxtype.CurrentValue = StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_diagnosis_br_diagnosis_dxtype_Internalname, "Values", dynavBr_diagnosis_br_diagnosis_dxtype.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF8N2( ) ;
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

      protected void RF8N2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E128N2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E148N2 ();
            WB8N0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes8N2( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP8N0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E118N2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVvVDXTSOURCE_html8N2( AV14tCurrentCode) ;
         GXVvVDXTYPE_html8N2( AV14tCurrentCode) ;
         GXVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE_html8N2( AV14tCurrentCode) ;
         GXVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE_html8N2( AV14tCurrentCode) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_diagnosis"), AV5BR_Diagnosis);
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_diagnosis_br_diagnosis_no_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_diagnosis_br_diagnosis_no_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_DIAGNOSIS_BR_DIAGNOSIS_NO");
               GX_FocusControl = edtavBr_diagnosis_br_diagnosis_no_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5BR_Diagnosis.gxTpr_Br_diagnosis_no = 0;
            }
            else
            {
               AV5BR_Diagnosis.gxTpr_Br_diagnosis_no = (long)(context.localUtil.CToN( cgiGet( edtavBr_diagnosis_br_diagnosis_no_Internalname), ".", ","));
            }
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxdescription = cgiGet( edtavBr_diagnosis_br_diagnosis_dxdescription_Internalname);
            dynavVdxtsource.CurrentValue = cgiGet( dynavVdxtsource_Internalname);
            AV13vDXTsource = cgiGet( dynavVdxtsource_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vDXTsource", AV13vDXTsource);
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxid = cgiGet( edtavBr_diagnosis_br_diagnosis_dxid_Internalname);
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxcode = cgiGet( edtavBr_diagnosis_br_diagnosis_dxcode_Internalname);
            dynavVdxtype.CurrentValue = cgiGet( dynavVdxtype_Internalname);
            AV15vDXType = cgiGet( dynavVdxtype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vDXType", AV15vDXType);
            cmbavBr_diagnosis_br_diagnosis_initialdx.CurrentValue = cgiGet( cmbavBr_diagnosis_br_diagnosis_initialdx_Internalname);
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_initialdx = cgiGet( cmbavBr_diagnosis_br_diagnosis_initialdx_Internalname);
            cmbavVmetastasesdx.CurrentValue = cgiGet( cmbavVmetastasesdx_Internalname);
            AV18vMetastasesDX = cgiGet( cmbavVmetastasesdx_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vMetastasesDX", AV18vMetastasesDX);
            AV19vDXSource = cgiGet( edtavVdxsource_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vDXSource", AV19vDXSource);
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_tumorstageclinical = cgiGet( edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_diagnosis_br_diagnosisid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_diagnosis_br_diagnosisid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_DIAGNOSIS_BR_DIAGNOSISID");
               GX_FocusControl = edtavBr_diagnosis_br_diagnosisid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5BR_Diagnosis.gxTpr_Br_diagnosisid = 0;
            }
            else
            {
               AV5BR_Diagnosis.gxTpr_Br_diagnosisid = (long)(context.localUtil.CToN( cgiGet( edtavBr_diagnosis_br_diagnosisid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_diagnosis_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_diagnosis_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_DIAGNOSIS_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_diagnosis_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5BR_Diagnosis.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV5BR_Diagnosis.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_diagnosis_br_encounterid_Internalname), ".", ","));
            }
            AV5BR_Diagnosis.gxTpr_Br_information_patientno = cgiGet( edtavBr_diagnosis_br_information_patientno_Internalname);
            dynavBr_diagnosis_br_diagnosis_dxtsource.CurrentValue = cgiGet( dynavBr_diagnosis_br_diagnosis_dxtsource_Internalname);
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource = cgiGet( dynavBr_diagnosis_br_diagnosis_dxtsource_Internalname);
            dynavBr_diagnosis_br_diagnosis_dxtype.CurrentValue = cgiGet( dynavBr_diagnosis_br_diagnosis_dxtype_Internalname);
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype = cgiGet( dynavBr_diagnosis_br_diagnosis_dxtype_Internalname);
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
            GXVvVDXTSOURCE_html8N2( AV14tCurrentCode) ;
            GXVvVDXTYPE_html8N2( AV14tCurrentCode) ;
            GXVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE_html8N2( AV14tCurrentCode) ;
            GXVBR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE_html8N2( AV14tCurrentCode) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E118N2 ();
         if (returnInSub) return;
      }

      protected void E118N2( )
      {
         /* Start Routine */
         GXt_char1 = AV14tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV14tCurrentCode = GXt_char1;
         edtavBr_diagnosis_br_diagnosisid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_diagnosis_br_diagnosisid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_diagnosis_br_diagnosisid_Visible), 5, 0)), true);
         edtavBr_diagnosis_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_diagnosis_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_diagnosis_br_encounterid_Visible), 5, 0)), true);
         edtavBr_diagnosis_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_diagnosis_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_diagnosis_br_information_patientno_Visible), 5, 0)), true);
         dynavBr_diagnosis_br_diagnosis_dxtsource.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_diagnosis_br_diagnosis_dxtsource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_diagnosis_br_diagnosis_dxtsource.Visible), 5, 0)), true);
         dynavBr_diagnosis_br_diagnosis_dxtype.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_diagnosis_br_diagnosis_dxtype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_diagnosis_br_diagnosis_dxtype.Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV7CheckRequiredFieldsResult = true;
         if ( (0==AV5BR_Diagnosis.gxTpr_Br_diagnosis_no) )
         {
            GX_msglist.addItem("");
            AV7CheckRequiredFieldsResult = false;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxdescription)) )
         {
            GX_msglist.addItem("诊断名称是必须填写的。");
            AV7CheckRequiredFieldsResult = false;
         }
      }

      protected void S122( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV34GXV12 = 1;
         while ( AV34GXV12 <= AV11Messages.Count )
         {
            AV10Message = ((SdtMessages_Message)AV11Messages.Item(AV34GXV12));
            GX_msglist.addItem(AV10Message.gxTpr_Description);
            AV34GXV12 = (int)(AV34GXV12+1);
         }
      }

      protected void E128N2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E138N2 ();
         if (returnInSub) return;
      }

      protected void E138N2( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV20tCheckFlag) ;
         if ( ! AV20tCheckFlag )
         {
            AV16tFlag = true;
            if ( ( AV16tFlag ) && (0==AV5BR_Diagnosis.gxTpr_Br_diagnosis_no) )
            {
               GX_msglist.addItem("诊断次序是必填的");
               AV16tFlag = false;
            }
            else
            {
               AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource = AV13vDXTsource;
               AV5BR_Diagnosis.gxTpr_Br_diagnosis_metastasesdx = AV18vMetastasesDX;
               AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype = AV15vDXType;
               AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxsource = AV19vDXSource;
            }
            if ( ( AV16tFlag ) && String.IsNullOrEmpty(StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxdescription)) )
            {
               GX_msglist.addItem("诊断名称是必填的");
               AV16tFlag = false;
            }
            else
            {
               AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource = AV13vDXTsource;
               AV5BR_Diagnosis.gxTpr_Br_diagnosis_metastasesdx = AV18vMetastasesDX;
               AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype = AV15vDXType;
               AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxsource = AV19vDXSource;
            }
            AV5BR_Diagnosis.gxTpr_Br_encounterid = AV6BR_EncounterID;
            if ( StringUtil.StrCmp(AV5BR_Diagnosis.gxTpr_Br_diagnosis_metastasesdx, "否") == 0 )
            {
               AV5BR_Diagnosis.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_SetNull();
            }
            if ( StringUtil.StrCmp(AV5BR_Diagnosis.gxTpr_Br_diagnosis_metastasesdx, "不详") == 0 )
            {
               AV5BR_Diagnosis.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_SetNull();
            }
            AV5BR_Diagnosis.Save();
            if ( AV5BR_Diagnosis.Success() )
            {
               context.CommitDataStores("br_diagnosisinsert",pr_default);
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
            else
            {
               AV17ErrorMsg = "";
               AV36GXV14 = 1;
               AV35GXV13 = AV5BR_Diagnosis.GetMessages();
               while ( AV36GXV14 <= AV35GXV13.Count )
               {
                  AV10Message = ((SdtMessages_Message)AV35GXV13.Item(AV36GXV14));
                  AV17ErrorMsg = AV17ErrorMsg + StringUtil.Trim( AV10Message.gxTpr_Description);
                  AV36GXV14 = (int)(AV36GXV14+1);
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5BR_Diagnosis", AV5BR_Diagnosis);
      }

      protected void nextLoad( )
      {
      }

      protected void E148N2( )
      {
         /* Load Routine */
         edtavVdxsource_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdxsource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdxsource_Visible), 5, 0)), true);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource)) )
         {
            dynavVdxtsource.addItem(AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource, AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource, 0);
            AV13vDXTsource = AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtsource;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vDXTsource", AV13vDXTsource);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype)) )
         {
            dynavVdxtype.addItem(AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype, AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype, 0);
            AV15vDXType = AV5BR_Diagnosis.gxTpr_Br_diagnosis_dxtype;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vDXType", AV15vDXType);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV5BR_Diagnosis.gxTpr_Br_diagnosis_metastasesdx)) )
         {
            cmbavVmetastasesdx.addItem(AV5BR_Diagnosis.gxTpr_Br_diagnosis_metastasesdx, AV5BR_Diagnosis.gxTpr_Br_diagnosis_metastasesdx, 0);
            AV18vMetastasesDX = AV5BR_Diagnosis.gxTpr_Br_diagnosis_metastasesdx;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vMetastasesDX", AV18vMetastasesDX);
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6BR_EncounterID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV6BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA8N2( ) ;
         WS8N2( ) ;
         WE8N2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815164384", true);
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
         context.AddJavascriptSource("br_diagnosisinsert.js", "?202022815164384", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavVdxtsource.Name = "vVDXTSOURCE";
         dynavVdxtsource.WebTags = "";
         dynavVdxtype.Name = "vVDXTYPE";
         dynavVdxtype.WebTags = "";
         cmbavBr_diagnosis_br_diagnosis_initialdx.Name = "BR_DIAGNOSIS_BR_DIAGNOSIS_INITIALDX";
         cmbavBr_diagnosis_br_diagnosis_initialdx.WebTags = "";
         cmbavBr_diagnosis_br_diagnosis_initialdx.addItem("", "(请选择)", 0);
         cmbavBr_diagnosis_br_diagnosis_initialdx.addItem("否", "否", 0);
         cmbavBr_diagnosis_br_diagnosis_initialdx.addItem("是", "是", 0);
         cmbavBr_diagnosis_br_diagnosis_initialdx.addItem("不详", "不详", 0);
         if ( cmbavBr_diagnosis_br_diagnosis_initialdx.ItemCount > 0 )
         {
            AV5BR_Diagnosis.gxTpr_Br_diagnosis_initialdx = cmbavBr_diagnosis_br_diagnosis_initialdx.getValidValue(AV5BR_Diagnosis.gxTpr_Br_diagnosis_initialdx);
         }
         cmbavVmetastasesdx.Name = "vVMETASTASESDX";
         cmbavVmetastasesdx.WebTags = "";
         cmbavVmetastasesdx.addItem("", "(请选择)", 0);
         cmbavVmetastasesdx.addItem("否", "否", 0);
         cmbavVmetastasesdx.addItem("是", "是", 0);
         cmbavVmetastasesdx.addItem("不详", "不详", 0);
         if ( cmbavVmetastasesdx.ItemCount > 0 )
         {
            AV18vMetastasesDX = cmbavVmetastasesdx.getValidValue(AV18vMetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vMetastasesDX", AV18vMetastasesDX);
         }
         dynavBr_diagnosis_br_diagnosis_dxtsource.Name = "BR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE";
         dynavBr_diagnosis_br_diagnosis_dxtsource.WebTags = "";
         dynavBr_diagnosis_br_diagnosis_dxtype.Name = "BR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE";
         dynavBr_diagnosis_br_diagnosis_dxtype.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavBr_diagnosis_br_diagnosis_no_Internalname = "BR_DIAGNOSIS_BR_DIAGNOSIS_NO";
         edtavBr_diagnosis_br_diagnosis_dxdescription_Internalname = "BR_DIAGNOSIS_BR_DIAGNOSIS_DXDESCRIPTION";
         dynavVdxtsource_Internalname = "vVDXTSOURCE";
         edtavBr_diagnosis_br_diagnosis_dxid_Internalname = "BR_DIAGNOSIS_BR_DIAGNOSIS_DXID";
         edtavBr_diagnosis_br_diagnosis_dxcode_Internalname = "BR_DIAGNOSIS_BR_DIAGNOSIS_DXCODE";
         dynavVdxtype_Internalname = "vVDXTYPE";
         cmbavBr_diagnosis_br_diagnosis_initialdx_Internalname = "BR_DIAGNOSIS_BR_DIAGNOSIS_INITIALDX";
         cmbavVmetastasesdx_Internalname = "vVMETASTASESDX";
         edtavVdxsource_Internalname = "vVDXSOURCE";
         edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Internalname = "BR_DIAGNOSIS_BR_DIAGNOSIS_TUMORSTAGECLINICAL";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavBr_diagnosis_br_diagnosisid_Internalname = "BR_DIAGNOSIS_BR_DIAGNOSISID";
         edtavBr_diagnosis_br_encounterid_Internalname = "BR_DIAGNOSIS_BR_ENCOUNTERID";
         edtavBr_diagnosis_br_information_patientno_Internalname = "BR_DIAGNOSIS_BR_INFORMATION_PATIENTNO";
         dynavBr_diagnosis_br_diagnosis_dxtsource_Internalname = "BR_DIAGNOSIS_BR_DIAGNOSIS_DXTSOURCE";
         dynavBr_diagnosis_br_diagnosis_dxtype_Internalname = "BR_DIAGNOSIS_BR_DIAGNOSIS_DXTYPE";
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
         dynavBr_diagnosis_br_diagnosis_dxtype_Jsonclick = "";
         dynavBr_diagnosis_br_diagnosis_dxtype.Visible = 1;
         dynavBr_diagnosis_br_diagnosis_dxtsource_Jsonclick = "";
         dynavBr_diagnosis_br_diagnosis_dxtsource.Visible = 1;
         edtavBr_diagnosis_br_information_patientno_Jsonclick = "";
         edtavBr_diagnosis_br_information_patientno_Visible = 1;
         edtavBr_diagnosis_br_encounterid_Jsonclick = "";
         edtavBr_diagnosis_br_encounterid_Visible = 1;
         edtavBr_diagnosis_br_diagnosisid_Jsonclick = "";
         edtavBr_diagnosis_br_diagnosisid_Visible = 1;
         edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Jsonclick = "";
         edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Enabled = 1;
         edtavVdxsource_Jsonclick = "";
         edtavVdxsource_Enabled = 1;
         edtavVdxsource_Visible = 1;
         cmbavVmetastasesdx_Jsonclick = "";
         cmbavVmetastasesdx.Enabled = 1;
         cmbavBr_diagnosis_br_diagnosis_initialdx_Jsonclick = "";
         cmbavBr_diagnosis_br_diagnosis_initialdx.Enabled = 1;
         dynavVdxtype_Jsonclick = "";
         dynavVdxtype.Enabled = 1;
         edtavBr_diagnosis_br_diagnosis_dxcode_Jsonclick = "";
         edtavBr_diagnosis_br_diagnosis_dxcode_Enabled = 1;
         edtavBr_diagnosis_br_diagnosis_dxid_Jsonclick = "";
         edtavBr_diagnosis_br_diagnosis_dxid_Enabled = 1;
         dynavVdxtsource_Jsonclick = "";
         dynavVdxtsource.Enabled = 1;
         edtavBr_diagnosis_br_diagnosis_dxdescription_Jsonclick = "";
         edtavBr_diagnosis_br_diagnosis_dxdescription_Enabled = 1;
         edtavBr_diagnosis_br_diagnosis_no_Jsonclick = "";
         edtavBr_diagnosis_br_diagnosis_no_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "诊断";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV6BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E138N2',iparms:[{av:'AV5BR_Diagnosis',fld:'vBR_DIAGNOSIS',pic:''},{av:'dynavVdxtsource'},{av:'AV13vDXTsource',fld:'vVDXTSOURCE',pic:''},{av:'cmbavVmetastasesdx'},{av:'AV18vMetastasesDX',fld:'vVMETASTASESDX',pic:''},{av:'dynavVdxtype'},{av:'AV15vDXType',fld:'vVDXTYPE',pic:''},{av:'AV19vDXSource',fld:'vVDXSOURCE',pic:''},{av:'AV6BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV5BR_Diagnosis',fld:'vBR_DIAGNOSIS',pic:''}]}");
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
         AV14tCurrentCode = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV5BR_Diagnosis = new SdtBR_Diagnosis(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         AV13vDXTsource = "";
         AV15vDXType = "";
         AV18vMetastasesDX = "";
         AV19vDXSource = "";
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
         H008N2_A167XT_DefineCodeID = new long[1] ;
         H008N2_A168XT_DefineCodeName = new String[] {""} ;
         H008N2_n168XT_DefineCodeName = new bool[] {false} ;
         H008N2_A165XT_DefindcodeTypeID = new long[1] ;
         H008N2_A432XT_TenantCode = new String[] {""} ;
         H008N2_n432XT_TenantCode = new bool[] {false} ;
         H008N3_A167XT_DefineCodeID = new long[1] ;
         H008N3_A168XT_DefineCodeName = new String[] {""} ;
         H008N3_n168XT_DefineCodeName = new bool[] {false} ;
         H008N3_A165XT_DefindcodeTypeID = new long[1] ;
         H008N3_A432XT_TenantCode = new String[] {""} ;
         H008N3_n432XT_TenantCode = new bool[] {false} ;
         H008N4_A167XT_DefineCodeID = new long[1] ;
         H008N4_A168XT_DefineCodeName = new String[] {""} ;
         H008N4_n168XT_DefineCodeName = new bool[] {false} ;
         H008N4_A165XT_DefindcodeTypeID = new long[1] ;
         H008N4_A432XT_TenantCode = new String[] {""} ;
         H008N4_n432XT_TenantCode = new bool[] {false} ;
         H008N5_A167XT_DefineCodeID = new long[1] ;
         H008N5_A168XT_DefineCodeName = new String[] {""} ;
         H008N5_n168XT_DefineCodeName = new bool[] {false} ;
         H008N5_A165XT_DefindcodeTypeID = new long[1] ;
         H008N5_A432XT_TenantCode = new String[] {""} ;
         H008N5_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         AV11Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV10Message = new SdtMessages_Message(context);
         AV8Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV17ErrorMsg = "";
         AV35GXV13 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_diagnosisinsert__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_diagnosisinsert__default(),
            new Object[][] {
                new Object[] {
               H008N2_A167XT_DefineCodeID, H008N2_A168XT_DefineCodeName, H008N2_n168XT_DefineCodeName, H008N2_A165XT_DefindcodeTypeID, H008N2_A432XT_TenantCode, H008N2_n432XT_TenantCode
               }
               , new Object[] {
               H008N3_A167XT_DefineCodeID, H008N3_A168XT_DefineCodeName, H008N3_n168XT_DefineCodeName, H008N3_A165XT_DefindcodeTypeID, H008N3_A432XT_TenantCode, H008N3_n432XT_TenantCode
               }
               , new Object[] {
               H008N4_A167XT_DefineCodeID, H008N4_A168XT_DefineCodeName, H008N4_n168XT_DefineCodeName, H008N4_A165XT_DefindcodeTypeID, H008N4_A432XT_TenantCode, H008N4_n432XT_TenantCode
               }
               , new Object[] {
               H008N5_A167XT_DefineCodeID, H008N5_A168XT_DefineCodeName, H008N5_n168XT_DefineCodeName, H008N5_A165XT_DefindcodeTypeID, H008N5_A432XT_TenantCode, H008N5_n432XT_TenantCode
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
      private int edtavBr_diagnosis_br_diagnosis_no_Enabled ;
      private int edtavBr_diagnosis_br_diagnosis_dxdescription_Enabled ;
      private int edtavBr_diagnosis_br_diagnosis_dxid_Enabled ;
      private int edtavBr_diagnosis_br_diagnosis_dxcode_Enabled ;
      private int edtavVdxsource_Visible ;
      private int edtavVdxsource_Enabled ;
      private int edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Enabled ;
      private int edtavBr_diagnosis_br_diagnosisid_Visible ;
      private int edtavBr_diagnosis_br_encounterid_Visible ;
      private int edtavBr_diagnosis_br_information_patientno_Visible ;
      private int gxdynajaxindex ;
      private int AV34GXV12 ;
      private int AV36GXV14 ;
      private int idxLst ;
      private long AV6BR_EncounterID ;
      private long wcpOAV6BR_EncounterID ;
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
      private String edtavBr_diagnosis_br_diagnosis_no_Internalname ;
      private String TempTags ;
      private String edtavBr_diagnosis_br_diagnosis_no_Jsonclick ;
      private String edtavBr_diagnosis_br_diagnosis_dxdescription_Internalname ;
      private String edtavBr_diagnosis_br_diagnosis_dxdescription_Jsonclick ;
      private String dynavVdxtsource_Internalname ;
      private String dynavVdxtsource_Jsonclick ;
      private String edtavBr_diagnosis_br_diagnosis_dxid_Internalname ;
      private String edtavBr_diagnosis_br_diagnosis_dxid_Jsonclick ;
      private String edtavBr_diagnosis_br_diagnosis_dxcode_Internalname ;
      private String edtavBr_diagnosis_br_diagnosis_dxcode_Jsonclick ;
      private String dynavVdxtype_Internalname ;
      private String dynavVdxtype_Jsonclick ;
      private String cmbavBr_diagnosis_br_diagnosis_initialdx_Internalname ;
      private String cmbavBr_diagnosis_br_diagnosis_initialdx_Jsonclick ;
      private String cmbavVmetastasesdx_Internalname ;
      private String cmbavVmetastasesdx_Jsonclick ;
      private String edtavVdxsource_Internalname ;
      private String edtavVdxsource_Jsonclick ;
      private String edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Internalname ;
      private String edtavBr_diagnosis_br_diagnosis_tumorstageclinical_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_diagnosis_br_diagnosisid_Internalname ;
      private String edtavBr_diagnosis_br_diagnosisid_Jsonclick ;
      private String edtavBr_diagnosis_br_encounterid_Internalname ;
      private String edtavBr_diagnosis_br_encounterid_Jsonclick ;
      private String edtavBr_diagnosis_br_information_patientno_Internalname ;
      private String edtavBr_diagnosis_br_information_patientno_Jsonclick ;
      private String dynavBr_diagnosis_br_diagnosis_dxtsource_Internalname ;
      private String dynavBr_diagnosis_br_diagnosis_dxtsource_Jsonclick ;
      private String dynavBr_diagnosis_br_diagnosis_dxtype_Internalname ;
      private String dynavBr_diagnosis_br_diagnosis_dxtype_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String GXt_char1 ;
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
      private bool AV7CheckRequiredFieldsResult ;
      private bool AV20tCheckFlag ;
      private bool AV16tFlag ;
      private String AV14tCurrentCode ;
      private String AV13vDXTsource ;
      private String AV15vDXType ;
      private String AV18vMetastasesDX ;
      private String AV19vDXSource ;
      private String AV17ErrorMsg ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavVdxtsource ;
      private GXCombobox dynavVdxtype ;
      private GXCombobox cmbavBr_diagnosis_br_diagnosis_initialdx ;
      private GXCombobox cmbavVmetastasesdx ;
      private GXCombobox dynavBr_diagnosis_br_diagnosis_dxtsource ;
      private GXCombobox dynavBr_diagnosis_br_diagnosis_dxtype ;
      private IDataStoreProvider pr_default ;
      private long[] H008N2_A167XT_DefineCodeID ;
      private String[] H008N2_A168XT_DefineCodeName ;
      private bool[] H008N2_n168XT_DefineCodeName ;
      private long[] H008N2_A165XT_DefindcodeTypeID ;
      private String[] H008N2_A432XT_TenantCode ;
      private bool[] H008N2_n432XT_TenantCode ;
      private long[] H008N3_A167XT_DefineCodeID ;
      private String[] H008N3_A168XT_DefineCodeName ;
      private bool[] H008N3_n168XT_DefineCodeName ;
      private long[] H008N3_A165XT_DefindcodeTypeID ;
      private String[] H008N3_A432XT_TenantCode ;
      private bool[] H008N3_n432XT_TenantCode ;
      private long[] H008N4_A167XT_DefineCodeID ;
      private String[] H008N4_A168XT_DefineCodeName ;
      private bool[] H008N4_n168XT_DefineCodeName ;
      private long[] H008N4_A165XT_DefindcodeTypeID ;
      private String[] H008N4_A432XT_TenantCode ;
      private bool[] H008N4_n432XT_TenantCode ;
      private long[] H008N5_A167XT_DefineCodeID ;
      private String[] H008N5_A168XT_DefineCodeName ;
      private bool[] H008N5_n168XT_DefineCodeName ;
      private long[] H008N5_A165XT_DefindcodeTypeID ;
      private String[] H008N5_A432XT_TenantCode ;
      private bool[] H008N5_n432XT_TenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV11Messages ;
      private GXBaseCollection<SdtMessages_Message> AV35GXV13 ;
      private GXWebForm Form ;
      private SdtBR_Diagnosis AV5BR_Diagnosis ;
      private SdtMessages_Message AV10Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8Context ;
   }

   public class br_diagnosisinsert__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_diagnosisinsert__default : DataStoreHelperBase, IDataStoreHelper
 {
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
        Object[] prmH008N2 ;
        prmH008N2 = new Object[] {
        new Object[] {"@AV14tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008N3 ;
        prmH008N3 = new Object[] {
        new Object[] {"@AV14tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008N4 ;
        prmH008N4 = new Object[] {
        new Object[] {"@AV14tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008N5 ;
        prmH008N5 = new Object[] {
        new Object[] {"@AV14tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H008N2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 21) AND ([XT_TenantCode] = @AV14tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008N2,0,0,true,false )
           ,new CursorDef("H008N3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 20) AND ([XT_TenantCode] = @AV14tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008N3,0,0,true,false )
           ,new CursorDef("H008N4", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 21) AND ([XT_TenantCode] = @AV14tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008N4,0,0,true,false )
           ,new CursorDef("H008N5", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 20) AND ([XT_TenantCode] = @AV14tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008N5,0,0,true,false )
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
     }
  }

}

}
