/*
               File: SYS_Database
        Description: SYS_Database
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:53.27
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
   public class sys_database : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "SYS_Database", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtDatabaseID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public sys_database( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_database( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "SYS_Database", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_SYS_Database.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_SYS_Database.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDatabaseID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDatabaseID_Internalname, "Database ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDatabaseID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A365DatabaseID), 9, 0, ".", "")), ((edtDatabaseID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A365DatabaseID), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A365DatabaseID), "ZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDatabaseID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDatabaseID_Enabled, 0, "number", "1", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDatabaseName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDatabaseName_Internalname, "Database Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDatabaseName_Internalname, A380DatabaseName, StringUtil.RTrim( context.localUtil.Format( A380DatabaseName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDatabaseName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDatabaseName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtConnectionString_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtConnectionString_Internalname, "Connection String", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtConnectionString_Internalname, A381ConnectionString, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, 1, edtConnectionString_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_DatabaseCreator_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_DatabaseCreator_Internalname, "Creator", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_DatabaseCreator_Internalname, A382SYS_DatabaseCreator, StringUtil.RTrim( context.localUtil.Format( A382SYS_DatabaseCreator, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_DatabaseCreator_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_DatabaseCreator_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_DatabaseCreateTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_DatabaseCreateTime_Internalname, "Create Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtSYS_DatabaseCreateTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtSYS_DatabaseCreateTime_Internalname, context.localUtil.TToC( A383SYS_DatabaseCreateTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A383SYS_DatabaseCreateTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_DatabaseCreateTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_DatabaseCreateTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Database.htm");
            GxWebStd.gx_bitmap( context, edtSYS_DatabaseCreateTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtSYS_DatabaseCreateTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_SYS_Database.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_DatabaseModifier_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_DatabaseModifier_Internalname, "Modifier", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_DatabaseModifier_Internalname, A384SYS_DatabaseModifier, StringUtil.RTrim( context.localUtil.Format( A384SYS_DatabaseModifier, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_DatabaseModifier_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_DatabaseModifier_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_DatabaseModifyTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_DatabaseModifyTime_Internalname, "Modify Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtSYS_DatabaseModifyTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtSYS_DatabaseModifyTime_Internalname, context.localUtil.TToC( A385SYS_DatabaseModifyTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A385SYS_DatabaseModifyTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_DatabaseModifyTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_DatabaseModifyTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Database.htm");
            GxWebStd.gx_bitmap( context, edtSYS_DatabaseModifyTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtSYS_DatabaseModifyTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_SYS_Database.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Database.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Database.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtDatabaseID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDatabaseID_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DATABASEID");
                  AnyError = 1;
                  GX_FocusControl = edtDatabaseID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A365DatabaseID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
               }
               else
               {
                  A365DatabaseID = (int)(context.localUtil.CToN( cgiGet( edtDatabaseID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
               }
               A380DatabaseName = cgiGet( edtDatabaseName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A380DatabaseName", A380DatabaseName);
               A381ConnectionString = cgiGet( edtConnectionString_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A381ConnectionString", A381ConnectionString);
               A382SYS_DatabaseCreator = cgiGet( edtSYS_DatabaseCreator_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A382SYS_DatabaseCreator", A382SYS_DatabaseCreator);
               if ( context.localUtil.VCDateTime( cgiGet( edtSYS_DatabaseCreateTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"SYS_Database Create Time"}), 1, "SYS_DATABASECREATETIME");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_DatabaseCreateTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A383SYS_DatabaseCreateTime = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A383SYS_DatabaseCreateTime", context.localUtil.TToC( A383SYS_DatabaseCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A383SYS_DatabaseCreateTime = context.localUtil.CToT( cgiGet( edtSYS_DatabaseCreateTime_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A383SYS_DatabaseCreateTime", context.localUtil.TToC( A383SYS_DatabaseCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               A384SYS_DatabaseModifier = cgiGet( edtSYS_DatabaseModifier_Internalname);
               n384SYS_DatabaseModifier = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A384SYS_DatabaseModifier", A384SYS_DatabaseModifier);
               n384SYS_DatabaseModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A384SYS_DatabaseModifier)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtSYS_DatabaseModifyTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"SYS_Database Modify Time"}), 1, "SYS_DATABASEMODIFYTIME");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_DatabaseModifyTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A385SYS_DatabaseModifyTime = (DateTime)(DateTime.MinValue);
                  n385SYS_DatabaseModifyTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A385SYS_DatabaseModifyTime", context.localUtil.TToC( A385SYS_DatabaseModifyTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A385SYS_DatabaseModifyTime = context.localUtil.CToT( cgiGet( edtSYS_DatabaseModifyTime_Internalname));
                  n385SYS_DatabaseModifyTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A385SYS_DatabaseModifyTime", context.localUtil.TToC( A385SYS_DatabaseModifyTime, 10, 8, 0, 0, "/", ":", " "));
               }
               n385SYS_DatabaseModifyTime = ((DateTime.MinValue==A385SYS_DatabaseModifyTime) ? true : false);
               /* Read saved values. */
               Z365DatabaseID = (int)(context.localUtil.CToN( cgiGet( "Z365DatabaseID"), ".", ","));
               Z380DatabaseName = cgiGet( "Z380DatabaseName");
               Z381ConnectionString = cgiGet( "Z381ConnectionString");
               Z382SYS_DatabaseCreator = cgiGet( "Z382SYS_DatabaseCreator");
               Z383SYS_DatabaseCreateTime = context.localUtil.CToT( cgiGet( "Z383SYS_DatabaseCreateTime"), 0);
               Z384SYS_DatabaseModifier = cgiGet( "Z384SYS_DatabaseModifier");
               n384SYS_DatabaseModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A384SYS_DatabaseModifier)) ? true : false);
               Z385SYS_DatabaseModifyTime = context.localUtil.CToT( cgiGet( "Z385SYS_DatabaseModifyTime"), 0);
               n385SYS_DatabaseModifyTime = ((DateTime.MinValue==A385SYS_DatabaseModifyTime) ? true : false);
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
                  A365DatabaseID = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
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
               InitAll1B48( ) ;
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
         DisableAttributes1B48( ) ;
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

      protected void ResetCaption1B0( )
      {
      }

      protected void ZM1B48( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z380DatabaseName = T001B3_A380DatabaseName[0];
               Z381ConnectionString = T001B3_A381ConnectionString[0];
               Z382SYS_DatabaseCreator = T001B3_A382SYS_DatabaseCreator[0];
               Z383SYS_DatabaseCreateTime = T001B3_A383SYS_DatabaseCreateTime[0];
               Z384SYS_DatabaseModifier = T001B3_A384SYS_DatabaseModifier[0];
               Z385SYS_DatabaseModifyTime = T001B3_A385SYS_DatabaseModifyTime[0];
            }
            else
            {
               Z380DatabaseName = A380DatabaseName;
               Z381ConnectionString = A381ConnectionString;
               Z382SYS_DatabaseCreator = A382SYS_DatabaseCreator;
               Z383SYS_DatabaseCreateTime = A383SYS_DatabaseCreateTime;
               Z384SYS_DatabaseModifier = A384SYS_DatabaseModifier;
               Z385SYS_DatabaseModifyTime = A385SYS_DatabaseModifyTime;
            }
         }
         if ( GX_JID == -3 )
         {
            Z365DatabaseID = A365DatabaseID;
            Z380DatabaseName = A380DatabaseName;
            Z381ConnectionString = A381ConnectionString;
            Z382SYS_DatabaseCreator = A382SYS_DatabaseCreator;
            Z383SYS_DatabaseCreateTime = A383SYS_DatabaseCreateTime;
            Z384SYS_DatabaseModifier = A384SYS_DatabaseModifier;
            Z385SYS_DatabaseModifyTime = A385SYS_DatabaseModifyTime;
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

      protected void Load1B48( )
      {
         /* Using cursor T001B4 */
         pr_datastore1.execute(2, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound48 = 1;
            A380DatabaseName = T001B4_A380DatabaseName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A380DatabaseName", A380DatabaseName);
            A381ConnectionString = T001B4_A381ConnectionString[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A381ConnectionString", A381ConnectionString);
            A382SYS_DatabaseCreator = T001B4_A382SYS_DatabaseCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A382SYS_DatabaseCreator", A382SYS_DatabaseCreator);
            A383SYS_DatabaseCreateTime = T001B4_A383SYS_DatabaseCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A383SYS_DatabaseCreateTime", context.localUtil.TToC( A383SYS_DatabaseCreateTime, 10, 8, 0, 0, "/", ":", " "));
            A384SYS_DatabaseModifier = T001B4_A384SYS_DatabaseModifier[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A384SYS_DatabaseModifier", A384SYS_DatabaseModifier);
            n384SYS_DatabaseModifier = T001B4_n384SYS_DatabaseModifier[0];
            A385SYS_DatabaseModifyTime = T001B4_A385SYS_DatabaseModifyTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A385SYS_DatabaseModifyTime", context.localUtil.TToC( A385SYS_DatabaseModifyTime, 10, 8, 0, 0, "/", ":", " "));
            n385SYS_DatabaseModifyTime = T001B4_n385SYS_DatabaseModifyTime[0];
            ZM1B48( -3) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1B48( ) ;
      }

      protected void OnLoadActions1B48( )
      {
      }

      protected void CheckExtendedTable1B48( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A383SYS_DatabaseCreateTime) || ( A383SYS_DatabaseCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_Database Create Time超界", "OutOfRange", 1, "SYS_DATABASECREATETIME");
            AnyError = 1;
            GX_FocusControl = edtSYS_DatabaseCreateTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A385SYS_DatabaseModifyTime) || ( A385SYS_DatabaseModifyTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_Database Modify Time超界", "OutOfRange", 1, "SYS_DATABASEMODIFYTIME");
            AnyError = 1;
            GX_FocusControl = edtSYS_DatabaseModifyTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1B48( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1B48( )
      {
         /* Using cursor T001B5 */
         pr_datastore1.execute(3, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound48 = 1;
         }
         else
         {
            RcdFound48 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001B3 */
         pr_datastore1.execute(1, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1B48( 3) ;
            RcdFound48 = 1;
            A365DatabaseID = T001B3_A365DatabaseID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
            A380DatabaseName = T001B3_A380DatabaseName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A380DatabaseName", A380DatabaseName);
            A381ConnectionString = T001B3_A381ConnectionString[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A381ConnectionString", A381ConnectionString);
            A382SYS_DatabaseCreator = T001B3_A382SYS_DatabaseCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A382SYS_DatabaseCreator", A382SYS_DatabaseCreator);
            A383SYS_DatabaseCreateTime = T001B3_A383SYS_DatabaseCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A383SYS_DatabaseCreateTime", context.localUtil.TToC( A383SYS_DatabaseCreateTime, 10, 8, 0, 0, "/", ":", " "));
            A384SYS_DatabaseModifier = T001B3_A384SYS_DatabaseModifier[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A384SYS_DatabaseModifier", A384SYS_DatabaseModifier);
            n384SYS_DatabaseModifier = T001B3_n384SYS_DatabaseModifier[0];
            A385SYS_DatabaseModifyTime = T001B3_A385SYS_DatabaseModifyTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A385SYS_DatabaseModifyTime", context.localUtil.TToC( A385SYS_DatabaseModifyTime, 10, 8, 0, 0, "/", ":", " "));
            n385SYS_DatabaseModifyTime = T001B3_n385SYS_DatabaseModifyTime[0];
            Z365DatabaseID = A365DatabaseID;
            sMode48 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1B48( ) ;
            if ( AnyError == 1 )
            {
               RcdFound48 = 0;
               InitializeNonKey1B48( ) ;
            }
            Gx_mode = sMode48;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound48 = 0;
            InitializeNonKey1B48( ) ;
            sMode48 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode48;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1B48( ) ;
         if ( RcdFound48 == 0 )
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
         RcdFound48 = 0;
         /* Using cursor T001B6 */
         pr_datastore1.execute(4, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            while ( (pr_datastore1.getStatus(4) != 101) && ( ( T001B6_A365DatabaseID[0] < A365DatabaseID ) ) )
            {
               pr_datastore1.readNext(4);
            }
            if ( (pr_datastore1.getStatus(4) != 101) && ( ( T001B6_A365DatabaseID[0] > A365DatabaseID ) ) )
            {
               A365DatabaseID = T001B6_A365DatabaseID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
               RcdFound48 = 1;
            }
         }
         pr_datastore1.close(4);
      }

      protected void move_previous( )
      {
         RcdFound48 = 0;
         /* Using cursor T001B7 */
         pr_datastore1.execute(5, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            while ( (pr_datastore1.getStatus(5) != 101) && ( ( T001B7_A365DatabaseID[0] > A365DatabaseID ) ) )
            {
               pr_datastore1.readNext(5);
            }
            if ( (pr_datastore1.getStatus(5) != 101) && ( ( T001B7_A365DatabaseID[0] < A365DatabaseID ) ) )
            {
               A365DatabaseID = T001B7_A365DatabaseID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
               RcdFound48 = 1;
            }
         }
         pr_datastore1.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1B48( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtDatabaseID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1B48( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound48 == 1 )
            {
               if ( A365DatabaseID != Z365DatabaseID )
               {
                  A365DatabaseID = Z365DatabaseID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "DATABASEID");
                  AnyError = 1;
                  GX_FocusControl = edtDatabaseID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtDatabaseID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1B48( ) ;
                  GX_FocusControl = edtDatabaseID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A365DatabaseID != Z365DatabaseID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtDatabaseID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1B48( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "DATABASEID");
                     AnyError = 1;
                     GX_FocusControl = edtDatabaseID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtDatabaseID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1B48( ) ;
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
         if ( A365DatabaseID != Z365DatabaseID )
         {
            A365DatabaseID = Z365DatabaseID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "DATABASEID");
            AnyError = 1;
            GX_FocusControl = edtDatabaseID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtDatabaseID_Internalname;
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
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "DATABASEID");
            AnyError = 1;
            GX_FocusControl = edtDatabaseID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtDatabaseName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1B48( ) ;
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDatabaseName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1B48( ) ;
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
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDatabaseName_Internalname;
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
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDatabaseName_Internalname;
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
         ScanStart1B48( ) ;
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound48 != 0 )
            {
               ScanNext1B48( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDatabaseName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1B48( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1B48( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001B2 */
            pr_datastore1.execute(0, new Object[] {A365DatabaseID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_DATABASE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z380DatabaseName, T001B2_A380DatabaseName[0]) != 0 ) || ( StringUtil.StrCmp(Z381ConnectionString, T001B2_A381ConnectionString[0]) != 0 ) || ( StringUtil.StrCmp(Z382SYS_DatabaseCreator, T001B2_A382SYS_DatabaseCreator[0]) != 0 ) || ( Z383SYS_DatabaseCreateTime != T001B2_A383SYS_DatabaseCreateTime[0] ) || ( StringUtil.StrCmp(Z384SYS_DatabaseModifier, T001B2_A384SYS_DatabaseModifier[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z385SYS_DatabaseModifyTime != T001B2_A385SYS_DatabaseModifyTime[0] ) )
            {
               if ( StringUtil.StrCmp(Z380DatabaseName, T001B2_A380DatabaseName[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_database:[seudo value changed for attri]"+"DatabaseName");
                  GXUtil.WriteLogRaw("Old: ",Z380DatabaseName);
                  GXUtil.WriteLogRaw("Current: ",T001B2_A380DatabaseName[0]);
               }
               if ( StringUtil.StrCmp(Z381ConnectionString, T001B2_A381ConnectionString[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_database:[seudo value changed for attri]"+"ConnectionString");
                  GXUtil.WriteLogRaw("Old: ",Z381ConnectionString);
                  GXUtil.WriteLogRaw("Current: ",T001B2_A381ConnectionString[0]);
               }
               if ( StringUtil.StrCmp(Z382SYS_DatabaseCreator, T001B2_A382SYS_DatabaseCreator[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_database:[seudo value changed for attri]"+"SYS_DatabaseCreator");
                  GXUtil.WriteLogRaw("Old: ",Z382SYS_DatabaseCreator);
                  GXUtil.WriteLogRaw("Current: ",T001B2_A382SYS_DatabaseCreator[0]);
               }
               if ( Z383SYS_DatabaseCreateTime != T001B2_A383SYS_DatabaseCreateTime[0] )
               {
                  GXUtil.WriteLog("sys_database:[seudo value changed for attri]"+"SYS_DatabaseCreateTime");
                  GXUtil.WriteLogRaw("Old: ",Z383SYS_DatabaseCreateTime);
                  GXUtil.WriteLogRaw("Current: ",T001B2_A383SYS_DatabaseCreateTime[0]);
               }
               if ( StringUtil.StrCmp(Z384SYS_DatabaseModifier, T001B2_A384SYS_DatabaseModifier[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_database:[seudo value changed for attri]"+"SYS_DatabaseModifier");
                  GXUtil.WriteLogRaw("Old: ",Z384SYS_DatabaseModifier);
                  GXUtil.WriteLogRaw("Current: ",T001B2_A384SYS_DatabaseModifier[0]);
               }
               if ( Z385SYS_DatabaseModifyTime != T001B2_A385SYS_DatabaseModifyTime[0] )
               {
                  GXUtil.WriteLog("sys_database:[seudo value changed for attri]"+"SYS_DatabaseModifyTime");
                  GXUtil.WriteLogRaw("Old: ",Z385SYS_DatabaseModifyTime);
                  GXUtil.WriteLogRaw("Current: ",T001B2_A385SYS_DatabaseModifyTime[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_DATABASE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1B48( )
      {
         BeforeValidate1B48( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1B48( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1B48( 0) ;
            CheckOptimisticConcurrency1B48( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1B48( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1B48( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001B8 */
                     pr_datastore1.execute(6, new Object[] {A365DatabaseID, A380DatabaseName, A381ConnectionString, A382SYS_DatabaseCreator, A383SYS_DatabaseCreateTime, n384SYS_DatabaseModifier, A384SYS_DatabaseModifier, n385SYS_DatabaseModifyTime, A385SYS_DatabaseModifyTime});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_DATABASE") ;
                     if ( (pr_datastore1.getStatus(6) == 1) )
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
                           ResetCaption1B0( ) ;
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
               Load1B48( ) ;
            }
            EndLevel1B48( ) ;
         }
         CloseExtendedTableCursors1B48( ) ;
      }

      protected void Update1B48( )
      {
         BeforeValidate1B48( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1B48( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1B48( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1B48( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1B48( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001B9 */
                     pr_datastore1.execute(7, new Object[] {A380DatabaseName, A381ConnectionString, A382SYS_DatabaseCreator, A383SYS_DatabaseCreateTime, n384SYS_DatabaseModifier, A384SYS_DatabaseModifier, n385SYS_DatabaseModifyTime, A385SYS_DatabaseModifyTime, A365DatabaseID});
                     pr_datastore1.close(7);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_DATABASE") ;
                     if ( (pr_datastore1.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_DATABASE"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1B48( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1B0( ) ;
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
            EndLevel1B48( ) ;
         }
         CloseExtendedTableCursors1B48( ) ;
      }

      protected void DeferredUpdate1B48( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1B48( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1B48( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1B48( ) ;
            AfterConfirm1B48( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1B48( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001B10 */
                  pr_datastore1.execute(8, new Object[] {A365DatabaseID});
                  pr_datastore1.close(8);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_DATABASE") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound48 == 0 )
                        {
                           InitAll1B48( ) ;
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
                        ResetCaption1B0( ) ;
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
         sMode48 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1B48( ) ;
         Gx_mode = sMode48;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1B48( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001B11 */
            pr_datastore1.execute(9, new Object[] {A365DatabaseID});
            if ( (pr_datastore1.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"BAS_Tenant"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(9);
         }
      }

      protected void EndLevel1B48( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1B48( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("sys_database",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1B0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("sys_database",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1B48( )
      {
         /* Using cursor T001B12 */
         pr_datastore1.execute(10);
         RcdFound48 = 0;
         if ( (pr_datastore1.getStatus(10) != 101) )
         {
            RcdFound48 = 1;
            A365DatabaseID = T001B12_A365DatabaseID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1B48( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(10);
         RcdFound48 = 0;
         if ( (pr_datastore1.getStatus(10) != 101) )
         {
            RcdFound48 = 1;
            A365DatabaseID = T001B12_A365DatabaseID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
         }
      }

      protected void ScanEnd1B48( )
      {
         pr_datastore1.close(10);
      }

      protected void AfterConfirm1B48( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1B48( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1B48( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1B48( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1B48( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1B48( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1B48( )
      {
         edtDatabaseID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDatabaseID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDatabaseID_Enabled), 5, 0)), true);
         edtDatabaseName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDatabaseName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDatabaseName_Enabled), 5, 0)), true);
         edtConnectionString_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConnectionString_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConnectionString_Enabled), 5, 0)), true);
         edtSYS_DatabaseCreator_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_DatabaseCreator_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_DatabaseCreator_Enabled), 5, 0)), true);
         edtSYS_DatabaseCreateTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_DatabaseCreateTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_DatabaseCreateTime_Enabled), 5, 0)), true);
         edtSYS_DatabaseModifier_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_DatabaseModifier_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_DatabaseModifier_Enabled), 5, 0)), true);
         edtSYS_DatabaseModifyTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_DatabaseModifyTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_DatabaseModifyTime_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1B48( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1B0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279385426", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_database.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z365DatabaseID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z365DatabaseID), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z380DatabaseName", Z380DatabaseName);
         GxWebStd.gx_hidden_field( context, "Z381ConnectionString", Z381ConnectionString);
         GxWebStd.gx_hidden_field( context, "Z382SYS_DatabaseCreator", Z382SYS_DatabaseCreator);
         GxWebStd.gx_hidden_field( context, "Z383SYS_DatabaseCreateTime", context.localUtil.TToC( Z383SYS_DatabaseCreateTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z384SYS_DatabaseModifier", Z384SYS_DatabaseModifier);
         GxWebStd.gx_hidden_field( context, "Z385SYS_DatabaseModifyTime", context.localUtil.TToC( Z385SYS_DatabaseModifyTime, 10, 8, 0, 0, "/", ":", " "));
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
         return formatLink("sys_database.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SYS_Database" ;
      }

      public override String GetPgmdesc( )
      {
         return "SYS_Database" ;
      }

      protected void InitializeNonKey1B48( )
      {
         A380DatabaseName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A380DatabaseName", A380DatabaseName);
         A381ConnectionString = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A381ConnectionString", A381ConnectionString);
         A382SYS_DatabaseCreator = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A382SYS_DatabaseCreator", A382SYS_DatabaseCreator);
         A383SYS_DatabaseCreateTime = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A383SYS_DatabaseCreateTime", context.localUtil.TToC( A383SYS_DatabaseCreateTime, 10, 8, 0, 0, "/", ":", " "));
         A384SYS_DatabaseModifier = "";
         n384SYS_DatabaseModifier = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A384SYS_DatabaseModifier", A384SYS_DatabaseModifier);
         n384SYS_DatabaseModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A384SYS_DatabaseModifier)) ? true : false);
         A385SYS_DatabaseModifyTime = (DateTime)(DateTime.MinValue);
         n385SYS_DatabaseModifyTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A385SYS_DatabaseModifyTime", context.localUtil.TToC( A385SYS_DatabaseModifyTime, 10, 8, 0, 0, "/", ":", " "));
         n385SYS_DatabaseModifyTime = ((DateTime.MinValue==A385SYS_DatabaseModifyTime) ? true : false);
         Z380DatabaseName = "";
         Z381ConnectionString = "";
         Z382SYS_DatabaseCreator = "";
         Z383SYS_DatabaseCreateTime = (DateTime)(DateTime.MinValue);
         Z384SYS_DatabaseModifier = "";
         Z385SYS_DatabaseModifyTime = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll1B48( )
      {
         A365DatabaseID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
         InitializeNonKey1B48( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279385433", true);
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
         context.AddJavascriptSource("sys_database.js", "?20202279385433", false);
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
         edtDatabaseID_Internalname = "DATABASEID";
         edtDatabaseName_Internalname = "DATABASENAME";
         edtConnectionString_Internalname = "CONNECTIONSTRING";
         edtSYS_DatabaseCreator_Internalname = "SYS_DATABASECREATOR";
         edtSYS_DatabaseCreateTime_Internalname = "SYS_DATABASECREATETIME";
         edtSYS_DatabaseModifier_Internalname = "SYS_DATABASEMODIFIER";
         edtSYS_DatabaseModifyTime_Internalname = "SYS_DATABASEMODIFYTIME";
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
         Form.Caption = "SYS_Database";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtSYS_DatabaseModifyTime_Jsonclick = "";
         edtSYS_DatabaseModifyTime_Enabled = 1;
         edtSYS_DatabaseModifier_Jsonclick = "";
         edtSYS_DatabaseModifier_Enabled = 1;
         edtSYS_DatabaseCreateTime_Jsonclick = "";
         edtSYS_DatabaseCreateTime_Enabled = 1;
         edtSYS_DatabaseCreator_Jsonclick = "";
         edtSYS_DatabaseCreator_Enabled = 1;
         edtConnectionString_Enabled = 1;
         edtDatabaseName_Jsonclick = "";
         edtDatabaseName_Enabled = 1;
         edtDatabaseID_Jsonclick = "";
         edtDatabaseID_Enabled = 1;
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
         GX_FocusControl = edtDatabaseName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Databaseid( int GX_Parm1 ,
                                    String GX_Parm2 ,
                                    String GX_Parm3 ,
                                    String GX_Parm4 ,
                                    DateTime GX_Parm5 ,
                                    String GX_Parm6 ,
                                    DateTime GX_Parm7 )
      {
         A365DatabaseID = GX_Parm1;
         A380DatabaseName = GX_Parm2;
         A381ConnectionString = GX_Parm3;
         A382SYS_DatabaseCreator = GX_Parm4;
         A383SYS_DatabaseCreateTime = GX_Parm5;
         A384SYS_DatabaseModifier = GX_Parm6;
         n384SYS_DatabaseModifier = false;
         A385SYS_DatabaseModifyTime = GX_Parm7;
         n385SYS_DatabaseModifyTime = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A380DatabaseName);
         isValidOutput.Add(A381ConnectionString);
         isValidOutput.Add(A382SYS_DatabaseCreator);
         isValidOutput.Add(context.localUtil.TToC( A383SYS_DatabaseCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(A384SYS_DatabaseModifier);
         isValidOutput.Add(context.localUtil.TToC( A385SYS_DatabaseModifyTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z365DatabaseID), 9, 0, ".", "")));
         isValidOutput.Add(Z380DatabaseName);
         isValidOutput.Add(Z381ConnectionString);
         isValidOutput.Add(Z382SYS_DatabaseCreator);
         isValidOutput.Add(context.localUtil.TToC( Z383SYS_DatabaseCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(Z384SYS_DatabaseModifier);
         isValidOutput.Add(context.localUtil.TToC( Z385SYS_DatabaseModifyTime, 10, 8, 0, 0, "/", ":", " "));
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
         pr_datastore1.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z380DatabaseName = "";
         Z381ConnectionString = "";
         Z382SYS_DatabaseCreator = "";
         Z383SYS_DatabaseCreateTime = (DateTime)(DateTime.MinValue);
         Z384SYS_DatabaseModifier = "";
         Z385SYS_DatabaseModifyTime = (DateTime)(DateTime.MinValue);
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
         A380DatabaseName = "";
         A381ConnectionString = "";
         A382SYS_DatabaseCreator = "";
         A383SYS_DatabaseCreateTime = (DateTime)(DateTime.MinValue);
         A384SYS_DatabaseModifier = "";
         A385SYS_DatabaseModifyTime = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T001B4_A365DatabaseID = new int[1] ;
         T001B4_A380DatabaseName = new String[] {""} ;
         T001B4_A381ConnectionString = new String[] {""} ;
         T001B4_A382SYS_DatabaseCreator = new String[] {""} ;
         T001B4_A383SYS_DatabaseCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001B4_A384SYS_DatabaseModifier = new String[] {""} ;
         T001B4_n384SYS_DatabaseModifier = new bool[] {false} ;
         T001B4_A385SYS_DatabaseModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001B4_n385SYS_DatabaseModifyTime = new bool[] {false} ;
         T001B5_A365DatabaseID = new int[1] ;
         T001B3_A365DatabaseID = new int[1] ;
         T001B3_A380DatabaseName = new String[] {""} ;
         T001B3_A381ConnectionString = new String[] {""} ;
         T001B3_A382SYS_DatabaseCreator = new String[] {""} ;
         T001B3_A383SYS_DatabaseCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001B3_A384SYS_DatabaseModifier = new String[] {""} ;
         T001B3_n384SYS_DatabaseModifier = new bool[] {false} ;
         T001B3_A385SYS_DatabaseModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001B3_n385SYS_DatabaseModifyTime = new bool[] {false} ;
         sMode48 = "";
         T001B6_A365DatabaseID = new int[1] ;
         T001B7_A365DatabaseID = new int[1] ;
         T001B2_A365DatabaseID = new int[1] ;
         T001B2_A380DatabaseName = new String[] {""} ;
         T001B2_A381ConnectionString = new String[] {""} ;
         T001B2_A382SYS_DatabaseCreator = new String[] {""} ;
         T001B2_A383SYS_DatabaseCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001B2_A384SYS_DatabaseModifier = new String[] {""} ;
         T001B2_n384SYS_DatabaseModifier = new bool[] {false} ;
         T001B2_A385SYS_DatabaseModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001B2_n385SYS_DatabaseModifyTime = new bool[] {false} ;
         T001B11_A360BAS_TenantTenantCode = new String[] {""} ;
         T001B12_A365DatabaseID = new int[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_database__datastore1(),
            new Object[][] {
                new Object[] {
               T001B2_A365DatabaseID, T001B2_A380DatabaseName, T001B2_A381ConnectionString, T001B2_A382SYS_DatabaseCreator, T001B2_A383SYS_DatabaseCreateTime, T001B2_A384SYS_DatabaseModifier, T001B2_n384SYS_DatabaseModifier, T001B2_A385SYS_DatabaseModifyTime, T001B2_n385SYS_DatabaseModifyTime
               }
               , new Object[] {
               T001B3_A365DatabaseID, T001B3_A380DatabaseName, T001B3_A381ConnectionString, T001B3_A382SYS_DatabaseCreator, T001B3_A383SYS_DatabaseCreateTime, T001B3_A384SYS_DatabaseModifier, T001B3_n384SYS_DatabaseModifier, T001B3_A385SYS_DatabaseModifyTime, T001B3_n385SYS_DatabaseModifyTime
               }
               , new Object[] {
               T001B4_A365DatabaseID, T001B4_A380DatabaseName, T001B4_A381ConnectionString, T001B4_A382SYS_DatabaseCreator, T001B4_A383SYS_DatabaseCreateTime, T001B4_A384SYS_DatabaseModifier, T001B4_n384SYS_DatabaseModifier, T001B4_A385SYS_DatabaseModifyTime, T001B4_n385SYS_DatabaseModifyTime
               }
               , new Object[] {
               T001B5_A365DatabaseID
               }
               , new Object[] {
               T001B6_A365DatabaseID
               }
               , new Object[] {
               T001B7_A365DatabaseID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001B11_A360BAS_TenantTenantCode
               }
               , new Object[] {
               T001B12_A365DatabaseID
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_database__default(),
            new Object[][] {
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
      private short RcdFound48 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z365DatabaseID ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int A365DatabaseID ;
      private int edtDatabaseID_Enabled ;
      private int edtDatabaseName_Enabled ;
      private int edtConnectionString_Enabled ;
      private int edtSYS_DatabaseCreator_Enabled ;
      private int edtSYS_DatabaseCreateTime_Enabled ;
      private int edtSYS_DatabaseModifier_Enabled ;
      private int edtSYS_DatabaseModifyTime_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtDatabaseID_Internalname ;
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
      private String edtDatabaseID_Jsonclick ;
      private String edtDatabaseName_Internalname ;
      private String edtDatabaseName_Jsonclick ;
      private String edtConnectionString_Internalname ;
      private String edtSYS_DatabaseCreator_Internalname ;
      private String edtSYS_DatabaseCreator_Jsonclick ;
      private String edtSYS_DatabaseCreateTime_Internalname ;
      private String edtSYS_DatabaseCreateTime_Jsonclick ;
      private String edtSYS_DatabaseModifier_Internalname ;
      private String edtSYS_DatabaseModifier_Jsonclick ;
      private String edtSYS_DatabaseModifyTime_Internalname ;
      private String edtSYS_DatabaseModifyTime_Jsonclick ;
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
      private String sMode48 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z383SYS_DatabaseCreateTime ;
      private DateTime Z385SYS_DatabaseModifyTime ;
      private DateTime A383SYS_DatabaseCreateTime ;
      private DateTime A385SYS_DatabaseModifyTime ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n384SYS_DatabaseModifier ;
      private bool n385SYS_DatabaseModifyTime ;
      private bool Gx_longc ;
      private String Z380DatabaseName ;
      private String Z381ConnectionString ;
      private String Z382SYS_DatabaseCreator ;
      private String Z384SYS_DatabaseModifier ;
      private String A380DatabaseName ;
      private String A381ConnectionString ;
      private String A382SYS_DatabaseCreator ;
      private String A384SYS_DatabaseModifier ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private int[] T001B4_A365DatabaseID ;
      private String[] T001B4_A380DatabaseName ;
      private String[] T001B4_A381ConnectionString ;
      private String[] T001B4_A382SYS_DatabaseCreator ;
      private DateTime[] T001B4_A383SYS_DatabaseCreateTime ;
      private String[] T001B4_A384SYS_DatabaseModifier ;
      private bool[] T001B4_n384SYS_DatabaseModifier ;
      private DateTime[] T001B4_A385SYS_DatabaseModifyTime ;
      private bool[] T001B4_n385SYS_DatabaseModifyTime ;
      private int[] T001B5_A365DatabaseID ;
      private int[] T001B3_A365DatabaseID ;
      private String[] T001B3_A380DatabaseName ;
      private String[] T001B3_A381ConnectionString ;
      private String[] T001B3_A382SYS_DatabaseCreator ;
      private DateTime[] T001B3_A383SYS_DatabaseCreateTime ;
      private String[] T001B3_A384SYS_DatabaseModifier ;
      private bool[] T001B3_n384SYS_DatabaseModifier ;
      private DateTime[] T001B3_A385SYS_DatabaseModifyTime ;
      private bool[] T001B3_n385SYS_DatabaseModifyTime ;
      private int[] T001B6_A365DatabaseID ;
      private int[] T001B7_A365DatabaseID ;
      private int[] T001B2_A365DatabaseID ;
      private String[] T001B2_A380DatabaseName ;
      private String[] T001B2_A381ConnectionString ;
      private String[] T001B2_A382SYS_DatabaseCreator ;
      private DateTime[] T001B2_A383SYS_DatabaseCreateTime ;
      private String[] T001B2_A384SYS_DatabaseModifier ;
      private bool[] T001B2_n384SYS_DatabaseModifier ;
      private DateTime[] T001B2_A385SYS_DatabaseModifyTime ;
      private bool[] T001B2_n385SYS_DatabaseModifyTime ;
      private String[] T001B11_A360BAS_TenantTenantCode ;
      private IDataStoreProvider pr_default ;
      private int[] T001B12_A365DatabaseID ;
      private GXWebForm Form ;
   }

   public class sys_database__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001B4 ;
          prmT001B4 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001B5 ;
          prmT001B5 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001B3 ;
          prmT001B3 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001B6 ;
          prmT001B6 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001B7 ;
          prmT001B7 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001B2 ;
          prmT001B2 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001B8 ;
          prmT001B8 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0} ,
          new Object[] {"@DatabaseName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@ConnectionString",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@SYS_DatabaseCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_DatabaseCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_DatabaseModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_DatabaseModifyTime",SqlDbType.DateTime,10,8}
          } ;
          Object[] prmT001B9 ;
          prmT001B9 = new Object[] {
          new Object[] {"@DatabaseName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@ConnectionString",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@SYS_DatabaseCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_DatabaseCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_DatabaseModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_DatabaseModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001B10 ;
          prmT001B10 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001B11 ;
          prmT001B11 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001B12 ;
          prmT001B12 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T001B2", "SELECT [DatabaseID], [DatabaseName], [ConnectionString], [Creator] AS SYS_DatabaseCreator, [CreateTime] AS SYS_DatabaseCreateTime, [Modifier] AS SYS_DatabaseModifier, [ModifyTime] AS SYS_DatabaseModifyTime FROM dbo.[SYS_Database] WITH (UPDLOCK) WHERE [DatabaseID] = @DatabaseID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001B2,1,0,true,false )
             ,new CursorDef("T001B3", "SELECT [DatabaseID], [DatabaseName], [ConnectionString], [Creator] AS SYS_DatabaseCreator, [CreateTime] AS SYS_DatabaseCreateTime, [Modifier] AS SYS_DatabaseModifier, [ModifyTime] AS SYS_DatabaseModifyTime FROM dbo.[SYS_Database] WITH (NOLOCK) WHERE [DatabaseID] = @DatabaseID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001B3,1,0,true,false )
             ,new CursorDef("T001B4", "SELECT TM1.[DatabaseID], TM1.[DatabaseName], TM1.[ConnectionString], TM1.[Creator] AS SYS_DatabaseCreator, TM1.[CreateTime] AS SYS_DatabaseCreateTime, TM1.[Modifier] AS SYS_DatabaseModifier, TM1.[ModifyTime] AS SYS_DatabaseModifyTime FROM dbo.[SYS_Database] TM1 WITH (NOLOCK) WHERE TM1.[DatabaseID] = @DatabaseID ORDER BY TM1.[DatabaseID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001B4,100,0,true,false )
             ,new CursorDef("T001B5", "SELECT [DatabaseID] FROM dbo.[SYS_Database] WITH (NOLOCK) WHERE [DatabaseID] = @DatabaseID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001B5,1,0,true,false )
             ,new CursorDef("T001B6", "SELECT TOP 1 [DatabaseID] FROM dbo.[SYS_Database] WITH (NOLOCK) WHERE ( [DatabaseID] > @DatabaseID) ORDER BY [DatabaseID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001B6,1,0,true,true )
             ,new CursorDef("T001B7", "SELECT TOP 1 [DatabaseID] FROM dbo.[SYS_Database] WITH (NOLOCK) WHERE ( [DatabaseID] < @DatabaseID) ORDER BY [DatabaseID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001B7,1,0,true,true )
             ,new CursorDef("T001B8", "INSERT INTO dbo.[SYS_Database]([DatabaseID], [DatabaseName], [ConnectionString], [Creator], [CreateTime], [Modifier], [ModifyTime]) VALUES(@DatabaseID, @DatabaseName, @ConnectionString, @SYS_DatabaseCreator, @SYS_DatabaseCreateTime, @SYS_DatabaseModifier, @SYS_DatabaseModifyTime)", GxErrorMask.GX_NOMASK,prmT001B8)
             ,new CursorDef("T001B9", "UPDATE dbo.[SYS_Database] SET [DatabaseName]=@DatabaseName, [ConnectionString]=@ConnectionString, [Creator]=@SYS_DatabaseCreator, [CreateTime]=@SYS_DatabaseCreateTime, [Modifier]=@SYS_DatabaseModifier, [ModifyTime]=@SYS_DatabaseModifyTime  WHERE [DatabaseID] = @DatabaseID", GxErrorMask.GX_NOMASK,prmT001B9)
             ,new CursorDef("T001B10", "DELETE FROM dbo.[SYS_Database]  WHERE [DatabaseID] = @DatabaseID", GxErrorMask.GX_NOMASK,prmT001B10)
             ,new CursorDef("T001B11", "SELECT TOP 1 [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [DatabaseID] = @DatabaseID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001B11,1,0,true,true )
             ,new CursorDef("T001B12", "SELECT [DatabaseID] FROM dbo.[SYS_Database] WITH (NOLOCK) ORDER BY [DatabaseID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001B12,100,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameterDatetime(5, (DateTime)parms[4]);
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 6 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[8]);
                }
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameterDatetime(4, (DateTime)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[7]);
                }
                stmt.SetParameter(7, (int)parms[8]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_database__default : DataStoreHelperBase, IDataStoreHelper
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

}

}
