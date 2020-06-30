/*
               File: BR_MedicationGeneral
        Description: BR_Medication General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:54:38.80
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
   public class br_medicationgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_medicationgeneral( )
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

      public br_medicationgeneral( IGxContext context )
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
         this.A119BR_MedicationID = aP0_BR_MedicationID;
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
         cmbBR_Medication_InpatientChemo = new GXCombobox();
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
                  A119BR_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A119BR_MedicationID});
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
            PA3M2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "BR_MedicationGeneral";
               context.Gx_err = 0;
               WS3M2( ) ;
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
            context.SendWebValue( "BR_Medication General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711543885", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicationgeneral.aspx") + "?" + UrlEncode("" +A119BR_MedicationID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA119BR_MedicationID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA119BR_MedicationID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm3M2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_medicationgeneral.js", "?202022711543889", false);
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
         return "BR_MedicationGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Medication General" ;
      }

      protected void WB3M0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_medicationgeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXName_Internalname, "药物名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXName_Internalname, A121BR_Medication_RXName, StringUtil.RTrim( context.localUtil.Format( A121BR_Medication_RXName, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXName_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXCode_Internalname, "药物代码", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXCode_Internalname, A122BR_Medication_RXCode, StringUtil.RTrim( context.localUtil.Format( A122BR_Medication_RXCode, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXCode_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXCode_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXType_Internalname, "药物类别", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXType_Internalname, A123BR_Medication_RXType, StringUtil.RTrim( context.localUtil.Format( A123BR_Medication_RXType, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXType_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXType_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXDose_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXDose_Internalname, "药物剂量", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXDose_Internalname, StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")), ((edtBR_Medication_RXDose_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ")) : context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXDose_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXDose_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXUnit_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXUnit_Internalname, "计量单位", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXUnit_Internalname, A125BR_Medication_RXUnit, StringUtil.RTrim( context.localUtil.Format( A125BR_Medication_RXUnit, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXUnit_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXUnit_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXFrequency_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXFrequency_Internalname, "服药频率", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXFrequency_Internalname, A126BR_Medication_RXFrequency, StringUtil.RTrim( context.localUtil.Format( A126BR_Medication_RXFrequency, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXFrequency_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXFrequency_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXQuantity_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXQuantity_Internalname, "用药量", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXQuantity_Internalname, A127BR_Medication_RXQuantity, StringUtil.RTrim( context.localUtil.Format( A127BR_Medication_RXQuantity, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXQuantity_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXQuantity_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXDaysSupply_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXDaysSupply_Internalname, "服药天数", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXDaysSupply_Internalname, StringUtil.LTrim( StringUtil.NToC( A128BR_Medication_RXDaysSupply, 15, 5, ".", "")), ((edtBR_Medication_RXDaysSupply_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A128BR_Medication_RXDaysSupply, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A128BR_Medication_RXDaysSupply, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXDaysSupply_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXDaysSupply_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXRoute_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXRoute_Internalname, "给药途径", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXRoute_Internalname, A129BR_Medication_RXRoute, StringUtil.RTrim( context.localUtil.Format( A129BR_Medication_RXRoute, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXRoute_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_RXRoute_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_PrescriptionDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_PrescriptionDate_Internalname, "处方日期", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Medication_PrescriptionDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_PrescriptionDate_Internalname, context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"), context.localUtil.Format( A130BR_Medication_PrescriptionDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_PrescriptionDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_PrescriptionDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Medication_PrescriptionDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Medication_PrescriptionDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicationGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_AdmitStartDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_AdmitStartDate_Internalname, "服药日期", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Medication_AdmitStartDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_AdmitStartDate_Internalname, context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"), context.localUtil.Format( A132BR_Medication_AdmitStartDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_AdmitStartDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_AdmitStartDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Medication_AdmitStartDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Medication_AdmitStartDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicationGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_AdmitEndDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_AdmitEndDate_Internalname, "停药日期", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Medication_AdmitEndDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_AdmitEndDate_Internalname, context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"), context.localUtil.Format( A133BR_Medication_AdmitEndDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_AdmitEndDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_AdmitEndDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Medication_AdmitEndDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Medication_AdmitEndDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicationGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Medication_InpatientChemo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Medication_InpatientChemo_Internalname, "是否接受住院化疗", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Medication_InpatientChemo, cmbBR_Medication_InpatientChemo_Internalname, StringUtil.RTrim( A131BR_Medication_InpatientChemo), 1, cmbBR_Medication_InpatientChemo_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Medication_InpatientChemo.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_MedicationGeneral.htm");
            cmbBR_Medication_InpatientChemo.CurrentValue = StringUtil.RTrim( A131BR_Medication_InpatientChemo);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Medication_InpatientChemo_Internalname, "Values", (String)(cmbBR_Medication_InpatientChemo.ToJavascriptSource()), true);
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
            GxWebStd.gx_single_line_edit( context, edtBR_MedicationID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicationID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicationID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_MedicationGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_MedicationGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A120BR_Medication_RXID), 4, 0, ".", "")), context.localUtil.Format( (decimal)(A120BR_Medication_RXID), "ZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Medication_RXID_Visible, 0, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START3M2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Medication General", 0) ;
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
               STRUP3M0( ) ;
            }
         }
      }

      protected void WS3M2( )
      {
         START3M2( ) ;
         EVT3M2( ) ;
      }

      protected void EVT3M2( )
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
                                 STRUP3M0( ) ;
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
                                 STRUP3M0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E113M2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3M0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E123M2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3M0( ) ;
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
                                 STRUP3M0( ) ;
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

      protected void WE3M2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3M2( ) ;
            }
         }
      }

      protected void PA3M2( )
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
         if ( cmbBR_Medication_InpatientChemo.ItemCount > 0 )
         {
            A131BR_Medication_InpatientChemo = cmbBR_Medication_InpatientChemo.getValidValue(A131BR_Medication_InpatientChemo);
            n131BR_Medication_InpatientChemo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Medication_InpatientChemo.CurrentValue = StringUtil.RTrim( A131BR_Medication_InpatientChemo);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Medication_InpatientChemo_Internalname, "Values", cmbBR_Medication_InpatientChemo.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF3M2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "BR_MedicationGeneral";
         context.Gx_err = 0;
      }

      protected void RF3M2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H003M2 */
            pr_default.execute(0, new Object[] {A119BR_MedicationID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A85BR_Information_ID = H003M2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003M2_n85BR_Information_ID[0];
               A120BR_Medication_RXID = H003M2_A120BR_Medication_RXID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A120BR_Medication_RXID", StringUtil.LTrim( StringUtil.Str( (decimal)(A120BR_Medication_RXID), 4, 0)));
               n120BR_Medication_RXID = H003M2_n120BR_Medication_RXID[0];
               A36BR_Information_PatientNo = H003M2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H003M2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H003M2_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               A131BR_Medication_InpatientChemo = H003M2_A131BR_Medication_InpatientChemo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
               n131BR_Medication_InpatientChemo = H003M2_n131BR_Medication_InpatientChemo[0];
               A133BR_Medication_AdmitEndDate = H003M2_A133BR_Medication_AdmitEndDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A133BR_Medication_AdmitEndDate", context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"));
               n133BR_Medication_AdmitEndDate = H003M2_n133BR_Medication_AdmitEndDate[0];
               A132BR_Medication_AdmitStartDate = H003M2_A132BR_Medication_AdmitStartDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A132BR_Medication_AdmitStartDate", context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"));
               n132BR_Medication_AdmitStartDate = H003M2_n132BR_Medication_AdmitStartDate[0];
               A130BR_Medication_PrescriptionDate = H003M2_A130BR_Medication_PrescriptionDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A130BR_Medication_PrescriptionDate", context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"));
               n130BR_Medication_PrescriptionDate = H003M2_n130BR_Medication_PrescriptionDate[0];
               A129BR_Medication_RXRoute = H003M2_A129BR_Medication_RXRoute[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
               n129BR_Medication_RXRoute = H003M2_n129BR_Medication_RXRoute[0];
               A128BR_Medication_RXDaysSupply = H003M2_A128BR_Medication_RXDaysSupply[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A128BR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( A128BR_Medication_RXDaysSupply, 15, 5)));
               n128BR_Medication_RXDaysSupply = H003M2_n128BR_Medication_RXDaysSupply[0];
               A127BR_Medication_RXQuantity = H003M2_A127BR_Medication_RXQuantity[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127BR_Medication_RXQuantity", A127BR_Medication_RXQuantity);
               n127BR_Medication_RXQuantity = H003M2_n127BR_Medication_RXQuantity[0];
               A126BR_Medication_RXFrequency = H003M2_A126BR_Medication_RXFrequency[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
               n126BR_Medication_RXFrequency = H003M2_n126BR_Medication_RXFrequency[0];
               A125BR_Medication_RXUnit = H003M2_A125BR_Medication_RXUnit[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
               n125BR_Medication_RXUnit = H003M2_n125BR_Medication_RXUnit[0];
               A124BR_Medication_RXDose = H003M2_A124BR_Medication_RXDose[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
               n124BR_Medication_RXDose = H003M2_n124BR_Medication_RXDose[0];
               A123BR_Medication_RXType = H003M2_A123BR_Medication_RXType[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A123BR_Medication_RXType", A123BR_Medication_RXType);
               n123BR_Medication_RXType = H003M2_n123BR_Medication_RXType[0];
               A122BR_Medication_RXCode = H003M2_A122BR_Medication_RXCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A122BR_Medication_RXCode", A122BR_Medication_RXCode);
               n122BR_Medication_RXCode = H003M2_n122BR_Medication_RXCode[0];
               A121BR_Medication_RXName = H003M2_A121BR_Medication_RXName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
               n121BR_Medication_RXName = H003M2_n121BR_Medication_RXName[0];
               A85BR_Information_ID = H003M2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003M2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H003M2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H003M2_n36BR_Information_PatientNo[0];
               /* Execute user event: Load */
               E123M2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB3M0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes3M2( )
      {
      }

      protected void STRUP3M0( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "BR_MedicationGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E113M2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A121BR_Medication_RXName = cgiGet( edtBR_Medication_RXName_Internalname);
            n121BR_Medication_RXName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
            A122BR_Medication_RXCode = cgiGet( edtBR_Medication_RXCode_Internalname);
            n122BR_Medication_RXCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A122BR_Medication_RXCode", A122BR_Medication_RXCode);
            A123BR_Medication_RXType = cgiGet( edtBR_Medication_RXType_Internalname);
            n123BR_Medication_RXType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A123BR_Medication_RXType", A123BR_Medication_RXType);
            A124BR_Medication_RXDose = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDose_Internalname), ".", ",");
            n124BR_Medication_RXDose = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
            A125BR_Medication_RXUnit = cgiGet( edtBR_Medication_RXUnit_Internalname);
            n125BR_Medication_RXUnit = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
            A126BR_Medication_RXFrequency = cgiGet( edtBR_Medication_RXFrequency_Internalname);
            n126BR_Medication_RXFrequency = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
            A127BR_Medication_RXQuantity = cgiGet( edtBR_Medication_RXQuantity_Internalname);
            n127BR_Medication_RXQuantity = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A127BR_Medication_RXQuantity", A127BR_Medication_RXQuantity);
            A128BR_Medication_RXDaysSupply = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDaysSupply_Internalname), ".", ",");
            n128BR_Medication_RXDaysSupply = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A128BR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( A128BR_Medication_RXDaysSupply, 15, 5)));
            A129BR_Medication_RXRoute = cgiGet( edtBR_Medication_RXRoute_Internalname);
            n129BR_Medication_RXRoute = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
            A130BR_Medication_PrescriptionDate = context.localUtil.CToD( cgiGet( edtBR_Medication_PrescriptionDate_Internalname), 0);
            n130BR_Medication_PrescriptionDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A130BR_Medication_PrescriptionDate", context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"));
            A132BR_Medication_AdmitStartDate = context.localUtil.CToD( cgiGet( edtBR_Medication_AdmitStartDate_Internalname), 0);
            n132BR_Medication_AdmitStartDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A132BR_Medication_AdmitStartDate", context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"));
            A133BR_Medication_AdmitEndDate = context.localUtil.CToD( cgiGet( edtBR_Medication_AdmitEndDate_Internalname), 0);
            n133BR_Medication_AdmitEndDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A133BR_Medication_AdmitEndDate", context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"));
            cmbBR_Medication_InpatientChemo.CurrentValue = cgiGet( cmbBR_Medication_InpatientChemo_Internalname);
            A131BR_Medication_InpatientChemo = cgiGet( cmbBR_Medication_InpatientChemo_Internalname);
            n131BR_Medication_InpatientChemo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
            n36BR_Information_PatientNo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            A120BR_Medication_RXID = (short)(context.localUtil.CToN( cgiGet( edtBR_Medication_RXID_Internalname), ".", ","));
            n120BR_Medication_RXID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A120BR_Medication_RXID", StringUtil.LTrim( StringUtil.Str( (decimal)(A120BR_Medication_RXID), 4, 0)));
            /* Read saved values. */
            wcpOA119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA119BR_MedicationID"), ".", ","));
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
         E113M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E113M2( )
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

      protected void E123M2( )
      {
         /* Load Routine */
         edtBR_MedicationID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicationID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         edtBR_Medication_RXID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Medication_RXID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_RXID_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV16Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Medication";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_MedicationID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_MedicationID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A119BR_MedicationID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
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
         PA3M2( ) ;
         WS3M2( ) ;
         WE3M2( ) ;
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
         sCtrlA119BR_MedicationID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA3M2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_medicationgeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA3M2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A119BR_MedicationID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
         }
         wcpOA119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA119BR_MedicationID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A119BR_MedicationID != wcpOA119BR_MedicationID ) ) )
         {
            setjustcreated();
         }
         wcpOA119BR_MedicationID = A119BR_MedicationID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA119BR_MedicationID = cgiGet( sPrefix+"A119BR_MedicationID_CTRL");
         if ( StringUtil.Len( sCtrlA119BR_MedicationID) > 0 )
         {
            A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( sCtrlA119BR_MedicationID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
         }
         else
         {
            A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A119BR_MedicationID_PARM"), ".", ","));
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
         PA3M2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS3M2( ) ;
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
         WS3M2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A119BR_MedicationID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA119BR_MedicationID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A119BR_MedicationID_CTRL", StringUtil.RTrim( sCtrlA119BR_MedicationID));
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
         WE3M2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711544021", true);
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
            context.AddJavascriptSource("br_medicationgeneral.js", "?202022711544021", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbBR_Medication_InpatientChemo.Name = "BR_MEDICATION_INPATIENTCHEMO";
         cmbBR_Medication_InpatientChemo.WebTags = "";
         cmbBR_Medication_InpatientChemo.addItem("", "(请选择)", 0);
         cmbBR_Medication_InpatientChemo.addItem("否", "否", 0);
         cmbBR_Medication_InpatientChemo.addItem("是", "是", 0);
         cmbBR_Medication_InpatientChemo.addItem("不详", "不详", 0);
         if ( cmbBR_Medication_InpatientChemo.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtBR_Medication_RXName_Internalname = sPrefix+"BR_MEDICATION_RXNAME";
         edtBR_Medication_RXCode_Internalname = sPrefix+"BR_MEDICATION_RXCODE";
         edtBR_Medication_RXType_Internalname = sPrefix+"BR_MEDICATION_RXTYPE";
         edtBR_Medication_RXDose_Internalname = sPrefix+"BR_MEDICATION_RXDOSE";
         edtBR_Medication_RXUnit_Internalname = sPrefix+"BR_MEDICATION_RXUNIT";
         edtBR_Medication_RXFrequency_Internalname = sPrefix+"BR_MEDICATION_RXFREQUENCY";
         edtBR_Medication_RXQuantity_Internalname = sPrefix+"BR_MEDICATION_RXQUANTITY";
         edtBR_Medication_RXDaysSupply_Internalname = sPrefix+"BR_MEDICATION_RXDAYSSUPPLY";
         edtBR_Medication_RXRoute_Internalname = sPrefix+"BR_MEDICATION_RXROUTE";
         edtBR_Medication_PrescriptionDate_Internalname = sPrefix+"BR_MEDICATION_PRESCRIPTIONDATE";
         edtBR_Medication_AdmitStartDate_Internalname = sPrefix+"BR_MEDICATION_ADMITSTARTDATE";
         edtBR_Medication_AdmitEndDate_Internalname = sPrefix+"BR_MEDICATION_ADMITENDDATE";
         cmbBR_Medication_InpatientChemo_Internalname = sPrefix+"BR_MEDICATION_INPATIENTCHEMO";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_MedicationID_Internalname = sPrefix+"BR_MEDICATIONID";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = sPrefix+"BR_INFORMATION_PATIENTNO";
         edtBR_Medication_RXID_Internalname = sPrefix+"BR_MEDICATION_RXID";
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
         edtBR_Medication_RXID_Jsonclick = "";
         edtBR_Medication_RXID_Visible = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtBR_MedicationID_Jsonclick = "";
         edtBR_MedicationID_Visible = 1;
         cmbBR_Medication_InpatientChemo_Jsonclick = "";
         cmbBR_Medication_InpatientChemo.Enabled = 0;
         edtBR_Medication_AdmitEndDate_Jsonclick = "";
         edtBR_Medication_AdmitEndDate_Enabled = 0;
         edtBR_Medication_AdmitStartDate_Jsonclick = "";
         edtBR_Medication_AdmitStartDate_Enabled = 0;
         edtBR_Medication_PrescriptionDate_Jsonclick = "";
         edtBR_Medication_PrescriptionDate_Enabled = 0;
         edtBR_Medication_RXRoute_Jsonclick = "";
         edtBR_Medication_RXRoute_Enabled = 0;
         edtBR_Medication_RXDaysSupply_Jsonclick = "";
         edtBR_Medication_RXDaysSupply_Enabled = 0;
         edtBR_Medication_RXQuantity_Jsonclick = "";
         edtBR_Medication_RXQuantity_Enabled = 0;
         edtBR_Medication_RXFrequency_Jsonclick = "";
         edtBR_Medication_RXFrequency_Enabled = 0;
         edtBR_Medication_RXUnit_Jsonclick = "";
         edtBR_Medication_RXUnit_Enabled = 0;
         edtBR_Medication_RXDose_Jsonclick = "";
         edtBR_Medication_RXDose_Enabled = 0;
         edtBR_Medication_RXType_Jsonclick = "";
         edtBR_Medication_RXType_Enabled = 0;
         edtBR_Medication_RXCode_Jsonclick = "";
         edtBR_Medication_RXCode_Enabled = 0;
         edtBR_Medication_RXName_Jsonclick = "";
         edtBR_Medication_RXName_Enabled = 0;
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
         A121BR_Medication_RXName = "";
         A122BR_Medication_RXCode = "";
         A123BR_Medication_RXType = "";
         A125BR_Medication_RXUnit = "";
         A126BR_Medication_RXFrequency = "";
         A127BR_Medication_RXQuantity = "";
         A129BR_Medication_RXRoute = "";
         A130BR_Medication_PrescriptionDate = DateTime.MinValue;
         A132BR_Medication_AdmitStartDate = DateTime.MinValue;
         A133BR_Medication_AdmitEndDate = DateTime.MinValue;
         A131BR_Medication_InpatientChemo = "";
         A36BR_Information_PatientNo = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H003M2_A85BR_Information_ID = new long[1] ;
         H003M2_n85BR_Information_ID = new bool[] {false} ;
         H003M2_A119BR_MedicationID = new long[1] ;
         H003M2_A120BR_Medication_RXID = new short[1] ;
         H003M2_n120BR_Medication_RXID = new bool[] {false} ;
         H003M2_A36BR_Information_PatientNo = new String[] {""} ;
         H003M2_n36BR_Information_PatientNo = new bool[] {false} ;
         H003M2_A19BR_EncounterID = new long[1] ;
         H003M2_A131BR_Medication_InpatientChemo = new String[] {""} ;
         H003M2_n131BR_Medication_InpatientChemo = new bool[] {false} ;
         H003M2_A133BR_Medication_AdmitEndDate = new DateTime[] {DateTime.MinValue} ;
         H003M2_n133BR_Medication_AdmitEndDate = new bool[] {false} ;
         H003M2_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         H003M2_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         H003M2_A130BR_Medication_PrescriptionDate = new DateTime[] {DateTime.MinValue} ;
         H003M2_n130BR_Medication_PrescriptionDate = new bool[] {false} ;
         H003M2_A129BR_Medication_RXRoute = new String[] {""} ;
         H003M2_n129BR_Medication_RXRoute = new bool[] {false} ;
         H003M2_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         H003M2_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         H003M2_A127BR_Medication_RXQuantity = new String[] {""} ;
         H003M2_n127BR_Medication_RXQuantity = new bool[] {false} ;
         H003M2_A126BR_Medication_RXFrequency = new String[] {""} ;
         H003M2_n126BR_Medication_RXFrequency = new bool[] {false} ;
         H003M2_A125BR_Medication_RXUnit = new String[] {""} ;
         H003M2_n125BR_Medication_RXUnit = new bool[] {false} ;
         H003M2_A124BR_Medication_RXDose = new decimal[1] ;
         H003M2_n124BR_Medication_RXDose = new bool[] {false} ;
         H003M2_A123BR_Medication_RXType = new String[] {""} ;
         H003M2_n123BR_Medication_RXType = new bool[] {false} ;
         H003M2_A122BR_Medication_RXCode = new String[] {""} ;
         H003M2_n122BR_Medication_RXCode = new bool[] {false} ;
         H003M2_A121BR_Medication_RXName = new String[] {""} ;
         H003M2_n121BR_Medication_RXName = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA119BR_MedicationID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicationgeneral__default(),
            new Object[][] {
                new Object[] {
               H003M2_A85BR_Information_ID, H003M2_n85BR_Information_ID, H003M2_A119BR_MedicationID, H003M2_A120BR_Medication_RXID, H003M2_n120BR_Medication_RXID, H003M2_A36BR_Information_PatientNo, H003M2_n36BR_Information_PatientNo, H003M2_A19BR_EncounterID, H003M2_A131BR_Medication_InpatientChemo, H003M2_n131BR_Medication_InpatientChemo,
               H003M2_A133BR_Medication_AdmitEndDate, H003M2_n133BR_Medication_AdmitEndDate, H003M2_A132BR_Medication_AdmitStartDate, H003M2_n132BR_Medication_AdmitStartDate, H003M2_A130BR_Medication_PrescriptionDate, H003M2_n130BR_Medication_PrescriptionDate, H003M2_A129BR_Medication_RXRoute, H003M2_n129BR_Medication_RXRoute, H003M2_A128BR_Medication_RXDaysSupply, H003M2_n128BR_Medication_RXDaysSupply,
               H003M2_A127BR_Medication_RXQuantity, H003M2_n127BR_Medication_RXQuantity, H003M2_A126BR_Medication_RXFrequency, H003M2_n126BR_Medication_RXFrequency, H003M2_A125BR_Medication_RXUnit, H003M2_n125BR_Medication_RXUnit, H003M2_A124BR_Medication_RXDose, H003M2_n124BR_Medication_RXDose, H003M2_A123BR_Medication_RXType, H003M2_n123BR_Medication_RXType,
               H003M2_A122BR_Medication_RXCode, H003M2_n122BR_Medication_RXCode, H003M2_A121BR_Medication_RXName, H003M2_n121BR_Medication_RXName
               }
            }
         );
         AV16Pgmname = "BR_MedicationGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "BR_MedicationGeneral";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short A120BR_Medication_RXID ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private int edtBR_Medication_RXName_Enabled ;
      private int edtBR_Medication_RXCode_Enabled ;
      private int edtBR_Medication_RXType_Enabled ;
      private int edtBR_Medication_RXDose_Enabled ;
      private int edtBR_Medication_RXUnit_Enabled ;
      private int edtBR_Medication_RXFrequency_Enabled ;
      private int edtBR_Medication_RXQuantity_Enabled ;
      private int edtBR_Medication_RXDaysSupply_Enabled ;
      private int edtBR_Medication_RXRoute_Enabled ;
      private int edtBR_Medication_PrescriptionDate_Enabled ;
      private int edtBR_Medication_AdmitStartDate_Enabled ;
      private int edtBR_Medication_AdmitEndDate_Enabled ;
      private int edtBR_MedicationID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtBR_Medication_RXID_Visible ;
      private int idxLst ;
      private long A119BR_MedicationID ;
      private long wcpOA119BR_MedicationID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV8BR_MedicationID ;
      private decimal A124BR_Medication_RXDose ;
      private decimal A128BR_Medication_RXDaysSupply ;
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
      private String edtBR_Medication_RXName_Internalname ;
      private String edtBR_Medication_RXName_Jsonclick ;
      private String edtBR_Medication_RXCode_Internalname ;
      private String edtBR_Medication_RXCode_Jsonclick ;
      private String edtBR_Medication_RXType_Internalname ;
      private String edtBR_Medication_RXType_Jsonclick ;
      private String edtBR_Medication_RXDose_Internalname ;
      private String edtBR_Medication_RXDose_Jsonclick ;
      private String edtBR_Medication_RXUnit_Internalname ;
      private String edtBR_Medication_RXUnit_Jsonclick ;
      private String edtBR_Medication_RXFrequency_Internalname ;
      private String edtBR_Medication_RXFrequency_Jsonclick ;
      private String edtBR_Medication_RXQuantity_Internalname ;
      private String edtBR_Medication_RXQuantity_Jsonclick ;
      private String edtBR_Medication_RXDaysSupply_Internalname ;
      private String edtBR_Medication_RXDaysSupply_Jsonclick ;
      private String edtBR_Medication_RXRoute_Internalname ;
      private String edtBR_Medication_RXRoute_Jsonclick ;
      private String edtBR_Medication_PrescriptionDate_Internalname ;
      private String edtBR_Medication_PrescriptionDate_Jsonclick ;
      private String edtBR_Medication_AdmitStartDate_Internalname ;
      private String edtBR_Medication_AdmitStartDate_Jsonclick ;
      private String edtBR_Medication_AdmitEndDate_Internalname ;
      private String edtBR_Medication_AdmitEndDate_Jsonclick ;
      private String cmbBR_Medication_InpatientChemo_Internalname ;
      private String cmbBR_Medication_InpatientChemo_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Medication_RXID_Internalname ;
      private String edtBR_Medication_RXID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA119BR_MedicationID ;
      private DateTime A130BR_Medication_PrescriptionDate ;
      private DateTime A132BR_Medication_AdmitStartDate ;
      private DateTime A133BR_Medication_AdmitEndDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n131BR_Medication_InpatientChemo ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool n120BR_Medication_RXID ;
      private bool n36BR_Information_PatientNo ;
      private bool n133BR_Medication_AdmitEndDate ;
      private bool n132BR_Medication_AdmitStartDate ;
      private bool n130BR_Medication_PrescriptionDate ;
      private bool n129BR_Medication_RXRoute ;
      private bool n128BR_Medication_RXDaysSupply ;
      private bool n127BR_Medication_RXQuantity ;
      private bool n126BR_Medication_RXFrequency ;
      private bool n125BR_Medication_RXUnit ;
      private bool n124BR_Medication_RXDose ;
      private bool n123BR_Medication_RXType ;
      private bool n122BR_Medication_RXCode ;
      private bool n121BR_Medication_RXName ;
      private bool returnInSub ;
      private String A121BR_Medication_RXName ;
      private String A122BR_Medication_RXCode ;
      private String A123BR_Medication_RXType ;
      private String A125BR_Medication_RXUnit ;
      private String A126BR_Medication_RXFrequency ;
      private String A127BR_Medication_RXQuantity ;
      private String A129BR_Medication_RXRoute ;
      private String A131BR_Medication_InpatientChemo ;
      private String A36BR_Information_PatientNo ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Medication_InpatientChemo ;
      private IDataStoreProvider pr_default ;
      private long[] H003M2_A85BR_Information_ID ;
      private bool[] H003M2_n85BR_Information_ID ;
      private long[] H003M2_A119BR_MedicationID ;
      private short[] H003M2_A120BR_Medication_RXID ;
      private bool[] H003M2_n120BR_Medication_RXID ;
      private String[] H003M2_A36BR_Information_PatientNo ;
      private bool[] H003M2_n36BR_Information_PatientNo ;
      private long[] H003M2_A19BR_EncounterID ;
      private String[] H003M2_A131BR_Medication_InpatientChemo ;
      private bool[] H003M2_n131BR_Medication_InpatientChemo ;
      private DateTime[] H003M2_A133BR_Medication_AdmitEndDate ;
      private bool[] H003M2_n133BR_Medication_AdmitEndDate ;
      private DateTime[] H003M2_A132BR_Medication_AdmitStartDate ;
      private bool[] H003M2_n132BR_Medication_AdmitStartDate ;
      private DateTime[] H003M2_A130BR_Medication_PrescriptionDate ;
      private bool[] H003M2_n130BR_Medication_PrescriptionDate ;
      private String[] H003M2_A129BR_Medication_RXRoute ;
      private bool[] H003M2_n129BR_Medication_RXRoute ;
      private decimal[] H003M2_A128BR_Medication_RXDaysSupply ;
      private bool[] H003M2_n128BR_Medication_RXDaysSupply ;
      private String[] H003M2_A127BR_Medication_RXQuantity ;
      private bool[] H003M2_n127BR_Medication_RXQuantity ;
      private String[] H003M2_A126BR_Medication_RXFrequency ;
      private bool[] H003M2_n126BR_Medication_RXFrequency ;
      private String[] H003M2_A125BR_Medication_RXUnit ;
      private bool[] H003M2_n125BR_Medication_RXUnit ;
      private decimal[] H003M2_A124BR_Medication_RXDose ;
      private bool[] H003M2_n124BR_Medication_RXDose ;
      private String[] H003M2_A123BR_Medication_RXType ;
      private bool[] H003M2_n123BR_Medication_RXType ;
      private String[] H003M2_A122BR_Medication_RXCode ;
      private bool[] H003M2_n122BR_Medication_RXCode ;
      private String[] H003M2_A121BR_Medication_RXName ;
      private bool[] H003M2_n121BR_Medication_RXName ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_medicationgeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH003M2 ;
          prmH003M2 = new Object[] {
          new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003M2", "SELECT T2.[BR_Information_ID], T1.[BR_MedicationID], T1.[BR_Medication_RXID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Medication_InpatientChemo], T1.[BR_Medication_AdmitEndDate], T1.[BR_Medication_AdmitStartDate], T1.[BR_Medication_PrescriptionDate], T1.[BR_Medication_RXRoute], T1.[BR_Medication_RXDaysSupply], T1.[BR_Medication_RXQuantity], T1.[BR_Medication_RXFrequency], T1.[BR_Medication_RXUnit], T1.[BR_Medication_RXDose], T1.[BR_Medication_RXType], T1.[BR_Medication_RXCode], T1.[BR_Medication_RXName] FROM (([BR_Medication] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE T1.[BR_MedicationID] = @BR_MedicationID ORDER BY T1.[BR_MedicationID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003M2,1,0,true,true )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[14])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((String[]) buf[16])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
                ((decimal[]) buf[18])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(11);
                ((String[]) buf[20])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(12);
                ((String[]) buf[22])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(13);
                ((String[]) buf[24])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(14);
                ((decimal[]) buf[26])[0] = rslt.getDecimal(15) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(15);
                ((String[]) buf[28])[0] = rslt.getVarchar(16) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(16);
                ((String[]) buf[30])[0] = rslt.getVarchar(17) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(17);
                ((String[]) buf[32])[0] = rslt.getVarchar(18) ;
                ((bool[]) buf[33])[0] = rslt.wasNull(18);
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
