/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:58:42.45
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.workwithplusmasterpage', false, function () {
   this.ServerClass =  "wwpbaseobjects.workwithplusmasterpage" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.IsMasterPage=true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
   };
   this.e11121_client=function()
   {
      this.clearMessages();
      this.UCMENU_MPAGEContainer.CollapseExpand() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e16122_client=function()
   {
      this.clearMessages();
      this.UCMENU_MPAGEContainer.CollapseExpand() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e13122_client=function()
   {
      return this.executeServerEvent("DDO_ACTIONGM_MPAGE.ONOPTIONCLICKED_MPAGE", false, null, true, true);
   };
   this.e12122_client=function()
   {
      return this.executeServerEvent("DDO_ADMINAG_MPAGE.ONOPTIONCLICKED_MPAGE", false, null, true, true);
   };
   this.e17122_client=function()
   {
      return this.executeServerEvent("ENTER_MPAGE", true, null, false, false);
   };
   this.e18122_client=function()
   {
      return this.executeServerEvent("CANCEL_MPAGE", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,15,17,19,20,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,41,42,43,44,45];
   this.GXLastCtrlId =45;
   this.DDO_ACTIONGM_MPAGEContainer = gx.uc.getNew(this, 21, 0, "BootstrapDropDownOptions", "DDO_ACTIONGM_MPAGEContainer", "Ddo_actiongm", "DDO_ACTIONGM_MPAGE");
   var DDO_ACTIONGM_MPAGEContainer = this.DDO_ACTIONGM_MPAGEContainer;
   DDO_ACTIONGM_MPAGEContainer.setProp("Class", "Class", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_ACTIONGM_MPAGEContainer.setDynProp("Icon", "Icon", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("Caption", "Caption", "", "str");
   DDO_ACTIONGM_MPAGEContainer.setProp("Tooltip", "Tooltip", "", "str");
   DDO_ACTIONGM_MPAGEContainer.setProp("Cls", "Cls", "ActionGroupHeaderTheo", "str");
   DDO_ACTIONGM_MPAGEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_ACTIONGM_MPAGEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "Regular", "str");
   DDO_ACTIONGM_MPAGEContainer.setProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_ACTIONGM_MPAGEContainer.setProp("IncludeSortASC", "Includesortasc", false, "boolean");
   DDO_ACTIONGM_MPAGEContainer.setProp("IncludeSortDSC", "Includesortdsc", false, "boolean");
   DDO_ACTIONGM_MPAGEContainer.setProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("IncludeFilter", "Includefilter", false, "boolean");
   DDO_ACTIONGM_MPAGEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_ACTIONGM_MPAGEContainer.setProp("IncludeDataList", "Includedatalist", false, "boolean");
   DDO_ACTIONGM_MPAGEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_ACTIONGM_MPAGEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_ACTIONGM_MPAGEContainer.setProp("FixedFilters", "Fixedfilters", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("SortASC", "Sortasc", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("SortDSC", "Sortdsc", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("SearchButtonText", "Searchbuttontext", "", "char");
   DDO_ACTIONGM_MPAGEContainer.setProp("UpdateButtonText", "Updatebuttontext", "", "char");
   DDO_ACTIONGM_MPAGEContainer.DropDownOptionsTitleSettingsIcons = '';
   DDO_ACTIONGM_MPAGEContainer.addV2CFunction('AV29actionGMData', "vACTIONGMDATA_MPAGE", 'SetDropDownOptionsData');
   DDO_ACTIONGM_MPAGEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV29actionGMData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vACTIONGMDATA_MPAGE",UC.ParentObject.AV29actionGMData); });
   DDO_ACTIONGM_MPAGEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_ACTIONGM_MPAGEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_ACTIONGM_MPAGEContainer.addEventHandler("OnOptionClicked", this.e13122_client);
   this.setUserControl(DDO_ACTIONGM_MPAGEContainer);
   this.UCMENU_MPAGEContainer = gx.uc.getNew(this, 46, 31, "BootstrapSidebarMenu", "UCMENU_MPAGEContainer", "Ucmenu", "UCMENU_MPAGE");
   var UCMENU_MPAGEContainer = this.UCMENU_MPAGEContainer;
   UCMENU_MPAGEContainer.setProp("Class", "Class", "", "char");
   UCMENU_MPAGEContainer.setProp("Enabled", "Enabled", true, "boolean");
   UCMENU_MPAGEContainer.setProp("SelectedItem", "Selecteditem", "", "char");
   UCMENU_MPAGEContainer.setProp("SearchServiceUrl", "Searchserviceurl", "", "str");
   UCMENU_MPAGEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   UCMENU_MPAGEContainer.setProp("SearchMinChars", "Searchminchars", 3, "num");
   UCMENU_MPAGEContainer.setProp("SearchHelperDescription", "Searchhelperdescription", "", "str");
   UCMENU_MPAGEContainer.setProp("SidebarMainClass", "Sidebarmainclass", "page-sidebar sidebar-fixed", "str");
   UCMENU_MPAGEContainer.setProp("HeaderClass", "Headerclass", "sidebar-header-wrapper", "str");
   UCMENU_MPAGEContainer.setProp("SearchInputClass", "Searchinputclass", "searchinput", "str");
   UCMENU_MPAGEContainer.setProp("SearchIconClass", "Searchiconclass", "searchicon fa fa-search", "str");
   UCMENU_MPAGEContainer.setProp("SearchHelperClass", "Searchhelperclass", "searchhelper", "str");
   UCMENU_MPAGEContainer.setProp("SidebarMenuClass", "Sidebarmenuclass", "nav sidebar-menu", "str");
   UCMENU_MPAGEContainer.setProp("ScrollWidth", "Scrollwidth", 3, "num");
   UCMENU_MPAGEContainer.setProp("ScrollAlwaysVisible", "Scrollalwaysvisible", false, "bool");
   UCMENU_MPAGEContainer.setProp("HideScrollInCompactMenu", "Hidescrollincompactmenu", true, "bool");
   UCMENU_MPAGEContainer.addV2CFunction('AV12DVelop_Menu', "vDVELOP_MENU_MPAGE", 'SetSidebarMenuOptionsDataOptionsData');
   UCMENU_MPAGEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV12DVelop_Menu=UC.GetSidebarMenuOptionsDataOptionsData();gx.fn.setControlValue("vDVELOP_MENU_MPAGE",UC.ParentObject.AV12DVelop_Menu); });
   UCMENU_MPAGEContainer.addV2CFunction('AV6DVelop_Menu_UserData', "vDVELOP_MENU_USERDATA_MPAGE", 'SetSidebarMenuUserData');
   UCMENU_MPAGEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV6DVelop_Menu_UserData=UC.GetSidebarMenuUserData();gx.fn.setControlValue("vDVELOP_MENU_USERDATA_MPAGE",UC.ParentObject.AV6DVelop_Menu_UserData); });
   UCMENU_MPAGEContainer.setProp("AllMenuItemsVisibleAtLoad", "Allmenuitemsvisibleatload", false, "bool");
   UCMENU_MPAGEContainer.setProp("Visible", "Visible", true, "bool");
   UCMENU_MPAGEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(UCMENU_MPAGEContainer);
   this.DDO_ADMINAG_MPAGEContainer = gx.uc.getNew(this, 18, 0, "BootstrapDropDownOptions", "DDO_ADMINAG_MPAGEContainer", "Ddo_adminag", "DDO_ADMINAG_MPAGE");
   var DDO_ADMINAG_MPAGEContainer = this.DDO_ADMINAG_MPAGEContainer;
   DDO_ADMINAG_MPAGEContainer.setProp("Class", "Class", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_ADMINAG_MPAGEContainer.setDynProp("Icon", "Icon", "", "char");
   DDO_ADMINAG_MPAGEContainer.setDynProp("Caption", "Caption", "", "str");
   DDO_ADMINAG_MPAGEContainer.setProp("Tooltip", "Tooltip", "", "str");
   DDO_ADMINAG_MPAGEContainer.setProp("Cls", "Cls", "Header_UserInfo", "str");
   DDO_ADMINAG_MPAGEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_ADMINAG_MPAGEContainer.setDynProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_ADMINAG_MPAGEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "Regular", "str");
   DDO_ADMINAG_MPAGEContainer.setProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_ADMINAG_MPAGEContainer.setProp("IncludeSortASC", "Includesortasc", false, "boolean");
   DDO_ADMINAG_MPAGEContainer.setProp("IncludeSortDSC", "Includesortdsc", false, "boolean");
   DDO_ADMINAG_MPAGEContainer.setProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("IncludeFilter", "Includefilter", false, "boolean");
   DDO_ADMINAG_MPAGEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_ADMINAG_MPAGEContainer.setProp("IncludeDataList", "Includedatalist", false, "boolean");
   DDO_ADMINAG_MPAGEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_ADMINAG_MPAGEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_ADMINAG_MPAGEContainer.setProp("FixedFilters", "Fixedfilters", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("SortASC", "Sortasc", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("SortDSC", "Sortdsc", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("SearchButtonText", "Searchbuttontext", "", "char");
   DDO_ADMINAG_MPAGEContainer.setProp("UpdateButtonText", "Updatebuttontext", "", "char");
   DDO_ADMINAG_MPAGEContainer.DropDownOptionsTitleSettingsIcons = '';
   DDO_ADMINAG_MPAGEContainer.addV2CFunction('AV9AdminAGData', "vADMINAGDATA_MPAGE", 'SetDropDownOptionsData');
   DDO_ADMINAG_MPAGEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV9AdminAGData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vADMINAGDATA_MPAGE",UC.ParentObject.AV9AdminAGData); });
   DDO_ADMINAG_MPAGEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_ADMINAG_MPAGEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_ADMINAG_MPAGEContainer.addEventHandler("OnOptionClicked", this.e12122_client);
   this.setUserControl(DDO_ADMINAG_MPAGEContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"TABLEHEADER",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"TABLEUSERROLE",grid:0};
   GXValidFnc[15]={ id: 15, fld:"WELCOMEUSE", format:0,grid:0};
   GXValidFnc[17]={ id: 17, fld:"HTML_USERTABLE_ADMINAG",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"HTML_USERTABLE_ACTIONGM",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"ROCHE_LOGO",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTDATAMANAGER", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id:31 ,lvl:0,type:"bits",len:1024,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vHOSPITALLOGO_MPAGE",gxz:"ZV33hospitalLogo",gxold:"OV33hospitalLogo",gxvar:"AV33hospitalLogo",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV33hospitalLogo=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV33hospitalLogo=Value},v2c:function(){gx.fn.setMultimediaValue("vHOSPITALLOGO_MPAGE",gx.O.AV33hospitalLogo,gx.O.AV64Hospitallogo_GXI)},c2v:function(){gx.O.AV64Hospitallogo_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV33hospitalLogo=this.val()},val:function(){return gx.fn.getBlobValue("vHOSPITALLOGO_MPAGE")},val_GXI:function(){return gx.fn.getControlValue("vHOSPITALLOGO_GXI_MPAGE")}, gxvar_GXI:'AV64Hospitallogo_GXI',nac:gx.falseFn};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TABLECONTENT",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"TABLECONTENTPLACEHOLDER",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"EXPANDMENU",grid:0,evt:"e11121_client"};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   this.AV64Hospitallogo_GXI = "" ;
   this.AV33hospitalLogo = "" ;
   this.ZV33hospitalLogo = "" ;
   this.OV33hospitalLogo = "" ;
   this.AV9AdminAGData = [ ] ;
   this.AV29actionGMData = [ ] ;
   this.AV33hospitalLogo = "" ;
   this.AV12DVelop_Menu = [ ] ;
   this.Events = {"e13122_client": ["DDO_ACTIONGM_MPAGE.ONOPTIONCLICKED_MPAGE", true] ,"e12122_client": ["DDO_ADMINAG_MPAGE.ONOPTIONCLICKED_MPAGE", true] ,"e17122_client": ["ENTER_MPAGE", true] ,"e18122_client": ["CANCEL_MPAGE", true] ,"e11121_client": ["DOEXPANDMENU_MPAGE", false] ,"e16122_client": ["DOTEST_MPAGE", false]};
   this.EvtParms["REFRESH_MPAGE"] = [[],[]];
   this.EvtParms["START_MPAGE"] = [[{av:'AV43tCurrentCode',fld:'vTCURRENTCODE_MPAGE',pic:''},{av:'AV64Hospitallogo_GXI',fld:'vHOSPITALLOGO_GXI_MPAGE',pic:''}],[{av:'AV43tCurrentCode',fld:'vTCURRENTCODE_MPAGE',pic:''},{av:'AV33hospitalLogo',fld:'vHOSPITALLOGO_MPAGE',pic:''},{av:'gx.fn.getCtrlProperty("ROCHE_LOGO_MPAGE","Visible")',ctrl:'ROCHE_LOGO_MPAGE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vHOSPITALLOGO_MPAGE","Visible")',ctrl:'vHOSPITALLOGO_MPAGE',prop:'Visible'},{av:'gx.fn.getCtrlProperty("LAYOUTMAINTABLE_MPAGE","Class")',ctrl:'LAYOUTMAINTABLE_MPAGE',prop:'Class'},{av:'AV12DVelop_Menu',fld:'vDVELOP_MENU_MPAGE',pic:''},{av:'this.DDO_ACTIONGM_MPAGEContainer.Icon',ctrl:'DDO_ACTIONGM_MPAGE',prop:'Icon'},{av:'AV29actionGMData',fld:'vACTIONGMDATA_MPAGE',pic:''},{av:'this.DDO_ADMINAG_MPAGEContainer.Icon',ctrl:'DDO_ADMINAG_MPAGE',prop:'Icon'},{av:'AV9AdminAGData',fld:'vADMINAGDATA_MPAGE',pic:''},{av:'this.DDO_ADMINAG_MPAGEContainer.TitleControlAlign',ctrl:'DDO_ADMINAG_MPAGE',prop:'TitleControlAlign'},{av:'this.DDO_ADMINAG_MPAGEContainer.Caption',ctrl:'DDO_ADMINAG_MPAGE',prop:'Caption'}]];
   this.EvtParms["DOEXPANDMENU_MPAGE"] = [[],[]];
   this.EvtParms["DDO_ACTIONGM_MPAGE.ONOPTIONCLICKED_MPAGE"] = [[{av:'this.DDO_ACTIONGM_MPAGEContainer.ActiveEventKey',ctrl:'DDO_ACTIONGM_MPAGE',prop:'ActiveEventKey'}],[]];
   this.EvtParms["DDO_ADMINAG_MPAGE.ONOPTIONCLICKED_MPAGE"] = [[{av:'this.DDO_ADMINAG_MPAGEContainer.ActiveEventKey',ctrl:'DDO_ADMINAG_MPAGE',prop:'ActiveEventKey'}],[]];
   this.EvtParms["DOTEST_MPAGE"] = [[],[]];
   this.Initialize( );
});
gx.createMasterPage(wwpbaseobjects.workwithplusmasterpage);
