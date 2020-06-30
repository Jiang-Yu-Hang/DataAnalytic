/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:46:23.49
*/
gx.evt.autoSkip = false;
gx.define('br_scheme_medicationprompt', false, function () {
   this.ServerClass =  "br_scheme_medicationprompt" ;
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
      this.AV8InOutBR_Scheme_MedicationID=gx.fn.getIntegerValue("vINOUTBR_SCHEME_MEDICATIONID",',') ;
   };
   this.Valid_Br_schemeid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("BR_SCHEMEID", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_medicationid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATIONID", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e116o2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e126o2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e136o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e146o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEMEID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e156o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATIONID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e166o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e176o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e186o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e196o2_client=function()
   {
      return this.executeServerEvent("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e236o2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e246o2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,21,22,23,25,26,27,29,31,33,35,37,39,41,43,44];
   this.GXLastCtrlId =44;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_scheme_medicationprompt",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Select","vSELECT",13,0,"px",17,"px","e236o2_client","","","SelectAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(332,14,"BR_SCHEME_MEDICATIONID","","","BR_Scheme_MedicationID","int",0,"px",18,18,"right",null,[],332,"BR_Scheme_MedicationID",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(327,15,"BR_SCHEMEID","","","BR_SchemeID","int",0,"px",18,18,"right",null,[],327,"BR_SchemeID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(119,16,"BR_MEDICATIONID","","","BR_MedicationID","int",0,"px",18,18,"right",null,[],119,"BR_MedicationID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(328,17,"BR_SCHEME_CHEM_REGIMENS","","","BR_Scheme_Chem_Regimens","svchar",0,"px",100,80,"left",null,[],328,"BR_Scheme_Chem_Regimens",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(121,18,"BR_MEDICATION_RXNAME","","","BR_Medication_RXName","svchar",0,"px",40,40,"left",null,[],121,"BR_Medication_RXName",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(124,19,"BR_MEDICATION_RXDOSE","","","BR_Medication_RXDose","decimal",0,"px",15,15,"right",null,[],124,"BR_Medication_RXDose",true,5,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(125,20,"BR_MEDICATION_RXUNIT","","","BR_Medication_RXUnit","svchar",0,"px",100,80,"left",null,[],125,"BR_Medication_RXUnit",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 24, 13, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV28GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV28GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV28GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV30GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV30GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV30GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV29GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV29GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV29GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e116o2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e126o2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_SCHEME_MEDICATIONIDContainer = gx.uc.getNew(this, 28, 13, "BootstrapDropDownOptions", "DDO_BR_SCHEME_MEDICATIONIDContainer", "Ddo_br_scheme_medicationid", "DDO_BR_SCHEME_MEDICATIONID");
   var DDO_BR_SCHEME_MEDICATIONIDContainer = this.DDO_BR_SCHEME_MEDICATIONIDContainer;
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEME_MEDICATIONIDContainer.addV2CFunction('AV26DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEME_MEDICATIONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV26DDO_TitleSettingsIcons); });
   DDO_BR_SCHEME_MEDICATIONIDContainer.addV2CFunction('AV12BR_Scheme_MedicationIDTitleFilterData', "vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEME_MEDICATIONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV12BR_Scheme_MedicationIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA",UC.ParentObject.AV12BR_Scheme_MedicationIDTitleFilterData); });
   DDO_BR_SCHEME_MEDICATIONIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEME_MEDICATIONIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEME_MEDICATIONIDContainer.addEventHandler("OnOptionClicked", this.e136o2_client);
   this.setUserControl(DDO_BR_SCHEME_MEDICATIONIDContainer);
   this.DDO_BR_SCHEMEIDContainer = gx.uc.getNew(this, 30, 29, "BootstrapDropDownOptions", "DDO_BR_SCHEMEIDContainer", "Ddo_br_schemeid", "DDO_BR_SCHEMEID");
   var DDO_BR_SCHEMEIDContainer = this.DDO_BR_SCHEMEIDContainer;
   DDO_BR_SCHEMEIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEMEIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEMEIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEMEIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEMEIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEMEIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEMEIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEMEIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_SCHEMEIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_SCHEMEIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_SCHEMEIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_SCHEMEIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEMEIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEMEIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEMEIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_SCHEMEIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEMEIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEMEIDContainer.addV2CFunction('AV26DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEMEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV26DDO_TitleSettingsIcons); });
   DDO_BR_SCHEMEIDContainer.addV2CFunction('AV14BR_SchemeIDTitleFilterData', "vBR_SCHEMEIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEMEIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV14BR_SchemeIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEMEIDTITLEFILTERDATA",UC.ParentObject.AV14BR_SchemeIDTitleFilterData); });
   DDO_BR_SCHEMEIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEMEIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEMEIDContainer.addEventHandler("OnOptionClicked", this.e146o2_client);
   this.setUserControl(DDO_BR_SCHEMEIDContainer);
   this.DDO_BR_MEDICATIONIDContainer = gx.uc.getNew(this, 32, 29, "BootstrapDropDownOptions", "DDO_BR_MEDICATIONIDContainer", "Ddo_br_medicationid", "DDO_BR_MEDICATIONID");
   var DDO_BR_MEDICATIONIDContainer = this.DDO_BR_MEDICATIONIDContainer;
   DDO_BR_MEDICATIONIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_MEDICATIONIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_MEDICATIONIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATIONIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATIONIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATIONIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATIONIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATIONIDContainer.addV2CFunction('AV26DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATIONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV26DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATIONIDContainer.addV2CFunction('AV16BR_MedicationIDTitleFilterData', "vBR_MEDICATIONIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATIONIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV16BR_MedicationIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATIONIDTITLEFILTERDATA",UC.ParentObject.AV16BR_MedicationIDTitleFilterData); });
   DDO_BR_MEDICATIONIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATIONIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATIONIDContainer.addEventHandler("OnOptionClicked", this.e156o2_client);
   this.setUserControl(DDO_BR_MEDICATIONIDContainer);
   this.DDO_BR_SCHEME_CHEM_REGIMENSContainer = gx.uc.getNew(this, 34, 29, "BootstrapDropDownOptions", "DDO_BR_SCHEME_CHEM_REGIMENSContainer", "Ddo_br_scheme_chem_regimens", "DDO_BR_SCHEME_CHEM_REGIMENS");
   var DDO_BR_SCHEME_CHEM_REGIMENSContainer = this.DDO_BR_SCHEME_CHEM_REGIMENSContainer;
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Class", "Class", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addV2CFunction('AV26DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV26DDO_TitleSettingsIcons); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addV2CFunction('AV18BR_Scheme_Chem_RegimensTitleFilterData', "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addC2VFunction(function(UC) { UC.ParentObject.AV18BR_Scheme_Chem_RegimensTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA",UC.ParentObject.AV18BR_Scheme_Chem_RegimensTitleFilterData); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_SCHEME_CHEM_REGIMENSContainer.addEventHandler("OnOptionClicked", this.e166o2_client);
   this.setUserControl(DDO_BR_SCHEME_CHEM_REGIMENSContainer);
   this.DDO_BR_MEDICATION_RXNAMEContainer = gx.uc.getNew(this, 36, 29, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXNAMEContainer", "Ddo_br_medication_rxname", "DDO_BR_MEDICATION_RXNAME");
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
   DDO_BR_MEDICATION_RXNAMEContainer.addV2CFunction('AV26DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV26DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXNAMEContainer.addV2CFunction('AV20BR_Medication_RXNameTitleFilterData', "vBR_MEDICATION_RXNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20BR_Medication_RXNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXNAMETITLEFILTERDATA",UC.ParentObject.AV20BR_Medication_RXNameTitleFilterData); });
   DDO_BR_MEDICATION_RXNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXNAMEContainer.addEventHandler("OnOptionClicked", this.e176o2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXNAMEContainer);
   this.DDO_BR_MEDICATION_RXDOSEContainer = gx.uc.getNew(this, 38, 29, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXDOSEContainer", "Ddo_br_medication_rxdose", "DDO_BR_MEDICATION_RXDOSE");
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
   DDO_BR_MEDICATION_RXDOSEContainer.addV2CFunction('AV26DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXDOSEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV26DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXDOSEContainer.addV2CFunction('AV22BR_Medication_RXDoseTitleFilterData', "vBR_MEDICATION_RXDOSETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXDOSEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV22BR_Medication_RXDoseTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXDOSETITLEFILTERDATA",UC.ParentObject.AV22BR_Medication_RXDoseTitleFilterData); });
   DDO_BR_MEDICATION_RXDOSEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXDOSEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXDOSEContainer.addEventHandler("OnOptionClicked", this.e186o2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXDOSEContainer);
   this.DDO_BR_MEDICATION_RXUNITContainer = gx.uc.getNew(this, 40, 29, "BootstrapDropDownOptions", "DDO_BR_MEDICATION_RXUNITContainer", "Ddo_br_medication_rxunit", "DDO_BR_MEDICATION_RXUNIT");
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
   DDO_BR_MEDICATION_RXUNITContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_MEDICATION_RXUNITContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_MEDICATION_RXUNITContainer.addV2CFunction('AV26DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_MEDICATION_RXUNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV26DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV26DDO_TitleSettingsIcons); });
   DDO_BR_MEDICATION_RXUNITContainer.addV2CFunction('AV24BR_Medication_RXUnitTitleFilterData', "vBR_MEDICATION_RXUNITTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_MEDICATION_RXUNITContainer.addC2VFunction(function(UC) { UC.ParentObject.AV24BR_Medication_RXUnitTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_MEDICATION_RXUNITTITLEFILTERDATA",UC.ParentObject.AV24BR_Medication_RXUnitTitleFilterData); });
   DDO_BR_MEDICATION_RXUNITContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_MEDICATION_RXUNITContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_MEDICATION_RXUNITContainer.addEventHandler("OnOptionClicked", this.e196o2_client);
   this.setUserControl(DDO_BR_MEDICATION_RXUNITContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 42, 29, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[9]={ id: 9, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[13]={ id:13 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSELECT",gxz:"ZV31Select",gxold:"OV31Select",gxvar:"AV31Select",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV31Select=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV31Select=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vSELECT",row || gx.fn.currentGridRowImpl(12),gx.O.AV31Select,gx.O.AV38Select_GXI)},c2v:function(){gx.O.AV38Select_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV31Select=this.val()},val:function(row){return gx.fn.getGridControlValue("vSELECT",row || gx.fn.currentGridRowImpl(12))},val_GXI:function(row){return gx.fn.getGridControlValue("vSELECT_GXI",row || gx.fn.currentGridRowImpl(12))}, gxvar_GXI:'AV38Select_GXI',nac:gx.falseFn,evt:"e236o2_client",std:"ENTER"};
   GXValidFnc[14]={ id:14 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_MEDICATIONID",gxz:"Z332BR_Scheme_MedicationID",gxold:"O332BR_Scheme_MedicationID",gxvar:"A332BR_Scheme_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A332BR_Scheme_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z332BR_Scheme_MedicationID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEME_MEDICATIONID",row || gx.fn.currentGridRowImpl(12),gx.O.A332BR_Scheme_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A332BR_Scheme_MedicationID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_SCHEME_MEDICATIONID",row || gx.fn.currentGridRowImpl(12),',')},nac:gx.falseFn};
   GXValidFnc[15]={ id:15 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Br_schemeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEMEID",gxz:"Z327BR_SchemeID",gxold:"O327BR_SchemeID",gxvar:"A327BR_SchemeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z327BR_SchemeID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEMEID",row || gx.fn.currentGridRowImpl(12),gx.O.A327BR_SchemeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_SCHEMEID",row || gx.fn.currentGridRowImpl(12),',')},nac:gx.falseFn};
   GXValidFnc[16]={ id:16 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Br_medicationid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z119BR_MedicationID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(12),gx.O.A119BR_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_MEDICATIONID",row || gx.fn.currentGridRowImpl(12),',')},nac:gx.falseFn};
   GXValidFnc[17]={ id:17 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_REGIMENS",gxz:"Z328BR_Scheme_Chem_Regimens",gxold:"O328BR_Scheme_Chem_Regimens",gxvar:"A328BR_Scheme_Chem_Regimens",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z328BR_Scheme_Chem_Regimens=Value},v2c:function(row){gx.fn.setGridControlValue("BR_SCHEME_CHEM_REGIMENS",row || gx.fn.currentGridRowImpl(12),gx.O.A328BR_Scheme_Chem_Regimens,0)},c2v:function(){if(this.val()!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_SCHEME_CHEM_REGIMENS",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[18]={ id:18 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXNAME",gxz:"Z121BR_Medication_RXName",gxold:"O121BR_Medication_RXName",gxvar:"A121BR_Medication_RXName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A121BR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z121BR_Medication_RXName=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXNAME",row || gx.fn.currentGridRowImpl(12),gx.O.A121BR_Medication_RXName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A121BR_Medication_RXName=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXNAME",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[19]={ id:19 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDOSE",gxz:"Z124BR_Medication_RXDose",gxold:"O124BR_Medication_RXDose",gxvar:"A124BR_Medication_RXDose",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_MEDICATION_RXDOSE",row || gx.fn.currentGridRowImpl(12),gx.O.A124BR_Medication_RXDose,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A124BR_Medication_RXDose=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_MEDICATION_RXDOSE",row || gx.fn.currentGridRowImpl(12),',','.')},nac:gx.falseFn};
   GXValidFnc[20]={ id:20 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXUNIT",gxz:"Z125BR_Medication_RXUnit",gxold:"O125BR_Medication_RXUnit",gxvar:"A125BR_Medication_RXUnit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A125BR_Medication_RXUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z125BR_Medication_RXUnit=Value},v2c:function(row){gx.fn.setGridControlValue("BR_MEDICATION_RXUNIT",row || gx.fn.currentGridRowImpl(12),gx.O.A125BR_Medication_RXUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.A125BR_Medication_RXUnit=this.val()},val:function(row){return gx.fn.getGridControlValue("BR_MEDICATION_RXUNIT",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE",gxz:"ZV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace",gxold:"OV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace",gxvar:"AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE",gx.O.AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[31]={ id:31 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE",gxz:"ZV15ddo_BR_SchemeIDTitleControlIdToReplace",gxold:"OV15ddo_BR_SchemeIDTitleControlIdToReplace",gxvar:"AV15ddo_BR_SchemeIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15ddo_BR_SchemeIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV15ddo_BR_SchemeIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE",gx.O.AV15ddo_BR_SchemeIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15ddo_BR_SchemeIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE",gxz:"ZV17ddo_BR_MedicationIDTitleControlIdToReplace",gxold:"OV17ddo_BR_MedicationIDTitleControlIdToReplace",gxvar:"AV17ddo_BR_MedicationIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17ddo_BR_MedicationIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV17ddo_BR_MedicationIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE",gx.O.AV17ddo_BR_MedicationIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17ddo_BR_MedicationIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[35]={ id:35 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE",gxz:"ZV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",gxold:"OV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",gxvar:"AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE",gx.O.AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE",gxz:"ZV21ddo_BR_Medication_RXNameTitleControlIdToReplace",gxold:"OV21ddo_BR_Medication_RXNameTitleControlIdToReplace",gxvar:"AV21ddo_BR_Medication_RXNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV21ddo_BR_Medication_RXNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV21ddo_BR_Medication_RXNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE",gx.O.AV21ddo_BR_Medication_RXNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV21ddo_BR_Medication_RXNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE",gxz:"ZV23ddo_BR_Medication_RXDoseTitleControlIdToReplace",gxold:"OV23ddo_BR_Medication_RXDoseTitleControlIdToReplace",gxvar:"AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23ddo_BR_Medication_RXDoseTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE",gx.O.AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE",gxz:"ZV25ddo_BR_Medication_RXUnitTitleControlIdToReplace",gxold:"OV25ddo_BR_Medication_RXUnitTitleControlIdToReplace",gxvar:"AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV25ddo_BR_Medication_RXUnitTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE",gx.O.AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV10OrderedBy",gxold:"OV10OrderedBy",gxvar:"AV10OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV10OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV10OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV10OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV10OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV11OrderedDsc",gxold:"OV11OrderedDsc",gxvar:"AV11OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV11OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV11OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV11OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV11OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.ZV31Select = "" ;
   this.OV31Select = "" ;
   this.Z332BR_Scheme_MedicationID = 0 ;
   this.O332BR_Scheme_MedicationID = 0 ;
   this.Z327BR_SchemeID = 0 ;
   this.O327BR_SchemeID = 0 ;
   this.Z119BR_MedicationID = 0 ;
   this.O119BR_MedicationID = 0 ;
   this.Z328BR_Scheme_Chem_Regimens = "" ;
   this.O328BR_Scheme_Chem_Regimens = "" ;
   this.Z121BR_Medication_RXName = "" ;
   this.O121BR_Medication_RXName = "" ;
   this.Z124BR_Medication_RXDose = 0 ;
   this.O124BR_Medication_RXDose = 0 ;
   this.Z125BR_Medication_RXUnit = "" ;
   this.O125BR_Medication_RXUnit = "" ;
   this.AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = "" ;
   this.ZV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = "" ;
   this.OV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = "" ;
   this.AV15ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.ZV15ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.OV15ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.AV17ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.ZV17ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.OV17ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.ZV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.OV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.ZV21ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.OV21ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.ZV23ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.OV23ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.ZV25ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.OV25ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.AV10OrderedBy = 0 ;
   this.ZV10OrderedBy = 0 ;
   this.OV10OrderedBy = 0 ;
   this.AV11OrderedDsc = false ;
   this.ZV11OrderedDsc = false ;
   this.OV11OrderedDsc = false ;
   this.AV28GridCurrentPage = 0 ;
   this.AV26DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = "" ;
   this.AV15ddo_BR_SchemeIDTitleControlIdToReplace = "" ;
   this.AV17ddo_BR_MedicationIDTitleControlIdToReplace = "" ;
   this.AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "" ;
   this.AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = "" ;
   this.AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace = "" ;
   this.AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace = "" ;
   this.AV10OrderedBy = 0 ;
   this.AV11OrderedDsc = false ;
   this.AV8InOutBR_Scheme_MedicationID = 0 ;
   this.AV31Select = "" ;
   this.A332BR_Scheme_MedicationID = 0 ;
   this.A327BR_SchemeID = 0 ;
   this.A119BR_MedicationID = 0 ;
   this.A328BR_Scheme_Chem_Regimens = "" ;
   this.A121BR_Medication_RXName = "" ;
   this.A124BR_Medication_RXDose = 0 ;
   this.A125BR_Medication_RXUnit = "" ;
   this.Events = {"e116o2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e126o2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e136o2_client": ["DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED", true] ,"e146o2_client": ["DDO_BR_SCHEMEID.ONOPTIONCLICKED", true] ,"e156o2_client": ["DDO_BR_MEDICATIONID.ONOPTIONCLICKED", true] ,"e166o2_client": ["DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED", true] ,"e176o2_client": ["DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED", true] ,"e186o2_client": ["DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED", true] ,"e196o2_client": ["DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED", true] ,"e236o2_client": ["ENTER", true] ,"e246o2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'}],[{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV37Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'}],[{av:'gx.fn.getCtrlProperty("TABLEMAIN","Height")',ctrl:'TABLEMAIN',prop:'Height'},{ctrl:'GRID',prop:'Rows'},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'TitleControlIdToReplace'},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_SCHEMEIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEMEID',prop:'TitleControlIdToReplace'},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATIONIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATIONID',prop:'TitleControlIdToReplace'},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.TitleControlIdToReplace',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'TitleControlIdToReplace'},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'TitleControlIdToReplace'},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'TitleControlIdToReplace'},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.TitleControlIdToReplace',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'TitleControlIdToReplace'},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV26DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEME_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_SCHEMEID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_BR_SCHEMEIDContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEMEID',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEMEIDContainer.SortedStatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATIONID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_BR_MEDICATIONIDContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATIONID',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATIONIDContainer.SortedStatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.ActiveEventKey',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_SCHEME_CHEM_REGIMENSContainer.SortedStatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXNAMEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXDOSEContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.ActiveEventKey',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'ActiveEventKey'}],[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_MEDICATION_RXUNITContainer.SortedStatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Title")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Title")',ctrl:'BR_SCHEMEID',prop:'Title'},{ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATIONID","Title")',ctrl:'BR_MEDICATIONID',prop:'Title'},{ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_SCHEME_CHEM_REGIMENS","Title")',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXNAME","Title")',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXDOSE","Title")',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_RXUNIT","Title")',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[],[{av:'AV31Select',fld:'vSELECT',pic:''},{av:'gx.fn.getCtrlProperty("vSELECT","Tooltiptext")',ctrl:'vSELECT',prop:'Tooltiptext'}]];
   this.EvtParms["ENTER"] = [[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV8InOutBR_Scheme_MedicationID',fld:'vINOUTBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.EnterCtrl = ["vSELECT"];
   this.setVCMap("AV8InOutBR_Scheme_MedicationID", "vINOUTBR_SCHEME_MEDICATIONID", 0, "int", 18, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[43]);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[29]);
   GridContainer.addRefreshingVar(this.GXValidFnc[31]);
   GridContainer.addRefreshingVar(this.GXValidFnc[33]);
   GridContainer.addRefreshingVar(this.GXValidFnc[35]);
   GridContainer.addRefreshingVar(this.GXValidFnc[37]);
   GridContainer.addRefreshingVar(this.GXValidFnc[39]);
   GridContainer.addRefreshingVar(this.GXValidFnc[41]);
   this.Initialize( );
});
gx.createParentObj(br_scheme_medicationprompt);
