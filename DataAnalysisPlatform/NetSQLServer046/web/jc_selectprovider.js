/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:1:20.96
*/
gx.evt.autoSkip = false;
gx.define('jc_selectprovider', false, function () {
   this.ServerClass =  "jc_selectprovider" ;
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
      this.AV8InSecUserId=gx.fn.getIntegerValue("vINSECUSERID",',') ;
      this.AV9InOutJC_ProviderID=gx.fn.getIntegerValue("vINOUTJC_PROVIDERID",',') ;
      this.AV8InSecUserId=gx.fn.getIntegerValue("vINSECUSERID",',') ;
   };
   this.Valid_Secuserid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(25) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("SECUSERID", gx.fn.currentGridRowImpl(25));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Jc_providerid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(25) ===0) {
            return true;
         }
         var gxballoon = gx.util.balloon.getNew("JC_PROVIDERID", gx.fn.currentGridRowImpl(25));
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e114a2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEPAGE", false, null, true, true);
   };
   this.e124a2_client=function()
   {
      return this.executeServerEvent("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", false, null, true, true);
   };
   this.e134a2_client=function()
   {
      return this.executeServerEvent("DDO_JC_PROVIDERNAME.ONOPTIONCLICKED", false, null, true, true);
   };
   this.e174a2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e184a2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,17,18,19,20,21,22,23,24,26,27,28,29,30,31,32,33,35,36,37,39,41];
   this.GXLastCtrlId =41;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",25,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"jc_selectprovider",[],false,1,false,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,true,false,false,null,null,false,"",false,[1,1,1,1],false,0,true,false);
   var GridContainer = this.GridContainer;
   GridContainer.addBitmap("&Select","vSELECT",26,0,"px",17,"px","e174a2_client","","","SelectAttribute ActionBaseColorAttribute","WWActionColumn");
   GridContainer.addSingleLineEdit(6,27,"SECUSERID","璐﹀彿涓婚敭","","SecUserId","int",0,"px",4,4,"right",null,[],6,"SecUserId",false,0,false,false,"Attribute",1,"WWColumn");
   GridContainer.addSingleLineEdit(87,28,"JC_PROVIDERID","灏辫瘖鍖婚櫌","","JC_ProviderID","int",0,"px",18,18,"right",null,[],87,"JC_ProviderID",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(14,29,"SECUSERNAME","濮撳悕","","SecUserName","svchar",0,"px",100,80,"left",null,[],14,"SecUserName",false,0,false,false,"Attribute",1,"WWColumn hidden-xs");
   GridContainer.addSingleLineEdit(89,30,"JC_PROVIDERNAME","","","JC_ProviderName","svchar",410,"px",200,80,"left",null,[],89,"JC_ProviderName",true,0,false,false,"Attribute",1,"WWColumn hidden-xs");
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
   this.GRIDPAGINATIONBARContainer = gx.uc.getNew(this, 34, 19, "DVelop_DVPaginationBar", "GRIDPAGINATIONBARContainer", "Gridpaginationbar", "GRIDPAGINATIONBAR");
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
   GRIDPAGINATIONBARContainer.addV2CFunction('AV17GridCurrentPage', "vGRIDCURRENTPAGE", 'SetCurrentPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV17GridCurrentPage=UC.GetCurrentPage();gx.fn.setControlValue("vGRIDCURRENTPAGE",UC.ParentObject.AV17GridCurrentPage); });
   GRIDPAGINATIONBARContainer.setProp("PageCount", "Pagecount", '', "str");
   GRIDPAGINATIONBARContainer.addV2CFunction('AV19GridRecordCount', "vGRIDRECORDCOUNT", 'SetRecordCount');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV19GridRecordCount=UC.GetRecordCount();gx.fn.setControlValue("vGRIDRECORDCOUNT",UC.ParentObject.AV19GridRecordCount); });
   GRIDPAGINATIONBARContainer.addV2CFunction('AV18GridPageSize', "vGRIDPAGESIZE", 'SetPage');
   GRIDPAGINATIONBARContainer.addC2VFunction(function(UC) { UC.ParentObject.AV18GridPageSize=UC.GetPage();gx.fn.setControlValue("vGRIDPAGESIZE",UC.ParentObject.AV18GridPageSize); });
   GRIDPAGINATIONBARContainer.setProp("Visible", "Visible", true, "bool");
   GRIDPAGINATIONBARContainer.setC2ShowFunction(function(UC) { UC.show(); });
   GRIDPAGINATIONBARContainer.addEventHandler("ChangePage", this.e114a2_client);
   GRIDPAGINATIONBARContainer.addEventHandler("ChangeRowsPerPage", this.e124a2_client);
   this.setUserControl(GRIDPAGINATIONBARContainer);
   this.DDO_JC_PROVIDERNAMEContainer = gx.uc.getNew(this, 38, 19, "BootstrapDropDownOptions", "DDO_JC_PROVIDERNAMEContainer", "Ddo_jc_providername", "DDO_JC_PROVIDERNAME");
   var DDO_JC_PROVIDERNAMEContainer = this.DDO_JC_PROVIDERNAMEContainer;
   DDO_JC_PROVIDERNAMEContainer.setProp("Class", "Class", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DDO_JC_PROVIDERNAMEContainer.setProp("Icon", "Icon", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("Caption", "Caption", "", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("Tooltip", "Tooltip", "WWP_TSColumnOptions", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("Cls", "Cls", "ColumnSettings", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("ActiveEventKey", "Activeeventkey", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilteredText_set", "Filteredtext_set", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilteredText_get", "Filteredtext_get", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilteredTextTo_set", "Filteredtextto_set", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilteredTextTo_get", "Filteredtextto_get", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("SelectedValue_set", "Selectedvalue_set", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("SelectedValue_get", "Selectedvalue_get", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("SelectedText_set", "Selectedtext_set", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("SelectedText_get", "Selectedtext_get", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("GAMOAuthToken", "Gamoauthtoken", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("TitleControlAlign", "Titlecontrolalign", "Automatic", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("DropDownOptionsType", "Dropdownoptionstype", "GridTitleSettings", "str");
   DDO_JC_PROVIDERNAMEContainer.setDynProp("TitleControlIdToReplace", "Titlecontrolidtoreplace", "", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("IncludeSortASC", "Includesortasc", true, "bool");
   DDO_JC_PROVIDERNAMEContainer.setProp("IncludeSortDSC", "Includesortdsc", true, "bool");
   DDO_JC_PROVIDERNAMEContainer.setDynProp("SortedStatus", "Sortedstatus", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("IncludeFilter", "Includefilter", false, "bool");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilterType", "Filtertype", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("FilterIsRange", "Filterisrange", false, "boolean");
   DDO_JC_PROVIDERNAMEContainer.setProp("IncludeDataList", "Includedatalist", false, "bool");
   DDO_JC_PROVIDERNAMEContainer.setProp("DataListType", "Datalisttype", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("AllowMultipleSelection", "Allowmultipleselection", false, "boolean");
   DDO_JC_PROVIDERNAMEContainer.setProp("DataListFixedValues", "Datalistfixedvalues", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("DataListProc", "Datalistproc", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("DataListUpdateMinimumCharacters", "Datalistupdateminimumcharacters", '', "int");
   DDO_JC_PROVIDERNAMEContainer.setProp("FixedFilters", "Fixedfilters", "", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("SelectedFixedFilter", "Selectedfixedfilter", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("ColumnsSelectorValues", "Columnsselectorvalues", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("SortASC", "Sortasc", "WWP_TSSortASC", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("SortDSC", "Sortdsc", "WWP_TSSortDSC", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("LoadingData", "Loadingdata", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("CleanFilter", "Cleanfilter", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("RangeFilterFrom", "Rangefilterfrom", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("RangeFilterTo", "Rangefilterto", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("NoResultsFound", "Noresultsfound", "", "char");
   DDO_JC_PROVIDERNAMEContainer.setProp("SearchButtonText", "Searchbuttontext", "WWP_TSSearchButtonCaption", "str");
   DDO_JC_PROVIDERNAMEContainer.setProp("UpdateButtonText", "Updatebuttontext", "Update", "str");
   DDO_JC_PROVIDERNAMEContainer.addV2CFunction('AV15DDO_TitleSettingsIcons', "vDDO_TITLESETTINGSICONS", 'SetDropDownOptionsTitleSettingsIcons');
   DDO_JC_PROVIDERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV15DDO_TitleSettingsIcons=UC.GetDropDownOptionsTitleSettingsIcons();gx.fn.setControlValue("vDDO_TITLESETTINGSICONS",UC.ParentObject.AV15DDO_TitleSettingsIcons); });
   DDO_JC_PROVIDERNAMEContainer.addV2CFunction('AV13JC_ProviderNameTitleFilterData', "vJC_PROVIDERNAMETITLEFILTERDATA", 'SetDropDownOptionsData');
   DDO_JC_PROVIDERNAMEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV13JC_ProviderNameTitleFilterData=UC.GetDropDownOptionsData();gx.fn.setControlValue("vJC_PROVIDERNAMETITLEFILTERDATA",UC.ParentObject.AV13JC_ProviderNameTitleFilterData); });
   DDO_JC_PROVIDERNAMEContainer.setProp("Visible", "Visible", true, "bool");
   DDO_JC_PROVIDERNAMEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DDO_JC_PROVIDERNAMEContainer.addEventHandler("OnOptionClicked", this.e134a2_client);
   this.setUserControl(DDO_JC_PROVIDERNAMEContainer);
   this.WORKWITHPLUSUTILITIES1Container = gx.uc.getNew(this, 40, 19, "DVelop_WorkWithPlusUtilities", "WORKWITHPLUSUTILITIES1Container", "Workwithplusutilities1", "WORKWITHPLUSUTILITIES1");
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
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id:19 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vJC_PROVIDERNAME",gxz:"ZV12JC_ProviderName",gxold:"OV12JC_ProviderName",gxvar:"AV12JC_ProviderName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV12JC_ProviderName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV12JC_ProviderName=Value},v2c:function(){gx.fn.setControlValue("vJC_PROVIDERNAME",gx.O.AV12JC_ProviderName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV12JC_ProviderName=this.val()},val:function(){return gx.fn.getControlValue("vJC_PROVIDERNAME")},nac:gx.falseFn};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"GRIDTABLEWITHPAGINATIONBAR",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vSELECT",gxz:"ZV20Select",gxold:"OV20Select",gxvar:"AV20Select",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){if(Value!==undefined)gx.O.AV20Select=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20Select=Value},v2c:function(row){gx.fn.setGridMultimediaValue("vSELECT",row || gx.fn.currentGridRowImpl(25),gx.O.AV20Select,gx.O.AV23Select_GXI)},c2v:function(){gx.O.AV23Select_GXI=this.val_GXI();if(this.val()!==undefined)gx.O.AV20Select=this.val()},val:function(row){return gx.fn.getGridControlValue("vSELECT",row || gx.fn.currentGridRowImpl(25))},val_GXI:function(row){return gx.fn.getGridControlValue("vSELECT_GXI",row || gx.fn.currentGridRowImpl(25))}, gxvar_GXI:'AV23Select_GXI',nac:gx.falseFn,evt:"e174a2_client",std:"ENTER"};
   GXValidFnc[27]={ id:27 ,lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Secuserid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERID",gxz:"Z6SecUserId",gxold:"O6SecUserId",gxvar:"A6SecUserId",ucs:[],op:[29,30],ip:[29,30,27,28],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A6SecUserId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z6SecUserId=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("SECUSERID",row || gx.fn.currentGridRowImpl(25),gx.O.A6SecUserId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A6SecUserId=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("SECUSERID",row || gx.fn.currentGridRowImpl(25),',')},nac:gx.falseFn};
   GXValidFnc[28]={ id:28 ,lvl:2,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:this.Valid_Jc_providerid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERID",gxz:"Z87JC_ProviderID",gxold:"O87JC_ProviderID",gxvar:"A87JC_ProviderID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'number',v2v:function(Value){if(Value!==undefined)gx.O.A87JC_ProviderID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z87JC_ProviderID=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("JC_PROVIDERID",row || gx.fn.currentGridRowImpl(25),gx.O.A87JC_ProviderID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A87JC_ProviderID=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("JC_PROVIDERID",row || gx.fn.currentGridRowImpl(25),',')},nac:gx.falseFn};
   GXValidFnc[29]={ id:29 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"SECUSERNAME",gxz:"Z14SecUserName",gxold:"O14SecUserName",gxvar:"A14SecUserName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A14SecUserName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z14SecUserName=Value},v2c:function(row){gx.fn.setGridControlValue("SECUSERNAME",row || gx.fn.currentGridRowImpl(25),gx.O.A14SecUserName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A14SecUserName=this.val()},val:function(row){return gx.fn.getGridControlValue("SECUSERNAME",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[30]={ id:30 ,lvl:2,type:"svchar",len:200,dec:0,sign:false,ro:1,isacc:0,grid:25,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"JC_PROVIDERNAME",gxz:"Z89JC_ProviderName",gxold:"O89JC_ProviderName",gxvar:"A89JC_ProviderName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.A89JC_ProviderName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z89JC_ProviderName=Value},v2c:function(row){gx.fn.setGridControlValue("JC_PROVIDERNAME",row || gx.fn.currentGridRowImpl(25),gx.O.A89JC_ProviderName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A89JC_ProviderName=this.val()},val:function(row){return gx.fn.getGridControlValue("JC_PROVIDERNAME",row || gx.fn.currentGridRowImpl(25))},nac:gx.falseFn};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"HTML_GRIDPAGINATIONBAR",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[39]={ id:39 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE",gxz:"ZV14ddo_JC_ProviderNameTitleControlIdToReplace",gxold:"OV14ddo_JC_ProviderNameTitleControlIdToReplace",gxvar:"AV14ddo_JC_ProviderNameTitleControlIdToReplace",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV14ddo_JC_ProviderNameTitleControlIdToReplace=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV14ddo_JC_ProviderNameTitleControlIdToReplace=Value},v2c:function(){gx.fn.setControlValue("vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE",gx.O.AV14ddo_JC_ProviderNameTitleControlIdToReplace,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV14ddo_JC_ProviderNameTitleControlIdToReplace=this.val()},val:function(){return gx.fn.getControlValue("vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE")},nac:gx.falseFn};
   GXValidFnc[41]={ id:41 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.GridContainer],fld:"vORDEREDDSC",gxz:"ZV11OrderedDsc",gxold:"OV11OrderedDsc",gxvar:"AV11OrderedDsc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV11OrderedDsc=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV11OrderedDsc=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("vORDEREDDSC",gx.O.AV11OrderedDsc,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV11OrderedDsc=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("vORDEREDDSC")},nac:gx.falseFn};
   this.AV12JC_ProviderName = "" ;
   this.ZV12JC_ProviderName = "" ;
   this.OV12JC_ProviderName = "" ;
   this.ZV20Select = "" ;
   this.OV20Select = "" ;
   this.Z6SecUserId = 0 ;
   this.O6SecUserId = 0 ;
   this.Z87JC_ProviderID = 0 ;
   this.O87JC_ProviderID = 0 ;
   this.Z14SecUserName = "" ;
   this.O14SecUserName = "" ;
   this.Z89JC_ProviderName = "" ;
   this.O89JC_ProviderName = "" ;
   this.AV14ddo_JC_ProviderNameTitleControlIdToReplace = "" ;
   this.ZV14ddo_JC_ProviderNameTitleControlIdToReplace = "" ;
   this.OV14ddo_JC_ProviderNameTitleControlIdToReplace = "" ;
   this.AV11OrderedDsc = false ;
   this.ZV11OrderedDsc = false ;
   this.OV11OrderedDsc = false ;
   this.AV12JC_ProviderName = "" ;
   this.AV17GridCurrentPage = 0 ;
   this.AV15DDO_TitleSettingsIcons = {Default:"",Default_GXI:"",Filtered:"",Filtered_GXI:"",SortedASC:"",SortedASC_GXI:"",SortedDSC:"",SortedDSC_GXI:"",FilteredSortedASC:"",FilteredSortedASC_GXI:"",FilteredSortedDSC:"",FilteredSortedDSC_GXI:"",OptionSortASC:"",OptionSortASC_GXI:"",OptionSortDSC:"",OptionSortDSC_GXI:"",OptionApplyFilter:"",OptionApplyFilter_GXI:"",OptionFilteringData:"",OptionFilteringData_GXI:"",OptionCleanFilters:"",OptionCleanFilters_GXI:"",SelectedOption:"",SelectedOption_GXI:"",MultiselOption:"",MultiselOption_GXI:"",MultiselSelOption:"",MultiselSelOption_GXI:""} ;
   this.AV14ddo_JC_ProviderNameTitleControlIdToReplace = "" ;
   this.AV11OrderedDsc = false ;
   this.AV8InSecUserId = 0 ;
   this.AV9InOutJC_ProviderID = 0 ;
   this.AV20Select = "" ;
   this.A6SecUserId = 0 ;
   this.A87JC_ProviderID = 0 ;
   this.A14SecUserName = "" ;
   this.A89JC_ProviderName = "" ;
   this.Events = {"e114a2_client": ["GRIDPAGINATIONBAR.CHANGEPAGE", true] ,"e124a2_client": ["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE", true] ,"e134a2_client": ["DDO_JC_PROVIDERNAME.ONOPTIONCLICKED", true] ,"e174a2_client": ["ENTER", true] ,"e184a2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV12JC_ProviderName',fld:'vJC_PROVIDERNAME',pic:''},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8InSecUserId',fld:'vINSECUSERID',pic:'ZZZ9'},{av:'AV14ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{ctrl:'GRID',prop:'Rows'}],[{av:'AV13JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERNAME","Title")',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["START"] = [[],[{av:'gx.fn.getCtrlProperty("TABLEMAIN","Height")',ctrl:'TABLEMAIN',prop:'Height'},{ctrl:'GRID',prop:'Rows'},{av:'this.DDO_JC_PROVIDERNAMEContainer.TitleControlIdToReplace',ctrl:'DDO_JC_PROVIDERNAME',prop:'TitleControlIdToReplace'},{av:'AV14ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'gx.fn.getCtrlProperty("vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE","Visible")',ctrl:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',prop:'Visible'},{ctrl:'FORM',prop:'Caption'},{av:'gx.fn.getCtrlProperty("vORDEREDDSC","Visible")',ctrl:'vORDEREDDSC',prop:'Visible'},{av:'AV15DDO_TitleSettingsIcons',fld:'vDDO_TITLESETTINGSICONS',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV12JC_ProviderName',fld:'vJC_PROVIDERNAME',pic:''},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8InSecUserId',fld:'vINSECUSERID',pic:'ZZZ9'},{av:'AV14ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.SelectedPage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}],[]];
   this.EvtParms["GRIDPAGINATIONBAR.CHANGEROWSPERPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV12JC_ProviderName',fld:'vJC_PROVIDERNAME',pic:''},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8InSecUserId',fld:'vINSECUSERID',pic:'ZZZ9'},{av:'AV14ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'this.GRIDPAGINATIONBARContainer.RowsPerPageSelectedValue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}],[{ctrl:'GRID',prop:'Rows'}]];
   this.EvtParms["DDO_JC_PROVIDERNAME.ONOPTIONCLICKED"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{ctrl:'GRID',prop:'Rows'},{av:'AV12JC_ProviderName',fld:'vJC_PROVIDERNAME',pic:''},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8InSecUserId',fld:'vINSECUSERID',pic:'ZZZ9'},{av:'AV14ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'this.DDO_JC_PROVIDERNAMEContainer.ActiveEventKey',ctrl:'DDO_JC_PROVIDERNAME',prop:'ActiveEventKey'}],[{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'this.DDO_JC_PROVIDERNAMEContainer.SortedStatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'AV13JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'gx.fn.getCtrlProperty("JC_PROVIDERNAME","Title")',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]];
   this.EvtParms["GRID.LOAD"] = [[],[{av:'AV20Select',fld:'vSELECT',pic:''},{av:'gx.fn.getCtrlProperty("vSELECT","Tooltiptext")',ctrl:'vSELECT',prop:'Tooltiptext'}]];
   this.EvtParms["ENTER"] = [[{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV9InOutJC_ProviderID',fld:'vINOUTJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.EnterCtrl = ["vSELECT"];
   this.setVCMap("AV8InSecUserId", "vINSECUSERID", 0, "int", 4, 0);
   this.setVCMap("AV9InOutJC_ProviderID", "vINOUTJC_PROVIDERID", 0, "int", 18, 0);
   this.setVCMap("AV8InSecUserId", "vINSECUSERID", 0, "int", 4, 0);
   this.setVCMap("AV8InSecUserId", "vINSECUSERID", 0, "int", 4, 0);
   GridContainer.addRefreshingVar(this.GXValidFnc[19]);
   GridContainer.addRefreshingVar(this.GXValidFnc[41]);
   GridContainer.addRefreshingVar({rfrVar:"AV8InSecUserId"});
   GridContainer.addRefreshingVar(this.GXValidFnc[39]);
   this.Initialize( );
});
gx.createParentObj(jc_selectprovider);
