/*
               File: BR_ProcedureGeneral
        Description: BR_Procedure General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:57:43.80
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
   public class br_proceduregeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_proceduregeneral( )
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

      public br_proceduregeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_ProcedureID )
      {
         this.A139BR_ProcedureID = aP0_BR_ProcedureID;
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
         cmbBR_Procedure_PXSurgery = new GXCombobox();
         cmbBR_Procedure_PXRadiotherapy = new GXCombobox();
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
                  A139BR_ProcedureID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A139BR_ProcedureID});
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
            PA3Q2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV17Pgmname = "BR_ProcedureGeneral";
               context.Gx_err = 0;
               WS3Q2( ) ;
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
            context.SendWebValue( "BR_Procedure General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711574384", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_proceduregeneral.aspx") + "?" + UrlEncode("" +A139BR_ProcedureID)+"\">") ;
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
         forbiddenHiddens = sPrefix + "hsh" + "BR_ProcedureGeneral";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A141BR_Procedure_PXSurgery, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A143BR_Procedure_PXRadiotherapy, ""));
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_proceduregeneral:[SendSecurityCheck value for]"+"BR_Procedure_PXSurgery:"+StringUtil.RTrim( context.localUtil.Format( A141BR_Procedure_PXSurgery, "")));
         GXUtil.WriteLog("br_proceduregeneral:[SendSecurityCheck value for]"+"BR_Procedure_PXRadiotherapy:"+StringUtil.RTrim( context.localUtil.Format( A143BR_Procedure_PXRadiotherapy, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA139BR_ProcedureID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA139BR_ProcedureID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm3Q2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_proceduregeneral.js", "?202022711574386", false);
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
         return "BR_ProcedureGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Procedure General" ;
      }

      protected void WB3Q0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_proceduregeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_pxsurgery_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_pxsurgery_Internalname, "是否手术", "", "", lblTextblockbr_procedure_pxsurgery_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_ProcedureGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Procedure_PXSurgery_Internalname, "是否手术", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Procedure_PXSurgery, cmbBR_Procedure_PXSurgery_Internalname, StringUtil.RTrim( A141BR_Procedure_PXSurgery), 1, cmbBR_Procedure_PXSurgery_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Procedure_PXSurgery.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_ProcedureGeneral.htm");
            cmbBR_Procedure_PXSurgery.CurrentValue = StringUtil.RTrim( A141BR_Procedure_PXSurgery);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Procedure_PXSurgery_Internalname, "Values", (String)(cmbBR_Procedure_PXSurgery.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, divUnnamedtable1_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_date_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_date_Internalname, "手术日期", "", "", lblTextblockbr_procedure_date_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_ProcedureGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Procedure_Date_Internalname, "手术日期", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Procedure_Date_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Procedure_Date_Internalname, context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"), context.localUtil.Format( A266BR_Procedure_Date, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Procedure_Date_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Procedure_Date_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_ProcedureGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Procedure_Date_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Procedure_Date_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_pxradiotherapy_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_pxradiotherapy_Internalname, "是否接受放射疗法", "", "", lblTextblockbr_procedure_pxradiotherapy_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_ProcedureGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Procedure_PXRadiotherapy_Internalname, "是否接受放射疗法", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Procedure_PXRadiotherapy, cmbBR_Procedure_PXRadiotherapy_Internalname, StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy), 1, cmbBR_Procedure_PXRadiotherapy_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Procedure_PXRadiotherapy.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_ProcedureGeneral.htm");
            cmbBR_Procedure_PXRadiotherapy.CurrentValue = StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Values", (String)(cmbBR_Procedure_PXRadiotherapy.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable2_Internalname, divUnnamedtable2_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_radiodate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_radiodate_Internalname, "放疗日期", "", "", lblTextblockbr_procedure_radiodate_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_ProcedureGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Procedure_RadioDate_Internalname, "放疗日期", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Procedure_RadioDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Procedure_RadioDate_Internalname, context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"), context.localUtil.Format( A268BR_Procedure_RadioDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Procedure_RadioDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Procedure_RadioDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_ProcedureGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Procedure_RadioDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Procedure_RadioDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_radiotime_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_radiotime_Internalname, "放疗疗程", "", "", lblTextblockbr_procedure_radiotime_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_ProcedureGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Procedure_RadioTime_Internalname, "放疗疗程", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Procedure_RadioTime_Internalname, StringUtil.LTrim( StringUtil.NToC( A269BR_Procedure_RadioTime, 15, 5, ".", "")), ((edtBR_Procedure_RadioTime_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A269BR_Procedure_RadioTime, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A269BR_Procedure_RadioTime, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Procedure_RadioTime_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Procedure_RadioTime_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_ProcedureGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_ProcedureID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_ProcedureID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_ProcedureID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_ProcedureGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_ProcedureGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_ProcedureGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START3Q2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Procedure General", 0) ;
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
               STRUP3Q0( ) ;
            }
         }
      }

      protected void WS3Q2( )
      {
         START3Q2( ) ;
         EVT3Q2( ) ;
      }

      protected void EVT3Q2( )
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
                                 STRUP3Q0( ) ;
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
                                 STRUP3Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E113Q2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E123Q2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3Q0( ) ;
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
                                 STRUP3Q0( ) ;
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

      protected void WE3Q2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3Q2( ) ;
            }
         }
      }

      protected void PA3Q2( )
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
         if ( cmbBR_Procedure_PXSurgery.ItemCount > 0 )
         {
            A141BR_Procedure_PXSurgery = cmbBR_Procedure_PXSurgery.getValidValue(A141BR_Procedure_PXSurgery);
            n141BR_Procedure_PXSurgery = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Procedure_PXSurgery.CurrentValue = StringUtil.RTrim( A141BR_Procedure_PXSurgery);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Procedure_PXSurgery_Internalname, "Values", cmbBR_Procedure_PXSurgery.ToJavascriptSource(), true);
         }
         if ( cmbBR_Procedure_PXRadiotherapy.ItemCount > 0 )
         {
            A143BR_Procedure_PXRadiotherapy = cmbBR_Procedure_PXRadiotherapy.getValidValue(A143BR_Procedure_PXRadiotherapy);
            n143BR_Procedure_PXRadiotherapy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Procedure_PXRadiotherapy.CurrentValue = StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Values", cmbBR_Procedure_PXRadiotherapy.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF3Q2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV17Pgmname = "BR_ProcedureGeneral";
         context.Gx_err = 0;
      }

      protected void RF3Q2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H003Q2 */
            pr_default.execute(0, new Object[] {A139BR_ProcedureID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A85BR_Information_ID = H003Q2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003Q2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H003Q2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H003Q2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H003Q2_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               n19BR_EncounterID = H003Q2_n19BR_EncounterID[0];
               A269BR_Procedure_RadioTime = H003Q2_A269BR_Procedure_RadioTime[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
               n269BR_Procedure_RadioTime = H003Q2_n269BR_Procedure_RadioTime[0];
               A268BR_Procedure_RadioDate = H003Q2_A268BR_Procedure_RadioDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
               n268BR_Procedure_RadioDate = H003Q2_n268BR_Procedure_RadioDate[0];
               A143BR_Procedure_PXRadiotherapy = H003Q2_A143BR_Procedure_PXRadiotherapy[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
               n143BR_Procedure_PXRadiotherapy = H003Q2_n143BR_Procedure_PXRadiotherapy[0];
               A266BR_Procedure_Date = H003Q2_A266BR_Procedure_Date[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
               n266BR_Procedure_Date = H003Q2_n266BR_Procedure_Date[0];
               A141BR_Procedure_PXSurgery = H003Q2_A141BR_Procedure_PXSurgery[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
               n141BR_Procedure_PXSurgery = H003Q2_n141BR_Procedure_PXSurgery[0];
               A85BR_Information_ID = H003Q2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003Q2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H003Q2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H003Q2_n36BR_Information_PatientNo[0];
               /* Execute user event: Load */
               E123Q2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB3Q0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes3Q2( )
      {
      }

      protected void STRUP3Q0( )
      {
         /* Before Start, stand alone formulas. */
         AV17Pgmname = "BR_ProcedureGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E113Q2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbBR_Procedure_PXSurgery.CurrentValue = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
            A141BR_Procedure_PXSurgery = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
            n141BR_Procedure_PXSurgery = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
            A266BR_Procedure_Date = context.localUtil.CToD( cgiGet( edtBR_Procedure_Date_Internalname), 0);
            n266BR_Procedure_Date = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
            cmbBR_Procedure_PXRadiotherapy.CurrentValue = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
            A143BR_Procedure_PXRadiotherapy = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
            n143BR_Procedure_PXRadiotherapy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
            A268BR_Procedure_RadioDate = context.localUtil.CToD( cgiGet( edtBR_Procedure_RadioDate_Internalname), 0);
            n268BR_Procedure_RadioDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
            A269BR_Procedure_RadioTime = context.localUtil.CToN( cgiGet( edtBR_Procedure_RadioTime_Internalname), ".", ",");
            n269BR_Procedure_RadioTime = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            n19BR_EncounterID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
            n36BR_Information_PatientNo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            /* Read saved values. */
            wcpOA139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA139BR_ProcedureID"), ".", ","));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = sPrefix + "hsh" + "BR_ProcedureGeneral";
            A141BR_Procedure_PXSurgery = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
            n141BR_Procedure_PXSurgery = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A141BR_Procedure_PXSurgery, ""));
            A143BR_Procedure_PXRadiotherapy = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
            n143BR_Procedure_PXRadiotherapy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A143BR_Procedure_PXRadiotherapy, ""));
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("br_proceduregeneral:[SecurityCheckFailed value for]"+"BR_Procedure_PXSurgery:"+StringUtil.RTrim( context.localUtil.Format( A141BR_Procedure_PXSurgery, "")));
               GXUtil.WriteLog("br_proceduregeneral:[SecurityCheckFailed value for]"+"BR_Procedure_PXRadiotherapy:"+StringUtil.RTrim( context.localUtil.Format( A143BR_Procedure_PXRadiotherapy, "")));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
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
         E113Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E113Q2( )
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

      protected void E123Q2( )
      {
         /* Load Routine */
         edtBR_ProcedureID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_ProcedureID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_ProcedureID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         divUnnamedtable1_Visible = (((StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "是")==0)) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divUnnamedtable1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable1_Visible), 5, 0)), true);
         divUnnamedtable2_Visible = (((StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "是")==0)) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divUnnamedtable2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable2_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV17Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Procedure";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_ProcedureID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_ProcedureID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A139BR_ProcedureID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
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
         PA3Q2( ) ;
         WS3Q2( ) ;
         WE3Q2( ) ;
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
         sCtrlA139BR_ProcedureID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA3Q2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_proceduregeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA3Q2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A139BR_ProcedureID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
         }
         wcpOA139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA139BR_ProcedureID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A139BR_ProcedureID != wcpOA139BR_ProcedureID ) ) )
         {
            setjustcreated();
         }
         wcpOA139BR_ProcedureID = A139BR_ProcedureID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA139BR_ProcedureID = cgiGet( sPrefix+"A139BR_ProcedureID_CTRL");
         if ( StringUtil.Len( sCtrlA139BR_ProcedureID) > 0 )
         {
            A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( sCtrlA139BR_ProcedureID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
         }
         else
         {
            A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A139BR_ProcedureID_PARM"), ".", ","));
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
         PA3Q2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS3Q2( ) ;
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
         WS3Q2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A139BR_ProcedureID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA139BR_ProcedureID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A139BR_ProcedureID_CTRL", StringUtil.RTrim( sCtrlA139BR_ProcedureID));
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
         WE3Q2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711574451", true);
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
            context.AddJavascriptSource("br_proceduregeneral.js", "?202022711574451", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbBR_Procedure_PXSurgery.Name = "BR_PROCEDURE_PXSURGERY";
         cmbBR_Procedure_PXSurgery.WebTags = "";
         cmbBR_Procedure_PXSurgery.addItem("否", "否", 0);
         cmbBR_Procedure_PXSurgery.addItem("是", "是", 0);
         cmbBR_Procedure_PXSurgery.addItem("不详", "不详", 0);
         if ( cmbBR_Procedure_PXSurgery.ItemCount > 0 )
         {
         }
         cmbBR_Procedure_PXRadiotherapy.Name = "BR_PROCEDURE_PXRADIOTHERAPY";
         cmbBR_Procedure_PXRadiotherapy.WebTags = "";
         cmbBR_Procedure_PXRadiotherapy.addItem("否", "否", 0);
         cmbBR_Procedure_PXRadiotherapy.addItem("是", "是", 0);
         cmbBR_Procedure_PXRadiotherapy.addItem("不详", "不详", 0);
         if ( cmbBR_Procedure_PXRadiotherapy.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_procedure_pxsurgery_Internalname = sPrefix+"TEXTBLOCKBR_PROCEDURE_PXSURGERY";
         cmbBR_Procedure_PXSurgery_Internalname = sPrefix+"BR_PROCEDURE_PXSURGERY";
         divUnnamedtablebr_procedure_pxsurgery_Internalname = sPrefix+"UNNAMEDTABLEBR_PROCEDURE_PXSURGERY";
         lblTextblockbr_procedure_date_Internalname = sPrefix+"TEXTBLOCKBR_PROCEDURE_DATE";
         edtBR_Procedure_Date_Internalname = sPrefix+"BR_PROCEDURE_DATE";
         divUnnamedtablebr_procedure_date_Internalname = sPrefix+"UNNAMEDTABLEBR_PROCEDURE_DATE";
         divUnnamedtable1_Internalname = sPrefix+"UNNAMEDTABLE1";
         lblTextblockbr_procedure_pxradiotherapy_Internalname = sPrefix+"TEXTBLOCKBR_PROCEDURE_PXRADIOTHERAPY";
         cmbBR_Procedure_PXRadiotherapy_Internalname = sPrefix+"BR_PROCEDURE_PXRADIOTHERAPY";
         divUnnamedtablebr_procedure_pxradiotherapy_Internalname = sPrefix+"UNNAMEDTABLEBR_PROCEDURE_PXRADIOTHERAPY";
         lblTextblockbr_procedure_radiodate_Internalname = sPrefix+"TEXTBLOCKBR_PROCEDURE_RADIODATE";
         edtBR_Procedure_RadioDate_Internalname = sPrefix+"BR_PROCEDURE_RADIODATE";
         divUnnamedtablebr_procedure_radiodate_Internalname = sPrefix+"UNNAMEDTABLEBR_PROCEDURE_RADIODATE";
         lblTextblockbr_procedure_radiotime_Internalname = sPrefix+"TEXTBLOCKBR_PROCEDURE_RADIOTIME";
         edtBR_Procedure_RadioTime_Internalname = sPrefix+"BR_PROCEDURE_RADIOTIME";
         divUnnamedtablebr_procedure_radiotime_Internalname = sPrefix+"UNNAMEDTABLEBR_PROCEDURE_RADIOTIME";
         divUnnamedtable2_Internalname = sPrefix+"UNNAMEDTABLE2";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_ProcedureID_Internalname = sPrefix+"BR_PROCEDUREID";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = sPrefix+"BR_INFORMATION_PATIENTNO";
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
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtBR_ProcedureID_Jsonclick = "";
         edtBR_ProcedureID_Visible = 1;
         edtBR_Procedure_RadioTime_Jsonclick = "";
         edtBR_Procedure_RadioTime_Enabled = 0;
         edtBR_Procedure_RadioDate_Jsonclick = "";
         edtBR_Procedure_RadioDate_Enabled = 0;
         divUnnamedtable2_Visible = 1;
         cmbBR_Procedure_PXRadiotherapy_Jsonclick = "";
         cmbBR_Procedure_PXRadiotherapy.Enabled = 0;
         edtBR_Procedure_Date_Jsonclick = "";
         edtBR_Procedure_Date_Enabled = 0;
         divUnnamedtable1_Visible = 1;
         cmbBR_Procedure_PXSurgery_Jsonclick = "";
         cmbBR_Procedure_PXSurgery.Enabled = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'cmbBR_Procedure_PXSurgery'},{av:'A141BR_Procedure_PXSurgery',fld:'BR_PROCEDURE_PXSURGERY',pic:''},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'A143BR_Procedure_PXRadiotherapy',fld:'BR_PROCEDURE_PXRADIOTHERAPY',pic:''}]");
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
         AV17Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         forbiddenHiddens = "";
         A141BR_Procedure_PXSurgery = "";
         A143BR_Procedure_PXRadiotherapy = "";
         GX_FocusControl = "";
         lblTextblockbr_procedure_pxsurgery_Jsonclick = "";
         lblTextblockbr_procedure_date_Jsonclick = "";
         A266BR_Procedure_Date = DateTime.MinValue;
         lblTextblockbr_procedure_pxradiotherapy_Jsonclick = "";
         lblTextblockbr_procedure_radiodate_Jsonclick = "";
         A268BR_Procedure_RadioDate = DateTime.MinValue;
         lblTextblockbr_procedure_radiotime_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H003Q2_A85BR_Information_ID = new long[1] ;
         H003Q2_n85BR_Information_ID = new bool[] {false} ;
         H003Q2_A139BR_ProcedureID = new long[1] ;
         H003Q2_A36BR_Information_PatientNo = new String[] {""} ;
         H003Q2_n36BR_Information_PatientNo = new bool[] {false} ;
         H003Q2_A19BR_EncounterID = new long[1] ;
         H003Q2_n19BR_EncounterID = new bool[] {false} ;
         H003Q2_A269BR_Procedure_RadioTime = new decimal[1] ;
         H003Q2_n269BR_Procedure_RadioTime = new bool[] {false} ;
         H003Q2_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         H003Q2_n268BR_Procedure_RadioDate = new bool[] {false} ;
         H003Q2_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         H003Q2_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         H003Q2_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         H003Q2_n266BR_Procedure_Date = new bool[] {false} ;
         H003Q2_A141BR_Procedure_PXSurgery = new String[] {""} ;
         H003Q2_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         hsh = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA139BR_ProcedureID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_proceduregeneral__default(),
            new Object[][] {
                new Object[] {
               H003Q2_A85BR_Information_ID, H003Q2_n85BR_Information_ID, H003Q2_A139BR_ProcedureID, H003Q2_A36BR_Information_PatientNo, H003Q2_n36BR_Information_PatientNo, H003Q2_A19BR_EncounterID, H003Q2_n19BR_EncounterID, H003Q2_A269BR_Procedure_RadioTime, H003Q2_n269BR_Procedure_RadioTime, H003Q2_A268BR_Procedure_RadioDate,
               H003Q2_n268BR_Procedure_RadioDate, H003Q2_A143BR_Procedure_PXRadiotherapy, H003Q2_n143BR_Procedure_PXRadiotherapy, H003Q2_A266BR_Procedure_Date, H003Q2_n266BR_Procedure_Date, H003Q2_A141BR_Procedure_PXSurgery, H003Q2_n141BR_Procedure_PXSurgery
               }
            }
         );
         AV17Pgmname = "BR_ProcedureGeneral";
         /* GeneXus formulas. */
         AV17Pgmname = "BR_ProcedureGeneral";
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
      private int divUnnamedtable1_Visible ;
      private int edtBR_Procedure_Date_Enabled ;
      private int divUnnamedtable2_Visible ;
      private int edtBR_Procedure_RadioDate_Enabled ;
      private int edtBR_Procedure_RadioTime_Enabled ;
      private int edtBR_ProcedureID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_Information_PatientNo_Visible ;
      private int idxLst ;
      private long A139BR_ProcedureID ;
      private long wcpOA139BR_ProcedureID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV8BR_ProcedureID ;
      private decimal A269BR_Procedure_RadioTime ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV17Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String divUnnamedtablebr_procedure_pxsurgery_Internalname ;
      private String lblTextblockbr_procedure_pxsurgery_Internalname ;
      private String lblTextblockbr_procedure_pxsurgery_Jsonclick ;
      private String cmbBR_Procedure_PXSurgery_Internalname ;
      private String cmbBR_Procedure_PXSurgery_Jsonclick ;
      private String divUnnamedtable1_Internalname ;
      private String divUnnamedtablebr_procedure_date_Internalname ;
      private String lblTextblockbr_procedure_date_Internalname ;
      private String lblTextblockbr_procedure_date_Jsonclick ;
      private String edtBR_Procedure_Date_Internalname ;
      private String edtBR_Procedure_Date_Jsonclick ;
      private String divUnnamedtablebr_procedure_pxradiotherapy_Internalname ;
      private String lblTextblockbr_procedure_pxradiotherapy_Internalname ;
      private String lblTextblockbr_procedure_pxradiotherapy_Jsonclick ;
      private String cmbBR_Procedure_PXRadiotherapy_Internalname ;
      private String cmbBR_Procedure_PXRadiotherapy_Jsonclick ;
      private String divUnnamedtable2_Internalname ;
      private String divUnnamedtablebr_procedure_radiodate_Internalname ;
      private String lblTextblockbr_procedure_radiodate_Internalname ;
      private String lblTextblockbr_procedure_radiodate_Jsonclick ;
      private String edtBR_Procedure_RadioDate_Internalname ;
      private String edtBR_Procedure_RadioDate_Jsonclick ;
      private String divUnnamedtablebr_procedure_radiotime_Internalname ;
      private String lblTextblockbr_procedure_radiotime_Internalname ;
      private String lblTextblockbr_procedure_radiotime_Jsonclick ;
      private String edtBR_Procedure_RadioTime_Internalname ;
      private String edtBR_Procedure_RadioTime_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_ProcedureID_Internalname ;
      private String edtBR_ProcedureID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String hsh ;
      private String sCtrlA139BR_ProcedureID ;
      private DateTime A266BR_Procedure_Date ;
      private DateTime A268BR_Procedure_RadioDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n141BR_Procedure_PXSurgery ;
      private bool n143BR_Procedure_PXRadiotherapy ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n19BR_EncounterID ;
      private bool n269BR_Procedure_RadioTime ;
      private bool n268BR_Procedure_RadioDate ;
      private bool n266BR_Procedure_Date ;
      private bool returnInSub ;
      private String A141BR_Procedure_PXSurgery ;
      private String A143BR_Procedure_PXRadiotherapy ;
      private String A36BR_Information_PatientNo ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Procedure_PXSurgery ;
      private GXCombobox cmbBR_Procedure_PXRadiotherapy ;
      private IDataStoreProvider pr_default ;
      private long[] H003Q2_A85BR_Information_ID ;
      private bool[] H003Q2_n85BR_Information_ID ;
      private long[] H003Q2_A139BR_ProcedureID ;
      private String[] H003Q2_A36BR_Information_PatientNo ;
      private bool[] H003Q2_n36BR_Information_PatientNo ;
      private long[] H003Q2_A19BR_EncounterID ;
      private bool[] H003Q2_n19BR_EncounterID ;
      private decimal[] H003Q2_A269BR_Procedure_RadioTime ;
      private bool[] H003Q2_n269BR_Procedure_RadioTime ;
      private DateTime[] H003Q2_A268BR_Procedure_RadioDate ;
      private bool[] H003Q2_n268BR_Procedure_RadioDate ;
      private String[] H003Q2_A143BR_Procedure_PXRadiotherapy ;
      private bool[] H003Q2_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] H003Q2_A266BR_Procedure_Date ;
      private bool[] H003Q2_n266BR_Procedure_Date ;
      private String[] H003Q2_A141BR_Procedure_PXSurgery ;
      private bool[] H003Q2_n141BR_Procedure_PXSurgery ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_proceduregeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH003Q2 ;
          prmH003Q2 = new Object[] {
          new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003Q2", "SELECT T2.[BR_Information_ID], T1.[BR_ProcedureID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Procedure_RadioTime], T1.[BR_Procedure_RadioDate], T1.[BR_Procedure_PXRadiotherapy], T1.[BR_Procedure_Date], T1.[BR_Procedure_PXSurgery] FROM (([BR_Procedure] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE T1.[BR_ProcedureID] = @BR_ProcedureID ORDER BY T1.[BR_ProcedureID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003Q2,1,0,true,true )
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
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
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
