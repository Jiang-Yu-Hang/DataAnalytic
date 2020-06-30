/*
               File: BR_Encounter_RefuseReason
        Description: 就诊信息驳回原因
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:46.97
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
   public class br_encounter_refusereason : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_12") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_12( A19BR_EncounterID) ;
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
               AV7BR_Encounter_RefuseReasonID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_Encounter_RefuseReasonID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTER_REFUSEREASONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            Form.Meta.addItem("description", "就诊信息驳回原因", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBR_Encounter_RefuseReason_FReason_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_encounter_refusereason( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounter_refusereason( IGxContext context )
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
                           long aP1_BR_Encounter_RefuseReasonID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_Encounter_RefuseReasonID = aP1_BR_Encounter_RefuseReasonID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbBR_Encounter_RefuseReason_Status = new GXCombobox();
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
         if ( cmbBR_Encounter_RefuseReason_Status.ItemCount > 0 )
         {
            A351BR_Encounter_RefuseReason_Status = (short)(NumberUtil.Val( cmbBR_Encounter_RefuseReason_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0))), "."));
            n351BR_Encounter_RefuseReason_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Encounter_RefuseReason_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Values", cmbBR_Encounter_RefuseReason_Status.ToJavascriptSource(), true);
         }
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-lg-6", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_EncounterID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_EncounterID_Internalname, "就诊信息主键", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), ((edtBR_EncounterID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_EncounterID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Encounter_RefuseReason.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavBr_information_br_information_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15BR_Information.gxTpr_Br_information_id), 18, 0, ".", "")), ((edtavBr_information_br_information_id_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV15BR_Information.gxTpr_Br_information_id), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(AV15BR_Information.gxTpr_Br_information_id), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_information_br_information_id_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_information_br_information_id_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReason.htm");
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
            GxWebStd.gx_label_element( context, edtBR_Encounter_RefuseReason_Reason_Internalname, "初审不通过原因", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Encounter_RefuseReason_Reason_Internalname, A349BR_Encounter_RefuseReason_Reason, "", "", 0, 1, edtBR_Encounter_RefuseReason_Reason_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReason.htm");
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
            GxWebStd.gx_label_element( context, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname, "初审不通过时间", "col-sm-3 AttributeDateTimeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_RefuseReason_NoApproveDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname, context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A350BR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick, 0, "AttributeDateTime", "", "", "", "", 1, edtBR_Encounter_RefuseReason_NoApproveDate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "UpdDate", "right", false, "HLP_BR_Encounter_RefuseReason.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Encounter_RefuseReason_NoApproveDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter_RefuseReason.htm");
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
            GxWebStd.gx_label_element( context, cmbBR_Encounter_RefuseReason_Status_Internalname, "初审不通过状态", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Encounter_RefuseReason_Status, cmbBR_Encounter_RefuseReason_Status_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)), 1, cmbBR_Encounter_RefuseReason_Status_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbBR_Encounter_RefuseReason_Status.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_BR_Encounter_RefuseReason.htm");
            cmbBR_Encounter_RefuseReason_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Values", (String)(cmbBR_Encounter_RefuseReason_Status.ToJavascriptSource()), true);
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
            GxWebStd.gx_label_element( context, edtBR_Encounter_RefuseReason_FReason_Internalname, "复审不通过原因", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Encounter_RefuseReason_FReason_Internalname, A355BR_Encounter_RefuseReason_FReason, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, 1, edtBR_Encounter_RefuseReason_FReason_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReason.htm");
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
            GxWebStd.gx_label_element( context, edtBR_Encounter_RefuseReason_FApproveDate_Internalname, "复审不通过时间", "col-sm-3 AttributeDateTimeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_RefuseReason_FApproveDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_RefuseReason_FApproveDate_Internalname, context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A354BR_Encounter_RefuseReason_FApproveDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_RefuseReason_FApproveDate_Jsonclick, 0, "AttributeDateTime", "", "", "", "", 1, edtBR_Encounter_RefuseReason_FApproveDate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "UpdDate", "right", false, "HLP_BR_Encounter_RefuseReason.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_RefuseReason_FApproveDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Encounter_RefuseReason_FApproveDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter_RefuseReason.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "确认", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Encounter_RefuseReason.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Encounter_RefuseReason.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Encounter_RefuseReason.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_RefuseReasonID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0, ".", "")), ((edtBR_Encounter_RefuseReasonID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A348BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A348BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_RefuseReasonID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_RefuseReasonID_Visible, edtBR_Encounter_RefuseReasonID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Encounter_RefuseReason.htm");
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
         E11152 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               AV15BR_Information.gxTpr_Br_information_id = (long)(context.localUtil.CToN( cgiGet( edtavBr_information_br_information_id_Internalname), ".", ","));
               A349BR_Encounter_RefuseReason_Reason = cgiGet( edtBR_Encounter_RefuseReason_Reason_Internalname);
               n349BR_Encounter_RefuseReason_Reason = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BR_Encounter_RefuseReason_Reason", A349BR_Encounter_RefuseReason_Reason);
               A350BR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_RefuseReason_NoApproveDate_Internalname));
               n350BR_Encounter_RefuseReason_NoApproveDate = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
               cmbBR_Encounter_RefuseReason_Status.CurrentValue = cgiGet( cmbBR_Encounter_RefuseReason_Status_Internalname);
               A351BR_Encounter_RefuseReason_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_RefuseReason_Status_Internalname), "."));
               n351BR_Encounter_RefuseReason_Status = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)));
               A355BR_Encounter_RefuseReason_FReason = cgiGet( edtBR_Encounter_RefuseReason_FReason_Internalname);
               n355BR_Encounter_RefuseReason_FReason = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BR_Encounter_RefuseReason_FReason", A355BR_Encounter_RefuseReason_FReason);
               n355BR_Encounter_RefuseReason_FReason = (String.IsNullOrEmpty(StringUtil.RTrim( A355BR_Encounter_RefuseReason_FReason)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtBR_Encounter_RefuseReason_FApproveDate_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"复审不通过时间"}), 1, "BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Encounter_RefuseReason_FApproveDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
                  n354BR_Encounter_RefuseReason_FApproveDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A354BR_Encounter_RefuseReason_FApproveDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_RefuseReason_FApproveDate_Internalname));
                  n354BR_Encounter_RefuseReason_FApproveDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
               }
               n354BR_Encounter_RefuseReason_FApproveDate = ((DateTime.MinValue==A354BR_Encounter_RefuseReason_FApproveDate) ? true : false);
               A348BR_Encounter_RefuseReasonID = (long)(context.localUtil.CToN( cgiGet( edtBR_Encounter_RefuseReasonID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
               /* Read saved values. */
               Z348BR_Encounter_RefuseReasonID = (long)(context.localUtil.CToN( cgiGet( "Z348BR_Encounter_RefuseReasonID"), ".", ","));
               Z349BR_Encounter_RefuseReason_Reason = cgiGet( "Z349BR_Encounter_RefuseReason_Reason");
               n349BR_Encounter_RefuseReason_Reason = (String.IsNullOrEmpty(StringUtil.RTrim( A349BR_Encounter_RefuseReason_Reason)) ? true : false);
               Z350BR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( cgiGet( "Z350BR_Encounter_RefuseReason_NoApproveDate"), 0);
               n350BR_Encounter_RefuseReason_NoApproveDate = ((DateTime.MinValue==A350BR_Encounter_RefuseReason_NoApproveDate) ? true : false);
               Z351BR_Encounter_RefuseReason_Status = (short)(context.localUtil.CToN( cgiGet( "Z351BR_Encounter_RefuseReason_Status"), ".", ","));
               n351BR_Encounter_RefuseReason_Status = ((0==A351BR_Encounter_RefuseReason_Status) ? true : false);
               Z352BR_Encounter_RefuseReason_Approver = cgiGet( "Z352BR_Encounter_RefuseReason_Approver");
               n352BR_Encounter_RefuseReason_Approver = (String.IsNullOrEmpty(StringUtil.RTrim( A352BR_Encounter_RefuseReason_Approver)) ? true : false);
               Z353BR_EncounterReason_IsApprove = StringUtil.StrToBool( cgiGet( "Z353BR_EncounterReason_IsApprove"));
               n353BR_EncounterReason_IsApprove = ((false==A353BR_EncounterReason_IsApprove) ? true : false);
               Z356BR_EncounterReason_vStatus = (short)(context.localUtil.CToN( cgiGet( "Z356BR_EncounterReason_vStatus"), ".", ","));
               n356BR_EncounterReason_vStatus = ((0==A356BR_EncounterReason_vStatus) ? true : false);
               Z355BR_Encounter_RefuseReason_FReason = cgiGet( "Z355BR_Encounter_RefuseReason_FReason");
               n355BR_Encounter_RefuseReason_FReason = (String.IsNullOrEmpty(StringUtil.RTrim( A355BR_Encounter_RefuseReason_FReason)) ? true : false);
               Z354BR_Encounter_RefuseReason_FApproveDate = context.localUtil.CToT( cgiGet( "Z354BR_Encounter_RefuseReason_FApproveDate"), 0);
               n354BR_Encounter_RefuseReason_FApproveDate = ((DateTime.MinValue==A354BR_Encounter_RefuseReason_FApproveDate) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               A352BR_Encounter_RefuseReason_Approver = cgiGet( "Z352BR_Encounter_RefuseReason_Approver");
               n352BR_Encounter_RefuseReason_Approver = false;
               n352BR_Encounter_RefuseReason_Approver = (String.IsNullOrEmpty(StringUtil.RTrim( A352BR_Encounter_RefuseReason_Approver)) ? true : false);
               A353BR_EncounterReason_IsApprove = StringUtil.StrToBool( cgiGet( "Z353BR_EncounterReason_IsApprove"));
               n353BR_EncounterReason_IsApprove = false;
               n353BR_EncounterReason_IsApprove = ((false==A353BR_EncounterReason_IsApprove) ? true : false);
               A356BR_EncounterReason_vStatus = (short)(context.localUtil.CToN( cgiGet( "Z356BR_EncounterReason_vStatus"), ".", ","));
               n356BR_EncounterReason_vStatus = false;
               n356BR_EncounterReason_vStatus = ((0==A356BR_EncounterReason_vStatus) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               AV7BR_Encounter_RefuseReasonID = (long)(context.localUtil.CToN( cgiGet( "vBR_ENCOUNTER_REFUSEREASONID"), ".", ","));
               AV13Insert_BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_ENCOUNTERID"), ".", ","));
               A352BR_Encounter_RefuseReason_Approver = cgiGet( "BR_ENCOUNTER_REFUSEREASON_APPROVER");
               n352BR_Encounter_RefuseReason_Approver = (String.IsNullOrEmpty(StringUtil.RTrim( A352BR_Encounter_RefuseReason_Approver)) ? true : false);
               A353BR_EncounterReason_IsApprove = StringUtil.StrToBool( cgiGet( "BR_ENCOUNTERREASON_ISAPPROVE"));
               n353BR_EncounterReason_IsApprove = ((false==A353BR_EncounterReason_IsApprove) ? true : false);
               A356BR_EncounterReason_vStatus = (short)(context.localUtil.CToN( cgiGet( "BR_ENCOUNTERREASON_VSTATUS"), ".", ","));
               n356BR_EncounterReason_vStatus = ((0==A356BR_EncounterReason_vStatus) ? true : false);
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
               n85BR_Information_ID = false;
               AV17Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "BR_Encounter_RefuseReason";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               A349BR_Encounter_RefuseReason_Reason = cgiGet( edtBR_Encounter_RefuseReason_Reason_Internalname);
               n349BR_Encounter_RefuseReason_Reason = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BR_Encounter_RefuseReason_Reason", A349BR_Encounter_RefuseReason_Reason);
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A349BR_Encounter_RefuseReason_Reason, ""));
               A350BR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_RefuseReason_NoApproveDate_Internalname));
               n350BR_Encounter_RefuseReason_NoApproveDate = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A350BR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99");
               A351BR_Encounter_RefuseReason_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_RefuseReason_Status_Internalname), "."));
               n351BR_Encounter_RefuseReason_Status = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A351BR_Encounter_RefuseReason_Status), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A352BR_Encounter_RefuseReason_Approver, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( A353BR_EncounterReason_IsApprove);
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A356BR_EncounterReason_vStatus), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A348BR_Encounter_RefuseReasonID != Z348BR_Encounter_RefuseReasonID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_encounter_refusereason:[SecurityCheckFailed value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_encounter_refusereason:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("br_encounter_refusereason:[SecurityCheckFailed value for]"+"BR_Encounter_RefuseReason_Reason:"+StringUtil.RTrim( context.localUtil.Format( A349BR_Encounter_RefuseReason_Reason, "")));
                  GXUtil.WriteLog("br_encounter_refusereason:[SecurityCheckFailed value for]"+"BR_Encounter_RefuseReason_NoApproveDate:"+context.localUtil.Format( A350BR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99"));
                  GXUtil.WriteLog("br_encounter_refusereason:[SecurityCheckFailed value for]"+"BR_Encounter_RefuseReason_Status:"+context.localUtil.Format( (decimal)(A351BR_Encounter_RefuseReason_Status), "ZZZ9"));
                  GXUtil.WriteLog("br_encounter_refusereason:[SecurityCheckFailed value for]"+"BR_Encounter_RefuseReason_Approver:"+StringUtil.RTrim( context.localUtil.Format( A352BR_Encounter_RefuseReason_Approver, "")));
                  GXUtil.WriteLog("br_encounter_refusereason:[SecurityCheckFailed value for]"+"BR_EncounterReason_IsApprove:"+StringUtil.BoolToStr( A353BR_EncounterReason_IsApprove));
                  GXUtil.WriteLog("br_encounter_refusereason:[SecurityCheckFailed value for]"+"BR_EncounterReason_vStatus:"+context.localUtil.Format( (decimal)(A356BR_EncounterReason_vStatus), "ZZZ9"));
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
                  A348BR_Encounter_RefuseReasonID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
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
                     sMode42 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode42;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound42 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_150( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_ENCOUNTER_REFUSEREASONID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_Encounter_RefuseReasonID_Internalname;
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
                           E11152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12152 ();
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
            E12152 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1542( ) ;
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
            DisableAttributes1542( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_information_br_information_id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_information_br_information_id_Enabled), 5, 0)), true);
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

      protected void CONFIRM_150( )
      {
         BeforeValidate1542( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1542( ) ;
            }
            else
            {
               CheckExtendedTable1542( ) ;
               CloseExtendedTableCursors1542( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption150( )
      {
      }

      protected void E11152( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_RefuseReason_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_RefuseReason_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_RefuseReason_Delete", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV2 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV2), 8, 0)));
            while ( AV18GXV2 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV18GXV2));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV13Insert_BR_EncounterID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_BR_EncounterID), 18, 0)));
               }
               AV18GXV2 = (int)(AV18GXV2+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV2), 8, 0)));
            }
         }
         edtBR_Encounter_RefuseReasonID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReasonID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReasonID_Visible), 5, 0)), true);
      }

      protected void E12152( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_encounter_refusereasonww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM1542( short GX_JID )
      {
         if ( ( GX_JID == 11 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z349BR_Encounter_RefuseReason_Reason = T00153_A349BR_Encounter_RefuseReason_Reason[0];
               Z350BR_Encounter_RefuseReason_NoApproveDate = T00153_A350BR_Encounter_RefuseReason_NoApproveDate[0];
               Z351BR_Encounter_RefuseReason_Status = T00153_A351BR_Encounter_RefuseReason_Status[0];
               Z352BR_Encounter_RefuseReason_Approver = T00153_A352BR_Encounter_RefuseReason_Approver[0];
               Z353BR_EncounterReason_IsApprove = T00153_A353BR_EncounterReason_IsApprove[0];
               Z356BR_EncounterReason_vStatus = T00153_A356BR_EncounterReason_vStatus[0];
               Z355BR_Encounter_RefuseReason_FReason = T00153_A355BR_Encounter_RefuseReason_FReason[0];
               Z354BR_Encounter_RefuseReason_FApproveDate = T00153_A354BR_Encounter_RefuseReason_FApproveDate[0];
               Z19BR_EncounterID = T00153_A19BR_EncounterID[0];
            }
            else
            {
               Z349BR_Encounter_RefuseReason_Reason = A349BR_Encounter_RefuseReason_Reason;
               Z350BR_Encounter_RefuseReason_NoApproveDate = A350BR_Encounter_RefuseReason_NoApproveDate;
               Z351BR_Encounter_RefuseReason_Status = A351BR_Encounter_RefuseReason_Status;
               Z352BR_Encounter_RefuseReason_Approver = A352BR_Encounter_RefuseReason_Approver;
               Z353BR_EncounterReason_IsApprove = A353BR_EncounterReason_IsApprove;
               Z356BR_EncounterReason_vStatus = A356BR_EncounterReason_vStatus;
               Z355BR_Encounter_RefuseReason_FReason = A355BR_Encounter_RefuseReason_FReason;
               Z354BR_Encounter_RefuseReason_FApproveDate = A354BR_Encounter_RefuseReason_FApproveDate;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -11 )
         {
            Z348BR_Encounter_RefuseReasonID = A348BR_Encounter_RefuseReasonID;
            Z349BR_Encounter_RefuseReason_Reason = A349BR_Encounter_RefuseReason_Reason;
            Z350BR_Encounter_RefuseReason_NoApproveDate = A350BR_Encounter_RefuseReason_NoApproveDate;
            Z351BR_Encounter_RefuseReason_Status = A351BR_Encounter_RefuseReason_Status;
            Z352BR_Encounter_RefuseReason_Approver = A352BR_Encounter_RefuseReason_Approver;
            Z353BR_EncounterReason_IsApprove = A353BR_EncounterReason_IsApprove;
            Z356BR_EncounterReason_vStatus = A356BR_EncounterReason_vStatus;
            Z355BR_Encounter_RefuseReason_FReason = A355BR_Encounter_RefuseReason_FReason;
            Z354BR_Encounter_RefuseReason_FApproveDate = A354BR_Encounter_RefuseReason_FApproveDate;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReason_Reason_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_Reason_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReason_Reason_Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReason_NoApproveDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReason_NoApproveDate_Enabled), 5, 0)), true);
         cmbBR_Encounter_RefuseReason_Status.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Encounter_RefuseReason_Status.Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReasonID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReasonID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReasonID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReason_Reason_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_Reason_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReason_Reason_Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReason_NoApproveDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReason_NoApproveDate_Enabled), 5, 0)), true);
         cmbBR_Encounter_RefuseReason_Status.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Encounter_RefuseReason_Status.Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReasonID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReasonID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReasonID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_Encounter_RefuseReasonID) )
         {
            A348BR_Encounter_RefuseReasonID = AV7BR_Encounter_RefuseReasonID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_EncounterID) )
         {
            A19BR_EncounterID = AV13Insert_BR_EncounterID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
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
            /* Using cursor T00154 */
            pr_default.execute(2, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T00154_A85BR_Information_ID[0];
            n85BR_Information_ID = T00154_n85BR_Information_ID[0];
            pr_default.close(2);
         }
      }

      protected void Load1542( )
      {
         /* Using cursor T00155 */
         pr_default.execute(3, new Object[] {A348BR_Encounter_RefuseReasonID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound42 = 1;
            A349BR_Encounter_RefuseReason_Reason = T00155_A349BR_Encounter_RefuseReason_Reason[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BR_Encounter_RefuseReason_Reason", A349BR_Encounter_RefuseReason_Reason);
            n349BR_Encounter_RefuseReason_Reason = T00155_n349BR_Encounter_RefuseReason_Reason[0];
            A350BR_Encounter_RefuseReason_NoApproveDate = T00155_A350BR_Encounter_RefuseReason_NoApproveDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
            n350BR_Encounter_RefuseReason_NoApproveDate = T00155_n350BR_Encounter_RefuseReason_NoApproveDate[0];
            A351BR_Encounter_RefuseReason_Status = T00155_A351BR_Encounter_RefuseReason_Status[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)));
            n351BR_Encounter_RefuseReason_Status = T00155_n351BR_Encounter_RefuseReason_Status[0];
            A352BR_Encounter_RefuseReason_Approver = T00155_A352BR_Encounter_RefuseReason_Approver[0];
            n352BR_Encounter_RefuseReason_Approver = T00155_n352BR_Encounter_RefuseReason_Approver[0];
            A353BR_EncounterReason_IsApprove = T00155_A353BR_EncounterReason_IsApprove[0];
            n353BR_EncounterReason_IsApprove = T00155_n353BR_EncounterReason_IsApprove[0];
            A356BR_EncounterReason_vStatus = T00155_A356BR_EncounterReason_vStatus[0];
            n356BR_EncounterReason_vStatus = T00155_n356BR_EncounterReason_vStatus[0];
            A355BR_Encounter_RefuseReason_FReason = T00155_A355BR_Encounter_RefuseReason_FReason[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BR_Encounter_RefuseReason_FReason", A355BR_Encounter_RefuseReason_FReason);
            n355BR_Encounter_RefuseReason_FReason = T00155_n355BR_Encounter_RefuseReason_FReason[0];
            A354BR_Encounter_RefuseReason_FApproveDate = T00155_A354BR_Encounter_RefuseReason_FApproveDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
            n354BR_Encounter_RefuseReason_FApproveDate = T00155_n354BR_Encounter_RefuseReason_FApproveDate[0];
            A19BR_EncounterID = T00155_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            A85BR_Information_ID = T00155_A85BR_Information_ID[0];
            n85BR_Information_ID = T00155_n85BR_Information_ID[0];
            ZM1542( -11) ;
         }
         pr_default.close(3);
         OnLoadActions1542( ) ;
      }

      protected void OnLoadActions1542( )
      {
         AV17Pgmname = "BR_Encounter_RefuseReason";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
      }

      protected void CheckExtendedTable1542( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV17Pgmname = "BR_Encounter_RefuseReason";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         if ( ! ( (DateTime.MinValue==A354BR_Encounter_RefuseReason_FApproveDate) || ( A354BR_Encounter_RefuseReason_FApproveDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域���������������������超界", "OutOfRange", 1, "BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Encounter_RefuseReason_FApproveDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00154 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A85BR_Information_ID = T00154_A85BR_Information_ID[0];
         n85BR_Information_ID = T00154_n85BR_Information_ID[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors1542( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_12( long A19BR_EncounterID )
      {
         /* Using cursor T00156 */
         pr_default.execute(4, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A85BR_Information_ID = T00156_A85BR_Information_ID[0];
         n85BR_Information_ID = T00156_n85BR_Information_ID[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey1542( )
      {
         /* Using cursor T00157 */
         pr_default.execute(5, new Object[] {A348BR_Encounter_RefuseReasonID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound42 = 1;
         }
         else
         {
            RcdFound42 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00153 */
         pr_default.execute(1, new Object[] {A348BR_Encounter_RefuseReasonID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1542( 11) ;
            RcdFound42 = 1;
            A348BR_Encounter_RefuseReasonID = T00153_A348BR_Encounter_RefuseReasonID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
            A349BR_Encounter_RefuseReason_Reason = T00153_A349BR_Encounter_RefuseReason_Reason[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BR_Encounter_RefuseReason_Reason", A349BR_Encounter_RefuseReason_Reason);
            n349BR_Encounter_RefuseReason_Reason = T00153_n349BR_Encounter_RefuseReason_Reason[0];
            A350BR_Encounter_RefuseReason_NoApproveDate = T00153_A350BR_Encounter_RefuseReason_NoApproveDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
            n350BR_Encounter_RefuseReason_NoApproveDate = T00153_n350BR_Encounter_RefuseReason_NoApproveDate[0];
            A351BR_Encounter_RefuseReason_Status = T00153_A351BR_Encounter_RefuseReason_Status[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)));
            n351BR_Encounter_RefuseReason_Status = T00153_n351BR_Encounter_RefuseReason_Status[0];
            A352BR_Encounter_RefuseReason_Approver = T00153_A352BR_Encounter_RefuseReason_Approver[0];
            n352BR_Encounter_RefuseReason_Approver = T00153_n352BR_Encounter_RefuseReason_Approver[0];
            A353BR_EncounterReason_IsApprove = T00153_A353BR_EncounterReason_IsApprove[0];
            n353BR_EncounterReason_IsApprove = T00153_n353BR_EncounterReason_IsApprove[0];
            A356BR_EncounterReason_vStatus = T00153_A356BR_EncounterReason_vStatus[0];
            n356BR_EncounterReason_vStatus = T00153_n356BR_EncounterReason_vStatus[0];
            A355BR_Encounter_RefuseReason_FReason = T00153_A355BR_Encounter_RefuseReason_FReason[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BR_Encounter_RefuseReason_FReason", A355BR_Encounter_RefuseReason_FReason);
            n355BR_Encounter_RefuseReason_FReason = T00153_n355BR_Encounter_RefuseReason_FReason[0];
            A354BR_Encounter_RefuseReason_FApproveDate = T00153_A354BR_Encounter_RefuseReason_FApproveDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
            n354BR_Encounter_RefuseReason_FApproveDate = T00153_n354BR_Encounter_RefuseReason_FApproveDate[0];
            A19BR_EncounterID = T00153_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z348BR_Encounter_RefuseReasonID = A348BR_Encounter_RefuseReasonID;
            sMode42 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1542( ) ;
            if ( AnyError == 1 )
            {
               RcdFound42 = 0;
               InitializeNonKey1542( ) ;
            }
            Gx_mode = sMode42;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound42 = 0;
            InitializeNonKey1542( ) ;
            sMode42 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode42;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1542( ) ;
         if ( RcdFound42 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound42 = 0;
         /* Using cursor T00158 */
         pr_default.execute(6, new Object[] {A348BR_Encounter_RefuseReasonID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00158_A348BR_Encounter_RefuseReasonID[0] < A348BR_Encounter_RefuseReasonID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00158_A348BR_Encounter_RefuseReasonID[0] > A348BR_Encounter_RefuseReasonID ) ) )
            {
               A348BR_Encounter_RefuseReasonID = T00158_A348BR_Encounter_RefuseReasonID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
               RcdFound42 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound42 = 0;
         /* Using cursor T00159 */
         pr_default.execute(7, new Object[] {A348BR_Encounter_RefuseReasonID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00159_A348BR_Encounter_RefuseReasonID[0] > A348BR_Encounter_RefuseReasonID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00159_A348BR_Encounter_RefuseReasonID[0] < A348BR_Encounter_RefuseReasonID ) ) )
            {
               A348BR_Encounter_RefuseReasonID = T00159_A348BR_Encounter_RefuseReasonID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
               RcdFound42 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1542( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_Encounter_RefuseReason_FReason_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1542( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound42 == 1 )
            {
               if ( A348BR_Encounter_RefuseReasonID != Z348BR_Encounter_RefuseReasonID )
               {
                  A348BR_Encounter_RefuseReasonID = Z348BR_Encounter_RefuseReasonID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_ENCOUNTER_REFUSEREASONID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Encounter_RefuseReasonID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_Encounter_RefuseReason_FReason_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update1542( ) ;
                  GX_FocusControl = edtBR_Encounter_RefuseReason_FReason_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A348BR_Encounter_RefuseReasonID != Z348BR_Encounter_RefuseReasonID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_Encounter_RefuseReason_FReason_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1542( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_ENCOUNTER_REFUSEREASONID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_Encounter_RefuseReasonID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_Encounter_RefuseReason_FReason_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1542( ) ;
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
         if ( A348BR_Encounter_RefuseReasonID != Z348BR_Encounter_RefuseReasonID )
         {
            A348BR_Encounter_RefuseReasonID = Z348BR_Encounter_RefuseReasonID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_ENCOUNTER_REFUSEREASONID");
            AnyError = 1;
            GX_FocusControl = edtBR_Encounter_RefuseReasonID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_Encounter_RefuseReason_FReason_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1542( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00152 */
            pr_default.execute(0, new Object[] {A348BR_Encounter_RefuseReasonID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Encounter_RefuseReason"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z349BR_Encounter_RefuseReason_Reason, T00152_A349BR_Encounter_RefuseReason_Reason[0]) != 0 ) || ( Z350BR_Encounter_RefuseReason_NoApproveDate != T00152_A350BR_Encounter_RefuseReason_NoApproveDate[0] ) || ( Z351BR_Encounter_RefuseReason_Status != T00152_A351BR_Encounter_RefuseReason_Status[0] ) || ( StringUtil.StrCmp(Z352BR_Encounter_RefuseReason_Approver, T00152_A352BR_Encounter_RefuseReason_Approver[0]) != 0 ) || ( Z353BR_EncounterReason_IsApprove != T00152_A353BR_EncounterReason_IsApprove[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z356BR_EncounterReason_vStatus != T00152_A356BR_EncounterReason_vStatus[0] ) || ( StringUtil.StrCmp(Z355BR_Encounter_RefuseReason_FReason, T00152_A355BR_Encounter_RefuseReason_FReason[0]) != 0 ) || ( Z354BR_Encounter_RefuseReason_FApproveDate != T00152_A354BR_Encounter_RefuseReason_FApproveDate[0] ) || ( Z19BR_EncounterID != T00152_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z349BR_Encounter_RefuseReason_Reason, T00152_A349BR_Encounter_RefuseReason_Reason[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter_refusereason:[seudo value changed for attri]"+"BR_Encounter_RefuseReason_Reason");
                  GXUtil.WriteLogRaw("Old: ",Z349BR_Encounter_RefuseReason_Reason);
                  GXUtil.WriteLogRaw("Current: ",T00152_A349BR_Encounter_RefuseReason_Reason[0]);
               }
               if ( Z350BR_Encounter_RefuseReason_NoApproveDate != T00152_A350BR_Encounter_RefuseReason_NoApproveDate[0] )
               {
                  GXUtil.WriteLog("br_encounter_refusereason:[seudo value changed for attri]"+"BR_Encounter_RefuseReason_NoApproveDate");
                  GXUtil.WriteLogRaw("Old: ",Z350BR_Encounter_RefuseReason_NoApproveDate);
                  GXUtil.WriteLogRaw("Current: ",T00152_A350BR_Encounter_RefuseReason_NoApproveDate[0]);
               }
               if ( Z351BR_Encounter_RefuseReason_Status != T00152_A351BR_Encounter_RefuseReason_Status[0] )
               {
                  GXUtil.WriteLog("br_encounter_refusereason:[seudo value changed for attri]"+"BR_Encounter_RefuseReason_Status");
                  GXUtil.WriteLogRaw("Old: ",Z351BR_Encounter_RefuseReason_Status);
                  GXUtil.WriteLogRaw("Current: ",T00152_A351BR_Encounter_RefuseReason_Status[0]);
               }
               if ( StringUtil.StrCmp(Z352BR_Encounter_RefuseReason_Approver, T00152_A352BR_Encounter_RefuseReason_Approver[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter_refusereason:[seudo value changed for attri]"+"BR_Encounter_RefuseReason_Approver");
                  GXUtil.WriteLogRaw("Old: ",Z352BR_Encounter_RefuseReason_Approver);
                  GXUtil.WriteLogRaw("Current: ",T00152_A352BR_Encounter_RefuseReason_Approver[0]);
               }
               if ( Z353BR_EncounterReason_IsApprove != T00152_A353BR_EncounterReason_IsApprove[0] )
               {
                  GXUtil.WriteLog("br_encounter_refusereason:[seudo value changed for attri]"+"BR_EncounterReason_IsApprove");
                  GXUtil.WriteLogRaw("Old: ",Z353BR_EncounterReason_IsApprove);
                  GXUtil.WriteLogRaw("Current: ",T00152_A353BR_EncounterReason_IsApprove[0]);
               }
               if ( Z356BR_EncounterReason_vStatus != T00152_A356BR_EncounterReason_vStatus[0] )
               {
                  GXUtil.WriteLog("br_encounter_refusereason:[seudo value changed for attri]"+"BR_EncounterReason_vStatus");
                  GXUtil.WriteLogRaw("Old: ",Z356BR_EncounterReason_vStatus);
                  GXUtil.WriteLogRaw("Current: ",T00152_A356BR_EncounterReason_vStatus[0]);
               }
               if ( StringUtil.StrCmp(Z355BR_Encounter_RefuseReason_FReason, T00152_A355BR_Encounter_RefuseReason_FReason[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter_refusereason:[seudo value changed for attri]"+"BR_Encounter_RefuseReason_FReason");
                  GXUtil.WriteLogRaw("Old: ",Z355BR_Encounter_RefuseReason_FReason);
                  GXUtil.WriteLogRaw("Current: ",T00152_A355BR_Encounter_RefuseReason_FReason[0]);
               }
               if ( Z354BR_Encounter_RefuseReason_FApproveDate != T00152_A354BR_Encounter_RefuseReason_FApproveDate[0] )
               {
                  GXUtil.WriteLog("br_encounter_refusereason:[seudo value changed for attri]"+"BR_Encounter_RefuseReason_FApproveDate");
                  GXUtil.WriteLogRaw("Old: ",Z354BR_Encounter_RefuseReason_FApproveDate);
                  GXUtil.WriteLogRaw("Current: ",T00152_A354BR_Encounter_RefuseReason_FApproveDate[0]);
               }
               if ( Z19BR_EncounterID != T00152_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_encounter_refusereason:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T00152_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Encounter_RefuseReason"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1542( )
      {
         BeforeValidate1542( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1542( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1542( 0) ;
            CheckOptimisticConcurrency1542( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1542( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1542( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001510 */
                     pr_default.execute(8, new Object[] {n349BR_Encounter_RefuseReason_Reason, A349BR_Encounter_RefuseReason_Reason, n350BR_Encounter_RefuseReason_NoApproveDate, A350BR_Encounter_RefuseReason_NoApproveDate, n351BR_Encounter_RefuseReason_Status, A351BR_Encounter_RefuseReason_Status, n352BR_Encounter_RefuseReason_Approver, A352BR_Encounter_RefuseReason_Approver, n353BR_EncounterReason_IsApprove, A353BR_EncounterReason_IsApprove, n356BR_EncounterReason_vStatus, A356BR_EncounterReason_vStatus, n355BR_Encounter_RefuseReason_FReason, A355BR_Encounter_RefuseReason_FReason, n354BR_Encounter_RefuseReason_FApproveDate, A354BR_Encounter_RefuseReason_FApproveDate, A19BR_EncounterID});
                     A348BR_Encounter_RefuseReasonID = T001510_A348BR_Encounter_RefuseReasonID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter_RefuseReason") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption150( ) ;
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
               Load1542( ) ;
            }
            EndLevel1542( ) ;
         }
         CloseExtendedTableCursors1542( ) ;
      }

      protected void Update1542( )
      {
         BeforeValidate1542( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1542( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1542( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1542( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1542( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001511 */
                     pr_default.execute(9, new Object[] {n349BR_Encounter_RefuseReason_Reason, A349BR_Encounter_RefuseReason_Reason, n350BR_Encounter_RefuseReason_NoApproveDate, A350BR_Encounter_RefuseReason_NoApproveDate, n351BR_Encounter_RefuseReason_Status, A351BR_Encounter_RefuseReason_Status, n352BR_Encounter_RefuseReason_Approver, A352BR_Encounter_RefuseReason_Approver, n353BR_EncounterReason_IsApprove, A353BR_EncounterReason_IsApprove, n356BR_EncounterReason_vStatus, A356BR_EncounterReason_vStatus, n355BR_Encounter_RefuseReason_FReason, A355BR_Encounter_RefuseReason_FReason, n354BR_Encounter_RefuseReason_FApproveDate, A354BR_Encounter_RefuseReason_FApproveDate, A19BR_EncounterID, A348BR_Encounter_RefuseReasonID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter_RefuseReason") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Encounter_RefuseReason"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1542( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
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
            EndLevel1542( ) ;
         }
         CloseExtendedTableCursors1542( ) ;
      }

      protected void DeferredUpdate1542( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1542( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1542( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1542( ) ;
            AfterConfirm1542( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1542( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001512 */
                  pr_default.execute(10, new Object[] {A348BR_Encounter_RefuseReasonID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter_RefuseReason") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
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
         sMode42 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1542( ) ;
         Gx_mode = sMode42;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1542( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "BR_Encounter_RefuseReason";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T001513 */
            pr_default.execute(11, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T001513_A85BR_Information_ID[0];
            n85BR_Information_ID = T001513_n85BR_Information_ID[0];
            pr_default.close(11);
         }
      }

      protected void EndLevel1542( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1542( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(11);
            context.CommitDataStores("br_encounter_refusereason",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues150( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(11);
            context.RollbackDataStores("br_encounter_refusereason",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1542( )
      {
         /* Scan By routine */
         /* Using cursor T001514 */
         pr_default.execute(12);
         RcdFound42 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound42 = 1;
            A348BR_Encounter_RefuseReasonID = T001514_A348BR_Encounter_RefuseReasonID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1542( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound42 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound42 = 1;
            A348BR_Encounter_RefuseReasonID = T001514_A348BR_Encounter_RefuseReasonID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
         }
      }

      protected void ScanEnd1542( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm1542( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1542( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1542( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1542( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1542( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1542( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1542( )
      {
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReason_Reason_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_Reason_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReason_Reason_Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReason_NoApproveDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReason_NoApproveDate_Enabled), 5, 0)), true);
         cmbBR_Encounter_RefuseReason_Status.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Encounter_RefuseReason_Status.Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReason_FReason_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_FReason_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReason_FReason_Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReason_FApproveDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_FApproveDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReason_FApproveDate_Enabled), 5, 0)), true);
         edtBR_Encounter_RefuseReasonID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReasonID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_RefuseReasonID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1542( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues150( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279384873", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounter_refusereason.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Encounter_RefuseReasonID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Encounter_RefuseReason";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A349BR_Encounter_RefuseReason_Reason, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A350BR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A351BR_Encounter_RefuseReason_Status), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A352BR_Encounter_RefuseReason_Approver, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( A353BR_EncounterReason_IsApprove);
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A356BR_EncounterReason_vStatus), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_encounter_refusereason:[SendSecurityCheck value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_encounter_refusereason:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("br_encounter_refusereason:[SendSecurityCheck value for]"+"BR_Encounter_RefuseReason_Reason:"+StringUtil.RTrim( context.localUtil.Format( A349BR_Encounter_RefuseReason_Reason, "")));
         GXUtil.WriteLog("br_encounter_refusereason:[SendSecurityCheck value for]"+"BR_Encounter_RefuseReason_NoApproveDate:"+context.localUtil.Format( A350BR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99"));
         GXUtil.WriteLog("br_encounter_refusereason:[SendSecurityCheck value for]"+"BR_Encounter_RefuseReason_Status:"+context.localUtil.Format( (decimal)(A351BR_Encounter_RefuseReason_Status), "ZZZ9"));
         GXUtil.WriteLog("br_encounter_refusereason:[SendSecurityCheck value for]"+"BR_Encounter_RefuseReason_Approver:"+StringUtil.RTrim( context.localUtil.Format( A352BR_Encounter_RefuseReason_Approver, "")));
         GXUtil.WriteLog("br_encounter_refusereason:[SendSecurityCheck value for]"+"BR_EncounterReason_IsApprove:"+StringUtil.BoolToStr( A353BR_EncounterReason_IsApprove));
         GXUtil.WriteLog("br_encounter_refusereason:[SendSecurityCheck value for]"+"BR_EncounterReason_vStatus:"+context.localUtil.Format( (decimal)(A356BR_EncounterReason_vStatus), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z348BR_Encounter_RefuseReasonID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z349BR_Encounter_RefuseReason_Reason", Z349BR_Encounter_RefuseReason_Reason);
         GxWebStd.gx_hidden_field( context, "Z350BR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( Z350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z351BR_Encounter_RefuseReason_Status), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z352BR_Encounter_RefuseReason_Approver", Z352BR_Encounter_RefuseReason_Approver);
         GxWebStd.gx_boolean_hidden_field( context, "Z353BR_EncounterReason_IsApprove", Z353BR_EncounterReason_IsApprove);
         GxWebStd.gx_hidden_field( context, "Z356BR_EncounterReason_vStatus", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z356BR_EncounterReason_vStatus), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z355BR_Encounter_RefuseReason_FReason", Z355BR_Encounter_RefuseReason_FReason);
         GxWebStd.gx_hidden_field( context, "Z354BR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( Z354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTER_REFUSEREASONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_Encounter_RefuseReasonID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTER_REFUSEREASONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_REFUSEREASON_APPROVER", A352BR_Encounter_RefuseReason_Approver);
         GxWebStd.gx_boolean_hidden_field( context, "BR_ENCOUNTERREASON_ISAPPROVE", A353BR_EncounterReason_IsApprove);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTERREASON_VSTATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A356BR_EncounterReason_vStatus), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV17Pgmname));
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
         return formatLink("br_encounter_refusereason.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Encounter_RefuseReasonID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Encounter_RefuseReason" ;
      }

      public override String GetPgmdesc( )
      {
         return "就诊信息驳回原因" ;
      }

      protected void InitializeNonKey1542( )
      {
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         A349BR_Encounter_RefuseReason_Reason = "";
         n349BR_Encounter_RefuseReason_Reason = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A349BR_Encounter_RefuseReason_Reason", A349BR_Encounter_RefuseReason_Reason);
         n349BR_Encounter_RefuseReason_Reason = (String.IsNullOrEmpty(StringUtil.RTrim( A349BR_Encounter_RefuseReason_Reason)) ? true : false);
         A350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         n350BR_Encounter_RefuseReason_NoApproveDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A350BR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
         n350BR_Encounter_RefuseReason_NoApproveDate = ((DateTime.MinValue==A350BR_Encounter_RefuseReason_NoApproveDate) ? true : false);
         A351BR_Encounter_RefuseReason_Status = 0;
         n351BR_Encounter_RefuseReason_Status = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)));
         n351BR_Encounter_RefuseReason_Status = ((0==A351BR_Encounter_RefuseReason_Status) ? true : false);
         A352BR_Encounter_RefuseReason_Approver = "";
         n352BR_Encounter_RefuseReason_Approver = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BR_Encounter_RefuseReason_Approver", A352BR_Encounter_RefuseReason_Approver);
         A353BR_EncounterReason_IsApprove = false;
         n353BR_EncounterReason_IsApprove = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353BR_EncounterReason_IsApprove", A353BR_EncounterReason_IsApprove);
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A356BR_EncounterReason_vStatus = 0;
         n356BR_EncounterReason_vStatus = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356BR_EncounterReason_vStatus", StringUtil.LTrim( StringUtil.Str( (decimal)(A356BR_EncounterReason_vStatus), 4, 0)));
         A355BR_Encounter_RefuseReason_FReason = "";
         n355BR_Encounter_RefuseReason_FReason = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BR_Encounter_RefuseReason_FReason", A355BR_Encounter_RefuseReason_FReason);
         n355BR_Encounter_RefuseReason_FReason = (String.IsNullOrEmpty(StringUtil.RTrim( A355BR_Encounter_RefuseReason_FReason)) ? true : false);
         A354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         n354BR_Encounter_RefuseReason_FApproveDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
         n354BR_Encounter_RefuseReason_FApproveDate = ((DateTime.MinValue==A354BR_Encounter_RefuseReason_FApproveDate) ? true : false);
         Z349BR_Encounter_RefuseReason_Reason = "";
         Z350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         Z351BR_Encounter_RefuseReason_Status = 0;
         Z352BR_Encounter_RefuseReason_Approver = "";
         Z353BR_EncounterReason_IsApprove = false;
         Z356BR_EncounterReason_vStatus = 0;
         Z355BR_Encounter_RefuseReason_FReason = "";
         Z354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         Z19BR_EncounterID = 0;
      }

      protected void InitAll1542( )
      {
         A348BR_Encounter_RefuseReasonID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A348BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0)));
         InitializeNonKey1542( ) ;
      }

      protected void StandaloneModalInsert( )
      {
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279384898", true);
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
         context.AddJavascriptSource("br_encounter_refusereason.js", "?20202279384899", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtavBr_information_br_information_id_Internalname = "BR_INFORMATION_BR_INFORMATION_ID";
         edtBR_Encounter_RefuseReason_Reason_Internalname = "BR_ENCOUNTER_REFUSEREASON_REASON";
         edtBR_Encounter_RefuseReason_NoApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE";
         cmbBR_Encounter_RefuseReason_Status_Internalname = "BR_ENCOUNTER_REFUSEREASON_STATUS";
         edtBR_Encounter_RefuseReason_FReason_Internalname = "BR_ENCOUNTER_REFUSEREASON_FREASON";
         edtBR_Encounter_RefuseReason_FApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_Encounter_RefuseReasonID_Internalname = "BR_ENCOUNTER_REFUSEREASONID";
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
         Form.Caption = "就诊信息驳回原因";
         edtBR_Encounter_RefuseReasonID_Jsonclick = "";
         edtBR_Encounter_RefuseReasonID_Enabled = 0;
         edtBR_Encounter_RefuseReasonID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Encounter_RefuseReason_FApproveDate_Jsonclick = "";
         edtBR_Encounter_RefuseReason_FApproveDate_Enabled = 1;
         edtBR_Encounter_RefuseReason_FReason_Enabled = 1;
         cmbBR_Encounter_RefuseReason_Status_Jsonclick = "";
         cmbBR_Encounter_RefuseReason_Status.Enabled = 0;
         edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick = "";
         edtBR_Encounter_RefuseReason_NoApproveDate_Enabled = 0;
         edtBR_Encounter_RefuseReason_Reason_Enabled = 0;
         edtavBr_information_br_information_id_Jsonclick = "";
         edtavBr_information_br_information_id_Enabled = 0;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "基础信息";
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

      protected void init_web_controls( )
      {
         cmbBR_Encounter_RefuseReason_Status.Name = "BR_ENCOUNTER_REFUSEREASON_STATUS";
         cmbBR_Encounter_RefuseReason_Status.WebTags = "";
         cmbBR_Encounter_RefuseReason_Status.addItem("1", "未处理", 0);
         cmbBR_Encounter_RefuseReason_Status.addItem("2", "已处理", 0);
         if ( cmbBR_Encounter_RefuseReason_Status.ItemCount > 0 )
         {
            A351BR_Encounter_RefuseReason_Status = (short)(NumberUtil.Val( cmbBR_Encounter_RefuseReason_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0))), "."));
            n351BR_Encounter_RefuseReason_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A351BR_Encounter_RefuseReason_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)));
         }
         /* End function init_web_controls */
      }

      public void Valid_Br_encounterid( long GX_Parm1 ,
                                        long GX_Parm2 )
      {
         A19BR_EncounterID = GX_Parm1;
         A85BR_Information_ID = GX_Parm2;
         n85BR_Information_ID = false;
         /* Using cursor T001513 */
         pr_default.execute(11, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A85BR_Information_ID = T001513_A85BR_Information_ID[0];
         n85BR_Information_ID = T001513_n85BR_Information_ID[0];
         pr_default.close(11);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A85BR_Information_ID = 0;
            n85BR_Information_ID = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Encounter_RefuseReasonID',fld:'vBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Encounter_RefuseReasonID',fld:'vBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV13Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A349BR_Encounter_RefuseReason_Reason',fld:'BR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'A350BR_Encounter_RefuseReason_NoApproveDate',fld:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'A351BR_Encounter_RefuseReason_Status',fld:'BR_ENCOUNTER_REFUSEREASON_STATUS',pic:'ZZZ9'},{av:'A352BR_Encounter_RefuseReason_Approver',fld:'BR_ENCOUNTER_REFUSEREASON_APPROVER',pic:''},{av:'A353BR_EncounterReason_IsApprove',fld:'BR_ENCOUNTERREASON_ISAPPROVE',pic:''},{av:'A356BR_EncounterReason_vStatus',fld:'BR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12152',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(11);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z349BR_Encounter_RefuseReason_Reason = "";
         Z350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         Z352BR_Encounter_RefuseReason_Approver = "";
         Z355BR_Encounter_RefuseReason_FReason = "";
         Z354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
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
         AV15BR_Information = new SdtBR_Information(context);
         A349BR_Encounter_RefuseReason_Reason = "";
         A350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         TempTags = "";
         A355BR_Encounter_RefuseReason_FReason = "";
         A354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A352BR_Encounter_RefuseReason_Approver = "";
         AV17Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode42 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         T00154_A85BR_Information_ID = new long[1] ;
         T00154_n85BR_Information_ID = new bool[] {false} ;
         T00155_A348BR_Encounter_RefuseReasonID = new long[1] ;
         T00155_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         T00155_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         T00155_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         T00155_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         T00155_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         T00155_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         T00155_A352BR_Encounter_RefuseReason_Approver = new String[] {""} ;
         T00155_n352BR_Encounter_RefuseReason_Approver = new bool[] {false} ;
         T00155_A353BR_EncounterReason_IsApprove = new bool[] {false} ;
         T00155_n353BR_EncounterReason_IsApprove = new bool[] {false} ;
         T00155_A356BR_EncounterReason_vStatus = new short[1] ;
         T00155_n356BR_EncounterReason_vStatus = new bool[] {false} ;
         T00155_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         T00155_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         T00155_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         T00155_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         T00155_A19BR_EncounterID = new long[1] ;
         T00155_A85BR_Information_ID = new long[1] ;
         T00155_n85BR_Information_ID = new bool[] {false} ;
         T00156_A85BR_Information_ID = new long[1] ;
         T00156_n85BR_Information_ID = new bool[] {false} ;
         T00157_A348BR_Encounter_RefuseReasonID = new long[1] ;
         T00153_A348BR_Encounter_RefuseReasonID = new long[1] ;
         T00153_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         T00153_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         T00153_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         T00153_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         T00153_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         T00153_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         T00153_A352BR_Encounter_RefuseReason_Approver = new String[] {""} ;
         T00153_n352BR_Encounter_RefuseReason_Approver = new bool[] {false} ;
         T00153_A353BR_EncounterReason_IsApprove = new bool[] {false} ;
         T00153_n353BR_EncounterReason_IsApprove = new bool[] {false} ;
         T00153_A356BR_EncounterReason_vStatus = new short[1] ;
         T00153_n356BR_EncounterReason_vStatus = new bool[] {false} ;
         T00153_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         T00153_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         T00153_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         T00153_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         T00153_A19BR_EncounterID = new long[1] ;
         T00158_A348BR_Encounter_RefuseReasonID = new long[1] ;
         T00159_A348BR_Encounter_RefuseReasonID = new long[1] ;
         T00152_A348BR_Encounter_RefuseReasonID = new long[1] ;
         T00152_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         T00152_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         T00152_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         T00152_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         T00152_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         T00152_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         T00152_A352BR_Encounter_RefuseReason_Approver = new String[] {""} ;
         T00152_n352BR_Encounter_RefuseReason_Approver = new bool[] {false} ;
         T00152_A353BR_EncounterReason_IsApprove = new bool[] {false} ;
         T00152_n353BR_EncounterReason_IsApprove = new bool[] {false} ;
         T00152_A356BR_EncounterReason_vStatus = new short[1] ;
         T00152_n356BR_EncounterReason_vStatus = new bool[] {false} ;
         T00152_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         T00152_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         T00152_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         T00152_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         T00152_A19BR_EncounterID = new long[1] ;
         T001510_A348BR_Encounter_RefuseReasonID = new long[1] ;
         T001513_A85BR_Information_ID = new long[1] ;
         T001513_n85BR_Information_ID = new bool[] {false} ;
         T001514_A348BR_Encounter_RefuseReasonID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encounter_refusereason__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounter_refusereason__default(),
            new Object[][] {
                new Object[] {
               T00152_A348BR_Encounter_RefuseReasonID, T00152_A349BR_Encounter_RefuseReason_Reason, T00152_n349BR_Encounter_RefuseReason_Reason, T00152_A350BR_Encounter_RefuseReason_NoApproveDate, T00152_n350BR_Encounter_RefuseReason_NoApproveDate, T00152_A351BR_Encounter_RefuseReason_Status, T00152_n351BR_Encounter_RefuseReason_Status, T00152_A352BR_Encounter_RefuseReason_Approver, T00152_n352BR_Encounter_RefuseReason_Approver, T00152_A353BR_EncounterReason_IsApprove,
               T00152_n353BR_EncounterReason_IsApprove, T00152_A356BR_EncounterReason_vStatus, T00152_n356BR_EncounterReason_vStatus, T00152_A355BR_Encounter_RefuseReason_FReason, T00152_n355BR_Encounter_RefuseReason_FReason, T00152_A354BR_Encounter_RefuseReason_FApproveDate, T00152_n354BR_Encounter_RefuseReason_FApproveDate, T00152_A19BR_EncounterID
               }
               , new Object[] {
               T00153_A348BR_Encounter_RefuseReasonID, T00153_A349BR_Encounter_RefuseReason_Reason, T00153_n349BR_Encounter_RefuseReason_Reason, T00153_A350BR_Encounter_RefuseReason_NoApproveDate, T00153_n350BR_Encounter_RefuseReason_NoApproveDate, T00153_A351BR_Encounter_RefuseReason_Status, T00153_n351BR_Encounter_RefuseReason_Status, T00153_A352BR_Encounter_RefuseReason_Approver, T00153_n352BR_Encounter_RefuseReason_Approver, T00153_A353BR_EncounterReason_IsApprove,
               T00153_n353BR_EncounterReason_IsApprove, T00153_A356BR_EncounterReason_vStatus, T00153_n356BR_EncounterReason_vStatus, T00153_A355BR_Encounter_RefuseReason_FReason, T00153_n355BR_Encounter_RefuseReason_FReason, T00153_A354BR_Encounter_RefuseReason_FApproveDate, T00153_n354BR_Encounter_RefuseReason_FApproveDate, T00153_A19BR_EncounterID
               }
               , new Object[] {
               T00154_A85BR_Information_ID, T00154_n85BR_Information_ID
               }
               , new Object[] {
               T00155_A348BR_Encounter_RefuseReasonID, T00155_A349BR_Encounter_RefuseReason_Reason, T00155_n349BR_Encounter_RefuseReason_Reason, T00155_A350BR_Encounter_RefuseReason_NoApproveDate, T00155_n350BR_Encounter_RefuseReason_NoApproveDate, T00155_A351BR_Encounter_RefuseReason_Status, T00155_n351BR_Encounter_RefuseReason_Status, T00155_A352BR_Encounter_RefuseReason_Approver, T00155_n352BR_Encounter_RefuseReason_Approver, T00155_A353BR_EncounterReason_IsApprove,
               T00155_n353BR_EncounterReason_IsApprove, T00155_A356BR_EncounterReason_vStatus, T00155_n356BR_EncounterReason_vStatus, T00155_A355BR_Encounter_RefuseReason_FReason, T00155_n355BR_Encounter_RefuseReason_FReason, T00155_A354BR_Encounter_RefuseReason_FApproveDate, T00155_n354BR_Encounter_RefuseReason_FApproveDate, T00155_A19BR_EncounterID, T00155_A85BR_Information_ID, T00155_n85BR_Information_ID
               }
               , new Object[] {
               T00156_A85BR_Information_ID, T00156_n85BR_Information_ID
               }
               , new Object[] {
               T00157_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               T00158_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               T00159_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               T001510_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001513_A85BR_Information_ID, T001513_n85BR_Information_ID
               }
               , new Object[] {
               T001514_A348BR_Encounter_RefuseReasonID
               }
            }
         );
         AV17Pgmname = "BR_Encounter_RefuseReason";
      }

      private short Z351BR_Encounter_RefuseReason_Status ;
      private short Z356BR_EncounterReason_vStatus ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A351BR_Encounter_RefuseReason_Status ;
      private short A356BR_EncounterReason_vStatus ;
      private short RcdFound42 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_EncounterID_Enabled ;
      private int edtavBr_information_br_information_id_Enabled ;
      private int edtBR_Encounter_RefuseReason_Reason_Enabled ;
      private int edtBR_Encounter_RefuseReason_NoApproveDate_Enabled ;
      private int edtBR_Encounter_RefuseReason_FReason_Enabled ;
      private int edtBR_Encounter_RefuseReason_FApproveDate_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_Encounter_RefuseReasonID_Enabled ;
      private int edtBR_Encounter_RefuseReasonID_Visible ;
      private int AV18GXV2 ;
      private int idxLst ;
      private long wcpOAV7BR_Encounter_RefuseReasonID ;
      private long Z348BR_Encounter_RefuseReasonID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long AV7BR_Encounter_RefuseReasonID ;
      private long A348BR_Encounter_RefuseReasonID ;
      private long AV13Insert_BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long Z85BR_Information_ID ;
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
      private String edtBR_Encounter_RefuseReason_FReason_Internalname ;
      private String cmbBR_Encounter_RefuseReason_Status_Internalname ;
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
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtavBr_information_br_information_id_Internalname ;
      private String edtavBr_information_br_information_id_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_Reason_Internalname ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Internalname ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick ;
      private String cmbBR_Encounter_RefuseReason_Status_Jsonclick ;
      private String TempTags ;
      private String edtBR_Encounter_RefuseReason_FApproveDate_Internalname ;
      private String edtBR_Encounter_RefuseReason_FApproveDate_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Encounter_RefuseReasonID_Internalname ;
      private String edtBR_Encounter_RefuseReasonID_Jsonclick ;
      private String AV17Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode42 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z350BR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime Z354BR_Encounter_RefuseReason_FApproveDate ;
      private DateTime A350BR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool Z353BR_EncounterReason_IsApprove ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n351BR_Encounter_RefuseReason_Status ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n349BR_Encounter_RefuseReason_Reason ;
      private bool n350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool n355BR_Encounter_RefuseReason_FReason ;
      private bool n354BR_Encounter_RefuseReason_FApproveDate ;
      private bool n352BR_Encounter_RefuseReason_Approver ;
      private bool n353BR_EncounterReason_IsApprove ;
      private bool A353BR_EncounterReason_IsApprove ;
      private bool n356BR_EncounterReason_vStatus ;
      private bool n85BR_Information_ID ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z349BR_Encounter_RefuseReason_Reason ;
      private String Z352BR_Encounter_RefuseReason_Approver ;
      private String Z355BR_Encounter_RefuseReason_FReason ;
      private String A349BR_Encounter_RefuseReason_Reason ;
      private String A355BR_Encounter_RefuseReason_FReason ;
      private String A352BR_Encounter_RefuseReason_Approver ;
      private IGxSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Encounter_RefuseReason_Status ;
      private IDataStoreProvider pr_default ;
      private long[] T00154_A85BR_Information_ID ;
      private bool[] T00154_n85BR_Information_ID ;
      private long[] T00155_A348BR_Encounter_RefuseReasonID ;
      private String[] T00155_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] T00155_n349BR_Encounter_RefuseReason_Reason ;
      private DateTime[] T00155_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] T00155_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private short[] T00155_A351BR_Encounter_RefuseReason_Status ;
      private bool[] T00155_n351BR_Encounter_RefuseReason_Status ;
      private String[] T00155_A352BR_Encounter_RefuseReason_Approver ;
      private bool[] T00155_n352BR_Encounter_RefuseReason_Approver ;
      private bool[] T00155_A353BR_EncounterReason_IsApprove ;
      private bool[] T00155_n353BR_EncounterReason_IsApprove ;
      private short[] T00155_A356BR_EncounterReason_vStatus ;
      private bool[] T00155_n356BR_EncounterReason_vStatus ;
      private String[] T00155_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] T00155_n355BR_Encounter_RefuseReason_FReason ;
      private DateTime[] T00155_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] T00155_n354BR_Encounter_RefuseReason_FApproveDate ;
      private long[] T00155_A19BR_EncounterID ;
      private long[] T00155_A85BR_Information_ID ;
      private bool[] T00155_n85BR_Information_ID ;
      private long[] T00156_A85BR_Information_ID ;
      private bool[] T00156_n85BR_Information_ID ;
      private long[] T00157_A348BR_Encounter_RefuseReasonID ;
      private long[] T00153_A348BR_Encounter_RefuseReasonID ;
      private String[] T00153_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] T00153_n349BR_Encounter_RefuseReason_Reason ;
      private DateTime[] T00153_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] T00153_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private short[] T00153_A351BR_Encounter_RefuseReason_Status ;
      private bool[] T00153_n351BR_Encounter_RefuseReason_Status ;
      private String[] T00153_A352BR_Encounter_RefuseReason_Approver ;
      private bool[] T00153_n352BR_Encounter_RefuseReason_Approver ;
      private bool[] T00153_A353BR_EncounterReason_IsApprove ;
      private bool[] T00153_n353BR_EncounterReason_IsApprove ;
      private short[] T00153_A356BR_EncounterReason_vStatus ;
      private bool[] T00153_n356BR_EncounterReason_vStatus ;
      private String[] T00153_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] T00153_n355BR_Encounter_RefuseReason_FReason ;
      private DateTime[] T00153_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] T00153_n354BR_Encounter_RefuseReason_FApproveDate ;
      private long[] T00153_A19BR_EncounterID ;
      private long[] T00158_A348BR_Encounter_RefuseReasonID ;
      private long[] T00159_A348BR_Encounter_RefuseReasonID ;
      private long[] T00152_A348BR_Encounter_RefuseReasonID ;
      private String[] T00152_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] T00152_n349BR_Encounter_RefuseReason_Reason ;
      private DateTime[] T00152_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] T00152_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private short[] T00152_A351BR_Encounter_RefuseReason_Status ;
      private bool[] T00152_n351BR_Encounter_RefuseReason_Status ;
      private String[] T00152_A352BR_Encounter_RefuseReason_Approver ;
      private bool[] T00152_n352BR_Encounter_RefuseReason_Approver ;
      private bool[] T00152_A353BR_EncounterReason_IsApprove ;
      private bool[] T00152_n353BR_EncounterReason_IsApprove ;
      private short[] T00152_A356BR_EncounterReason_vStatus ;
      private bool[] T00152_n356BR_EncounterReason_vStatus ;
      private String[] T00152_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] T00152_n355BR_Encounter_RefuseReason_FReason ;
      private DateTime[] T00152_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] T00152_n354BR_Encounter_RefuseReason_FApproveDate ;
      private long[] T00152_A19BR_EncounterID ;
      private long[] T001510_A348BR_Encounter_RefuseReasonID ;
      private long[] T001513_A85BR_Information_ID ;
      private bool[] T001513_n85BR_Information_ID ;
      private long[] T001514_A348BR_Encounter_RefuseReasonID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
      private SdtBR_Information AV15BR_Information ;
   }

   public class br_encounter_refusereason__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_encounter_refusereason__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT00155 ;
        prmT00155 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00154 ;
        prmT00154 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00156 ;
        prmT00156 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00157 ;
        prmT00157 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00153 ;
        prmT00153 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00158 ;
        prmT00158 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00159 ;
        prmT00159 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00152 ;
        prmT00152 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001510 ;
        prmT001510 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReason_Reason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_NoApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_RefuseReason_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_Approver",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterReason_IsApprove",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_EncounterReason_vStatus",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_FReason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_FApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001511 ;
        prmT001511 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReason_Reason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_NoApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_RefuseReason_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_Approver",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterReason_IsApprove",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_EncounterReason_vStatus",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_FReason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_FApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001512 ;
        prmT001512 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001514 ;
        prmT001514 = new Object[] {
        } ;
        Object[] prmT001513 ;
        prmT001513 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00152", "SELECT [BR_Encounter_RefuseReasonID], [BR_Encounter_RefuseReason_Reason], [BR_Encounter_RefuseReason_NoApproveDate], [BR_Encounter_RefuseReason_Status], [BR_Encounter_RefuseReason_Approver], [BR_EncounterReason_IsApprove], [BR_EncounterReason_vStatus], [BR_Encounter_RefuseReason_FReason], [BR_Encounter_RefuseReason_FApproveDate], [BR_EncounterID] FROM [BR_Encounter_RefuseReason] WITH (UPDLOCK) WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00152,1,0,true,false )
           ,new CursorDef("T00153", "SELECT [BR_Encounter_RefuseReasonID], [BR_Encounter_RefuseReason_Reason], [BR_Encounter_RefuseReason_NoApproveDate], [BR_Encounter_RefuseReason_Status], [BR_Encounter_RefuseReason_Approver], [BR_EncounterReason_IsApprove], [BR_EncounterReason_vStatus], [BR_Encounter_RefuseReason_FReason], [BR_Encounter_RefuseReason_FApproveDate], [BR_EncounterID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK) WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00153,1,0,true,false )
           ,new CursorDef("T00154", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00154,1,0,true,false )
           ,new CursorDef("T00155", "SELECT TM1.[BR_Encounter_RefuseReasonID], TM1.[BR_Encounter_RefuseReason_Reason], TM1.[BR_Encounter_RefuseReason_NoApproveDate], TM1.[BR_Encounter_RefuseReason_Status], TM1.[BR_Encounter_RefuseReason_Approver], TM1.[BR_EncounterReason_IsApprove], TM1.[BR_EncounterReason_vStatus], TM1.[BR_Encounter_RefuseReason_FReason], TM1.[BR_Encounter_RefuseReason_FApproveDate], TM1.[BR_EncounterID], T2.[BR_Information_ID] FROM ([BR_Encounter_RefuseReason] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) WHERE TM1.[BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID ORDER BY TM1.[BR_Encounter_RefuseReasonID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00155,100,0,true,false )
           ,new CursorDef("T00156", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00156,1,0,true,false )
           ,new CursorDef("T00157", "SELECT [BR_Encounter_RefuseReasonID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK) WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00157,1,0,true,false )
           ,new CursorDef("T00158", "SELECT TOP 1 [BR_Encounter_RefuseReasonID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK) WHERE ( [BR_Encounter_RefuseReasonID] > @BR_Encounter_RefuseReasonID) ORDER BY [BR_Encounter_RefuseReasonID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00158,1,0,true,true )
           ,new CursorDef("T00159", "SELECT TOP 1 [BR_Encounter_RefuseReasonID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK) WHERE ( [BR_Encounter_RefuseReasonID] < @BR_Encounter_RefuseReasonID) ORDER BY [BR_Encounter_RefuseReasonID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00159,1,0,true,true )
           ,new CursorDef("T001510", "INSERT INTO [BR_Encounter_RefuseReason]([BR_Encounter_RefuseReason_Reason], [BR_Encounter_RefuseReason_NoApproveDate], [BR_Encounter_RefuseReason_Status], [BR_Encounter_RefuseReason_Approver], [BR_EncounterReason_IsApprove], [BR_EncounterReason_vStatus], [BR_Encounter_RefuseReason_FReason], [BR_Encounter_RefuseReason_FApproveDate], [BR_EncounterID]) VALUES(@BR_Encounter_RefuseReason_Reason, @BR_Encounter_RefuseReason_NoApproveDate, @BR_Encounter_RefuseReason_Status, @BR_Encounter_RefuseReason_Approver, @BR_EncounterReason_IsApprove, @BR_EncounterReason_vStatus, @BR_Encounter_RefuseReason_FReason, @BR_Encounter_RefuseReason_FApproveDate, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT001510)
           ,new CursorDef("T001511", "UPDATE [BR_Encounter_RefuseReason] SET [BR_Encounter_RefuseReason_Reason]=@BR_Encounter_RefuseReason_Reason, [BR_Encounter_RefuseReason_NoApproveDate]=@BR_Encounter_RefuseReason_NoApproveDate, [BR_Encounter_RefuseReason_Status]=@BR_Encounter_RefuseReason_Status, [BR_Encounter_RefuseReason_Approver]=@BR_Encounter_RefuseReason_Approver, [BR_EncounterReason_IsApprove]=@BR_EncounterReason_IsApprove, [BR_EncounterReason_vStatus]=@BR_EncounterReason_vStatus, [BR_Encounter_RefuseReason_FReason]=@BR_Encounter_RefuseReason_FReason, [BR_Encounter_RefuseReason_FApproveDate]=@BR_Encounter_RefuseReason_FApproveDate, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID", GxErrorMask.GX_NOMASK,prmT001511)
           ,new CursorDef("T001512", "DELETE FROM [BR_Encounter_RefuseReason]  WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID", GxErrorMask.GX_NOMASK,prmT001512)
           ,new CursorDef("T001513", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001513,1,0,true,false )
           ,new CursorDef("T001514", "SELECT [BR_Encounter_RefuseReasonID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK) ORDER BY [BR_Encounter_RefuseReasonID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001514,100,0,true,false )
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
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((short[]) buf[5])[0] = rslt.getShort(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDateTime(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((short[]) buf[5])[0] = rslt.getShort(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDateTime(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((short[]) buf[5])[0] = rslt.getShort(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDateTime(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((long[]) buf[18])[0] = rslt.getLong(11) ;
              ((bool[]) buf[19])[0] = rslt.wasNull(11);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
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
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(2, (DateTime)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(3, (short)parms[5]);
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
                 stmt.setNull( 5 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(5, (bool)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(6, (short)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(8, (DateTime)parms[15]);
              }
              stmt.SetParameter(9, (long)parms[16]);
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
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(2, (DateTime)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(3, (short)parms[5]);
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
                 stmt.setNull( 5 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(5, (bool)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(6, (short)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(8, (DateTime)parms[15]);
              }
              stmt.SetParameter(9, (long)parms[16]);
              stmt.SetParameter(10, (long)parms[17]);
              return;
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 11 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
