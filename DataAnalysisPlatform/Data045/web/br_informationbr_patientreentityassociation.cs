/*
               File: BR_InformationBR_PatientReEntityAssociation
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:16:29.51
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_informationbr_patientreentityassociation : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_informationbr_patientreentityassociation( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_informationbr_patientreentityassociation( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Information_ID )
      {
         this.AV8BR_Information_ID = aP0_BR_Information_ID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         lstavNotassociatedrecords = new GXListbox();
         lstavAssociatedrecords = new GXListbox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV8BR_Information_ID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
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

      public override short ExecuteStartEvent( )
      {
         PA832( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START832( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?202022815162961", false);
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
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_informationbr_patientreentityassociation.aspx") + "?" + UrlEncode("" +AV8BR_Information_ID)+"\">") ;
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
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vADDEDKEYLIST", AV21AddedKeyList);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vADDEDKEYLIST", AV21AddedKeyList);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vADDEDDSCLIST", AV23AddedDscList);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vADDEDDSCLIST", AV23AddedDscList);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vNOTADDEDKEYLIST", AV22NotAddedKeyList);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vNOTADDEDKEYLIST", AV22NotAddedKeyList);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vNOTADDEDDSCLIST", AV24NotAddedDscList);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vNOTADDEDDSCLIST", AV24NotAddedDscList);
         }
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vBR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "DATAPACKAGE", A366DataPackage);
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATIENTREENTITY", AV12BR_PatientReEntity);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATIENTREENTITY", AV12BR_PatientReEntity);
         }
         GxWebStd.gx_hidden_field( context, "vDATAPACKAGE", AV9DataPackage);
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE832( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT832( ) ;
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
         return formatLink("br_informationbr_patientreentityassociation.aspx") + "?" + UrlEncode("" +AV8BR_Information_ID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_InformationBR_PatientReEntityAssociation" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB830( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, divTablefullcontent_Internalname, 1, 0, "px", 0, "px", "TableAssociation", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablenotassociated_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 AssociationTitleCell", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblNotassociatedrecordstitle_Internalname, "病种列表", "", "", lblNotassociatedrecordstitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "AssociationTitle", 0, "", 1, 1, 0, "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, lstavNotassociatedrecords_Internalname, "Not Associated Records", "col-sm-3 AssociationListAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            /* ListBox */
            GxWebStd.gx_listbox_ctrl1( context, lstavNotassociatedrecords, lstavNotassociatedrecords_Internalname, StringUtil.RTrim( AV26NotAssociatedRecords), 2, lstavNotassociatedrecords_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, lstavNotassociatedrecords.Enabled, 0, 0, 50, "em", 0, "row", "", "AssociationListAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,22);\"", "", true, "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            lstavNotassociatedrecords.CurrentValue = StringUtil.RTrim( AV26NotAssociatedRecords);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavNotassociatedrecords_Internalname, "Values", (String)(lstavNotassociatedrecords.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-1 CellTableAssociationButtons", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableassociationbuttons_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-12 hidden-sm hidden-md hidden-lg", "left", "top", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-12 CellMarginTopAssociationButtons", "left", "top", "", "", "div");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            ClassString = "AssociationImage";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "6591e2a3-49b6-43b7-b8e3-a292564a32a4", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgImageassociateall_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgImageassociateall_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ASSOCIATE ALL\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-12 CellMarginTopAssociationButtons", "left", "top", "", "", "div");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            ClassString = "AssociationImage";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "56a5f17b-0bc3-48b5-b303-afa6e0585b6d", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgImageassociateselected_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgImageassociateselected_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ASSOCIATE SELECTED\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-12 CellMarginTopAssociationButtons", "left", "top", "", "", "div");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            ClassString = "AssociationImage";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "a3800d0c-bf04-4575-bc01-11fe5d7b3525", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgImagedisassociateselected_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgImagedisassociateselected_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'DISASSOCIATE SELECTED\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-sm-12 CellMarginTopAssociationButtons", "left", "top", "", "", "div");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            ClassString = "AssociationImage";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "c619e28f-4b32-4ff9-baaf-b3063fe4f782", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgImagedisassociateall_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgImagedisassociateall_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'DISASSOCIATE ALL\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableassociated_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 AssociationTitleCell", "Center", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblAssociatedrecordstitle_Internalname, "已选择病种", "", "", lblAssociatedrecordstitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "AssociationTitle", 0, "", 1, 1, 0, "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, lstavAssociatedrecords_Internalname, "Associated Records", "col-sm-3 AssociationListAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            /* ListBox */
            GxWebStd.gx_listbox_ctrl1( context, lstavAssociatedrecords, lstavAssociatedrecords_Internalname, StringUtil.RTrim( AV25AssociatedRecords), 2, lstavAssociatedrecords_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, lstavAssociatedrecords.Enabled, 0, 0, 50, "em", 0, "row", "", "AssociationListAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "", true, "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            lstavAssociatedrecords.CurrentValue = StringUtil.RTrim( AV25AssociatedRecords);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavAssociatedrecords_Internalname, "Values", (String)(lstavAssociatedrecords.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnconfirm_Internalname, "", "确认", bttBtnconfirm_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
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
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavAddedkeylistxml_Internalname, AV17AddedKeyListXml, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavAddedkeylistxml_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2097152", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavNotaddedkeylistxml_Internalname, AV18NotAddedKeyListXml, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavNotaddedkeylistxml_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2097152", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavAddeddsclistxml_Internalname, AV19AddedDscListXml, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavAddeddsclistxml_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2097152", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavNotaddeddsclistxml_Internalname, AV20NotAddedDscListXml, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavNotaddeddsclistxml_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2097152", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_InformationBR_PatientReEntityAssociation.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START832( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
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
         wbErr = false;
         STRUP830( ) ;
      }

      protected void WS832( )
      {
         START832( ) ;
         EVT832( ) ;
      }

      protected void EVT832( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E11832 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E12832 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: Enter */
                                    E13832 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DISASSOCIATE SELECTED'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Disassociate Selected' */
                              E14832 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ASSOCIATE SELECTED'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Associate selected' */
                              E15832 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ASSOCIATE ALL'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Associate All' */
                              E16832 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DISASSOCIATE ALL'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Disassociate All' */
                              E17832 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VASSOCIATEDRECORDS.DBLCLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18832 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VNOTASSOCIATEDRECORDS.DBLCLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E19832 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E20832 ();
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VASSOCIATEDRECORDS.DBLCLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18832 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VNOTASSOCIATEDRECORDS.DBLCLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E19832 ();
                              dynload_actions( ) ;
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
      }

      protected void WE832( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA832( )
      {
         if ( nDonePA == 0 )
         {
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
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = lstavNotassociatedrecords_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( lstavNotassociatedrecords.ItemCount > 0 )
         {
            AV26NotAssociatedRecords = lstavNotassociatedrecords.getValidValue(AV26NotAssociatedRecords);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26NotAssociatedRecords", AV26NotAssociatedRecords);
         }
         if ( context.isAjaxRequest( ) )
         {
            lstavNotassociatedrecords.CurrentValue = StringUtil.RTrim( AV26NotAssociatedRecords);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavNotassociatedrecords_Internalname, "Values", lstavNotassociatedrecords.ToJavascriptSource(), true);
         }
         if ( lstavAssociatedrecords.ItemCount > 0 )
         {
            AV25AssociatedRecords = lstavAssociatedrecords.getValidValue(AV25AssociatedRecords);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25AssociatedRecords", AV25AssociatedRecords);
         }
         if ( context.isAjaxRequest( ) )
         {
            lstavAssociatedrecords.CurrentValue = StringUtil.RTrim( AV25AssociatedRecords);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavAssociatedrecords_Internalname, "Values", lstavAssociatedrecords.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF832( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF832( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E12832 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E20832 ();
            WB830( ) ;
         }
      }

      protected void send_integrity_lvl_hashes832( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP830( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11832 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            lstavNotassociatedrecords.CurrentValue = cgiGet( lstavNotassociatedrecords_Internalname);
            AV26NotAssociatedRecords = cgiGet( lstavNotassociatedrecords_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26NotAssociatedRecords", AV26NotAssociatedRecords);
            lstavAssociatedrecords.CurrentValue = cgiGet( lstavAssociatedrecords_Internalname);
            AV25AssociatedRecords = cgiGet( lstavAssociatedrecords_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25AssociatedRecords", AV25AssociatedRecords);
            AV17AddedKeyListXml = cgiGet( edtavAddedkeylistxml_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17AddedKeyListXml", AV17AddedKeyListXml);
            AV18NotAddedKeyListXml = cgiGet( edtavNotaddedkeylistxml_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18NotAddedKeyListXml", AV18NotAddedKeyListXml);
            AV19AddedDscListXml = cgiGet( edtavAddeddsclistxml_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19AddedDscListXml", AV19AddedDscListXml);
            AV20NotAddedDscListXml = cgiGet( edtavNotaddeddsclistxml_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20NotAddedDscListXml", AV20NotAddedDscListXml);
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E11832 ();
         if (returnInSub) return;
      }

      protected void E11832( )
      {
         /* Start Routine */
         GXt_boolean1 = AV28IsManager;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
         AV28IsManager = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28IsManager", AV28IsManager);
         if ( ! AV28IsManager )
         {
            AV32tDataPackage.Clear();
            AV29tResult = AV30websession.Get("DAS_UserPermission");
            AV31tSDT_MicroUserInfo.FromJSonString(AV29tResult, null);
            AV32tDataPackage.Clear();
            AV33tNum = 1;
            while ( AV33tNum <= ((SdtSDT_MicroUserInfo_Tenants)AV31tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Datascoptes.Count )
            {
               AV32tDataPackage.Add(StringUtil.Trim( ((String)((SdtSDT_MicroUserInfo_Tenants)AV31tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Datascoptes.Item((int)(AV33tNum)))), 0);
               AV33tNum = (long)(AV33tNum+1);
            }
         }
         if ( 1 == 0 )
         {
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
            if ( StringUtil.StrCmp(AV10HTTPRequest.Method, "GET") == 0 )
            {
               AV36GXLvl30 = 0;
               /* Using cursor H00832 */
               pr_default.execute(0, new Object[] {AV8BR_Information_ID});
               while ( (pr_default.getStatus(0) != 101) )
               {
                  A85BR_Information_ID = H00832_A85BR_Information_ID[0];
                  AV36GXLvl30 = 1;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(0);
               if ( AV36GXLvl30 == 0 )
               {
                  GX_msglist.addItem("记录未找到");
               }
               /* Using cursor H00833 */
               pr_datastore1.execute(0);
               while ( (pr_datastore1.getStatus(0) != 101) )
               {
                  A366DataPackage = H00833_A366DataPackage[0];
                  AV11Exist = false;
                  /* Using cursor H00834 */
                  pr_default.execute(1, new Object[] {AV8BR_Information_ID, A366DataPackage});
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A85BR_Information_ID = H00834_A85BR_Information_ID[0];
                     AV11Exist = true;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(1);
                  AV14Description = A366DataPackage;
                  if ( AV11Exist )
                  {
                     AV21AddedKeyList.Add(A366DataPackage, 0);
                     AV23AddedDscList.Add(AV14Description, 0);
                  }
                  else
                  {
                     AV22NotAddedKeyList.Add(A366DataPackage, 0);
                     AV24NotAddedDscList.Add(AV14Description, 0);
                  }
                  pr_datastore1.readNext(0);
               }
               pr_datastore1.close(0);
               /* Execute user subroutine: 'SAVELISTS' */
               S112 ();
               if (returnInSub) return;
            }
            edtavAddedkeylistxml_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAddedkeylistxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAddedkeylistxml_Visible), 5, 0)), true);
            edtavNotaddedkeylistxml_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNotaddedkeylistxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNotaddedkeylistxml_Visible), 5, 0)), true);
            edtavAddeddsclistxml_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAddeddsclistxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAddeddsclistxml_Visible), 5, 0)), true);
            edtavNotaddeddsclistxml_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNotaddeddsclistxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNotaddeddsclistxml_Visible), 5, 0)), true);
         }
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         if ( StringUtil.StrCmp(AV10HTTPRequest.Method, "GET") == 0 )
         {
            AV39GXLvl65 = 0;
            /* Using cursor H00835 */
            pr_default.execute(2, new Object[] {AV8BR_Information_ID});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A85BR_Information_ID = H00835_A85BR_Information_ID[0];
               AV39GXLvl65 = 1;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            if ( AV39GXLvl65 == 0 )
            {
               GX_msglist.addItem("记录未找到");
            }
            pr_datastore1.dynParam(1, new Object[]{ new Object[]{
                                                 A366DataPackage ,
                                                 AV32tDataPackage ,
                                                 AV28IsManager } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H00836 */
            pr_datastore1.execute(1);
            while ( (pr_datastore1.getStatus(1) != 101) )
            {
               A366DataPackage = H00836_A366DataPackage[0];
               AV11Exist = false;
               /* Using cursor H00837 */
               pr_default.execute(3, new Object[] {AV8BR_Information_ID, A366DataPackage});
               while ( (pr_default.getStatus(3) != 101) )
               {
                  A85BR_Information_ID = H00837_A85BR_Information_ID[0];
                  AV11Exist = true;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(3);
               AV14Description = A366DataPackage;
               if ( AV11Exist )
               {
                  AV21AddedKeyList.Add(A366DataPackage, 0);
                  AV23AddedDscList.Add(AV14Description, 0);
               }
               else
               {
                  AV22NotAddedKeyList.Add(A366DataPackage, 0);
                  AV24NotAddedDscList.Add(AV14Description, 0);
               }
               pr_datastore1.readNext(1);
            }
            pr_datastore1.close(1);
            /* Execute user subroutine: 'SAVELISTS' */
            S112 ();
            if (returnInSub) return;
         }
         edtavAddedkeylistxml_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAddedkeylistxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAddedkeylistxml_Visible), 5, 0)), true);
         edtavNotaddedkeylistxml_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNotaddedkeylistxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNotaddedkeylistxml_Visible), 5, 0)), true);
         edtavAddeddsclistxml_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAddeddsclistxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAddeddsclistxml_Visible), 5, 0)), true);
         edtavNotaddeddsclistxml_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNotaddeddsclistxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNotaddeddsclistxml_Visible), 5, 0)), true);
      }

      protected void E12832( )
      {
         /* Refresh Routine */
         /* Execute user subroutine: 'UPDATEASSOCIATIONVARIABLES' */
         S122 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
         lstavAssociatedrecords.CurrentValue = StringUtil.RTrim( AV25AssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavAssociatedrecords_Internalname, "Values", lstavAssociatedrecords.ToJavascriptSource(), true);
         lstavNotassociatedrecords.CurrentValue = StringUtil.RTrim( AV26NotAssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavNotassociatedrecords_Internalname, "Values", lstavNotassociatedrecords.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23AddedDscList", AV23AddedDscList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21AddedKeyList", AV21AddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22NotAddedKeyList", AV22NotAddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24NotAddedDscList", AV24NotAddedDscList);
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E13832 ();
         if (returnInSub) return;
      }

      protected void E13832( )
      {
         /* Enter Routine */
         if ( 1 == 0 )
         {
            /* Execute user subroutine: 'LOADLISTS' */
            S132 ();
            if (returnInSub) return;
            AV15i = 1;
            AV13Success = true;
            AV42GXV1 = 1;
            while ( AV42GXV1 <= AV21AddedKeyList.Count )
            {
               AV9DataPackage = ((String)AV21AddedKeyList.Item(AV42GXV1));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DataPackage", AV9DataPackage);
               if ( AV13Success )
               {
                  AV11Exist = false;
                  /* Using cursor H00838 */
                  pr_default.execute(4, new Object[] {AV8BR_Information_ID, AV9DataPackage});
                  while ( (pr_default.getStatus(4) != 101) )
                  {
                     A366DataPackage = H00838_A366DataPackage[0];
                     A85BR_Information_ID = H00838_A85BR_Information_ID[0];
                     AV11Exist = true;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(4);
                  if ( ! AV11Exist )
                  {
                     AV12BR_PatientReEntity = new SdtBR_PatientReEntity(context);
                     AV12BR_PatientReEntity.gxTpr_Br_information_id = AV8BR_Information_ID;
                     AV12BR_PatientReEntity.gxTpr_Datapackage = AV9DataPackage;
                     AV12BR_PatientReEntity.Save();
                     if ( ! AV12BR_PatientReEntity.Success() )
                     {
                        AV13Success = false;
                     }
                  }
               }
               AV15i = (int)(AV15i+1);
               AV42GXV1 = (int)(AV42GXV1+1);
            }
            AV15i = 1;
            AV44GXV2 = 1;
            while ( AV44GXV2 <= AV22NotAddedKeyList.Count )
            {
               AV9DataPackage = ((String)AV22NotAddedKeyList.Item(AV44GXV2));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DataPackage", AV9DataPackage);
               if ( AV13Success )
               {
                  AV11Exist = false;
                  /* Using cursor H00839 */
                  pr_default.execute(5, new Object[] {AV8BR_Information_ID, AV9DataPackage});
                  while ( (pr_default.getStatus(5) != 101) )
                  {
                     A366DataPackage = H00839_A366DataPackage[0];
                     A85BR_Information_ID = H00839_A85BR_Information_ID[0];
                     AV11Exist = true;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(5);
                  if ( AV11Exist )
                  {
                     AV12BR_PatientReEntity = new SdtBR_PatientReEntity(context);
                     AV12BR_PatientReEntity.Load(AV8BR_Information_ID, AV9DataPackage);
                     if ( AV12BR_PatientReEntity.Success() )
                     {
                        AV12BR_PatientReEntity.Delete();
                     }
                     if ( ! AV12BR_PatientReEntity.Success() )
                     {
                        AV13Success = false;
                     }
                  }
               }
               AV15i = (int)(AV15i+1);
               AV44GXV2 = (int)(AV44GXV2+1);
            }
            if ( AV13Success )
            {
               context.CommitDataStores("br_informationbr_patientreentityassociation",pr_default);
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
            else
            {
               /* Execute user subroutine: 'SHOW ERROR MESSAGES' */
               S142 ();
               if (returnInSub) return;
            }
         }
         /* Execute user subroutine: 'LOADLISTS' */
         S132 ();
         if (returnInSub) return;
         AV15i = 1;
         AV13Success = true;
         AV46GXV3 = 1;
         while ( AV46GXV3 <= AV21AddedKeyList.Count )
         {
            AV9DataPackage = ((String)AV21AddedKeyList.Item(AV46GXV3));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DataPackage", AV9DataPackage);
            if ( AV13Success )
            {
               AV11Exist = false;
               /* Using cursor H008310 */
               pr_default.execute(6, new Object[] {AV8BR_Information_ID, AV9DataPackage});
               while ( (pr_default.getStatus(6) != 101) )
               {
                  A366DataPackage = H008310_A366DataPackage[0];
                  A85BR_Information_ID = H008310_A85BR_Information_ID[0];
                  AV11Exist = true;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(6);
               if ( ! AV11Exist )
               {
                  AV12BR_PatientReEntity = new SdtBR_PatientReEntity(context);
                  AV12BR_PatientReEntity.gxTpr_Br_information_id = AV8BR_Information_ID;
                  AV12BR_PatientReEntity.gxTpr_Datapackage = AV9DataPackage;
                  AV12BR_PatientReEntity.Save();
                  if ( ! AV12BR_PatientReEntity.Success() )
                  {
                     AV13Success = false;
                  }
               }
            }
            AV15i = (int)(AV15i+1);
            AV46GXV3 = (int)(AV46GXV3+1);
         }
         AV15i = 1;
         AV48GXV4 = 1;
         while ( AV48GXV4 <= AV22NotAddedKeyList.Count )
         {
            AV9DataPackage = ((String)AV22NotAddedKeyList.Item(AV48GXV4));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DataPackage", AV9DataPackage);
            if ( AV13Success )
            {
               AV11Exist = false;
               /* Using cursor H008311 */
               pr_default.execute(7, new Object[] {AV8BR_Information_ID, AV9DataPackage});
               while ( (pr_default.getStatus(7) != 101) )
               {
                  A366DataPackage = H008311_A366DataPackage[0];
                  A85BR_Information_ID = H008311_A85BR_Information_ID[0];
                  AV11Exist = true;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(7);
               if ( AV11Exist )
               {
                  AV12BR_PatientReEntity = new SdtBR_PatientReEntity(context);
                  AV12BR_PatientReEntity.Load(AV8BR_Information_ID, AV9DataPackage);
                  if ( AV12BR_PatientReEntity.Success() )
                  {
                     AV12BR_PatientReEntity.Delete();
                  }
                  if ( ! AV12BR_PatientReEntity.Success() )
                  {
                     AV13Success = false;
                  }
               }
            }
            AV15i = (int)(AV15i+1);
            AV48GXV4 = (int)(AV48GXV4+1);
         }
         if ( AV13Success )
         {
            context.CommitDataStores("br_informationbr_patientreentityassociation",pr_default);
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         else
         {
            /* Execute user subroutine: 'SHOW ERROR MESSAGES' */
            S142 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_PatientReEntity", AV12BR_PatientReEntity);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23AddedDscList", AV23AddedDscList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21AddedKeyList", AV21AddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22NotAddedKeyList", AV22NotAddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24NotAddedDscList", AV24NotAddedDscList);
      }

      protected void E14832( )
      {
         /* 'Disassociate Selected' Routine */
         /* Execute user subroutine: 'DISASSOCIATESELECTED' */
         S152 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22NotAddedKeyList", AV22NotAddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24NotAddedDscList", AV24NotAddedDscList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21AddedKeyList", AV21AddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23AddedDscList", AV23AddedDscList);
         lstavAssociatedrecords.CurrentValue = StringUtil.RTrim( AV25AssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavAssociatedrecords_Internalname, "Values", lstavAssociatedrecords.ToJavascriptSource(), true);
         lstavNotassociatedrecords.CurrentValue = StringUtil.RTrim( AV26NotAssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavNotassociatedrecords_Internalname, "Values", lstavNotassociatedrecords.ToJavascriptSource(), true);
      }

      protected void E15832( )
      {
         /* 'Associate selected' Routine */
         /* Execute user subroutine: 'ASSOCIATESELECTED' */
         S162 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21AddedKeyList", AV21AddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23AddedDscList", AV23AddedDscList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22NotAddedKeyList", AV22NotAddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24NotAddedDscList", AV24NotAddedDscList);
         lstavAssociatedrecords.CurrentValue = StringUtil.RTrim( AV25AssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavAssociatedrecords_Internalname, "Values", lstavAssociatedrecords.ToJavascriptSource(), true);
         lstavNotassociatedrecords.CurrentValue = StringUtil.RTrim( AV26NotAssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavNotassociatedrecords_Internalname, "Values", lstavNotassociatedrecords.ToJavascriptSource(), true);
      }

      protected void E16832( )
      {
         /* 'Associate All' Routine */
         /* Execute user subroutine: 'ASSOCIATEALL' */
         S172 ();
         if (returnInSub) return;
         /* Execute user subroutine: 'UPDATEASSOCIATIONVARIABLES' */
         S122 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21AddedKeyList", AV21AddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23AddedDscList", AV23AddedDscList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22NotAddedKeyList", AV22NotAddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24NotAddedDscList", AV24NotAddedDscList);
         lstavAssociatedrecords.CurrentValue = StringUtil.RTrim( AV25AssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavAssociatedrecords_Internalname, "Values", lstavAssociatedrecords.ToJavascriptSource(), true);
         lstavNotassociatedrecords.CurrentValue = StringUtil.RTrim( AV26NotAssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavNotassociatedrecords_Internalname, "Values", lstavNotassociatedrecords.ToJavascriptSource(), true);
      }

      protected void E17832( )
      {
         /* 'Disassociate All' Routine */
         /* Execute user subroutine: 'ASSOCIATEALL' */
         S172 ();
         if (returnInSub) return;
         AV22NotAddedKeyList = (GxSimpleCollection<String>)(AV21AddedKeyList.Clone());
         AV24NotAddedDscList = (GxSimpleCollection<String>)(AV23AddedDscList.Clone());
         AV23AddedDscList.Clear();
         AV21AddedKeyList.Clear();
         /* Execute user subroutine: 'SAVELISTS' */
         S112 ();
         if (returnInSub) return;
         /* Execute user subroutine: 'UPDATEASSOCIATIONVARIABLES' */
         S122 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22NotAddedKeyList", AV22NotAddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24NotAddedDscList", AV24NotAddedDscList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23AddedDscList", AV23AddedDscList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21AddedKeyList", AV21AddedKeyList);
         lstavAssociatedrecords.CurrentValue = StringUtil.RTrim( AV25AssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavAssociatedrecords_Internalname, "Values", lstavAssociatedrecords.ToJavascriptSource(), true);
         lstavNotassociatedrecords.CurrentValue = StringUtil.RTrim( AV26NotAssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavNotassociatedrecords_Internalname, "Values", lstavNotassociatedrecords.ToJavascriptSource(), true);
      }

      protected void E18832( )
      {
         /* Associatedrecords_Dblclick Routine */
         /* Execute user subroutine: 'DISASSOCIATESELECTED' */
         S152 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22NotAddedKeyList", AV22NotAddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24NotAddedDscList", AV24NotAddedDscList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21AddedKeyList", AV21AddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23AddedDscList", AV23AddedDscList);
         lstavAssociatedrecords.CurrentValue = StringUtil.RTrim( AV25AssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavAssociatedrecords_Internalname, "Values", lstavAssociatedrecords.ToJavascriptSource(), true);
         lstavNotassociatedrecords.CurrentValue = StringUtil.RTrim( AV26NotAssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavNotassociatedrecords_Internalname, "Values", lstavNotassociatedrecords.ToJavascriptSource(), true);
      }

      protected void E19832( )
      {
         /* Notassociatedrecords_Dblclick Routine */
         /* Execute user subroutine: 'ASSOCIATESELECTED' */
         S162 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21AddedKeyList", AV21AddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23AddedDscList", AV23AddedDscList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22NotAddedKeyList", AV22NotAddedKeyList);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24NotAddedDscList", AV24NotAddedDscList);
         lstavAssociatedrecords.CurrentValue = StringUtil.RTrim( AV25AssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavAssociatedrecords_Internalname, "Values", lstavAssociatedrecords.ToJavascriptSource(), true);
         lstavNotassociatedrecords.CurrentValue = StringUtil.RTrim( AV26NotAssociatedRecords);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lstavNotassociatedrecords_Internalname, "Values", lstavNotassociatedrecords.ToJavascriptSource(), true);
      }

      protected void S122( )
      {
         /* 'UPDATEASSOCIATIONVARIABLES' Routine */
         /* Execute user subroutine: 'LOADLISTS' */
         S132 ();
         if (returnInSub) return;
         lstavAssociatedrecords.removeAllItems();
         lstavNotassociatedrecords.removeAllItems();
         AV15i = 1;
         AV50GXV5 = 1;
         while ( AV50GXV5 <= AV21AddedKeyList.Count )
         {
            AV9DataPackage = ((String)AV21AddedKeyList.Item(AV50GXV5));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DataPackage", AV9DataPackage);
            AV14Description = ((String)AV23AddedDscList.Item(AV15i));
            lstavAssociatedrecords.addItem(AV9DataPackage, StringUtil.Trim( AV14Description), 0);
            AV15i = (int)(AV15i+1);
            AV50GXV5 = (int)(AV50GXV5+1);
         }
         AV15i = 1;
         AV51GXV6 = 1;
         while ( AV51GXV6 <= AV22NotAddedKeyList.Count )
         {
            AV9DataPackage = ((String)AV22NotAddedKeyList.Item(AV51GXV6));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DataPackage", AV9DataPackage);
            AV14Description = ((String)AV24NotAddedDscList.Item(AV15i));
            lstavNotassociatedrecords.addItem(AV9DataPackage, StringUtil.Trim( AV14Description), 0);
            AV15i = (int)(AV15i+1);
            AV51GXV6 = (int)(AV51GXV6+1);
         }
      }

      protected void S142( )
      {
         /* 'SHOW ERROR MESSAGES' Routine */
         AV53GXV8 = 1;
         AV52GXV7 = AV12BR_PatientReEntity.GetMessages();
         while ( AV53GXV8 <= AV52GXV7.Count )
         {
            AV16Message = ((SdtMessages_Message)AV52GXV7.Item(AV53GXV8));
            if ( AV16Message.gxTpr_Type == 1 )
            {
               GX_msglist.addItem(AV16Message.gxTpr_Description);
            }
            AV53GXV8 = (int)(AV53GXV8+1);
         }
      }

      protected void S132( )
      {
         /* 'LOADLISTS' Routine */
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV17AddedKeyListXml)) )
         {
            AV23AddedDscList.FromXml(AV19AddedDscListXml, null, "Collection", "");
            AV21AddedKeyList.FromXml(AV17AddedKeyListXml, null, "Collection", "");
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV18NotAddedKeyListXml)) )
         {
            AV22NotAddedKeyList.FromXml(AV18NotAddedKeyListXml, null, "Collection", "");
            AV24NotAddedDscList.FromXml(AV20NotAddedDscListXml, null, "Collection", "");
         }
      }

      protected void S112( )
      {
         /* 'SAVELISTS' Routine */
         if ( AV21AddedKeyList.Count > 0 )
         {
            AV17AddedKeyListXml = AV21AddedKeyList.ToXml(false, true, "Collection", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17AddedKeyListXml", AV17AddedKeyListXml);
            AV19AddedDscListXml = AV23AddedDscList.ToXml(false, true, "Collection", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19AddedDscListXml", AV19AddedDscListXml);
         }
         else
         {
            AV17AddedKeyListXml = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17AddedKeyListXml", AV17AddedKeyListXml);
            AV19AddedDscListXml = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19AddedDscListXml", AV19AddedDscListXml);
         }
         if ( AV22NotAddedKeyList.Count > 0 )
         {
            AV18NotAddedKeyListXml = AV22NotAddedKeyList.ToXml(false, true, "Collection", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18NotAddedKeyListXml", AV18NotAddedKeyListXml);
            AV20NotAddedDscListXml = AV24NotAddedDscList.ToXml(false, true, "Collection", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20NotAddedDscListXml", AV20NotAddedDscListXml);
         }
         else
         {
            AV18NotAddedKeyListXml = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18NotAddedKeyListXml", AV18NotAddedKeyListXml);
            AV20NotAddedDscListXml = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20NotAddedDscListXml", AV20NotAddedDscListXml);
         }
      }

      protected void S172( )
      {
         /* 'ASSOCIATEALL' Routine */
         /* Execute user subroutine: 'LOADLISTS' */
         S132 ();
         if (returnInSub) return;
         AV15i = 1;
         AV27InsertIndex = 1;
         AV54GXV9 = 1;
         while ( AV54GXV9 <= AV22NotAddedKeyList.Count )
         {
            AV9DataPackage = ((String)AV22NotAddedKeyList.Item(AV54GXV9));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DataPackage", AV9DataPackage);
            AV14Description = ((String)AV24NotAddedDscList.Item(AV15i));
            while ( ( AV27InsertIndex <= AV23AddedDscList.Count ) && ( StringUtil.StrCmp(((String)AV23AddedDscList.Item(AV27InsertIndex)), AV14Description) < 0 ) )
            {
               AV27InsertIndex = (int)(AV27InsertIndex+1);
            }
            AV21AddedKeyList.Add(AV9DataPackage, AV27InsertIndex);
            AV23AddedDscList.Add(AV14Description, AV27InsertIndex);
            AV15i = (int)(AV15i+1);
            AV54GXV9 = (int)(AV54GXV9+1);
         }
         AV22NotAddedKeyList.Clear();
         AV24NotAddedDscList.Clear();
         /* Execute user subroutine: 'SAVELISTS' */
         S112 ();
         if (returnInSub) return;
      }

      protected void S162( )
      {
         /* 'ASSOCIATESELECTED' Routine */
         /* Execute user subroutine: 'LOADLISTS' */
         S132 ();
         if (returnInSub) return;
         AV15i = 1;
         AV55GXV10 = 1;
         while ( AV55GXV10 <= AV22NotAddedKeyList.Count )
         {
            AV9DataPackage = ((String)AV22NotAddedKeyList.Item(AV55GXV10));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DataPackage", AV9DataPackage);
            if ( StringUtil.StrCmp(AV9DataPackage, AV26NotAssociatedRecords) == 0 )
            {
               if (true) break;
            }
            AV15i = (int)(AV15i+1);
            AV55GXV10 = (int)(AV55GXV10+1);
         }
         if ( AV15i <= AV22NotAddedKeyList.Count )
         {
            AV14Description = ((String)AV24NotAddedDscList.Item(AV15i));
            AV27InsertIndex = 1;
            while ( ( AV27InsertIndex <= AV23AddedDscList.Count ) && ( StringUtil.StrCmp(((String)AV23AddedDscList.Item(AV27InsertIndex)), AV14Description) < 0 ) )
            {
               AV27InsertIndex = (int)(AV27InsertIndex+1);
            }
            AV21AddedKeyList.Add(AV26NotAssociatedRecords, AV27InsertIndex);
            AV23AddedDscList.Add(AV14Description, AV27InsertIndex);
            AV22NotAddedKeyList.RemoveItem(AV15i);
            AV24NotAddedDscList.RemoveItem(AV15i);
            /* Execute user subroutine: 'SAVELISTS' */
            S112 ();
            if (returnInSub) return;
         }
         /* Execute user subroutine: 'UPDATEASSOCIATIONVARIABLES' */
         S122 ();
         if (returnInSub) return;
      }

      protected void S152( )
      {
         /* 'DISASSOCIATESELECTED' Routine */
         /* Execute user subroutine: 'LOADLISTS' */
         S132 ();
         if (returnInSub) return;
         AV15i = 1;
         AV56GXV11 = 1;
         while ( AV56GXV11 <= AV21AddedKeyList.Count )
         {
            AV9DataPackage = ((String)AV21AddedKeyList.Item(AV56GXV11));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9DataPackage", AV9DataPackage);
            if ( StringUtil.StrCmp(AV9DataPackage, AV25AssociatedRecords) == 0 )
            {
               if (true) break;
            }
            AV15i = (int)(AV15i+1);
            AV56GXV11 = (int)(AV56GXV11+1);
         }
         if ( AV15i <= AV21AddedKeyList.Count )
         {
            AV14Description = ((String)AV23AddedDscList.Item(AV15i));
            AV27InsertIndex = 1;
            while ( ( AV27InsertIndex <= AV24NotAddedDscList.Count ) && ( StringUtil.StrCmp(((String)AV24NotAddedDscList.Item(AV27InsertIndex)), AV14Description) < 0 ) )
            {
               AV27InsertIndex = (int)(AV27InsertIndex+1);
            }
            AV22NotAddedKeyList.Add(AV25AssociatedRecords, AV27InsertIndex);
            AV24NotAddedDscList.Add(AV14Description, AV27InsertIndex);
            AV21AddedKeyList.RemoveItem(AV15i);
            AV23AddedDscList.RemoveItem(AV15i);
            /* Execute user subroutine: 'SAVELISTS' */
            S112 ();
            if (returnInSub) return;
         }
         /* Execute user subroutine: 'UPDATEASSOCIATIONVARIABLES' */
         S122 ();
         if (returnInSub) return;
      }

      protected void nextLoad( )
      {
      }

      protected void E20832( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8BR_Information_ID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA832( ) ;
         WS832( ) ;
         WE832( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815163080", true);
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
         context.AddJavascriptSource("br_informationbr_patientreentityassociation.js", "?202022815163080", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         lstavNotassociatedrecords.Name = "vNOTASSOCIATEDRECORDS";
         lstavNotassociatedrecords.WebTags = "";
         if ( lstavNotassociatedrecords.ItemCount > 0 )
         {
            AV26NotAssociatedRecords = lstavNotassociatedrecords.getValidValue(AV26NotAssociatedRecords);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26NotAssociatedRecords", AV26NotAssociatedRecords);
         }
         lstavAssociatedrecords.Name = "vASSOCIATEDRECORDS";
         lstavAssociatedrecords.WebTags = "";
         if ( lstavAssociatedrecords.ItemCount > 0 )
         {
            AV25AssociatedRecords = lstavAssociatedrecords.getValidValue(AV25AssociatedRecords);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25AssociatedRecords", AV25AssociatedRecords);
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblNotassociatedrecordstitle_Internalname = "NOTASSOCIATEDRECORDSTITLE";
         lstavNotassociatedrecords_Internalname = "vNOTASSOCIATEDRECORDS";
         divTablenotassociated_Internalname = "TABLENOTASSOCIATED";
         imgImageassociateall_Internalname = "IMAGEASSOCIATEALL";
         imgImageassociateselected_Internalname = "IMAGEASSOCIATESELECTED";
         imgImagedisassociateselected_Internalname = "IMAGEDISASSOCIATESELECTED";
         imgImagedisassociateall_Internalname = "IMAGEDISASSOCIATEALL";
         divUnnamedtableassociationbuttons_Internalname = "UNNAMEDTABLEASSOCIATIONBUTTONS";
         lblAssociatedrecordstitle_Internalname = "ASSOCIATEDRECORDSTITLE";
         lstavAssociatedrecords_Internalname = "vASSOCIATEDRECORDS";
         divTableassociated_Internalname = "TABLEASSOCIATED";
         divTablefullcontent_Internalname = "TABLEFULLCONTENT";
         bttBtnconfirm_Internalname = "BTNCONFIRM";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavAddedkeylistxml_Internalname = "vADDEDKEYLISTXML";
         edtavNotaddedkeylistxml_Internalname = "vNOTADDEDKEYLISTXML";
         edtavAddeddsclistxml_Internalname = "vADDEDDSCLISTXML";
         edtavNotaddeddsclistxml_Internalname = "vNOTADDEDDSCLISTXML";
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
         edtavNotaddeddsclistxml_Visible = 1;
         edtavAddeddsclistxml_Visible = 1;
         edtavNotaddedkeylistxml_Visible = 1;
         edtavAddedkeylistxml_Visible = 1;
         lstavAssociatedrecords_Jsonclick = "";
         lstavAssociatedrecords.Enabled = 1;
         lstavNotassociatedrecords_Jsonclick = "";
         lstavNotassociatedrecords.Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Data Mgmt Portal - RAAP";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'lstavAssociatedrecords'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:''},{av:'lstavNotassociatedrecords'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:''},{av:'AV9DataPackage',fld:'vDATAPACKAGE',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''}]}");
         setEventMetadata("ENTER","{handler:'E13832',iparms:[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A366DataPackage',fld:'DATAPACKAGE',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{av:'AV12BR_PatientReEntity',fld:'vBR_PATIENTREENTITY',pic:''},{av:'AV9DataPackage',fld:'vDATAPACKAGE',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV9DataPackage',fld:'vDATAPACKAGE',pic:''},{av:'AV12BR_PatientReEntity',fld:'vBR_PATIENTREENTITY',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''}]}");
         setEventMetadata("'DISASSOCIATE SELECTED'","{handler:'E14832',iparms:[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'lstavAssociatedrecords'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}]");
         setEventMetadata("'DISASSOCIATE SELECTED'",",oparms:[{av:'AV9DataPackage',fld:'vDATAPACKAGE',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{av:'lstavAssociatedrecords'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:''},{av:'lstavNotassociatedrecords'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:''}]}");
         setEventMetadata("'ASSOCIATE SELECTED'","{handler:'E15832',iparms:[{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'lstavNotassociatedrecords'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}]");
         setEventMetadata("'ASSOCIATE SELECTED'",",oparms:[{av:'AV9DataPackage',fld:'vDATAPACKAGE',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{av:'lstavAssociatedrecords'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:''},{av:'lstavNotassociatedrecords'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:''}]}");
         setEventMetadata("'ASSOCIATE ALL'","{handler:'E16832',iparms:[{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}]");
         setEventMetadata("'ASSOCIATE ALL'",",oparms:[{av:'AV9DataPackage',fld:'vDATAPACKAGE',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'lstavAssociatedrecords'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:''},{av:'lstavNotassociatedrecords'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}]}");
         setEventMetadata("'DISASSOCIATE ALL'","{handler:'E17832',iparms:[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}]");
         setEventMetadata("'DISASSOCIATE ALL'",",oparms:[{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV9DataPackage',fld:'vDATAPACKAGE',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{av:'lstavAssociatedrecords'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:''},{av:'lstavNotassociatedrecords'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:''}]}");
         setEventMetadata("VASSOCIATEDRECORDS.DBLCLICK","{handler:'E18832',iparms:[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'lstavAssociatedrecords'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}]");
         setEventMetadata("VASSOCIATEDRECORDS.DBLCLICK",",oparms:[{av:'AV9DataPackage',fld:'vDATAPACKAGE',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{av:'lstavAssociatedrecords'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:''},{av:'lstavNotassociatedrecords'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:''}]}");
         setEventMetadata("VNOTASSOCIATEDRECORDS.DBLCLICK","{handler:'E19832',iparms:[{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'lstavNotassociatedrecords'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}]");
         setEventMetadata("VNOTASSOCIATEDRECORDS.DBLCLICK",",oparms:[{av:'AV9DataPackage',fld:'vDATAPACKAGE',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{av:'lstavAssociatedrecords'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:''},{av:'lstavNotassociatedrecords'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:''}]}");
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV21AddedKeyList = new GxSimpleCollection<String>();
         AV23AddedDscList = new GxSimpleCollection<String>();
         AV22NotAddedKeyList = new GxSimpleCollection<String>();
         AV24NotAddedDscList = new GxSimpleCollection<String>();
         A366DataPackage = "";
         AV12BR_PatientReEntity = new SdtBR_PatientReEntity(context);
         AV9DataPackage = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         lblNotassociatedrecordstitle_Jsonclick = "";
         TempTags = "";
         AV26NotAssociatedRecords = "";
         sImgUrl = "";
         imgImageassociateall_Jsonclick = "";
         imgImageassociateselected_Jsonclick = "";
         imgImagedisassociateselected_Jsonclick = "";
         imgImagedisassociateall_Jsonclick = "";
         lblAssociatedrecordstitle_Jsonclick = "";
         AV25AssociatedRecords = "";
         bttBtnconfirm_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         AV17AddedKeyListXml = "";
         AV18NotAddedKeyListXml = "";
         AV19AddedDscListXml = "";
         AV20NotAddedDscListXml = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV32tDataPackage = new GxSimpleCollection<String>();
         AV29tResult = "";
         AV30websession = context.GetSession();
         AV31tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV10HTTPRequest = new GxHttpRequest( context);
         scmdbuf = "";
         H00832_A85BR_Information_ID = new long[1] ;
         H00833_A366DataPackage = new String[] {""} ;
         H00834_A366DataPackage = new String[] {""} ;
         H00834_A85BR_Information_ID = new long[1] ;
         AV14Description = "";
         H00835_A85BR_Information_ID = new long[1] ;
         H00836_A366DataPackage = new String[] {""} ;
         H00837_A366DataPackage = new String[] {""} ;
         H00837_A85BR_Information_ID = new long[1] ;
         H00838_A366DataPackage = new String[] {""} ;
         H00838_A85BR_Information_ID = new long[1] ;
         H00839_A366DataPackage = new String[] {""} ;
         H00839_A85BR_Information_ID = new long[1] ;
         H008310_A366DataPackage = new String[] {""} ;
         H008310_A85BR_Information_ID = new long[1] ;
         H008311_A366DataPackage = new String[] {""} ;
         H008311_A85BR_Information_ID = new long[1] ;
         AV52GXV7 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV16Message = new SdtMessages_Message(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_informationbr_patientreentityassociation__datastore1(),
            new Object[][] {
                new Object[] {
               H00833_A366DataPackage
               }
               , new Object[] {
               H00836_A366DataPackage
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_informationbr_patientreentityassociation__default(),
            new Object[][] {
                new Object[] {
               H00832_A85BR_Information_ID
               }
               , new Object[] {
               H00834_A366DataPackage, H00834_A85BR_Information_ID
               }
               , new Object[] {
               H00835_A85BR_Information_ID
               }
               , new Object[] {
               H00837_A366DataPackage, H00837_A85BR_Information_ID
               }
               , new Object[] {
               H00838_A366DataPackage, H00838_A85BR_Information_ID
               }
               , new Object[] {
               H00839_A366DataPackage, H00839_A85BR_Information_ID
               }
               , new Object[] {
               H008310_A366DataPackage, H008310_A85BR_Information_ID
               }
               , new Object[] {
               H008311_A366DataPackage, H008311_A85BR_Information_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV36GXLvl30 ;
      private short AV39GXLvl65 ;
      private short nGXWrapped ;
      private int edtavAddedkeylistxml_Visible ;
      private int edtavNotaddedkeylistxml_Visible ;
      private int edtavAddeddsclistxml_Visible ;
      private int edtavNotaddeddsclistxml_Visible ;
      private int AV15i ;
      private int AV42GXV1 ;
      private int AV44GXV2 ;
      private int AV46GXV3 ;
      private int AV48GXV4 ;
      private int AV50GXV5 ;
      private int AV51GXV6 ;
      private int AV53GXV8 ;
      private int AV27InsertIndex ;
      private int AV54GXV9 ;
      private int AV55GXV10 ;
      private int AV56GXV11 ;
      private int idxLst ;
      private long AV8BR_Information_ID ;
      private long wcpOAV8BR_Information_ID ;
      private long A85BR_Information_ID ;
      private long AV33tNum ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablefullcontent_Internalname ;
      private String divTablenotassociated_Internalname ;
      private String lblNotassociatedrecordstitle_Internalname ;
      private String lblNotassociatedrecordstitle_Jsonclick ;
      private String lstavNotassociatedrecords_Internalname ;
      private String TempTags ;
      private String lstavNotassociatedrecords_Jsonclick ;
      private String divUnnamedtableassociationbuttons_Internalname ;
      private String sImgUrl ;
      private String imgImageassociateall_Internalname ;
      private String imgImageassociateall_Jsonclick ;
      private String imgImageassociateselected_Internalname ;
      private String imgImageassociateselected_Jsonclick ;
      private String imgImagedisassociateselected_Internalname ;
      private String imgImagedisassociateselected_Jsonclick ;
      private String imgImagedisassociateall_Internalname ;
      private String imgImagedisassociateall_Jsonclick ;
      private String divTableassociated_Internalname ;
      private String lblAssociatedrecordstitle_Internalname ;
      private String lblAssociatedrecordstitle_Jsonclick ;
      private String lstavAssociatedrecords_Internalname ;
      private String lstavAssociatedrecords_Jsonclick ;
      private String bttBtnconfirm_Internalname ;
      private String bttBtnconfirm_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavAddedkeylistxml_Internalname ;
      private String edtavNotaddedkeylistxml_Internalname ;
      private String edtavAddeddsclistxml_Internalname ;
      private String edtavNotaddeddsclistxml_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV28IsManager ;
      private bool GXt_boolean1 ;
      private bool AV11Exist ;
      private bool AV13Success ;
      private String AV17AddedKeyListXml ;
      private String AV18NotAddedKeyListXml ;
      private String AV19AddedDscListXml ;
      private String AV20NotAddedDscListXml ;
      private String A366DataPackage ;
      private String AV9DataPackage ;
      private String AV26NotAssociatedRecords ;
      private String AV25AssociatedRecords ;
      private String AV29tResult ;
      private String AV14Description ;
      private IGxSession AV30websession ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXListbox lstavNotassociatedrecords ;
      private GXListbox lstavAssociatedrecords ;
      private IDataStoreProvider pr_default ;
      private long[] H00832_A85BR_Information_ID ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] H00833_A366DataPackage ;
      private String[] H00834_A366DataPackage ;
      private long[] H00834_A85BR_Information_ID ;
      private long[] H00835_A85BR_Information_ID ;
      private String[] H00836_A366DataPackage ;
      private String[] H00837_A366DataPackage ;
      private long[] H00837_A85BR_Information_ID ;
      private String[] H00838_A366DataPackage ;
      private long[] H00838_A85BR_Information_ID ;
      private String[] H00839_A366DataPackage ;
      private long[] H00839_A85BR_Information_ID ;
      private String[] H008310_A366DataPackage ;
      private long[] H008310_A85BR_Information_ID ;
      private String[] H008311_A366DataPackage ;
      private long[] H008311_A85BR_Information_ID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10HTTPRequest ;
      private GxSimpleCollection<String> AV21AddedKeyList ;
      private GxSimpleCollection<String> AV23AddedDscList ;
      private GxSimpleCollection<String> AV22NotAddedKeyList ;
      private GxSimpleCollection<String> AV24NotAddedDscList ;
      private GxSimpleCollection<String> AV32tDataPackage ;
      private GXBaseCollection<SdtMessages_Message> AV52GXV7 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private SdtBR_PatientReEntity AV12BR_PatientReEntity ;
      private SdtMessages_Message AV16Message ;
      private SdtSDT_MicroUserInfo AV31tSDT_MicroUserInfo ;
   }

   public class br_informationbr_patientreentityassociation__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00836( IGxContext context ,
                                             String A366DataPackage ,
                                             GxSimpleCollection<String> AV32tDataPackage ,
                                             bool AV28IsManager )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [DataPackage] FROM dbo.[BAS_DataPackage] WITH (NOLOCK)";
         if ( ! AV28IsManager )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV32tDataPackage, "[DataPackage] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV32tDataPackage, "[DataPackage] IN (", ")") + ")";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [DataPackage]";
         GXv_Object2[0] = scmdbuf;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 1 :
                     return conditional_H00836(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (bool)dynConstraints[2] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00833 ;
          prmH00833 = new Object[] {
          } ;
          Object[] prmH00836 ;
          prmH00836 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H00833", "SELECT [DataPackage] FROM dbo.[BAS_DataPackage] WITH (NOLOCK) ORDER BY [DataPackage] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00833,100,0,true,false )
             ,new CursorDef("H00836", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00836,100,0,true,false )
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
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class br_informationbr_patientreentityassociation__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmH00832 ;
        prmH00832 = new Object[] {
        new Object[] {"@AV8BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmH00834 ;
        prmH00834 = new Object[] {
        new Object[] {"@AV8BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmH00835 ;
        prmH00835 = new Object[] {
        new Object[] {"@AV8BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmH00837 ;
        prmH00837 = new Object[] {
        new Object[] {"@AV8BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmH00838 ;
        prmH00838 = new Object[] {
        new Object[] {"@AV8BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@AV9DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmH00839 ;
        prmH00839 = new Object[] {
        new Object[] {"@AV8BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@AV9DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmH008310 ;
        prmH008310 = new Object[] {
        new Object[] {"@AV8BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@AV9DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmH008311 ;
        prmH008311 = new Object[] {
        new Object[] {"@AV8BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@AV9DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H00832", "SELECT [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV8BR_Information_ID ORDER BY [BR_Information_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00832,1,0,false,true )
           ,new CursorDef("H00834", "SELECT [DataPackage], [BR_Information_ID] FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV8BR_Information_ID and [DataPackage] = @DataPackage ORDER BY [BR_Information_ID], [DataPackage] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00834,1,0,false,true )
           ,new CursorDef("H00835", "SELECT [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV8BR_Information_ID ORDER BY [BR_Information_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00835,1,0,false,true )
           ,new CursorDef("H00837", "SELECT [DataPackage], [BR_Information_ID] FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV8BR_Information_ID and [DataPackage] = @DataPackage ORDER BY [BR_Information_ID], [DataPackage] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00837,1,0,false,true )
           ,new CursorDef("H00838", "SELECT [DataPackage], [BR_Information_ID] FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV8BR_Information_ID and [DataPackage] = @AV9DataPackage ORDER BY [BR_Information_ID], [DataPackage] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00838,1,0,false,true )
           ,new CursorDef("H00839", "SELECT [DataPackage], [BR_Information_ID] FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV8BR_Information_ID and [DataPackage] = @AV9DataPackage ORDER BY [BR_Information_ID], [DataPackage] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00839,1,0,false,true )
           ,new CursorDef("H008310", "SELECT [DataPackage], [BR_Information_ID] FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV8BR_Information_ID and [DataPackage] = @AV9DataPackage ORDER BY [BR_Information_ID], [DataPackage] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008310,1,0,false,true )
           ,new CursorDef("H008311", "SELECT [DataPackage], [BR_Information_ID] FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV8BR_Information_ID and [DataPackage] = @AV9DataPackage ORDER BY [BR_Information_ID], [DataPackage] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008311,1,0,false,true )
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
              return;
           case 1 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 7 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     short sIdx ;
     switch ( cursor )
     {
           case 0 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
     }
  }

}

}
