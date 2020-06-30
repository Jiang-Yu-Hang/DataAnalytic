/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:35:18.17
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secusersecuserrolewc', true, function (CmpContext) {
   this.ServerClass =  "wwpbaseobjects.secusersecuserrolewc" ;
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
      this.AV65Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV18IsAuthorized_SecRoleName=gx.fn.getControlValue("vISAUTHORIZED_SECROLENAME") ;
      this.AV8SecUserId=gx.fn.getIntegerValue("vSECUSERID",',') ;
      this.AV8SecUserId=gx.fn.getIntegerValue("vSECUSERID",',') ;
      this.AV65Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.AV18IsAuthorized_SecRoleName=gx.fn.getControlValue("vISAUTHORIZED_SECROLENAME") ;
   };
   this.Valid_Secroleid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(12) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECROLEID", gx.fn.currentGridRowImpl(12));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e11102_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e12102_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e13102_client=function()
   {
      return this.executeServerEvent("DDO_SECROLENAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e14102_client=function()
   {
      return this.executeServerEvent("DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e18102_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e19102_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18,20,21,22,24,26,27,29,30];
   this.GXLastCtrlId =30;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"wwpbaseobjects.secusersecuserrolewc",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(4,13,"SECROLEID","瑙掕壊缂栧彿","","SecRoleId","int",0,"px",4,4,"right",null,[],4,"SecRoleId",false,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(13,14,"SECROLENAME","","","SecRoleName","svchar",0,"px",40,40,"left",null,[],13,"SecRoleName",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(12,15,"SECROLEDESCRIPTION","","","SecRoleDescription","svchar",0,"px",120,80,"left",null,[],12,"SecRoleDescription",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 19, 13, "DVelop_DVPaginationBar", this.CmpContext + "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV57GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV57GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV57GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV60GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV60GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV60GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV59GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV59GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV59GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e11102_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e12102_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_SECROLENAMEContainer = gx.uc.getNew(this, 23, 13, "BootstrapDropDownOptions", this.CmpContext + "DDO_SECROLENAMEContainer", "Ddo_secrolename", "DDO_SECROLENAME");
   var DDO_SECROLENAMEContainer = this.DDO_SECROLENAMEContainer;
   DDO_SECROLENAMEContainer.setProp("Class", "Class", "", "char");
   DDO_SECROLENAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECROLENAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECROLENAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECROLENAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECROLENAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECROLENAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECROLENAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECROLENAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECROLENAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECROLENAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECROLENAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECROLENAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECROLENAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECROLENAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECROLENAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECROLENAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECROLENAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_SECROLENAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_SECROLENAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_SECROLENAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_SECROLENAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_SECROLENAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_SECROLENAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECROLENAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_SECROLENAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_SECROLENAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECROLENAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECROLENAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECROLENAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECROLENAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECROLENAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_SECROLENAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_SECROLENAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECROLENAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECROLENAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_SECROLENAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECROLENAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECROLENAMEContainer.addV2CFunction('AV45DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECROLENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV45DDO_TitleSettingsIcons); });
   DDO_SECROLENAMEContainer.addV2CFunction('AV37SecRoleNameTitleFilterData', "vSECROLENAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECROLENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV37SecRoleNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECROLENAMETITLEFILTERDATA",UC.ParentObject.AV37SecRoleNameTitleFilterData); });
   DDO_SECROLENAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECROLENAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECROLENAMEContainer.addEventHandler("OnOptionClicked", this.e13102_client);
   this.setUserControl(DDO_SECROLENAMEContainer);
   this.DDO_SECROLEDESCRIPTIONContainer = gx.uc.getNew(this, 25, 24, "BootstrapDropDownOptions", this.CmpContext + "DDO_SECROLEDESCRIPTIONContainer", "Ddo_secroledescription", "DDO_SECROLEDESCRIPTION");
   var DDO_SECROLEDESCRIPTIONContainer = this.DDO_SECROLEDESCRIPTIONContainer;
   DDO_SECROLEDESCRIPTIONContainer.setProp("Class", "Class", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Icon", "Icon", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Caption", "Caption", "", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_SECROLEDESCRIPTIONContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_SECROLEDESCRIPTIONContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_SECROLEDESCRIPTIONContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_SECROLEDESCRIPTIONContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_SECROLEDESCRIPTIONContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_SECROLEDESCRIPTIONContainer.addV2CFunction('AV45DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_SECROLEDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV45DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV45DDO_TitleSettingsIcons); });
   DDO_SECROLEDESCRIPTIONContainer.addV2CFunction('AV41SecRoleDescriptionTitleFilterData', "vSECROLEDESCRIPTIONTITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_SECROLEDESCRIPTIONContainer.addC2VFunction(function(UC) { UC.ParentObject.AV41SecRoleDescriptionTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vSECROLEDESCRIPTIONTITLEFILTERDATA",UC.ParentObject.AV41SecRoleDescriptionTitleFilterData); });
   DDO_SECROLEDESCRIPTIONContainer.setProp("Visible", "Visible", true, "bool");
   DDO_SECROLEDESCRIPTIONContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_SECROLEDESCRIPTIONContainer.addEventHandler("OnOptionClicked", this.e14102_client);
   this.setUserControl(DDO_SECROLEDESCRIPTIONContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 28, 24, "DVelop_WorkWithPlusUtilities", this.CmpContext + "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[6]={ id: 6, fld:"TABLEGRIDHEADER",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[13]={ id:13 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:this.Valid_Secroleid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLEID",gxz:"Z4SecRoleId",gxold:"O4SecRoleId",gxvar:"A4SecRoleId",ucs:[],op:[14,15],ip:[14,15,13],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A4SecRoleId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z4SecRoleId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECROLEID",row || gx.fn.currentGridRowImpl(12),gx.O.A4SecRoleId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A4SecRoleId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECROLEID",row || gx.fn.currentGridRowImpl(12),',')},nac:gx.falseFn};
   GXValidFnc[14]={ id:14 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLENAME",gxz:"Z13SecRoleName",gxold:"O13SecRoleName",gxvar:"A13SecRoleName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A13SecRoleName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z13SecRoleName=Value},v2c:function(row){gx.fn.setGridControlValue("SECROLENAME",row || gx.fn.currentGridRowImpl(12),gx.O.A13SecRoleName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A13SecRoleName=this.val()},val:function(row){return gx.fn.getGridControlValue("SECROLENAME",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[15]={ id:15 ,lvl:2,type:"svchar",len:120,dec:0,sign:false,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECROLEDESCRIPTION",gxz:"Z12SecRoleDescription",gxold:"O12SecRoleDescription",gxvar:"A12SecRoleDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A12SecRoleDescription=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z12SecRoleDescription=Value},v2c:function(row){gx.fn.setGridControlValue("SECROLEDESCRIPTION",row || gx.fn.currentGridRowImpl(12),gx.O.A12SecRoleDescription,0)},c2v:function(){if(this.val()!==undefined)gx.O.A12SecRoleDescription=this.val()},val:function(row){return gx.fn.getGridControlValue("SECROLEDESCRIPTION",row || gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[24]={ id:24 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECROLENAMETITLECONTROLIDTOREPLACE",gxz:"ZV40ddo_SecRoleNameTitleControlIdToReplace",gxold:"OV40ddo_SecRoleNameTitleControlIdToReplace",gxvar:"AV40ddo_SecRoleNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV40ddo_SecRoleNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV40ddo_SecRoleNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECROLENAMETITLECONTROLIDTOREPLACE",gx.O.AV40ddo_SecRoleNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV40ddo_SecRoleNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECROLENAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE",gxz:"ZV44ddo_SecRoleDescriptionTitleControlIdToReplace",gxold:"OV44ddo_SecRoleDescriptionTitleControlIdToReplace",gxvar:"AV44ddo_SecRoleDescriptionTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV44ddo_SecRoleDescriptionTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV44ddo_SecRoleDescriptionTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE",gx.O.AV44ddo_SecRoleDescriptionTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV44ddo_SecRoleDescriptionTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[27]={ id:27 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERID",gxz:"Z6SecUserId",gxold:"O6SecUserId",gxvar:"A6SecUserId",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A6SecUserId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z6SecUserId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("SECUSERID",gx.O.A6SecUserId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A6SecUserId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("SECUSERID",',')},nac:gx.falseFn};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV22OrderedBy",gxold:"OV22OrderedBy",gxvar:"AV22OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV22OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV22OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV22OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV23OrderedDsc",gxold:"OV23OrderedDsc",gxvar:"AV23OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV23OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV23OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.Z4SecRoleId = 0 ;
   this.O4SecRoleId = 0 ;
   this.Z13SecRoleName = "" ;
   this.O13SecRoleName = "" ;
   this.Z12SecRoleDescription = "" ;
   this.O12SecRoleDescription = "" ;
   this.AV40ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.ZV40ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.OV40ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.AV44ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.ZV44ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.OV44ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.A6SecUserId = 0 ;
   this.Z6SecUserId = 0 ;
   this.O6SecUserId = 0 ;
   this.AV22OrderedBy = 0 ;
   this.ZV22OrderedBy = 0 ;
   this.OV22OrderedBy = 0 ;
   this.AV23OrderedDsc = false ;
   this.ZV23OrderedDsc = false ;
   this.OV23OrderedDsc = false ;
   this.AV57GridCurrentPage = 0 ;
   this.AV45DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV40ddo_SecRoleNameTitleControlIdToReplace = "" ;
   this.AV44ddo_SecRoleDescriptionTitleControlIdToReplace = "" ;
   this.A6SecUserId = 0 ;
   this.AV22OrderedBy = 0 ;
   this.AV23OrderedDsc = false ;
   this.AV8SecUserId = 0 ;
   this.A4SecRoleId = 0 ;
   this.A13SecRoleName = "" ;
   this.A12SecRoleDescription = "" ;
   this.AV65Pgmname = "" ;
   this.AV18IsAuthorized_SecRoleName = false ;
   this.Events = {"e11102_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e12102_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e13102_client": ["DDO_SECROLENAME.ONOPTIONCLICKED", true] ,"e14102_client": ["DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED", true] ,"e18102_client": ["ENTER", true] ,"e19102_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8SecUserId',fld:'vSECUSERID',pic:'ZZZ9'},{av:'sPrefix'},{av:'AV40ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV22OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true}],[{av:'AV37SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV41SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECROLENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Title")',ctrl:'SECROLENAME',prop:'Title'},{ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLEDESCRIPTION","Title")',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV57GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV22OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8SecUserId',fld:'vSECUSERID',pic:'ZZZ9'}],[{ctrl:'GRID',prop:'Rows'},{av:'AV18IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'this.DDO_SECROLENAMEContainer.TitleControlIdToReplace',ctrl:'DDO_SECROLENAME',prop:'TitleControlIdToReplace'},{av:'AV40ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECROLENAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.TitleControlIdToReplace',ctrl:'DDO_SECROLEDESCRIPTION',prop:'TitleControlIdToReplace'},{av:'AV44ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("SECUSERID","Visible")',ctrl:'SECUSERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV22OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV45DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV22OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8SecUserId',fld:'vSECUSERID',pic:'ZZZ9'},{av:'AV40ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV22OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8SecUserId',fld:'vSECUSERID',pic:'ZZZ9'},{av:'AV40ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'sPrefix'},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_SECROLENAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV22OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8SecUserId',fld:'vSECUSERID',pic:'ZZZ9'},{av:'AV40ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'sPrefix'},{av:'this.DDO_SECROLENAMEContainer.ActiveEventKey',ctrl:'DDO_SECROLENAME',prop:'ActiveEventKey'}],[{av:'AV22OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECROLENAMEContainer.SortedStatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'AV37SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV41SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECROLENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Title")',ctrl:'SECROLENAME',prop:'Title'},{ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLEDESCRIPTION","Title")',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV57GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV22OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8SecUserId',fld:'vSECUSERID',pic:'ZZZ9'},{av:'AV40ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'sPrefix'},{av:'this.DDO_SECROLEDESCRIPTIONContainer.ActiveEventKey',ctrl:'DDO_SECROLEDESCRIPTION',prop:'ActiveEventKey'}],[{av:'AV22OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_SECROLEDESCRIPTIONContainer.SortedStatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'},{av:'AV37SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV41SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{ctrl:'SECROLENAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLENAME","Title")',ctrl:'SECROLENAME',prop:'Title'},{ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("SECROLEDESCRIPTION","Title")',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV57GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[{av:'AV18IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'}],[{av:'gx.fn.getCtrlProperty("SECROLENAME","Link")',ctrl:'SECROLENAME',prop:'Link'}]];
   this.setVCMap("AV65Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV18IsAuthorized_SecRoleName", "vISAUTHORIZED_SECROLENAME", 0, "boolean", 4, 0);
   this.setVCMap("AV8SecUserId", "vSECUSERID", 0, "int", 4, 0);
   this.setVCMap("AV8SecUserId", "vSECUSERID", 0, "int", 4, 0);
   this.setVCMap("AV65Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV18IsAuthorized_SecRoleName", "vISAUTHORIZED_SECROLENAME", 0, "boolean", 4, 0);
   this.setVCMap("AV8SecUserId", "vSECUSERID", 0, "int", 4, 0);
   this.setVCMap("AV65Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("AV18IsAuthorized_SecRoleName", "vISAUTHORIZED_SECROLENAME", 0, "boolean", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[29]);
   GridContainer.addRefreshingVar(this.GXValidFnc[30]);
   GridContainer.addRefreshingVar({rfrVar:"AV8SecUserId"});
   GridContainer.addRefreshingVar(this.GXValidFnc[24]);
   GridContainer.addRefreshingVar(this.GXValidFnc[26]);
   GridContainer.addRefreshingVar({rfrVar:"AV65Pgmname"});
   GridContainer.addRefreshingVar({rfrVar:"AV18IsAuthorized_SecRoleName"});
   this.Initialize( );
});
