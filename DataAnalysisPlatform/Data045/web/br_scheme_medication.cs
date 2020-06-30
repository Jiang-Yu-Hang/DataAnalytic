/*
               File: BR_Scheme_Medication
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:42.8
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
   public class br_scheme_medication : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            XC_14_1340( ) ;
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
            XC_15_1340( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action16") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_16_1340( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_18") == 0 )
         {
            A327BR_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n327BR_SchemeID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_18( A327BR_SchemeID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_19") == 0 )
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
            gxLoad_19( A119BR_MedicationID) ;
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
               AV7BR_Scheme_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_Scheme_MedicationID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_SCHEME_MEDICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         GX_FocusControl = edtBR_MedicationID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_scheme_medication( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_scheme_medication( IGxContext context )
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
                           long aP1_BR_Scheme_MedicationID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_Scheme_MedicationID = aP1_BR_Scheme_MedicationID;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_scheme_chem_regimens_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_scheme_chem_regimens_Internalname, "化疗方案", "", "", lblTextblockbr_scheme_chem_regimens_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Scheme_Chem_Regimens_Internalname, "化疗方案", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Scheme_Chem_Regimens_Internalname, A328BR_Scheme_Chem_Regimens, StringUtil.RTrim( context.localUtil.Format( A328BR_Scheme_Chem_Regimens, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Scheme_Chem_Regimens_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Scheme_Chem_Regimens_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicationid_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicationid_Internalname, "药物识别码", "", "", lblTextblockbr_medicationid_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicationID_Internalname, "药物治疗主键", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_MedicationID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicationID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_MedicationID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Scheme_Medication.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_119_Internalname, sImgUrl, imgprompt_119_Link, "", "", context.GetTheme( ), imgprompt_119_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_BR_Scheme_Medication.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVmedicationname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVmedicationname_Internalname, "药物名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavVmedicationname_Internalname, AV19vMedicationName, StringUtil.RTrim( context.localUtil.Format( AV19vMedicationName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVmedicationname_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVmedicationname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVdose_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVdose_Internalname, "药物剂量", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavVdose_Internalname, StringUtil.LTrim( StringUtil.NToC( AV16vDose, 16, 5, ".", "")), ((edtavVdose_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV16vDose, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV16vDose, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVdose_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVdose_Enabled, 0, "text", "", 16, "chr", 1, "row", 16, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medication_rxunit_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medication_rxunit_Internalname, "计量单位", "", "", lblTextblockbr_medication_rxunit_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXUnit_Internalname, "计量单位", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXUnit_Internalname, A125BR_Medication_RXUnit, StringUtil.RTrim( context.localUtil.Format( A125BR_Medication_RXUnit, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXUnit_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_RXUnit_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_Medication.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Scheme_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Scheme_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Scheme_Medication.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Scheme_MedicationID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")), ((edtBR_Scheme_MedicationID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Scheme_MedicationID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Scheme_MedicationID_Visible, edtBR_Scheme_MedicationID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Scheme_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_SchemeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_SchemeID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_SchemeID_Visible, edtBR_SchemeID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Scheme_Medication.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXName_Internalname, A121BR_Medication_RXName, StringUtil.RTrim( context.localUtil.Format( A121BR_Medication_RXName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXName_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Medication_RXName_Visible, edtBR_Medication_RXName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_Medication.htm");
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
         E11132 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A328BR_Scheme_Chem_Regimens = cgiGet( edtBR_Scheme_Chem_Regimens_Internalname);
               n328BR_Scheme_Chem_Regimens = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
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
               AV19vMedicationName = cgiGet( edtavVmedicationname_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vMedicationName", AV19vMedicationName);
               AV16vDose = context.localUtil.CToN( cgiGet( edtavVdose_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vDose", StringUtil.LTrim( StringUtil.Str( AV16vDose, 16, 5)));
               A125BR_Medication_RXUnit = cgiGet( edtBR_Medication_RXUnit_Internalname);
               n125BR_Medication_RXUnit = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
               A332BR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_Scheme_MedicationID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_SchemeID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_SchemeID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_SCHEMEID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_SchemeID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A327BR_SchemeID = 0;
                  n327BR_SchemeID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
               }
               else
               {
                  A327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_SchemeID_Internalname), ".", ","));
                  n327BR_SchemeID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
               }
               n327BR_SchemeID = ((0==A327BR_SchemeID) ? true : false);
               A121BR_Medication_RXName = cgiGet( edtBR_Medication_RXName_Internalname);
               n121BR_Medication_RXName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
               /* Read saved values. */
               Z332BR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( "Z332BR_Scheme_MedicationID"), ".", ","));
               Z327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( "Z327BR_SchemeID"), ".", ","));
               n327BR_SchemeID = ((0==A327BR_SchemeID) ? true : false);
               Z119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( "Z119BR_MedicationID"), ".", ","));
               n119BR_MedicationID = ((0==A119BR_MedicationID) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( "N327BR_SchemeID"), ".", ","));
               n327BR_SchemeID = ((0==A327BR_SchemeID) ? true : false);
               N119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( "N119BR_MedicationID"), ".", ","));
               n119BR_MedicationID = ((0==A119BR_MedicationID) ? true : false);
               AV7BR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( "vBR_SCHEME_MEDICATIONID"), ".", ","));
               AV13Insert_BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_SCHEMEID"), ".", ","));
               AV14Insert_BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_MEDICATIONID"), ".", ","));
               A124BR_Medication_RXDose = context.localUtil.CToN( cgiGet( "BR_MEDICATION_RXDOSE"), ".", ",");
               n124BR_Medication_RXDose = false;
               AV20Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "BR_Scheme_Medication";
               A332BR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_Scheme_MedicationID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV14Insert_BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A332BR_Scheme_MedicationID != Z332BR_Scheme_MedicationID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_scheme_medication:[SecurityCheckFailed value for]"+"BR_Scheme_MedicationID:"+context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_scheme_medication:[SecurityCheckFailed value for]"+"Insert_BR_SchemeID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_scheme_medication:[SecurityCheckFailed value for]"+"Insert_BR_MedicationID:"+context.localUtil.Format( (decimal)(AV14Insert_BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_scheme_medication:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A332BR_Scheme_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
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
                     sMode40 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode40;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound40 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_130( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_SCHEME_MEDICATIONID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_Scheme_MedicationID_Internalname;
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
                           E11132 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12132 ();
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
            E12132 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1340( ) ;
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
            DisableAttributes1340( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdose_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdose_Enabled), 5, 0)), true);
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

      protected void CONFIRM_130( )
      {
         BeforeValidate1340( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1340( ) ;
            }
            else
            {
               CheckExtendedTable1340( ) ;
               CloseExtendedTableCursors1340( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption130( )
      {
      }

      protected void E11132( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV20Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV20Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV21GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GXV1), 8, 0)));
            while ( AV21GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV15TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV21GXV1));
               if ( StringUtil.StrCmp(AV15TrnContextAtt.gxTpr_Attributename, "BR_SchemeID") == 0 )
               {
                  AV13Insert_BR_SchemeID = (long)(NumberUtil.Val( AV15TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_BR_SchemeID), 18, 0)));
               }
               else if ( StringUtil.StrCmp(AV15TrnContextAtt.gxTpr_Attributename, "BR_MedicationID") == 0 )
               {
                  AV14Insert_BR_MedicationID = (long)(NumberUtil.Val( AV15TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Insert_BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14Insert_BR_MedicationID), 18, 0)));
               }
               AV21GXV1 = (int)(AV21GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GXV1), 8, 0)));
            }
         }
         edtBR_Scheme_MedicationID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_MedicationID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Scheme_MedicationID_Visible), 5, 0)), true);
         edtBR_SchemeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_SchemeID_Visible), 5, 0)), true);
         edtBR_Medication_RXName_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXName_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_RXName_Visible), 5, 0)), true);
         GXt_boolean1 = AV18TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean1) ;
         AV18TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TempBoolean", AV18TempBoolean);
         if ( ! ( AV18TempBoolean ) )
         {
            bttBtntrn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV18TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean1) ;
         AV18TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TempBoolean", AV18TempBoolean);
         if ( ! ( AV18TempBoolean ) )
         {
            bttBtntrn_cancel_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_cancel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_cancel_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV18TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean1) ;
         AV18TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TempBoolean", AV18TempBoolean);
         if ( ! ( AV18TempBoolean ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         }
      }

      protected void E12132( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_scheme_medicationww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM1340( short GX_JID )
      {
         if ( ( GX_JID == 17 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z327BR_SchemeID = T00133_A327BR_SchemeID[0];
               Z119BR_MedicationID = T00133_A119BR_MedicationID[0];
            }
            else
            {
               Z327BR_SchemeID = A327BR_SchemeID;
               Z119BR_MedicationID = A119BR_MedicationID;
            }
         }
         if ( GX_JID == -17 )
         {
            Z332BR_Scheme_MedicationID = A332BR_Scheme_MedicationID;
            Z327BR_SchemeID = A327BR_SchemeID;
            Z119BR_MedicationID = A119BR_MedicationID;
            Z328BR_Scheme_Chem_Regimens = A328BR_Scheme_Chem_Regimens;
            Z121BR_Medication_RXName = A121BR_Medication_RXName;
            Z124BR_Medication_RXDose = A124BR_Medication_RXDose;
            Z125BR_Medication_RXUnit = A125BR_Medication_RXUnit;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_Scheme_MedicationID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_MedicationID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Scheme_MedicationID_Enabled), 5, 0)), true);
         imgprompt_119_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"br_medicationprompt.aspx"+"',["+"{Ctrl:gx.dom.el('"+"BR_MEDICATIONID"+"'), id:'"+"BR_MEDICATIONID"+"'"+",IOType:'inout'}"+","+"{Ctrl:gx.dom.el('"+"BR_MEDICATION_RXNAME"+"'), id:'"+"BR_MEDICATION_RXNAME"+"'"+",IOType:'inout'}"+","+"{Ctrl:gx.dom.el('"+"vVDOSE"+"'), id:'"+"vVDOSE"+"'"+",IOType:'inout'}"+","+"{Ctrl:gx.dom.el('"+"BR_MEDICATION_RXUNIT"+"'), id:'"+"BR_MEDICATION_RXUNIT"+"'"+",IOType:'inout'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtBR_Scheme_MedicationID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_MedicationID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Scheme_MedicationID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_Scheme_MedicationID) )
         {
            A332BR_Scheme_MedicationID = AV7BR_Scheme_MedicationID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_SchemeID) )
         {
            edtBR_SchemeID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_SchemeID_Enabled), 5, 0)), true);
         }
         else
         {
            edtBR_SchemeID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_SchemeID_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV14Insert_BR_MedicationID) )
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV14Insert_BR_MedicationID) )
         {
            A119BR_MedicationID = AV14Insert_BR_MedicationID;
            n119BR_MedicationID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_SchemeID) )
         {
            A327BR_SchemeID = AV13Insert_BR_SchemeID;
            n327BR_SchemeID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
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
            AV20Pgmname = "BR_Scheme_Medication";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
            /* Using cursor T00135 */
            pr_default.execute(3, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            A121BR_Medication_RXName = T00135_A121BR_Medication_RXName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
            n121BR_Medication_RXName = T00135_n121BR_Medication_RXName[0];
            A124BR_Medication_RXDose = T00135_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = T00135_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = T00135_A125BR_Medication_RXUnit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
            n125BR_Medication_RXUnit = T00135_n125BR_Medication_RXUnit[0];
            pr_default.close(3);
            AV19vMedicationName = A121BR_Medication_RXName;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vMedicationName", AV19vMedicationName);
            AV16vDose = A124BR_Medication_RXDose;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vDose", StringUtil.LTrim( StringUtil.Str( AV16vDose, 16, 5)));
            /* Using cursor T00134 */
            pr_default.execute(2, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
            A328BR_Scheme_Chem_Regimens = T00134_A328BR_Scheme_Chem_Regimens[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
            n328BR_Scheme_Chem_Regimens = T00134_n328BR_Scheme_Chem_Regimens[0];
            pr_default.close(2);
         }
      }

      protected void Load1340( )
      {
         /* Using cursor T00136 */
         pr_default.execute(4, new Object[] {A332BR_Scheme_MedicationID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound40 = 1;
            A328BR_Scheme_Chem_Regimens = T00136_A328BR_Scheme_Chem_Regimens[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
            n328BR_Scheme_Chem_Regimens = T00136_n328BR_Scheme_Chem_Regimens[0];
            A121BR_Medication_RXName = T00136_A121BR_Medication_RXName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
            n121BR_Medication_RXName = T00136_n121BR_Medication_RXName[0];
            A124BR_Medication_RXDose = T00136_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = T00136_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = T00136_A125BR_Medication_RXUnit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
            n125BR_Medication_RXUnit = T00136_n125BR_Medication_RXUnit[0];
            A327BR_SchemeID = T00136_A327BR_SchemeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
            n327BR_SchemeID = T00136_n327BR_SchemeID[0];
            A119BR_MedicationID = T00136_A119BR_MedicationID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
            n119BR_MedicationID = T00136_n119BR_MedicationID[0];
            ZM1340( -17) ;
         }
         pr_default.close(4);
         OnLoadActions1340( ) ;
      }

      protected void OnLoadActions1340( )
      {
         AV20Pgmname = "BR_Scheme_Medication";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
         AV19vMedicationName = A121BR_Medication_RXName;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vMedicationName", AV19vMedicationName);
         AV16vDose = A124BR_Medication_RXDose;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vDose", StringUtil.LTrim( StringUtil.Str( AV16vDose, 16, 5)));
      }

      protected void CheckExtendedTable1340( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV20Pgmname = "BR_Scheme_Medication";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
         /* Using cursor T00134 */
         pr_default.execute(2, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A327BR_SchemeID) ) )
            {
               GX_msglist.addItem("不匹配' T39'", "ForeignKeyNotFound", 1, "BR_SCHEMEID");
               AnyError = 1;
               GX_FocusControl = edtBR_SchemeID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A328BR_Scheme_Chem_Regimens = T00134_A328BR_Scheme_Chem_Regimens[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
         n328BR_Scheme_Chem_Regimens = T00134_n328BR_Scheme_Chem_Regimens[0];
         pr_default.close(2);
         /* Using cursor T00135 */
         pr_default.execute(3, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A119BR_MedicationID) ) )
            {
               GX_msglist.addItem("不匹配' T18'", "ForeignKeyNotFound", 1, "BR_MEDICATIONID");
               AnyError = 1;
               GX_FocusControl = edtBR_MedicationID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A121BR_Medication_RXName = T00135_A121BR_Medication_RXName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
         n121BR_Medication_RXName = T00135_n121BR_Medication_RXName[0];
         A124BR_Medication_RXDose = T00135_A124BR_Medication_RXDose[0];
         n124BR_Medication_RXDose = T00135_n124BR_Medication_RXDose[0];
         A125BR_Medication_RXUnit = T00135_A125BR_Medication_RXUnit[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
         n125BR_Medication_RXUnit = T00135_n125BR_Medication_RXUnit[0];
         pr_default.close(3);
         AV19vMedicationName = A121BR_Medication_RXName;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vMedicationName", AV19vMedicationName);
         AV16vDose = A124BR_Medication_RXDose;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vDose", StringUtil.LTrim( StringUtil.Str( AV16vDose, 16, 5)));
         if ( (0==A119BR_MedicationID) )
         {
            GX_msglist.addItem("药物是必须选择的", 1, "BR_MEDICATIONID");
            AnyError = 1;
            GX_FocusControl = edtBR_MedicationID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1340( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_18( long A327BR_SchemeID )
      {
         /* Using cursor T00137 */
         pr_default.execute(5, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            if ( ! ( (0==A327BR_SchemeID) ) )
            {
               GX_msglist.addItem("不匹配' T39'", "ForeignKeyNotFound", 1, "BR_SCHEMEID");
               AnyError = 1;
               GX_FocusControl = edtBR_SchemeID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A328BR_Scheme_Chem_Regimens = T00137_A328BR_Scheme_Chem_Regimens[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
         n328BR_Scheme_Chem_Regimens = T00137_n328BR_Scheme_Chem_Regimens[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A328BR_Scheme_Chem_Regimens)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void gxLoad_19( long A119BR_MedicationID )
      {
         /* Using cursor T00138 */
         pr_default.execute(6, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A119BR_MedicationID) ) )
            {
               GX_msglist.addItem("不匹配' T18'", "ForeignKeyNotFound", 1, "BR_MEDICATIONID");
               AnyError = 1;
               GX_FocusControl = edtBR_MedicationID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A121BR_Medication_RXName = T00138_A121BR_Medication_RXName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
         n121BR_Medication_RXName = T00138_n121BR_Medication_RXName[0];
         A124BR_Medication_RXDose = T00138_A124BR_Medication_RXDose[0];
         n124BR_Medication_RXDose = T00138_n124BR_Medication_RXDose[0];
         A125BR_Medication_RXUnit = T00138_A125BR_Medication_RXUnit[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
         n125BR_Medication_RXUnit = T00138_n125BR_Medication_RXUnit[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A121BR_Medication_RXName)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( A125BR_Medication_RXUnit)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey1340( )
      {
         /* Using cursor T00139 */
         pr_default.execute(7, new Object[] {A332BR_Scheme_MedicationID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound40 = 1;
         }
         else
         {
            RcdFound40 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00133 */
         pr_default.execute(1, new Object[] {A332BR_Scheme_MedicationID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1340( 17) ;
            RcdFound40 = 1;
            A332BR_Scheme_MedicationID = T00133_A332BR_Scheme_MedicationID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
            A327BR_SchemeID = T00133_A327BR_SchemeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
            n327BR_SchemeID = T00133_n327BR_SchemeID[0];
            A119BR_MedicationID = T00133_A119BR_MedicationID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
            n119BR_MedicationID = T00133_n119BR_MedicationID[0];
            Z332BR_Scheme_MedicationID = A332BR_Scheme_MedicationID;
            sMode40 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1340( ) ;
            if ( AnyError == 1 )
            {
               RcdFound40 = 0;
               InitializeNonKey1340( ) ;
            }
            Gx_mode = sMode40;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound40 = 0;
            InitializeNonKey1340( ) ;
            sMode40 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode40;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1340( ) ;
         if ( RcdFound40 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound40 = 0;
         /* Using cursor T001310 */
         pr_default.execute(8, new Object[] {A332BR_Scheme_MedicationID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T001310_A332BR_Scheme_MedicationID[0] < A332BR_Scheme_MedicationID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T001310_A332BR_Scheme_MedicationID[0] > A332BR_Scheme_MedicationID ) ) )
            {
               A332BR_Scheme_MedicationID = T001310_A332BR_Scheme_MedicationID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
               RcdFound40 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound40 = 0;
         /* Using cursor T001311 */
         pr_default.execute(9, new Object[] {A332BR_Scheme_MedicationID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T001311_A332BR_Scheme_MedicationID[0] > A332BR_Scheme_MedicationID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T001311_A332BR_Scheme_MedicationID[0] < A332BR_Scheme_MedicationID ) ) )
            {
               A332BR_Scheme_MedicationID = T001311_A332BR_Scheme_MedicationID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
               RcdFound40 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1340( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_MedicationID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1340( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound40 == 1 )
            {
               if ( A332BR_Scheme_MedicationID != Z332BR_Scheme_MedicationID )
               {
                  A332BR_Scheme_MedicationID = Z332BR_Scheme_MedicationID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_SCHEME_MEDICATIONID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Scheme_MedicationID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_MedicationID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update1340( ) ;
                  GX_FocusControl = edtBR_MedicationID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A332BR_Scheme_MedicationID != Z332BR_Scheme_MedicationID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_MedicationID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1340( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_SCHEME_MEDICATIONID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_Scheme_MedicationID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_MedicationID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1340( ) ;
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
         if ( A332BR_Scheme_MedicationID != Z332BR_Scheme_MedicationID )
         {
            A332BR_Scheme_MedicationID = Z332BR_Scheme_MedicationID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_SCHEME_MEDICATIONID");
            AnyError = 1;
            GX_FocusControl = edtBR_Scheme_MedicationID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_MedicationID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1340( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00132 */
            pr_default.execute(0, new Object[] {A332BR_Scheme_MedicationID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Scheme_Medication"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z327BR_SchemeID != T00132_A327BR_SchemeID[0] ) || ( Z119BR_MedicationID != T00132_A119BR_MedicationID[0] ) )
            {
               if ( Z327BR_SchemeID != T00132_A327BR_SchemeID[0] )
               {
                  GXUtil.WriteLog("br_scheme_medication:[seudo value changed for attri]"+"BR_SchemeID");
                  GXUtil.WriteLogRaw("Old: ",Z327BR_SchemeID);
                  GXUtil.WriteLogRaw("Current: ",T00132_A327BR_SchemeID[0]);
               }
               if ( Z119BR_MedicationID != T00132_A119BR_MedicationID[0] )
               {
                  GXUtil.WriteLog("br_scheme_medication:[seudo value changed for attri]"+"BR_MedicationID");
                  GXUtil.WriteLogRaw("Old: ",Z119BR_MedicationID);
                  GXUtil.WriteLogRaw("Current: ",T00132_A119BR_MedicationID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Scheme_Medication"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1340( )
      {
         BeforeValidate1340( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1340( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1340( 0) ;
            CheckOptimisticConcurrency1340( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1340( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1340( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001312 */
                     pr_default.execute(10, new Object[] {n327BR_SchemeID, A327BR_SchemeID, n119BR_MedicationID, A119BR_MedicationID});
                     A332BR_Scheme_MedicationID = T001312_A332BR_Scheme_MedicationID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme_Medication") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)),  "药物详情",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption130( ) ;
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
               Load1340( ) ;
            }
            EndLevel1340( ) ;
         }
         CloseExtendedTableCursors1340( ) ;
      }

      protected void Update1340( )
      {
         BeforeValidate1340( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1340( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1340( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1340( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1340( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001313 */
                     pr_default.execute(11, new Object[] {n327BR_SchemeID, A327BR_SchemeID, n119BR_MedicationID, A119BR_MedicationID, A332BR_Scheme_MedicationID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme_Medication") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Scheme_Medication"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1340( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)),  "药物详情",  "Update",  1) ;
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
            EndLevel1340( ) ;
         }
         CloseExtendedTableCursors1340( ) ;
      }

      protected void DeferredUpdate1340( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1340( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1340( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1340( ) ;
            AfterConfirm1340( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1340( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001314 */
                  pr_default.execute(12, new Object[] {A332BR_Scheme_MedicationID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme_Medication") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)),  "药物详情",  "Delete",  1) ;
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
         sMode40 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1340( ) ;
         Gx_mode = sMode40;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1340( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV20Pgmname = "BR_Scheme_Medication";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
            /* Using cursor T001315 */
            pr_default.execute(13, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
            A328BR_Scheme_Chem_Regimens = T001315_A328BR_Scheme_Chem_Regimens[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
            n328BR_Scheme_Chem_Regimens = T001315_n328BR_Scheme_Chem_Regimens[0];
            pr_default.close(13);
            /* Using cursor T001316 */
            pr_default.execute(14, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            A121BR_Medication_RXName = T001316_A121BR_Medication_RXName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
            n121BR_Medication_RXName = T001316_n121BR_Medication_RXName[0];
            A124BR_Medication_RXDose = T001316_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = T001316_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = T001316_A125BR_Medication_RXUnit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
            n125BR_Medication_RXUnit = T001316_n125BR_Medication_RXUnit[0];
            pr_default.close(14);
            AV19vMedicationName = A121BR_Medication_RXName;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vMedicationName", AV19vMedicationName);
            AV16vDose = A124BR_Medication_RXDose;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vDose", StringUtil.LTrim( StringUtil.Str( AV16vDose, 16, 5)));
         }
      }

      protected void EndLevel1340( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1340( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_scheme_medication",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues130( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.RollbackDataStores("br_scheme_medication",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1340( )
      {
         /* Scan By routine */
         /* Using cursor T001317 */
         pr_default.execute(15);
         RcdFound40 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound40 = 1;
            A332BR_Scheme_MedicationID = T001317_A332BR_Scheme_MedicationID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1340( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound40 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound40 = 1;
            A332BR_Scheme_MedicationID = T001317_A332BR_Scheme_MedicationID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
         }
      }

      protected void ScanEnd1340( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm1340( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1340( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1340( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1340( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1340( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1340( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1340( )
      {
         edtBR_Scheme_Chem_Regimens_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Regimens_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Scheme_Chem_Regimens_Enabled), 5, 0)), true);
         edtBR_MedicationID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Enabled), 5, 0)), true);
         edtavVmedicationname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Enabled), 5, 0)), true);
         edtavVdose_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdose_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdose_Enabled), 5, 0)), true);
         edtBR_Medication_RXUnit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXUnit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_RXUnit_Enabled), 5, 0)), true);
         edtBR_Scheme_MedicationID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_MedicationID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Scheme_MedicationID_Enabled), 5, 0)), true);
         edtBR_SchemeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_SchemeID_Enabled), 5, 0)), true);
         edtBR_Medication_RXName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_RXName_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1340( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues130( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202281584383", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_scheme_medication.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Scheme_MedicationID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Scheme_Medication";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV14Insert_BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_scheme_medication:[SendSecurityCheck value for]"+"BR_Scheme_MedicationID:"+context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_scheme_medication:[SendSecurityCheck value for]"+"Insert_BR_SchemeID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_scheme_medication:[SendSecurityCheck value for]"+"Insert_BR_MedicationID:"+context.localUtil.Format( (decimal)(AV14Insert_BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_scheme_medication:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z332BR_Scheme_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z327BR_SchemeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z327BR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z119BR_MedicationID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z119BR_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N327BR_SchemeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N119BR_MedicationID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_SCHEME_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_Scheme_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_SCHEME_MEDICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_BR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14Insert_BR_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_RXDOSE", StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV20Pgmname));
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
         return formatLink("br_scheme_medication.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Scheme_MedicationID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Scheme_Medication" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey1340( )
      {
         A327BR_SchemeID = 0;
         n327BR_SchemeID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
         n327BR_SchemeID = ((0==A327BR_SchemeID) ? true : false);
         A119BR_MedicationID = 0;
         n119BR_MedicationID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
         n119BR_MedicationID = ((0==A119BR_MedicationID) ? true : false);
         AV19vMedicationName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vMedicationName", AV19vMedicationName);
         AV16vDose = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vDose", StringUtil.LTrim( StringUtil.Str( AV16vDose, 16, 5)));
         A328BR_Scheme_Chem_Regimens = "";
         n328BR_Scheme_Chem_Regimens = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
         A121BR_Medication_RXName = "";
         n121BR_Medication_RXName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
         A124BR_Medication_RXDose = 0;
         n124BR_Medication_RXDose = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
         A125BR_Medication_RXUnit = "";
         n125BR_Medication_RXUnit = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
         Z327BR_SchemeID = 0;
         Z119BR_MedicationID = 0;
      }

      protected void InitAll1340( )
      {
         A332BR_Scheme_MedicationID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A332BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)));
         InitializeNonKey1340( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228158446", true);
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
         context.AddJavascriptSource("br_scheme_medication.js", "?2020228158446", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_scheme_chem_regimens_Internalname = "TEXTBLOCKBR_SCHEME_CHEM_REGIMENS";
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS";
         divUnnamedtablebr_scheme_chem_regimens_Internalname = "UNNAMEDTABLEBR_SCHEME_CHEM_REGIMENS";
         lblTextblockbr_medicationid_Internalname = "TEXTBLOCKBR_MEDICATIONID";
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID";
         divUnnamedtablebr_medicationid_Internalname = "UNNAMEDTABLEBR_MEDICATIONID";
         edtavVmedicationname_Internalname = "vVMEDICATIONNAME";
         edtavVdose_Internalname = "vVDOSE";
         lblTextblockbr_medication_rxunit_Internalname = "TEXTBLOCKBR_MEDICATION_RXUNIT";
         edtBR_Medication_RXUnit_Internalname = "BR_MEDICATION_RXUNIT";
         divUnnamedtablebr_medication_rxunit_Internalname = "UNNAMEDTABLEBR_MEDICATION_RXUNIT";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_Scheme_MedicationID_Internalname = "BR_SCHEME_MEDICATIONID";
         edtBR_SchemeID_Internalname = "BR_SCHEMEID";
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_119_Internalname = "PROMPT_119";
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
         edtBR_Medication_RXName_Jsonclick = "";
         edtBR_Medication_RXName_Enabled = 0;
         edtBR_Medication_RXName_Visible = 1;
         edtBR_SchemeID_Jsonclick = "";
         edtBR_SchemeID_Enabled = 1;
         edtBR_SchemeID_Visible = 1;
         edtBR_Scheme_MedicationID_Jsonclick = "";
         edtBR_Scheme_MedicationID_Enabled = 0;
         edtBR_Scheme_MedicationID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Medication_RXUnit_Jsonclick = "";
         edtBR_Medication_RXUnit_Enabled = 0;
         edtavVdose_Jsonclick = "";
         edtavVdose_Enabled = 0;
         edtavVmedicationname_Jsonclick = "";
         edtavVmedicationname_Enabled = 0;
         imgprompt_119_Visible = 1;
         imgprompt_119_Link = "";
         edtBR_MedicationID_Jsonclick = "";
         edtBR_MedicationID_Enabled = 1;
         edtBR_Scheme_Chem_Regimens_Jsonclick = "";
         edtBR_Scheme_Chem_Regimens_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "化疗方案药物详情";
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

      protected void XC_14_1340( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)),  "药物详情",  "Create",  1) ;
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

      protected void XC_15_1340( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)),  "药物详情",  "Update",  1) ;
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

      protected void XC_16_1340( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)),  "药物详情",  "Delete",  1) ;
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

      public void Valid_Br_medicationid( long GX_Parm1 ,
                                         String GX_Parm2 ,
                                         decimal GX_Parm3 ,
                                         String GX_Parm4 ,
                                         String GX_Parm5 ,
                                         decimal GX_Parm6 )
      {
         A119BR_MedicationID = GX_Parm1;
         n119BR_MedicationID = false;
         A121BR_Medication_RXName = GX_Parm2;
         n121BR_Medication_RXName = false;
         A124BR_Medication_RXDose = GX_Parm3;
         n124BR_Medication_RXDose = false;
         A125BR_Medication_RXUnit = GX_Parm4;
         n125BR_Medication_RXUnit = false;
         AV19vMedicationName = GX_Parm5;
         AV16vDose = GX_Parm6;
         /* Using cursor T001316 */
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
         A121BR_Medication_RXName = T001316_A121BR_Medication_RXName[0];
         n121BR_Medication_RXName = T001316_n121BR_Medication_RXName[0];
         A124BR_Medication_RXDose = T001316_A124BR_Medication_RXDose[0];
         n124BR_Medication_RXDose = T001316_n124BR_Medication_RXDose[0];
         A125BR_Medication_RXUnit = T001316_A125BR_Medication_RXUnit[0];
         n125BR_Medication_RXUnit = T001316_n125BR_Medication_RXUnit[0];
         pr_default.close(14);
         AV19vMedicationName = A121BR_Medication_RXName;
         AV16vDose = A124BR_Medication_RXDose;
         if ( (0==A119BR_MedicationID) )
         {
            GX_msglist.addItem("药物是必须选择的", 1, "BR_MEDICATIONID");
            AnyError = 1;
            GX_FocusControl = edtBR_MedicationID_Internalname;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A121BR_Medication_RXName = "";
            n121BR_Medication_RXName = false;
            A124BR_Medication_RXDose = 0;
            n124BR_Medication_RXDose = false;
            A125BR_Medication_RXUnit = "";
            n125BR_Medication_RXUnit = false;
         }
         isValidOutput.Add(A121BR_Medication_RXName);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")));
         isValidOutput.Add(A125BR_Medication_RXUnit);
         isValidOutput.Add(AV19vMedicationName);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( AV16vDose, 16, 5, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Br_schemeid( long GX_Parm1 ,
                                     String GX_Parm2 )
      {
         A327BR_SchemeID = GX_Parm1;
         n327BR_SchemeID = false;
         A328BR_Scheme_Chem_Regimens = GX_Parm2;
         n328BR_Scheme_Chem_Regimens = false;
         /* Using cursor T001315 */
         pr_default.execute(13, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            if ( ! ( (0==A327BR_SchemeID) ) )
            {
               GX_msglist.addItem("不匹配' T39'", "ForeignKeyNotFound", 1, "BR_SCHEMEID");
               AnyError = 1;
               GX_FocusControl = edtBR_SchemeID_Internalname;
            }
         }
         A328BR_Scheme_Chem_Regimens = T001315_A328BR_Scheme_Chem_Regimens[0];
         n328BR_Scheme_Chem_Regimens = T001315_n328BR_Scheme_Chem_Regimens[0];
         pr_default.close(13);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A328BR_Scheme_Chem_Regimens = "";
            n328BR_Scheme_Chem_Regimens = false;
         }
         isValidOutput.Add(A328BR_Scheme_Chem_Regimens);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Scheme_MedicationID',fld:'vBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Scheme_MedicationID',fld:'vBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_BR_SchemeID',fld:'vINSERT_BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV14Insert_BR_MedicationID',fld:'vINSERT_BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12132',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(13);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
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
         lblTextblockbr_scheme_chem_regimens_Jsonclick = "";
         A328BR_Scheme_Chem_Regimens = "";
         lblTextblockbr_medicationid_Jsonclick = "";
         TempTags = "";
         sImgUrl = "";
         AV19vMedicationName = "";
         lblTextblockbr_medication_rxunit_Jsonclick = "";
         A125BR_Medication_RXUnit = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A121BR_Medication_RXName = "";
         AV20Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode40 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV15TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z328BR_Scheme_Chem_Regimens = "";
         Z121BR_Medication_RXName = "";
         Z125BR_Medication_RXUnit = "";
         T00135_A121BR_Medication_RXName = new String[] {""} ;
         T00135_n121BR_Medication_RXName = new bool[] {false} ;
         T00135_A124BR_Medication_RXDose = new decimal[1] ;
         T00135_n124BR_Medication_RXDose = new bool[] {false} ;
         T00135_A125BR_Medication_RXUnit = new String[] {""} ;
         T00135_n125BR_Medication_RXUnit = new bool[] {false} ;
         T00134_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         T00134_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         T00136_A332BR_Scheme_MedicationID = new long[1] ;
         T00136_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         T00136_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         T00136_A121BR_Medication_RXName = new String[] {""} ;
         T00136_n121BR_Medication_RXName = new bool[] {false} ;
         T00136_A124BR_Medication_RXDose = new decimal[1] ;
         T00136_n124BR_Medication_RXDose = new bool[] {false} ;
         T00136_A125BR_Medication_RXUnit = new String[] {""} ;
         T00136_n125BR_Medication_RXUnit = new bool[] {false} ;
         T00136_A327BR_SchemeID = new long[1] ;
         T00136_n327BR_SchemeID = new bool[] {false} ;
         T00136_A119BR_MedicationID = new long[1] ;
         T00136_n119BR_MedicationID = new bool[] {false} ;
         T00137_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         T00137_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         T00138_A121BR_Medication_RXName = new String[] {""} ;
         T00138_n121BR_Medication_RXName = new bool[] {false} ;
         T00138_A124BR_Medication_RXDose = new decimal[1] ;
         T00138_n124BR_Medication_RXDose = new bool[] {false} ;
         T00138_A125BR_Medication_RXUnit = new String[] {""} ;
         T00138_n125BR_Medication_RXUnit = new bool[] {false} ;
         T00139_A332BR_Scheme_MedicationID = new long[1] ;
         T00133_A332BR_Scheme_MedicationID = new long[1] ;
         T00133_A327BR_SchemeID = new long[1] ;
         T00133_n327BR_SchemeID = new bool[] {false} ;
         T00133_A119BR_MedicationID = new long[1] ;
         T00133_n119BR_MedicationID = new bool[] {false} ;
         T001310_A332BR_Scheme_MedicationID = new long[1] ;
         T001311_A332BR_Scheme_MedicationID = new long[1] ;
         T00132_A332BR_Scheme_MedicationID = new long[1] ;
         T00132_A327BR_SchemeID = new long[1] ;
         T00132_n327BR_SchemeID = new bool[] {false} ;
         T00132_A119BR_MedicationID = new long[1] ;
         T00132_n119BR_MedicationID = new bool[] {false} ;
         T001312_A332BR_Scheme_MedicationID = new long[1] ;
         T001315_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         T001315_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         T001316_A121BR_Medication_RXName = new String[] {""} ;
         T001316_n121BR_Medication_RXName = new bool[] {false} ;
         T001316_A124BR_Medication_RXDose = new decimal[1] ;
         T001316_n124BR_Medication_RXDose = new bool[] {false} ;
         T001316_A125BR_Medication_RXUnit = new String[] {""} ;
         T001316_n125BR_Medication_RXUnit = new bool[] {false} ;
         T001317_A332BR_Scheme_MedicationID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_medication__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_medication__default(),
            new Object[][] {
                new Object[] {
               T00132_A332BR_Scheme_MedicationID, T00132_A327BR_SchemeID, T00132_n327BR_SchemeID, T00132_A119BR_MedicationID, T00132_n119BR_MedicationID
               }
               , new Object[] {
               T00133_A332BR_Scheme_MedicationID, T00133_A327BR_SchemeID, T00133_n327BR_SchemeID, T00133_A119BR_MedicationID, T00133_n119BR_MedicationID
               }
               , new Object[] {
               T00134_A328BR_Scheme_Chem_Regimens, T00134_n328BR_Scheme_Chem_Regimens
               }
               , new Object[] {
               T00135_A121BR_Medication_RXName, T00135_n121BR_Medication_RXName, T00135_A124BR_Medication_RXDose, T00135_n124BR_Medication_RXDose, T00135_A125BR_Medication_RXUnit, T00135_n125BR_Medication_RXUnit
               }
               , new Object[] {
               T00136_A332BR_Scheme_MedicationID, T00136_A328BR_Scheme_Chem_Regimens, T00136_n328BR_Scheme_Chem_Regimens, T00136_A121BR_Medication_RXName, T00136_n121BR_Medication_RXName, T00136_A124BR_Medication_RXDose, T00136_n124BR_Medication_RXDose, T00136_A125BR_Medication_RXUnit, T00136_n125BR_Medication_RXUnit, T00136_A327BR_SchemeID,
               T00136_n327BR_SchemeID, T00136_A119BR_MedicationID, T00136_n119BR_MedicationID
               }
               , new Object[] {
               T00137_A328BR_Scheme_Chem_Regimens, T00137_n328BR_Scheme_Chem_Regimens
               }
               , new Object[] {
               T00138_A121BR_Medication_RXName, T00138_n121BR_Medication_RXName, T00138_A124BR_Medication_RXDose, T00138_n124BR_Medication_RXDose, T00138_A125BR_Medication_RXUnit, T00138_n125BR_Medication_RXUnit
               }
               , new Object[] {
               T00139_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               T001310_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               T001311_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               T001312_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001315_A328BR_Scheme_Chem_Regimens, T001315_n328BR_Scheme_Chem_Regimens
               }
               , new Object[] {
               T001316_A121BR_Medication_RXName, T001316_n121BR_Medication_RXName, T001316_A124BR_Medication_RXDose, T001316_n124BR_Medication_RXDose, T001316_A125BR_Medication_RXUnit, T001316_n125BR_Medication_RXUnit
               }
               , new Object[] {
               T001317_A332BR_Scheme_MedicationID
               }
            }
         );
         AV20Pgmname = "BR_Scheme_Medication";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound40 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Scheme_Chem_Regimens_Enabled ;
      private int edtBR_MedicationID_Enabled ;
      private int imgprompt_119_Visible ;
      private int edtavVmedicationname_Enabled ;
      private int edtavVdose_Enabled ;
      private int edtBR_Medication_RXUnit_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_Scheme_MedicationID_Enabled ;
      private int edtBR_Scheme_MedicationID_Visible ;
      private int edtBR_SchemeID_Visible ;
      private int edtBR_SchemeID_Enabled ;
      private int edtBR_Medication_RXName_Visible ;
      private int edtBR_Medication_RXName_Enabled ;
      private int AV21GXV1 ;
      private int idxLst ;
      private long wcpOAV7BR_Scheme_MedicationID ;
      private long Z332BR_Scheme_MedicationID ;
      private long Z327BR_SchemeID ;
      private long Z119BR_MedicationID ;
      private long N327BR_SchemeID ;
      private long N119BR_MedicationID ;
      private long A327BR_SchemeID ;
      private long A119BR_MedicationID ;
      private long AV7BR_Scheme_MedicationID ;
      private long A332BR_Scheme_MedicationID ;
      private long AV13Insert_BR_SchemeID ;
      private long AV14Insert_BR_MedicationID ;
      private decimal AV16vDose ;
      private decimal A124BR_Medication_RXDose ;
      private decimal Z124BR_Medication_RXDose ;
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
      private String edtBR_MedicationID_Internalname ;
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
      private String divUnnamedtablebr_scheme_chem_regimens_Internalname ;
      private String lblTextblockbr_scheme_chem_regimens_Internalname ;
      private String lblTextblockbr_scheme_chem_regimens_Jsonclick ;
      private String edtBR_Scheme_Chem_Regimens_Internalname ;
      private String edtBR_Scheme_Chem_Regimens_Jsonclick ;
      private String divUnnamedtablebr_medicationid_Internalname ;
      private String lblTextblockbr_medicationid_Internalname ;
      private String lblTextblockbr_medicationid_Jsonclick ;
      private String TempTags ;
      private String edtBR_MedicationID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_119_Internalname ;
      private String imgprompt_119_Link ;
      private String edtavVmedicationname_Internalname ;
      private String edtavVmedicationname_Jsonclick ;
      private String edtavVdose_Internalname ;
      private String edtavVdose_Jsonclick ;
      private String divUnnamedtablebr_medication_rxunit_Internalname ;
      private String lblTextblockbr_medication_rxunit_Internalname ;
      private String lblTextblockbr_medication_rxunit_Jsonclick ;
      private String edtBR_Medication_RXUnit_Internalname ;
      private String edtBR_Medication_RXUnit_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Scheme_MedicationID_Internalname ;
      private String edtBR_Scheme_MedicationID_Jsonclick ;
      private String edtBR_SchemeID_Internalname ;
      private String edtBR_SchemeID_Jsonclick ;
      private String edtBR_Medication_RXName_Internalname ;
      private String edtBR_Medication_RXName_Jsonclick ;
      private String AV20Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode40 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool n327BR_SchemeID ;
      private bool n119BR_MedicationID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n125BR_Medication_RXUnit ;
      private bool n121BR_Medication_RXName ;
      private bool n124BR_Medication_RXDose ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool AV18TempBoolean ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String AV19vMedicationName ;
      private String A125BR_Medication_RXUnit ;
      private String A121BR_Medication_RXName ;
      private String Z328BR_Scheme_Chem_Regimens ;
      private String Z121BR_Medication_RXName ;
      private String Z125BR_Medication_RXUnit ;
      private IGxSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00135_A121BR_Medication_RXName ;
      private bool[] T00135_n121BR_Medication_RXName ;
      private decimal[] T00135_A124BR_Medication_RXDose ;
      private bool[] T00135_n124BR_Medication_RXDose ;
      private String[] T00135_A125BR_Medication_RXUnit ;
      private bool[] T00135_n125BR_Medication_RXUnit ;
      private String[] T00134_A328BR_Scheme_Chem_Regimens ;
      private bool[] T00134_n328BR_Scheme_Chem_Regimens ;
      private long[] T00136_A332BR_Scheme_MedicationID ;
      private String[] T00136_A328BR_Scheme_Chem_Regimens ;
      private bool[] T00136_n328BR_Scheme_Chem_Regimens ;
      private String[] T00136_A121BR_Medication_RXName ;
      private bool[] T00136_n121BR_Medication_RXName ;
      private decimal[] T00136_A124BR_Medication_RXDose ;
      private bool[] T00136_n124BR_Medication_RXDose ;
      private String[] T00136_A125BR_Medication_RXUnit ;
      private bool[] T00136_n125BR_Medication_RXUnit ;
      private long[] T00136_A327BR_SchemeID ;
      private bool[] T00136_n327BR_SchemeID ;
      private long[] T00136_A119BR_MedicationID ;
      private bool[] T00136_n119BR_MedicationID ;
      private String[] T00137_A328BR_Scheme_Chem_Regimens ;
      private bool[] T00137_n328BR_Scheme_Chem_Regimens ;
      private String[] T00138_A121BR_Medication_RXName ;
      private bool[] T00138_n121BR_Medication_RXName ;
      private decimal[] T00138_A124BR_Medication_RXDose ;
      private bool[] T00138_n124BR_Medication_RXDose ;
      private String[] T00138_A125BR_Medication_RXUnit ;
      private bool[] T00138_n125BR_Medication_RXUnit ;
      private long[] T00139_A332BR_Scheme_MedicationID ;
      private long[] T00133_A332BR_Scheme_MedicationID ;
      private long[] T00133_A327BR_SchemeID ;
      private bool[] T00133_n327BR_SchemeID ;
      private long[] T00133_A119BR_MedicationID ;
      private bool[] T00133_n119BR_MedicationID ;
      private long[] T001310_A332BR_Scheme_MedicationID ;
      private long[] T001311_A332BR_Scheme_MedicationID ;
      private long[] T00132_A332BR_Scheme_MedicationID ;
      private long[] T00132_A327BR_SchemeID ;
      private bool[] T00132_n327BR_SchemeID ;
      private long[] T00132_A119BR_MedicationID ;
      private bool[] T00132_n119BR_MedicationID ;
      private long[] T001312_A332BR_Scheme_MedicationID ;
      private String[] T001315_A328BR_Scheme_Chem_Regimens ;
      private bool[] T001315_n328BR_Scheme_Chem_Regimens ;
      private String[] T001316_A121BR_Medication_RXName ;
      private bool[] T001316_n121BR_Medication_RXName ;
      private decimal[] T001316_A124BR_Medication_RXDose ;
      private bool[] T001316_n124BR_Medication_RXDose ;
      private String[] T001316_A125BR_Medication_RXUnit ;
      private bool[] T001316_n125BR_Medication_RXUnit ;
      private long[] T001317_A332BR_Scheme_MedicationID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV15TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
   }

   public class br_scheme_medication__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_scheme_medication__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new UpdateCursor(def[11])
       ,new UpdateCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
       ,new ForEachCursor(def[15])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00136 ;
        prmT00136 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00134 ;
        prmT00134 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00135 ;
        prmT00135 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00137 ;
        prmT00137 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00138 ;
        prmT00138 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00139 ;
        prmT00139 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00133 ;
        prmT00133 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001310 ;
        prmT001310 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001311 ;
        prmT001311 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00132 ;
        prmT00132 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001312 ;
        prmT001312 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001313 ;
        prmT001313 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001314 ;
        prmT001314 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001317 ;
        prmT001317 = new Object[] {
        } ;
        Object[] prmT001316 ;
        prmT001316 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001315 ;
        prmT001315 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00132", "SELECT [BR_Scheme_MedicationID], [BR_SchemeID], [BR_MedicationID] FROM [BR_Scheme_Medication] WITH (UPDLOCK) WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00132,1,0,true,false )
           ,new CursorDef("T00133", "SELECT [BR_Scheme_MedicationID], [BR_SchemeID], [BR_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00133,1,0,true,false )
           ,new CursorDef("T00134", "SELECT [BR_Scheme_Chem_Regimens] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00134,1,0,true,false )
           ,new CursorDef("T00135", "SELECT [BR_Medication_RXName], [BR_Medication_RXDose], [BR_Medication_RXUnit] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00135,1,0,true,false )
           ,new CursorDef("T00136", "SELECT TM1.[BR_Scheme_MedicationID], T2.[BR_Scheme_Chem_Regimens], T3.[BR_Medication_RXName], T3.[BR_Medication_RXDose], T3.[BR_Medication_RXUnit], TM1.[BR_SchemeID], TM1.[BR_MedicationID] FROM (([BR_Scheme_Medication] TM1 WITH (NOLOCK) LEFT JOIN [BR_Scheme] T2 WITH (NOLOCK) ON T2.[BR_SchemeID] = TM1.[BR_SchemeID]) LEFT JOIN [BR_Medication] T3 WITH (NOLOCK) ON T3.[BR_MedicationID] = TM1.[BR_MedicationID]) WHERE TM1.[BR_Scheme_MedicationID] = @BR_Scheme_MedicationID ORDER BY TM1.[BR_Scheme_MedicationID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00136,100,0,true,false )
           ,new CursorDef("T00137", "SELECT [BR_Scheme_Chem_Regimens] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00137,1,0,true,false )
           ,new CursorDef("T00138", "SELECT [BR_Medication_RXName], [BR_Medication_RXDose], [BR_Medication_RXUnit] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00138,1,0,true,false )
           ,new CursorDef("T00139", "SELECT [BR_Scheme_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00139,1,0,true,false )
           ,new CursorDef("T001310", "SELECT TOP 1 [BR_Scheme_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) WHERE ( [BR_Scheme_MedicationID] > @BR_Scheme_MedicationID) ORDER BY [BR_Scheme_MedicationID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001310,1,0,true,true )
           ,new CursorDef("T001311", "SELECT TOP 1 [BR_Scheme_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) WHERE ( [BR_Scheme_MedicationID] < @BR_Scheme_MedicationID) ORDER BY [BR_Scheme_MedicationID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001311,1,0,true,true )
           ,new CursorDef("T001312", "INSERT INTO [BR_Scheme_Medication]([BR_SchemeID], [BR_MedicationID]) VALUES(@BR_SchemeID, @BR_MedicationID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT001312)
           ,new CursorDef("T001313", "UPDATE [BR_Scheme_Medication] SET [BR_SchemeID]=@BR_SchemeID, [BR_MedicationID]=@BR_MedicationID  WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID", GxErrorMask.GX_NOMASK,prmT001313)
           ,new CursorDef("T001314", "DELETE FROM [BR_Scheme_Medication]  WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID", GxErrorMask.GX_NOMASK,prmT001314)
           ,new CursorDef("T001315", "SELECT [BR_Scheme_Chem_Regimens] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001315,1,0,true,false )
           ,new CursorDef("T001316", "SELECT [BR_Medication_RXName], [BR_Medication_RXDose], [BR_Medication_RXUnit] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001316,1,0,true,false )
           ,new CursorDef("T001317", "SELECT [BR_Scheme_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) ORDER BY [BR_Scheme_MedicationID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001317,100,0,true,false )
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
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(2);
              ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(3);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(2);
              ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(3);
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 10 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 13 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 14 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(2);
              ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(3);
              return;
           case 15 :
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
              stmt.SetParameter(1, (long)parms[0]);
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (long)parms[3]);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (long)parms[3]);
              }
              stmt.SetParameter(3, (long)parms[4]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 13 :
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
