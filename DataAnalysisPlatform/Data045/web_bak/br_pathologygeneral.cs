/*
               File: BR_PathologyGeneral
        Description: BR_Pathology General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:34:25.37
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
   public class br_pathologygeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathologygeneral( )
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

      public br_pathologygeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_PathologyID )
      {
         this.A226BR_PathologyID = aP0_BR_PathologyID;
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
         cmbBR_Pathology_N = new GXCombobox();
         cmbBR_Pathology_M = new GXCombobox();
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
                  A226BR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A226BR_PathologyID});
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
            PA5D2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV15Pgmname = "BR_PathologyGeneral";
               context.Gx_err = 0;
               WS5D2( ) ;
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
            context.SendWebValue( "BR_Pathology General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279342548", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathologygeneral.aspx") + "?" + UrlEncode("" +A226BR_PathologyID)+"\">") ;
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
         forbiddenHiddens = sPrefix + "hsh" + "BR_PathologyGeneral";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A318BR_Pathology_M, ""));
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_pathologygeneral:[SendSecurityCheck value for]"+"BR_Pathology_M:"+StringUtil.RTrim( context.localUtil.Format( A318BR_Pathology_M, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA226BR_PathologyID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA226BR_PathologyID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm5D2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_pathologygeneral.js", "?20202279342553", false);
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
         return "BR_PathologyGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Pathology General" ;
      }

      protected void WB5D0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_pathologygeneral.aspx");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathologyid_padate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathologyid_padate_Internalname, "病理检查日期", "", "", lblTextblockbr_pathologyid_padate_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_PathologyID_PADate_Internalname, "病理检查日期", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_PathologyID_PADate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_PADate_Internalname, context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"), context.localUtil.Format( A238BR_PathologyID_PADate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_PADate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_PathologyID_PADate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_PathologyID_PADate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_PathologyID_PADate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_PathologyGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathologyid_paage_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathologyid_paage_Internalname, "年龄", "", "", lblTextblockbr_pathologyid_paage_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_PathologyID_PAAge_Internalname, "年龄", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_PAAge_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A240BR_PathologyID_PAAge), 3, 0, ".", "")), ((edtBR_PathologyID_PAAge_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A240BR_PathologyID_PAAge), "ZZZ")) : context.localUtil.Format( (decimal)(A240BR_PathologyID_PAAge), "ZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_PAAge_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_PathologyID_PAAge_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathologyid_pahosp_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathologyid_pahosp_Internalname, "检查医院", "", "", lblTextblockbr_pathologyid_pahosp_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_PathologyID_PAHosp_Internalname, "检查医院", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_PAHosp_Internalname, A239BR_PathologyID_PAHosp, StringUtil.RTrim( context.localUtil.Format( A239BR_PathologyID_PAHosp, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_PAHosp_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_PathologyID_PAHosp_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_dia_name_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_dia_name_Internalname, "病理诊断名称", "", "", lblTextblockbr_pathology_dia_name_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Dia_Name_Internalname, "病理诊断名称", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Multiple line edit */
            ClassString = "AttributeReadGray";
            StyleString = "";
            ClassString = "AttributeReadGray";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Pathology_Dia_Name_Internalname, A326BR_Pathology_Dia_Name, "", "", 0, 1, edtBR_Pathology_Dia_Name_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "3000", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathologyid_paresult_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathologyid_paresult_Internalname, "病理描述", "", "", lblTextblockbr_pathologyid_paresult_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_PathologyID_PAResult_Internalname, "病理描述", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Multiple line edit */
            ClassString = "AttributeReadGray";
            StyleString = "";
            ClassString = "AttributeReadGray";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_PathologyID_PAResult_Internalname, A242BR_PathologyID_PAResult, "", "", 0, 1, edtBR_PathologyID_PAResult_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "9999", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathologyid_prepadia_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathologyid_prepadia_Internalname, "病理前诊断", "", "", lblTextblockbr_pathologyid_prepadia_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_PathologyID_PrePaDia_Internalname, "病理前诊断", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Multiple line edit */
            ClassString = "AttributeReadGray";
            StyleString = "";
            ClassString = "AttributeReadGray";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_PathologyID_PrePaDia_Internalname, A241BR_PathologyID_PrePaDia, "", "", 0, 1, edtBR_PathologyID_PrePaDia_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_t_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_t_Internalname, "原发肿瘤分级", "", "", lblTextblockbr_pathology_t_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_T_Internalname, "原发肿瘤分级", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_T_Internalname, StringUtil.LTrim( StringUtil.NToC( A314BR_Pathology_T, 15, 5, ".", "")), ((edtBR_Pathology_T_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A314BR_Pathology_T, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A314BR_Pathology_T, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_T_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_T_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_PathologyGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_n_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_n_Internalname, "是否淋巴结转移", "", "", lblTextblockbr_pathology_n_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Pathology_N_Internalname, "是否淋巴结转移", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Pathology_N, cmbBR_Pathology_N_Internalname, StringUtil.RTrim( A315BR_Pathology_N), 1, cmbBR_Pathology_N_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Pathology_N.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_PathologyGeneral.htm");
            cmbBR_Pathology_N.CurrentValue = StringUtil.RTrim( A315BR_Pathology_N);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Pathology_N_Internalname, "Values", (String)(cmbBR_Pathology_N.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_lymphnum_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_lymphnum_Internalname, "淋巴结数目", "", "", lblTextblockbr_pathology_lymphnum_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_LymphNum_Internalname, "淋巴结数目", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_LymphNum_Internalname, StringUtil.LTrim( StringUtil.NToC( A316BR_Pathology_LymphNum, 15, 5, ".", "")), ((edtBR_Pathology_LymphNum_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A316BR_Pathology_LymphNum, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A316BR_Pathology_LymphNum, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_LymphNum_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_LymphNum_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_lymphrate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_lymphrate_Internalname, "淋巴结转移比例", "", "", lblTextblockbr_pathology_lymphrate_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_LymphRate_Internalname, "淋巴结转移比例", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_LymphRate_Internalname, A317BR_Pathology_LymphRate, StringUtil.RTrim( context.localUtil.Format( A317BR_Pathology_LymphRate, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_LymphRate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_LymphRate_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_m_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_m_Internalname, "是否远端转移", "", "", lblTextblockbr_pathology_m_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Pathology_M_Internalname, "是否远端转移", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Pathology_M, cmbBR_Pathology_M_Internalname, StringUtil.RTrim( A318BR_Pathology_M), 1, cmbBR_Pathology_M_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Pathology_M.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_PathologyGeneral.htm");
            cmbBR_Pathology_M.CurrentValue = StringUtil.RTrim( A318BR_Pathology_M);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Pathology_M_Internalname, "Values", (String)(cmbBR_Pathology_M.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_metaloc_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_metaloc_Internalname, "远端转移部位", "", "", lblTextblockbr_pathology_metaloc_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_MetaLoc_Internalname, "远端转移部位", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_MetaLoc_Internalname, A319BR_Pathology_MetaLoc, StringUtil.RTrim( context.localUtil.Format( A319BR_Pathology_MetaLoc, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_MetaLoc_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_MetaLoc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_PathologyID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_PathologyGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_PathologyGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START5D2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Pathology General", 0) ;
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
               STRUP5D0( ) ;
            }
         }
      }

      protected void WS5D2( )
      {
         START5D2( ) ;
         EVT5D2( ) ;
      }

      protected void EVT5D2( )
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
                                 STRUP5D0( ) ;
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
                                 STRUP5D0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E115D2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5D0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E125D2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5D0( ) ;
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
                                 STRUP5D0( ) ;
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

      protected void WE5D2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5D2( ) ;
            }
         }
      }

      protected void PA5D2( )
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
         if ( cmbBR_Pathology_N.ItemCount > 0 )
         {
            A315BR_Pathology_N = cmbBR_Pathology_N.getValidValue(A315BR_Pathology_N);
            n315BR_Pathology_N = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A315BR_Pathology_N", A315BR_Pathology_N);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Pathology_N.CurrentValue = StringUtil.RTrim( A315BR_Pathology_N);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Pathology_N_Internalname, "Values", cmbBR_Pathology_N.ToJavascriptSource(), true);
         }
         if ( cmbBR_Pathology_M.ItemCount > 0 )
         {
            A318BR_Pathology_M = cmbBR_Pathology_M.getValidValue(A318BR_Pathology_M);
            n318BR_Pathology_M = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A318BR_Pathology_M", A318BR_Pathology_M);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Pathology_M.CurrentValue = StringUtil.RTrim( A318BR_Pathology_M);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Pathology_M_Internalname, "Values", cmbBR_Pathology_M.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF5D2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV15Pgmname = "BR_PathologyGeneral";
         context.Gx_err = 0;
      }

      protected void RF5D2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H005D2 */
            pr_default.execute(0, new Object[] {A226BR_PathologyID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A85BR_Information_ID = H005D2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005D2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H005D2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H005D2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H005D2_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               n19BR_EncounterID = H005D2_n19BR_EncounterID[0];
               A319BR_Pathology_MetaLoc = H005D2_A319BR_Pathology_MetaLoc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A319BR_Pathology_MetaLoc", A319BR_Pathology_MetaLoc);
               n319BR_Pathology_MetaLoc = H005D2_n319BR_Pathology_MetaLoc[0];
               A318BR_Pathology_M = H005D2_A318BR_Pathology_M[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A318BR_Pathology_M", A318BR_Pathology_M);
               n318BR_Pathology_M = H005D2_n318BR_Pathology_M[0];
               A317BR_Pathology_LymphRate = H005D2_A317BR_Pathology_LymphRate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A317BR_Pathology_LymphRate", A317BR_Pathology_LymphRate);
               n317BR_Pathology_LymphRate = H005D2_n317BR_Pathology_LymphRate[0];
               A316BR_Pathology_LymphNum = H005D2_A316BR_Pathology_LymphNum[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A316BR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( A316BR_Pathology_LymphNum, 15, 5)));
               n316BR_Pathology_LymphNum = H005D2_n316BR_Pathology_LymphNum[0];
               A315BR_Pathology_N = H005D2_A315BR_Pathology_N[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A315BR_Pathology_N", A315BR_Pathology_N);
               n315BR_Pathology_N = H005D2_n315BR_Pathology_N[0];
               A314BR_Pathology_T = H005D2_A314BR_Pathology_T[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A314BR_Pathology_T", StringUtil.LTrim( StringUtil.Str( A314BR_Pathology_T, 15, 5)));
               n314BR_Pathology_T = H005D2_n314BR_Pathology_T[0];
               A241BR_PathologyID_PrePaDia = H005D2_A241BR_PathologyID_PrePaDia[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A241BR_PathologyID_PrePaDia", A241BR_PathologyID_PrePaDia);
               n241BR_PathologyID_PrePaDia = H005D2_n241BR_PathologyID_PrePaDia[0];
               A242BR_PathologyID_PAResult = H005D2_A242BR_PathologyID_PAResult[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A242BR_PathologyID_PAResult", A242BR_PathologyID_PAResult);
               n242BR_PathologyID_PAResult = H005D2_n242BR_PathologyID_PAResult[0];
               A326BR_Pathology_Dia_Name = H005D2_A326BR_Pathology_Dia_Name[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A326BR_Pathology_Dia_Name", A326BR_Pathology_Dia_Name);
               n326BR_Pathology_Dia_Name = H005D2_n326BR_Pathology_Dia_Name[0];
               A239BR_PathologyID_PAHosp = H005D2_A239BR_PathologyID_PAHosp[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
               n239BR_PathologyID_PAHosp = H005D2_n239BR_PathologyID_PAHosp[0];
               A240BR_PathologyID_PAAge = H005D2_A240BR_PathologyID_PAAge[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A240BR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A240BR_PathologyID_PAAge), 3, 0)));
               n240BR_PathologyID_PAAge = H005D2_n240BR_PathologyID_PAAge[0];
               A238BR_PathologyID_PADate = H005D2_A238BR_PathologyID_PADate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A238BR_PathologyID_PADate", context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"));
               n238BR_PathologyID_PADate = H005D2_n238BR_PathologyID_PADate[0];
               A85BR_Information_ID = H005D2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005D2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H005D2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H005D2_n36BR_Information_PatientNo[0];
               /* Execute user event: Load */
               E125D2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB5D0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes5D2( )
      {
      }

      protected void STRUP5D0( )
      {
         /* Before Start, stand alone formulas. */
         AV15Pgmname = "BR_PathologyGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E115D2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A238BR_PathologyID_PADate = context.localUtil.CToD( cgiGet( edtBR_PathologyID_PADate_Internalname), 0);
            n238BR_PathologyID_PADate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A238BR_PathologyID_PADate", context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"));
            A240BR_PathologyID_PAAge = (short)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_PAAge_Internalname), ".", ","));
            n240BR_PathologyID_PAAge = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A240BR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A240BR_PathologyID_PAAge), 3, 0)));
            A239BR_PathologyID_PAHosp = cgiGet( edtBR_PathologyID_PAHosp_Internalname);
            n239BR_PathologyID_PAHosp = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
            A326BR_Pathology_Dia_Name = cgiGet( edtBR_Pathology_Dia_Name_Internalname);
            n326BR_Pathology_Dia_Name = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A326BR_Pathology_Dia_Name", A326BR_Pathology_Dia_Name);
            A242BR_PathologyID_PAResult = cgiGet( edtBR_PathologyID_PAResult_Internalname);
            n242BR_PathologyID_PAResult = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A242BR_PathologyID_PAResult", A242BR_PathologyID_PAResult);
            A241BR_PathologyID_PrePaDia = cgiGet( edtBR_PathologyID_PrePaDia_Internalname);
            n241BR_PathologyID_PrePaDia = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A241BR_PathologyID_PrePaDia", A241BR_PathologyID_PrePaDia);
            A314BR_Pathology_T = context.localUtil.CToN( cgiGet( edtBR_Pathology_T_Internalname), ".", ",");
            n314BR_Pathology_T = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A314BR_Pathology_T", StringUtil.LTrim( StringUtil.Str( A314BR_Pathology_T, 15, 5)));
            cmbBR_Pathology_N.CurrentValue = cgiGet( cmbBR_Pathology_N_Internalname);
            A315BR_Pathology_N = cgiGet( cmbBR_Pathology_N_Internalname);
            n315BR_Pathology_N = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A315BR_Pathology_N", A315BR_Pathology_N);
            A316BR_Pathology_LymphNum = context.localUtil.CToN( cgiGet( edtBR_Pathology_LymphNum_Internalname), ".", ",");
            n316BR_Pathology_LymphNum = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A316BR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( A316BR_Pathology_LymphNum, 15, 5)));
            A317BR_Pathology_LymphRate = cgiGet( edtBR_Pathology_LymphRate_Internalname);
            n317BR_Pathology_LymphRate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A317BR_Pathology_LymphRate", A317BR_Pathology_LymphRate);
            cmbBR_Pathology_M.CurrentValue = cgiGet( cmbBR_Pathology_M_Internalname);
            A318BR_Pathology_M = cgiGet( cmbBR_Pathology_M_Internalname);
            n318BR_Pathology_M = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A318BR_Pathology_M", A318BR_Pathology_M);
            A319BR_Pathology_MetaLoc = cgiGet( edtBR_Pathology_MetaLoc_Internalname);
            n319BR_Pathology_MetaLoc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A319BR_Pathology_MetaLoc", A319BR_Pathology_MetaLoc);
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            n19BR_EncounterID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
            n36BR_Information_PatientNo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            /* Read saved values. */
            wcpOA226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA226BR_PathologyID"), ".", ","));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = sPrefix + "hsh" + "BR_PathologyGeneral";
            A318BR_Pathology_M = cgiGet( cmbBR_Pathology_M_Internalname);
            n318BR_Pathology_M = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A318BR_Pathology_M", A318BR_Pathology_M);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A318BR_Pathology_M, ""));
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("br_pathologygeneral:[SecurityCheckFailed value for]"+"BR_Pathology_M:"+StringUtil.RTrim( context.localUtil.Format( A318BR_Pathology_M, "")));
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
         E115D2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E115D2( )
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

      protected void E125D2( )
      {
         /* Load Routine */
         edtBR_PathologyID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_PathologyID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         divUnnamedtable1_Visible = (((StringUtil.StrCmp(A318BR_Pathology_M, "是")==0)) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divUnnamedtable1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable1_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV15Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Pathology";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_PathologyID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A226BR_PathologyID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
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
         PA5D2( ) ;
         WS5D2( ) ;
         WE5D2( ) ;
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
         sCtrlA226BR_PathologyID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA5D2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_pathologygeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA5D2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A226BR_PathologyID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
         }
         wcpOA226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA226BR_PathologyID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A226BR_PathologyID != wcpOA226BR_PathologyID ) ) )
         {
            setjustcreated();
         }
         wcpOA226BR_PathologyID = A226BR_PathologyID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA226BR_PathologyID = cgiGet( sPrefix+"A226BR_PathologyID_CTRL");
         if ( StringUtil.Len( sCtrlA226BR_PathologyID) > 0 )
         {
            A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sCtrlA226BR_PathologyID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
         }
         else
         {
            A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A226BR_PathologyID_PARM"), ".", ","));
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
         PA5D2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS5D2( ) ;
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
         WS5D2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A226BR_PathologyID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA226BR_PathologyID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A226BR_PathologyID_CTRL", StringUtil.RTrim( sCtrlA226BR_PathologyID));
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
         WE5D2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227934286", true);
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
            context.AddJavascriptSource("br_pathologygeneral.js", "?2020227934287", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbBR_Pathology_N.Name = "BR_PATHOLOGY_N";
         cmbBR_Pathology_N.WebTags = "";
         cmbBR_Pathology_N.addItem("", "(请选择)", 0);
         cmbBR_Pathology_N.addItem("否", "否", 0);
         cmbBR_Pathology_N.addItem("是", "是", 0);
         cmbBR_Pathology_N.addItem("不详", "不详", 0);
         if ( cmbBR_Pathology_N.ItemCount > 0 )
         {
         }
         cmbBR_Pathology_M.Name = "BR_PATHOLOGY_M";
         cmbBR_Pathology_M.WebTags = "";
         cmbBR_Pathology_M.addItem("", "(请选择)", 0);
         cmbBR_Pathology_M.addItem("否", "否", 0);
         cmbBR_Pathology_M.addItem("是", "是", 0);
         cmbBR_Pathology_M.addItem("不详", "不详", 0);
         if ( cmbBR_Pathology_M.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_pathologyid_padate_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGYID_PADATE";
         edtBR_PathologyID_PADate_Internalname = sPrefix+"BR_PATHOLOGYID_PADATE";
         divUnnamedtablebr_pathologyid_padate_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGYID_PADATE";
         lblTextblockbr_pathologyid_paage_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGYID_PAAGE";
         edtBR_PathologyID_PAAge_Internalname = sPrefix+"BR_PATHOLOGYID_PAAGE";
         divUnnamedtablebr_pathologyid_paage_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGYID_PAAGE";
         lblTextblockbr_pathologyid_pahosp_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGYID_PAHOSP";
         edtBR_PathologyID_PAHosp_Internalname = sPrefix+"BR_PATHOLOGYID_PAHOSP";
         divUnnamedtablebr_pathologyid_pahosp_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGYID_PAHOSP";
         lblTextblockbr_pathology_dia_name_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_DIA_NAME";
         edtBR_Pathology_Dia_Name_Internalname = sPrefix+"BR_PATHOLOGY_DIA_NAME";
         divUnnamedtablebr_pathology_dia_name_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_DIA_NAME";
         lblTextblockbr_pathologyid_paresult_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGYID_PARESULT";
         edtBR_PathologyID_PAResult_Internalname = sPrefix+"BR_PATHOLOGYID_PARESULT";
         divUnnamedtablebr_pathologyid_paresult_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGYID_PARESULT";
         lblTextblockbr_pathologyid_prepadia_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGYID_PREPADIA";
         edtBR_PathologyID_PrePaDia_Internalname = sPrefix+"BR_PATHOLOGYID_PREPADIA";
         divUnnamedtablebr_pathologyid_prepadia_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGYID_PREPADIA";
         lblTextblockbr_pathology_t_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_T";
         edtBR_Pathology_T_Internalname = sPrefix+"BR_PATHOLOGY_T";
         divUnnamedtablebr_pathology_t_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_T";
         lblTextblockbr_pathology_n_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_N";
         cmbBR_Pathology_N_Internalname = sPrefix+"BR_PATHOLOGY_N";
         divUnnamedtablebr_pathology_n_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_N";
         lblTextblockbr_pathology_lymphnum_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_LYMPHNUM";
         edtBR_Pathology_LymphNum_Internalname = sPrefix+"BR_PATHOLOGY_LYMPHNUM";
         divUnnamedtablebr_pathology_lymphnum_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_LYMPHNUM";
         lblTextblockbr_pathology_lymphrate_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_LYMPHRATE";
         edtBR_Pathology_LymphRate_Internalname = sPrefix+"BR_PATHOLOGY_LYMPHRATE";
         divUnnamedtablebr_pathology_lymphrate_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_LYMPHRATE";
         lblTextblockbr_pathology_m_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_M";
         cmbBR_Pathology_M_Internalname = sPrefix+"BR_PATHOLOGY_M";
         divUnnamedtablebr_pathology_m_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_M";
         lblTextblockbr_pathology_metaloc_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_METALOC";
         edtBR_Pathology_MetaLoc_Internalname = sPrefix+"BR_PATHOLOGY_METALOC";
         divUnnamedtablebr_pathology_metaloc_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_METALOC";
         divUnnamedtable1_Internalname = sPrefix+"UNNAMEDTABLE1";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_PathologyID_Internalname = sPrefix+"BR_PATHOLOGYID";
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
         edtBR_PathologyID_Jsonclick = "";
         edtBR_PathologyID_Visible = 1;
         edtBR_Pathology_MetaLoc_Jsonclick = "";
         edtBR_Pathology_MetaLoc_Enabled = 0;
         divUnnamedtable1_Visible = 1;
         cmbBR_Pathology_M_Jsonclick = "";
         cmbBR_Pathology_M.Enabled = 0;
         edtBR_Pathology_LymphRate_Jsonclick = "";
         edtBR_Pathology_LymphRate_Enabled = 0;
         edtBR_Pathology_LymphNum_Jsonclick = "";
         edtBR_Pathology_LymphNum_Enabled = 0;
         cmbBR_Pathology_N_Jsonclick = "";
         cmbBR_Pathology_N.Enabled = 0;
         edtBR_Pathology_T_Jsonclick = "";
         edtBR_Pathology_T_Enabled = 0;
         edtBR_PathologyID_PrePaDia_Enabled = 0;
         edtBR_PathologyID_PAResult_Enabled = 0;
         edtBR_Pathology_Dia_Name_Enabled = 0;
         edtBR_PathologyID_PAHosp_Jsonclick = "";
         edtBR_PathologyID_PAHosp_Enabled = 0;
         edtBR_PathologyID_PAAge_Jsonclick = "";
         edtBR_PathologyID_PAAge_Enabled = 0;
         edtBR_PathologyID_PADate_Jsonclick = "";
         edtBR_PathologyID_PADate_Enabled = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'cmbBR_Pathology_M'},{av:'A318BR_Pathology_M',fld:'BR_PATHOLOGY_M',pic:''}]");
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
         AV15Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         forbiddenHiddens = "";
         A318BR_Pathology_M = "";
         GX_FocusControl = "";
         lblTextblockbr_pathologyid_padate_Jsonclick = "";
         A238BR_PathologyID_PADate = DateTime.MinValue;
         lblTextblockbr_pathologyid_paage_Jsonclick = "";
         lblTextblockbr_pathologyid_pahosp_Jsonclick = "";
         A239BR_PathologyID_PAHosp = "";
         lblTextblockbr_pathology_dia_name_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         A326BR_Pathology_Dia_Name = "";
         lblTextblockbr_pathologyid_paresult_Jsonclick = "";
         A242BR_PathologyID_PAResult = "";
         lblTextblockbr_pathologyid_prepadia_Jsonclick = "";
         A241BR_PathologyID_PrePaDia = "";
         lblTextblockbr_pathology_t_Jsonclick = "";
         lblTextblockbr_pathology_n_Jsonclick = "";
         A315BR_Pathology_N = "";
         lblTextblockbr_pathology_lymphnum_Jsonclick = "";
         lblTextblockbr_pathology_lymphrate_Jsonclick = "";
         A317BR_Pathology_LymphRate = "";
         lblTextblockbr_pathology_m_Jsonclick = "";
         lblTextblockbr_pathology_metaloc_Jsonclick = "";
         A319BR_Pathology_MetaLoc = "";
         A36BR_Information_PatientNo = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H005D2_A85BR_Information_ID = new long[1] ;
         H005D2_n85BR_Information_ID = new bool[] {false} ;
         H005D2_A226BR_PathologyID = new long[1] ;
         H005D2_A36BR_Information_PatientNo = new String[] {""} ;
         H005D2_n36BR_Information_PatientNo = new bool[] {false} ;
         H005D2_A19BR_EncounterID = new long[1] ;
         H005D2_n19BR_EncounterID = new bool[] {false} ;
         H005D2_A319BR_Pathology_MetaLoc = new String[] {""} ;
         H005D2_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         H005D2_A318BR_Pathology_M = new String[] {""} ;
         H005D2_n318BR_Pathology_M = new bool[] {false} ;
         H005D2_A317BR_Pathology_LymphRate = new String[] {""} ;
         H005D2_n317BR_Pathology_LymphRate = new bool[] {false} ;
         H005D2_A316BR_Pathology_LymphNum = new decimal[1] ;
         H005D2_n316BR_Pathology_LymphNum = new bool[] {false} ;
         H005D2_A315BR_Pathology_N = new String[] {""} ;
         H005D2_n315BR_Pathology_N = new bool[] {false} ;
         H005D2_A314BR_Pathology_T = new decimal[1] ;
         H005D2_n314BR_Pathology_T = new bool[] {false} ;
         H005D2_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         H005D2_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         H005D2_A242BR_PathologyID_PAResult = new String[] {""} ;
         H005D2_n242BR_PathologyID_PAResult = new bool[] {false} ;
         H005D2_A326BR_Pathology_Dia_Name = new String[] {""} ;
         H005D2_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         H005D2_A239BR_PathologyID_PAHosp = new String[] {""} ;
         H005D2_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         H005D2_A240BR_PathologyID_PAAge = new short[1] ;
         H005D2_n240BR_PathologyID_PAAge = new bool[] {false} ;
         H005D2_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         H005D2_n238BR_PathologyID_PADate = new bool[] {false} ;
         hsh = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA226BR_PathologyID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathologygeneral__default(),
            new Object[][] {
                new Object[] {
               H005D2_A85BR_Information_ID, H005D2_n85BR_Information_ID, H005D2_A226BR_PathologyID, H005D2_A36BR_Information_PatientNo, H005D2_n36BR_Information_PatientNo, H005D2_A19BR_EncounterID, H005D2_n19BR_EncounterID, H005D2_A319BR_Pathology_MetaLoc, H005D2_n319BR_Pathology_MetaLoc, H005D2_A318BR_Pathology_M,
               H005D2_n318BR_Pathology_M, H005D2_A317BR_Pathology_LymphRate, H005D2_n317BR_Pathology_LymphRate, H005D2_A316BR_Pathology_LymphNum, H005D2_n316BR_Pathology_LymphNum, H005D2_A315BR_Pathology_N, H005D2_n315BR_Pathology_N, H005D2_A314BR_Pathology_T, H005D2_n314BR_Pathology_T, H005D2_A241BR_PathologyID_PrePaDia,
               H005D2_n241BR_PathologyID_PrePaDia, H005D2_A242BR_PathologyID_PAResult, H005D2_n242BR_PathologyID_PAResult, H005D2_A326BR_Pathology_Dia_Name, H005D2_n326BR_Pathology_Dia_Name, H005D2_A239BR_PathologyID_PAHosp, H005D2_n239BR_PathologyID_PAHosp, H005D2_A240BR_PathologyID_PAAge, H005D2_n240BR_PathologyID_PAAge, H005D2_A238BR_PathologyID_PADate,
               H005D2_n238BR_PathologyID_PADate
               }
            }
         );
         AV15Pgmname = "BR_PathologyGeneral";
         /* GeneXus formulas. */
         AV15Pgmname = "BR_PathologyGeneral";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short A240BR_PathologyID_PAAge ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private int edtBR_PathologyID_PADate_Enabled ;
      private int edtBR_PathologyID_PAAge_Enabled ;
      private int edtBR_PathologyID_PAHosp_Enabled ;
      private int edtBR_Pathology_Dia_Name_Enabled ;
      private int edtBR_PathologyID_PAResult_Enabled ;
      private int edtBR_PathologyID_PrePaDia_Enabled ;
      private int edtBR_Pathology_T_Enabled ;
      private int edtBR_Pathology_LymphNum_Enabled ;
      private int edtBR_Pathology_LymphRate_Enabled ;
      private int divUnnamedtable1_Visible ;
      private int edtBR_Pathology_MetaLoc_Enabled ;
      private int edtBR_PathologyID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_Information_PatientNo_Visible ;
      private int idxLst ;
      private long A226BR_PathologyID ;
      private long wcpOA226BR_PathologyID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV8BR_PathologyID ;
      private decimal A314BR_Pathology_T ;
      private decimal A316BR_Pathology_LymphNum ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV15Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String divUnnamedtablebr_pathologyid_padate_Internalname ;
      private String lblTextblockbr_pathologyid_padate_Internalname ;
      private String lblTextblockbr_pathologyid_padate_Jsonclick ;
      private String edtBR_PathologyID_PADate_Internalname ;
      private String edtBR_PathologyID_PADate_Jsonclick ;
      private String divUnnamedtablebr_pathologyid_paage_Internalname ;
      private String lblTextblockbr_pathologyid_paage_Internalname ;
      private String lblTextblockbr_pathologyid_paage_Jsonclick ;
      private String edtBR_PathologyID_PAAge_Internalname ;
      private String edtBR_PathologyID_PAAge_Jsonclick ;
      private String divUnnamedtablebr_pathologyid_pahosp_Internalname ;
      private String lblTextblockbr_pathologyid_pahosp_Internalname ;
      private String lblTextblockbr_pathologyid_pahosp_Jsonclick ;
      private String edtBR_PathologyID_PAHosp_Internalname ;
      private String edtBR_PathologyID_PAHosp_Jsonclick ;
      private String divUnnamedtablebr_pathology_dia_name_Internalname ;
      private String lblTextblockbr_pathology_dia_name_Internalname ;
      private String lblTextblockbr_pathology_dia_name_Jsonclick ;
      private String edtBR_Pathology_Dia_Name_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divUnnamedtablebr_pathologyid_paresult_Internalname ;
      private String lblTextblockbr_pathologyid_paresult_Internalname ;
      private String lblTextblockbr_pathologyid_paresult_Jsonclick ;
      private String edtBR_PathologyID_PAResult_Internalname ;
      private String divUnnamedtablebr_pathologyid_prepadia_Internalname ;
      private String lblTextblockbr_pathologyid_prepadia_Internalname ;
      private String lblTextblockbr_pathologyid_prepadia_Jsonclick ;
      private String edtBR_PathologyID_PrePaDia_Internalname ;
      private String divUnnamedtablebr_pathology_t_Internalname ;
      private String lblTextblockbr_pathology_t_Internalname ;
      private String lblTextblockbr_pathology_t_Jsonclick ;
      private String edtBR_Pathology_T_Internalname ;
      private String edtBR_Pathology_T_Jsonclick ;
      private String divUnnamedtablebr_pathology_n_Internalname ;
      private String lblTextblockbr_pathology_n_Internalname ;
      private String lblTextblockbr_pathology_n_Jsonclick ;
      private String cmbBR_Pathology_N_Internalname ;
      private String cmbBR_Pathology_N_Jsonclick ;
      private String divUnnamedtablebr_pathology_lymphnum_Internalname ;
      private String lblTextblockbr_pathology_lymphnum_Internalname ;
      private String lblTextblockbr_pathology_lymphnum_Jsonclick ;
      private String edtBR_Pathology_LymphNum_Internalname ;
      private String edtBR_Pathology_LymphNum_Jsonclick ;
      private String divUnnamedtablebr_pathology_lymphrate_Internalname ;
      private String lblTextblockbr_pathology_lymphrate_Internalname ;
      private String lblTextblockbr_pathology_lymphrate_Jsonclick ;
      private String edtBR_Pathology_LymphRate_Internalname ;
      private String edtBR_Pathology_LymphRate_Jsonclick ;
      private String divUnnamedtablebr_pathology_m_Internalname ;
      private String lblTextblockbr_pathology_m_Internalname ;
      private String lblTextblockbr_pathology_m_Jsonclick ;
      private String cmbBR_Pathology_M_Internalname ;
      private String cmbBR_Pathology_M_Jsonclick ;
      private String divUnnamedtable1_Internalname ;
      private String divUnnamedtablebr_pathology_metaloc_Internalname ;
      private String lblTextblockbr_pathology_metaloc_Internalname ;
      private String lblTextblockbr_pathology_metaloc_Jsonclick ;
      private String edtBR_Pathology_MetaLoc_Internalname ;
      private String edtBR_Pathology_MetaLoc_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_PathologyID_Jsonclick ;
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
      private String sCtrlA226BR_PathologyID ;
      private DateTime A238BR_PathologyID_PADate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n315BR_Pathology_N ;
      private bool n318BR_Pathology_M ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n19BR_EncounterID ;
      private bool n319BR_Pathology_MetaLoc ;
      private bool n317BR_Pathology_LymphRate ;
      private bool n316BR_Pathology_LymphNum ;
      private bool n314BR_Pathology_T ;
      private bool n241BR_PathologyID_PrePaDia ;
      private bool n242BR_PathologyID_PAResult ;
      private bool n326BR_Pathology_Dia_Name ;
      private bool n239BR_PathologyID_PAHosp ;
      private bool n240BR_PathologyID_PAAge ;
      private bool n238BR_PathologyID_PADate ;
      private bool returnInSub ;
      private String A318BR_Pathology_M ;
      private String A239BR_PathologyID_PAHosp ;
      private String A326BR_Pathology_Dia_Name ;
      private String A242BR_PathologyID_PAResult ;
      private String A241BR_PathologyID_PrePaDia ;
      private String A315BR_Pathology_N ;
      private String A317BR_Pathology_LymphRate ;
      private String A319BR_Pathology_MetaLoc ;
      private String A36BR_Information_PatientNo ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Pathology_N ;
      private GXCombobox cmbBR_Pathology_M ;
      private IDataStoreProvider pr_default ;
      private long[] H005D2_A85BR_Information_ID ;
      private bool[] H005D2_n85BR_Information_ID ;
      private long[] H005D2_A226BR_PathologyID ;
      private String[] H005D2_A36BR_Information_PatientNo ;
      private bool[] H005D2_n36BR_Information_PatientNo ;
      private long[] H005D2_A19BR_EncounterID ;
      private bool[] H005D2_n19BR_EncounterID ;
      private String[] H005D2_A319BR_Pathology_MetaLoc ;
      private bool[] H005D2_n319BR_Pathology_MetaLoc ;
      private String[] H005D2_A318BR_Pathology_M ;
      private bool[] H005D2_n318BR_Pathology_M ;
      private String[] H005D2_A317BR_Pathology_LymphRate ;
      private bool[] H005D2_n317BR_Pathology_LymphRate ;
      private decimal[] H005D2_A316BR_Pathology_LymphNum ;
      private bool[] H005D2_n316BR_Pathology_LymphNum ;
      private String[] H005D2_A315BR_Pathology_N ;
      private bool[] H005D2_n315BR_Pathology_N ;
      private decimal[] H005D2_A314BR_Pathology_T ;
      private bool[] H005D2_n314BR_Pathology_T ;
      private String[] H005D2_A241BR_PathologyID_PrePaDia ;
      private bool[] H005D2_n241BR_PathologyID_PrePaDia ;
      private String[] H005D2_A242BR_PathologyID_PAResult ;
      private bool[] H005D2_n242BR_PathologyID_PAResult ;
      private String[] H005D2_A326BR_Pathology_Dia_Name ;
      private bool[] H005D2_n326BR_Pathology_Dia_Name ;
      private String[] H005D2_A239BR_PathologyID_PAHosp ;
      private bool[] H005D2_n239BR_PathologyID_PAHosp ;
      private short[] H005D2_A240BR_PathologyID_PAAge ;
      private bool[] H005D2_n240BR_PathologyID_PAAge ;
      private DateTime[] H005D2_A238BR_PathologyID_PADate ;
      private bool[] H005D2_n238BR_PathologyID_PADate ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_pathologygeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH005D2 ;
          prmH005D2 = new Object[] {
          new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005D2", "SELECT T2.[BR_Information_ID], T1.[BR_PathologyID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Pathology_MetaLoc], T1.[BR_Pathology_M], T1.[BR_Pathology_LymphRate], T1.[BR_Pathology_LymphNum], T1.[BR_Pathology_N], T1.[BR_Pathology_T], T1.[BR_PathologyID_PrePaDia], T1.[BR_PathologyID_PAResult], T1.[BR_Pathology_Dia_Name], T1.[BR_PathologyID_PAHosp], T1.[BR_PathologyID_PAAge], T1.[BR_PathologyID_PADate] FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE T1.[BR_PathologyID] = @BR_PathologyID ORDER BY T1.[BR_PathologyID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005D2,1,0,true,true )
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
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((decimal[]) buf[13])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((short[]) buf[27])[0] = rslt.getShort(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                ((DateTime[]) buf[29])[0] = rslt.getGXDate(16) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(16);
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
