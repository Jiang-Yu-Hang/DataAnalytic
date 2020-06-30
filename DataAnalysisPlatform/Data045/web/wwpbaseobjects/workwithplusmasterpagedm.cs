/*
               File: WWPBaseObjects.WorkWithPlusMasterPageDM
        Description: Master Page
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:17:13.25
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
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   public class workwithplusmasterpagedm : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public workwithplusmasterpagedm( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithplusmasterpagedm( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
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
            PAA22( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WSA22( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WEA22( ) ;
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         if ( ! isFullAjaxMode( ) )
         {
            GXWebForm.AddResponsiveMetaHeaders((getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Meta);
            getDataAreaObject().RenderHtmlHeaders();
         }
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlOpenForm();
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "vADMINAGDATA_MPAGE", AV8AdminAGData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vADMINAGDATA_MPAGE", AV8AdminAGData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "vACTIONGMDATA_MPAGE", AV6actionGMData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vACTIONGMDATA_MPAGE", AV6actionGMData);
         }
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Icon", StringUtil.RTrim( Ddo_adminag_Icon));
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Caption", StringUtil.RTrim( Ddo_adminag_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Cls", StringUtil.RTrim( Ddo_adminag_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Titlecontrolalign", StringUtil.RTrim( Ddo_adminag_Titlecontrolalign));
         GxWebStd.gx_hidden_field( context, "DDO_ACTIONGM_MPAGE_Icon", StringUtil.RTrim( Ddo_actiongm_Icon));
         GxWebStd.gx_hidden_field( context, "DDO_ACTIONGM_MPAGE_Caption", StringUtil.RTrim( Ddo_actiongm_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_ACTIONGM_MPAGE_Cls", StringUtil.RTrim( Ddo_actiongm_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_ACTIONGM_MPAGE_Activeeventkey", StringUtil.RTrim( Ddo_actiongm_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Activeeventkey", StringUtil.RTrim( Ddo_adminag_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_ACTIONGM_MPAGE_Activeeventkey", StringUtil.RTrim( Ddo_actiongm_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Activeeventkey", StringUtil.RTrim( Ddo_adminag_Activeeventkey));
      }

      protected void RenderHtmlCloseFormA22( )
      {
         SendCloseFormHiddens( ) ;
         SendSecurityToken((String)(sPrefix));
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlCloseForm();
         }
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("wwpbaseobjects/workwithplusmasterpagedm.js", "?202022815171362", false);
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.WorkWithPlusMasterPageDM" ;
      }

      public override String GetPgmdesc( )
      {
         return "Master Page" ;
      }

      protected void WBA20( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            if ( ! ShowMPWhenPopUp( ) && context.isPopUpObject( ) )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableOutput();
               }
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
               /* Content placeholder */
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gx-content-placeholder");
               context.WriteHtmlText( ">") ;
               if ( ! isFullAjaxMode( ) )
               {
                  getDataAreaObject().RenderHtmlContent();
               }
               context.WriteHtmlText( "</div>") ;
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
               wbLoad = true;
               return  ;
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 MasterHeaderCell navbar-fixed-top", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableheader_Internalname, 1, 0, "px", 0, "px", "TableHeader", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-4 hidden-xs col-sm-6 TableUserRoleCell", "left", "top", "", "", "div");
            wb_table1_12_A22( true) ;
         }
         else
         {
            wb_table1_12_A22( false) ;
         }
         return  ;
      }

      protected void wb_table1_12_A22e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 ShowMenuImageCellDirect", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_usertable_actiongm_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDdo_actiongm.SetProperty("Caption", Ddo_actiongm_Caption);
            ucDdo_actiongm.SetProperty("Cls", Ddo_actiongm_Cls);
            ucDdo_actiongm.SetProperty("DropDownOptionsData", AV6actionGMData);
            ucDdo_actiongm.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_actiongm_Internalname, "DDO_ACTIONGM_MPAGEContainer");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 ShowMenuImageCellHLogo", "left", "top", "", "", "div");
            /* Static images/pictures */
            ClassString = "Image_Logo";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "efd1b220-984f-417c-9e44-ff406910bd26", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRoche_logo_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRoche_logo_Visible, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\WorkWithPlusMasterPageDM.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 ShowMenuImageCellDes", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextdatamanager_Internalname, "Data Management", "", "", lblTextdatamanager_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "TextBlock_Des", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\WorkWithPlusMasterPageDM.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 ShowMenuImageCellHLogo", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", imgavHospitallogo_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgavHospitallogo_Internalname+"\"", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            ClassString = "Image_HospitalLogo";
            StyleString = "";
            AV16hospitalLogo_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo))&&String.IsNullOrEmpty(StringUtil.RTrim( AV50Hospitallogo_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo)) ? AV50Hospitallogo_GXI : context.PathToRelativeUrl( AV16hospitalLogo));
            GxWebStd.gx_bitmap( context, imgavHospitallogo_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgavHospitallogo_Visible, 0, "", "", 0, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, AV16hospitalLogo_IsBlob, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\WorkWithPlusMasterPageDM.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellTableContentMaster CellTableContentWithFooter", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontentplaceholder_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            /* Content placeholder */
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-content-placeholder");
            context.WriteHtmlText( ">") ;
            if ( ! isFullAjaxMode( ) )
            {
               getDataAreaObject().RenderHtmlContent();
            }
            context.WriteHtmlText( "</div>") ;
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
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
         }
         wbLoad = true;
      }

      protected void STARTA22( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUPA20( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( getDataAreaObject().ExecuteStartEvent() != 0 )
            {
               setAjaxCallMode();
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      protected void WSA22( )
      {
         STARTA22( ) ;
         EVTA22( ) ;
      }

      protected void EVTA22( )
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
                        if ( StringUtil.StrCmp(sEvt, "RFR_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_ADMINAG_MPAGE.ONOPTIONCLICKED_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E11A22 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_ACTIONGM_MPAGE.ONOPTIONCLICKED_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E12A22 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E13A22 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E14A22 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER_MPAGE") == 0 )
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
                           dynload_actions( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  if ( context.wbHandled == 0 )
                  {
                     getDataAreaObject().DispatchEvents();
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WEA22( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseFormA22( ) ;
            }
         }
      }

      protected void PAA22( )
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
         RFA22( ) ;
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

      protected void RFA22( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( ShowMPWhenPopUp( ) || ! context.isPopUpObject( ) )
         {
            gxdyncontrolsrefreshing = true;
            fix_multi_value_controls( ) ;
            gxdyncontrolsrefreshing = false;
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E14A22 ();
            WBA20( ) ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
      }

      protected void send_integrity_lvl_hashesA22( )
      {
      }

      protected void STRUPA20( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E13A22 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vADMINAGDATA_MPAGE"), AV8AdminAGData);
            ajax_req_read_hidden_sdt(cgiGet( "vACTIONGMDATA_MPAGE"), AV6actionGMData);
            /* Read variables values. */
            AV16hospitalLogo = cgiGet( imgavHospitallogo_Internalname);
            /* Read saved values. */
            Ddo_adminag_Icon = cgiGet( "DDO_ADMINAG_MPAGE_Icon");
            Ddo_adminag_Caption = cgiGet( "DDO_ADMINAG_MPAGE_Caption");
            Ddo_adminag_Cls = cgiGet( "DDO_ADMINAG_MPAGE_Cls");
            Ddo_adminag_Titlecontrolalign = cgiGet( "DDO_ADMINAG_MPAGE_Titlecontrolalign");
            Ddo_actiongm_Icon = cgiGet( "DDO_ACTIONGM_MPAGE_Icon");
            Ddo_actiongm_Caption = cgiGet( "DDO_ACTIONGM_MPAGE_Caption");
            Ddo_actiongm_Cls = cgiGet( "DDO_ACTIONGM_MPAGE_Cls");
            Ddo_actiongm_Activeeventkey = cgiGet( "DDO_ACTIONGM_MPAGE_Activeeventkey");
            Ddo_adminag_Activeeventkey = cgiGet( "DDO_ADMINAG_MPAGE_Activeeventkey");
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
         E13A22 ();
         if (returnInSub) return;
      }

      protected void E13A22( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV5WWPContext) ;
         new zutil_setsession(context ).execute(  AV5WWPContext) ;
         AV38tResult = context.GetCookie( "DAS_UserTInfo");
         AV11BCBAS_Tenant = new SdtBAS_Tenant(context);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV38tResult))) )
         {
            AV30tCurrentCode = StringUtil.Trim( AV38tResult);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV30tCurrentCode", AV30tCurrentCode);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV30tCurrentCode)) )
         {
            imgRoche_logo_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgRoche_logo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRoche_logo_Visible), 5, 0)), true);
            imgavHospitallogo_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgavHospitallogo_Visible), 5, 0)), true);
         }
         else
         {
            imgRoche_logo_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgRoche_logo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRoche_logo_Visible), 5, 0)), true);
            imgavHospitallogo_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgavHospitallogo_Visible), 5, 0)), true);
            AV11BCBAS_Tenant.Load(StringUtil.Trim( AV30tCurrentCode));
            AV16hospitalLogo = AV11BCBAS_Tenant.gxTpr_Bas_tenantlogo;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo)) ? AV50Hospitallogo_GXI : context.convertURL( context.PathToRelativeUrl( AV16hospitalLogo))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "SrcSet", context.GetImageSrcSet( AV16hospitalLogo), true);
            AV50Hospitallogo_GXI = GXDbFile.PathToUrl( AV11BCBAS_Tenant.gxTpr_Bas_tenantlogo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo)) ? AV50Hospitallogo_GXI : context.convertURL( context.PathToRelativeUrl( AV16hospitalLogo))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "SrcSet", context.GetImageSrcSet( AV16hospitalLogo), true);
            AV35tLogoImageUrl = AV50Hospitallogo_GXI;
            AV47BCNewXT_Config.Load(8);
            AV50Hospitallogo_GXI = StringUtil.StringReplace( AV35tLogoImageUrl, StringUtil.Trim( AV47BCNewXT_Config.gxTpr_Xt_configvalue1), StringUtil.Trim( AV47BCNewXT_Config.gxTpr_Xt_configvalue2));
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo)) ? AV50Hospitallogo_GXI : context.convertURL( context.PathToRelativeUrl( AV16hospitalLogo))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "SrcSet", context.GetImageSrcSet( AV16hospitalLogo), true);
            AV16hospitalLogo = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo)) ? AV50Hospitallogo_GXI : context.convertURL( context.PathToRelativeUrl( AV16hospitalLogo))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "SrcSet", context.GetImageSrcSet( AV16hospitalLogo), true);
         }
         divLayoutmaintable_Class = "MainContainerWithFooter";
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, divLayoutmaintable_Internalname, "Class", divLayoutmaintable_Class, true);
         GXt_objcol_SdtDVelop_Menu_Item1 = AV13DVelop_Menu;
         new GeneXus.Programs.wwpbaseobjects.menuoptionsdata(context ).execute( out  GXt_objcol_SdtDVelop_Menu_Item1) ;
         AV13DVelop_Menu = GXt_objcol_SdtDVelop_Menu_Item1;
         new GeneXus.Programs.wwpbaseobjects.getmenuauthorizedoptions(context ).execute( ref  AV13DVelop_Menu) ;
         Ddo_actiongm_Icon = context.convertURL( (String)(context.GetImagePath( "f41016dd-84e0-420e-89fd-a070d39d1203", "", context.GetTheme( ))));
         ucDdo_actiongm.SendProperty(context, "", true, Ddo_actiongm_Internalname, "Icon", Ddo_actiongm_Icon);
         AV6actionGMData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV7actionGMDataItem.gxTpr_Title = "Home";
         AV7actionGMDataItem.gxTpr_Eventkey = "gotopage5";
         AV7actionGMDataItem.gxTpr_Isdivider = false;
         AV6actionGMData.Add(AV7actionGMDataItem, 0);
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV7actionGMDataItem.gxTpr_Title = "Admin Portal";
         AV7actionGMDataItem.gxTpr_Eventkey = "gotopage1";
         AV7actionGMDataItem.gxTpr_Isdivider = false;
         AV6actionGMData.Add(AV7actionGMDataItem, 0);
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV7actionGMDataItem.gxTpr_Title = "Data Management Portal";
         AV7actionGMDataItem.gxTpr_Eventkey = "gotopage3";
         AV7actionGMDataItem.gxTpr_Isdivider = false;
         AV6actionGMData.Add(AV7actionGMDataItem, 0);
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV7actionGMDataItem.gxTpr_Title = "Patient 360";
         AV7actionGMDataItem.gxTpr_Eventkey = "gotopage2";
         AV7actionGMDataItem.gxTpr_Isdivider = false;
         AV6actionGMData.Add(AV7actionGMDataItem, 0);
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV7actionGMDataItem.gxTpr_Title = "Overview";
         AV7actionGMDataItem.gxTpr_Eventkey = "gotopage4";
         AV7actionGMDataItem.gxTpr_Isdivider = false;
         AV6actionGMData.Add(AV7actionGMDataItem, 0);
         Ddo_adminag_Icon = context.convertURL( (String)(context.GetImagePath( "d22e46c4-f4d3-420c-9523-26ffa5332482", "", context.GetTheme( ))));
         AV8AdminAGData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV10AdminAGDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV10AdminAGDataItem.gxTpr_Title = "个人信息";
         AV10AdminAGDataItem.gxTpr_Eventkey = "ActionChangePassword";
         AV10AdminAGDataItem.gxTpr_Isdivider = false;
         AV8AdminAGData.Add(AV10AdminAGDataItem, 0);
         AV10AdminAGDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV10AdminAGDataItem.gxTpr_Title = "切换租户";
         AV10AdminAGDataItem.gxTpr_Eventkey = "changeTenant";
         AV10AdminAGDataItem.gxTpr_Isdivider = false;
         AV8AdminAGData.Add(AV10AdminAGDataItem, 0);
         AV10AdminAGDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV10AdminAGDataItem.gxTpr_Title = "退出";
         AV10AdminAGDataItem.gxTpr_Eventkey = "ActionLogOut";
         AV10AdminAGDataItem.gxTpr_Isdivider = false;
         AV8AdminAGData.Add(AV10AdminAGDataItem, 0);
         AV44UserName = AV5WWPContext.gxTpr_Userdisplayname;
         Ddo_adminag_Titlecontrolalign = "Left";
         Ddo_adminag_Caption = AV44UserName;
         AV38tResult = AV45websession.Get("DAS_UserPermission");
         AV40tSDT_MicroUserInfo.FromJSonString(AV38tResult, null);
         AV43tUserType = StringUtil.Str( (decimal)(AV40tSDT_MicroUserInfo.gxTpr_Usertype), 4, 0);
         if ( AV5WWPContext.gxTpr_Currenttnum <= 1 )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( AV43tUserType), "0") != 0 )
            {
               AV8AdminAGData.RemoveItem(2);
            }
         }
      }

      protected void E12A22( )
      {
         /* Ddo_actiongm_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_actiongm_Activeeventkey, "gotopage5") == 0 )
         {
            /* Execute user subroutine: 'DO GOTOPAGE5' */
            S112 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_actiongm_Activeeventkey, "gotopage1") == 0 )
         {
            /* Execute user subroutine: 'DO GOTOPAGE1' */
            S122 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_actiongm_Activeeventkey, "gotopage3") == 0 )
         {
            /* Execute user subroutine: 'DO GOTOPAGE3' */
            S132 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_actiongm_Activeeventkey, "gotopage2") == 0 )
         {
            /* Execute user subroutine: 'DO GOTOPAGE2' */
            S142 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_actiongm_Activeeventkey, "gotopage4") == 0 )
         {
            /* Execute user subroutine: 'DO GOTOPAGE4' */
            S152 ();
            if (returnInSub) return;
         }
      }

      protected void E11A22( )
      {
         /* Ddo_adminag_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_adminag_Activeeventkey, "ActionChangePassword") == 0 )
         {
            /* Execute user subroutine: 'DO ACTIONCHANGEPASSWORD' */
            S162 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_adminag_Activeeventkey, "changeTenant") == 0 )
         {
            /* Execute user subroutine: 'DO CHANGETENANT' */
            S172 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_adminag_Activeeventkey, "ActionLogOut") == 0 )
         {
            /* Execute user subroutine: 'DO ACTIONLOGOUT' */
            S182 ();
            if (returnInSub) return;
         }
      }

      protected void S112( )
      {
         /* 'DO GOTOPAGE5' Routine */
         new zutil_checksessionandrejwt(context ).execute( ) ;
         new zutil_setjwt(context ).execute( ) ;
         AV12BCXT_Config.Load(4);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue3);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S122( )
      {
         /* 'DO GOTOPAGE1' Routine */
         new zutil_checksessionandrejwt(context ).execute( ) ;
         new zutil_setjwt(context ).execute( ) ;
         AV12BCXT_Config.Load(5);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue1);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S132( )
      {
         /* 'DO GOTOPAGE3' Routine */
         new zutil_checksessionandrejwt(context ).execute( ) ;
         AV12BCXT_Config.Load(3);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue2);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S142( )
      {
         /* 'DO GOTOPAGE2' Routine */
         new zutil_checksessionandrejwt(context ).execute( ) ;
         new zutil_setjwt(context ).execute( ) ;
         AV12BCXT_Config.Load(5);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue2);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S152( )
      {
         /* 'DO GOTOPAGE4' Routine */
         new zutil_checksessionandrejwt(context ).execute( ) ;
         CallWebObject(formatLink("dashboard.aspx") );
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'DO ACTIONCHANGEPASSWORD' Routine */
         new zutil_checksessionandrejwt(context ).execute( ) ;
         AV12BCXT_Config.Load(5);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue3);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S172( )
      {
         /* 'DO CHANGETENANT' Routine */
         new zutil_checksessionandrejwt(context ).execute( ) ;
         AV12BCXT_Config.Load(4);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue4);
         AV41tTargetUrl = AV41tTargetUrl + "?returnurl=" + StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue5);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S182( )
      {
         /* 'DO ACTIONLOGOUT' Routine */
         AV12BCXT_Config.Load(4);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue1);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void nextLoad( )
      {
      }

      protected void E14A22( )
      {
         /* Load Routine */
      }

      protected void wb_table1_12_A22( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTableuserrole_Internalname, tblTableuserrole_Internalname, "", "TableAlignRightMaster", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblWelcomeuse_Internalname, "欢迎使用", "", "", lblWelcomeuse_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "TextBlock_Welcome", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\WorkWithPlusMasterPageDM.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='MasterTopIconsCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_usertable_adminag_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDdo_adminag.SetProperty("Caption", Ddo_adminag_Caption);
            ucDdo_adminag.SetProperty("Cls", Ddo_adminag_Cls);
            ucDdo_adminag.SetProperty("DropDownOptionsData", AV8AdminAGData);
            ucDdo_adminag.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_adminag_Internalname, "DDO_ADMINAG_MPAGEContainer");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_12_A22e( true) ;
         }
         else
         {
            wb_table1_12_A22e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PAA22( ) ;
         WSA22( ) ;
         WEA22( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void master_styles( )
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
         while ( idxLst <= (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)(getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Item(idxLst))), "?202022815171637", true);
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
         context.AddJavascriptSource("wwpbaseobjects/workwithplusmasterpagedm.js", "?202022815171638", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblWelcomeuse_Internalname = "WELCOMEUSE_MPAGE";
         Ddo_adminag_Internalname = "DDO_ADMINAG_MPAGE";
         divHtml_usertable_adminag_Internalname = "HTML_USERTABLE_ADMINAG_MPAGE";
         tblTableuserrole_Internalname = "TABLEUSERROLE_MPAGE";
         Ddo_actiongm_Internalname = "DDO_ACTIONGM_MPAGE";
         divHtml_usertable_actiongm_Internalname = "HTML_USERTABLE_ACTIONGM_MPAGE";
         imgRoche_logo_Internalname = "ROCHE_LOGO_MPAGE";
         lblTextdatamanager_Internalname = "TEXTDATAMANAGER_MPAGE";
         imgavHospitallogo_Internalname = "vHOSPITALLOGO_MPAGE";
         divTableheader_Internalname = "TABLEHEADER_MPAGE";
         divTablecontentplaceholder_Internalname = "TABLECONTENTPLACEHOLDER_MPAGE";
         divTablecontent_Internalname = "TABLECONTENT_MPAGE";
         divTablemain_Internalname = "TABLEMAIN_MPAGE";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE_MPAGE";
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Internalname = "FORM_MPAGE";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         imgavHospitallogo_Visible = 1;
         imgRoche_logo_Visible = 1;
         divLayoutmaintable_Class = "Table";
         Ddo_actiongm_Cls = "ActionGroupHeaderTheo";
         Ddo_adminag_Titlecontrolalign = "Automatic";
         Ddo_adminag_Cls = "Header_UserInfo";
         Contentholder.setDataArea(getDataAreaObject());
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
         setEventMetadata("REFRESH_MPAGE","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH_MPAGE",",oparms:[]}");
         setEventMetadata("DDO_ACTIONGM_MPAGE.ONOPTIONCLICKED_MPAGE","{handler:'E12A22',iparms:[{av:'Ddo_actiongm_Activeeventkey',ctrl:'DDO_ACTIONGM_MPAGE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_ACTIONGM_MPAGE.ONOPTIONCLICKED_MPAGE",",oparms:[]}");
         setEventMetadata("DDO_ADMINAG_MPAGE.ONOPTIONCLICKED_MPAGE","{handler:'E11A22',iparms:[{av:'Ddo_adminag_Activeeventkey',ctrl:'DDO_ADMINAG_MPAGE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_ADMINAG_MPAGE.ONOPTIONCLICKED_MPAGE",",oparms:[]}");
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
         Contentholder = new GXDataAreaControl();
         Ddo_actiongm_Activeeventkey = "";
         Ddo_adminag_Activeeventkey = "";
         GXKey = "";
         AV8AdminAGData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV6actionGMData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_adminag_Icon = "";
         Ddo_adminag_Caption = "";
         Ddo_actiongm_Icon = "";
         Ddo_actiongm_Caption = "";
         sPrefix = "";
         ucDdo_actiongm = new GXUserControl();
         ClassString = "";
         StyleString = "";
         sImgUrl = "";
         lblTextdatamanager_Jsonclick = "";
         AV16hospitalLogo = "";
         AV50Hospitallogo_GXI = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV5WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV38tResult = "";
         AV11BCBAS_Tenant = new SdtBAS_Tenant(context);
         AV30tCurrentCode = "";
         AV35tLogoImageUrl = "";
         AV47BCNewXT_Config = new SdtXT_Config(context);
         AV13DVelop_Menu = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item>( context, "Item", "DataAnalysisPlatform");
         GXt_objcol_SdtDVelop_Menu_Item1 = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item>( context, "Item", "DataAnalysisPlatform");
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV10AdminAGDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV44UserName = "";
         AV45websession = context.GetSession();
         AV40tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         AV43tUserType = "";
         AV12BCXT_Config = new SdtXT_Config(context);
         AV41tTargetUrl = "";
         sStyleString = "";
         lblWelcomeuse_Jsonclick = "";
         ucDdo_adminag = new GXUserControl();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "";
         Form = new GXWebForm();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int imgRoche_logo_Visible ;
      private int imgavHospitallogo_Visible ;
      private int idxLst ;
      private String Ddo_actiongm_Activeeventkey ;
      private String Ddo_adminag_Activeeventkey ;
      private String GXKey ;
      private String Ddo_adminag_Icon ;
      private String Ddo_adminag_Caption ;
      private String Ddo_adminag_Cls ;
      private String Ddo_adminag_Titlecontrolalign ;
      private String Ddo_actiongm_Icon ;
      private String Ddo_actiongm_Caption ;
      private String Ddo_actiongm_Cls ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divLayoutmaintable_Class ;
      private String divTablemain_Internalname ;
      private String divTableheader_Internalname ;
      private String divHtml_usertable_actiongm_Internalname ;
      private String Ddo_actiongm_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String sImgUrl ;
      private String imgRoche_logo_Internalname ;
      private String lblTextdatamanager_Internalname ;
      private String lblTextdatamanager_Jsonclick ;
      private String imgavHospitallogo_Internalname ;
      private String divTablecontent_Internalname ;
      private String divTablecontentplaceholder_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sStyleString ;
      private String tblTableuserrole_Internalname ;
      private String lblWelcomeuse_Internalname ;
      private String lblWelcomeuse_Jsonclick ;
      private String divHtml_usertable_adminag_Internalname ;
      private String Ddo_adminag_Internalname ;
      private String sDynURL ;
      private bool wbLoad ;
      private bool AV16hospitalLogo_IsBlob ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool toggleJsOutput ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private String AV50Hospitallogo_GXI ;
      private String AV38tResult ;
      private String AV30tCurrentCode ;
      private String AV35tLogoImageUrl ;
      private String AV44UserName ;
      private String AV43tUserType ;
      private String AV41tTargetUrl ;
      private String AV16hospitalLogo ;
      private IGxSession AV45websession ;
      private GXUserControl ucDdo_actiongm ;
      private GXUserControl ucDdo_adminag ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXDataAreaControl Contentholder ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV8AdminAGData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV6actionGMData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> AV13DVelop_Menu ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> GXt_objcol_SdtDVelop_Menu_Item1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV5WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item AV7actionGMDataItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item AV10AdminAGDataItem ;
      private SdtBAS_Tenant AV11BCBAS_Tenant ;
      private SdtXT_Config AV47BCNewXT_Config ;
      private SdtXT_Config AV12BCXT_Config ;
      private SdtSDT_MicroUserInfo AV40tSDT_MicroUserInfo ;
   }

}
