/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:37.70
*/
gx.evt.autoSkip = false;
gx.define('xt_defindcodetypeprompt', false, function () {
   this.ServerClass =  "xt_defindcodetypeprompt" ;
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
      this.AV8InOutXT_DefindcodeTypeID=gx.fn.getIntegerValue("vINOUTXT_DEFINDCODETYPEID",',') ;
      this.AV9InOutXT_DefindcodeTypeName=gx.fn.getControlValue("vINOUTXT_DEFINDCODETYPENAME") ;
   };
   this.e112c2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e122c2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e132c2_client=function()
   {
      return this.executeServerEvent("DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e172c2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e182c2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,26,27,28,29,30,31,33,34,35,37,39,40];
   this.GXLastCtrlId =40;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"xt_defindcodetypeprompt",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Select","vSELECT",26,0,"px",17,"px","e172c2_client","","","SelectAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(165,27,"XT_DEFINDCODETYPEID","鏁版嵁瀛楀吀绫诲瀷涓婚敭","","XT_DefindcodeTypeID","int",0,"px",18,18,"right",null,[],165,"XT_DefindcodeTypeID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(166,28,"XT_DEFINDCODETYPENAME","","","XT_DefindcodeTypeName","svchar",0,"px",40,40,"left",null,[],166,"XT_DefindcodeTypeName",true,0,false,false,"Attribute",1,"WWColumn");
   this.GridContainer.emptyText = "";
   this.setGrid(GridContainer);
   this.DVPANEL_UNNAMEDTABLE1Container = gx.uc.getNew(this, 10, 0, "BootstrapPanel", "DVPANEL_UNNAMEDTABLE1Container", "Dvpanel_unnamedtable1", "DVPANEL_UNNAMEDTABLE1");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 32, 19, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV19GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV19GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV19GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV21GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV21GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV21GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV20GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV20GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV20GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e112c2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e122c2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_XT_DEFINDCODETYPENAMEContainer = gx.uc.getNew(this, 36, 19, "BootstrapDropDownOptions", "DDO_XT_DEFINDCODETYPENAMEContainer", "Ddo_xt_defindcodetypename", "DDO_XT_DEFINDCODETYPENAME");
   var DDO_XT_DEFINDCODETYPENAMEContainer = this.DDO_XT_DEFINDCODETYPENAMEContainer;
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Class", "Class", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_XT_DEFINDCODETYPENAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_XT_DEFINDCODETYPENAMEContainer.addV2CFunction('AV17DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_XT_DEFINDCODETYPENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV17DDO_TitleSettingsIcons); });
   DDO_XT_DEFINDCODETYPENAMEContainer.addV2CFunction('AV15XT_DefindcodeTypeNameTitleFilterData', "vXT_DEFINDCODETYPENAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_XT_DEFINDCODETYPENAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV15XT_DefindcodeTypeNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vXT_DEFINDCODETYPENAMETITLEFILTERDATA",UC.ParentObject.AV15XT_DefindcodeTypeNameTitleFilterData); });
   DDO_XT_DEFINDCODETYPENAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_XT_DEFINDCODETYPENAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_XT_DEFINDCODETYPENAMEContainer.addEventHandler("OnOptionClicked", this.e132c2_client);
   this.setUserControl(DDO_XT_DEFINDCODETYPENAMEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 38, 19, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[9]={ id: 9, fld:"HTML_DVPANEL_UNNAMEDTABLE1",grid:0};
   GXValidFnc[12]={ id: 12, fld:"LAYOUT_UNNAMEDTABLE1",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id:19 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vXT_DEFINDCODETYPENAME",gxz:"ZV23XT_DefindcodeTypeName",gxold:"OV23XT_DefindcodeTypeName",gxvar:"AV23XT_DefindcodeTypeName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV23XT_DefindcodeTypeName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV23XT_DefindcodeTypeName=Value},v2c:function(){gx.fn.setControlValue("vXT_DEFINDCODETYPENAME",gx.O.AV23XT_DefindcodeTypeName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV23XT_DefindcodeTypeName=this.val()},val:function(){return gx.fn.getControlValue("vXT_DEFINDCODETYPENAME")},nac:gx.falseFn};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSELECT",gxz:"ZV22Select",gxold:"OV22Select",gxvar:"AV22Select",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV22Select=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22Select=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vSELECT",row || gx.fn.currentGridRowImpl(25),gx.O.AV22Select,gx.O.AV28Select_GXI)},c2v:function(){gx.O.AV28Select_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV22Select=this.val()},val:function(row){return gx.fn.getGridControlValue("vSELECT",row || gx.fn.currentGridRowImpl(25))},val_GXI:function(row){return gx.fn.getGridControlValue("vSELECT_GXI",row || gx.fn.currentGridRowImpl(25))}, gxvar_GXI:'AV28Select_GXI',nac:gx.falseFn,evt:"e172c2_client",std:"ENTER"};
   GXValidFnc[27]={ id:27 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINDCODETYPEID",gxz:"Z165XT_DefindcodeTypeID",gxold:"O165XT_DefindcodeTypeID",gxvar:"A165XT_DefindcodeTypeID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A165XT_DefindcodeTypeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z165XT_DefindcodeTypeID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("XT_DEFINDCODETYPEID",row || gx.fn.currentGridRowImpl(25),gx.O.A165XT_DefindcodeTypeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A165XT_DefindcodeTypeID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("XT_DEFINDCODETYPEID",row || gx.fn.currentGridRowImpl(25),',')},nac:gx.falseFn};
   GXValidFnc[28]={ id:28 ,lvl:2,type:"svchar",len:40,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"XT_DEFINDCODETYPENAME",gxz:"Z166XT_DefindcodeTypeName",gxold:"O166XT_DefindcodeTypeName",gxvar:"A166XT_DefindcodeTypeName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A166XT_DefindcodeTypeName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z166XT_DefindcodeTypeName=Value},v2c:function(row){gx.fn.setGridControlValue("XT_DEFINDCODETYPENAME",row || gx.fn.currentGridRowImpl(25),gx.O.A166XT_DefindcodeTypeName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A166XT_DefindcodeTypeName=this.val()},val:function(row){return gx.fn.getGridControlValue("XT_DEFINDCODETYPENAME",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE",gxz:"ZV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace",gxold:"OV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace",gxvar:"AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE",gx.O.AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDBY",gxz:"ZV11OrderedBy",gxold:"OV11OrderedBy",gxvar:"AV11OrderedBy",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV11OrderedBy=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV11OrderedBy=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDBY",gx.O.AV11OrderedBy,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV11OrderedBy=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vORDEREDBY",',')},nac:gx.falseFn};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV12OrderedDsc",gxold:"OV12OrderedDsc",gxvar:"AV12OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV12OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV12OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.AV23XT_DefindcodeTypeName = "" ;
   this.ZV23XT_DefindcodeTypeName = "" ;
   this.OV23XT_DefindcodeTypeName = "" ;
   this.ZV22Select = "" ;
   this.OV22Select = "" ;
   this.Z165XT_DefindcodeTypeID = 0 ;
   this.O165XT_DefindcodeTypeID = 0 ;
   this.Z166XT_DefindcodeTypeName = "" ;
   this.O166XT_DefindcodeTypeName = "" ;
   this.AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = "" ;
   this.ZV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = "" ;
   this.OV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = "" ;
   this.AV11OrderedBy = 0 ;
   this.ZV11OrderedBy = 0 ;
   this.OV11OrderedBy = 0 ;
   this.AV12OrderedDsc = false ;
   this.ZV12OrderedDsc = false ;
   this.OV12OrderedDsc = false ;
   this.AV23XT_DefindcodeTypeName = "" ;
   this.AV19GridCurrentPage = 0 ;
   this.AV17DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = "" ;
   this.AV11OrderedBy = 0 ;
   this.AV12OrderedDsc = false ;
   this.AV8InOutXT_DefindcodeTypeID = 0 ;
   this.AV9InOutXT_DefindcodeTypeName = "" ;
   this.AV22Select = "" ;
   this.A165XT_DefindcodeTypeID = 0 ;
   this.A166XT_DefindcodeTypeName = "" ;
   this.Events = {"e112c2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e122c2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e132c2_client": ["DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED", true] ,"e172c2_client": ["ENTER", true] ,"e182c2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV23XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'}],[{av:'AV15XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("XT_DEFINDCODETYPENAME","Title")',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'AV19GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV20GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV21GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[{av:'AV27Pgmname',fld:'vPGMNAME',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'}],[{av:'gx.fn.getCtrlProperty("TABLEMAIN","Height")',ctrl:'TABLEMAIN',prop:'Height'},{ctrl:'GRID',prop:'Rows'},{av:'this.DDO_XT_DEFINDCODETYPENAMEContainer.TitleControlIdToReplace',ctrl:'DDO_XT_DEFINDCODETYPENAME',prop:'TitleControlIdToReplace'},{av:'AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDBY","Visible")',ctrl:'vORDEREDBY',prop:'Visible'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV17DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV23XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV23XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV23XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_XT_DEFINDCODETYPENAMEContainer.ActiveEventKey',ctrl:'DDO_XT_DEFINDCODETYPENAME',prop:'ActiveEventKey'}],[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_XT_DEFINDCODETYPENAMEContainer.SortedStatus',ctrl:'DDO_XT_DEFINDCODETYPENAME',prop:'SortedStatus'},{av:'AV15XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat',hsh:true},{av:'gx.fn.getCtrlProperty("XT_DEFINDCODETYPENAME","Title")',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'AV19GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV20GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV21GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[],[{av:'AV22Select',fld:'vSELECT',pic:''},{av:'gx.fn.getCtrlProperty("vSELECT","Tooltiptext")',ctrl:'vSELECT',prop:'Tooltiptext'}]];
   this.EvtParms["ENTER"] = [[{av:'A165XT_DefindcodeTypeID',fld:'XT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A166XT_DefindcodeTypeName',fld:'XT_DEFINDCODETYPENAME',pic:'',hsh:true}],[{av:'AV8InOutXT_DefindcodeTypeID',fld:'vINOUTXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutXT_DefindcodeTypeName',fld:'vINOUTXT_DEFINDCODETYPENAME',pic:''}]];
   this.EnterCtrl = ["vSELECT"];
   this.setVCMap("AV8InOutXT_DefindcodeTypeID", "vINOUTXT_DEFINDCODETYPEID", 0, "int", 18, 0);
   this.setVCMap("AV9InOutXT_DefindcodeTypeName", "vINOUTXT_DEFINDCODETYPENAME", 0, "svchar", 40, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[19]);
   GridContainer.addRefreshingVar(this.GXValidFnc[39]);
   GridContainer.addRefreshingVar(this.GXValidFnc[40]);
   GridContainer.addRefreshingVar(this.GXValidFnc[37]);
   this.Initialize( );
});
gx.createParentObj(xt_defindcodetypeprompt);
