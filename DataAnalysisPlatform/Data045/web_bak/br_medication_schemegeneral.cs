/*
               File: BR_Medication_SchemeGeneral
        Description: BR_Medication_Scheme General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:34:32.74
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
   public class br_medication_schemegeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_medication_schemegeneral( )
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

      public br_medication_schemegeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Medication_SchemeID ,
                           long aP1_BR_MedicationID )
      {
         this.A296BR_Medication_SchemeID = aP0_BR_Medication_SchemeID;
         this.A119BR_MedicationID = aP1_BR_MedicationID;
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
                  A296BR_Medication_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
                  A119BR_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  n119BR_MedicationID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A296BR_Medication_SchemeID,(long)A119BR_MedicationID});
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
            PA502( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "BR_Medication_SchemeGeneral";
               context.Gx_err = 0;
               WS502( ) ;
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
            context.SendWebValue( "BR_Medication_Scheme General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279343278", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medication_schemegeneral.aspx") + "?" + UrlEncode("" +A296BR_Medication_SchemeID) + "," + UrlEncode("" +A119BR_MedicationID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA296BR_Medication_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA119BR_MedicationID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA119BR_MedicationID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm502( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_medication_schemegeneral.js", "?20202279343281", false);
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
         return "BR_Medication_SchemeGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Medication_Scheme General" ;
      }

      protected void WB500( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_medication_schemegeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_Chem_Name_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_Chem_Name_Internalname, "化疗方案名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_Chem_Name_Internalname, A305BR_Medication_Chem_Name, StringUtil.RTrim( context.localUtil.Format( A305BR_Medication_Chem_Name, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_Chem_Name_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_Chem_Name_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_SchemeGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_Chem_Cycle_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_Chem_Cycle_Internalname, "周期", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_Chem_Cycle_Internalname, StringUtil.LTrim( StringUtil.NToC( A306BR_Medication_Chem_Cycle, 15, 5, ".", "")), ((edtBR_Medication_Chem_Cycle_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A306BR_Medication_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A306BR_Medication_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_Chem_Cycle_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_Chem_Cycle_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Medication_SchemeGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_Chem_Line_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_Chem_Line_Internalname, "线级", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_Chem_Line_Internalname, A307BR_Medication_Chem_Line, StringUtil.RTrim( context.localUtil.Format( A307BR_Medication_Chem_Line, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_Chem_Line_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_Chem_Line_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_SchemeGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medication_chem_detail_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-1 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medication_chem_detail_Internalname, "描述化疗方案", "", "", lblTextblockbr_medication_chem_detail_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Medication_SchemeGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-11", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_Chem_Detail_Internalname, "描述化疗方案", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_Chem_Detail_Internalname, A313BR_Medication_Chem_Detail, StringUtil.RTrim( context.localUtil.Format( A313BR_Medication_Chem_Detail, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_Chem_Detail_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Medication_Chem_Detail_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_SchemeGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_SchemeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A296BR_Medication_SchemeID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_SchemeID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Medication_SchemeID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Medication_SchemeGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicationID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicationID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicationID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Medication_SchemeGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START502( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Medication_Scheme General", 0) ;
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
               STRUP500( ) ;
            }
         }
      }

      protected void WS502( )
      {
         START502( ) ;
         EVT502( ) ;
      }

      protected void EVT502( )
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
                                 STRUP500( ) ;
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
                                 STRUP500( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E11502 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP500( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E12502 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP500( ) ;
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
                                 STRUP500( ) ;
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

      protected void WE502( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm502( ) ;
            }
         }
      }

      protected void PA502( )
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
         RF502( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "BR_Medication_SchemeGeneral";
         context.Gx_err = 0;
      }

      protected void RF502( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00502 */
            pr_default.execute(0, new Object[] {A296BR_Medication_SchemeID, n119BR_MedicationID, A119BR_MedicationID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A313BR_Medication_Chem_Detail = H00502_A313BR_Medication_Chem_Detail[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A313BR_Medication_Chem_Detail", A313BR_Medication_Chem_Detail);
               n313BR_Medication_Chem_Detail = H00502_n313BR_Medication_Chem_Detail[0];
               A307BR_Medication_Chem_Line = H00502_A307BR_Medication_Chem_Line[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A307BR_Medication_Chem_Line", A307BR_Medication_Chem_Line);
               n307BR_Medication_Chem_Line = H00502_n307BR_Medication_Chem_Line[0];
               A306BR_Medication_Chem_Cycle = H00502_A306BR_Medication_Chem_Cycle[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A306BR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A306BR_Medication_Chem_Cycle, 15, 5)));
               n306BR_Medication_Chem_Cycle = H00502_n306BR_Medication_Chem_Cycle[0];
               A305BR_Medication_Chem_Name = H00502_A305BR_Medication_Chem_Name[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A305BR_Medication_Chem_Name", A305BR_Medication_Chem_Name);
               n305BR_Medication_Chem_Name = H00502_n305BR_Medication_Chem_Name[0];
               /* Execute user event: Load */
               E12502 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB500( ) ;
         }
      }

      protected void send_integrity_lvl_hashes502( )
      {
      }

      protected void STRUP500( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "BR_Medication_SchemeGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11502 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A305BR_Medication_Chem_Name = cgiGet( edtBR_Medication_Chem_Name_Internalname);
            n305BR_Medication_Chem_Name = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A305BR_Medication_Chem_Name", A305BR_Medication_Chem_Name);
            A306BR_Medication_Chem_Cycle = context.localUtil.CToN( cgiGet( edtBR_Medication_Chem_Cycle_Internalname), ".", ",");
            n306BR_Medication_Chem_Cycle = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A306BR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A306BR_Medication_Chem_Cycle, 15, 5)));
            A307BR_Medication_Chem_Line = cgiGet( edtBR_Medication_Chem_Line_Internalname);
            n307BR_Medication_Chem_Line = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A307BR_Medication_Chem_Line", A307BR_Medication_Chem_Line);
            A313BR_Medication_Chem_Detail = cgiGet( edtBR_Medication_Chem_Detail_Internalname);
            n313BR_Medication_Chem_Detail = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A313BR_Medication_Chem_Detail", A313BR_Medication_Chem_Detail);
            /* Read saved values. */
            wcpOA296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA296BR_Medication_SchemeID"), ".", ","));
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
         E11502 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11502( )
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

      protected void E12502( )
      {
         /* Load Routine */
         edtBR_Medication_SchemeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Medication_SchemeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_SchemeID_Visible), 5, 0)), true);
         edtBR_MedicationID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicationID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV16Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Medication_Scheme";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_Medication_SchemeID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_Medication_SchemeID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_MedicationID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV13BR_MedicationID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A296BR_Medication_SchemeID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
         A119BR_MedicationID = Convert.ToInt64(getParm(obj,1));
         n119BR_MedicationID = false;
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
         PA502( ) ;
         WS502( ) ;
         WE502( ) ;
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
         sCtrlA296BR_Medication_SchemeID = (String)((String)getParm(obj,0));
         sCtrlA119BR_MedicationID = (String)((String)getParm(obj,1));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA502( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_medication_schemegeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA502( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A296BR_Medication_SchemeID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
            A119BR_MedicationID = Convert.ToInt64(getParm(obj,3));
            n119BR_MedicationID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
         }
         wcpOA296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA296BR_Medication_SchemeID"), ".", ","));
         wcpOA119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA119BR_MedicationID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A296BR_Medication_SchemeID != wcpOA296BR_Medication_SchemeID ) || ( A119BR_MedicationID != wcpOA119BR_MedicationID ) ) )
         {
            setjustcreated();
         }
         wcpOA296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
         wcpOA119BR_MedicationID = A119BR_MedicationID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA296BR_Medication_SchemeID = cgiGet( sPrefix+"A296BR_Medication_SchemeID_CTRL");
         if ( StringUtil.Len( sCtrlA296BR_Medication_SchemeID) > 0 )
         {
            A296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( sCtrlA296BR_Medication_SchemeID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
         }
         else
         {
            A296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A296BR_Medication_SchemeID_PARM"), ".", ","));
         }
         sCtrlA119BR_MedicationID = cgiGet( sPrefix+"A119BR_MedicationID_CTRL");
         if ( StringUtil.Len( sCtrlA119BR_MedicationID) > 0 )
         {
            A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( sCtrlA119BR_MedicationID), ".", ","));
            n119BR_MedicationID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
         }
         else
         {
            A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A119BR_MedicationID_PARM"), ".", ","));
            n119BR_MedicationID = false;
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
         PA502( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS502( ) ;
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
         WS502( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A296BR_Medication_SchemeID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A296BR_Medication_SchemeID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA296BR_Medication_SchemeID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A296BR_Medication_SchemeID_CTRL", StringUtil.RTrim( sCtrlA296BR_Medication_SchemeID));
         }
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
         WE502( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279343336", true);
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
            context.AddJavascriptSource("br_medication_schemegeneral.js", "?20202279343336", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtBR_Medication_Chem_Name_Internalname = sPrefix+"BR_MEDICATION_CHEM_NAME";
         edtBR_Medication_Chem_Cycle_Internalname = sPrefix+"BR_MEDICATION_CHEM_CYCLE";
         edtBR_Medication_Chem_Line_Internalname = sPrefix+"BR_MEDICATION_CHEM_LINE";
         lblTextblockbr_medication_chem_detail_Internalname = sPrefix+"TEXTBLOCKBR_MEDICATION_CHEM_DETAIL";
         edtBR_Medication_Chem_Detail_Internalname = sPrefix+"BR_MEDICATION_CHEM_DETAIL";
         divUnnamedtablebr_medication_chem_detail_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICATION_CHEM_DETAIL";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_Medication_SchemeID_Internalname = sPrefix+"BR_MEDICATION_SCHEMEID";
         edtBR_MedicationID_Internalname = sPrefix+"BR_MEDICATIONID";
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
         edtBR_MedicationID_Jsonclick = "";
         edtBR_MedicationID_Visible = 1;
         edtBR_Medication_SchemeID_Jsonclick = "";
         edtBR_Medication_SchemeID_Visible = 1;
         edtBR_Medication_Chem_Detail_Jsonclick = "";
         edtBR_Medication_Chem_Detail_Enabled = 0;
         edtBR_Medication_Chem_Line_Jsonclick = "";
         edtBR_Medication_Chem_Line_Enabled = 0;
         edtBR_Medication_Chem_Cycle_Jsonclick = "";
         edtBR_Medication_Chem_Cycle_Enabled = 0;
         edtBR_Medication_Chem_Name_Jsonclick = "";
         edtBR_Medication_Chem_Name_Enabled = 0;
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
         A305BR_Medication_Chem_Name = "";
         A307BR_Medication_Chem_Line = "";
         lblTextblockbr_medication_chem_detail_Jsonclick = "";
         A313BR_Medication_Chem_Detail = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H00502_A296BR_Medication_SchemeID = new long[1] ;
         H00502_A119BR_MedicationID = new long[1] ;
         H00502_n119BR_MedicationID = new bool[] {false} ;
         H00502_A313BR_Medication_Chem_Detail = new String[] {""} ;
         H00502_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         H00502_A307BR_Medication_Chem_Line = new String[] {""} ;
         H00502_n307BR_Medication_Chem_Line = new bool[] {false} ;
         H00502_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         H00502_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         H00502_A305BR_Medication_Chem_Name = new String[] {""} ;
         H00502_n305BR_Medication_Chem_Name = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA296BR_Medication_SchemeID = "";
         sCtrlA119BR_MedicationID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_schemegeneral__default(),
            new Object[][] {
                new Object[] {
               H00502_A296BR_Medication_SchemeID, H00502_A119BR_MedicationID, H00502_n119BR_MedicationID, H00502_A313BR_Medication_Chem_Detail, H00502_n313BR_Medication_Chem_Detail, H00502_A307BR_Medication_Chem_Line, H00502_n307BR_Medication_Chem_Line, H00502_A306BR_Medication_Chem_Cycle, H00502_n306BR_Medication_Chem_Cycle, H00502_A305BR_Medication_Chem_Name,
               H00502_n305BR_Medication_Chem_Name
               }
            }
         );
         AV16Pgmname = "BR_Medication_SchemeGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "BR_Medication_SchemeGeneral";
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
      private int edtBR_Medication_Chem_Name_Enabled ;
      private int edtBR_Medication_Chem_Cycle_Enabled ;
      private int edtBR_Medication_Chem_Line_Enabled ;
      private int edtBR_Medication_Chem_Detail_Enabled ;
      private int edtBR_Medication_SchemeID_Visible ;
      private int edtBR_MedicationID_Visible ;
      private int idxLst ;
      private long A296BR_Medication_SchemeID ;
      private long A119BR_MedicationID ;
      private long wcpOA296BR_Medication_SchemeID ;
      private long wcpOA119BR_MedicationID ;
      private long AV8BR_Medication_SchemeID ;
      private long AV13BR_MedicationID ;
      private decimal A306BR_Medication_Chem_Cycle ;
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
      private String edtBR_Medication_Chem_Name_Internalname ;
      private String edtBR_Medication_Chem_Name_Jsonclick ;
      private String edtBR_Medication_Chem_Cycle_Internalname ;
      private String edtBR_Medication_Chem_Cycle_Jsonclick ;
      private String edtBR_Medication_Chem_Line_Internalname ;
      private String edtBR_Medication_Chem_Line_Jsonclick ;
      private String divUnnamedtablebr_medication_chem_detail_Internalname ;
      private String lblTextblockbr_medication_chem_detail_Internalname ;
      private String lblTextblockbr_medication_chem_detail_Jsonclick ;
      private String edtBR_Medication_Chem_Detail_Internalname ;
      private String edtBR_Medication_Chem_Detail_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Medication_SchemeID_Internalname ;
      private String edtBR_Medication_SchemeID_Jsonclick ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_MedicationID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA296BR_Medication_SchemeID ;
      private String sCtrlA119BR_MedicationID ;
      private bool entryPointCalled ;
      private bool n119BR_MedicationID ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n313BR_Medication_Chem_Detail ;
      private bool n307BR_Medication_Chem_Line ;
      private bool n306BR_Medication_Chem_Cycle ;
      private bool n305BR_Medication_Chem_Name ;
      private bool returnInSub ;
      private String A305BR_Medication_Chem_Name ;
      private String A307BR_Medication_Chem_Line ;
      private String A313BR_Medication_Chem_Detail ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H00502_A296BR_Medication_SchemeID ;
      private long[] H00502_A119BR_MedicationID ;
      private bool[] H00502_n119BR_MedicationID ;
      private String[] H00502_A313BR_Medication_Chem_Detail ;
      private bool[] H00502_n313BR_Medication_Chem_Detail ;
      private String[] H00502_A307BR_Medication_Chem_Line ;
      private bool[] H00502_n307BR_Medication_Chem_Line ;
      private decimal[] H00502_A306BR_Medication_Chem_Cycle ;
      private bool[] H00502_n306BR_Medication_Chem_Cycle ;
      private String[] H00502_A305BR_Medication_Chem_Name ;
      private bool[] H00502_n305BR_Medication_Chem_Name ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_medication_schemegeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00502 ;
          prmH00502 = new Object[] {
          new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00502", "SELECT [BR_Medication_SchemeID], [BR_MedicationID], [BR_Medication_Chem_Detail], [BR_Medication_Chem_Line], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Name] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE ([BR_Medication_SchemeID] = @BR_Medication_SchemeID) AND ([BR_MedicationID] = @BR_MedicationID) ORDER BY [BR_Medication_SchemeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00502,1,0,true,true )
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
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
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
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(2, (long)parms[2]);
                }
                return;
       }
    }

 }

}
