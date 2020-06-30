/*
               File: view_lastest_patient_info
        Description: view_lastest_patient_info
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:3.8
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
   public class view_lastest_patient_info : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "view_lastest_patient_info", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public view_lastest_patient_info( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public view_lastest_patient_info( IGxContext context )
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "Container FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "view_lastest_patient_info", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_view_lastest_patient_info.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_view_lastest_patient_info.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVIEW_LPI_BR_Information_ID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVIEW_LPI_BR_Information_ID_Internalname, "VIEW_LPI_BR_Information_ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVIEW_LPI_BR_Information_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0, ".", "")), ((edtVIEW_LPI_BR_Information_ID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A520VIEW_LPI_BR_Information_ID), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A520VIEW_LPI_BR_Information_ID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVIEW_LPI_BR_Information_ID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVIEW_LPI_BR_Information_ID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVIEW_LPI_BR_Information_PatientNo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVIEW_LPI_BR_Information_PatientNo_Internalname, "VIEW_LPI_BR_Information_Patient No", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtVIEW_LPI_BR_Information_PatientNo_Internalname, A519VIEW_LPI_BR_Information_PatientNo, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, 1, edtVIEW_LPI_BR_Information_PatientNo_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname, "VIEW_LPI_BR_Encounter_Admit Date", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname, context.localUtil.TToC( A521VIEW_LPI_BR_Encounter_AdmitDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A521VIEW_LPI_BR_Encounter_AdmitDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVIEW_LPI_BR_Encounter_AdmitDate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVIEW_LPI_BR_Encounter_AdmitDate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_bitmap( context, edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtVIEW_LPI_BR_Encounter_AdmitDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_view_lastest_patient_info.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVIEW_LPI_BR_Demographics_Sex_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVIEW_LPI_BR_Demographics_Sex_Internalname, "VIEW_LPI_BR_Demographics_Sex", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtVIEW_LPI_BR_Demographics_Sex_Internalname, A522VIEW_LPI_BR_Demographics_Sex, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, 1, edtVIEW_LPI_BR_Demographics_Sex_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVIEW_LPI_BR_Demographics_BirthDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVIEW_LPI_BR_Demographics_BirthDate_Internalname, "VIEW_LPI_BR_Demographics_Birth Date", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtVIEW_LPI_BR_Demographics_BirthDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtVIEW_LPI_BR_Demographics_BirthDate_Internalname, context.localUtil.Format(A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"), context.localUtil.Format( A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVIEW_LPI_BR_Demographics_BirthDate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVIEW_LPI_BR_Demographics_BirthDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_bitmap( context, edtVIEW_LPI_BR_Demographics_BirthDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtVIEW_LPI_BR_Demographics_BirthDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_view_lastest_patient_info.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVIEW_LPI_BR_Demographics_Ethnic_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVIEW_LPI_BR_Demographics_Ethnic_Internalname, "VIEW_LPI_BR_Demographics_Ethnic", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtVIEW_LPI_BR_Demographics_Ethnic_Internalname, A524VIEW_LPI_BR_Demographics_Ethnic, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, 1, edtVIEW_LPI_BR_Demographics_Ethnic_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_view_lastest_patient_info.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_view_lastest_patient_info.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_view_lastest_patient_info.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtVIEW_LPI_BR_Information_ID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVIEW_LPI_BR_Information_ID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VIEW_LPI_BR_INFORMATION_ID");
                  AnyError = 1;
                  GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A520VIEW_LPI_BR_Information_ID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
               }
               else
               {
                  A520VIEW_LPI_BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtVIEW_LPI_BR_Information_ID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
               }
               A519VIEW_LPI_BR_Information_PatientNo = cgiGet( edtVIEW_LPI_BR_Information_PatientNo_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A519VIEW_LPI_BR_Information_PatientNo", A519VIEW_LPI_BR_Information_PatientNo);
               if ( context.localUtil.VCDateTime( cgiGet( edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"VIEW_LPI_BR_Encounter_Admit Date"}), 1, "VIEW_LPI_BR_ENCOUNTER_ADMITDATE");
                  AnyError = 1;
                  GX_FocusControl = edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A521VIEW_LPI_BR_Encounter_AdmitDate = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A521VIEW_LPI_BR_Encounter_AdmitDate", context.localUtil.TToC( A521VIEW_LPI_BR_Encounter_AdmitDate, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A521VIEW_LPI_BR_Encounter_AdmitDate = context.localUtil.CToT( cgiGet( edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A521VIEW_LPI_BR_Encounter_AdmitDate", context.localUtil.TToC( A521VIEW_LPI_BR_Encounter_AdmitDate, 10, 8, 0, 0, "/", ":", " "));
               }
               A522VIEW_LPI_BR_Demographics_Sex = cgiGet( edtVIEW_LPI_BR_Demographics_Sex_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A522VIEW_LPI_BR_Demographics_Sex", A522VIEW_LPI_BR_Demographics_Sex);
               if ( context.localUtil.VCDate( cgiGet( edtVIEW_LPI_BR_Demographics_BirthDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"VIEW_LPI_BR_Demographics_Birth Date"}), 1, "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE");
                  AnyError = 1;
                  GX_FocusControl = edtVIEW_LPI_BR_Demographics_BirthDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A523VIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
               }
               else
               {
                  A523VIEW_LPI_BR_Demographics_BirthDate = context.localUtil.CToD( cgiGet( edtVIEW_LPI_BR_Demographics_BirthDate_Internalname), 0);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A523VIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
               }
               A524VIEW_LPI_BR_Demographics_Ethnic = cgiGet( edtVIEW_LPI_BR_Demographics_Ethnic_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A524VIEW_LPI_BR_Demographics_Ethnic", A524VIEW_LPI_BR_Demographics_Ethnic);
               /* Read saved values. */
               Z520VIEW_LPI_BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "Z520VIEW_LPI_BR_Information_ID"), ".", ","));
               Z519VIEW_LPI_BR_Information_PatientNo = cgiGet( "Z519VIEW_LPI_BR_Information_PatientNo");
               Z521VIEW_LPI_BR_Encounter_AdmitDate = context.localUtil.CToT( cgiGet( "Z521VIEW_LPI_BR_Encounter_AdmitDate"), 0);
               Z522VIEW_LPI_BR_Demographics_Sex = cgiGet( "Z522VIEW_LPI_BR_Demographics_Sex");
               Z523VIEW_LPI_BR_Demographics_BirthDate = context.localUtil.CToD( cgiGet( "Z523VIEW_LPI_BR_Demographics_BirthDate"), 0);
               Z524VIEW_LPI_BR_Demographics_Ethnic = cgiGet( "Z524VIEW_LPI_BR_Demographics_Ethnic");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
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
                  A520VIEW_LPI_BR_Information_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
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
               InitAll1O71( ) ;
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
         DisableAttributes1O71( ) ;
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

      protected void ResetCaption1O0( )
      {
      }

      protected void ZM1O71( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z519VIEW_LPI_BR_Information_PatientNo = T001O3_A519VIEW_LPI_BR_Information_PatientNo[0];
               Z521VIEW_LPI_BR_Encounter_AdmitDate = T001O3_A521VIEW_LPI_BR_Encounter_AdmitDate[0];
               Z522VIEW_LPI_BR_Demographics_Sex = T001O3_A522VIEW_LPI_BR_Demographics_Sex[0];
               Z523VIEW_LPI_BR_Demographics_BirthDate = T001O3_A523VIEW_LPI_BR_Demographics_BirthDate[0];
               Z524VIEW_LPI_BR_Demographics_Ethnic = T001O3_A524VIEW_LPI_BR_Demographics_Ethnic[0];
            }
            else
            {
               Z519VIEW_LPI_BR_Information_PatientNo = A519VIEW_LPI_BR_Information_PatientNo;
               Z521VIEW_LPI_BR_Encounter_AdmitDate = A521VIEW_LPI_BR_Encounter_AdmitDate;
               Z522VIEW_LPI_BR_Demographics_Sex = A522VIEW_LPI_BR_Demographics_Sex;
               Z523VIEW_LPI_BR_Demographics_BirthDate = A523VIEW_LPI_BR_Demographics_BirthDate;
               Z524VIEW_LPI_BR_Demographics_Ethnic = A524VIEW_LPI_BR_Demographics_Ethnic;
            }
         }
         if ( GX_JID == -3 )
         {
            Z520VIEW_LPI_BR_Information_ID = A520VIEW_LPI_BR_Information_ID;
            Z519VIEW_LPI_BR_Information_PatientNo = A519VIEW_LPI_BR_Information_PatientNo;
            Z521VIEW_LPI_BR_Encounter_AdmitDate = A521VIEW_LPI_BR_Encounter_AdmitDate;
            Z522VIEW_LPI_BR_Demographics_Sex = A522VIEW_LPI_BR_Demographics_Sex;
            Z523VIEW_LPI_BR_Demographics_BirthDate = A523VIEW_LPI_BR_Demographics_BirthDate;
            Z524VIEW_LPI_BR_Demographics_Ethnic = A524VIEW_LPI_BR_Demographics_Ethnic;
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

      protected void Load1O71( )
      {
         /* Using cursor T001O4 */
         pr_default.execute(2, new Object[] {A520VIEW_LPI_BR_Information_ID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound71 = 1;
            A519VIEW_LPI_BR_Information_PatientNo = T001O4_A519VIEW_LPI_BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A519VIEW_LPI_BR_Information_PatientNo", A519VIEW_LPI_BR_Information_PatientNo);
            A521VIEW_LPI_BR_Encounter_AdmitDate = T001O4_A521VIEW_LPI_BR_Encounter_AdmitDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A521VIEW_LPI_BR_Encounter_AdmitDate", context.localUtil.TToC( A521VIEW_LPI_BR_Encounter_AdmitDate, 10, 8, 0, 0, "/", ":", " "));
            A522VIEW_LPI_BR_Demographics_Sex = T001O4_A522VIEW_LPI_BR_Demographics_Sex[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A522VIEW_LPI_BR_Demographics_Sex", A522VIEW_LPI_BR_Demographics_Sex);
            A523VIEW_LPI_BR_Demographics_BirthDate = T001O4_A523VIEW_LPI_BR_Demographics_BirthDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A523VIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
            A524VIEW_LPI_BR_Demographics_Ethnic = T001O4_A524VIEW_LPI_BR_Demographics_Ethnic[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A524VIEW_LPI_BR_Demographics_Ethnic", A524VIEW_LPI_BR_Demographics_Ethnic);
            ZM1O71( -3) ;
         }
         pr_default.close(2);
         OnLoadActions1O71( ) ;
      }

      protected void OnLoadActions1O71( )
      {
      }

      protected void CheckExtendedTable1O71( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A521VIEW_LPI_BR_Encounter_AdmitDate) || ( A521VIEW_LPI_BR_Encounter_AdmitDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域VIEW_LPI_BR_Encounter_Admit Date超界", "OutOfRange", 1, "VIEW_LPI_BR_ENCOUNTER_ADMITDATE");
            AnyError = 1;
            GX_FocusControl = edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A523VIEW_LPI_BR_Demographics_BirthDate) || ( A523VIEW_LPI_BR_Demographics_BirthDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域VIEW_LPI_BR_Demographics_Birth Date超界", "OutOfRange", 1, "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE");
            AnyError = 1;
            GX_FocusControl = edtVIEW_LPI_BR_Demographics_BirthDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1O71( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1O71( )
      {
         /* Using cursor T001O5 */
         pr_default.execute(3, new Object[] {A520VIEW_LPI_BR_Information_ID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound71 = 1;
         }
         else
         {
            RcdFound71 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001O3 */
         pr_default.execute(1, new Object[] {A520VIEW_LPI_BR_Information_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1O71( 3) ;
            RcdFound71 = 1;
            A520VIEW_LPI_BR_Information_ID = T001O3_A520VIEW_LPI_BR_Information_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
            A519VIEW_LPI_BR_Information_PatientNo = T001O3_A519VIEW_LPI_BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A519VIEW_LPI_BR_Information_PatientNo", A519VIEW_LPI_BR_Information_PatientNo);
            A521VIEW_LPI_BR_Encounter_AdmitDate = T001O3_A521VIEW_LPI_BR_Encounter_AdmitDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A521VIEW_LPI_BR_Encounter_AdmitDate", context.localUtil.TToC( A521VIEW_LPI_BR_Encounter_AdmitDate, 10, 8, 0, 0, "/", ":", " "));
            A522VIEW_LPI_BR_Demographics_Sex = T001O3_A522VIEW_LPI_BR_Demographics_Sex[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A522VIEW_LPI_BR_Demographics_Sex", A522VIEW_LPI_BR_Demographics_Sex);
            A523VIEW_LPI_BR_Demographics_BirthDate = T001O3_A523VIEW_LPI_BR_Demographics_BirthDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A523VIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
            A524VIEW_LPI_BR_Demographics_Ethnic = T001O3_A524VIEW_LPI_BR_Demographics_Ethnic[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A524VIEW_LPI_BR_Demographics_Ethnic", A524VIEW_LPI_BR_Demographics_Ethnic);
            Z520VIEW_LPI_BR_Information_ID = A520VIEW_LPI_BR_Information_ID;
            sMode71 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1O71( ) ;
            if ( AnyError == 1 )
            {
               RcdFound71 = 0;
               InitializeNonKey1O71( ) ;
            }
            Gx_mode = sMode71;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound71 = 0;
            InitializeNonKey1O71( ) ;
            sMode71 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode71;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1O71( ) ;
         if ( RcdFound71 == 0 )
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
         RcdFound71 = 0;
         /* Using cursor T001O6 */
         pr_default.execute(4, new Object[] {A520VIEW_LPI_BR_Information_ID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T001O6_A520VIEW_LPI_BR_Information_ID[0] < A520VIEW_LPI_BR_Information_ID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T001O6_A520VIEW_LPI_BR_Information_ID[0] > A520VIEW_LPI_BR_Information_ID ) ) )
            {
               A520VIEW_LPI_BR_Information_ID = T001O6_A520VIEW_LPI_BR_Information_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
               RcdFound71 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound71 = 0;
         /* Using cursor T001O7 */
         pr_default.execute(5, new Object[] {A520VIEW_LPI_BR_Information_ID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T001O7_A520VIEW_LPI_BR_Information_ID[0] > A520VIEW_LPI_BR_Information_ID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T001O7_A520VIEW_LPI_BR_Information_ID[0] < A520VIEW_LPI_BR_Information_ID ) ) )
            {
               A520VIEW_LPI_BR_Information_ID = T001O7_A520VIEW_LPI_BR_Information_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
               RcdFound71 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1O71( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1O71( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound71 == 1 )
            {
               if ( A520VIEW_LPI_BR_Information_ID != Z520VIEW_LPI_BR_Information_ID )
               {
                  A520VIEW_LPI_BR_Information_ID = Z520VIEW_LPI_BR_Information_ID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "VIEW_LPI_BR_INFORMATION_ID");
                  AnyError = 1;
                  GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1O71( ) ;
                  GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A520VIEW_LPI_BR_Information_ID != Z520VIEW_LPI_BR_Information_ID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1O71( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "VIEW_LPI_BR_INFORMATION_ID");
                     AnyError = 1;
                     GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1O71( ) ;
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
         if ( A520VIEW_LPI_BR_Information_ID != Z520VIEW_LPI_BR_Information_ID )
         {
            A520VIEW_LPI_BR_Information_ID = Z520VIEW_LPI_BR_Information_ID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "VIEW_LPI_BR_INFORMATION_ID");
            AnyError = 1;
            GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
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
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "VIEW_LPI_BR_INFORMATION_ID");
            AnyError = 1;
            GX_FocusControl = edtVIEW_LPI_BR_Information_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtVIEW_LPI_BR_Information_PatientNo_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1O71( ) ;
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVIEW_LPI_BR_Information_PatientNo_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1O71( ) ;
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
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVIEW_LPI_BR_Information_PatientNo_Internalname;
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
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVIEW_LPI_BR_Information_PatientNo_Internalname;
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
         ScanStart1O71( ) ;
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound71 != 0 )
            {
               ScanNext1O71( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVIEW_LPI_BR_Information_PatientNo_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1O71( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1O71( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001O2 */
            pr_default.execute(0, new Object[] {A520VIEW_LPI_BR_Information_ID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VIEW_LASTEST_PATIENT_INFO"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z519VIEW_LPI_BR_Information_PatientNo, T001O2_A519VIEW_LPI_BR_Information_PatientNo[0]) != 0 ) || ( Z521VIEW_LPI_BR_Encounter_AdmitDate != T001O2_A521VIEW_LPI_BR_Encounter_AdmitDate[0] ) || ( StringUtil.StrCmp(Z522VIEW_LPI_BR_Demographics_Sex, T001O2_A522VIEW_LPI_BR_Demographics_Sex[0]) != 0 ) || ( Z523VIEW_LPI_BR_Demographics_BirthDate != T001O2_A523VIEW_LPI_BR_Demographics_BirthDate[0] ) || ( StringUtil.StrCmp(Z524VIEW_LPI_BR_Demographics_Ethnic, T001O2_A524VIEW_LPI_BR_Demographics_Ethnic[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z519VIEW_LPI_BR_Information_PatientNo, T001O2_A519VIEW_LPI_BR_Information_PatientNo[0]) != 0 )
               {
                  GXUtil.WriteLog("view_lastest_patient_info:[seudo value changed for attri]"+"VIEW_LPI_BR_Information_PatientNo");
                  GXUtil.WriteLogRaw("Old: ",Z519VIEW_LPI_BR_Information_PatientNo);
                  GXUtil.WriteLogRaw("Current: ",T001O2_A519VIEW_LPI_BR_Information_PatientNo[0]);
               }
               if ( Z521VIEW_LPI_BR_Encounter_AdmitDate != T001O2_A521VIEW_LPI_BR_Encounter_AdmitDate[0] )
               {
                  GXUtil.WriteLog("view_lastest_patient_info:[seudo value changed for attri]"+"VIEW_LPI_BR_Encounter_AdmitDate");
                  GXUtil.WriteLogRaw("Old: ",Z521VIEW_LPI_BR_Encounter_AdmitDate);
                  GXUtil.WriteLogRaw("Current: ",T001O2_A521VIEW_LPI_BR_Encounter_AdmitDate[0]);
               }
               if ( StringUtil.StrCmp(Z522VIEW_LPI_BR_Demographics_Sex, T001O2_A522VIEW_LPI_BR_Demographics_Sex[0]) != 0 )
               {
                  GXUtil.WriteLog("view_lastest_patient_info:[seudo value changed for attri]"+"VIEW_LPI_BR_Demographics_Sex");
                  GXUtil.WriteLogRaw("Old: ",Z522VIEW_LPI_BR_Demographics_Sex);
                  GXUtil.WriteLogRaw("Current: ",T001O2_A522VIEW_LPI_BR_Demographics_Sex[0]);
               }
               if ( Z523VIEW_LPI_BR_Demographics_BirthDate != T001O2_A523VIEW_LPI_BR_Demographics_BirthDate[0] )
               {
                  GXUtil.WriteLog("view_lastest_patient_info:[seudo value changed for attri]"+"VIEW_LPI_BR_Demographics_BirthDate");
                  GXUtil.WriteLogRaw("Old: ",Z523VIEW_LPI_BR_Demographics_BirthDate);
                  GXUtil.WriteLogRaw("Current: ",T001O2_A523VIEW_LPI_BR_Demographics_BirthDate[0]);
               }
               if ( StringUtil.StrCmp(Z524VIEW_LPI_BR_Demographics_Ethnic, T001O2_A524VIEW_LPI_BR_Demographics_Ethnic[0]) != 0 )
               {
                  GXUtil.WriteLog("view_lastest_patient_info:[seudo value changed for attri]"+"VIEW_LPI_BR_Demographics_Ethnic");
                  GXUtil.WriteLogRaw("Old: ",Z524VIEW_LPI_BR_Demographics_Ethnic);
                  GXUtil.WriteLogRaw("Current: ",T001O2_A524VIEW_LPI_BR_Demographics_Ethnic[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"VIEW_LASTEST_PATIENT_INFO"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1O71( )
      {
         BeforeValidate1O71( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1O71( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1O71( 0) ;
            CheckOptimisticConcurrency1O71( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1O71( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1O71( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001O8 */
                     pr_default.execute(6, new Object[] {A520VIEW_LPI_BR_Information_ID, A519VIEW_LPI_BR_Information_PatientNo, A521VIEW_LPI_BR_Encounter_AdmitDate, A522VIEW_LPI_BR_Demographics_Sex, A523VIEW_LPI_BR_Demographics_BirthDate, A524VIEW_LPI_BR_Demographics_Ethnic});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("VIEW_LASTEST_PATIENT_INFO") ;
                     if ( (pr_default.getStatus(6) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption1O0( ) ;
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
               Load1O71( ) ;
            }
            EndLevel1O71( ) ;
         }
         CloseExtendedTableCursors1O71( ) ;
      }

      protected void Update1O71( )
      {
         BeforeValidate1O71( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1O71( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1O71( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1O71( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1O71( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001O9 */
                     pr_default.execute(7, new Object[] {A519VIEW_LPI_BR_Information_PatientNo, A521VIEW_LPI_BR_Encounter_AdmitDate, A522VIEW_LPI_BR_Demographics_Sex, A523VIEW_LPI_BR_Demographics_BirthDate, A524VIEW_LPI_BR_Demographics_Ethnic, A520VIEW_LPI_BR_Information_ID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("VIEW_LASTEST_PATIENT_INFO") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VIEW_LASTEST_PATIENT_INFO"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1O71( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1O0( ) ;
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
            EndLevel1O71( ) ;
         }
         CloseExtendedTableCursors1O71( ) ;
      }

      protected void DeferredUpdate1O71( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1O71( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1O71( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1O71( ) ;
            AfterConfirm1O71( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1O71( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001O10 */
                  pr_default.execute(8, new Object[] {A520VIEW_LPI_BR_Information_ID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("VIEW_LASTEST_PATIENT_INFO") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound71 == 0 )
                        {
                           InitAll1O71( ) ;
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
                        ResetCaption1O0( ) ;
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
         sMode71 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1O71( ) ;
         Gx_mode = sMode71;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1O71( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1O71( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1O71( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("view_lastest_patient_info",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1O0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("view_lastest_patient_info",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1O71( )
      {
         /* Using cursor T001O11 */
         pr_default.execute(9);
         RcdFound71 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound71 = 1;
            A520VIEW_LPI_BR_Information_ID = T001O11_A520VIEW_LPI_BR_Information_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1O71( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound71 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound71 = 1;
            A520VIEW_LPI_BR_Information_ID = T001O11_A520VIEW_LPI_BR_Information_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
         }
      }

      protected void ScanEnd1O71( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm1O71( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1O71( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1O71( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1O71( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1O71( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1O71( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1O71( )
      {
         edtVIEW_LPI_BR_Information_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVIEW_LPI_BR_Information_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVIEW_LPI_BR_Information_ID_Enabled), 5, 0)), true);
         edtVIEW_LPI_BR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVIEW_LPI_BR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVIEW_LPI_BR_Information_PatientNo_Enabled), 5, 0)), true);
         edtVIEW_LPI_BR_Encounter_AdmitDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVIEW_LPI_BR_Encounter_AdmitDate_Enabled), 5, 0)), true);
         edtVIEW_LPI_BR_Demographics_Sex_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVIEW_LPI_BR_Demographics_Sex_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVIEW_LPI_BR_Demographics_Sex_Enabled), 5, 0)), true);
         edtVIEW_LPI_BR_Demographics_BirthDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVIEW_LPI_BR_Demographics_BirthDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVIEW_LPI_BR_Demographics_BirthDate_Enabled), 5, 0)), true);
         edtVIEW_LPI_BR_Demographics_Ethnic_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVIEW_LPI_BR_Demographics_Ethnic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVIEW_LPI_BR_Demographics_Ethnic_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1O71( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1O0( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020228159390", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("view_lastest_patient_info.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z520VIEW_LPI_BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z519VIEW_LPI_BR_Information_PatientNo", Z519VIEW_LPI_BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "Z521VIEW_LPI_BR_Encounter_AdmitDate", context.localUtil.TToC( Z521VIEW_LPI_BR_Encounter_AdmitDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z522VIEW_LPI_BR_Demographics_Sex", Z522VIEW_LPI_BR_Demographics_Sex);
         GxWebStd.gx_hidden_field( context, "Z523VIEW_LPI_BR_Demographics_BirthDate", context.localUtil.DToC( Z523VIEW_LPI_BR_Demographics_BirthDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z524VIEW_LPI_BR_Demographics_Ethnic", Z524VIEW_LPI_BR_Demographics_Ethnic);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
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
         return formatLink("view_lastest_patient_info.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "view_lastest_patient_info" ;
      }

      public override String GetPgmdesc( )
      {
         return "view_lastest_patient_info" ;
      }

      protected void InitializeNonKey1O71( )
      {
         A519VIEW_LPI_BR_Information_PatientNo = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A519VIEW_LPI_BR_Information_PatientNo", A519VIEW_LPI_BR_Information_PatientNo);
         A521VIEW_LPI_BR_Encounter_AdmitDate = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A521VIEW_LPI_BR_Encounter_AdmitDate", context.localUtil.TToC( A521VIEW_LPI_BR_Encounter_AdmitDate, 10, 8, 0, 0, "/", ":", " "));
         A522VIEW_LPI_BR_Demographics_Sex = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A522VIEW_LPI_BR_Demographics_Sex", A522VIEW_LPI_BR_Demographics_Sex);
         A523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A523VIEW_LPI_BR_Demographics_BirthDate", context.localUtil.Format(A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
         A524VIEW_LPI_BR_Demographics_Ethnic = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A524VIEW_LPI_BR_Demographics_Ethnic", A524VIEW_LPI_BR_Demographics_Ethnic);
         Z519VIEW_LPI_BR_Information_PatientNo = "";
         Z521VIEW_LPI_BR_Encounter_AdmitDate = (DateTime)(DateTime.MinValue);
         Z522VIEW_LPI_BR_Demographics_Sex = "";
         Z523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         Z524VIEW_LPI_BR_Demographics_Ethnic = "";
      }

      protected void InitAll1O71( )
      {
         A520VIEW_LPI_BR_Information_ID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A520VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A520VIEW_LPI_BR_Information_ID), 18, 0)));
         InitializeNonKey1O71( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228159395", true);
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
         context.AddJavascriptSource("view_lastest_patient_info.js", "?2020228159395", false);
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
         edtVIEW_LPI_BR_Information_ID_Internalname = "VIEW_LPI_BR_INFORMATION_ID";
         edtVIEW_LPI_BR_Information_PatientNo_Internalname = "VIEW_LPI_BR_INFORMATION_PATIENTNO";
         edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname = "VIEW_LPI_BR_ENCOUNTER_ADMITDATE";
         edtVIEW_LPI_BR_Demographics_Sex_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_SEX";
         edtVIEW_LPI_BR_Demographics_BirthDate_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE";
         edtVIEW_LPI_BR_Demographics_Ethnic_Internalname = "VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC";
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
         Form.Caption = "view_lastest_patient_info";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtVIEW_LPI_BR_Demographics_Ethnic_Enabled = 1;
         edtVIEW_LPI_BR_Demographics_BirthDate_Jsonclick = "";
         edtVIEW_LPI_BR_Demographics_BirthDate_Enabled = 1;
         edtVIEW_LPI_BR_Demographics_Sex_Enabled = 1;
         edtVIEW_LPI_BR_Encounter_AdmitDate_Jsonclick = "";
         edtVIEW_LPI_BR_Encounter_AdmitDate_Enabled = 1;
         edtVIEW_LPI_BR_Information_PatientNo_Enabled = 1;
         edtVIEW_LPI_BR_Information_ID_Jsonclick = "";
         edtVIEW_LPI_BR_Information_ID_Enabled = 1;
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
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtVIEW_LPI_BR_Information_PatientNo_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_View_lpi_br_information_id( long GX_Parm1 ,
                                                    String GX_Parm2 ,
                                                    DateTime GX_Parm3 ,
                                                    String GX_Parm4 ,
                                                    DateTime GX_Parm5 ,
                                                    String GX_Parm6 )
      {
         A520VIEW_LPI_BR_Information_ID = GX_Parm1;
         A519VIEW_LPI_BR_Information_PatientNo = GX_Parm2;
         A521VIEW_LPI_BR_Encounter_AdmitDate = GX_Parm3;
         A522VIEW_LPI_BR_Demographics_Sex = GX_Parm4;
         A523VIEW_LPI_BR_Demographics_BirthDate = GX_Parm5;
         A524VIEW_LPI_BR_Demographics_Ethnic = GX_Parm6;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A519VIEW_LPI_BR_Information_PatientNo);
         isValidOutput.Add(context.localUtil.TToC( A521VIEW_LPI_BR_Encounter_AdmitDate, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(A522VIEW_LPI_BR_Demographics_Sex);
         isValidOutput.Add(context.localUtil.Format(A523VIEW_LPI_BR_Demographics_BirthDate, "9999/99/99"));
         isValidOutput.Add(A524VIEW_LPI_BR_Demographics_Ethnic);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z520VIEW_LPI_BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(Z519VIEW_LPI_BR_Information_PatientNo);
         isValidOutput.Add(context.localUtil.TToC( Z521VIEW_LPI_BR_Encounter_AdmitDate, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(Z522VIEW_LPI_BR_Demographics_Sex);
         isValidOutput.Add(context.localUtil.DToC( Z523VIEW_LPI_BR_Demographics_BirthDate, 0, "/"));
         isValidOutput.Add(Z524VIEW_LPI_BR_Demographics_Ethnic);
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
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
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z519VIEW_LPI_BR_Information_PatientNo = "";
         Z521VIEW_LPI_BR_Encounter_AdmitDate = (DateTime)(DateTime.MinValue);
         Z522VIEW_LPI_BR_Demographics_Sex = "";
         Z523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         Z524VIEW_LPI_BR_Demographics_Ethnic = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A519VIEW_LPI_BR_Information_PatientNo = "";
         A521VIEW_LPI_BR_Encounter_AdmitDate = (DateTime)(DateTime.MinValue);
         A522VIEW_LPI_BR_Demographics_Sex = "";
         A523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         A524VIEW_LPI_BR_Demographics_Ethnic = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T001O4_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         T001O4_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         T001O4_A521VIEW_LPI_BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T001O4_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         T001O4_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         T001O4_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         T001O5_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         T001O3_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         T001O3_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         T001O3_A521VIEW_LPI_BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T001O3_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         T001O3_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         T001O3_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         sMode71 = "";
         T001O6_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         T001O7_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         T001O2_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         T001O2_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         T001O2_A521VIEW_LPI_BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T001O2_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         T001O2_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         T001O2_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         T001O11_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.view_lastest_patient_info__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.view_lastest_patient_info__default(),
            new Object[][] {
                new Object[] {
               T001O2_A520VIEW_LPI_BR_Information_ID, T001O2_A519VIEW_LPI_BR_Information_PatientNo, T001O2_A521VIEW_LPI_BR_Encounter_AdmitDate, T001O2_A522VIEW_LPI_BR_Demographics_Sex, T001O2_A523VIEW_LPI_BR_Demographics_BirthDate, T001O2_A524VIEW_LPI_BR_Demographics_Ethnic
               }
               , new Object[] {
               T001O3_A520VIEW_LPI_BR_Information_ID, T001O3_A519VIEW_LPI_BR_Information_PatientNo, T001O3_A521VIEW_LPI_BR_Encounter_AdmitDate, T001O3_A522VIEW_LPI_BR_Demographics_Sex, T001O3_A523VIEW_LPI_BR_Demographics_BirthDate, T001O3_A524VIEW_LPI_BR_Demographics_Ethnic
               }
               , new Object[] {
               T001O4_A520VIEW_LPI_BR_Information_ID, T001O4_A519VIEW_LPI_BR_Information_PatientNo, T001O4_A521VIEW_LPI_BR_Encounter_AdmitDate, T001O4_A522VIEW_LPI_BR_Demographics_Sex, T001O4_A523VIEW_LPI_BR_Demographics_BirthDate, T001O4_A524VIEW_LPI_BR_Demographics_Ethnic
               }
               , new Object[] {
               T001O5_A520VIEW_LPI_BR_Information_ID
               }
               , new Object[] {
               T001O6_A520VIEW_LPI_BR_Information_ID
               }
               , new Object[] {
               T001O7_A520VIEW_LPI_BR_Information_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001O11_A520VIEW_LPI_BR_Information_ID
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
      private short RcdFound71 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtVIEW_LPI_BR_Information_ID_Enabled ;
      private int edtVIEW_LPI_BR_Information_PatientNo_Enabled ;
      private int edtVIEW_LPI_BR_Encounter_AdmitDate_Enabled ;
      private int edtVIEW_LPI_BR_Demographics_Sex_Enabled ;
      private int edtVIEW_LPI_BR_Demographics_BirthDate_Enabled ;
      private int edtVIEW_LPI_BR_Demographics_Ethnic_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z520VIEW_LPI_BR_Information_ID ;
      private long A520VIEW_LPI_BR_Information_ID ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtVIEW_LPI_BR_Information_ID_Internalname ;
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
      private String edtVIEW_LPI_BR_Information_ID_Jsonclick ;
      private String edtVIEW_LPI_BR_Information_PatientNo_Internalname ;
      private String edtVIEW_LPI_BR_Encounter_AdmitDate_Internalname ;
      private String edtVIEW_LPI_BR_Encounter_AdmitDate_Jsonclick ;
      private String edtVIEW_LPI_BR_Demographics_Sex_Internalname ;
      private String edtVIEW_LPI_BR_Demographics_BirthDate_Internalname ;
      private String edtVIEW_LPI_BR_Demographics_BirthDate_Jsonclick ;
      private String edtVIEW_LPI_BR_Demographics_Ethnic_Internalname ;
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
      private String sMode71 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z521VIEW_LPI_BR_Encounter_AdmitDate ;
      private DateTime A521VIEW_LPI_BR_Encounter_AdmitDate ;
      private DateTime Z523VIEW_LPI_BR_Demographics_BirthDate ;
      private DateTime A523VIEW_LPI_BR_Demographics_BirthDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private String Z519VIEW_LPI_BR_Information_PatientNo ;
      private String Z522VIEW_LPI_BR_Demographics_Sex ;
      private String Z524VIEW_LPI_BR_Demographics_Ethnic ;
      private String A519VIEW_LPI_BR_Information_PatientNo ;
      private String A522VIEW_LPI_BR_Demographics_Sex ;
      private String A524VIEW_LPI_BR_Demographics_Ethnic ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T001O4_A520VIEW_LPI_BR_Information_ID ;
      private String[] T001O4_A519VIEW_LPI_BR_Information_PatientNo ;
      private DateTime[] T001O4_A521VIEW_LPI_BR_Encounter_AdmitDate ;
      private String[] T001O4_A522VIEW_LPI_BR_Demographics_Sex ;
      private DateTime[] T001O4_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] T001O4_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private long[] T001O5_A520VIEW_LPI_BR_Information_ID ;
      private long[] T001O3_A520VIEW_LPI_BR_Information_ID ;
      private String[] T001O3_A519VIEW_LPI_BR_Information_PatientNo ;
      private DateTime[] T001O3_A521VIEW_LPI_BR_Encounter_AdmitDate ;
      private String[] T001O3_A522VIEW_LPI_BR_Demographics_Sex ;
      private DateTime[] T001O3_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] T001O3_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private long[] T001O6_A520VIEW_LPI_BR_Information_ID ;
      private long[] T001O7_A520VIEW_LPI_BR_Information_ID ;
      private long[] T001O2_A520VIEW_LPI_BR_Information_ID ;
      private String[] T001O2_A519VIEW_LPI_BR_Information_PatientNo ;
      private DateTime[] T001O2_A521VIEW_LPI_BR_Encounter_AdmitDate ;
      private String[] T001O2_A522VIEW_LPI_BR_Demographics_Sex ;
      private DateTime[] T001O2_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] T001O2_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private long[] T001O11_A520VIEW_LPI_BR_Information_ID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
   }

   public class view_lastest_patient_info__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class view_lastest_patient_info__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[6])
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new ForEachCursor(def[9])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT001O4 ;
        prmT001O4 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001O5 ;
        prmT001O5 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001O3 ;
        prmT001O3 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001O6 ;
        prmT001O6 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001O7 ;
        prmT001O7 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001O2 ;
        prmT001O2 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001O8 ;
        prmT001O8 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@VIEW_LPI_BR_Information_PatientNo",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@VIEW_LPI_BR_Encounter_AdmitDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_Sex",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_BirthDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_Ethnic",SqlDbType.NVarChar,4000,0}
        } ;
        Object[] prmT001O9 ;
        prmT001O9 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_PatientNo",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@VIEW_LPI_BR_Encounter_AdmitDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_Sex",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_BirthDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_Ethnic",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001O10 ;
        prmT001O10 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001O11 ;
        prmT001O11 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T001O2", "SELECT [VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Information_PatientNo], [VIEW_LPI_BR_Encounter_AdmitDate], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Demographics_Ethnic] FROM dbo.[view_lastest_patient_info] WITH (UPDLOCK) WHERE [VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O2,1,0,true,false )
           ,new CursorDef("T001O3", "SELECT [VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Information_PatientNo], [VIEW_LPI_BR_Encounter_AdmitDate], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Demographics_Ethnic] FROM dbo.[view_lastest_patient_info] WITH (NOLOCK) WHERE [VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O3,1,0,true,false )
           ,new CursorDef("T001O4", "SELECT TM1.[VIEW_LPI_BR_Information_ID], TM1.[VIEW_LPI_BR_Information_PatientNo], TM1.[VIEW_LPI_BR_Encounter_AdmitDate], TM1.[VIEW_LPI_BR_Demographics_Sex], TM1.[VIEW_LPI_BR_Demographics_BirthDate], TM1.[VIEW_LPI_BR_Demographics_Ethnic] FROM dbo.[view_lastest_patient_info] TM1 WITH (NOLOCK) WHERE TM1.[VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID ORDER BY TM1.[VIEW_LPI_BR_Information_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001O4,100,0,true,false )
           ,new CursorDef("T001O5", "SELECT [VIEW_LPI_BR_Information_ID] FROM dbo.[view_lastest_patient_info] WITH (NOLOCK) WHERE [VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001O5,1,0,true,false )
           ,new CursorDef("T001O6", "SELECT TOP 1 [VIEW_LPI_BR_Information_ID] FROM dbo.[view_lastest_patient_info] WITH (NOLOCK) WHERE ( [VIEW_LPI_BR_Information_ID] > @VIEW_LPI_BR_Information_ID) ORDER BY [VIEW_LPI_BR_Information_ID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001O6,1,0,true,true )
           ,new CursorDef("T001O7", "SELECT TOP 1 [VIEW_LPI_BR_Information_ID] FROM dbo.[view_lastest_patient_info] WITH (NOLOCK) WHERE ( [VIEW_LPI_BR_Information_ID] < @VIEW_LPI_BR_Information_ID) ORDER BY [VIEW_LPI_BR_Information_ID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001O7,1,0,true,true )
           ,new CursorDef("T001O8", "INSERT INTO dbo.[view_lastest_patient_info]([VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Information_PatientNo], [VIEW_LPI_BR_Encounter_AdmitDate], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Demographics_Ethnic]) VALUES(@VIEW_LPI_BR_Information_ID, @VIEW_LPI_BR_Information_PatientNo, @VIEW_LPI_BR_Encounter_AdmitDate, @VIEW_LPI_BR_Demographics_Sex, @VIEW_LPI_BR_Demographics_BirthDate, @VIEW_LPI_BR_Demographics_Ethnic)", GxErrorMask.GX_NOMASK,prmT001O8)
           ,new CursorDef("T001O9", "UPDATE dbo.[view_lastest_patient_info] SET [VIEW_LPI_BR_Information_PatientNo]=@VIEW_LPI_BR_Information_PatientNo, [VIEW_LPI_BR_Encounter_AdmitDate]=@VIEW_LPI_BR_Encounter_AdmitDate, [VIEW_LPI_BR_Demographics_Sex]=@VIEW_LPI_BR_Demographics_Sex, [VIEW_LPI_BR_Demographics_BirthDate]=@VIEW_LPI_BR_Demographics_BirthDate, [VIEW_LPI_BR_Demographics_Ethnic]=@VIEW_LPI_BR_Demographics_Ethnic  WHERE [VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID", GxErrorMask.GX_NOMASK,prmT001O9)
           ,new CursorDef("T001O10", "DELETE FROM dbo.[view_lastest_patient_info]  WHERE [VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID", GxErrorMask.GX_NOMASK,prmT001O10)
           ,new CursorDef("T001O11", "SELECT [VIEW_LPI_BR_Information_ID] FROM dbo.[view_lastest_patient_info] WITH (NOLOCK) ORDER BY [VIEW_LPI_BR_Information_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001O11,100,0,true,false )
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
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
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
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameterDatetime(3, (DateTime)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (DateTime)parms[4]);
              stmt.SetParameter(6, (String)parms[5]);
              return;
           case 7 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameterDatetime(2, (DateTime)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (DateTime)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
