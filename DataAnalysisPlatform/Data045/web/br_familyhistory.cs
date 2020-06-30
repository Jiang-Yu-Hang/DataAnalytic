/*
               File: BR_Familyhistory
        Description: 家族史
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:3.27
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
   public class br_familyhistory : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A19BR_EncounterID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A85BR_Information_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n85BR_Information_ID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A85BR_Information_ID) ;
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
            Form.Meta.addItem("description", "家族史", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_familyhistory( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_familyhistory( IGxContext context )
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
         cmbBR_FamilyCaHistory = new GXCombobox();
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
         if ( cmbBR_FamilyCaHistory.ItemCount > 0 )
         {
            A577BR_FamilyCaHistory = cmbBR_FamilyCaHistory.getValidValue(A577BR_FamilyCaHistory);
            n577BR_FamilyCaHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A577BR_FamilyCaHistory", A577BR_FamilyCaHistory);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_FamilyCaHistory.CurrentValue = StringUtil.RTrim( A577BR_FamilyCaHistory);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_FamilyCaHistory_Internalname, "Values", cmbBR_FamilyCaHistory.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "Container FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "家族史", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_FamilyhistoryID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_FamilyhistoryID_Internalname, "ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_FamilyhistoryID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A576BR_FamilyhistoryID), 18, 0, ".", "")), ((edtBR_FamilyhistoryID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A576BR_FamilyhistoryID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A576BR_FamilyhistoryID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_FamilyhistoryID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_FamilyhistoryID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_EncounterID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_EncounterID_Internalname, "就诊信息主键", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), ((edtBR_EncounterID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_EncounterID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Information_PatientNo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Information_PatientNo_Internalname, "患者编号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_FamilyCaHistory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_FamilyCaHistory_Internalname, "是否有家族肿瘤史", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_FamilyCaHistory, cmbBR_FamilyCaHistory_Internalname, StringUtil.RTrim( A577BR_FamilyCaHistory), 1, cmbBR_FamilyCaHistory_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_FamilyCaHistory.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "", true, "HLP_BR_Familyhistory.htm");
            cmbBR_FamilyCaHistory.CurrentValue = StringUtil.RTrim( A577BR_FamilyCaHistory);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_FamilyCaHistory_Internalname, "Values", (String)(cmbBR_FamilyCaHistory.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_FamilyCaHistory_Code_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_FamilyCaHistory_Code_Internalname, "是否有家族肿瘤史code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_FamilyCaHistory_Code_Internalname, A578BR_FamilyCaHistory_Code, StringUtil.RTrim( context.localUtil.Format( A578BR_FamilyCaHistory_Code, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_FamilyCaHistory_Code_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_FamilyCaHistory_Code_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_FamilyCancer_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_FamilyCancer_Internalname, "家族性肿瘤", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_FamilyCancer_Internalname, A579BR_FamilyCancer, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, 1, edtBR_FamilyCancer_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Familyhistory.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_FamilyhistoryID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_FamilyhistoryID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_FAMILYHISTORYID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A576BR_FamilyhistoryID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
               }
               else
               {
                  A576BR_FamilyhistoryID = (long)(context.localUtil.CToN( cgiGet( edtBR_FamilyhistoryID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTERID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19BR_EncounterID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               }
               else
               {
                  A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               }
               A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
               n36BR_Information_PatientNo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               cmbBR_FamilyCaHistory.CurrentValue = cgiGet( cmbBR_FamilyCaHistory_Internalname);
               A577BR_FamilyCaHistory = cgiGet( cmbBR_FamilyCaHistory_Internalname);
               n577BR_FamilyCaHistory = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A577BR_FamilyCaHistory", A577BR_FamilyCaHistory);
               n577BR_FamilyCaHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A577BR_FamilyCaHistory)) ? true : false);
               A578BR_FamilyCaHistory_Code = cgiGet( edtBR_FamilyCaHistory_Code_Internalname);
               n578BR_FamilyCaHistory_Code = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A578BR_FamilyCaHistory_Code", A578BR_FamilyCaHistory_Code);
               n578BR_FamilyCaHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A578BR_FamilyCaHistory_Code)) ? true : false);
               A579BR_FamilyCancer = cgiGet( edtBR_FamilyCancer_Internalname);
               n579BR_FamilyCancer = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A579BR_FamilyCancer", A579BR_FamilyCancer);
               n579BR_FamilyCancer = (String.IsNullOrEmpty(StringUtil.RTrim( A579BR_FamilyCancer)) ? true : false);
               /* Read saved values. */
               Z576BR_FamilyhistoryID = (long)(context.localUtil.CToN( cgiGet( "Z576BR_FamilyhistoryID"), ".", ","));
               Z577BR_FamilyCaHistory = cgiGet( "Z577BR_FamilyCaHistory");
               n577BR_FamilyCaHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A577BR_FamilyCaHistory)) ? true : false);
               Z578BR_FamilyCaHistory_Code = cgiGet( "Z578BR_FamilyCaHistory_Code");
               n578BR_FamilyCaHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A578BR_FamilyCaHistory_Code)) ? true : false);
               Z579BR_FamilyCancer = cgiGet( "Z579BR_FamilyCancer");
               n579BR_FamilyCancer = (String.IsNullOrEmpty(StringUtil.RTrim( A579BR_FamilyCancer)) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A576BR_FamilyhistoryID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
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
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1S74( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)), true);
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)), true);
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)), true);
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)), true);
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)), true);
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
         }
         DisableAttributes1S74( ) ;
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

      protected void ResetCaption1S0( )
      {
      }

      protected void ZM1S74( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z577BR_FamilyCaHistory = T001S3_A577BR_FamilyCaHistory[0];
               Z578BR_FamilyCaHistory_Code = T001S3_A578BR_FamilyCaHistory_Code[0];
               Z579BR_FamilyCancer = T001S3_A579BR_FamilyCancer[0];
               Z19BR_EncounterID = T001S3_A19BR_EncounterID[0];
            }
            else
            {
               Z577BR_FamilyCaHistory = A577BR_FamilyCaHistory;
               Z578BR_FamilyCaHistory_Code = A578BR_FamilyCaHistory_Code;
               Z579BR_FamilyCancer = A579BR_FamilyCancer;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -2 )
         {
            Z576BR_FamilyhistoryID = A576BR_FamilyhistoryID;
            Z577BR_FamilyCaHistory = A577BR_FamilyCaHistory;
            Z578BR_FamilyCaHistory_Code = A578BR_FamilyCaHistory_Code;
            Z579BR_FamilyCancer = A579BR_FamilyCancer;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
      }

      protected void Load1S74( )
      {
         /* Using cursor T001S6 */
         pr_default.execute(4, new Object[] {A576BR_FamilyhistoryID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound74 = 1;
            A85BR_Information_ID = T001S6_A85BR_Information_ID[0];
            n85BR_Information_ID = T001S6_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = T001S6_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T001S6_n36BR_Information_PatientNo[0];
            A577BR_FamilyCaHistory = T001S6_A577BR_FamilyCaHistory[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A577BR_FamilyCaHistory", A577BR_FamilyCaHistory);
            n577BR_FamilyCaHistory = T001S6_n577BR_FamilyCaHistory[0];
            A578BR_FamilyCaHistory_Code = T001S6_A578BR_FamilyCaHistory_Code[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A578BR_FamilyCaHistory_Code", A578BR_FamilyCaHistory_Code);
            n578BR_FamilyCaHistory_Code = T001S6_n578BR_FamilyCaHistory_Code[0];
            A579BR_FamilyCancer = T001S6_A579BR_FamilyCancer[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A579BR_FamilyCancer", A579BR_FamilyCancer);
            n579BR_FamilyCancer = T001S6_n579BR_FamilyCancer[0];
            A19BR_EncounterID = T001S6_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            ZM1S74( -2) ;
         }
         pr_default.close(4);
         OnLoadActions1S74( ) ;
      }

      protected void OnLoadActions1S74( )
      {
      }

      protected void CheckExtendedTable1S74( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T001S4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T001S4_A85BR_Information_ID[0];
         n85BR_Information_ID = T001S4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T001S5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T001S5_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T001S5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( ( StringUtil.StrCmp(A577BR_FamilyCaHistory, "否") == 0 ) || ( StringUtil.StrCmp(A577BR_FamilyCaHistory, "是") == 0 ) || ( StringUtil.StrCmp(A577BR_FamilyCaHistory, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A577BR_FamilyCaHistory)) ) )
         {
            GX_msglist.addItem("域是否有家族肿瘤史超界", "OutOfRange", 1, "BR_FAMILYCAHISTORY");
            AnyError = 1;
            GX_FocusControl = cmbBR_FamilyCaHistory_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1S74( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( long A19BR_EncounterID )
      {
         /* Using cursor T001S7 */
         pr_default.execute(5, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T001S7_A85BR_Information_ID[0];
         n85BR_Information_ID = T001S7_n85BR_Information_ID[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void gxLoad_4( long A85BR_Information_ID )
      {
         /* Using cursor T001S8 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T001S8_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T001S8_n36BR_Information_PatientNo[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A36BR_Information_PatientNo)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey1S74( )
      {
         /* Using cursor T001S9 */
         pr_default.execute(7, new Object[] {A576BR_FamilyhistoryID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound74 = 1;
         }
         else
         {
            RcdFound74 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001S3 */
         pr_default.execute(1, new Object[] {A576BR_FamilyhistoryID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1S74( 2) ;
            RcdFound74 = 1;
            A576BR_FamilyhistoryID = T001S3_A576BR_FamilyhistoryID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
            A577BR_FamilyCaHistory = T001S3_A577BR_FamilyCaHistory[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A577BR_FamilyCaHistory", A577BR_FamilyCaHistory);
            n577BR_FamilyCaHistory = T001S3_n577BR_FamilyCaHistory[0];
            A578BR_FamilyCaHistory_Code = T001S3_A578BR_FamilyCaHistory_Code[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A578BR_FamilyCaHistory_Code", A578BR_FamilyCaHistory_Code);
            n578BR_FamilyCaHistory_Code = T001S3_n578BR_FamilyCaHistory_Code[0];
            A579BR_FamilyCancer = T001S3_A579BR_FamilyCancer[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A579BR_FamilyCancer", A579BR_FamilyCancer);
            n579BR_FamilyCancer = T001S3_n579BR_FamilyCancer[0];
            A19BR_EncounterID = T001S3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z576BR_FamilyhistoryID = A576BR_FamilyhistoryID;
            sMode74 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1S74( ) ;
            if ( AnyError == 1 )
            {
               RcdFound74 = 0;
               InitializeNonKey1S74( ) ;
            }
            Gx_mode = sMode74;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound74 = 0;
            InitializeNonKey1S74( ) ;
            sMode74 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode74;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1S74( ) ;
         if ( RcdFound74 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound74 = 0;
         /* Using cursor T001S10 */
         pr_default.execute(8, new Object[] {A576BR_FamilyhistoryID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T001S10_A576BR_FamilyhistoryID[0] < A576BR_FamilyhistoryID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T001S10_A576BR_FamilyhistoryID[0] > A576BR_FamilyhistoryID ) ) )
            {
               A576BR_FamilyhistoryID = T001S10_A576BR_FamilyhistoryID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
               RcdFound74 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound74 = 0;
         /* Using cursor T001S11 */
         pr_default.execute(9, new Object[] {A576BR_FamilyhistoryID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T001S11_A576BR_FamilyhistoryID[0] > A576BR_FamilyhistoryID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T001S11_A576BR_FamilyhistoryID[0] < A576BR_FamilyhistoryID ) ) )
            {
               A576BR_FamilyhistoryID = T001S11_A576BR_FamilyhistoryID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
               RcdFound74 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1S74( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1S74( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound74 == 1 )
            {
               if ( A576BR_FamilyhistoryID != Z576BR_FamilyhistoryID )
               {
                  A576BR_FamilyhistoryID = Z576BR_FamilyhistoryID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_FAMILYHISTORYID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1S74( ) ;
                  GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A576BR_FamilyhistoryID != Z576BR_FamilyhistoryID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1S74( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_FAMILYHISTORYID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1S74( ) ;
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
      }

      protected void btn_delete( )
      {
         if ( A576BR_FamilyhistoryID != Z576BR_FamilyhistoryID )
         {
            A576BR_FamilyhistoryID = Z576BR_FamilyhistoryID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_FAMILYHISTORYID");
            AnyError = 1;
            GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "BR_FAMILYHISTORYID");
            AnyError = 1;
            GX_FocusControl = edtBR_FamilyhistoryID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1S74( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1S74( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_previous( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_next( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1S74( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound74 != 0 )
            {
               ScanNext1S74( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1S74( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1S74( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001S2 */
            pr_default.execute(0, new Object[] {A576BR_FamilyhistoryID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Familyhistory"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z577BR_FamilyCaHistory, T001S2_A577BR_FamilyCaHistory[0]) != 0 ) || ( StringUtil.StrCmp(Z578BR_FamilyCaHistory_Code, T001S2_A578BR_FamilyCaHistory_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z579BR_FamilyCancer, T001S2_A579BR_FamilyCancer[0]) != 0 ) || ( Z19BR_EncounterID != T001S2_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z577BR_FamilyCaHistory, T001S2_A577BR_FamilyCaHistory[0]) != 0 )
               {
                  GXUtil.WriteLog("br_familyhistory:[seudo value changed for attri]"+"BR_FamilyCaHistory");
                  GXUtil.WriteLogRaw("Old: ",Z577BR_FamilyCaHistory);
                  GXUtil.WriteLogRaw("Current: ",T001S2_A577BR_FamilyCaHistory[0]);
               }
               if ( StringUtil.StrCmp(Z578BR_FamilyCaHistory_Code, T001S2_A578BR_FamilyCaHistory_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_familyhistory:[seudo value changed for attri]"+"BR_FamilyCaHistory_Code");
                  GXUtil.WriteLogRaw("Old: ",Z578BR_FamilyCaHistory_Code);
                  GXUtil.WriteLogRaw("Current: ",T001S2_A578BR_FamilyCaHistory_Code[0]);
               }
               if ( StringUtil.StrCmp(Z579BR_FamilyCancer, T001S2_A579BR_FamilyCancer[0]) != 0 )
               {
                  GXUtil.WriteLog("br_familyhistory:[seudo value changed for attri]"+"BR_FamilyCancer");
                  GXUtil.WriteLogRaw("Old: ",Z579BR_FamilyCancer);
                  GXUtil.WriteLogRaw("Current: ",T001S2_A579BR_FamilyCancer[0]);
               }
               if ( Z19BR_EncounterID != T001S2_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_familyhistory:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T001S2_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Familyhistory"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1S74( )
      {
         BeforeValidate1S74( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1S74( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1S74( 0) ;
            CheckOptimisticConcurrency1S74( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1S74( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1S74( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001S12 */
                     pr_default.execute(10, new Object[] {n577BR_FamilyCaHistory, A577BR_FamilyCaHistory, n578BR_FamilyCaHistory_Code, A578BR_FamilyCaHistory_Code, n579BR_FamilyCancer, A579BR_FamilyCancer, A19BR_EncounterID});
                     A576BR_FamilyhistoryID = T001S12_A576BR_FamilyhistoryID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Familyhistory") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption1S0( ) ;
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
               Load1S74( ) ;
            }
            EndLevel1S74( ) ;
         }
         CloseExtendedTableCursors1S74( ) ;
      }

      protected void Update1S74( )
      {
         BeforeValidate1S74( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1S74( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1S74( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1S74( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1S74( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001S13 */
                     pr_default.execute(11, new Object[] {n577BR_FamilyCaHistory, A577BR_FamilyCaHistory, n578BR_FamilyCaHistory_Code, A578BR_FamilyCaHistory_Code, n579BR_FamilyCancer, A579BR_FamilyCancer, A19BR_EncounterID, A576BR_FamilyhistoryID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Familyhistory") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Familyhistory"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1S74( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1S0( ) ;
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
            EndLevel1S74( ) ;
         }
         CloseExtendedTableCursors1S74( ) ;
      }

      protected void DeferredUpdate1S74( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1S74( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1S74( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1S74( ) ;
            AfterConfirm1S74( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1S74( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001S14 */
                  pr_default.execute(12, new Object[] {A576BR_FamilyhistoryID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Familyhistory") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound74 == 0 )
                        {
                           InitAll1S74( ) ;
                           Gx_mode = "INS";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                        ResetCaption1S0( ) ;
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
         sMode74 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1S74( ) ;
         Gx_mode = sMode74;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1S74( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T001S15 */
            pr_default.execute(13, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T001S15_A85BR_Information_ID[0];
            n85BR_Information_ID = T001S15_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T001S16 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T001S16_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T001S16_n36BR_Information_PatientNo[0];
            pr_default.close(14);
         }
      }

      protected void EndLevel1S74( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1S74( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_familyhistory",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1S0( ) ;
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
            context.RollbackDataStores("br_familyhistory",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1S74( )
      {
         /* Using cursor T001S17 */
         pr_default.execute(15);
         RcdFound74 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound74 = 1;
            A576BR_FamilyhistoryID = T001S17_A576BR_FamilyhistoryID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1S74( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound74 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound74 = 1;
            A576BR_FamilyhistoryID = T001S17_A576BR_FamilyhistoryID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
         }
      }

      protected void ScanEnd1S74( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm1S74( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1S74( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1S74( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1S74( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1S74( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1S74( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1S74( )
      {
         edtBR_FamilyhistoryID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_FamilyhistoryID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_FamilyhistoryID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Enabled), 5, 0)), true);
         cmbBR_FamilyCaHistory.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_FamilyCaHistory_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_FamilyCaHistory.Enabled), 5, 0)), true);
         edtBR_FamilyCaHistory_Code_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_FamilyCaHistory_Code_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_FamilyCaHistory_Code_Enabled), 5, 0)), true);
         edtBR_FamilyCancer_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_FamilyCancer_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_FamilyCancer_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1S74( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1S0( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020228159426", false);
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
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_familyhistory.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z576BR_FamilyhistoryID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z577BR_FamilyCaHistory", Z577BR_FamilyCaHistory);
         GxWebStd.gx_hidden_field( context, "Z578BR_FamilyCaHistory_Code", Z578BR_FamilyCaHistory_Code);
         GxWebStd.gx_hidden_field( context, "Z579BR_FamilyCancer", Z579BR_FamilyCancer);
         GxWebStd.gx_hidden_field( context, "Z19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
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
         return formatLink("br_familyhistory.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Familyhistory" ;
      }

      public override String GetPgmdesc( )
      {
         return "家族史" ;
      }

      protected void InitializeNonKey1S74( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A577BR_FamilyCaHistory = "";
         n577BR_FamilyCaHistory = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A577BR_FamilyCaHistory", A577BR_FamilyCaHistory);
         n577BR_FamilyCaHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A577BR_FamilyCaHistory)) ? true : false);
         A578BR_FamilyCaHistory_Code = "";
         n578BR_FamilyCaHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A578BR_FamilyCaHistory_Code", A578BR_FamilyCaHistory_Code);
         n578BR_FamilyCaHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A578BR_FamilyCaHistory_Code)) ? true : false);
         A579BR_FamilyCancer = "";
         n579BR_FamilyCancer = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A579BR_FamilyCancer", A579BR_FamilyCancer);
         n579BR_FamilyCancer = (String.IsNullOrEmpty(StringUtil.RTrim( A579BR_FamilyCancer)) ? true : false);
         Z577BR_FamilyCaHistory = "";
         Z578BR_FamilyCaHistory_Code = "";
         Z579BR_FamilyCancer = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll1S74( )
      {
         A576BR_FamilyhistoryID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A576BR_FamilyhistoryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A576BR_FamilyhistoryID), 18, 0)));
         InitializeNonKey1S74( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228159432", true);
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
         context.AddJavascriptSource("br_familyhistory.js", "?2020228159432", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         edtBR_FamilyhistoryID_Internalname = "BR_FAMILYHISTORYID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         cmbBR_FamilyCaHistory_Internalname = "BR_FAMILYCAHISTORY";
         edtBR_FamilyCaHistory_Code_Internalname = "BR_FAMILYCAHISTORY_CODE";
         edtBR_FamilyCancer_Internalname = "BR_FAMILYCANCER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
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
         Form.Caption = "家族史";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtBR_FamilyCancer_Enabled = 1;
         edtBR_FamilyCaHistory_Code_Jsonclick = "";
         edtBR_FamilyCaHistory_Code_Enabled = 1;
         cmbBR_FamilyCaHistory_Jsonclick = "";
         cmbBR_FamilyCaHistory.Enabled = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         edtBR_FamilyhistoryID_Jsonclick = "";
         edtBR_FamilyhistoryID_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
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
         cmbBR_FamilyCaHistory.Name = "BR_FAMILYCAHISTORY";
         cmbBR_FamilyCaHistory.WebTags = "";
         cmbBR_FamilyCaHistory.addItem("", "(请选择)", 0);
         cmbBR_FamilyCaHistory.addItem("否", "否", 0);
         cmbBR_FamilyCaHistory.addItem("是", "是", 0);
         cmbBR_FamilyCaHistory.addItem("不详", "不详", 0);
         if ( cmbBR_FamilyCaHistory.ItemCount > 0 )
         {
            A577BR_FamilyCaHistory = cmbBR_FamilyCaHistory.getValidValue(A577BR_FamilyCaHistory);
            n577BR_FamilyCaHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A577BR_FamilyCaHistory", A577BR_FamilyCaHistory);
         }
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Br_familyhistoryid( long GX_Parm1 ,
                                            GXCombobox cmbGX_Parm2 ,
                                            String GX_Parm3 ,
                                            String GX_Parm4 ,
                                            long GX_Parm5 )
      {
         A576BR_FamilyhistoryID = GX_Parm1;
         cmbBR_FamilyCaHistory = cmbGX_Parm2;
         A577BR_FamilyCaHistory = cmbBR_FamilyCaHistory.CurrentValue;
         n577BR_FamilyCaHistory = false;
         cmbBR_FamilyCaHistory.CurrentValue = A577BR_FamilyCaHistory;
         A578BR_FamilyCaHistory_Code = GX_Parm3;
         n578BR_FamilyCaHistory_Code = false;
         A579BR_FamilyCancer = GX_Parm4;
         n579BR_FamilyCancer = false;
         A19BR_EncounterID = GX_Parm5;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A85BR_Information_ID = 0;
            n85BR_Information_ID = false;
            A36BR_Information_PatientNo = "";
            n36BR_Information_PatientNo = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         cmbBR_FamilyCaHistory.CurrentValue = A577BR_FamilyCaHistory;
         isValidOutput.Add(cmbBR_FamilyCaHistory);
         isValidOutput.Add(A578BR_FamilyCaHistory_Code);
         isValidOutput.Add(A579BR_FamilyCancer);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(A36BR_Information_PatientNo);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z576BR_FamilyhistoryID), 18, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         isValidOutput.Add(Z577BR_FamilyCaHistory);
         isValidOutput.Add(Z578BR_FamilyCaHistory_Code);
         isValidOutput.Add(Z579BR_FamilyCancer);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z85BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(Z36BR_Information_PatientNo);
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Br_encounterid( long GX_Parm1 ,
                                        long GX_Parm2 ,
                                        String GX_Parm3 )
      {
         A19BR_EncounterID = GX_Parm1;
         A85BR_Information_ID = GX_Parm2;
         n85BR_Information_ID = false;
         A36BR_Information_PatientNo = GX_Parm3;
         n36BR_Information_PatientNo = false;
         /* Using cursor T001S15 */
         pr_default.execute(13, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
         }
         A85BR_Information_ID = T001S15_A85BR_Information_ID[0];
         n85BR_Information_ID = T001S15_n85BR_Information_ID[0];
         pr_default.close(13);
         /* Using cursor T001S16 */
         pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T001S16_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T001S16_n36BR_Information_PatientNo[0];
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A85BR_Information_ID = 0;
            n85BR_Information_ID = false;
            A36BR_Information_PatientNo = "";
            n36BR_Information_PatientNo = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(A36BR_Information_PatientNo);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
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
         pr_default.close(1);
         pr_default.close(13);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z577BR_FamilyCaHistory = "";
         Z578BR_FamilyCaHistory_Code = "";
         Z579BR_FamilyCancer = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A577BR_FamilyCaHistory = "";
         lblTitle_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         A578BR_FamilyCaHistory_Code = "";
         A579BR_FamilyCancer = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z36BR_Information_PatientNo = "";
         T001S6_A85BR_Information_ID = new long[1] ;
         T001S6_n85BR_Information_ID = new bool[] {false} ;
         T001S6_A576BR_FamilyhistoryID = new long[1] ;
         T001S6_A36BR_Information_PatientNo = new String[] {""} ;
         T001S6_n36BR_Information_PatientNo = new bool[] {false} ;
         T001S6_A577BR_FamilyCaHistory = new String[] {""} ;
         T001S6_n577BR_FamilyCaHistory = new bool[] {false} ;
         T001S6_A578BR_FamilyCaHistory_Code = new String[] {""} ;
         T001S6_n578BR_FamilyCaHistory_Code = new bool[] {false} ;
         T001S6_A579BR_FamilyCancer = new String[] {""} ;
         T001S6_n579BR_FamilyCancer = new bool[] {false} ;
         T001S6_A19BR_EncounterID = new long[1] ;
         T001S4_A85BR_Information_ID = new long[1] ;
         T001S4_n85BR_Information_ID = new bool[] {false} ;
         T001S5_A36BR_Information_PatientNo = new String[] {""} ;
         T001S5_n36BR_Information_PatientNo = new bool[] {false} ;
         T001S7_A85BR_Information_ID = new long[1] ;
         T001S7_n85BR_Information_ID = new bool[] {false} ;
         T001S8_A36BR_Information_PatientNo = new String[] {""} ;
         T001S8_n36BR_Information_PatientNo = new bool[] {false} ;
         T001S9_A576BR_FamilyhistoryID = new long[1] ;
         T001S3_A576BR_FamilyhistoryID = new long[1] ;
         T001S3_A577BR_FamilyCaHistory = new String[] {""} ;
         T001S3_n577BR_FamilyCaHistory = new bool[] {false} ;
         T001S3_A578BR_FamilyCaHistory_Code = new String[] {""} ;
         T001S3_n578BR_FamilyCaHistory_Code = new bool[] {false} ;
         T001S3_A579BR_FamilyCancer = new String[] {""} ;
         T001S3_n579BR_FamilyCancer = new bool[] {false} ;
         T001S3_A19BR_EncounterID = new long[1] ;
         sMode74 = "";
         T001S10_A576BR_FamilyhistoryID = new long[1] ;
         T001S11_A576BR_FamilyhistoryID = new long[1] ;
         T001S2_A576BR_FamilyhistoryID = new long[1] ;
         T001S2_A577BR_FamilyCaHistory = new String[] {""} ;
         T001S2_n577BR_FamilyCaHistory = new bool[] {false} ;
         T001S2_A578BR_FamilyCaHistory_Code = new String[] {""} ;
         T001S2_n578BR_FamilyCaHistory_Code = new bool[] {false} ;
         T001S2_A579BR_FamilyCancer = new String[] {""} ;
         T001S2_n579BR_FamilyCancer = new bool[] {false} ;
         T001S2_A19BR_EncounterID = new long[1] ;
         T001S12_A576BR_FamilyhistoryID = new long[1] ;
         T001S15_A85BR_Information_ID = new long[1] ;
         T001S15_n85BR_Information_ID = new bool[] {false} ;
         T001S16_A36BR_Information_PatientNo = new String[] {""} ;
         T001S16_n36BR_Information_PatientNo = new bool[] {false} ;
         T001S17_A576BR_FamilyhistoryID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_familyhistory__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_familyhistory__default(),
            new Object[][] {
                new Object[] {
               T001S2_A576BR_FamilyhistoryID, T001S2_A577BR_FamilyCaHistory, T001S2_n577BR_FamilyCaHistory, T001S2_A578BR_FamilyCaHistory_Code, T001S2_n578BR_FamilyCaHistory_Code, T001S2_A579BR_FamilyCancer, T001S2_n579BR_FamilyCancer, T001S2_A19BR_EncounterID
               }
               , new Object[] {
               T001S3_A576BR_FamilyhistoryID, T001S3_A577BR_FamilyCaHistory, T001S3_n577BR_FamilyCaHistory, T001S3_A578BR_FamilyCaHistory_Code, T001S3_n578BR_FamilyCaHistory_Code, T001S3_A579BR_FamilyCancer, T001S3_n579BR_FamilyCancer, T001S3_A19BR_EncounterID
               }
               , new Object[] {
               T001S4_A85BR_Information_ID, T001S4_n85BR_Information_ID
               }
               , new Object[] {
               T001S5_A36BR_Information_PatientNo, T001S5_n36BR_Information_PatientNo
               }
               , new Object[] {
               T001S6_A85BR_Information_ID, T001S6_n85BR_Information_ID, T001S6_A576BR_FamilyhistoryID, T001S6_A36BR_Information_PatientNo, T001S6_n36BR_Information_PatientNo, T001S6_A577BR_FamilyCaHistory, T001S6_n577BR_FamilyCaHistory, T001S6_A578BR_FamilyCaHistory_Code, T001S6_n578BR_FamilyCaHistory_Code, T001S6_A579BR_FamilyCancer,
               T001S6_n579BR_FamilyCancer, T001S6_A19BR_EncounterID
               }
               , new Object[] {
               T001S7_A85BR_Information_ID, T001S7_n85BR_Information_ID
               }
               , new Object[] {
               T001S8_A36BR_Information_PatientNo, T001S8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T001S9_A576BR_FamilyhistoryID
               }
               , new Object[] {
               T001S10_A576BR_FamilyhistoryID
               }
               , new Object[] {
               T001S11_A576BR_FamilyhistoryID
               }
               , new Object[] {
               T001S12_A576BR_FamilyhistoryID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001S15_A85BR_Information_ID, T001S15_n85BR_Information_ID
               }
               , new Object[] {
               T001S16_A36BR_Information_PatientNo, T001S16_n36BR_Information_PatientNo
               }
               , new Object[] {
               T001S17_A576BR_FamilyhistoryID
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short RcdFound74 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtBR_FamilyhistoryID_Enabled ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtBR_FamilyCaHistory_Code_Enabled ;
      private int edtBR_FamilyCancer_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z576BR_FamilyhistoryID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long A576BR_FamilyhistoryID ;
      private long Z85BR_Information_ID ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtBR_FamilyhistoryID_Internalname ;
      private String cmbBR_FamilyCaHistory_Internalname ;
      private String divTablemain_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtBR_FamilyhistoryID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String cmbBR_FamilyCaHistory_Jsonclick ;
      private String edtBR_FamilyCaHistory_Code_Internalname ;
      private String edtBR_FamilyCaHistory_Code_Jsonclick ;
      private String edtBR_FamilyCancer_Internalname ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode74 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n577BR_FamilyCaHistory ;
      private bool n36BR_Information_PatientNo ;
      private bool n578BR_FamilyCaHistory_Code ;
      private bool n579BR_FamilyCancer ;
      private String Z577BR_FamilyCaHistory ;
      private String Z578BR_FamilyCaHistory_Code ;
      private String Z579BR_FamilyCancer ;
      private String A577BR_FamilyCaHistory ;
      private String A36BR_Information_PatientNo ;
      private String A578BR_FamilyCaHistory_Code ;
      private String A579BR_FamilyCancer ;
      private String Z36BR_Information_PatientNo ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_FamilyCaHistory ;
      private IDataStoreProvider pr_default ;
      private long[] T001S6_A85BR_Information_ID ;
      private bool[] T001S6_n85BR_Information_ID ;
      private long[] T001S6_A576BR_FamilyhistoryID ;
      private String[] T001S6_A36BR_Information_PatientNo ;
      private bool[] T001S6_n36BR_Information_PatientNo ;
      private String[] T001S6_A577BR_FamilyCaHistory ;
      private bool[] T001S6_n577BR_FamilyCaHistory ;
      private String[] T001S6_A578BR_FamilyCaHistory_Code ;
      private bool[] T001S6_n578BR_FamilyCaHistory_Code ;
      private String[] T001S6_A579BR_FamilyCancer ;
      private bool[] T001S6_n579BR_FamilyCancer ;
      private long[] T001S6_A19BR_EncounterID ;
      private long[] T001S4_A85BR_Information_ID ;
      private bool[] T001S4_n85BR_Information_ID ;
      private String[] T001S5_A36BR_Information_PatientNo ;
      private bool[] T001S5_n36BR_Information_PatientNo ;
      private long[] T001S7_A85BR_Information_ID ;
      private bool[] T001S7_n85BR_Information_ID ;
      private String[] T001S8_A36BR_Information_PatientNo ;
      private bool[] T001S8_n36BR_Information_PatientNo ;
      private long[] T001S9_A576BR_FamilyhistoryID ;
      private long[] T001S3_A576BR_FamilyhistoryID ;
      private String[] T001S3_A577BR_FamilyCaHistory ;
      private bool[] T001S3_n577BR_FamilyCaHistory ;
      private String[] T001S3_A578BR_FamilyCaHistory_Code ;
      private bool[] T001S3_n578BR_FamilyCaHistory_Code ;
      private String[] T001S3_A579BR_FamilyCancer ;
      private bool[] T001S3_n579BR_FamilyCancer ;
      private long[] T001S3_A19BR_EncounterID ;
      private long[] T001S10_A576BR_FamilyhistoryID ;
      private long[] T001S11_A576BR_FamilyhistoryID ;
      private long[] T001S2_A576BR_FamilyhistoryID ;
      private String[] T001S2_A577BR_FamilyCaHistory ;
      private bool[] T001S2_n577BR_FamilyCaHistory ;
      private String[] T001S2_A578BR_FamilyCaHistory_Code ;
      private bool[] T001S2_n578BR_FamilyCaHistory_Code ;
      private String[] T001S2_A579BR_FamilyCancer ;
      private bool[] T001S2_n579BR_FamilyCancer ;
      private long[] T001S2_A19BR_EncounterID ;
      private long[] T001S12_A576BR_FamilyhistoryID ;
      private long[] T001S15_A85BR_Information_ID ;
      private bool[] T001S15_n85BR_Information_ID ;
      private String[] T001S16_A36BR_Information_PatientNo ;
      private bool[] T001S16_n36BR_Information_PatientNo ;
      private long[] T001S17_A576BR_FamilyhistoryID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
   }

   public class br_familyhistory__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_familyhistory__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT001S6 ;
        prmT001S6 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S4 ;
        prmT001S4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S5 ;
        prmT001S5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S7 ;
        prmT001S7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S8 ;
        prmT001S8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S9 ;
        prmT001S9 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S3 ;
        prmT001S3 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S10 ;
        prmT001S10 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S11 ;
        prmT001S11 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S2 ;
        prmT001S2 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S12 ;
        prmT001S12 = new Object[] {
        new Object[] {"@BR_FamilyCaHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_FamilyCaHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_FamilyCancer",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S13 ;
        prmT001S13 = new Object[] {
        new Object[] {"@BR_FamilyCaHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_FamilyCaHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_FamilyCancer",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S14 ;
        prmT001S14 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S17 ;
        prmT001S17 = new Object[] {
        } ;
        Object[] prmT001S15 ;
        prmT001S15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001S16 ;
        prmT001S16 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T001S2", "SELECT [BR_FamilyhistoryID], [BR_FamilyCaHistory], [BR_FamilyCaHistory_Code], [BR_FamilyCancer], [BR_EncounterID] FROM [BR_Familyhistory] WITH (UPDLOCK) WHERE [BR_FamilyhistoryID] = @BR_FamilyhistoryID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001S2,1,0,true,false )
           ,new CursorDef("T001S3", "SELECT [BR_FamilyhistoryID], [BR_FamilyCaHistory], [BR_FamilyCaHistory_Code], [BR_FamilyCancer], [BR_EncounterID] FROM [BR_Familyhistory] WITH (NOLOCK) WHERE [BR_FamilyhistoryID] = @BR_FamilyhistoryID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001S3,1,0,true,false )
           ,new CursorDef("T001S4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001S4,1,0,true,false )
           ,new CursorDef("T001S5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001S5,1,0,true,false )
           ,new CursorDef("T001S6", "SELECT T2.[BR_Information_ID], TM1.[BR_FamilyhistoryID], T3.[BR_Information_PatientNo], TM1.[BR_FamilyCaHistory], TM1.[BR_FamilyCaHistory_Code], TM1.[BR_FamilyCancer], TM1.[BR_EncounterID] FROM (([BR_Familyhistory] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_FamilyhistoryID] = @BR_FamilyhistoryID ORDER BY TM1.[BR_FamilyhistoryID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001S6,100,0,true,false )
           ,new CursorDef("T001S7", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001S7,1,0,true,false )
           ,new CursorDef("T001S8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001S8,1,0,true,false )
           ,new CursorDef("T001S9", "SELECT [BR_FamilyhistoryID] FROM [BR_Familyhistory] WITH (NOLOCK) WHERE [BR_FamilyhistoryID] = @BR_FamilyhistoryID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001S9,1,0,true,false )
           ,new CursorDef("T001S10", "SELECT TOP 1 [BR_FamilyhistoryID] FROM [BR_Familyhistory] WITH (NOLOCK) WHERE ( [BR_FamilyhistoryID] > @BR_FamilyhistoryID) ORDER BY [BR_FamilyhistoryID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001S10,1,0,true,true )
           ,new CursorDef("T001S11", "SELECT TOP 1 [BR_FamilyhistoryID] FROM [BR_Familyhistory] WITH (NOLOCK) WHERE ( [BR_FamilyhistoryID] < @BR_FamilyhistoryID) ORDER BY [BR_FamilyhistoryID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001S11,1,0,true,true )
           ,new CursorDef("T001S12", "INSERT INTO [BR_Familyhistory]([BR_FamilyCaHistory], [BR_FamilyCaHistory_Code], [BR_FamilyCancer], [BR_EncounterID]) VALUES(@BR_FamilyCaHistory, @BR_FamilyCaHistory_Code, @BR_FamilyCancer, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT001S12)
           ,new CursorDef("T001S13", "UPDATE [BR_Familyhistory] SET [BR_FamilyCaHistory]=@BR_FamilyCaHistory, [BR_FamilyCaHistory_Code]=@BR_FamilyCaHistory_Code, [BR_FamilyCancer]=@BR_FamilyCancer, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_FamilyhistoryID] = @BR_FamilyhistoryID", GxErrorMask.GX_NOMASK,prmT001S13)
           ,new CursorDef("T001S14", "DELETE FROM [BR_Familyhistory]  WHERE [BR_FamilyhistoryID] = @BR_FamilyhistoryID", GxErrorMask.GX_NOMASK,prmT001S14)
           ,new CursorDef("T001S15", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001S15,1,0,true,false )
           ,new CursorDef("T001S16", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001S16,1,0,true,false )
           ,new CursorDef("T001S17", "SELECT [BR_FamilyhistoryID] FROM [BR_Familyhistory] WITH (NOLOCK) ORDER BY [BR_FamilyhistoryID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001S17,100,0,true,false )
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
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 14 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
              stmt.SetParameter(1, (long)parms[0]);
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
              stmt.SetParameter(1, (long)parms[0]);
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
              stmt.SetParameter(4, (long)parms[6]);
              return;
           case 11 :
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
              stmt.SetParameter(4, (long)parms[6]);
              stmt.SetParameter(5, (long)parms[7]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
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
