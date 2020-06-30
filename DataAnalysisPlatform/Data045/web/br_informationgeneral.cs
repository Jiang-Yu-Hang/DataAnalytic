/*
               File: BR_InformationGeneral
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:2.50
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
   public class br_informationgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_informationgeneral( )
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

      public br_informationgeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Information_ID )
      {
         this.A85BR_Information_ID = aP0_BR_Information_ID;
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
                  A85BR_Information_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A85BR_Information_ID});
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
            PA1I2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV25Pgmname = "BR_InformationGeneral";
               context.Gx_err = 0;
               edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_information_patientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled), 5, 0)), true);
               edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled), 5, 0)), true);
               edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled), 5, 0)), true);
               edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled), 5, 0)), true);
               WS1I2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020228159254", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_informationgeneral.aspx") + "?" + UrlEncode("" +A85BR_Information_ID)+"\">") ;
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
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"View_lastest_patient_info", AV16view_lastest_patient_info);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"View_lastest_patient_info", AV16view_lastest_patient_info);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA85BR_Information_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm1I2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_informationgeneral.js", "?2020228159256", false);
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
         return "BR_InformationGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB1I0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_informationgeneral.aspx");
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
            GxWebStd.gx_div_start( context, divUnnamedtableview_lastest_patient_info_view_lpi_br_information_patientno_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-5 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockview_lastest_patient_info_view_lpi_br_information_patientno_Internalname, "患者编号", "", "", lblTextblockview_lastest_patient_info_view_lpi_br_information_patientno_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_InformationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-7", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavView_lastest_patient_info_view_lpi_br_information_patientno_Internalname, "VIEW_LPI_BR_Information_Patient No", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavView_lastest_patient_info_view_lpi_br_information_patientno_Internalname, AV16view_lastest_patient_info.gxTpr_View_lpi_br_information_patientno, "", "", 0, 1, edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableview_lastest_patient_info_view_lpi_br_demographics_sex_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-5 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockview_lastest_patient_info_view_lpi_br_demographics_sex_Internalname, "性别", "", "", lblTextblockview_lastest_patient_info_view_lpi_br_demographics_sex_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_InformationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-7", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Internalname, "VIEW_LPI_BR_Demographics_Sex", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Internalname, AV16view_lastest_patient_info.gxTpr_View_lpi_br_demographics_sex, "", "", 0, 1, edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtableview_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-5 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockview_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname, "民族", "", "", lblTextblockview_lastest_patient_info_view_lpi_br_demographics_ethnic_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_InformationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-7", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname, "VIEW_LPI_BR_Demographics_Ethnic", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname, AV16view_lastest_patient_info.gxTpr_View_lpi_br_demographics_ethnic, "", "", 0, 1, edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableview_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-5 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockview_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname, "出生日期", "", "", lblTextblockview_lastest_patient_info_view_lpi_br_demographics_birthdate_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_InformationGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-7", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname, "VIEW_LPI_BR_Demographics_Birth Date", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname, context.localUtil.Format(AV16view_lastest_patient_info.gxTpr_View_lpi_br_demographics_birthdate, "9999/99/99"), context.localUtil.Format( AV16view_lastest_patient_info.gxTpr_View_lpi_br_demographics_birthdate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_InformationGeneral.htm");
            GxWebStd.gx_bitmap( context, edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_InformationGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_InformationGeneral.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavView_lastest_patient_info_view_lpi_br_information_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16view_lastest_patient_info.gxTpr_View_lpi_br_information_id), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV16view_lastest_patient_info.gxTpr_View_lpi_br_information_id), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavView_lastest_patient_info_view_lpi_br_information_id_Jsonclick, 0, "Attribute", "", "", "", "", edtavView_lastest_patient_info_view_lpi_br_information_id_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_InformationGeneral.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'" + sPrefix + "',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Internalname, context.localUtil.TToC( AV16view_lastest_patient_info.gxTpr_View_lpi_br_encounter_admitdate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV16view_lastest_patient_info.gxTpr_View_lpi_br_encounter_admitdate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Jsonclick, 0, "Attribute", "", "", "", "", edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Visible, 1, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_InformationGeneral.htm");
            GxWebStd.gx_bitmap( context, edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_InformationGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1I2( )
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
               STRUP1I0( ) ;
            }
         }
      }

      protected void WS1I2( )
      {
         START1I2( ) ;
         EVT1I2( ) ;
      }

      protected void EVT1I2( )
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
                                 STRUP1I0( ) ;
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
                                 STRUP1I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E111I2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E121I2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1I0( ) ;
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
                                 STRUP1I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavView_lastest_patient_info_view_lpi_br_information_patientno_Internalname;
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

      protected void WE1I2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1I2( ) ;
            }
         }
      }

      protected void PA1I2( )
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
               GX_FocusControl = edtavView_lastest_patient_info_view_lpi_br_information_patientno_Internalname;
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1I2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV25Pgmname = "BR_InformationGeneral";
         context.Gx_err = 0;
         edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_information_patientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled), 5, 0)), true);
         edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled), 5, 0)), true);
         edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled), 5, 0)), true);
         edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled), 5, 0)), true);
      }

      protected void RF1I2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H001I2 */
            pr_default.execute(0, new Object[] {A85BR_Information_ID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A36BR_Information_PatientNo = H001I2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H001I2_n36BR_Information_PatientNo[0];
               /* Execute user event: Load */
               E121I2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB1I0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1I2( )
      {
      }

      protected void STRUP1I0( )
      {
         /* Before Start, stand alone formulas. */
         AV25Pgmname = "BR_InformationGeneral";
         context.Gx_err = 0;
         edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_information_patientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled), 5, 0)), true);
         edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled), 5, 0)), true);
         edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled), 5, 0)), true);
         edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E111I2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"View_lastest_patient_info"), AV16view_lastest_patient_info);
            /* Read variables values. */
            AV16view_lastest_patient_info.gxTpr_View_lpi_br_information_patientno = cgiGet( edtavView_lastest_patient_info_view_lpi_br_information_patientno_Internalname);
            AV16view_lastest_patient_info.gxTpr_View_lpi_br_demographics_sex = cgiGet( edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Internalname);
            AV16view_lastest_patient_info.gxTpr_View_lpi_br_demographics_ethnic = cgiGet( edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname);
            if ( context.localUtil.VCDate( cgiGet( edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"VIEW_LPI_BR_Demographics_Birth Date"}), 1, "VIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE");
               GX_FocusControl = edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV16view_lastest_patient_info.gxTpr_View_lpi_br_demographics_birthdate = DateTime.MinValue;
            }
            else
            {
               AV16view_lastest_patient_info.gxTpr_View_lpi_br_demographics_birthdate = context.localUtil.CToD( cgiGet( edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname), 0);
            }
            A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
            n36BR_Information_PatientNo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavView_lastest_patient_info_view_lpi_br_information_id_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavView_lastest_patient_info_view_lpi_br_information_id_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_INFORMATION_ID");
               GX_FocusControl = edtavView_lastest_patient_info_view_lpi_br_information_id_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV16view_lastest_patient_info.gxTpr_View_lpi_br_information_id = 0;
            }
            else
            {
               AV16view_lastest_patient_info.gxTpr_View_lpi_br_information_id = (long)(context.localUtil.CToN( cgiGet( edtavView_lastest_patient_info_view_lpi_br_information_id_Internalname), ".", ","));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"VIEW_LPI_BR_Encounter_Admit Date"}), 1, "VIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_ENCOUNTER_ADMITDATE");
               GX_FocusControl = edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV16view_lastest_patient_info.gxTpr_View_lpi_br_encounter_admitdate = (DateTime)(DateTime.MinValue);
            }
            else
            {
               AV16view_lastest_patient_info.gxTpr_View_lpi_br_encounter_admitdate = context.localUtil.CToT( cgiGet( edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Internalname));
            }
            /* Read saved values. */
            wcpOA85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA85BR_Information_ID"), ".", ","));
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
         E111I2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E111I2( )
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
         AV16view_lastest_patient_info.Load(A85BR_Information_ID);
      }

      protected void nextLoad( )
      {
      }

      protected void E121I2( )
      {
         /* Load Routine */
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         edtavView_lastest_patient_info_view_lpi_br_information_id_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_information_id_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_information_id_Visible), 5, 0)), true);
         edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV25Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Information";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_Information_ID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A85BR_Information_ID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
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
         PA1I2( ) ;
         WS1I2( ) ;
         WE1I2( ) ;
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
         sCtrlA85BR_Information_ID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA1I2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_informationgeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA1I2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A85BR_Information_ID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         }
         wcpOA85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA85BR_Information_ID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A85BR_Information_ID != wcpOA85BR_Information_ID ) ) )
         {
            setjustcreated();
         }
         wcpOA85BR_Information_ID = A85BR_Information_ID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA85BR_Information_ID = cgiGet( sPrefix+"A85BR_Information_ID_CTRL");
         if ( StringUtil.Len( sCtrlA85BR_Information_ID) > 0 )
         {
            A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( sCtrlA85BR_Information_ID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         }
         else
         {
            A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A85BR_Information_ID_PARM"), ".", ","));
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
         PA1I2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS1I2( ) ;
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
         WS1I2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A85BR_Information_ID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA85BR_Information_ID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A85BR_Information_ID_CTRL", StringUtil.RTrim( sCtrlA85BR_Information_ID));
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
         WE1I2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815939", true);
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
            context.AddJavascriptSource("br_informationgeneral.js", "?202022815939", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockview_lastest_patient_info_view_lpi_br_information_patientno_Internalname = sPrefix+"TEXTBLOCKVIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_INFORMATION_PATIENTNO";
         edtavView_lastest_patient_info_view_lpi_br_information_patientno_Internalname = sPrefix+"VIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_INFORMATION_PATIENTNO";
         divUnnamedtableview_lastest_patient_info_view_lpi_br_information_patientno_Internalname = sPrefix+"UNNAMEDTABLEVIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_INFORMATION_PATIENTNO";
         lblTextblockview_lastest_patient_info_view_lpi_br_demographics_sex_Internalname = sPrefix+"TEXTBLOCKVIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_DEMOGRAPHICS_SEX";
         edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Internalname = sPrefix+"VIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_DEMOGRAPHICS_SEX";
         divUnnamedtableview_lastest_patient_info_view_lpi_br_demographics_sex_Internalname = sPrefix+"UNNAMEDTABLEVIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_DEMOGRAPHICS_SEX";
         lblTextblockview_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname = sPrefix+"TEXTBLOCKVIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
         edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname = sPrefix+"VIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
         divUnnamedtableview_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname = sPrefix+"UNNAMEDTABLEVIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
         lblTextblockview_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname = sPrefix+"TEXTBLOCKVIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname = sPrefix+"VIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         divUnnamedtableview_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname = sPrefix+"UNNAMEDTABLEVIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_Information_PatientNo_Internalname = sPrefix+"BR_INFORMATION_PATIENTNO";
         edtavView_lastest_patient_info_view_lpi_br_information_id_Internalname = sPrefix+"VIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_INFORMATION_ID";
         edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Internalname = sPrefix+"VIEW_LASTEST_PATIENT_INFO_VIEW_LPI_BR_ENCOUNTER_ADMITDATE";
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
         edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Jsonclick = "";
         edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Visible = 1;
         edtavView_lastest_patient_info_view_lpi_br_information_id_Jsonclick = "";
         edtavView_lastest_patient_info_view_lpi_br_information_id_Visible = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Visible = 1;
         edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Jsonclick = "";
         edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled = 0;
         edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled = 0;
         edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled = 0;
         edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled = 0;
         edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled = -1;
         edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled = -1;
         edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled = -1;
         edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled = -1;
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
         AV25Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV16view_lastest_patient_info = new Sdtview_lastest_patient_info(context);
         GX_FocusControl = "";
         lblTextblockview_lastest_patient_info_view_lpi_br_information_patientno_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         lblTextblockview_lastest_patient_info_view_lpi_br_demographics_sex_Jsonclick = "";
         lblTextblockview_lastest_patient_info_view_lpi_br_demographics_ethnic_Jsonclick = "";
         lblTextblockview_lastest_patient_info_view_lpi_br_demographics_birthdate_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         TempTags = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H001I2_A85BR_Information_ID = new long[1] ;
         H001I2_A36BR_Information_PatientNo = new String[] {""} ;
         H001I2_n36BR_Information_PatientNo = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA85BR_Information_ID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_informationgeneral__default(),
            new Object[][] {
                new Object[] {
               H001I2_A85BR_Information_ID, H001I2_A36BR_Information_PatientNo, H001I2_n36BR_Information_PatientNo
               }
            }
         );
         AV25Pgmname = "BR_InformationGeneral";
         /* GeneXus formulas. */
         AV25Pgmname = "BR_InformationGeneral";
         context.Gx_err = 0;
         edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled = 0;
         edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled = 0;
         edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled = 0;
         edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled = 0;
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
      private int edtavView_lastest_patient_info_view_lpi_br_information_patientno_Enabled ;
      private int edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Enabled ;
      private int edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Enabled ;
      private int edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Enabled ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtavView_lastest_patient_info_view_lpi_br_information_id_Visible ;
      private int edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Visible ;
      private int idxLst ;
      private long A85BR_Information_ID ;
      private long wcpOA85BR_Information_ID ;
      private long AV8BR_Information_ID ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV25Pgmname ;
      private String edtavView_lastest_patient_info_view_lpi_br_information_patientno_Internalname ;
      private String edtavView_lastest_patient_info_view_lpi_br_demographics_sex_Internalname ;
      private String edtavView_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname ;
      private String edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String divUnnamedtableview_lastest_patient_info_view_lpi_br_information_patientno_Internalname ;
      private String lblTextblockview_lastest_patient_info_view_lpi_br_information_patientno_Internalname ;
      private String lblTextblockview_lastest_patient_info_view_lpi_br_information_patientno_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divUnnamedtableview_lastest_patient_info_view_lpi_br_demographics_sex_Internalname ;
      private String lblTextblockview_lastest_patient_info_view_lpi_br_demographics_sex_Internalname ;
      private String lblTextblockview_lastest_patient_info_view_lpi_br_demographics_sex_Jsonclick ;
      private String divUnnamedtableview_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname ;
      private String lblTextblockview_lastest_patient_info_view_lpi_br_demographics_ethnic_Internalname ;
      private String lblTextblockview_lastest_patient_info_view_lpi_br_demographics_ethnic_Jsonclick ;
      private String divUnnamedtableview_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname ;
      private String lblTextblockview_lastest_patient_info_view_lpi_br_demographics_birthdate_Internalname ;
      private String lblTextblockview_lastest_patient_info_view_lpi_br_demographics_birthdate_Jsonclick ;
      private String edtavView_lastest_patient_info_view_lpi_br_demographics_birthdate_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String TempTags ;
      private String edtavView_lastest_patient_info_view_lpi_br_information_id_Internalname ;
      private String edtavView_lastest_patient_info_view_lpi_br_information_id_Jsonclick ;
      private String edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Internalname ;
      private String edtavView_lastest_patient_info_view_lpi_br_encounter_admitdate_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA85BR_Information_ID ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n36BR_Information_PatientNo ;
      private bool returnInSub ;
      private String A36BR_Information_PatientNo ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H001I2_A85BR_Information_ID ;
      private String[] H001I2_A36BR_Information_PatientNo ;
      private bool[] H001I2_n36BR_Information_PatientNo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private Sdtview_lastest_patient_info AV16view_lastest_patient_info ;
   }

   public class br_informationgeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001I2 ;
          prmH001I2 = new Object[] {
          new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001I2", "SELECT [BR_Information_ID], [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ORDER BY [BR_Information_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001I2,1,0,true,true )
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
