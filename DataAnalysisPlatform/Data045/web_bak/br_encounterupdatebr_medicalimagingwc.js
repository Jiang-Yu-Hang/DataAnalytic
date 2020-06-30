/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:38:4.40
*/
gx.evt.autoSkip = false;
gx.define('br_encounterupdatebr_medicalimagingwc', true, function (CmpContext) {
   this.ServerClass =  "br_encounterupdatebr_medicalimagingwc" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV67Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV50IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV8BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV8BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV67Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV50IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
   };
   this.s132_client=function()
   {
      this.s162_client();
      if ( this.AV14OrderedBy == 1 )
      {
         this.DDO_BR_MEDICALIMAGING_NOContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 2 )
      {
         this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 3 )
      {
         this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 4 )
      {
         this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 5 )
      {
         this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_MEDICALIMAGING_NOContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.SortedStatus =  ""  ;
   };
   this.e245h2_client=function()
   {
      this.clearMessages();
      this.AV54BR_MedicalImagingID_Selected = gx.num.trunc( this.A225BR_MedicalImagingID ,0) ;
      this.DVELOP_CONFIRMPANEL_MYDELContainer.Confirm() ;
      this.refreshOutputs([{av:'AV54BR_MedicalImagingID_Selected',fld:'vBR_MEDICALIMAGINGID_SELECTED',pic:'ZZZZZZZZZZZZZZZZZZ'}]);
      return gx.$.Deferred().resolve();
   };
   this.e115h2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e125h2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e135h2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGING_NO.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e145h2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGING_IMAGEAGE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e155h2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGING_IMAGENAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e165h2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGING_IMAGEDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e175h2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICALIMAGING_IMAGEHOSP.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e185h2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_MYDEL.CLOSE", false, null, true, true);
   };
   this.e195h2_client=function()
   {
      return this.executeServerEvent("'DOINSERT'", false, null, false, false);
   };
   this.e235h2_client=function()
   {
      return this.executeServerEvent("VEDIT.CLICK", true, arguments[0], false, false);
   };
   this.e255h2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e265h2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,40,42,43,44,46,48,50,52,54,55,57,58,59,60,65,66];
   this.GXLastCtrlId =66;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",28,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_encounterupdatebr_medicalimagingwc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",29,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Edit","vEDIT",30,0,"px",17,"px","e235h2_client","","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addBitmap("&Mydel","vMYDEL",31,0,"px",17,"px","e245h2_client","","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(518,32,"BR_MEDICALIMAGING_NO","","","BR_MedicalImaging_No","int",0,"px",18,18,"right",null,[],518,"BR_MedicalImaging_No",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(225,33,"BR_MEDICALIMAGINGID","搴忓彿","","BR_MedicalImagingID","int",0,"px",18,18,"right",null,[],225,"BR_MedicalImagingID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(231,34,"BR_MEDICALIMAGING_IMAGEAGE","","","BR_MedicalImaging_ImageAge","int",0,"px",3,3,"right",null,[],231,"BR_MedicalImaging_ImageAge",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(228,35,"BR_MEDICALIMAGING_IMAGENAME","","","BR_MedicalImaging_ImageName","svchar",0,"px",100,80,"left",null,[],228,"BR_MedicalImaging_ImageName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(229,36,"BR_MEDICALIMAGING_IMAGEDATE","","","BR_MedicalImaging_ImageDate","date",0,"px",10,10,"right",null,[],229,"BR_MedicalImaging_ImageDate",true,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(230,37,"BR_MEDICALIMAGING_IMAGEHOSP","","","BR_MedicalImaging_ImageHosp","svchar",0,"px",40,40,"left",null,[],230,"BR_MedicalImaging_ImageHosp",true,0,false,false,"Attribute",1,"WWColumn");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_TABLEHEADERContainer = gx.uc.getNew(this, 10, 0, "BootstrapPanel", this.CmpContext + "DVPANEL_TABLEHEADERContainer", "Dvpanel_tableheader", "DVPANEL_TABLEHEADER");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 41, 29, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV42GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV42GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV42GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV44GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV44GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV44GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV43GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV43GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV43GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e115h2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e125h2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_MEDICALIMAGING_NOContainer = gx.uc.getNew(this, 45, 29, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICALIMAGING_NOContainer", "Ddo_br_medicalimaging_no", "DDO_BR_MEDICALIMAGING_NO");
   var DDO_BR_MEDICALIMAGING_NOContainer = this.DDO_BR_MEDICALIMAGING_NOContainer;
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGING_NOContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGING_NOContainer.addV2CFunction('AV39DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGING_NOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV39DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV39DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGING_NOContainer.addV2CFunction('AV58BR_MedicalImaging_NoTitleFilterData', "vBR_MEDICALIMAGING_NOTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGING_NOContainer.addC2VFunction(function(UC) { UC.ParentObject.AV58BR_MedicalImaging_NoTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGING_NOTITLEFILTERDATA",UC.ParentObject.AV58BR_MedicalImaging_NoTitleFilterData); });
   DDO_BR_MEDICALIMAGING_NOContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGING_NOContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGING_NOContainer.addEventHandler("OnOptionClicked", this.e135h2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGING_NOContainer);
   this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer = gx.uc.getNew(this, 47, 46, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICALIMAGING_IMAGEAGEContainer", "Ddo_br_medicalimaging_imageage", "DDO_BR_MEDICALIMAGING_IMAGEAGE");
   var DDO_BR_MEDICALIMAGING_IMAGEAGEContainer = this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer;
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.addV2CFunction('AV39DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV39DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV39DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.addV2CFunction('AV27BR_MedicalImaging_ImageAgeTitleFilterData', "vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV27BR_MedicalImaging_ImageAgeTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA",UC.ParentObject.AV27BR_MedicalImaging_ImageAgeTitleFilterData); });
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.addEventHandler("OnOptionClicked", this.e145h2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGING_IMAGEAGEContainer);
   this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer = gx.uc.getNew(this, 49, 46, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICALIMAGING_IMAGENAMEContainer", "Ddo_br_medicalimaging_imagename", "DDO_BR_MEDICALIMAGING_IMAGENAME");
   var DDO_BR_MEDICALIMAGING_IMAGENAMEContainer = this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer;
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.addV2CFunction('AV39DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV39DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV39DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.addV2CFunction('AV21BR_MedicalImaging_ImageNameTitleFilterData', "vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21BR_MedicalImaging_ImageNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA",UC.ParentObject.AV21BR_MedicalImaging_ImageNameTitleFilterData); });
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.addEventHandler("OnOptionClicked", this.e155h2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGING_IMAGENAMEContainer);
   this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer = gx.uc.getNew(this, 51, 46, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICALIMAGING_IMAGEDATEContainer", "Ddo_br_medicalimaging_imagedate", "DDO_BR_MEDICALIMAGING_IMAGEDATE");
   var DDO_BR_MEDICALIMAGING_IMAGEDATEContainer = this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer;
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.addV2CFunction('AV39DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV39DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV39DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.addV2CFunction('AV23BR_MedicalImaging_ImageDateTitleFilterData', "vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV23BR_MedicalImaging_ImageDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA",UC.ParentObject.AV23BR_MedicalImaging_ImageDateTitleFilterData); });
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.addEventHandler("OnOptionClicked", this.e165h2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGING_IMAGEDATEContainer);
   this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer = gx.uc.getNew(this, 53, 46, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer", "Ddo_br_medicalimaging_imagehosp", "DDO_BR_MEDICALIMAGING_IMAGEHOSP");
   var DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer = this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer;
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.addV2CFunction('AV39DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.addC2VFunction(function(UC) { UC.ParentObject.AV39DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV39DDO_TitleSettingsIcons); });
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.addV2CFunction('AV25BR_MedicalImaging_ImageHospTitleFilterData', "vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.addC2VFunction(function(UC) { UC.ParentObject.AV25BR_MedicalImaging_ImageHospTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA",UC.ParentObject.AV25BR_MedicalImaging_ImageHospTitleFilterData); });
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.addEventHandler("OnOptionClicked", this.e175h2_client);
   this.setUserControl(DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 56, 46, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
   var WORKWITHPLUSUTILITIES1Container = this.WORKWITHPLUSUTILITIES1Container;
   WORKWITHPLUSUTILITIES1Container.setProp("Class", "Class", "", "char");
   WORKWITHPLUSUTILITIES1Container.setProp("Enabled", "Enabled", true, "boolean");
   WORKWITHPLUSUTILITIES1Container.setProp("Width", "Width", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Height", "Height", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Visible", "Visible", true, "bool");
   WORKWITHPLUSUTILITIES1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(WORKWITHPLUSUTILITIES1Container);
   this.DVELOP_CONFIRMPANEL_MYDELContainer = gx.uc.getNew(this, 63, 46, "BootstrapConfirmPanel", this.CmpContext + "DVELOP_CONFIRMPANEL_MYDELContainer", "Dvelop_confirmpanel_mydel", "DVELOP_CONFIRMPANEL_MYDEL");
   var DVELOP_CONFIRMPANEL_MYDELContainer = this.DVELOP_CONFIRMPANEL_MYDELContainer;
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("ConfirmationText", "Confirmationtext", "纭鍒犻櫎锛?, "str");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_MYDELContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_MYDELContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_MYDELContainer.addEventHandler("Close", this.e185h2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_MYDELContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEGRIDHEADER",grid:0};
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
   GXValidFnc[22]={ id: 22, fld:"BTNINSERT",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV49Display",gxold:"OV49Display",gxvar:"AV49Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV49Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV49Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28),gx.O.AV49Display,gx.O.AV64Display_GXI)},c2v:function(){gx.O.AV64Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV49Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV64Display_GXI',nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vEDIT",gxz:"ZV52edit",gxold:"OV52edit",gxvar:"AV52edit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV52edit=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV52edit=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vEDIT",row || gx.fn.currentGridRowImpl(28),gx.O.AV52edit,gx.O.AV65Edit_GXI)},c2v:function(){gx.O.AV65Edit_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV52edit=this.val()},val:function(row){return gx.fn.getGridControlValue("vEDIT",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vEDIT_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV65Edit_GXI',nac:gx.falseFn,evt:"e235h2_client"};
   GXValidFnc[31]={ id:31 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vMYDEL",gxz:"ZV53mydel",gxold:"OV53mydel",gxvar:"AV53mydel",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV53mydel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV53mydel=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vMYDEL",row || gx.fn.currentGridRowImpl(28),gx.O.AV53mydel,gx.O.AV66Mydel_GXI)},c2v:function(){gx.O.AV66Mydel_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV53mydel=this.val()},val:function(row){return gx.fn.getGridControlValue("vMYDEL",row || gx.fn.currentGridRowImpl(28))},val_GXI:function(row){return gx.fn.getGridControlValue("vMYDEL_GXI",row || gx.fn.currentGridRowImpl(28))}, gxvar_GXI:'AV66Mydel_GXI',nac:gx.falseFn,evt:"e245h2_client"};
   GXValidFnc[32]={ id:32 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_NO",gxz:"Z518BR_MedicalImaging_No",gxold:"O518BR_MedicalImaging_No",gxvar:"A518BR_MedicalImaging_No",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A518BR_MedicalImaging_No=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z518BR_MedicalImaging_No=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGING_NO",row || gx.fn.currentGridRowImpl(28),gx.O.A518BR_MedicalImaging_No,0)},c2v:function(){if(this.val()!==undefined)gx.O.A518BR_MedicalImaging_No=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICALIMAGING_NO",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGINGID",gxz:"Z225BR_MedicalImagingID",gxold:"O225BR_MedicalImagingID",gxvar:"A225BR_MedicalImagingID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A225BR_MedicalImagingID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z225BR_MedicalImagingID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGINGID",row || gx.fn.currentGridRowImpl(28),gx.O.A225BR_MedicalImagingID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A225BR_MedicalImagingID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICALIMAGINGID",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZZ",ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGEAGE",gxz:"Z231BR_MedicalImaging_ImageAge",gxold:"O231BR_MedicalImaging_ImageAge",gxvar:"A231BR_MedicalImaging_ImageAge",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A231BR_MedicalImaging_ImageAge=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z231BR_MedicalImaging_ImageAge=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGING_IMAGEAGE",row || gx.fn.currentGridRowImpl(28),gx.O.A231BR_MedicalImaging_ImageAge,0)},c2v:function(){if(this.val()!==undefined)gx.O.A231BR_MedicalImaging_ImageAge=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICALIMAGING_IMAGEAGE",row || gx.fn.currentGridRowImpl(28),',')},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGENAME",gxz:"Z228BR_MedicalImaging_ImageName",gxold:"O228BR_MedicalImaging_ImageName",gxvar:"A228BR_MedicalImaging_ImageName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A228BR_MedicalImaging_ImageName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z228BR_MedicalImaging_ImageName=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGING_IMAGENAME",row || gx.fn.currentGridRowImpl(28),gx.O.A228BR_MedicalImaging_ImageName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A228BR_MedicalImaging_ImageName=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICALIMAGING_IMAGENAME",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGEDATE",gxz:"Z229BR_MedicalImaging_ImageDate",gxold:"O229BR_MedicalImaging_ImageDate",gxvar:"A229BR_MedicalImaging_ImageDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A229BR_MedicalImaging_ImageDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z229BR_MedicalImaging_ImageDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGING_IMAGEDATE",row || gx.fn.currentGridRowImpl(28),gx.O.A229BR_MedicalImaging_ImageDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A229BR_MedicalImaging_ImageDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_MEDICALIMAGING_IMAGEDATE",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:28,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_IMAGEHOSP",gxz:"Z230BR_MedicalImaging_ImageHosp",gxold:"O230BR_MedicalImaging_ImageHosp",gxvar:"A230BR_MedicalImaging_ImageHosp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A230BR_MedicalImaging_ImageHosp=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z230BR_MedicalImaging_ImageHosp=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICALIMAGING_IMAGEHOSP",row || gx.fn.currentGridRowImpl(28),gx.O.A230BR_MedicalImaging_ImageHosp,0)},c2v:function(){if(this.val()!==undefined)gx.O.A230BR_MedicalImaging_ImageHosp=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICALIMAGING_IMAGEHOSP",row || gx.fn.currentGridRowImpl(28))},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE",gxz:"ZV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace",gxold:"OV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace",gxvar:"AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE",gx.O.AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE",gxz:"ZV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace",gxold:"OV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace",gxvar:"AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE",gx.O.AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE",gxz:"ZV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace",gxold:"OV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace",gxvar:"AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE",gx.O.AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE",gxz:"ZV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace",gxold:"OV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace",gxvar:"AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE",gx.O.AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE",gxz:"ZV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace",gxold:"OV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace",gxvar:"AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE",gx.O.AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 55 , function() {
   });
   GXValidFnc[57]={ id:57 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vBR_MEDICALIMAGINGID_SELECTED",gxz:"ZV54BR_MedicalImagingID_Selected",gxold:"OV54BR_MedicalImagingID_Selected",gxvar:"AV54BR_MedicalImagingID_Selected",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV54BR_MedicalImagingID_Selected=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV54BR_MedicalImagingID_Selected=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vBR_MEDICALIMAGINGID_SELECTED",gx.O.AV54BR_MedicalImagingID_Selected,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV54BR_MedicalImagingID_Selected=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vBR_MEDICALIMAGINGID_SELECTED",',')},nac:gx.falseFn};
   GXValidFnc[58]={ id:58 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV14OrderedBy",gxold:"OV14OrderedBy",gxvar:"AV14OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV14OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV15OrderedDsc",gxold:"OV15OrderedDsc",gxvar:"AV15OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV15OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[60]={ id: 60, fld:"TABLEDVELOP_CONFIRMPANEL_MYDEL",grid:0};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_NO",gxz:"ZV59TFBR_MedicalImaging_No",gxold:"OV59TFBR_MedicalImaging_No",gxvar:"AV59TFBR_MedicalImaging_No",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV59TFBR_MedicalImaging_No=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV59TFBR_MedicalImaging_No=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_NO",gx.O.AV59TFBR_MedicalImaging_No,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV59TFBR_MedicalImaging_No=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICALIMAGING_NO",',')},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICALIMAGING_NO_TO",gxz:"ZV60TFBR_MedicalImaging_No_To",gxold:"OV60TFBR_MedicalImaging_No_To",gxvar:"AV60TFBR_MedicalImaging_No_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV60TFBR_MedicalImaging_No_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV60TFBR_MedicalImaging_No_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICALIMAGING_NO_TO",gx.O.AV60TFBR_MedicalImaging_No_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV60TFBR_MedicalImaging_No_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_MEDICALIMAGING_NO_TO",',')},nac:gx.falseFn};
   this.ZV49Display = "" ;
   this.OV49Display = "" ;
   this.ZV52edit = "" ;
   this.OV52edit = "" ;
   this.ZV53mydel = "" ;
   this.OV53mydel = "" ;
   this.Z518BR_MedicalImaging_No = 0 ;
   this.O518BR_MedicalImaging_No = 0 ;
   this.Z225BR_MedicalImagingID = 0 ;
   this.O225BR_MedicalImagingID = 0 ;
   this.Z231BR_MedicalImaging_ImageAge = 0 ;
   this.O231BR_MedicalImaging_ImageAge = 0 ;
   this.Z228BR_MedicalImaging_ImageName = "" ;
   this.O228BR_MedicalImaging_ImageName = "" ;
   this.Z229BR_MedicalImaging_ImageDate = gx.date.nullDate() ;
   this.O229BR_MedicalImaging_ImageDate = gx.date.nullDate() ;
   this.Z230BR_MedicalImaging_ImageHosp = "" ;
   this.O230BR_MedicalImaging_ImageHosp = "" ;
   this.AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace = "" ;
   this.ZV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace = "" ;
   this.OV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace = "" ;
   this.AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = "" ;
   this.ZV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = "" ;
   this.OV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = "" ;
   this.AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = "" ;
   this.ZV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = "" ;
   this.OV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = "" ;
   this.AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = "" ;
   this.ZV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = "" ;
   this.OV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = "" ;
   this.AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = "" ;
   this.ZV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = "" ;
   this.OV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = "" ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.AV54BR_MedicalImagingID_Selected = 0 ;
   this.ZV54BR_MedicalImagingID_Selected = 0 ;
   this.OV54BR_MedicalImagingID_Selected = 0 ;
   this.AV14OrderedBy = 0 ;
   this.ZV14OrderedBy = 0 ;
   this.OV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.ZV15OrderedDsc = false ;
   this.OV15OrderedDsc = false ;
   this.AV59TFBR_MedicalImaging_No = 0 ;
   this.ZV59TFBR_MedicalImaging_No = 0 ;
   this.OV59TFBR_MedicalImaging_No = 0 ;
   this.AV60TFBR_MedicalImaging_No_To = 0 ;
   this.ZV60TFBR_MedicalImaging_No_To = 0 ;
   this.OV60TFBR_MedicalImaging_No_To = 0 ;
   this.AV42GridCurrentPage = 0 ;
   this.AV39DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace = "" ;
   this.AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = "" ;
   this.AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = "" ;
   this.AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = "" ;
   this.AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = "" ;
   this.A19BR_EncounterID = 0 ;
   this.AV54BR_MedicalImagingID_Selected = 0 ;
   this.AV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.AV59TFBR_MedicalImaging_No = 0 ;
   this.AV60TFBR_MedicalImaging_No_To = 0 ;
   this.AV8BR_EncounterID = 0 ;
   this.AV49Display = "" ;
   this.AV52edit = "" ;
   this.AV53mydel = "" ;
   this.A518BR_MedicalImaging_No = 0 ;
   this.A225BR_MedicalImagingID = 0 ;
   this.A231BR_MedicalImaging_ImageAge = 0 ;
   this.A228BR_MedicalImaging_ImageName = "" ;
   this.A229BR_MedicalImaging_ImageDate = gx.date.nullDate() ;
   this.A230BR_MedicalImaging_ImageHosp = "" ;
   this.AV67Pgmname = "" ;
   this.AV50IsAuthorized_Display = false ;
   this.Events = {"e115h2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e125h2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e135h2_client": ["DDO_BR_MEDICALIMAGING_NO.ONOPTIONCLICKED", true] ,"e145h2_client": ["DDO_BR_MEDICALIMAGING_IMAGEAGE.ONOPTIONCLICKED", true] ,"e155h2_client": ["DDO_BR_MEDICALIMAGING_IMAGENAME.ONOPTIONCLICKED", true] ,"e165h2_client": ["DDO_BR_MEDICALIMAGING_IMAGEDATE.ONOPTIONCLICKED", true] ,"e175h2_client": ["DDO_BR_MEDICALIMAGING_IMAGEHOSP.ONOPTIONCLICKED", true] ,"e185h2_client": ["DVELOP_CONFIRMPANEL_MYDEL.CLOSE", true] ,"e195h2_client": ["'DOINSERT'", true] ,"e235h2_client": ["VEDIT.CLICK", true] ,"e255h2_client": ["ENTER", true] ,"e265h2_client": ["CANCEL", true] ,"e245h2_client": ["'DOMYDEL'", false]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV67Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV58BR_MedicalImaging_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_NO","Title")',ctrl:'BR_MEDICALIMAGING_NO',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEAGE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGENAME","Title")',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEDATE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEHOSP","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vEDIT","Visible")',ctrl:'vEDIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vMYDEL","Visible")',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV67Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'gx.fn.getCtrlProperty("vBR_MEDICALIMAGINGID_SELECTED","Visible")',ctrl:'vBR_MEDICALIMAGINGID_SELECTED',prop:'Visible'},{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_NO","Visible")',ctrl:'vTFBR_MEDICALIMAGING_NO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICALIMAGING_NO_TO","Visible")',ctrl:'vTFBR_MEDICALIMAGING_NO_TO',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'TitleControlIdToReplace'},{av:'AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'TitleControlIdToReplace'},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'TitleControlIdToReplace'},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'TitleControlIdToReplace'},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'TitleControlIdToReplace'},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV39DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.FilteredText_set',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'FilteredText_set'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.FilteredTextTo_set',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGING_NO.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.FilteredText_get',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.FilteredTextTo_get',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'FilteredTextTo_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'SortedStatus'},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'SortedStatus'},{av:'AV58BR_MedicalImaging_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_NO","Title")',ctrl:'BR_MEDICALIMAGING_NO',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEAGE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGENAME","Title")',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEDATE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEHOSP","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vEDIT","Visible")',ctrl:'vEDIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vMYDEL","Visible")',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGING_IMAGEAGE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'SortedStatus'},{av:'AV58BR_MedicalImaging_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_NO","Title")',ctrl:'BR_MEDICALIMAGING_NO',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEAGE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGENAME","Title")',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEDATE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEHOSP","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vEDIT","Visible")',ctrl:'vEDIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vMYDEL","Visible")',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGING_IMAGENAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'SortedStatus'},{av:'AV58BR_MedicalImaging_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_NO","Title")',ctrl:'BR_MEDICALIMAGING_NO',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEAGE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGENAME","Title")',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEDATE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEHOSP","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vEDIT","Visible")',ctrl:'vEDIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vMYDEL","Visible")',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGING_IMAGEDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'SortedStatus'},{av:'AV58BR_MedicalImaging_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_NO","Title")',ctrl:'BR_MEDICALIMAGING_NO',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEAGE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGENAME","Title")',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEDATE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEHOSP","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vEDIT","Visible")',ctrl:'vEDIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vMYDEL","Visible")',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["DDO_BR_MEDICALIMAGING_IMAGEHOSP.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'ActiveEventKey'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_NOContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_NO',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEAGEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGENAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICALIMAGING_IMAGEDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'SortedStatus'},{av:'AV58BR_MedicalImaging_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_NO","Title")',ctrl:'BR_MEDICALIMAGING_NO',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEAGE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGENAME","Title")',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEDATE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEHOSP","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vEDIT","Visible")',ctrl:'vEDIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vMYDEL","Visible")',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV49Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'},{av:'AV52edit',fld:'vEDIT',pic:''},{av:'gx.fn.getCtrlProperty("vEDIT","Tooltiptext")',ctrl:'vEDIT',prop:'Tooltiptext'},{av:'AV53mydel',fld:'vMYDEL',pic:''},{av:'gx.fn.getCtrlProperty("vMYDEL","Tooltiptext")',ctrl:'vMYDEL',prop:'Tooltiptext'}]];
   this.EvtParms["'DOMYDEL'"] = [[{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV54BR_MedicalImagingID_Selected',fld:'vBR_MEDICALIMAGINGID_SELECTED',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.EvtParms["DVELOP_CONFIRMPANEL_MYDEL.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_MYDELContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_MYDEL',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFBR_MedicalImaging_No',fld:'vTFBR_MEDICALIMAGING_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV60TFBR_MedicalImaging_No_To',fld:'vTFBR_MEDICALIMAGING_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV61ddo_BR_MedicalImaging_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV58BR_MedicalImaging_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_NOTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICALIMAGING_NO',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_NO","Title")',ctrl:'BR_MEDICALIMAGING_NO',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEAGE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGENAME","Title")',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEDATE","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICALIMAGING_IMAGEHOSP","Title")',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vEDIT","Visible")',ctrl:'vEDIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vMYDEL","Visible")',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]];
   this.EvtParms["'DOINSERT'"] = [[{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["VEDIT.CLICK"] = [[{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.setVCMap("AV67Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV50IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV67Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV50IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV67Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV50IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[58]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar(this.GXValidFnc[65]);
   GridContainer.addRefreshingVar(this.GXValidFnc[66]);
   GridContainer.addRefreshingVar({rfrVar:"AV8BR_EncounterID"});
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[48]);
   GridContainer.addRefreshingVar(this.GXValidFnc[50]);
   GridContainer.addRefreshingVar(this.GXValidFnc[52]);
   GridContainer.addRefreshingVar(this.GXValidFnc[54]);
   GridContainer.addRefreshingVar({rfrVar:"AV67Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV50IsAuthorized_Display"});
   this.Initialize( );
});
