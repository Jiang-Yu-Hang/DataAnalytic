/*
               File: BR_Scheme_MedicationGeneral
        Description: BR_Scheme_Medication General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:53:57.48
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
   public class br_scheme_medicationgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_scheme_medicationgeneral( )
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

      public br_scheme_medicationgeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Scheme_MedicationID )
      {
         this.A332BR_Scheme_MedicationID = aP0_BR_Scheme_MedicationID;
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
                  A332BR_Scheme_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A332BR_Scheme_MedicationID});
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
            PA6K2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "BR_Scheme_MedicationGeneral";
               context.Gx_err = 0;
               WS6K2( ) ;
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
            context.SendWebValue( "BR_Scheme_Medication General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711535752", false);
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
            FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_scheme_medicationgeneral.aspx") + "?" + UrlEncode("" +A332BR_Scheme_MedicationID)+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
               context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
            }
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA332BR_Scheme_MedicationID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm6K2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_scheme_medicationgeneral.js", "?202022711535754", false);
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
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "</form>") ;
            }
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
         return "BR_Scheme_MedicationGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Scheme_Medication General" ;
      }

      protected void WB6K0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_scheme_medicationgeneral.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTransactiondetail_tableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_scheme_chem_regimens_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_scheme_chem_regimens_Internalname, "化疗方案", "", "", lblTextblockbr_scheme_chem_regimens_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Scheme_Chem_Regimens_Internalname, "化疗方案", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Scheme_Chem_Regimens_Internalname, A328BR_Scheme_Chem_Regimens, StringUtil.RTrim( context.localUtil.Format( A328BR_Scheme_Chem_Regimens, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Scheme_Chem_Regimens_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Scheme_Chem_Regimens_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicationid_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicationid_Internalname, "药物识别码", "", "", lblTextblockbr_medicationid_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicationID_Internalname, "药物治疗主键", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicationID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")), ((edtBR_MedicationID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicationID_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_MedicationID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Scheme_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXName_Internalname, "药物名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXName_Internalname, A121BR_Medication_RXName, StringUtil.RTrim( context.localUtil.Format( A121BR_Medication_RXName, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXName_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXDose_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXDose_Internalname, "药物剂量", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXDose_Internalname, StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")), ((edtBR_Medication_RXDose_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ")) : context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXDose_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXDose_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Scheme_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medication_rxunit_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medication_rxunit_Internalname, "计量单位", "", "", lblTextblockbr_medication_rxunit_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXUnit_Internalname, "计量单位", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXUnit_Internalname, A125BR_Medication_RXUnit, StringUtil.RTrim( context.localUtil.Format( A125BR_Medication_RXUnit, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXUnit_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXUnit_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationGeneral.htm");
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Scheme_MedicationID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Scheme_MedicationID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Scheme_MedicationID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Scheme_MedicationGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_SchemeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_SchemeID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_SchemeID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Scheme_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START6K2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Scheme_Medication General", 0) ;
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
               STRUP6K0( ) ;
            }
         }
      }

      protected void WS6K2( )
      {
         START6K2( ) ;
         EVT6K2( ) ;
      }

      protected void EVT6K2( )
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
                                 STRUP6K0( ) ;
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
                                 STRUP6K0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E116K2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP6K0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E126K2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP6K0( ) ;
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
                                 STRUP6K0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
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

      protected void WE6K2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm6K2( ) ;
            }
         }
      }

      protected void PA6K2( )
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF6K2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "BR_Scheme_MedicationGeneral";
         context.Gx_err = 0;
      }

      protected void RF6K2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H006K2 */
            pr_default.execute(0, new Object[] {A332BR_Scheme_MedicationID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A327BR_SchemeID = H006K2_A327BR_SchemeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
               n327BR_SchemeID = H006K2_n327BR_SchemeID[0];
               A125BR_Medication_RXUnit = H006K2_A125BR_Medication_RXUnit[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
               n125BR_Medication_RXUnit = H006K2_n125BR_Medication_RXUnit[0];
               A124BR_Medication_RXDose = H006K2_A124BR_Medication_RXDose[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
               n124BR_Medication_RXDose = H006K2_n124BR_Medication_RXDose[0];
               A121BR_Medication_RXName = H006K2_A121BR_Medication_RXName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
               n121BR_Medication_RXName = H006K2_n121BR_Medication_RXName[0];
               A119BR_MedicationID = H006K2_A119BR_MedicationID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
               n119BR_MedicationID = H006K2_n119BR_MedicationID[0];
               A328BR_Scheme_Chem_Regimens = H006K2_A328BR_Scheme_Chem_Regimens[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
               n328BR_Scheme_Chem_Regimens = H006K2_n328BR_Scheme_Chem_Regimens[0];
               A328BR_Scheme_Chem_Regimens = H006K2_A328BR_Scheme_Chem_Regimens[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
               n328BR_Scheme_Chem_Regimens = H006K2_n328BR_Scheme_Chem_Regimens[0];
               A125BR_Medication_RXUnit = H006K2_A125BR_Medication_RXUnit[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
               n125BR_Medication_RXUnit = H006K2_n125BR_Medication_RXUnit[0];
               A124BR_Medication_RXDose = H006K2_A124BR_Medication_RXDose[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
               n124BR_Medication_RXDose = H006K2_n124BR_Medication_RXDose[0];
               A121BR_Medication_RXName = H006K2_A121BR_Medication_RXName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
               n121BR_Medication_RXName = H006K2_n121BR_Medication_RXName[0];
               /* Execute user event: Load */
               E126K2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB6K0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes6K2( )
      {
      }

      protected void STRUP6K0( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "BR_Scheme_MedicationGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E116K2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A328BR_Scheme_Chem_Regimens = cgiGet( edtBR_Scheme_Chem_Regimens_Internalname);
            n328BR_Scheme_Chem_Regimens = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
            A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ","));
            n119BR_MedicationID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
            A121BR_Medication_RXName = cgiGet( edtBR_Medication_RXName_Internalname);
            n121BR_Medication_RXName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
            A124BR_Medication_RXDose = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDose_Internalname), ".", ",");
            n124BR_Medication_RXDose = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
            A125BR_Medication_RXUnit = cgiGet( edtBR_Medication_RXUnit_Internalname);
            n125BR_Medication_RXUnit = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
            A327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_SchemeID_Internalname), ".", ","));
            n327BR_SchemeID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
            /* Read saved values. */
            wcpOA332BR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA332BR_Scheme_MedicationID"), ".", ","));
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
         E116K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E116K2( )
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
      }

      protected void nextLoad( )
      {
      }

      protected void E126K2( )
      {
         /* Load Routine */
         edtBR_Scheme_MedicationID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Scheme_MedicationID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Scheme_MedicationID_Visible), 5, 0)), true);
         edtBR_SchemeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_SchemeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_SchemeID_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV16Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Scheme_Medication";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_Scheme_MedicationID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_Scheme_MedicationID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A332BR_Scheme_MedicationID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
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
         PA6K2( ) ;
         WS6K2( ) ;
         WE6K2( ) ;
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
         sCtrlA332BR_Scheme_MedicationID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA6K2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_scheme_medicationgeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA6K2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A332BR_Scheme_MedicationID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
         }
         wcpOA332BR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA332BR_Scheme_MedicationID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A332BR_Scheme_MedicationID != wcpOA332BR_Scheme_MedicationID ) ) )
         {
            setjustcreated();
         }
         wcpOA332BR_Scheme_MedicationID = A332BR_Scheme_MedicationID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA332BR_Scheme_MedicationID = cgiGet( sPrefix+"A332BR_Scheme_MedicationID_CTRL");
         if ( StringUtil.Len( sCtrlA332BR_Scheme_MedicationID) > 0 )
         {
            A332BR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( sCtrlA332BR_Scheme_MedicationID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
         }
         else
         {
            A332BR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A332BR_Scheme_MedicationID_PARM"), ".", ","));
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
         PA6K2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS6K2( ) ;
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
         WS6K2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A332BR_Scheme_MedicationID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA332BR_Scheme_MedicationID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A332BR_Scheme_MedicationID_CTRL", StringUtil.RTrim( sCtrlA332BR_Scheme_MedicationID));
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
         WE6K2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711535821", true);
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
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("br_scheme_medicationgeneral.js", "?202022711535822", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_scheme_chem_regimens_Internalname = sPrefix+"TEXTBLOCKBR_SCHEME_CHEM_REGIMENS";
         edtBR_Scheme_Chem_Regimens_Internalname = sPrefix+"BR_SCHEME_CHEM_REGIMENS";
         divUnnamedtablebr_scheme_chem_regimens_Internalname = sPrefix+"UNNAMEDTABLEBR_SCHEME_CHEM_REGIMENS";
         lblTextblockbr_medicationid_Internalname = sPrefix+"TEXTBLOCKBR_MEDICATIONID";
         edtBR_MedicationID_Internalname = sPrefix+"BR_MEDICATIONID";
         divUnnamedtablebr_medicationid_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICATIONID";
         edtBR_Medication_RXName_Internalname = sPrefix+"BR_MEDICATION_RXNAME";
         edtBR_Medication_RXDose_Internalname = sPrefix+"BR_MEDICATION_RXDOSE";
         lblTextblockbr_medication_rxunit_Internalname = sPrefix+"TEXTBLOCKBR_MEDICATION_RXUNIT";
         edtBR_Medication_RXUnit_Internalname = sPrefix+"BR_MEDICATION_RXUNIT";
         divUnnamedtablebr_medication_rxunit_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICATION_RXUNIT";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_Scheme_MedicationID_Internalname = sPrefix+"BR_SCHEME_MEDICATIONID";
         edtBR_SchemeID_Internalname = sPrefix+"BR_SCHEMEID";
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
         edtBR_SchemeID_Jsonclick = "";
         edtBR_SchemeID_Visible = 1;
         edtBR_Scheme_MedicationID_Jsonclick = "";
         edtBR_Scheme_MedicationID_Visible = 1;
         edtBR_Medication_RXUnit_Jsonclick = "";
         edtBR_Medication_RXUnit_Enabled = 0;
         edtBR_Medication_RXDose_Jsonclick = "";
         edtBR_Medication_RXDose_Enabled = 0;
         edtBR_Medication_RXName_Jsonclick = "";
         edtBR_Medication_RXName_Enabled = 0;
         edtBR_MedicationID_Jsonclick = "";
         edtBR_MedicationID_Enabled = 0;
         edtBR_Scheme_Chem_Regimens_Jsonclick = "";
         edtBR_Scheme_Chem_Regimens_Enabled = 0;
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
         AV16Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         lblTextblockbr_scheme_chem_regimens_Jsonclick = "";
         A328BR_Scheme_Chem_Regimens = "";
         lblTextblockbr_medicationid_Jsonclick = "";
         A121BR_Medication_RXName = "";
         lblTextblockbr_medication_rxunit_Jsonclick = "";
         A125BR_Medication_RXUnit = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H006K2_A332BR_Scheme_MedicationID = new long[1] ;
         H006K2_A327BR_SchemeID = new long[1] ;
         H006K2_n327BR_SchemeID = new bool[] {false} ;
         H006K2_A125BR_Medication_RXUnit = new String[] {""} ;
         H006K2_n125BR_Medication_RXUnit = new bool[] {false} ;
         H006K2_A124BR_Medication_RXDose = new decimal[1] ;
         H006K2_n124BR_Medication_RXDose = new bool[] {false} ;
         H006K2_A121BR_Medication_RXName = new String[] {""} ;
         H006K2_n121BR_Medication_RXName = new bool[] {false} ;
         H006K2_A119BR_MedicationID = new long[1] ;
         H006K2_n119BR_MedicationID = new bool[] {false} ;
         H006K2_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         H006K2_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA332BR_Scheme_MedicationID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_medicationgeneral__default(),
            new Object[][] {
                new Object[] {
               H006K2_A332BR_Scheme_MedicationID, H006K2_A327BR_SchemeID, H006K2_n327BR_SchemeID, H006K2_A125BR_Medication_RXUnit, H006K2_n125BR_Medication_RXUnit, H006K2_A124BR_Medication_RXDose, H006K2_n124BR_Medication_RXDose, H006K2_A121BR_Medication_RXName, H006K2_n121BR_Medication_RXName, H006K2_A119BR_MedicationID,
               H006K2_n119BR_MedicationID, H006K2_A328BR_Scheme_Chem_Regimens, H006K2_n328BR_Scheme_Chem_Regimens
               }
            }
         );
         AV16Pgmname = "BR_Scheme_MedicationGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "BR_Scheme_MedicationGeneral";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private int edtBR_Scheme_Chem_Regimens_Enabled ;
      private int edtBR_MedicationID_Enabled ;
      private int edtBR_Medication_RXName_Enabled ;
      private int edtBR_Medication_RXDose_Enabled ;
      private int edtBR_Medication_RXUnit_Enabled ;
      private int edtBR_Scheme_MedicationID_Visible ;
      private int edtBR_SchemeID_Visible ;
      private int idxLst ;
      private long A332BR_Scheme_MedicationID ;
      private long wcpOA332BR_Scheme_MedicationID ;
      private long A119BR_MedicationID ;
      private long A327BR_SchemeID ;
      private long AV8BR_Scheme_MedicationID ;
      private decimal A124BR_Medication_RXDose ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV16Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String divUnnamedtablebr_scheme_chem_regimens_Internalname ;
      private String lblTextblockbr_scheme_chem_regimens_Internalname ;
      private String lblTextblockbr_scheme_chem_regimens_Jsonclick ;
      private String edtBR_Scheme_Chem_Regimens_Internalname ;
      private String edtBR_Scheme_Chem_Regimens_Jsonclick ;
      private String divUnnamedtablebr_medicationid_Internalname ;
      private String lblTextblockbr_medicationid_Internalname ;
      private String lblTextblockbr_medicationid_Jsonclick ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_Medication_RXName_Internalname ;
      private String edtBR_Medication_RXName_Jsonclick ;
      private String edtBR_Medication_RXDose_Internalname ;
      private String edtBR_Medication_RXDose_Jsonclick ;
      private String divUnnamedtablebr_medication_rxunit_Internalname ;
      private String lblTextblockbr_medication_rxunit_Internalname ;
      private String lblTextblockbr_medication_rxunit_Jsonclick ;
      private String edtBR_Medication_RXUnit_Internalname ;
      private String edtBR_Medication_RXUnit_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Scheme_MedicationID_Internalname ;
      private String edtBR_Scheme_MedicationID_Jsonclick ;
      private String edtBR_SchemeID_Internalname ;
      private String edtBR_SchemeID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA332BR_Scheme_MedicationID ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n327BR_SchemeID ;
      private bool n125BR_Medication_RXUnit ;
      private bool n124BR_Medication_RXDose ;
      private bool n121BR_Medication_RXName ;
      private bool n119BR_MedicationID ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool returnInSub ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String A121BR_Medication_RXName ;
      private String A125BR_Medication_RXUnit ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H006K2_A332BR_Scheme_MedicationID ;
      private long[] H006K2_A327BR_SchemeID ;
      private bool[] H006K2_n327BR_SchemeID ;
      private String[] H006K2_A125BR_Medication_RXUnit ;
      private bool[] H006K2_n125BR_Medication_RXUnit ;
      private decimal[] H006K2_A124BR_Medication_RXDose ;
      private bool[] H006K2_n124BR_Medication_RXDose ;
      private String[] H006K2_A121BR_Medication_RXName ;
      private bool[] H006K2_n121BR_Medication_RXName ;
      private long[] H006K2_A119BR_MedicationID ;
      private bool[] H006K2_n119BR_MedicationID ;
      private String[] H006K2_A328BR_Scheme_Chem_Regimens ;
      private bool[] H006K2_n328BR_Scheme_Chem_Regimens ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_scheme_medicationgeneral__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH006K2 ;
          prmH006K2 = new Object[] {
          new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H006K2", "SELECT T1.[BR_Scheme_MedicationID], T1.[BR_SchemeID], T3.[BR_Medication_RXUnit], T3.[BR_Medication_RXDose], T3.[BR_Medication_RXName], T1.[BR_MedicationID], T2.[BR_Scheme_Chem_Regimens] FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Scheme] T2 WITH (NOLOCK) ON T2.[BR_SchemeID] = T1.[BR_SchemeID]) LEFT JOIN [BR_Medication] T3 WITH (NOLOCK) ON T3.[BR_MedicationID] = T1.[BR_MedicationID]) WHERE T1.[BR_Scheme_MedicationID] = @BR_Scheme_MedicationID ORDER BY T1.[BR_Scheme_MedicationID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006K2,1,0,true,true )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((long[]) buf[9])[0] = rslt.getLong(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
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
       }
    }

 }

}
