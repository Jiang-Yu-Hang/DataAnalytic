/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:40:19.17
*/
gx.evt.autoSkip = false;
gx.define('br_encounterww', false, function () {
   this.ServerClass =  "br_encounterww" ;
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
      this.AV243Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV231tAllBR_EncounterID=gx.fn.getControlValue("vTALLBR_ENCOUNTERID") ;
      this.AV137IsInsert=gx.fn.getControlValue("vISINSERT") ;
      this.AV243Pgmname=gx.fn.getControlValue("vPGMNAME") ;
   };
   this.Validv_Br_encounter_admitdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vBR_ENCOUNTER_ADMITDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV122BR_Encounter_AdmitDate)==0) || new gx.date.gxdate( this.AV122BR_Encounter_AdmitDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烞R_Encounter_Admit Date瓒呯晫");
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
   this.Validv_Br_encounter_admitdate_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vBR_ENCOUNTER_ADMITDATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV121BR_Encounter_AdmitDate_To)==0) || new gx.date.gxdate( this.AV121BR_Encounter_AdmitDate_To ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烞R_Encounter_Admit Date_To瓒呯晫");
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
   this.Validv_Br_encounter_status=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vBR_ENCOUNTER_STATUS");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_information_id=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(87) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("BR_INFORMATION_ID", gx.fn.currentGridRowImpl(87));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e34142_client=function()
   {
      this.clearMessages();
      this.AV165BR_EncounterID_Selected = gx.num.trunc( this.A19BR_EncounterID ,0) ;
      this.DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.Confirm() ;
      this.refreshOutputs([{av:'AV165BR_EncounterID_Selected',fld:'vBR_ENCOUNTERID_SELECTED',pic:'ZZZZZZZZZZZZZZZZZZ'}]);
      return gx.$.Deferred().resolve();
   };
   this.e32141_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e33141_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e35142_client=function()
   {
      this.clearMessages();
      this.call("br_informationview.aspx", [this.A85BR_Information_ID, "br_encounter"]);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e11142_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12142_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13142_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14142_client=function()
   {
      return this.executeServerEvent("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15142_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16142_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e17142_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e18142_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e19142_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e20142_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e21142_client=function()
   {
      return this.executeServerEvent("DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e22142_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_DELETEENCOUNTER.CLOSE", false, null, true, true);
   };
   this.e23142_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE", false, null, true, true);
   };
   this.e24142_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE", false, null, true, true);
   };
   this.e25142_client=function()
   {
      return this.executeServerEvent("VSBR_ENCOUNTERID.CONTROLVALUECHANGING", true, null, false, true);
   };
   this.e29142_client=function()
   {
      return this.executeServerEvent("'DOTEST'", true, arguments[0], false, false);
   };
   this.e30142_client=function()
   {
      return this.executeServerEvent("'DOADD'", true, arguments[0], false, false);
   };
   this.e31142_client=function()
   {
      return this.executeServerEvent("BR_ENCOUNTERID.CLICK", true, arguments[0], false, false);
   };
   this.e36142_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e37142_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,36,37,39,40,42,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,72,73,74,77,78,79,80,81,82,83,84,85,86,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,104,105,106,108,110,112,114,116,118,120,122,124,126,127,128,129,134,139];
   this.GXLastCtrlId =139;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",87,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_encounterww",[],false,1,true,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Deleteencounter","vDELETEENCOUNTER",88,0,"px",17,"px","e34142_client","","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(19,89,"BR_ENCOUNTERID","","","BR_EncounterID","int",0,"px",18,18,"right","e31142_client",[],19,"BR_EncounterID",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(36,90,"BR_INFORMATION_PATIENTNO","","","BR_Information_PatientNo","svchar",410,"px",2000,80,"left","e35142_client",[],36,"BR_Information_PatientNo",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(84,91,"BR_ENCOUNTER_DEPARTMENT","","","BR_Encounter_Department","svchar",0,"px",100,80,"left",null,[],84,"BR_Encounter_Department",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(90,92,"BR_ENCOUNTER_ENCTYPE","","","BR_Encounter_ENCType","svchar",0,"px",100,80,"left",null,[],90,"BR_Encounter_ENCType",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(91,93,"BR_ENCOUNTER_ADMITDATE","","","BR_Encounter_AdmitDate","date",0,"px",10,10,"right",null,[],91,"BR_Encounter_AdmitDate",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(85,94,"BR_INFORMATION_ID","鎮ｈ€呭熀鏈俊鎭富閿甀D","","BR_Information_ID","int",0,"px",18,18,"right",null,[],85,"BR_Information_ID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addComboBox(172,95,"BR_ENCOUNTER_STATUS","","BR_Encounter_Status","int",null,0,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addCheckBox(192,96,"BR_ENCOUNTER_ISRANDAPPROVE","","","BR_Encounter_IsRandApprove","boolean","true","false",null,true,false,0,"px","WWColumn hidden-xs");
   GridContainer.addCheckBox(193,97,"BR_ENCOUNTER_ISRANDRECHECK","","","BR_Encounter_IsRandRecheck","boolean","true","false",null,true,false,0,"px","WWColumn");
   GridContainer.addCheckBox(202,98,"BR_ENCOUNTER_ISUPDATE","","","BR_Encounter_IsUpdate","boolean","true","false",null,true,false,0,"px","WWColumn");
   GridContainer.addSingleLineEdit(360,99,"BAS_TENANTTENANTCODE","BAS_Tenant Tenant Code","","BAS_TenantTenantCode","svchar",0,"px",20,20,"left",null,[],360,"BAS_TenantTenantCode",false,0,false,false,"Attribute",1,"WWColumn");
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
   this.DVPANEL_UNNAMEDTABLE1Container = gx.uc.getNew(this, 70, 22, "BootstrapPanel", "DVPANEL_UNNAMEDTABLE1Container", "Dvpanel_unnamedtable1", "DVPANEL_UNNAMEDTABLE1");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 103, 22, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV97GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV97GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV97GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV99GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV99GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV99GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV98GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV98GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV98GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11142_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12142_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_ENCOUNTERIDContainer = gx.uc.getNew(this, 107, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTERIDContainer", "Ddo_br_encounterid", "DDO_BR_ENCOUNTERID");
   var DDO_BR_ENCOUNTERIDContainer = this.DDO_BR_ENCOUNTERIDContainer;
   DDO_BR_ENCOUNTERIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTERIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTERIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTERIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTERIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTERIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV95DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV95DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV95DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTERIDContainer.addV2CFunction('AV45BR_EncounterIDTitleFilterData', "vBR_ENCOUNTERIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTERIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45BR_EncounterIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTERIDTITLEFILTERDATA",UC.ParentObject.AV45BR_EncounterIDTitleFilterData); });
   DDO_BR_ENCOUNTERIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTERIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTERIDContainer.addEventHandler("OnOptionClicked", this.e13142_client);
   this.setUserControl(DDO_BR_ENCOUNTERIDContainer);
   this.DDO_BR_INFORMATION_PATIENTNOContainer = gx.uc.getNew(this, 109, 22, "BootstrapDropDownOptions", "DDO_BR_INFORMATION_PATIENTNOContainer", "Ddo_br_information_patientno", "DDO_BR_INFORMATION_PATIENTNO");
   var DDO_BR_INFORMATION_PATIENTNOContainer = this.DDO_BR_INFORMATION_PATIENTNOContainer;
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Class", "Class", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_INFORMATION_PATIENTNOContainer.addV2CFunction('AV95DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_INFORMATION_PATIENTNOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV95DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV95DDO_TitleSettingsIcons); });
   DDO_BR_INFORMATION_PATIENTNOContainer.addV2CFunction('AV83BR_Information_PatientNoTitleFilterData', "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_INFORMATION_PATIENTNOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV83BR_Information_PatientNoTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA",UC.ParentObject.AV83BR_Information_PatientNoTitleFilterData); });
   DDO_BR_INFORMATION_PATIENTNOContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_INFORMATION_PATIENTNOContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_INFORMATION_PATIENTNOContainer.addEventHandler("OnOptionClicked", this.e14142_client);
   this.setUserControl(DDO_BR_INFORMATION_PATIENTNOContainer);
   this.DDO_BR_ENCOUNTER_DEPARTMENTContainer = gx.uc.getNew(this, 111, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_DEPARTMENTContainer", "Ddo_br_encounter_department", "DDO_BR_ENCOUNTER_DEPARTMENT");
   var DDO_BR_ENCOUNTER_DEPARTMENTContainer = this.DDO_BR_ENCOUNTER_DEPARTMENTContainer;
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.addV2CFunction('AV95DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV95DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV95DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.addV2CFunction('AV53BR_Encounter_DepartmentTitleFilterData', "vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV53BR_Encounter_DepartmentTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA",UC.ParentObject.AV53BR_Encounter_DepartmentTitleFilterData); });
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_DEPARTMENTContainer.addEventHandler("OnOptionClicked", this.e15142_client);
   this.setUserControl(DDO_BR_ENCOUNTER_DEPARTMENTContainer);
   this.DDO_BR_ENCOUNTER_ENCTYPEContainer = gx.uc.getNew(this, 113, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_ENCTYPEContainer", "Ddo_br_encounter_enctype", "DDO_BR_ENCOUNTER_ENCTYPE");
   var DDO_BR_ENCOUNTER_ENCTYPEContainer = this.DDO_BR_ENCOUNTER_ENCTYPEContainer;
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.addV2CFunction('AV95DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_ENCTYPEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV95DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV95DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_ENCTYPEContainer.addV2CFunction('AV57BR_Encounter_ENCTypeTitleFilterData', "vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_ENCTYPEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV57BR_Encounter_ENCTypeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA",UC.ParentObject.AV57BR_Encounter_ENCTypeTitleFilterData); });
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_ENCTYPEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_ENCTYPEContainer.addEventHandler("OnOptionClicked", this.e16142_client);
   this.setUserControl(DDO_BR_ENCOUNTER_ENCTYPEContainer);
   this.DDO_BR_ENCOUNTER_ADMITDATEContainer = gx.uc.getNew(this, 115, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_ADMITDATEContainer", "Ddo_br_encounter_admitdate", "DDO_BR_ENCOUNTER_ADMITDATE");
   var DDO_BR_ENCOUNTER_ADMITDATEContainer = this.DDO_BR_ENCOUNTER_ADMITDATEContainer;
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.addV2CFunction('AV95DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_ADMITDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV95DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV95DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_ADMITDATEContainer.addV2CFunction('AV61BR_Encounter_AdmitDateTitleFilterData', "vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_ADMITDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV61BR_Encounter_AdmitDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA",UC.ParentObject.AV61BR_Encounter_AdmitDateTitleFilterData); });
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_ADMITDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_ADMITDATEContainer.addEventHandler("OnOptionClicked", this.e17142_client);
   this.setUserControl(DDO_BR_ENCOUNTER_ADMITDATEContainer);
   this.DDO_BR_ENCOUNTER_STATUSContainer = gx.uc.getNew(this, 117, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_STATUSContainer", "Ddo_br_encounter_status", "DDO_BR_ENCOUNTER_STATUS");
   var DDO_BR_ENCOUNTER_STATUSContainer = this.DDO_BR_ENCOUNTER_STATUSContainer;
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_STATUSContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_STATUSContainer.addV2CFunction('AV95DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_STATUSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV95DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV95DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_STATUSContainer.addV2CFunction('AV132BR_Encounter_StatusTitleFilterData', "vBR_ENCOUNTER_STATUSTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_STATUSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV132BR_Encounter_StatusTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_STATUSTITLEFILTERDATA",UC.ParentObject.AV132BR_Encounter_StatusTitleFilterData); });
   DDO_BR_ENCOUNTER_STATUSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_STATUSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_STATUSContainer.addEventHandler("OnOptionClicked", this.e18142_client);
   this.setUserControl(DDO_BR_ENCOUNTER_STATUSContainer);
   this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer = gx.uc.getNew(this, 119, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer", "Ddo_br_encounter_israndapprove", "DDO_BR_ENCOUNTER_ISRANDAPPROVE");
   var DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer = this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer;
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.addV2CFunction('AV95DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV95DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV95DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.addV2CFunction('AV155BR_Encounter_IsRandApproveTitleFilterData', "vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV155BR_Encounter_IsRandApproveTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA",UC.ParentObject.AV155BR_Encounter_IsRandApproveTitleFilterData); });
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.addEventHandler("OnOptionClicked", this.e19142_client);
   this.setUserControl(DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer);
   this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer = gx.uc.getNew(this, 121, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_ISRANDRECHECKContainer", "Ddo_br_encounter_israndrecheck", "DDO_BR_ENCOUNTER_ISRANDRECHECK");
   var DDO_BR_ENCOUNTER_ISRANDRECHECKContainer = this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer;
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.addV2CFunction('AV95DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.addC2VFunction(function(UC) { UC.ParentObject.AV95DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV95DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.addV2CFunction('AV158BR_Encounter_IsRandRecheckTitleFilterData', "vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.addC2VFunction(function(UC) { UC.ParentObject.AV158BR_Encounter_IsRandRecheckTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA",UC.ParentObject.AV158BR_Encounter_IsRandRecheckTitleFilterData); });
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.addEventHandler("OnOptionClicked", this.e20142_client);
   this.setUserControl(DDO_BR_ENCOUNTER_ISRANDRECHECKContainer);
   this.DDO_BR_ENCOUNTER_ISUPDATEContainer = gx.uc.getNew(this, 123, 22, "BootstrapDropDownOptions", "DDO_BR_ENCOUNTER_ISUPDATEContainer", "Ddo_br_encounter_isupdate", "DDO_BR_ENCOUNTER_ISUPDATE");
   var DDO_BR_ENCOUNTER_ISUPDATEContainer = this.DDO_BR_ENCOUNTER_ISUPDATEContainer;
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.addV2CFunction('AV95DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_ENCOUNTER_ISUPDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV95DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV95DDO_TitleSettingsIcons); });
   DDO_BR_ENCOUNTER_ISUPDATEContainer.addV2CFunction('AV161BR_Encounter_IsUpdateTitleFilterData', "vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_ENCOUNTER_ISUPDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV161BR_Encounter_IsUpdateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA",UC.ParentObject.AV161BR_Encounter_IsUpdateTitleFilterData); });
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_ENCOUNTER_ISUPDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_ENCOUNTER_ISUPDATEContainer.addEventHandler("OnOptionClicked", this.e21142_client);
   this.setUserControl(DDO_BR_ENCOUNTER_ISUPDATEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 125, 22, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
   var WORKWITHPLUSUTILITIES1Container = this.WORKWITHPLUSUTILITIES1Container;
   WORKWITHPLUSUTILITIES1Container.setProp("Class", "Class", "", "char");
   WORKWITHPLUSUTILITIES1Container.setProp("Enabled", "Enabled", true, "boolean");
   WORKWITHPLUSUTILITIES1Container.setProp("Width", "Width", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Height", "Height", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Visible", "Visible", true, "bool");
   WORKWITHPLUSUTILITIES1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(WORKWITHPLUSUTILITIES1Container);
   this.DVELOP_CONFIRMPANEL_BATCHRECHECKContainer = gx.uc.getNew(this, 142, 22, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_BATCHRECHECKContainer", "Dvelop_confirmpanel_batchrecheck", "DVELOP_CONFIRMPANEL_BATCHRECHECK");
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
   DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.addEventHandler("Close", this.e24142_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_BATCHRECHECKContainer);
   this.DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer = gx.uc.getNew(this, 137, 22, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer", "Dvelop_confirmpanel_batchapprove", "DVELOP_CONFIRMPANEL_BATCHAPPROVE");
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
   DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.addEventHandler("Close", this.e23142_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer);
   this.DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer = gx.uc.getNew(this, 132, 22, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer", "Dvelop_confirmpanel_deleteencounter", "DVELOP_CONFIRMPANEL_DELETEENCOUNTER");
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
   DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.addEventHandler("Close", this.e22142_client);
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
   GXValidFnc[22]={ id:22 ,lvl:0,type:"svchar",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:'e25142_client',rgrid:[this.GridContainer],fld:"vSBR_ENCOUNTERID",gxz:"ZV221sBR_EncounterID",gxold:"OV221sBR_EncounterID",gxvar:"AV221sBR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV221sBR_EncounterID=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV221sBR_EncounterID=Value},v2c:function(){gx.fn.setControlValue("vSBR_ENCOUNTERID",gx.O.AV221sBR_EncounterID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV221sBR_EncounterID=this.val()},val:function(){return gx.fn.getControlValue("vSBR_ENCOUNTERID")},nac:gx.falseFn};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_INFORMATION_PATIENTNO",gxz:"ZV17BR_Information_PatientNo",gxold:"OV17BR_Information_PatientNo",gxvar:"AV17BR_Information_PatientNo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV17BR_Information_PatientNo=Value},v2c:function(){gx.fn.setControlValue("vBR_INFORMATION_PATIENTNO",gx.O.AV17BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17BR_Information_PatientNo=this.val()},val:function(){return gx.fn.getControlValue("vBR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"TABLESPLITTEDFILTERTEXTBR_ENCOUNTER_ADMITDATE",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"FILTERTEXTBR_ENCOUNTER_ADMITDATE", format:0,grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"TABLEMERGEDBR_ENCOUNTER_ADMITDATE",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_ENCOUNTER_ADMITDATEOPERATOR",gxz:"ZV120BR_Encounter_AdmitDateOperator",gxold:"OV120BR_Encounter_AdmitDateOperator",gxvar:"AV120BR_Encounter_AdmitDateOperator",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV120BR_Encounter_AdmitDateOperator=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV120BR_Encounter_AdmitDateOperator=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vBR_ENCOUNTER_ADMITDATEOPERATOR",gx.O.AV120BR_Encounter_AdmitDateOperator)},c2v:function(){if(this.val()!==undefined)gx.O.AV120BR_Encounter_AdmitDateOperator=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vBR_ENCOUNTER_ADMITDATEOPERATOR",',')},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Br_encounter_admitdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_ENCOUNTER_ADMITDATE",gxz:"ZV122BR_Encounter_AdmitDate",gxold:"OV122BR_Encounter_AdmitDate",gxvar:"AV122BR_Encounter_AdmitDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[40],ip:[40],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV122BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV122BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vBR_ENCOUNTER_ADMITDATE",gx.O.AV122BR_Encounter_AdmitDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV122BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vBR_ENCOUNTER_ADMITDATE")},nac:gx.falseFn};
   GXValidFnc[42]={ id: 42, fld:"BR_ENCOUNTER_ADMITDATE_RANGEMIDDLETEXT_1", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Br_encounter_admitdate_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_ENCOUNTER_ADMITDATE_TO",gxz:"ZV121BR_Encounter_AdmitDate_To",gxold:"OV121BR_Encounter_AdmitDate_To",gxvar:"AV121BR_Encounter_AdmitDate_To",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[45],ip:[45],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV121BR_Encounter_AdmitDate_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV121BR_Encounter_AdmitDate_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vBR_ENCOUNTER_ADMITDATE_TO",gx.O.AV121BR_Encounter_AdmitDate_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV121BR_Encounter_AdmitDate_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vBR_ENCOUNTER_ADMITDATE_TO")},nac:gx.falseFn};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Br_encounter_status,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_ENCOUNTER_STATUS",gxz:"ZV141BR_Encounter_Status",gxold:"OV141BR_Encounter_Status",gxvar:"AV141BR_Encounter_Status",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.AV141BR_Encounter_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV141BR_Encounter_Status=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vBR_ENCOUNTER_STATUS",gx.O.AV141BR_Encounter_Status)},c2v:function(){if(this.val()!==undefined)gx.O.AV141BR_Encounter_Status=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vBR_ENCOUNTER_STATUS",',')},nac:gx.falseFn};
   GXValidFnc[51]={ id: 51, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"UNNAMEDTABLE2",grid:0};
   GXValidFnc[54]={ id: 54, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_ENCOUNTER_ISRANDAPPROVE",gxz:"ZV151BR_Encounter_IsRandApprove",gxold:"OV151BR_Encounter_IsRandApprove",gxvar:"AV151BR_Encounter_IsRandApprove",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"checkbox",v2v:function(Value){if(Value!==undefined)gx.O.AV151BR_Encounter_IsRandApprove=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV151BR_Encounter_IsRandApprove=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setCheckBoxValue("vBR_ENCOUNTER_ISRANDAPPROVE",gx.O.AV151BR_Encounter_IsRandApprove,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV151BR_Encounter_IsRandApprove=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vBR_ENCOUNTER_ISRANDAPPROVE")},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id:62 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_ENCOUNTER_ISRANDRECHECK",gxz:"ZV152BR_Encounter_IsRandRecheck",gxold:"OV152BR_Encounter_IsRandRecheck",gxvar:"AV152BR_Encounter_IsRandRecheck",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"checkbox",v2v:function(Value){if(Value!==undefined)gx.O.AV152BR_Encounter_IsRandRecheck=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV152BR_Encounter_IsRandRecheck=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setCheckBoxValue("vBR_ENCOUNTER_ISRANDRECHECK",gx.O.AV152BR_Encounter_IsRandRecheck,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV152BR_Encounter_IsRandRecheck=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vBR_ENCOUNTER_ISRANDRECHECK")},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[63]={ id: 63, fld:"",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_ENCOUNTER_ISUPDATE",gxz:"ZV153BR_Encounter_IsUpdate",gxold:"OV153BR_Encounter_IsUpdate",gxvar:"AV153BR_Encounter_IsUpdate",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"checkbox",v2v:function(Value){if(Value!==undefined)gx.O.AV153BR_Encounter_IsUpdate=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV153BR_Encounter_IsUpdate=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setCheckBoxValue("vBR_ENCOUNTER_ISUPDATE",gx.O.AV153BR_Encounter_IsUpdate,true)},c2v:function(){if(this.val()!==undefined)gx.O.AV153BR_Encounter_IsUpdate=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vBR_ENCOUNTER_ISUPDATE")},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id: 69, fld:"HTML_DVPANEL_UNNAMEDTABLE1",grid:0};
   GXValidFnc[72]={ id: 72, fld:"LAYOUT_UNNAMEDTABLE1",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[74]={ id: 74, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[77]={ id: 77, fld:"",grid:0};
   GXValidFnc[78]={ id: 78, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"BTNBATCHAPPROVE",grid:0};
   GXValidFnc[80]={ id: 80, fld:"",grid:0};
   GXValidFnc[81]={ id: 81, fld:"BTNBATCHRECHECK",grid:0};
   GXValidFnc[82]={ id: 82, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[86]={ id: 86, fld:"",grid:0};
   GXValidFnc[88]={ id:88 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETEENCOUNTER",gxz:"ZV164deleteEncounter",gxold:"OV164deleteEncounter",gxvar:"AV164deleteEncounter",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV164deleteEncounter=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV164deleteEncounter=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDELETEENCOUNTER",row || gx.fn.currentGridRowImpl(87),gx.O.AV164deleteEncounter,gx.O.AV242Deleteencounter_GXI)},c2v:function(){gx.O.AV242Deleteencounter_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV164deleteEncounter=this.val()},val:function(row){return gx.fn.getGridControlValue("vDELETEENCOUNTER",row || gx.fn.currentGridRowImpl(87))},val_GXI:function(row){return gx.fn.getGridControlValue("vDELETEENCOUNTER_GXI",row || gx.fn.currentGridRowImpl(87))}, gxvar_GXI:'AV242Deleteencounter_GXI',nac:gx.falseFn,evt:"e34142_client"};
   GXValidFnc[89]={ id:89 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(87),gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(87),',')},nac:gx.falseFn,evt:"e31142_client"};
   GXValidFnc[90]={ id:90 ,lvl:2,type:"svchar",len:2000,dec:0,sign:false,ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_PATIENTNO",gxz:"Z36BR_Information_PatientNo",gxold:"O36BR_Information_PatientNo",gxvar:"A36BR_Information_PatientNo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A36BR_Information_PatientNo=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z36BR_Information_PatientNo=Value},v2c:function(row){gx.fn.setGridControlValue("BR_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(87),gx.O.A36BR_Information_PatientNo,0)},c2v:function(){if(this.val()!==undefined)gx.O.A36BR_Information_PatientNo=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_INFORMATION_PATIENTNO",row || gx.fn.currentGridRowImpl(87))},nac:gx.falseFn,evt:"e35142_client"};
   GXValidFnc[91]={ id:91 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_DEPARTMENT",gxz:"Z84BR_Encounter_Department",gxold:"O84BR_Encounter_Department",gxvar:"A84BR_Encounter_Department",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A84BR_Encounter_Department=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z84BR_Encounter_Department=Value},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_DEPARTMENT",row || gx.fn.currentGridRowImpl(87),gx.O.A84BR_Encounter_Department,0)},c2v:function(){if(this.val()!==undefined)gx.O.A84BR_Encounter_Department=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_DEPARTMENT",row || gx.fn.currentGridRowImpl(87))},nac:gx.falseFn};
   GXValidFnc[92]={ id:92 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ENCTYPE",gxz:"Z90BR_Encounter_ENCType",gxold:"O90BR_Encounter_ENCType",gxvar:"A90BR_Encounter_ENCType",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A90BR_Encounter_ENCType=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z90BR_Encounter_ENCType=Value},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_ENCTYPE",row || gx.fn.currentGridRowImpl(87),gx.O.A90BR_Encounter_ENCType,0)},c2v:function(){if(this.val()!==undefined)gx.O.A90BR_Encounter_ENCType=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_ENCTYPE",row || gx.fn.currentGridRowImpl(87))},nac:gx.falseFn};
   GXValidFnc[93]={ id:93 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ADMITDATE",gxz:"Z91BR_Encounter_AdmitDate",gxold:"O91BR_Encounter_AdmitDate",gxvar:"A91BR_Encounter_AdmitDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTER_ADMITDATE",row || gx.fn.currentGridRowImpl(87),gx.O.A91BR_Encounter_AdmitDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A91BR_Encounter_AdmitDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_ENCOUNTER_ADMITDATE",row || gx.fn.currentGridRowImpl(87))},nac:gx.falseFn};
   GXValidFnc[94]={ id:94 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:this.Valid_Br_information_id,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_ID",gxz:"Z85BR_Information_ID",gxold:"O85BR_Information_ID",gxvar:"A85BR_Information_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A85BR_Information_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z85BR_Information_ID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_INFORMATION_ID",row || gx.fn.currentGridRowImpl(87),gx.O.A85BR_Information_ID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A85BR_Information_ID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_INFORMATION_ID",row || gx.fn.currentGridRowImpl(87),',')},nac:gx.falseFn};
   GXValidFnc[95]={ id:95 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_STATUS",gxz:"Z172BR_Encounter_Status",gxold:"O172BR_Encounter_Status",gxvar:"A172BR_Encounter_Status",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A172BR_Encounter_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z172BR_Encounter_Status=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridComboBoxValue("BR_ENCOUNTER_STATUS",row || gx.fn.currentGridRowImpl(87),gx.O.A172BR_Encounter_Status);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A172BR_Encounter_Status=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTER_STATUS",row || gx.fn.currentGridRowImpl(87),',')},nac:gx.falseFn};
   GXValidFnc[96]={ id:96 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ISRANDAPPROVE",gxz:"Z192BR_Encounter_IsRandApprove",gxold:"O192BR_Encounter_IsRandApprove",gxvar:"A192BR_Encounter_IsRandApprove",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A192BR_Encounter_IsRandApprove=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z192BR_Encounter_IsRandApprove=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("BR_ENCOUNTER_ISRANDAPPROVE",row || gx.fn.currentGridRowImpl(87),gx.O.A192BR_Encounter_IsRandApprove,true)},c2v:function(){if(this.val()!==undefined)gx.O.A192BR_Encounter_IsRandApprove=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_ISRANDAPPROVE",row || gx.fn.currentGridRowImpl(87))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[97]={ id:97 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ISRANDRECHECK",gxz:"Z193BR_Encounter_IsRandRecheck",gxold:"O193BR_Encounter_IsRandRecheck",gxvar:"A193BR_Encounter_IsRandRecheck",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A193BR_Encounter_IsRandRecheck=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z193BR_Encounter_IsRandRecheck=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("BR_ENCOUNTER_ISRANDRECHECK",row || gx.fn.currentGridRowImpl(87),gx.O.A193BR_Encounter_IsRandRecheck,true)},c2v:function(){if(this.val()!==undefined)gx.O.A193BR_Encounter_IsRandRecheck=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_ISRANDRECHECK",row || gx.fn.currentGridRowImpl(87))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[98]={ id:98 ,lvl:2,type:"boolean",len:4,dec:0,sign:false,ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ISUPDATE",gxz:"Z202BR_Encounter_IsUpdate",gxold:"O202BR_Encounter_IsUpdate",gxvar:"A202BR_Encounter_IsUpdate",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A202BR_Encounter_IsUpdate=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z202BR_Encounter_IsUpdate=gx.lang.booleanValue(Value)},v2c:function(row){gx.fn.setGridCheckBoxValue("BR_ENCOUNTER_ISUPDATE",row || gx.fn.currentGridRowImpl(87),gx.O.A202BR_Encounter_IsUpdate,true)},c2v:function(){if(this.val()!==undefined)gx.O.A202BR_Encounter_IsUpdate=gx.lang.booleanValue(this.val())},val:function(row){return gx.fn.getGridControlValue("BR_ENCOUNTER_ISUPDATE",row || gx.fn.currentGridRowImpl(87))},nac:gx.falseFn,values:['true','false']};
   GXValidFnc[99]={ id:99 ,lvl:2,type:"svchar",len:20,dec:0,sign:false,ro:1,isacc:0,grid:87,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BAS_TENANTTENANTCODE",gxz:"Z360BAS_TenantTenantCode",gxold:"O360BAS_TenantTenantCode",gxvar:"A360BAS_TenantTenantCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A360BAS_TenantTenantCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z360BAS_TenantTenantCode=Value},v2c:function(row){gx.fn.setGridControlValue("BAS_TENANTTENANTCODE",row || gx.fn.currentGridRowImpl(87),gx.O.A360BAS_TenantTenantCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.A360BAS_TenantTenantCode=this.val()},val:function(row){return gx.fn.getGridControlValue("BAS_TENANTTENANTCODE",row || gx.fn.currentGridRowImpl(87))},nac:gx.falseFn};
   GXValidFnc[100]={ id: 100, fld:"",grid:0};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[102]={ id: 102, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[104]={ id: 104, fld:"",grid:0};
   GXValidFnc[105]={ id: 105, fld:"",grid:0};
   GXValidFnc[106]={ id: 106, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[108]={ id:108 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gxz:"ZV48ddo_BR_EncounterIDTitleControlIdToReplace",gxold:"OV48ddo_BR_EncounterIDTitleControlIdToReplace",gxvar:"AV48ddo_BR_EncounterIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV48ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV48ddo_BR_EncounterIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE",gx.O.AV48ddo_BR_EncounterIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV48ddo_BR_EncounterIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[110]={ id:110 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE",gxz:"ZV86ddo_BR_Information_PatientNoTitleControlIdToReplace",gxold:"OV86ddo_BR_Information_PatientNoTitleControlIdToReplace",gxvar:"AV86ddo_BR_Information_PatientNoTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV86ddo_BR_Information_PatientNoTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV86ddo_BR_Information_PatientNoTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE",gx.O.AV86ddo_BR_Information_PatientNoTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV86ddo_BR_Information_PatientNoTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[112]={ id:112 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE",gxz:"ZV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace",gxold:"OV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace",gxvar:"AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE",gx.O.AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[114]={ id:114 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE",gxz:"ZV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace",gxold:"OV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace",gxvar:"AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE",gx.O.AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[116]={ id:116 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE",gxz:"ZV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace",gxold:"OV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace",gxvar:"AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE",gx.O.AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[118]={ id:118 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE",gxz:"ZV135ddo_BR_Encounter_StatusTitleControlIdToReplace",gxold:"OV135ddo_BR_Encounter_StatusTitleControlIdToReplace",gxvar:"AV135ddo_BR_Encounter_StatusTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV135ddo_BR_Encounter_StatusTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV135ddo_BR_Encounter_StatusTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE",gx.O.AV135ddo_BR_Encounter_StatusTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV135ddo_BR_Encounter_StatusTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[120]={ id:120 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE",gxz:"ZV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace",gxold:"OV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace",gxvar:"AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE",gx.O.AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[122]={ id:122 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE",gxz:"ZV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace",gxold:"OV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace",gxvar:"AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE",gx.O.AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[124]={ id:124 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE",gxz:"ZV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace",gxold:"OV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace",gxvar:"AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE",gx.O.AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[126]={ id:126 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vBR_ENCOUNTERID_SELECTED",gxz:"ZV165BR_EncounterID_Selected",gxold:"OV165BR_EncounterID_Selected",gxvar:"AV165BR_EncounterID_Selected",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV165BR_EncounterID_Selected=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV165BR_EncounterID_Selected=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vBR_ENCOUNTERID_SELECTED",gx.O.AV165BR_EncounterID_Selected,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV165BR_EncounterID_Selected=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vBR_ENCOUNTERID_SELECTED",',')},nac:gx.falseFn};
   GXValidFnc[127]={ id:127 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV13OrderedBy",gxold:"OV13OrderedBy",gxvar:"AV13OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV13OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV13OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[128]={ id:128 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV14OrderedDsc",gxold:"OV14OrderedDsc",gxvar:"AV14OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV14OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[129]={ id: 129, fld:"TABLEDVELOP_CONFIRMPANEL_DELETEENCOUNTER",grid:0};
   GXValidFnc[134]={ id: 134, fld:"TABLEDVELOP_CONFIRMPANEL_BATCHAPPROVE",grid:0};
   GXValidFnc[139]={ id: 139, fld:"TABLEDVELOP_CONFIRMPANEL_BATCHRECHECK",grid:0};
   this.AV221sBR_EncounterID = "" ;
   this.ZV221sBR_EncounterID = "" ;
   this.OV221sBR_EncounterID = "" ;
   this.AV17BR_Information_PatientNo = "" ;
   this.ZV17BR_Information_PatientNo = "" ;
   this.OV17BR_Information_PatientNo = "" ;
   this.AV120BR_Encounter_AdmitDateOperator = 0 ;
   this.ZV120BR_Encounter_AdmitDateOperator = 0 ;
   this.OV120BR_Encounter_AdmitDateOperator = 0 ;
   this.AV122BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.ZV122BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.OV122BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.AV121BR_Encounter_AdmitDate_To = gx.date.nullDate() ;
   this.ZV121BR_Encounter_AdmitDate_To = gx.date.nullDate() ;
   this.OV121BR_Encounter_AdmitDate_To = gx.date.nullDate() ;
   this.AV141BR_Encounter_Status = 0 ;
   this.ZV141BR_Encounter_Status = 0 ;
   this.OV141BR_Encounter_Status = 0 ;
   this.AV151BR_Encounter_IsRandApprove = false ;
   this.ZV151BR_Encounter_IsRandApprove = false ;
   this.OV151BR_Encounter_IsRandApprove = false ;
   this.AV152BR_Encounter_IsRandRecheck = false ;
   this.ZV152BR_Encounter_IsRandRecheck = false ;
   this.OV152BR_Encounter_IsRandRecheck = false ;
   this.AV153BR_Encounter_IsUpdate = false ;
   this.ZV153BR_Encounter_IsUpdate = false ;
   this.OV153BR_Encounter_IsUpdate = false ;
   this.ZV164deleteEncounter = "" ;
   this.OV164deleteEncounter = "" ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.Z36BR_Information_PatientNo = "" ;
   this.O36BR_Information_PatientNo = "" ;
   this.Z84BR_Encounter_Department = "" ;
   this.O84BR_Encounter_Department = "" ;
   this.Z90BR_Encounter_ENCType = "" ;
   this.O90BR_Encounter_ENCType = "" ;
   this.Z91BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.O91BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.Z85BR_Information_ID = 0 ;
   this.O85BR_Information_ID = 0 ;
   this.Z172BR_Encounter_Status = 0 ;
   this.O172BR_Encounter_Status = 0 ;
   this.Z192BR_Encounter_IsRandApprove = false ;
   this.O192BR_Encounter_IsRandApprove = false ;
   this.Z193BR_Encounter_IsRandRecheck = false ;
   this.O193BR_Encounter_IsRandRecheck = false ;
   this.Z202BR_Encounter_IsUpdate = false ;
   this.O202BR_Encounter_IsUpdate = false ;
   this.Z360BAS_TenantTenantCode = "" ;
   this.O360BAS_TenantTenantCode = "" ;
   this.AV48ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.ZV48ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.OV48ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV86ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.ZV86ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.OV86ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "" ;
   this.ZV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "" ;
   this.OV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "" ;
   this.AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "" ;
   this.ZV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "" ;
   this.OV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "" ;
   this.AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "" ;
   this.ZV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "" ;
   this.OV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "" ;
   this.AV135ddo_BR_Encounter_StatusTitleControlIdToReplace = "" ;
   this.ZV135ddo_BR_Encounter_StatusTitleControlIdToReplace = "" ;
   this.OV135ddo_BR_Encounter_StatusTitleControlIdToReplace = "" ;
   this.AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = "" ;
   this.ZV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = "" ;
   this.OV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = "" ;
   this.AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = "" ;
   this.ZV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = "" ;
   this.OV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = "" ;
   this.AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = "" ;
   this.ZV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = "" ;
   this.OV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = "" ;
   this.AV165BR_EncounterID_Selected = 0 ;
   this.ZV165BR_EncounterID_Selected = 0 ;
   this.OV165BR_EncounterID_Selected = 0 ;
   this.AV13OrderedBy = 0 ;
   this.ZV13OrderedBy = 0 ;
   this.OV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.ZV14OrderedDsc = false ;
   this.OV14OrderedDsc = false ;
   this.AV221sBR_EncounterID = "" ;
   this.AV17BR_Information_PatientNo = "" ;
   this.AV120BR_Encounter_AdmitDateOperator = 0 ;
   this.AV122BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.AV121BR_Encounter_AdmitDate_To = gx.date.nullDate() ;
   this.AV141BR_Encounter_Status = 0 ;
   this.AV151BR_Encounter_IsRandApprove = false ;
   this.AV152BR_Encounter_IsRandRecheck = false ;
   this.AV153BR_Encounter_IsUpdate = false ;
   this.AV97GridCurrentPage = 0 ;
   this.AV95DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV48ddo_BR_EncounterIDTitleControlIdToReplace = "" ;
   this.AV86ddo_BR_Information_PatientNoTitleControlIdToReplace = "" ;
   this.AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "" ;
   this.AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "" ;
   this.AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "" ;
   this.AV135ddo_BR_Encounter_StatusTitleControlIdToReplace = "" ;
   this.AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = "" ;
   this.AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = "" ;
   this.AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = "" ;
   this.AV165BR_EncounterID_Selected = 0 ;
   this.AV13OrderedBy = 0 ;
   this.AV14OrderedDsc = false ;
   this.AV164deleteEncounter = "" ;
   this.A19BR_EncounterID = 0 ;
   this.A36BR_Information_PatientNo = "" ;
   this.A84BR_Encounter_Department = "" ;
   this.A90BR_Encounter_ENCType = "" ;
   this.A91BR_Encounter_AdmitDate = gx.date.nullDate() ;
   this.A85BR_Information_ID = 0 ;
   this.A172BR_Encounter_Status = 0 ;
   this.A192BR_Encounter_IsRandApprove = false ;
   this.A193BR_Encounter_IsRandRecheck = false ;
   this.A202BR_Encounter_IsUpdate = false ;
   this.A360BAS_TenantTenantCode = "" ;
   this.AV243Pgmname = "" ;
   this.AV231tAllBR_EncounterID = [ ] ;
   this.AV137IsInsert = false ;
   this.Events = {"e11142_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12142_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13142_client": ["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED", true] ,"e14142_client": ["DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED", true] ,"e15142_client": ["DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED", true] ,"e16142_client": ["DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED", true] ,"e17142_client": ["DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED", true] ,"e18142_client": ["DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED", true] ,"e19142_client": ["DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED", true] ,"e20142_client": ["DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED", true] ,"e21142_client": ["DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED", true] ,"e22142_client": ["DVELOP_CONFIRMPANEL_DELETEENCOUNTER.CLOSE", true] ,"e23142_client": ["DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE", true] ,"e24142_client": ["DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE", true] ,"e25142_client": ["VSBR_ENCOUNTERID.CONTROLVALUECHANGING", true] ,"e29142_client": ["'DOTEST'", true] ,"e30142_client": ["'DOADD'", true] ,"e31142_client": ["BR_ENCOUNTERID.CLICK", true] ,"e36142_client": ["ENTER", true] ,"e37142_client": ["CANCEL", true] ,"e34142_client": ["'DODELETEENCOUNTER'", false] ,"e32141_client": ["'DOBATCHAPPROVE'", false] ,"e33141_client": ["'DOBATCHRECHECK'", false] ,"e35142_client": ["BR_INFORMATION_PATIENTNO.CLICK", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true}],[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["START"] = [[{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'gx.fn.getCtrlProperty("vBR_ENCOUNTERID_SELECTED","Visible")',ctrl:'vBR_ENCOUNTERID_SELECTED',prop:'Visible'},{ctrl:'GRID',prop:'Rows'},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'this.DDO_BR_ENCOUNTERIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTERID',prop:'TitleControlIdToReplace'},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.TitleControlIdToReplace',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'TitleControlIdToReplace'},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'TitleControlIdToReplace'},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'TitleControlIdToReplace'},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'TitleControlIdToReplace'},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'TitleControlIdToReplace'},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'TitleControlIdToReplace'},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'TitleControlIdToReplace'},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'TitleControlIdToReplace'},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV95DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_ENCOUNTERID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTERIDContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTERIDContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.ActiveEventKey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_INFORMATION_PATIENTNOContainer.SortedStatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_DEPARTMENTContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_ENCTYPEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_ADMITDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_STATUSContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_ISRANDRECHECKContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.ActiveEventKey',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'ActiveEventKey'}],[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_ENCOUNTER_ISUPDATEContainer.SortedStatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[],[{av:'AV164deleteEncounter',fld:'vDELETEENCOUNTER',pic:''},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Tooltiptext")',ctrl:'vDELETEENCOUNTER',prop:'Tooltiptext'}]];
   this.EvtParms["'DODELETEENCOUNTER'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV165BR_EncounterID_Selected',fld:'vBR_ENCOUNTERID_SELECTED',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.EvtParms["DVELOP_CONFIRMPANEL_DELETEENCOUNTER.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_DELETEENCOUNTER',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["'DOBATCHAPPROVE'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_BATCHAPPROVE',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''}],[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["'DOBATCHRECHECK'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_BATCHRECHECKContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_BATCHRECHECK',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''}],[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["BR_INFORMATION_PATIENTNO.CLICK"] = [[{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["VSBR_ENCOUNTERID.CONTROLVALUECHANGING"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true}],[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{ctrl:'BR_ENCOUNTERID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Title")',ctrl:'BR_ENCOUNTERID',prop:'Title'},{ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_INFORMATION_PATIENTNO","Title")',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_DEPARTMENT","Title")',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ENCTYPE","Title")',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ADMITDATE","Title")',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{ctrl:'BR_ENCOUNTER_STATUS'},{ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDAPPROVE","Title")',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISRANDRECHECK","Title")',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTER_ISUPDATE","Title")',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'gx.fn.getCtrlProperty("vDELETEENCOUNTER","Visible")',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]];
   this.EvtParms["'DOTEST'"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{ctrl:'vBR_ENCOUNTER_ADMITDATEOPERATOR'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true}],[]];
   this.EvtParms["'DOADD'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["BR_ENCOUNTERID.CLICK"] = [[{ctrl:'vBR_ENCOUNTER_STATUS'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{ctrl:'BR_ENCOUNTER_STATUS'},{av:'A172BR_Encounter_Status',fld:'BR_ENCOUNTER_STATUS',pic:'ZZZ9',hsh:true},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV243Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV231tAllBR_EncounterID", "vTALLBR_ENCOUNTERID", 0, "Collint", 0, 0);
   this.setVCMap("AV137IsInsert", "vISINSERT", 0, "boolean", 4, 0);
   this.setVCMap("AV243Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV243Pgmname", "vPGMNAME", 0, "char", 129, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[22]);
   GridContainer.addRefreshingVar(this.GXValidFnc[26]);
   GridContainer.addRefreshingVar(this.GXValidFnc[37]);
   GridContainer.addRefreshingVar(this.GXValidFnc[40]);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[62]);
   GridContainer.addRefreshingVar(this.GXValidFnc[66]);
   GridContainer.addRefreshingVar(this.GXValidFnc[127]);
   GridContainer.addRefreshingVar(this.GXValidFnc[128]);
   GridContainer.addRefreshingVar(this.GXValidFnc[108]);
   GridContainer.addRefreshingVar(this.GXValidFnc[110]);
   GridContainer.addRefreshingVar(this.GXValidFnc[112]);
   GridContainer.addRefreshingVar(this.GXValidFnc[114]);
   GridContainer.addRefreshingVar(this.GXValidFnc[116]);
   GridContainer.addRefreshingVar(this.GXValidFnc[118]);
   GridContainer.addRefreshingVar(this.GXValidFnc[120]);
   GridContainer.addRefreshingVar(this.GXValidFnc[122]);
   GridContainer.addRefreshingVar(this.GXValidFnc[124]);
   GridContainer.addRefreshingVar({rfrVar:"AV243Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV137IsInsert"});
   this.Initialize( );
});
gx.createParentObj(br_encounterww);
