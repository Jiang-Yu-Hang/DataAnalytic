/*
               File: BR_Pathology_Diag
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:15.53
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
namespace GeneXus.Programs {
   public class br_pathology_diag : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action10") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_10_0X34( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action11") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_11_0X34( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action12") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_12_0X34( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A226BR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n226BR_PathologyID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_14( A226BR_PathologyID) ;
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
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7BR_Pathology_DiagID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_Pathology_DiagID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PATHOLOGY_DIAGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBR_Pathology_Diag_Loc_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_pathology_diag( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_diag( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           long aP1_BR_Pathology_DiagID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_Pathology_DiagID = aP1_BR_Pathology_DiagID;
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

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpage", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableattributes.SetProperty("Width", Dvpanel_tableattributes_Width);
            ucDvpanel_tableattributes.SetProperty("AutoWidth", Dvpanel_tableattributes_Autowidth);
            ucDvpanel_tableattributes.SetProperty("AutoHeight", Dvpanel_tableattributes_Autoheight);
            ucDvpanel_tableattributes.SetProperty("Cls", Dvpanel_tableattributes_Cls);
            ucDvpanel_tableattributes.SetProperty("Title", Dvpanel_tableattributes_Title);
            ucDvpanel_tableattributes.SetProperty("Collapsible", Dvpanel_tableattributes_Collapsible);
            ucDvpanel_tableattributes.SetProperty("Collapsed", Dvpanel_tableattributes_Collapsed);
            ucDvpanel_tableattributes.SetProperty("ShowCollapseIcon", Dvpanel_tableattributes_Showcollapseicon);
            ucDvpanel_tableattributes.SetProperty("IconPosition", Dvpanel_tableattributes_Iconposition);
            ucDvpanel_tableattributes.SetProperty("AutoScroll", Dvpanel_tableattributes_Autoscroll);
            ucDvpanel_tableattributes.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableattributes_Internalname, "DVPANEL_TABLEATTRIBUTESContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_loc_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_diag_loc_Internalname, "病理诊断(部位)", "", "", lblTextblockbr_pathology_diag_loc_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Diag_Loc_Internalname, "病理诊断(部位)", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Diag_Loc_Internalname, A277BR_Pathology_Diag_Loc, StringUtil.RTrim( context.localUtil.Format( A277BR_Pathology_Diag_Loc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Diag_Loc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_Diag_Loc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_organ_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_diag_organ_Internalname, "病理诊断(器官)", "", "", lblTextblockbr_pathology_diag_organ_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Diag_Organ_Internalname, "病理诊断(器官)", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Diag_Organ_Internalname, A278BR_Pathology_Diag_Organ, StringUtil.RTrim( context.localUtil.Format( A278BR_Pathology_Diag_Organ, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Diag_Organ_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_Diag_Organ_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_Diag.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_tumortype_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_diag_tumortype_Internalname, "肿瘤类型", "", "", lblTextblockbr_pathology_diag_tumortype_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Diag_TumorType_Internalname, "肿瘤类型", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Diag_TumorType_Internalname, A279BR_Pathology_Diag_TumorType, StringUtil.RTrim( context.localUtil.Format( A279BR_Pathology_Diag_TumorType, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Diag_TumorType_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_Diag_TumorType_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_tumorstage_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_diag_tumorstage_Internalname, "肿瘤分期", "", "", lblTextblockbr_pathology_diag_tumorstage_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Diag_TumorStage_Internalname, "肿瘤分期", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Diag_TumorStage_Internalname, A280BR_Pathology_Diag_TumorStage, StringUtil.RTrim( context.localUtil.Format( A280BR_Pathology_Diag_TumorStage, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Diag_TumorStage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_Diag_TumorStage_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_Diag.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_tumorgrade_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_diag_tumorgrade_Internalname, "肿瘤分级", "", "", lblTextblockbr_pathology_diag_tumorgrade_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Diag_TumorGrade_Internalname, "肿瘤分级", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Diag_TumorGrade_Internalname, A281BR_Pathology_Diag_TumorGrade, StringUtil.RTrim( context.localUtil.Format( A281BR_Pathology_Diag_TumorGrade, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Diag_TumorGrade_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_Diag_TumorGrade_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_Diag.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_DiagID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A276BR_Pathology_DiagID), 18, 0, ".", "")), ((edtBR_Pathology_DiagID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_DiagID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Pathology_DiagID_Visible, edtBR_Pathology_DiagID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Pathology_Diag.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_PathologyID_Visible, edtBR_PathologyID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Pathology_Diag.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110X2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A277BR_Pathology_Diag_Loc = cgiGet( edtBR_Pathology_Diag_Loc_Internalname);
               n277BR_Pathology_Diag_Loc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277BR_Pathology_Diag_Loc", A277BR_Pathology_Diag_Loc);
               n277BR_Pathology_Diag_Loc = (String.IsNullOrEmpty(StringUtil.RTrim( A277BR_Pathology_Diag_Loc)) ? true : false);
               A278BR_Pathology_Diag_Organ = cgiGet( edtBR_Pathology_Diag_Organ_Internalname);
               n278BR_Pathology_Diag_Organ = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278BR_Pathology_Diag_Organ", A278BR_Pathology_Diag_Organ);
               n278BR_Pathology_Diag_Organ = (String.IsNullOrEmpty(StringUtil.RTrim( A278BR_Pathology_Diag_Organ)) ? true : false);
               A279BR_Pathology_Diag_TumorType = cgiGet( edtBR_Pathology_Diag_TumorType_Internalname);
               n279BR_Pathology_Diag_TumorType = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279BR_Pathology_Diag_TumorType", A279BR_Pathology_Diag_TumorType);
               n279BR_Pathology_Diag_TumorType = (String.IsNullOrEmpty(StringUtil.RTrim( A279BR_Pathology_Diag_TumorType)) ? true : false);
               A280BR_Pathology_Diag_TumorStage = cgiGet( edtBR_Pathology_Diag_TumorStage_Internalname);
               n280BR_Pathology_Diag_TumorStage = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A280BR_Pathology_Diag_TumorStage", A280BR_Pathology_Diag_TumorStage);
               n280BR_Pathology_Diag_TumorStage = (String.IsNullOrEmpty(StringUtil.RTrim( A280BR_Pathology_Diag_TumorStage)) ? true : false);
               A281BR_Pathology_Diag_TumorGrade = cgiGet( edtBR_Pathology_Diag_TumorGrade_Internalname);
               n281BR_Pathology_Diag_TumorGrade = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281BR_Pathology_Diag_TumorGrade", A281BR_Pathology_Diag_TumorGrade);
               n281BR_Pathology_Diag_TumorGrade = (String.IsNullOrEmpty(StringUtil.RTrim( A281BR_Pathology_Diag_TumorGrade)) ? true : false);
               A276BR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( edtBR_Pathology_DiagID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGYID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_PathologyID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A226BR_PathologyID = 0;
                  n226BR_PathologyID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               }
               else
               {
                  A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
                  n226BR_PathologyID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               }
               n226BR_PathologyID = ((0==A226BR_PathologyID) ? true : false);
               /* Read saved values. */
               Z276BR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( "Z276BR_Pathology_DiagID"), ".", ","));
               Z277BR_Pathology_Diag_Loc = cgiGet( "Z277BR_Pathology_Diag_Loc");
               n277BR_Pathology_Diag_Loc = (String.IsNullOrEmpty(StringUtil.RTrim( A277BR_Pathology_Diag_Loc)) ? true : false);
               Z278BR_Pathology_Diag_Organ = cgiGet( "Z278BR_Pathology_Diag_Organ");
               n278BR_Pathology_Diag_Organ = (String.IsNullOrEmpty(StringUtil.RTrim( A278BR_Pathology_Diag_Organ)) ? true : false);
               Z279BR_Pathology_Diag_TumorType = cgiGet( "Z279BR_Pathology_Diag_TumorType");
               n279BR_Pathology_Diag_TumorType = (String.IsNullOrEmpty(StringUtil.RTrim( A279BR_Pathology_Diag_TumorType)) ? true : false);
               Z280BR_Pathology_Diag_TumorStage = cgiGet( "Z280BR_Pathology_Diag_TumorStage");
               n280BR_Pathology_Diag_TumorStage = (String.IsNullOrEmpty(StringUtil.RTrim( A280BR_Pathology_Diag_TumorStage)) ? true : false);
               Z281BR_Pathology_Diag_TumorGrade = cgiGet( "Z281BR_Pathology_Diag_TumorGrade");
               n281BR_Pathology_Diag_TumorGrade = (String.IsNullOrEmpty(StringUtil.RTrim( A281BR_Pathology_Diag_TumorGrade)) ? true : false);
               Z226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( "Z226BR_PathologyID"), ".", ","));
               n226BR_PathologyID = ((0==A226BR_PathologyID) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( "N226BR_PathologyID"), ".", ","));
               n226BR_PathologyID = ((0==A226BR_PathologyID) ? true : false);
               AV7BR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( "vBR_PATHOLOGY_DIAGID"), ".", ","));
               AV13Insert_BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_PATHOLOGYID"), ".", ","));
               AV16Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               Dvpanel_tableattributes_Objectcall = cgiGet( "DVPANEL_TABLEATTRIBUTES_Objectcall");
               Dvpanel_tableattributes_Class = cgiGet( "DVPANEL_TABLEATTRIBUTES_Class");
               Dvpanel_tableattributes_Enabled = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Enabled"));
               Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
               Dvpanel_tableattributes_Height = cgiGet( "DVPANEL_TABLEATTRIBUTES_Height");
               Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
               Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
               Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
               Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
               Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
               Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
               Dvpanel_tableattributes_Showheader = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showheader"));
               Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
               Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
               Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
               Dvpanel_tableattributes_Visible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Visible"));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "BR_Pathology_Diag";
               A276BR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( edtBR_Pathology_DiagID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A276BR_Pathology_DiagID != Z276BR_Pathology_DiagID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_pathology_diag:[SecurityCheckFailed value for]"+"BR_Pathology_DiagID:"+context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_pathology_diag:[SecurityCheckFailed value for]"+"Insert_BR_PathologyID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_pathology_diag:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A276BR_Pathology_DiagID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode34 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode34;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound34 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0X0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_PATHOLOGY_DIAGID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_Pathology_DiagID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E110X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E120X2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0X34( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtntrn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes0X34( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_0X0( )
      {
         BeforeValidate0X34( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0X34( ) ;
            }
            else
            {
               CheckExtendedTable0X34( ) ;
               CloseExtendedTableCursors0X34( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0X0( )
      {
      }

      protected void E110X2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV16Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV17GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            while ( AV17GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV17GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_PathologyID") == 0 )
               {
                  AV13Insert_BR_PathologyID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_BR_PathologyID), 18, 0)));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            }
         }
         edtBR_Pathology_DiagID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_DiagID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_DiagID_Visible), 5, 0)), true);
         edtBR_PathologyID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Visible), 5, 0)), true);
         GXt_boolean1 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean1) ;
         AV15TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean1) ;
         AV15TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_cancel_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_cancel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_cancel_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean1) ;
         AV15TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         }
      }

      protected void E120X2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_pathology_diagww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0X34( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z277BR_Pathology_Diag_Loc = T000X3_A277BR_Pathology_Diag_Loc[0];
               Z278BR_Pathology_Diag_Organ = T000X3_A278BR_Pathology_Diag_Organ[0];
               Z279BR_Pathology_Diag_TumorType = T000X3_A279BR_Pathology_Diag_TumorType[0];
               Z280BR_Pathology_Diag_TumorStage = T000X3_A280BR_Pathology_Diag_TumorStage[0];
               Z281BR_Pathology_Diag_TumorGrade = T000X3_A281BR_Pathology_Diag_TumorGrade[0];
               Z226BR_PathologyID = T000X3_A226BR_PathologyID[0];
            }
            else
            {
               Z277BR_Pathology_Diag_Loc = A277BR_Pathology_Diag_Loc;
               Z278BR_Pathology_Diag_Organ = A278BR_Pathology_Diag_Organ;
               Z279BR_Pathology_Diag_TumorType = A279BR_Pathology_Diag_TumorType;
               Z280BR_Pathology_Diag_TumorStage = A280BR_Pathology_Diag_TumorStage;
               Z281BR_Pathology_Diag_TumorGrade = A281BR_Pathology_Diag_TumorGrade;
               Z226BR_PathologyID = A226BR_PathologyID;
            }
         }
         if ( GX_JID == -13 )
         {
            Z276BR_Pathology_DiagID = A276BR_Pathology_DiagID;
            Z277BR_Pathology_Diag_Loc = A277BR_Pathology_Diag_Loc;
            Z278BR_Pathology_Diag_Organ = A278BR_Pathology_Diag_Organ;
            Z279BR_Pathology_Diag_TumorType = A279BR_Pathology_Diag_TumorType;
            Z280BR_Pathology_Diag_TumorStage = A280BR_Pathology_Diag_TumorStage;
            Z281BR_Pathology_Diag_TumorGrade = A281BR_Pathology_Diag_TumorGrade;
            Z226BR_PathologyID = A226BR_PathologyID;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_Pathology_DiagID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_DiagID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_DiagID_Enabled), 5, 0)), true);
         edtBR_Pathology_DiagID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_DiagID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_DiagID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_Pathology_DiagID) )
         {
            A276BR_Pathology_DiagID = AV7BR_Pathology_DiagID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_PathologyID) )
         {
            edtBR_PathologyID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Enabled), 5, 0)), true);
         }
         else
         {
            edtBR_PathologyID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_PathologyID) )
         {
            A226BR_PathologyID = AV13Insert_BR_PathologyID;
            n226BR_PathologyID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtntrn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV16Pgmname = "BR_Pathology_Diag";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         }
      }

      protected void Load0X34( )
      {
         /* Using cursor T000X5 */
         pr_default.execute(3, new Object[] {A276BR_Pathology_DiagID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound34 = 1;
            A277BR_Pathology_Diag_Loc = T000X5_A277BR_Pathology_Diag_Loc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277BR_Pathology_Diag_Loc", A277BR_Pathology_Diag_Loc);
            n277BR_Pathology_Diag_Loc = T000X5_n277BR_Pathology_Diag_Loc[0];
            A278BR_Pathology_Diag_Organ = T000X5_A278BR_Pathology_Diag_Organ[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278BR_Pathology_Diag_Organ", A278BR_Pathology_Diag_Organ);
            n278BR_Pathology_Diag_Organ = T000X5_n278BR_Pathology_Diag_Organ[0];
            A279BR_Pathology_Diag_TumorType = T000X5_A279BR_Pathology_Diag_TumorType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279BR_Pathology_Diag_TumorType", A279BR_Pathology_Diag_TumorType);
            n279BR_Pathology_Diag_TumorType = T000X5_n279BR_Pathology_Diag_TumorType[0];
            A280BR_Pathology_Diag_TumorStage = T000X5_A280BR_Pathology_Diag_TumorStage[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A280BR_Pathology_Diag_TumorStage", A280BR_Pathology_Diag_TumorStage);
            n280BR_Pathology_Diag_TumorStage = T000X5_n280BR_Pathology_Diag_TumorStage[0];
            A281BR_Pathology_Diag_TumorGrade = T000X5_A281BR_Pathology_Diag_TumorGrade[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281BR_Pathology_Diag_TumorGrade", A281BR_Pathology_Diag_TumorGrade);
            n281BR_Pathology_Diag_TumorGrade = T000X5_n281BR_Pathology_Diag_TumorGrade[0];
            A226BR_PathologyID = T000X5_A226BR_PathologyID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            n226BR_PathologyID = T000X5_n226BR_PathologyID[0];
            ZM0X34( -13) ;
         }
         pr_default.close(3);
         OnLoadActions0X34( ) ;
      }

      protected void OnLoadActions0X34( )
      {
         AV16Pgmname = "BR_Pathology_Diag";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
      }

      protected void CheckExtendedTable0X34( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV16Pgmname = "BR_Pathology_Diag";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         /* Using cursor T000X4 */
         pr_default.execute(2, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A226BR_PathologyID) ) )
            {
               GX_msglist.addItem("不匹配' T36'", "ForeignKeyNotFound", 1, "BR_PATHOLOGYID");
               AnyError = 1;
               GX_FocusControl = edtBR_PathologyID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A277BR_Pathology_Diag_Loc)) )
         {
            GX_msglist.addItem("病理诊断(部位)是必须填写的。", 1, "BR_PATHOLOGY_DIAG_LOC");
            AnyError = 1;
            GX_FocusControl = edtBR_Pathology_Diag_Loc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A278BR_Pathology_Diag_Organ)) )
         {
            GX_msglist.addItem("病理诊断(器官)是必须填写的。", 1, "BR_PATHOLOGY_DIAG_ORGAN");
            AnyError = 1;
            GX_FocusControl = edtBR_Pathology_Diag_Organ_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0X34( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_14( long A226BR_PathologyID )
      {
         /* Using cursor T000X6 */
         pr_default.execute(4, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( (0==A226BR_PathologyID) ) )
            {
               GX_msglist.addItem("不匹配' T36'", "ForeignKeyNotFound", 1, "BR_PATHOLOGYID");
               AnyError = 1;
               GX_FocusControl = edtBR_PathologyID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey0X34( )
      {
         /* Using cursor T000X7 */
         pr_default.execute(5, new Object[] {A276BR_Pathology_DiagID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound34 = 1;
         }
         else
         {
            RcdFound34 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000X3 */
         pr_default.execute(1, new Object[] {A276BR_Pathology_DiagID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0X34( 13) ;
            RcdFound34 = 1;
            A276BR_Pathology_DiagID = T000X3_A276BR_Pathology_DiagID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
            A277BR_Pathology_Diag_Loc = T000X3_A277BR_Pathology_Diag_Loc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277BR_Pathology_Diag_Loc", A277BR_Pathology_Diag_Loc);
            n277BR_Pathology_Diag_Loc = T000X3_n277BR_Pathology_Diag_Loc[0];
            A278BR_Pathology_Diag_Organ = T000X3_A278BR_Pathology_Diag_Organ[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278BR_Pathology_Diag_Organ", A278BR_Pathology_Diag_Organ);
            n278BR_Pathology_Diag_Organ = T000X3_n278BR_Pathology_Diag_Organ[0];
            A279BR_Pathology_Diag_TumorType = T000X3_A279BR_Pathology_Diag_TumorType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279BR_Pathology_Diag_TumorType", A279BR_Pathology_Diag_TumorType);
            n279BR_Pathology_Diag_TumorType = T000X3_n279BR_Pathology_Diag_TumorType[0];
            A280BR_Pathology_Diag_TumorStage = T000X3_A280BR_Pathology_Diag_TumorStage[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A280BR_Pathology_Diag_TumorStage", A280BR_Pathology_Diag_TumorStage);
            n280BR_Pathology_Diag_TumorStage = T000X3_n280BR_Pathology_Diag_TumorStage[0];
            A281BR_Pathology_Diag_TumorGrade = T000X3_A281BR_Pathology_Diag_TumorGrade[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281BR_Pathology_Diag_TumorGrade", A281BR_Pathology_Diag_TumorGrade);
            n281BR_Pathology_Diag_TumorGrade = T000X3_n281BR_Pathology_Diag_TumorGrade[0];
            A226BR_PathologyID = T000X3_A226BR_PathologyID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            n226BR_PathologyID = T000X3_n226BR_PathologyID[0];
            Z276BR_Pathology_DiagID = A276BR_Pathology_DiagID;
            sMode34 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0X34( ) ;
            if ( AnyError == 1 )
            {
               RcdFound34 = 0;
               InitializeNonKey0X34( ) ;
            }
            Gx_mode = sMode34;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound34 = 0;
            InitializeNonKey0X34( ) ;
            sMode34 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode34;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0X34( ) ;
         if ( RcdFound34 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound34 = 0;
         /* Using cursor T000X8 */
         pr_default.execute(6, new Object[] {A276BR_Pathology_DiagID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000X8_A276BR_Pathology_DiagID[0] < A276BR_Pathology_DiagID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000X8_A276BR_Pathology_DiagID[0] > A276BR_Pathology_DiagID ) ) )
            {
               A276BR_Pathology_DiagID = T000X8_A276BR_Pathology_DiagID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
               RcdFound34 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound34 = 0;
         /* Using cursor T000X9 */
         pr_default.execute(7, new Object[] {A276BR_Pathology_DiagID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000X9_A276BR_Pathology_DiagID[0] > A276BR_Pathology_DiagID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000X9_A276BR_Pathology_DiagID[0] < A276BR_Pathology_DiagID ) ) )
            {
               A276BR_Pathology_DiagID = T000X9_A276BR_Pathology_DiagID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
               RcdFound34 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0X34( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_Pathology_Diag_Loc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0X34( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound34 == 1 )
            {
               if ( A276BR_Pathology_DiagID != Z276BR_Pathology_DiagID )
               {
                  A276BR_Pathology_DiagID = Z276BR_Pathology_DiagID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_PATHOLOGY_DIAGID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Pathology_DiagID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_Pathology_Diag_Loc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0X34( ) ;
                  GX_FocusControl = edtBR_Pathology_Diag_Loc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A276BR_Pathology_DiagID != Z276BR_Pathology_DiagID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_Pathology_Diag_Loc_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0X34( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_PATHOLOGY_DIAGID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_Pathology_DiagID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_Pathology_Diag_Loc_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0X34( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A276BR_Pathology_DiagID != Z276BR_Pathology_DiagID )
         {
            A276BR_Pathology_DiagID = Z276BR_Pathology_DiagID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_PATHOLOGY_DIAGID");
            AnyError = 1;
            GX_FocusControl = edtBR_Pathology_DiagID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_Pathology_Diag_Loc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0X34( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000X2 */
            pr_default.execute(0, new Object[] {A276BR_Pathology_DiagID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology_Diag"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z277BR_Pathology_Diag_Loc, T000X2_A277BR_Pathology_Diag_Loc[0]) != 0 ) || ( StringUtil.StrCmp(Z278BR_Pathology_Diag_Organ, T000X2_A278BR_Pathology_Diag_Organ[0]) != 0 ) || ( StringUtil.StrCmp(Z279BR_Pathology_Diag_TumorType, T000X2_A279BR_Pathology_Diag_TumorType[0]) != 0 ) || ( StringUtil.StrCmp(Z280BR_Pathology_Diag_TumorStage, T000X2_A280BR_Pathology_Diag_TumorStage[0]) != 0 ) || ( StringUtil.StrCmp(Z281BR_Pathology_Diag_TumorGrade, T000X2_A281BR_Pathology_Diag_TumorGrade[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z226BR_PathologyID != T000X2_A226BR_PathologyID[0] ) )
            {
               if ( StringUtil.StrCmp(Z277BR_Pathology_Diag_Loc, T000X2_A277BR_Pathology_Diag_Loc[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_diag:[seudo value changed for attri]"+"BR_Pathology_Diag_Loc");
                  GXUtil.WriteLogRaw("Old: ",Z277BR_Pathology_Diag_Loc);
                  GXUtil.WriteLogRaw("Current: ",T000X2_A277BR_Pathology_Diag_Loc[0]);
               }
               if ( StringUtil.StrCmp(Z278BR_Pathology_Diag_Organ, T000X2_A278BR_Pathology_Diag_Organ[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_diag:[seudo value changed for attri]"+"BR_Pathology_Diag_Organ");
                  GXUtil.WriteLogRaw("Old: ",Z278BR_Pathology_Diag_Organ);
                  GXUtil.WriteLogRaw("Current: ",T000X2_A278BR_Pathology_Diag_Organ[0]);
               }
               if ( StringUtil.StrCmp(Z279BR_Pathology_Diag_TumorType, T000X2_A279BR_Pathology_Diag_TumorType[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_diag:[seudo value changed for attri]"+"BR_Pathology_Diag_TumorType");
                  GXUtil.WriteLogRaw("Old: ",Z279BR_Pathology_Diag_TumorType);
                  GXUtil.WriteLogRaw("Current: ",T000X2_A279BR_Pathology_Diag_TumorType[0]);
               }
               if ( StringUtil.StrCmp(Z280BR_Pathology_Diag_TumorStage, T000X2_A280BR_Pathology_Diag_TumorStage[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_diag:[seudo value changed for attri]"+"BR_Pathology_Diag_TumorStage");
                  GXUtil.WriteLogRaw("Old: ",Z280BR_Pathology_Diag_TumorStage);
                  GXUtil.WriteLogRaw("Current: ",T000X2_A280BR_Pathology_Diag_TumorStage[0]);
               }
               if ( StringUtil.StrCmp(Z281BR_Pathology_Diag_TumorGrade, T000X2_A281BR_Pathology_Diag_TumorGrade[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_diag:[seudo value changed for attri]"+"BR_Pathology_Diag_TumorGrade");
                  GXUtil.WriteLogRaw("Old: ",Z281BR_Pathology_Diag_TumorGrade);
                  GXUtil.WriteLogRaw("Current: ",T000X2_A281BR_Pathology_Diag_TumorGrade[0]);
               }
               if ( Z226BR_PathologyID != T000X2_A226BR_PathologyID[0] )
               {
                  GXUtil.WriteLog("br_pathology_diag:[seudo value changed for attri]"+"BR_PathologyID");
                  GXUtil.WriteLogRaw("Old: ",Z226BR_PathologyID);
                  GXUtil.WriteLogRaw("Current: ",T000X2_A226BR_PathologyID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Pathology_Diag"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0X34( )
      {
         BeforeValidate0X34( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0X34( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0X34( 0) ;
            CheckOptimisticConcurrency0X34( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0X34( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0X34( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000X10 */
                     pr_default.execute(8, new Object[] {n277BR_Pathology_Diag_Loc, A277BR_Pathology_Diag_Loc, n278BR_Pathology_Diag_Organ, A278BR_Pathology_Diag_Organ, n279BR_Pathology_Diag_TumorType, A279BR_Pathology_Diag_TumorType, n280BR_Pathology_Diag_TumorStage, A280BR_Pathology_Diag_TumorStage, n281BR_Pathology_Diag_TumorGrade, A281BR_Pathology_Diag_TumorGrade, n226BR_PathologyID, A226BR_PathologyID});
                     A276BR_Pathology_DiagID = T000X10_A276BR_Pathology_DiagID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Diag") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)),  "诊断",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0X0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0X34( ) ;
            }
            EndLevel0X34( ) ;
         }
         CloseExtendedTableCursors0X34( ) ;
      }

      protected void Update0X34( )
      {
         BeforeValidate0X34( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0X34( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0X34( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0X34( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0X34( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000X11 */
                     pr_default.execute(9, new Object[] {n277BR_Pathology_Diag_Loc, A277BR_Pathology_Diag_Loc, n278BR_Pathology_Diag_Organ, A278BR_Pathology_Diag_Organ, n279BR_Pathology_Diag_TumorType, A279BR_Pathology_Diag_TumorType, n280BR_Pathology_Diag_TumorStage, A280BR_Pathology_Diag_TumorStage, n281BR_Pathology_Diag_TumorGrade, A281BR_Pathology_Diag_TumorGrade, n226BR_PathologyID, A226BR_PathologyID, A276BR_Pathology_DiagID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Diag") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology_Diag"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0X34( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)),  "诊断",  "Update",  1) ;
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0X34( ) ;
         }
         CloseExtendedTableCursors0X34( ) ;
      }

      protected void DeferredUpdate0X34( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0X34( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0X34( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0X34( ) ;
            AfterConfirm0X34( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0X34( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000X12 */
                  pr_default.execute(10, new Object[] {A276BR_Pathology_DiagID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Diag") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)),  "诊断",  "Delete",  1) ;
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode34 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0X34( ) ;
         Gx_mode = sMode34;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0X34( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Pathology_Diag";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         }
      }

      protected void EndLevel0X34( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0X34( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("br_pathology_diag",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0X0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("br_pathology_diag",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0X34( )
      {
         /* Scan By routine */
         /* Using cursor T000X13 */
         pr_default.execute(11);
         RcdFound34 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound34 = 1;
            A276BR_Pathology_DiagID = T000X13_A276BR_Pathology_DiagID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0X34( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound34 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound34 = 1;
            A276BR_Pathology_DiagID = T000X13_A276BR_Pathology_DiagID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
         }
      }

      protected void ScanEnd0X34( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0X34( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0X34( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0X34( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0X34( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0X34( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0X34( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0X34( )
      {
         edtBR_Pathology_Diag_Loc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Diag_Loc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_Diag_Loc_Enabled), 5, 0)), true);
         edtBR_Pathology_Diag_Organ_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Diag_Organ_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_Diag_Organ_Enabled), 5, 0)), true);
         edtBR_Pathology_Diag_TumorType_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Diag_TumorType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_Diag_TumorType_Enabled), 5, 0)), true);
         edtBR_Pathology_Diag_TumorStage_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Diag_TumorStage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_Diag_TumorStage_Enabled), 5, 0)), true);
         edtBR_Pathology_Diag_TumorGrade_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Diag_TumorGrade_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_Diag_TumorGrade_Enabled), 5, 0)), true);
         edtBR_Pathology_DiagID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_DiagID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_DiagID_Enabled), 5, 0)), true);
         edtBR_PathologyID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0X34( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0X0( )
      {
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
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202281581721", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Pathology_DiagID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Pathology_Diag";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_pathology_diag:[SendSecurityCheck value for]"+"BR_Pathology_DiagID:"+context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_pathology_diag:[SendSecurityCheck value for]"+"Insert_BR_PathologyID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_pathology_diag:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z276BR_Pathology_DiagID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z277BR_Pathology_Diag_Loc", Z277BR_Pathology_Diag_Loc);
         GxWebStd.gx_hidden_field( context, "Z278BR_Pathology_Diag_Organ", Z278BR_Pathology_Diag_Organ);
         GxWebStd.gx_hidden_field( context, "Z279BR_Pathology_Diag_TumorType", Z279BR_Pathology_Diag_TumorType);
         GxWebStd.gx_hidden_field( context, "Z280BR_Pathology_Diag_TumorStage", Z280BR_Pathology_Diag_TumorStage);
         GxWebStd.gx_hidden_field( context, "Z281BR_Pathology_Diag_TumorGrade", Z281BR_Pathology_Diag_TumorGrade);
         GxWebStd.gx_hidden_field( context, "Z226BR_PathologyID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z226BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N226BR_PathologyID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_PATHOLOGY_DIAGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_Pathology_DiagID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PATHOLOGY_DIAGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV16Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Objectcall", StringUtil.RTrim( Dvpanel_tableattributes_Objectcall));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Enabled", StringUtil.BoolToStr( Dvpanel_tableattributes_Enabled));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
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
         return formatLink("br_pathology_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Pathology_DiagID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Pathology_Diag" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey0X34( )
      {
         A226BR_PathologyID = 0;
         n226BR_PathologyID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
         n226BR_PathologyID = ((0==A226BR_PathologyID) ? true : false);
         A277BR_Pathology_Diag_Loc = "";
         n277BR_Pathology_Diag_Loc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A277BR_Pathology_Diag_Loc", A277BR_Pathology_Diag_Loc);
         n277BR_Pathology_Diag_Loc = (String.IsNullOrEmpty(StringUtil.RTrim( A277BR_Pathology_Diag_Loc)) ? true : false);
         A278BR_Pathology_Diag_Organ = "";
         n278BR_Pathology_Diag_Organ = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278BR_Pathology_Diag_Organ", A278BR_Pathology_Diag_Organ);
         n278BR_Pathology_Diag_Organ = (String.IsNullOrEmpty(StringUtil.RTrim( A278BR_Pathology_Diag_Organ)) ? true : false);
         A279BR_Pathology_Diag_TumorType = "";
         n279BR_Pathology_Diag_TumorType = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279BR_Pathology_Diag_TumorType", A279BR_Pathology_Diag_TumorType);
         n279BR_Pathology_Diag_TumorType = (String.IsNullOrEmpty(StringUtil.RTrim( A279BR_Pathology_Diag_TumorType)) ? true : false);
         A280BR_Pathology_Diag_TumorStage = "";
         n280BR_Pathology_Diag_TumorStage = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A280BR_Pathology_Diag_TumorStage", A280BR_Pathology_Diag_TumorStage);
         n280BR_Pathology_Diag_TumorStage = (String.IsNullOrEmpty(StringUtil.RTrim( A280BR_Pathology_Diag_TumorStage)) ? true : false);
         A281BR_Pathology_Diag_TumorGrade = "";
         n281BR_Pathology_Diag_TumorGrade = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281BR_Pathology_Diag_TumorGrade", A281BR_Pathology_Diag_TumorGrade);
         n281BR_Pathology_Diag_TumorGrade = (String.IsNullOrEmpty(StringUtil.RTrim( A281BR_Pathology_Diag_TumorGrade)) ? true : false);
         Z277BR_Pathology_Diag_Loc = "";
         Z278BR_Pathology_Diag_Organ = "";
         Z279BR_Pathology_Diag_TumorType = "";
         Z280BR_Pathology_Diag_TumorStage = "";
         Z281BR_Pathology_Diag_TumorGrade = "";
         Z226BR_PathologyID = 0;
      }

      protected void InitAll0X34( )
      {
         A276BR_Pathology_DiagID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
         InitializeNonKey0X34( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281581742", true);
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
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("br_pathology_diag.js", "?20202281581743", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_pathology_diag_loc_Internalname = "TEXTBLOCKBR_PATHOLOGY_DIAG_LOC";
         edtBR_Pathology_Diag_Loc_Internalname = "BR_PATHOLOGY_DIAG_LOC";
         divUnnamedtablebr_pathology_diag_loc_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_DIAG_LOC";
         lblTextblockbr_pathology_diag_organ_Internalname = "TEXTBLOCKBR_PATHOLOGY_DIAG_ORGAN";
         edtBR_Pathology_Diag_Organ_Internalname = "BR_PATHOLOGY_DIAG_ORGAN";
         divUnnamedtablebr_pathology_diag_organ_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_DIAG_ORGAN";
         lblTextblockbr_pathology_diag_tumortype_Internalname = "TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORTYPE";
         edtBR_Pathology_Diag_TumorType_Internalname = "BR_PATHOLOGY_DIAG_TUMORTYPE";
         divUnnamedtablebr_pathology_diag_tumortype_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORTYPE";
         lblTextblockbr_pathology_diag_tumorstage_Internalname = "TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORSTAGE";
         edtBR_Pathology_Diag_TumorStage_Internalname = "BR_PATHOLOGY_DIAG_TUMORSTAGE";
         divUnnamedtablebr_pathology_diag_tumorstage_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORSTAGE";
         lblTextblockbr_pathology_diag_tumorgrade_Internalname = "TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORGRADE";
         edtBR_Pathology_Diag_TumorGrade_Internalname = "BR_PATHOLOGY_DIAG_TUMORGRADE";
         divUnnamedtablebr_pathology_diag_tumorgrade_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORGRADE";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_Pathology_DiagID_Internalname = "BR_PATHOLOGY_DIAGID";
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Data Mgmt Portal - RAAP";
         edtBR_PathologyID_Jsonclick = "";
         edtBR_PathologyID_Enabled = 1;
         edtBR_PathologyID_Visible = 1;
         edtBR_Pathology_DiagID_Jsonclick = "";
         edtBR_Pathology_DiagID_Enabled = 0;
         edtBR_Pathology_DiagID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Pathology_Diag_TumorGrade_Jsonclick = "";
         edtBR_Pathology_Diag_TumorGrade_Enabled = 1;
         edtBR_Pathology_Diag_TumorStage_Jsonclick = "";
         edtBR_Pathology_Diag_TumorStage_Enabled = 1;
         edtBR_Pathology_Diag_TumorType_Jsonclick = "";
         edtBR_Pathology_Diag_TumorType_Enabled = 1;
         edtBR_Pathology_Diag_Organ_Jsonclick = "";
         edtBR_Pathology_Diag_Organ_Enabled = 1;
         edtBR_Pathology_Diag_Loc_Jsonclick = "";
         edtBR_Pathology_Diag_Loc_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "病理学诊断";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Width = "100%";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void XC_10_0X34( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)),  "诊断",  "Create",  1) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_11_0X34( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)),  "诊断",  "Update",  1) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_12_0X34( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)),  "诊断",  "Delete",  1) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Br_pathologyid( long GX_Parm1 )
      {
         A226BR_PathologyID = GX_Parm1;
         n226BR_PathologyID = false;
         /* Using cursor T000X14 */
         pr_default.execute(12, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(12) == 101) )
         {
            if ( ! ( (0==A226BR_PathologyID) ) )
            {
               GX_msglist.addItem("不匹配' T36'", "ForeignKeyNotFound", 1, "BR_PATHOLOGYID");
               AnyError = 1;
               GX_FocusControl = edtBR_PathologyID_Internalname;
            }
         }
         pr_default.close(12);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Pathology_DiagID',fld:'vBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Pathology_DiagID',fld:'vBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A276BR_Pathology_DiagID',fld:'BR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_BR_PathologyID',fld:'vINSERT_BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120X2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
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
         pr_default.close(1);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z277BR_Pathology_Diag_Loc = "";
         Z278BR_Pathology_Diag_Organ = "";
         Z279BR_Pathology_Diag_TumorType = "";
         Z280BR_Pathology_Diag_TumorStage = "";
         Z281BR_Pathology_Diag_TumorGrade = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_pathology_diag_loc_Jsonclick = "";
         TempTags = "";
         A277BR_Pathology_Diag_Loc = "";
         lblTextblockbr_pathology_diag_organ_Jsonclick = "";
         A278BR_Pathology_Diag_Organ = "";
         lblTextblockbr_pathology_diag_tumortype_Jsonclick = "";
         A279BR_Pathology_Diag_TumorType = "";
         lblTextblockbr_pathology_diag_tumorstage_Jsonclick = "";
         A280BR_Pathology_Diag_TumorStage = "";
         lblTextblockbr_pathology_diag_tumorgrade_Jsonclick = "";
         A281BR_Pathology_Diag_TumorGrade = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         AV16Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode34 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         T000X5_A276BR_Pathology_DiagID = new long[1] ;
         T000X5_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         T000X5_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         T000X5_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         T000X5_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         T000X5_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         T000X5_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         T000X5_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         T000X5_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         T000X5_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         T000X5_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         T000X5_A226BR_PathologyID = new long[1] ;
         T000X5_n226BR_PathologyID = new bool[] {false} ;
         T000X4_A226BR_PathologyID = new long[1] ;
         T000X4_n226BR_PathologyID = new bool[] {false} ;
         T000X6_A226BR_PathologyID = new long[1] ;
         T000X6_n226BR_PathologyID = new bool[] {false} ;
         T000X7_A276BR_Pathology_DiagID = new long[1] ;
         T000X3_A276BR_Pathology_DiagID = new long[1] ;
         T000X3_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         T000X3_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         T000X3_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         T000X3_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         T000X3_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         T000X3_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         T000X3_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         T000X3_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         T000X3_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         T000X3_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         T000X3_A226BR_PathologyID = new long[1] ;
         T000X3_n226BR_PathologyID = new bool[] {false} ;
         T000X8_A276BR_Pathology_DiagID = new long[1] ;
         T000X9_A276BR_Pathology_DiagID = new long[1] ;
         T000X2_A276BR_Pathology_DiagID = new long[1] ;
         T000X2_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         T000X2_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         T000X2_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         T000X2_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         T000X2_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         T000X2_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         T000X2_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         T000X2_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         T000X2_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         T000X2_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         T000X2_A226BR_PathologyID = new long[1] ;
         T000X2_n226BR_PathologyID = new bool[] {false} ;
         T000X10_A276BR_Pathology_DiagID = new long[1] ;
         T000X13_A276BR_Pathology_DiagID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000X14_A226BR_PathologyID = new long[1] ;
         T000X14_n226BR_PathologyID = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_diag__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_diag__default(),
            new Object[][] {
                new Object[] {
               T000X2_A276BR_Pathology_DiagID, T000X2_A277BR_Pathology_Diag_Loc, T000X2_n277BR_Pathology_Diag_Loc, T000X2_A278BR_Pathology_Diag_Organ, T000X2_n278BR_Pathology_Diag_Organ, T000X2_A279BR_Pathology_Diag_TumorType, T000X2_n279BR_Pathology_Diag_TumorType, T000X2_A280BR_Pathology_Diag_TumorStage, T000X2_n280BR_Pathology_Diag_TumorStage, T000X2_A281BR_Pathology_Diag_TumorGrade,
               T000X2_n281BR_Pathology_Diag_TumorGrade, T000X2_A226BR_PathologyID, T000X2_n226BR_PathologyID
               }
               , new Object[] {
               T000X3_A276BR_Pathology_DiagID, T000X3_A277BR_Pathology_Diag_Loc, T000X3_n277BR_Pathology_Diag_Loc, T000X3_A278BR_Pathology_Diag_Organ, T000X3_n278BR_Pathology_Diag_Organ, T000X3_A279BR_Pathology_Diag_TumorType, T000X3_n279BR_Pathology_Diag_TumorType, T000X3_A280BR_Pathology_Diag_TumorStage, T000X3_n280BR_Pathology_Diag_TumorStage, T000X3_A281BR_Pathology_Diag_TumorGrade,
               T000X3_n281BR_Pathology_Diag_TumorGrade, T000X3_A226BR_PathologyID, T000X3_n226BR_PathologyID
               }
               , new Object[] {
               T000X4_A226BR_PathologyID
               }
               , new Object[] {
               T000X5_A276BR_Pathology_DiagID, T000X5_A277BR_Pathology_Diag_Loc, T000X5_n277BR_Pathology_Diag_Loc, T000X5_A278BR_Pathology_Diag_Organ, T000X5_n278BR_Pathology_Diag_Organ, T000X5_A279BR_Pathology_Diag_TumorType, T000X5_n279BR_Pathology_Diag_TumorType, T000X5_A280BR_Pathology_Diag_TumorStage, T000X5_n280BR_Pathology_Diag_TumorStage, T000X5_A281BR_Pathology_Diag_TumorGrade,
               T000X5_n281BR_Pathology_Diag_TumorGrade, T000X5_A226BR_PathologyID, T000X5_n226BR_PathologyID
               }
               , new Object[] {
               T000X6_A226BR_PathologyID
               }
               , new Object[] {
               T000X7_A276BR_Pathology_DiagID
               }
               , new Object[] {
               T000X8_A276BR_Pathology_DiagID
               }
               , new Object[] {
               T000X9_A276BR_Pathology_DiagID
               }
               , new Object[] {
               T000X10_A276BR_Pathology_DiagID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000X13_A276BR_Pathology_DiagID
               }
               , new Object[] {
               T000X14_A226BR_PathologyID
               }
            }
         );
         AV16Pgmname = "BR_Pathology_Diag";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound34 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Pathology_Diag_Loc_Enabled ;
      private int edtBR_Pathology_Diag_Organ_Enabled ;
      private int edtBR_Pathology_Diag_TumorType_Enabled ;
      private int edtBR_Pathology_Diag_TumorStage_Enabled ;
      private int edtBR_Pathology_Diag_TumorGrade_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_Pathology_DiagID_Enabled ;
      private int edtBR_Pathology_DiagID_Visible ;
      private int edtBR_PathologyID_Visible ;
      private int edtBR_PathologyID_Enabled ;
      private int AV17GXV1 ;
      private int idxLst ;
      private long wcpOAV7BR_Pathology_DiagID ;
      private long Z276BR_Pathology_DiagID ;
      private long Z226BR_PathologyID ;
      private long N226BR_PathologyID ;
      private long A226BR_PathologyID ;
      private long AV7BR_Pathology_DiagID ;
      private long A276BR_Pathology_DiagID ;
      private long AV13Insert_BR_PathologyID ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtBR_Pathology_Diag_Loc_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String divUnnamedtablebr_pathology_diag_loc_Internalname ;
      private String lblTextblockbr_pathology_diag_loc_Internalname ;
      private String lblTextblockbr_pathology_diag_loc_Jsonclick ;
      private String TempTags ;
      private String edtBR_Pathology_Diag_Loc_Jsonclick ;
      private String divUnnamedtablebr_pathology_diag_organ_Internalname ;
      private String lblTextblockbr_pathology_diag_organ_Internalname ;
      private String lblTextblockbr_pathology_diag_organ_Jsonclick ;
      private String edtBR_Pathology_Diag_Organ_Internalname ;
      private String edtBR_Pathology_Diag_Organ_Jsonclick ;
      private String divUnnamedtablebr_pathology_diag_tumortype_Internalname ;
      private String lblTextblockbr_pathology_diag_tumortype_Internalname ;
      private String lblTextblockbr_pathology_diag_tumortype_Jsonclick ;
      private String edtBR_Pathology_Diag_TumorType_Internalname ;
      private String edtBR_Pathology_Diag_TumorType_Jsonclick ;
      private String divUnnamedtablebr_pathology_diag_tumorstage_Internalname ;
      private String lblTextblockbr_pathology_diag_tumorstage_Internalname ;
      private String lblTextblockbr_pathology_diag_tumorstage_Jsonclick ;
      private String edtBR_Pathology_Diag_TumorStage_Internalname ;
      private String edtBR_Pathology_Diag_TumorStage_Jsonclick ;
      private String divUnnamedtablebr_pathology_diag_tumorgrade_Internalname ;
      private String lblTextblockbr_pathology_diag_tumorgrade_Internalname ;
      private String lblTextblockbr_pathology_diag_tumorgrade_Jsonclick ;
      private String edtBR_Pathology_Diag_TumorGrade_Internalname ;
      private String edtBR_Pathology_Diag_TumorGrade_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Pathology_DiagID_Internalname ;
      private String edtBR_Pathology_DiagID_Jsonclick ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_PathologyID_Jsonclick ;
      private String AV16Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode34 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool n226BR_PathologyID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n277BR_Pathology_Diag_Loc ;
      private bool n278BR_Pathology_Diag_Organ ;
      private bool n279BR_Pathology_Diag_TumorType ;
      private bool n280BR_Pathology_Diag_TumorStage ;
      private bool n281BR_Pathology_Diag_TumorGrade ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool AV15TempBoolean ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z277BR_Pathology_Diag_Loc ;
      private String Z278BR_Pathology_Diag_Organ ;
      private String Z279BR_Pathology_Diag_TumorType ;
      private String Z280BR_Pathology_Diag_TumorStage ;
      private String Z281BR_Pathology_Diag_TumorGrade ;
      private String A277BR_Pathology_Diag_Loc ;
      private String A278BR_Pathology_Diag_Organ ;
      private String A279BR_Pathology_Diag_TumorType ;
      private String A280BR_Pathology_Diag_TumorStage ;
      private String A281BR_Pathology_Diag_TumorGrade ;
      private IGxSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T000X5_A276BR_Pathology_DiagID ;
      private String[] T000X5_A277BR_Pathology_Diag_Loc ;
      private bool[] T000X5_n277BR_Pathology_Diag_Loc ;
      private String[] T000X5_A278BR_Pathology_Diag_Organ ;
      private bool[] T000X5_n278BR_Pathology_Diag_Organ ;
      private String[] T000X5_A279BR_Pathology_Diag_TumorType ;
      private bool[] T000X5_n279BR_Pathology_Diag_TumorType ;
      private String[] T000X5_A280BR_Pathology_Diag_TumorStage ;
      private bool[] T000X5_n280BR_Pathology_Diag_TumorStage ;
      private String[] T000X5_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] T000X5_n281BR_Pathology_Diag_TumorGrade ;
      private long[] T000X5_A226BR_PathologyID ;
      private bool[] T000X5_n226BR_PathologyID ;
      private long[] T000X4_A226BR_PathologyID ;
      private bool[] T000X4_n226BR_PathologyID ;
      private long[] T000X6_A226BR_PathologyID ;
      private bool[] T000X6_n226BR_PathologyID ;
      private long[] T000X7_A276BR_Pathology_DiagID ;
      private long[] T000X3_A276BR_Pathology_DiagID ;
      private String[] T000X3_A277BR_Pathology_Diag_Loc ;
      private bool[] T000X3_n277BR_Pathology_Diag_Loc ;
      private String[] T000X3_A278BR_Pathology_Diag_Organ ;
      private bool[] T000X3_n278BR_Pathology_Diag_Organ ;
      private String[] T000X3_A279BR_Pathology_Diag_TumorType ;
      private bool[] T000X3_n279BR_Pathology_Diag_TumorType ;
      private String[] T000X3_A280BR_Pathology_Diag_TumorStage ;
      private bool[] T000X3_n280BR_Pathology_Diag_TumorStage ;
      private String[] T000X3_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] T000X3_n281BR_Pathology_Diag_TumorGrade ;
      private long[] T000X3_A226BR_PathologyID ;
      private bool[] T000X3_n226BR_PathologyID ;
      private long[] T000X8_A276BR_Pathology_DiagID ;
      private long[] T000X9_A276BR_Pathology_DiagID ;
      private long[] T000X2_A276BR_Pathology_DiagID ;
      private String[] T000X2_A277BR_Pathology_Diag_Loc ;
      private bool[] T000X2_n277BR_Pathology_Diag_Loc ;
      private String[] T000X2_A278BR_Pathology_Diag_Organ ;
      private bool[] T000X2_n278BR_Pathology_Diag_Organ ;
      private String[] T000X2_A279BR_Pathology_Diag_TumorType ;
      private bool[] T000X2_n279BR_Pathology_Diag_TumorType ;
      private String[] T000X2_A280BR_Pathology_Diag_TumorStage ;
      private bool[] T000X2_n280BR_Pathology_Diag_TumorStage ;
      private String[] T000X2_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] T000X2_n281BR_Pathology_Diag_TumorGrade ;
      private long[] T000X2_A226BR_PathologyID ;
      private bool[] T000X2_n226BR_PathologyID ;
      private long[] T000X10_A276BR_Pathology_DiagID ;
      private long[] T000X13_A276BR_Pathology_DiagID ;
      private long[] T000X14_A226BR_PathologyID ;
      private bool[] T000X14_n226BR_PathologyID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_pathology_diag__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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

 public class br_pathology_diag__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
       ,new ForEachCursor(def[5])
       ,new ForEachCursor(def[6])
       ,new ForEachCursor(def[7])
       ,new ForEachCursor(def[8])
       ,new UpdateCursor(def[9])
       ,new UpdateCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000X5 ;
        prmT000X5 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X4 ;
        prmT000X4 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X6 ;
        prmT000X6 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X7 ;
        prmT000X7 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X3 ;
        prmT000X3 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X8 ;
        prmT000X8 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X9 ;
        prmT000X9 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X2 ;
        prmT000X2 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X10 ;
        prmT000X10 = new Object[] {
        new Object[] {"@BR_Pathology_Diag_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Pathology_Diag_Organ",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorType",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorStage",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorGrade",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X11 ;
        prmT000X11 = new Object[] {
        new Object[] {"@BR_Pathology_Diag_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Pathology_Diag_Organ",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorType",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorStage",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorGrade",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X12 ;
        prmT000X12 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000X13 ;
        prmT000X13 = new Object[] {
        } ;
        Object[] prmT000X14 ;
        prmT000X14 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000X2", "SELECT [BR_Pathology_DiagID], [BR_Pathology_Diag_Loc], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorGrade], [BR_PathologyID] FROM [BR_Pathology_Diag] WITH (UPDLOCK) WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X2,1,0,true,false )
           ,new CursorDef("T000X3", "SELECT [BR_Pathology_DiagID], [BR_Pathology_Diag_Loc], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorGrade], [BR_PathologyID] FROM [BR_Pathology_Diag] WITH (NOLOCK) WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X3,1,0,true,false )
           ,new CursorDef("T000X4", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X4,1,0,true,false )
           ,new CursorDef("T000X5", "SELECT TM1.[BR_Pathology_DiagID], TM1.[BR_Pathology_Diag_Loc], TM1.[BR_Pathology_Diag_Organ], TM1.[BR_Pathology_Diag_TumorType], TM1.[BR_Pathology_Diag_TumorStage], TM1.[BR_Pathology_Diag_TumorGrade], TM1.[BR_PathologyID] FROM [BR_Pathology_Diag] TM1 WITH (NOLOCK) WHERE TM1.[BR_Pathology_DiagID] = @BR_Pathology_DiagID ORDER BY TM1.[BR_Pathology_DiagID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X5,100,0,true,false )
           ,new CursorDef("T000X6", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X6,1,0,true,false )
           ,new CursorDef("T000X7", "SELECT [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK) WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X7,1,0,true,false )
           ,new CursorDef("T000X8", "SELECT TOP 1 [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK) WHERE ( [BR_Pathology_DiagID] > @BR_Pathology_DiagID) ORDER BY [BR_Pathology_DiagID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X8,1,0,true,true )
           ,new CursorDef("T000X9", "SELECT TOP 1 [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK) WHERE ( [BR_Pathology_DiagID] < @BR_Pathology_DiagID) ORDER BY [BR_Pathology_DiagID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X9,1,0,true,true )
           ,new CursorDef("T000X10", "INSERT INTO [BR_Pathology_Diag]([BR_Pathology_Diag_Loc], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorGrade], [BR_PathologyID]) VALUES(@BR_Pathology_Diag_Loc, @BR_Pathology_Diag_Organ, @BR_Pathology_Diag_TumorType, @BR_Pathology_Diag_TumorStage, @BR_Pathology_Diag_TumorGrade, @BR_PathologyID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000X10)
           ,new CursorDef("T000X11", "UPDATE [BR_Pathology_Diag] SET [BR_Pathology_Diag_Loc]=@BR_Pathology_Diag_Loc, [BR_Pathology_Diag_Organ]=@BR_Pathology_Diag_Organ, [BR_Pathology_Diag_TumorType]=@BR_Pathology_Diag_TumorType, [BR_Pathology_Diag_TumorStage]=@BR_Pathology_Diag_TumorStage, [BR_Pathology_Diag_TumorGrade]=@BR_Pathology_Diag_TumorGrade, [BR_PathologyID]=@BR_PathologyID  WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID", GxErrorMask.GX_NOMASK,prmT000X11)
           ,new CursorDef("T000X12", "DELETE FROM [BR_Pathology_Diag]  WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID", GxErrorMask.GX_NOMASK,prmT000X12)
           ,new CursorDef("T000X13", "SELECT [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK) ORDER BY [BR_Pathology_DiagID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000X13,100,0,true,false )
           ,new CursorDef("T000X14", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000X14,1,0,true,false )
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
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 12 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 2 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(6, (long)parms[11]);
              }
              return;
           case 9 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(6, (long)parms[11]);
              }
              stmt.SetParameter(7, (long)parms[12]);
              return;
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 12 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
     }
  }

}

}
