/*
               File: BR_ChooseTenent
        Description: Data Mangement Platform
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:6:18.37
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
   public class br_choosetenent : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_choosetenent( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_choosetenent( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_iReturnUrl )
      {
         this.AV28iReturnUrl = aP0_iReturnUrl;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Tenentsshow") == 0 )
            {
               nRC_GXsfl_15 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_15_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_15_idx = GetNextPar( );
               edtavVcode_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVcode_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVcode_Visible), 5, 0)), !bGXsfl_15_Refreshing);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrTenentsshow_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Tenentsshow") == 0 )
            {
               edtavVcode_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVcode_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVcode_Visible), 5, 0)), !bGXsfl_15_Refreshing);
               AV36tUserType = GetNextPar( );
               A401BAS_TenantIsDeleted = (short)(NumberUtil.Val( GetNextPar( ), "."));
               A395HospitalName = GetNextPar( );
               A360BAS_TenantTenantCode = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV12iTenantsCode);
               AV28iReturnUrl = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrTenentsshow_refresh( AV36tUserType, A401BAS_TenantIsDeleted, A395HospitalName, A360BAS_TenantTenantCode, AV12iTenantsCode, AV28iReturnUrl) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
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
               AV28iReturnUrl = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28iReturnUrl", AV28iReturnUrl);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV28iReturnUrl, "")), context));
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
         PA7L2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START7L2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271261854", false);
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
         FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_choosetenent.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV28iReturnUrl))+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         }
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
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_15", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_15), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vTUSERTYPE", AV36tUserType);
         GxWebStd.gx_hidden_field( context, "gxhash_vTUSERTYPE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV36tUserType, "")), context));
         GxWebStd.gx_hidden_field( context, "BAS_TENANTISDELETED", StringUtil.LTrim( StringUtil.NToC( (decimal)(A401BAS_TenantIsDeleted), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "HOSPITALNAME", A395HospitalName);
         GxWebStd.gx_hidden_field( context, "BAS_TENANTTENANTCODE", A360BAS_TenantTenantCode);
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vITENANTSCODE", AV12iTenantsCode);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vITENANTSCODE", AV12iTenantsCode);
         }
         GxWebStd.gx_hidden_field( context, "vIRETURNURL", AV28iReturnUrl);
         GxWebStd.gx_hidden_field( context, "gxhash_vIRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV28iReturnUrl, "")), context));
         GxWebStd.gx_hidden_field( context, "vVCODE_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavVcode_Visible), 5, 0, ".", "")));
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
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
            WE7L2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT7L2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("br_choosetenent.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV28iReturnUrl)) ;
      }

      public override String GetPgmname( )
      {
         return "BR_ChooseTenent" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mangement Platform" ;
      }

      protected void WB7L0( )
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
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableChooseTenants", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblChoosetenant_Internalname, "选择租户", "", "", lblChoosetenant_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockTitleLogin", 0, "", 1, 1, 0, "HLP_BR_ChooseTenent.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            TenentsshowContainer.SetIsFreestyle(true);
            TenentsshowContainer.SetWrapped(nGXWrapped);
            if ( TenentsshowContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"TenentsshowContainer"+"DivS\" data-gxgridid=\"15\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subTenentsshow_Internalname, subTenentsshow_Internalname, "", "FreeStyleGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               TenentsshowContainer.AddObjectProperty("GridName", "Tenentsshow");
            }
            else
            {
               TenentsshowContainer.AddObjectProperty("GridName", "Tenentsshow");
               TenentsshowContainer.AddObjectProperty("Header", subTenentsshow_Header);
               TenentsshowContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
               TenentsshowContainer.AddObjectProperty("Class", "FreeStyleGrid");
               TenentsshowContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               TenentsshowContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               TenentsshowContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTenentsshow_Backcolorstyle), 1, 0, ".", "")));
               TenentsshowContainer.AddObjectProperty("CmpContext", "");
               TenentsshowContainer.AddObjectProperty("InMasterPage", "false");
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowColumn.AddObjectProperty("Value", lblTextblockvhosiptalname_Caption);
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowColumn.AddObjectProperty("Value", AV7vHosiptalName);
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               TenentsshowColumn.AddObjectProperty("Value", AV19vCode);
               TenentsshowColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavVcode_Visible), 5, 0, ".", "")));
               TenentsshowContainer.AddColumnProperties(TenentsshowColumn);
               TenentsshowContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTenentsshow_Selectedindex), 4, 0, ".", "")));
               TenentsshowContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTenentsshow_Allowselection), 1, 0, ".", "")));
               TenentsshowContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTenentsshow_Selectioncolor), 9, 0, ".", "")));
               TenentsshowContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTenentsshow_Allowhovering), 1, 0, ".", "")));
               TenentsshowContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTenentsshow_Hoveringcolor), 9, 0, ".", "")));
               TenentsshowContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTenentsshow_Allowcollapsing), 1, 0, ".", "")));
               TenentsshowContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTenentsshow_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 15 )
         {
            wbEnd = 0;
            nRC_GXsfl_15 = (short)(nGXsfl_15_idx-1);
            if ( TenentsshowContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"TenentsshowContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Tenentsshow", TenentsshowContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "TenentsshowContainerData", TenentsshowContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "TenentsshowContainerData"+"V", TenentsshowContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"TenentsshowContainerData"+"V"+"\" value='"+TenentsshowContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 15 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( TenentsshowContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"TenentsshowContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Tenentsshow", TenentsshowContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "TenentsshowContainerData", TenentsshowContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "TenentsshowContainerData"+"V", TenentsshowContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"TenentsshowContainerData"+"V"+"\" value='"+TenentsshowContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START7L2( )
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
         STRUP7L0( ) ;
      }

      protected void WS7L2( )
      {
         START7L2( ) ;
         EVT7L2( ) ;
      }

      protected void EVT7L2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "HOSPITALDISTRICT.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E117L2 ();
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
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 16), "TENENTSSHOW.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 22), "HOSPITALDISTRICT.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_15_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
                              SubsflControlProps_152( ) ;
                              AV7vHosiptalName = cgiGet( edtavVhosiptalname_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavVhosiptalname_Internalname, AV7vHosiptalName);
                              AV19vCode = cgiGet( edtavVcode_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavVcode_Internalname, AV19vCode);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E127L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "TENENTSSHOW.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E137L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "HOSPITALDISTRICT.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E117L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE7L2( )
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

      protected void PA7L2( )
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
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrTenentsshow_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_152( ) ;
         while ( nGXsfl_15_idx <= nRC_GXsfl_15 )
         {
            sendrow_152( ) ;
            nGXsfl_15_idx = (short)(((subTenentsshow_Islastpage==1)&&(nGXsfl_15_idx+1>subTenentsshow_Recordsperpage( )) ? 1 : nGXsfl_15_idx+1));
            sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
            SubsflControlProps_152( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( TenentsshowContainer));
         /* End function gxnrTenentsshow_newrow */
      }

      protected void gxgrTenentsshow_refresh( String AV36tUserType ,
                                              short A401BAS_TenantIsDeleted ,
                                              String A395HospitalName ,
                                              String A360BAS_TenantTenantCode ,
                                              GxSimpleCollection<String> AV12iTenantsCode ,
                                              String AV28iReturnUrl )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         TENENTSSHOW_nCurrentRecord = 0;
         RF7L2( ) ;
         /* End function gxgrTenentsshow_refresh */
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
         RF7L2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV60Pgmdesc = "Data Mangement Platform";
         AV59Pgmname = "BR_ChooseTenent";
         context.Gx_err = 0;
      }

      protected void RF7L2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            TenentsshowContainer.ClearRows();
         }
         wbStart = 15;
         nGXsfl_15_idx = 1;
         sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
         SubsflControlProps_152( ) ;
         bGXsfl_15_Refreshing = true;
         TenentsshowContainer.AddObjectProperty("GridName", "Tenentsshow");
         TenentsshowContainer.AddObjectProperty("CmpContext", "");
         TenentsshowContainer.AddObjectProperty("InMasterPage", "false");
         TenentsshowContainer.AddObjectProperty("Class", StringUtil.RTrim( "FreeStyleGrid"));
         TenentsshowContainer.AddObjectProperty("Class", "FreeStyleGrid");
         TenentsshowContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         TenentsshowContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         TenentsshowContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subTenentsshow_Backcolorstyle), 1, 0, ".", "")));
         TenentsshowContainer.PageSize = subTenentsshow_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_152( ) ;
            E137L2 ();
            wbEnd = 15;
            WB7L0( ) ;
         }
         bGXsfl_15_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes7L2( )
      {
         GxWebStd.gx_hidden_field( context, "vTUSERTYPE", AV36tUserType);
         GxWebStd.gx_hidden_field( context, "gxhash_vTUSERTYPE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV36tUserType, "")), context));
         GxWebStd.gx_hidden_field( context, "vIRETURNURL", AV28iReturnUrl);
         GxWebStd.gx_hidden_field( context, "gxhash_vIRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV28iReturnUrl, "")), context));
      }

      protected int subTenentsshow_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subTenentsshow_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subTenentsshow_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subTenentsshow_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP7L0( )
      {
         /* Before Start, stand alone formulas. */
         AV60Pgmdesc = "Data Mangement Platform";
         AV59Pgmname = "BR_ChooseTenent";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E127L2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_15 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_15"), ".", ","));
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
         E127L2 ();
         if (returnInSub) return;
      }

      protected void E127L2( )
      {
         /* Start Routine */
         AV59Pgmname = "Data Mgmt Portal -RAAP";
         AV60Pgmdesc = "Data Mgmt Portal -RAAP";
         AV11tCookieContent = context.GetCookie( "DAS_LoginUser");
         if ( String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11tCookieContent))) )
         {
            new wb_logout(context ).execute( out  AV38tFlag) ;
            AV16BCXT_Config.Load(4);
            AV17tTargetUrl = StringUtil.Trim( AV16BCXT_Config.gxTpr_Xt_configvalue2);
            CallWebObject(formatLink(AV17tTargetUrl) );
            context.wjLocDisableFrm = 0;
         }
         AV40BCNewXT_Config.Load(6);
         AV41tTargetAPI = StringUtil.Trim( AV40BCNewXT_Config.gxTpr_Xt_configvalue3);
         AV29httpclient.Host = AV41tTargetAPI;
         AV29httpclient.AddHeader("Connection", "keep-alive");
         AV29httpclient.AddHeader("Content-Type", "application/json; charset=utf-8");
         AV30tCookieCon = "DAS_LoginUser=" + StringUtil.Trim( AV11tCookieContent) + ";";
         AV29httpclient.AddHeader("Cookie", AV30tCookieCon);
         AV32tUserInfo = AV33JWTDecode.decode(AV11tCookieContent);
         AV32tUserInfo = StringUtil.StringReplace( StringUtil.Substring( AV32tUserInfo, 2, StringUtil.Len( AV32tUserInfo)-2), "\\", "");
         AV32tUserInfo = "{" + StringUtil.Trim( AV32tUserInfo) + "}";
         AV31tSDT_JWT.FromJSonString(AV32tUserInfo, null);
         AV29httpclient.Execute("Get", "/api/User/getpermission?userid="+StringUtil.Trim( AV31tSDT_JWT.gxTpr_Userid));
         AV21tResult = StringUtil.Trim( AV29httpclient.ToString());
         AV20tSDT_MicroUserInfo.FromJSonString(AV21tResult, null);
         AV12iTenantsCode.Clear();
         AV22i = 1;
         while ( AV22i <= AV20tSDT_MicroUserInfo.gxTpr_Tenants.Count )
         {
            AV12iTenantsCode.Add(StringUtil.Trim( ((SdtSDT_MicroUserInfo_Tenants)AV20tSDT_MicroUserInfo.gxTpr_Tenants.Item(AV22i)).gxTpr_Code), 0);
            AV22i = (short)(AV22i+1);
         }
         AV36tUserType = StringUtil.Str( (decimal)(AV20tSDT_MicroUserInfo.gxTpr_Usertype), 4, 0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36tUserType", AV36tUserType);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTUSERTYPE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV36tUserType, "")), context));
         edtavVcode_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVcode_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVcode_Visible), 5, 0)), !bGXsfl_15_Refreshing);
      }

      private void E137L2( )
      {
         /* Tenentsshow_Load Routine */
         if ( StringUtil.StrCmp(StringUtil.Trim( AV36tUserType), "0") == 0 )
         {
            /* Using cursor H007L2 */
            pr_datastore1.execute(0);
            while ( (pr_datastore1.getStatus(0) != 101) )
            {
               A401BAS_TenantIsDeleted = H007L2_A401BAS_TenantIsDeleted[0];
               A395HospitalName = H007L2_A395HospitalName[0];
               A360BAS_TenantTenantCode = H007L2_A360BAS_TenantTenantCode[0];
               AV7vHosiptalName = A395HospitalName;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavVhosiptalname_Internalname, AV7vHosiptalName);
               AV19vCode = A360BAS_TenantTenantCode;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavVcode_Internalname, AV19vCode);
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 15;
               }
               sendrow_152( ) ;
               if ( isFullAjaxMode( ) && ! bGXsfl_15_Refreshing )
               {
                  context.DoAjaxLoad(15, TenentsshowRow);
               }
               pr_datastore1.readNext(0);
            }
            pr_datastore1.close(0);
         }
         else
         {
            AV22i = 1;
            while ( AV22i <= AV12iTenantsCode.Count )
            {
               AV14BCBAS_Tenant = new SdtBAS_Tenant(context);
               AV14BCBAS_Tenant.Load(((String)AV12iTenantsCode.Item(AV22i)));
               AV7vHosiptalName = AV14BCBAS_Tenant.gxTpr_Hospitalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavVhosiptalname_Internalname, AV7vHosiptalName);
               AV19vCode = AV14BCBAS_Tenant.gxTpr_Bas_tenanttenantcode;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavVcode_Internalname, AV19vCode);
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 15;
               }
               sendrow_152( ) ;
               if ( isFullAjaxMode( ) && ! bGXsfl_15_Refreshing )
               {
                  context.DoAjaxLoad(15, TenentsshowRow);
               }
               AV22i = (short)(AV22i+1);
            }
         }
         /*  Sending Event outputs  */
      }

      protected void E117L2( )
      {
         /* Hospitaldistrict_Click Routine */
         AV43cookie = new GxHttpCookie();
         AV43cookie.Name = "DAS_UserTInfo";
         AV43cookie.CurrentValue = StringUtil.Trim( AV19vCode);
         AV43cookie.Path = "/";
         AV43cookie.HttpOnly = false;
         AV42httpresponse.SetCookie(AV43cookie);
         AV47tCurrentCode = context.GetCookie( "DAS_UserTInfo");
         AV43cookie = new GxHttpCookie();
         AV43cookie.Name = "ASP.NET_SessionId";
         AV43cookie.Path = "/";
         AV43cookie.HttpOnly = false;
         AV42httpresponse.SetCookie(AV43cookie);
         new zutil_recordlog(context ).execute(  "",  "",  "Login",  2) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV28iReturnUrl)) )
         {
            AV16BCXT_Config.Load(3);
            AV17tTargetUrl = StringUtil.Trim( AV16BCXT_Config.gxTpr_Xt_configvalue2);
            CallWebObject(formatLink(AV17tTargetUrl) );
            context.wjLocDisableFrm = 0;
         }
         else
         {
            AV17tTargetUrl = StringUtil.Substring( AV28iReturnUrl, 11, StringUtil.Len( AV28iReturnUrl)-10);
            CallWebObject(formatLink(AV17tTargetUrl) );
            context.wjLocDisableFrm = 0;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV28iReturnUrl = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28iReturnUrl", AV28iReturnUrl);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIRETURNURL", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV28iReturnUrl, "")), context));
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
         PA7L2( ) ;
         WS7L2( ) ;
         WE7L2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227126195", true);
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
            context.AddJavascriptSource("messages.chs.js", "?"+GetCacheInvalidationToken( ), false);
            context.AddJavascriptSource("br_choosetenent.js", "?2020227126195", false);
         }
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_152( )
      {
         lblTextblockvhosiptalname_Internalname = "TEXTBLOCKVHOSIPTALNAME_"+sGXsfl_15_idx;
         edtavVhosiptalname_Internalname = "vVHOSIPTALNAME_"+sGXsfl_15_idx;
         edtavVcode_Internalname = "vVCODE_"+sGXsfl_15_idx;
      }

      protected void SubsflControlProps_fel_152( )
      {
         lblTextblockvhosiptalname_Internalname = "TEXTBLOCKVHOSIPTALNAME_"+sGXsfl_15_fel_idx;
         edtavVhosiptalname_Internalname = "vVHOSIPTALNAME_"+sGXsfl_15_fel_idx;
         edtavVcode_Internalname = "vVCODE_"+sGXsfl_15_fel_idx;
      }

      protected void sendrow_152( )
      {
         SubsflControlProps_152( ) ;
         WB7L0( ) ;
         TenentsshowRow = GXWebRow.GetNew(context,TenentsshowContainer);
         if ( subTenentsshow_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subTenentsshow_Backstyle = 0;
            if ( StringUtil.StrCmp(subTenentsshow_Class, "") != 0 )
            {
               subTenentsshow_Linesclass = subTenentsshow_Class+"Odd";
            }
         }
         else if ( subTenentsshow_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subTenentsshow_Backstyle = 0;
            subTenentsshow_Backcolor = subTenentsshow_Allbackcolor;
            if ( StringUtil.StrCmp(subTenentsshow_Class, "") != 0 )
            {
               subTenentsshow_Linesclass = subTenentsshow_Class+"Uniform";
            }
         }
         else if ( subTenentsshow_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subTenentsshow_Backstyle = 1;
            if ( StringUtil.StrCmp(subTenentsshow_Class, "") != 0 )
            {
               subTenentsshow_Linesclass = subTenentsshow_Class+"Odd";
            }
            subTenentsshow_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subTenentsshow_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subTenentsshow_Backstyle = 1;
            if ( ((int)(((nGXsfl_15_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subTenentsshow_Backcolor = (int)(0xFFFFFF);
               if ( StringUtil.StrCmp(subTenentsshow_Class, "") != 0 )
               {
                  subTenentsshow_Linesclass = subTenentsshow_Class+"Odd";
               }
            }
            else
            {
               subTenentsshow_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subTenentsshow_Class, "") != 0 )
               {
                  subTenentsshow_Linesclass = subTenentsshow_Class+"Even";
               }
            }
         }
         /* Start of Columns property logic. */
         if ( TenentsshowContainer.GetWrapped() == 1 )
         {
            if ( ( 1 == 0 ) && ( nGXsfl_15_idx == 1 ) )
            {
               context.WriteHtmlText( "<tr"+" class=\""+subTenentsshow_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_15_idx+"\">") ;
            }
            if ( 1 > 0 )
            {
               if ( ( 1 == 1 ) || ( ((int)((nGXsfl_15_idx) % (1))) - 1 == 0 ) )
               {
                  context.WriteHtmlText( "<tr"+" class=\""+subTenentsshow_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_15_idx+"\">") ;
               }
            }
         }
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divUnnamedtablefstenentsshow_Internalname+"_"+sGXsfl_15_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divHospitaldistrict_Internalname+"_"+sGXsfl_15_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 Section_ChooseTenants",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divUnnamedtablevhosiptalname_Internalname+"_"+sGXsfl_15_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-5 MergeLabelCell",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         TenentsshowRow.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTextblockvhosiptalname_Internalname,(String)"租户名称：",(String)"",(String)"",(String)lblTextblockvhosiptalname_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"Label",(short)0,(String)"",(short)1,(short)1,(short)0});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-7",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         TenentsshowRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtavVhosiptalname_Internalname,(String)"v Hosiptal Name",(String)"col-sm-3 TextBlock_ChooseHospitalLabel",(short)0,(bool)true});
         /* Multiple line edit */
         ClassString = "TextBlock_ChooseHospital";
         StyleString = "";
         ClassString = "TextBlock_ChooseHospital";
         StyleString = "";
         TenentsshowRow.AddColumnProperties("html_textarea", 1, isAjaxCallMode( ), new Object[] {(String)edtavVhosiptalname_Internalname,(String)AV7vHosiptalName,(String)"",(String)"",(short)0,(short)1,(short)0,(short)0,(short)80,(String)"chr",(short)5,(String)"row",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"400",(short)-1,(short)0,(String)"",(String)"",(short)-1,(bool)true,(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(short)0});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 Invisible",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Table start */
         TenentsshowRow.AddColumnProperties("table", -1, isAjaxCallMode( ), new Object[] {(String)tblUnnamedtablecontentfstenentsshow_Internalname+"_"+sGXsfl_15_idx,(short)1,(String)"Table",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(short)2,(String)"",(String)"",(String)"",(String)"px",(String)"px",(String)""});
         TenentsshowRow.AddColumnProperties("row", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)"",(String)""});
         TenentsshowRow.AddColumnProperties("cell", -1, isAjaxCallMode( ), new Object[] {(String)"",(String)""});
         /* Div Control */
         TenentsshowRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)" gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         TenentsshowRow.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtavVcode_Internalname,(String)"v Code",(String)"col-sm-3 AttributeLabel",(short)0,(bool)true});
         /* Single line edit */
         ROClassString = "Attribute";
         TenentsshowRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavVcode_Internalname,(String)AV19vCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavVcode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(int)edtavVcode_Visible,(short)0,(short)0,(String)"text",(String)"",(short)80,(String)"chr",(short)1,(String)"row",(short)100,(short)0,(short)0,(short)15,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         if ( TenentsshowContainer.GetWrapped() == 1 )
         {
            TenentsshowContainer.CloseTag("cell");
         }
         if ( TenentsshowContainer.GetWrapped() == 1 )
         {
            TenentsshowContainer.CloseTag("row");
         }
         if ( TenentsshowContainer.GetWrapped() == 1 )
         {
            TenentsshowContainer.CloseTag("table");
         }
         /* End of table */
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         TenentsshowRow.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         send_integrity_lvl_hashes7L2( ) ;
         /* End of Columns property logic. */
         TenentsshowContainer.AddRow(TenentsshowRow);
         nGXsfl_15_idx = (short)(((subTenentsshow_Islastpage==1)&&(nGXsfl_15_idx+1>subTenentsshow_Recordsperpage( )) ? 1 : nGXsfl_15_idx+1));
         sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
         SubsflControlProps_152( ) ;
         /* End function sendrow_152 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblChoosetenant_Internalname = "CHOOSETENANT";
         lblTextblockvhosiptalname_Internalname = "TEXTBLOCKVHOSIPTALNAME";
         edtavVhosiptalname_Internalname = "vVHOSIPTALNAME";
         divUnnamedtablevhosiptalname_Internalname = "UNNAMEDTABLEVHOSIPTALNAME";
         divHospitaldistrict_Internalname = "HOSPITALDISTRICT";
         edtavVcode_Internalname = "vVCODE";
         tblUnnamedtablecontentfstenentsshow_Internalname = "UNNAMEDTABLECONTENTFSTENENTSSHOW";
         divUnnamedtablefstenentsshow_Internalname = "UNNAMEDTABLEFSTENENTSSHOW";
         divTablecontent_Internalname = "TABLECONTENT";
         divTablemain_Internalname = "TABLEMAIN";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         subTenentsshow_Internalname = "TENENTSSHOW";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavVcode_Jsonclick = "";
         subTenentsshow_Class = "FreeStyleGrid";
         subTenentsshow_Allowcollapsing = 0;
         lblTextblockvhosiptalname_Caption = "租户名称：";
         subTenentsshow_Backcolorstyle = 0;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Data Mangement Platform";
         edtavVcode_Visible = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'TENENTSSHOW_nFirstRecordOnPage'},{av:'TENENTSSHOW_nEOF'},{av:'edtavVcode_Visible',ctrl:'vVCODE',prop:'Visible'},{av:'A401BAS_TenantIsDeleted',fld:'BAS_TENANTISDELETED',pic:'9'},{av:'A395HospitalName',fld:'HOSPITALNAME',pic:''},{av:'A360BAS_TenantTenantCode',fld:'BAS_TENANTTENANTCODE',pic:''},{av:'AV12iTenantsCode',fld:'vITENANTSCODE',pic:''},{av:'AV28iReturnUrl',fld:'vIRETURNURL',pic:'',hsh:true},{av:'AV36tUserType',fld:'vTUSERTYPE',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("TENENTSSHOW.LOAD","{handler:'E137L2',iparms:[{av:'AV36tUserType',fld:'vTUSERTYPE',pic:'',hsh:true},{av:'A401BAS_TenantIsDeleted',fld:'BAS_TENANTISDELETED',pic:'9'},{av:'A395HospitalName',fld:'HOSPITALNAME',pic:''},{av:'A360BAS_TenantTenantCode',fld:'BAS_TENANTTENANTCODE',pic:''},{av:'AV12iTenantsCode',fld:'vITENANTSCODE',pic:''}]");
         setEventMetadata("TENENTSSHOW.LOAD",",oparms:[{av:'AV7vHosiptalName',fld:'vVHOSIPTALNAME',pic:''},{av:'AV19vCode',fld:'vVCODE',pic:''}]}");
         setEventMetadata("HOSPITALDISTRICT.CLICK","{handler:'E117L2',iparms:[{av:'AV19vCode',fld:'vVCODE',pic:''},{av:'AV28iReturnUrl',fld:'vIRETURNURL',pic:'',hsh:true}]");
         setEventMetadata("HOSPITALDISTRICT.CLICK",",oparms:[]}");
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
         wcpOAV28iReturnUrl = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV36tUserType = "";
         A395HospitalName = "";
         A360BAS_TenantTenantCode = "";
         AV12iTenantsCode = new GxSimpleCollection<String>();
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblChoosetenant_Jsonclick = "";
         TenentsshowContainer = new GXWebGrid( context);
         sStyleString = "";
         subTenentsshow_Header = "";
         TenentsshowColumn = new GXWebColumn();
         AV7vHosiptalName = "";
         AV19vCode = "";
         ClassString = "";
         StyleString = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV60Pgmdesc = "";
         AV59Pgmname = "";
         AV11tCookieContent = "";
         AV16BCXT_Config = new SdtXT_Config(context);
         AV17tTargetUrl = "";
         AV40BCNewXT_Config = new SdtXT_Config(context);
         AV41tTargetAPI = "";
         AV29httpclient = new GxHttpClient( context);
         AV30tCookieCon = "";
         AV32tUserInfo = "";
         AV33JWTDecode = new SdtJWTDecode(context);
         AV31tSDT_JWT = new SdtSDT_JWT(context);
         AV21tResult = "";
         AV20tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         scmdbuf = "";
         H007L2_A401BAS_TenantIsDeleted = new short[1] ;
         H007L2_A395HospitalName = new String[] {""} ;
         H007L2_A360BAS_TenantTenantCode = new String[] {""} ;
         TenentsshowRow = new GXWebRow();
         AV14BCBAS_Tenant = new SdtBAS_Tenant(context);
         AV43cookie = new GxHttpCookie();
         AV42httpresponse = new GxHttpResponse( context);
         AV47tCurrentCode = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         subTenentsshow_Linesclass = "";
         lblTextblockvhosiptalname_Jsonclick = "";
         ROClassString = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_choosetenent__datastore1(),
            new Object[][] {
                new Object[] {
               H007L2_A401BAS_TenantIsDeleted, H007L2_A395HospitalName, H007L2_A360BAS_TenantTenantCode
               }
            }
         );
         AV60Pgmdesc = "Data Mangement Platform";
         AV59Pgmname = "BR_ChooseTenent";
         /* GeneXus formulas. */
         AV60Pgmdesc = "Data Mangement Platform";
         AV59Pgmname = "BR_ChooseTenent";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_15 ;
      private short nGXsfl_15_idx=1 ;
      private short A401BAS_TenantIsDeleted ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short subTenentsshow_Backcolorstyle ;
      private short subTenentsshow_Allowselection ;
      private short subTenentsshow_Allowhovering ;
      private short subTenentsshow_Allowcollapsing ;
      private short subTenentsshow_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV38tFlag ;
      private short AV22i ;
      private short subTenentsshow_Backstyle ;
      private short TENENTSSHOW_nEOF ;
      private int edtavVcode_Visible ;
      private int subTenentsshow_Selectedindex ;
      private int subTenentsshow_Selectioncolor ;
      private int subTenentsshow_Hoveringcolor ;
      private int subTenentsshow_Islastpage ;
      private int idxLst ;
      private int subTenentsshow_Backcolor ;
      private int subTenentsshow_Allbackcolor ;
      private long TENENTSSHOW_nCurrentRecord ;
      private long TENENTSSHOW_nFirstRecordOnPage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_15_idx="0001" ;
      private String edtavVcode_Internalname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divTablecontent_Internalname ;
      private String lblChoosetenant_Internalname ;
      private String lblChoosetenant_Jsonclick ;
      private String sStyleString ;
      private String subTenentsshow_Internalname ;
      private String subTenentsshow_Header ;
      private String lblTextblockvhosiptalname_Caption ;
      private String ClassString ;
      private String StyleString ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavVhosiptalname_Internalname ;
      private String AV60Pgmdesc ;
      private String AV59Pgmname ;
      private String scmdbuf ;
      private String lblTextblockvhosiptalname_Internalname ;
      private String sGXsfl_15_fel_idx="0001" ;
      private String subTenentsshow_Class ;
      private String subTenentsshow_Linesclass ;
      private String divUnnamedtablefstenentsshow_Internalname ;
      private String divHospitaldistrict_Internalname ;
      private String divUnnamedtablevhosiptalname_Internalname ;
      private String lblTextblockvhosiptalname_Jsonclick ;
      private String tblUnnamedtablecontentfstenentsshow_Internalname ;
      private String ROClassString ;
      private String edtavVcode_Jsonclick ;
      private bool entryPointCalled ;
      private bool bGXsfl_15_Refreshing=false ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private String AV11tCookieContent ;
      private String AV28iReturnUrl ;
      private String wcpOAV28iReturnUrl ;
      private String AV36tUserType ;
      private String A395HospitalName ;
      private String A360BAS_TenantTenantCode ;
      private String AV7vHosiptalName ;
      private String AV19vCode ;
      private String AV17tTargetUrl ;
      private String AV41tTargetAPI ;
      private String AV30tCookieCon ;
      private String AV32tUserInfo ;
      private String AV21tResult ;
      private String AV47tCurrentCode ;
      private GXWebGrid TenentsshowContainer ;
      private GXWebRow TenentsshowRow ;
      private GXWebColumn TenentsshowColumn ;
      private SdtJWTDecode AV33JWTDecode ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private short[] H007L2_A401BAS_TenantIsDeleted ;
      private String[] H007L2_A395HospitalName ;
      private String[] H007L2_A360BAS_TenantTenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpCookie AV43cookie ;
      private GxHttpClient AV29httpclient ;
      private GxHttpResponse AV42httpresponse ;
      private GxSimpleCollection<String> AV12iTenantsCode ;
      private GXWebForm Form ;
      private SdtBAS_Tenant AV14BCBAS_Tenant ;
      private SdtXT_Config AV16BCXT_Config ;
      private SdtXT_Config AV40BCNewXT_Config ;
      private SdtSDT_JWT AV31tSDT_JWT ;
      private SdtSDT_MicroUserInfo AV20tSDT_MicroUserInfo ;
   }

   public class br_choosetenent__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH007L2 ;
          prmH007L2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H007L2", "SELECT [IsDeleted], [HospitalName], [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [IsDeleted] = 0 ORDER BY [TenantCode] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH007L2,100,0,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

}
