/*
               File: BR_Encounter_RefuseReasonGeneral
        Description: BR_Encounter_Refuse Reason General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:45.64
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
   public class br_encounter_refusereasongeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounter_refusereasongeneral( )
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

      public br_encounter_refusereasongeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Encounter_RefuseReasonID )
      {
         this.A348BR_Encounter_RefuseReasonID = aP0_BR_Encounter_RefuseReasonID;
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
         cmbBR_Encounter_RefuseReason_Status = new GXCombobox();
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
                  A348BR_Encounter_RefuseReasonID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A348BR_Encounter_RefuseReasonID});
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
            PA7F2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV18Pgmname = "BR_Encounter_RefuseReasonGeneral";
               context.Gx_err = 0;
               edtavBr_information_br_information_id_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_information_br_information_id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_information_br_information_id_Enabled), 5, 0)), true);
               WS7F2( ) ;
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
            context.SendWebValue( "BR_Encounter_Refuse Reason General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279384568", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounter_refusereasongeneral.aspx") + "?" + UrlEncode("" +A348BR_Encounter_RefuseReasonID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"Br_information", AV14BR_Information);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"Br_information", AV14BR_Information);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA348BR_Encounter_RefuseReasonID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm7F2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encounter_refusereasongeneral.js", "?20202279384570", false);
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
         return "BR_Encounter_RefuseReasonGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Encounter_Refuse Reason General" ;
      }

      protected void WB7F0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encounter_refusereasongeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_EncounterID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_EncounterID_Internalname, "就诊信息主键", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), ((edtBR_EncounterID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_EncounterID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_information_br_information_id_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_information_br_information_id_Internalname, "患者编号", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_information_br_information_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14BR_Information.gxTpr_Br_information_id), 18, 0, ".", "")), ((edtavBr_information_br_information_id_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14BR_Information.gxTpr_Br_information_id), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(AV14BR_Information.gxTpr_Br_information_id), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_information_br_information_id_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_information_br_information_id_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_RefuseReason_Reason_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_RefuseReason_Reason_Internalname, "初审不通过原因", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Encounter_RefuseReason_Reason_Internalname, A349BR_Encounter_RefuseReason_Reason, "", "", 0, 1, edtBR_Encounter_RefuseReason_Reason_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_RefuseReason_NoApproveDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname, "初审不通过时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_RefuseReason_NoApproveDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname, context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A350BR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_RefuseReason_NoApproveDate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "UpdDate", "right", false, "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Encounter_RefuseReason_NoApproveDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Encounter_RefuseReason_Status_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Encounter_RefuseReason_Status_Internalname, "初审不通过状态", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Encounter_RefuseReason_Status, cmbBR_Encounter_RefuseReason_Status_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)), 1, cmbBR_Encounter_RefuseReason_Status_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbBR_Encounter_RefuseReason_Status.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            cmbBR_Encounter_RefuseReason_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Values", (String)(cmbBR_Encounter_RefuseReason_Status.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_RefuseReason_FReason_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_RefuseReason_FReason_Internalname, "复审不通过原因", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Encounter_RefuseReason_FReason_Internalname, A355BR_Encounter_RefuseReason_FReason, "", "", 0, 1, edtBR_Encounter_RefuseReason_FReason_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_RefuseReason_FApproveDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_RefuseReason_FApproveDate_Internalname, "复审不通过时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_RefuseReason_FApproveDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_RefuseReason_FApproveDate_Internalname, context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A354BR_Encounter_RefuseReason_FApproveDate, "9999/99/99 99:99:99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_RefuseReason_FApproveDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_RefuseReason_FApproveDate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "UpdDate", "right", false, "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_RefuseReason_FApproveDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Encounter_RefuseReason_FApproveDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "修改", bttBtnupdate_Jsonclick, 7, "修改", "", StyleString, ClassString, bttBtnupdate_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e117f1_client"+"'", TempTags, "", 2, "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "删除", bttBtndelete_Jsonclick, 7, "删除", "", StyleString, ClassString, bttBtndelete_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e127f1_client"+"'", TempTags, "", 2, "HLP_BR_Encounter_RefuseReasonGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_RefuseReasonID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A348BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_RefuseReasonID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_RefuseReasonID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Encounter_RefuseReasonGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START7F2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Encounter_Refuse Reason General", 0) ;
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
               STRUP7F0( ) ;
            }
         }
      }

      protected void WS7F2( )
      {
         START7F2( ) ;
         EVT7F2( ) ;
      }

      protected void EVT7F2( )
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
                                 STRUP7F0( ) ;
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
                                 STRUP7F0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E137F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP7F0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E147F2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP7F0( ) ;
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
                                 STRUP7F0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavBr_information_br_information_id_Internalname;
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

      protected void WE7F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm7F2( ) ;
            }
         }
      }

      protected void PA7F2( )
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
               GX_FocusControl = edtavBr_information_br_information_id_Internalname;
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
         if ( cmbBR_Encounter_RefuseReason_Status.ItemCount > 0 )
         {
            A351BR_Encounter_RefuseReason_Status = (short)(NumberUtil.Val( cmbBR_Encounter_RefuseReason_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0))), "."));
            n351BR_Encounter_RefuseReason_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Encounter_RefuseReason_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Values", cmbBR_Encounter_RefuseReason_Status.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF7F2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV18Pgmname = "BR_Encounter_RefuseReasonGeneral";
         context.Gx_err = 0;
         edtavBr_information_br_information_id_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_information_br_information_id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_information_br_information_id_Enabled), 5, 0)), true);
      }

      protected void RF7F2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H007F2 */
            pr_default.execute(0, new Object[] {A348BR_Encounter_RefuseReasonID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A354BR_Encounter_RefuseReason_FApproveDate = H007F2_A354BR_Encounter_RefuseReason_FApproveDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A354BR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
               n354BR_Encounter_RefuseReason_FApproveDate = H007F2_n354BR_Encounter_RefuseReason_FApproveDate[0];
               A355BR_Encounter_RefuseReason_FReason = H007F2_A355BR_Encounter_RefuseReason_FReason[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A355BR_Encounter_RefuseReason_FReason", A355BR_Encounter_RefuseReason_FReason);
               n355BR_Encounter_RefuseReason_FReason = H007F2_n355BR_Encounter_RefuseReason_FReason[0];
               A351BR_Encounter_RefuseReason_Status = H007F2_A351BR_Encounter_RefuseReason_Status[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)));
               n351BR_Encounter_RefuseReason_Status = H007F2_n351BR_Encounter_RefuseReason_Status[0];
               A350BR_Encounter_RefuseReason_NoApproveDate = H007F2_A350BR_Encounter_RefuseReason_NoApproveDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A350BR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
               n350BR_Encounter_RefuseReason_NoApproveDate = H007F2_n350BR_Encounter_RefuseReason_NoApproveDate[0];
               A349BR_Encounter_RefuseReason_Reason = H007F2_A349BR_Encounter_RefuseReason_Reason[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A349BR_Encounter_RefuseReason_Reason", A349BR_Encounter_RefuseReason_Reason);
               n349BR_Encounter_RefuseReason_Reason = H007F2_n349BR_Encounter_RefuseReason_Reason[0];
               A19BR_EncounterID = H007F2_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               /* Execute user event: Load */
               E147F2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB7F0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes7F2( )
      {
      }

      protected void STRUP7F0( )
      {
         /* Before Start, stand alone formulas. */
         AV18Pgmname = "BR_Encounter_RefuseReasonGeneral";
         context.Gx_err = 0;
         edtavBr_information_br_information_id_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_information_br_information_id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_information_br_information_id_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E137F2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"Br_information"), AV14BR_Information);
            /* Read variables values. */
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_information_br_information_id_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_information_br_information_id_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_INFORMATION_BR_INFORMATION_ID");
               GX_FocusControl = edtavBr_information_br_information_id_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14BR_Information.gxTpr_Br_information_id = 0;
            }
            else
            {
               AV14BR_Information.gxTpr_Br_information_id = (long)(context.localUtil.CToN( cgiGet( edtavBr_information_br_information_id_Internalname), ".", ","));
            }
            A349BR_Encounter_RefuseReason_Reason = cgiGet( edtBR_Encounter_RefuseReason_Reason_Internalname);
            n349BR_Encounter_RefuseReason_Reason = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A349BR_Encounter_RefuseReason_Reason", A349BR_Encounter_RefuseReason_Reason);
            A350BR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_RefuseReason_NoApproveDate_Internalname));
            n350BR_Encounter_RefuseReason_NoApproveDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A350BR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
            cmbBR_Encounter_RefuseReason_Status.CurrentValue = cgiGet( cmbBR_Encounter_RefuseReason_Status_Internalname);
            A351BR_Encounter_RefuseReason_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_RefuseReason_Status_Internalname), "."));
            n351BR_Encounter_RefuseReason_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)));
            A355BR_Encounter_RefuseReason_FReason = cgiGet( edtBR_Encounter_RefuseReason_FReason_Internalname);
            n355BR_Encounter_RefuseReason_FReason = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A355BR_Encounter_RefuseReason_FReason", A355BR_Encounter_RefuseReason_FReason);
            A354BR_Encounter_RefuseReason_FApproveDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_RefuseReason_FApproveDate_Internalname));
            n354BR_Encounter_RefuseReason_FApproveDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A354BR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
            /* Read saved values. */
            wcpOA348BR_Encounter_RefuseReasonID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA348BR_Encounter_RefuseReasonID"), ".", ","));
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
         E137F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E137F2( )
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

      protected void E147F2( )
      {
         /* Load Routine */
         edtBR_Encounter_RefuseReasonID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_RefuseReasonID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReasonID_Visible), 5, 0)), true);
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_RefuteReason", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtnupdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtnupdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnupdate_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_RefuteReason", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtndelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtndelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtndelete_Visible), 5, 0)), true);
         }
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV18Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Encounter_RefuseReason";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_Encounter_RefuseReasonID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_Encounter_RefuseReasonID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A348BR_Encounter_RefuseReasonID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
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
         PA7F2( ) ;
         WS7F2( ) ;
         WE7F2( ) ;
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
         sCtrlA348BR_Encounter_RefuseReasonID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA7F2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encounter_refusereasongeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA7F2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A348BR_Encounter_RefuseReasonID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
         }
         wcpOA348BR_Encounter_RefuseReasonID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA348BR_Encounter_RefuseReasonID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A348BR_Encounter_RefuseReasonID != wcpOA348BR_Encounter_RefuseReasonID ) ) )
         {
            setjustcreated();
         }
         wcpOA348BR_Encounter_RefuseReasonID = A348BR_Encounter_RefuseReasonID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA348BR_Encounter_RefuseReasonID = cgiGet( sPrefix+"A348BR_Encounter_RefuseReasonID_CTRL");
         if ( StringUtil.Len( sCtrlA348BR_Encounter_RefuseReasonID) > 0 )
         {
            A348BR_Encounter_RefuseReasonID = (long)(context.localUtil.CToN( cgiGet( sCtrlA348BR_Encounter_RefuseReasonID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
         }
         else
         {
            A348BR_Encounter_RefuseReasonID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A348BR_Encounter_RefuseReasonID_PARM"), ".", ","));
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
         PA7F2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS7F2( ) ;
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
         WS7F2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A348BR_Encounter_RefuseReasonID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA348BR_Encounter_RefuseReasonID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A348BR_Encounter_RefuseReasonID_CTRL", StringUtil.RTrim( sCtrlA348BR_Encounter_RefuseReasonID));
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
         WE7F2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279384631", true);
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
         context.AddJavascriptSource("br_encounter_refusereasongeneral.js", "?20202279384631", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbBR_Encounter_RefuseReason_Status.Name = "BR_ENCOUNTER_REFUSEREASON_STATUS";
         cmbBR_Encounter_RefuseReason_Status.WebTags = "";
         cmbBR_Encounter_RefuseReason_Status.addItem("1", "未处理", 0);
         cmbBR_Encounter_RefuseReason_Status.addItem("2", "已处理", 0);
         if ( cmbBR_Encounter_RefuseReason_Status.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         edtavBr_information_br_information_id_Internalname = sPrefix+"BR_INFORMATION_BR_INFORMATION_ID";
         edtBR_Encounter_RefuseReason_Reason_Internalname = sPrefix+"BR_ENCOUNTER_REFUSEREASON_REASON";
         edtBR_Encounter_RefuseReason_NoApproveDate_Internalname = sPrefix+"BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE";
         cmbBR_Encounter_RefuseReason_Status_Internalname = sPrefix+"BR_ENCOUNTER_REFUSEREASON_STATUS";
         edtBR_Encounter_RefuseReason_FReason_Internalname = sPrefix+"BR_ENCOUNTER_REFUSEREASON_FREASON";
         edtBR_Encounter_RefuseReason_FApproveDate_Internalname = sPrefix+"BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_Encounter_RefuseReasonID_Internalname = sPrefix+"BR_ENCOUNTER_REFUSEREASONID";
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
         edtBR_Encounter_RefuseReasonID_Jsonclick = "";
         edtBR_Encounter_RefuseReasonID_Visible = 1;
         bttBtndelete_Visible = 1;
         bttBtnupdate_Visible = 1;
         edtBR_Encounter_RefuseReason_FApproveDate_Jsonclick = "";
         edtBR_Encounter_RefuseReason_FApproveDate_Enabled = 0;
         edtBR_Encounter_RefuseReason_FReason_Enabled = 0;
         cmbBR_Encounter_RefuseReason_Status_Jsonclick = "";
         cmbBR_Encounter_RefuseReason_Status.Enabled = 0;
         edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick = "";
         edtBR_Encounter_RefuseReason_NoApproveDate_Enabled = 0;
         edtBR_Encounter_RefuseReason_Reason_Enabled = 0;
         edtavBr_information_br_information_id_Jsonclick = "";
         edtavBr_information_br_information_id_Enabled = 0;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 0;
         edtavBr_information_br_information_id_Enabled = -1;
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
         setEventMetadata("'DOUPDATE'","{handler:'E117F1',iparms:[{av:'A348BR_Encounter_RefuseReasonID',fld:'BR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E127F1',iparms:[{av:'A348BR_Encounter_RefuseReasonID',fld:'BR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DODELETE'",",oparms:[]}");
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
         AV18Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV14BR_Information = new SdtBR_Information(context);
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         A349BR_Encounter_RefuseReason_Reason = "";
         A350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         A355BR_Encounter_RefuseReason_FReason = "";
         A354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         TempTags = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H007F2_A348BR_Encounter_RefuseReasonID = new long[1] ;
         H007F2_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         H007F2_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         H007F2_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         H007F2_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         H007F2_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         H007F2_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         H007F2_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         H007F2_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         H007F2_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         H007F2_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         H007F2_A19BR_EncounterID = new long[1] ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA348BR_Encounter_RefuseReasonID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounter_refusereasongeneral__default(),
            new Object[][] {
                new Object[] {
               H007F2_A348BR_Encounter_RefuseReasonID, H007F2_A354BR_Encounter_RefuseReason_FApproveDate, H007F2_n354BR_Encounter_RefuseReason_FApproveDate, H007F2_A355BR_Encounter_RefuseReason_FReason, H007F2_n355BR_Encounter_RefuseReason_FReason, H007F2_A351BR_Encounter_RefuseReason_Status, H007F2_n351BR_Encounter_RefuseReason_Status, H007F2_A350BR_Encounter_RefuseReason_NoApproveDate, H007F2_n350BR_Encounter_RefuseReason_NoApproveDate, H007F2_A349BR_Encounter_RefuseReason_Reason,
               H007F2_n349BR_Encounter_RefuseReason_Reason, H007F2_A19BR_EncounterID
               }
            }
         );
         AV18Pgmname = "BR_Encounter_RefuseReasonGeneral";
         /* GeneXus formulas. */
         AV18Pgmname = "BR_Encounter_RefuseReasonGeneral";
         context.Gx_err = 0;
         edtavBr_information_br_information_id_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short A351BR_Encounter_RefuseReason_Status ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavBr_information_br_information_id_Enabled ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Encounter_RefuseReason_Reason_Enabled ;
      private int edtBR_Encounter_RefuseReason_NoApproveDate_Enabled ;
      private int edtBR_Encounter_RefuseReason_FReason_Enabled ;
      private int edtBR_Encounter_RefuseReason_FApproveDate_Enabled ;
      private int bttBtnupdate_Visible ;
      private int bttBtndelete_Visible ;
      private int edtBR_Encounter_RefuseReasonID_Visible ;
      private int idxLst ;
      private long A348BR_Encounter_RefuseReasonID ;
      private long wcpOA348BR_Encounter_RefuseReasonID ;
      private long A19BR_EncounterID ;
      private long AV8BR_Encounter_RefuseReasonID ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV18Pgmname ;
      private String edtavBr_information_br_information_id_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtavBr_information_br_information_id_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_Reason_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Internalname ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick ;
      private String cmbBR_Encounter_RefuseReason_Status_Internalname ;
      private String cmbBR_Encounter_RefuseReason_Status_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_FReason_Internalname ;
      private String edtBR_Encounter_RefuseReason_FApproveDate_Internalname ;
      private String edtBR_Encounter_RefuseReason_FApproveDate_Jsonclick ;
      private String TempTags ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Encounter_RefuseReasonID_Internalname ;
      private String edtBR_Encounter_RefuseReasonID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA348BR_Encounter_RefuseReasonID ;
      private DateTime A350BR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n351BR_Encounter_RefuseReason_Status ;
      private bool gxdyncontrolsrefreshing ;
      private bool n354BR_Encounter_RefuseReason_FApproveDate ;
      private bool n355BR_Encounter_RefuseReason_FReason ;
      private bool n350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool n349BR_Encounter_RefuseReason_Reason ;
      private bool returnInSub ;
      private bool AV13TempBoolean ;
      private bool GXt_boolean1 ;
      private String A349BR_Encounter_RefuseReason_Reason ;
      private String A355BR_Encounter_RefuseReason_FReason ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Encounter_RefuseReason_Status ;
      private IDataStoreProvider pr_default ;
      private long[] H007F2_A348BR_Encounter_RefuseReasonID ;
      private DateTime[] H007F2_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] H007F2_n354BR_Encounter_RefuseReason_FApproveDate ;
      private String[] H007F2_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] H007F2_n355BR_Encounter_RefuseReason_FReason ;
      private short[] H007F2_A351BR_Encounter_RefuseReason_Status ;
      private bool[] H007F2_n351BR_Encounter_RefuseReason_Status ;
      private DateTime[] H007F2_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] H007F2_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private String[] H007F2_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] H007F2_n349BR_Encounter_RefuseReason_Reason ;
      private long[] H007F2_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
      private SdtBR_Information AV14BR_Information ;
   }

   public class br_encounter_refusereasongeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH007F2 ;
          prmH007F2 = new Object[] {
          new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H007F2", "SELECT [BR_Encounter_RefuseReasonID], [BR_Encounter_RefuseReason_FApproveDate], [BR_Encounter_RefuseReason_FReason], [BR_Encounter_RefuseReason_Status], [BR_Encounter_RefuseReason_NoApproveDate], [BR_Encounter_RefuseReason_Reason], [BR_EncounterID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK) WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID ORDER BY [BR_Encounter_RefuseReasonID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH007F2,1,0,true,true )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((long[]) buf[11])[0] = rslt.getLong(7) ;
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
