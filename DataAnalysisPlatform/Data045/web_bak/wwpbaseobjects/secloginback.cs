/*
               File: WWPBaseObjects.SecLogInBack
        Description: Log In
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:47:12.59
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
   public class secloginback : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public secloginback( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secloginback( IGxContext context )
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
         this.AV12returnurl = aP0_returnurl;
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
               AV12returnurl = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12returnurl", AV12returnurl);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV12returnurl, "")), context));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpageap", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpageap", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
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

      public override short ExecuteStartEvent( )
      {
         PA852( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START852( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202279471264", false);
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
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secloginback.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12returnurl))+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
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
         GxWebStd.gx_hidden_field( context, "PASSWORDHASH", A418PasswordHash);
         GxWebStd.gx_hidden_field( context, "USERID", A359UserID.ToString());
         GxWebStd.gx_hidden_field( context, "DISPLAYNAME", A416DisplayName);
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vWWPCONTEXT", AV32WWPContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vWWPCONTEXT", AV32WWPContext);
         }
         GxWebStd.gx_hidden_field( context, "vTDISPLAYNAME", AV36tDisplayName);
         GxWebStd.gx_hidden_field( context, "vTUSERID", AV29tUserID.ToString());
         GxWebStd.gx_hidden_field( context, "vTCLIENTADDRESS", AV18tClientAddress);
         GxWebStd.gx_hidden_field( context, "gxhash_vTCLIENTADDRESS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tClientAddress, "")), context));
         GxWebStd.gx_hidden_field( context, "vRETURNURL", AV12returnurl);
         GxWebStd.gx_hidden_field( context, "gxhash_vRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV12returnurl, "")), context));
      }

      public override void RenderHtmlCloseForm( )
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
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE852( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT852( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wwpbaseobjects.secloginback.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12returnurl)) ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecLogInBack" ;
      }

      public override String GetPgmdesc( )
      {
         return "Log In" ;
      }

      protected void WB850( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", divLayoutmaintable_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "Table100x100H", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginLogin", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Static images/pictures */
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f0e23749-fbda-4089-ae28-d2796da03b9a", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgLogologin_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\SecLogInBack.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablelogin_Internalname, 1, 0, "px", 0, "px", "TableLogin", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblSignin_Internalname, "用户登录", "", "", lblSignin_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockTitleLogin", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecLogInBack.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            wb_table1_21_852( true) ;
         }
         else
         {
            wb_table1_21_852( false) ;
         }
         return  ;
      }

      protected void wb_table1_21_852e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableloginerror_Internalname, divTableloginerror_Visible, 0, "px", 0, "px", "TableLoginError", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_end( context, "Center", "top", "div");
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

      protected void START852( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Log In", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP850( ) ;
      }

      protected void WS852( )
      {
         START852( ) ;
         EVT852( ) ;
      }

      protected void EVT852( )
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
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
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
                              E11852 ();
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
                                    E12852 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E13852 ();
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
      }

      protected void WE852( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA852( )
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
         RF852( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF852( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E13852 ();
            WB850( ) ;
         }
      }

      protected void send_integrity_lvl_hashes852( )
      {
         GxWebStd.gx_hidden_field( context, "vTCLIENTADDRESS", AV18tClientAddress);
         GxWebStd.gx_hidden_field( context, "gxhash_vTCLIENTADDRESS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tClientAddress, "")), context));
         GxWebStd.gx_hidden_field( context, "vRETURNURL", AV12returnurl);
         GxWebStd.gx_hidden_field( context, "gxhash_vRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV12returnurl, "")), context));
      }

      protected void STRUP850( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11852 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV15SecUserName = cgiGet( edtavSecusername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SecUserName", AV15SecUserName);
            AV16SecUserPassword = cgiGet( edtavSecuserpassword_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16SecUserPassword", AV16SecUserPassword);
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
         E11852 ();
         if (returnInSub) return;
      }

      protected void E11852( )
      {
         /* Start Routine */
         Form.Headerrawhtml = "<script>sessionStorage.clear(); </script>";
         AV31WebSession.Clear();
         divTableloginerror_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTableloginerror_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableloginerror_Visible), 5, 0)), true);
         divLayoutmaintable_Class = "MainContainer";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divLayoutmaintable_Internalname, "Class", divLayoutmaintable_Class, true);
         AV18tClientAddress = StringUtil.Trim( AV23tHttprequest.GetHeader("X-Real_IP"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18tClientAddress", AV18tClientAddress);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTCLIENTADDRESS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tClientAddress, "")), context));
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E12852 ();
         if (returnInSub) return;
      }

      protected void E12852( )
      {
         /* Enter Routine */
         AV8LogInSuccessful = false;
         /* Using cursor H00852 */
         pr_datastore1.execute(0, new Object[] {AV15SecUserName});
         while ( (pr_datastore1.getStatus(0) != 101) )
         {
            A364Account = H00852_A364Account[0];
            A418PasswordHash = H00852_A418PasswordHash[0];
            A359UserID = (Guid)((Guid)(H00852_A359UserID[0]));
            A416DisplayName = H00852_A416DisplayName[0];
            AV19tConbination = StringUtil.Trim( AV15SecUserName) + StringUtil.Trim( AV16SecUserPassword);
            if ( StringUtil.StrCmp(StringUtil.Trim( StringUtil.Lower( new SdtMd5(context).getstringmd5(AV19tConbination))), StringUtil.Trim( A418PasswordHash)) == 0 )
            {
               AV8LogInSuccessful = true;
               AV29tUserID = (Guid)(A359UserID);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29tUserID", AV29tUserID.ToString());
               AV36tDisplayName = A416DisplayName;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36tDisplayName", AV36tDisplayName);
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_datastore1.close(0);
         if ( AV8LogInSuccessful )
         {
            GX_msglist.addItem("登录成功!");
            AV32WWPContext.gxTpr_Username = AV15SecUserName;
            AV32WWPContext.gxTpr_Userdisplayname = AV36tDisplayName;
            AV32WWPContext.gxTpr_Userguid = StringUtil.Trim( AV29tUserID.ToString());
            new GeneXus.Programs.wwpbaseobjects.setwwpcontextincludecookie(context ).execute(  AV32WWPContext,  AV18tClientAddress,  AV29tUserID,  AV36tDisplayName, out  AV9oCode, out  AV30tUserType) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18tClientAddress", AV18tClientAddress);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTCLIENTADDRESS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tClientAddress, "")), context));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29tUserID", AV29tUserID.ToString());
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36tDisplayName", AV36tDisplayName);
            AV11oTenantsCode.FromJSonString(AV9oCode, null);
            AV33BCManageXT_Config.Load(3);
            AV34BCSanageXT_Config.Load(4);
            divTableloginerror_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTableloginerror_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableloginerror_Visible), 5, 0)), true);
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12returnurl)) )
            {
               if ( StringUtil.StrCmp(StringUtil.Trim( AV30tUserType), "0") == 0 )
               {
                  AV28tTargetUrl = StringUtil.Trim( AV34BCSanageXT_Config.gxTpr_Xt_configvalue4);
                  CallWebObject(formatLink(AV28tTargetUrl) );
                  context.wjLocDisableFrm = 0;
               }
               else
               {
                  if ( AV11oTenantsCode.Count <= 1 )
                  {
                     AV28tTargetUrl = StringUtil.Trim( AV33BCManageXT_Config.gxTpr_Xt_configvalue2);
                     CallWebObject(formatLink(AV28tTargetUrl) );
                     context.wjLocDisableFrm = 0;
                  }
                  else
                  {
                     AV28tTargetUrl = StringUtil.Trim( AV34BCSanageXT_Config.gxTpr_Xt_configvalue4);
                     CallWebObject(formatLink(AV28tTargetUrl) );
                     context.wjLocDisableFrm = 0;
                  }
               }
            }
            else
            {
               AV20tDirectUrl = StringUtil.Substring( AV12returnurl, 11, StringUtil.Len( AV12returnurl)-10);
               if ( StringUtil.StrCmp(StringUtil.Trim( AV30tUserType), "0") == 0 )
               {
                  AV28tTargetUrl = StringUtil.Trim( AV34BCSanageXT_Config.gxTpr_Xt_configvalue4) + "?returnurl=" + StringUtil.Trim( AV20tDirectUrl);
                  CallWebObject(formatLink(AV28tTargetUrl) );
                  context.wjLocDisableFrm = 0;
               }
               else
               {
                  if ( AV11oTenantsCode.Count <= 1 )
                  {
                     CallWebObject(formatLink(AV20tDirectUrl) );
                     context.wjLocDisableFrm = 0;
                  }
                  else
                  {
                     AV28tTargetUrl = StringUtil.Trim( AV34BCSanageXT_Config.gxTpr_Xt_configvalue4) + "?returnurl=" + StringUtil.Trim( AV20tDirectUrl);
                     CallWebObject(formatLink(AV28tTargetUrl) );
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32WWPContext", AV32WWPContext);
      }

      protected void nextLoad( )
      {
      }

      protected void E13852( )
      {
         /* Load Routine */
      }

      protected void wb_table1_21_852( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtable1_Internalname, tblUnnamedtable1_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='DataContentCellLogin CellPaddingLogin'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecusername_Internalname, "Sec User Name", "col-sm-3 AttributeLoginLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecusername_Internalname, AV15SecUserName, StringUtil.RTrim( context.localUtil.Format( AV15SecUserName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请输入用户名", edtavSecusername_Jsonclick, 0, "AttributeLogin", "", "", "", "", 1, edtavSecusername_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecLogInBack.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='DataContentCellLogin CellPaddingLogin'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuserpassword_Internalname, "Sec User Password", "col-sm-3 AttributeLoginLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuserpassword_Internalname, AV16SecUserPassword, StringUtil.RTrim( context.localUtil.Format( AV16SecUserPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请输入密码", edtavSecuserpassword_Jsonclick, 0, "AttributeLogin", "", "", "", "", 1, edtavSecuserpassword_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, -1, 0, 0, 1, 0, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecLogInBack.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='TableActionsCellLogin'>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "登录", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecLogInBack.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_21_852e( true) ;
         }
         else
         {
            wb_table1_21_852e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12returnurl = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12returnurl", AV12returnurl);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV12returnurl, "")), context));
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
         PA852( ) ;
         WS852( ) ;
         WE852( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279471298", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secloginback.js", "?20202279471299", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         imgLogologin_Internalname = "LOGOLOGIN";
         lblSignin_Internalname = "SIGNIN";
         edtavSecusername_Internalname = "vSECUSERNAME";
         edtavSecuserpassword_Internalname = "vSECUSERPASSWORD";
         bttBtnenter_Internalname = "BTNENTER";
         tblUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divTablelogin_Internalname = "TABLELOGIN";
         divTableloginerror_Internalname = "TABLELOGINERROR";
         divTablecontent_Internalname = "TABLECONTENT";
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
         edtavSecuserpassword_Jsonclick = "";
         edtavSecuserpassword_Enabled = 1;
         edtavSecusername_Jsonclick = "";
         edtavSecusername_Enabled = 1;
         divTableloginerror_Visible = 1;
         divLayoutmaintable_Class = "Table";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Log In";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV12returnurl',fld:'vRETURNURL',pic:'',hsh:true},{av:'AV18tClientAddress',fld:'vTCLIENTADDRESS',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E12852',iparms:[{av:'A364Account',fld:'ACCOUNT',pic:''},{av:'AV15SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV16SecUserPassword',fld:'vSECUSERPASSWORD',pic:''},{av:'A418PasswordHash',fld:'PASSWORDHASH',pic:''},{av:'A359UserID',fld:'USERID',pic:''},{av:'A416DisplayName',fld:'DISPLAYNAME',pic:''},{av:'AV32WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV36tDisplayName',fld:'vTDISPLAYNAME',pic:''},{av:'AV29tUserID',fld:'vTUSERID',pic:''},{av:'AV18tClientAddress',fld:'vTCLIENTADDRESS',pic:'',hsh:true},{av:'AV12returnurl',fld:'vRETURNURL',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV29tUserID',fld:'vTUSERID',pic:''},{av:'AV36tDisplayName',fld:'vTDISPLAYNAME',pic:''},{av:'AV32WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'divTableloginerror_Visible',ctrl:'TABLELOGINERROR',prop:'Visible'}]}");
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
         wcpOAV12returnurl = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         A364Account = "";
         A418PasswordHash = "";
         A359UserID = (Guid)(Guid.Empty);
         A416DisplayName = "";
         AV32WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV36tDisplayName = "";
         AV29tUserID = (Guid)(Guid.Empty);
         AV18tClientAddress = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         sImgUrl = "";
         lblSignin_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15SecUserName = "";
         AV16SecUserPassword = "";
         AV31WebSession = context.GetSession();
         AV23tHttprequest = new GxHttpRequest( context);
         scmdbuf = "";
         H00852_A364Account = new String[] {""} ;
         H00852_A418PasswordHash = new String[] {""} ;
         H00852_A359UserID = new Guid[] {Guid.Empty} ;
         H00852_A416DisplayName = new String[] {""} ;
         AV19tConbination = "";
         AV9oCode = "";
         AV30tUserType = "";
         AV11oTenantsCode = new GxSimpleCollection<String>();
         AV33BCManageXT_Config = new SdtXT_Config(context);
         AV34BCSanageXT_Config = new SdtXT_Config(context);
         AV28tTargetUrl = "";
         AV20tDirectUrl = "";
         sStyleString = "";
         TempTags = "";
         bttBtnenter_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secloginback__datastore1(),
            new Object[][] {
                new Object[] {
               H00852_A364Account, H00852_A418PasswordHash, H00852_A359UserID, H00852_A416DisplayName
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int divTableloginerror_Visible ;
      private int edtavSecusername_Enabled ;
      private int edtavSecuserpassword_Enabled ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divLayoutmaintable_Class ;
      private String divTablemain_Internalname ;
      private String divTablecontent_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String sImgUrl ;
      private String imgLogologin_Internalname ;
      private String divTablelogin_Internalname ;
      private String lblSignin_Internalname ;
      private String lblSignin_Jsonclick ;
      private String divTableloginerror_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavSecusername_Internalname ;
      private String edtavSecuserpassword_Internalname ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblUnnamedtable1_Internalname ;
      private String TempTags ;
      private String edtavSecusername_Jsonclick ;
      private String edtavSecuserpassword_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV8LogInSuccessful ;
      private String AV12returnurl ;
      private String wcpOAV12returnurl ;
      private String A364Account ;
      private String A418PasswordHash ;
      private String A416DisplayName ;
      private String AV36tDisplayName ;
      private String AV18tClientAddress ;
      private String AV15SecUserName ;
      private String AV16SecUserPassword ;
      private String AV19tConbination ;
      private String AV9oCode ;
      private String AV30tUserType ;
      private String AV28tTargetUrl ;
      private String AV20tDirectUrl ;
      private Guid A359UserID ;
      private Guid AV29tUserID ;
      private GxHttpRequest AV23tHttprequest ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] H00852_A364Account ;
      private String[] H00852_A418PasswordHash ;
      private Guid[] H00852_A359UserID ;
      private String[] H00852_A416DisplayName ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IGxSession AV31WebSession ;
      private GxSimpleCollection<String> AV11oTenantsCode ;
      private GXWebForm Form ;
      private SdtXT_Config AV33BCManageXT_Config ;
      private SdtXT_Config AV34BCSanageXT_Config ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV32WWPContext ;
   }

   public class secloginback__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00852 ;
          prmH00852 = new Object[] {
          new Object[] {"@AV15SecUserName",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00852", "SELECT [Account], [PasswordHash], [UserID], [DisplayName] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [Account] = @AV15SecUserName ORDER BY [Account] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00852,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((Guid[]) buf[2])[0] = rslt.getGuid(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
