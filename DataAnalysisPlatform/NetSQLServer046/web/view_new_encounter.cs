/*
               File: View_New_Encounter
        Description: View_New_Encounter
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:15.61
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
   public class view_new_encounter : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "View_New_Encounter", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtview_NE_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public view_new_encounter( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public view_new_encounter( IGxContext context )
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
         cmbview_NE_Status = new GXCombobox();
         chkview_NE_IsRandRecheck = new GXCheckbox();
         chkview_NE_IsRandApprove = new GXCheckbox();
         chkview_NE_IsUpdate = new GXCheckbox();
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
         if ( cmbview_NE_Status.ItemCount > 0 )
         {
            A553view_NE_Status = (short)(NumberUtil.Val( cmbview_NE_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0))), "."));
            n553view_NE_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A553view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbview_NE_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbview_NE_Status_Internalname, "Values", cmbview_NE_Status.ToJavascriptSource(), true);
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "View_New_Encounter", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_View_New_Encounter.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_View_New_Encounter.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtview_NE_EncounterID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtview_NE_EncounterID_Internalname, "view_NE_Encounter ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtview_NE_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A549view_NE_EncounterID), 18, 0, ".", "")), ((edtview_NE_EncounterID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A549view_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A549view_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtview_NE_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtview_NE_EncounterID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtview_NE_Department_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtview_NE_Department_Internalname, "view_NE_Department", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtview_NE_Department_Internalname, A550view_NE_Department, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, 1, edtview_NE_Department_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtview_NE_ENCType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtview_NE_ENCType_Internalname, "view_NE_ENCType", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtview_NE_ENCType_Internalname, A551view_NE_ENCType, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, 1, edtview_NE_ENCType_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtview_NE_AdmitDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtview_NE_AdmitDate_Internalname, "view_NE_Admit Date", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtview_NE_AdmitDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtview_NE_AdmitDate_Internalname, context.localUtil.Format(A552view_NE_AdmitDate, "9999/99/99"), context.localUtil.Format( A552view_NE_AdmitDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtview_NE_AdmitDate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtview_NE_AdmitDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_View_New_Encounter.htm");
            GxWebStd.gx_bitmap( context, edtview_NE_AdmitDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtview_NE_AdmitDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_View_New_Encounter.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbview_NE_Status_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbview_NE_Status_Internalname, "view_NE_Status", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbview_NE_Status, cmbview_NE_Status_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0)), 1, cmbview_NE_Status_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbview_NE_Status.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "", true, "HLP_View_New_Encounter.htm");
            cmbview_NE_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbview_NE_Status_Internalname, "Values", (String)(cmbview_NE_Status.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkview_NE_IsRandRecheck_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkview_NE_IsRandRecheck_Internalname, "view_NE_Is Rand Recheck", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkview_NE_IsRandRecheck_Internalname, StringUtil.BoolToStr( A554view_NE_IsRandRecheck), "", "view_NE_Is Rand Recheck", 1, chkview_NE_IsRandRecheck.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(53, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkview_NE_IsRandApprove_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkview_NE_IsRandApprove_Internalname, "view_NE_Is Rand Approve", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkview_NE_IsRandApprove_Internalname, StringUtil.BoolToStr( A555view_NE_IsRandApprove), "", "view_NE_Is Rand Approve", 1, chkview_NE_IsRandApprove.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(58, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkview_NE_IsUpdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkview_NE_IsUpdate_Internalname, "view_NE_Is Update", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkview_NE_IsUpdate_Internalname, StringUtil.BoolToStr( A556view_NE_IsUpdate), "", "view_NE_Is Update", 1, chkview_NE_IsUpdate.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(63, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtview_NE_TenantTenantCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtview_NE_TenantTenantCode_Internalname, "view_NE_Tenant Tenant Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtview_NE_TenantTenantCode_Internalname, A557view_NE_TenantTenantCode, StringUtil.RTrim( context.localUtil.Format( A557view_NE_TenantTenantCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtview_NE_TenantTenantCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtview_NE_TenantTenantCode_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtview_NE_Information_ID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtview_NE_Information_ID_Internalname, "view_NE_Information_ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtview_NE_Information_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A558view_NE_Information_ID), 18, 0, ".", "")), ((edtview_NE_Information_ID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A558view_NE_Information_ID), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A558view_NE_Information_ID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtview_NE_Information_ID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtview_NE_Information_ID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtview_NE_Information_PatientNo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtview_NE_Information_PatientNo_Internalname, "view_NE_Information_Patient No", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtview_NE_Information_PatientNo_Internalname, A559view_NE_Information_PatientNo, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", 0, 1, edtview_NE_Information_PatientNo_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_View_New_Encounter.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_View_New_Encounter.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtview_NE_EncounterID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtview_NE_EncounterID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VIEW_NE_ENCOUNTERID");
                  AnyError = 1;
                  GX_FocusControl = edtview_NE_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A549view_NE_EncounterID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
               }
               else
               {
                  A549view_NE_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtview_NE_EncounterID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
               }
               A550view_NE_Department = cgiGet( edtview_NE_Department_Internalname);
               n550view_NE_Department = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A550view_NE_Department", A550view_NE_Department);
               n550view_NE_Department = (String.IsNullOrEmpty(StringUtil.RTrim( A550view_NE_Department)) ? true : false);
               A551view_NE_ENCType = cgiGet( edtview_NE_ENCType_Internalname);
               n551view_NE_ENCType = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A551view_NE_ENCType", A551view_NE_ENCType);
               n551view_NE_ENCType = (String.IsNullOrEmpty(StringUtil.RTrim( A551view_NE_ENCType)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtview_NE_AdmitDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"view_NE_Admit Date"}), 1, "VIEW_NE_ADMITDATE");
                  AnyError = 1;
                  GX_FocusControl = edtview_NE_AdmitDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A552view_NE_AdmitDate = DateTime.MinValue;
                  n552view_NE_AdmitDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A552view_NE_AdmitDate", context.localUtil.Format(A552view_NE_AdmitDate, "9999/99/99"));
               }
               else
               {
                  A552view_NE_AdmitDate = context.localUtil.CToD( cgiGet( edtview_NE_AdmitDate_Internalname), 0);
                  n552view_NE_AdmitDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A552view_NE_AdmitDate", context.localUtil.Format(A552view_NE_AdmitDate, "9999/99/99"));
               }
               n552view_NE_AdmitDate = ((DateTime.MinValue==A552view_NE_AdmitDate) ? true : false);
               cmbview_NE_Status.CurrentValue = cgiGet( cmbview_NE_Status_Internalname);
               A553view_NE_Status = (short)(NumberUtil.Val( cgiGet( cmbview_NE_Status_Internalname), "."));
               n553view_NE_Status = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A553view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0)));
               n553view_NE_Status = ((0==A553view_NE_Status) ? true : false);
               A554view_NE_IsRandRecheck = StringUtil.StrToBool( cgiGet( chkview_NE_IsRandRecheck_Internalname));
               n554view_NE_IsRandRecheck = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A554view_NE_IsRandRecheck", A554view_NE_IsRandRecheck);
               n554view_NE_IsRandRecheck = ((false==A554view_NE_IsRandRecheck) ? true : false);
               A555view_NE_IsRandApprove = StringUtil.StrToBool( cgiGet( chkview_NE_IsRandApprove_Internalname));
               n555view_NE_IsRandApprove = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A555view_NE_IsRandApprove", A555view_NE_IsRandApprove);
               n555view_NE_IsRandApprove = ((false==A555view_NE_IsRandApprove) ? true : false);
               A556view_NE_IsUpdate = StringUtil.StrToBool( cgiGet( chkview_NE_IsUpdate_Internalname));
               n556view_NE_IsUpdate = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A556view_NE_IsUpdate", A556view_NE_IsUpdate);
               n556view_NE_IsUpdate = ((false==A556view_NE_IsUpdate) ? true : false);
               A557view_NE_TenantTenantCode = cgiGet( edtview_NE_TenantTenantCode_Internalname);
               n557view_NE_TenantTenantCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A557view_NE_TenantTenantCode", A557view_NE_TenantTenantCode);
               n557view_NE_TenantTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A557view_NE_TenantTenantCode)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtview_NE_Information_ID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtview_NE_Information_ID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VIEW_NE_INFORMATION_ID");
                  AnyError = 1;
                  GX_FocusControl = edtview_NE_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A558view_NE_Information_ID = 0;
                  n558view_NE_Information_ID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A558view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A558view_NE_Information_ID), 18, 0)));
               }
               else
               {
                  A558view_NE_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtview_NE_Information_ID_Internalname), ".", ","));
                  n558view_NE_Information_ID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A558view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A558view_NE_Information_ID), 18, 0)));
               }
               n558view_NE_Information_ID = ((0==A558view_NE_Information_ID) ? true : false);
               A559view_NE_Information_PatientNo = cgiGet( edtview_NE_Information_PatientNo_Internalname);
               n559view_NE_Information_PatientNo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A559view_NE_Information_PatientNo", A559view_NE_Information_PatientNo);
               n559view_NE_Information_PatientNo = (String.IsNullOrEmpty(StringUtil.RTrim( A559view_NE_Information_PatientNo)) ? true : false);
               /* Read saved values. */
               Z549view_NE_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z549view_NE_EncounterID"), ".", ","));
               Z550view_NE_Department = cgiGet( "Z550view_NE_Department");
               n550view_NE_Department = (String.IsNullOrEmpty(StringUtil.RTrim( A550view_NE_Department)) ? true : false);
               Z551view_NE_ENCType = cgiGet( "Z551view_NE_ENCType");
               n551view_NE_ENCType = (String.IsNullOrEmpty(StringUtil.RTrim( A551view_NE_ENCType)) ? true : false);
               Z552view_NE_AdmitDate = context.localUtil.CToD( cgiGet( "Z552view_NE_AdmitDate"), 0);
               n552view_NE_AdmitDate = ((DateTime.MinValue==A552view_NE_AdmitDate) ? true : false);
               Z553view_NE_Status = (short)(context.localUtil.CToN( cgiGet( "Z553view_NE_Status"), ".", ","));
               n553view_NE_Status = ((0==A553view_NE_Status) ? true : false);
               Z554view_NE_IsRandRecheck = StringUtil.StrToBool( cgiGet( "Z554view_NE_IsRandRecheck"));
               n554view_NE_IsRandRecheck = ((false==A554view_NE_IsRandRecheck) ? true : false);
               Z555view_NE_IsRandApprove = StringUtil.StrToBool( cgiGet( "Z555view_NE_IsRandApprove"));
               n555view_NE_IsRandApprove = ((false==A555view_NE_IsRandApprove) ? true : false);
               Z556view_NE_IsUpdate = StringUtil.StrToBool( cgiGet( "Z556view_NE_IsUpdate"));
               n556view_NE_IsUpdate = ((false==A556view_NE_IsUpdate) ? true : false);
               Z557view_NE_TenantTenantCode = cgiGet( "Z557view_NE_TenantTenantCode");
               n557view_NE_TenantTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A557view_NE_TenantTenantCode)) ? true : false);
               Z558view_NE_Information_ID = (long)(context.localUtil.CToN( cgiGet( "Z558view_NE_Information_ID"), ".", ","));
               n558view_NE_Information_ID = ((0==A558view_NE_Information_ID) ? true : false);
               Z559view_NE_Information_PatientNo = cgiGet( "Z559view_NE_Information_PatientNo");
               n559view_NE_Information_PatientNo = (String.IsNullOrEmpty(StringUtil.RTrim( A559view_NE_Information_PatientNo)) ? true : false);
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
                  A549view_NE_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
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
               InitAll1Q72( ) ;
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
         DisableAttributes1Q72( ) ;
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

      protected void ResetCaption1Q0( )
      {
      }

      protected void ZM1Q72( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z550view_NE_Department = T001Q3_A550view_NE_Department[0];
               Z551view_NE_ENCType = T001Q3_A551view_NE_ENCType[0];
               Z552view_NE_AdmitDate = T001Q3_A552view_NE_AdmitDate[0];
               Z553view_NE_Status = T001Q3_A553view_NE_Status[0];
               Z554view_NE_IsRandRecheck = T001Q3_A554view_NE_IsRandRecheck[0];
               Z555view_NE_IsRandApprove = T001Q3_A555view_NE_IsRandApprove[0];
               Z556view_NE_IsUpdate = T001Q3_A556view_NE_IsUpdate[0];
               Z557view_NE_TenantTenantCode = T001Q3_A557view_NE_TenantTenantCode[0];
               Z558view_NE_Information_ID = T001Q3_A558view_NE_Information_ID[0];
               Z559view_NE_Information_PatientNo = T001Q3_A559view_NE_Information_PatientNo[0];
            }
            else
            {
               Z550view_NE_Department = A550view_NE_Department;
               Z551view_NE_ENCType = A551view_NE_ENCType;
               Z552view_NE_AdmitDate = A552view_NE_AdmitDate;
               Z553view_NE_Status = A553view_NE_Status;
               Z554view_NE_IsRandRecheck = A554view_NE_IsRandRecheck;
               Z555view_NE_IsRandApprove = A555view_NE_IsRandApprove;
               Z556view_NE_IsUpdate = A556view_NE_IsUpdate;
               Z557view_NE_TenantTenantCode = A557view_NE_TenantTenantCode;
               Z558view_NE_Information_ID = A558view_NE_Information_ID;
               Z559view_NE_Information_PatientNo = A559view_NE_Information_PatientNo;
            }
         }
         if ( GX_JID == -3 )
         {
            Z549view_NE_EncounterID = A549view_NE_EncounterID;
            Z550view_NE_Department = A550view_NE_Department;
            Z551view_NE_ENCType = A551view_NE_ENCType;
            Z552view_NE_AdmitDate = A552view_NE_AdmitDate;
            Z553view_NE_Status = A553view_NE_Status;
            Z554view_NE_IsRandRecheck = A554view_NE_IsRandRecheck;
            Z555view_NE_IsRandApprove = A555view_NE_IsRandApprove;
            Z556view_NE_IsUpdate = A556view_NE_IsUpdate;
            Z557view_NE_TenantTenantCode = A557view_NE_TenantTenantCode;
            Z558view_NE_Information_ID = A558view_NE_Information_ID;
            Z559view_NE_Information_PatientNo = A559view_NE_Information_PatientNo;
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

      protected void Load1Q72( )
      {
         /* Using cursor T001Q4 */
         pr_default.execute(2, new Object[] {A549view_NE_EncounterID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound72 = 1;
            A550view_NE_Department = T001Q4_A550view_NE_Department[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A550view_NE_Department", A550view_NE_Department);
            n550view_NE_Department = T001Q4_n550view_NE_Department[0];
            A551view_NE_ENCType = T001Q4_A551view_NE_ENCType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A551view_NE_ENCType", A551view_NE_ENCType);
            n551view_NE_ENCType = T001Q4_n551view_NE_ENCType[0];
            A552view_NE_AdmitDate = T001Q4_A552view_NE_AdmitDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A552view_NE_AdmitDate", context.localUtil.Format(A552view_NE_AdmitDate, "9999/99/99"));
            n552view_NE_AdmitDate = T001Q4_n552view_NE_AdmitDate[0];
            A553view_NE_Status = T001Q4_A553view_NE_Status[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A553view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0)));
            n553view_NE_Status = T001Q4_n553view_NE_Status[0];
            A554view_NE_IsRandRecheck = T001Q4_A554view_NE_IsRandRecheck[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A554view_NE_IsRandRecheck", A554view_NE_IsRandRecheck);
            n554view_NE_IsRandRecheck = T001Q4_n554view_NE_IsRandRecheck[0];
            A555view_NE_IsRandApprove = T001Q4_A555view_NE_IsRandApprove[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A555view_NE_IsRandApprove", A555view_NE_IsRandApprove);
            n555view_NE_IsRandApprove = T001Q4_n555view_NE_IsRandApprove[0];
            A556view_NE_IsUpdate = T001Q4_A556view_NE_IsUpdate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A556view_NE_IsUpdate", A556view_NE_IsUpdate);
            n556view_NE_IsUpdate = T001Q4_n556view_NE_IsUpdate[0];
            A557view_NE_TenantTenantCode = T001Q4_A557view_NE_TenantTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A557view_NE_TenantTenantCode", A557view_NE_TenantTenantCode);
            n557view_NE_TenantTenantCode = T001Q4_n557view_NE_TenantTenantCode[0];
            A558view_NE_Information_ID = T001Q4_A558view_NE_Information_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A558view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A558view_NE_Information_ID), 18, 0)));
            n558view_NE_Information_ID = T001Q4_n558view_NE_Information_ID[0];
            A559view_NE_Information_PatientNo = T001Q4_A559view_NE_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A559view_NE_Information_PatientNo", A559view_NE_Information_PatientNo);
            n559view_NE_Information_PatientNo = T001Q4_n559view_NE_Information_PatientNo[0];
            ZM1Q72( -3) ;
         }
         pr_default.close(2);
         OnLoadActions1Q72( ) ;
      }

      protected void OnLoadActions1Q72( )
      {
      }

      protected void CheckExtendedTable1Q72( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A552view_NE_AdmitDate) || ( A552view_NE_AdmitDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域view_NE_Admit Date超界", "OutOfRange", 1, "VIEW_NE_ADMITDATE");
            AnyError = 1;
            GX_FocusControl = edtview_NE_AdmitDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( A553view_NE_Status == 1 ) || ( A553view_NE_Status == 2 ) || ( A553view_NE_Status == 3 ) || ( A553view_NE_Status == 4 ) || ( A553view_NE_Status == 5 ) || ( A553view_NE_Status == 6 ) || (0==A553view_NE_Status) ) )
         {
            GX_msglist.addItem("域view_NE_Status超界", "OutOfRange", 1, "VIEW_NE_STATUS");
            AnyError = 1;
            GX_FocusControl = cmbview_NE_Status_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1Q72( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1Q72( )
      {
         /* Using cursor T001Q5 */
         pr_default.execute(3, new Object[] {A549view_NE_EncounterID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound72 = 1;
         }
         else
         {
            RcdFound72 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001Q3 */
         pr_default.execute(1, new Object[] {A549view_NE_EncounterID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1Q72( 3) ;
            RcdFound72 = 1;
            A549view_NE_EncounterID = T001Q3_A549view_NE_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
            A550view_NE_Department = T001Q3_A550view_NE_Department[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A550view_NE_Department", A550view_NE_Department);
            n550view_NE_Department = T001Q3_n550view_NE_Department[0];
            A551view_NE_ENCType = T001Q3_A551view_NE_ENCType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A551view_NE_ENCType", A551view_NE_ENCType);
            n551view_NE_ENCType = T001Q3_n551view_NE_ENCType[0];
            A552view_NE_AdmitDate = T001Q3_A552view_NE_AdmitDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A552view_NE_AdmitDate", context.localUtil.Format(A552view_NE_AdmitDate, "9999/99/99"));
            n552view_NE_AdmitDate = T001Q3_n552view_NE_AdmitDate[0];
            A553view_NE_Status = T001Q3_A553view_NE_Status[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A553view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0)));
            n553view_NE_Status = T001Q3_n553view_NE_Status[0];
            A554view_NE_IsRandRecheck = T001Q3_A554view_NE_IsRandRecheck[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A554view_NE_IsRandRecheck", A554view_NE_IsRandRecheck);
            n554view_NE_IsRandRecheck = T001Q3_n554view_NE_IsRandRecheck[0];
            A555view_NE_IsRandApprove = T001Q3_A555view_NE_IsRandApprove[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A555view_NE_IsRandApprove", A555view_NE_IsRandApprove);
            n555view_NE_IsRandApprove = T001Q3_n555view_NE_IsRandApprove[0];
            A556view_NE_IsUpdate = T001Q3_A556view_NE_IsUpdate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A556view_NE_IsUpdate", A556view_NE_IsUpdate);
            n556view_NE_IsUpdate = T001Q3_n556view_NE_IsUpdate[0];
            A557view_NE_TenantTenantCode = T001Q3_A557view_NE_TenantTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A557view_NE_TenantTenantCode", A557view_NE_TenantTenantCode);
            n557view_NE_TenantTenantCode = T001Q3_n557view_NE_TenantTenantCode[0];
            A558view_NE_Information_ID = T001Q3_A558view_NE_Information_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A558view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A558view_NE_Information_ID), 18, 0)));
            n558view_NE_Information_ID = T001Q3_n558view_NE_Information_ID[0];
            A559view_NE_Information_PatientNo = T001Q3_A559view_NE_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A559view_NE_Information_PatientNo", A559view_NE_Information_PatientNo);
            n559view_NE_Information_PatientNo = T001Q3_n559view_NE_Information_PatientNo[0];
            Z549view_NE_EncounterID = A549view_NE_EncounterID;
            sMode72 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1Q72( ) ;
            if ( AnyError == 1 )
            {
               RcdFound72 = 0;
               InitializeNonKey1Q72( ) ;
            }
            Gx_mode = sMode72;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound72 = 0;
            InitializeNonKey1Q72( ) ;
            sMode72 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode72;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1Q72( ) ;
         if ( RcdFound72 == 0 )
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
         RcdFound72 = 0;
         /* Using cursor T001Q6 */
         pr_default.execute(4, new Object[] {A549view_NE_EncounterID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T001Q6_A549view_NE_EncounterID[0] < A549view_NE_EncounterID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T001Q6_A549view_NE_EncounterID[0] > A549view_NE_EncounterID ) ) )
            {
               A549view_NE_EncounterID = T001Q6_A549view_NE_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
               RcdFound72 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound72 = 0;
         /* Using cursor T001Q7 */
         pr_default.execute(5, new Object[] {A549view_NE_EncounterID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T001Q7_A549view_NE_EncounterID[0] > A549view_NE_EncounterID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T001Q7_A549view_NE_EncounterID[0] < A549view_NE_EncounterID ) ) )
            {
               A549view_NE_EncounterID = T001Q7_A549view_NE_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
               RcdFound72 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1Q72( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtview_NE_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1Q72( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound72 == 1 )
            {
               if ( A549view_NE_EncounterID != Z549view_NE_EncounterID )
               {
                  A549view_NE_EncounterID = Z549view_NE_EncounterID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "VIEW_NE_ENCOUNTERID");
                  AnyError = 1;
                  GX_FocusControl = edtview_NE_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtview_NE_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1Q72( ) ;
                  GX_FocusControl = edtview_NE_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A549view_NE_EncounterID != Z549view_NE_EncounterID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtview_NE_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1Q72( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "VIEW_NE_ENCOUNTERID");
                     AnyError = 1;
                     GX_FocusControl = edtview_NE_EncounterID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtview_NE_EncounterID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1Q72( ) ;
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
         if ( A549view_NE_EncounterID != Z549view_NE_EncounterID )
         {
            A549view_NE_EncounterID = Z549view_NE_EncounterID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "VIEW_NE_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtview_NE_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtview_NE_EncounterID_Internalname;
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
         if ( RcdFound72 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "VIEW_NE_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtview_NE_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtview_NE_Department_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1Q72( ) ;
         if ( RcdFound72 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtview_NE_Department_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1Q72( ) ;
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
         if ( RcdFound72 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtview_NE_Department_Internalname;
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
         if ( RcdFound72 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtview_NE_Department_Internalname;
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
         ScanStart1Q72( ) ;
         if ( RcdFound72 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound72 != 0 )
            {
               ScanNext1Q72( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtview_NE_Department_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1Q72( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1Q72( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001Q2 */
            pr_default.execute(0, new Object[] {A549view_NE_EncounterID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VIEW_NEW_ENCOUNTER"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z550view_NE_Department, T001Q2_A550view_NE_Department[0]) != 0 ) || ( StringUtil.StrCmp(Z551view_NE_ENCType, T001Q2_A551view_NE_ENCType[0]) != 0 ) || ( Z552view_NE_AdmitDate != T001Q2_A552view_NE_AdmitDate[0] ) || ( Z553view_NE_Status != T001Q2_A553view_NE_Status[0] ) || ( Z554view_NE_IsRandRecheck != T001Q2_A554view_NE_IsRandRecheck[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z555view_NE_IsRandApprove != T001Q2_A555view_NE_IsRandApprove[0] ) || ( Z556view_NE_IsUpdate != T001Q2_A556view_NE_IsUpdate[0] ) || ( StringUtil.StrCmp(Z557view_NE_TenantTenantCode, T001Q2_A557view_NE_TenantTenantCode[0]) != 0 ) || ( Z558view_NE_Information_ID != T001Q2_A558view_NE_Information_ID[0] ) || ( StringUtil.StrCmp(Z559view_NE_Information_PatientNo, T001Q2_A559view_NE_Information_PatientNo[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z550view_NE_Department, T001Q2_A550view_NE_Department[0]) != 0 )
               {
                  GXUtil.WriteLog("view_new_encounter:[seudo value changed for attri]"+"view_NE_Department");
                  GXUtil.WriteLogRaw("Old: ",Z550view_NE_Department);
                  GXUtil.WriteLogRaw("Current: ",T001Q2_A550view_NE_Department[0]);
               }
               if ( StringUtil.StrCmp(Z551view_NE_ENCType, T001Q2_A551view_NE_ENCType[0]) != 0 )
               {
                  GXUtil.WriteLog("view_new_encounter:[seudo value changed for attri]"+"view_NE_ENCType");
                  GXUtil.WriteLogRaw("Old: ",Z551view_NE_ENCType);
                  GXUtil.WriteLogRaw("Current: ",T001Q2_A551view_NE_ENCType[0]);
               }
               if ( Z552view_NE_AdmitDate != T001Q2_A552view_NE_AdmitDate[0] )
               {
                  GXUtil.WriteLog("view_new_encounter:[seudo value changed for attri]"+"view_NE_AdmitDate");
                  GXUtil.WriteLogRaw("Old: ",Z552view_NE_AdmitDate);
                  GXUtil.WriteLogRaw("Current: ",T001Q2_A552view_NE_AdmitDate[0]);
               }
               if ( Z553view_NE_Status != T001Q2_A553view_NE_Status[0] )
               {
                  GXUtil.WriteLog("view_new_encounter:[seudo value changed for attri]"+"view_NE_Status");
                  GXUtil.WriteLogRaw("Old: ",Z553view_NE_Status);
                  GXUtil.WriteLogRaw("Current: ",T001Q2_A553view_NE_Status[0]);
               }
               if ( Z554view_NE_IsRandRecheck != T001Q2_A554view_NE_IsRandRecheck[0] )
               {
                  GXUtil.WriteLog("view_new_encounter:[seudo value changed for attri]"+"view_NE_IsRandRecheck");
                  GXUtil.WriteLogRaw("Old: ",Z554view_NE_IsRandRecheck);
                  GXUtil.WriteLogRaw("Current: ",T001Q2_A554view_NE_IsRandRecheck[0]);
               }
               if ( Z555view_NE_IsRandApprove != T001Q2_A555view_NE_IsRandApprove[0] )
               {
                  GXUtil.WriteLog("view_new_encounter:[seudo value changed for attri]"+"view_NE_IsRandApprove");
                  GXUtil.WriteLogRaw("Old: ",Z555view_NE_IsRandApprove);
                  GXUtil.WriteLogRaw("Current: ",T001Q2_A555view_NE_IsRandApprove[0]);
               }
               if ( Z556view_NE_IsUpdate != T001Q2_A556view_NE_IsUpdate[0] )
               {
                  GXUtil.WriteLog("view_new_encounter:[seudo value changed for attri]"+"view_NE_IsUpdate");
                  GXUtil.WriteLogRaw("Old: ",Z556view_NE_IsUpdate);
                  GXUtil.WriteLogRaw("Current: ",T001Q2_A556view_NE_IsUpdate[0]);
               }
               if ( StringUtil.StrCmp(Z557view_NE_TenantTenantCode, T001Q2_A557view_NE_TenantTenantCode[0]) != 0 )
               {
                  GXUtil.WriteLog("view_new_encounter:[seudo value changed for attri]"+"view_NE_TenantTenantCode");
                  GXUtil.WriteLogRaw("Old: ",Z557view_NE_TenantTenantCode);
                  GXUtil.WriteLogRaw("Current: ",T001Q2_A557view_NE_TenantTenantCode[0]);
               }
               if ( Z558view_NE_Information_ID != T001Q2_A558view_NE_Information_ID[0] )
               {
                  GXUtil.WriteLog("view_new_encounter:[seudo value changed for attri]"+"view_NE_Information_ID");
                  GXUtil.WriteLogRaw("Old: ",Z558view_NE_Information_ID);
                  GXUtil.WriteLogRaw("Current: ",T001Q2_A558view_NE_Information_ID[0]);
               }
               if ( StringUtil.StrCmp(Z559view_NE_Information_PatientNo, T001Q2_A559view_NE_Information_PatientNo[0]) != 0 )
               {
                  GXUtil.WriteLog("view_new_encounter:[seudo value changed for attri]"+"view_NE_Information_PatientNo");
                  GXUtil.WriteLogRaw("Old: ",Z559view_NE_Information_PatientNo);
                  GXUtil.WriteLogRaw("Current: ",T001Q2_A559view_NE_Information_PatientNo[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"VIEW_NEW_ENCOUNTER"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1Q72( )
      {
         BeforeValidate1Q72( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1Q72( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1Q72( 0) ;
            CheckOptimisticConcurrency1Q72( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1Q72( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1Q72( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001Q8 */
                     pr_default.execute(6, new Object[] {A549view_NE_EncounterID, n550view_NE_Department, A550view_NE_Department, n551view_NE_ENCType, A551view_NE_ENCType, n552view_NE_AdmitDate, A552view_NE_AdmitDate, n553view_NE_Status, A553view_NE_Status, n554view_NE_IsRandRecheck, A554view_NE_IsRandRecheck, n555view_NE_IsRandApprove, A555view_NE_IsRandApprove, n556view_NE_IsUpdate, A556view_NE_IsUpdate, n557view_NE_TenantTenantCode, A557view_NE_TenantTenantCode, n558view_NE_Information_ID, A558view_NE_Information_ID, n559view_NE_Information_PatientNo, A559view_NE_Information_PatientNo});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("VIEW_NEW_ENCOUNTER") ;
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
                           ResetCaption1Q0( ) ;
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
               Load1Q72( ) ;
            }
            EndLevel1Q72( ) ;
         }
         CloseExtendedTableCursors1Q72( ) ;
      }

      protected void Update1Q72( )
      {
         BeforeValidate1Q72( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1Q72( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1Q72( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1Q72( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1Q72( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001Q9 */
                     pr_default.execute(7, new Object[] {n550view_NE_Department, A550view_NE_Department, n551view_NE_ENCType, A551view_NE_ENCType, n552view_NE_AdmitDate, A552view_NE_AdmitDate, n553view_NE_Status, A553view_NE_Status, n554view_NE_IsRandRecheck, A554view_NE_IsRandRecheck, n555view_NE_IsRandApprove, A555view_NE_IsRandApprove, n556view_NE_IsUpdate, A556view_NE_IsUpdate, n557view_NE_TenantTenantCode, A557view_NE_TenantTenantCode, n558view_NE_Information_ID, A558view_NE_Information_ID, n559view_NE_Information_PatientNo, A559view_NE_Information_PatientNo, A549view_NE_EncounterID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("VIEW_NEW_ENCOUNTER") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VIEW_NEW_ENCOUNTER"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1Q72( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1Q0( ) ;
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
            EndLevel1Q72( ) ;
         }
         CloseExtendedTableCursors1Q72( ) ;
      }

      protected void DeferredUpdate1Q72( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1Q72( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1Q72( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1Q72( ) ;
            AfterConfirm1Q72( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1Q72( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001Q10 */
                  pr_default.execute(8, new Object[] {A549view_NE_EncounterID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("VIEW_NEW_ENCOUNTER") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound72 == 0 )
                        {
                           InitAll1Q72( ) ;
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
                        ResetCaption1Q0( ) ;
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
         sMode72 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1Q72( ) ;
         Gx_mode = sMode72;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1Q72( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1Q72( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1Q72( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("view_new_encounter",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1Q0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("view_new_encounter",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1Q72( )
      {
         /* Using cursor T001Q11 */
         pr_default.execute(9);
         RcdFound72 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound72 = 1;
            A549view_NE_EncounterID = T001Q11_A549view_NE_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1Q72( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound72 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound72 = 1;
            A549view_NE_EncounterID = T001Q11_A549view_NE_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
         }
      }

      protected void ScanEnd1Q72( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm1Q72( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1Q72( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1Q72( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1Q72( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1Q72( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1Q72( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1Q72( )
      {
         edtview_NE_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtview_NE_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtview_NE_EncounterID_Enabled), 5, 0)), true);
         edtview_NE_Department_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtview_NE_Department_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtview_NE_Department_Enabled), 5, 0)), true);
         edtview_NE_ENCType_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtview_NE_ENCType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtview_NE_ENCType_Enabled), 5, 0)), true);
         edtview_NE_AdmitDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtview_NE_AdmitDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtview_NE_AdmitDate_Enabled), 5, 0)), true);
         cmbview_NE_Status.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbview_NE_Status_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbview_NE_Status.Enabled), 5, 0)), true);
         chkview_NE_IsRandRecheck.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkview_NE_IsRandRecheck_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkview_NE_IsRandRecheck.Enabled), 5, 0)), true);
         chkview_NE_IsRandApprove.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkview_NE_IsRandApprove_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkview_NE_IsRandApprove.Enabled), 5, 0)), true);
         chkview_NE_IsUpdate.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkview_NE_IsUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkview_NE_IsUpdate.Enabled), 5, 0)), true);
         edtview_NE_TenantTenantCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtview_NE_TenantTenantCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtview_NE_TenantTenantCode_Enabled), 5, 0)), true);
         edtview_NE_Information_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtview_NE_Information_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtview_NE_Information_ID_Enabled), 5, 0)), true);
         edtview_NE_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtview_NE_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtview_NE_Information_PatientNo_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1Q72( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1Q0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202022711581698", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("view_new_encounter.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z549view_NE_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z549view_NE_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z550view_NE_Department", Z550view_NE_Department);
         GxWebStd.gx_hidden_field( context, "Z551view_NE_ENCType", Z551view_NE_ENCType);
         GxWebStd.gx_hidden_field( context, "Z552view_NE_AdmitDate", context.localUtil.DToC( Z552view_NE_AdmitDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z553view_NE_Status", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z553view_NE_Status), 4, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, "Z554view_NE_IsRandRecheck", Z554view_NE_IsRandRecheck);
         GxWebStd.gx_boolean_hidden_field( context, "Z555view_NE_IsRandApprove", Z555view_NE_IsRandApprove);
         GxWebStd.gx_boolean_hidden_field( context, "Z556view_NE_IsUpdate", Z556view_NE_IsUpdate);
         GxWebStd.gx_hidden_field( context, "Z557view_NE_TenantTenantCode", Z557view_NE_TenantTenantCode);
         GxWebStd.gx_hidden_field( context, "Z558view_NE_Information_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z558view_NE_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z559view_NE_Information_PatientNo", Z559view_NE_Information_PatientNo);
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
         return formatLink("view_new_encounter.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "View_New_Encounter" ;
      }

      public override String GetPgmdesc( )
      {
         return "View_New_Encounter" ;
      }

      protected void InitializeNonKey1Q72( )
      {
         A550view_NE_Department = "";
         n550view_NE_Department = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A550view_NE_Department", A550view_NE_Department);
         n550view_NE_Department = (String.IsNullOrEmpty(StringUtil.RTrim( A550view_NE_Department)) ? true : false);
         A551view_NE_ENCType = "";
         n551view_NE_ENCType = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A551view_NE_ENCType", A551view_NE_ENCType);
         n551view_NE_ENCType = (String.IsNullOrEmpty(StringUtil.RTrim( A551view_NE_ENCType)) ? true : false);
         A552view_NE_AdmitDate = DateTime.MinValue;
         n552view_NE_AdmitDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A552view_NE_AdmitDate", context.localUtil.Format(A552view_NE_AdmitDate, "9999/99/99"));
         n552view_NE_AdmitDate = ((DateTime.MinValue==A552view_NE_AdmitDate) ? true : false);
         A553view_NE_Status = 0;
         n553view_NE_Status = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A553view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0)));
         n553view_NE_Status = ((0==A553view_NE_Status) ? true : false);
         A554view_NE_IsRandRecheck = false;
         n554view_NE_IsRandRecheck = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A554view_NE_IsRandRecheck", A554view_NE_IsRandRecheck);
         n554view_NE_IsRandRecheck = ((false==A554view_NE_IsRandRecheck) ? true : false);
         A555view_NE_IsRandApprove = false;
         n555view_NE_IsRandApprove = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A555view_NE_IsRandApprove", A555view_NE_IsRandApprove);
         n555view_NE_IsRandApprove = ((false==A555view_NE_IsRandApprove) ? true : false);
         A556view_NE_IsUpdate = false;
         n556view_NE_IsUpdate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A556view_NE_IsUpdate", A556view_NE_IsUpdate);
         n556view_NE_IsUpdate = ((false==A556view_NE_IsUpdate) ? true : false);
         A557view_NE_TenantTenantCode = "";
         n557view_NE_TenantTenantCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A557view_NE_TenantTenantCode", A557view_NE_TenantTenantCode);
         n557view_NE_TenantTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A557view_NE_TenantTenantCode)) ? true : false);
         A558view_NE_Information_ID = 0;
         n558view_NE_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A558view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A558view_NE_Information_ID), 18, 0)));
         n558view_NE_Information_ID = ((0==A558view_NE_Information_ID) ? true : false);
         A559view_NE_Information_PatientNo = "";
         n559view_NE_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A559view_NE_Information_PatientNo", A559view_NE_Information_PatientNo);
         n559view_NE_Information_PatientNo = (String.IsNullOrEmpty(StringUtil.RTrim( A559view_NE_Information_PatientNo)) ? true : false);
         Z550view_NE_Department = "";
         Z551view_NE_ENCType = "";
         Z552view_NE_AdmitDate = DateTime.MinValue;
         Z553view_NE_Status = 0;
         Z554view_NE_IsRandRecheck = false;
         Z555view_NE_IsRandApprove = false;
         Z556view_NE_IsUpdate = false;
         Z557view_NE_TenantTenantCode = "";
         Z558view_NE_Information_ID = 0;
         Z559view_NE_Information_PatientNo = "";
      }

      protected void InitAll1Q72( )
      {
         A549view_NE_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A549view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A549view_NE_EncounterID), 18, 0)));
         InitializeNonKey1Q72( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271158176", true);
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
         context.AddJavascriptSource("view_new_encounter.js", "?20202271158176", false);
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
         edtview_NE_EncounterID_Internalname = "VIEW_NE_ENCOUNTERID";
         edtview_NE_Department_Internalname = "VIEW_NE_DEPARTMENT";
         edtview_NE_ENCType_Internalname = "VIEW_NE_ENCTYPE";
         edtview_NE_AdmitDate_Internalname = "VIEW_NE_ADMITDATE";
         cmbview_NE_Status_Internalname = "VIEW_NE_STATUS";
         chkview_NE_IsRandRecheck_Internalname = "VIEW_NE_ISRANDRECHECK";
         chkview_NE_IsRandApprove_Internalname = "VIEW_NE_ISRANDAPPROVE";
         chkview_NE_IsUpdate_Internalname = "VIEW_NE_ISUPDATE";
         edtview_NE_TenantTenantCode_Internalname = "VIEW_NE_TENANTTENANTCODE";
         edtview_NE_Information_ID_Internalname = "VIEW_NE_INFORMATION_ID";
         edtview_NE_Information_PatientNo_Internalname = "VIEW_NE_INFORMATION_PATIENTNO";
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
         Form.Caption = "View_New_Encounter";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtview_NE_Information_PatientNo_Enabled = 1;
         edtview_NE_Information_ID_Jsonclick = "";
         edtview_NE_Information_ID_Enabled = 1;
         edtview_NE_TenantTenantCode_Jsonclick = "";
         edtview_NE_TenantTenantCode_Enabled = 1;
         chkview_NE_IsUpdate.Enabled = 1;
         chkview_NE_IsRandApprove.Enabled = 1;
         chkview_NE_IsRandRecheck.Enabled = 1;
         cmbview_NE_Status_Jsonclick = "";
         cmbview_NE_Status.Enabled = 1;
         edtview_NE_AdmitDate_Jsonclick = "";
         edtview_NE_AdmitDate_Enabled = 1;
         edtview_NE_ENCType_Enabled = 1;
         edtview_NE_Department_Enabled = 1;
         edtview_NE_EncounterID_Jsonclick = "";
         edtview_NE_EncounterID_Enabled = 1;
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
         cmbview_NE_Status.Name = "VIEW_NE_STATUS";
         cmbview_NE_Status.WebTags = "";
         cmbview_NE_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
         cmbview_NE_Status.addItem("1", "录入中", 0);
         cmbview_NE_Status.addItem("2", "待初审", 0);
         cmbview_NE_Status.addItem("3", "初审不通过", 0);
         cmbview_NE_Status.addItem("4", "待复审", 0);
         cmbview_NE_Status.addItem("5", "复审不通过", 0);
         cmbview_NE_Status.addItem("6", "完成", 0);
         if ( cmbview_NE_Status.ItemCount > 0 )
         {
            A553view_NE_Status = (short)(NumberUtil.Val( cmbview_NE_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0))), "."));
            n553view_NE_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A553view_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0)));
         }
         chkview_NE_IsRandRecheck.Name = "VIEW_NE_ISRANDRECHECK";
         chkview_NE_IsRandRecheck.WebTags = "";
         chkview_NE_IsRandRecheck.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkview_NE_IsRandRecheck_Internalname, "TitleCaption", chkview_NE_IsRandRecheck.Caption, true);
         chkview_NE_IsRandRecheck.CheckedValue = "false";
         chkview_NE_IsRandApprove.Name = "VIEW_NE_ISRANDAPPROVE";
         chkview_NE_IsRandApprove.WebTags = "";
         chkview_NE_IsRandApprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkview_NE_IsRandApprove_Internalname, "TitleCaption", chkview_NE_IsRandApprove.Caption, true);
         chkview_NE_IsRandApprove.CheckedValue = "false";
         chkview_NE_IsUpdate.Name = "VIEW_NE_ISUPDATE";
         chkview_NE_IsUpdate.WebTags = "";
         chkview_NE_IsUpdate.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkview_NE_IsUpdate_Internalname, "TitleCaption", chkview_NE_IsUpdate.Caption, true);
         chkview_NE_IsUpdate.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtview_NE_Department_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_View_ne_encounterid( long GX_Parm1 ,
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
         A549view_NE_EncounterID = GX_Parm1;
         A550view_NE_Department = GX_Parm2;
         n550view_NE_Department = false;
         A551view_NE_ENCType = GX_Parm3;
         n551view_NE_ENCType = false;
         A552view_NE_AdmitDate = GX_Parm4;
         n552view_NE_AdmitDate = false;
         cmbview_NE_Status = cmbGX_Parm5;
         A553view_NE_Status = (short)(NumberUtil.Val( cmbview_NE_Status.CurrentValue, "."));
         n553view_NE_Status = false;
         cmbview_NE_Status.CurrentValue = StringUtil.LTrim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0));
         A554view_NE_IsRandRecheck = GX_Parm6;
         n554view_NE_IsRandRecheck = false;
         A555view_NE_IsRandApprove = GX_Parm7;
         n555view_NE_IsRandApprove = false;
         A556view_NE_IsUpdate = GX_Parm8;
         n556view_NE_IsUpdate = false;
         A557view_NE_TenantTenantCode = GX_Parm9;
         n557view_NE_TenantTenantCode = false;
         A558view_NE_Information_ID = GX_Parm10;
         n558view_NE_Information_ID = false;
         A559view_NE_Information_PatientNo = GX_Parm11;
         n559view_NE_Information_PatientNo = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A550view_NE_Department);
         isValidOutput.Add(A551view_NE_ENCType);
         isValidOutput.Add(context.localUtil.Format(A552view_NE_AdmitDate, "9999/99/99"));
         cmbview_NE_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0));
         isValidOutput.Add(cmbview_NE_Status);
         isValidOutput.Add(A554view_NE_IsRandRecheck);
         isValidOutput.Add(A555view_NE_IsRandApprove);
         isValidOutput.Add(A556view_NE_IsUpdate);
         isValidOutput.Add(A557view_NE_TenantTenantCode);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A558view_NE_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(A559view_NE_Information_PatientNo);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z549view_NE_EncounterID), 18, 0, ".", "")));
         isValidOutput.Add(Z550view_NE_Department);
         isValidOutput.Add(Z551view_NE_ENCType);
         isValidOutput.Add(context.localUtil.DToC( Z552view_NE_AdmitDate, 0, "/"));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z553view_NE_Status), 4, 0, ".", "")));
         isValidOutput.Add(Z554view_NE_IsRandRecheck);
         isValidOutput.Add(Z555view_NE_IsRandApprove);
         isValidOutput.Add(Z556view_NE_IsUpdate);
         isValidOutput.Add(Z557view_NE_TenantTenantCode);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z558view_NE_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(Z559view_NE_Information_PatientNo);
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
         Z550view_NE_Department = "";
         Z551view_NE_ENCType = "";
         Z552view_NE_AdmitDate = DateTime.MinValue;
         Z557view_NE_TenantTenantCode = "";
         Z559view_NE_Information_PatientNo = "";
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
         A550view_NE_Department = "";
         A551view_NE_ENCType = "";
         A552view_NE_AdmitDate = DateTime.MinValue;
         A557view_NE_TenantTenantCode = "";
         A559view_NE_Information_PatientNo = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T001Q4_A549view_NE_EncounterID = new long[1] ;
         T001Q4_A550view_NE_Department = new String[] {""} ;
         T001Q4_n550view_NE_Department = new bool[] {false} ;
         T001Q4_A551view_NE_ENCType = new String[] {""} ;
         T001Q4_n551view_NE_ENCType = new bool[] {false} ;
         T001Q4_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T001Q4_n552view_NE_AdmitDate = new bool[] {false} ;
         T001Q4_A553view_NE_Status = new short[1] ;
         T001Q4_n553view_NE_Status = new bool[] {false} ;
         T001Q4_A554view_NE_IsRandRecheck = new bool[] {false} ;
         T001Q4_n554view_NE_IsRandRecheck = new bool[] {false} ;
         T001Q4_A555view_NE_IsRandApprove = new bool[] {false} ;
         T001Q4_n555view_NE_IsRandApprove = new bool[] {false} ;
         T001Q4_A556view_NE_IsUpdate = new bool[] {false} ;
         T001Q4_n556view_NE_IsUpdate = new bool[] {false} ;
         T001Q4_A557view_NE_TenantTenantCode = new String[] {""} ;
         T001Q4_n557view_NE_TenantTenantCode = new bool[] {false} ;
         T001Q4_A558view_NE_Information_ID = new long[1] ;
         T001Q4_n558view_NE_Information_ID = new bool[] {false} ;
         T001Q4_A559view_NE_Information_PatientNo = new String[] {""} ;
         T001Q4_n559view_NE_Information_PatientNo = new bool[] {false} ;
         T001Q5_A549view_NE_EncounterID = new long[1] ;
         T001Q3_A549view_NE_EncounterID = new long[1] ;
         T001Q3_A550view_NE_Department = new String[] {""} ;
         T001Q3_n550view_NE_Department = new bool[] {false} ;
         T001Q3_A551view_NE_ENCType = new String[] {""} ;
         T001Q3_n551view_NE_ENCType = new bool[] {false} ;
         T001Q3_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T001Q3_n552view_NE_AdmitDate = new bool[] {false} ;
         T001Q3_A553view_NE_Status = new short[1] ;
         T001Q3_n553view_NE_Status = new bool[] {false} ;
         T001Q3_A554view_NE_IsRandRecheck = new bool[] {false} ;
         T001Q3_n554view_NE_IsRandRecheck = new bool[] {false} ;
         T001Q3_A555view_NE_IsRandApprove = new bool[] {false} ;
         T001Q3_n555view_NE_IsRandApprove = new bool[] {false} ;
         T001Q3_A556view_NE_IsUpdate = new bool[] {false} ;
         T001Q3_n556view_NE_IsUpdate = new bool[] {false} ;
         T001Q3_A557view_NE_TenantTenantCode = new String[] {""} ;
         T001Q3_n557view_NE_TenantTenantCode = new bool[] {false} ;
         T001Q3_A558view_NE_Information_ID = new long[1] ;
         T001Q3_n558view_NE_Information_ID = new bool[] {false} ;
         T001Q3_A559view_NE_Information_PatientNo = new String[] {""} ;
         T001Q3_n559view_NE_Information_PatientNo = new bool[] {false} ;
         sMode72 = "";
         T001Q6_A549view_NE_EncounterID = new long[1] ;
         T001Q7_A549view_NE_EncounterID = new long[1] ;
         T001Q2_A549view_NE_EncounterID = new long[1] ;
         T001Q2_A550view_NE_Department = new String[] {""} ;
         T001Q2_n550view_NE_Department = new bool[] {false} ;
         T001Q2_A551view_NE_ENCType = new String[] {""} ;
         T001Q2_n551view_NE_ENCType = new bool[] {false} ;
         T001Q2_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T001Q2_n552view_NE_AdmitDate = new bool[] {false} ;
         T001Q2_A553view_NE_Status = new short[1] ;
         T001Q2_n553view_NE_Status = new bool[] {false} ;
         T001Q2_A554view_NE_IsRandRecheck = new bool[] {false} ;
         T001Q2_n554view_NE_IsRandRecheck = new bool[] {false} ;
         T001Q2_A555view_NE_IsRandApprove = new bool[] {false} ;
         T001Q2_n555view_NE_IsRandApprove = new bool[] {false} ;
         T001Q2_A556view_NE_IsUpdate = new bool[] {false} ;
         T001Q2_n556view_NE_IsUpdate = new bool[] {false} ;
         T001Q2_A557view_NE_TenantTenantCode = new String[] {""} ;
         T001Q2_n557view_NE_TenantTenantCode = new bool[] {false} ;
         T001Q2_A558view_NE_Information_ID = new long[1] ;
         T001Q2_n558view_NE_Information_ID = new bool[] {false} ;
         T001Q2_A559view_NE_Information_PatientNo = new String[] {""} ;
         T001Q2_n559view_NE_Information_PatientNo = new bool[] {false} ;
         T001Q11_A549view_NE_EncounterID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.view_new_encounter__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.view_new_encounter__default(),
            new Object[][] {
                new Object[] {
               T001Q2_A549view_NE_EncounterID, T001Q2_A550view_NE_Department, T001Q2_n550view_NE_Department, T001Q2_A551view_NE_ENCType, T001Q2_n551view_NE_ENCType, T001Q2_A552view_NE_AdmitDate, T001Q2_n552view_NE_AdmitDate, T001Q2_A553view_NE_Status, T001Q2_n553view_NE_Status, T001Q2_A554view_NE_IsRandRecheck,
               T001Q2_n554view_NE_IsRandRecheck, T001Q2_A555view_NE_IsRandApprove, T001Q2_n555view_NE_IsRandApprove, T001Q2_A556view_NE_IsUpdate, T001Q2_n556view_NE_IsUpdate, T001Q2_A557view_NE_TenantTenantCode, T001Q2_n557view_NE_TenantTenantCode, T001Q2_A558view_NE_Information_ID, T001Q2_n558view_NE_Information_ID, T001Q2_A559view_NE_Information_PatientNo,
               T001Q2_n559view_NE_Information_PatientNo
               }
               , new Object[] {
               T001Q3_A549view_NE_EncounterID, T001Q3_A550view_NE_Department, T001Q3_n550view_NE_Department, T001Q3_A551view_NE_ENCType, T001Q3_n551view_NE_ENCType, T001Q3_A552view_NE_AdmitDate, T001Q3_n552view_NE_AdmitDate, T001Q3_A553view_NE_Status, T001Q3_n553view_NE_Status, T001Q3_A554view_NE_IsRandRecheck,
               T001Q3_n554view_NE_IsRandRecheck, T001Q3_A555view_NE_IsRandApprove, T001Q3_n555view_NE_IsRandApprove, T001Q3_A556view_NE_IsUpdate, T001Q3_n556view_NE_IsUpdate, T001Q3_A557view_NE_TenantTenantCode, T001Q3_n557view_NE_TenantTenantCode, T001Q3_A558view_NE_Information_ID, T001Q3_n558view_NE_Information_ID, T001Q3_A559view_NE_Information_PatientNo,
               T001Q3_n559view_NE_Information_PatientNo
               }
               , new Object[] {
               T001Q4_A549view_NE_EncounterID, T001Q4_A550view_NE_Department, T001Q4_n550view_NE_Department, T001Q4_A551view_NE_ENCType, T001Q4_n551view_NE_ENCType, T001Q4_A552view_NE_AdmitDate, T001Q4_n552view_NE_AdmitDate, T001Q4_A553view_NE_Status, T001Q4_n553view_NE_Status, T001Q4_A554view_NE_IsRandRecheck,
               T001Q4_n554view_NE_IsRandRecheck, T001Q4_A555view_NE_IsRandApprove, T001Q4_n555view_NE_IsRandApprove, T001Q4_A556view_NE_IsUpdate, T001Q4_n556view_NE_IsUpdate, T001Q4_A557view_NE_TenantTenantCode, T001Q4_n557view_NE_TenantTenantCode, T001Q4_A558view_NE_Information_ID, T001Q4_n558view_NE_Information_ID, T001Q4_A559view_NE_Information_PatientNo,
               T001Q4_n559view_NE_Information_PatientNo
               }
               , new Object[] {
               T001Q5_A549view_NE_EncounterID
               }
               , new Object[] {
               T001Q6_A549view_NE_EncounterID
               }
               , new Object[] {
               T001Q7_A549view_NE_EncounterID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001Q11_A549view_NE_EncounterID
               }
            }
         );
      }

      private short Z553view_NE_Status ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A553view_NE_Status ;
      private short GX_JID ;
      private short RcdFound72 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtview_NE_EncounterID_Enabled ;
      private int edtview_NE_Department_Enabled ;
      private int edtview_NE_ENCType_Enabled ;
      private int edtview_NE_AdmitDate_Enabled ;
      private int edtview_NE_TenantTenantCode_Enabled ;
      private int edtview_NE_Information_ID_Enabled ;
      private int edtview_NE_Information_PatientNo_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z549view_NE_EncounterID ;
      private long Z558view_NE_Information_ID ;
      private long A549view_NE_EncounterID ;
      private long A558view_NE_Information_ID ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtview_NE_EncounterID_Internalname ;
      private String cmbview_NE_Status_Internalname ;
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
      private String edtview_NE_EncounterID_Jsonclick ;
      private String edtview_NE_Department_Internalname ;
      private String edtview_NE_ENCType_Internalname ;
      private String edtview_NE_AdmitDate_Internalname ;
      private String edtview_NE_AdmitDate_Jsonclick ;
      private String cmbview_NE_Status_Jsonclick ;
      private String chkview_NE_IsRandRecheck_Internalname ;
      private String chkview_NE_IsRandApprove_Internalname ;
      private String chkview_NE_IsUpdate_Internalname ;
      private String edtview_NE_TenantTenantCode_Internalname ;
      private String edtview_NE_TenantTenantCode_Jsonclick ;
      private String edtview_NE_Information_ID_Internalname ;
      private String edtview_NE_Information_ID_Jsonclick ;
      private String edtview_NE_Information_PatientNo_Internalname ;
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
      private String sMode72 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z552view_NE_AdmitDate ;
      private DateTime A552view_NE_AdmitDate ;
      private bool Z554view_NE_IsRandRecheck ;
      private bool Z555view_NE_IsRandApprove ;
      private bool Z556view_NE_IsUpdate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n553view_NE_Status ;
      private bool A554view_NE_IsRandRecheck ;
      private bool A555view_NE_IsRandApprove ;
      private bool A556view_NE_IsUpdate ;
      private bool n550view_NE_Department ;
      private bool n551view_NE_ENCType ;
      private bool n552view_NE_AdmitDate ;
      private bool n554view_NE_IsRandRecheck ;
      private bool n555view_NE_IsRandApprove ;
      private bool n556view_NE_IsUpdate ;
      private bool n557view_NE_TenantTenantCode ;
      private bool n558view_NE_Information_ID ;
      private bool n559view_NE_Information_PatientNo ;
      private bool Gx_longc ;
      private String Z550view_NE_Department ;
      private String Z551view_NE_ENCType ;
      private String Z557view_NE_TenantTenantCode ;
      private String Z559view_NE_Information_PatientNo ;
      private String A550view_NE_Department ;
      private String A551view_NE_ENCType ;
      private String A557view_NE_TenantTenantCode ;
      private String A559view_NE_Information_PatientNo ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbview_NE_Status ;
      private GXCheckbox chkview_NE_IsRandRecheck ;
      private GXCheckbox chkview_NE_IsRandApprove ;
      private GXCheckbox chkview_NE_IsUpdate ;
      private IDataStoreProvider pr_default ;
      private long[] T001Q4_A549view_NE_EncounterID ;
      private String[] T001Q4_A550view_NE_Department ;
      private bool[] T001Q4_n550view_NE_Department ;
      private String[] T001Q4_A551view_NE_ENCType ;
      private bool[] T001Q4_n551view_NE_ENCType ;
      private DateTime[] T001Q4_A552view_NE_AdmitDate ;
      private bool[] T001Q4_n552view_NE_AdmitDate ;
      private short[] T001Q4_A553view_NE_Status ;
      private bool[] T001Q4_n553view_NE_Status ;
      private bool[] T001Q4_A554view_NE_IsRandRecheck ;
      private bool[] T001Q4_n554view_NE_IsRandRecheck ;
      private bool[] T001Q4_A555view_NE_IsRandApprove ;
      private bool[] T001Q4_n555view_NE_IsRandApprove ;
      private bool[] T001Q4_A556view_NE_IsUpdate ;
      private bool[] T001Q4_n556view_NE_IsUpdate ;
      private String[] T001Q4_A557view_NE_TenantTenantCode ;
      private bool[] T001Q4_n557view_NE_TenantTenantCode ;
      private long[] T001Q4_A558view_NE_Information_ID ;
      private bool[] T001Q4_n558view_NE_Information_ID ;
      private String[] T001Q4_A559view_NE_Information_PatientNo ;
      private bool[] T001Q4_n559view_NE_Information_PatientNo ;
      private long[] T001Q5_A549view_NE_EncounterID ;
      private long[] T001Q3_A549view_NE_EncounterID ;
      private String[] T001Q3_A550view_NE_Department ;
      private bool[] T001Q3_n550view_NE_Department ;
      private String[] T001Q3_A551view_NE_ENCType ;
      private bool[] T001Q3_n551view_NE_ENCType ;
      private DateTime[] T001Q3_A552view_NE_AdmitDate ;
      private bool[] T001Q3_n552view_NE_AdmitDate ;
      private short[] T001Q3_A553view_NE_Status ;
      private bool[] T001Q3_n553view_NE_Status ;
      private bool[] T001Q3_A554view_NE_IsRandRecheck ;
      private bool[] T001Q3_n554view_NE_IsRandRecheck ;
      private bool[] T001Q3_A555view_NE_IsRandApprove ;
      private bool[] T001Q3_n555view_NE_IsRandApprove ;
      private bool[] T001Q3_A556view_NE_IsUpdate ;
      private bool[] T001Q3_n556view_NE_IsUpdate ;
      private String[] T001Q3_A557view_NE_TenantTenantCode ;
      private bool[] T001Q3_n557view_NE_TenantTenantCode ;
      private long[] T001Q3_A558view_NE_Information_ID ;
      private bool[] T001Q3_n558view_NE_Information_ID ;
      private String[] T001Q3_A559view_NE_Information_PatientNo ;
      private bool[] T001Q3_n559view_NE_Information_PatientNo ;
      private long[] T001Q6_A549view_NE_EncounterID ;
      private long[] T001Q7_A549view_NE_EncounterID ;
      private long[] T001Q2_A549view_NE_EncounterID ;
      private String[] T001Q2_A550view_NE_Department ;
      private bool[] T001Q2_n550view_NE_Department ;
      private String[] T001Q2_A551view_NE_ENCType ;
      private bool[] T001Q2_n551view_NE_ENCType ;
      private DateTime[] T001Q2_A552view_NE_AdmitDate ;
      private bool[] T001Q2_n552view_NE_AdmitDate ;
      private short[] T001Q2_A553view_NE_Status ;
      private bool[] T001Q2_n553view_NE_Status ;
      private bool[] T001Q2_A554view_NE_IsRandRecheck ;
      private bool[] T001Q2_n554view_NE_IsRandRecheck ;
      private bool[] T001Q2_A555view_NE_IsRandApprove ;
      private bool[] T001Q2_n555view_NE_IsRandApprove ;
      private bool[] T001Q2_A556view_NE_IsUpdate ;
      private bool[] T001Q2_n556view_NE_IsUpdate ;
      private String[] T001Q2_A557view_NE_TenantTenantCode ;
      private bool[] T001Q2_n557view_NE_TenantTenantCode ;
      private long[] T001Q2_A558view_NE_Information_ID ;
      private bool[] T001Q2_n558view_NE_Information_ID ;
      private String[] T001Q2_A559view_NE_Information_PatientNo ;
      private bool[] T001Q2_n559view_NE_Information_PatientNo ;
      private long[] T001Q11_A549view_NE_EncounterID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
   }

   public class view_new_encounter__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class view_new_encounter__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT001Q4 ;
        prmT001Q4 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001Q5 ;
        prmT001Q5 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001Q3 ;
        prmT001Q3 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001Q6 ;
        prmT001Q6 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001Q7 ;
        prmT001Q7 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001Q2 ;
        prmT001Q2 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001Q8 ;
        prmT001Q8 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@view_NE_Department",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@view_NE_ENCType",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@view_NE_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@view_NE_IsRandRecheck",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_IsRandApprove",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_IsUpdate",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
        new Object[] {"@view_NE_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@view_NE_Information_PatientNo",SqlDbType.NVarChar,4000,0}
        } ;
        Object[] prmT001Q9 ;
        prmT001Q9 = new Object[] {
        new Object[] {"@view_NE_Department",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@view_NE_ENCType",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@view_NE_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@view_NE_IsRandRecheck",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_IsRandApprove",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_IsUpdate",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
        new Object[] {"@view_NE_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@view_NE_Information_PatientNo",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001Q10 ;
        prmT001Q10 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001Q11 ;
        prmT001Q11 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T001Q2", "SELECT [view_NE_EncounterID], [view_NE_Department], [view_NE_ENCType], [view_NE_AdmitDate], [view_NE_Status], [view_NE_IsRandRecheck], [view_NE_IsRandApprove], [view_NE_IsUpdate], [view_NE_TenantTenantCode], [view_NE_Information_ID], [view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] WITH (UPDLOCK) WHERE [view_NE_EncounterID] = @view_NE_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001Q2,1,0,true,false )
           ,new CursorDef("T001Q3", "SELECT [view_NE_EncounterID], [view_NE_Department], [view_NE_ENCType], [view_NE_AdmitDate], [view_NE_Status], [view_NE_IsRandRecheck], [view_NE_IsRandApprove], [view_NE_IsUpdate], [view_NE_TenantTenantCode], [view_NE_Information_ID], [view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] WITH (NOLOCK) WHERE [view_NE_EncounterID] = @view_NE_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001Q3,1,0,true,false )
           ,new CursorDef("T001Q4", "SELECT TM1.[view_NE_EncounterID], TM1.[view_NE_Department], TM1.[view_NE_ENCType], TM1.[view_NE_AdmitDate], TM1.[view_NE_Status], TM1.[view_NE_IsRandRecheck], TM1.[view_NE_IsRandApprove], TM1.[view_NE_IsUpdate], TM1.[view_NE_TenantTenantCode], TM1.[view_NE_Information_ID], TM1.[view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] TM1 WITH (NOLOCK) WHERE TM1.[view_NE_EncounterID] = @view_NE_EncounterID ORDER BY TM1.[view_NE_EncounterID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001Q4,100,0,true,false )
           ,new CursorDef("T001Q5", "SELECT [view_NE_EncounterID] FROM dbo.[View_New_Encounter] WITH (NOLOCK) WHERE [view_NE_EncounterID] = @view_NE_EncounterID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001Q5,1,0,true,false )
           ,new CursorDef("T001Q6", "SELECT TOP 1 [view_NE_EncounterID] FROM dbo.[View_New_Encounter] WITH (NOLOCK) WHERE ( [view_NE_EncounterID] > @view_NE_EncounterID) ORDER BY [view_NE_EncounterID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001Q6,1,0,true,true )
           ,new CursorDef("T001Q7", "SELECT TOP 1 [view_NE_EncounterID] FROM dbo.[View_New_Encounter] WITH (NOLOCK) WHERE ( [view_NE_EncounterID] < @view_NE_EncounterID) ORDER BY [view_NE_EncounterID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001Q7,1,0,true,true )
           ,new CursorDef("T001Q8", "INSERT INTO dbo.[View_New_Encounter]([view_NE_EncounterID], [view_NE_Department], [view_NE_ENCType], [view_NE_AdmitDate], [view_NE_Status], [view_NE_IsRandRecheck], [view_NE_IsRandApprove], [view_NE_IsUpdate], [view_NE_TenantTenantCode], [view_NE_Information_ID], [view_NE_Information_PatientNo]) VALUES(@view_NE_EncounterID, @view_NE_Department, @view_NE_ENCType, @view_NE_AdmitDate, @view_NE_Status, @view_NE_IsRandRecheck, @view_NE_IsRandApprove, @view_NE_IsUpdate, @view_NE_TenantTenantCode, @view_NE_Information_ID, @view_NE_Information_PatientNo)", GxErrorMask.GX_NOMASK,prmT001Q8)
           ,new CursorDef("T001Q9", "UPDATE dbo.[View_New_Encounter] SET [view_NE_Department]=@view_NE_Department, [view_NE_ENCType]=@view_NE_ENCType, [view_NE_AdmitDate]=@view_NE_AdmitDate, [view_NE_Status]=@view_NE_Status, [view_NE_IsRandRecheck]=@view_NE_IsRandRecheck, [view_NE_IsRandApprove]=@view_NE_IsRandApprove, [view_NE_IsUpdate]=@view_NE_IsUpdate, [view_NE_TenantTenantCode]=@view_NE_TenantTenantCode, [view_NE_Information_ID]=@view_NE_Information_ID, [view_NE_Information_PatientNo]=@view_NE_Information_PatientNo  WHERE [view_NE_EncounterID] = @view_NE_EncounterID", GxErrorMask.GX_NOMASK,prmT001Q9)
           ,new CursorDef("T001Q10", "DELETE FROM dbo.[View_New_Encounter]  WHERE [view_NE_EncounterID] = @view_NE_EncounterID", GxErrorMask.GX_NOMASK,prmT001Q10)
           ,new CursorDef("T001Q11", "SELECT [view_NE_EncounterID] FROM dbo.[View_New_Encounter] WITH (NOLOCK) ORDER BY [view_NE_EncounterID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001Q11,100,0,true,false )
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
