/*
               File: BR_Medication_Scheme
        Description: 药物治疗化疗方案0813弃用
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:12.30
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
   public class br_medication_scheme : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action14") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_14_0V32( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action15") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_15_0V32( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_MEDICATION_CHEM_LINE") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_MEDICATION_CHEM_LINE0V32( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_17") == 0 )
         {
            A119BR_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n119BR_MedicationID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_17( A119BR_MedicationID) ;
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
               AV7BR_Medication_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_Medication_SchemeID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_MEDICATION_SCHEMEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            Form.Meta.addItem("description", "药物治疗化疗方案0813弃用", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBR_Medication_Chem_Name_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_medication_scheme( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_scheme( IGxContext context )
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
                           long aP1_BR_Medication_SchemeID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_Medication_SchemeID = aP1_BR_Medication_SchemeID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynBR_Medication_Chem_Line = new GXCombobox();
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
         if ( dynBR_Medication_Chem_Line.ItemCount > 0 )
         {
            A307BR_Medication_Chem_Line = dynBR_Medication_Chem_Line.getValidValue(A307BR_Medication_Chem_Line);
            n307BR_Medication_Chem_Line = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307BR_Medication_Chem_Line", A307BR_Medication_Chem_Line);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Medication_Chem_Line.CurrentValue = StringUtil.RTrim( A307BR_Medication_Chem_Line);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_Chem_Line_Internalname, "Values", dynBR_Medication_Chem_Line.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_Chem_Name_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_Chem_Name_Internalname, "化疗方案名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_Chem_Name_Internalname, A305BR_Medication_Chem_Name, StringUtil.RTrim( context.localUtil.Format( A305BR_Medication_Chem_Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_Chem_Name_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_Chem_Name_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_Chem_Cycle_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_Chem_Cycle_Internalname, "周期", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_Chem_Cycle_Internalname, StringUtil.LTrim( StringUtil.NToC( A306BR_Medication_Chem_Cycle, 15, 5, ".", "")), ((edtBR_Medication_Chem_Cycle_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A306BR_Medication_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A306BR_Medication_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_Chem_Cycle_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_Chem_Cycle_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Medication_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_medication_chem_line_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medication_chem_line_Internalname, "线级", "", "", lblTextblockbr_medication_chem_line_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Medication_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_36_0V32( true) ;
         }
         return  ;
      }

      protected void wb_table1_36_0V32e( bool wbgen )
      {
         if ( wbgen )
         {
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medication_chem_detail_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-1 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medication_chem_detail_Internalname, "描述化疗方案", "", "", lblTextblockbr_medication_chem_detail_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Medication_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-11", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_Chem_Detail_Internalname, "描述化疗方案", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_Chem_Detail_Internalname, A313BR_Medication_Chem_Detail, StringUtil.RTrim( context.localUtil.Format( A313BR_Medication_Chem_Detail, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_Chem_Detail_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_Chem_Detail_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_Scheme.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication_Scheme.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_SchemeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A296BR_Medication_SchemeID), 18, 0, ".", "")), ((edtBR_Medication_SchemeID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_SchemeID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Medication_SchemeID_Visible, edtBR_Medication_SchemeID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Medication_Scheme.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_MedicationID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicationID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicationID_Visible, edtBR_MedicationID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Medication_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_36_0V32( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_medication_chem_line_Internalname, tblTablemergedbr_medication_chem_line_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Medication_Chem_Line_Internalname, "线级", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Medication_Chem_Line, dynBR_Medication_Chem_Line_Internalname, StringUtil.RTrim( A307BR_Medication_Chem_Line), 1, dynBR_Medication_Chem_Line_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Medication_Chem_Line.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "", true, "HLP_BR_Medication_Scheme.htm");
            dynBR_Medication_Chem_Line.CurrentValue = StringUtil.RTrim( A307BR_Medication_Chem_Line);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_Chem_Line_Internalname, "Values", (String)(dynBR_Medication_Chem_Line.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVline_cell_Internalname+"\"  class='"+cellVline_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVline_Internalname, "v Line", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVline_Internalname, AV15vLine, StringUtil.RTrim( context.localUtil.Format( AV15vLine, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其他线级", edtavVline_Jsonclick, 0, "Attribute", "", "", "", "", edtavVline_Visible, edtavVline_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_36_0V32e( true) ;
         }
         else
         {
            wb_table1_36_0V32e( false) ;
         }
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
         E110V2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A305BR_Medication_Chem_Name = cgiGet( edtBR_Medication_Chem_Name_Internalname);
               n305BR_Medication_Chem_Name = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A305BR_Medication_Chem_Name", A305BR_Medication_Chem_Name);
               n305BR_Medication_Chem_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A305BR_Medication_Chem_Name)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Medication_Chem_Cycle_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Medication_Chem_Cycle_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICATION_CHEM_CYCLE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Medication_Chem_Cycle_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A306BR_Medication_Chem_Cycle = 0;
                  n306BR_Medication_Chem_Cycle = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306BR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A306BR_Medication_Chem_Cycle, 15, 5)));
               }
               else
               {
                  A306BR_Medication_Chem_Cycle = context.localUtil.CToN( cgiGet( edtBR_Medication_Chem_Cycle_Internalname), ".", ",");
                  n306BR_Medication_Chem_Cycle = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306BR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A306BR_Medication_Chem_Cycle, 15, 5)));
               }
               n306BR_Medication_Chem_Cycle = ((Convert.ToDecimal(0)==A306BR_Medication_Chem_Cycle) ? true : false);
               dynBR_Medication_Chem_Line.CurrentValue = cgiGet( dynBR_Medication_Chem_Line_Internalname);
               A307BR_Medication_Chem_Line = cgiGet( dynBR_Medication_Chem_Line_Internalname);
               n307BR_Medication_Chem_Line = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307BR_Medication_Chem_Line", A307BR_Medication_Chem_Line);
               n307BR_Medication_Chem_Line = (String.IsNullOrEmpty(StringUtil.RTrim( A307BR_Medication_Chem_Line)) ? true : false);
               AV15vLine = cgiGet( edtavVline_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vLine", AV15vLine);
               A313BR_Medication_Chem_Detail = cgiGet( edtBR_Medication_Chem_Detail_Internalname);
               n313BR_Medication_Chem_Detail = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313BR_Medication_Chem_Detail", A313BR_Medication_Chem_Detail);
               n313BR_Medication_Chem_Detail = (String.IsNullOrEmpty(StringUtil.RTrim( A313BR_Medication_Chem_Detail)) ? true : false);
               A296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_Medication_SchemeID_Internalname), ".", ","));
               n296BR_Medication_SchemeID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICATIONID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_MedicationID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A119BR_MedicationID = 0;
                  n119BR_MedicationID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
               }
               else
               {
                  A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ","));
                  n119BR_MedicationID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
               }
               n119BR_MedicationID = ((0==A119BR_MedicationID) ? true : false);
               /* Read saved values. */
               Z296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( "Z296BR_Medication_SchemeID"), ".", ","));
               Z305BR_Medication_Chem_Name = cgiGet( "Z305BR_Medication_Chem_Name");
               n305BR_Medication_Chem_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A305BR_Medication_Chem_Name)) ? true : false);
               Z306BR_Medication_Chem_Cycle = context.localUtil.CToN( cgiGet( "Z306BR_Medication_Chem_Cycle"), ".", ",");
               n306BR_Medication_Chem_Cycle = ((Convert.ToDecimal(0)==A306BR_Medication_Chem_Cycle) ? true : false);
               Z307BR_Medication_Chem_Line = cgiGet( "Z307BR_Medication_Chem_Line");
               n307BR_Medication_Chem_Line = (String.IsNullOrEmpty(StringUtil.RTrim( A307BR_Medication_Chem_Line)) ? true : false);
               Z313BR_Medication_Chem_Detail = cgiGet( "Z313BR_Medication_Chem_Detail");
               n313BR_Medication_Chem_Detail = (String.IsNullOrEmpty(StringUtil.RTrim( A313BR_Medication_Chem_Detail)) ? true : false);
               Z119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( "Z119BR_MedicationID"), ".", ","));
               n119BR_MedicationID = ((0==A119BR_MedicationID) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( "N119BR_MedicationID"), ".", ","));
               n119BR_MedicationID = ((0==A119BR_MedicationID) ? true : false);
               AV7BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( "vBR_MEDICATION_SCHEMEID"), ".", ","));
               AV13Insert_BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_MEDICATIONID"), ".", ","));
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
               forbiddenHiddens = "hsh" + "BR_Medication_Scheme";
               A296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_Medication_SchemeID_Internalname), ".", ","));
               n296BR_Medication_SchemeID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A296BR_Medication_SchemeID != Z296BR_Medication_SchemeID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_medication_scheme:[SecurityCheckFailed value for]"+"BR_Medication_SchemeID:"+context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_medication_scheme:[SecurityCheckFailed value for]"+"Insert_BR_MedicationID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_medication_scheme:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A296BR_Medication_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  n296BR_Medication_SchemeID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
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
                     sMode32 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode32;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound32 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0V0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_MEDICATION_SCHEMEID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_Medication_SchemeID_Internalname;
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
                           E110V2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120V2 ();
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
            E120V2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0V32( ) ;
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
            DisableAttributes0V32( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Enabled), 5, 0)), true);
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

      protected void CONFIRM_0V0( )
      {
         BeforeValidate0V32( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0V32( ) ;
            }
            else
            {
               CheckExtendedTable0V32( ) ;
               CloseExtendedTableCursors0V32( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0V0( )
      {
      }

      protected void E110V2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme_Delete", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV16Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV17GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            while ( AV17GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV17GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_MedicationID") == 0 )
               {
                  AV13Insert_BR_MedicationID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_BR_MedicationID), 18, 0)));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            }
         }
         edtBR_Medication_SchemeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_SchemeID_Visible), 5, 0)), true);
         edtBR_MedicationID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Visible), 5, 0)), true);
      }

      protected void E120V2( )
      {
         /* After Trn Routine */
         if ( 1 == 0 )
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
            {
               CallWebObject(formatLink("br_medication_schemeww.aspx") );
               context.wjLocDisableFrm = 1;
            }
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            CallWebObject(formatLink("br_medication_schemeview.aspx") + "?" + UrlEncode("" +A296BR_Medication_SchemeID) + "," + UrlEncode("" +A119BR_MedicationID) + "," + UrlEncode(StringUtil.RTrim("General")));
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         edtavVline_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Visible), 5, 0)), true);
         cellVline_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
      }

      protected void ZM0V32( short GX_JID )
      {
         if ( ( GX_JID == 16 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z305BR_Medication_Chem_Name = T000V3_A305BR_Medication_Chem_Name[0];
               Z306BR_Medication_Chem_Cycle = T000V3_A306BR_Medication_Chem_Cycle[0];
               Z307BR_Medication_Chem_Line = T000V3_A307BR_Medication_Chem_Line[0];
               Z313BR_Medication_Chem_Detail = T000V3_A313BR_Medication_Chem_Detail[0];
               Z119BR_MedicationID = T000V3_A119BR_MedicationID[0];
            }
            else
            {
               Z305BR_Medication_Chem_Name = A305BR_Medication_Chem_Name;
               Z306BR_Medication_Chem_Cycle = A306BR_Medication_Chem_Cycle;
               Z307BR_Medication_Chem_Line = A307BR_Medication_Chem_Line;
               Z313BR_Medication_Chem_Detail = A313BR_Medication_Chem_Detail;
               Z119BR_MedicationID = A119BR_MedicationID;
            }
         }
         if ( GX_JID == -16 )
         {
            Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
            Z305BR_Medication_Chem_Name = A305BR_Medication_Chem_Name;
            Z306BR_Medication_Chem_Cycle = A306BR_Medication_Chem_Cycle;
            Z307BR_Medication_Chem_Line = A307BR_Medication_Chem_Line;
            Z313BR_Medication_Chem_Detail = A313BR_Medication_Chem_Detail;
            Z119BR_MedicationID = A119BR_MedicationID;
         }
      }

      protected void standaloneNotModal( )
      {
         GXABR_MEDICATION_CHEM_LINE_html0V32( ) ;
         edtBR_Medication_SchemeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_SchemeID_Enabled), 5, 0)), true);
         edtBR_Medication_SchemeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_SchemeID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_Medication_SchemeID) )
         {
            A296BR_Medication_SchemeID = AV7BR_Medication_SchemeID;
            n296BR_Medication_SchemeID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_MedicationID) )
         {
            edtBR_MedicationID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Enabled), 5, 0)), true);
         }
         else
         {
            edtBR_MedicationID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_MedicationID) )
         {
            A119BR_MedicationID = AV13Insert_BR_MedicationID;
            n119BR_MedicationID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
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
            edtavVline_Visible = ((StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它") == 0 ) ) )
            {
               cellVline_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它") == 0 )
               {
                  cellVline_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
               }
            }
            AV16Pgmname = "BR_Medication_Scheme";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         }
      }

      protected void Load0V32( )
      {
         /* Using cursor T000V5 */
         pr_default.execute(3, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound32 = 1;
            A305BR_Medication_Chem_Name = T000V5_A305BR_Medication_Chem_Name[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A305BR_Medication_Chem_Name", A305BR_Medication_Chem_Name);
            n305BR_Medication_Chem_Name = T000V5_n305BR_Medication_Chem_Name[0];
            A306BR_Medication_Chem_Cycle = T000V5_A306BR_Medication_Chem_Cycle[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306BR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A306BR_Medication_Chem_Cycle, 15, 5)));
            n306BR_Medication_Chem_Cycle = T000V5_n306BR_Medication_Chem_Cycle[0];
            A307BR_Medication_Chem_Line = T000V5_A307BR_Medication_Chem_Line[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307BR_Medication_Chem_Line", A307BR_Medication_Chem_Line);
            n307BR_Medication_Chem_Line = T000V5_n307BR_Medication_Chem_Line[0];
            A313BR_Medication_Chem_Detail = T000V5_A313BR_Medication_Chem_Detail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313BR_Medication_Chem_Detail", A313BR_Medication_Chem_Detail);
            n313BR_Medication_Chem_Detail = T000V5_n313BR_Medication_Chem_Detail[0];
            A119BR_MedicationID = T000V5_A119BR_MedicationID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
            n119BR_MedicationID = T000V5_n119BR_MedicationID[0];
            ZM0V32( -16) ;
         }
         pr_default.close(3);
         OnLoadActions0V32( ) ;
      }

      protected void OnLoadActions0V32( )
      {
         AV16Pgmname = "BR_Medication_Scheme";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         edtavVline_Visible = ((StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它") == 0 ) ) )
         {
            cellVline_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它") == 0 )
            {
               cellVline_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
            }
         }
      }

      protected void CheckExtendedTable0V32( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV16Pgmname = "BR_Medication_Scheme";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         /* Using cursor T000V4 */
         pr_default.execute(2, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A119BR_MedicationID) ) )
            {
               GX_msglist.addItem("不匹配' T18'", "ForeignKeyNotFound", 1, "BR_MEDICATIONID");
               AnyError = 1;
               GX_FocusControl = edtBR_MedicationID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A305BR_Medication_Chem_Name)) )
         {
            GX_msglist.addItem("化疗方案名称是必须填写的。", 1, "BR_MEDICATION_CHEM_NAME");
            AnyError = 1;
            GX_FocusControl = edtBR_Medication_Chem_Name_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         edtavVline_Visible = ((StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它") == 0 ) ) )
         {
            cellVline_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它") == 0 )
            {
               cellVline_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
            }
         }
         if ( ( ( StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV15vLine)) )
         {
            GX_msglist.addItem("其它线级是必填的", 1, "BR_MEDICATION_CHEM_LINE");
            AnyError = 1;
            GX_FocusControl = dynBR_Medication_Chem_Line_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0V32( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_17( long A119BR_MedicationID )
      {
         /* Using cursor T000V6 */
         pr_default.execute(4, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( (0==A119BR_MedicationID) ) )
            {
               GX_msglist.addItem("不匹配' T18'", "ForeignKeyNotFound", 1, "BR_MEDICATIONID");
               AnyError = 1;
               GX_FocusControl = edtBR_MedicationID_Internalname;
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

      protected void GetKey0V32( )
      {
         /* Using cursor T000V7 */
         pr_default.execute(5, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound32 = 1;
         }
         else
         {
            RcdFound32 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000V3 */
         pr_default.execute(1, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0V32( 16) ;
            RcdFound32 = 1;
            A296BR_Medication_SchemeID = T000V3_A296BR_Medication_SchemeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
            n296BR_Medication_SchemeID = T000V3_n296BR_Medication_SchemeID[0];
            A305BR_Medication_Chem_Name = T000V3_A305BR_Medication_Chem_Name[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A305BR_Medication_Chem_Name", A305BR_Medication_Chem_Name);
            n305BR_Medication_Chem_Name = T000V3_n305BR_Medication_Chem_Name[0];
            A306BR_Medication_Chem_Cycle = T000V3_A306BR_Medication_Chem_Cycle[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306BR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A306BR_Medication_Chem_Cycle, 15, 5)));
            n306BR_Medication_Chem_Cycle = T000V3_n306BR_Medication_Chem_Cycle[0];
            A307BR_Medication_Chem_Line = T000V3_A307BR_Medication_Chem_Line[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307BR_Medication_Chem_Line", A307BR_Medication_Chem_Line);
            n307BR_Medication_Chem_Line = T000V3_n307BR_Medication_Chem_Line[0];
            A313BR_Medication_Chem_Detail = T000V3_A313BR_Medication_Chem_Detail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313BR_Medication_Chem_Detail", A313BR_Medication_Chem_Detail);
            n313BR_Medication_Chem_Detail = T000V3_n313BR_Medication_Chem_Detail[0];
            A119BR_MedicationID = T000V3_A119BR_MedicationID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
            n119BR_MedicationID = T000V3_n119BR_MedicationID[0];
            Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
            sMode32 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0V32( ) ;
            if ( AnyError == 1 )
            {
               RcdFound32 = 0;
               InitializeNonKey0V32( ) ;
            }
            Gx_mode = sMode32;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound32 = 0;
            InitializeNonKey0V32( ) ;
            sMode32 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode32;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0V32( ) ;
         if ( RcdFound32 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound32 = 0;
         /* Using cursor T000V8 */
         pr_default.execute(6, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000V8_A296BR_Medication_SchemeID[0] < A296BR_Medication_SchemeID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000V8_A296BR_Medication_SchemeID[0] > A296BR_Medication_SchemeID ) ) )
            {
               A296BR_Medication_SchemeID = T000V8_A296BR_Medication_SchemeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
               n296BR_Medication_SchemeID = T000V8_n296BR_Medication_SchemeID[0];
               RcdFound32 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound32 = 0;
         /* Using cursor T000V9 */
         pr_default.execute(7, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000V9_A296BR_Medication_SchemeID[0] > A296BR_Medication_SchemeID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000V9_A296BR_Medication_SchemeID[0] < A296BR_Medication_SchemeID ) ) )
            {
               A296BR_Medication_SchemeID = T000V9_A296BR_Medication_SchemeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
               n296BR_Medication_SchemeID = T000V9_n296BR_Medication_SchemeID[0];
               RcdFound32 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0V32( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_Medication_Chem_Name_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0V32( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound32 == 1 )
            {
               if ( A296BR_Medication_SchemeID != Z296BR_Medication_SchemeID )
               {
                  A296BR_Medication_SchemeID = Z296BR_Medication_SchemeID;
                  n296BR_Medication_SchemeID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_MEDICATION_SCHEMEID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Medication_SchemeID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_Medication_Chem_Name_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0V32( ) ;
                  GX_FocusControl = edtBR_Medication_Chem_Name_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A296BR_Medication_SchemeID != Z296BR_Medication_SchemeID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_Medication_Chem_Name_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0V32( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_MEDICATION_SCHEMEID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_Medication_SchemeID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_Medication_Chem_Name_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0V32( ) ;
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
         if ( A296BR_Medication_SchemeID != Z296BR_Medication_SchemeID )
         {
            A296BR_Medication_SchemeID = Z296BR_Medication_SchemeID;
            n296BR_Medication_SchemeID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_MEDICATION_SCHEMEID");
            AnyError = 1;
            GX_FocusControl = edtBR_Medication_SchemeID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_Medication_Chem_Name_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0V32( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000V2 */
            pr_default.execute(0, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication_Scheme"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z305BR_Medication_Chem_Name, T000V2_A305BR_Medication_Chem_Name[0]) != 0 ) || ( Z306BR_Medication_Chem_Cycle != T000V2_A306BR_Medication_Chem_Cycle[0] ) || ( StringUtil.StrCmp(Z307BR_Medication_Chem_Line, T000V2_A307BR_Medication_Chem_Line[0]) != 0 ) || ( StringUtil.StrCmp(Z313BR_Medication_Chem_Detail, T000V2_A313BR_Medication_Chem_Detail[0]) != 0 ) || ( Z119BR_MedicationID != T000V2_A119BR_MedicationID[0] ) )
            {
               if ( StringUtil.StrCmp(Z305BR_Medication_Chem_Name, T000V2_A305BR_Medication_Chem_Name[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication_scheme:[seudo value changed for attri]"+"BR_Medication_Chem_Name");
                  GXUtil.WriteLogRaw("Old: ",Z305BR_Medication_Chem_Name);
                  GXUtil.WriteLogRaw("Current: ",T000V2_A305BR_Medication_Chem_Name[0]);
               }
               if ( Z306BR_Medication_Chem_Cycle != T000V2_A306BR_Medication_Chem_Cycle[0] )
               {
                  GXUtil.WriteLog("br_medication_scheme:[seudo value changed for attri]"+"BR_Medication_Chem_Cycle");
                  GXUtil.WriteLogRaw("Old: ",Z306BR_Medication_Chem_Cycle);
                  GXUtil.WriteLogRaw("Current: ",T000V2_A306BR_Medication_Chem_Cycle[0]);
               }
               if ( StringUtil.StrCmp(Z307BR_Medication_Chem_Line, T000V2_A307BR_Medication_Chem_Line[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication_scheme:[seudo value changed for attri]"+"BR_Medication_Chem_Line");
                  GXUtil.WriteLogRaw("Old: ",Z307BR_Medication_Chem_Line);
                  GXUtil.WriteLogRaw("Current: ",T000V2_A307BR_Medication_Chem_Line[0]);
               }
               if ( StringUtil.StrCmp(Z313BR_Medication_Chem_Detail, T000V2_A313BR_Medication_Chem_Detail[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication_scheme:[seudo value changed for attri]"+"BR_Medication_Chem_Detail");
                  GXUtil.WriteLogRaw("Old: ",Z313BR_Medication_Chem_Detail);
                  GXUtil.WriteLogRaw("Current: ",T000V2_A313BR_Medication_Chem_Detail[0]);
               }
               if ( Z119BR_MedicationID != T000V2_A119BR_MedicationID[0] )
               {
                  GXUtil.WriteLog("br_medication_scheme:[seudo value changed for attri]"+"BR_MedicationID");
                  GXUtil.WriteLogRaw("Old: ",Z119BR_MedicationID);
                  GXUtil.WriteLogRaw("Current: ",T000V2_A119BR_MedicationID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Medication_Scheme"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0V32( )
      {
         BeforeValidate0V32( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0V32( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0V32( 0) ;
            CheckOptimisticConcurrency0V32( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0V32( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0V32( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000V10 */
                     pr_default.execute(8, new Object[] {n305BR_Medication_Chem_Name, A305BR_Medication_Chem_Name, n306BR_Medication_Chem_Cycle, A306BR_Medication_Chem_Cycle, n307BR_Medication_Chem_Line, A307BR_Medication_Chem_Line, n313BR_Medication_Chem_Detail, A313BR_Medication_Chem_Detail, n119BR_MedicationID, A119BR_MedicationID});
                     A296BR_Medication_SchemeID = T000V10_A296BR_Medication_SchemeID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
                     n296BR_Medication_SchemeID = T000V10_n296BR_Medication_SchemeID[0];
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Scheme") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)),  "药物治疗",  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0V0( ) ;
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
               Load0V32( ) ;
            }
            EndLevel0V32( ) ;
         }
         CloseExtendedTableCursors0V32( ) ;
      }

      protected void Update0V32( )
      {
         BeforeValidate0V32( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0V32( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0V32( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0V32( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0V32( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000V11 */
                     pr_default.execute(9, new Object[] {n305BR_Medication_Chem_Name, A305BR_Medication_Chem_Name, n306BR_Medication_Chem_Cycle, A306BR_Medication_Chem_Cycle, n307BR_Medication_Chem_Line, A307BR_Medication_Chem_Line, n313BR_Medication_Chem_Detail, A313BR_Medication_Chem_Detail, n119BR_MedicationID, A119BR_MedicationID, n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Scheme") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication_Scheme"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0V32( ) ;
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
            EndLevel0V32( ) ;
         }
         CloseExtendedTableCursors0V32( ) ;
      }

      protected void DeferredUpdate0V32( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0V32( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0V32( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0V32( ) ;
            AfterConfirm0V32( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0V32( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000V12 */
                  pr_default.execute(10, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Scheme") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)),  "药物治疗",  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  "Delete",  1) ;
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
         sMode32 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0V32( ) ;
         Gx_mode = sMode32;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0V32( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Medication_Scheme";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            edtavVline_Visible = ((StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它") == 0 ) ) )
            {
               cellVline_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它") == 0 )
               {
                  cellVline_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
               }
            }
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000V13 */
            pr_default.execute(11, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T31"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel0V32( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0V32( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("br_medication_scheme",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0V0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("br_medication_scheme",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0V32( )
      {
         /* Scan By routine */
         /* Using cursor T000V14 */
         pr_default.execute(12);
         RcdFound32 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound32 = 1;
            A296BR_Medication_SchemeID = T000V14_A296BR_Medication_SchemeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
            n296BR_Medication_SchemeID = T000V14_n296BR_Medication_SchemeID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0V32( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound32 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound32 = 1;
            A296BR_Medication_SchemeID = T000V14_A296BR_Medication_SchemeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
            n296BR_Medication_SchemeID = T000V14_n296BR_Medication_SchemeID[0];
         }
      }

      protected void ScanEnd0V32( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm0V32( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0V32( )
      {
         /* Before Insert Rules */
         if ( StringUtil.StrCmp(A307BR_Medication_Chem_Line, "其它") == 0 )
         {
            A307BR_Medication_Chem_Line = AV15vLine;
            n307BR_Medication_Chem_Line = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307BR_Medication_Chem_Line", A307BR_Medication_Chem_Line);
         }
      }

      protected void BeforeUpdate0V32( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0V32( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0V32( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0V32( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0V32( )
      {
         edtBR_Medication_Chem_Name_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Name_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_Chem_Name_Enabled), 5, 0)), true);
         edtBR_Medication_Chem_Cycle_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Cycle_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_Chem_Cycle_Enabled), 5, 0)), true);
         dynBR_Medication_Chem_Line.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_Chem_Line_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Medication_Chem_Line.Enabled), 5, 0)), true);
         edtavVline_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Enabled), 5, 0)), true);
         edtBR_Medication_Chem_Detail_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Detail_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_Chem_Detail_Enabled), 5, 0)), true);
         edtBR_Medication_SchemeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_SchemeID_Enabled), 5, 0)), true);
         edtBR_MedicationID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0V32( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0V0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202281581393", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medication_scheme.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Medication_SchemeID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Medication_Scheme";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_medication_scheme:[SendSecurityCheck value for]"+"BR_Medication_SchemeID:"+context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_medication_scheme:[SendSecurityCheck value for]"+"Insert_BR_MedicationID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_medication_scheme:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z296BR_Medication_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z305BR_Medication_Chem_Name", Z305BR_Medication_Chem_Name);
         GxWebStd.gx_hidden_field( context, "Z306BR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.NToC( Z306BR_Medication_Chem_Cycle, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z307BR_Medication_Chem_Line", Z307BR_Medication_Chem_Line);
         GxWebStd.gx_hidden_field( context, "Z313BR_Medication_Chem_Detail", Z313BR_Medication_Chem_Detail);
         GxWebStd.gx_hidden_field( context, "Z119BR_MedicationID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z119BR_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N119BR_MedicationID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_MEDICATION_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_Medication_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_MEDICATION_SCHEMEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_BR_MedicationID), 18, 0, ".", "")));
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
         return formatLink("br_medication_scheme.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Medication_SchemeID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Medication_Scheme" ;
      }

      public override String GetPgmdesc( )
      {
         return "药物治疗化疗方案0813弃用" ;
      }

      protected void InitializeNonKey0V32( )
      {
         A119BR_MedicationID = 0;
         n119BR_MedicationID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
         n119BR_MedicationID = ((0==A119BR_MedicationID) ? true : false);
         AV15vLine = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vLine", AV15vLine);
         A305BR_Medication_Chem_Name = "";
         n305BR_Medication_Chem_Name = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A305BR_Medication_Chem_Name", A305BR_Medication_Chem_Name);
         n305BR_Medication_Chem_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A305BR_Medication_Chem_Name)) ? true : false);
         A306BR_Medication_Chem_Cycle = 0;
         n306BR_Medication_Chem_Cycle = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306BR_Medication_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A306BR_Medication_Chem_Cycle, 15, 5)));
         n306BR_Medication_Chem_Cycle = ((Convert.ToDecimal(0)==A306BR_Medication_Chem_Cycle) ? true : false);
         A307BR_Medication_Chem_Line = "";
         n307BR_Medication_Chem_Line = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A307BR_Medication_Chem_Line", A307BR_Medication_Chem_Line);
         n307BR_Medication_Chem_Line = (String.IsNullOrEmpty(StringUtil.RTrim( A307BR_Medication_Chem_Line)) ? true : false);
         A313BR_Medication_Chem_Detail = "";
         n313BR_Medication_Chem_Detail = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313BR_Medication_Chem_Detail", A313BR_Medication_Chem_Detail);
         n313BR_Medication_Chem_Detail = (String.IsNullOrEmpty(StringUtil.RTrim( A313BR_Medication_Chem_Detail)) ? true : false);
         Z305BR_Medication_Chem_Name = "";
         Z306BR_Medication_Chem_Cycle = 0;
         Z307BR_Medication_Chem_Line = "";
         Z313BR_Medication_Chem_Detail = "";
         Z119BR_MedicationID = 0;
      }

      protected void InitAll0V32( )
      {
         A296BR_Medication_SchemeID = 0;
         n296BR_Medication_SchemeID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
         InitializeNonKey0V32( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281581414", true);
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
         context.AddJavascriptSource("br_medication_scheme.js", "?20202281581414", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtBR_Medication_Chem_Name_Internalname = "BR_MEDICATION_CHEM_NAME";
         edtBR_Medication_Chem_Cycle_Internalname = "BR_MEDICATION_CHEM_CYCLE";
         lblTextblockbr_medication_chem_line_Internalname = "TEXTBLOCKBR_MEDICATION_CHEM_LINE";
         dynBR_Medication_Chem_Line_Internalname = "BR_MEDICATION_CHEM_LINE";
         edtavVline_Internalname = "vVLINE";
         cellVline_cell_Internalname = "VLINE_CELL";
         tblTablemergedbr_medication_chem_line_Internalname = "TABLEMERGEDBR_MEDICATION_CHEM_LINE";
         divTablesplittedbr_medication_chem_line_Internalname = "TABLESPLITTEDBR_MEDICATION_CHEM_LINE";
         lblTextblockbr_medication_chem_detail_Internalname = "TEXTBLOCKBR_MEDICATION_CHEM_DETAIL";
         edtBR_Medication_Chem_Detail_Internalname = "BR_MEDICATION_CHEM_DETAIL";
         divUnnamedtablebr_medication_chem_detail_Internalname = "UNNAMEDTABLEBR_MEDICATION_CHEM_DETAIL";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID";
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID";
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
         Form.Caption = "药物治疗化疗方案0813弃用";
         edtavVline_Jsonclick = "";
         edtavVline_Enabled = 1;
         edtavVline_Visible = 1;
         cellVline_cell_Class = "";
         dynBR_Medication_Chem_Line_Jsonclick = "";
         dynBR_Medication_Chem_Line.Enabled = 1;
         edtBR_MedicationID_Jsonclick = "";
         edtBR_MedicationID_Enabled = 1;
         edtBR_MedicationID_Visible = 1;
         edtBR_Medication_SchemeID_Jsonclick = "";
         edtBR_Medication_SchemeID_Enabled = 0;
         edtBR_Medication_SchemeID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Medication_Chem_Detail_Jsonclick = "";
         edtBR_Medication_Chem_Detail_Enabled = 1;
         edtBR_Medication_Chem_Cycle_Jsonclick = "";
         edtBR_Medication_Chem_Cycle_Enabled = 1;
         edtBR_Medication_Chem_Name_Jsonclick = "";
         edtBR_Medication_Chem_Name_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "药物治疗化疗方案";
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

      protected void GXDLABR_MEDICATION_CHEM_LINE0V32( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_MEDICATION_CHEM_LINE_data0V32( ) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXABR_MEDICATION_CHEM_LINE_html0V32( )
      {
         String gxdynajaxvalue ;
         GXDLABR_MEDICATION_CHEM_LINE_data0V32( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Medication_Chem_Line.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Medication_Chem_Line.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_MEDICATION_CHEM_LINE_data0V32( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000V15 */
         pr_default.execute(13);
         while ( (pr_default.getStatus(13) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000V15_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000V15_A168XT_DefineCodeName[0]);
            pr_default.readNext(13);
         }
         pr_default.close(13);
      }

      protected void XC_14_0V32( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)),  "药物治疗",  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  "Create",  1) ;
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

      protected void XC_15_0V32( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)),  "药物治疗",  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  "Delete",  1) ;
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
         dynBR_Medication_Chem_Line.Name = "BR_MEDICATION_CHEM_LINE";
         dynBR_Medication_Chem_Line.WebTags = "";
         /* End function init_web_controls */
      }

      public void Valid_Br_medicationid( long GX_Parm1 )
      {
         A119BR_MedicationID = GX_Parm1;
         n119BR_MedicationID = false;
         /* Using cursor T000V16 */
         pr_default.execute(14, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            if ( ! ( (0==A119BR_MedicationID) ) )
            {
               GX_msglist.addItem("不匹配' T18'", "ForeignKeyNotFound", 1, "BR_MEDICATIONID");
               AnyError = 1;
               GX_FocusControl = edtBR_MedicationID_Internalname;
            }
         }
         pr_default.close(14);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Medication_SchemeID',fld:'vBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'dynBR_Medication_Chem_Line'},{av:'A307BR_Medication_Chem_Line',fld:'BR_MEDICATION_CHEM_LINE',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'dynBR_Medication_Chem_Line'},{av:'A307BR_Medication_Chem_Line',fld:'BR_MEDICATION_CHEM_LINE',pic:''}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Medication_SchemeID',fld:'vBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A296BR_Medication_SchemeID',fld:'BR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_BR_MedicationID',fld:'vINSERT_BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'dynBR_Medication_Chem_Line'},{av:'A307BR_Medication_Chem_Line',fld:'BR_MEDICATION_CHEM_LINE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dynBR_Medication_Chem_Line'},{av:'A307BR_Medication_Chem_Line',fld:'BR_MEDICATION_CHEM_LINE',pic:''}]}");
         setEventMetadata("AFTER TRN","{handler:'E120V2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'A296BR_Medication_SchemeID',fld:'BR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A119BR_MedicationID',fld:'BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'dynBR_Medication_Chem_Line'},{av:'A307BR_Medication_Chem_Line',fld:'BR_MEDICATION_CHEM_LINE',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[{av:'dynBR_Medication_Chem_Line'},{av:'A307BR_Medication_Chem_Line',fld:'BR_MEDICATION_CHEM_LINE',pic:''}]}");
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
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z305BR_Medication_Chem_Name = "";
         Z307BR_Medication_Chem_Line = "";
         Z313BR_Medication_Chem_Detail = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A307BR_Medication_Chem_Line = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         A305BR_Medication_Chem_Name = "";
         lblTextblockbr_medication_chem_line_Jsonclick = "";
         lblTextblockbr_medication_chem_detail_Jsonclick = "";
         A313BR_Medication_Chem_Detail = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         sStyleString = "";
         AV15vLine = "";
         AV16Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode32 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         T000V5_A296BR_Medication_SchemeID = new long[1] ;
         T000V5_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000V5_A305BR_Medication_Chem_Name = new String[] {""} ;
         T000V5_n305BR_Medication_Chem_Name = new bool[] {false} ;
         T000V5_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         T000V5_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         T000V5_A307BR_Medication_Chem_Line = new String[] {""} ;
         T000V5_n307BR_Medication_Chem_Line = new bool[] {false} ;
         T000V5_A313BR_Medication_Chem_Detail = new String[] {""} ;
         T000V5_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         T000V5_A119BR_MedicationID = new long[1] ;
         T000V5_n119BR_MedicationID = new bool[] {false} ;
         T000V4_A119BR_MedicationID = new long[1] ;
         T000V4_n119BR_MedicationID = new bool[] {false} ;
         T000V6_A119BR_MedicationID = new long[1] ;
         T000V6_n119BR_MedicationID = new bool[] {false} ;
         T000V7_A296BR_Medication_SchemeID = new long[1] ;
         T000V7_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000V3_A296BR_Medication_SchemeID = new long[1] ;
         T000V3_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000V3_A305BR_Medication_Chem_Name = new String[] {""} ;
         T000V3_n305BR_Medication_Chem_Name = new bool[] {false} ;
         T000V3_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         T000V3_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         T000V3_A307BR_Medication_Chem_Line = new String[] {""} ;
         T000V3_n307BR_Medication_Chem_Line = new bool[] {false} ;
         T000V3_A313BR_Medication_Chem_Detail = new String[] {""} ;
         T000V3_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         T000V3_A119BR_MedicationID = new long[1] ;
         T000V3_n119BR_MedicationID = new bool[] {false} ;
         T000V8_A296BR_Medication_SchemeID = new long[1] ;
         T000V8_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000V9_A296BR_Medication_SchemeID = new long[1] ;
         T000V9_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000V2_A296BR_Medication_SchemeID = new long[1] ;
         T000V2_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000V2_A305BR_Medication_Chem_Name = new String[] {""} ;
         T000V2_n305BR_Medication_Chem_Name = new bool[] {false} ;
         T000V2_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         T000V2_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         T000V2_A307BR_Medication_Chem_Line = new String[] {""} ;
         T000V2_n307BR_Medication_Chem_Line = new bool[] {false} ;
         T000V2_A313BR_Medication_Chem_Detail = new String[] {""} ;
         T000V2_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         T000V2_A119BR_MedicationID = new long[1] ;
         T000V2_n119BR_MedicationID = new bool[] {false} ;
         T000V10_A296BR_Medication_SchemeID = new long[1] ;
         T000V10_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000V13_A301BR_Medication_DetailID = new long[1] ;
         T000V14_A296BR_Medication_SchemeID = new long[1] ;
         T000V14_n296BR_Medication_SchemeID = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000V15_A167XT_DefineCodeID = new long[1] ;
         T000V15_A168XT_DefineCodeName = new String[] {""} ;
         T000V15_n168XT_DefineCodeName = new bool[] {false} ;
         T000V15_A165XT_DefindcodeTypeID = new long[1] ;
         T000V16_A119BR_MedicationID = new long[1] ;
         T000V16_n119BR_MedicationID = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medication_scheme__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_scheme__default(),
            new Object[][] {
                new Object[] {
               T000V2_A296BR_Medication_SchemeID, T000V2_A305BR_Medication_Chem_Name, T000V2_n305BR_Medication_Chem_Name, T000V2_A306BR_Medication_Chem_Cycle, T000V2_n306BR_Medication_Chem_Cycle, T000V2_A307BR_Medication_Chem_Line, T000V2_n307BR_Medication_Chem_Line, T000V2_A313BR_Medication_Chem_Detail, T000V2_n313BR_Medication_Chem_Detail, T000V2_A119BR_MedicationID,
               T000V2_n119BR_MedicationID
               }
               , new Object[] {
               T000V3_A296BR_Medication_SchemeID, T000V3_A305BR_Medication_Chem_Name, T000V3_n305BR_Medication_Chem_Name, T000V3_A306BR_Medication_Chem_Cycle, T000V3_n306BR_Medication_Chem_Cycle, T000V3_A307BR_Medication_Chem_Line, T000V3_n307BR_Medication_Chem_Line, T000V3_A313BR_Medication_Chem_Detail, T000V3_n313BR_Medication_Chem_Detail, T000V3_A119BR_MedicationID,
               T000V3_n119BR_MedicationID
               }
               , new Object[] {
               T000V4_A119BR_MedicationID
               }
               , new Object[] {
               T000V5_A296BR_Medication_SchemeID, T000V5_A305BR_Medication_Chem_Name, T000V5_n305BR_Medication_Chem_Name, T000V5_A306BR_Medication_Chem_Cycle, T000V5_n306BR_Medication_Chem_Cycle, T000V5_A307BR_Medication_Chem_Line, T000V5_n307BR_Medication_Chem_Line, T000V5_A313BR_Medication_Chem_Detail, T000V5_n313BR_Medication_Chem_Detail, T000V5_A119BR_MedicationID,
               T000V5_n119BR_MedicationID
               }
               , new Object[] {
               T000V6_A119BR_MedicationID
               }
               , new Object[] {
               T000V7_A296BR_Medication_SchemeID
               }
               , new Object[] {
               T000V8_A296BR_Medication_SchemeID
               }
               , new Object[] {
               T000V9_A296BR_Medication_SchemeID
               }
               , new Object[] {
               T000V10_A296BR_Medication_SchemeID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000V13_A301BR_Medication_DetailID
               }
               , new Object[] {
               T000V14_A296BR_Medication_SchemeID
               }
               , new Object[] {
               T000V15_A167XT_DefineCodeID, T000V15_A168XT_DefineCodeName, T000V15_n168XT_DefineCodeName, T000V15_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               T000V16_A119BR_MedicationID
               }
            }
         );
         AV16Pgmname = "BR_Medication_Scheme";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound32 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Medication_Chem_Name_Enabled ;
      private int edtBR_Medication_Chem_Cycle_Enabled ;
      private int edtBR_Medication_Chem_Detail_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_Medication_SchemeID_Enabled ;
      private int edtBR_Medication_SchemeID_Visible ;
      private int edtBR_MedicationID_Visible ;
      private int edtBR_MedicationID_Enabled ;
      private int edtavVline_Visible ;
      private int edtavVline_Enabled ;
      private int AV17GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV7BR_Medication_SchemeID ;
      private long Z296BR_Medication_SchemeID ;
      private long Z119BR_MedicationID ;
      private long N119BR_MedicationID ;
      private long A119BR_MedicationID ;
      private long AV7BR_Medication_SchemeID ;
      private long A296BR_Medication_SchemeID ;
      private long AV13Insert_BR_MedicationID ;
      private decimal Z306BR_Medication_Chem_Cycle ;
      private decimal A306BR_Medication_Chem_Cycle ;
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
      private String edtBR_Medication_Chem_Name_Internalname ;
      private String dynBR_Medication_Chem_Line_Internalname ;
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
      private String TempTags ;
      private String edtBR_Medication_Chem_Name_Jsonclick ;
      private String edtBR_Medication_Chem_Cycle_Internalname ;
      private String edtBR_Medication_Chem_Cycle_Jsonclick ;
      private String divTablesplittedbr_medication_chem_line_Internalname ;
      private String lblTextblockbr_medication_chem_line_Internalname ;
      private String lblTextblockbr_medication_chem_line_Jsonclick ;
      private String divUnnamedtablebr_medication_chem_detail_Internalname ;
      private String lblTextblockbr_medication_chem_detail_Internalname ;
      private String lblTextblockbr_medication_chem_detail_Jsonclick ;
      private String edtBR_Medication_Chem_Detail_Internalname ;
      private String edtBR_Medication_Chem_Detail_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Medication_SchemeID_Internalname ;
      private String edtBR_Medication_SchemeID_Jsonclick ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_MedicationID_Jsonclick ;
      private String sStyleString ;
      private String tblTablemergedbr_medication_chem_line_Internalname ;
      private String dynBR_Medication_Chem_Line_Jsonclick ;
      private String cellVline_cell_Internalname ;
      private String cellVline_cell_Class ;
      private String edtavVline_Internalname ;
      private String edtavVline_Jsonclick ;
      private String AV16Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode32 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private bool entryPointCalled ;
      private bool n119BR_MedicationID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n307BR_Medication_Chem_Line ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n305BR_Medication_Chem_Name ;
      private bool n306BR_Medication_Chem_Cycle ;
      private bool n313BR_Medication_Chem_Detail ;
      private bool n296BR_Medication_SchemeID ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool gxdyncontrolsrefreshing ;
      private String Z305BR_Medication_Chem_Name ;
      private String Z307BR_Medication_Chem_Line ;
      private String Z313BR_Medication_Chem_Detail ;
      private String A307BR_Medication_Chem_Line ;
      private String A305BR_Medication_Chem_Name ;
      private String A313BR_Medication_Chem_Detail ;
      private String AV15vLine ;
      private IGxSession AV12WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_Medication_Chem_Line ;
      private IDataStoreProvider pr_default ;
      private long[] T000V5_A296BR_Medication_SchemeID ;
      private bool[] T000V5_n296BR_Medication_SchemeID ;
      private String[] T000V5_A305BR_Medication_Chem_Name ;
      private bool[] T000V5_n305BR_Medication_Chem_Name ;
      private decimal[] T000V5_A306BR_Medication_Chem_Cycle ;
      private bool[] T000V5_n306BR_Medication_Chem_Cycle ;
      private String[] T000V5_A307BR_Medication_Chem_Line ;
      private bool[] T000V5_n307BR_Medication_Chem_Line ;
      private String[] T000V5_A313BR_Medication_Chem_Detail ;
      private bool[] T000V5_n313BR_Medication_Chem_Detail ;
      private long[] T000V5_A119BR_MedicationID ;
      private bool[] T000V5_n119BR_MedicationID ;
      private long[] T000V4_A119BR_MedicationID ;
      private bool[] T000V4_n119BR_MedicationID ;
      private long[] T000V6_A119BR_MedicationID ;
      private bool[] T000V6_n119BR_MedicationID ;
      private long[] T000V7_A296BR_Medication_SchemeID ;
      private bool[] T000V7_n296BR_Medication_SchemeID ;
      private long[] T000V3_A296BR_Medication_SchemeID ;
      private bool[] T000V3_n296BR_Medication_SchemeID ;
      private String[] T000V3_A305BR_Medication_Chem_Name ;
      private bool[] T000V3_n305BR_Medication_Chem_Name ;
      private decimal[] T000V3_A306BR_Medication_Chem_Cycle ;
      private bool[] T000V3_n306BR_Medication_Chem_Cycle ;
      private String[] T000V3_A307BR_Medication_Chem_Line ;
      private bool[] T000V3_n307BR_Medication_Chem_Line ;
      private String[] T000V3_A313BR_Medication_Chem_Detail ;
      private bool[] T000V3_n313BR_Medication_Chem_Detail ;
      private long[] T000V3_A119BR_MedicationID ;
      private bool[] T000V3_n119BR_MedicationID ;
      private long[] T000V8_A296BR_Medication_SchemeID ;
      private bool[] T000V8_n296BR_Medication_SchemeID ;
      private long[] T000V9_A296BR_Medication_SchemeID ;
      private bool[] T000V9_n296BR_Medication_SchemeID ;
      private long[] T000V2_A296BR_Medication_SchemeID ;
      private bool[] T000V2_n296BR_Medication_SchemeID ;
      private String[] T000V2_A305BR_Medication_Chem_Name ;
      private bool[] T000V2_n305BR_Medication_Chem_Name ;
      private decimal[] T000V2_A306BR_Medication_Chem_Cycle ;
      private bool[] T000V2_n306BR_Medication_Chem_Cycle ;
      private String[] T000V2_A307BR_Medication_Chem_Line ;
      private bool[] T000V2_n307BR_Medication_Chem_Line ;
      private String[] T000V2_A313BR_Medication_Chem_Detail ;
      private bool[] T000V2_n313BR_Medication_Chem_Detail ;
      private long[] T000V2_A119BR_MedicationID ;
      private bool[] T000V2_n119BR_MedicationID ;
      private long[] T000V10_A296BR_Medication_SchemeID ;
      private bool[] T000V10_n296BR_Medication_SchemeID ;
      private long[] T000V13_A301BR_Medication_DetailID ;
      private long[] T000V14_A296BR_Medication_SchemeID ;
      private bool[] T000V14_n296BR_Medication_SchemeID ;
      private long[] T000V15_A167XT_DefineCodeID ;
      private String[] T000V15_A168XT_DefineCodeName ;
      private bool[] T000V15_n168XT_DefineCodeName ;
      private long[] T000V15_A165XT_DefindcodeTypeID ;
      private long[] T000V16_A119BR_MedicationID ;
      private bool[] T000V16_n119BR_MedicationID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_medication_scheme__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_medication_scheme__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000V5 ;
        prmT000V5 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V4 ;
        prmT000V4 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V6 ;
        prmT000V6 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V7 ;
        prmT000V7 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V3 ;
        prmT000V3 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V8 ;
        prmT000V8 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V9 ;
        prmT000V9 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V2 ;
        prmT000V2 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V10 ;
        prmT000V10 = new Object[] {
        new Object[] {"@BR_Medication_Chem_Name",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_Chem_Cycle",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_Chem_Line",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_Chem_Detail",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V11 ;
        prmT000V11 = new Object[] {
        new Object[] {"@BR_Medication_Chem_Name",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_Chem_Cycle",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_Chem_Line",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_Chem_Detail",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V12 ;
        prmT000V12 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V13 ;
        prmT000V13 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000V14 ;
        prmT000V14 = new Object[] {
        } ;
        Object[] prmT000V15 ;
        prmT000V15 = new Object[] {
        } ;
        Object[] prmT000V16 ;
        prmT000V16 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000V2", "SELECT [BR_Medication_SchemeID], [BR_Medication_Chem_Name], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Line], [BR_Medication_Chem_Detail], [BR_MedicationID] FROM [BR_Medication_Scheme] WITH (UPDLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V2,1,0,true,false )
           ,new CursorDef("T000V3", "SELECT [BR_Medication_SchemeID], [BR_Medication_Chem_Name], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Line], [BR_Medication_Chem_Detail], [BR_MedicationID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V3,1,0,true,false )
           ,new CursorDef("T000V4", "SELECT [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V4,1,0,true,false )
           ,new CursorDef("T000V5", "SELECT TM1.[BR_Medication_SchemeID], TM1.[BR_Medication_Chem_Name], TM1.[BR_Medication_Chem_Cycle], TM1.[BR_Medication_Chem_Line], TM1.[BR_Medication_Chem_Detail], TM1.[BR_MedicationID] FROM [BR_Medication_Scheme] TM1 WITH (NOLOCK) WHERE TM1.[BR_Medication_SchemeID] = @BR_Medication_SchemeID ORDER BY TM1.[BR_Medication_SchemeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V5,100,0,true,false )
           ,new CursorDef("T000V6", "SELECT [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V6,1,0,true,false )
           ,new CursorDef("T000V7", "SELECT [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V7,1,0,true,false )
           ,new CursorDef("T000V8", "SELECT TOP 1 [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE ( [BR_Medication_SchemeID] > @BR_Medication_SchemeID) ORDER BY [BR_Medication_SchemeID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V8,1,0,true,true )
           ,new CursorDef("T000V9", "SELECT TOP 1 [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE ( [BR_Medication_SchemeID] < @BR_Medication_SchemeID) ORDER BY [BR_Medication_SchemeID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V9,1,0,true,true )
           ,new CursorDef("T000V10", "INSERT INTO [BR_Medication_Scheme]([BR_Medication_Chem_Name], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Line], [BR_Medication_Chem_Detail], [BR_MedicationID]) VALUES(@BR_Medication_Chem_Name, @BR_Medication_Chem_Cycle, @BR_Medication_Chem_Line, @BR_Medication_Chem_Detail, @BR_MedicationID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000V10)
           ,new CursorDef("T000V11", "UPDATE [BR_Medication_Scheme] SET [BR_Medication_Chem_Name]=@BR_Medication_Chem_Name, [BR_Medication_Chem_Cycle]=@BR_Medication_Chem_Cycle, [BR_Medication_Chem_Line]=@BR_Medication_Chem_Line, [BR_Medication_Chem_Detail]=@BR_Medication_Chem_Detail, [BR_MedicationID]=@BR_MedicationID  WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID", GxErrorMask.GX_NOMASK,prmT000V11)
           ,new CursorDef("T000V12", "DELETE FROM [BR_Medication_Scheme]  WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID", GxErrorMask.GX_NOMASK,prmT000V12)
           ,new CursorDef("T000V13", "SELECT TOP 1 [BR_Medication_DetailID] FROM [BR_Medication_Detail] WITH (NOLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V13,1,0,true,true )
           ,new CursorDef("T000V14", "SELECT [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) ORDER BY [BR_Medication_SchemeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V14,100,0,true,false )
           ,new CursorDef("T000V15", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = 27 ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V15,0,0,true,false )
           ,new CursorDef("T000V16", "SELECT [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V16,1,0,true,false )
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
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
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
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              return;
           case 14 :
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 1 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 6 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 7 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (decimal)parms[3]);
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
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[9]);
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
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (decimal)parms[3]);
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
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[9]);
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
           case 10 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 11 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 14 :
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
