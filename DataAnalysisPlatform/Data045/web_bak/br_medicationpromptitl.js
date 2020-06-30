/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:42.8
*/
gx.evt.autoSkip = false;
gx.define('br_medicationpromptitl', false, function () {
   this.ServerClass =  "br_medicationpromptitl" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV74Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV8InOutBR_MedicationID=gx.fn.getIntegerValue("vINOUTBR_MEDICATIONID",',') ;
      this.AV65InOutBR_Medication_RXName=gx.fn.getControlValue("vINOUTBR_MEDICATION_RXNAME") ;
      this.AV66InOutBR_Medication_RXDose=gx.fn.getDecimalValue("vINOUTBR_MEDICATION_RXDOSE",',','.') ;
      this.AV67InOutBR_Medication_RXUnit=gx.fn.getControlValue("vINOUTBR_MEDICATION_RXUNIT") ;
      this.AV74Pgmname=gx.fn.getControlValue("vPGMNAME") ;
   };
   this.s112_client=function()
   {
      this.s132_client();
      if ( this.AV10OrderedBy == 1 )
      {
         this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus =  (this.AV11OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV10OrderedBy == 2 )
      {
         this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus =  (this.AV11OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV10OrderedBy == 3 )
      {
         this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus =  (this.AV11OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV10OrderedBy == 4 )
      {
         this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus =  (this.AV11OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV10OrderedBy == 5 )
      {
         this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus =  (this.AV11OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV10OrderedBy == 6 )
      {
         this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus =  (this.AV11OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV10OrderedBy == 7 )
      {
         this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus =  (this.AV11OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s132_client=function()
   {
      this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus =  ""  ;
      this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus =  ""  ;
   };
   this.e118g2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e128g2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e138g2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e148g2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e158g2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e168g2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e178g2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e188g2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e198g2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e238g2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e248g2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,33,34,35,36,37,38,39,40,41,42,43,44,45,47,48,49,51,53,55,57,59,61,63,65,66,67,68];
   this.GXLastCtrlId =68;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",32,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_medicationpromptitl",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Select","vSELECT",33,0,"px",17,"px","e238g2_client","","","SelectAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(119,34,"BR_MEDICATIONID","鑽墿娌荤枟涓婚敭","","BR_MedicationID","int",0,"px",18,18,"right",null,[],119,"BR_MedicationID",false,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(19,35,"BR_ENCOUNTERID","灏辫瘖淇℃伅涓婚敭","","BR_EncounterID","int",0,"px",18,18,"right",null,[],19,"BR_EncounterID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(121,36,"BR_MEDICATION_RXNAME","","","BR_Medication_RXName","svchar",0,"px",40,40,"left",null,[],121,"BR_Medication_RXName",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(124,37,"BR_MEDICATION_RXDOSE","","","BR_Medication_RXDose","decimal",0,"px",15,15,"right",null,[],124,"BR_Medication_RXDose",true,5,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(125,38,"BR_MEDICATION_RXUNIT","","","BR_Medication_RXUnit","svchar",0,"px",100,80,"left",null,[],125,"BR_Medication_RXUnit",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(126,39,"BR_MEDICATION_RXFREQUENCY","","","BR_Medication_RXFrequency","svchar",0,"px",100,80,"left",null,[],126,"BR_Medication_RXFrequency",true,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(127,40,"BR_MEDICATION_RXQUANTITY","","","BR_Medication_RXQuantity","svchar",0,"px",100,80,"left",null,[],127,"BR_Medication_RXQuantity",true,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(128,41,"BR_MEDICATION_RXDAYSSUPPLY","","","BR_Medication_RXDaysSupply","decimal",0,"px",15,15,"right",null,[],128,"BR_Medication_RXDaysSupply",true,5,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(132,42,"BR_MEDICATION_ADMITSTARTDATE","","","BR_Medication_AdmitStartDate","date",0,"px",10,10,"right",null,[],132,"BR_Medication_AdmitStartDate",true,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 46, 26, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e118g2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e128g2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_MEDICATION_RXNAMEContainer = gx.uc.getNew(this, 50, 26, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXNAMEContainer", "Ddo_br_medication_rxname", "DDO_BR_MEDICATION_RXNAME");
   var DDO_BR_MEDICATION_RXNAMEContainer = this.DDO_BR_MEDICATION_RXNAMEContainer;
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXNAMEContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXNAMEContainer.addV2CFunction('AV20BR_Medication_RXNameTitleFilterData', "vBR_MEDICATION_RXNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_Medication_RXNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXNAMETITLEFILTERDATA",UC.ParentObject.AV20BR_Medication_RXNameTitleFilterData); });
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXNAMEContainer.addEventHandler("OnOptionClicked", this.e138g2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXNAMEContainer);
   this.DDO_BR_MEDICATION_RXDOSEContainer = gx.uc.getNew(this, 52, 26, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXDOSEContainer", "Ddo_br_medication_rxdose", "DDO_BR_MEDICATION_RXDOSE");
   var DDO_BR_MEDICATION_RXDOSEContainer = this.DDO_BR_MEDICATION_RXDOSEContainer;
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXDOSEContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXDOSEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXDOSEContainer.addV2CFunction('AV26BR_Medication_RXDoseTitleFilterData', "vBR_MEDICATION_RXDOSETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXDOSEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26BR_Medication_RXDoseTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXDOSETITLEFILTERDATA",UC.ParentObject.AV26BR_Medication_RXDoseTitleFilterData); });
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXDOSEContainer.addEventHandler("OnOptionClicked", this.e148g2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXDOSEContainer);
   this.DDO_BR_MEDICATION_RXUNITContainer = gx.uc.getNew(this, 54, 26, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXUNITContainer", "Ddo_br_medication_rxunit", "DDO_BR_MEDICATION_RXUNIT");
   var DDO_BR_MEDICATION_RXUNITContainer = this.DDO_BR_MEDICATION_RXUNITContainer;
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilterType", "Filtertype", "Character", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilterIsRange", "Filterisrange", false, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("IncludeDataList", "Includedatalist", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListType", "Datalisttype", "Dynamic", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListProc", "Datalistproc", "BR_MedicationPromptGetFilterData", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", 0, "num");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("LoadingData", "Loadingdata", "WWP_TSLoading", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("NoResultsFound", "Noresultsfound", "WWP_TSNoResults", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXUNITContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXUNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXUNITContainer.addV2CFunction('AV28BR_Medication_RXUnitTitleFilterData', "vBR_MEDICATION_RXUNITTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXUNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28BR_Medication_RXUnitTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXUNITTITLEFILTERDATA",UC.ParentObject.AV28BR_Medication_RXUnitTitleFilterData); });
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXUNITContainer.addEventHandler("OnOptionClicked", this.e158g2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXUNITContainer);
   this.DDO_BR_MEDICATION_RXFREQUENCYContainer = gx.uc.getNew(this, 56, 26, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXFREQUENCYContainer", "Ddo_br_medication_rxfrequency", "DDO_BR_MEDICATION_RXFREQUENCY");
   var DDO_BR_MEDICATION_RXFREQUENCYContainer = this.DDO_BR_MEDICATION_RXFREQUENCYContainer;
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXFREQUENCYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXFREQUENCYContainer.addV2CFunction('AV30BR_Medication_RXFrequencyTitleFilterData', "vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXFREQUENCYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV30BR_Medication_RXFrequencyTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA",UC.ParentObject.AV30BR_Medication_RXFrequencyTitleFilterData); });
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXFREQUENCYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXFREQUENCYContainer.addEventHandler("OnOptionClicked", this.e168g2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXFREQUENCYContainer);
   this.DDO_BR_MEDICATION_RXQUANTITYContainer = gx.uc.getNew(this, 58, 26, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXQUANTITYContainer", "Ddo_br_medication_rxquantity", "DDO_BR_MEDICATION_RXQUANTITY");
   var DDO_BR_MEDICATION_RXQUANTITYContainer = this.DDO_BR_MEDICATION_RXQUANTITYContainer;
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXQUANTITYContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXQUANTITYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXQUANTITYContainer.addV2CFunction('AV32BR_Medication_RXQuantityTitleFilterData', "vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXQUANTITYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV32BR_Medication_RXQuantityTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA",UC.ParentObject.AV32BR_Medication_RXQuantityTitleFilterData); });
   DDO_BR_MEDICATION_RXQUANTITYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXQUANTITYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXQUANTITYContainer.addEventHandler("OnOptionClicked", this.e178g2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXQUANTITYContainer);
   this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer = gx.uc.getNew(this, 60, 26, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXDAYSSUPPLYContainer", "Ddo_br_medication_rxdayssupply", "DDO_BR_MEDICATION_RXDAYSSUPPLY");
   var DDO_BR_MEDICATION_RXDAYSSUPPLYContainer = this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer;
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.addV2CFunction('AV34BR_Medication_RXDaysSupplyTitleFilterData', "vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.addC2VFunction(function(UC) { UC.ParentObject.AV34BR_Medication_RXDaysSupplyTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA",UC.ParentObject.AV34BR_Medication_RXDaysSupplyTitleFilterData); });
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.addEventHandler("OnOptionClicked", this.e188g2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXDAYSSUPPLYContainer);
   this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer = gx.uc.getNew(this, 62, 26, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_ADMITSTARTDATEContainer", "Ddo_br_medication_admitstartdate", "DDO_BR_MEDICATION_ADMITSTARTDATE");
   var DDO_BR_MEDICATION_ADMITSTARTDATEContainer = this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer;
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.addV2CFunction('AV56DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV56DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.addV2CFunction('AV42BR_Medication_AdmitStartDateTitleFilterData', "vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV42BR_Medication_AdmitStartDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA",UC.ParentObject.AV42BR_Medication_AdmitStartDateTitleFilterData); });
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_ADMITSTARTDATEContainer.addEventHandler("OnOptionClicked", this.e198g2_client);
   this.setUserControl(DDO_BR_MEDICATION_ADMITSTARTDATEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 64, 26, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
   var WORKWITHPLUSUTILITIES1Container = this.WORKWITHPLUSUTILITIES1Container;
   WORKWITHPLUSUTILITIES1Container.setProp("Class", "Class", "", "char");
   WORKWITHPLUSUTILITIES1Container.setProp("Enabled", "Enabled", true, "boolean");
   WORKWITHPLUSUTILITIES1Container.setProp("Width", "Width", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Height", "Height", "100", "str");
   WORKWITHPLUSUTILITIES1Container.setProp("Visible", "Visible", true, "bool");
   WORKWITHPLUSUTILITIES1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(WORKWITHPLUSUTILITIES1Container);
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
   GXValidFnc[20]={ id: 20, fld:"UNNAMEDTABLER_MEDICATION_RXNAME",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"FILTERTEXTBR_MEDICATION_RXNAME", format:0,grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vBR_MEDICATION_RXNAME",gxz:"ZV62BR_Medication_RXName",gxold:"OV62BR_Medication_RXName",gxvar:"AV62BR_Medication_RXName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV62BR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV62BR_Medication_RXName=Value},v2c:function(){gx.fn.setControlValue("vBR_MEDICATION_RXNAME",gx.O.AV62BR_Medication_RXName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV62BR_Medication_RXName=this.val()},val:function(){return gx.fn.getControlValue("vBR_MEDICATION_RXNAME")},nac:gx.falseFn};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[33]={ id:33 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:32,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSELECT",gxz:"ZV61Select",gxold:"OV61Select",gxvar:"AV61Select",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV61Select=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV61Select=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vSELECT",row || gx.fn.currentGridRowImpl(32),gx.O.AV61Select,gx.O.AV75Select_GXI)},c2v:function(){gx.O.AV75Select_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV61Select=this.val()},val:function(row){return gx.fn.getGridControlValue("vSELECT",row || gx.fn.currentGridRowImpl(32))},val_GXI:function(row){return gx.fn.getGridControlValue("vSELECT_GXI",row || gx.fn.currentGridRowImpl(32))}, gxvar_GXI:'AV75Select_GXI',nac:gx.falseFn,evt:"e238g2_client",std:"ENTER"};
   GXValidFnc[34]={ id:34 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:32,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z119BR_MedicationID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(32),gx.O.A119BR_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(32),',')},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:32,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(32),gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_ENCOUNTERID",row || gx.fn.currentGridRowImpl(32),',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:32,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXNAME",gxz:"Z121BR_Medication_RXName",gxold:"O121BR_Medication_RXName",gxvar:"A121BR_Medication_RXName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A121BR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z121BR_Medication_RXName=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXNAME",row || gx.fn.currentGridRowImpl(32),gx.O.A121BR_Medication_RXName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A121BR_Medication_RXName=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXNAME",row || gx.fn.currentGridRowImpl(32))},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZ",ro:1,isacc:0,grid:32,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDOSE",gxz:"Z124BR_Medication_RXDose",gxold:"O124BR_Medication_RXDose",gxvar:"A124BR_Medication_RXDose",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_MEDICATION_RXDOSE",row || gx.fn.currentGridRowImpl(32),gx.O.A124BR_Medication_RXDose,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A124BR_Medication_RXDose=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_MEDICATION_RXDOSE",row || gx.fn.currentGridRowImpl(32),',','.')},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:32,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXUNIT",gxz:"Z125BR_Medication_RXUnit",gxold:"O125BR_Medication_RXUnit",gxvar:"A125BR_Medication_RXUnit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A125BR_Medication_RXUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z125BR_Medication_RXUnit=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXUNIT",row || gx.fn.currentGridRowImpl(32),gx.O.A125BR_Medication_RXUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.A125BR_Medication_RXUnit=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXUNIT",row || gx.fn.currentGridRowImpl(32))},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:32,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXFREQUENCY",gxz:"Z126BR_Medication_RXFrequency",gxold:"O126BR_Medication_RXFrequency",gxvar:"A126BR_Medication_RXFrequency",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A126BR_Medication_RXFrequency=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z126BR_Medication_RXFrequency=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXFREQUENCY",row || gx.fn.currentGridRowImpl(32),gx.O.A126BR_Medication_RXFrequency,0)},c2v:function(){if(this.val()!==undefined)gx.O.A126BR_Medication_RXFrequency=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXFREQUENCY",row || gx.fn.currentGridRowImpl(32))},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:32,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXQUANTITY",gxz:"Z127BR_Medication_RXQuantity",gxold:"O127BR_Medication_RXQuantity",gxvar:"A127BR_Medication_RXQuantity",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A127BR_Medication_RXQuantity=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z127BR_Medication_RXQuantity=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXQUANTITY",row || gx.fn.currentGridRowImpl(32),gx.O.A127BR_Medication_RXQuantity,0)},c2v:function(){if(this.val()!==undefined)gx.O.A127BR_Medication_RXQuantity=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXQUANTITY",row || gx.fn.currentGridRowImpl(32))},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:32,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDAYSSUPPLY",gxz:"Z128BR_Medication_RXDaysSupply",gxold:"O128BR_Medication_RXDaysSupply",gxvar:"A128BR_Medication_RXDaysSupply",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A128BR_Medication_RXDaysSupply=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z128BR_Medication_RXDaysSupply=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_MEDICATION_RXDAYSSUPPLY",row || gx.fn.currentGridRowImpl(32),gx.O.A128BR_Medication_RXDaysSupply,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A128BR_Medication_RXDaysSupply=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_MEDICATION_RXDAYSSUPPLY",row || gx.fn.currentGridRowImpl(32),',','.')},nac:gx.falseFn};
   GXValidFnc[42]={ id:42 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:32,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_ADMITSTARTDATE",gxz:"Z132BR_Medication_AdmitStartDate",gxold:"O132BR_Medication_AdmitStartDate",gxvar:"A132BR_Medication_AdmitStartDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_ADMITSTARTDATE",row || gx.fn.currentGridRowImpl(32),gx.O.A132BR_Medication_AdmitStartDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A132BR_Medication_AdmitStartDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_MEDICATION_ADMITSTARTDATE",row || gx.fn.currentGridRowImpl(32))},nac:gx.falseFn};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE",gxz:"ZV21ddo_BR_Medication_RXNameTitleControlIdToReplace",gxold:"OV21ddo_BR_Medication_RXNameTitleControlIdToReplace",gxvar:"AV21ddo_BR_Medication_RXNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21ddo_BR_Medication_RXNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV21ddo_BR_Medication_RXNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE",gx.O.AV21ddo_BR_Medication_RXNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21ddo_BR_Medication_RXNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE",gxz:"ZV27ddo_BR_Medication_RXDoseTitleControlIdToReplace",gxold:"OV27ddo_BR_Medication_RXDoseTitleControlIdToReplace",gxvar:"AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV27ddo_BR_Medication_RXDoseTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE",gx.O.AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[55]={ id:55 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE",gxz:"ZV29ddo_BR_Medication_RXUnitTitleControlIdToReplace",gxold:"OV29ddo_BR_Medication_RXUnitTitleControlIdToReplace",gxvar:"AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV29ddo_BR_Medication_RXUnitTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE",gx.O.AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[57]={ id:57 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE",gxz:"ZV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace",gxold:"OV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace",gxvar:"AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE",gx.O.AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[59]={ id:59 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE",gxz:"ZV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace",gxold:"OV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace",gxvar:"AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE",gx.O.AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[61]={ id:61 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE",gxz:"ZV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace",gxold:"OV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace",gxvar:"AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE",gx.O.AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE",gxz:"ZV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace",gxold:"OV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace",gxvar:"AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE",gx.O.AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[65]={ id:65 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV10OrderedBy",gxold:"OV10OrderedBy",gxvar:"AV10OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV10OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV10OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV10OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV10OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[66]={ id:66 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV11OrderedDsc",gxold:"OV11OrderedDsc",gxvar:"AV11OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV11OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV11OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV11OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV11OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[67]={ id:67 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXUNIT",gxz:"ZV70TFBR_Medication_RXUnit",gxold:"OV70TFBR_Medication_RXUnit",gxvar:"AV70TFBR_Medication_RXUnit",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV70TFBR_Medication_RXUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV70TFBR_Medication_RXUnit=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXUNIT",gx.O.AV70TFBR_Medication_RXUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV70TFBR_Medication_RXUnit=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXUNIT")},nac:gx.falseFn};
   GXValidFnc[68]={ id:68 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_MEDICATION_RXUNIT_SEL",gxz:"ZV71TFBR_Medication_RXUnit_Sel",gxold:"OV71TFBR_Medication_RXUnit_Sel",gxvar:"AV71TFBR_Medication_RXUnit_Sel",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV71TFBR_Medication_RXUnit_Sel=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV71TFBR_Medication_RXUnit_Sel=Value},v2c:function(){gx.fn.setControlValue("vTFBR_MEDICATION_RXUNIT_SEL",gx.O.AV71TFBR_Medication_RXUnit_Sel,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV71TFBR_Medication_RXUnit_Sel=this.val()},val:function(){return gx.fn.getControlValue("vTFBR_MEDICATION_RXUNIT_SEL")},nac:gx.falseFn};
   this.AV62BR_Medication_RXName = "" ;
   this.ZV62BR_Medication_RXName = "" ;
   this.OV62BR_Medication_RXName = "" ;
   this.ZV61Select = "" ;
   this.OV61Select = "" ;
   this.Z119BR_MedicationID = 0 ;
   this.O119BR_MedicationID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.Z121BR_Medication_RXName = "" ;
   this.O121BR_Medication_RXName = "" ;
   this.Z124BR_Medication_RXDose = 0 ;
   this.O124BR_Medication_RXDose = 0 ;
   this.Z125BR_Medication_RXUnit = "" ;
   this.O125BR_Medication_RXUnit = "" ;
   this.Z126BR_Medication_RXFrequency = "" ;
   this.O126BR_Medication_RXFrequency = "" ;
   this.Z127BR_Medication_RXQuantity = "" ;
   this.O127BR_Medication_RXQuantity = "" ;
   this.Z128BR_Medication_RXDaysSupply = 0 ;
   this.O128BR_Medication_RXDaysSupply = 0 ;
   this.Z132BR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.O132BR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.ZV21ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.OV21ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.ZV27ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.OV27ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.ZV29ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.OV29ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = "" ;
   this.ZV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = "" ;
   this.OV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = "" ;
   this.AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace = "" ;
   this.ZV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace = "" ;
   this.OV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = "" ;
   this.ZV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = "" ;
   this.OV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = "" ;
   this.AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "" ;
   this.ZV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "" ;
   this.OV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "" ;
   this.AV10OrderedBy = 0 ;
   this.ZV10OrderedBy = 0 ;
   this.OV10OrderedBy = 0 ;
   this.AV11OrderedDsc = false ;
   this.ZV11OrderedDsc = false ;
   this.OV11OrderedDsc = false ;
   this.AV70TFBR_Medication_RXUnit = "" ;
   this.ZV70TFBR_Medication_RXUnit = "" ;
   this.OV70TFBR_Medication_RXUnit = "" ;
   this.AV71TFBR_Medication_RXUnit_Sel = "" ;
   this.ZV71TFBR_Medication_RXUnit_Sel = "" ;
   this.OV71TFBR_Medication_RXUnit_Sel = "" ;
   this.AV62BR_Medication_RXName = "" ;
   this.AV58GridCurrentPage = 0 ;
   this.AV56DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = "" ;
   this.AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace = "" ;
   this.AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = "" ;
   this.AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "" ;
   this.AV10OrderedBy = 0 ;
   this.AV11OrderedDsc = false ;
   this.AV70TFBR_Medication_RXUnit = "" ;
   this.AV71TFBR_Medication_RXUnit_Sel = "" ;
   this.AV8InOutBR_MedicationID = 0 ;
   this.AV65InOutBR_Medication_RXName = "" ;
   this.AV66InOutBR_Medication_RXDose = 0 ;
   this.AV67InOutBR_Medication_RXUnit = "" ;
   this.AV61Select = "" ;
   this.A119BR_MedicationID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A121BR_Medication_RXName = "" ;
   this.A124BR_Medication_RXDose = 0 ;
   this.A125BR_Medication_RXUnit = "" ;
   this.A126BR_Medication_RXFrequency = "" ;
   this.A127BR_Medication_RXQuantity = "" ;
   this.A128BR_Medication_RXDaysSupply = 0 ;
   this.A132BR_Medication_AdmitStartDate = gx.date.nullDate() ;
   this.AV74Pgmname = "" ;
   this.Events = {"e118g2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e128g2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e138g2_client": ["DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED", true] ,"e148g2_client": ["DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED", true] ,"e158g2_client": ["DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED", true] ,"e168g2_client": ["DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED", true] ,"e178g2_client": ["DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED", true] ,"e188g2_client": ["DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED", true] ,"e198g2_client": ["DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED", true] ,"e238g2_client": ["ENTER", true] ,"e248g2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("TABLEMAIN","Height")',ctrl:'TABLEMAIN',prop:'Height'},{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXUNIT","Visible")',ctrl:'vTFBR_MEDICATION_RXUNIT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_MEDICATION_RXUNIT_SEL","Visible")',ctrl:'vTFBR_MEDICATION_RXUNIT_SEL',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'TitleControlIdToReplace'},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'TitleControlIdToReplace'},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'TitleControlIdToReplace'},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'TitleControlIdToReplace'},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'TitleControlIdToReplace'},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'TitleControlIdToReplace'},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'TitleControlIdToReplace'},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV56DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'ActiveEventKey'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.FilteredText_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'FilteredText_get'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SelectedValue_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SelectedValue_get'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_ADMITSTARTDATEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXFREQUENCYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXQUANTITYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'this.DDO_BR_MEDICATION_RXDAYSSUPPLYContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXFREQUENCY","Title")',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXQUANTITY","Title")',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDAYSSUPPLY","Title")',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_ADMITSTARTDATE","Title")',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[],[{av:'AV61Select',fld:'vSELECT',pic:''},{av:'gx.fn.getCtrlProperty("vSELECT","Tooltiptext")',ctrl:'vSELECT',prop:'Tooltiptext'}]];
   this.EvtParms["ENTER"] = [[{av:'A119BR_MedicationID',fld:'BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A121BR_Medication_RXName',fld:'BR_MEDICATION_RXNAME',pic:'',hsh:true},{av:'A124BR_Medication_RXDose',fld:'BR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ',hsh:true},{av:'A125BR_Medication_RXUnit',fld:'BR_MEDICATION_RXUNIT',pic:'',hsh:true}],[{av:'AV8InOutBR_MedicationID',fld:'vINOUTBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV65InOutBR_Medication_RXName',fld:'vINOUTBR_MEDICATION_RXNAME',pic:''},{av:'AV66InOutBR_Medication_RXDose',fld:'vINOUTBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV67InOutBR_Medication_RXUnit',fld:'vINOUTBR_MEDICATION_RXUNIT',pic:''}]];
   this.EnterCtrl = ["vSELECT"];
   this.setVCMap("AV74Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV8InOutBR_MedicationID", "vINOUTBR_MEDICATIONID", 0, "int", 18, 0);
   this.setVCMap("AV65InOutBR_Medication_RXName", "vINOUTBR_MEDICATION_RXNAME", 0, "svchar", 40, 0);
   this.setVCMap("AV66InOutBR_Medication_RXDose", "vINOUTBR_MEDICATION_RXDOSE", 0, "decimal", 15, 5);
   this.setVCMap("AV67InOutBR_Medication_RXUnit", "vINOUTBR_MEDICATION_RXUNIT", 0, "svchar", 100, 0);
   this.setVCMap("AV74Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV74Pgmname", "vPGMNAME", 0, "char", 129, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[26]);
   GridContainer.addRefreshingVar(this.GXValidFnc[65]);
   GridContainer.addRefreshingVar(this.GXValidFnc[66]);
   GridContainer.addRefreshingVar(this.GXValidFnc[67]);
   GridContainer.addRefreshingVar(this.GXValidFnc[68]);
   GridContainer.addRefreshingVar(this.GXValidFnc[51]);
   GridContainer.addRefreshingVar(this.GXValidFnc[53]);
   GridContainer.addRefreshingVar(this.GXValidFnc[55]);
   GridContainer.addRefreshingVar(this.GXValidFnc[57]);
   GridContainer.addRefreshingVar(this.GXValidFnc[59]);
   GridContainer.addRefreshingVar(this.GXValidFnc[61]);
   GridContainer.addRefreshingVar(this.GXValidFnc[63]);
   GridContainer.addRefreshingVar({rfrVar:"AV74Pgmname"});
   this.Initialize( );
});
gx.createParentObj(br_medicationpromptitl);
