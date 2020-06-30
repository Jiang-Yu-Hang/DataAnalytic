/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:48:36.33
*/
gx.evt.autoSkip = false;
gx.define('br_encounterlist', false, function () {
   this.ServerClass =  "br_encounterlist" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV75TFview_NE_Status_Sels=gx.fn.getControlValue("vTFVIEW_NE_STATUS_SELS") ;
      this.AV107Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV92tAllBR_EncounterID=gx.fn.getControlValue("vTALLBR_ENCOUNTERID") ;
      this.AV79view_NE_Status=gx.fn.getIntegerValue("vVIEW_NE_STATUS",',') ;
      this.AV85IsInsert=gx.fn.getControlValue("vISINSERT") ;
      this.AV65tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE") ;
      this.AV75TFview_NE_Status_Sels=gx.fn.getControlValue("vTFVIEW_NE_STATUS_SELS") ;
      this.AV107Pgmname=gx.fn.getControlValue("vPGMNAME") ;
   };
   this.Validv_View_ne_admitdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vVIEW_NE_ADMITDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV64view_NE_AdmitDate)==0) || new gx.date.gxdate( this.AV64view_NE_AdmitDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩焩iew_NE_Admit Date瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Endview_ne_admitdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vENDVIEW_NE_ADMITDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV104endview_NE_AdmitDate)==0) || new gx.date.gxdate( this.AV104endview_NE_AdmitDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩焑ndview_NE_Admit Date瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Tview_ne_status=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTVIEW_NE_STATUS");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Validv_Admitdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vADMITDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV103AdmitDate)==0) || new gx.date.gxdate( this.AV103AdmitDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烝dmit Date瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV13OrderedBy == 1 )
      {
         this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 2 )
      {
         this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 3 )
      {
         this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 4 )
      {
         this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 5 )
      {
         this.DDO_VIEW_NE_STATUSContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 6 )
      {
         this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 7 )
      {
         this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV13OrderedBy == 8 )
      {
         this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus =  (this.AV14OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus =  ""  ;
      this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus =  ""  ;
      this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus =  ""  ;
      this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus =  ""  ;
      this.DDO_VIEW_NE_STATUSContainer.SortedStatus =  ""  ;
      this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus =  ""  ;
      this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus =  ""  ;
      this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus =  ""  ;
   };
   this.e32ag2_client=function()
   {
      this.clearMessages();
      this.AV100view_NE_EncounterID_Selected = gx.num.trunc( this.A549view_NE_EncounterID ,0) ;
      this.DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.Confirm() ;
      this.refreshOutputs([{av:'AV100view_NE_EncounterID_Selected',fld:'vVIEW_NE_ENCOUNTERID_SELECTED',pic:'ZZZZZZZZZZZZZZZZZ9'}]);
      return gx.$.Deferred().resolve();
   };
   this.e34ag1_client=function()
   {
      this.clearMessages();
      if ( this.DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.Result == "Yes" )
      {
         this.s172_client();
      }
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.s172_client=function()
   {
   };
   this.e30ag1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e31ag1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e33ag2_client=function()
   {
      this.clearMessages();
      this.call("br_informationview.aspx", [this.A558view_NE_Information_ID, "br_encounter"]);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e11ag2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12ag2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13ag2_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_NE_ENCOUNTERID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14ag2_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_NE_INFORMATION_PATIENTNO.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15ag2_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_NE_DEPARTMENT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16ag2_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_NE_ENCTYPE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e17ag2_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_NE_STATUS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e18ag2_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_NE_ISRANDAPPROVE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e19ag2_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_NE_ISRANDRECHECK.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e20ag2_client=function()
   {
      return this.executeServerEvent("DDO_VIEW_NE_ISUPDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e21ag2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE", false, null, true, true);
   };
   this.e22ag2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE", false, null, true, true);
   };
   this.e23ag2_client=function()
   {
      return this.executeServerEvent("VSBR_ENCOUNTERID.CONTROLVALUECHANGING", true, null, false, true);
   };
   this.e27ag2_client=function()
   {
      return this.executeServerEvent("'DOTEST'", true, arguments[0], false, false);
   };
   this.e28ag2_client=function()
   {
      return this.executeServerEvent("'DOADD'", true, arguments[0], false, false);
   };
   this.e29ag2_client=function()
   {
      return this.executeServerEvent("VIEW_NE_ENCOUNTERID.CLICK", true, arguments[0], false, false);
   };
   this.e35ag2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e36ag2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,61,62,63,66,67,68,69,70,71,72,73,74,75,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,95,96,97,99,101,103,105,107,109,111,113,115,116,117,118,123,128,133,134,135,136,137,138,139,140,141,142,143];
   this.GXLastCtrlId =143;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",76,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_encounterlist",[],false,1,true,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Deleteencounter","vDELETEENCOUNTER",77,0,"px",17,"px","e32ag2_client","","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(549,78,"VIEW_NE_ENCOUNTERID","","","view_NE_EncounterID","int",0,"px",18,18,"right","e29ag2_client",[],549,"view_NE_EncounterID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(559,79,"VIEW_NE_INFORMATION_PATIENTNO","","","view_NE_Information_PatientNo","svchar",0,"px",4000,80,"left","e33ag2_client",[],559,"view_NE_Information_PatientNo",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit("Patientno",80,"vPATIENTNO","鎮ｈ€呯紪鍙?,"","PatientNo","svchar",0,"px",4000,80,"left",null,[],"Patientno","PatientNo",false,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(550,81,"VIEW_NE_DEPARTMENT","","","view_NE_Department","svchar",0,"px",4000,80,"left",null,[],550,"view_NE_Department",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(551,82,"VIEW_NE_ENCTYPE","","","view_NE_ENCType","svchar",0,"px",4000,80,"left",null,[],551,"view_NE_ENCType",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit("Admitdate",83,"vADMITDATE","灏辫瘖/鍏ラ櫌鏃堕棿","","AdmitDate","date",0,"px",10,10,"right",null,[],"Admitdate","AdmitDate",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(552,84,"VIEW_NE_ADMITDATE","灏辫瘖/鍏ラ櫌鏃堕棿","","view_NE_AdmitDate","date",0,"px",10,10,"right",null,[],552,"view_NE_AdmitDate",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addComboBox(553,85,"VIEW_NE_STATUS","","view_NE_Status","int",null,0,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addCheckBox(555,86,"VIEW_NE_ISRANDAPPROVE","","","view_NE_IsRandApprove","boolean","true","false",null,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addCheckBox(554,87,"VIEW_NE_ISRANDRECHECK","","","view_NE_IsRandRecheck","boolean","true","false",null,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addCheckBox(556,88,"VIEW_NE_ISUPDATE","","","view_NE_IsUpdate","boolean","true","false",null,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(557,89,"VIEW_NE_TENANTTENANTCODE","view_NE_Tenant Tenant Code","","view_NE_TenantTenantCode","svchar",0,"px",20,20,"left",null,[],557,"view_NE_TenantTenantCode",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(558,90,"VIEW_NE_INFORMATION_ID","view_NE_Information_ID","","view_NE_Information_ID","int",0,"px",18,18,"right",null,[],558,"view_NE_Information_ID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_TABLEHEADERContainer = gx.uc.getNew(this, 10, 0, "BootstrapPanel", "DVPANEL_TABLEHEADERContainer", "Dvpanel_tableheader", "DVPANEL_TABLEHEADER");
   var DVPANEL_TABLEHEADERContainer = this.DVPANEL_TABLEHEADERContainer;
   DVPANEL_TABLEHEADERContainer.setProp("Class", "Class", "", "char");
   DVPANEL_TABLEHEADERContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_TABLEHEADERContainer.setProp("Width", "Width", "100%", "str");
   DVPANEL_TABLEHEADERContainer.setProp("Height", "Height", "100", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Cls", "Cls", "PanelNoHeader", "str");
   DVPANEL_TABLEHEADERContainer.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Title", "Title", "閫夐」", "str");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_TABLEHEADERContainer.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_TABLEHEADERContainer.setProp("Visible", "Visible", true, "bool");
   DVPANEL_TABLEHEADERContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_TABLEHEADERContainer);
   this.DVPANEL_UNNAMEDTABLE1Container = gx.uc.getNew(this, 59, 22, "BootstrapPanel", "DVPANEL_UNNAMEDTABLE1Container", "Dvpanel_unnamedtable1", "DVPANEL_UNNAMEDTABLE1");
   var DVPANEL_UNNAMEDTABLE1Container = this.DVPANEL_UNNAMEDTABLE1Container;
   DVPANEL_UNNAMEDTABLE1Container.setProp("Class", "Class", "", "char");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Width", "Width", "100%", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Height", "Height", "100", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Cls", "Cls", "PanelNoHeader", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Title", "Title", "", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Visible", "Visible", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_UNNAMEDTABLE1Container);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 94, 22, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
   var GRIDPAGINATIONBARContainer = this.GRIDPAGINATIONBARContainer;
   GRIDPAGINATIONBARContainer.setProp("Enabled", "Enabled", true, "boolean");
   GRIDPAGINATIONBARContainer.setProp("Class", "Class", "PaginationBar", "str");
   GRIDPAGINATIONBARContainer.setProp("ShowFirst", "Showfirst", false, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowPrevious", "Showprevious", true, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowNext", "Shownext", true, "bool");
   GRIDPAGINATIONBARContainer.setProp("ShowLast", "Showlast", false, "bool");
   GRIDPAGINATIONBARContainer.setProp("PagesToShow", "Pagestoshow", 5, "num");
   GRIDPAGINATIONBARContainer.setProp("PagingButtonsPosition", "Pagingbuttonsposition", "Right", "str");
   GRIDPAGINATIONBARContainer.setProp("PagingCaptionPosition", "Pagingcaptionposition", "Left", "str");
   GRIDPAGINATIONBARContainer.setProp("EmptyGridClass", "Emptygridclass", "PaginationBarEmptyGrid", "str");
   GRIDPAGINATIONBARContainer.setProp("SelectedPage", "Selectedpage", "", "char");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageSelector", "Rowsperpageselector", true, "bool");
   GRIDPAGINATIONBARContainer.setDynProp("RowsPerPageSelectedValue", "Rowsperpageselectedvalue", 10, "num");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageOptions", "Rowsperpageoptions", "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50", "str");
   GRIDPAGINATIONBARContainer.setProp("First", "First", "First", "str");
   GRIDPAGINATIONBARContainer.setProp("Previous", "Previous", "WWP_PagingPreviousCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("Next", "Next", "WWP_PagingNextCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("Last", "Last", "Last", "str");
   GRIDPAGINATIONBARContainer.setProp("Caption", "Caption", "<CURRENT_PAGE>椤?<TOTAL_PAGES>椤?璁板綍锛?TOTAL_RECORDS>鏉?, "str");
   GRIDPAGINATIONBARContainer.setProp("EmptyGridCaption", "Emptygridcaption", "WWP_PagingEmptyGridCaption", "str");
   GRIDPAGINATIONBARContainer.setProp("RowsPerPageCaption", "Rowsperpagecaption", "WWP_PagingRowsPerPage", "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV58GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV58GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV58GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV60GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV60GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV60GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV59GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV59GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV59GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11ag2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12ag2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_VIEW_NE_ENCOUNTERIDContainer = gx.uc.getNew(this, 98, 22, "BootstrapDropDownOptions", "DDO_VIEW_NE_ENCOUNTERIDContainer", "Ddo_view_ne_encounterid", "DDO_VIEW_NE_ENCOUNTERID");
   var DDO_VIEW_NE_ENCOUNTERIDContainer = this.DDO_VIEW_NE_ENCOUNTERIDContainer;
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_NE_ENCOUNTERIDContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_NE_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_VIEW_NE_ENCOUNTERIDContainer.addV2CFunction('AV18view_NE_EncounterIDTitleFilterData', "vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_NE_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV18view_NE_EncounterIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA",UC.ParentObject.AV18view_NE_EncounterIDTitleFilterData); });
   DDO_VIEW_NE_ENCOUNTERIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_NE_ENCOUNTERIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_NE_ENCOUNTERIDContainer.addEventHandler("OnOptionClicked", this.e13ag2_client);
   this.setUserControl(DDO_VIEW_NE_ENCOUNTERIDContainer);
   this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer = gx.uc.getNew(this, 100, 22, "BootstrapDropDownOptions", "DDO_VIEW_NE_INFORMATION_PATIENTNOContainer", "Ddo_view_ne_information_patientno", "DDO_VIEW_NE_INFORMATION_PATIENTNO");
   var DDO_VIEW_NE_INFORMATION_PATIENTNOContainer = this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer;
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("DataListProc", "Datalistproc", "BR_EncounterListGetFilterData", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.addV2CFunction('AV22view_NE_Information_PatientNoTitleFilterData', "vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV22view_NE_Information_PatientNoTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA",UC.ParentObject.AV22view_NE_Information_PatientNoTitleFilterData); });
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.addEventHandler("OnOptionClicked", this.e14ag2_client);
   this.setUserControl(DDO_VIEW_NE_INFORMATION_PATIENTNOContainer);
   this.DDO_VIEW_NE_DEPARTMENTContainer = gx.uc.getNew(this, 102, 22, "BootstrapDropDownOptions", "DDO_VIEW_NE_DEPARTMENTContainer", "Ddo_view_ne_department", "DDO_VIEW_NE_DEPARTMENT");
   var DDO_VIEW_NE_DEPARTMENTContainer = this.DDO_VIEW_NE_DEPARTMENTContainer;
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_NE_DEPARTMENTContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("DataListProc", "Datalistproc", "BR_EncounterListGetFilterData", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_NE_DEPARTMENTContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_NE_DEPARTMENTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_VIEW_NE_DEPARTMENTContainer.addV2CFunction('AV26view_NE_DepartmentTitleFilterData', "vVIEW_NE_DEPARTMENTTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_NE_DEPARTMENTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26view_NE_DepartmentTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_NE_DEPARTMENTTITLEFILTERDATA",UC.ParentObject.AV26view_NE_DepartmentTitleFilterData); });
   DDO_VIEW_NE_DEPARTMENTContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_NE_DEPARTMENTContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_NE_DEPARTMENTContainer.addEventHandler("OnOptionClicked", this.e15ag2_client);
   this.setUserControl(DDO_VIEW_NE_DEPARTMENTContainer);
   this.DDO_VIEW_NE_ENCTYPEContainer = gx.uc.getNew(this, 104, 22, "BootstrapDropDownOptions", "DDO_VIEW_NE_ENCTYPEContainer", "Ddo_view_ne_enctype", "DDO_VIEW_NE_ENCTYPE");
   var DDO_VIEW_NE_ENCTYPEContainer = this.DDO_VIEW_NE_ENCTYPEContainer;
   DDO_VIEW_NE_ENCTYPEContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_NE_ENCTYPEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("DataListProc", "Datalistproc", "BR_EncounterListGetFilterData", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_NE_ENCTYPEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_NE_ENCTYPEContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_NE_ENCTYPEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_VIEW_NE_ENCTYPEContainer.addV2CFunction('AV30view_NE_ENCTypeTitleFilterData', "vVIEW_NE_ENCTYPETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_NE_ENCTYPEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV30view_NE_ENCTypeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_NE_ENCTYPETITLEFILTERDATA",UC.ParentObject.AV30view_NE_ENCTypeTitleFilterData); });
   DDO_VIEW_NE_ENCTYPEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_NE_ENCTYPEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_NE_ENCTYPEContainer.addEventHandler("OnOptionClicked", this.e16ag2_client);
   this.setUserControl(DDO_VIEW_NE_ENCTYPEContainer);
   this.DDO_VIEW_NE_STATUSContainer = gx.uc.getNew(this, 106, 22, "BootstrapDropDownOptions", "DDO_VIEW_NE_STATUSContainer", "Ddo_view_ne_status", "DDO_VIEW_NE_STATUS");
   var DDO_VIEW_NE_STATUSContainer = this.DDO_VIEW_NE_STATUSContainer;
   DDO_VIEW_NE_STATUSContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_NE_STATUSContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_NE_STATUSContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_NE_STATUSContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_NE_STATUSContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_NE_STATUSContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_VIEW_NE_STATUSContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_VIEW_NE_STATUSContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_VIEW_NE_STATUSContainer.setProp("DataListType", "Datalisttype", "FixedValues", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", true, "bool");
   DDO_VIEW_NE_STATUSContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "1:褰曞叆涓?2:寰呭垵瀹?3:鍒濆涓嶉€氳繃,4:寰呭瀹?5:澶嶅涓嶉€氳繃,6:瀹屾垚", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_VIEW_NE_STATUSContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_VIEW_NE_STATUSContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_FilterSelected", "str");
   DDO_VIEW_NE_STATUSContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_NE_STATUSContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_NE_STATUSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_VIEW_NE_STATUSContainer.addV2CFunction('AV40view_NE_StatusTitleFilterData', "vVIEW_NE_STATUSTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_NE_STATUSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV40view_NE_StatusTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_NE_STATUSTITLEFILTERDATA",UC.ParentObject.AV40view_NE_StatusTitleFilterData); });
   DDO_VIEW_NE_STATUSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_NE_STATUSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_NE_STATUSContainer.addEventHandler("OnOptionClicked", this.e17ag2_client);
   this.setUserControl(DDO_VIEW_NE_STATUSContainer);
   this.DDO_VIEW_NE_ISRANDAPPROVEContainer = gx.uc.getNew(this, 108, 22, "BootstrapDropDownOptions", "DDO_VIEW_NE_ISRANDAPPROVEContainer", "Ddo_view_ne_israndapprove", "DDO_VIEW_NE_ISRANDAPPROVE");
   var DDO_VIEW_NE_ISRANDAPPROVEContainer = this.DDO_VIEW_NE_ISRANDAPPROVEContainer;
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("DataListType", "Datalisttype", "FixedValues", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "1:WWP_TSChecked,2:WWP_TSUnChecked", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_NE_ISRANDAPPROVEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_VIEW_NE_ISRANDAPPROVEContainer.addV2CFunction('AV48view_NE_IsRandApproveTitleFilterData', "vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_NE_ISRANDAPPROVEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV48view_NE_IsRandApproveTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA",UC.ParentObject.AV48view_NE_IsRandApproveTitleFilterData); });
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_NE_ISRANDAPPROVEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_NE_ISRANDAPPROVEContainer.addEventHandler("OnOptionClicked", this.e18ag2_client);
   this.setUserControl(DDO_VIEW_NE_ISRANDAPPROVEContainer);
   this.DDO_VIEW_NE_ISRANDRECHECKContainer = gx.uc.getNew(this, 110, 22, "BootstrapDropDownOptions", "DDO_VIEW_NE_ISRANDRECHECKContainer", "Ddo_view_ne_israndrecheck", "DDO_VIEW_NE_ISRANDRECHECK");
   var DDO_VIEW_NE_ISRANDRECHECKContainer = this.DDO_VIEW_NE_ISRANDRECHECKContainer;
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("DataListType", "Datalisttype", "FixedValues", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "1:WWP_TSChecked,2:WWP_TSUnChecked", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_NE_ISRANDRECHECKContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_NE_ISRANDRECHECKContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_VIEW_NE_ISRANDRECHECKContainer.addV2CFunction('AV44view_NE_IsRandRecheckTitleFilterData', "vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_NE_ISRANDRECHECKContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44view_NE_IsRandRecheckTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA",UC.ParentObject.AV44view_NE_IsRandRecheckTitleFilterData); });
   DDO_VIEW_NE_ISRANDRECHECKContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_NE_ISRANDRECHECKContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_NE_ISRANDRECHECKContainer.addEventHandler("OnOptionClicked", this.e19ag2_client);
   this.setUserControl(DDO_VIEW_NE_ISRANDRECHECKContainer);
   this.DDO_VIEW_NE_ISUPDATEContainer = gx.uc.getNew(this, 112, 22, "BootstrapDropDownOptions", "DDO_VIEW_NE_ISUPDATEContainer", "Ddo_view_ne_isupdate", "DDO_VIEW_NE_ISUPDATE");
   var DDO_VIEW_NE_ISUPDATEContainer = this.DDO_VIEW_NE_ISUPDATEContainer;
   DDO_VIEW_NE_ISUPDATEContainer.setProp("Class", "Class", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setDynProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_VIEW_NE_ISUPDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("DataListType", "Datalisttype", "FixedValues", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "1:WWP_TSChecked,2:WWP_TSUnChecked", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_VIEW_NE_ISUPDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_VIEW_NE_ISUPDATEContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_VIEW_NE_ISUPDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_VIEW_NE_ISUPDATEContainer.addV2CFunction('AV52view_NE_IsUpdateTitleFilterData', "vVIEW_NE_ISUPDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_VIEW_NE_ISUPDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV52view_NE_IsUpdateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vVIEW_NE_ISUPDATETITLEFILTERDATA",UC.ParentObject.AV52view_NE_IsUpdateTitleFilterData); });
   DDO_VIEW_NE_ISUPDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_VIEW_NE_ISUPDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_VIEW_NE_ISUPDATEContainer.addEventHandler("OnOptionClicked", this.e20ag2_client);
   this.setUserControl(DDO_VIEW_NE_ISUPDATEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 114, 22, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
   var WORKWITHPLUSUTILITIES1Container = this.WORKWITHPLUSUTILITIES1Container;
   WORKWITHPLUSUTILITIES1Container.setProp("Class", "Class", "", "char");
   WORKWITHPLUSUTILITIES1Container.setProp("Enabled", "Enabled", true, "boolean");
   WORKWITHPLUSUTILITIES1Container.setProp("Width", "Width", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Height", "Height", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Visible", "Visible", true, "bool");
   WORKWITHPLUSUTILITIES1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(WORKWITHPLUSUTILITIES1Container);
   this.DVELOP_CONFIRMPANEL_BATCHRECHECKContainer = gx.uc.getNew(this, 131, 22, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_BATCHRECHECKContainer", "Dvelop_confirmpanel_batchrecheck", "DVELOP_CONFIRMPANEL_BATCHRECHECK");
   var DVELOP_CONFIRMPANEL_BATCHRECHECKContainer = this.DVELOP_CONFIRMPANEL_BATCHRECHECKContainer;
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("ConfirmationText", "Confirmationtext", "纭鎵归噺鎻愪氦澶嶅锛?, "str");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.addEventHandler("Close", this.e22ag2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_BATCHRECHECKContainer);
   this.DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer = gx.uc.getNew(this, 126, 22, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer", "Dvelop_confirmpanel_batchapprove", "DVELOP_CONFIRMPANEL_BATCHAPPROVE");
   var DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer = this.DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer;
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("ConfirmationText", "Confirmationtext", "纭鎵归噺鎻愪氦鍒濆锛?, "str");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.addEventHandler("Close", this.e21ag2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer);
   this.DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer = gx.uc.getNew(this, 121, 22, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer", "Dvelop_confirmpanel_deleteencounter", "DVELOP_CONFIRMPANEL_DELETEENCOUNTER");
   var DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer = this.DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer;
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("ConfirmationText", "Confirmationtext", "纭鍒犻櫎锛?, "str");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.addEventHandler("Close", this.e34ag1_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"HTML_DVPANEL_TABLEHEADER",grid:0};
   GXValidFnc[12]={ id: 12, fld:"LAYOUT_TABLEHEADER",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"TABLEHEADER",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"TABLEACTIONS",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id:22 ,lvl:0,type:"svchar",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:'e23ag2_client',rgrid:[this.GridContainer],fld:"vSBR_ENCOUNTERID",gxz:"ZV17sBR_EncounterID",gxold:"OV17sBR_EncounterID",gxvar:"AV17sBR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17sBR_EncounterID=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV17sBR_EncounterID=Value},v2c:function(){gx.fn.setControlValue("vSBR_ENCOUNTERID",gx.O.AV17sBR_EncounterID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17sBR_EncounterID=this.val()},val:function(){return gx.fn.getControlValue("vSBR_ENCOUNTERID")},nac:gx.falseFn};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_INFORMATION_PATIENTNO",gxz:"ZV15BR_Information_PatientNo",gxold:"OV15BR_Information_PatientNo",gxvar:"AV15BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("vBR_INFORMATION_PATIENTNO",gx.O.AV15BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("vBR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id:30 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_View_ne_admitdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vVIEW_NE_ADMITDATE",gxz:"ZV64view_NE_AdmitDate",gxold:"OV64view_NE_AdmitDate",gxvar:"AV64view_NE_AdmitDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[30],ip:[30],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV64view_NE_AdmitDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV64view_NE_AdmitDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vVIEW_NE_ADMITDATE",gx.O.AV64view_NE_AdmitDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV64view_NE_AdmitDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vVIEW_NE_ADMITDATE")},nac:gx.falseFn};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Endview_ne_admitdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vENDVIEW_NE_ADMITDATE",gxz:"ZV104endview_NE_AdmitDate",gxold:"OV104endview_NE_AdmitDate",gxvar:"AV104endview_NE_AdmitDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[34],ip:[34],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV104endview_NE_AdmitDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV104endview_NE_AdmitDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vENDVIEW_NE_ADMITDATE",gx.O.AV104endview_NE_AdmitDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV104endview_NE_AdmitDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vENDVIEW_NE_ADMITDATE")},nac:gx.falseFn};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tview_ne_status,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTVIEW_NE_STATUS",gxz:"ZV102tview_NE_Status",gxold:"OV102tview_NE_Status",gxvar:"AV102tview_NE_Status",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV102tview_NE_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV102tview_NE_Status=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vTVIEW_NE_STATUS",gx.O.AV102tview_NE_Status);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.AV102tview_NE_Status=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTVIEW_NE_STATUS",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 39 , function() {
   });
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"UNNAMEDTABLE2",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"boolean",len:1,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vVIEW_NE_ISRANDAPPROVE",gxz:"ZV80view_NE_IsRandApprove",gxold:"OV80view_NE_IsRandApprove",gxvar:"AV80view_NE_IsRandApprove",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"checkbox",v2v:function(Value){if(Value!==undefined)gx.O.AV80view_NE_IsRandApprove=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV80view_NE_IsRandApprove=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setCheckBoxValue("vVIEW_NE_ISRANDAPPROVE",gx.O.AV80view_NE_IsRandApprove,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV80view_NE_IsRandApprove=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vVIEW_NE_ISRANDAPPROVE")},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"boolean",len:1,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vVIEW_NE_ISRANDRECHECK",gxz:"ZV81view_NE_IsRandRecheck",gxold:"OV81view_NE_IsRandRecheck",gxvar:"AV81view_NE_IsRandRecheck",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"checkbox",v2v:function(Value){if(Value!==undefined)gx.O.AV81view_NE_IsRandRecheck=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV81view_NE_IsRandRecheck=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setCheckBoxValue("vVIEW_NE_ISRANDRECHECK",gx.O.AV81view_NE_IsRandRecheck,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV81view_NE_IsRandRecheck=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vVIEW_NE_ISRANDRECHECK")},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"boolean",len:1,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vVIEW_NE_ISUPDATE",gxz:"ZV82view_NE_IsUpdate",gxold:"OV82view_NE_IsUpdate",gxvar:"AV82view_NE_IsUpdate",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"checkbox",v2v:function(Value){if(Value!==undefined)gx.O.AV82view_NE_IsUpdate=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV82view_NE_IsUpdate=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setCheckBoxValue("vVIEW_NE_ISUPDATE",gx.O.AV82view_NE_IsUpdate,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV82view_NE_IsUpdate=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vVIEW_NE_ISUPDATE")},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id: 58, fld:"HTML_DVPANEL_UNNAMEDTABLE1",grid:0};
   GXValidFnc[61]={ id: 61, fld:"LAYOUT_UNNAMEDTABLE1",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"BTNBATCHAPPROVE",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"BTNBATCHRECHECK",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[74]={ id: 74, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"",grid:0};
   GXValidFnc[77]={ id:77 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETEENCOUNTER",gxz:"ZV98deleteEncounter",gxold:"OV98deleteEncounter",gxvar:"AV98deleteEncounter",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV98deleteEncounter=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV98deleteEncounter=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETEENCOUNTER",row || gx.fn.currentGridRowImpl(76),gx.O.AV98deleteEncounter,gx.O.AV125Deleteencounter_GXI)},c2v:function(){gx.O.AV125Deleteencounter_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV98deleteEncounter=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETEENCOUNTER",row || gx.fn.currentGridRowImpl(76))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETEENCOUNTER_GXI",row || gx.fn.currentGridRowImpl(76))}, gxvar_GXI:'AV125Deleteencounter_GXI',nac:gx.falseFn,evt:"e32ag2_client"};
   GXValidFnc[78]={ id:78 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_ENCOUNTERID",gxz:"Z549view_NE_EncounterID",gxold:"O549view_NE_EncounterID",gxvar:"A549view_NE_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A549view_NE_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z549view_NE_EncounterID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("VIEW_NE_ENCOUNTERID",row || gx.fn.currentGridRowImpl(76),gx.O.A549view_NE_EncounterID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A549view_NE_EncounterID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("VIEW_NE_ENCOUNTERID",row || gx.fn.currentGridRowImpl(76),',')},nac:gx.falseFn,evt:"e29ag2_client"};
   GXValidFnc[79]={ id:79 ,lvl:2,type:"svchar",len:4000,dec:0,sign:false,ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_INFORMATION_PATIENTNO",gxz:"Z559view_NE_Information_PatientNo",gxold:"O559view_NE_Information_PatientNo",gxvar:"A559view_NE_Information_PatientNo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A559view_NE_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z559view_NE_Information_PatientNo=Value},v2c:function(row){gx.fn.setGridControlValue("VIEW_NE_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(76),gx.O.A559view_NE_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A559view_NE_Information_PatientNo=this.val()},val:function(row){return gx.fn.getGridControlValue("VIEW_NE_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(76))},nac:gx.falseFn,evt:"e33ag2_client"};
   GXValidFnc[80]={ id:80 ,lvl:2,type:"svchar",len:4000,dec:0,sign:false,ro:0,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vPATIENTNO",gxz:"ZV83PatientNo",gxold:"OV83PatientNo",gxvar:"AV83PatientNo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.AV83PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV83PatientNo=Value},v2c:function(row){gx.fn.setGridControlValue("vPATIENTNO",row || gx.fn.currentGridRowImpl(76),gx.O.AV83PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV83PatientNo=this.val()},val:function(row){return gx.fn.getGridControlValue("vPATIENTNO",row || gx.fn.currentGridRowImpl(76))},nac:gx.falseFn};
   GXValidFnc[81]={ id:81 ,lvl:2,type:"svchar",len:4000,dec:0,sign:false,ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_DEPARTMENT",gxz:"Z550view_NE_Department",gxold:"O550view_NE_Department",gxvar:"A550view_NE_Department",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A550view_NE_Department=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z550view_NE_Department=Value},v2c:function(row){gx.fn.setGridControlValue("VIEW_NE_DEPARTMENT",row || gx.fn.currentGridRowImpl(76),gx.O.A550view_NE_Department,0)},c2v:function(){if(this.val()!==undefined)gx.O.A550view_NE_Department=this.val()},val:function(row){return gx.fn.getGridControlValue("VIEW_NE_DEPARTMENT",row || gx.fn.currentGridRowImpl(76))},nac:gx.falseFn};
   GXValidFnc[82]={ id:82 ,lvl:2,type:"svchar",len:4000,dec:0,sign:false,ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_ENCTYPE",gxz:"Z551view_NE_ENCType",gxold:"O551view_NE_ENCType",gxvar:"A551view_NE_ENCType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A551view_NE_ENCType=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z551view_NE_ENCType=Value},v2c:function(row){gx.fn.setGridControlValue("VIEW_NE_ENCTYPE",row || gx.fn.currentGridRowImpl(76),gx.O.A551view_NE_ENCType,0)},c2v:function(){if(this.val()!==undefined)gx.O.A551view_NE_ENCType=this.val()},val:function(row){return gx.fn.getGridControlValue("VIEW_NE_ENCTYPE",row || gx.fn.currentGridRowImpl(76))},nac:gx.falseFn};
   GXValidFnc[83]={ id:83 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:0,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:this.Validv_Admitdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vADMITDATE",gxz:"ZV103AdmitDate",gxold:"OV103AdmitDate",gxvar:"AV103AdmitDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[83],ip:[83],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV103AdmitDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV103AdmitDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("vADMITDATE",row || gx.fn.currentGridRowImpl(76),gx.O.AV103AdmitDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.AV103AdmitDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("vADMITDATE",row || gx.fn.currentGridRowImpl(76))},nac:gx.falseFn};
   GXValidFnc[84]={ id:84 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_ADMITDATE",gxz:"Z552view_NE_AdmitDate",gxold:"O552view_NE_AdmitDate",gxvar:"A552view_NE_AdmitDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A552view_NE_AdmitDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z552view_NE_AdmitDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("VIEW_NE_ADMITDATE",row || gx.fn.currentGridRowImpl(76),gx.O.A552view_NE_AdmitDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A552view_NE_AdmitDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("VIEW_NE_ADMITDATE",row || gx.fn.currentGridRowImpl(76))},nac:gx.falseFn};
   GXValidFnc[85]={ id:85 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_STATUS",gxz:"Z553view_NE_Status",gxold:"O553view_NE_Status",gxvar:"A553view_NE_Status",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A553view_NE_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z553view_NE_Status=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridComboBoxValue("VIEW_NE_STATUS",row || gx.fn.currentGridRowImpl(76),gx.O.A553view_NE_Status);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A553view_NE_Status=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("VIEW_NE_STATUS",row || gx.fn.currentGridRowImpl(76),',')},nac:gx.falseFn};
   GXValidFnc[86]={ id:86 ,lvl:2,type:"boolean",len:1,dec:0,sign:false,ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_ISRANDAPPROVE",gxz:"Z555view_NE_IsRandApprove",gxold:"O555view_NE_IsRandApprove",gxvar:"A555view_NE_IsRandApprove",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A555view_NE_IsRandApprove=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z555view_NE_IsRandApprove=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("VIEW_NE_ISRANDAPPROVE",row || gx.fn.currentGridRowImpl(76),gx.O.A555view_NE_IsRandApprove,true)},c2v:function(){if(this.val()!==undefined)gx.O.A555view_NE_IsRandApprove=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("VIEW_NE_ISRANDAPPROVE",row || gx.fn.currentGridRowImpl(76))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[87]={ id:87 ,lvl:2,type:"boolean",len:1,dec:0,sign:false,ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_ISRANDRECHECK",gxz:"Z554view_NE_IsRandRecheck",gxold:"O554view_NE_IsRandRecheck",gxvar:"A554view_NE_IsRandRecheck",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A554view_NE_IsRandRecheck=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z554view_NE_IsRandRecheck=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("VIEW_NE_ISRANDRECHECK",row || gx.fn.currentGridRowImpl(76),gx.O.A554view_NE_IsRandRecheck,true)},c2v:function(){if(this.val()!==undefined)gx.O.A554view_NE_IsRandRecheck=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("VIEW_NE_ISRANDRECHECK",row || gx.fn.currentGridRowImpl(76))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[88]={ id:88 ,lvl:2,type:"boolean",len:1,dec:0,sign:false,ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_ISUPDATE",gxz:"Z556view_NE_IsUpdate",gxold:"O556view_NE_IsUpdate",gxvar:"A556view_NE_IsUpdate",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A556view_NE_IsUpdate=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z556view_NE_IsUpdate=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("VIEW_NE_ISUPDATE",row || gx.fn.currentGridRowImpl(76),gx.O.A556view_NE_IsUpdate,true)},c2v:function(){if(this.val()!==undefined)gx.O.A556view_NE_IsUpdate=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("VIEW_NE_ISUPDATE",row || gx.fn.currentGridRowImpl(76))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[89]={ id:89 ,lvl:2,type:"svchar",len:20,dec:0,sign:false,ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_TENANTTENANTCODE",gxz:"Z557view_NE_TenantTenantCode",gxold:"O557view_NE_TenantTenantCode",gxvar:"A557view_NE_TenantTenantCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A557view_NE_TenantTenantCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z557view_NE_TenantTenantCode=Value},v2c:function(row){gx.fn.setGridControlValue("VIEW_NE_TENANTTENANTCODE",row || gx.fn.currentGridRowImpl(76),gx.O.A557view_NE_TenantTenantCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A557view_NE_TenantTenantCode=this.val()},val:function(row){return gx.fn.getGridControlValue("VIEW_NE_TENANTTENANTCODE",row || gx.fn.currentGridRowImpl(76))},nac:gx.falseFn};
   GXValidFnc[90]={ id:90 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZ9",ro:1,isacc:0,grid:76,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"VIEW_NE_INFORMATION_ID",gxz:"Z558view_NE_Information_ID",gxold:"O558view_NE_Information_ID",gxvar:"A558view_NE_Information_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A558view_NE_Information_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z558view_NE_Information_ID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("VIEW_NE_INFORMATION_ID",row || gx.fn.currentGridRowImpl(76),gx.O.A558view_NE_Information_ID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A558view_NE_Information_ID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("VIEW_NE_INFORMATION_ID",row || gx.fn.currentGridRowImpl(76),',')},nac:gx.falseFn};
   GXValidFnc[91]={ id: 91, fld:"",grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[95]={ id: 95, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id: 97, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[99]={ id:99 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gxz:"ZV21ddo_view_NE_EncounterIDTitleControlIdToReplace",gxold:"OV21ddo_view_NE_EncounterIDTitleControlIdToReplace",gxvar:"AV21ddo_view_NE_EncounterIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21ddo_view_NE_EncounterIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV21ddo_view_NE_EncounterIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gx.O.AV21ddo_view_NE_EncounterIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21ddo_view_NE_EncounterIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[101]={ id:101 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE",gxz:"ZV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace",gxold:"OV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace",gxvar:"AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE",gx.O.AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[103]={ id:103 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE",gxz:"ZV29ddo_view_NE_DepartmentTitleControlIdToReplace",gxold:"OV29ddo_view_NE_DepartmentTitleControlIdToReplace",gxvar:"AV29ddo_view_NE_DepartmentTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29ddo_view_NE_DepartmentTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29ddo_view_NE_DepartmentTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE",gx.O.AV29ddo_view_NE_DepartmentTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29ddo_view_NE_DepartmentTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[105]={ id:105 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE",gxz:"ZV33ddo_view_NE_ENCTypeTitleControlIdToReplace",gxold:"OV33ddo_view_NE_ENCTypeTitleControlIdToReplace",gxvar:"AV33ddo_view_NE_ENCTypeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33ddo_view_NE_ENCTypeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33ddo_view_NE_ENCTypeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE",gx.O.AV33ddo_view_NE_ENCTypeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33ddo_view_NE_ENCTypeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[107]={ id:107 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE",gxz:"ZV43ddo_view_NE_StatusTitleControlIdToReplace",gxold:"OV43ddo_view_NE_StatusTitleControlIdToReplace",gxvar:"AV43ddo_view_NE_StatusTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV43ddo_view_NE_StatusTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43ddo_view_NE_StatusTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE",gx.O.AV43ddo_view_NE_StatusTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV43ddo_view_NE_StatusTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[109]={ id:109 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE",gxz:"ZV51ddo_view_NE_IsRandApproveTitleControlIdToReplace",gxold:"OV51ddo_view_NE_IsRandApproveTitleControlIdToReplace",gxvar:"AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV51ddo_view_NE_IsRandApproveTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE",gx.O.AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[111]={ id:111 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE",gxz:"ZV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace",gxold:"OV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace",gxvar:"AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE",gx.O.AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[113]={ id:113 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE",gxz:"ZV55ddo_view_NE_IsUpdateTitleControlIdToReplace",gxold:"OV55ddo_view_NE_IsUpdateTitleControlIdToReplace",gxvar:"AV55ddo_view_NE_IsUpdateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV55ddo_view_NE_IsUpdateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV55ddo_view_NE_IsUpdateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE",gx.O.AV55ddo_view_NE_IsUpdateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV55ddo_view_NE_IsUpdateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[115]={ id:115 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVIEW_NE_ENCOUNTERID_SELECTED",gxz:"ZV100view_NE_EncounterID_Selected",gxold:"OV100view_NE_EncounterID_Selected",gxvar:"AV100view_NE_EncounterID_Selected",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV100view_NE_EncounterID_Selected=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV100view_NE_EncounterID_Selected=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vVIEW_NE_ENCOUNTERID_SELECTED",gx.O.AV100view_NE_EncounterID_Selected,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV100view_NE_EncounterID_Selected=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vVIEW_NE_ENCOUNTERID_SELECTED",',')},nac:gx.falseFn};
   GXValidFnc[116]={ id:116 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[117]={ id:117 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[118]={ id: 118, fld:"TABLEDVELOP_CONFIRMPANEL_DELETEENCOUNTER",grid:0};
   GXValidFnc[123]={ id: 123, fld:"TABLEDVELOP_CONFIRMPANEL_BATCHAPPROVE",grid:0};
   GXValidFnc[128]={ id: 128, fld:"TABLEDVELOP_CONFIRMPANEL_BATCHRECHECK",grid:0};
   GXValidFnc[133]={ id:133 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_ENCOUNTERID",gxz:"ZV19TFview_NE_EncounterID",gxold:"OV19TFview_NE_EncounterID",gxvar:"AV19TFview_NE_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19TFview_NE_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV19TFview_NE_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_ENCOUNTERID",gx.O.AV19TFview_NE_EncounterID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19TFview_NE_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFVIEW_NE_ENCOUNTERID",',')},nac:gx.falseFn};
   GXValidFnc[134]={ id:134 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_ENCOUNTERID_TO",gxz:"ZV20TFview_NE_EncounterID_To",gxold:"OV20TFview_NE_EncounterID_To",gxvar:"AV20TFview_NE_EncounterID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20TFview_NE_EncounterID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV20TFview_NE_EncounterID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_ENCOUNTERID_TO",gx.O.AV20TFview_NE_EncounterID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20TFview_NE_EncounterID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFVIEW_NE_ENCOUNTERID_TO",',')},nac:gx.falseFn};
   GXValidFnc[135]={ id:135 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_INFORMATION_PATIENTNO",gxz:"ZV23TFview_NE_Information_PatientNo",gxold:"OV23TFview_NE_Information_PatientNo",gxvar:"AV23TFview_NE_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23TFview_NE_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23TFview_NE_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_INFORMATION_PATIENTNO",gx.O.AV23TFview_NE_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23TFview_NE_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_NE_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[136]={ id:136 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_INFORMATION_PATIENTNO_SEL",gxz:"ZV24TFview_NE_Information_PatientNo_Sel",gxold:"OV24TFview_NE_Information_PatientNo_Sel",gxvar:"AV24TFview_NE_Information_PatientNo_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24TFview_NE_Information_PatientNo_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24TFview_NE_Information_PatientNo_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_INFORMATION_PATIENTNO_SEL",gx.O.AV24TFview_NE_Information_PatientNo_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24TFview_NE_Information_PatientNo_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_NE_INFORMATION_PATIENTNO_SEL")},nac:gx.falseFn};
   GXValidFnc[137]={ id:137 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_DEPARTMENT",gxz:"ZV27TFview_NE_Department",gxold:"OV27TFview_NE_Department",gxvar:"AV27TFview_NE_Department",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27TFview_NE_Department=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27TFview_NE_Department=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_DEPARTMENT",gx.O.AV27TFview_NE_Department,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27TFview_NE_Department=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_NE_DEPARTMENT")},nac:gx.falseFn};
   GXValidFnc[138]={ id:138 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_DEPARTMENT_SEL",gxz:"ZV28TFview_NE_Department_Sel",gxold:"OV28TFview_NE_Department_Sel",gxvar:"AV28TFview_NE_Department_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV28TFview_NE_Department_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28TFview_NE_Department_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_DEPARTMENT_SEL",gx.O.AV28TFview_NE_Department_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV28TFview_NE_Department_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_NE_DEPARTMENT_SEL")},nac:gx.falseFn};
   GXValidFnc[139]={ id:139 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_ENCTYPE",gxz:"ZV31TFview_NE_ENCType",gxold:"OV31TFview_NE_ENCType",gxvar:"AV31TFview_NE_ENCType",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31TFview_NE_ENCType=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31TFview_NE_ENCType=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_ENCTYPE",gx.O.AV31TFview_NE_ENCType,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31TFview_NE_ENCType=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_NE_ENCTYPE")},nac:gx.falseFn};
   GXValidFnc[140]={ id:140 ,lvl:0,type:"svchar",len:4000,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_ENCTYPE_SEL",gxz:"ZV32TFview_NE_ENCType_Sel",gxold:"OV32TFview_NE_ENCType_Sel",gxvar:"AV32TFview_NE_ENCType_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV32TFview_NE_ENCType_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV32TFview_NE_ENCType_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_ENCTYPE_SEL",gx.O.AV32TFview_NE_ENCType_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV32TFview_NE_ENCType_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFVIEW_NE_ENCTYPE_SEL")},nac:gx.falseFn};
   GXValidFnc[141]={ id:141 ,lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_ISRANDAPPROVE_SEL",gxz:"ZV77TFview_NE_IsRandApprove_Sel",gxold:"OV77TFview_NE_IsRandApprove_Sel",gxvar:"AV77TFview_NE_IsRandApprove_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV77TFview_NE_IsRandApprove_Sel=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV77TFview_NE_IsRandApprove_Sel=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_ISRANDAPPROVE_SEL",gx.O.AV77TFview_NE_IsRandApprove_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV77TFview_NE_IsRandApprove_Sel=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFVIEW_NE_ISRANDAPPROVE_SEL",',')},nac:gx.falseFn};
   GXValidFnc[142]={ id:142 ,lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_ISRANDRECHECK_SEL",gxz:"ZV76TFview_NE_IsRandRecheck_Sel",gxold:"OV76TFview_NE_IsRandRecheck_Sel",gxvar:"AV76TFview_NE_IsRandRecheck_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV76TFview_NE_IsRandRecheck_Sel=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV76TFview_NE_IsRandRecheck_Sel=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_ISRANDRECHECK_SEL",gx.O.AV76TFview_NE_IsRandRecheck_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV76TFview_NE_IsRandRecheck_Sel=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFVIEW_NE_ISRANDRECHECK_SEL",',')},nac:gx.falseFn};
   GXValidFnc[143]={ id:143 ,lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFVIEW_NE_ISUPDATE_SEL",gxz:"ZV78TFview_NE_IsUpdate_Sel",gxold:"OV78TFview_NE_IsUpdate_Sel",gxvar:"AV78TFview_NE_IsUpdate_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV78TFview_NE_IsUpdate_Sel=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV78TFview_NE_IsUpdate_Sel=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFVIEW_NE_ISUPDATE_SEL",gx.O.AV78TFview_NE_IsUpdate_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV78TFview_NE_IsUpdate_Sel=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFVIEW_NE_ISUPDATE_SEL",',')},nac:gx.falseFn};
   this.AV17sBR_EncounterID = "" ;
   this.ZV17sBR_EncounterID = "" ;
   this.OV17sBR_EncounterID = "" ;
   this.AV15BR_Information_PatientNo = "" ;
   this.ZV15BR_Information_PatientNo = "" ;
   this.OV15BR_Information_PatientNo = "" ;
   this.AV64view_NE_AdmitDate = gx.date.nullDate() ;
   this.ZV64view_NE_AdmitDate = gx.date.nullDate() ;
   this.OV64view_NE_AdmitDate = gx.date.nullDate() ;
   this.AV104endview_NE_AdmitDate = gx.date.nullDate() ;
   this.ZV104endview_NE_AdmitDate = gx.date.nullDate() ;
   this.OV104endview_NE_AdmitDate = gx.date.nullDate() ;
   this.AV102tview_NE_Status = 0 ;
   this.ZV102tview_NE_Status = 0 ;
   this.OV102tview_NE_Status = 0 ;
   this.AV80view_NE_IsRandApprove = false ;
   this.ZV80view_NE_IsRandApprove = false ;
   this.OV80view_NE_IsRandApprove = false ;
   this.AV81view_NE_IsRandRecheck = false ;
   this.ZV81view_NE_IsRandRecheck = false ;
   this.OV81view_NE_IsRandRecheck = false ;
   this.AV82view_NE_IsUpdate = false ;
   this.ZV82view_NE_IsUpdate = false ;
   this.OV82view_NE_IsUpdate = false ;
   this.ZV98deleteEncounter = "" ;
   this.OV98deleteEncounter = "" ;
   this.Z549view_NE_EncounterID = 0 ;
   this.O549view_NE_EncounterID = 0 ;
   this.Z559view_NE_Information_PatientNo = "" ;
   this.O559view_NE_Information_PatientNo = "" ;
   this.ZV83PatientNo = "" ;
   this.OV83PatientNo = "" ;
   this.Z550view_NE_Department = "" ;
   this.O550view_NE_Department = "" ;
   this.Z551view_NE_ENCType = "" ;
   this.O551view_NE_ENCType = "" ;
   this.ZV103AdmitDate = gx.date.nullDate() ;
   this.OV103AdmitDate = gx.date.nullDate() ;
   this.Z552view_NE_AdmitDate = gx.date.nullDate() ;
   this.O552view_NE_AdmitDate = gx.date.nullDate() ;
   this.Z553view_NE_Status = 0 ;
   this.O553view_NE_Status = 0 ;
   this.Z555view_NE_IsRandApprove = false ;
   this.O555view_NE_IsRandApprove = false ;
   this.Z554view_NE_IsRandRecheck = false ;
   this.O554view_NE_IsRandRecheck = false ;
   this.Z556view_NE_IsUpdate = false ;
   this.O556view_NE_IsUpdate = false ;
   this.Z557view_NE_TenantTenantCode = "" ;
   this.O557view_NE_TenantTenantCode = "" ;
   this.Z558view_NE_Information_ID = 0 ;
   this.O558view_NE_Information_ID = 0 ;
   this.AV21ddo_view_NE_EncounterIDTitleControlIdToReplace = "" ;
   this.ZV21ddo_view_NE_EncounterIDTitleControlIdToReplace = "" ;
   this.OV21ddo_view_NE_EncounterIDTitleControlIdToReplace = "" ;
   this.AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace = "" ;
   this.ZV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace = "" ;
   this.OV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace = "" ;
   this.AV29ddo_view_NE_DepartmentTitleControlIdToReplace = "" ;
   this.ZV29ddo_view_NE_DepartmentTitleControlIdToReplace = "" ;
   this.OV29ddo_view_NE_DepartmentTitleControlIdToReplace = "" ;
   this.AV33ddo_view_NE_ENCTypeTitleControlIdToReplace = "" ;
   this.ZV33ddo_view_NE_ENCTypeTitleControlIdToReplace = "" ;
   this.OV33ddo_view_NE_ENCTypeTitleControlIdToReplace = "" ;
   this.AV43ddo_view_NE_StatusTitleControlIdToReplace = "" ;
   this.ZV43ddo_view_NE_StatusTitleControlIdToReplace = "" ;
   this.OV43ddo_view_NE_StatusTitleControlIdToReplace = "" ;
   this.AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace = "" ;
   this.ZV51ddo_view_NE_IsRandApproveTitleControlIdToReplace = "" ;
   this.OV51ddo_view_NE_IsRandApproveTitleControlIdToReplace = "" ;
   this.AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace = "" ;
   this.ZV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace = "" ;
   this.OV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace = "" ;
   this.AV55ddo_view_NE_IsUpdateTitleControlIdToReplace = "" ;
   this.ZV55ddo_view_NE_IsUpdateTitleControlIdToReplace = "" ;
   this.OV55ddo_view_NE_IsUpdateTitleControlIdToReplace = "" ;
   this.AV100view_NE_EncounterID_Selected = 0 ;
   this.ZV100view_NE_EncounterID_Selected = 0 ;
   this.OV100view_NE_EncounterID_Selected = 0 ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV19TFview_NE_EncounterID = 0 ;
   this.ZV19TFview_NE_EncounterID = 0 ;
   this.OV19TFview_NE_EncounterID = 0 ;
   this.AV20TFview_NE_EncounterID_To = 0 ;
   this.ZV20TFview_NE_EncounterID_To = 0 ;
   this.OV20TFview_NE_EncounterID_To = 0 ;
   this.AV23TFview_NE_Information_PatientNo = "" ;
   this.ZV23TFview_NE_Information_PatientNo = "" ;
   this.OV23TFview_NE_Information_PatientNo = "" ;
   this.AV24TFview_NE_Information_PatientNo_Sel = "" ;
   this.ZV24TFview_NE_Information_PatientNo_Sel = "" ;
   this.OV24TFview_NE_Information_PatientNo_Sel = "" ;
   this.AV27TFview_NE_Department = "" ;
   this.ZV27TFview_NE_Department = "" ;
   this.OV27TFview_NE_Department = "" ;
   this.AV28TFview_NE_Department_Sel = "" ;
   this.ZV28TFview_NE_Department_Sel = "" ;
   this.OV28TFview_NE_Department_Sel = "" ;
   this.AV31TFview_NE_ENCType = "" ;
   this.ZV31TFview_NE_ENCType = "" ;
   this.OV31TFview_NE_ENCType = "" ;
   this.AV32TFview_NE_ENCType_Sel = "" ;
   this.ZV32TFview_NE_ENCType_Sel = "" ;
   this.OV32TFview_NE_ENCType_Sel = "" ;
   this.AV77TFview_NE_IsRandApprove_Sel = 0 ;
   this.ZV77TFview_NE_IsRandApprove_Sel = 0 ;
   this.OV77TFview_NE_IsRandApprove_Sel = 0 ;
   this.AV76TFview_NE_IsRandRecheck_Sel = 0 ;
   this.ZV76TFview_NE_IsRandRecheck_Sel = 0 ;
   this.OV76TFview_NE_IsRandRecheck_Sel = 0 ;
   this.AV78TFview_NE_IsUpdate_Sel = 0 ;
   this.ZV78TFview_NE_IsUpdate_Sel = 0 ;
   this.OV78TFview_NE_IsUpdate_Sel = 0 ;
   this.AV17sBR_EncounterID = "" ;
   this.AV15BR_Information_PatientNo = "" ;
   this.AV64view_NE_AdmitDate = gx.date.nullDate() ;
   this.AV104endview_NE_AdmitDate = gx.date.nullDate() ;
   this.AV102tview_NE_Status = 0 ;
   this.AV80view_NE_IsRandApprove = false ;
   this.AV81view_NE_IsRandRecheck = false ;
   this.AV82view_NE_IsUpdate = false ;
   this.AV58GridCurrentPage = 0 ;
   this.AV56DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV21ddo_view_NE_EncounterIDTitleControlIdToReplace = "" ;
   this.AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace = "" ;
   this.AV29ddo_view_NE_DepartmentTitleControlIdToReplace = "" ;
   this.AV33ddo_view_NE_ENCTypeTitleControlIdToReplace = "" ;
   this.AV43ddo_view_NE_StatusTitleControlIdToReplace = "" ;
   this.AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace = "" ;
   this.AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace = "" ;
   this.AV55ddo_view_NE_IsUpdateTitleControlIdToReplace = "" ;
   this.AV100view_NE_EncounterID_Selected = 0 ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV19TFview_NE_EncounterID = 0 ;
   this.AV20TFview_NE_EncounterID_To = 0 ;
   this.AV23TFview_NE_Information_PatientNo = "" ;
   this.AV24TFview_NE_Information_PatientNo_Sel = "" ;
   this.AV27TFview_NE_Department = "" ;
   this.AV28TFview_NE_Department_Sel = "" ;
   this.AV31TFview_NE_ENCType = "" ;
   this.AV32TFview_NE_ENCType_Sel = "" ;
   this.AV77TFview_NE_IsRandApprove_Sel = 0 ;
   this.AV76TFview_NE_IsRandRecheck_Sel = 0 ;
   this.AV78TFview_NE_IsUpdate_Sel = 0 ;
   this.AV98deleteEncounter = "" ;
   this.A549view_NE_EncounterID = 0 ;
   this.A559view_NE_Information_PatientNo = "" ;
   this.AV83PatientNo = "" ;
   this.A550view_NE_Department = "" ;
   this.A551view_NE_ENCType = "" ;
   this.AV103AdmitDate = gx.date.nullDate() ;
   this.A552view_NE_AdmitDate = gx.date.nullDate() ;
   this.A553view_NE_Status = 0 ;
   this.A555view_NE_IsRandApprove = false ;
   this.A554view_NE_IsRandRecheck = false ;
   this.A556view_NE_IsUpdate = false ;
   this.A557view_NE_TenantTenantCode = "" ;
   this.A558view_NE_Information_ID = 0 ;
   this.AV75TFview_NE_Status_Sels = [ ] ;
   this.AV107Pgmname = "" ;
   this.AV92tAllBR_EncounterID = [ ] ;
   this.AV79view_NE_Status = 0 ;
   this.AV85IsInsert = false ;
   this.AV65tCurrentCode = "" ;
   this.Events = {"e11ag2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12ag2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13ag2_client": ["DDO_VIEW_NE_ENCOUNTERID.ONOPTIONCLICKED", true] ,"e14ag2_client": ["DDO_VIEW_NE_INFORMATION_PATIENTNO.ONOPTIONCLICKED", true] ,"e15ag2_client": ["DDO_VIEW_NE_DEPARTMENT.ONOPTIONCLICKED", true] ,"e16ag2_client": ["DDO_VIEW_NE_ENCTYPE.ONOPTIONCLICKED", true] ,"e17ag2_client": ["DDO_VIEW_NE_STATUS.ONOPTIONCLICKED", true] ,"e18ag2_client": ["DDO_VIEW_NE_ISRANDAPPROVE.ONOPTIONCLICKED", true] ,"e19ag2_client": ["DDO_VIEW_NE_ISRANDRECHECK.ONOPTIONCLICKED", true] ,"e20ag2_client": ["DDO_VIEW_NE_ISUPDATE.ONOPTIONCLICKED", true] ,"e21ag2_client": ["DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE", true] ,"e22ag2_client": ["DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE", true] ,"e23ag2_client": ["VSBR_ENCOUNTERID.CONTROLVALUECHANGING", true] ,"e27ag2_client": ["'DOTEST'", true] ,"e28ag2_client": ["'DOADD'", true] ,"e29ag2_client": ["VIEW_NE_ENCOUNTERID.CLICK", true] ,"e35ag2_client": ["ENTER", true] ,"e36ag2_client": ["CANCEL", true] ,"e32ag2_client": ["'DODELETEENCOUNTER'", false] ,"e34ag1_client": ["DVELOP_CONFIRMPANEL_DELETEENCOUNTER.CLOSE", false] ,"e30ag1_client": ["'DOBATCHAPPROVE'", false] ,"e31ag1_client": ["'DOBATCHRECHECK'", false] ,"e33ag2_client": ["VIEW_NE_INFORMATION_PATIENTNO.CLICK", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true}],[{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'gx.fn.getCtrlProperty("vVIEW_NE_ENCOUNTERID_SELECTED","Visible")',ctrl:'vVIEW_NE_ENCOUNTERID_SELECTED',prop:'Visible'},{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_ENCOUNTERID","Visible")',ctrl:'vTFVIEW_NE_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_ENCOUNTERID_TO","Visible")',ctrl:'vTFVIEW_NE_ENCOUNTERID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_INFORMATION_PATIENTNO","Visible")',ctrl:'vTFVIEW_NE_INFORMATION_PATIENTNO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_INFORMATION_PATIENTNO_SEL","Visible")',ctrl:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_DEPARTMENT","Visible")',ctrl:'vTFVIEW_NE_DEPARTMENT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_DEPARTMENT_SEL","Visible")',ctrl:'vTFVIEW_NE_DEPARTMENT_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_ENCTYPE","Visible")',ctrl:'vTFVIEW_NE_ENCTYPE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_ENCTYPE_SEL","Visible")',ctrl:'vTFVIEW_NE_ENCTYPE_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_ISRANDAPPROVE_SEL","Visible")',ctrl:'vTFVIEW_NE_ISRANDAPPROVE_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_ISRANDRECHECK_SEL","Visible")',ctrl:'vTFVIEW_NE_ISRANDRECHECK_SEL',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFVIEW_NE_ISUPDATE_SEL","Visible")',ctrl:'vTFVIEW_NE_ISUPDATE_SEL',prop:'Visible'},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'TitleControlIdToReplace'},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'TitleControlIdToReplace'},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'TitleControlIdToReplace'},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'TitleControlIdToReplace'},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_VIEW_NE_STATUSContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_NE_STATUS',prop:'TitleControlIdToReplace'},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'TitleControlIdToReplace'},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'TitleControlIdToReplace'},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.TitleControlIdToReplace',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'TitleControlIdToReplace'},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV56DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SelectedValue_set',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SelectedValue_set'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SelectedValue_set',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SelectedValue_set'},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SelectedValue_set',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SelectedValue_set'},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'this.DDO_VIEW_NE_STATUSContainer.SelectedValue_set',ctrl:'DDO_VIEW_NE_STATUS',prop:'SelectedValue_set'},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SelectedValue_set',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SelectedValue_set'},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.FilteredText_set',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'FilteredText_set'},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SelectedValue_set',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SelectedValue_set'},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.FilteredText_set',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'FilteredText_set'},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SelectedValue_set',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SelectedValue_set'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.FilteredText_set',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'FilteredText_set'},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.FilteredText_set',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'FilteredText_set'},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.FilteredTextTo_set',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'FilteredTextTo_set'},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_STATUSContainer.SortedStatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_VIEW_NE_ENCOUNTERID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.ActiveEventKey',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.FilteredText_get',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'FilteredText_get'},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.FilteredTextTo_get',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'FilteredTextTo_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_STATUSContainer.SortedStatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_VIEW_NE_INFORMATION_PATIENTNO.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.ActiveEventKey',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.FilteredText_get',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'FilteredText_get'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SelectedValue_get',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_STATUSContainer.SortedStatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_VIEW_NE_DEPARTMENT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.ActiveEventKey',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.FilteredText_get',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'FilteredText_get'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SelectedValue_get',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SortedStatus'},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_STATUSContainer.SortedStatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_VIEW_NE_ENCTYPE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.ActiveEventKey',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.FilteredText_get',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'FilteredText_get'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SelectedValue_get',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_STATUSContainer.SortedStatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_VIEW_NE_STATUS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_VIEW_NE_STATUSContainer.ActiveEventKey',ctrl:'DDO_VIEW_NE_STATUS',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_NE_STATUSContainer.SelectedValue_get',ctrl:'DDO_VIEW_NE_STATUS',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_NE_STATUSContainer.SortedStatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_VIEW_NE_ISRANDAPPROVE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.ActiveEventKey',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SelectedValue_get',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_STATUSContainer.SortedStatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_VIEW_NE_ISRANDRECHECK.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.ActiveEventKey',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SelectedValue_get',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_STATUSContainer.SortedStatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_VIEW_NE_ISUPDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.ActiveEventKey',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'ActiveEventKey'},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SelectedValue_get',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SelectedValue_get'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_VIEW_NE_ISUPDATEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'this.DDO_VIEW_NE_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_VIEW_NE_DEPARTMENT',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ENCTYPEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_STATUSContainer.SortedStatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'this.DDO_VIEW_NE_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'A559view_NE_Information_PatientNo',fld:'VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'A552view_NE_AdmitDate',fld:'VIEW_NE_ADMITDATE',pic:''}],[{av:'AV83PatientNo',fld:'vPATIENTNO',pic:''},{av:'AV103AdmitDate',fld:'vADMITDATE',pic:''},{av:'AV98deleteEncounter',fld:'vDELETEENCOUNTER',pic:''},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Tooltiptext")',ctrl:'vDELETEENCOUNTER',prop:'Tooltiptext'}]];
   this.EvtParms["'DODELETEENCOUNTER'"] = [[{av:'A549view_NE_EncounterID',fld:'VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true}],[{av:'AV100view_NE_EncounterID_Selected',fld:'vVIEW_NE_ENCOUNTERID_SELECTED',pic:'ZZZZZZZZZZZZZZZZZ9'}]];
   this.EvtParms["DVELOP_CONFIRMPANEL_DELETEENCOUNTER.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_DELETEENCOUNTER',prop:'Result'}],[]];
   this.EvtParms["'DOBATCHAPPROVE'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_BATCHAPPROVE',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''}],[{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["'DOBATCHRECHECK'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_BATCHRECHECK',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''}],[{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["VIEW_NE_INFORMATION_PATIENTNO.CLICK"] = [[{av:'A558view_NE_Information_ID',fld:'VIEW_NE_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true}],[]];
   this.EvtParms["VSBR_ENCOUNTERID.CONTROLVALUECHANGING"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true}],[{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV92tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV18view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26view_NE_DepartmentTitleFilterData',fld:'vVIEW_NE_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV30view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV40view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV48view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV44view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV52view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCOUNTERID","Title")',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_INFORMATION_PATIENTNO","Title")',ctrl:'VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'VIEW_NE_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_DEPARTMENT","Title")',ctrl:'VIEW_NE_DEPARTMENT',prop:'Title'},{ctrl:'VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ENCTYPE","Title")',ctrl:'VIEW_NE_ENCTYPE',prop:'Title'},{ctrl:'VIEW_NE_STATUS'},{ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDAPPROVE","Title")',ctrl:'VIEW_NE_ISRANDAPPROVE',prop:'Title'},{ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISRANDRECHECK","Title")',ctrl:'VIEW_NE_ISRANDRECHECK',prop:'Title'},{ctrl:'VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("VIEW_NE_ISUPDATE","Title")',ctrl:'VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["'DOTEST'"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV17sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV64view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV104endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{ctrl:'vTVIEW_NE_STATUS'},{av:'AV102tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV80view_NE_IsRandApprove',fld:'vVIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV81view_NE_IsRandRecheck',fld:'vVIEW_NE_ISRANDRECHECK',pic:''},{av:'AV82view_NE_IsUpdate',fld:'vVIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV19TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV20TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV23TFview_NE_Information_PatientNo',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFview_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV28TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV31TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV32TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV77TFview_NE_IsRandApprove_Sel',fld:'vTFVIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV76TFview_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV78TFview_NE_IsUpdate_Sel',fld:'vTFVIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV65tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV21ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_view_NE_DepartmentTitleControlIdToReplace',fld:'vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true}],[]];
   this.EvtParms["'DOADD'"] = [[{av:'A549view_NE_EncounterID',fld:'VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true}],[]];
   this.EvtParms["VIEW_NE_ENCOUNTERID.CLICK"] = [[{av:'AV79view_NE_Status',fld:'vVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV85IsInsert',fld:'vISINSERT',pic:'',hsh:true},{ctrl:'VIEW_NE_STATUS'},{av:'A553view_NE_Status',fld:'VIEW_NE_STATUS',pic:'ZZZ9',hsh:true},{av:'A549view_NE_EncounterID',fld:'VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true}],[]];
   this.setVCMap("AV75TFview_NE_Status_Sels", "vTFVIEW_NE_STATUS_SELS", 0, "Collint", 0, 0);
   this.setVCMap("AV107Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV92tAllBR_EncounterID", "vTALLBR_ENCOUNTERID", 0, "Collint", 0, 0);
   this.setVCMap("AV79view_NE_Status", "vVIEW_NE_STATUS", 0, "int", 4, 0);
   this.setVCMap("AV85IsInsert", "vISINSERT", 0, "boolean", 4, 0);
   this.setVCMap("AV65tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV75TFview_NE_Status_Sels", "vTFVIEW_NE_STATUS_SELS", 0, "Collint", 0, 0);
   this.setVCMap("AV107Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV65tCurrentCode", "vTCURRENTCODE", 0, "svchar", 40, 0);
   this.setVCMap("AV75TFview_NE_Status_Sels", "vTFVIEW_NE_STATUS_SELS", 0, "Collint", 0, 0);
   this.setVCMap("AV107Pgmname", "vPGMNAME", 0, "char", 129, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[22]);
   GridContainer.addRefreshingVar(this.GXValidFnc[26]);
   GridContainer.addRefreshingVar(this.GXValidFnc[30]);
   GridContainer.addRefreshingVar(this.GXValidFnc[34]);
   GridContainer.addRefreshingVar(this.GXValidFnc[39]);
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[116]);
   GridContainer.addRefreshingVar(this.GXValidFnc[117]);
   GridContainer.addRefreshingVar(this.GXValidFnc[133]);
   GridContainer.addRefreshingVar(this.GXValidFnc[134]);
   GridContainer.addRefreshingVar(this.GXValidFnc[135]);
   GridContainer.addRefreshingVar(this.GXValidFnc[136]);
   GridContainer.addRefreshingVar(this.GXValidFnc[137]);
   GridContainer.addRefreshingVar(this.GXValidFnc[138]);
   GridContainer.addRefreshingVar(this.GXValidFnc[139]);
   GridContainer.addRefreshingVar(this.GXValidFnc[140]);
   GridContainer.addRefreshingVar(this.GXValidFnc[141]);
   GridContainer.addRefreshingVar(this.GXValidFnc[142]);
   GridContainer.addRefreshingVar(this.GXValidFnc[143]);
   GridContainer.addRefreshingVar({rfrVar:"AV65tCurrentCode"});
   GridContainer.addRefreshingVar(this.GXValidFnc[99]);
   GridContainer.addRefreshingVar(this.GXValidFnc[101]);
   GridContainer.addRefreshingVar(this.GXValidFnc[103]);
   GridContainer.addRefreshingVar(this.GXValidFnc[105]);
   GridContainer.addRefreshingVar(this.GXValidFnc[107]);
   GridContainer.addRefreshingVar(this.GXValidFnc[109]);
   GridContainer.addRefreshingVar(this.GXValidFnc[111]);
   GridContainer.addRefreshingVar(this.GXValidFnc[113]);
   GridContainer.addRefreshingVar({rfrVar:"AV75TFview_NE_Status_Sels"});
   GridContainer.addRefreshingVar({rfrVar:"AV107Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV85IsInsert"});
   this.Initialize( );
});
gx.createParentObj(br_encounterlist);
