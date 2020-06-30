/*
               File: View_New_Encounter2
        Description: View_New_Encounter2
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:5.54
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
   public class view_new_encounter2 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "View_New_Encounter2", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public view_new_encounter2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public view_new_encounter2( IGxContext context )
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
         cmbView_New_Encounter2view_NE_Status = new GXCombobox();
         chkView_New_Encounter2view_NE_IsRandRecheck = new GXCheckbox();
         chkView_New_Encounter2view_NE_IsRandApprove = new GXCheckbox();
         chkView_New_Encounter2view_NE_IsUpdate = new GXCheckbox();
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
         if ( cmbView_New_Encounter2view_NE_Status.ItemCount > 0 )
         {
            A595View_New_Encounter2view_NE_Status = (short)(NumberUtil.Val( cmbView_New_Encounter2view_NE_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0))), "."));
            n595View_New_Encounter2view_NE_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A595View_New_Encounter2view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbView_New_Encounter2view_NE_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbView_New_Encounter2view_NE_Status_Internalname, "Values", cmbView_New_Encounter2view_NE_Status.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "View_New_Encounter2", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_View_New_Encounter2.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_View_New_Encounter2.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtView_New_Encounter2view_NE_EncounterID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtView_New_Encounter2view_NE_EncounterID_Internalname, "view_NE_Encounter ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtView_New_Encounter2view_NE_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0, ".", "")), ((edtView_New_Encounter2view_NE_EncounterID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A591View_New_Encounter2view_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A591View_New_Encounter2view_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtView_New_Encounter2view_NE_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtView_New_Encounter2view_NE_EncounterID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtView_New_Encounter2view_NE_ENCType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtView_New_Encounter2view_NE_ENCType_Internalname, "view_NE_ENCType", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtView_New_Encounter2view_NE_ENCType_Internalname, A592View_New_Encounter2view_NE_ENCType, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, 1, edtView_New_Encounter2view_NE_ENCType_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtView_New_Encounter2view_NE_Departmentadm_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtView_New_Encounter2view_NE_Departmentadm_Internalname, "view_NE_Departmentadm", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtView_New_Encounter2view_NE_Departmentadm_Internalname, A593View_New_Encounter2view_NE_Departmentadm, StringUtil.RTrim( context.localUtil.Format( A593View_New_Encounter2view_NE_Departmentadm, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtView_New_Encounter2view_NE_Departmentadm_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtView_New_Encounter2view_NE_Departmentadm_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtView_New_Encounter2view_NE_AdmitDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtView_New_Encounter2view_NE_AdmitDate_Internalname, "view_NE_Admit Date", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtView_New_Encounter2view_NE_AdmitDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtView_New_Encounter2view_NE_AdmitDate_Internalname, context.localUtil.Format(A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"), context.localUtil.Format( A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtView_New_Encounter2view_NE_AdmitDate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtView_New_Encounter2view_NE_AdmitDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_bitmap( context, edtView_New_Encounter2view_NE_AdmitDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtView_New_Encounter2view_NE_AdmitDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_View_New_Encounter2.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbView_New_Encounter2view_NE_Status_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbView_New_Encounter2view_NE_Status_Internalname, "view_NE_Status", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbView_New_Encounter2view_NE_Status, cmbView_New_Encounter2view_NE_Status_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0)), 1, cmbView_New_Encounter2view_NE_Status_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbView_New_Encounter2view_NE_Status.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "", true, "HLP_View_New_Encounter2.htm");
            cmbView_New_Encounter2view_NE_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbView_New_Encounter2view_NE_Status_Internalname, "Values", (String)(cmbView_New_Encounter2view_NE_Status.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkView_New_Encounter2view_NE_IsRandRecheck_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkView_New_Encounter2view_NE_IsRandRecheck_Internalname, "view_NE_Is Rand Recheck", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkView_New_Encounter2view_NE_IsRandRecheck_Internalname, StringUtil.BoolToStr( A596View_New_Encounter2view_NE_IsRandRecheck), "", "view_NE_Is Rand Recheck", 1, chkView_New_Encounter2view_NE_IsRandRecheck.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(53, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkView_New_Encounter2view_NE_IsRandApprove_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkView_New_Encounter2view_NE_IsRandApprove_Internalname, "view_NE_Is Rand Approve", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkView_New_Encounter2view_NE_IsRandApprove_Internalname, StringUtil.BoolToStr( A597View_New_Encounter2view_NE_IsRandApprove), "", "view_NE_Is Rand Approve", 1, chkView_New_Encounter2view_NE_IsRandApprove.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(58, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkView_New_Encounter2view_NE_IsUpdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkView_New_Encounter2view_NE_IsUpdate_Internalname, "view_NE_Is Update", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkView_New_Encounter2view_NE_IsUpdate_Internalname, StringUtil.BoolToStr( A598View_New_Encounter2view_NE_IsUpdate), "", "view_NE_Is Update", 1, chkView_New_Encounter2view_NE_IsUpdate.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(63, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtView_New_Encounter2view_NE_TenantTenantCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtView_New_Encounter2view_NE_TenantTenantCode_Internalname, "view_NE_Tenant Tenant Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtView_New_Encounter2view_NE_TenantTenantCode_Internalname, A599View_New_Encounter2view_NE_TenantTenantCode, StringUtil.RTrim( context.localUtil.Format( A599View_New_Encounter2view_NE_TenantTenantCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtView_New_Encounter2view_NE_TenantTenantCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtView_New_Encounter2view_NE_TenantTenantCode_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtView_New_Encounter2view_NE_Information_ID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtView_New_Encounter2view_NE_Information_ID_Internalname, "view_NE_Information_ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtView_New_Encounter2view_NE_Information_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A600View_New_Encounter2view_NE_Information_ID), 18, 0, ".", "")), ((edtView_New_Encounter2view_NE_Information_ID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A600View_New_Encounter2view_NE_Information_ID), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A600View_New_Encounter2view_NE_Information_ID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtView_New_Encounter2view_NE_Information_ID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtView_New_Encounter2view_NE_Information_ID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtView_New_Encounter2view_NE_Information_PatientNo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtView_New_Encounter2view_NE_Information_PatientNo_Internalname, "view_NE_Information_Patient No", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtView_New_Encounter2view_NE_Information_PatientNo_Internalname, A601View_New_Encounter2view_NE_Information_PatientNo, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", 0, 1, edtView_New_Encounter2view_NE_Information_PatientNo_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_View_New_Encounter2.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter2.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter2.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtView_New_Encounter2view_NE_EncounterID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtView_New_Encounter2view_NE_EncounterID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID");
                  AnyError = 1;
                  GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A591View_New_Encounter2view_NE_EncounterID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
               }
               else
               {
                  A591View_New_Encounter2view_NE_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtView_New_Encounter2view_NE_EncounterID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
               }
               A592View_New_Encounter2view_NE_ENCType = cgiGet( edtView_New_Encounter2view_NE_ENCType_Internalname);
               n592View_New_Encounter2view_NE_ENCType = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A592View_New_Encounter2view_NE_ENCType", A592View_New_Encounter2view_NE_ENCType);
               n592View_New_Encounter2view_NE_ENCType = (String.IsNullOrEmpty(StringUtil.RTrim( A592View_New_Encounter2view_NE_ENCType)) ? true : false);
               A593View_New_Encounter2view_NE_Departmentadm = cgiGet( edtView_New_Encounter2view_NE_Departmentadm_Internalname);
               n593View_New_Encounter2view_NE_Departmentadm = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A593View_New_Encounter2view_NE_Departmentadm", A593View_New_Encounter2view_NE_Departmentadm);
               n593View_New_Encounter2view_NE_Departmentadm = (String.IsNullOrEmpty(StringUtil.RTrim( A593View_New_Encounter2view_NE_Departmentadm)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtView_New_Encounter2view_NE_AdmitDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"View_New_Encounter2view_NE_Admit Date"}), 1, "VIEW_NEW_ENCOUNTER2VIEW_NE_ADMITDATE");
                  AnyError = 1;
                  GX_FocusControl = edtView_New_Encounter2view_NE_AdmitDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
                  n594View_New_Encounter2view_NE_AdmitDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A594View_New_Encounter2view_NE_AdmitDate", context.localUtil.Format(A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"));
               }
               else
               {
                  A594View_New_Encounter2view_NE_AdmitDate = context.localUtil.CToD( cgiGet( edtView_New_Encounter2view_NE_AdmitDate_Internalname), 0);
                  n594View_New_Encounter2view_NE_AdmitDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A594View_New_Encounter2view_NE_AdmitDate", context.localUtil.Format(A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"));
               }
               n594View_New_Encounter2view_NE_AdmitDate = ((DateTime.MinValue==A594View_New_Encounter2view_NE_AdmitDate) ? true : false);
               cmbView_New_Encounter2view_NE_Status.CurrentValue = cgiGet( cmbView_New_Encounter2view_NE_Status_Internalname);
               A595View_New_Encounter2view_NE_Status = (short)(NumberUtil.Val( cgiGet( cmbView_New_Encounter2view_NE_Status_Internalname), "."));
               n595View_New_Encounter2view_NE_Status = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A595View_New_Encounter2view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0)));
               n595View_New_Encounter2view_NE_Status = ((0==A595View_New_Encounter2view_NE_Status) ? true : false);
               A596View_New_Encounter2view_NE_IsRandRecheck = StringUtil.StrToBool( cgiGet( chkView_New_Encounter2view_NE_IsRandRecheck_Internalname));
               n596View_New_Encounter2view_NE_IsRandRecheck = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A596View_New_Encounter2view_NE_IsRandRecheck", A596View_New_Encounter2view_NE_IsRandRecheck);
               n596View_New_Encounter2view_NE_IsRandRecheck = ((false==A596View_New_Encounter2view_NE_IsRandRecheck) ? true : false);
               A597View_New_Encounter2view_NE_IsRandApprove = StringUtil.StrToBool( cgiGet( chkView_New_Encounter2view_NE_IsRandApprove_Internalname));
               n597View_New_Encounter2view_NE_IsRandApprove = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A597View_New_Encounter2view_NE_IsRandApprove", A597View_New_Encounter2view_NE_IsRandApprove);
               n597View_New_Encounter2view_NE_IsRandApprove = ((false==A597View_New_Encounter2view_NE_IsRandApprove) ? true : false);
               A598View_New_Encounter2view_NE_IsUpdate = StringUtil.StrToBool( cgiGet( chkView_New_Encounter2view_NE_IsUpdate_Internalname));
               n598View_New_Encounter2view_NE_IsUpdate = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A598View_New_Encounter2view_NE_IsUpdate", A598View_New_Encounter2view_NE_IsUpdate);
               n598View_New_Encounter2view_NE_IsUpdate = ((false==A598View_New_Encounter2view_NE_IsUpdate) ? true : false);
               A599View_New_Encounter2view_NE_TenantTenantCode = cgiGet( edtView_New_Encounter2view_NE_TenantTenantCode_Internalname);
               n599View_New_Encounter2view_NE_TenantTenantCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A599View_New_Encounter2view_NE_TenantTenantCode", A599View_New_Encounter2view_NE_TenantTenantCode);
               n599View_New_Encounter2view_NE_TenantTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A599View_New_Encounter2view_NE_TenantTenantCode)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtView_New_Encounter2view_NE_Information_ID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtView_New_Encounter2view_NE_Information_ID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_ID");
                  AnyError = 1;
                  GX_FocusControl = edtView_New_Encounter2view_NE_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A600View_New_Encounter2view_NE_Information_ID = 0;
                  n600View_New_Encounter2view_NE_Information_ID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A600View_New_Encounter2view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A600View_New_Encounter2view_NE_Information_ID), 18, 0)));
               }
               else
               {
                  A600View_New_Encounter2view_NE_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtView_New_Encounter2view_NE_Information_ID_Internalname), ".", ","));
                  n600View_New_Encounter2view_NE_Information_ID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A600View_New_Encounter2view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A600View_New_Encounter2view_NE_Information_ID), 18, 0)));
               }
               n600View_New_Encounter2view_NE_Information_ID = ((0==A600View_New_Encounter2view_NE_Information_ID) ? true : false);
               A601View_New_Encounter2view_NE_Information_PatientNo = cgiGet( edtView_New_Encounter2view_NE_Information_PatientNo_Internalname);
               n601View_New_Encounter2view_NE_Information_PatientNo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A601View_New_Encounter2view_NE_Information_PatientNo", A601View_New_Encounter2view_NE_Information_PatientNo);
               n601View_New_Encounter2view_NE_Information_PatientNo = (String.IsNullOrEmpty(StringUtil.RTrim( A601View_New_Encounter2view_NE_Information_PatientNo)) ? true : false);
               /* Read saved values. */
               Z591View_New_Encounter2view_NE_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z591View_New_Encounter2view_NE_EncounterID"), ".", ","));
               Z592View_New_Encounter2view_NE_ENCType = cgiGet( "Z592View_New_Encounter2view_NE_ENCType");
               n592View_New_Encounter2view_NE_ENCType = (String.IsNullOrEmpty(StringUtil.RTrim( A592View_New_Encounter2view_NE_ENCType)) ? true : false);
               Z593View_New_Encounter2view_NE_Departmentadm = cgiGet( "Z593View_New_Encounter2view_NE_Departmentadm");
               n593View_New_Encounter2view_NE_Departmentadm = (String.IsNullOrEmpty(StringUtil.RTrim( A593View_New_Encounter2view_NE_Departmentadm)) ? true : false);
               Z594View_New_Encounter2view_NE_AdmitDate = context.localUtil.CToD( cgiGet( "Z594View_New_Encounter2view_NE_AdmitDate"), 0);
               n594View_New_Encounter2view_NE_AdmitDate = ((DateTime.MinValue==A594View_New_Encounter2view_NE_AdmitDate) ? true : false);
               Z595View_New_Encounter2view_NE_Status = (short)(context.localUtil.CToN( cgiGet( "Z595View_New_Encounter2view_NE_Status"), ".", ","));
               n595View_New_Encounter2view_NE_Status = ((0==A595View_New_Encounter2view_NE_Status) ? true : false);
               Z596View_New_Encounter2view_NE_IsRandRecheck = StringUtil.StrToBool( cgiGet( "Z596View_New_Encounter2view_NE_IsRandRecheck"));
               n596View_New_Encounter2view_NE_IsRandRecheck = ((false==A596View_New_Encounter2view_NE_IsRandRecheck) ? true : false);
               Z597View_New_Encounter2view_NE_IsRandApprove = StringUtil.StrToBool( cgiGet( "Z597View_New_Encounter2view_NE_IsRandApprove"));
               n597View_New_Encounter2view_NE_IsRandApprove = ((false==A597View_New_Encounter2view_NE_IsRandApprove) ? true : false);
               Z598View_New_Encounter2view_NE_IsUpdate = StringUtil.StrToBool( cgiGet( "Z598View_New_Encounter2view_NE_IsUpdate"));
               n598View_New_Encounter2view_NE_IsUpdate = ((false==A598View_New_Encounter2view_NE_IsUpdate) ? true : false);
               Z599View_New_Encounter2view_NE_TenantTenantCode = cgiGet( "Z599View_New_Encounter2view_NE_TenantTenantCode");
               n599View_New_Encounter2view_NE_TenantTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A599View_New_Encounter2view_NE_TenantTenantCode)) ? true : false);
               Z600View_New_Encounter2view_NE_Information_ID = (long)(context.localUtil.CToN( cgiGet( "Z600View_New_Encounter2view_NE_Information_ID"), ".", ","));
               n600View_New_Encounter2view_NE_Information_ID = ((0==A600View_New_Encounter2view_NE_Information_ID) ? true : false);
               Z601View_New_Encounter2view_NE_Information_PatientNo = cgiGet( "Z601View_New_Encounter2view_NE_Information_PatientNo");
               n601View_New_Encounter2view_NE_Information_PatientNo = (String.IsNullOrEmpty(StringUtil.RTrim( A601View_New_Encounter2view_NE_Information_PatientNo)) ? true : false);
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
                  A591View_New_Encounter2view_NE_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
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
               InitAll1T75( ) ;
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
         DisableAttributes1T75( ) ;
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

      protected void ResetCaption1T0( )
      {
      }

      protected void ZM1T75( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z592View_New_Encounter2view_NE_ENCType = T001T3_A592View_New_Encounter2view_NE_ENCType[0];
               Z593View_New_Encounter2view_NE_Departmentadm = T001T3_A593View_New_Encounter2view_NE_Departmentadm[0];
               Z594View_New_Encounter2view_NE_AdmitDate = T001T3_A594View_New_Encounter2view_NE_AdmitDate[0];
               Z595View_New_Encounter2view_NE_Status = T001T3_A595View_New_Encounter2view_NE_Status[0];
               Z596View_New_Encounter2view_NE_IsRandRecheck = T001T3_A596View_New_Encounter2view_NE_IsRandRecheck[0];
               Z597View_New_Encounter2view_NE_IsRandApprove = T001T3_A597View_New_Encounter2view_NE_IsRandApprove[0];
               Z598View_New_Encounter2view_NE_IsUpdate = T001T3_A598View_New_Encounter2view_NE_IsUpdate[0];
               Z599View_New_Encounter2view_NE_TenantTenantCode = T001T3_A599View_New_Encounter2view_NE_TenantTenantCode[0];
               Z600View_New_Encounter2view_NE_Information_ID = T001T3_A600View_New_Encounter2view_NE_Information_ID[0];
               Z601View_New_Encounter2view_NE_Information_PatientNo = T001T3_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            }
            else
            {
               Z592View_New_Encounter2view_NE_ENCType = A592View_New_Encounter2view_NE_ENCType;
               Z593View_New_Encounter2view_NE_Departmentadm = A593View_New_Encounter2view_NE_Departmentadm;
               Z594View_New_Encounter2view_NE_AdmitDate = A594View_New_Encounter2view_NE_AdmitDate;
               Z595View_New_Encounter2view_NE_Status = A595View_New_Encounter2view_NE_Status;
               Z596View_New_Encounter2view_NE_IsRandRecheck = A596View_New_Encounter2view_NE_IsRandRecheck;
               Z597View_New_Encounter2view_NE_IsRandApprove = A597View_New_Encounter2view_NE_IsRandApprove;
               Z598View_New_Encounter2view_NE_IsUpdate = A598View_New_Encounter2view_NE_IsUpdate;
               Z599View_New_Encounter2view_NE_TenantTenantCode = A599View_New_Encounter2view_NE_TenantTenantCode;
               Z600View_New_Encounter2view_NE_Information_ID = A600View_New_Encounter2view_NE_Information_ID;
               Z601View_New_Encounter2view_NE_Information_PatientNo = A601View_New_Encounter2view_NE_Information_PatientNo;
            }
         }
         if ( GX_JID == -3 )
         {
            Z591View_New_Encounter2view_NE_EncounterID = A591View_New_Encounter2view_NE_EncounterID;
            Z592View_New_Encounter2view_NE_ENCType = A592View_New_Encounter2view_NE_ENCType;
            Z593View_New_Encounter2view_NE_Departmentadm = A593View_New_Encounter2view_NE_Departmentadm;
            Z594View_New_Encounter2view_NE_AdmitDate = A594View_New_Encounter2view_NE_AdmitDate;
            Z595View_New_Encounter2view_NE_Status = A595View_New_Encounter2view_NE_Status;
            Z596View_New_Encounter2view_NE_IsRandRecheck = A596View_New_Encounter2view_NE_IsRandRecheck;
            Z597View_New_Encounter2view_NE_IsRandApprove = A597View_New_Encounter2view_NE_IsRandApprove;
            Z598View_New_Encounter2view_NE_IsUpdate = A598View_New_Encounter2view_NE_IsUpdate;
            Z599View_New_Encounter2view_NE_TenantTenantCode = A599View_New_Encounter2view_NE_TenantTenantCode;
            Z600View_New_Encounter2view_NE_Information_ID = A600View_New_Encounter2view_NE_Information_ID;
            Z601View_New_Encounter2view_NE_Information_PatientNo = A601View_New_Encounter2view_NE_Information_PatientNo;
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

      protected void Load1T75( )
      {
         /* Using cursor T001T4 */
         pr_default.execute(2, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound75 = 1;
            A592View_New_Encounter2view_NE_ENCType = T001T4_A592View_New_Encounter2view_NE_ENCType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A592View_New_Encounter2view_NE_ENCType", A592View_New_Encounter2view_NE_ENCType);
            n592View_New_Encounter2view_NE_ENCType = T001T4_n592View_New_Encounter2view_NE_ENCType[0];
            A593View_New_Encounter2view_NE_Departmentadm = T001T4_A593View_New_Encounter2view_NE_Departmentadm[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A593View_New_Encounter2view_NE_Departmentadm", A593View_New_Encounter2view_NE_Departmentadm);
            n593View_New_Encounter2view_NE_Departmentadm = T001T4_n593View_New_Encounter2view_NE_Departmentadm[0];
            A594View_New_Encounter2view_NE_AdmitDate = T001T4_A594View_New_Encounter2view_NE_AdmitDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A594View_New_Encounter2view_NE_AdmitDate", context.localUtil.Format(A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"));
            n594View_New_Encounter2view_NE_AdmitDate = T001T4_n594View_New_Encounter2view_NE_AdmitDate[0];
            A595View_New_Encounter2view_NE_Status = T001T4_A595View_New_Encounter2view_NE_Status[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A595View_New_Encounter2view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0)));
            n595View_New_Encounter2view_NE_Status = T001T4_n595View_New_Encounter2view_NE_Status[0];
            A596View_New_Encounter2view_NE_IsRandRecheck = T001T4_A596View_New_Encounter2view_NE_IsRandRecheck[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A596View_New_Encounter2view_NE_IsRandRecheck", A596View_New_Encounter2view_NE_IsRandRecheck);
            n596View_New_Encounter2view_NE_IsRandRecheck = T001T4_n596View_New_Encounter2view_NE_IsRandRecheck[0];
            A597View_New_Encounter2view_NE_IsRandApprove = T001T4_A597View_New_Encounter2view_NE_IsRandApprove[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A597View_New_Encounter2view_NE_IsRandApprove", A597View_New_Encounter2view_NE_IsRandApprove);
            n597View_New_Encounter2view_NE_IsRandApprove = T001T4_n597View_New_Encounter2view_NE_IsRandApprove[0];
            A598View_New_Encounter2view_NE_IsUpdate = T001T4_A598View_New_Encounter2view_NE_IsUpdate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A598View_New_Encounter2view_NE_IsUpdate", A598View_New_Encounter2view_NE_IsUpdate);
            n598View_New_Encounter2view_NE_IsUpdate = T001T4_n598View_New_Encounter2view_NE_IsUpdate[0];
            A599View_New_Encounter2view_NE_TenantTenantCode = T001T4_A599View_New_Encounter2view_NE_TenantTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A599View_New_Encounter2view_NE_TenantTenantCode", A599View_New_Encounter2view_NE_TenantTenantCode);
            n599View_New_Encounter2view_NE_TenantTenantCode = T001T4_n599View_New_Encounter2view_NE_TenantTenantCode[0];
            A600View_New_Encounter2view_NE_Information_ID = T001T4_A600View_New_Encounter2view_NE_Information_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A600View_New_Encounter2view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A600View_New_Encounter2view_NE_Information_ID), 18, 0)));
            n600View_New_Encounter2view_NE_Information_ID = T001T4_n600View_New_Encounter2view_NE_Information_ID[0];
            A601View_New_Encounter2view_NE_Information_PatientNo = T001T4_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A601View_New_Encounter2view_NE_Information_PatientNo", A601View_New_Encounter2view_NE_Information_PatientNo);
            n601View_New_Encounter2view_NE_Information_PatientNo = T001T4_n601View_New_Encounter2view_NE_Information_PatientNo[0];
            ZM1T75( -3) ;
         }
         pr_default.close(2);
         OnLoadActions1T75( ) ;
      }

      protected void OnLoadActions1T75( )
      {
      }

      protected void CheckExtendedTable1T75( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A594View_New_Encounter2view_NE_AdmitDate) || ( A594View_New_Encounter2view_NE_AdmitDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域View_New_Encounter2view_NE_Admit Date超界", "OutOfRange", 1, "VIEW_NEW_ENCOUNTER2VIEW_NE_ADMITDATE");
            AnyError = 1;
            GX_FocusControl = edtView_New_Encounter2view_NE_AdmitDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( A595View_New_Encounter2view_NE_Status == 1 ) || ( A595View_New_Encounter2view_NE_Status == 2 ) || ( A595View_New_Encounter2view_NE_Status == 3 ) || ( A595View_New_Encounter2view_NE_Status == 4 ) || ( A595View_New_Encounter2view_NE_Status == 5 ) || ( A595View_New_Encounter2view_NE_Status == 6 ) || (0==A595View_New_Encounter2view_NE_Status) ) )
         {
            GX_msglist.addItem("域View_New_Encounter2view_NE_Status超界", "OutOfRange", 1, "VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS");
            AnyError = 1;
            GX_FocusControl = cmbView_New_Encounter2view_NE_Status_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1T75( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1T75( )
      {
         /* Using cursor T001T5 */
         pr_default.execute(3, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound75 = 1;
         }
         else
         {
            RcdFound75 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001T3 */
         pr_default.execute(1, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1T75( 3) ;
            RcdFound75 = 1;
            A591View_New_Encounter2view_NE_EncounterID = T001T3_A591View_New_Encounter2view_NE_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
            A592View_New_Encounter2view_NE_ENCType = T001T3_A592View_New_Encounter2view_NE_ENCType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A592View_New_Encounter2view_NE_ENCType", A592View_New_Encounter2view_NE_ENCType);
            n592View_New_Encounter2view_NE_ENCType = T001T3_n592View_New_Encounter2view_NE_ENCType[0];
            A593View_New_Encounter2view_NE_Departmentadm = T001T3_A593View_New_Encounter2view_NE_Departmentadm[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A593View_New_Encounter2view_NE_Departmentadm", A593View_New_Encounter2view_NE_Departmentadm);
            n593View_New_Encounter2view_NE_Departmentadm = T001T3_n593View_New_Encounter2view_NE_Departmentadm[0];
            A594View_New_Encounter2view_NE_AdmitDate = T001T3_A594View_New_Encounter2view_NE_AdmitDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A594View_New_Encounter2view_NE_AdmitDate", context.localUtil.Format(A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"));
            n594View_New_Encounter2view_NE_AdmitDate = T001T3_n594View_New_Encounter2view_NE_AdmitDate[0];
            A595View_New_Encounter2view_NE_Status = T001T3_A595View_New_Encounter2view_NE_Status[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A595View_New_Encounter2view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0)));
            n595View_New_Encounter2view_NE_Status = T001T3_n595View_New_Encounter2view_NE_Status[0];
            A596View_New_Encounter2view_NE_IsRandRecheck = T001T3_A596View_New_Encounter2view_NE_IsRandRecheck[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A596View_New_Encounter2view_NE_IsRandRecheck", A596View_New_Encounter2view_NE_IsRandRecheck);
            n596View_New_Encounter2view_NE_IsRandRecheck = T001T3_n596View_New_Encounter2view_NE_IsRandRecheck[0];
            A597View_New_Encounter2view_NE_IsRandApprove = T001T3_A597View_New_Encounter2view_NE_IsRandApprove[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A597View_New_Encounter2view_NE_IsRandApprove", A597View_New_Encounter2view_NE_IsRandApprove);
            n597View_New_Encounter2view_NE_IsRandApprove = T001T3_n597View_New_Encounter2view_NE_IsRandApprove[0];
            A598View_New_Encounter2view_NE_IsUpdate = T001T3_A598View_New_Encounter2view_NE_IsUpdate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A598View_New_Encounter2view_NE_IsUpdate", A598View_New_Encounter2view_NE_IsUpdate);
            n598View_New_Encounter2view_NE_IsUpdate = T001T3_n598View_New_Encounter2view_NE_IsUpdate[0];
            A599View_New_Encounter2view_NE_TenantTenantCode = T001T3_A599View_New_Encounter2view_NE_TenantTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A599View_New_Encounter2view_NE_TenantTenantCode", A599View_New_Encounter2view_NE_TenantTenantCode);
            n599View_New_Encounter2view_NE_TenantTenantCode = T001T3_n599View_New_Encounter2view_NE_TenantTenantCode[0];
            A600View_New_Encounter2view_NE_Information_ID = T001T3_A600View_New_Encounter2view_NE_Information_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A600View_New_Encounter2view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A600View_New_Encounter2view_NE_Information_ID), 18, 0)));
            n600View_New_Encounter2view_NE_Information_ID = T001T3_n600View_New_Encounter2view_NE_Information_ID[0];
            A601View_New_Encounter2view_NE_Information_PatientNo = T001T3_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A601View_New_Encounter2view_NE_Information_PatientNo", A601View_New_Encounter2view_NE_Information_PatientNo);
            n601View_New_Encounter2view_NE_Information_PatientNo = T001T3_n601View_New_Encounter2view_NE_Information_PatientNo[0];
            Z591View_New_Encounter2view_NE_EncounterID = A591View_New_Encounter2view_NE_EncounterID;
            sMode75 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1T75( ) ;
            if ( AnyError == 1 )
            {
               RcdFound75 = 0;
               InitializeNonKey1T75( ) ;
            }
            Gx_mode = sMode75;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound75 = 0;
            InitializeNonKey1T75( ) ;
            sMode75 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode75;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1T75( ) ;
         if ( RcdFound75 == 0 )
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
         RcdFound75 = 0;
         /* Using cursor T001T6 */
         pr_default.execute(4, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T001T6_A591View_New_Encounter2view_NE_EncounterID[0] < A591View_New_Encounter2view_NE_EncounterID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T001T6_A591View_New_Encounter2view_NE_EncounterID[0] > A591View_New_Encounter2view_NE_EncounterID ) ) )
            {
               A591View_New_Encounter2view_NE_EncounterID = T001T6_A591View_New_Encounter2view_NE_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
               RcdFound75 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound75 = 0;
         /* Using cursor T001T7 */
         pr_default.execute(5, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T001T7_A591View_New_Encounter2view_NE_EncounterID[0] > A591View_New_Encounter2view_NE_EncounterID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T001T7_A591View_New_Encounter2view_NE_EncounterID[0] < A591View_New_Encounter2view_NE_EncounterID ) ) )
            {
               A591View_New_Encounter2view_NE_EncounterID = T001T7_A591View_New_Encounter2view_NE_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
               RcdFound75 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1T75( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1T75( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound75 == 1 )
            {
               if ( A591View_New_Encounter2view_NE_EncounterID != Z591View_New_Encounter2view_NE_EncounterID )
               {
                  A591View_New_Encounter2view_NE_EncounterID = Z591View_New_Encounter2view_NE_EncounterID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID");
                  AnyError = 1;
                  GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1T75( ) ;
                  GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A591View_New_Encounter2view_NE_EncounterID != Z591View_New_Encounter2view_NE_EncounterID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1T75( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID");
                     AnyError = 1;
                     GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1T75( ) ;
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
         if ( A591View_New_Encounter2view_NE_EncounterID != Z591View_New_Encounter2view_NE_EncounterID )
         {
            A591View_New_Encounter2view_NE_EncounterID = Z591View_New_Encounter2view_NE_EncounterID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
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
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtView_New_Encounter2view_NE_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtView_New_Encounter2view_NE_ENCType_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1T75( ) ;
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtView_New_Encounter2view_NE_ENCType_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1T75( ) ;
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
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtView_New_Encounter2view_NE_ENCType_Internalname;
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
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtView_New_Encounter2view_NE_ENCType_Internalname;
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
         ScanStart1T75( ) ;
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound75 != 0 )
            {
               ScanNext1T75( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtView_New_Encounter2view_NE_ENCType_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1T75( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1T75( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001T2 */
            pr_default.execute(0, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"View_New_Encounter"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z592View_New_Encounter2view_NE_ENCType, T001T2_A592View_New_Encounter2view_NE_ENCType[0]) != 0 ) || ( StringUtil.StrCmp(Z593View_New_Encounter2view_NE_Departmentadm, T001T2_A593View_New_Encounter2view_NE_Departmentadm[0]) != 0 ) || ( Z594View_New_Encounter2view_NE_AdmitDate != T001T2_A594View_New_Encounter2view_NE_AdmitDate[0] ) || ( Z595View_New_Encounter2view_NE_Status != T001T2_A595View_New_Encounter2view_NE_Status[0] ) || ( Z596View_New_Encounter2view_NE_IsRandRecheck != T001T2_A596View_New_Encounter2view_NE_IsRandRecheck[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z597View_New_Encounter2view_NE_IsRandApprove != T001T2_A597View_New_Encounter2view_NE_IsRandApprove[0] ) || ( Z598View_New_Encounter2view_NE_IsUpdate != T001T2_A598View_New_Encounter2view_NE_IsUpdate[0] ) || ( StringUtil.StrCmp(Z599View_New_Encounter2view_NE_TenantTenantCode, T001T2_A599View_New_Encounter2view_NE_TenantTenantCode[0]) != 0 ) || ( Z600View_New_Encounter2view_NE_Information_ID != T001T2_A600View_New_Encounter2view_NE_Information_ID[0] ) || ( StringUtil.StrCmp(Z601View_New_Encounter2view_NE_Information_PatientNo, T001T2_A601View_New_Encounter2view_NE_Information_PatientNo[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z592View_New_Encounter2view_NE_ENCType, T001T2_A592View_New_Encounter2view_NE_ENCType[0]) != 0 )
               {
                  GXUtil.WriteLog("view_new_encounter2:[seudo value changed for attri]"+"View_New_Encounter2view_NE_ENCType");
                  GXUtil.WriteLogRaw("Old: ",Z592View_New_Encounter2view_NE_ENCType);
                  GXUtil.WriteLogRaw("Current: ",T001T2_A592View_New_Encounter2view_NE_ENCType[0]);
               }
               if ( StringUtil.StrCmp(Z593View_New_Encounter2view_NE_Departmentadm, T001T2_A593View_New_Encounter2view_NE_Departmentadm[0]) != 0 )
               {
                  GXUtil.WriteLog("view_new_encounter2:[seudo value changed for attri]"+"View_New_Encounter2view_NE_Departmentadm");
                  GXUtil.WriteLogRaw("Old: ",Z593View_New_Encounter2view_NE_Departmentadm);
                  GXUtil.WriteLogRaw("Current: ",T001T2_A593View_New_Encounter2view_NE_Departmentadm[0]);
               }
               if ( Z594View_New_Encounter2view_NE_AdmitDate != T001T2_A594View_New_Encounter2view_NE_AdmitDate[0] )
               {
                  GXUtil.WriteLog("view_new_encounter2:[seudo value changed for attri]"+"View_New_Encounter2view_NE_AdmitDate");
                  GXUtil.WriteLogRaw("Old: ",Z594View_New_Encounter2view_NE_AdmitDate);
                  GXUtil.WriteLogRaw("Current: ",T001T2_A594View_New_Encounter2view_NE_AdmitDate[0]);
               }
               if ( Z595View_New_Encounter2view_NE_Status != T001T2_A595View_New_Encounter2view_NE_Status[0] )
               {
                  GXUtil.WriteLog("view_new_encounter2:[seudo value changed for attri]"+"View_New_Encounter2view_NE_Status");
                  GXUtil.WriteLogRaw("Old: ",Z595View_New_Encounter2view_NE_Status);
                  GXUtil.WriteLogRaw("Current: ",T001T2_A595View_New_Encounter2view_NE_Status[0]);
               }
               if ( Z596View_New_Encounter2view_NE_IsRandRecheck != T001T2_A596View_New_Encounter2view_NE_IsRandRecheck[0] )
               {
                  GXUtil.WriteLog("view_new_encounter2:[seudo value changed for attri]"+"View_New_Encounter2view_NE_IsRandRecheck");
                  GXUtil.WriteLogRaw("Old: ",Z596View_New_Encounter2view_NE_IsRandRecheck);
                  GXUtil.WriteLogRaw("Current: ",T001T2_A596View_New_Encounter2view_NE_IsRandRecheck[0]);
               }
               if ( Z597View_New_Encounter2view_NE_IsRandApprove != T001T2_A597View_New_Encounter2view_NE_IsRandApprove[0] )
               {
                  GXUtil.WriteLog("view_new_encounter2:[seudo value changed for attri]"+"View_New_Encounter2view_NE_IsRandApprove");
                  GXUtil.WriteLogRaw("Old: ",Z597View_New_Encounter2view_NE_IsRandApprove);
                  GXUtil.WriteLogRaw("Current: ",T001T2_A597View_New_Encounter2view_NE_IsRandApprove[0]);
               }
               if ( Z598View_New_Encounter2view_NE_IsUpdate != T001T2_A598View_New_Encounter2view_NE_IsUpdate[0] )
               {
                  GXUtil.WriteLog("view_new_encounter2:[seudo value changed for attri]"+"View_New_Encounter2view_NE_IsUpdate");
                  GXUtil.WriteLogRaw("Old: ",Z598View_New_Encounter2view_NE_IsUpdate);
                  GXUtil.WriteLogRaw("Current: ",T001T2_A598View_New_Encounter2view_NE_IsUpdate[0]);
               }
               if ( StringUtil.StrCmp(Z599View_New_Encounter2view_NE_TenantTenantCode, T001T2_A599View_New_Encounter2view_NE_TenantTenantCode[0]) != 0 )
               {
                  GXUtil.WriteLog("view_new_encounter2:[seudo value changed for attri]"+"View_New_Encounter2view_NE_TenantTenantCode");
                  GXUtil.WriteLogRaw("Old: ",Z599View_New_Encounter2view_NE_TenantTenantCode);
                  GXUtil.WriteLogRaw("Current: ",T001T2_A599View_New_Encounter2view_NE_TenantTenantCode[0]);
               }
               if ( Z600View_New_Encounter2view_NE_Information_ID != T001T2_A600View_New_Encounter2view_NE_Information_ID[0] )
               {
                  GXUtil.WriteLog("view_new_encounter2:[seudo value changed for attri]"+"View_New_Encounter2view_NE_Information_ID");
                  GXUtil.WriteLogRaw("Old: ",Z600View_New_Encounter2view_NE_Information_ID);
                  GXUtil.WriteLogRaw("Current: ",T001T2_A600View_New_Encounter2view_NE_Information_ID[0]);
               }
               if ( StringUtil.StrCmp(Z601View_New_Encounter2view_NE_Information_PatientNo, T001T2_A601View_New_Encounter2view_NE_Information_PatientNo[0]) != 0 )
               {
                  GXUtil.WriteLog("view_new_encounter2:[seudo value changed for attri]"+"View_New_Encounter2view_NE_Information_PatientNo");
                  GXUtil.WriteLogRaw("Old: ",Z601View_New_Encounter2view_NE_Information_PatientNo);
                  GXUtil.WriteLogRaw("Current: ",T001T2_A601View_New_Encounter2view_NE_Information_PatientNo[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"View_New_Encounter"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1T75( )
      {
         BeforeValidate1T75( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1T75( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1T75( 0) ;
            CheckOptimisticConcurrency1T75( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1T75( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1T75( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001T8 */
                     pr_default.execute(6, new Object[] {A591View_New_Encounter2view_NE_EncounterID, n592View_New_Encounter2view_NE_ENCType, A592View_New_Encounter2view_NE_ENCType, n593View_New_Encounter2view_NE_Departmentadm, A593View_New_Encounter2view_NE_Departmentadm, n594View_New_Encounter2view_NE_AdmitDate, A594View_New_Encounter2view_NE_AdmitDate, n595View_New_Encounter2view_NE_Status, A595View_New_Encounter2view_NE_Status, n596View_New_Encounter2view_NE_IsRandRecheck, A596View_New_Encounter2view_NE_IsRandRecheck, n597View_New_Encounter2view_NE_IsRandApprove, A597View_New_Encounter2view_NE_IsRandApprove, n598View_New_Encounter2view_NE_IsUpdate, A598View_New_Encounter2view_NE_IsUpdate, n599View_New_Encounter2view_NE_TenantTenantCode, A599View_New_Encounter2view_NE_TenantTenantCode, n600View_New_Encounter2view_NE_Information_ID, A600View_New_Encounter2view_NE_Information_ID, n601View_New_Encounter2view_NE_Information_PatientNo, A601View_New_Encounter2view_NE_Information_PatientNo});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("View_New_Encounter") ;
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
                           ResetCaption1T0( ) ;
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
               Load1T75( ) ;
            }
            EndLevel1T75( ) ;
         }
         CloseExtendedTableCursors1T75( ) ;
      }

      protected void Update1T75( )
      {
         BeforeValidate1T75( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1T75( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1T75( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1T75( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1T75( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001T9 */
                     pr_default.execute(7, new Object[] {n592View_New_Encounter2view_NE_ENCType, A592View_New_Encounter2view_NE_ENCType, n593View_New_Encounter2view_NE_Departmentadm, A593View_New_Encounter2view_NE_Departmentadm, n594View_New_Encounter2view_NE_AdmitDate, A594View_New_Encounter2view_NE_AdmitDate, n595View_New_Encounter2view_NE_Status, A595View_New_Encounter2view_NE_Status, n596View_New_Encounter2view_NE_IsRandRecheck, A596View_New_Encounter2view_NE_IsRandRecheck, n597View_New_Encounter2view_NE_IsRandApprove, A597View_New_Encounter2view_NE_IsRandApprove, n598View_New_Encounter2view_NE_IsUpdate, A598View_New_Encounter2view_NE_IsUpdate, n599View_New_Encounter2view_NE_TenantTenantCode, A599View_New_Encounter2view_NE_TenantTenantCode, n600View_New_Encounter2view_NE_Information_ID, A600View_New_Encounter2view_NE_Information_ID, n601View_New_Encounter2view_NE_Information_PatientNo, A601View_New_Encounter2view_NE_Information_PatientNo, A591View_New_Encounter2view_NE_EncounterID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("View_New_Encounter") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"View_New_Encounter"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1T75( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1T0( ) ;
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
            EndLevel1T75( ) ;
         }
         CloseExtendedTableCursors1T75( ) ;
      }

      protected void DeferredUpdate1T75( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1T75( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1T75( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1T75( ) ;
            AfterConfirm1T75( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1T75( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001T10 */
                  pr_default.execute(8, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("View_New_Encounter") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound75 == 0 )
                        {
                           InitAll1T75( ) ;
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
                        ResetCaption1T0( ) ;
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
         sMode75 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1T75( ) ;
         Gx_mode = sMode75;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1T75( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1T75( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1T75( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("view_new_encounter2",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1T0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("view_new_encounter2",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1T75( )
      {
         /* Using cursor T001T11 */
         pr_default.execute(9);
         RcdFound75 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound75 = 1;
            A591View_New_Encounter2view_NE_EncounterID = T001T11_A591View_New_Encounter2view_NE_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1T75( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound75 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound75 = 1;
            A591View_New_Encounter2view_NE_EncounterID = T001T11_A591View_New_Encounter2view_NE_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
         }
      }

      protected void ScanEnd1T75( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm1T75( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1T75( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1T75( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1T75( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1T75( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1T75( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1T75( )
      {
         edtView_New_Encounter2view_NE_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtView_New_Encounter2view_NE_EncounterID_Enabled), 5, 0)), true);
         edtView_New_Encounter2view_NE_ENCType_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_ENCType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtView_New_Encounter2view_NE_ENCType_Enabled), 5, 0)), true);
         edtView_New_Encounter2view_NE_Departmentadm_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_Departmentadm_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtView_New_Encounter2view_NE_Departmentadm_Enabled), 5, 0)), true);
         edtView_New_Encounter2view_NE_AdmitDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_AdmitDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtView_New_Encounter2view_NE_AdmitDate_Enabled), 5, 0)), true);
         cmbView_New_Encounter2view_NE_Status.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbView_New_Encounter2view_NE_Status_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbView_New_Encounter2view_NE_Status.Enabled), 5, 0)), true);
         chkView_New_Encounter2view_NE_IsRandRecheck.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsRandRecheck_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkView_New_Encounter2view_NE_IsRandRecheck.Enabled), 5, 0)), true);
         chkView_New_Encounter2view_NE_IsRandApprove.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsRandApprove_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkView_New_Encounter2view_NE_IsRandApprove.Enabled), 5, 0)), true);
         chkView_New_Encounter2view_NE_IsUpdate.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkView_New_Encounter2view_NE_IsUpdate.Enabled), 5, 0)), true);
         edtView_New_Encounter2view_NE_TenantTenantCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_TenantTenantCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtView_New_Encounter2view_NE_TenantTenantCode_Enabled), 5, 0)), true);
         edtView_New_Encounter2view_NE_Information_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_Information_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtView_New_Encounter2view_NE_Information_ID_Enabled), 5, 0)), true);
         edtView_New_Encounter2view_NE_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtView_New_Encounter2view_NE_Information_PatientNo_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1T75( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1T0( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020228159689", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("view_new_encounter2.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z591View_New_Encounter2view_NE_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z592View_New_Encounter2view_NE_ENCType", Z592View_New_Encounter2view_NE_ENCType);
         GxWebStd.gx_hidden_field( context, "Z593View_New_Encounter2view_NE_Departmentadm", Z593View_New_Encounter2view_NE_Departmentadm);
         GxWebStd.gx_hidden_field( context, "Z594View_New_Encounter2view_NE_AdmitDate", context.localUtil.DToC( Z594View_New_Encounter2view_NE_AdmitDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z595View_New_Encounter2view_NE_Status", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z595View_New_Encounter2view_NE_Status), 4, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, "Z596View_New_Encounter2view_NE_IsRandRecheck", Z596View_New_Encounter2view_NE_IsRandRecheck);
         GxWebStd.gx_boolean_hidden_field( context, "Z597View_New_Encounter2view_NE_IsRandApprove", Z597View_New_Encounter2view_NE_IsRandApprove);
         GxWebStd.gx_boolean_hidden_field( context, "Z598View_New_Encounter2view_NE_IsUpdate", Z598View_New_Encounter2view_NE_IsUpdate);
         GxWebStd.gx_hidden_field( context, "Z599View_New_Encounter2view_NE_TenantTenantCode", Z599View_New_Encounter2view_NE_TenantTenantCode);
         GxWebStd.gx_hidden_field( context, "Z600View_New_Encounter2view_NE_Information_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z600View_New_Encounter2view_NE_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z601View_New_Encounter2view_NE_Information_PatientNo", Z601View_New_Encounter2view_NE_Information_PatientNo);
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
         return formatLink("view_new_encounter2.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "View_New_Encounter2" ;
      }

      public override String GetPgmdesc( )
      {
         return "View_New_Encounter2" ;
      }

      protected void InitializeNonKey1T75( )
      {
         A592View_New_Encounter2view_NE_ENCType = "";
         n592View_New_Encounter2view_NE_ENCType = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A592View_New_Encounter2view_NE_ENCType", A592View_New_Encounter2view_NE_ENCType);
         n592View_New_Encounter2view_NE_ENCType = (String.IsNullOrEmpty(StringUtil.RTrim( A592View_New_Encounter2view_NE_ENCType)) ? true : false);
         A593View_New_Encounter2view_NE_Departmentadm = "";
         n593View_New_Encounter2view_NE_Departmentadm = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A593View_New_Encounter2view_NE_Departmentadm", A593View_New_Encounter2view_NE_Departmentadm);
         n593View_New_Encounter2view_NE_Departmentadm = (String.IsNullOrEmpty(StringUtil.RTrim( A593View_New_Encounter2view_NE_Departmentadm)) ? true : false);
         A594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         n594View_New_Encounter2view_NE_AdmitDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A594View_New_Encounter2view_NE_AdmitDate", context.localUtil.Format(A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"));
         n594View_New_Encounter2view_NE_AdmitDate = ((DateTime.MinValue==A594View_New_Encounter2view_NE_AdmitDate) ? true : false);
         A595View_New_Encounter2view_NE_Status = 0;
         n595View_New_Encounter2view_NE_Status = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A595View_New_Encounter2view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0)));
         n595View_New_Encounter2view_NE_Status = ((0==A595View_New_Encounter2view_NE_Status) ? true : false);
         A596View_New_Encounter2view_NE_IsRandRecheck = false;
         n596View_New_Encounter2view_NE_IsRandRecheck = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A596View_New_Encounter2view_NE_IsRandRecheck", A596View_New_Encounter2view_NE_IsRandRecheck);
         n596View_New_Encounter2view_NE_IsRandRecheck = ((false==A596View_New_Encounter2view_NE_IsRandRecheck) ? true : false);
         A597View_New_Encounter2view_NE_IsRandApprove = false;
         n597View_New_Encounter2view_NE_IsRandApprove = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A597View_New_Encounter2view_NE_IsRandApprove", A597View_New_Encounter2view_NE_IsRandApprove);
         n597View_New_Encounter2view_NE_IsRandApprove = ((false==A597View_New_Encounter2view_NE_IsRandApprove) ? true : false);
         A598View_New_Encounter2view_NE_IsUpdate = false;
         n598View_New_Encounter2view_NE_IsUpdate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A598View_New_Encounter2view_NE_IsUpdate", A598View_New_Encounter2view_NE_IsUpdate);
         n598View_New_Encounter2view_NE_IsUpdate = ((false==A598View_New_Encounter2view_NE_IsUpdate) ? true : false);
         A599View_New_Encounter2view_NE_TenantTenantCode = "";
         n599View_New_Encounter2view_NE_TenantTenantCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A599View_New_Encounter2view_NE_TenantTenantCode", A599View_New_Encounter2view_NE_TenantTenantCode);
         n599View_New_Encounter2view_NE_TenantTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A599View_New_Encounter2view_NE_TenantTenantCode)) ? true : false);
         A600View_New_Encounter2view_NE_Information_ID = 0;
         n600View_New_Encounter2view_NE_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A600View_New_Encounter2view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A600View_New_Encounter2view_NE_Information_ID), 18, 0)));
         n600View_New_Encounter2view_NE_Information_ID = ((0==A600View_New_Encounter2view_NE_Information_ID) ? true : false);
         A601View_New_Encounter2view_NE_Information_PatientNo = "";
         n601View_New_Encounter2view_NE_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A601View_New_Encounter2view_NE_Information_PatientNo", A601View_New_Encounter2view_NE_Information_PatientNo);
         n601View_New_Encounter2view_NE_Information_PatientNo = (String.IsNullOrEmpty(StringUtil.RTrim( A601View_New_Encounter2view_NE_Information_PatientNo)) ? true : false);
         Z592View_New_Encounter2view_NE_ENCType = "";
         Z593View_New_Encounter2view_NE_Departmentadm = "";
         Z594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         Z595View_New_Encounter2view_NE_Status = 0;
         Z596View_New_Encounter2view_NE_IsRandRecheck = false;
         Z597View_New_Encounter2view_NE_IsRandApprove = false;
         Z598View_New_Encounter2view_NE_IsUpdate = false;
         Z599View_New_Encounter2view_NE_TenantTenantCode = "";
         Z600View_New_Encounter2view_NE_Information_ID = 0;
         Z601View_New_Encounter2view_NE_Information_PatientNo = "";
      }

      protected void InitAll1T75( )
      {
         A591View_New_Encounter2view_NE_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A591View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0)));
         InitializeNonKey1T75( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228159696", true);
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
         context.AddJavascriptSource("view_new_encounter2.js", "?2020228159696", false);
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
         edtView_New_Encounter2view_NE_EncounterID_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID";
         edtView_New_Encounter2view_NE_ENCType_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE";
         edtView_New_Encounter2view_NE_Departmentadm_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM";
         edtView_New_Encounter2view_NE_AdmitDate_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ADMITDATE";
         cmbView_New_Encounter2view_NE_Status_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS";
         chkView_New_Encounter2view_NE_IsRandRecheck_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK";
         chkView_New_Encounter2view_NE_IsRandApprove_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE";
         chkView_New_Encounter2view_NE_IsUpdate_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE";
         edtView_New_Encounter2view_NE_TenantTenantCode_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_TENANTTENANTCODE";
         edtView_New_Encounter2view_NE_Information_ID_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_ID";
         edtView_New_Encounter2view_NE_Information_PatientNo_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO";
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
         Form.Caption = "View_New_Encounter2";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtView_New_Encounter2view_NE_Information_PatientNo_Enabled = 1;
         edtView_New_Encounter2view_NE_Information_ID_Jsonclick = "";
         edtView_New_Encounter2view_NE_Information_ID_Enabled = 1;
         edtView_New_Encounter2view_NE_TenantTenantCode_Jsonclick = "";
         edtView_New_Encounter2view_NE_TenantTenantCode_Enabled = 1;
         chkView_New_Encounter2view_NE_IsUpdate.Enabled = 1;
         chkView_New_Encounter2view_NE_IsRandApprove.Enabled = 1;
         chkView_New_Encounter2view_NE_IsRandRecheck.Enabled = 1;
         cmbView_New_Encounter2view_NE_Status_Jsonclick = "";
         cmbView_New_Encounter2view_NE_Status.Enabled = 1;
         edtView_New_Encounter2view_NE_AdmitDate_Jsonclick = "";
         edtView_New_Encounter2view_NE_AdmitDate_Enabled = 1;
         edtView_New_Encounter2view_NE_Departmentadm_Jsonclick = "";
         edtView_New_Encounter2view_NE_Departmentadm_Enabled = 1;
         edtView_New_Encounter2view_NE_ENCType_Enabled = 1;
         edtView_New_Encounter2view_NE_EncounterID_Jsonclick = "";
         edtView_New_Encounter2view_NE_EncounterID_Enabled = 1;
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
         cmbView_New_Encounter2view_NE_Status.Name = "VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS";
         cmbView_New_Encounter2view_NE_Status.WebTags = "";
         cmbView_New_Encounter2view_NE_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("1", "录入中", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("2", "待初审", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("3", "初审不通过", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("4", "待复审", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("5", "复审不通过", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("6", "完成", 0);
         if ( cmbView_New_Encounter2view_NE_Status.ItemCount > 0 )
         {
            A595View_New_Encounter2view_NE_Status = (short)(NumberUtil.Val( cmbView_New_Encounter2view_NE_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0))), "."));
            n595View_New_Encounter2view_NE_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A595View_New_Encounter2view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0)));
         }
         chkView_New_Encounter2view_NE_IsRandRecheck.Name = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK";
         chkView_New_Encounter2view_NE_IsRandRecheck.WebTags = "";
         chkView_New_Encounter2view_NE_IsRandRecheck.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsRandRecheck_Internalname, "TitleCaption", chkView_New_Encounter2view_NE_IsRandRecheck.Caption, true);
         chkView_New_Encounter2view_NE_IsRandRecheck.CheckedValue = "false";
         chkView_New_Encounter2view_NE_IsRandApprove.Name = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE";
         chkView_New_Encounter2view_NE_IsRandApprove.WebTags = "";
         chkView_New_Encounter2view_NE_IsRandApprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsRandApprove_Internalname, "TitleCaption", chkView_New_Encounter2view_NE_IsRandApprove.Caption, true);
         chkView_New_Encounter2view_NE_IsRandApprove.CheckedValue = "false";
         chkView_New_Encounter2view_NE_IsUpdate.Name = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE";
         chkView_New_Encounter2view_NE_IsUpdate.WebTags = "";
         chkView_New_Encounter2view_NE_IsUpdate.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsUpdate_Internalname, "TitleCaption", chkView_New_Encounter2view_NE_IsUpdate.Caption, true);
         chkView_New_Encounter2view_NE_IsUpdate.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtView_New_Encounter2view_NE_ENCType_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_View_new_encounter2view_ne_encounterid( long GX_Parm1 ,
                                                                String GX_Parm2 ,
                                                                String GX_Parm3 ,
                                                                DateTime GX_Parm4 ,
                                                                GXCombobox cmbGX_Parm5 ,
                                                                bool GX_Parm6 ,
                                                                bool GX_Parm7 ,
                                                                bool GX_Parm8 ,
                                                                String GX_Parm9 ,
                                                                long GX_Parm10 ,
                                                                String GX_Parm11 )
      {
         A591View_New_Encounter2view_NE_EncounterID = GX_Parm1;
         A592View_New_Encounter2view_NE_ENCType = GX_Parm2;
         n592View_New_Encounter2view_NE_ENCType = false;
         A593View_New_Encounter2view_NE_Departmentadm = GX_Parm3;
         n593View_New_Encounter2view_NE_Departmentadm = false;
         A594View_New_Encounter2view_NE_AdmitDate = GX_Parm4;
         n594View_New_Encounter2view_NE_AdmitDate = false;
         cmbView_New_Encounter2view_NE_Status = cmbGX_Parm5;
         A595View_New_Encounter2view_NE_Status = (short)(NumberUtil.Val( cmbView_New_Encounter2view_NE_Status.CurrentValue, "."));
         n595View_New_Encounter2view_NE_Status = false;
         cmbView_New_Encounter2view_NE_Status.CurrentValue = StringUtil.LTrim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0));
         A596View_New_Encounter2view_NE_IsRandRecheck = GX_Parm6;
         n596View_New_Encounter2view_NE_IsRandRecheck = false;
         A597View_New_Encounter2view_NE_IsRandApprove = GX_Parm7;
         n597View_New_Encounter2view_NE_IsRandApprove = false;
         A598View_New_Encounter2view_NE_IsUpdate = GX_Parm8;
         n598View_New_Encounter2view_NE_IsUpdate = false;
         A599View_New_Encounter2view_NE_TenantTenantCode = GX_Parm9;
         n599View_New_Encounter2view_NE_TenantTenantCode = false;
         A600View_New_Encounter2view_NE_Information_ID = GX_Parm10;
         n600View_New_Encounter2view_NE_Information_ID = false;
         A601View_New_Encounter2view_NE_Information_PatientNo = GX_Parm11;
         n601View_New_Encounter2view_NE_Information_PatientNo = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A592View_New_Encounter2view_NE_ENCType);
         isValidOutput.Add(A593View_New_Encounter2view_NE_Departmentadm);
         isValidOutput.Add(context.localUtil.Format(A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"));
         cmbView_New_Encounter2view_NE_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0));
         isValidOutput.Add(cmbView_New_Encounter2view_NE_Status);
         isValidOutput.Add(A596View_New_Encounter2view_NE_IsRandRecheck);
         isValidOutput.Add(A597View_New_Encounter2view_NE_IsRandApprove);
         isValidOutput.Add(A598View_New_Encounter2view_NE_IsUpdate);
         isValidOutput.Add(A599View_New_Encounter2view_NE_TenantTenantCode);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A600View_New_Encounter2view_NE_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(A601View_New_Encounter2view_NE_Information_PatientNo);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z591View_New_Encounter2view_NE_EncounterID), 18, 0, ".", "")));
         isValidOutput.Add(Z592View_New_Encounter2view_NE_ENCType);
         isValidOutput.Add(Z593View_New_Encounter2view_NE_Departmentadm);
         isValidOutput.Add(context.localUtil.DToC( Z594View_New_Encounter2view_NE_AdmitDate, 0, "/"));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z595View_New_Encounter2view_NE_Status), 4, 0, ".", "")));
         isValidOutput.Add(Z596View_New_Encounter2view_NE_IsRandRecheck);
         isValidOutput.Add(Z597View_New_Encounter2view_NE_IsRandApprove);
         isValidOutput.Add(Z598View_New_Encounter2view_NE_IsUpdate);
         isValidOutput.Add(Z599View_New_Encounter2view_NE_TenantTenantCode);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z600View_New_Encounter2view_NE_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(Z601View_New_Encounter2view_NE_Information_PatientNo);
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
         Z592View_New_Encounter2view_NE_ENCType = "";
         Z593View_New_Encounter2view_NE_Departmentadm = "";
         Z594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         Z599View_New_Encounter2view_NE_TenantTenantCode = "";
         Z601View_New_Encounter2view_NE_Information_PatientNo = "";
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
         A592View_New_Encounter2view_NE_ENCType = "";
         A593View_New_Encounter2view_NE_Departmentadm = "";
         A594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         A599View_New_Encounter2view_NE_TenantTenantCode = "";
         A601View_New_Encounter2view_NE_Information_PatientNo = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T001T4_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         T001T4_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         T001T4_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         T001T4_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         T001T4_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         T001T4_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T001T4_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         T001T4_A595View_New_Encounter2view_NE_Status = new short[1] ;
         T001T4_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         T001T4_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         T001T4_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         T001T4_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         T001T4_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         T001T4_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         T001T4_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         T001T4_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         T001T4_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         T001T4_A600View_New_Encounter2view_NE_Information_ID = new long[1] ;
         T001T4_n600View_New_Encounter2view_NE_Information_ID = new bool[] {false} ;
         T001T4_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         T001T4_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         T001T5_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         T001T3_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         T001T3_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         T001T3_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         T001T3_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         T001T3_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         T001T3_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T001T3_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         T001T3_A595View_New_Encounter2view_NE_Status = new short[1] ;
         T001T3_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         T001T3_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         T001T3_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         T001T3_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         T001T3_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         T001T3_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         T001T3_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         T001T3_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         T001T3_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         T001T3_A600View_New_Encounter2view_NE_Information_ID = new long[1] ;
         T001T3_n600View_New_Encounter2view_NE_Information_ID = new bool[] {false} ;
         T001T3_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         T001T3_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         sMode75 = "";
         T001T6_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         T001T7_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         T001T2_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         T001T2_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         T001T2_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         T001T2_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         T001T2_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         T001T2_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T001T2_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         T001T2_A595View_New_Encounter2view_NE_Status = new short[1] ;
         T001T2_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         T001T2_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         T001T2_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         T001T2_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         T001T2_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         T001T2_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         T001T2_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         T001T2_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         T001T2_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         T001T2_A600View_New_Encounter2view_NE_Information_ID = new long[1] ;
         T001T2_n600View_New_Encounter2view_NE_Information_ID = new bool[] {false} ;
         T001T2_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         T001T2_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         T001T11_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.view_new_encounter2__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.view_new_encounter2__default(),
            new Object[][] {
                new Object[] {
               T001T2_A591View_New_Encounter2view_NE_EncounterID, T001T2_A592View_New_Encounter2view_NE_ENCType, T001T2_n592View_New_Encounter2view_NE_ENCType, T001T2_A593View_New_Encounter2view_NE_Departmentadm, T001T2_n593View_New_Encounter2view_NE_Departmentadm, T001T2_A594View_New_Encounter2view_NE_AdmitDate, T001T2_n594View_New_Encounter2view_NE_AdmitDate, T001T2_A595View_New_Encounter2view_NE_Status, T001T2_n595View_New_Encounter2view_NE_Status, T001T2_A596View_New_Encounter2view_NE_IsRandRecheck,
               T001T2_n596View_New_Encounter2view_NE_IsRandRecheck, T001T2_A597View_New_Encounter2view_NE_IsRandApprove, T001T2_n597View_New_Encounter2view_NE_IsRandApprove, T001T2_A598View_New_Encounter2view_NE_IsUpdate, T001T2_n598View_New_Encounter2view_NE_IsUpdate, T001T2_A599View_New_Encounter2view_NE_TenantTenantCode, T001T2_n599View_New_Encounter2view_NE_TenantTenantCode, T001T2_A600View_New_Encounter2view_NE_Information_ID, T001T2_n600View_New_Encounter2view_NE_Information_ID, T001T2_A601View_New_Encounter2view_NE_Information_PatientNo,
               T001T2_n601View_New_Encounter2view_NE_Information_PatientNo
               }
               , new Object[] {
               T001T3_A591View_New_Encounter2view_NE_EncounterID, T001T3_A592View_New_Encounter2view_NE_ENCType, T001T3_n592View_New_Encounter2view_NE_ENCType, T001T3_A593View_New_Encounter2view_NE_Departmentadm, T001T3_n593View_New_Encounter2view_NE_Departmentadm, T001T3_A594View_New_Encounter2view_NE_AdmitDate, T001T3_n594View_New_Encounter2view_NE_AdmitDate, T001T3_A595View_New_Encounter2view_NE_Status, T001T3_n595View_New_Encounter2view_NE_Status, T001T3_A596View_New_Encounter2view_NE_IsRandRecheck,
               T001T3_n596View_New_Encounter2view_NE_IsRandRecheck, T001T3_A597View_New_Encounter2view_NE_IsRandApprove, T001T3_n597View_New_Encounter2view_NE_IsRandApprove, T001T3_A598View_New_Encounter2view_NE_IsUpdate, T001T3_n598View_New_Encounter2view_NE_IsUpdate, T001T3_A599View_New_Encounter2view_NE_TenantTenantCode, T001T3_n599View_New_Encounter2view_NE_TenantTenantCode, T001T3_A600View_New_Encounter2view_NE_Information_ID, T001T3_n600View_New_Encounter2view_NE_Information_ID, T001T3_A601View_New_Encounter2view_NE_Information_PatientNo,
               T001T3_n601View_New_Encounter2view_NE_Information_PatientNo
               }
               , new Object[] {
               T001T4_A591View_New_Encounter2view_NE_EncounterID, T001T4_A592View_New_Encounter2view_NE_ENCType, T001T4_n592View_New_Encounter2view_NE_ENCType, T001T4_A593View_New_Encounter2view_NE_Departmentadm, T001T4_n593View_New_Encounter2view_NE_Departmentadm, T001T4_A594View_New_Encounter2view_NE_AdmitDate, T001T4_n594View_New_Encounter2view_NE_AdmitDate, T001T4_A595View_New_Encounter2view_NE_Status, T001T4_n595View_New_Encounter2view_NE_Status, T001T4_A596View_New_Encounter2view_NE_IsRandRecheck,
               T001T4_n596View_New_Encounter2view_NE_IsRandRecheck, T001T4_A597View_New_Encounter2view_NE_IsRandApprove, T001T4_n597View_New_Encounter2view_NE_IsRandApprove, T001T4_A598View_New_Encounter2view_NE_IsUpdate, T001T4_n598View_New_Encounter2view_NE_IsUpdate, T001T4_A599View_New_Encounter2view_NE_TenantTenantCode, T001T4_n599View_New_Encounter2view_NE_TenantTenantCode, T001T4_A600View_New_Encounter2view_NE_Information_ID, T001T4_n600View_New_Encounter2view_NE_Information_ID, T001T4_A601View_New_Encounter2view_NE_Information_PatientNo,
               T001T4_n601View_New_Encounter2view_NE_Information_PatientNo
               }
               , new Object[] {
               T001T5_A591View_New_Encounter2view_NE_EncounterID
               }
               , new Object[] {
               T001T6_A591View_New_Encounter2view_NE_EncounterID
               }
               , new Object[] {
               T001T7_A591View_New_Encounter2view_NE_EncounterID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001T11_A591View_New_Encounter2view_NE_EncounterID
               }
            }
         );
      }

      private short Z595View_New_Encounter2view_NE_Status ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A595View_New_Encounter2view_NE_Status ;
      private short GX_JID ;
      private short RcdFound75 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtView_New_Encounter2view_NE_EncounterID_Enabled ;
      private int edtView_New_Encounter2view_NE_ENCType_Enabled ;
      private int edtView_New_Encounter2view_NE_Departmentadm_Enabled ;
      private int edtView_New_Encounter2view_NE_AdmitDate_Enabled ;
      private int edtView_New_Encounter2view_NE_TenantTenantCode_Enabled ;
      private int edtView_New_Encounter2view_NE_Information_ID_Enabled ;
      private int edtView_New_Encounter2view_NE_Information_PatientNo_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z591View_New_Encounter2view_NE_EncounterID ;
      private long Z600View_New_Encounter2view_NE_Information_ID ;
      private long A591View_New_Encounter2view_NE_EncounterID ;
      private long A600View_New_Encounter2view_NE_Information_ID ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtView_New_Encounter2view_NE_EncounterID_Internalname ;
      private String cmbView_New_Encounter2view_NE_Status_Internalname ;
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
      private String edtView_New_Encounter2view_NE_EncounterID_Jsonclick ;
      private String edtView_New_Encounter2view_NE_ENCType_Internalname ;
      private String edtView_New_Encounter2view_NE_Departmentadm_Internalname ;
      private String edtView_New_Encounter2view_NE_Departmentadm_Jsonclick ;
      private String edtView_New_Encounter2view_NE_AdmitDate_Internalname ;
      private String edtView_New_Encounter2view_NE_AdmitDate_Jsonclick ;
      private String cmbView_New_Encounter2view_NE_Status_Jsonclick ;
      private String chkView_New_Encounter2view_NE_IsRandRecheck_Internalname ;
      private String chkView_New_Encounter2view_NE_IsRandApprove_Internalname ;
      private String chkView_New_Encounter2view_NE_IsUpdate_Internalname ;
      private String edtView_New_Encounter2view_NE_TenantTenantCode_Internalname ;
      private String edtView_New_Encounter2view_NE_TenantTenantCode_Jsonclick ;
      private String edtView_New_Encounter2view_NE_Information_ID_Internalname ;
      private String edtView_New_Encounter2view_NE_Information_ID_Jsonclick ;
      private String edtView_New_Encounter2view_NE_Information_PatientNo_Internalname ;
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
      private String sMode75 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z594View_New_Encounter2view_NE_AdmitDate ;
      private DateTime A594View_New_Encounter2view_NE_AdmitDate ;
      private bool Z596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool Z597View_New_Encounter2view_NE_IsRandApprove ;
      private bool Z598View_New_Encounter2view_NE_IsUpdate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n595View_New_Encounter2view_NE_Status ;
      private bool A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool A598View_New_Encounter2view_NE_IsUpdate ;
      private bool n592View_New_Encounter2view_NE_ENCType ;
      private bool n593View_New_Encounter2view_NE_Departmentadm ;
      private bool n594View_New_Encounter2view_NE_AdmitDate ;
      private bool n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool n598View_New_Encounter2view_NE_IsUpdate ;
      private bool n599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool n600View_New_Encounter2view_NE_Information_ID ;
      private bool n601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool Gx_longc ;
      private String Z592View_New_Encounter2view_NE_ENCType ;
      private String Z593View_New_Encounter2view_NE_Departmentadm ;
      private String Z599View_New_Encounter2view_NE_TenantTenantCode ;
      private String Z601View_New_Encounter2view_NE_Information_PatientNo ;
      private String A592View_New_Encounter2view_NE_ENCType ;
      private String A593View_New_Encounter2view_NE_Departmentadm ;
      private String A599View_New_Encounter2view_NE_TenantTenantCode ;
      private String A601View_New_Encounter2view_NE_Information_PatientNo ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbView_New_Encounter2view_NE_Status ;
      private GXCheckbox chkView_New_Encounter2view_NE_IsRandRecheck ;
      private GXCheckbox chkView_New_Encounter2view_NE_IsRandApprove ;
      private GXCheckbox chkView_New_Encounter2view_NE_IsUpdate ;
      private IDataStoreProvider pr_default ;
      private long[] T001T4_A591View_New_Encounter2view_NE_EncounterID ;
      private String[] T001T4_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] T001T4_n592View_New_Encounter2view_NE_ENCType ;
      private String[] T001T4_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] T001T4_n593View_New_Encounter2view_NE_Departmentadm ;
      private DateTime[] T001T4_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] T001T4_n594View_New_Encounter2view_NE_AdmitDate ;
      private short[] T001T4_A595View_New_Encounter2view_NE_Status ;
      private bool[] T001T4_n595View_New_Encounter2view_NE_Status ;
      private bool[] T001T4_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] T001T4_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] T001T4_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] T001T4_n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] T001T4_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] T001T4_n598View_New_Encounter2view_NE_IsUpdate ;
      private String[] T001T4_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] T001T4_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private long[] T001T4_A600View_New_Encounter2view_NE_Information_ID ;
      private bool[] T001T4_n600View_New_Encounter2view_NE_Information_ID ;
      private String[] T001T4_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] T001T4_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private long[] T001T5_A591View_New_Encounter2view_NE_EncounterID ;
      private long[] T001T3_A591View_New_Encounter2view_NE_EncounterID ;
      private String[] T001T3_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] T001T3_n592View_New_Encounter2view_NE_ENCType ;
      private String[] T001T3_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] T001T3_n593View_New_Encounter2view_NE_Departmentadm ;
      private DateTime[] T001T3_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] T001T3_n594View_New_Encounter2view_NE_AdmitDate ;
      private short[] T001T3_A595View_New_Encounter2view_NE_Status ;
      private bool[] T001T3_n595View_New_Encounter2view_NE_Status ;
      private bool[] T001T3_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] T001T3_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] T001T3_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] T001T3_n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] T001T3_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] T001T3_n598View_New_Encounter2view_NE_IsUpdate ;
      private String[] T001T3_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] T001T3_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private long[] T001T3_A600View_New_Encounter2view_NE_Information_ID ;
      private bool[] T001T3_n600View_New_Encounter2view_NE_Information_ID ;
      private String[] T001T3_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] T001T3_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private long[] T001T6_A591View_New_Encounter2view_NE_EncounterID ;
      private long[] T001T7_A591View_New_Encounter2view_NE_EncounterID ;
      private long[] T001T2_A591View_New_Encounter2view_NE_EncounterID ;
      private String[] T001T2_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] T001T2_n592View_New_Encounter2view_NE_ENCType ;
      private String[] T001T2_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] T001T2_n593View_New_Encounter2view_NE_Departmentadm ;
      private DateTime[] T001T2_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] T001T2_n594View_New_Encounter2view_NE_AdmitDate ;
      private short[] T001T2_A595View_New_Encounter2view_NE_Status ;
      private bool[] T001T2_n595View_New_Encounter2view_NE_Status ;
      private bool[] T001T2_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] T001T2_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] T001T2_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] T001T2_n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] T001T2_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] T001T2_n598View_New_Encounter2view_NE_IsUpdate ;
      private String[] T001T2_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] T001T2_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private long[] T001T2_A600View_New_Encounter2view_NE_Information_ID ;
      private bool[] T001T2_n600View_New_Encounter2view_NE_Information_ID ;
      private String[] T001T2_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] T001T2_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private long[] T001T11_A591View_New_Encounter2view_NE_EncounterID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
   }

   public class view_new_encounter2__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class view_new_encounter2__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT001T4 ;
        prmT001T4 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001T5 ;
        prmT001T5 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001T3 ;
        prmT001T3 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001T6 ;
        prmT001T6 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001T7 ;
        prmT001T7 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001T2 ;
        prmT001T2 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001T8 ;
        prmT001T8 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@View_New_Encounter2view_NE_ENCType",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Departmentadm",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@View_New_Encounter2view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsRandRecheck",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsRandApprove",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsUpdate",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Information_PatientNo",SqlDbType.NVarChar,4000,0}
        } ;
        Object[] prmT001T9 ;
        prmT001T9 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_ENCType",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Departmentadm",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@View_New_Encounter2view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsRandRecheck",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsRandApprove",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsUpdate",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Information_PatientNo",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001T10 ;
        prmT001T10 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001T11 ;
        prmT001T11 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T001T2", "SELECT [View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_Information_ID], [View_New_Encounter2view_NE_Information_PatientNo] FROM [View_New_Encounter] WITH (UPDLOCK) WHERE [View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001T2,1,0,true,false )
           ,new CursorDef("T001T3", "SELECT [View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_Information_ID], [View_New_Encounter2view_NE_Information_PatientNo] FROM [View_New_Encounter] WITH (NOLOCK) WHERE [View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001T3,1,0,true,false )
           ,new CursorDef("T001T4", "SELECT TM1.[View_New_Encounter2view_NE_EncounterID], TM1.[View_New_Encounter2view_NE_ENCType], TM1.[View_New_Encounter2view_NE_Departmentadm], TM1.[View_New_Encounter2view_NE_AdmitDate], TM1.[View_New_Encounter2view_NE_Status], TM1.[View_New_Encounter2view_NE_IsRandRecheck], TM1.[View_New_Encounter2view_NE_IsRandApprove], TM1.[View_New_Encounter2view_NE_IsUpdate], TM1.[View_New_Encounter2view_NE_TenantTenantCode], TM1.[View_New_Encounter2view_NE_Information_ID], TM1.[View_New_Encounter2view_NE_Information_PatientNo] FROM [View_New_Encounter] TM1 WITH (NOLOCK) WHERE TM1.[View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID ORDER BY TM1.[View_New_Encounter2view_NE_EncounterID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001T4,100,0,true,false )
           ,new CursorDef("T001T5", "SELECT [View_New_Encounter2view_NE_EncounterID] FROM [View_New_Encounter] WITH (NOLOCK) WHERE [View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001T5,1,0,true,false )
           ,new CursorDef("T001T6", "SELECT TOP 1 [View_New_Encounter2view_NE_EncounterID] FROM [View_New_Encounter] WITH (NOLOCK) WHERE ( [View_New_Encounter2view_NE_EncounterID] > @View_New_Encounter2view_NE_EncounterID) ORDER BY [View_New_Encounter2view_NE_EncounterID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001T6,1,0,true,true )
           ,new CursorDef("T001T7", "SELECT TOP 1 [View_New_Encounter2view_NE_EncounterID] FROM [View_New_Encounter] WITH (NOLOCK) WHERE ( [View_New_Encounter2view_NE_EncounterID] < @View_New_Encounter2view_NE_EncounterID) ORDER BY [View_New_Encounter2view_NE_EncounterID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001T7,1,0,true,true )
           ,new CursorDef("T001T8", "INSERT INTO [View_New_Encounter]([View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_Information_ID], [View_New_Encounter2view_NE_Information_PatientNo]) VALUES(@View_New_Encounter2view_NE_EncounterID, @View_New_Encounter2view_NE_ENCType, @View_New_Encounter2view_NE_Departmentadm, @View_New_Encounter2view_NE_AdmitDate, @View_New_Encounter2view_NE_Status, @View_New_Encounter2view_NE_IsRandRecheck, @View_New_Encounter2view_NE_IsRandApprove, @View_New_Encounter2view_NE_IsUpdate, @View_New_Encounter2view_NE_TenantTenantCode, @View_New_Encounter2view_NE_Information_ID, @View_New_Encounter2view_NE_Information_PatientNo)", GxErrorMask.GX_NOMASK,prmT001T8)
           ,new CursorDef("T001T9", "UPDATE [View_New_Encounter] SET [View_New_Encounter2view_NE_ENCType]=@View_New_Encounter2view_NE_ENCType, [View_New_Encounter2view_NE_Departmentadm]=@View_New_Encounter2view_NE_Departmentadm, [View_New_Encounter2view_NE_AdmitDate]=@View_New_Encounter2view_NE_AdmitDate, [View_New_Encounter2view_NE_Status]=@View_New_Encounter2view_NE_Status, [View_New_Encounter2view_NE_IsRandRecheck]=@View_New_Encounter2view_NE_IsRandRecheck, [View_New_Encounter2view_NE_IsRandApprove]=@View_New_Encounter2view_NE_IsRandApprove, [View_New_Encounter2view_NE_IsUpdate]=@View_New_Encounter2view_NE_IsUpdate, [View_New_Encounter2view_NE_TenantTenantCode]=@View_New_Encounter2view_NE_TenantTenantCode, [View_New_Encounter2view_NE_Information_ID]=@View_New_Encounter2view_NE_Information_ID, [View_New_Encounter2view_NE_Information_PatientNo]=@View_New_Encounter2view_NE_Information_PatientNo  WHERE [View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID", GxErrorMask.GX_NOMASK,prmT001T9)
           ,new CursorDef("T001T10", "DELETE FROM [View_New_Encounter]  WHERE [View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID", GxErrorMask.GX_NOMASK,prmT001T10)
           ,new CursorDef("T001T11", "SELECT [View_New_Encounter2view_NE_EncounterID] FROM [View_New_Encounter] WITH (NOLOCK) ORDER BY [View_New_Encounter2view_NE_EncounterID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001T11,100,0,true,false )
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
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((bool[]) buf[11])[0] = rslt.getBool(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((bool[]) buf[13])[0] = rslt.getBool(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((bool[]) buf[11])[0] = rslt.getBool(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((bool[]) buf[13])[0] = rslt.getBool(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((bool[]) buf[11])[0] = rslt.getBool(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((bool[]) buf[13])[0] = rslt.getBool(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
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
              if ( (bool)parms[1] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[2]);
              }
              if ( (bool)parms[3] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[4]);
              }
              if ( (bool)parms[5] )
              {
                 stmt.setNull( 4 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(4, (DateTime)parms[6]);
              }
              if ( (bool)parms[7] )
              {
                 stmt.setNull( 5 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(5, (short)parms[8]);
              }
              if ( (bool)parms[9] )
              {
                 stmt.setNull( 6 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(6, (bool)parms[10]);
              }
              if ( (bool)parms[11] )
              {
                 stmt.setNull( 7 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(7, (bool)parms[12]);
              }
              if ( (bool)parms[13] )
              {
                 stmt.setNull( 8 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(8, (bool)parms[14]);
              }
              if ( (bool)parms[15] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[16]);
              }
              if ( (bool)parms[17] )
              {
                 stmt.setNull( 10 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(10, (long)parms[18]);
              }
              if ( (bool)parms[19] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[20]);
              }
              return;
           case 7 :
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
                 stmt.setNull( 3 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(3, (DateTime)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(4, (short)parms[7]);
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
                 stmt.setNull( 6 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(6, (bool)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(7, (bool)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(9, (long)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              stmt.SetParameter(11, (long)parms[20]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
