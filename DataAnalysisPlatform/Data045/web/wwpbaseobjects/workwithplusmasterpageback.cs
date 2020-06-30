/*
               File: WWPBaseObjects.WorkWithPlusMasterPageBack
        Description: Master Page
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:16:31.85
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
   public class workwithplusmasterpageback : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public workwithplusmasterpageback( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithplusmasterpageback( IGxContext context )
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
            PA822( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS822( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE822( ) ;
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
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "vDVELOP_MENU_MPAGE", AV13DVelop_Menu);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDVELOP_MENU_MPAGE", AV13DVelop_Menu);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "vDVELOP_MENU_USERDATA_MPAGE", AV14DVelop_Menu_UserData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDVELOP_MENU_USERDATA_MPAGE", AV14DVelop_Menu_UserData);
         }
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Icon", StringUtil.RTrim( Ddo_adminag_Icon));
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Caption", StringUtil.RTrim( Ddo_adminag_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Cls", StringUtil.RTrim( Ddo_adminag_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Titlecontrolalign", StringUtil.RTrim( Ddo_adminag_Titlecontrolalign));
         GxWebStd.gx_hidden_field( context, "DDO_ACTIONGM_MPAGE_Icon", StringUtil.RTrim( Ddo_actiongm_Icon));
         GxWebStd.gx_hidden_field( context, "DDO_ACTIONGM_MPAGE_Caption", StringUtil.RTrim( Ddo_actiongm_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_ACTIONGM_MPAGE_Cls", StringUtil.RTrim( Ddo_actiongm_Cls));
         GxWebStd.gx_hidden_field( context, "UCMENU_MPAGE_Sidebarmainclass", StringUtil.RTrim( Ucmenu_Sidebarmainclass));
         GxWebStd.gx_hidden_field( context, "DDO_ACTIONGM_MPAGE_Activeeventkey", StringUtil.RTrim( Ddo_actiongm_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Activeeventkey", StringUtil.RTrim( Ddo_adminag_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_ACTIONGM_MPAGE_Activeeventkey", StringUtil.RTrim( Ddo_actiongm_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_ADMINAG_MPAGE_Activeeventkey", StringUtil.RTrim( Ddo_adminag_Activeeventkey));
      }

      protected void RenderHtmlCloseForm822( )
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/slimscroll/jquery.slimscroll.min.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/SidebarMenu/BootstrapSidebarMenuRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Tooltip/BootstrapTooltipRender.js", "", false);
         context.AddJavascriptSource("wwpbaseobjects/workwithplusmasterpageback.js", "?202022815163230", false);
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.WorkWithPlusMasterPageBack" ;
      }

      public override String GetPgmdesc( )
      {
         return "Master Page" ;
      }

      protected void WB820( )
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
            wb_table1_12_822( true) ;
         }
         else
         {
            wb_table1_12_822( false) ;
         }
         return  ;
      }

      protected void wb_table1_12_822e( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgRoche_logo_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRoche_logo_Visible, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\WorkWithPlusMasterPageBack.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 ShowMenuImageCellDes", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextdatamanager_Internalname, "Data Management", "", "", lblTextdatamanager_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "TextBlock_Des", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\WorkWithPlusMasterPageBack.htm");
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
            GxWebStd.gx_bitmap( context, imgavHospitallogo_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgavHospitallogo_Visible, 0, "", "", 0, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, AV16hospitalLogo_IsBlob, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\WorkWithPlusMasterPageBack.htm");
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
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "page-content", "left", "top", "", "", "div");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',true,'',0)\"";
            ClassString = "Image_NoVisiable";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "3a9b65d2-1eba-4aaa-98e3-54d523afff3c", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgExpandmenu_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 7, imgExpandmenu_Jsonclick, "'"+""+"'"+",true,"+"'"+"e11821_client"+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\WorkWithPlusMasterPageBack.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellWidthAuto", "left", "top", "", "", "div");
            /* User Defined Control */
            ucUcmenu.SetProperty("SidebarMainClass", Ucmenu_Sidebarmainclass);
            ucUcmenu.SetProperty("SidebarMenuOptionsData", AV13DVelop_Menu);
            ucUcmenu.SetProperty("SidebarMenuUserData", AV14DVelop_Menu_UserData);
            ucUcmenu.Render(context, "dvelop.gxbootstrap.sidebarmenu", Ucmenu_Internalname, "UCMENU_MPAGEContainer");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 MasterFooterCellFixedVM page-content", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablefooter_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Right", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockfooter_Internalname, "sungiant - copyright 2018", "", "", lblTextblockfooter_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "FooterText", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\WorkWithPlusMasterPageBack.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            ucUctooltip.Render(context, "dvelop.gxbootstrap.tooltip", Uctooltip_Internalname, "UCTOOLTIP_MPAGEContainer");
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

      protected void START822( )
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
         STRUP820( ) ;
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

      protected void WS822( )
      {
         START822( ) ;
         EVT822( ) ;
      }

      protected void EVT822( )
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
                           E12822 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_ACTIONGM_MPAGE.ONOPTIONCLICKED_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E13822 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E14822 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Load */
                           E15822 ();
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

      protected void WE822( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm822( ) ;
            }
         }
      }

      protected void PA822( )
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
         RF822( ) ;
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

      protected void RF822( )
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
            E15822 ();
            WB820( ) ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
      }

      protected void send_integrity_lvl_hashes822( )
      {
      }

      protected void STRUP820( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E14822 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vADMINAGDATA_MPAGE"), AV8AdminAGData);
            ajax_req_read_hidden_sdt(cgiGet( "vACTIONGMDATA_MPAGE"), AV6actionGMData);
            ajax_req_read_hidden_sdt(cgiGet( "vDVELOP_MENU_MPAGE"), AV13DVelop_Menu);
            ajax_req_read_hidden_sdt(cgiGet( "vDVELOP_MENU_USERDATA_MPAGE"), AV14DVelop_Menu_UserData);
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
            Ucmenu_Sidebarmainclass = cgiGet( "UCMENU_MPAGE_Sidebarmainclass");
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
         E14822 ();
         if (returnInSub) return;
      }

      protected void E14822( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV5WWPContext) ;
         AV29tCookieContent = context.GetCookie( "DAS_LoginUser");
         if ( String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV29tCookieContent))) )
         {
            GXt_int1 = (short)(Convert.ToInt16(AV34tFlag));
            new wb_logout(context ).execute( out  GXt_int1) ;
            AV34tFlag = (bool)(Convert.ToBoolean(GXt_int1));
            AV12BCXT_Config.Load(4);
            AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue2);
            AV46tCurPage = AV47httprequest.BaseURL;
            AV46tCurPage = AV46tCurPage + AV47httprequest.ScriptName;
            AV41tTargetUrl = AV41tTargetUrl + "?returnurl=";
            AV41tTargetUrl = AV41tTargetUrl + AV46tCurPage;
            CallWebObject(formatLink(AV41tTargetUrl) );
            context.wjLocDisableFrm = 0;
         }
         AV38tResult = context.GetCookie( "DAS_UserTInfo");
         if ( String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV45websession.Get("DAS_UserPermission")))) )
         {
            AV17httpclient.Host = "admin1.chinacloudsites.cn";
            AV17httpclient.AddHeader("Connection", "keep-alive");
            AV17httpclient.AddHeader("Content-Type", "application/json; charset=utf-8");
            AV29tCookieContent = "DAS_LoginUser=" + StringUtil.Trim( AV29tCookieContent) + ";";
            AV17httpclient.AddHeader("Cookie", AV29tCookieContent);
            AV17httpclient.Execute("Get", "/api/User/getpermission?userid="+StringUtil.Trim( StringUtil.Upper( AV5WWPContext.gxTpr_Userguid)));
            AV45websession.Set("DAS_UserPermission", StringUtil.Trim( AV17httpclient.ToString()));
         }
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
            AV11BCBAS_Tenant = new SdtBAS_Tenant(context);
            AV11BCBAS_Tenant.Load(StringUtil.Trim( AV30tCurrentCode));
            AV16hospitalLogo = AV11BCBAS_Tenant.gxTpr_Bas_tenantlogo;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo)) ? AV50Hospitallogo_GXI : context.convertURL( context.PathToRelativeUrl( AV16hospitalLogo))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "SrcSet", context.GetImageSrcSet( AV16hospitalLogo), true);
            AV50Hospitallogo_GXI = GXDbFile.PathToUrl( AV11BCBAS_Tenant.gxTpr_Bas_tenantlogo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo)) ? AV50Hospitallogo_GXI : context.convertURL( context.PathToRelativeUrl( AV16hospitalLogo))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "SrcSet", context.GetImageSrcSet( AV16hospitalLogo), true);
            AV35tLogoImageUrl = AV50Hospitallogo_GXI;
            AV50Hospitallogo_GXI = StringUtil.StringReplace( AV35tLogoImageUrl, "https://datamanager.chinacloudsites.cn", "/datamanager");
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo)) ? AV50Hospitallogo_GXI : context.convertURL( context.PathToRelativeUrl( AV16hospitalLogo))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "SrcSet", context.GetImageSrcSet( AV16hospitalLogo), true);
            AV16hospitalLogo = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV16hospitalLogo)) ? AV50Hospitallogo_GXI : context.convertURL( context.PathToRelativeUrl( AV16hospitalLogo))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, imgavHospitallogo_Internalname, "SrcSet", context.GetImageSrcSet( AV16hospitalLogo), true);
         }
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Headerrawhtml = "<link rel=\"shortcut icon\" type=\"image/x-icon\" href=\""+context.convertURL( (String)(context.GetImagePath( "dc95f888-0f39-4e7f-89e6-7fab68843e0d", "", context.GetTheme( ))))+"\">";
         divLayoutmaintable_Class = "MainContainerWithFooter";
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, divLayoutmaintable_Internalname, "Class", divLayoutmaintable_Class, true);
         GXt_objcol_SdtDVelop_Menu_Item2 = AV13DVelop_Menu;
         new GeneXus.Programs.wwpbaseobjects.menuoptionsdata(context ).execute( out  GXt_objcol_SdtDVelop_Menu_Item2) ;
         AV13DVelop_Menu = GXt_objcol_SdtDVelop_Menu_Item2;
         new GeneXus.Programs.wwpbaseobjects.getmenuauthorizedoptions(context ).execute( ref  AV13DVelop_Menu) ;
         Ddo_actiongm_Icon = context.convertURL( (String)(context.GetImagePath( "f41016dd-84e0-420e-89fd-a070d39d1203", "", context.GetTheme( ))));
         ucDdo_actiongm.SendProperty(context, "", true, Ddo_actiongm_Internalname, "Icon", Ddo_actiongm_Icon);
         AV6actionGMData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV7actionGMDataItem.gxTpr_Title = "Admin Portal";
         AV7actionGMDataItem.gxTpr_Eventkey = "gotopage1";
         AV7actionGMDataItem.gxTpr_Isdivider = false;
         AV6actionGMData.Add(AV7actionGMDataItem, 0);
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV7actionGMDataItem.gxTpr_Title = "Data Management";
         AV7actionGMDataItem.gxTpr_Eventkey = "gotopage3";
         AV7actionGMDataItem.gxTpr_Isdivider = false;
         AV6actionGMData.Add(AV7actionGMDataItem, 0);
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV7actionGMDataItem.gxTpr_Title = "Patient 360";
         AV7actionGMDataItem.gxTpr_Eventkey = "gotopage2";
         AV7actionGMDataItem.gxTpr_Isdivider = false;
         AV6actionGMData.Add(AV7actionGMDataItem, 0);
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV7actionGMDataItem.gxTpr_Title = "HOME";
         AV7actionGMDataItem.gxTpr_Eventkey = "gotopage5";
         AV7actionGMDataItem.gxTpr_Isdivider = false;
         AV6actionGMData.Add(AV7actionGMDataItem, 0);
         Ddo_adminag_Icon = context.convertURL( (String)(context.GetImagePath( "f3587200-564c-4c34-a609-159f6889c108", "", context.GetTheme( ))));
         AV8AdminAGData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV10AdminAGDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV10AdminAGDataItem.gxTpr_Title = "个人信息";
         AV10AdminAGDataItem.gxTpr_Eventkey = "ActionChangePassword";
         AV10AdminAGDataItem.gxTpr_Isdivider = false;
         AV8AdminAGData.Add(AV10AdminAGDataItem, 0);
         AV10AdminAGDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV10AdminAGDataItem.gxTpr_Title = "退出";
         AV10AdminAGDataItem.gxTpr_Eventkey = "ActionLogOut";
         AV10AdminAGDataItem.gxTpr_Isdivider = false;
         AV8AdminAGData.Add(AV10AdminAGDataItem, 0);
         AV10AdminAGDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV10AdminAGDataItem.gxTpr_Title = "切换租户";
         AV10AdminAGDataItem.gxTpr_Eventkey = "changeTenant";
         AV10AdminAGDataItem.gxTpr_Isdivider = false;
         AV8AdminAGData.Add(AV10AdminAGDataItem, 0);
         AV44UserName = AV5WWPContext.gxTpr_Username;
         AV14DVelop_Menu_UserData.gxTpr_Firstline = AV44UserName;
         lblText_username_Caption = StringUtil.Trim( AV44UserName);
         context.httpAjaxContext.ajax_rsp_assign_prop("", true, lblText_username_Internalname, "Caption", lblText_username_Caption, true);
         Ddo_adminag_Titlecontrolalign = "Left";
         AV38tResult = AV45websession.Get("DAS_UserPermission");
         AV40tSDT_MicroUserInfo.FromJSonString(AV38tResult, null);
         AV43tUserType = StringUtil.Str( (decimal)(AV40tSDT_MicroUserInfo.gxTpr_Usertype), 4, 0);
         if ( AV5WWPContext.gxTpr_Currenttnum <= 1 )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( AV43tUserType), "0") != 0 )
            {
               AV8AdminAGData.RemoveItem(3);
            }
         }
      }

      protected void E13822( )
      {
         /* Ddo_actiongm_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_actiongm_Activeeventkey, "gotopage1") == 0 )
         {
            /* Execute user subroutine: 'DO GOTOPAGE1' */
            S112 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_actiongm_Activeeventkey, "gotopage3") == 0 )
         {
            /* Execute user subroutine: 'DO GOTOPAGE3' */
            S122 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_actiongm_Activeeventkey, "gotopage2") == 0 )
         {
            /* Execute user subroutine: 'DO GOTOPAGE2' */
            S132 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_actiongm_Activeeventkey, "gotopage5") == 0 )
         {
            /* Execute user subroutine: 'DO GOTOPAGE5' */
            S142 ();
            if (returnInSub) return;
         }
      }

      protected void E12822( )
      {
         /* Ddo_adminag_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_adminag_Activeeventkey, "ActionChangePassword") == 0 )
         {
            /* Execute user subroutine: 'DO ACTIONCHANGEPASSWORD' */
            S152 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_adminag_Activeeventkey, "ActionLogOut") == 0 )
         {
            /* Execute user subroutine: 'DO ACTIONLOGOUT' */
            S162 ();
            if (returnInSub) return;
         }
         else if ( StringUtil.StrCmp(Ddo_adminag_Activeeventkey, "changeTenant") == 0 )
         {
            /* Execute user subroutine: 'DO CHANGETENANT' */
            S172 ();
            if (returnInSub) return;
         }
      }

      protected void S112( )
      {
         /* 'DO GOTOPAGE1' Routine */
         AV12BCXT_Config.Load(5);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue1);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S122( )
      {
         /* 'DO GOTOPAGE3' Routine */
         AV12BCXT_Config.Load(3);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue2);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S132( )
      {
         /* 'DO GOTOPAGE2' Routine */
         AV12BCXT_Config.Load(5);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue2);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S142( )
      {
         /* 'DO GOTOPAGE5' Routine */
         AV12BCXT_Config.Load(4);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue3);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S152( )
      {
         /* 'DO ACTIONCHANGEPASSWORD' Routine */
         AV12BCXT_Config.Load(5);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue3);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S162( )
      {
         /* 'DO ACTIONLOGOUT' Routine */
         AV12BCXT_Config.Load(4);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue1);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S172( )
      {
         /* 'DO CHANGETENANT' Routine */
         AV12BCXT_Config.Load(4);
         AV41tTargetUrl = StringUtil.Trim( AV12BCXT_Config.gxTpr_Xt_configvalue4);
         CallWebObject(formatLink(AV41tTargetUrl) );
         context.wjLocDisableFrm = 0;
      }

      protected void S182( )
      {
         /* 'DO GOTOPAGE4' Routine */
         CallWebObject(formatLink("dashboard.aspx") );
         context.wjLocDisableFrm = 1;
      }

      protected void nextLoad( )
      {
      }

      protected void E15822( )
      {
         /* Load Routine */
      }

      protected void wb_table1_12_822( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTableuserrole_Internalname, tblTableuserrole_Internalname, "", "TableAlignRightMaster", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblWelcomeuse_Internalname, "欢迎使用", "", "", lblWelcomeuse_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "TextBlock_Welcome", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\WorkWithPlusMasterPageBack.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Static images/pictures */
            ClassString = "Image_HeadUser";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "d22e46c4-f4d3-420c-9523-26ffa5332482", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgDas_menu_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" ", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WWPBaseObjects\\WorkWithPlusMasterPageBack.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblText_username_Internalname, lblText_username_Caption, "", "", lblText_username_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "TextBlock_HeaderUser", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\WorkWithPlusMasterPageBack.htm");
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
            wb_table1_12_822e( true) ;
         }
         else
         {
            wb_table1_12_822e( false) ;
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
         PA822( ) ;
         WS822( ) ;
         WE822( ) ;
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
         AddStyleSheetFile("DVelop/Bootstrap/Shared/fontawesome/font-awesome.min.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/DVelopBootstrap.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)(getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Item(idxLst))), "?202022815163617", true);
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
         context.AddJavascriptSource("wwpbaseobjects/workwithplusmasterpageback.js", "?202022815163617", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/slimscroll/jquery.slimscroll.min.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/SidebarMenu/BootstrapSidebarMenuRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Tooltip/BootstrapTooltipRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblWelcomeuse_Internalname = "WELCOMEUSE_MPAGE";
         imgDas_menu_Internalname = "DAS_MENU_MPAGE";
         lblText_username_Internalname = "TEXT_USERNAME_MPAGE";
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
         imgExpandmenu_Internalname = "EXPANDMENU_MPAGE";
         divTablecontent_Internalname = "TABLECONTENT_MPAGE";
         Ucmenu_Internalname = "UCMENU_MPAGE";
         lblTextblockfooter_Internalname = "TEXTBLOCKFOOTER_MPAGE";
         divTablefooter_Internalname = "TABLEFOOTER_MPAGE";
         Uctooltip_Internalname = "UCTOOLTIP_MPAGE";
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
         lblText_username_Caption = "用户";
         imgavHospitallogo_Visible = 1;
         imgRoche_logo_Visible = 1;
         divLayoutmaintable_Class = "Table";
         Ucmenu_Sidebarmainclass = "page-sidebar sidebar-fixed";
         Ddo_actiongm_Cls = "ActionGroupHeaderTheo";
         Ddo_adminag_Titlecontrolalign = "Automatic";
         Ddo_adminag_Cls = "ActionGroupHeader";
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
         setEventMetadata("DOEXPANDMENU_MPAGE","{handler:'E11821',iparms:[]");
         setEventMetadata("DOEXPANDMENU_MPAGE",",oparms:[]}");
         setEventMetadata("DDO_ACTIONGM_MPAGE.ONOPTIONCLICKED_MPAGE","{handler:'E13822',iparms:[{av:'Ddo_actiongm_Activeeventkey',ctrl:'DDO_ACTIONGM_MPAGE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_ACTIONGM_MPAGE.ONOPTIONCLICKED_MPAGE",",oparms:[]}");
         setEventMetadata("DDO_ADMINAG_MPAGE.ONOPTIONCLICKED_MPAGE","{handler:'E12822',iparms:[{av:'Ddo_adminag_Activeeventkey',ctrl:'DDO_ADMINAG_MPAGE',prop:'ActiveEventKey'}]");
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
         AV13DVelop_Menu = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item>( context, "Item", "DataAnalysisPlatform");
         AV14DVelop_Menu_UserData = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_UserData(context);
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
         TempTags = "";
         imgExpandmenu_Jsonclick = "";
         ucUcmenu = new GXUserControl();
         lblTextblockfooter_Jsonclick = "";
         ucUctooltip = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV5WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV29tCookieContent = "";
         AV12BCXT_Config = new SdtXT_Config(context);
         AV41tTargetUrl = "";
         AV46tCurPage = "";
         AV47httprequest = new GxHttpRequest( context);
         AV38tResult = "";
         AV45websession = context.GetSession();
         AV17httpclient = new GxHttpClient( context);
         AV30tCurrentCode = "";
         AV11BCBAS_Tenant = new SdtBAS_Tenant(context);
         AV35tLogoImageUrl = "";
         GXt_objcol_SdtDVelop_Menu_Item2 = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item>( context, "Item", "DataAnalysisPlatform");
         AV7actionGMDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV10AdminAGDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV44UserName = "";
         AV40tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         AV43tUserType = "";
         sStyleString = "";
         lblWelcomeuse_Jsonclick = "";
         lblText_username_Jsonclick = "";
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
      private short GXt_int1 ;
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
      private String Ucmenu_Sidebarmainclass ;
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
      private String TempTags ;
      private String imgExpandmenu_Internalname ;
      private String imgExpandmenu_Jsonclick ;
      private String Ucmenu_Internalname ;
      private String divTablefooter_Internalname ;
      private String lblTextblockfooter_Internalname ;
      private String lblTextblockfooter_Jsonclick ;
      private String Uctooltip_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String lblText_username_Caption ;
      private String lblText_username_Internalname ;
      private String sStyleString ;
      private String tblTableuserrole_Internalname ;
      private String lblWelcomeuse_Internalname ;
      private String lblWelcomeuse_Jsonclick ;
      private String imgDas_menu_Internalname ;
      private String lblText_username_Jsonclick ;
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
      private bool AV34tFlag ;
      private String AV50Hospitallogo_GXI ;
      private String AV29tCookieContent ;
      private String AV41tTargetUrl ;
      private String AV46tCurPage ;
      private String AV38tResult ;
      private String AV30tCurrentCode ;
      private String AV35tLogoImageUrl ;
      private String AV44UserName ;
      private String AV43tUserType ;
      private String AV16hospitalLogo ;
      private IGxSession AV45websession ;
      private GXUserControl ucDdo_actiongm ;
      private GXUserControl ucUcmenu ;
      private GXUserControl ucUctooltip ;
      private GXUserControl ucDdo_adminag ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXDataAreaControl Contentholder ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpClient AV17httpclient ;
      private GxHttpRequest AV47httprequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV8AdminAGData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV6actionGMData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> AV13DVelop_Menu ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> GXt_objcol_SdtDVelop_Menu_Item2 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV5WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item AV7actionGMDataItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item AV10AdminAGDataItem ;
      private SdtBAS_Tenant AV11BCBAS_Tenant ;
      private SdtXT_Config AV12BCXT_Config ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_UserData AV14DVelop_Menu_UserData ;
      private SdtSDT_MicroUserInfo AV40tSDT_MicroUserInfo ;
   }

}
