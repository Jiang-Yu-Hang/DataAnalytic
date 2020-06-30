/*
               File: WWPBaseObjects.SecFunctionalityGeneral
        Description: Sec Functionality General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:41.74
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class secfunctionalitygeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public secfunctionalitygeneral( )
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

      public secfunctionalitygeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_SecFunctionalityId )
      {
         this.A1SecFunctionalityId = aP0_SecFunctionalityId;
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
         cmbSecFunctionalityType = new GXCombobox();
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
                  A1SecFunctionalityId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A1SecFunctionalityId});
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
            PA0R2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV19Pgmname = "WWPBaseObjects.SecFunctionalityGeneral";
               context.Gx_err = 0;
               WS0R2( ) ;
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
            context.SendWebValue( "Sec Functionality General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279354179", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secfunctionalitygeneral.aspx") + "?" + UrlEncode("" +A1SecFunctionalityId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA1SecFunctionalityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA1SecFunctionalityId), 10, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm0R2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("wwpbaseobjects/secfunctionalitygeneral.js", "?20202279354182", false);
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
         return "WWPBaseObjects.SecFunctionalityGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Sec Functionality General" ;
      }

      protected void WB0R0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wwpbaseobjects.secfunctionalitygeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSecFunctionalityKey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecFunctionalityKey_Internalname, "名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecFunctionalityKey_Internalname, A3SecFunctionalityKey, StringUtil.RTrim( context.localUtil.Format( A3SecFunctionalityKey, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecFunctionalityKey_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtSecFunctionalityKey_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalityGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSecFunctionalityDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecFunctionalityDescription_Internalname, "描述", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecFunctionalityDescription_Internalname, A8SecFunctionalityDescription, StringUtil.RTrim( context.localUtil.Format( A8SecFunctionalityDescription, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecFunctionalityDescription_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtSecFunctionalityDescription_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalityGeneral.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "修改", bttBtnupdate_Jsonclick, 7, "修改", "", StyleString, ClassString, bttBtnupdate_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e110r1_client"+"'", TempTags, "", 2, "HLP_WWPBaseObjects\\SecFunctionalityGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "删除", bttBtndelete_Jsonclick, 7, "删除", "", StyleString, ClassString, bttBtndelete_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e120r1_client"+"'", TempTags, "", 2, "HLP_WWPBaseObjects\\SecFunctionalityGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtSecFunctionalityId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")), context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecFunctionalityId_Jsonclick, 0, "Attribute", "", "", "", "", edtSecFunctionalityId_Visible, 0, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionalityGeneral.htm");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbSecFunctionalityType, cmbSecFunctionalityType_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)), 1, cmbSecFunctionalityType_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "int", "", cmbSecFunctionalityType.Visible, 0, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_WWPBaseObjects\\SecFunctionalityGeneral.htm");
            cmbSecFunctionalityType.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbSecFunctionalityType_Internalname, "Values", (String)(cmbSecFunctionalityType.ToJavascriptSource()), true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecParentFunctionalityId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2SecParentFunctionalityId), 10, 0, ".", "")), context.localUtil.Format( (decimal)(A2SecParentFunctionalityId), "ZZZZZZZZZ9"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecParentFunctionalityId_Jsonclick, 0, "Attribute", "", "", "", "", edtSecParentFunctionalityId_Visible, 0, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionalityGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecParentFunctionalityDescription_Internalname, A11SecParentFunctionalityDescription, StringUtil.RTrim( context.localUtil.Format( A11SecParentFunctionalityDescription, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecParentFunctionalityDescription_Jsonclick, 0, "Attribute", "", "", "", "", edtSecParentFunctionalityDescription_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalityGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecFunctionalityActive_Internalname, StringUtil.BoolToStr( A7SecFunctionalityActive), StringUtil.BoolToStr( A7SecFunctionalityActive), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecFunctionalityActive_Jsonclick, 0, "Attribute", "", "", "", "", edtSecFunctionalityActive_Visible, 0, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionalityGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0R2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "Sec Functionality General", 0) ;
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
               STRUP0R0( ) ;
            }
         }
      }

      protected void WS0R2( )
      {
         START0R2( ) ;
         EVT0R2( ) ;
      }

      protected void EVT0R2( )
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
                                 STRUP0R0( ) ;
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
                                 STRUP0R0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E130R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0R0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E140R2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0R0( ) ;
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
                                 STRUP0R0( ) ;
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

      protected void WE0R2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0R2( ) ;
            }
         }
      }

      protected void PA0R2( )
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
         if ( cmbSecFunctionalityType.ItemCount > 0 )
         {
            A9SecFunctionalityType = (short)(NumberUtil.Val( cmbSecFunctionalityType.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A9SecFunctionalityType", StringUtil.LTrim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbSecFunctionalityType.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbSecFunctionalityType_Internalname, "Values", cmbSecFunctionalityType.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0R2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV19Pgmname = "WWPBaseObjects.SecFunctionalityGeneral";
         context.Gx_err = 0;
      }

      protected void RF0R2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000R2 */
            pr_default.execute(0, new Object[] {A1SecFunctionalityId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A7SecFunctionalityActive = H000R2_A7SecFunctionalityActive[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7SecFunctionalityActive", A7SecFunctionalityActive);
               A11SecParentFunctionalityDescription = H000R2_A11SecParentFunctionalityDescription[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11SecParentFunctionalityDescription", A11SecParentFunctionalityDescription);
               A2SecParentFunctionalityId = H000R2_A2SecParentFunctionalityId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2SecParentFunctionalityId), 10, 0)));
               n2SecParentFunctionalityId = H000R2_n2SecParentFunctionalityId[0];
               A9SecFunctionalityType = H000R2_A9SecFunctionalityType[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A9SecFunctionalityType", StringUtil.LTrim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)));
               A8SecFunctionalityDescription = H000R2_A8SecFunctionalityDescription[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A8SecFunctionalityDescription", A8SecFunctionalityDescription);
               A3SecFunctionalityKey = H000R2_A3SecFunctionalityKey[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3SecFunctionalityKey", A3SecFunctionalityKey);
               A11SecParentFunctionalityDescription = H000R2_A11SecParentFunctionalityDescription[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11SecParentFunctionalityDescription", A11SecParentFunctionalityDescription);
               /* Execute user event: Load */
               E140R2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB0R0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0R2( )
      {
      }

      protected void STRUP0R0( )
      {
         /* Before Start, stand alone formulas. */
         AV19Pgmname = "WWPBaseObjects.SecFunctionalityGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E130R2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A3SecFunctionalityKey = cgiGet( edtSecFunctionalityKey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A3SecFunctionalityKey", A3SecFunctionalityKey);
            A8SecFunctionalityDescription = cgiGet( edtSecFunctionalityDescription_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A8SecFunctionalityDescription", A8SecFunctionalityDescription);
            cmbSecFunctionalityType.CurrentValue = cgiGet( cmbSecFunctionalityType_Internalname);
            A9SecFunctionalityType = (short)(NumberUtil.Val( cgiGet( cmbSecFunctionalityType_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A9SecFunctionalityType", StringUtil.LTrim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)));
            A2SecParentFunctionalityId = (long)(context.localUtil.CToN( cgiGet( edtSecParentFunctionalityId_Internalname), ".", ","));
            n2SecParentFunctionalityId = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2SecParentFunctionalityId), 10, 0)));
            A11SecParentFunctionalityDescription = cgiGet( edtSecParentFunctionalityDescription_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A11SecParentFunctionalityDescription", A11SecParentFunctionalityDescription);
            A7SecFunctionalityActive = StringUtil.StrToBool( cgiGet( edtSecFunctionalityActive_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A7SecFunctionalityActive", A7SecFunctionalityActive);
            /* Read saved values. */
            wcpOA1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA1SecFunctionalityId"), ".", ","));
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
         E130R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130R2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV16WWPContext) ;
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

      protected void E140R2( )
      {
         /* Load Routine */
         edtSecFunctionalityId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSecFunctionalityId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Visible), 5, 0)), true);
         cmbSecFunctionalityType.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbSecFunctionalityType_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbSecFunctionalityType.Visible), 5, 0)), true);
         edtSecParentFunctionalityId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSecParentFunctionalityId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecParentFunctionalityId_Visible), 5, 0)), true);
         edtSecParentFunctionalityDescription_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSecParentFunctionalityDescription_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecParentFunctionalityDescription_Visible), 5, 0)), true);
         edtSecFunctionalityActive_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSecFunctionalityActive_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityActive_Visible), 5, 0)), true);
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWFunctionality", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtnupdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtnupdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnupdate_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWFunctionality", out  GXt_boolean1) ;
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
         AV9TrnContext.gxTpr_Callerobject = AV19Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "WWPBaseObjects.SecFunctionality";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "SecFunctionalityId";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8SecFunctionalityId), 10, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A1SecFunctionalityId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
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
         PA0R2( ) ;
         WS0R2( ) ;
         WE0R2( ) ;
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
         sCtrlA1SecFunctionalityId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0R2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "wwpbaseobjects\\secfunctionalitygeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA0R2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A1SecFunctionalityId = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
         }
         wcpOA1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA1SecFunctionalityId"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A1SecFunctionalityId != wcpOA1SecFunctionalityId ) ) )
         {
            setjustcreated();
         }
         wcpOA1SecFunctionalityId = A1SecFunctionalityId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA1SecFunctionalityId = cgiGet( sPrefix+"A1SecFunctionalityId_CTRL");
         if ( StringUtil.Len( sCtrlA1SecFunctionalityId) > 0 )
         {
            A1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( sCtrlA1SecFunctionalityId), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
         }
         else
         {
            A1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A1SecFunctionalityId_PARM"), ".", ","));
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
         PA0R2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0R2( ) ;
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
         WS0R2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A1SecFunctionalityId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA1SecFunctionalityId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A1SecFunctionalityId_CTRL", StringUtil.RTrim( sCtrlA1SecFunctionalityId));
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
         WE0R2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279354235", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secfunctionalitygeneral.js", "?20202279354235", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbSecFunctionalityType.Name = "SECFUNCTIONALITYTYPE";
         cmbSecFunctionalityType.WebTags = "";
         cmbSecFunctionalityType.addItem("1", "Mode", 0);
         cmbSecFunctionalityType.addItem("2", "Action", 0);
         cmbSecFunctionalityType.addItem("3", "Tab", 0);
         cmbSecFunctionalityType.addItem("4", "Object", 0);
         cmbSecFunctionalityType.addItem("5", "Attribute", 0);
         if ( cmbSecFunctionalityType.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtSecFunctionalityKey_Internalname = sPrefix+"SECFUNCTIONALITYKEY";
         edtSecFunctionalityDescription_Internalname = sPrefix+"SECFUNCTIONALITYDESCRIPTION";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         divTable_Internalname = sPrefix+"TABLE";
         edtSecFunctionalityId_Internalname = sPrefix+"SECFUNCTIONALITYID";
         cmbSecFunctionalityType_Internalname = sPrefix+"SECFUNCTIONALITYTYPE";
         edtSecParentFunctionalityId_Internalname = sPrefix+"SECPARENTFUNCTIONALITYID";
         edtSecParentFunctionalityDescription_Internalname = sPrefix+"SECPARENTFUNCTIONALITYDESCRIPTION";
         edtSecFunctionalityActive_Internalname = sPrefix+"SECFUNCTIONALITYACTIVE";
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
         edtSecFunctionalityActive_Jsonclick = "";
         edtSecFunctionalityActive_Visible = 1;
         edtSecParentFunctionalityDescription_Jsonclick = "";
         edtSecParentFunctionalityDescription_Visible = 1;
         edtSecParentFunctionalityId_Jsonclick = "";
         edtSecParentFunctionalityId_Visible = 1;
         cmbSecFunctionalityType_Jsonclick = "";
         cmbSecFunctionalityType.Visible = 1;
         edtSecFunctionalityId_Jsonclick = "";
         edtSecFunctionalityId_Visible = 1;
         bttBtndelete_Visible = 1;
         bttBtnupdate_Visible = 1;
         edtSecFunctionalityDescription_Jsonclick = "";
         edtSecFunctionalityDescription_Enabled = 0;
         edtSecFunctionalityKey_Jsonclick = "";
         edtSecFunctionalityKey_Enabled = 0;
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
         setEventMetadata("'DOUPDATE'","{handler:'E110R1',iparms:[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E120R1',iparms:[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'}]");
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
         AV19Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         A3SecFunctionalityKey = "";
         A8SecFunctionalityDescription = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         A11SecParentFunctionalityDescription = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H000R2_A1SecFunctionalityId = new long[1] ;
         H000R2_A7SecFunctionalityActive = new bool[] {false} ;
         H000R2_A11SecParentFunctionalityDescription = new String[] {""} ;
         H000R2_A2SecParentFunctionalityId = new long[1] ;
         H000R2_n2SecParentFunctionalityId = new bool[] {false} ;
         H000R2_A9SecFunctionalityType = new short[1] ;
         H000R2_A8SecFunctionalityDescription = new String[] {""} ;
         H000R2_A3SecFunctionalityKey = new String[] {""} ;
         AV16WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA1SecFunctionalityId = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionalitygeneral__default(),
            new Object[][] {
                new Object[] {
               H000R2_A1SecFunctionalityId, H000R2_A7SecFunctionalityActive, H000R2_A11SecParentFunctionalityDescription, H000R2_A2SecParentFunctionalityId, H000R2_n2SecParentFunctionalityId, H000R2_A9SecFunctionalityType, H000R2_A8SecFunctionalityDescription, H000R2_A3SecFunctionalityKey
               }
            }
         );
         AV19Pgmname = "WWPBaseObjects.SecFunctionalityGeneral";
         /* GeneXus formulas. */
         AV19Pgmname = "WWPBaseObjects.SecFunctionalityGeneral";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short A9SecFunctionalityType ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtSecFunctionalityKey_Enabled ;
      private int edtSecFunctionalityDescription_Enabled ;
      private int bttBtnupdate_Visible ;
      private int bttBtndelete_Visible ;
      private int edtSecFunctionalityId_Visible ;
      private int edtSecParentFunctionalityId_Visible ;
      private int edtSecParentFunctionalityDescription_Visible ;
      private int edtSecFunctionalityActive_Visible ;
      private int idxLst ;
      private long A1SecFunctionalityId ;
      private long wcpOA1SecFunctionalityId ;
      private long A2SecParentFunctionalityId ;
      private long AV8SecFunctionalityId ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV19Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String edtSecFunctionalityKey_Internalname ;
      private String edtSecFunctionalityKey_Jsonclick ;
      private String edtSecFunctionalityDescription_Internalname ;
      private String edtSecFunctionalityDescription_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtSecFunctionalityId_Internalname ;
      private String edtSecFunctionalityId_Jsonclick ;
      private String cmbSecFunctionalityType_Internalname ;
      private String cmbSecFunctionalityType_Jsonclick ;
      private String edtSecParentFunctionalityId_Internalname ;
      private String edtSecParentFunctionalityId_Jsonclick ;
      private String edtSecParentFunctionalityDescription_Internalname ;
      private String edtSecParentFunctionalityDescription_Jsonclick ;
      private String edtSecFunctionalityActive_Internalname ;
      private String edtSecFunctionalityActive_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA1SecFunctionalityId ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool A7SecFunctionalityActive ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n2SecParentFunctionalityId ;
      private bool returnInSub ;
      private bool AV13TempBoolean ;
      private bool GXt_boolean1 ;
      private String A3SecFunctionalityKey ;
      private String A8SecFunctionalityDescription ;
      private String A11SecParentFunctionalityDescription ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbSecFunctionalityType ;
      private IDataStoreProvider pr_default ;
      private long[] H000R2_A1SecFunctionalityId ;
      private bool[] H000R2_A7SecFunctionalityActive ;
      private String[] H000R2_A11SecParentFunctionalityDescription ;
      private long[] H000R2_A2SecParentFunctionalityId ;
      private bool[] H000R2_n2SecParentFunctionalityId ;
      private short[] H000R2_A9SecFunctionalityType ;
      private String[] H000R2_A8SecFunctionalityDescription ;
      private String[] H000R2_A3SecFunctionalityKey ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV16WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class secfunctionalitygeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000R2 ;
          prmH000R2 = new Object[] {
          new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000R2", "SELECT T1.[SecFunctionalityId], T1.[SecFunctionalityActive], T2.[SecFunctionalityDescription] AS SecParentFunctionalityDescription, T1.[SecParentFunctionalityId] AS SecParentFunctionalityId, T1.[SecFunctionalityType], T1.[SecFunctionalityDescription], T1.[SecFunctionalityKey] FROM ([SecFunctionality] T1 WITH (NOLOCK) LEFT JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecParentFunctionalityId]) WHERE T1.[SecFunctionalityId] = @SecFunctionalityId ORDER BY T1.[SecFunctionalityId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R2,1,0,true,true )
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
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
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