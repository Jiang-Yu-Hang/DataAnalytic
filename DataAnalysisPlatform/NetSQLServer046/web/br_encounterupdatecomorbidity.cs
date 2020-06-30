/*
               File: BR_EncounterUpdateComorbidity
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:42.97
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
   public class br_encounterupdatecomorbidity : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterupdatecomorbidity( )
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

      public br_encounterupdatecomorbidity( IGxContext context )
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
         this.A19BR_EncounterID = aP0_BR_EncounterID;
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
         cmbavBr_comorbidity_br_comorbidity_hypertension = new GXCombobox();
         cmbavBr_comorbidity_br_comorbidity_diabetes = new GXCombobox();
         cmbavBr_comorbidity_br_comorbidity_chd = new GXCombobox();
         cmbavBr_comorbidity_br_comorbidity_hapetitis = new GXCombobox();
         cmbavBr_comorbidity_br_comorbidity_tb = new GXCombobox();
         cmbavBr_comorbidity_br_comorbidity_kidneydisease = new GXCombobox();
         cmbavBr_comorbidity_br_comorbidity_surgeryhistory = new GXCombobox();
         cmbavBr_comorbidity_br_comorbidity_injuryhistory = new GXCombobox();
         cmbavBr_comorbidity_br_comorbidity_bloodhistory = new GXCombobox();
         cmbavBr_comorbidity_br_comorbidity_allergy = new GXCombobox();
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
                  A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A19BR_EncounterID});
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
            PA2U2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV40Pgmname = "BR_EncounterUpdateComorbidity";
               context.Gx_err = 0;
               WS2U2( ) ;
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
            context.SendWebValue( "Data Mgmt Portal - RAAP") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711554321", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterupdatecomorbidity.aspx") + "?" + UrlEncode("" +A19BR_EncounterID)+"\">") ;
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
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"Br_comorbidity", AV13BR_Comorbidity);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"Br_comorbidity", AV13BR_Comorbidity);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA19BR_EncounterID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_COMORBIDITY", AV13BR_Comorbidity);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_COMORBIDITY", AV13BR_Comorbidity);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_BEHAVIOR", AV17BR_Behavior);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_BEHAVIOR", AV17BR_Behavior);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm2U2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encounterupdatecomorbidity.js", "?202022711554325", false);
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
         return "BR_EncounterUpdateComorbidity" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB2U0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encounterupdatecomorbidity.aspx");
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
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable2_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname, "高血压", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_comorbidity_br_comorbidity_hypertension, cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname, StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_hypertension), 1, cmbavBr_comorbidity_br_comorbidity_hypertension_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_comorbidity_br_comorbidity_hypertension.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,14);\"", "", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            cmbavBr_comorbidity_br_comorbidity_hypertension.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_hypertension);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname, "Values", (String)(cmbavBr_comorbidity_br_comorbidity_hypertension.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_comorbidity_br_comorbidity_diabetes_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_comorbidity_br_comorbidity_diabetes_Internalname, "糖尿病", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_comorbidity_br_comorbidity_diabetes, cmbavBr_comorbidity_br_comorbidity_diabetes_Internalname, StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_diabetes), 1, cmbavBr_comorbidity_br_comorbidity_diabetes_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_comorbidity_br_comorbidity_diabetes.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,18);\"", "", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            cmbavBr_comorbidity_br_comorbidity_diabetes.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_diabetes);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_diabetes_Internalname, "Values", (String)(cmbavBr_comorbidity_br_comorbidity_diabetes.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_comorbidity_br_comorbidity_chd_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_comorbidity_br_comorbidity_chd_Internalname, "冠心病", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_comorbidity_br_comorbidity_chd, cmbavBr_comorbidity_br_comorbidity_chd_Internalname, StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_chd), 1, cmbavBr_comorbidity_br_comorbidity_chd_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_comorbidity_br_comorbidity_chd.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,23);\"", "", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            cmbavBr_comorbidity_br_comorbidity_chd.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_chd);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_chd_Internalname, "Values", (String)(cmbavBr_comorbidity_br_comorbidity_chd.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_comorbidity_br_comorbidity_hapetitis_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_comorbidity_br_comorbidity_hapetitis_Internalname, "肝炎", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_comorbidity_br_comorbidity_hapetitis, cmbavBr_comorbidity_br_comorbidity_hapetitis_Internalname, StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_hapetitis), 1, cmbavBr_comorbidity_br_comorbidity_hapetitis_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_comorbidity_br_comorbidity_hapetitis.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,27);\"", "", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            cmbavBr_comorbidity_br_comorbidity_hapetitis.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_hapetitis);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_hapetitis_Internalname, "Values", (String)(cmbavBr_comorbidity_br_comorbidity_hapetitis.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_comorbidity_br_comorbidity_tb_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_comorbidity_br_comorbidity_tb_Internalname, "结核病", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_comorbidity_br_comorbidity_tb, cmbavBr_comorbidity_br_comorbidity_tb_Internalname, StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_tb), 1, cmbavBr_comorbidity_br_comorbidity_tb_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_comorbidity_br_comorbidity_tb.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", "", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            cmbavBr_comorbidity_br_comorbidity_tb.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_tb);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_tb_Internalname, "Values", (String)(cmbavBr_comorbidity_br_comorbidity_tb.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_comorbidity_br_comorbidity_kidneydisease_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_comorbidity_br_comorbidity_kidneydisease_Internalname, "肾病", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_comorbidity_br_comorbidity_kidneydisease, cmbavBr_comorbidity_br_comorbidity_kidneydisease_Internalname, StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_kidneydisease), 1, cmbavBr_comorbidity_br_comorbidity_kidneydisease_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_comorbidity_br_comorbidity_kidneydisease.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            cmbavBr_comorbidity_br_comorbidity_kidneydisease.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_kidneydisease);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_kidneydisease_Internalname, "Values", (String)(cmbavBr_comorbidity_br_comorbidity_kidneydisease.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Internalname, "手术史", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_comorbidity_br_comorbidity_surgeryhistory, cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Internalname, StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_surgeryhistory), 1, cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_comorbidity_br_comorbidity_surgeryhistory.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            cmbavBr_comorbidity_br_comorbidity_surgeryhistory.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_surgeryhistory);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Internalname, "Values", (String)(cmbavBr_comorbidity_br_comorbidity_surgeryhistory.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_comorbidity_br_comorbidity_injuryhistory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_comorbidity_br_comorbidity_injuryhistory_Internalname, "外伤史", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_comorbidity_br_comorbidity_injuryhistory, cmbavBr_comorbidity_br_comorbidity_injuryhistory_Internalname, StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_injuryhistory), 1, cmbavBr_comorbidity_br_comorbidity_injuryhistory_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_comorbidity_br_comorbidity_injuryhistory.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            cmbavBr_comorbidity_br_comorbidity_injuryhistory.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_injuryhistory);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_injuryhistory_Internalname, "Values", (String)(cmbavBr_comorbidity_br_comorbidity_injuryhistory.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_comorbidity_br_comorbidity_bloodhistory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_comorbidity_br_comorbidity_bloodhistory_Internalname, "输血史", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_comorbidity_br_comorbidity_bloodhistory, cmbavBr_comorbidity_br_comorbidity_bloodhistory_Internalname, StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_bloodhistory), 1, cmbavBr_comorbidity_br_comorbidity_bloodhistory_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_comorbidity_br_comorbidity_bloodhistory.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            cmbavBr_comorbidity_br_comorbidity_bloodhistory.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_bloodhistory);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_bloodhistory_Internalname, "Values", (String)(cmbavBr_comorbidity_br_comorbidity_bloodhistory.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_comorbidity_br_comorbidity_allergy_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_comorbidity_br_comorbidity_allergy_Internalname, "过敏史", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_comorbidity_br_comorbidity_allergy, cmbavBr_comorbidity_br_comorbidity_allergy_Internalname, StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_allergy), 1, cmbavBr_comorbidity_br_comorbidity_allergy_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_comorbidity_br_comorbidity_allergy.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            cmbavBr_comorbidity_br_comorbidity_allergy.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_allergy);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_allergy_Internalname, "Values", (String)(cmbavBr_comorbidity_br_comorbidity_allergy.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_comorbidity_br_comorbidity_others_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_comorbidity_br_comorbidity_others_Internalname, "其他病史", "", "", lblTextblockbr_comorbidity_br_comorbidity_others_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdateComorbidity.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_comorbidity_br_comorbidity_others_Internalname, "其他病史", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'" + sPrefix + "',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_comorbidity_br_comorbidity_others_Internalname, AV13BR_Comorbidity.gxTpr_Br_comorbidity_others, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", 0, 1, edtavBr_comorbidity_br_comorbidity_others_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "255", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateComorbidity.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnsave_Internalname, "", "保存", bttBtnsave_Jsonclick, 5, "保存", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOSAVE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdateComorbidity.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewerOrange";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_comorbidity_br_comorbidityid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_Comorbidity.gxTpr_Br_comorbidityid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13BR_Comorbidity.gxTpr_Br_comorbidityid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_comorbidity_br_comorbidityid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_comorbidity_br_comorbidityid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateComorbidity.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_comorbidity_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_Comorbidity.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13BR_Comorbidity.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_comorbidity_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_comorbidity_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateComorbidity.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_comorbidity_br_information_patientno_Internalname, AV13BR_Comorbidity.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV13BR_Comorbidity.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_comorbidity_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_comorbidity_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterUpdateComorbidity.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START2U2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
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
               STRUP2U0( ) ;
            }
         }
      }

      protected void WS2U2( )
      {
         START2U2( ) ;
         EVT2U2( ) ;
      }

      protected void EVT2U2( )
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
                                 STRUP2U0( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2U0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E112U2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2U0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E122U2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOSAVE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2U0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'Dosave' */
                                    E132U2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2U0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
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
                                 STRUP2U0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
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

      protected void WE2U2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2U2( ) ;
            }
         }
      }

      protected void PA2U2( )
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
               GX_FocusControl = cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
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
         if ( cmbavBr_comorbidity_br_comorbidity_hypertension.ItemCount > 0 )
         {
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_hypertension = cmbavBr_comorbidity_br_comorbidity_hypertension.getValidValue(AV13BR_Comorbidity.gxTpr_Br_comorbidity_hypertension);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_comorbidity_br_comorbidity_hypertension.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_hypertension);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname, "Values", cmbavBr_comorbidity_br_comorbidity_hypertension.ToJavascriptSource(), true);
         }
         if ( cmbavBr_comorbidity_br_comorbidity_diabetes.ItemCount > 0 )
         {
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_diabetes = cmbavBr_comorbidity_br_comorbidity_diabetes.getValidValue(AV13BR_Comorbidity.gxTpr_Br_comorbidity_diabetes);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_comorbidity_br_comorbidity_diabetes.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_diabetes);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_diabetes_Internalname, "Values", cmbavBr_comorbidity_br_comorbidity_diabetes.ToJavascriptSource(), true);
         }
         if ( cmbavBr_comorbidity_br_comorbidity_chd.ItemCount > 0 )
         {
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_chd = cmbavBr_comorbidity_br_comorbidity_chd.getValidValue(AV13BR_Comorbidity.gxTpr_Br_comorbidity_chd);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_comorbidity_br_comorbidity_chd.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_chd);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_chd_Internalname, "Values", cmbavBr_comorbidity_br_comorbidity_chd.ToJavascriptSource(), true);
         }
         if ( cmbavBr_comorbidity_br_comorbidity_hapetitis.ItemCount > 0 )
         {
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_hapetitis = cmbavBr_comorbidity_br_comorbidity_hapetitis.getValidValue(AV13BR_Comorbidity.gxTpr_Br_comorbidity_hapetitis);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_comorbidity_br_comorbidity_hapetitis.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_hapetitis);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_hapetitis_Internalname, "Values", cmbavBr_comorbidity_br_comorbidity_hapetitis.ToJavascriptSource(), true);
         }
         if ( cmbavBr_comorbidity_br_comorbidity_tb.ItemCount > 0 )
         {
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_tb = cmbavBr_comorbidity_br_comorbidity_tb.getValidValue(AV13BR_Comorbidity.gxTpr_Br_comorbidity_tb);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_comorbidity_br_comorbidity_tb.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_tb);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_tb_Internalname, "Values", cmbavBr_comorbidity_br_comorbidity_tb.ToJavascriptSource(), true);
         }
         if ( cmbavBr_comorbidity_br_comorbidity_kidneydisease.ItemCount > 0 )
         {
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_kidneydisease = cmbavBr_comorbidity_br_comorbidity_kidneydisease.getValidValue(AV13BR_Comorbidity.gxTpr_Br_comorbidity_kidneydisease);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_comorbidity_br_comorbidity_kidneydisease.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_kidneydisease);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_kidneydisease_Internalname, "Values", cmbavBr_comorbidity_br_comorbidity_kidneydisease.ToJavascriptSource(), true);
         }
         if ( cmbavBr_comorbidity_br_comorbidity_surgeryhistory.ItemCount > 0 )
         {
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_surgeryhistory = cmbavBr_comorbidity_br_comorbidity_surgeryhistory.getValidValue(AV13BR_Comorbidity.gxTpr_Br_comorbidity_surgeryhistory);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_comorbidity_br_comorbidity_surgeryhistory.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_surgeryhistory);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Internalname, "Values", cmbavBr_comorbidity_br_comorbidity_surgeryhistory.ToJavascriptSource(), true);
         }
         if ( cmbavBr_comorbidity_br_comorbidity_injuryhistory.ItemCount > 0 )
         {
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_injuryhistory = cmbavBr_comorbidity_br_comorbidity_injuryhistory.getValidValue(AV13BR_Comorbidity.gxTpr_Br_comorbidity_injuryhistory);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_comorbidity_br_comorbidity_injuryhistory.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_injuryhistory);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_injuryhistory_Internalname, "Values", cmbavBr_comorbidity_br_comorbidity_injuryhistory.ToJavascriptSource(), true);
         }
         if ( cmbavBr_comorbidity_br_comorbidity_bloodhistory.ItemCount > 0 )
         {
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_bloodhistory = cmbavBr_comorbidity_br_comorbidity_bloodhistory.getValidValue(AV13BR_Comorbidity.gxTpr_Br_comorbidity_bloodhistory);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_comorbidity_br_comorbidity_bloodhistory.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_bloodhistory);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_bloodhistory_Internalname, "Values", cmbavBr_comorbidity_br_comorbidity_bloodhistory.ToJavascriptSource(), true);
         }
         if ( cmbavBr_comorbidity_br_comorbidity_allergy.ItemCount > 0 )
         {
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_allergy = cmbavBr_comorbidity_br_comorbidity_allergy.getValidValue(AV13BR_Comorbidity.gxTpr_Br_comorbidity_allergy);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_comorbidity_br_comorbidity_allergy.CurrentValue = StringUtil.RTrim( AV13BR_Comorbidity.gxTpr_Br_comorbidity_allergy);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_comorbidity_br_comorbidity_allergy_Internalname, "Values", cmbavBr_comorbidity_br_comorbidity_allergy.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF2U2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV40Pgmname = "BR_EncounterUpdateComorbidity";
         context.Gx_err = 0;
      }

      protected void RF2U2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H002U2 */
            pr_default.execute(0, new Object[] {A19BR_EncounterID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               /* Execute user event: Load */
               E122U2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB2U0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes2U2( )
      {
      }

      protected void STRUP2U0( )
      {
         /* Before Start, stand alone formulas. */
         AV40Pgmname = "BR_EncounterUpdateComorbidity";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E112U2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"Br_comorbidity"), AV13BR_Comorbidity);
            /* Read variables values. */
            cmbavBr_comorbidity_br_comorbidity_hypertension.CurrentValue = cgiGet( cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_hypertension = cgiGet( cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname);
            cmbavBr_comorbidity_br_comorbidity_diabetes.CurrentValue = cgiGet( cmbavBr_comorbidity_br_comorbidity_diabetes_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_diabetes = cgiGet( cmbavBr_comorbidity_br_comorbidity_diabetes_Internalname);
            cmbavBr_comorbidity_br_comorbidity_chd.CurrentValue = cgiGet( cmbavBr_comorbidity_br_comorbidity_chd_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_chd = cgiGet( cmbavBr_comorbidity_br_comorbidity_chd_Internalname);
            cmbavBr_comorbidity_br_comorbidity_hapetitis.CurrentValue = cgiGet( cmbavBr_comorbidity_br_comorbidity_hapetitis_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_hapetitis = cgiGet( cmbavBr_comorbidity_br_comorbidity_hapetitis_Internalname);
            cmbavBr_comorbidity_br_comorbidity_tb.CurrentValue = cgiGet( cmbavBr_comorbidity_br_comorbidity_tb_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_tb = cgiGet( cmbavBr_comorbidity_br_comorbidity_tb_Internalname);
            cmbavBr_comorbidity_br_comorbidity_kidneydisease.CurrentValue = cgiGet( cmbavBr_comorbidity_br_comorbidity_kidneydisease_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_kidneydisease = cgiGet( cmbavBr_comorbidity_br_comorbidity_kidneydisease_Internalname);
            cmbavBr_comorbidity_br_comorbidity_surgeryhistory.CurrentValue = cgiGet( cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_surgeryhistory = cgiGet( cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Internalname);
            cmbavBr_comorbidity_br_comorbidity_injuryhistory.CurrentValue = cgiGet( cmbavBr_comorbidity_br_comorbidity_injuryhistory_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_injuryhistory = cgiGet( cmbavBr_comorbidity_br_comorbidity_injuryhistory_Internalname);
            cmbavBr_comorbidity_br_comorbidity_bloodhistory.CurrentValue = cgiGet( cmbavBr_comorbidity_br_comorbidity_bloodhistory_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_bloodhistory = cgiGet( cmbavBr_comorbidity_br_comorbidity_bloodhistory_Internalname);
            cmbavBr_comorbidity_br_comorbidity_allergy.CurrentValue = cgiGet( cmbavBr_comorbidity_br_comorbidity_allergy_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_allergy = cgiGet( cmbavBr_comorbidity_br_comorbidity_allergy_Internalname);
            AV13BR_Comorbidity.gxTpr_Br_comorbidity_others = cgiGet( edtavBr_comorbidity_br_comorbidity_others_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_comorbidity_br_comorbidityid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_comorbidity_br_comorbidityid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_COMORBIDITY_BR_COMORBIDITYID");
               GX_FocusControl = edtavBr_comorbidity_br_comorbidityid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Comorbidity.gxTpr_Br_comorbidityid = 0;
            }
            else
            {
               AV13BR_Comorbidity.gxTpr_Br_comorbidityid = (long)(context.localUtil.CToN( cgiGet( edtavBr_comorbidity_br_comorbidityid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_comorbidity_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_comorbidity_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_COMORBIDITY_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_comorbidity_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Comorbidity.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV13BR_Comorbidity.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_comorbidity_br_encounterid_Internalname), ".", ","));
            }
            AV13BR_Comorbidity.gxTpr_Br_information_patientno = cgiGet( edtavBr_comorbidity_br_information_patientno_Internalname);
            /* Read saved values. */
            wcpOA19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA19BR_EncounterID"), ".", ","));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E112U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112U2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV37GXLvl14 = 0;
         /* Using cursor H002U3 */
         pr_default.execute(1, new Object[] {A19BR_EncounterID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A37BR_ComorbidityID = H002U3_A37BR_ComorbidityID[0];
            AV37GXLvl14 = 1;
            AV18tBR_ComorbidityID = A37BR_ComorbidityID;
            AV13BR_Comorbidity.Load(AV18tBR_ComorbidityID);
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(1);
         }
         pr_default.close(1);
         if ( AV37GXLvl14 == 0 )
         {
            AV13BR_Comorbidity = new SdtBR_Comorbidity(context);
            AV13BR_Comorbidity.gxTpr_Br_encounterid = A19BR_EncounterID;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E122U2( )
      {
         /* Load Routine */
         edtavBr_comorbidity_br_comorbidityid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_comorbidity_br_comorbidityid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_comorbidity_br_comorbidityid_Visible), 5, 0)), true);
         edtavBr_comorbidity_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_comorbidity_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_comorbidity_br_encounterid_Visible), 5, 0)), true);
         edtavBr_comorbidity_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_comorbidity_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_comorbidity_br_information_patientno_Visible), 5, 0)), true);
      }

      protected void E132U2( )
      {
         /* 'Dosave' Routine */
         new zutil_checksession(context ).execute( out  AV20tCheckFlag) ;
         if ( ! AV20tCheckFlag )
         {
            AV19tFlag = true;
            if ( ( AV19tFlag ) && ( StringUtil.Len( AV13BR_Comorbidity.gxTpr_Br_comorbidity_others) > 120 ) )
            {
               GX_msglist.addItem("其他病史信息过长,请截取信息");
               AV19tFlag = false;
            }
            if ( AV19tFlag )
            {
               AV13BR_Comorbidity.Save();
               if ( AV13BR_Comorbidity.Success() )
               {
                  GX_msglist.addItem("保存成功");
                  new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV13BR_Comorbidity.gxTpr_Br_encounterid), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(AV13BR_Comorbidity.gxTpr_Br_comorbidityid), 18, 0)),  "既往病史",  "Create",  1) ;
                  context.CommitDataStores("br_encounterupdatecomorbidity",pr_default);
                  AV18tBR_ComorbidityID = AV13BR_Comorbidity.gxTpr_Br_comorbidityid;
                  AV13BR_Comorbidity.Load(AV18tBR_ComorbidityID);
               }
               else
               {
                  AV15ErrorMsg = "";
                  AV39GXV16 = 1;
                  AV38GXV15 = AV17BR_Behavior.GetMessages();
                  while ( AV39GXV16 <= AV38GXV15.Count )
                  {
                     AV16Message = ((SdtMessages_Message)AV38GXV15.Item(AV39GXV16));
                     AV15ErrorMsg = AV15ErrorMsg + StringUtil.Trim( AV16Message.gxTpr_Description);
                     AV39GXV16 = (int)(AV39GXV16+1);
                  }
                  GX_msglist.addItem(StringUtil.Trim( AV15ErrorMsg));
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV13BR_Comorbidity", AV13BR_Comorbidity);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV40Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Encounter";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A19BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
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
         PA2U2( ) ;
         WS2U2( ) ;
         WE2U2( ) ;
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
         sCtrlA19BR_EncounterID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA2U2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encounterupdatecomorbidity", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA2U2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A19BR_EncounterID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         }
         wcpOA19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA19BR_EncounterID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A19BR_EncounterID != wcpOA19BR_EncounterID ) ) )
         {
            setjustcreated();
         }
         wcpOA19BR_EncounterID = A19BR_EncounterID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA19BR_EncounterID = cgiGet( sPrefix+"A19BR_EncounterID_CTRL");
         if ( StringUtil.Len( sCtrlA19BR_EncounterID) > 0 )
         {
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sCtrlA19BR_EncounterID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         }
         else
         {
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A19BR_EncounterID_PARM"), ".", ","));
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
         PA2U2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS2U2( ) ;
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
         WS2U2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A19BR_EncounterID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA19BR_EncounterID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A19BR_EncounterID_CTRL", StringUtil.RTrim( sCtrlA19BR_EncounterID));
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
         WE2U2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271155451", true);
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
         context.AddJavascriptSource("br_encounterupdatecomorbidity.js", "?20202271155452", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbavBr_comorbidity_br_comorbidity_hypertension.Name = "BR_COMORBIDITY_BR_COMORBIDITY_HYPERTENSION";
         cmbavBr_comorbidity_br_comorbidity_hypertension.WebTags = "";
         cmbavBr_comorbidity_br_comorbidity_hypertension.addItem("", "(请选择)", 0);
         cmbavBr_comorbidity_br_comorbidity_hypertension.addItem("否", "否", 0);
         cmbavBr_comorbidity_br_comorbidity_hypertension.addItem("是", "是", 0);
         cmbavBr_comorbidity_br_comorbidity_hypertension.addItem("不详", "不详", 0);
         if ( cmbavBr_comorbidity_br_comorbidity_hypertension.ItemCount > 0 )
         {
         }
         cmbavBr_comorbidity_br_comorbidity_diabetes.Name = "BR_COMORBIDITY_BR_COMORBIDITY_DIABETES";
         cmbavBr_comorbidity_br_comorbidity_diabetes.WebTags = "";
         cmbavBr_comorbidity_br_comorbidity_diabetes.addItem("", "(请选择)", 0);
         cmbavBr_comorbidity_br_comorbidity_diabetes.addItem("否", "否", 0);
         cmbavBr_comorbidity_br_comorbidity_diabetes.addItem("是", "是", 0);
         cmbavBr_comorbidity_br_comorbidity_diabetes.addItem("不详", "不详", 0);
         if ( cmbavBr_comorbidity_br_comorbidity_diabetes.ItemCount > 0 )
         {
         }
         cmbavBr_comorbidity_br_comorbidity_chd.Name = "BR_COMORBIDITY_BR_COMORBIDITY_CHD";
         cmbavBr_comorbidity_br_comorbidity_chd.WebTags = "";
         cmbavBr_comorbidity_br_comorbidity_chd.addItem("", "(请选择)", 0);
         cmbavBr_comorbidity_br_comorbidity_chd.addItem("否", "否", 0);
         cmbavBr_comorbidity_br_comorbidity_chd.addItem("是", "是", 0);
         cmbavBr_comorbidity_br_comorbidity_chd.addItem("不详", "不详", 0);
         if ( cmbavBr_comorbidity_br_comorbidity_chd.ItemCount > 0 )
         {
         }
         cmbavBr_comorbidity_br_comorbidity_hapetitis.Name = "BR_COMORBIDITY_BR_COMORBIDITY_HAPETITIS";
         cmbavBr_comorbidity_br_comorbidity_hapetitis.WebTags = "";
         cmbavBr_comorbidity_br_comorbidity_hapetitis.addItem("", "(请选择)", 0);
         cmbavBr_comorbidity_br_comorbidity_hapetitis.addItem("否", "否", 0);
         cmbavBr_comorbidity_br_comorbidity_hapetitis.addItem("是", "是", 0);
         cmbavBr_comorbidity_br_comorbidity_hapetitis.addItem("不详", "不详", 0);
         if ( cmbavBr_comorbidity_br_comorbidity_hapetitis.ItemCount > 0 )
         {
         }
         cmbavBr_comorbidity_br_comorbidity_tb.Name = "BR_COMORBIDITY_BR_COMORBIDITY_TB";
         cmbavBr_comorbidity_br_comorbidity_tb.WebTags = "";
         cmbavBr_comorbidity_br_comorbidity_tb.addItem("", "(请选择)", 0);
         cmbavBr_comorbidity_br_comorbidity_tb.addItem("否", "否", 0);
         cmbavBr_comorbidity_br_comorbidity_tb.addItem("是", "是", 0);
         cmbavBr_comorbidity_br_comorbidity_tb.addItem("不详", "不详", 0);
         if ( cmbavBr_comorbidity_br_comorbidity_tb.ItemCount > 0 )
         {
         }
         cmbavBr_comorbidity_br_comorbidity_kidneydisease.Name = "BR_COMORBIDITY_BR_COMORBIDITY_KIDNEYDISEASE";
         cmbavBr_comorbidity_br_comorbidity_kidneydisease.WebTags = "";
         cmbavBr_comorbidity_br_comorbidity_kidneydisease.addItem("", "(请选择)", 0);
         cmbavBr_comorbidity_br_comorbidity_kidneydisease.addItem("否", "否", 0);
         cmbavBr_comorbidity_br_comorbidity_kidneydisease.addItem("是", "是", 0);
         cmbavBr_comorbidity_br_comorbidity_kidneydisease.addItem("不详", "不详", 0);
         if ( cmbavBr_comorbidity_br_comorbidity_kidneydisease.ItemCount > 0 )
         {
         }
         cmbavBr_comorbidity_br_comorbidity_surgeryhistory.Name = "BR_COMORBIDITY_BR_COMORBIDITY_SURGERYHISTORY";
         cmbavBr_comorbidity_br_comorbidity_surgeryhistory.WebTags = "";
         cmbavBr_comorbidity_br_comorbidity_surgeryhistory.addItem("", "(请选择)", 0);
         cmbavBr_comorbidity_br_comorbidity_surgeryhistory.addItem("否", "否", 0);
         cmbavBr_comorbidity_br_comorbidity_surgeryhistory.addItem("是", "是", 0);
         cmbavBr_comorbidity_br_comorbidity_surgeryhistory.addItem("不详", "不详", 0);
         if ( cmbavBr_comorbidity_br_comorbidity_surgeryhistory.ItemCount > 0 )
         {
         }
         cmbavBr_comorbidity_br_comorbidity_injuryhistory.Name = "BR_COMORBIDITY_BR_COMORBIDITY_INJURYHISTORY";
         cmbavBr_comorbidity_br_comorbidity_injuryhistory.WebTags = "";
         cmbavBr_comorbidity_br_comorbidity_injuryhistory.addItem("", "(请选择)", 0);
         cmbavBr_comorbidity_br_comorbidity_injuryhistory.addItem("否", "否", 0);
         cmbavBr_comorbidity_br_comorbidity_injuryhistory.addItem("是", "是", 0);
         cmbavBr_comorbidity_br_comorbidity_injuryhistory.addItem("不详", "不详", 0);
         if ( cmbavBr_comorbidity_br_comorbidity_injuryhistory.ItemCount > 0 )
         {
         }
         cmbavBr_comorbidity_br_comorbidity_bloodhistory.Name = "BR_COMORBIDITY_BR_COMORBIDITY_BLOODHISTORY";
         cmbavBr_comorbidity_br_comorbidity_bloodhistory.WebTags = "";
         cmbavBr_comorbidity_br_comorbidity_bloodhistory.addItem("", "(请选择)", 0);
         cmbavBr_comorbidity_br_comorbidity_bloodhistory.addItem("否", "否", 0);
         cmbavBr_comorbidity_br_comorbidity_bloodhistory.addItem("是", "是", 0);
         cmbavBr_comorbidity_br_comorbidity_bloodhistory.addItem("不详", "不详", 0);
         if ( cmbavBr_comorbidity_br_comorbidity_bloodhistory.ItemCount > 0 )
         {
         }
         cmbavBr_comorbidity_br_comorbidity_allergy.Name = "BR_COMORBIDITY_BR_COMORBIDITY_ALLERGY";
         cmbavBr_comorbidity_br_comorbidity_allergy.WebTags = "";
         cmbavBr_comorbidity_br_comorbidity_allergy.addItem("", "(请选择)", 0);
         cmbavBr_comorbidity_br_comorbidity_allergy.addItem("否", "否", 0);
         cmbavBr_comorbidity_br_comorbidity_allergy.addItem("是", "是", 0);
         cmbavBr_comorbidity_br_comorbidity_allergy.addItem("不详", "不详", 0);
         if ( cmbavBr_comorbidity_br_comorbidity_allergy.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_HYPERTENSION";
         cmbavBr_comorbidity_br_comorbidity_diabetes_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_DIABETES";
         cmbavBr_comorbidity_br_comorbidity_chd_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_CHD";
         cmbavBr_comorbidity_br_comorbidity_hapetitis_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_HAPETITIS";
         cmbavBr_comorbidity_br_comorbidity_tb_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_TB";
         cmbavBr_comorbidity_br_comorbidity_kidneydisease_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_KIDNEYDISEASE";
         cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_SURGERYHISTORY";
         cmbavBr_comorbidity_br_comorbidity_injuryhistory_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_INJURYHISTORY";
         cmbavBr_comorbidity_br_comorbidity_bloodhistory_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_BLOODHISTORY";
         cmbavBr_comorbidity_br_comorbidity_allergy_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_ALLERGY";
         lblTextblockbr_comorbidity_br_comorbidity_others_Internalname = sPrefix+"TEXTBLOCKBR_COMORBIDITY_BR_COMORBIDITY_OTHERS";
         edtavBr_comorbidity_br_comorbidity_others_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITY_OTHERS";
         divUnnamedtablebr_comorbidity_br_comorbidity_others_Internalname = sPrefix+"UNNAMEDTABLEBR_COMORBIDITY_BR_COMORBIDITY_OTHERS";
         divUnnamedtable2_Internalname = sPrefix+"UNNAMEDTABLE2";
         bttBtnsave_Internalname = sPrefix+"BTNSAVE";
         divUnnamedtable1_Internalname = sPrefix+"UNNAMEDTABLE1";
         edtavBr_comorbidity_br_comorbidityid_Internalname = sPrefix+"BR_COMORBIDITY_BR_COMORBIDITYID";
         edtavBr_comorbidity_br_encounterid_Internalname = sPrefix+"BR_COMORBIDITY_BR_ENCOUNTERID";
         edtavBr_comorbidity_br_information_patientno_Internalname = sPrefix+"BR_COMORBIDITY_BR_INFORMATION_PATIENTNO";
         divHtml_bottomauxiliarcontrols_Internalname = sPrefix+"HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = sPrefix+"LAYOUTMAINTABLE";
         Form.Internalname = sPrefix+"FORM";
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
         edtavBr_comorbidity_br_information_patientno_Jsonclick = "";
         edtavBr_comorbidity_br_information_patientno_Visible = 1;
         edtavBr_comorbidity_br_encounterid_Jsonclick = "";
         edtavBr_comorbidity_br_encounterid_Visible = 1;
         edtavBr_comorbidity_br_comorbidityid_Jsonclick = "";
         edtavBr_comorbidity_br_comorbidityid_Visible = 1;
         edtavBr_comorbidity_br_comorbidity_others_Enabled = 1;
         cmbavBr_comorbidity_br_comorbidity_allergy_Jsonclick = "";
         cmbavBr_comorbidity_br_comorbidity_allergy.Enabled = 1;
         cmbavBr_comorbidity_br_comorbidity_bloodhistory_Jsonclick = "";
         cmbavBr_comorbidity_br_comorbidity_bloodhistory.Enabled = 1;
         cmbavBr_comorbidity_br_comorbidity_injuryhistory_Jsonclick = "";
         cmbavBr_comorbidity_br_comorbidity_injuryhistory.Enabled = 1;
         cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Jsonclick = "";
         cmbavBr_comorbidity_br_comorbidity_surgeryhistory.Enabled = 1;
         cmbavBr_comorbidity_br_comorbidity_kidneydisease_Jsonclick = "";
         cmbavBr_comorbidity_br_comorbidity_kidneydisease.Enabled = 1;
         cmbavBr_comorbidity_br_comorbidity_tb_Jsonclick = "";
         cmbavBr_comorbidity_br_comorbidity_tb.Enabled = 1;
         cmbavBr_comorbidity_br_comorbidity_hapetitis_Jsonclick = "";
         cmbavBr_comorbidity_br_comorbidity_hapetitis.Enabled = 1;
         cmbavBr_comorbidity_br_comorbidity_chd_Jsonclick = "";
         cmbavBr_comorbidity_br_comorbidity_chd.Enabled = 1;
         cmbavBr_comorbidity_br_comorbidity_diabetes_Jsonclick = "";
         cmbavBr_comorbidity_br_comorbidity_diabetes.Enabled = 1;
         cmbavBr_comorbidity_br_comorbidity_hypertension_Jsonclick = "";
         cmbavBr_comorbidity_br_comorbidity_hypertension.Enabled = 1;
         context.GX_msglist.DisplayMode = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOSAVE'","{handler:'E132U2',iparms:[{av:'AV13BR_Comorbidity',fld:'vBR_COMORBIDITY',pic:''},{av:'AV17BR_Behavior',fld:'vBR_BEHAVIOR',pic:''}]");
         setEventMetadata("'DOSAVE'",",oparms:[{av:'AV13BR_Comorbidity',fld:'vBR_COMORBIDITY',pic:''}]}");
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
         sPrefix = "";
         AV40Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV13BR_Comorbidity = new SdtBR_Comorbidity(context);
         AV17BR_Behavior = new SdtBR_Behavior(context);
         GX_FocusControl = "";
         TempTags = "";
         lblTextblockbr_comorbidity_br_comorbidity_others_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtnsave_Jsonclick = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H002U2_A19BR_EncounterID = new long[1] ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         H002U3_A19BR_EncounterID = new long[1] ;
         H002U3_A37BR_ComorbidityID = new long[1] ;
         AV15ErrorMsg = "";
         AV38GXV15 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV16Message = new SdtMessages_Message(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA19BR_EncounterID = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encounterupdatecomorbidity__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterupdatecomorbidity__default(),
            new Object[][] {
                new Object[] {
               H002U2_A19BR_EncounterID
               }
               , new Object[] {
               H002U3_A19BR_EncounterID, H002U3_A37BR_ComorbidityID
               }
            }
         );
         AV40Pgmname = "BR_EncounterUpdateComorbidity";
         /* GeneXus formulas. */
         AV40Pgmname = "BR_EncounterUpdateComorbidity";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV37GXLvl14 ;
      private short nGXWrapped ;
      private int edtavBr_comorbidity_br_comorbidity_others_Enabled ;
      private int edtavBr_comorbidity_br_comorbidityid_Visible ;
      private int edtavBr_comorbidity_br_encounterid_Visible ;
      private int edtavBr_comorbidity_br_information_patientno_Visible ;
      private int AV39GXV16 ;
      private int idxLst ;
      private long A19BR_EncounterID ;
      private long wcpOA19BR_EncounterID ;
      private long A37BR_ComorbidityID ;
      private long AV18tBR_ComorbidityID ;
      private long AV8BR_EncounterID ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV40Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String divUnnamedtable2_Internalname ;
      private String cmbavBr_comorbidity_br_comorbidity_hypertension_Internalname ;
      private String TempTags ;
      private String cmbavBr_comorbidity_br_comorbidity_hypertension_Jsonclick ;
      private String cmbavBr_comorbidity_br_comorbidity_diabetes_Internalname ;
      private String cmbavBr_comorbidity_br_comorbidity_diabetes_Jsonclick ;
      private String cmbavBr_comorbidity_br_comorbidity_chd_Internalname ;
      private String cmbavBr_comorbidity_br_comorbidity_chd_Jsonclick ;
      private String cmbavBr_comorbidity_br_comorbidity_hapetitis_Internalname ;
      private String cmbavBr_comorbidity_br_comorbidity_hapetitis_Jsonclick ;
      private String cmbavBr_comorbidity_br_comorbidity_tb_Internalname ;
      private String cmbavBr_comorbidity_br_comorbidity_tb_Jsonclick ;
      private String cmbavBr_comorbidity_br_comorbidity_kidneydisease_Internalname ;
      private String cmbavBr_comorbidity_br_comorbidity_kidneydisease_Jsonclick ;
      private String cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Internalname ;
      private String cmbavBr_comorbidity_br_comorbidity_surgeryhistory_Jsonclick ;
      private String cmbavBr_comorbidity_br_comorbidity_injuryhistory_Internalname ;
      private String cmbavBr_comorbidity_br_comorbidity_injuryhistory_Jsonclick ;
      private String cmbavBr_comorbidity_br_comorbidity_bloodhistory_Internalname ;
      private String cmbavBr_comorbidity_br_comorbidity_bloodhistory_Jsonclick ;
      private String cmbavBr_comorbidity_br_comorbidity_allergy_Internalname ;
      private String cmbavBr_comorbidity_br_comorbidity_allergy_Jsonclick ;
      private String divUnnamedtablebr_comorbidity_br_comorbidity_others_Internalname ;
      private String lblTextblockbr_comorbidity_br_comorbidity_others_Internalname ;
      private String lblTextblockbr_comorbidity_br_comorbidity_others_Jsonclick ;
      private String edtavBr_comorbidity_br_comorbidity_others_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnsave_Internalname ;
      private String bttBtnsave_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_comorbidity_br_comorbidityid_Internalname ;
      private String edtavBr_comorbidity_br_comorbidityid_Jsonclick ;
      private String edtavBr_comorbidity_br_encounterid_Internalname ;
      private String edtavBr_comorbidity_br_encounterid_Jsonclick ;
      private String edtavBr_comorbidity_br_information_patientno_Internalname ;
      private String edtavBr_comorbidity_br_information_patientno_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA19BR_EncounterID ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV20tCheckFlag ;
      private bool AV19tFlag ;
      private String AV15ErrorMsg ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavBr_comorbidity_br_comorbidity_hypertension ;
      private GXCombobox cmbavBr_comorbidity_br_comorbidity_diabetes ;
      private GXCombobox cmbavBr_comorbidity_br_comorbidity_chd ;
      private GXCombobox cmbavBr_comorbidity_br_comorbidity_hapetitis ;
      private GXCombobox cmbavBr_comorbidity_br_comorbidity_tb ;
      private GXCombobox cmbavBr_comorbidity_br_comorbidity_kidneydisease ;
      private GXCombobox cmbavBr_comorbidity_br_comorbidity_surgeryhistory ;
      private GXCombobox cmbavBr_comorbidity_br_comorbidity_injuryhistory ;
      private GXCombobox cmbavBr_comorbidity_br_comorbidity_bloodhistory ;
      private GXCombobox cmbavBr_comorbidity_br_comorbidity_allergy ;
      private IDataStoreProvider pr_default ;
      private long[] H002U2_A19BR_EncounterID ;
      private long[] H002U3_A19BR_EncounterID ;
      private long[] H002U3_A37BR_ComorbidityID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GXBaseCollection<SdtMessages_Message> AV38GXV15 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
      private SdtBR_Comorbidity AV13BR_Comorbidity ;
      private SdtMessages_Message AV16Message ;
      private SdtBR_Behavior AV17BR_Behavior ;
   }

   public class br_encounterupdatecomorbidity__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_encounterupdatecomorbidity__default : DataStoreHelperBase, IDataStoreHelper
 {
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
        Object[] prmH002U2 ;
        prmH002U2 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmH002U3 ;
        prmH002U3 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H002U2", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002U2,1,0,true,true )
           ,new CursorDef("H002U3", "SELECT TOP 1 [BR_EncounterID], [BR_ComorbidityID] FROM [BR_Comorbidity] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002U3,1,0,true,true )
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
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
