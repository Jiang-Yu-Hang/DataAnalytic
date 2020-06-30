/*
               File: WWPBaseObjects.SecLogIn
        Description: Data Mangement Platform
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:21.58
       Program type: Main program
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
   public class seclogin : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public seclogin( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public seclogin( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_returnurl )
      {
         this.AV21returnurl = aP0_returnurl;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
               AV21returnurl = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21returnurl", AV21returnurl);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV21returnurl, "")), context));
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
            ValidateSpaRequest();
            PA0T2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV47Pgmdesc = "Data Mangement Platform";
               AV46Pgmname = "WWPBaseObjects.SecLogIn";
               context.Gx_err = 0;
               WS0T2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE0T2( ) ;
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
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( "Data Mangement Platform") ;
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
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202281592162", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal FormBackgroundImage\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal FormBackgroundImage\" data-gx-class=\"form-horizontal FormBackgroundImage\" novalidate action=\""+formatLink("wwpbaseobjects.seclogin.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV21returnurl))+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal FormBackgroundImage", true);
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
         GxWebStd.gx_hidden_field( context, "ACCOUNT", A364Account);
         GxWebStd.gx_hidden_field( context, "USERTYPE", StringUtil.LTrim( StringUtil.NToC( (decimal)(A417UserType), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PASSWORDHASH", A418PasswordHash);
         GxWebStd.gx_hidden_field( context, "USERID", A359UserID.ToString());
         GxWebStd.gx_hidden_field( context, "DISPLAYNAME", A416DisplayName);
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vWWPCONTEXT", AV12WWPContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vWWPCONTEXT", AV12WWPContext);
         }
         GxWebStd.gx_hidden_field( context, "vTDISPLAYNAME", AV42tDisplayName);
         GxWebStd.gx_hidden_field( context, "vTUSERID", AV29tUserID.ToString());
         GxWebStd.gx_hidden_field( context, "vTUSERTYPE", AV38tUserType);
         GxWebStd.gx_hidden_field( context, "vTCLIENTADDRESS", AV18tClientAddress);
         GxWebStd.gx_hidden_field( context, "gxhash_vTCLIENTADDRESS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tClientAddress, "")), context));
         GxWebStd.gx_hidden_field( context, "vRETURNURL", AV21returnurl);
         GxWebStd.gx_hidden_field( context, "gxhash_vRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV21returnurl, "")), context));
      }

      protected void RenderHtmlCloseForm0T2( )
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
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecLogIn" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mangement Platform" ;
      }

      protected void WB0T0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", divLayoutmaintable_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "Table100x100H_Login", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDesc_Internalname, "Data Management Platform", "", "", lblDesc_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Attribute_LoginDes", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecLogIn.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDescson_Internalname, "A fully integrated platform of scalable,secure workflow solutions to analytics and actionable insights.", "", "", lblDescson_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Attribute_LoginDesSon", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecLogIn.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 CellMarginLoginImageLeft", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablelogincontent_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablelogin_Internalname, 1, 0, "px", 0, "px", "TableLoginWithLeftImage", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            wb_table1_23_0T2( true) ;
         }
         else
         {
            wb_table1_23_0T2( false) ;
         }
         return  ;
      }

      protected void wb_table1_23_0T2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "Center", "top", "", "", "div");
            wb_table2_31_0T2( true) ;
         }
         else
         {
            wb_table2_31_0T2( false) ;
         }
         return  ;
      }

      protected void wb_table2_31_0T2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableloginerror_Internalname, divTableloginerror_Visible, 0, "px", 0, "px", "TableLoginWithLeftImageError", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0T2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Data Mangement Platform", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0T0( ) ;
      }

      protected void WS0T2( )
      {
         START0T2( ) ;
         EVT0T2( ) ;
      }

      protected void EVT0T2( )
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
                           E110T2 ();
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
                                 E120T2 ();
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E130T2 ();
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

      protected void WE0T2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0T2( ) ;
            }
         }
      }

      protected void PA0T2( )
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
               GX_FocusControl = edtavSecusername_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
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
         RF0T2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV47Pgmdesc = "Data Mangement Platform";
         AV46Pgmname = "WWPBaseObjects.SecLogIn";
         context.Gx_err = 0;
      }

      protected void RF0T2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E130T2 ();
            WB0T0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0T2( )
      {
         GxWebStd.gx_hidden_field( context, "vTCLIENTADDRESS", AV18tClientAddress);
         GxWebStd.gx_hidden_field( context, "gxhash_vTCLIENTADDRESS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tClientAddress, "")), context));
         GxWebStd.gx_hidden_field( context, "vRETURNURL", AV21returnurl);
         GxWebStd.gx_hidden_field( context, "gxhash_vRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV21returnurl, "")), context));
      }

      protected void STRUP0T0( )
      {
         /* Before Start, stand alone formulas. */
         AV47Pgmdesc = "Data Mangement Platform";
         AV46Pgmname = "WWPBaseObjects.SecLogIn";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110T2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV7SecUserName = cgiGet( edtavSecusername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SecUserName", AV7SecUserName);
            AV8SecUserPassword = cgiGet( edtavSecuserpassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SecUserPassword", AV8SecUserPassword);
            /* Read saved values. */
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
         E110T2 ();
         if (returnInSub) return;
      }

      protected void E110T2( )
      {
         /* Start Routine */
         AV46Pgmname = "Data Mgmt Portal -RAAP";
         AV47Pgmdesc = "Data Mgmt Portal -RAAP";
         Form.Headerrawhtml = "<script>sessionStorage.clear(); </script>";
         AV10WebSession.Clear();
         divTableloginerror_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTableloginerror_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableloginerror_Visible), 5, 0)), true);
         divLayoutmaintable_Class = "MainContainerNoBackground";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divLayoutmaintable_Internalname, "Class", divLayoutmaintable_Class, true);
         AV18tClientAddress = StringUtil.Trim( AV13tHttprequest.GetHeader("X-Real_IP"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18tClientAddress", AV18tClientAddress);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTCLIENTADDRESS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tClientAddress, "")), context));
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E120T2 ();
         if (returnInSub) return;
      }

      protected void E120T2( )
      {
         /* Enter Routine */
         AV9LogInSuccessful = false;
         /* Using cursor H000T2 */
         pr_datastore1.execute(0, new Object[] {AV7SecUserName});
         while ( (pr_datastore1.getStatus(0) != 101) )
         {
            A417UserType = H000T2_A417UserType[0];
            A364Account = H000T2_A364Account[0];
            A418PasswordHash = H000T2_A418PasswordHash[0];
            A359UserID = (Guid)((Guid)(H000T2_A359UserID[0]));
            A416DisplayName = H000T2_A416DisplayName[0];
            AV27tConbination = StringUtil.Trim( AV7SecUserName) + StringUtil.Trim( AV8SecUserPassword);
            if ( StringUtil.StrCmp(StringUtil.Trim( StringUtil.Lower( new SdtMd5(context).getstringmd5(AV27tConbination))), StringUtil.Trim( A418PasswordHash)) == 0 )
            {
               AV9LogInSuccessful = true;
               AV29tUserID = (Guid)(A359UserID);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29tUserID", AV29tUserID.ToString());
               AV42tDisplayName = A416DisplayName;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42tDisplayName", AV42tDisplayName);
               AV38tUserType = StringUtil.Str( (decimal)(A417UserType), 9, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38tUserType", AV38tUserType);
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_datastore1.close(0);
         if ( AV9LogInSuccessful )
         {
            GX_msglist.addItem("登录成功!");
            AV12WWPContext.gxTpr_Username = AV7SecUserName;
            AV12WWPContext.gxTpr_Userdisplayname = AV42tDisplayName;
            AV12WWPContext.gxTpr_Userguid = StringUtil.Trim( AV29tUserID.ToString());
            AV12WWPContext.gxTpr_Usertype = (short)(NumberUtil.Val( AV38tUserType, "."));
            new GeneXus.Programs.wwpbaseobjects.setwwpcontextincludecookie(context ).execute(  AV12WWPContext,  AV18tClientAddress,  AV29tUserID,  AV42tDisplayName, out  AV32oCode, out  AV38tUserType) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18tClientAddress", AV18tClientAddress);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTCLIENTADDRESS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tClientAddress, "")), context));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29tUserID", AV29tUserID.ToString());
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42tDisplayName", AV42tDisplayName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38tUserType", AV38tUserType);
            AV31oTenantsCode.FromJSonString(AV32oCode, null);
            AV39BCManageXT_Config.Load(3);
            AV40BCSanageXT_Config.Load(4);
            divTableloginerror_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTableloginerror_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableloginerror_Visible), 5, 0)), true);
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV21returnurl)) )
            {
               if ( AV12WWPContext.gxTpr_Usertype == 0 )
               {
                  AV24tTargetUrl = StringUtil.Trim( AV40BCSanageXT_Config.gxTpr_Xt_configvalue4);
                  CallWebObject(formatLink(AV24tTargetUrl) );
                  context.wjLocDisableFrm = 0;
               }
               else
               {
                  if ( AV31oTenantsCode.Count <= 1 )
                  {
                     AV24tTargetUrl = StringUtil.Trim( AV39BCManageXT_Config.gxTpr_Xt_configvalue2);
                     CallWebObject(formatLink(AV24tTargetUrl) );
                     context.wjLocDisableFrm = 0;
                  }
                  else
                  {
                     AV24tTargetUrl = StringUtil.Trim( AV40BCSanageXT_Config.gxTpr_Xt_configvalue4);
                     CallWebObject(formatLink(AV24tTargetUrl) );
                     context.wjLocDisableFrm = 0;
                  }
               }
            }
            else
            {
               AV22tDirectUrl = StringUtil.Substring( AV21returnurl, 11, StringUtil.Len( AV21returnurl)-10);
               if ( AV12WWPContext.gxTpr_Usertype == 0 )
               {
                  AV24tTargetUrl = StringUtil.Trim( AV40BCSanageXT_Config.gxTpr_Xt_configvalue4) + "?returnurl=" + StringUtil.Trim( AV22tDirectUrl);
                  CallWebObject(formatLink(AV24tTargetUrl) );
                  context.wjLocDisableFrm = 0;
               }
               else
               {
                  if ( AV31oTenantsCode.Count <= 1 )
                  {
                     CallWebObject(formatLink(AV22tDirectUrl) );
                     context.wjLocDisableFrm = 0;
                  }
                  else
                  {
                     AV24tTargetUrl = StringUtil.Trim( AV40BCSanageXT_Config.gxTpr_Xt_configvalue4) + "?returnurl=" + StringUtil.Trim( AV22tDirectUrl);
                     CallWebObject(formatLink(AV24tTargetUrl) );
                     context.wjLocDisableFrm = 0;
                  }
               }
            }
         }
         else
         {
            divTableloginerror_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTableloginerror_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableloginerror_Visible), 5, 0)), true);
            GX_msglist.addItem("错误的 登录名/密码");
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12WWPContext", AV12WWPContext);
      }

      protected void nextLoad( )
      {
      }

      protected void E130T2( )
      {
         /* Load Routine */
      }

      protected void wb_table2_31_0T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtable3_Internalname, tblUnnamedtable3_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_34_0T2( true) ;
         }
         else
         {
            wb_table3_34_0T2( false) ;
         }
         return  ;
      }

      protected void wb_table3_34_0T2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_49_0T2( true) ;
         }
         else
         {
            wb_table4_49_0T2( false) ;
         }
         return  ;
      }

      protected void wb_table4_49_0T2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"Center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-Center;text-align:-moz-Center;text-align:-webkit-Center")+"\" class='DataContentCellLogin CellPaddingLogin'>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "Button_Login";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "登录", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecLogIn.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_31_0T2e( true) ;
         }
         else
         {
            wb_table2_31_0T2e( false) ;
         }
      }

      protected void wb_table4_49_0T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergeddas_loginpassword_Internalname, tblTablemergeddas_loginpassword_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Static images/pictures */
            ClassString = "Image_login";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "41142ffb-4d4a-49a2-955e-1b94836e6ada", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgDas_loginpassword_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\SecLogIn.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='DataContentCellLogin CellPaddingLogin'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablesecuserpassword_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblocksecuserpassword_Internalname, "", "", "", lblTextblocksecuserpassword_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataDescription", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecLogIn.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuserpassword_Internalname, "Sec User Password", "col-sm-3 AttributeLoginImageLeftLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuserpassword_Internalname, AV8SecUserPassword, StringUtil.RTrim( context.localUtil.Format( AV8SecUserPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "Password", edtavSecuserpassword_Jsonclick, 0, "AttributeLoginImageLeft", "", "", "", "", 1, edtavSecuserpassword_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, -1, 0, 0, 1, 0, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecLogIn.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_49_0T2e( true) ;
         }
         else
         {
            wb_table4_49_0T2e( false) ;
         }
      }

      protected void wb_table3_34_0T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergeddas_loginuser_Internalname, tblTablemergeddas_loginuser_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Static images/pictures */
            ClassString = "Image_login";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "079d3655-5c04-47b9-b127-825acbca336c", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgDas_loginuser_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\SecLogIn.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='DataContentCellLogin CellPaddingLogin'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablesecusername_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblocksecusername_Internalname, "", "", "", lblTextblocksecusername_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataDescriptionLogin", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecLogIn.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecusername_Internalname, "Sec User Name", "col-sm-3 AttributeLoginImageLeftLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecusername_Internalname, AV7SecUserName, StringUtil.RTrim( context.localUtil.Format( AV7SecUserName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "User ID", edtavSecusername_Jsonclick, 0, "AttributeLoginImageLeft", "", "", "", "", 1, edtavSecusername_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecLogIn.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_34_0T2e( true) ;
         }
         else
         {
            wb_table3_34_0T2e( false) ;
         }
      }

      protected void wb_table1_23_0T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtable2_Internalname, tblUnnamedtable2_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextcnlogin_Internalname, "用户登录", "", "", lblTextcnlogin_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock_UserloginCN", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecLogIn.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLogin_title_Internalname, "User Login", "", "", lblLogin_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock_Userlogin", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecLogIn.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_23_0T2e( true) ;
         }
         else
         {
            wb_table1_23_0T2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV21returnurl = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21returnurl", AV21returnurl);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV21returnurl, "")), context));
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
         PA0T2( ) ;
         WS0T2( ) ;
         WE0T2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281592227", true);
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
         context.AddJavascriptSource("wwpbaseobjects/seclogin.js", "?20202281592228", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblDesc_Internalname = "DESC";
         lblDescson_Internalname = "DESCSON";
         divUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         lblTextcnlogin_Internalname = "TEXTCNLOGIN";
         lblLogin_title_Internalname = "LOGIN_TITLE";
         tblUnnamedtable2_Internalname = "UNNAMEDTABLE2";
         imgDas_loginuser_Internalname = "DAS_LOGINUSER";
         lblTextblocksecusername_Internalname = "TEXTBLOCKSECUSERNAME";
         edtavSecusername_Internalname = "vSECUSERNAME";
         divUnnamedtablesecusername_Internalname = "UNNAMEDTABLESECUSERNAME";
         tblTablemergeddas_loginuser_Internalname = "TABLEMERGEDDAS_LOGINUSER";
         imgDas_loginpassword_Internalname = "DAS_LOGINPASSWORD";
         lblTextblocksecuserpassword_Internalname = "TEXTBLOCKSECUSERPASSWORD";
         edtavSecuserpassword_Internalname = "vSECUSERPASSWORD";
         divUnnamedtablesecuserpassword_Internalname = "UNNAMEDTABLESECUSERPASSWORD";
         tblTablemergeddas_loginpassword_Internalname = "TABLEMERGEDDAS_LOGINPASSWORD";
         bttBtnenter_Internalname = "BTNENTER";
         tblUnnamedtable3_Internalname = "UNNAMEDTABLE3";
         divTablelogin_Internalname = "TABLELOGIN";
         divTableloginerror_Internalname = "TABLELOGINERROR";
         divTablelogincontent_Internalname = "TABLELOGINCONTENT";
         divTablemain_Internalname = "TABLEMAIN";
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
         edtavSecusername_Jsonclick = "";
         edtavSecusername_Enabled = 1;
         edtavSecuserpassword_Jsonclick = "";
         edtavSecuserpassword_Enabled = 1;
         divTableloginerror_Visible = 1;
         divLayoutmaintable_Class = "Table";
         Form.Headerrawhtml = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV21returnurl',fld:'vRETURNURL',pic:'',hsh:true},{av:'AV18tClientAddress',fld:'vTCLIENTADDRESS',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E120T2',iparms:[{av:'A364Account',fld:'ACCOUNT',pic:''},{av:'AV7SecUserName',fld:'vSECUSERNAME',pic:''},{av:'A417UserType',fld:'USERTYPE',pic:'ZZZZZZZZ9'},{av:'AV8SecUserPassword',fld:'vSECUSERPASSWORD',pic:''},{av:'A418PasswordHash',fld:'PASSWORDHASH',pic:''},{av:'A359UserID',fld:'USERID',pic:''},{av:'A416DisplayName',fld:'DISPLAYNAME',pic:''},{av:'AV12WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV42tDisplayName',fld:'vTDISPLAYNAME',pic:''},{av:'AV29tUserID',fld:'vTUSERID',pic:''},{av:'AV38tUserType',fld:'vTUSERTYPE',pic:''},{av:'AV18tClientAddress',fld:'vTCLIENTADDRESS',pic:'',hsh:true},{av:'AV21returnurl',fld:'vRETURNURL',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV29tUserID',fld:'vTUSERID',pic:''},{av:'AV42tDisplayName',fld:'vTDISPLAYNAME',pic:''},{av:'AV38tUserType',fld:'vTUSERTYPE',pic:''},{av:'AV12WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'divTableloginerror_Visible',ctrl:'TABLELOGINERROR',prop:'Visible'}]}");
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
         wcpOAV21returnurl = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV47Pgmdesc = "";
         AV46Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         A364Account = "";
         A418PasswordHash = "";
         A359UserID = (Guid)(Guid.Empty);
         A416DisplayName = "";
         AV12WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV42tDisplayName = "";
         AV29tUserID = (Guid)(Guid.Empty);
         AV38tUserType = "";
         AV18tClientAddress = "";
         GX_FocusControl = "";
         sPrefix = "";
         lblDesc_Jsonclick = "";
         lblDescson_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV7SecUserName = "";
         AV8SecUserPassword = "";
         AV10WebSession = context.GetSession();
         AV13tHttprequest = new GxHttpRequest( context);
         scmdbuf = "";
         H000T2_A417UserType = new int[1] ;
         H000T2_A364Account = new String[] {""} ;
         H000T2_A418PasswordHash = new String[] {""} ;
         H000T2_A359UserID = new Guid[] {Guid.Empty} ;
         H000T2_A416DisplayName = new String[] {""} ;
         AV27tConbination = "";
         AV32oCode = "";
         AV31oTenantsCode = new GxSimpleCollection<String>();
         AV39BCManageXT_Config = new SdtXT_Config(context);
         AV40BCSanageXT_Config = new SdtXT_Config(context);
         AV24tTargetUrl = "";
         AV22tDirectUrl = "";
         sStyleString = "";
         TempTags = "";
         bttBtnenter_Jsonclick = "";
         sImgUrl = "";
         lblTextblocksecuserpassword_Jsonclick = "";
         lblTextblocksecusername_Jsonclick = "";
         lblTextcnlogin_Jsonclick = "";
         lblLogin_title_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.seclogin__datastore1(),
            new Object[][] {
                new Object[] {
               H000T2_A417UserType, H000T2_A364Account, H000T2_A418PasswordHash, H000T2_A359UserID, H000T2_A416DisplayName
               }
            }
         );
         AV47Pgmdesc = "Data Mangement Platform";
         AV46Pgmname = "WWPBaseObjects.SecLogIn";
         /* GeneXus formulas. */
         AV47Pgmdesc = "Data Mangement Platform";
         AV46Pgmname = "WWPBaseObjects.SecLogIn";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int A417UserType ;
      private int divTableloginerror_Visible ;
      private int edtavSecuserpassword_Enabled ;
      private int edtavSecusername_Enabled ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String AV47Pgmdesc ;
      private String AV46Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divLayoutmaintable_Class ;
      private String divTablemain_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String lblDesc_Internalname ;
      private String lblDesc_Jsonclick ;
      private String lblDescson_Internalname ;
      private String lblDescson_Jsonclick ;
      private String divTablelogincontent_Internalname ;
      private String divTablelogin_Internalname ;
      private String divTableloginerror_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavSecusername_Internalname ;
      private String edtavSecuserpassword_Internalname ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblUnnamedtable3_Internalname ;
      private String TempTags ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String tblTablemergeddas_loginpassword_Internalname ;
      private String sImgUrl ;
      private String imgDas_loginpassword_Internalname ;
      private String divUnnamedtablesecuserpassword_Internalname ;
      private String lblTextblocksecuserpassword_Internalname ;
      private String lblTextblocksecuserpassword_Jsonclick ;
      private String edtavSecuserpassword_Jsonclick ;
      private String tblTablemergeddas_loginuser_Internalname ;
      private String imgDas_loginuser_Internalname ;
      private String divUnnamedtablesecusername_Internalname ;
      private String lblTextblocksecusername_Internalname ;
      private String lblTextblocksecusername_Jsonclick ;
      private String edtavSecusername_Jsonclick ;
      private String tblUnnamedtable2_Internalname ;
      private String lblTextcnlogin_Internalname ;
      private String lblTextcnlogin_Jsonclick ;
      private String lblLogin_title_Internalname ;
      private String lblLogin_title_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV9LogInSuccessful ;
      private String AV21returnurl ;
      private String wcpOAV21returnurl ;
      private String A364Account ;
      private String A418PasswordHash ;
      private String A416DisplayName ;
      private String AV42tDisplayName ;
      private String AV38tUserType ;
      private String AV18tClientAddress ;
      private String AV7SecUserName ;
      private String AV8SecUserPassword ;
      private String AV27tConbination ;
      private String AV32oCode ;
      private String AV24tTargetUrl ;
      private String AV22tDirectUrl ;
      private Guid A359UserID ;
      private Guid AV29tUserID ;
      private GxHttpRequest AV13tHttprequest ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private int[] H000T2_A417UserType ;
      private String[] H000T2_A364Account ;
      private String[] H000T2_A418PasswordHash ;
      private Guid[] H000T2_A359UserID ;
      private String[] H000T2_A416DisplayName ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IGxSession AV10WebSession ;
      private GxSimpleCollection<String> AV31oTenantsCode ;
      private SdtXT_Config AV39BCManageXT_Config ;
      private SdtXT_Config AV40BCSanageXT_Config ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV12WWPContext ;
   }

   public class seclogin__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000T2 ;
          prmH000T2 = new Object[] {
          new Object[] {"@AV7SecUserName",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000T2", "SELECT [UserType], [Account], [PasswordHash], [UserID], [DisplayName] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE ([Account] = @AV7SecUserName) AND ([UserType] <> -1) ORDER BY [Account] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000T2,1,0,false,true )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((Guid[]) buf[3])[0] = rslt.getGuid(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

}
