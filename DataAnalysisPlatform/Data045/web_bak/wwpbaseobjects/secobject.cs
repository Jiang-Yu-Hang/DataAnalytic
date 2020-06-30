/*
               File: SecObject
        Description: Sec Object
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:43.39
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
   public class secobject : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A1SecFunctionalityId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A1SecFunctionalityId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridsecobject_functionalities") == 0 )
         {
            nRC_GXsfl_34 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_34_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_34_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridsecobject_functionalities_newrow( ) ;
            return  ;
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
            Form.Meta.addItem("description", "Sec Object", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSecObjectName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public secobject( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secobject( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Sec Object", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecObject.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecObject.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecObject.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecObject.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecObject.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_WWPBaseObjects\\SecObject.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSecObjectName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecObjectName_Internalname, "Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecObjectName_Internalname, A5SecObjectName, StringUtil.RTrim( context.localUtil.Format( A5SecObjectName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecObjectName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecObjectName_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecObject.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitlefunctionalities_Internalname, "Functionalities", "", "", lblTitlefunctionalities_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecObject.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            gxdraw_Gridsecobject_functionalities( ) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecObject.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecObject.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecObject.htm");
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

      protected void gxdraw_Gridsecobject_functionalities( )
      {
         /*  Grid Control  */
         Gridsecobject_functionalitiesContainer.AddObjectProperty("GridName", "Gridsecobject_functionalities");
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Header", subGridsecobject_functionalities_Header);
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Class", "Grid");
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsecobject_functionalities_Backcolorstyle), 1, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddObjectProperty("CmpContext", "");
         Gridsecobject_functionalitiesContainer.AddObjectProperty("InMasterPage", "false");
         Gridsecobject_functionalitiesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridsecobject_functionalitiesColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")));
         Gridsecobject_functionalitiesColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityId_Enabled), 5, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddColumnProperties(Gridsecobject_functionalitiesColumn);
         Gridsecobject_functionalitiesColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridsecobject_functionalitiesColumn.AddObjectProperty("Value", A8SecFunctionalityDescription);
         Gridsecobject_functionalitiesColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityDescription_Enabled), 5, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddColumnProperties(Gridsecobject_functionalitiesColumn);
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsecobject_functionalities_Selectedindex), 4, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsecobject_functionalities_Allowselection), 1, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsecobject_functionalities_Selectioncolor), 9, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsecobject_functionalities_Allowhovering), 1, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsecobject_functionalities_Hoveringcolor), 9, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsecobject_functionalities_Allowcollapsing), 1, 0, ".", "")));
         Gridsecobject_functionalitiesContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridsecobject_functionalities_Collapsed), 1, 0, ".", "")));
         nGXsfl_34_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount4 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_4 = 1;
               ScanStart034( ) ;
               while ( RcdFound4 != 0 )
               {
                  init_level_properties4( ) ;
                  getByPrimaryKey034( ) ;
                  AddRow034( ) ;
                  ScanNext034( ) ;
               }
               ScanEnd034( ) ;
               nBlankRcdCount4 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal034( ) ;
            standaloneModal034( ) ;
            sMode4 = Gx_mode;
            while ( nGXsfl_34_idx < nRC_GXsfl_34 )
            {
               bGXsfl_34_Refreshing = true;
               ReadRow034( ) ;
               edtSecFunctionalityId_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECFUNCTIONALITYID_"+sGXsfl_34_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Enabled), 5, 0)), !bGXsfl_34_Refreshing);
               edtSecFunctionalityDescription_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_34_idx+"Enabled"), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityDescription_Enabled), 5, 0)), !bGXsfl_34_Refreshing);
               if ( ( nRcdExists_4 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal034( ) ;
               }
               SendRow034( ) ;
               bGXsfl_34_Refreshing = false;
            }
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount4 = 5;
            nRcdExists_4 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart034( ) ;
               while ( RcdFound4 != 0 )
               {
                  sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_344( ) ;
                  init_level_properties4( ) ;
                  standaloneNotModal034( ) ;
                  getByPrimaryKey034( ) ;
                  standaloneModal034( ) ;
                  AddRow034( ) ;
                  ScanNext034( ) ;
               }
               ScanEnd034( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         sMode4 = Gx_mode;
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx+1), 4, 0)), 4, "0");
         SubsflControlProps_344( ) ;
         InitAll034( ) ;
         init_level_properties4( ) ;
         standaloneNotModal034( ) ;
         standaloneModal034( ) ;
         nRcdExists_4 = 0;
         nIsMod_4 = 0;
         nRcdDeleted_4 = 0;
         nBlankRcdCount4 = (short)(nBlankRcdUsr4+nBlankRcdCount4);
         fRowAdded = 0;
         while ( nBlankRcdCount4 > 0 )
         {
            AddRow034( ) ;
            if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
            {
               fRowAdded = 1;
               GX_FocusControl = edtSecFunctionalityId_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nBlankRcdCount4 = (short)(nBlankRcdCount4-1);
         }
         Gx_mode = sMode4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridsecobject_functionalitiesContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridsecobject_functionalities", Gridsecobject_functionalitiesContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridsecobject_functionalitiesContainerData", Gridsecobject_functionalitiesContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridsecobject_functionalitiesContainerData"+"V", Gridsecobject_functionalitiesContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridsecobject_functionalitiesContainerData"+"V"+"\" value='"+Gridsecobject_functionalitiesContainer.GridValuesHidden()+"'/>") ;
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
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A5SecObjectName = cgiGet( edtSecObjectName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SecObjectName", A5SecObjectName);
               /* Read saved values. */
               Z5SecObjectName = cgiGet( "Z5SecObjectName");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_34 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_34"), ".", ","));
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               /* Check if conditions changed and reset current page numbers */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A5SecObjectName = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SecObjectName", A5SecObjectName);
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
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
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
               InitAll033( ) ;
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
         DisableAttributes033( ) ;
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

      protected void CONFIRM_034( )
      {
         nGXsfl_34_idx = 0;
         while ( nGXsfl_34_idx < nRC_GXsfl_34 )
         {
            ReadRow034( ) ;
            if ( ( nRcdExists_4 != 0 ) || ( nIsMod_4 != 0 ) )
            {
               GetKey034( ) ;
               if ( ( nRcdExists_4 == 0 ) && ( nRcdDeleted_4 == 0 ) )
               {
                  if ( RcdFound4 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate034( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable034( ) ;
                        CloseExtendedTableCursors034( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "SECFUNCTIONALITYID_" + sGXsfl_34_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtSecFunctionalityId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound4 != 0 )
                  {
                     if ( nRcdDeleted_4 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey034( ) ;
                        Load034( ) ;
                        BeforeValidate034( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls034( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_4 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate034( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable034( ) ;
                              CloseExtendedTableCursors034( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_4 == 0 )
                     {
                        GXCCtl = "SECFUNCTIONALITYID_" + sGXsfl_34_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSecFunctionalityId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSecFunctionalityId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", ""))) ;
            ChangePostValue( edtSecFunctionalityDescription_Internalname, A8SecFunctionalityDescription) ;
            ChangePostValue( "ZT_"+"Z1SecFunctionalityId_"+sGXsfl_34_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1SecFunctionalityId), 10, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_4_"+sGXsfl_34_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_4_"+sGXsfl_34_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_4), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_4_"+sGXsfl_34_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_4), 4, 0, ".", ""))) ;
            if ( nIsMod_4 != 0 )
            {
               ChangePostValue( "SECFUNCTIONALITYID_"+sGXsfl_34_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_34_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityDescription_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption030( )
      {
      }

      protected void ZM033( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -1 )
         {
            Z5SecObjectName = A5SecObjectName;
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

      protected void Load033( )
      {
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A5SecObjectName});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound3 = 1;
            ZM033( -1) ;
         }
         pr_default.close(5);
         OnLoadActions033( ) ;
      }

      protected void OnLoadActions033( )
      {
      }

      protected void CheckExtendedTable033( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors033( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey033( )
      {
         /* Using cursor T00038 */
         pr_default.execute(6, new Object[] {A5SecObjectName});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A5SecObjectName});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM033( 1) ;
            RcdFound3 = 1;
            A5SecObjectName = T00036_A5SecObjectName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SecObjectName", A5SecObjectName);
            Z5SecObjectName = A5SecObjectName;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load033( ) ;
            if ( AnyError == 1 )
            {
               RcdFound3 = 0;
               InitializeNonKey033( ) ;
            }
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey033( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey033( ) ;
         if ( RcdFound3 == 0 )
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
         RcdFound3 = 0;
         /* Using cursor T00039 */
         pr_default.execute(7, new Object[] {A5SecObjectName});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00039_A5SecObjectName[0], A5SecObjectName) < 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00039_A5SecObjectName[0], A5SecObjectName) > 0 ) ) )
            {
               A5SecObjectName = T00039_A5SecObjectName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SecObjectName", A5SecObjectName);
               RcdFound3 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0;
         /* Using cursor T000310 */
         pr_default.execute(8, new Object[] {A5SecObjectName});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000310_A5SecObjectName[0], A5SecObjectName) > 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000310_A5SecObjectName[0], A5SecObjectName) < 0 ) ) )
            {
               A5SecObjectName = T000310_A5SecObjectName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SecObjectName", A5SecObjectName);
               RcdFound3 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey033( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSecObjectName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert033( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound3 == 1 )
            {
               if ( StringUtil.StrCmp(A5SecObjectName, Z5SecObjectName) != 0 )
               {
                  A5SecObjectName = Z5SecObjectName;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SecObjectName", A5SecObjectName);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SECOBJECTNAME");
                  AnyError = 1;
                  GX_FocusControl = edtSecObjectName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSecObjectName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update033( ) ;
                  GX_FocusControl = edtSecObjectName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A5SecObjectName, Z5SecObjectName) != 0 )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtSecObjectName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert033( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SECOBJECTNAME");
                     AnyError = 1;
                     GX_FocusControl = edtSecObjectName_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtSecObjectName_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert033( ) ;
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
         if ( StringUtil.StrCmp(A5SecObjectName, Z5SecObjectName) != 0 )
         {
            A5SecObjectName = Z5SecObjectName;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SecObjectName", A5SecObjectName);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SECOBJECTNAME");
            AnyError = 1;
            GX_FocusControl = edtSecObjectName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSecObjectName_Internalname;
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "SECOBJECTNAME");
            AnyError = 1;
            GX_FocusControl = edtSecObjectName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart033( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd033( ) ;
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart033( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound3 != 0 )
            {
               ScanNext033( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd033( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00035 */
            pr_default.execute(3, new Object[] {A5SecObjectName});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecObject"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecObject"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM033( 0) ;
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000311 */
                     pr_default.execute(9, new Object[] {A5SecObjectName});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("SecObject") ;
                     if ( (pr_default.getStatus(9) == 1) )
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
                           ProcessLevel033( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption030( ) ;
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
            else
            {
               Load033( ) ;
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void Update033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [SecObject] */
                     DeferredUpdate033( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel033( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                              ResetCaption030( ) ;
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
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void DeferredUpdate033( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls033( ) ;
            AfterConfirm033( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete033( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart034( ) ;
                  while ( RcdFound4 != 0 )
                  {
                     getByPrimaryKey034( ) ;
                     Delete034( ) ;
                     ScanNext034( ) ;
                  }
                  ScanEnd034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000312 */
                     pr_default.execute(10, new Object[] {A5SecObjectName});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("SecObject") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound3 == 0 )
                           {
                              InitAll033( ) ;
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
                           ResetCaption030( ) ;
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
         }
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel033( ) ;
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls033( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel034( )
      {
         nGXsfl_34_idx = 0;
         while ( nGXsfl_34_idx < nRC_GXsfl_34 )
         {
            ReadRow034( ) ;
            if ( ( nRcdExists_4 != 0 ) || ( nIsMod_4 != 0 ) )
            {
               standaloneNotModal034( ) ;
               GetKey034( ) ;
               if ( ( nRcdExists_4 == 0 ) && ( nRcdDeleted_4 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  Insert034( ) ;
               }
               else
               {
                  if ( RcdFound4 != 0 )
                  {
                     if ( ( nRcdDeleted_4 != 0 ) && ( nRcdExists_4 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete034( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_4 != 0 ) && ( nRcdExists_4 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update034( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_4 == 0 )
                     {
                        GXCCtl = "SECFUNCTIONALITYID_" + sGXsfl_34_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSecFunctionalityId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSecFunctionalityId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", ""))) ;
            ChangePostValue( edtSecFunctionalityDescription_Internalname, A8SecFunctionalityDescription) ;
            ChangePostValue( "ZT_"+"Z1SecFunctionalityId_"+sGXsfl_34_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1SecFunctionalityId), 10, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_4_"+sGXsfl_34_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_4_"+sGXsfl_34_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_4), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_4_"+sGXsfl_34_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_4), 4, 0, ".", ""))) ;
            if ( nIsMod_4 != 0 )
            {
               ChangePostValue( "SECFUNCTIONALITYID_"+sGXsfl_34_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_34_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityDescription_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll034( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_4 = 0;
         nIsMod_4 = 0;
         nRcdDeleted_4 = 0;
      }

      protected void ProcessLevel033( )
      {
         /* Save parent mode. */
         sMode3 = Gx_mode;
         ProcessNestedLevel034( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete033( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.CommitDataStores("wwpbaseobjects.secobject",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(4);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.RollbackDataStores("wwpbaseobjects.secobject",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart033( )
      {
         /* Using cursor T000313 */
         pr_default.execute(11);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound3 = 1;
            A5SecObjectName = T000313_A5SecObjectName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SecObjectName", A5SecObjectName);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext033( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound3 = 1;
            A5SecObjectName = T000313_A5SecObjectName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SecObjectName", A5SecObjectName);
         }
      }

      protected void ScanEnd033( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm033( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert033( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate033( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete033( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete033( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate033( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes033( )
      {
         edtSecObjectName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecObjectName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecObjectName_Enabled), 5, 0)), true);
      }

      protected void ZM034( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -2 )
         {
            Z5SecObjectName = A5SecObjectName;
            Z1SecFunctionalityId = A1SecFunctionalityId;
            Z8SecFunctionalityDescription = A8SecFunctionalityDescription;
         }
      }

      protected void standaloneNotModal034( )
      {
      }

      protected void standaloneModal034( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtSecFunctionalityId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Enabled), 5, 0)), !bGXsfl_34_Refreshing);
         }
         else
         {
            edtSecFunctionalityId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Enabled), 5, 0)), !bGXsfl_34_Refreshing);
         }
      }

      protected void Load034( )
      {
         /* Using cursor T000314 */
         pr_default.execute(12, new Object[] {A5SecObjectName, A1SecFunctionalityId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound4 = 1;
            A8SecFunctionalityDescription = T000314_A8SecFunctionalityDescription[0];
            ZM034( -2) ;
         }
         pr_default.close(12);
         OnLoadActions034( ) ;
      }

      protected void OnLoadActions034( )
      {
      }

      protected void CheckExtendedTable034( )
      {
         Gx_BScreen = 1;
         standaloneModal034( ) ;
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "SECFUNCTIONALITYID_" + sGXsfl_34_idx;
            GX_msglist.addItem("不匹配'Functionality'", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSecFunctionalityId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A8SecFunctionalityDescription = T00034_A8SecFunctionalityDescription[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors034( )
      {
         pr_default.close(2);
      }

      protected void enableDisable034( )
      {
      }

      protected void gxLoad_3( long A1SecFunctionalityId )
      {
         /* Using cursor T000315 */
         pr_default.execute(13, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GXCCtl = "SECFUNCTIONALITYID_" + sGXsfl_34_idx;
            GX_msglist.addItem("不匹配'Functionality'", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSecFunctionalityId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A8SecFunctionalityDescription = T000315_A8SecFunctionalityDescription[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A8SecFunctionalityDescription)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(13) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(13);
      }

      protected void GetKey034( )
      {
         /* Using cursor T000316 */
         pr_default.execute(14, new Object[] {A5SecObjectName, A1SecFunctionalityId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(14);
      }

      protected void getByPrimaryKey034( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A5SecObjectName, A1SecFunctionalityId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM034( 2) ;
            RcdFound4 = 1;
            InitializeNonKey034( ) ;
            A1SecFunctionalityId = T00033_A1SecFunctionalityId[0];
            Z5SecObjectName = A5SecObjectName;
            Z1SecFunctionalityId = A1SecFunctionalityId;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal034( ) ;
            Load034( ) ;
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey034( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal034( ) ;
            Gx_mode = sMode4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes034( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency034( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A5SecObjectName, A1SecFunctionalityId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecObjectFunctionalities"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecObjectFunctionalities"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert034( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable034( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM034( 0) ;
            CheckOptimisticConcurrency034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000317 */
                     pr_default.execute(15, new Object[] {A5SecObjectName, A1SecFunctionalityId});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("SecObjectFunctionalities") ;
                     if ( (pr_default.getStatus(15) == 1) )
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
               Load034( ) ;
            }
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void Update034( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable034( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [SecObjectFunctionalities] */
                     DeferredUpdate034( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey034( ) ;
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
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void DeferredUpdate034( )
      {
      }

      protected void Delete034( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency034( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls034( ) ;
            AfterConfirm034( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete034( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000318 */
                  pr_default.execute(16, new Object[] {A5SecObjectName, A1SecFunctionalityId});
                  pr_default.close(16);
                  dsDefault.SmartCacheProvider.SetUpdated("SecObjectFunctionalities") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel034( ) ;
         Gx_mode = sMode4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls034( )
      {
         standaloneModal034( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000319 */
            pr_default.execute(17, new Object[] {A1SecFunctionalityId});
            A8SecFunctionalityDescription = T000319_A8SecFunctionalityDescription[0];
            pr_default.close(17);
         }
      }

      protected void EndLevel034( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart034( )
      {
         /* Scan By routine */
         /* Using cursor T000320 */
         pr_default.execute(18, new Object[] {A5SecObjectName});
         RcdFound4 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound4 = 1;
            A1SecFunctionalityId = T000320_A1SecFunctionalityId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext034( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound4 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound4 = 1;
            A1SecFunctionalityId = T000320_A1SecFunctionalityId[0];
         }
      }

      protected void ScanEnd034( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm034( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert034( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate034( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete034( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete034( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate034( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes034( )
      {
         edtSecFunctionalityId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Enabled), 5, 0)), !bGXsfl_34_Refreshing);
         edtSecFunctionalityDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityDescription_Enabled), 5, 0)), !bGXsfl_34_Refreshing);
      }

      protected void send_integrity_lvl_hashes034( )
      {
      }

      protected void send_integrity_lvl_hashes033( )
      {
      }

      protected void SubsflControlProps_344( )
      {
         edtSecFunctionalityId_Internalname = "SECFUNCTIONALITYID_"+sGXsfl_34_idx;
         edtSecFunctionalityDescription_Internalname = "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_34_idx;
      }

      protected void SubsflControlProps_fel_344( )
      {
         edtSecFunctionalityId_Internalname = "SECFUNCTIONALITYID_"+sGXsfl_34_fel_idx;
         edtSecFunctionalityDescription_Internalname = "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_34_fel_idx;
      }

      protected void AddRow034( )
      {
         nGXsfl_34_idx = (short)(nGXsfl_34_idx+1);
         sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0");
         SubsflControlProps_344( ) ;
         SendRow034( ) ;
      }

      protected void SendRow034( )
      {
         Gridsecobject_functionalitiesRow = GXWebRow.GetNew(context);
         if ( subGridsecobject_functionalities_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridsecobject_functionalities_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridsecobject_functionalities_Class, "") != 0 )
            {
               subGridsecobject_functionalities_Linesclass = subGridsecobject_functionalities_Class+"Odd";
            }
         }
         else if ( subGridsecobject_functionalities_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridsecobject_functionalities_Backstyle = 0;
            subGridsecobject_functionalities_Backcolor = subGridsecobject_functionalities_Allbackcolor;
            if ( StringUtil.StrCmp(subGridsecobject_functionalities_Class, "") != 0 )
            {
               subGridsecobject_functionalities_Linesclass = subGridsecobject_functionalities_Class+"Uniform";
            }
         }
         else if ( subGridsecobject_functionalities_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridsecobject_functionalities_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridsecobject_functionalities_Class, "") != 0 )
            {
               subGridsecobject_functionalities_Linesclass = subGridsecobject_functionalities_Class+"Odd";
            }
            subGridsecobject_functionalities_Backcolor = (int)(0x0);
         }
         else if ( subGridsecobject_functionalities_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridsecobject_functionalities_Backstyle = 1;
            if ( ((int)(((nGXsfl_34_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridsecobject_functionalities_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridsecobject_functionalities_Class, "") != 0 )
               {
                  subGridsecobject_functionalities_Linesclass = subGridsecobject_functionalities_Class+"Odd";
               }
            }
            else
            {
               subGridsecobject_functionalities_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridsecobject_functionalities_Class, "") != 0 )
               {
                  subGridsecobject_functionalities_Linesclass = subGridsecobject_functionalities_Class+"Even";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_4_" + sGXsfl_34_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_34_idx + "',34)\"";
         ROClassString = "Attribute";
         Gridsecobject_functionalitiesRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecFunctionalityId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSecFunctionalityId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)34,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridsecobject_functionalitiesRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityDescription_Internalname,(String)A8SecFunctionalityDescription,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecFunctionalityDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSecFunctionalityDescription_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)34,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         context.httpAjaxContext.ajax_sending_grid_row(Gridsecobject_functionalitiesRow);
         send_integrity_lvl_hashes034( ) ;
         GXCCtl = "Z1SecFunctionalityId_" + sGXsfl_34_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1SecFunctionalityId), 10, 0, ".", "")));
         GXCCtl = "nRcdDeleted_4_" + sGXsfl_34_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_4_" + sGXsfl_34_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_4), 4, 0, ".", "")));
         GXCCtl = "nIsMod_4_" + sGXsfl_34_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_4), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SECFUNCTIONALITYID_"+sGXsfl_34_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_34_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityDescription_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridsecobject_functionalitiesContainer.AddRow(Gridsecobject_functionalitiesRow);
      }

      protected void ReadRow034( )
      {
         nGXsfl_34_idx = (short)(nGXsfl_34_idx+1);
         sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0");
         SubsflControlProps_344( ) ;
         edtSecFunctionalityId_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECFUNCTIONALITYID_"+sGXsfl_34_idx+"Enabled"), ".", ","));
         edtSecFunctionalityDescription_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_34_idx+"Enabled"), ".", ","));
         if ( ( ( context.localUtil.CToN( cgiGet( edtSecFunctionalityId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSecFunctionalityId_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
         {
            GXCCtl = "SECFUNCTIONALITYID_" + sGXsfl_34_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSecFunctionalityId_Internalname;
            wbErr = true;
            A1SecFunctionalityId = 0;
         }
         else
         {
            A1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( edtSecFunctionalityId_Internalname), ".", ","));
         }
         A8SecFunctionalityDescription = cgiGet( edtSecFunctionalityDescription_Internalname);
         GXCCtl = "Z1SecFunctionalityId_" + sGXsfl_34_idx;
         Z1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdDeleted_4_" + sGXsfl_34_idx;
         nRcdDeleted_4 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_4_" + sGXsfl_34_idx;
         nRcdExists_4 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_4_" + sGXsfl_34_idx;
         nIsMod_4 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtSecFunctionalityId_Enabled = edtSecFunctionalityId_Enabled;
      }

      protected void ConfirmValues030( )
      {
         nGXsfl_34_idx = 0;
         sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0");
         SubsflControlProps_344( ) ;
         while ( nGXsfl_34_idx < nRC_GXsfl_34 )
         {
            nGXsfl_34_idx = (short)(nGXsfl_34_idx+1);
            sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0");
            SubsflControlProps_344( ) ;
            ChangePostValue( "Z1SecFunctionalityId_"+sGXsfl_34_idx, cgiGet( "ZT_"+"Z1SecFunctionalityId_"+sGXsfl_34_idx)) ;
            DeletePostValue( "ZT_"+"Z1SecFunctionalityId_"+sGXsfl_34_idx) ;
         }
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
         context.AddJavascriptSource("gxcfg.js", "?20202279354512", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secobject.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z5SecObjectName", Z5SecObjectName);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_34", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_34_idx), 4, 0, ".", "")));
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
         return formatLink("wwpbaseobjects.secobject.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecObject" ;
      }

      public override String GetPgmdesc( )
      {
         return "Sec Object" ;
      }

      protected void InitializeNonKey033( )
      {
      }

      protected void InitAll033( )
      {
         A5SecObjectName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5SecObjectName", A5SecObjectName);
         InitializeNonKey033( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey034( )
      {
         A8SecFunctionalityDescription = "";
      }

      protected void InitAll034( )
      {
         A1SecFunctionalityId = 0;
         InitializeNonKey034( ) ;
      }

      protected void StandaloneModalInsert034( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279354517", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secobject.js", "?20202279354518", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties4( )
      {
         edtSecFunctionalityId_Enabled = defedtSecFunctionalityId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Enabled), 5, 0)), !bGXsfl_34_Refreshing);
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         edtSecObjectName_Internalname = "SECOBJECTNAME";
         lblTitlefunctionalities_Internalname = "TITLEFUNCTIONALITIES";
         edtSecFunctionalityId_Internalname = "SECFUNCTIONALITYID";
         edtSecFunctionalityDescription_Internalname = "SECFUNCTIONALITYDESCRIPTION";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         Form.Internalname = "FORM";
         subGridsecobject_functionalities_Internalname = "GRIDSECOBJECT_FUNCTIONALITIES";
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
         Form.Caption = "Sec Object";
         edtSecFunctionalityDescription_Jsonclick = "";
         edtSecFunctionalityId_Jsonclick = "";
         subGridsecobject_functionalities_Class = "Grid";
         subGridsecobject_functionalities_Backcolorstyle = 0;
         subGridsecobject_functionalities_Allowcollapsing = 0;
         subGridsecobject_functionalities_Allowselection = 0;
         edtSecFunctionalityDescription_Enabled = 0;
         edtSecFunctionalityId_Enabled = 1;
         subGridsecobject_functionalities_Header = "";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtSecObjectName_Jsonclick = "";
         edtSecObjectName_Enabled = 1;
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

      protected void gxnrGridsecobject_functionalities_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         SubsflControlProps_344( ) ;
         while ( nGXsfl_34_idx <= nRC_GXsfl_34 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal034( ) ;
            standaloneModal034( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow034( ) ;
            nGXsfl_34_idx = (short)(nGXsfl_34_idx+1);
            sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0");
            SubsflControlProps_344( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridsecobject_functionalitiesContainer));
         /* End function gxnrGridsecobject_functionalities_newrow */
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
         if ( AnyError == 0 )
         {
            GX_FocusControl = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Secobjectname( String GX_Parm1 ,
                                       String GX_Parm2 )
      {
         Gx_mode = GX_Parm1;
         A5SecObjectName = GX_Parm2;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(Z5SecObjectName);
         isValidOutput.Add(Gridsecobject_functionalitiesContainer);
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Secfunctionalityid( long GX_Parm1 ,
                                            String GX_Parm2 )
      {
         A1SecFunctionalityId = GX_Parm1;
         A8SecFunctionalityDescription = GX_Parm2;
         /* Using cursor T000319 */
         pr_default.execute(17, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("不匹配'Functionality'", "ForeignKeyNotFound", 1, "SECFUNCTIONALITYID");
            AnyError = 1;
            GX_FocusControl = edtSecFunctionalityId_Internalname;
         }
         A8SecFunctionalityDescription = T000319_A8SecFunctionalityDescription[0];
         pr_default.close(17);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A8SecFunctionalityDescription = "";
         }
         isValidOutput.Add(A8SecFunctionalityDescription);
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
         pr_default.close(17);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z5SecObjectName = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         Gx_mode = "";
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
         A5SecObjectName = "";
         lblTitlefunctionalities_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridsecobject_functionalitiesContainer = new GXWebGrid( context);
         Gridsecobject_functionalitiesColumn = new GXWebColumn();
         A8SecFunctionalityDescription = "";
         sMode4 = "";
         sStyleString = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         T00037_A5SecObjectName = new String[] {""} ;
         T00038_A5SecObjectName = new String[] {""} ;
         T00036_A5SecObjectName = new String[] {""} ;
         sMode3 = "";
         T00039_A5SecObjectName = new String[] {""} ;
         T000310_A5SecObjectName = new String[] {""} ;
         T00035_A5SecObjectName = new String[] {""} ;
         T000313_A5SecObjectName = new String[] {""} ;
         Z8SecFunctionalityDescription = "";
         T000314_A5SecObjectName = new String[] {""} ;
         T000314_A8SecFunctionalityDescription = new String[] {""} ;
         T000314_A1SecFunctionalityId = new long[1] ;
         T00034_A8SecFunctionalityDescription = new String[] {""} ;
         T000315_A8SecFunctionalityDescription = new String[] {""} ;
         T000316_A5SecObjectName = new String[] {""} ;
         T000316_A1SecFunctionalityId = new long[1] ;
         T00033_A5SecObjectName = new String[] {""} ;
         T00033_A1SecFunctionalityId = new long[1] ;
         T00032_A5SecObjectName = new String[] {""} ;
         T00032_A1SecFunctionalityId = new long[1] ;
         T000319_A8SecFunctionalityDescription = new String[] {""} ;
         T000320_A5SecObjectName = new String[] {""} ;
         T000320_A1SecFunctionalityId = new long[1] ;
         Gridsecobject_functionalitiesRow = new GXWebRow();
         subGridsecobject_functionalities_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secobject__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secobject__default(),
            new Object[][] {
                new Object[] {
               T00032_A5SecObjectName, T00032_A1SecFunctionalityId
               }
               , new Object[] {
               T00033_A5SecObjectName, T00033_A1SecFunctionalityId
               }
               , new Object[] {
               T00034_A8SecFunctionalityDescription
               }
               , new Object[] {
               T00035_A5SecObjectName
               }
               , new Object[] {
               T00036_A5SecObjectName
               }
               , new Object[] {
               T00037_A5SecObjectName
               }
               , new Object[] {
               T00038_A5SecObjectName
               }
               , new Object[] {
               T00039_A5SecObjectName
               }
               , new Object[] {
               T000310_A5SecObjectName
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000313_A5SecObjectName
               }
               , new Object[] {
               T000314_A5SecObjectName, T000314_A8SecFunctionalityDescription, T000314_A1SecFunctionalityId
               }
               , new Object[] {
               T000315_A8SecFunctionalityDescription
               }
               , new Object[] {
               T000316_A5SecObjectName, T000316_A1SecFunctionalityId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000319_A8SecFunctionalityDescription
               }
               , new Object[] {
               T000320_A5SecObjectName, T000320_A1SecFunctionalityId
               }
            }
         );
      }

      private short nRC_GXsfl_34 ;
      private short nGXsfl_34_idx=1 ;
      private short nRcdDeleted_4 ;
      private short nRcdExists_4 ;
      private short nIsMod_4 ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridsecobject_functionalities_Backcolorstyle ;
      private short subGridsecobject_functionalities_Allowselection ;
      private short subGridsecobject_functionalities_Allowhovering ;
      private short subGridsecobject_functionalities_Allowcollapsing ;
      private short subGridsecobject_functionalities_Collapsed ;
      private short nBlankRcdCount4 ;
      private short RcdFound4 ;
      private short nBlankRcdUsr4 ;
      private short GX_JID ;
      private short RcdFound3 ;
      private short Gx_BScreen ;
      private short subGridsecobject_functionalities_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtSecObjectName_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtSecFunctionalityId_Enabled ;
      private int edtSecFunctionalityDescription_Enabled ;
      private int subGridsecobject_functionalities_Selectedindex ;
      private int subGridsecobject_functionalities_Selectioncolor ;
      private int subGridsecobject_functionalities_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridsecobject_functionalities_Backcolor ;
      private int subGridsecobject_functionalities_Allbackcolor ;
      private int defedtSecFunctionalityId_Enabled ;
      private int idxLst ;
      private long Z1SecFunctionalityId ;
      private long A1SecFunctionalityId ;
      private long GRIDSECOBJECT_FUNCTIONALITIES_nFirstRecordOnPage ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_34_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtSecObjectName_Internalname ;
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
      private String edtSecObjectName_Jsonclick ;
      private String lblTitlefunctionalities_Internalname ;
      private String lblTitlefunctionalities_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridsecobject_functionalities_Header ;
      private String sMode4 ;
      private String edtSecFunctionalityId_Internalname ;
      private String edtSecFunctionalityDescription_Internalname ;
      private String sStyleString ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sMode3 ;
      private String sGXsfl_34_fel_idx="0001" ;
      private String subGridsecobject_functionalities_Class ;
      private String subGridsecobject_functionalities_Linesclass ;
      private String ROClassString ;
      private String edtSecFunctionalityId_Jsonclick ;
      private String edtSecFunctionalityDescription_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridsecobject_functionalities_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_34_Refreshing=false ;
      private String Z5SecObjectName ;
      private String A5SecObjectName ;
      private String A8SecFunctionalityDescription ;
      private String Z8SecFunctionalityDescription ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridsecobject_functionalitiesContainer ;
      private GXWebRow Gridsecobject_functionalitiesRow ;
      private GXWebColumn Gridsecobject_functionalitiesColumn ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00037_A5SecObjectName ;
      private String[] T00038_A5SecObjectName ;
      private String[] T00036_A5SecObjectName ;
      private String[] T00039_A5SecObjectName ;
      private String[] T000310_A5SecObjectName ;
      private String[] T00035_A5SecObjectName ;
      private String[] T000313_A5SecObjectName ;
      private String[] T000314_A5SecObjectName ;
      private String[] T000314_A8SecFunctionalityDescription ;
      private long[] T000314_A1SecFunctionalityId ;
      private String[] T00034_A8SecFunctionalityDescription ;
      private String[] T000315_A8SecFunctionalityDescription ;
      private String[] T000316_A5SecObjectName ;
      private long[] T000316_A1SecFunctionalityId ;
      private String[] T00033_A5SecObjectName ;
      private long[] T00033_A1SecFunctionalityId ;
      private String[] T00032_A5SecObjectName ;
      private long[] T00032_A1SecFunctionalityId ;
      private String[] T000319_A8SecFunctionalityDescription ;
      private String[] T000320_A5SecObjectName ;
      private long[] T000320_A1SecFunctionalityId ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
   }

   public class secobject__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secobject__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[15])
       ,new UpdateCursor(def[16])
       ,new ForEachCursor(def[17])
       ,new ForEachCursor(def[18])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00037 ;
        prmT00037 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmT00038 ;
        prmT00038 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmT00036 ;
        prmT00036 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmT00039 ;
        prmT00039 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmT000310 ;
        prmT000310 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmT00035 ;
        prmT00035 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmT000311 ;
        prmT000311 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmT000312 ;
        prmT000312 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmT000313 ;
        prmT000313 = new Object[] {
        } ;
        Object[] prmT000314 ;
        prmT000314 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00034 ;
        prmT00034 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000315 ;
        prmT000315 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000316 ;
        prmT000316 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00033 ;
        prmT00033 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00032 ;
        prmT00032 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000317 ;
        prmT000317 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000318 ;
        prmT000318 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000320 ;
        prmT000320 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmT000319 ;
        prmT000319 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00032", "SELECT [SecObjectName], [SecFunctionalityId] FROM [SecObjectFunctionalities] WITH (UPDLOCK) WHERE [SecObjectName] = @SecObjectName AND [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,false )
           ,new CursorDef("T00033", "SELECT [SecObjectName], [SecFunctionalityId] FROM [SecObjectFunctionalities] WITH (NOLOCK) WHERE [SecObjectName] = @SecObjectName AND [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,false )
           ,new CursorDef("T00034", "SELECT [SecFunctionalityDescription] FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,1,0,true,false )
           ,new CursorDef("T00035", "SELECT [SecObjectName] FROM [SecObject] WITH (UPDLOCK) WHERE [SecObjectName] = @SecObjectName ",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1,0,true,false )
           ,new CursorDef("T00036", "SELECT [SecObjectName] FROM [SecObject] WITH (NOLOCK) WHERE [SecObjectName] = @SecObjectName ",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,1,0,true,false )
           ,new CursorDef("T00037", "SELECT TM1.[SecObjectName] FROM [SecObject] TM1 WITH (NOLOCK) WHERE TM1.[SecObjectName] = @SecObjectName ORDER BY TM1.[SecObjectName]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,100,0,true,false )
           ,new CursorDef("T00038", "SELECT [SecObjectName] FROM [SecObject] WITH (NOLOCK) WHERE [SecObjectName] = @SecObjectName  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00038,1,0,true,false )
           ,new CursorDef("T00039", "SELECT TOP 1 [SecObjectName] FROM [SecObject] WITH (NOLOCK) WHERE ( [SecObjectName] > @SecObjectName) ORDER BY [SecObjectName]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00039,1,0,true,true )
           ,new CursorDef("T000310", "SELECT TOP 1 [SecObjectName] FROM [SecObject] WITH (NOLOCK) WHERE ( [SecObjectName] < @SecObjectName) ORDER BY [SecObjectName] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000310,1,0,true,true )
           ,new CursorDef("T000311", "INSERT INTO [SecObject]([SecObjectName]) VALUES(@SecObjectName)", GxErrorMask.GX_NOMASK,prmT000311)
           ,new CursorDef("T000312", "DELETE FROM [SecObject]  WHERE [SecObjectName] = @SecObjectName", GxErrorMask.GX_NOMASK,prmT000312)
           ,new CursorDef("T000313", "SELECT [SecObjectName] FROM [SecObject] WITH (NOLOCK) ORDER BY [SecObjectName]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000313,100,0,true,false )
           ,new CursorDef("T000314", "SELECT T1.[SecObjectName], T2.[SecFunctionalityDescription], T1.[SecFunctionalityId] FROM ([SecObjectFunctionalities] T1 WITH (NOLOCK) INNER JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecFunctionalityId]) WHERE T1.[SecObjectName] = @SecObjectName and T1.[SecFunctionalityId] = @SecFunctionalityId ORDER BY T1.[SecObjectName], T1.[SecFunctionalityId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000314,11,0,true,false )
           ,new CursorDef("T000315", "SELECT [SecFunctionalityDescription] FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000315,1,0,true,false )
           ,new CursorDef("T000316", "SELECT [SecObjectName], [SecFunctionalityId] FROM [SecObjectFunctionalities] WITH (NOLOCK) WHERE [SecObjectName] = @SecObjectName AND [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000316,1,0,true,false )
           ,new CursorDef("T000317", "INSERT INTO [SecObjectFunctionalities]([SecObjectName], [SecFunctionalityId]) VALUES(@SecObjectName, @SecFunctionalityId)", GxErrorMask.GX_NOMASK,prmT000317)
           ,new CursorDef("T000318", "DELETE FROM [SecObjectFunctionalities]  WHERE [SecObjectName] = @SecObjectName AND [SecFunctionalityId] = @SecFunctionalityId", GxErrorMask.GX_NOMASK,prmT000318)
           ,new CursorDef("T000319", "SELECT [SecFunctionalityDescription] FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000319,1,0,true,false )
           ,new CursorDef("T000320", "SELECT [SecObjectName], [SecFunctionalityId] FROM [SecObjectFunctionalities] WITH (NOLOCK) WHERE [SecObjectName] = @SecObjectName ORDER BY [SecObjectName], [SecFunctionalityId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000320,11,0,true,false )
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
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 1 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 7 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 8 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 11 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 12 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((long[]) buf[2])[0] = rslt.getLong(3) ;
              return;
           case 13 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 14 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 17 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 18 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
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
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 10 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 12 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 14 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 15 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 16 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 17 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 18 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
     }
  }

}

}
