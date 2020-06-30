/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:34:26.34
*/
gx.evt.autoSkip = false;
gx.define('br_encountercheckvitalwc', true, function (CmpContext) {
   this.ServerClass =  "br_encountercheckvitalwc" ;
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
      this.AV64Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV58IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
      this.AV8BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV8BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV64Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV58IsAuthorized_Display=gx.fn.getControlValue("vISAUTHORIZED_DISPLAY") ;
   };
   this.Validv_Tfbr_vital_measuredate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_VITAL_MEASUREDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV22TFBR_Vital_MeasureDate)==0) || new gx.date.gxdate( this.AV22TFBR_Vital_MeasureDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Vital_Measure Date瓒呯晫");
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
   this.Validv_Tfbr_vital_measuredate_to=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vTFBR_VITAL_MEASUREDATE_TO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV23TFBR_Vital_MeasureDate_To)==0) || new gx.date.gxdate( this.AV23TFBR_Vital_MeasureDate_To ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烼FBR_Vital_Measure Date_To瓒呯晫");
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
   this.Validv_Ddo_br_vital_measuredateauxdate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_VITAL_MEASUREDATEAUXDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV24DDO_BR_Vital_MeasureDateAuxDate)==0) || new gx.date.gxdate( this.AV24DDO_BR_Vital_MeasureDateAuxDate ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Vital_Measure Date Aux Date瓒呯晫");
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
   this.Validv_Ddo_br_vital_measuredateauxdateto=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("vDDO_BR_VITAL_MEASUREDATEAUXDATETO");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.AV25DDO_BR_Vital_MeasureDateAuxDateTo)==0) || new gx.date.gxdate( this.AV25DDO_BR_Vital_MeasureDateAuxDateTo ).compare( gx.date.ymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩烡DO_BR_Vital_Measure Date Aux Date To瓒呯晫");
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
      if ( this.AV14OrderedBy == 1 )
      {
         this.DDO_BR_VITALIDContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 2 )
      {
         this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 3 )
      {
         this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
      else if ( this.AV14OrderedBy == 4 )
      {
         this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus =  (this.AV15OrderedDsc ? "DSC" : "ASC")  ;
      }
   };
   this.s162_client=function()
   {
      this.DDO_BR_VITALIDContainer.SortedStatus =  ""  ;
      this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus =  ""  ;
      this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus =  ""  ;
      this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus =  ""  ;
   };
   this.e11612_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12612_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13612_client=function()
   {
      return this.executeServerEvent("DDO_BR_VITALID.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14612_client=function()
   {
      return this.executeServerEvent("DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e15612_client=function()
   {
      return this.executeServerEvent("DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e16612_client=function()
   {
      return this.executeServerEvent("DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e20612_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e21612_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,19,20,22,23,24,26,28,30,32,33,35,36,37,38,39,40,41,42,43,44,45,46,47];
   this.GXLastCtrlId =47;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"br_encountercheckvitalwc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Display","vDISPLAY",13,0,"px",17,"px",null,"","","ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(150,14,"BR_VITALID","","","BR_VitalID","int",0,"px",18,18,"right",null,[],150,"BR_VitalID",true,0,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(152,15,"BR_VITAL_MEASUREDATE","","","BR_Vital_MeasureDate","date",0,"px",10,10,"right",null,[],152,"BR_Vital_MeasureDate",true,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(159,16,"BR_VITAL_WEIGHT","","","BR_Vital_Weight","decimal",0,"px",15,15,"right",null,[],159,"BR_Vital_Weight",true,5,false,false,"Attribute",1,"WWColumn hidden-xs hidden-sm");
   GridContainer.addSingleLineEdit(153,17,"BR_VITAL_TEMPERATURE","","","BR_Vital_Temperature","decimal",0,"px",15,15,"right",null,[],153,"BR_Vital_Temperature",true,5,false,false,"Attribute",1,"WWColumn");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 21, 13, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV54GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV54GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV54GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV56GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV56GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV56GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV55GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV55GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV55GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11612_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12612_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_BR_VITALIDContainer = gx.uc.getNew(this, 25, 13, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_VITALIDContainer", "Ddo_br_vitalid", "DDO_BR_VITALID");
   var DDO_BR_VITALIDContainer = this.DDO_BR_VITALIDContainer;
   DDO_BR_VITALIDContainer.setProp("Class", "Class", "", "char");
   DDO_BR_VITALIDContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_VITALIDContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_VITALIDContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_VITALIDContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_VITALIDContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_VITALIDContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_VITALIDContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_VITALIDContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_VITALIDContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_VITALIDContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_VITALIDContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_VITALIDContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_VITALIDContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_VITALIDContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_VITALIDContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_VITALIDContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_VITALIDContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_VITALIDContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_VITALIDContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_VITALIDContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_VITALIDContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_VITALIDContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_VITALIDContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_VITALIDContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_VITALIDContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_VITALIDContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_VITALIDContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_VITALIDContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_VITALIDContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_VITALIDContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_VITALIDContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_VITALIDContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_VITALIDContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_VITALIDContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_VITALIDContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_VITALIDContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_VITALIDContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_VITALIDContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_VITALIDContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_VITALIDContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_VITALIDContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_VITALIDContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_VITALIDContainer.addV2CFunction('AV51DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_VITALIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV51DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV51DDO_TitleSettingsIcons); });
   DDO_BR_VITALIDContainer.addV2CFunction('AV17BR_VitalIDTitleFilterData', "vBR_VITALIDTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_VITALIDContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17BR_VitalIDTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_VITALIDTITLEFILTERDATA",UC.ParentObject.AV17BR_VitalIDTitleFilterData); });
   DDO_BR_VITALIDContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_VITALIDContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_VITALIDContainer.addEventHandler("OnOptionClicked", this.e13612_client);
   this.setUserControl(DDO_BR_VITALIDContainer);
   this.DDO_BR_VITAL_MEASUREDATEContainer = gx.uc.getNew(this, 27, 26, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_VITAL_MEASUREDATEContainer", "Ddo_br_vital_measuredate", "DDO_BR_VITAL_MEASUREDATE");
   var DDO_BR_VITAL_MEASUREDATEContainer = this.DDO_BR_VITAL_MEASUREDATEContainer;
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Class", "Class", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FilterType", "Filtertype", "Date", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_VITAL_MEASUREDATEContainer.addV2CFunction('AV51DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_VITAL_MEASUREDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV51DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV51DDO_TitleSettingsIcons); });
   DDO_BR_VITAL_MEASUREDATEContainer.addV2CFunction('AV21BR_Vital_MeasureDateTitleFilterData', "vBR_VITAL_MEASUREDATETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_VITAL_MEASUREDATEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21BR_Vital_MeasureDateTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_VITAL_MEASUREDATETITLEFILTERDATA",UC.ParentObject.AV21BR_Vital_MeasureDateTitleFilterData); });
   DDO_BR_VITAL_MEASUREDATEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_VITAL_MEASUREDATEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_VITAL_MEASUREDATEContainer.addEventHandler("OnOptionClicked", this.e14612_client);
   this.setUserControl(DDO_BR_VITAL_MEASUREDATEContainer);
   this.DDO_BR_VITAL_WEIGHTContainer = gx.uc.getNew(this, 29, 26, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_VITAL_WEIGHTContainer", "Ddo_br_vital_weight", "DDO_BR_VITAL_WEIGHT");
   var DDO_BR_VITAL_WEIGHTContainer = this.DDO_BR_VITAL_WEIGHTContainer;
   DDO_BR_VITAL_WEIGHTContainer.setProp("Class", "Class", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_VITAL_WEIGHTContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_VITAL_WEIGHTContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_VITAL_WEIGHTContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_VITAL_WEIGHTContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_VITAL_WEIGHTContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_VITAL_WEIGHTContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_VITAL_WEIGHTContainer.addV2CFunction('AV51DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_VITAL_WEIGHTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV51DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV51DDO_TitleSettingsIcons); });
   DDO_BR_VITAL_WEIGHTContainer.addV2CFunction('AV27BR_Vital_WeightTitleFilterData', "vBR_VITAL_WEIGHTTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_VITAL_WEIGHTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV27BR_Vital_WeightTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_VITAL_WEIGHTTITLEFILTERDATA",UC.ParentObject.AV27BR_Vital_WeightTitleFilterData); });
   DDO_BR_VITAL_WEIGHTContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_VITAL_WEIGHTContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_VITAL_WEIGHTContainer.addEventHandler("OnOptionClicked", this.e15612_client);
   this.setUserControl(DDO_BR_VITAL_WEIGHTContainer);
   this.DDO_BR_VITAL_TEMPERATUREContainer = gx.uc.getNew(this, 31, 26, "BootstrapDropDownOptions", this.CmpContext + "DDO_BR_VITAL_TEMPERATUREContainer", "Ddo_br_vital_temperature", "DDO_BR_VITAL_TEMPERATURE");
   var DDO_BR_VITAL_TEMPERATUREContainer = this.DDO_BR_VITAL_TEMPERATUREContainer;
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Class", "Class", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Icon", "Icon", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Caption", "Caption", "", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setDynProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setDynProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("IncludeFilter", "Includefilter", true, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("FilterType", "Filtertype", "Numeric", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("FilterIsRange", "Filterisrange", true, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("CleanFilter", "Cleanfilter", "WWP_TSCleanFilter", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "WWP_TSFrom", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("RangeFilterTo", "Rangefilterto", "WWP_TSTo", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_BR_VITAL_TEMPERATUREContainer.addV2CFunction('AV51DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_BR_VITAL_TEMPERATUREContainer.addC2VFunction(function(UC) { UC.ParentObject.AV51DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV51DDO_TitleSettingsIcons); });
   DDO_BR_VITAL_TEMPERATUREContainer.addV2CFunction('AV31BR_Vital_TemperatureTitleFilterData', "vBR_VITAL_TEMPERATURETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_BR_VITAL_TEMPERATUREContainer.addC2VFunction(function(UC) { UC.ParentObject.AV31BR_Vital_TemperatureTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vBR_VITAL_TEMPERATURETITLEFILTERDATA",UC.ParentObject.AV31BR_Vital_TemperatureTitleFilterData); });
   DDO_BR_VITAL_TEMPERATUREContainer.setProp("Visible", "Visible", true, "bool");
   DDO_BR_VITAL_TEMPERATUREContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_BR_VITAL_TEMPERATUREContainer.addEventHandler("OnOptionClicked", this.e16612_client);
   this.setUserControl(DDO_BR_VITAL_TEMPERATUREContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 34, 26, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[6]={ id: 6, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[13]={ id:13 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDISPLAY",gxz:"ZV57Display",gxold:"OV57Display",gxvar:"AV57Display",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV57Display=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV57Display=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vDISPLAY",row || gx.fn.currentGridRowImpl(12),gx.O.AV57Display,gx.O.AV63Display_GXI)},c2v:function(){gx.O.AV63Display_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV57Display=this.val()},val:function(row){return gx.fn.getGridControlValue("vDISPLAY",row || gx.fn.currentGridRowImpl(12))},val_GXI:function(row){return gx.fn.getGridControlValue("vDISPLAY_GXI",row || gx.fn.currentGridRowImpl(12))}, gxvar_GXI:'AV63Display_GXI',nac:gx.falseFn};
   GXValidFnc[14]={ id:14 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITALID",gxz:"Z150BR_VitalID",gxold:"O150BR_VitalID",gxvar:"A150BR_VitalID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A150BR_VitalID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z150BR_VitalID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_VITALID",row || gx.fn.currentGridRowImpl(12),gx.O.A150BR_VitalID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A150BR_VitalID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("BR_VITALID",row || gx.fn.currentGridRowImpl(12),',')},nac:gx.falseFn};
   GXValidFnc[15]={ id:15 ,lvl:2,type:"date",len:10,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_MEASUREDATE",gxz:"Z152BR_Vital_MeasureDate",gxold:"O152BR_Vital_MeasureDate",gxvar:"A152BR_Vital_MeasureDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A152BR_Vital_MeasureDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z152BR_Vital_MeasureDate=gx.fn.toDatetimeValue(Value)},v2c:function(row){gx.fn.setGridControlValue("BR_VITAL_MEASUREDATE",row || gx.fn.currentGridRowImpl(12),gx.O.A152BR_Vital_MeasureDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A152BR_Vital_MeasureDate=gx.fn.toDatetimeValue(this.val())},val:function(row){return gx.fn.getGridDateTimeValue("BR_VITAL_MEASUREDATE",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[16]={ id:16 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_WEIGHT",gxz:"Z159BR_Vital_Weight",gxold:"O159BR_Vital_Weight",gxvar:"A159BR_Vital_Weight",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A159BR_Vital_Weight=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z159BR_Vital_Weight=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_VITAL_WEIGHT",row || gx.fn.currentGridRowImpl(12),gx.O.A159BR_Vital_Weight,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A159BR_Vital_Weight=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_VITAL_WEIGHT",row || gx.fn.currentGridRowImpl(12),',','.')},nac:gx.falseFn};
   GXValidFnc[17]={ id:17 ,lvl:2,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_VITAL_TEMPERATURE",gxz:"Z153BR_Vital_Temperature",gxold:"O153BR_Vital_Temperature",gxvar:"A153BR_Vital_Temperature",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.A153BR_Vital_Temperature=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z153BR_Vital_Temperature=gx.fn.toDecimalValue(Value,',','.')},v2c:function(row){gx.fn.setGridDecimalValue("BR_VITAL_TEMPERATURE",row || gx.fn.currentGridRowImpl(12),gx.O.A153BR_Vital_Temperature,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A153BR_Vital_Temperature=this.val()},val:function(row){return gx.fn.getGridDecimalValue("BR_VITAL_TEMPERATURE",row || gx.fn.currentGridRowImpl(12),',','.')},nac:gx.falseFn};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE",gxz:"ZV20ddo_BR_VitalIDTitleControlIdToReplace",gxold:"OV20ddo_BR_VitalIDTitleControlIdToReplace",gxvar:"AV20ddo_BR_VitalIDTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20ddo_BR_VitalIDTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20ddo_BR_VitalIDTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE",gx.O.AV20ddo_BR_VitalIDTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20ddo_BR_VitalIDTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[28]={ id:28 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE",gxz:"ZV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace",gxold:"OV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace",gxvar:"AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE",gx.O.AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE",gxz:"ZV30ddo_BR_Vital_WeightTitleControlIdToReplace",gxold:"OV30ddo_BR_Vital_WeightTitleControlIdToReplace",gxvar:"AV30ddo_BR_Vital_WeightTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV30ddo_BR_Vital_WeightTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV30ddo_BR_Vital_WeightTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE",gx.O.AV30ddo_BR_Vital_WeightTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV30ddo_BR_Vital_WeightTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[32]={ id:32 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE",gxz:"ZV34ddo_BR_Vital_TemperatureTitleControlIdToReplace",gxold:"OV34ddo_BR_Vital_TemperatureTitleControlIdToReplace",gxvar:"AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV34ddo_BR_Vital_TemperatureTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE",gx.O.AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[33]={ id:33 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 33 , function() {
   });
   GXValidFnc[35]={ id:35 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV14OrderedBy",gxold:"OV14OrderedBy",gxvar:"AV14OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV14OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV14OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[36]={ id:36 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV15OrderedDsc",gxold:"OV15OrderedDsc",gxvar:"AV15OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV15OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV15OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV15OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_VITALID",gxz:"ZV18TFBR_VitalID",gxold:"OV18TFBR_VitalID",gxvar:"AV18TFBR_VitalID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18TFBR_VitalID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV18TFBR_VitalID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_VITALID",gx.O.AV18TFBR_VitalID,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18TFBR_VitalID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_VITALID",',')},nac:gx.falseFn};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_VITALID_TO",gxz:"ZV19TFBR_VitalID_To",gxold:"OV19TFBR_VitalID_To",gxvar:"AV19TFBR_VitalID_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19TFBR_VitalID_To=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV19TFBR_VitalID_To=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_VITALID_TO",gx.O.AV19TFBR_VitalID_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19TFBR_VitalID_To=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vTFBR_VITALID_TO",',')},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_vital_measuredate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_VITAL_MEASUREDATE",gxz:"ZV22TFBR_Vital_MeasureDate",gxold:"OV22TFBR_Vital_MeasureDate",gxvar:"AV22TFBR_Vital_MeasureDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[39],ip:[39],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22TFBR_Vital_MeasureDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22TFBR_Vital_MeasureDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_VITAL_MEASUREDATE",gx.O.AV22TFBR_Vital_MeasureDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22TFBR_Vital_MeasureDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vTFBR_VITAL_MEASUREDATE")},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Tfbr_vital_measuredate_to,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_VITAL_MEASUREDATE_TO",gxz:"ZV23TFBR_Vital_MeasureDate_To",gxold:"OV23TFBR_Vital_MeasureDate_To",gxvar:"AV23TFBR_Vital_MeasureDate_To",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[40],ip:[40],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23TFBR_Vital_MeasureDate_To=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV23TFBR_Vital_MeasureDate_To=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vTFBR_VITAL_MEASUREDATE_TO",gx.O.AV23TFBR_Vital_MeasureDate_To,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23TFBR_Vital_MeasureDate_To=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vTFBR_VITAL_MEASUREDATE_TO")},nac:gx.falseFn};
   GXValidFnc[41]={ id: 41, fld:"DDO_BR_VITAL_MEASUREDATEAUXDATES",grid:0};
   GXValidFnc[42]={ id:42 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_vital_measuredateauxdate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_VITAL_MEASUREDATEAUXDATE",gxz:"ZV24DDO_BR_Vital_MeasureDateAuxDate",gxold:"OV24DDO_BR_Vital_MeasureDateAuxDate",gxvar:"AV24DDO_BR_Vital_MeasureDateAuxDate",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[42],ip:[42],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV24DDO_BR_Vital_MeasureDateAuxDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV24DDO_BR_Vital_MeasureDateAuxDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_VITAL_MEASUREDATEAUXDATE",gx.O.AV24DDO_BR_Vital_MeasureDateAuxDate,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV24DDO_BR_Vital_MeasureDateAuxDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_VITAL_MEASUREDATEAUXDATE")},nac:gx.falseFn};
   GXValidFnc[43]={ id:43 ,lvl:0,type:"date",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Ddo_br_vital_measuredateauxdateto,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_BR_VITAL_MEASUREDATEAUXDATETO",gxz:"ZV25DDO_BR_Vital_MeasureDateAuxDateTo",gxold:"OV25DDO_BR_Vital_MeasureDateAuxDateTo",gxvar:"AV25DDO_BR_Vital_MeasureDateAuxDateTo",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/9999",dec:0},ucs:[],op:[43],ip:[43],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV25DDO_BR_Vital_MeasureDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV25DDO_BR_Vital_MeasureDateAuxDateTo=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("vDDO_BR_VITAL_MEASUREDATEAUXDATETO",gx.O.AV25DDO_BR_Vital_MeasureDateAuxDateTo,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV25DDO_BR_Vital_MeasureDateAuxDateTo=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getControlValue("vDDO_BR_VITAL_MEASUREDATEAUXDATETO")},nac:gx.falseFn};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_VITAL_WEIGHT",gxz:"ZV28TFBR_Vital_Weight",gxold:"OV28TFBR_Vital_Weight",gxvar:"AV28TFBR_Vital_Weight",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV28TFBR_Vital_Weight=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV28TFBR_Vital_Weight=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_VITAL_WEIGHT",gx.O.AV28TFBR_Vital_Weight,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV28TFBR_Vital_Weight=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_VITAL_WEIGHT",',','.')},nac:gx.falseFn};
   GXValidFnc[45]={ id:45 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_VITAL_WEIGHT_TO",gxz:"ZV29TFBR_Vital_Weight_To",gxold:"OV29TFBR_Vital_Weight_To",gxvar:"AV29TFBR_Vital_Weight_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV29TFBR_Vital_Weight_To=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV29TFBR_Vital_Weight_To=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_VITAL_WEIGHT_TO",gx.O.AV29TFBR_Vital_Weight_To,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV29TFBR_Vital_Weight_To=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_VITAL_WEIGHT_TO",',','.')},nac:gx.falseFn};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_VITAL_TEMPERATURE",gxz:"ZV32TFBR_Vital_Temperature",gxold:"OV32TFBR_Vital_Temperature",gxvar:"AV32TFBR_Vital_Temperature",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV32TFBR_Vital_Temperature=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV32TFBR_Vital_Temperature=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_VITAL_TEMPERATURE",gx.O.AV32TFBR_Vital_Temperature,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV32TFBR_Vital_Temperature=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_VITAL_TEMPERATURE",',','.')},nac:gx.falseFn};
   GXValidFnc[47]={ id:47 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vTFBR_VITAL_TEMPERATURE_TO",gxz:"ZV33TFBR_Vital_Temperature_To",gxold:"OV33TFBR_Vital_Temperature_To",gxvar:"AV33TFBR_Vital_Temperature_To",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33TFBR_Vital_Temperature_To=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.ZV33TFBR_Vital_Temperature_To=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vTFBR_VITAL_TEMPERATURE_TO",gx.O.AV33TFBR_Vital_Temperature_To,5,'.')},c2v:function(){if(this.val()!==undefined)gx.O.AV33TFBR_Vital_Temperature_To=this.val()},val:function(){return gx.fn.getDecimalValue("vTFBR_VITAL_TEMPERATURE_TO",',','.')},nac:gx.falseFn};
   this.ZV57Display = "" ;
   this.OV57Display = "" ;
   this.Z150BR_VitalID = 0 ;
   this.O150BR_VitalID = 0 ;
   this.Z152BR_Vital_MeasureDate = gx.date.nullDate() ;
   this.O152BR_Vital_MeasureDate = gx.date.nullDate() ;
   this.Z159BR_Vital_Weight = 0 ;
   this.O159BR_Vital_Weight = 0 ;
   this.Z153BR_Vital_Temperature = 0 ;
   this.O153BR_Vital_Temperature = 0 ;
   this.AV20ddo_BR_VitalIDTitleControlIdToReplace = "" ;
   this.ZV20ddo_BR_VitalIDTitleControlIdToReplace = "" ;
   this.OV20ddo_BR_VitalIDTitleControlIdToReplace = "" ;
   this.AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "" ;
   this.ZV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "" ;
   this.OV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "" ;
   this.AV30ddo_BR_Vital_WeightTitleControlIdToReplace = "" ;
   this.ZV30ddo_BR_Vital_WeightTitleControlIdToReplace = "" ;
   this.OV30ddo_BR_Vital_WeightTitleControlIdToReplace = "" ;
   this.AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace = "" ;
   this.ZV34ddo_BR_Vital_TemperatureTitleControlIdToReplace = "" ;
   this.OV34ddo_BR_Vital_TemperatureTitleControlIdToReplace = "" ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.ZV14OrderedBy = 0 ;
   this.OV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.ZV15OrderedDsc = false ;
   this.OV15OrderedDsc = false ;
   this.AV18TFBR_VitalID = 0 ;
   this.ZV18TFBR_VitalID = 0 ;
   this.OV18TFBR_VitalID = 0 ;
   this.AV19TFBR_VitalID_To = 0 ;
   this.ZV19TFBR_VitalID_To = 0 ;
   this.OV19TFBR_VitalID_To = 0 ;
   this.AV22TFBR_Vital_MeasureDate = gx.date.nullDate() ;
   this.ZV22TFBR_Vital_MeasureDate = gx.date.nullDate() ;
   this.OV22TFBR_Vital_MeasureDate = gx.date.nullDate() ;
   this.AV23TFBR_Vital_MeasureDate_To = gx.date.nullDate() ;
   this.ZV23TFBR_Vital_MeasureDate_To = gx.date.nullDate() ;
   this.OV23TFBR_Vital_MeasureDate_To = gx.date.nullDate() ;
   this.AV24DDO_BR_Vital_MeasureDateAuxDate = gx.date.nullDate() ;
   this.ZV24DDO_BR_Vital_MeasureDateAuxDate = gx.date.nullDate() ;
   this.OV24DDO_BR_Vital_MeasureDateAuxDate = gx.date.nullDate() ;
   this.AV25DDO_BR_Vital_MeasureDateAuxDateTo = gx.date.nullDate() ;
   this.ZV25DDO_BR_Vital_MeasureDateAuxDateTo = gx.date.nullDate() ;
   this.OV25DDO_BR_Vital_MeasureDateAuxDateTo = gx.date.nullDate() ;
   this.AV28TFBR_Vital_Weight = 0 ;
   this.ZV28TFBR_Vital_Weight = 0 ;
   this.OV28TFBR_Vital_Weight = 0 ;
   this.AV29TFBR_Vital_Weight_To = 0 ;
   this.ZV29TFBR_Vital_Weight_To = 0 ;
   this.OV29TFBR_Vital_Weight_To = 0 ;
   this.AV32TFBR_Vital_Temperature = 0 ;
   this.ZV32TFBR_Vital_Temperature = 0 ;
   this.OV32TFBR_Vital_Temperature = 0 ;
   this.AV33TFBR_Vital_Temperature_To = 0 ;
   this.ZV33TFBR_Vital_Temperature_To = 0 ;
   this.OV33TFBR_Vital_Temperature_To = 0 ;
   this.AV54GridCurrentPage = 0 ;
   this.AV51DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV20ddo_BR_VitalIDTitleControlIdToReplace = "" ;
   this.AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "" ;
   this.AV30ddo_BR_Vital_WeightTitleControlIdToReplace = "" ;
   this.AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace = "" ;
   this.A19BR_EncounterID = 0 ;
   this.AV14OrderedBy = 0 ;
   this.AV15OrderedDsc = false ;
   this.AV18TFBR_VitalID = 0 ;
   this.AV19TFBR_VitalID_To = 0 ;
   this.AV22TFBR_Vital_MeasureDate = gx.date.nullDate() ;
   this.AV23TFBR_Vital_MeasureDate_To = gx.date.nullDate() ;
   this.AV24DDO_BR_Vital_MeasureDateAuxDate = gx.date.nullDate() ;
   this.AV25DDO_BR_Vital_MeasureDateAuxDateTo = gx.date.nullDate() ;
   this.AV28TFBR_Vital_Weight = 0 ;
   this.AV29TFBR_Vital_Weight_To = 0 ;
   this.AV32TFBR_Vital_Temperature = 0 ;
   this.AV33TFBR_Vital_Temperature_To = 0 ;
   this.AV8BR_EncounterID = 0 ;
   this.AV57Display = "" ;
   this.A150BR_VitalID = 0 ;
   this.A152BR_Vital_MeasureDate = gx.date.nullDate() ;
   this.A159BR_Vital_Weight = 0 ;
   this.A153BR_Vital_Temperature = 0 ;
   this.AV64Pgmname = "" ;
   this.AV58IsAuthorized_Display = false ;
   this.Events = {"e11612_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12612_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13612_client": ["DDO_BR_VITALID.ONOPTIONCLICKED", true] ,"e14612_client": ["DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED", true] ,"e15612_client": ["DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED", true] ,"e16612_client": ["DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED", true] ,"e20612_client": ["ENTER", true] ,"e21612_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV64Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'}],[{av:'AV17BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV31BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{ctrl:'BR_VITALID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITALID","Title")',ctrl:'BR_VITALID',prop:'Title'},{ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_MEASUREDATE","Title")',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_WEIGHT","Title")',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_TEMPERATURE","Title")',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV64Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}],[{ctrl:'GRID',prop:'Rows'},{av:'gx.fn.getCtrlProperty("vTFBR_VITALID","Visible")',ctrl:'vTFBR_VITALID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_VITALID_TO","Visible")',ctrl:'vTFBR_VITALID_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_VITAL_MEASUREDATE","Visible")',ctrl:'vTFBR_VITAL_MEASUREDATE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_VITAL_MEASUREDATE_TO","Visible")',ctrl:'vTFBR_VITAL_MEASUREDATE_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_VITAL_WEIGHT","Visible")',ctrl:'vTFBR_VITAL_WEIGHT',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_VITAL_WEIGHT_TO","Visible")',ctrl:'vTFBR_VITAL_WEIGHT_TO',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_VITAL_TEMPERATURE","Visible")',ctrl:'vTFBR_VITAL_TEMPERATURE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vTFBR_VITAL_TEMPERATURE_TO","Visible")',ctrl:'vTFBR_VITAL_TEMPERATURE_TO',prop:'Visible'},{av:'this.DDO_BR_VITALIDContainer.TitleControlIdToReplace',ctrl:'DDO_BR_VITALID',prop:'TitleControlIdToReplace'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.TitleControlIdToReplace',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'TitleControlIdToReplace'},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.TitleControlIdToReplace',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'TitleControlIdToReplace'},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.TitleControlIdToReplace',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'TitleControlIdToReplace'},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV51DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_VITALIDContainer.FilteredText_set',ctrl:'DDO_BR_VITALID',prop:'FilteredText_set'},{av:'this.DDO_BR_VITALIDContainer.FilteredTextTo_set',ctrl:'DDO_BR_VITALID',prop:'FilteredTextTo_set'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.FilteredText_set',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'FilteredText_set'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.FilteredTextTo_set',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'FilteredTextTo_set'},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.FilteredText_set',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'FilteredText_set'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.FilteredTextTo_set',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'FilteredTextTo_set'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.FilteredText_set',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredText_set'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.FilteredTextTo_set',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredTextTo_set'},{av:'this.DDO_BR_VITALIDContainer.SortedStatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV64Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV64Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_BR_VITALID.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV64Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_VITALIDContainer.ActiveEventKey',ctrl:'DDO_BR_VITALID',prop:'ActiveEventKey'},{av:'this.DDO_BR_VITALIDContainer.FilteredText_get',ctrl:'DDO_BR_VITALID',prop:'FilteredText_get'},{av:'this.DDO_BR_VITALIDContainer.FilteredTextTo_get',ctrl:'DDO_BR_VITALID',prop:'FilteredTextTo_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_VITALIDContainer.SortedStatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV17BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV31BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{ctrl:'BR_VITALID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITALID","Title")',ctrl:'BR_VITALID',prop:'Title'},{ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_MEASUREDATE","Title")',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_WEIGHT","Title")',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_TEMPERATURE","Title")',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV64Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.ActiveEventKey',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'ActiveEventKey'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.FilteredText_get',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'FilteredText_get'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.FilteredTextTo_get',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'FilteredTextTo_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'this.DDO_BR_VITALIDContainer.SortedStatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV17BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV31BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{ctrl:'BR_VITALID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITALID","Title")',ctrl:'BR_VITALID',prop:'Title'},{ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_MEASUREDATE","Title")',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_WEIGHT","Title")',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_TEMPERATURE","Title")',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV64Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.ActiveEventKey',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'ActiveEventKey'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.FilteredText_get',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'FilteredText_get'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.FilteredTextTo_get',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'FilteredTextTo_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_VITALIDContainer.SortedStatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV17BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV31BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{ctrl:'BR_VITALID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITALID","Title")',ctrl:'BR_VITALID',prop:'Title'},{ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_MEASUREDATE","Title")',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_WEIGHT","Title")',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_TEMPERATURE","Title")',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV64Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.ActiveEventKey',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'ActiveEventKey'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.FilteredText_get',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredText_get'},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.FilteredTextTo_get',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredTextTo_get'}],[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_BR_VITAL_TEMPERATUREContainer.SortedStatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'this.DDO_BR_VITALIDContainer.SortedStatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_MEASUREDATEContainer.SortedStatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'this.DDO_BR_VITAL_WEIGHTContainer.SortedStatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV17BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV31BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{ctrl:'BR_VITALID',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITALID","Title")',ctrl:'BR_VITALID',prop:'Title'},{ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_MEASUREDATE","Title")',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_WEIGHT","Title")',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("BR_VITAL_TEMPERATURE","Title")',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Visible")',ctrl:'vDISPLAY',prop:'Visible'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV57Display',fld:'vDISPLAY',pic:''},{av:'gx.fn.getCtrlProperty("vDISPLAY","Tooltiptext")',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'gx.fn.getCtrlProperty("vDISPLAY","Link")',ctrl:'vDISPLAY',prop:'Link'}]];
   this.setVCMap("AV64Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV58IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV64Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV58IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   this.setVCMap("AV8BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV64Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV58IsAuthorized_Display", "vISAUTHORIZED_DISPLAY", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[35]);
   GridContainer.addRefreshingVar(this.GXValidFnc[36]);
   GridContainer.addRefreshingVar(this.GXValidFnc[37]);
   GridContainer.addRefreshingVar(this.GXValidFnc[38]);
   GridContainer.addRefreshingVar(this.GXValidFnc[39]);
   GridContainer.addRefreshingVar(this.GXValidFnc[40]);
   GridContainer.addRefreshingVar(this.GXValidFnc[44]);
   GridContainer.addRefreshingVar(this.GXValidFnc[45]);
   GridContainer.addRefreshingVar(this.GXValidFnc[46]);
   GridContainer.addRefreshingVar(this.GXValidFnc[47]);
   GridContainer.addRefreshingVar({rfrVar:"AV8BR_EncounterID"});
   GridContainer.addRefreshingVar(this.GXValidFnc[26]);
   GridContainer.addRefreshingVar(this.GXValidFnc[28]);
   GridContainer.addRefreshingVar(this.GXValidFnc[30]);
   GridContainer.addRefreshingVar(this.GXValidFnc[32]);
   GridContainer.addRefreshingVar({rfrVar:"AV64Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV58IsAuthorized_Display"});
   this.Initialize( );
});
